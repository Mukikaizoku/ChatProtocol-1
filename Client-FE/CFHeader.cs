using System.Runtime.InteropServices;

namespace ChatServer
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    struct CFHeader
    {
        public CFMessageType type;
        public CFMessageState state;
        public int length;
    }
    
    enum CFMessageType : short
    {
        Id_Dup = 110,                   //Reserve for a later implementation of an incorrect-server login attempt and subsequent pass to login server
        Signup = 120,                   //Reserve for a later implementation of an incorrect-server login attempt and subsequent pass to login server
        Delete = 130,
        Change_Password = 140,

        Login = 210,                    //Reserve for a later implementation of an incorrect-server login attempt and subsequent pass to login server
        LogOut = 220,                   //Reserve for a later implementation of an incorrect-server login attempt and subsequent pass to login server

        Room_Create = 310,              //Request to Create a Room
        Room_Leave = 320,               //Request to Leave a Room
        Room_Join = 330,                //Request to Join a Room
        Room_List = 340,                //Request to Get the Room List
        ConnectionPass = 350,
        Room_Delete = 360,              //Request to Delete a Room

        Chat_MSG_From_Client = 410,     //Chat Message Send
        Chat_MSG_Broadcast = 420,       //Chat Message Broadcast

        Health_Check = 510              
    };

    enum CFMessageState : short
    {
        Request = 100,
        Success = 200,
        Fail = 400
    }
}
