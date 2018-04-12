using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;


namespace VTK{
class vtkCompound {
	[DllImport("vtkplugin")] unsafe public static extern void free_data (IntPtr h);
	[DllImport("vtkplugin")] unsafe public static extern void get_array(IntPtr h, string array_name, IntPtr *values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe public static extern  void get_array_range(IntPtr h, string array_name, int component, float * min, float * max);
	[DllImport("vtkplugin")] unsafe public static extern void get_points(IntPtr h, IntPtr* values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe public static extern int get_number_of_lines (IntPtr h);
	[DllImport("vtkplugin")] unsafe public static extern void get_line_ids (IntPtr h, int line, IntPtr* ids_list, int*number_of_ids, int*reasonForTermination, int*seedId);
		[DllImport("vtkplugin")] public static extern IntPtr open_data (StringBuilder sb);
		[DllImport("vtkplugin")] public static extern void   close_data (IntPtr h);
		[DllImport("vtkplugin")] public static extern int   get_number_of_vertices (IntPtr h);
	[DllImport("vtkplugin")] public static extern IntPtr get_bounds (IntPtr h);
		[DllImport("vtkplugin")] public static extern IntPtr get_dimensions (IntPtr h);
		[DllImport("vtkplugin")] public static extern int   get_number_of_polygons (IntPtr h);
		[DllImport("vtkplugin")] public static extern int   get_number_of_strips (IntPtr h);
		[DllImport("vtkplugin")] public static extern int   get_number_of_points (IntPtr h);
		[DllImport("vtkplugin")] public static extern int   ComputePointId (IntPtr h, int i, int j, int k);
		[DllImport("vtkplugin")] public static extern int   get_number_of_cells (IntPtr h);
		[DllImport("vtkplugin")] public static extern int   IsA (IntPtr h, string type);
		[DllImport("vtkplugin")] unsafe public static extern void get_point_variable_names(IntPtr h, char ***names, int ** components, int *number_of_variables);
		[DllImport("vtkplugin")] unsafe public static extern void get_cell_variable_names(IntPtr h, char ***names, int ** components, int *number_of_variables);


}
}