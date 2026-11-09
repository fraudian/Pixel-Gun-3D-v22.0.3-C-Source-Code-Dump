using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丁且万专丁丐丏丙丂 : IMessagePackFormatter<PGCompany.上世东丗与丈丐丙丘>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.上世东丗与丈丐丙丘 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_16;
            var val_17;
            MessagePack.MessagePackWriter val_18;
            bool val_19;
            MessagePack.IFormatterResolver val_20;
            System.Collections.Generic.List<PGCompany.丐丐上丝丑七丕三丑> val_21;
            var val_22;
            var val_23;
            val_16 = 丆与丛丅丂三万一丑;
            val_17 = 丙业与丙丗丝不丈东;
            val_18 = 1152921541934656512;
            val_19 = true;
            if(val_17 != null)
            {
                    val_20 = val_16.Resolver;
                val_21 = 丙业与丙丗丝不丈东.PromotionSettings;
                val_22 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.丐丐上丝丑七丕三丑>>(resolver:  val_20);
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
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.丛上丐万下丘丙丘丌>>(resolver:  val_20).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
            var val_17 = 0;
            val_17 = val_17 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.丛且丂丐丌丈丈不一>>(resolver:  val_20).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
        }
        public PGCompany.上世东丗与丈丐丙丘 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            System.Collections.Generic.List<PGCompany.丐丐上丝丑七丕三丑> val_13;
            System.Collections.Generic.List<PGCompany.丛上丐万下丘丙丘丌> val_14;
            val_12 = 0;
            if((1152921541934863824 & 1) != 0)
            {
                    return (PGCompany.上世东丗与丈丐丙丘)val_12;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541934863824 < 1)
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
            
            var val_16 = -21403592;
            val_16 = val_16 + 106067720;
            goto (-21403592 + 106067720);
            label_38:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541934863824)
            {
                goto label_39;
            }
            
            goto label_40;
            label_5:
            val_14 = 0;
            val_13 = 0;
            label_40:
            PGCompany.上世东丗与丈丐丙丘 val_15 = null;
            val_12 = val_15;
            val_15 = new PGCompany.上世东丗与丈丐丙丘();
            if(val_12 != null)
            {
                    .PromotionSettings = val_13;
                .GroupSettings = val_14;
            }
            else
            {
                    mem[16] = val_13;
                mem[24] = val_14;
            }
            
            .GuiSettings = 0;
            return (PGCompany.上世东丗与丈丐丙丘)val_12;
        }
        public 丁且万专丁丐丏丙丂()
        {
        
        }
    
    }

}
