using UnityEngine;

namespace MessagePack.Formatters.ExpOpenSystem
{
    internal sealed class 且丗七丕与且上丅七 : IMessagePackFormatter<ExpOpenSystem.丒上丂丑丐不丂丐且>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, ExpOpenSystem.丒上丂丑丐不丂丐且 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_26;
            var val_27;
            MessagePack.MessagePackWriter val_28;
            bool val_29;
            MessagePack.IFormatterResolver val_30;
            var val_31;
            string val_32;
            var val_33;
            var val_34;
            var val_35;
            val_26 = 丆与丛丅丂三万一丑;
            val_27 = 丙业与丙丗丝不丈东;
            val_28 = 1152921541975606816;
            val_29 = true;
            if(val_27 != null)
            {
                    val_30 = val_26.Resolver;
                val_31 = 1152921541903713024;
                val_32 = 丙业与丙丗丝不丈东.Tag;
                val_33 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_30);
                val_34 = 1152921504968347648;
                var val_25 = 0;
                val_25 = val_25 + 1;
            }
            else
            {
                    val_28 = ???;
                val_26 = ???;
                val_30 = ???;
                val_27 = ???;
                val_33 = ???;
                val_32 = ???;
                val_34 = ???;
                val_31 = ???;
                val_29 = val_29 + ((X11) << 4);
                val_35 = val_29 + 296;
            }
            
            val_33.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_28, _span = new System.Span<System.Byte>() {_length = val_28}, _segment = new System.ArraySegment<System.Byte>() {_count = val_28}, _buffered = val_28, _bytesCommitted = val_28, _sequencePool = val_28, _rental = new Rental() {owner = val_28, <Value>k__BackingField = val_28}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_28}, <OldSpec>k__BackingField = val_28}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_30);
            var val_26 = 0;
            val_26 = val_26 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_5 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_30);
            var val_27 = 0;
            val_27 = val_27 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_7 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_30);
            var val_28 = 0;
            val_28 = val_28 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_30);
            var val_29 = 0;
            val_29 = val_29 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_30);
            var val_30 = 0;
            val_30 = val_30 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_13 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_30);
            var val_31 = 0;
            val_31 = val_31 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_13, typeof(), slot: 0);
        }
        public ExpOpenSystem.丒上丂丑丐不丂丐且 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_18;
            string val_19;
            string val_20;
            string val_21;
            string val_22;
            string val_23;
            val_18 = 0;
            if((1152921541975841792 & 1) != 0)
            {
                    return (ExpOpenSystem.丒上丂丑丐不丂丐且)val_18;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541975841792 >= 1)
            {
                    val_19 = 0;
                val_20 = 0;
                val_21 = 0;
                val_22 = 0;
                val_23 = 0;
                var val_32 = 0;
                do
            {
                if(val_32 <= 6)
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_19 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            }
            
                val_32 = val_32 + 1;
            }
            while(val_32 != 1152921541975841792);
            
            }
            else
            {
                    val_23 = 0;
                val_22 = 0;
                val_21 = 0;
                val_20 = 0;
                val_19 = 0;
            }
            
            ExpOpenSystem.丒上丂丑丐不丂丐且 val_24 = null;
            val_18 = val_24;
            val_24 = new ExpOpenSystem.丒上丂丑丐不丂丐且();
            if(val_18 != null)
            {
                    .Tag = val_19;
                .NameKey = val_20;
                .DescriptionKey = val_21;
                .ModeKey = val_22;
                .Icon = val_23;
                .PathTexture = 0;
            }
            else
            {
                    mem[16] = val_19;
                mem[24] = val_20;
                mem[32] = val_21;
                mem[40] = val_22;
                mem[48] = val_23;
                mem[56] = 0;
            }
            
            .BgColor = 0;
            return (ExpOpenSystem.丒上丂丑丐不丂丐且)val_18;
        }
        public 且丗七丕与且上丅七()
        {
        
        }
    
    }

}
