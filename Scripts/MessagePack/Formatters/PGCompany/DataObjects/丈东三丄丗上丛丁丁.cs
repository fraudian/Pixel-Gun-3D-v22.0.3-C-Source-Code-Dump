using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丈东三丄丗上丛丁丁 : IMessagePackFormatter<PGCompany.DataObjects.丟业专丘七丐丗且丌>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.丟业专丘七丐丗且丌 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_11;
            var val_12;
            MessagePack.MessagePackWriter val_13;
            bool val_14;
            System.Collections.Generic.List<丙丕丈一一丝丑七丈> val_15;
            var val_16;
            var val_17;
            val_11 = 丆与丛丅丂三万一丑;
            val_12 = 丙业与丙丗丝不丈东;
            val_13 = 1152921541961448448;
            val_14 = true;
            if(val_12 != null)
            {
                    val_15 = 丙业与丙丗丝不丈东.Slots;
                val_16 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<丙丕丈一一丝丑七丈>>(resolver:  val_11.Resolver);
                var val_10 = 0;
                val_10 = val_10 + 1;
            }
            else
            {
                    val_12 = ???;
                val_13 = ???;
                val_15 = ???;
                val_11 = ???;
                val_16 = ???;
                val_14 = val_14 + ((X11) << 4);
                val_17 = val_14 + 296;
            }
            
            val_16.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_13, _span = new System.Span<System.Byte>() {_length = val_13}, _segment = new System.ArraySegment<System.Byte>() {_count = val_13}, _buffered = val_13, _bytesCommitted = val_13, _sequencePool = val_13, _rental = new Rental() {owner = val_13, <Value>k__BackingField = val_13}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_13}, <OldSpec>k__BackingField = val_13}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.丟业专丘七丐丗且丌 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            int val_6;
            var val_7;
            int val_8;
            int val_9;
            System.Collections.Generic.List<丙丕丈一一丝丑七丈> val_10;
            val_7 = 0;
            if((1152921541961634176 & 1) != 0)
            {
                    return (PGCompany.DataObjects.丟业专丘七丐丗且丌)val_7;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541961634176 < 1)
            {
                goto label_5;
            }
            
            val_8 = 0;
            val_9 = 0;
            val_10 = 0;
            val_6 = 0;
            var val_9 = 0;
            label_18:
            if(val_9 > 3)
            {
                goto label_17;
            }
            
            var val_7 = -35368612;
            val_7 = val_7 + 106046044;
            goto (-35368612 + 106046044);
            label_17:
            val_9 = val_9 + 1;
            if(val_9 != 1152921541961634176)
            {
                goto label_18;
            }
            
            goto label_19;
            label_5:
            val_6 = 0;
            val_10 = 0;
            val_9 = 0;
            val_8 = 0;
            label_19:
            PGCompany.DataObjects.丟业专丘七丐丗且丌 val_6 = null;
            val_7 = val_6;
            val_6 = new PGCompany.DataObjects.丟业专丘七丐丗且丌();
            if(val_7 != null)
            {
                    .SeasonId = val_8;
                .NextDayInterval = val_9;
                .Slots = val_10;
            }
            else
            {
                    mem[16] = val_8;
                .NextDayInterval = val_9;
                mem[24] = val_10;
            }
            
            .StartLevel = val_6;
            return (PGCompany.DataObjects.丟业专丘七丐丗且丌)val_7;
        }
        public 丈东三丄丗上丛丁丁()
        {
        
        }
    
    }

}
