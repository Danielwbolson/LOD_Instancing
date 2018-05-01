

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataCompressor : vtkObject {

// virtual size_t GetMaximumCompressionSpace(size_t size)
// "virtual size_t GetMaximumCompressionSpace(size_t size)"
public new ulong GetMaximumCompressionSpace(ulong /*(size_t)*/ size) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataCompressor.GetMaximumCompressionSpace_0(this, returnPointer, size);
	return Ptr.deref(returnPointer);
}


// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char * compressedData, size_t compressionSpace)
// "size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char* compressedData, size_t compressionSpace)"
public new ulong Compress(char /*(charconst*)*/ []uncompressedData, ulong /*(size_t)*/ uncompressedSize, char /*(char*)*/ []compressedData, ulong /*(size_t)*/ compressionSpace) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataCompressor.Compress_0(this, returnPointer, uncompressedData, uncompressedSize, compressedData, compressionSpace);
	return Ptr.deref(returnPointer);
}


// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char * uncompressedData, size_t uncompressedSize)
// "size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char* uncompressedData, size_t uncompressedSize)"
public new ulong Uncompress(char /*(charconst*)*/ []compressedData, ulong /*(size_t)*/ compressedSize, char /*(char*)*/ []uncompressedData, ulong /*(size_t)*/ uncompressedSize) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataCompressor.Uncompress_0(this, returnPointer, compressedData, compressedSize, uncompressedData, uncompressedSize);
	return Ptr.deref(returnPointer);
}


// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
// "vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)"
public new vtkUnsignedCharArray Compress(char /*(charconst*)*/ []uncompressedData, ulong /*(size_t)*/ uncompressedSize) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataCompressor.Compress_1(this, returnPointer, uncompressedData, uncompressedSize);
	return Ptr.deref(returnPointer);
}


// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
// "vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)"
public new vtkUnsignedCharArray Uncompress(char /*(charconst*)*/ []compressedData, ulong /*(size_t)*/ compressedSize, ulong /*(size_t)*/ uncompressedSize) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataCompressor.Uncompress_1(this, returnPointer, compressedData, compressedSize, uncompressedSize);
	return Ptr.deref(returnPointer);
}


}
};
