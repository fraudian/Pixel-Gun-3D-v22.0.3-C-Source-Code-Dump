using UnityEngine;

namespace MessagePack.Formatters.Rilisoft
{
    internal sealed class 上丌丆丝丘丆丑丙丄 : IMessagePackFormatter<Rilisoft.GameEventDropChanceData.一七下丝丐丞丁万丌>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.GameEventDropChanceData.一七下丝丐丞丁万丌 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_15;
            var val_16;
            MessagePack.MessagePackWriter val_17;
            bool val_18;
            MessagePack.IFormatterResolver val_19;
            Rilisoft.丝丑丂丛万丐丈丘且 val_20;
            var val_21;
            var val_22;
            var val_23;
            val_15 = 丆与丛丅丂三万一丑;
            val_16 = 丙业与丙丗丝不丈东;
            val_17 = 1152921541906944560;
            val_18 = true;
            if(val_16 != null)
            {
                    val_19 = val_15.Resolver;
                val_20 = 丙业与丙丗丝不丈东._chestId;
                val_22 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_19);
                var val_14 = 0;
                val_14 = val_14 + 1;
            }
            else
            {
                    val_17 = ???;
                val_15 = ???;
                val_19 = ???;
                val_16 = ???;
                val_21 = ???;
                val_20 = ???;
                val_22 = ???;
                val_18 = val_18 + ((X11) << 4);
                val_23 = val_18 + 296;
            }
            
            val_22.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_17, _span = new System.Span<System.Byte>() {_length = val_17}, _segment = new System.ArraySegment<System.Byte>() {_count = val_17}, _buffered = val_17, _bytesCommitted = val_17, _sequencePool = val_17, _rental = new Rental() {owner = val_17, <Value>k__BackingField = val_17}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_17}, <OldSpec>k__BackingField = val_17}, value:  null, options:  null);
            var val_15 = 0;
            val_15 = val_15 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<丙三丏一丈上且丌丒>>(resolver:  val_19).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_17, _span = new System.Span<System.Byte>() {_length = val_17}, _segment = new System.ArraySegment<System.Byte>() {_count = val_17}, _buffered = val_17, _bytesCommitted = val_17, _sequencePool = val_17, _rental = new Rental() {owner = val_17, <Value>k__BackingField = val_17}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_17}, <OldSpec>k__BackingField = val_17}, value:  null, options:  null);
        }
        public Rilisoft.GameEventDropChanceData.一七下丝丐丞丁万丌 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_8;
            System.Collections.Generic.List<丙三丏一丈上且丌丒> val_9;
            Rilisoft.丝丑丂丛万丐丈丘且 val_10;
            var val_11;
            val_8 = 0;
            if((1152921541907134416 & 1) != 0)
            {
                    return (一七下丝丐丞丁万丌)val_8;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541907134416 < 1)
            {
                goto label_5;
            }
            
            val_9 = 0;
            var val_12 = 0;
            val_10 = 0;
            val_11 = 0;
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
            val_10 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            val_11 = 1152921541907134416;
            goto label_23;
            label_21:
            val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<丙三丏一丈上且丌丒>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            label_23:
            val_12 = val_12 + 1;
            if(val_12 != 1152921541907134416)
            {
                goto label_24;
            }
            
            goto label_25;
            label_5:
            val_11 = 0;
            val_10 = 0;
            val_9 = 0;
            label_25:
            GameEventDropChanceData.一七下丝丐丞丁万丌 val_9 = null;
            val_8 = val_9;
            val_9 = new GameEventDropChanceData.一七下丝丐丞丁万丌();
            if(val_8 != null)
            {
                    ._chestId = val_10;
                mem[1152921541907163096] = val_11;
            }
            else
            {
                    mem[16] = val_10;
                mem[24] = val_11;
            }
            
            .ChanceDatas = val_9;
            return (一七下丝丐丞丁万丌)val_8;
        }
        public 上丌丆丝丘丆丑丙丄()
        {
        
        }
    
    }

}
