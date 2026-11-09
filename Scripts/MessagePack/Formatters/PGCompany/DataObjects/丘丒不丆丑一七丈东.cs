using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丘丒不丆丑一七丈东 : IMessagePackFormatter<PGCompany.DataObjects.丞东三丒一丒下丈不.丗丄丑丄下丌三一丂>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.丞东三丒一丒下丈不.丗丄丑丄下丌三一丂 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_14;
            var val_15;
            MessagePack.MessagePackWriter val_16;
            bool val_17;
            MessagePack.IFormatterResolver val_18;
            string val_19;
            var val_20;
            var val_21;
            val_14 = 丆与丛丅丂三万一丑;
            val_15 = 丙业与丙丗丝不丈东;
            val_16 = 1152921541949087056;
            val_17 = true;
            if(val_15 != null)
            {
                    val_18 = val_14.Resolver;
                val_19 = 丙业与丙丗丝不丈东.presetName;
                val_20 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_18);
                var val_13 = 0;
                val_13 = val_13 + 1;
            }
            else
            {
                    val_16 = ???;
                val_14 = ???;
                val_18 = ???;
                val_15 = ???;
                val_20 = ???;
                val_19 = ???;
                val_17 = val_17 + ((X11) << 4);
                val_21 = val_17 + 296;
            }
            
            val_20.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_16, _span = new System.Span<System.Byte>() {_length = val_16}, _segment = new System.ArraySegment<System.Byte>() {_count = val_16}, _buffered = val_16, _bytesCommitted = val_16, _sequencePool = val_16, _rental = new Rental() {owner = val_16, <Value>k__BackingField = val_16}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_16}, <OldSpec>k__BackingField = val_16}, value:  null, options:  null);
            var val_14 = 0;
            val_14 = val_14 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<七专丟丒七丆下丂丛>>(resolver:  val_18).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_16, _span = new System.Span<System.Byte>() {_length = val_16}, _segment = new System.ArraySegment<System.Byte>() {_count = val_16}, _buffered = val_16, _bytesCommitted = val_16, _sequencePool = val_16, _rental = new Rental() {owner = val_16, <Value>k__BackingField = val_16}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_16}, <OldSpec>k__BackingField = val_16}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.丞东三丒一丒下丈不.丗丄丑丄下丌三一丂 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_8;
            var val_9;
            string val_10;
            int val_11;
            int val_12;
            System.Collections.Generic.List<七专丟丒七丆下丂丛> val_13;
            val_9 = 0;
            if((1152921541949281008 & 1) != 0)
            {
                    return (丗丄丑丄下丌三一丂)val_9;
            }
            
            val_8 = 丆与丛丅丂三万一丑.Security;
            val_8.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541949281008 < 1)
            {
                goto label_5;
            }
            
            val_10 = 0;
            val_11 = 0;
            val_12 = 0;
            val_13 = 0;
            var val_13 = 0;
            val_8 = 106067268;
            label_26:
            if(val_13 > 4)
            {
                goto label_25;
            }
            
            var val_10 = -21450240;
            val_10 = val_10 + val_8;
            goto (-21450240 + val_8);
            label_25:
            val_13 = val_13 + 1;
            if(val_13 != 1152921541949281008)
            {
                goto label_26;
            }
            
            goto label_27;
            label_5:
            val_13 = 0;
            val_12 = 0;
            val_11 = 0;
            val_10 = 0;
            label_27:
            丞东三丒一丒下丈不.丗丄丑丄下丌三一丂 val_9 = null;
            val_9 = val_9;
            val_9 = new 丞东三丒一丒下丈不.丗丄丑丄下丌三一丂();
            if(val_9 != null)
            {
                    .presetName = val_10;
                .roundTime = val_11;
                .loadingTime = val_12;
                .respawnTime = 0;
            }
            else
            {
                    mem[16] = val_10;
                mem[24] = val_11;
                .loadingTime = val_12;
                mem[32] = 0;
            }
            
            .weapons = val_13;
            return (丗丄丑丄下丌三一丂)val_9;
        }
        public 丘丒不丆丑一七丈东()
        {
        
        }
    
    }

}
