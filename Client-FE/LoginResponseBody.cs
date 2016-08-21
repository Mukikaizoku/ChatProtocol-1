using System.Runtime.InteropServices;

namespace Client
{
    struct LoginResponseBody
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public char[] ip;
        public int port;
        public Protocol protocolType;
        public int cookie;
    }
}
