using System.Buffers;
using MySql.Cdc.Events;
using MySql.Cdc.Protocol;

namespace MySql.Cdc.Parsers
{
    public class IntVarEventParser : IEventParser
    {
        public IBinlogEvent ParseEvent(EventHeader header, ReadOnlySequence<byte> buffer)
        {
            var reader = new PacketReader(buffer);

            var type = reader.ReadInt(1);
            var value = reader.ReadLong(8);

            return new IntVarEvent(header, type, value);
        }
    }
}
