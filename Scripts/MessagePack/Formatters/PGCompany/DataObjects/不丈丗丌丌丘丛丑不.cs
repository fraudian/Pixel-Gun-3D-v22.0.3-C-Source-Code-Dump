using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 不丈丗丌丌丘丛丑不 : IMessagePackFormatter<PGCompany.DataObjects.丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_22;
            var val_23;
            MessagePack.MessagePackWriter val_24;
            bool val_25;
            MessagePack.IFormatterResolver val_26;
            var val_27;
            string val_28;
            var val_29;
            var val_30;
            var val_31;
            val_22 = 丆与丛丅丂三万一丑;
            val_23 = 丙业与丙丗丝不丈东;
            val_24 = 1152921541960914656;
            val_25 = true;
            if(val_23 != null)
            {
                    val_26 = val_22.Resolver;
                val_27 = 1152921541903713024;
                val_28 = 丙业与丙丗丝不丈东.Prefab;
                val_29 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_26);
                val_30 = 1152921504968347648;
                var val_21 = 0;
                val_21 = val_21 + 1;
            }
            else
            {
                    val_24 = ???;
                val_22 = ???;
                val_26 = ???;
                val_23 = ???;
                val_29 = ???;
                val_28 = ???;
                val_30 = ???;
                val_27 = ???;
                val_25 = val_25 + ((X11) << 4);
                val_31 = val_25 + 296;
            }
            
            val_29.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_24, _span = new System.Span<System.Byte>() {_length = val_24}, _segment = new System.ArraySegment<System.Byte>() {_count = val_24}, _buffered = val_24, _bytesCommitted = val_24, _sequencePool = val_24, _rental = new Rental() {owner = val_24, <Value>k__BackingField = val_24}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_24}, <OldSpec>k__BackingField = val_24}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_26);
            var val_22 = 0;
            val_22 = val_22 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_5 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_26);
            var val_23 = 0;
            val_23 = val_23 + 1;
            var val_24 = 0;
            val_24 = val_24 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_26).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_24, _span = new System.Span<System.Byte>() {_length = val_24}, _segment = new System.ArraySegment<System.Byte>() {_count = val_24}, _buffered = val_24, _bytesCommitted = val_24, _sequencePool = val_24, _rental = new Rental() {owner = val_24, <Value>k__BackingField = val_24}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_24}, <OldSpec>k__BackingField = val_24}, value:  null, options:  null);
            var val_25 = 0;
            val_25 = val_25 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(resolver:  val_26).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_24, _span = new System.Span<System.Byte>() {_length = val_24}, _segment = new System.ArraySegment<System.Byte>() {_count = val_24}, _buffered = val_24, _bytesCommitted = val_24, _sequencePool = val_24, _rental = new Rental() {owner = val_24, <Value>k__BackingField = val_24}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_24}, <OldSpec>k__BackingField = val_24}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_14;
            var val_15;
            string val_16;
            string val_17;
            string val_18;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_19;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_20;
            val_15 = 0;
            if((1152921541961133248 & 1) != 0)
            {
                    return (丙丕丈一一丝丑七丈)val_15;
            }
            
            val_14 = 丆与丛丅丂三万一丑.Security;
            val_14.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541961133248 < 1)
            {
                goto label_5;
            }
            
            val_16 = 0;
            val_17 = 0;
            val_18 = 0;
            val_19 = 0;
            val_20 = 0;
            label_48:
            if(0 > 5)
            {
                goto label_47;
            }
            
            var val_19 = -21482896;
            val_19 = val_19 + 106066952;
            goto (-21482896 + 106066952);
            label_47:
            val_14 = 0 + 1;
            if(val_14 != 1152921541961133248)
            {
                goto label_48;
            }
            
            goto label_49;
            label_5:
            val_20 = 0;
            val_19 = 0;
            val_18 = 0;
            val_17 = 0;
            val_16 = 0;
            label_49:
            丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈 val_18 = null;
            val_15 = val_18;
            val_18 = new 丟业专丘七丐丗且丌.丙丕丈一一丝丑七丈();
            if(val_15 != null)
            {
                    .Prefab = val_16;
                .CustomIcon = val_17;
                .NameLocKey = val_18;
                .Rewards = val_19;
                .DayNumber = 0;
            }
            else
            {
                    mem[16] = 0;
                mem[24] = val_16;
                mem[32] = val_17;
                mem[40] = val_18;
                mem[48] = val_19;
            }
            
            .AlternativeRewards = val_20;
            return (丙丕丈一一丝丑七丈)val_15;
        }
        public 不丈丗丌丌丘丛丑不()
        {
        
        }
    
    }

}
