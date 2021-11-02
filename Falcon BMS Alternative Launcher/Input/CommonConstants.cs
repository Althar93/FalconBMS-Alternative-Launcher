﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconBMS.Launcher.Input
{
    public static class CommonConstants
    {
        public static readonly int DEVICE16 = 16;

        public static readonly int DX0      = 0;
        public static readonly int DX32     = 32;
        public static readonly int DX128    = 128;

        public static readonly int PRS0     = 0;
        public static readonly int PRS128   = 128;

        public static readonly int DX_PRESS         = 0;
        public static readonly int DX_PRESS_SHIFT   = 1;
        public static readonly int DX_RELEASE       = 2;
        public static readonly int DX_RELEASE_SHIFT = 3;

        public static readonly int KEYBOARD_KEYLENGTH = 238;

        public static readonly int POV360   = 36000;
        public static readonly int POV45    = 36000 / 8;
    }
}
