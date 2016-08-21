using System.Runtime.InteropServices;

namespace Agent
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    struct AdminHeader : IHeader
    {
        public AdminMessageType type;
        public AdminMessageState state;
        public int length;

        public AdminHeader(AdminMessageType type, AdminMessageState state, int length)
        {
            this.type = type;
            this.state = state;
            this.length = length;
        }
    }

    enum AdminMessageType : short
    {
        Total_Room_Count = 110, // type for request total room number in application
        User_Status = 210, // type for request FE' user number
        Chat_Ranking = 310, // type for request chatting ranking 

        LogIn = 410,
        LogOut = 420,

        DelegateCIA = 510,
        FEServerManaging = 610
    }
    
    enum AdminMessageState : short
    {
        REQUEST = 100, // state that this message is 'Request'
        SUCCESS = 200, // state that this message is Response messgae with 'Success'
        FAIL = 400 // state that this message is Response message with 'Fail'
    }

}
