
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDataCompressor {

// virtual size_t GetMaximumCompressionSpace(size_t size)
// virtual size_t GetMaximumCompressionSpace(size_t size)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_GetMaximumCompressionSpace_0")] public static extern 
bool GetMaximumCompressionSpace_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, ulong /*(size_t)*/ size);

// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char * compressedData, size_t compressionSpace)
// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char* compressedData, size_t compressionSpace)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Compress_0")] public static extern 
bool Compress_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(unsigned charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize, string /*(unsigned char*)*/ compressedData, ulong /*(size_t)*/ compressionSpace);

// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char * uncompressedData, size_t uncompressedSize)
// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char* uncompressedData, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Uncompress_0")] public static extern 
bool Uncompress_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(unsigned charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, string /*(unsigned char*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize);

// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Compress_1")] public static extern 
bool Compress_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(unsigned charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize);

// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Uncompress_1")] public static extern 
bool Uncompress_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(unsigned charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, ulong /*(size_t)*/ uncompressedSize);

}
};
