import numpy as np
from vtk import *
import vtk.util.numpy_support as ns
from glob import glob

# Get a list of Zep files, make sure they are in correct order

files = sorted(glob('Zep_c*.txt'), key=lambda a: int(a.split('.')[0].rsplit('_', 1)[1]))

# Load the CSV files, skipping the first row of each and first 3 columns of each, 
# and make sure they come in as 32 bit floats

slices = []
for f in files:
  slices.append(np.loadtxt(f, skiprows=1)[:,3:].astype('f4'))   # Note - drop X, Y and Z

data = np.vstack(slices)    # Concatenates into one giant (x*y*z by ncols) table, with
                                                    # x varying fastest, Z next and Y slowest
ncols = data.shape[1]           # number of variables per row

# Reshape into [Y,Z,X] table of rows, then exchange the Y and Z axes, 
# then reshape to one giant (x*y*z, ncols) table now with X varying fastest,
# then Y then Z

data = data.reshape((len(files), 64, 80, ncols))
data = data.transpose((1,0,2,3)).reshape((80*64*len(files), ncols))

# We'll slice out the individual variables - here are names and the columns 
# that correspond

vars = ['FA', 'f1', 'n1', 'R1', 'f2', 'n2', 'R2', 'f3', 'n3', 'd_perp']
cols = [[0], [1], [2, 3, 4], [5], [6], [7, 8, 9], [10], [11], [12, 13, 14], [15]]

vti = vtkImageData()
vti.SetDimensions((80, len(files), 64))

for v, c in zip(vars, cols):
    a = ns.numpy_to_vtk(data[:, c].flatten(), deep=1)    # Here's the slicing
    a.SetName(v)
    a.SetNumberOfComponents(len(c))
    vti.GetPointData().AddArray(a)

w = vtkXMLImageDataWriter()
w.SetFileName('zep.vti')
w.SetInputData(vti)
w.Write()

