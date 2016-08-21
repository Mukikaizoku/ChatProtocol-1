using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.CFProtocol
{
    class RemoveAcountRequestBody
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        char[] id;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        char[] password;

        public RemoveAcountRequestBody(char[] id, char[] password)
        {
            this.id = new char[12];
            this.password = new char[16];
            Array.Copy(id, this.id, id.Length);
            Array.Copy(password, this.password, password.Length);
        }
    }
}
