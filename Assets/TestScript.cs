using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Linq; 

public class TestScript : MonoBehaviour {
    [DllImport("vtkplugin")] private static extern IntPtr open_data(StringBuilder sb);
    [DllImport("vtkplugin")] private static extern void close_data(IntPtr h);
    [DllImport("vtkplugin")] private static extern int get_number_of_vertices(IntPtr h);
    [DllImport("vtkplugin")] private static extern IntPtr get_bounds(IntPtr h);
    [DllImport("vtkplugin")] private static extern IntPtr get_dimensions(IntPtr h);

    [DllImport("vtkplugin")] private static extern void free_data(IntPtr h);
    [DllImport("vtkplugin")] private static extern int get_number_of_lines(IntPtr h);
    [DllImport("vtkplugin")] private static extern int get_number_of_polygons(IntPtr h);
    [DllImport("vtkplugin")] private static extern int get_number_of_strips(IntPtr h);
    [DllImport("vtkplugin")] private static extern int get_number_of_points(IntPtr h);
    [DllImport("vtkplugin")] private static extern int ComputePointId(IntPtr h, int i, int j, int k);

    [DllImport("vtkplugin")] private static extern int get_number_of_cells(IntPtr h);
    [DllImport("vtkplugin")] private static extern int IsA(IntPtr h, string type);

    [DllImport("vtkplugin")] unsafe private static extern void get_point_variable_names(IntPtr h, char*** names, int** components, int* number_of_variables);

    [DllImport("vtkplugin")] unsafe private static extern void get_array(IntPtr h, string array_name, IntPtr* values, int* number_of_elements, int* number_of_components);

    [DllImport("vtkplugin")] unsafe private static extern void get_cell_variable_names(IntPtr h, char*** names, int** components, int* number_of_variables);



	// Use this for initialization
	void Start () {
        VTK.vtkXMLUnstructuredGridReader reader = VTK.vtkXMLUnstructuredGridReader.New();
        int a = reader.CanReadFile("/Users/sethjohnson/NSF-Sculpting-Vis-Platform/unity/VisualizationPlatform/Assets/StreamingAssets/example_data/VTK/CICE.vtu");
        reader.SetFileName("/Users/sethjohnson/NSF-Sculpting-Vis-Platform/unity/VisualizationPlatform/Assets/StreamingAssets/example_data/VTK/CICE.vtu");
        reader.Update();
        VTK.vtkDataSet ds = reader.GetOutputAsDataSet();

        VTK.vtkPointData pd = ds.GetPointData();
        VTK.vtkCellData cd = ds.GetCellData();
        long np = ds.GetNumberOfPoints();
        long nc = ds.GetNumberOfCells();
        int n = cd.GetNumberOfArrays();
        int n2 = pd.GetNumberOfArrays();
        string s = pd.GetArrayName(0);
        for (int i = 0; i < n2; i++) 
            print(pd.GetArrayName(i));

        for (int i = 0; i < 5; i++)
            print("cell " + i + ": " + VTK.vtkCellTypes.GetClassNameFromTypeId(ds.GetCell(i).GetCellType()));
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
