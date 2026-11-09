using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丞丘丈丙丅丛丛七丑 : IMessagePackFormatter<PGCompany.DataObjects.万丞丘丏丆丆丝与与.丅丒不上七丘万丙一>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.万丞丘丏丆丆丝与与.丅丒不上七丘万丙一 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_22;
            var val_23;
            MessagePack.MessagePackWriter val_24;
            bool val_25;
            MessagePack.IFormatterResolver val_26;
            System.Nullable<System.Boolean> val_27;
            var val_28;
            var val_29;
            val_22 = 丆与丛丅丂三万一丑;
            val_23 = 丙业与丙丗丝不丈东;
            val_24 = 1152921541947965952;
            val_25 = true;
            if(val_23 != null)
            {
                    val_26 = val_22.Resolver;
                val_27 = 丙业与丙丗丝不丈东.enabled;
                val_28 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Nullable<System.Boolean>>(resolver:  val_26);
                var val_21 = 0;
                val_21 = val_21 + 1;
            }
            else
            {
                    val_24 = ???;
                val_22 = ???;
                val_26 = ???;
                val_23 = ???;
                val_28 = ???;
                val_27 = ???;
                val_25 = val_25 + ((X11) << 4);
                val_29 = val_25 + 296;
            }
            
            val_28.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_24, _span = new System.Span<System.Byte>() {_length = val_24}, _segment = new System.ArraySegment<System.Byte>() {_count = val_24}, _buffered = val_24, _bytesCommitted = val_24, _sequencePool = val_24, _rental = new Rental() {owner = val_24, <Value>k__BackingField = val_24}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_24}, <OldSpec>k__BackingField = val_24}, value:  null, options:  null);
            var val_22 = 0;
            val_22 = val_22 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<System.String>>(resolver:  val_26).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_24, _span = new System.Span<System.Byte>() {_length = val_24}, _segment = new System.ArraySegment<System.Byte>() {_count = val_24}, _buffered = val_24, _bytesCommitted = val_24, _sequencePool = val_24, _rental = new Rental() {owner = val_24, <Value>k__BackingField = val_24}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_24}, <OldSpec>k__BackingField = val_24}, value:  null, options:  null);
            var val_23 = 0;
            val_23 = val_23 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Nullable<System.Single>>(resolver:  val_26).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_24, _span = new System.Span<System.Byte>() {_length = val_24}, _segment = new System.ArraySegment<System.Byte>() {_count = val_24}, _buffered = val_24, _bytesCommitted = val_24, _sequencePool = val_24, _rental = new Rental() {owner = val_24, <Value>k__BackingField = val_24}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_24}, <OldSpec>k__BackingField = val_24}, value:  null, options:  null);
            var val_24 = 0;
            val_24 = val_24 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Nullable<System.Single>>(resolver:  val_26).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_24, _span = new System.Span<System.Byte>() {_length = val_24}, _segment = new System.ArraySegment<System.Byte>() {_count = val_24}, _buffered = val_24, _bytesCommitted = val_24, _sequencePool = val_24, _rental = new Rental() {owner = val_24, <Value>k__BackingField = val_24}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_24}, <OldSpec>k__BackingField = val_24}, value:  null, options:  null);
            var val_25 = 0;
            val_25 = val_25 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.String, 丅丒不上七丘万丙一>>(resolver:  val_26).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_24, _span = new System.Span<System.Byte>() {_length = val_24}, _segment = new System.ArraySegment<System.Byte>() {_count = val_24}, _buffered = val_24, _bytesCommitted = val_24, _sequencePool = val_24, _rental = new Rental() {owner = val_24, <Value>k__BackingField = val_24}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_24}, <OldSpec>k__BackingField = val_24}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.万丞丘丏丆丆丝与与.丅丒不上七丘万丙一 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_14;
            System.Collections.Generic.List<System.String> val_15;
            System.Collections.Generic.Dictionary<System.String, 丅丒不上七丘万丙一> val_16;
            System.Nullable<System.Single> val_17;
            System.Nullable<System.Single> val_18;
            System.Nullable<System.Boolean> val_19;
            val_14 = 0;
            if((1152921541948180480 & 1) != 0)
            {
                    return (丅丒不上七丘万丙一)val_14;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541948180480 >= 1)
            {
                    val_15 = 0;
                val_16 = 0;
                var val_24 = 0;
                val_17 = 0;
                val_18 = 0;
                val_19 = 0;
                do
            {
                if(val_24 <= 4)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_19 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Nullable<System.Boolean>>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            }
            
                val_24 = val_24 + 1;
            }
            while(val_24 != 1152921541948180480);
            
            }
            else
            {
                    val_19 = 0;
                val_18 = 0;
                val_17 = 0;
                val_16 = 0;
                val_15 = 0;
            }
            
            万丞丘丏丆丆丝与与.丅丒不上七丘万丙一 val_18 = null;
            val_14 = val_18;
            val_18 = new 万丞丘丏丆丆丝与与.丅丒不上七丘万丙一();
            if(val_14 != null)
            {
                    .enabled = val_19;
                .disableDevices = val_15;
                .timeoutWaitSeconds = val_18;
                .delayBetweenSeriesInHours = val_17;
            }
            else
            {
                    mem[16] = val_19;
                mem[24] = val_15;
                mem[32] = val_18;
                mem[40] = val_17;
            }
            
            .overrides = val_16;
            return (丅丒不上七丘万丙一)val_14;
        }
        public 丞丘丈丙丅丛丛七丑()
        {
        
        }
    
    }

}
