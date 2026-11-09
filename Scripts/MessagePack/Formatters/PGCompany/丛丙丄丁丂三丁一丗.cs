using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丛丙丄丁丂三丁一丗 : IMessagePackFormatter<PGCompany.丅丝丂丕上业与丐丏.专七丙丅丙东七万万>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丅丝丂丕上业与丐丏.专七丙丅丙东七万万 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_19;
            var val_20;
            MessagePack.MessagePackWriter val_21;
            bool val_22;
            MessagePack.IFormatterResolver val_23;
            世丕上丞与业丂丞丞 val_24;
            var val_25;
            var val_26;
            val_19 = 丆与丛丅丂三万一丑;
            val_20 = 丙业与丙丗丝不丈东;
            val_21 = 1152921541916786192;
            val_22 = true;
            if(val_20 != null)
            {
                    val_23 = val_19.Resolver;
                val_24 = 丙业与丙丗丝不丈东.ItemGroup;
                val_25 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<世丕上丞与业丂丞丞>(resolver:  val_23);
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
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<ItemRarity>(resolver:  val_23).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_21, _span = new System.Span<System.Byte>() {_length = val_21}, _segment = new System.ArraySegment<System.Byte>() {_count = val_21}, _buffered = val_21, _bytesCommitted = val_21, _sequencePool = val_21, _rental = new Rental() {owner = val_21, <Value>k__BackingField = val_21}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_21}, <OldSpec>k__BackingField = val_21}, value:  null, options:  null);
            var val_20 = 0;
            val_20 = val_20 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_23).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_21, _span = new System.Span<System.Byte>() {_length = val_21}, _segment = new System.ArraySegment<System.Byte>() {_count = val_21}, _buffered = val_21, _bytesCommitted = val_21, _sequencePool = val_21, _rental = new Rental() {owner = val_21, <Value>k__BackingField = val_21}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_21}, <OldSpec>k__BackingField = val_21}, value:  null, options:  null);
            var val_21 = 0;
            val_21 = val_21 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_23).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_21, _span = new System.Span<System.Byte>() {_length = val_21}, _segment = new System.ArraySegment<System.Byte>() {_count = val_21}, _buffered = val_21, _bytesCommitted = val_21, _sequencePool = val_21, _rental = new Rental() {owner = val_21, <Value>k__BackingField = val_21}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_21}, <OldSpec>k__BackingField = val_21}, value:  null, options:  null);
        }
        public PGCompany.丅丝丂丕上业与丐丏.专七丙丅丙东七万万 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            世丕上丞与业丂丞丞 val_13;
            ItemRarity val_14;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_15;
            Rilisoft.丝丑丂丛万丐丈丘且 val_16;
            val_12 = 0;
            if((1152921541916996592 & 1) != 0)
            {
                    return (专七丙丅丙东七万万)val_12;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541916996592 < 1)
            {
                goto label_5;
            }
            
            val_13 = 0;
            val_14 = 0;
            val_15 = 0;
            var val_21 = 0;
            val_16 = 0;
            label_39:
            if(val_21 > 3)
            {
                goto label_38;
            }
            
            var val_16 = -18975764;
            val_16 = val_16 + 106070204;
            goto (-18975764 + 106070204);
            label_38:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541916996592)
            {
                goto label_39;
            }
            
            goto label_40;
            label_5:
            val_16 = 0;
            val_15 = 0;
            val_14 = 0;
            val_13 = 0;
            label_40:
            丅丝丂丕上业与丐丏.专七丙丅丙东七万万 val_15 = null;
            val_12 = val_15;
            val_15 = new 丅丝丂丕上业与丐丏.专七丙丅丙东七万万();
            if(val_12 != null)
            {
                    .ItemGroup = val_13;
                .ItemRarity = val_14;
                .CountItems = val_16;
                mem[1152921541917033504] = 0;
            }
            else
            {
                    mem[16] = val_13;
                .ItemRarity = val_14;
                mem[24] = val_16;
                mem[32] = 0;
            }
            
            .AlternativeItemParams = val_15;
            return (专七丙丅丙东七万万)val_12;
        }
        public 丛丙丄丁丂三丁一丗()
        {
        
        }
    
    }

}
