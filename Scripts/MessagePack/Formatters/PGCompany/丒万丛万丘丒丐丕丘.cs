using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丒万丛万丘丒丐丕丘 : IMessagePackFormatter<PGCompany.丌七丒万丝丄东且七.丑不且丁丌专不东丂>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丌七丒万丝丄东且七.丑不且丁丌专不东丂 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_19;
            var val_20;
            MessagePack.MessagePackWriter val_21;
            bool val_22;
            MessagePack.IFormatterResolver val_23;
            var val_24;
            Rilisoft.丝丑丂丛万丐丈丘且 val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_19 = 丆与丛丅丂三万一丑;
            val_20 = 丙业与丙丗丝不丈东;
            val_21 = 1152921541929581232;
            val_22 = true;
            if(val_20 != null)
            {
                    val_23 = val_19.Resolver;
                val_24 = 1152921541903703776;
                val_25 = 丙业与丙丗丝不丈东.AttributeIndex;
                val_27 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_23);
                val_28 = 1152921504968347648;
                var val_18 = 0;
                val_18 = val_18 + 1;
            }
            else
            {
                    val_21 = ???;
                val_19 = ???;
                val_23 = ???;
                val_20 = ???;
                val_26 = ???;
                val_25 = ???;
                val_24 = ???;
                val_27 = ???;
                val_28 = ???;
                val_22 = val_22 + ((X11) << 4);
                val_29 = val_22 + 296;
            }
            
            val_27.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_21, _span = new System.Span<System.Byte>() {_length = val_21}, _segment = new System.ArraySegment<System.Byte>() {_count = val_21}, _buffered = val_21, _bytesCommitted = val_21, _sequencePool = val_21, _rental = new Rental() {owner = val_21, <Value>k__BackingField = val_21}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_21}, <OldSpec>k__BackingField = val_21}, value:  null, options:  null);
            var val_19 = 0;
            val_19 = val_19 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.Common.专一与丁丒丝丞丂三>(resolver:  val_23).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_21, _span = new System.Span<System.Byte>() {_length = val_21}, _segment = new System.ArraySegment<System.Byte>() {_count = val_21}, _buffered = val_21, _bytesCommitted = val_21, _sequencePool = val_21, _rental = new Rental() {owner = val_21, <Value>k__BackingField = val_21}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_21}, <OldSpec>k__BackingField = val_21}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_5 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_23);
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_5, typeof(), slot: 0);
        }
        public PGCompany.丌七丒万丝丄东且七.丑不且丁丌专不东丂 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            PGCompany.Common.专一与丁丒丝丞丂三 val_11;
            Rilisoft.丝丑丂丛万丐丈丘且 val_12;
            Rilisoft.丝丑丂丛万丐丈丘且 val_13;
            var val_14;
            val_10 = 0;
            if((1152921541929779296 & 1) != 0)
            {
                    return (丑不且丁丌专不东丂)val_10;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541929779296 < 1)
            {
                goto label_5;
            }
            
            val_11 = 0;
            var val_16 = 0;
            val_12 = 0;
            val_13 = 0;
            val_14 = 0;
            label_33:
            if(val_16 == 2)
            {
                goto label_6;
            }
            
            if(val_16 == 1)
            {
                goto label_7;
            }
            
            if(val_16 != 0)
            {
                goto label_32;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_15;
            label_6:
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_22;
            label_7:
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_29;
            label_15:
            val_13 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            val_14 = 1152921541929779296;
            goto label_32;
            label_22:
            val_12 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_32;
            label_29:
            val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.Common.专一与丁丒丝丞丂三>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            label_32:
            val_16 = val_16 + 1;
            if(val_16 != 1152921541929779296)
            {
                goto label_33;
            }
            
            goto label_34;
            label_5:
            val_14 = 0;
            val_13 = 0;
            val_12 = 0;
            val_11 = 0;
            label_34:
            丌七丒万丝丄东且七.丑不且丁丌专不东丂 val_12 = null;
            val_10 = val_12;
            val_12 = new 丌七丒万丝丄东且七.丑不且丁丌专不东丂();
            if(val_10 != null)
            {
                    .AttributeIndex = val_13;
                mem[1152921541929812088] = val_14;
                .Type = val_11;
            }
            else
            {
                    mem[16] = val_13;
                mem[24] = val_14;
                mem[32] = val_11;
            }
            
            .Value = val_12;
            mem[1152921541929812112] = 0;
            return (丑不且丁丌专不东丂)val_10;
        }
        public 丒万丛万丘丒丐丕丘()
        {
        
        }
    
    }

}
