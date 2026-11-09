using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丕丏专丟与世丌丟丂 : IMessagePackFormatter<PGCompany.StorePromotionPurchaseSettings>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.StorePromotionPurchaseSettings 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_23;
            var val_24;
            MessagePack.MessagePackWriter val_25;
            bool val_26;
            MessagePack.IFormatterResolver val_27;
            PGCompany.丆一丁丏三万丑东不 val_28;
            var val_29;
            var val_30;
            val_23 = 丆与丛丅丂三万一丑;
            val_24 = 丙业与丙丗丝不丈东;
            val_25 = 1152921541927495104;
            val_26 = true;
            if(val_24 != null)
            {
                    val_27 = val_23.Resolver;
                val_28 = 丙业与丙丗丝不丈东.Type;
                val_29 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.丆一丁丏三万丑东不>(resolver:  val_27);
                var val_21 = 0;
                val_21 = val_21 + 1;
            }
            else
            {
                    val_25 = ???;
                val_23 = ???;
                val_27 = ???;
                val_24 = ???;
                val_29 = ???;
                val_28 = ???;
                val_26 = val_26 + ((X11) << 4);
                val_30 = val_26 + 296;
            }
            
            val_29.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_25, _span = new System.Span<System.Byte>() {_length = val_25}, _segment = new System.ArraySegment<System.Byte>() {_count = val_25}, _buffered = val_25, _bytesCommitted = val_25, _sequencePool = val_25, _rental = new Rental() {owner = val_25, <Value>k__BackingField = val_25}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_25}, <OldSpec>k__BackingField = val_25}, value:  null, options:  null);
            PGCompany.三东丏不丗世丅丌丄 val_4 = val_24.与丂三丟业丘与丅三();
            var val_22 = 0;
            val_22 = val_22 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.三东丏不丗世丅丌丄>(resolver:  val_27).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_25, _span = new System.Span<System.Byte>() {_length = val_25}, _segment = new System.ArraySegment<System.Byte>() {_count = val_25}, _buffered = val_25, _bytesCommitted = val_25, _sequencePool = val_25, _rental = new Rental() {owner = val_25, <Value>k__BackingField = val_25}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_25}, <OldSpec>k__BackingField = val_25}, value:  null, options:  null);
            var val_23 = 0;
            val_23 = val_23 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_27).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_25, _span = new System.Span<System.Byte>() {_length = val_25}, _segment = new System.ArraySegment<System.Byte>() {_count = val_25}, _buffered = val_25, _bytesCommitted = val_25, _sequencePool = val_25, _rental = new Rental() {owner = val_25, <Value>k__BackingField = val_25}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_25}, <OldSpec>k__BackingField = val_25}, value:  null, options:  null);
            var val_24 = 0;
            val_24 = val_24 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丂上丐丄丛一一丒七>(resolver:  val_27).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_25, _span = new System.Span<System.Byte>() {_length = val_25}, _segment = new System.ArraySegment<System.Byte>() {_count = val_25}, _buffered = val_25, _bytesCommitted = val_25, _sequencePool = val_25, _rental = new Rental() {owner = val_25, <Value>k__BackingField = val_25}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_25}, <OldSpec>k__BackingField = val_25}, value:  val_24 + 56, options:  val_24 + 56);
            var val_25 = 0;
            val_25 = val_25 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_27).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_25, _span = new System.Span<System.Byte>() {_length = val_25}, _segment = new System.ArraySegment<System.Byte>() {_count = val_25}, _buffered = val_25, _bytesCommitted = val_25, _sequencePool = val_25, _rental = new Rental() {owner = val_25, <Value>k__BackingField = val_25}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_25}, <OldSpec>k__BackingField = val_25}, value:  val_24 + 56, options:  val_24 + 56);
        }
        public PGCompany.StorePromotionPurchaseSettings Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_16;
            Rilisoft.丂上丐丄丛一一丒七 val_17;
            var val_17;
            var val_18;
            PGCompany.丆一丁丏三万丑东不 val_19;
            string val_20;
            Rilisoft.丝丑丂丛万丐丈丘且 val_21;
            val_17 = 0;
            if((1152921541927717824 & 1) != 0)
            {
                    return (PGCompany.StorePromotionPurchaseSettings)val_17;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541927717824 < 1)
            {
                goto label_5;
            }
            
            val_18 = 1152921504957165568;
            val_19 = 0;
            val_20 = 0;
            var val_27 = 0;
            val_21 = 0;
            label_47:
            if(val_27 > 4)
            {
                goto label_46;
            }
            
            var val_21 = -18997524;
            val_21 = val_21 + 106070056;
            goto (-18997524 + 106070056);
            label_46:
            val_27 = val_27 + 1;
            if(val_27 != 1152921541927717824)
            {
                goto label_47;
            }
            
            goto label_48;
            label_5:
            val_21 = 0;
            val_20 = 0;
            val_19 = 0;
            label_48:
            PGCompany.StorePromotionPurchaseSettings val_20 = null;
            val_17 = val_20;
            val_20 = new PGCompany.StorePromotionPurchaseSettings();
            if(val_17 != null)
            {
                    .Type = val_19;
            }
            else
            {
                    mem[16] = val_19;
            }
            
            .Sale = val_21;
            mem[1152921541927758864] = 0;
            val_16 = val_16;
            val_17 = val_17;
            if(val_17 != null)
            {
                    mem[1152921541927758888] = val_16;
                .Profit = val_17;
            }
            else
            {
                    mem[72] = val_16;
                mem[56] = val_17;
            }
            
            .InAppId = val_20;
            return (PGCompany.StorePromotionPurchaseSettings)val_17;
        }
        public 丕丏专丟与世丌丟丂()
        {
        
        }
    
    }

}
