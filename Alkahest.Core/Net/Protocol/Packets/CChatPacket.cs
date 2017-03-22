using Alkahest.Core.Data;

namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class CChatPacket : Packet
    {
        const string Name = "C_CHAT";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new CChatPacket();
        }

        [PacketField]
        internal ushort MessageOffset { get; set; }

        [PacketField]
        public ChatChannel Channel { get; set; }

        [PacketField]
        public string Message { get; set; }
    }
}
