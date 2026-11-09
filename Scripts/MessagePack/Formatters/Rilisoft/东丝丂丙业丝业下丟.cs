using UnityEngine;

namespace MessagePack.Formatters.Rilisoft
{
    public sealed class 东丝丂丙业丝业下丟 : IMessagePackFormatter<Rilisoft.GameEventData>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.GameEventData 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_27;
            var val_28;
            MessagePack.MessagePackWriter val_29;
            bool val_30;
            MessagePack.IFormatterResolver val_31;
            System.Collections.Generic.List<Rilisoft.GameEventChestData> val_32;
            var val_33;
            var val_34;
            val_27 = 丆与丛丅丂三万一丑;
            val_28 = 丙业与丙丗丝不丈东;
            val_29 = 1152921541905393280;
            val_30 = true;
            if(val_28 != null)
            {
                    val_31 = val_27.Resolver;
                val_32 = 丙业与丙丗丝不丈东.Chests;
                val_33 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<Rilisoft.GameEventChestData>>(resolver:  val_31);
                var val_26 = 0;
                val_26 = val_26 + 1;
            }
            else
            {
                    val_29 = ???;
                val_27 = ???;
                val_31 = ???;
                val_28 = ???;
                val_33 = ???;
                val_32 = ???;
                val_30 = val_30 + ((X11) << 4);
                val_34 = val_30 + 296;
            }
            
            val_33.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            var val_27 = 0;
            val_27 = val_27 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Nullable<System.DateTime>>(resolver:  val_31).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            var val_28 = 0;
            val_28 = val_28 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_31).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            var val_29 = 0;
            val_29 = val_29 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<Rilisoft.GameEventRewardData>>(resolver:  val_31).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            var val_30 = 0;
            val_30 = val_30 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Nullable<System.DateTime>>(resolver:  val_31).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            var val_31 = 0;
            val_31 = val_31 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<Rilisoft.GameCurrencyData>>(resolver:  val_31).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
            var val_32 = 0;
            val_32 = val_32 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<丈丞丕丘丕丗与上一>(resolver:  val_31).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_29, _span = new System.Span<System.Byte>() {_length = val_29}, _segment = new System.ArraySegment<System.Byte>() {_count = val_29}, _buffered = val_29, _bytesCommitted = val_29, _sequencePool = val_29, _rental = new Rental() {owner = val_29, <Value>k__BackingField = val_29}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_29}, <OldSpec>k__BackingField = val_29}, value:  null, options:  null);
        }
        public Rilisoft.GameEventData Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_18;
            System.Collections.Generic.List<Rilisoft.GameEventChestData> val_19;
            string val_20;
            System.Collections.Generic.List<Rilisoft.GameEventRewardData> val_21;
            System.Nullable<System.DateTime> val_22;
            val_18 = 0;
            if((1152921541905628352 & 1) != 0)
            {
                    return (Rilisoft.GameEventData)val_18;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541905628352 < 1)
            {
                goto label_5;
            }
            
            val_19 = 0;
            val_20 = 0;
            val_21 = 0;
            var val_33 = 0;
            val_22 = 0;
            label_66:
            if(val_33 > 9)
            {
                goto label_65;
            }
            
            var val_25 = -47360304;
            val_25 = val_25 + 106027692;
            goto (-47360304 + 106027692);
            label_65:
            val_33 = val_33 + 1;
            if(val_33 != 1152921541905628352)
            {
                goto label_66;
            }
            
            goto label_67;
            label_5:
            val_22 = 0;
            val_21 = 0;
            val_20 = 0;
            val_19 = 0;
            label_67:
            Rilisoft.GameEventData val_24 = null;
            val_18 = val_24;
            val_24 = new Rilisoft.GameEventData();
            if(val_18 != null)
            {
                    .Chests = val_19;
                .EndDate = val_22;
                mem[1152921541905677600] = 0;
                .EventId = val_20;
                .Rewards = val_21;
                .MinimumLevel = 0;
                .StartCurrency = 0;
                .StartDate = 0;
                mem[1152921541905677648] = 0;
                .UniqueId = 0;
                .СurrencyPrices = 0;
            }
            else
            {
                    mem[16] = val_19;
                mem[24] = val_22;
                mem[32] = 0;
                mem[40] = val_20;
                mem[48] = 0;
                mem[56] = val_21;
                mem[64] = 0;
                mem[72] = 0;
                mem[80] = 0;
                .UniqueId = 0;
                mem[96] = 0;
            }
            
            .BloggerReward = 0;
            return (Rilisoft.GameEventData)val_18;
        }
        public 东丝丂丙业丝业下丟()
        {
        
        }
    
    }

}
