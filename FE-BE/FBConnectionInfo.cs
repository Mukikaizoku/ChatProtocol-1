 using System.Runtime.InteropServices;
 struct FBConnectionInfo
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
    public char[] ip;
    public int port;
    Protocol protocol;
}
