using UnityEngine;

namespace MessagePack.Formatters.Rilisoft
{
    internal sealed class 丘三丌丏丂丒丈七丞 : IMessagePackFormatter<Rilisoft.GameEventDropChanceData.丈七一上丒业丗专丈>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.GameEventDropChanceData.丈七一上丒业丗专丈 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_17;
            var val_18;
            MessagePack.MessagePackWriter val_19;
            bool val_20;
            MessagePack.IFormatterResolver val_21;
            var val_22;
            Rilisoft.丝丑丂丛万丐丈丘且 val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_17 = 丆与丛丅丂三万一丑;
            val_18 = 丙业与丙丗丝不丈东;
            val_19 = 1152921541907436256;
            val_20 = true;
            if(val_18 != null)
            {
                    val_21 = val_17.Resolver;
                val_22 = 1152921541903703776;
                val_23 = 丙业与丙丗丝不丈东._inapp;
                val_25 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_21);
                val_26 = 1152921504968347648;
                var val_16 = 0;
                val_16 = val_16 + 1;
            }
            else
            {
                    val_19 = ???;
                val_17 = ???;
                val_21 = ???;
                val_18 = ???;
                val_24 = ???;
                val_23 = ???;
                val_22 = ???;
                val_25 = ???;
                val_26 = ???;
                val_20 = val_20 + ((X11) << 4);
                val_27 = val_20 + 296;
            }
            
            val_25.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_19, _span = new System.Span<System.Byte>() {_length = val_19}, _segment = new System.ArraySegment<System.Byte>() {_count = val_19}, _buffered = val_19, _bytesCommitted = val_19, _sequencePool = val_19, _rental = new Rental() {owner = val_19, <Value>k__BackingField = val_19}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_19}, <OldSpec>k__BackingField = val_19}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_21);
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_3, typeof(), slot: 0);
        }
        public Rilisoft.GameEventDropChanceData.丈七一上丒业丗专丈 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_8;
            Rilisoft.丝丑丂丛万丐丈丘且 val_9;
            var val_10;
            Rilisoft.丝丑丂丛万丐丈丘且 val_11;
            var val_12;
            val_8 = 0;
            if((1152921541907626096 & 1) != 0)
            {
                    return (丈七一上丒业丗专丈)val_8;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541907626096 < 1)
            {
                goto label_5;
            }
            
            var val_12 = 0;
            val_9 = 0;
            val_10 = 0;
            val_11 = 0;
            val_12 = 0;
            label_24:
            if(val_12 == 1)
            {
                goto label_6;
            }
            
            if(val_12 != 0)
            {
                goto label_23;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_14;
            label_6:
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_21;
            label_14:
            val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            val_12 = 1152921541907626096;
            goto label_23;
            label_21:
            val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            val_10 = 1152921541907626096;
            label_23:
            val_12 = val_12 + 1;
            if(val_12 != 1152921541907626096)
            {
                goto label_24;
            }
            
            goto label_25;
            label_5:
            val_12 = 0;
            val_11 = 0;
            val_10 = 0;
            val_9 = 0;
            label_25:
            GameEventDropChanceData.丈七一上丒业丗专丈 val_9 = null;
            val_8 = val_9;
            val_9 = new GameEventDropChanceData.丈七一上丒业丗专丈();
            if(val_8 != null)
            {
                    ._inapp = val_11;
                mem[1152921541907654776] = val_12;
            }
            else
            {
                    mem[16] = val_11;
                mem[24] = val_12;
            }
            
            ._superSpinCount = val_9;
            mem[1152921541907654792] = val_10;
            return (丈七一上丒业丗专丈)val_8;
        }
        public 丘三丌丏丂丒丈七丞()
        {
        
        }
    
    }

}
