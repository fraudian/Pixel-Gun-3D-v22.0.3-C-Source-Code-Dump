using UnityEngine;

namespace MessagePack.Formatters.Rilisoft
{
    public sealed class 不丅万东丏丌专与丈 : IMessagePackFormatter<Rilisoft.GameEventRewardData>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.GameEventRewardData 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_16;
            var val_17;
            MessagePack.MessagePackWriter val_18;
            bool val_19;
            MessagePack.IFormatterResolver val_20;
            Rilisoft.七丕丟丏三丈一丄世 val_21;
            var val_22;
            var val_23;
            val_16 = 丆与丛丅丂三万一丑;
            val_17 = 丙业与丙丗丝不丈东;
            val_18 = 1152921541910010848;
            val_19 = true;
            if(val_17 != null)
            {
                    val_20 = val_16.Resolver;
                val_21 = 丙业与丙丗丝不丈东.GameMode;
                val_22 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.七丕丟丏三丈一丄世>(resolver:  val_20);
                var val_15 = 0;
                val_15 = val_15 + 1;
            }
            else
            {
                    val_18 = ???;
                val_16 = ???;
                val_20 = ???;
                val_17 = ???;
                val_22 = ???;
                val_21 = ???;
                val_19 = val_19 + ((X11) << 4);
                val_23 = val_19 + 296;
            }
            
            val_22.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
            var val_16 = 0;
            val_16 = val_16 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.Int32, System.Int32>>(resolver:  val_20).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
            var val_17 = 0;
            val_17 = val_17 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.Int32, System.String>>(resolver:  val_20).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
        }
        public Rilisoft.GameEventRewardData Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            var val_11;
            Rilisoft.七丕丟丏三丈一丄世 val_12;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_13;
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_14;
            val_11 = 0;
            if((1152921541910213024 & 1) != 0)
            {
                    return (Rilisoft.GameEventRewardData)val_11;
            }
            
            val_10 = 丆与丛丅丂三万一丑.Security;
            val_10.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541910213024 < 1)
            {
                goto label_5;
            }
            
            val_10 = 1152921504957165568;
            val_12 = 0;
            val_13 = 0;
            val_14 = 0;
            var val_17 = 0;
            label_32:
            if(val_17 > 3)
            {
                goto label_31;
            }
            
            var val_13 = -47376220;
            val_13 = val_13 + 106027560;
            goto (-47376220 + 106027560);
            label_31:
            val_17 = val_17 + 1;
            if(val_17 != 1152921541910213024)
            {
                goto label_32;
            }
            
            goto label_33;
            label_5:
            val_14 = 0;
            val_13 = 0;
            val_12 = 0;
            label_33:
            Rilisoft.GameEventRewardData val_12 = null;
            val_11 = val_12;
            val_12 = new Rilisoft.GameEventRewardData();
            if(val_11 != null)
            {
                    .GameMode = val_12;
                .RankRewards = val_13;
                .MinimumPoints = 0;
            }
            else
            {
                    mem[16] = val_12;
                mem[24] = 0;
                mem[32] = val_13;
            }
            
            .RankRewardItems = val_14;
            return (Rilisoft.GameEventRewardData)val_11;
        }
        public 不丅万东丏丌专与丈()
        {
        
        }
    
    }

}
