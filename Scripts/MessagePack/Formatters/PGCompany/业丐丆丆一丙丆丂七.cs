using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 业丐丆丆一丙丆丂七 : IMessagePackFormatter<PGCompany.丙且丟业丗世下丈且>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丙且丟业丗世下丈且 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_19;
            var val_20;
            MessagePack.MessagePackWriter val_21;
            bool val_22;
            MessagePack.IFormatterResolver val_23;
            System.Collections.Generic.List<丅万丂世不丘丕下一> val_24;
            var val_25;
            var val_26;
            val_19 = 丆与丛丅丂三万一丑;
            val_20 = 丙业与丙丗丝不丈东;
            val_21 = 1152921541913777344;
            val_22 = true;
            if(val_20 != null)
            {
                    val_23 = val_19.Resolver;
                val_24 = 丙业与丙丗丝不丈东.AllSettings;
                val_25 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<丅万丂世不丘丕下一>>(resolver:  val_23);
                var val_18 = 0;
                val_18 = val_18 + 1;
            }
            else
            {
                    val_21 = ???;
                val_19 = ???;
                val_23 = ???;
                val_20 = ???;
                val_25 = ???;
                val_24 = ???;
                val_22 = val_22 + ((X11) << 4);
                val_26 = val_22 + 296;
            }
            
            val_25.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_21, _span = new System.Span<System.Byte>() {_length = val_21}, _segment = new System.ArraySegment<System.Byte>() {_count = val_21}, _buffered = val_21, _bytesCommitted = val_21, _sequencePool = val_21, _rental = new Rental() {owner = val_21, <Value>k__BackingField = val_21}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_21}, <OldSpec>k__BackingField = val_21}, value:  null, options:  null);
            var val_19 = 0;
            val_19 = val_19 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_23).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_21, _span = new System.Span<System.Byte>() {_length = val_21}, _segment = new System.ArraySegment<System.Byte>() {_count = val_21}, _buffered = val_21, _bytesCommitted = val_21, _sequencePool = val_21, _rental = new Rental() {owner = val_21, <Value>k__BackingField = val_21}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_21}, <OldSpec>k__BackingField = val_21}, value:  null, options:  null);
            var val_20 = 0;
            val_20 = val_20 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_23).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_21, _span = new System.Span<System.Byte>() {_length = val_21}, _segment = new System.ArraySegment<System.Byte>() {_count = val_21}, _buffered = val_21, _bytesCommitted = val_21, _sequencePool = val_21, _rental = new Rental() {owner = val_21, <Value>k__BackingField = val_21}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_21}, <OldSpec>k__BackingField = val_21}, value:  null, options:  null);
        }
        public PGCompany.丙且丟业丗世下丈且 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            System.Collections.Generic.List<丅万丂世不丘丕下一> val_11;
            Rilisoft.丝丑丂丛万丐丈丘且 val_12;
            Rilisoft.丝丑丂丛万丐丈丘且 val_13;
            var val_14;
            val_10 = 0;
            if((1152921541913979520 & 1) != 0)
            {
                    return (PGCompany.丙且丟业丗世下丈且)val_10;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541913979520 < 1)
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
            val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<丅万丂世不丘丕下一>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_32;
            label_22:
            val_12 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_32;
            label_29:
            val_13 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            val_14 = 1152921541913979520;
            label_32:
            val_16 = val_16 + 1;
            if(val_16 != 1152921541913979520)
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
            PGCompany.丙且丟业丗世下丈且 val_12 = null;
            val_10 = val_12;
            val_12 = new PGCompany.丙且丟业丗世下丈且();
            if(val_10 != null)
            {
                    .AllSettings = val_11;
                .OpenLevel = val_13;
                mem[1152921541914012320] = val_14;
            }
            else
            {
                    mem[16] = val_11;
                mem[24] = val_13;
                mem[32] = val_14;
            }
            
            .TimeLife = val_12;
            mem[1152921541914012336] = 0;
            return (PGCompany.丙且丟业丗世下丈且)val_10;
        }
        public 业丐丆丆一丙丆丂七()
        {
        
        }
    
    }

}
