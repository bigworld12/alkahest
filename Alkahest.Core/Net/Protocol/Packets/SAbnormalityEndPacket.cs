using Alkahest.Core.Game;

namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class SAbnormalityEndPacket : Packet
    {
        const string Name = "S_ABNORMALITY_END";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new SAbnormalityEndPacket();
        }

        [PacketField]
        public GameId Target { get; set; }

        [PacketField]
        public uint AbnormalityId { get; set; }
    }
}
