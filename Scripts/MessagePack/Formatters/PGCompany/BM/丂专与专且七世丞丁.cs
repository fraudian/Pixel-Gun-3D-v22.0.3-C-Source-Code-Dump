using UnityEngine;

namespace MessagePack.Formatters.PGCompany.BM
{
    internal sealed class 丂专与专且七世丞丁 : IMessagePackFormatter<PGCompany.BM.丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.BM.丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            var val_13;
            MessagePack.MessagePackWriter val_14;
            bool val_15;
            decimal val_16;
            var val_17;
            var val_18;
            var val_19;
            val_12 = 丆与丛丅丂三万一丑;
            val_13 = 丙业与丙丗丝不丈东;
            val_14 = 1152921541972238720;
            val_15 = true;
            if(val_13 != null)
            {
                    val_16 = 丙业与丙丗丝不丈东._chance;
                val_18 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Decimal>(resolver:  val_12.Resolver);
                var val_11 = 0;
                val_11 = val_11 + 1;
            }
            else
            {
                    val_13 = ???;
                val_14 = ???;
                val_16 = ???;
                val_12 = ???;
                val_18 = ???;
                val_17 = ???;
                val_15 = val_15 + ((X11) << 4);
                val_19 = val_15 + 296;
            }
            
            val_18.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_14, _span = new System.Span<System.Byte>() {_length = val_14}, _segment = new System.ArraySegment<System.Byte>() {_count = val_14}, _buffered = val_14, _bytesCommitted = val_14, _sequencePool = val_14, _rental = new Rental() {owner = val_14, <Value>k__BackingField = val_14}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_14}, <OldSpec>k__BackingField = val_14}, value:  null, options:  null);
        }
        public PGCompany.BM.丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            int val_6;
            var val_7;
            decimal val_8;
            var val_9;
            val_7 = 0;
            if((1152921541972420352 & 1) != 0)
            {
                    return (丝丆丁丒丌丂上丑丏)val_7;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541972420352 < 1)
            {
                goto label_5;
            }
            
            val_6 = 0;
            var val_8 = 0;
            val_8 = 0;
            val_9 = 0;
            label_17:
            if(val_8 == 1)
            {
                goto label_6;
            }
            
            if(val_8 != 0)
            {
                goto label_16;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_14;
            label_6:
            val_6 = 1152921541972420352;
            goto label_16;
            label_14:
            val_8 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Decimal>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            val_9 = 1152921541972420352;
            label_16:
            val_8 = val_8 + 1;
            if(val_8 != 1152921541972420352)
            {
                goto label_17;
            }
            
            goto label_18;
            label_5:
            val_9 = 0;
            val_8 = 0m;
            val_6 = 0;
            label_18:
            丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏 val_6 = null;
            val_7 = val_6;
            val_6 = new 丒万丗丏一丝丅丌世.丝丆丁丒丌丂上丑丏();
            if(val_7 != null)
            {
                    ._chance = val_8;
                mem[1152921541972444920] = val_9;
            }
            else
            {
                    mem[16] = val_8;
                mem[24] = val_9;
            }
            
            ._count = val_6;
            return (丝丆丁丒丌丂上丑丏)val_7;
        }
        public 丂专与专且七世丞丁()
        {
        
        }
    
    }

}
