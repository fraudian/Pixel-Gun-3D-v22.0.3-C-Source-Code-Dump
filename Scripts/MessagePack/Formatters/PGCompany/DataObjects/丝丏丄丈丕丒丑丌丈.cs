using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丝丏丄丈丕丒丑丌丈 : IMessagePackFormatter<PGCompany.DataObjects.三七业丘丑不丒且丄>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.三七业丘丑不丒且丄 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_17;
            var val_18;
            MessagePack.MessagePackWriter val_19;
            bool val_20;
            MessagePack.IFormatterResolver val_21;
            string val_22;
            var val_23;
            var val_24;
            val_17 = 丆与丛丅丂三万一丑;
            val_18 = 丙业与丙丗丝不丈东;
            val_19 = 1152921541959357472;
            val_20 = true;
            if(val_18 != null)
            {
                    val_21 = val_17.Resolver;
                val_22 = 丙业与丙丗丝不丈东.TimeRefresh;
                val_23 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_21);
                var val_16 = 0;
                val_16 = val_16 + 1;
            }
            else
            {
                    val_19 = ???;
                val_17 = ???;
                val_21 = ???;
                val_18 = ???;
                val_23 = ???;
                val_22 = ???;
                val_20 = val_20 + ((X11) << 4);
                val_24 = val_20 + 296;
            }
            
            val_23.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_19, _span = new System.Span<System.Byte>() {_length = val_19}, _segment = new System.ArraySegment<System.Byte>() {_count = val_19}, _buffered = val_19, _bytesCommitted = val_19, _sequencePool = val_19, _rental = new Rental() {owner = val_19, <Value>k__BackingField = val_19}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_19}, <OldSpec>k__BackingField = val_19}, value:  null, options:  null);
            var val_17 = 0;
            val_17 = val_17 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_21).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_19, _span = new System.Span<System.Byte>() {_length = val_19}, _segment = new System.ArraySegment<System.Byte>() {_count = val_19}, _buffered = val_19, _bytesCommitted = val_19, _sequencePool = val_19, _rental = new Rental() {owner = val_19, <Value>k__BackingField = val_19}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_19}, <OldSpec>k__BackingField = val_19}, value:  null, options:  null);
            var val_18 = 0;
            val_18 = val_18 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_21).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_19, _span = new System.Span<System.Byte>() {_length = val_19}, _segment = new System.ArraySegment<System.Byte>() {_count = val_19}, _buffered = val_19, _bytesCommitted = val_19, _sequencePool = val_19, _rental = new Rental() {owner = val_19, <Value>k__BackingField = val_19}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_19}, <OldSpec>k__BackingField = val_19}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.三七业丘丑不丒且丄 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            string val_11;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_12;
            Rilisoft.丝丑丂丛万丐丈丘且 val_13;
            var val_14;
            val_10 = 0;
            if((1152921541959559648 & 1) != 0)
            {
                    return (PGCompany.DataObjects.三七业丘丑不丒且丄)val_10;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541959559648 < 1)
            {
                goto label_5;
            }
            
            val_11 = 0;
            val_12 = 0;
            var val_16 = 0;
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
            val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_32;
            label_22:
            val_12 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_32;
            label_29:
            val_13 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            val_14 = 1152921541959559648;
            label_32:
            val_16 = val_16 + 1;
            if(val_16 != 1152921541959559648)
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
            PGCompany.DataObjects.三七业丘丑不丒且丄 val_12 = null;
            val_10 = val_12;
            val_12 = new PGCompany.DataObjects.三七业丘丑不丒且丄();
            if(val_10 != null)
            {
                    .TimeRefresh = val_11;
                .Level = val_13;
                mem[1152921541959592448] = val_14;
            }
            else
            {
                    mem[16] = val_11;
                mem[24] = val_13;
                mem[32] = val_14;
            }
            
            .ItemParams = val_12;
            return (PGCompany.DataObjects.三七业丘丑不丒且丄)val_10;
        }
        public 丝丏丄丈丕丒丑丌丈()
        {
        
        }
    
    }

}
