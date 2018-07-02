
# Input through command line
# Arguments is two filepaths that are the location of the .obj and the directory we want to send it to.
#
# Looks like this:
# blender --background --python mytest.py -- example args 123
# In our case, the command line call would look more like:
# blender --background --python Automating_lod_mapping.py -- "D:/path/to/input/file.obj" "D:/path/to/output/directory"#
# No slash at end of input files. Spaces surrounding "--" ^^ here
# I had to add blender to my path environment variables. The command prompt needs to be in the same directory as our .py file.
#
# My exact command call was as follows:
# blender --background --python Automating_lod_mapping.py -- "D:/Daniel Olson/Downloads/CL_Hiaku_disk1.obj" "D:/Daniel Olson/Desktop"
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
	lod0.data.name = model_name + '_LOD0'
	lod0.name = model_name + '_LOD0'
	
	# Smooth shading
	mesh = lod0.data
	for face in mesh.polygons:
		face.use_smooth = True
		
	lods = [lod0]
	
	# Create other lods
	for i in range(1, 4):
		obj = lod0.copy()
		obj.data = lod0.data.copy()
		obj.data.name = model_name + '_LOD' + str(i)
		obj.name = model_name + '_LOD' + str(i)
		scene.objects.link(obj)
		lods.append(obj)

	for i in range(4):
		
		# Scale to a unit bounding box
		x = lods[i].dimensions[0]
		y = lods[i].dimensions[1]
		z = lods[i].dimensions[2]
		m = max(lods[i].dimensions[j] for j in range(3))
		r = 1.0 / m
		lods[i].dimensions = [x*r, y*r, z*r]
		
		if i > 0:
			# Decimate the mesh
			scene.objects.active = lods[i]
			bpy.ops.object.modifier_add(type='DECIMATE')
			bpy.context.object.modifiers["Decimate"].ratio = 1.0 / math.pow(10, i)
			bpy.context.object.modifiers["Decimate"].use_collapse_triangulate = True
			bpy.context.object.modifiers["Decimate"].decimate_type = 'COLLAPSE'
			bpy.ops.object.convert(target='MESH')

		# Set our active object
		bpy.context.scene.objects.active = lods[i]
		
		# Move object origin to center of geometry
		bpy.ops.object.origin_set(type = 'ORIGIN_GEOMETRY')
		
		# Clear location - set location to (0,0,0)
		bpy.ops.object.location_clear()
		
		# Smart uv unwrap and set image
		bpy.ops.object.editmode_toggle()
		bpy.ops.mesh.select_all(action='SELECT')
		bpy.ops.mesh.normals_make_consistent(inside=False)
		bpy.ops.uv.smart_project()
		bpy.ops.object.editmode_toggle()
		
		img = bpy.data.images.new("Lod" + str(i), 1024, 1024, alpha=True)
		
		for uv_face in lods[i].data.uv_textures.active.data:
			uv_face.image = img
		
		# Bake the normal maps from the high res model (lod0) to the rest
		if i > 0:
			lod0.select = True
			bpy.data.scenes["Scene"].render.bake_type = 'NORMALS'
			bpy.data.scenes["Scene"].render.use_bake_selected_to_active = True
			bpy.data.scenes["Scene"].render.use_bake_clear = True
			bpy.data.scenes["Scene"].render.bake_normal_space = 'TANGENT'
			bpy.ops.object.bake_image()
			lod0.select = False

			img = bpy.data.images['Lod' + str(i)]
			img.filepath_raw = file_path + 'LOD' + str(i) + '.png'
			img.file_format = 'PNG'
			img.save()

# New name just for the high res obj
lods[0].name = filename
lods[0].data.name = filename

# Export only our selected mesh, which is our high res one
for obj in lods:
	obj.select = False
lods[0].select = True

bpy.ops.export_scene.obj(filepath=outputFile + '/' + filename + '/' + filename + '_high_res.obj', 
				use_selection=True, use_materials=False)

# Change back to correct name
lods[0].name = filename + '_LOD0'
lods[0].data.name = filename + '_LOD0'

# Export our level of detail obj
bpy.ops.export_scene.obj(filepath=outputFile + '/' + filename + '/' + filename + '.obj',
        use_materials=False, use_blen_objects=False, group_by_object=True)
