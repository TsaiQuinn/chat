﻿using System;
using System.Runtime.InteropServices;

namespace ChatControl.ChatRichTextBox
{
    [Flags, ComVisible(false)]
    public enum TYMED : int
    {
        TYMED_NULL = 0,
        TYMED_HGLOBAL = 1,
        TYMED_FILE = 2,
        TYMED_ISTREAM = 4,
        TYMED_ISTORAGE = 8,
        TYMED_GDI = 16,
        TYMED_MFPICT = 32,
        TYMED_ENHMF = 64,
    }
}
