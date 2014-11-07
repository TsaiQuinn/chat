using System.Runtime.InteropServices;

namespace ChatControl.ChatRichTextBox
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CHARRANGE
    {
        public int cpMin;
        public int cpMax;
    }
}
