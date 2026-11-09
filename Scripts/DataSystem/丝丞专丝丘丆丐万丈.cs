using UnityEngine;

namespace DataSystem
{
    internal sealed class 丝丞专丝丘丆丐万丈 : IMessagePackFormatter<PGCompany.上丅丙丟不业不丆东>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.上丅丙丟不业不丆东 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = 丙业与丙丗丝不丈东.丁丕上三丕丌丟丗丙();
            var val_5 = 0;
            val_5 = val_5 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.Int32, System.Int32>>(resolver:  丆与丛丅丂三万一丑.Resolver).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = 业专丘专七丕丟丅与.writer._output, _span = new System.Span<System.Byte>() {_length = 业专丘专七丕丟丅与.writer._span._length}, _segment = new System.ArraySegment<System.Byte>() {_count = 业专丘专七丕丟丅与.writer._segment._count}, _buffered = 业专丘专七丕丟丅与.writer._buffered, _bytesCommitted = 业专丘专七丕丟丅与.writer._bytesCommitted, _sequencePool = 业专丘专七丕丟丅与.writer._sequencePool, _rental = new Rental() {owner = 业专丘专七丕丟丅与.writer._rental.owner, <Value>k__BackingField = 业专丘专七丕丟丅与.writer._rental.<Value>k__BackingField}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 业专丘专七丕丟丅与.<CancellationToken>k__BackingField.m_source}, <OldSpec>k__BackingField = 业专丘专七丕丟丅与.<OldSpec>k__BackingField}, value:  null, options:  null);
        }
        public PGCompany.上丅丙丟不业不丆东 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            return PGCompany.上丅丙丟不业不丆东.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.Int32, System.Int32>>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑));
        }
        public 丝丞专丝丘丆丐万丈()
        {
        
        }
    
    }

}
