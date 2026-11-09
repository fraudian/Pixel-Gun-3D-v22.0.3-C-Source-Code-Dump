using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 不丗丙上丅丑丑丛丞 : IMessagePackFormatter<PGCompany.DataObjects.上业万丝丟丕专丝万>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.上业万丝丟丕专丝万 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_24;
            var val_25;
            MessagePack.MessagePackWriter val_26;
            bool val_27;
            MessagePack.IFormatterResolver val_28;
            var val_29;
            System.Collections.Generic.List<System.Int32> val_30;
            var val_31;
            var val_32;
            var val_33;
            val_24 = 丆与丛丅丂三万一丑;
            val_25 = 丙业与丙丗丝不丈东;
            val_26 = 1152921541950588736;
            val_27 = true;
            if(val_25 != null)
            {
                    val_28 = val_24.Resolver;
                val_29 = 1152921541903694544;
                val_30 = 丙业与丙丗丝不丈东.ArmoryTimeItems;
                val_31 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<System.Int32>>(resolver:  val_28);
                val_32 = 1152921504968347648;
                var val_23 = 0;
                val_23 = val_23 + 1;
            }
            else
            {
                    val_26 = ???;
                val_24 = ???;
                val_28 = ???;
                val_25 = ???;
                val_31 = ???;
                val_30 = ???;
                val_32 = ???;
                val_29 = ???;
                val_27 = val_27 + ((X11) << 4);
                val_33 = val_27 + 296;
            }
            
            val_31.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_26, _span = new System.Span<System.Byte>() {_length = val_26}, _segment = new System.ArraySegment<System.Byte>() {_count = val_26}, _buffered = val_26, _bytesCommitted = val_26, _sequencePool = val_26, _rental = new Rental() {owner = val_26, <Value>k__BackingField = val_26}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_26}, <OldSpec>k__BackingField = val_26}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_28);
            var val_24 = 0;
            val_24 = val_24 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_5 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_28);
            var val_25 = 0;
            val_25 = val_25 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_7 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_28);
            var val_26 = 0;
            val_26 = val_26 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_28);
            var val_27 = 0;
            val_27 = val_27 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_28);
            var val_28 = 0;
            val_28 = val_28 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_11, typeof(), slot: 0);
        }
        public PGCompany.DataObjects.上业万丝丟丕专丝万 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_16;
            System.Collections.Generic.List<System.Int32> val_17;
            System.Collections.Generic.List<System.Int32> val_18;
            System.Collections.Generic.List<System.Int32> val_19;
            System.Collections.Generic.List<System.Int32> val_20;
            System.Collections.Generic.List<System.Int32> val_21;
            System.Collections.Generic.List<System.Int32> val_22;
            val_16 = 0;
            if((1152921541950815504 & 1) != 0)
            {
                    return (PGCompany.DataObjects.上业万丝丟丕专丝万)val_16;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541950815504 >= 1)
            {
                    val_17 = 0;
                val_18 = 0;
                val_19 = 0;
                val_20 = 0;
                val_21 = 0;
                val_22 = 0;
                var val_28 = 0;
                do
            {
                if(val_28 <= 5)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_17 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<System.Int32>>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            }
            
                val_28 = val_28 + 1;
            }
            while(val_28 != 1152921541950815504);
            
            }
            else
            {
                    val_22 = 0;
                val_21 = 0;
                val_20 = 0;
                val_19 = 0;
                val_18 = 0;
                val_17 = 0;
            }
            
            PGCompany.DataObjects.上业万丝丟丕专丝万 val_21 = null;
            val_16 = val_21;
            val_21 = new PGCompany.DataObjects.上业万丝丟丕专丝万();
            if(val_16 != null)
            {
                    .ArmoryTimeItems = val_17;
                .GatchaItems = val_18;
                .EventChestsItems = val_19;
                .RouletteItems = val_20;
                .BattlePassItems = val_21;
            }
            else
            {
                    mem[16] = val_17;
                mem[24] = val_18;
                mem[32] = val_19;
                mem[40] = val_20;
                mem[48] = val_21;
            }
            
            .ContestItems = val_22;
            return (PGCompany.DataObjects.上业万丝丟丕专丝万)val_16;
        }
        public 不丗丙上丅丑丑丛丞()
        {
        
        }
    
    }

}
