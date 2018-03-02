import os
import vtk
import math

# somehow 'two_cylinders.txt' does not contain information about the third glyph
# so use the files for slices.
dataDir = '../BrainVIS/BrainTensorData/'
dataDir = '.'
inputFileNamePrefix = 'Zep_cyl_cyl_'
inputFileType = '.txt' # include . in front.

# 3 colume: x, y, z
# 1 colume: FA
# a glyph type has 5 columes: f[i], n[i](1), n[i](2), n[i](3), R[i] 
# there are two such glyphs: 5 * 2 = 10
# another glyph type has 5 columes: f3, n3(1), n3(2), n3(3), d_perp
# there are one such glyph: 5 * 1 = 5
# therefore there shall be 3 + 1 + (10 + 5) = 19 columes for a row.
numOfValsInLine = 19

# construct the vtk image data
# only support the VTK 5.0 or above
outputFileName = dataDir + "/brain_CMRR_test.vti"
imageData = vtk.vtkImageData()
imageData.SetDimensions(80 , 96 , 64 )
components = numOfValsInLine - 3;
components = 1;
imageData.AllocateScalars(vtk.VTK_FLOAT, components) # the three are x, y, z


#for fileIndex in range(0, imageData.GetDimensions()[1]):
for fileIndex in range(15, 61):
        
        inputFilePath = dataDir + '/' + inputFileNamePrefix + str(fileIndex) + inputFileType
        
        if not os.path.exists(inputFilePath):
                print('WARNING: the file does not exist: ' + inputFilePath)
                continue
        
        # parsing
        lineCnt = 0;
        validLineCnt = 0
        with open(inputFilePath) as infile:
                for line in infile:
                        vals = line.split() # split by white spaces
                        
                        # a valid line shall have 'numOfValsInLine' values
                        if (len(vals) != numOfValsInLine):
                                print('WARNING: skipping the line: ' + str(lineCnt) + ', because num of values: ' + str(len(vals)) + "does not equal expected: " + str(numOfValsInLine))  
                        else:
                                if validLineCnt == 0: # the first valid line is the colume names
                                        print('colume names: ' + line)
                                else:
                                        # update the dimension
                                        x = int(float(vals[0]))-1
                                        y = int(float(vals[1]))-1
                                        z = int(float(vals[2]))-1
                                        colOffset = 3 # the colume index the actual value starts
                                        colsToRead = components; # This is one right now

                                        #This loops accross the one column (f1) right now
                                        for i in range(colOffset, min(colOffset+components,numOfValsInLine)):
                                                v = float(vals[i]);
                                                imageData.SetScalarComponentFromDouble(x, y, z, i - colOffset, v)
                              
                                validLineCnt += 1
                        lineCnt += 1
        
        # print out the summary of the file
        print('file path: ')
        print(inputFilePath)
        print('number of line(s): ')
        print(lineCnt)
        print('number of valid line(s) - including a line for colume names: ')
        print(validLineCnt)
    
# write to the file
writer = vtk.vtkXMLImageDataWriter()
writer.SetFileName(outputFileName)
writer.SetInputData(imageData)
writer.Write()


