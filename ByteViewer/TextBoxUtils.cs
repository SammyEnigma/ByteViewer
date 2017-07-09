using System;
using System.Runtime.InteropServices;

namespace ByteVieer
{
    internal class TextBoxUtils
    {
        public enum ScrollType : int
        {
            HORIZONTAL = 0,
            VERTICAL = 1
        }

        public const UInt16 WM_HSCROLL = 0x0114;
        public const UInt16 WM_VSCROLL = 0x0115;
        public const UInt16 SB_THUMB_POS = 0x04;

        [DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr controlHandle, int scrollType);

        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr controlHandle, uint message, IntPtr wParam, IntPtr lParam);
    }
}
