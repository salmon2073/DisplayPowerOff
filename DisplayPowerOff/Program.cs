using System;
using System.Runtime.InteropServices;

namespace DisplayPowerOff {
    class Program {
        [DllImport("user32.dll")]
        static extern IntPtr PostMessage(int hWnd, uint Msg, int wParam, int lParam);
        static void Main(string[] args) {
            PostMessage(-1, 0x112, 0xf170, 2);
        }
    }
}