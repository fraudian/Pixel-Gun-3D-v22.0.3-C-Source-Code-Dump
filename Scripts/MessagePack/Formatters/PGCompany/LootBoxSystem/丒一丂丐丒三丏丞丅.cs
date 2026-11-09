using UnityEngine;

namespace MessagePack.Formatters.PGCompany.LootBoxSystem
{
    internal sealed class 丒一丂丐丒三丏丞丅 : IMessagePackFormatter<PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_21;
            var val_22;
            MessagePack.MessagePackWriter val_23;
            bool val_24;
            MessagePack.IFormatterResolver val_25;
            string val_26;
            var val_27;
            var val_28;
            val_21 = 丆与丛丅丂三万一丑;
            val_22 = 丙业与丙丗丝不丈东;
            val_23 = 1152921541938132816;
            val_24 = true;
            if(val_22 != null)
            {
                    val_25 = val_21.Resolver;
                val_26 = 丙业与丙丗丝不丈东.RateId;
                val_27 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_25);
                var val_20 = 0;
                val_20 = val_20 + 1;
            }
            else
            {
                    val_23 = ???;
                val_21 = ???;
                val_25 = ???;
                val_22 = ???;
                val_27 = ???;
                val_26 = ???;
                val_24 = val_24 + ((X11) << 4);
                val_28 = val_24 + 296;
            }
            
            val_27.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_23, _span = new System.Span<System.Byte>() {_length = val_23}, _segment = new System.ArraySegment<System.Byte>() {_count = val_23}, _buffered = val_23, _bytesCommitted = val_23, _sequencePool = val_23, _rental = new Rental() {owner = val_23, <Value>k__BackingField = val_23}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_23}, <OldSpec>k__BackingField = val_23}, value:  null, options:  null);
            var val_21 = 0;
            val_21 = val_21 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_25).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_23, _span = new System.Span<System.Byte>() {_length = val_23}, _segment = new System.ArraySegment<System.Byte>() {_count = val_23}, _buffered = val_23, _bytesCommitted = val_23, _sequencePool = val_23, _rental = new Rental() {owner = val_23, <Value>k__BackingField = val_23}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_23}, <OldSpec>k__BackingField = val_23}, value:  null, options:  null);
            var val_22 = 0;
            val_22 = val_22 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.Common.丗七业丏东且丟丕一>(resolver:  val_25).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_23, _span = new System.Span<System.Byte>() {_length = val_23}, _segment = new System.ArraySegment<System.Byte>() {_count = val_23}, _buffered = val_23, _bytesCommitted = val_23, _sequencePool = val_23, _rental = new Rental() {owner = val_23, <Value>k__BackingField = val_23}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_23}, <OldSpec>k__BackingField = val_23}, value:  null, options:  null);
            var val_23 = 0;
            val_23 = val_23 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_25).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_23, _span = new System.Span<System.Byte>() {_length = val_23}, _segment = new System.ArraySegment<System.Byte>() {_count = val_23}, _buffered = val_23, _bytesCommitted = val_23, _sequencePool = val_23, _rental = new Rental() {owner = val_23, <Value>k__BackingField = val_23}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_23}, <OldSpec>k__BackingField = val_23}, value:  null, options:  null);
        }
        public PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            string val_13;
            PGCompany.Common.丗七业丏东且丟丕一 val_14;
            Rilisoft.丝丑丂丛万丐丈丘且 val_15;
            Rilisoft.丝丑丂丛万丐丈丘且 val_16;
            val_12 = 0;
            if((1152921541938343216 & 1) != 0)
            {
                    return (PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七)val_12;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541938343216 < 1)
            {
                goto label_5;
            }
            
            val_13 = 0;
            val_14 = 0;
            var val_21 = 0;
            val_15 = 0;
            val_16 = 0;
            label_39:
            if(val_21 > 3)
            {
                goto label_38;
            }
            
            var val_16 = -21407712;
            val_16 = val_16 + 106067688;
            goto (-21407712 + 106067688);
            label_38:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541938343216)
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
            PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七 val_15 = null;
            val_12 = val_15;
            val_15 = new PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七();
            if(val_12 != null)
            {
                    .RateId = val_13;
                .AttributeIndex = val_16;
                .Type = val_14;
                mem[1152921541938380128] = 0;
            }
            else
            {
                    mem[16] = val_13;
                mem[24] = val_16;
                mem[32] = 0;
                mem[40] = val_14;
            }
            
            .Value = val_15;
            mem[1152921541938380152] = 0;
            return (PGCompany.LootBoxSystem.丏丒丅丏丝丘丏与七)val_12;
        }
        public 丒一丂丐丒三丏丞丅()
        {
        
        }
    
    }

}
