using UnityEngine;

namespace MessagePack.Formatters.PGCompany.LootBoxSystem
{
    internal sealed class 七万丙东丑上丘业丏 : IMessagePackFormatter<PGCompany.LootBoxSystem.丅且丕丌丞丟且丈丒>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.LootBoxSystem.丅且丕丌丞丟且丈丒 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_20;
            var val_21;
            MessagePack.MessagePackWriter val_22;
            bool val_23;
            MessagePack.IFormatterResolver val_24;
            System.Collections.Generic.List<PGCompany.LootBoxSystem.东丆一丞丛不与与丐> val_25;
            var val_26;
            var val_27;
            val_20 = 丆与丛丅丂三万一丑;
            val_21 = 丙业与丙丗丝不丈东;
            val_22 = 1152921541939783648;
            val_23 = true;
            if(val_21 != null)
            {
                    val_24 = val_20.Resolver;
                val_25 = 丙业与丙丗丝不丈东.LootBoxDatas;
                val_26 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.LootBoxSystem.东丆一丞丛不与与丐>>(resolver:  val_24);
                var val_19 = 0;
                val_19 = val_19 + 1;
            }
            else
            {
                    val_22 = ???;
                val_20 = ???;
                val_24 = ???;
                val_21 = ???;
                val_26 = ???;
                val_25 = ???;
                val_23 = val_23 + ((X11) << 4);
                val_27 = val_23 + 296;
            }
            
            val_26.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_20 = 0;
            val_20 = val_20 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_21 = 0;
            val_21 = val_21 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_22 = 0;
            val_22 = val_22 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_23 = 0;
            val_23 = val_23 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.LootBoxSystem.一丏丙丒世丅丞下东>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
        }
        public PGCompany.LootBoxSystem.丅且丕丌丞丟且丈丒 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_14;
            System.Collections.Generic.List<PGCompany.LootBoxSystem.东丆一丞丛不与与丐> val_15;
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丛东丟丕丌丄丝丑丒> val_16;
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丛且不丏与万一上> val_17;
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七> val_18;
            System.Collections.Generic.List<PGCompany.LootBoxSystem.一丏丙丒世丅丞下东> val_19;
            val_14 = 0;
            if((1152921541940002272 & 1) != 0)
            {
                    return (PGCompany.LootBoxSystem.丅且丕丌丞丟且丈丒)val_14;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541940002272 >= 1)
            {
                    val_15 = 0;
                val_16 = 0;
                val_17 = 0;
                val_18 = 0;
                val_19 = 0;
                var val_24 = 0;
                do
            {
                if(val_24 <= 4)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_15 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.LootBoxSystem.东丆一丞丛不与与丐>>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            }
            
                val_24 = val_24 + 1;
            }
            while(val_24 != 1152921541940002272);
            
            }
            else
            {
                    val_19 = 0;
                val_18 = 0;
                val_17 = 0;
                val_16 = 0;
                val_15 = 0;
            }
            
            PGCompany.LootBoxSystem.丅且丕丌丞丟且丈丒 val_18 = null;
            val_14 = val_18;
            val_18 = new PGCompany.LootBoxSystem.丅且丕丌丞丟且丈丒();
            if(val_14 != null)
            {
                    .LootBoxDatas = val_15;
                .LootBoxRateDatas = val_16;
                .LootBoxItemDatas = val_17;
                .LootBoxAttrFilter = val_18;
            }
            else
            {
                    mem[16] = val_15;
                mem[24] = val_16;
                mem[32] = val_17;
                mem[40] = val_18;
            }
            
            .LootBoxAttrModifier = val_19;
            return (PGCompany.LootBoxSystem.丅且丕丌丞丟且丈丒)val_14;
        }
        public 七万丙东丑上丘业丏()
        {
        
        }
    
    }

}
