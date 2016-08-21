using Agent;
using System.Runtime.InteropServices;

namespace Agent
{
    // struct for Client ~ BE Header
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct BEHeader : IHeader
    {
        public BEMessageType type; // message type
        public BEMessageState state; // message status
        public int length; // body length 

        public BEHeader(BEMessageType type, BEMessageState state, int length)
        {
            this.type = type;
            this.state = state;
            this.length = length;
        }
    }
    // 
    public enum BEMessageType : short
    {

        Total_Room_Count = 110, // type for request total room number in application
        User_Status = 210, // type for request FE' user number
        Chat_Ranking = 310, // type for request chatting ranking 

        LogIn = 410,
        LogOut = 420,

    };

    public enum BEMessageState : short
    {
        REQUEST = 100, // state that this message is 'Request'
        SUCCESS = 200, // state that this message is Response messgae with 'Success'
        FAIL = 400 // state that this message is Response message with 'Fail'
    }
}
