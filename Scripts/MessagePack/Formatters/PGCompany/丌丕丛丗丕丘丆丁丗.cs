using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丌丕丛丗丕丘丆丁丗 : IMessagePackFormatter<PGCompany.丛上丐万下丘丙丘丌>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丛上丐万下丘丙丘丌 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_21;
            var val_22;
            MessagePack.MessagePackWriter val_23;
            bool val_24;
            MessagePack.IFormatterResolver val_25;
            var val_26;
            Rilisoft.丝丑丂丛万丐丈丘且 val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            val_21 = 丆与丛丅丂三万一丑;
            val_22 = 丙业与丙丗丝不丈东;
            val_23 = 1152921541935183120;
            val_24 = true;
            if(val_22 != null)
            {
                    val_25 = val_21.Resolver;
                val_26 = 1152921541903703776;
                val_27 = 丙业与丙丗丝不丈东.Index;
                val_29 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_25);
                val_30 = 1152921504968347648;
                var val_20 = 0;
                val_20 = val_20 + 1;
            }
            else
            {
                    val_22 = ???;
                val_23 = ???;
                val_25 = ???;
                val_21 = ???;
                val_28 = ???;
                val_27 = ???;
                val_26 = ???;
                val_29 = ???;
                val_30 = ???;
                val_24 = val_24 + ((X11) << 4);
                val_31 = val_24 + 296;
            }
            
            val_29.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_23, _span = new System.Span<System.Byte>() {_length = val_23}, _segment = new System.ArraySegment<System.Byte>() {_count = val_23}, _buffered = val_23, _bytesCommitted = val_23, _sequencePool = val_23, _rental = new Rental() {owner = val_23, <Value>k__BackingField = val_23}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_23}, <OldSpec>k__BackingField = val_23}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_25);
            var val_21 = 0;
            val_21 = val_21 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_5 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_25);
            var val_22 = 0;
            val_22 = val_22 + 1;
            var val_23 = 0;
            val_23 = val_23 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.下丄丄丞三且丒下业>>(resolver:  val_25).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_23, _span = new System.Span<System.Byte>() {_length = val_23}, _segment = new System.ArraySegment<System.Byte>() {_count = val_23}, _buffered = val_23, _bytesCommitted = val_23, _sequencePool = val_23, _rental = new Rental() {owner = val_23, <Value>k__BackingField = val_23}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_23}, <OldSpec>k__BackingField = val_23}, value:  null, options:  null);
        }
        public PGCompany.丛上丐万下丘丙丘丌 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_12;
            var val_13;
            Rilisoft.丝丑丂丛万丐丈丘且 val_14;
            val_13 = 0;
            if((1152921541935389392 & 1) != 0)
            {
                    return (PGCompany.丛上丐万下丘丙丘丌)val_13;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541935389392 < 1)
            {
                goto label_5;
            }
            
            var val_21 = 0;
            val_14 = 0;
            val_12 = 0;
            label_40:
            if(val_21 > 5)
            {
                goto label_39;
            }
            
            var val_16 = -19026908;
            val_16 = val_16 + 106069844;
            goto (-19026908 + 106069844);
            label_39:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541935389392)
            {
                goto label_40;
            }
            
            goto label_41;
            label_5:
            val_12 = 0;
            val_14 = 0;
            label_41:
            PGCompany.丛上丐万下丘丙丘丌 val_15 = null;
            val_13 = val_15;
            val_15 = new PGCompany.丛上丐万下丘丙丘丌();
            if(val_13 != null)
            {
                    .Index = val_12;
                mem[1152921541935426296] = 0;
                .StartLimit = val_14;
                mem[1152921541935426312] = 0;
                .Cooldown = 0;
                mem[1152921541935426328] = 0;
                .ConditionItemDatas = 0;
            }
            else
            {
                    mem[16] = val_12;
                mem[24] = 0;
                mem[32] = val_14;
                mem[40] = 0;
                mem[48] = 0;
                mem[56] = 0;
                mem[72] = 0;
            }
            
            bool val_22 = false;
            val_22 = val_22 & 1;
            .SkipCooldownOnBuy = val_22;
            return (PGCompany.丛上丐万下丘丙丘丌)val_13;
        }
        public 丌丕丛丗丕丘丆丁丗()
        {
        
        }
    
    }

}
