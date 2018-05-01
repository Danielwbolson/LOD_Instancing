

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataCompressor : vtkObject {
		public vtkDataCompressor(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataCompressor(IntPtr p) {return new vtkDataCompressor(p);}
		public static implicit operator  IntPtr(vtkDataCompressor o) {return o.GetPtr();}

// virtual size_t GetMaximumCompressionSpace(size_t size)
// "virtual size_t GetMaximumCompressionSpace(size_t size)"
public ulong GetMaximumCompressionSpace(ulong /*(size_t)*/ size) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkDataCompressor.GetMaximumCompressionSpace_0(returnPointer.GetPtr(), this, size);
	return (ulong)returnPointer;
}


// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char * compressedData, size_t compressionSpace)
// "size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char* compressedData, size_t compressionSpace)"
public ulong Compress(string /*(unsigned charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize, string /*(unsigned char*)*/ compressedData, ulong /*(size_t)*/ compressionSpace) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkDataCompressor.Compress_0(returnPointer.GetPtr(), this, uncompressedData, uncompressedSize, compressedData, compressionSpace);
	return (ulong)returnPointer;
}


// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char * uncompressedData, size_t uncompressedSize)
// "size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char* uncompressedData, size_t uncompressedSize)"
public ulong Uncompress(string /*(unsigned charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, string /*(unsigned char*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkDataCompressor.Uncompress_0(returnPointer.GetPtr(), this, compressedData, compressedSize, uncompressedData, uncompressedSize);
	return (ulong)returnPointer;
}


// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
// "vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)"
public vtkUnsignedCharArray Compress(string /*(unsigned charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataCompressor.Compress_1(returnPointer.GetPtr(), this, uncompressedData, uncompressedSize);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
// "vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)"
public vtkUnsignedCharArray Uncompress(string /*(unsigned charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, ulong /*(size_t)*/ uncompressedSize) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkDataCompressor.Uncompress_1(returnPointer.GetPtr(), this, compressedData, compressedSize, uncompressedSize);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


}
};
