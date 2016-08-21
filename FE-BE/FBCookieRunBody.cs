using System.Runtime.InteropServices;

    public struct FBCookieRunBody
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public char[] id;
        public int cookie;
    }

