
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDataCompressor {

// virtual size_t GetMaximumCompressionSpace(size_t size)
// virtual size_t GetMaximumCompressionSpace(size_t size)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_GetMaximumCompressionSpace_0")] public static extern 
bool vtkDataCompressor_GetMaximumCompressionSpace_0(IntPtr /*(size_t*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, ulong /*(size_t)*/ size);

// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char * compressedData, size_t compressionSpace)
// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char* compressedData, size_t compressionSpace)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Compress_0")] public static extern 
bool vtkDataCompressor_Compress_0(IntPtr /*(size_t*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, IntPtr /*(charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize, IntPtr /*(char*)*/ compressedData, ulong /*(size_t)*/ compressionSpace);

// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char * uncompressedData, size_t uncompressedSize)
// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char* uncompressedData, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Uncompress_0")] public static extern 
bool vtkDataCompressor_Uncompress_0(IntPtr /*(size_t*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, IntPtr /*(charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, IntPtr /*(char*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize);

// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Compress_1")] public static extern 
bool vtkDataCompressor_Compress_1(IntPtr /*(vtkUnsignedCharArray**)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, IntPtr /*(charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize);

// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Uncompress_1")] public static extern 
bool vtkDataCompressor_Uncompress_1(IntPtr /*(vtkUnsignedCharArray**)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, IntPtr /*(charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, ulong /*(size_t)*/ uncompressedSize);

}
};
