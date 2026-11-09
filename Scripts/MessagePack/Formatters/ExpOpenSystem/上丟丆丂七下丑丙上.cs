using UnityEngine;

namespace MessagePack.Formatters.ExpOpenSystem
{
    public sealed class 上丟丆丂七下丑丙上 : IMessagePackFormatter<ExpOpenSystem.丅一丐丌与丄上三丗>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, ExpOpenSystem.丅一丐丌与丄上三丗 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_17;
            var val_18;
            MessagePack.MessagePackWriter val_19;
            bool val_20;
            MessagePack.IFormatterResolver val_21;
            Rilisoft.丝丑丂丛万丐丈丘且 val_22;
            var val_23;
            var val_24;
            var val_25;
            val_17 = 丆与丛丅丂三万一丑;
            val_18 = 丙业与丙丗丝不丈东;
            val_19 = 1152921541976727840;
            val_20 = true;
            if(val_18 != null)
            {
                    val_21 = val_17.Resolver;
                val_22 = 丙业与丙丗丝不丈东.Progress;
                val_24 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_21);
                var val_16 = 0;
                val_16 = val_16 + 1;
            }
            else
            {
                    val_19 = ???;
                val_17 = ???;
                val_21 = ???;
                val_18 = ???;
                val_23 = ???;
                val_22 = ???;
                val_24 = ???;
                val_20 = val_20 + ((X11) << 4);
                val_25 = val_20 + 296;
            }
            
            val_24.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_19, _span = new System.Span<System.Byte>() {_length = val_19}, _segment = new System.ArraySegment<System.Byte>() {_count = val_19}, _buffered = val_19, _bytesCommitted = val_19, _sequencePool = val_19, _rental = new Rental() {owner = val_19, <Value>k__BackingField = val_19}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_19}, <OldSpec>k__BackingField = val_19}, value:  null, options:  null);
            var val_17 = 0;
            val_17 = val_17 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_21).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_19, _span = new System.Span<System.Byte>() {_length = val_19}, _segment = new System.ArraySegment<System.Byte>() {_count = val_19}, _buffered = val_19, _bytesCommitted = val_19, _sequencePool = val_19, _rental = new Rental() {owner = val_19, <Value>k__BackingField = val_19}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_19}, <OldSpec>k__BackingField = val_19}, value:  null, options:  null);
            var val_18 = 0;
            val_18 = val_18 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_21).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_19, _span = new System.Span<System.Byte>() {_length = val_19}, _segment = new System.ArraySegment<System.Byte>() {_count = val_19}, _buffered = val_19, _bytesCommitted = val_19, _sequencePool = val_19, _rental = new Rental() {owner = val_19, <Value>k__BackingField = val_19}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_19}, <OldSpec>k__BackingField = val_19}, value:  null, options:  null);
        }
        public ExpOpenSystem.丅一丐丌与丄上三丗 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            var val_11;
            string val_12;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_13;
            Rilisoft.丝丑丂丛万丐丈丘且 val_14;
            var val_15;
            val_11 = 0;
            if((1152921541976925920 & 1) != 0)
            {
                    return (ExpOpenSystem.丅一丐丌与丄上三丗)val_11;
            }
            
            val_10 = 丆与丛丅丂三万一丑.Security;
            val_10.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541976925920 < 1)
            {
                goto label_5;
            }
            
            val_12 = 0;
            val_13 = 0;
            var val_17 = 0;
            val_14 = 0;
            val_15 = 0;
            val_10 = 106045700;
            label_32:
            if(val_17 > 3)
            {
                goto label_31;
            }
            
            var val_13 = -35419892;
            val_13 = val_13 + val_10;
            goto (-35419892 + val_10);
            label_31:
            val_17 = val_17 + 1;
            if(val_17 != 1152921541976925920)
            {
                goto label_32;
            }
            
            goto label_33;
            label_5:
            val_15 = 0;
            val_14 = 0;
            val_13 = 0;
            val_12 = 0;
            label_33:
            ExpOpenSystem.丅一丐丌与丄上三丗 val_12 = null;
            val_11 = val_12;
            val_12 = new ExpOpenSystem.丅一丐丌与丄上三丗();
            if(val_11 != null)
            {
                    .Progress = val_14;
                mem[1152921541976958712] = val_15;
                .Tag = val_12;
                .ViewInProgressRoad = false;
            }
            else
            {
                    mem[16] = val_14;
                mem[24] = val_15;
                mem[32] = val_12;
                mem[40] = 0;
            }
            
            .Rewards = val_13;
            return (ExpOpenSystem.丅一丐丌与丄上三丗)val_11;
        }
        public 上丟丆丂七下丑丙上()
        {
        
        }
    
    }

}
