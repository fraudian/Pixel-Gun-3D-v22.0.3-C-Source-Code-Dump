using UnityEngine;

namespace MessagePack.Formatters.Rilisoft
{
    public sealed class 三上丏万一不与三与 : IMessagePackFormatter<Rilisoft.GameEventItemContainerData>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.GameEventItemContainerData 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_18;
            var val_19;
            MessagePack.MessagePackWriter val_20;
            bool val_21;
            MessagePack.IFormatterResolver val_22;
            Rilisoft.GameEventItemContainerContentType val_23;
            var val_24;
            var val_25;
            val_18 = 丆与丛丅丂三万一丑;
            val_19 = 丙业与丙丗丝不丈东;
            val_20 = 1152921541908978160;
            val_21 = true;
            if(val_19 != null)
            {
                    val_22 = val_18.Resolver;
                val_23 = 丙业与丙丗丝不丈东.ContentType;
                val_24 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.GameEventItemContainerContentType>(resolver:  val_22);
                var val_17 = 0;
                val_17 = val_17 + 1;
            }
            else
            {
                    val_20 = ???;
                val_18 = ???;
                val_22 = ???;
                val_19 = ???;
                val_24 = ???;
                val_23 = ???;
                val_21 = val_21 + ((X11) << 4);
                val_25 = val_21 + 296;
            }
            
            val_24.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_20, _span = new System.Span<System.Byte>() {_length = val_20}, _segment = new System.ArraySegment<System.Byte>() {_count = val_20}, _buffered = val_20, _bytesCommitted = val_20, _sequencePool = val_20, _rental = new Rental() {owner = val_20, <Value>k__BackingField = val_20}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_20}, <OldSpec>k__BackingField = val_20}, value:  null, options:  null);
            var val_18 = 0;
            val_18 = val_18 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丒丙丂丛丙且且不丕>(resolver:  val_22).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_20, _span = new System.Span<System.Byte>() {_length = val_20}, _segment = new System.ArraySegment<System.Byte>() {_count = val_20}, _buffered = val_20, _bytesCommitted = val_20, _sequencePool = val_20, _rental = new Rental() {owner = val_20, <Value>k__BackingField = val_20}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_20}, <OldSpec>k__BackingField = val_20}, value:  null, options:  null);
            var val_19 = 0;
            val_19 = val_19 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.GameEventContainerDropType>(resolver:  val_22).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_20, _span = new System.Span<System.Byte>() {_length = val_20}, _segment = new System.ArraySegment<System.Byte>() {_count = val_20}, _buffered = val_20, _bytesCommitted = val_20, _sequencePool = val_20, _rental = new Rental() {owner = val_20, <Value>k__BackingField = val_20}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_20}, <OldSpec>k__BackingField = val_20}, value:  null, options:  null);
            var val_20 = 0;
            val_20 = val_20 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<Rilisoft.GameEventItemData>>(resolver:  val_22).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_20, _span = new System.Span<System.Byte>() {_length = val_20}, _segment = new System.ArraySegment<System.Byte>() {_count = val_20}, _buffered = val_20, _bytesCommitted = val_20, _sequencePool = val_20, _rental = new Rental() {owner = val_20, <Value>k__BackingField = val_20}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_20}, <OldSpec>k__BackingField = val_20}, value:  null, options:  null);
        }
        public Rilisoft.GameEventItemContainerData Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            var val_13;
            Rilisoft.GameEventItemContainerContentType val_14;
            Rilisoft.丒丙丂丛丙且且不丕 val_15;
            Rilisoft.GameEventContainerDropType val_16;
            System.Collections.Generic.List<Rilisoft.GameEventItemData> val_17;
            float val_18;
            val_13 = 0;
            if((1152921541909188560 & 1) != 0)
            {
                    return (Rilisoft.GameEventItemContainerData)val_13;
            }
            
            val_12 = 丆与丛丅丂三万一丑.Security;
            val_12.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541909188560 < 1)
            {
                goto label_5;
            }
            
            val_14 = 0;
            val_15 = 0;
            val_16 = 0;
            val_17 = 0;
            var val_21 = 0;
            val_18 = 0f;
            val_12 = 106070456;
            label_41:
            if(val_21 > 5)
            {
                goto label_40;
            }
            
            var val_16 = -18944140;
            val_16 = val_16 + val_12;
            goto (-18944140 + val_12);
            label_40:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541909188560)
            {
                goto label_41;
            }
            
            goto label_42;
            label_5:
            val_17 = 0;
            val_16 = 0;
            val_15 = 0;
            val_14 = 0;
            val_18 = 0f;
            label_42:
            Rilisoft.GameEventItemContainerData val_15 = null;
            val_13 = val_15;
            val_15 = new Rilisoft.GameEventItemContainerData();
            if(val_13 != null)
            {
                    .DropCategory = val_15;
                .DropChance = val_18;
                .DropType = val_16;
                .ContainerId = 0;
                .ContentType = val_14;
            }
            else
            {
                    mem[16] = 0;
                .ContentType = val_14;
                mem[24] = val_15;
                .DropChance = val_18;
                mem[32] = val_16;
            }
            
            .Items = val_17;
            return (Rilisoft.GameEventItemContainerData)val_13;
        }
        public 三上丏万一不与三与()
        {
        
        }
    
    }

}
