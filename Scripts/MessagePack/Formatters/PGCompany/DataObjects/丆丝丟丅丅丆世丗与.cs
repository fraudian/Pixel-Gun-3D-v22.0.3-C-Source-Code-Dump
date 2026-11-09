using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丆丝丟丅丅丆世丗与 : IMessagePackFormatter<PGCompany.DataObjects.丌丏不丈三丛丘丝业>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.丌丏不丈三丛丘丝业 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            MessagePack.MessagePackWriter val_11;
            bool val_12;
            string val_13;
            var val_14;
            var val_15;
            val_10 = 丆与丛丅丂三万一丑;
            val_11 = 1152921541954957888;
            val_12 = true;
            if(丙业与丙丗丝不丈东 != null)
            {
                    val_13 = 丙业与丙丗丝不丈东.Type;
                val_14 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_10.Resolver);
                var val_9 = 0;
                val_9 = val_9 + 1;
            }
            else
            {
                    val_11 = ???;
                val_10 = ???;
                val_14 = ???;
                val_13 = ???;
                val_12 = val_12 + ((X11) << 4);
                val_15 = val_12 + 296;
            }
            
            val_14.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_11, _span = new System.Span<System.Byte>() {_length = val_11}, _segment = new System.ArraySegment<System.Byte>() {_count = val_11}, _buffered = val_11, _bytesCommitted = val_11, _sequencePool = val_11, _rental = new Rental() {owner = val_11, <Value>k__BackingField = val_11}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_11}, <OldSpec>k__BackingField = val_11}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.丌丏不丈三丛丘丝业 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            int val_6;
            var val_7;
            string val_8;
            val_7 = 0;
            if((1152921541955143616 & 1) != 0)
            {
                    return (PGCompany.DataObjects.丌丏不丈三丛丘丝业)val_7;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541955143616 < 1)
            {
                goto label_5;
            }
            
            val_6 = 0;
            val_8 = 0;
            var val_8 = 0;
            label_17:
            if(val_8 != 1)
            {
                    if(val_8 != 0)
            {
                goto label_16;
            }
            
                val_6 = 1152921541955143616;
            }
            else
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_8 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            }
            
            label_16:
            val_8 = val_8 + 1;
            if(val_8 != 1152921541955143616)
            {
                goto label_17;
            }
            
            goto label_18;
            label_5:
            val_8 = 0;
            val_6 = 0;
            label_18:
            PGCompany.DataObjects.丌丏不丈三丛丘丝业 val_6 = null;
            val_7 = val_6;
            val_6 = new PGCompany.DataObjects.丌丏不丈三丛丘丝业();
            if(val_7 != null)
            {
                    .Position = val_6;
            }
            else
            {
                    mem[16] = val_6;
            }
            
            .Type = val_8;
            return (PGCompany.DataObjects.丌丏不丈三丛丘丝业)val_7;
        }
        public 丆丝丟丅丅丆世丗与()
        {
        
        }
    
    }

}
