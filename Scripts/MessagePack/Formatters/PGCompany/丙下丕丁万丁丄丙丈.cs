using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丙下丕丁万丁丄丙丈 : IMessagePackFormatter<PGCompany.丅丞与丟与丄丕丒丂>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丅丞与丟与丄丕丒丂 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_23;
            var val_24;
            var val_25;
            MessagePack.MessagePackWriter val_26;
            bool val_27;
            MessagePack.IFormatterResolver val_28;
            var val_29;
            var val_30;
            val_24 = 丆与丛丅丂三万一丑;
            val_25 = 丙业与丙丗丝不丈东;
            val_26 = 1152921541920063024;
            val_27 = true;
            if(val_25 != null)
            {
                    val_28 = val_24.Resolver;
                val_29 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<七东万一万丞丂且丒>(resolver:  val_28);
                var val_21 = 0;
                val_21 = val_21 + 1;
                val_30 = 1152921541920104000;
            }
            else
            {
                    val_23 = ???;
                val_26 = ???;
                val_24 = ???;
                val_28 = ???;
                val_25 = ???;
                val_29 = ???;
                val_27 = val_27 + ((X11) << 4);
                val_30 = val_27 + 296;
            }
            
            var val_3 = val_23 - 160;
            var val_4 = val_23 - 160;
            var val_22 = 0;
            val_22 = val_22 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏>>(resolver:  val_28).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  null, options:  null);
            var val_23 = 0;
            val_23 = val_23 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>>>(resolver:  val_28).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  null, options:  null);
            var val_24 = 0;
            val_24 = val_24 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>>(resolver:  val_28).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  null, options:  null);
        }
        public PGCompany.丅丞与丟与丄丕丒丂 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, 专丙丆丏且七丈丗丏> val_13;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<丞丗丆丙丝丌且丄丝>> val_14;
            val_12 = 0;
            if((1152921541920269328 & 1) != 0)
            {
                    return (PGCompany.丅丞与丟与丄丕丒丂)val_12;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541920269328 < 1)
            {
                goto label_5;
            }
            
            val_13 = 0;
            val_14 = 0;
            var val_21 = 0;
            label_39:
            if(val_21 > 3)
            {
                goto label_38;
            }
            
            var val_16 = -18990744;
            val_16 = val_16 + 106070076;
            goto (-18990744 + 106070076);
            label_38:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541920269328)
            {
                goto label_39;
            }
            
            goto label_40;
            label_5:
            val_14 = 0;
            val_13 = 0;
            label_40:
            PGCompany.丅丞与丟与丄丕丒丂 val_15 = null;
            val_12 = val_15;
            val_15 = new PGCompany.丅丞与丟与丄丕丒丂();
            if(val_12 != null)
            {
                    .CohortsSettings = val_13;
                .Packs = val_14;
            }
            else
            {
                    mem[112] = val_13;
                mem[120] = val_14;
            }
            
            .AvailableItems = 0;
            return (PGCompany.丅丞与丟与丄丕丒丂)val_12;
        }
        public 丙下丕丁万丁丄丙丈()
        {
        
        }
    
    }

}
