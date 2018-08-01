
# Input through command line
# Looks like this:
# blender --background --python mytest.py -- example args 123
# In our case, the command line call would look more like:
# blender --background --python Normal_map_bake.py -- "D:/path/to/input/obj" "D:/path/to/output"
# No slash at end of input files
# I had to add blender to my path environment variables. The command prompt needs to be in the same directory as our .py file
#
# We would need to run this program for each model in the database.
# I have assumed that the output directory is one directory above a file which contains our meshes and maps
# --OutputPath
# ----Model folder
# ------model_high_res.obj
# ------model.obj
# ------NormalMaps
# --------Lod1.png
# --------Lod2.png
# --------Lod3.png

# Currently, it is set up to export a couple things:
# - A high res mesh
# - A obj file consisting of all 4 level-of-detail meshes
# - A new file that contains the normal maps for the level of detail meshes

import bpy
import os
import math
import sys

# argv is our list of arguments
argv = sys.argv
argv = argv[argv.index("--") + 1:]

# Save our file
inputFile = argv[0]
outputFile = argv[1]

# Delete all objects already in scene
objs = bpy.data.objects
for o in objs:
  if o.type == 'MESH':
    objs.remove(o, True)

# Cache our scene
scene = bpy.context.scene

# Make sure that our origin is correct
origin = (0.0, 0.0, 0.0)
scene.cursor_location = origin

# Import our mesh and select all meshes (there should only be one)
bpy.ops.import_scene.obj(filepath=inputFile)
bpy.ops.object.select_by_type(type='MESH')
filename = bpy.context.selected_objects[0].name

# If we have successfully selected objects
if bpy.context.selected_objects != []:
	
# Make a directory
	file_path = outputFile + '/' + filename + '/NormalMaps/'
	dirname = os.path.dirname(bpy.data.filepath)
	target_file = os.path.join(dirname, file_path)
	directory = os.path.dirname(target_file)
	if not os.path.exists(directory):
		os.makedirs(directory)
	
	# Save data on our parent mesh
	lod0 = bpy.context.selected_objects[0]
	model_name = lod0.name
	
	# Scale to a unit bounding box
	x = lod0.dimensions[0]
	y = lod0.dimensions[1]
	z = lod0.dimensions[2]
	m = max(lod0.dimensions[j] for j in range(3))
	r = 1.0 / m
	lod0.dimensions = [x*r, y*r, z*r]
	
	# Set our active object
	bpy.context.scene.objects.active = lod0
		
	# Move object origin to center of geometry
	bpy.ops.object.origin_set(type = 'ORIGIN_GEOMETRY')
		
	# Clear location - set location to (0,0,0)
	bpy.ops.object.location_clear()
	
	lods = [lod0]
	
	# Create other lods
	for i in range(1, 4):
		
		print("Starting copy, will decimate mesh")
		obj = lods[0].copy()
		obj.data = lods[0].data.copy()
		obj.data.name = model_name + '_LOD' + str(i)
		obj.name = model_name + '_LOD' + str(i)
		scene.objects.link(obj)
		lods.append(obj)
		
		# Set our active object
		bpy.context.scene.objects.active = lods[i]
		
		# Move object origin to center of geometry
		bpy.ops.object.origin_set(type = 'ORIGIN_GEOMETRY')
		
		# Clear location - set location to (0,0,0)
		bpy.ops.object.location_clear()
		
		# Decimate the mesh
		starting_vertices = len(lods[i].data.vertices)
		goal_vertices = 100000.0 / math.pow(10, i)
		ratio = goal_vertices / starting_vertices
		
		scene.objects.active = lods[i]
		decimate_mod = lods[i].modifiers.new('Decimate', 'DECIMATE')
		decimate_mod.use_collapse_triangulate = True
		decimate_mod.decimate_type = 'COLLAPSE'
		decimate_mod.ratio = ratio
		bpy.ops.object.modifier_apply(apply_as='DATA', modifier=decimate_mod.name)
		
		print("Finished decimating mesh")
		
		# Smart uv unwrap and set image
		print("Entering edit mode")
		bpy.ops.object.editmode_toggle()
		bpy.ops.mesh.select_all(action='SELECT')
		bpy.ops.mesh.normals_make_consistent(inside=False)
		print("Starting smart projection")
		bpy.ops.uv.smart_project(angle_limit=30)
		bpy.ops.object.editmode_toggle()
		print("Exited edit mode")
		
		img = bpy.data.images.new("Lod" + str(i-1), 2048, 2048, alpha=True)
		
		for uv_face in lods[i].data.uv_textures.active.data:
			uv_face.image = img
		
		# Bake the normal maps from the high res model (lod0) to the rest
		print ("Baking normal maps")
		lod0.select = True
		bpy.data.scenes["Scene"].render.bake_type = 'NORMALS'
		bpy.data.scenes["Scene"].render.use_bake_selected_to_active = True
		bpy.data.scenes["Scene"].render.use_bake_clear = True
		bpy.data.scenes["Scene"].render.bake_normal_space = 'TANGENT'
		bpy.ops.object.bake_image()
		lod0.select = False

		img = bpy.data.images['Lod' + str(i-1)]
		img.filepath_raw = file_path + 'LOD' + str(i-1) + '.png'
		img.file_format = 'PNG'
		img.save()
		print("Finished baking normal maps")

# New name just for the high res obj
lods[0].name = filename
lods[0].data.name = filename

# Export only our selected mesh, which is our high res one
for obj in lods:
	obj.select = False
lods[0].select = True

bpy.ops.export_scene.obj(filepath=outputFile + '/' + filename + '/' + filename + '_high_res.obj', 
				use_selection=True, use_materials=False)

# Select all objects besides the highest LOD
for obj in lods:
	obj.select = True
lods[0].select = False

# Export our level of detail obj
bpy.ops.export_scene.obj(filepath=outputFile + '/' + filename + '/' + filename + '.obj',
        use_selection=True, use_materials=False, use_blen_objects=False, group_by_object=True)
