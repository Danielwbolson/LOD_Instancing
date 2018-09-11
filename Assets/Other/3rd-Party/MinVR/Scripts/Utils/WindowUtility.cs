using System;
using System.Runtime.InteropServices;
using System.Text;

public class WindowUtility {

	// http://unitydevelopers.blogspot.com/2015/04/set-size-and-position-of-windows.html
	// http://answers.unity3d.com/questions/148723/how-can-i-change-the-title-of-the-standalone-playe.html
	// http://matt.benic.us/post/88468666204/using-win32-api-to-get-specific-window-instance-in
	// http://answers.unity3d.com/questions/936814/choose-screen-with-command-line-arguments.html
	// https://gist.github.com/mattbenic/908483ad0bedbc62ab17
	// Unity3D does not have a built-in function to set the position of an window
	#if UNITY_STANDALONE_WIN || UNITY_EDITOR
	private const string UnityWindowClassName = "UnityWndClass";

	[DllImport("kernel32.dll")]
	static extern uint GetCurrentThreadId();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	static extern int GetClassName(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
	static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int wFlags);

	[DllImport("user32.dll", EntryPoint = "SetWindowText")]
	static extern bool SetWindowText(IntPtr hwnd, System.String lpString);

	public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool EnumThreadWindows(uint dwThreadId, EnumWindowsProc lpEnumFunc, IntPtr lParam);

	public static void SetPosition(int x, int y, int resX = 0, int resY = 0) 
	{
		// 1) get the current window handle.
		IntPtr windowHandle = WindowUtility.GetWindowHandle();

		// 2) offset and positio the window, if we got something.
		if (windowHandle != IntPtr.Zero) {
			SetWindowPos(windowHandle, 0, x, y, resX, resY, resX * resY == 0 ? 1 : 0);
		}
	}

	public static void SetWindowTitle(string title) {
		// 1) get the current window handle.
		IntPtr windowHandle = WindowUtility.GetWindowHandle();
		// 2) set the window title, if we got something.
		if (windowHandle != IntPtr.Zero) {
			SetWindowText(windowHandle, title);
		}
	}

	/// <summary>
	/// Gets the current window handle.
	/// </summary>
	/// <returns>The window handle.</returns>
	private static IntPtr GetWindowHandle() {
		IntPtr windowHandle = IntPtr.Zero;

		// enumerates all nonchild windows associated with the current thread.
		uint threadId = GetCurrentThreadId();
		EnumThreadWindows(threadId, (hWnd, lParam) =>
			{
				// retrieves the name of the class to which the specified window belongs.
				var classText = new StringBuilder(UnityWindowClassName.Length + 1);
				GetClassName(hWnd, classText, classText.Capacity);
				// compare to see if this is what we are looking for
				if (classText.ToString() == UnityWindowClassName)
				{
					windowHandle = hWnd;
					return false;
				}
				return true;
			}, IntPtr.Zero);

		//
		return windowHandle;
	}
	#endif
}
