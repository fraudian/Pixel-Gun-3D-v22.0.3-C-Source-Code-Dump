using UnityEngine;

namespace MessagePack.Formatters.ExpOpenSystem
{
    public sealed class 七丛丟丟下丕下丒丁 : IMessagePackFormatter<ExpOpenSystem.一丘不丘丄万丂丈丝>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, ExpOpenSystem.一丘不丘丄万丂丈丝 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_25;
            var val_26;
            MessagePack.MessagePackWriter val_27;
            bool val_28;
            MessagePack.IFormatterResolver val_29;
            var val_30;
            Rilisoft.丝丑丂丛万丐丈丘且 val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            val_25 = 丆与丛丅丂三万一丑;
            val_26 = 丙业与丙丗丝不丈东;
            val_27 = 1152921541976182688;
            val_28 = true;
            if(val_26 != null)
            {
                    val_29 = val_25.Resolver;
                val_30 = 1152921541903703776;
                val_31 = 丙业与丙丗丝不丈东.Id;
                val_33 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_29);
                val_34 = 1152921504968347648;
                var val_24 = 0;
                val_24 = val_24 + 1;
            }
            else
            {
                    val_27 = ???;
                val_25 = ???;
                val_29 = ???;
                val_26 = ???;
                val_32 = ???;
                val_31 = ???;
                val_30 = ???;
                val_33 = ???;
                val_34 = ???;
                val_28 = val_28 + ((X11) << 4);
                val_35 = val_28 + 296;
            }
            
            val_33.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_27, _span = new System.Span<System.Byte>() {_length = val_27}, _segment = new System.ArraySegment<System.Byte>() {_count = val_27}, _buffered = val_27, _bytesCommitted = val_27, _sequencePool = val_27, _rental = new Rental() {owner = val_27, <Value>k__BackingField = val_27}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_27}, <OldSpec>k__BackingField = val_27}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_29);
            var val_25 = 0;
            val_25 = val_25 + 1;
            var val_26 = 0;
            val_26 = val_26 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_29).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_27, _span = new System.Span<System.Byte>() {_length = val_27}, _segment = new System.ArraySegment<System.Byte>() {_count = val_27}, _buffered = val_27, _bytesCommitted = val_27, _sequencePool = val_27, _rental = new Rental() {owner = val_27, <Value>k__BackingField = val_27}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_27}, <OldSpec>k__BackingField = val_27}, value:  null, options:  null);
            var val_27 = 0;
            val_27 = val_27 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<ExpOpenSystem.丅一丐丌与丄上三丗>>(resolver:  val_29).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_27, _span = new System.Span<System.Byte>() {_length = val_27}, _segment = new System.ArraySegment<System.Byte>() {_count = val_27}, _buffered = val_27, _bytesCommitted = val_27, _sequencePool = val_27, _rental = new Rental() {owner = val_27, <Value>k__BackingField = val_27}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_27}, <OldSpec>k__BackingField = val_27}, value:  null, options:  null);
            var val_28 = 0;
            val_28 = val_28 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>>(resolver:  val_29).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_27, _span = new System.Span<System.Byte>() {_length = val_27}, _segment = new System.ArraySegment<System.Byte>() {_count = val_27}, _buffered = val_27, _bytesCommitted = val_27, _sequencePool = val_27, _rental = new Rental() {owner = val_27, <Value>k__BackingField = val_27}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_27}, <OldSpec>k__BackingField = val_27}, value:  null, options:  null);
            var val_29 = 0;
            val_29 = val_29 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.String, ExpOpenSystem.丒上丂丑丐不丂丐且>>(resolver:  val_29).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_27, _span = new System.Span<System.Byte>() {_length = val_27}, _segment = new System.ArraySegment<System.Byte>() {_count = val_27}, _buffered = val_27, _bytesCommitted = val_27, _sequencePool = val_27, _rental = new Rental() {owner = val_27, <Value>k__BackingField = val_27}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_27}, <OldSpec>k__BackingField = val_27}, value:  null, options:  null);
        }
        public ExpOpenSystem.一丘不丘丄万丂丈丝 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_16;
            var val_17;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_18;
            Rilisoft.丝丑丂丛万丐丈丘且 val_19;
            val_17 = 0;
            if((1152921541976405424 & 1) != 0)
            {
                    return (ExpOpenSystem.一丘不丘丄万丂丈丝)val_17;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541976405424 < 1)
            {
                goto label_5;
            }
            
            val_18 = 0;
            var val_29 = 0;
            val_16 = 0;
            val_19 = 0;
            label_56:
            if(val_29 > 6)
            {
                goto label_53;
            }
            
            var val_22 = -35422280;
            val_22 = val_22 + 106045672;
            goto (-35422280 + 106045672);
            label_53:
            val_29 = val_29 + 1;
            if(val_29 != 1152921541976405424)
            {
                goto label_56;
            }
            
            goto label_57;
            label_5:
            val_19 = 0;
            val_16 = 0;
            val_18 = 0;
            label_57:
            ExpOpenSystem.一丘不丘丄万丂丈丝 val_21 = null;
            val_17 = val_21;
            val_21 = new ExpOpenSystem.一丘不丘丄万丂丈丝();
            if(val_17 != null)
            {
                    .Id = val_19;
                mem[1152921541976450552] = 0;
                .MaxLevelRewardExp = val_16;
                mem[1152921541976450568] = 0;
                .SpecialRewards = val_18;
                .IsEnable = false;
                .ExpOpenSettings = 0;
                .MigrationSettings = 0;
            }
            else
            {
                    mem[16] = val_19;
                mem[24] = 0;
                mem[32] = val_16;
                mem[40] = 0;
                mem[48] = val_18;
                mem[56] = 0;
                mem[64] = 0;
                mem[72] = 0;
            }
            
            .ContentSettings = 0;
            return (ExpOpenSystem.一丘不丘丄万丂丈丝)val_17;
        }
        public 七丛丟丟下丕下丒丁()
        {
        
        }
    
    }

}
