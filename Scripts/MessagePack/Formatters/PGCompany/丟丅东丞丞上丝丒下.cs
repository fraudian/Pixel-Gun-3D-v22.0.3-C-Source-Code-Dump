using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丟丅东丞丞上丝丒下 : IMessagePackFormatter<PGCompany.丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_16;
            var val_17;
            MessagePack.MessagePackWriter val_18;
            bool val_19;
            MessagePack.IFormatterResolver val_20;
            var val_21;
            System.Collections.Generic.List<System.String> val_22;
            var val_23;
            var val_24;
            var val_25;
            val_16 = 丆与丛丅丂三万一丑;
            val_17 = 丙业与丙丗丝不丈东;
            val_18 = 1152921541919554912;
            val_19 = true;
            if(val_17 != null)
            {
                    val_20 = val_16.Resolver;
                val_21 = 1152921541919485584;
                val_22 = 丙业与丙丗丝不丈东.ItemsFirst;
                val_23 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<System.String>>(resolver:  val_20);
                val_24 = 1152921504968347648;
                var val_15 = 0;
                val_15 = val_15 + 1;
            }
            else
            {
                    val_18 = ???;
                val_16 = ???;
                val_20 = ???;
                val_17 = ???;
                val_23 = ???;
                val_22 = ???;
                val_24 = ???;
                val_21 = ???;
                val_19 = val_19 + ((X11) << 4);
                val_25 = val_19 + 296;
            }
            
            val_23.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_20);
            var val_16 = 0;
            val_16 = val_16 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_3, typeof(), slot: 0);
        }
        public PGCompany.丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_8;
            System.Collections.Generic.List<System.String> val_9;
            System.Collections.Generic.List<System.String> val_10;
            val_8 = 0;
            if((1152921541919748848 & 1) != 0)
            {
                    return (丞丗丆丙丝丌且丄丝)val_8;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541919748848 < 1)
            {
                goto label_5;
            }
            
            val_9 = 0;
            val_10 = 0;
            var val_12 = 0;
            label_24:
            if(val_12 == 1)
            {
                goto label_6;
            }
            
            if(val_12 != 0)
            {
                goto label_23;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_14;
            label_6:
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_21;
            label_14:
            val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<System.String>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_23;
            label_21:
            val_10 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<System.String>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            label_23:
            val_12 = val_12 + 1;
            if(val_12 != 1152921541919748848)
            {
                goto label_24;
            }
            
            goto label_25;
            label_5:
            val_10 = 0;
            val_9 = 0;
            label_25:
            丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝 val_9 = null;
            val_8 = val_9;
            val_9 = new 丅丞与丟与丄丕丒丂.丞丗丆丙丝丌且丄丝();
            if(val_8 != null)
            {
                    .ItemsFirst = val_9;
            }
            else
            {
                    mem[16] = val_9;
            }
            
            .ItemsSeconds = val_10;
            return (丞丗丆丙丝丌且丄丝)val_8;
        }
        public 丟丅东丞丞上丝丒下()
        {
        
        }
    
    }

}
