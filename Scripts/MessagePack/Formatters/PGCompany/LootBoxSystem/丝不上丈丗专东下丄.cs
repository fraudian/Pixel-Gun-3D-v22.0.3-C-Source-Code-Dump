using UnityEngine;

namespace MessagePack.Formatters.PGCompany.LootBoxSystem
{
    internal sealed class 丝不上丈丗专东下丄 : IMessagePackFormatter<PGCompany.LootBoxSystem.丏丛且不丏与万一上>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.LootBoxSystem.丏丛且不丏与万一上 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_20;
            var val_21;
            MessagePack.MessagePackWriter val_22;
            bool val_23;
            MessagePack.IFormatterResolver val_24;
            Rilisoft.丝丑丂丛万丐丈丘且 val_25;
            var val_26;
            var val_27;
            var val_28;
            val_20 = 丆与丛丅丂三万一丑;
            val_21 = 丙业与丙丗丝不丈东;
            val_22 = 1152921541940324688;
            val_23 = true;
            if(val_21 != null)
            {
                    val_24 = val_20.Resolver;
                val_25 = 丙业与丙丗丝不丈东.LootRateIndex;
                val_27 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_24);
                var val_18 = 0;
                val_18 = val_18 + 1;
            }
            else
            {
                    val_22 = ???;
                val_20 = ???;
                val_24 = ???;
                val_21 = ???;
                val_26 = ???;
                val_25 = ???;
                val_27 = ???;
                val_23 = val_23 + ((X11) << 4);
                val_28 = val_23 + 296;
            }
            
            val_27.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_19 = 0;
            val_19 = val_19 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_20 = 0;
            val_20 = val_20 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丂上丐丄丛一一丒七>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  val_21 + 40, options:  val_21 + 40);
            var val_21 = 0;
            val_21 = val_21 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  val_21 + 40, options:  val_21 + 40);
        }
        public PGCompany.LootBoxSystem.丏丛且不丏与万一上 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_13;
            Rilisoft.丂上丐丄丛一一丒七 val_14;
            var val_15;
            var val_16;
            string val_17;
            Rilisoft.丝丑丂丛万丐丈丘且 val_18;
            val_15 = 0;
            if((1152921541940530992 & 1) != 0)
            {
                    return (PGCompany.LootBoxSystem.丏丛且不丏与万一上)val_15;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541940530992 < 1)
            {
                goto label_5;
            }
            
            val_16 = 1152921504957165568;
            val_17 = 0;
            var val_23 = 0;
            val_18 = 0;
            label_39:
            if(val_23 > 3)
            {
                goto label_38;
            }
            
            var val_18 = -21405528;
            val_18 = val_18 + 106067704;
            goto (-21405528 + 106067704);
            label_38:
            val_23 = val_23 + 1;
            if(val_23 != 1152921541940530992)
            {
                goto label_39;
            }
            
            goto label_40;
            label_5:
            val_18 = 0;
            val_17 = 0;
            label_40:
            PGCompany.LootBoxSystem.丏丛且不丏与万一上 val_17 = null;
            val_15 = val_17;
            val_17 = new PGCompany.LootBoxSystem.丏丛且不丏与万一上();
            if(val_15 != null)
            {
                    .LootRateIndex = val_18;
                mem[1152921541940567896] = 0;
                .LootGroup = val_17;
                val_13 = val_13;
                val_14 = val_14;
                mem[1152921541940567928] = val_13;
                .Chance = val_14;
            }
            else
            {
                    mem[16] = val_18;
                mem[24] = 0;
                mem[32] = val_17;
                val_13 = val_13;
                val_14 = val_14;
                mem[56] = val_13;
                mem[40] = val_14;
            }
            
            .Rewards = 0;
            return (PGCompany.LootBoxSystem.丏丛且不丏与万一上)val_15;
        }
        public 丝不上丈丗专东下丄()
        {
        
        }
    
    }

}
