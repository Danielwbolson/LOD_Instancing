import vtk
reader = vtk.vtk.vtkXMLPolyDataReader()
reader.SetFileName("streamlines.vtp")
reader.Update();
ds = reader.GetOutputAsDataSet()
normals = ds.GetPointData().GetArray("Normals")
data = ds.GetPointData().GetArray("RTData")
print(data.GetNumberOfComponents())
print(normals.GetNumberOfComponents())

for i in range(pd.GetNumberOfArrays()):
        name = pd.GetArrayName(i)
        array = pd.GetArray(i)
        ncomp = array.GetNumberOfComponents()
        varnames.append('%s(%d)' % (name, ncomp))
        variables.append(array)


points = ds.GetPoints();

lines = ds.GetLines();

print("Number of streamlines: " + str(lines.GetNumberOfCells()))

for l in range(lines.GetNumberOfCells()):
	npts = 0
	pts = vtk.vtkIdList()

	ds.GetCellPoints(l,pts)

	#print("Number of streamlines: " + str(pts.GetNumberOfIds()))

	for p in range(pts.GetNumberOfIds()):
		Id = pts.GetId(p);
		#print(ds.GetPoint(Id))
		#print(normals.GetTuple(Id))
		#print(data.GetTuple(Id))
