using System.Runtime.InteropServices;

namespace Client
{
    struct JoinFailBody
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public char[] ip;
        public int port;
    }
}
