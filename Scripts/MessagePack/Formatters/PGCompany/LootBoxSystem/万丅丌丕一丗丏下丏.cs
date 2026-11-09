using UnityEngine;

namespace MessagePack.Formatters.PGCompany.LootBoxSystem
{
    internal sealed class 万丅丌丕一丗丏下丏 : IMessagePackFormatter<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_24;
            var val_25;
            MessagePack.MessagePackWriter val_26;
            bool val_27;
            MessagePack.IFormatterResolver val_28;
            string val_29;
            var val_30;
            var val_31;
            val_24 = 丆与丛丅丂三万一丑;
            val_25 = 丙业与丙丗丝不丈东;
            val_26 = 1152921541941283552;
            val_27 = true;
            if(val_25 != null)
            {
                    val_28 = val_24.Resolver;
                val_29 = 丙业与丙丗丝不丈东.Id;
                val_30 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_28);
                var val_22 = 0;
                val_22 = val_22 + 1;
            }
            else
            {
                    val_26 = ???;
                val_24 = ???;
                val_28 = ???;
                val_25 = ???;
                val_30 = ???;
                val_29 = ???;
                val_27 = val_27 + ((X11) << 4);
                val_31 = val_27 + 296;
            }
            
            val_30.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  null, options:  null);
            var val_23 = 0;
            val_23 = val_23 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_28).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  null, options:  null);
            var val_24 = 0;
            val_24 = val_24 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_28).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  null, options:  null);
            var val_25 = 0;
            val_25 = val_25 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_28).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  null, options:  null);
            var val_26 = 0;
            val_26 = val_26 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丂上丐丄丛一一丒七>(resolver:  val_28).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  val_25 + 72, options:  val_25 + 72);
        }
        public PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_18;
            Rilisoft.丂上丐丄丛一一丒七 val_19;
            var val_17;
            string val_18;
            Rilisoft.丝丑丂丛万丐丈丘且 val_19;
            val_17 = 0;
            if((1152921541941502176 & 1) != 0)
            {
                    return (PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒)val_17;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541941502176 < 1)
            {
                goto label_5;
            }
            
            val_18 = 0;
            var val_27 = 0;
            val_19 = 0;
            label_47:
            if(val_27 > 4)
            {
                goto label_46;
            }
            
            var val_21 = -21415452;
            val_21 = val_21 + 106067612;
            goto (-21415452 + 106067612);
            label_46:
            val_27 = val_27 + 1;
            if(val_27 != 1152921541941502176)
            {
                goto label_47;
            }
            
            goto label_48;
            label_5:
            val_19 = 0;
            val_18 = 0;
            label_48:
            PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒 val_20 = null;
            val_17 = val_20;
            val_20 = new PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒();
            if(val_17 != null)
            {
                    .Id = val_18;
                .LootBoxIndex = val_19;
                mem[1152921541941543200] = 0;
                .LootRateIndex = 0;
                mem[1152921541941543216] = 0;
            }
            else
            {
                    mem[16] = val_18;
                mem[24] = val_19;
                mem[32] = 0;
                mem[40] = 0;
                mem[48] = 0;
            }
            
            .Count = 0;
            mem[1152921541941543232] = 0;
            val_18 = val_18;
            val_19 = val_19;
            mem[1152921541941543256] = val_18;
            .Chance = val_19;
            return (PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒)val_17;
        }
        public 万丅丌丕一丗丏下丏()
        {
        
        }
    
    }

}
