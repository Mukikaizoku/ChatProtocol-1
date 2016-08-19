 using System.Runtime.InteropServices;


namespace ChatServer
{
    struct CFRoomRequestBody
    {
        public int roomNo;          // 0 = Lobby
        //public int cookie;        //If 0, server knows it's not a connection pass request?
    }
}