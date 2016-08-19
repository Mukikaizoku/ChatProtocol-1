
using System.Runtime.InteropServices;

public struct FBConnectionInfoBody
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
    public char[] ip;
    public int port; //lenght of next body 

    Protocol protocol;

    public char[] Ip
    {
        get { return this.ip; }
        set { this.ip = value; }
    }

    public int Port
    {
        get { return this.port; }
        set { this.port = value; }
    }
}
