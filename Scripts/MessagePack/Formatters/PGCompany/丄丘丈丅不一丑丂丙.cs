using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丄丘丈丅不一丑丂丙 : IMessagePackFormatter<PGCompany.丅丝丂丕上业与丐丏>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丅丝丂丕上业与丐丏 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_16;
            var val_17;
            MessagePack.MessagePackWriter val_18;
            bool val_19;
            MessagePack.IFormatterResolver val_20;
            七东万一万丞丂且丒 val_21;
            var val_22;
            var val_23;
            val_16 = 丆与丛丅丂三万一丑;
            val_17 = 丙业与丙丗丝不丈东;
            val_18 = 1152921541917818880;
            val_19 = true;
            if(val_17 != null)
            {
                    val_20 = val_16.Resolver;
                val_21 = 丙业与丙丗丝不丈东.Common;
                val_22 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<七东万一万丞丂且丒>(resolver:  val_20);
                var val_15 = 0;
                val_15 = val_15 + 1;
            }
            else
            {
                    val_18 = ???;
                val_16 = ???;
                val_20 = ???;
                val_17 = ???;
                val_22 = ???;
                val_21 = ???;
                val_19 = val_19 + ((X11) << 4);
                val_23 = val_19 + 296;
            }
            
            val_22.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
            var val_16 = 0;
            val_16 = val_16 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(resolver:  val_20).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
            var val_17 = 0;
            val_17 = val_17 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<丌丙三且世与丄丁专>>(resolver:  val_20).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
        }
        public PGCompany.丅丝丂丕上业与丐丏 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            七东万一万丞丂且丒 val_11;
            System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>> val_12;
            System.Collections.Generic.List<丌丙三且世与丄丁专> val_13;
            val_10 = 0;
            if((1152921541918021056 & 1) != 0)
            {
                    return (PGCompany.丅丝丂丕上业与丐丏)val_10;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541918021056 < 1)
            {
                goto label_5;
            }
            
            val_11 = 0;
            val_12 = 0;
            val_13 = 0;
            var val_16 = 0;
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
            val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<七东万一万丞丂且丒>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_32;
            label_22:
            val_13 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<丌丙三且世与丄丁专>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_32;
            label_29:
            val_12 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            label_32:
            val_16 = val_16 + 1;
            if(val_16 != 1152921541918021056)
            {
                goto label_33;
            }
            
            goto label_34;
            label_5:
            val_13 = 0;
            val_12 = 0;
            val_11 = 0;
            label_34:
            PGCompany.丅丝丂丕上业与丐丏 val_12 = null;
            val_10 = val_12;
            val_12 = new PGCompany.丅丝丂丕上业与丐丏();
            if(val_10 != null)
            {
                    .Common = val_11;
                .CohortSettings = val_12;
            }
            else
            {
                    mem[16] = val_11;
                mem[24] = val_12;
            }
            
            .OffersSettings = val_13;
            return (PGCompany.丅丝丂丕上业与丐丏)val_10;
        }
        public 丄丘丈丅不一丑丂丙()
        {
        
        }
    
    }

}
