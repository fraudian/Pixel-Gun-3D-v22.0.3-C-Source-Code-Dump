using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丆业丑丒上业丏丄丗 : IMessagePackFormatter<PGCompany.DataObjects.丆丏丛丝丈三七丗东>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.丆丏丛丝丈三七丗东 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
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
            val_16 = 1152921541957357776;
            val_17 = true;
            if(val_15 != null)
            {
                    val_18 = val_14.Resolver;
                val_19 = 丙业与丙丗丝不丈东.Id;
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
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.DataObjects.丑丑丘不一丈丞丐且>(resolver:  val_18).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_16, _span = new System.Span<System.Byte>() {_length = val_16}, _segment = new System.ArraySegment<System.Byte>() {_count = val_16}, _buffered = val_16, _bytesCommitted = val_16, _sequencePool = val_16, _rental = new Rental() {owner = val_16, <Value>k__BackingField = val_16}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_16}, <OldSpec>k__BackingField = val_16}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.丆丏丛丝丈三七丗东 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_8;
            var val_9;
            string val_10;
            var val_11;
            PGCompany.DataObjects.丑丑丘不一丈丞丐且 val_12;
            val_9 = 0;
            if((1152921541957551728 & 1) != 0)
            {
                    return (PGCompany.DataObjects.丆丏丛丝丈三七丗东)val_9;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541957551728 < 1)
            {
                goto label_5;
            }
            
            val_10 = 0;
            val_11 = 0;
            val_8 = 0;
            val_12 = 0;
            var val_17 = 0;
            label_25:
            if(val_17 > 3)
            {
                goto label_24;
            }
            
            var val_14 = -35372160;
            val_14 = val_14 + 106046028;
            goto (-35372160 + 106046028);
            label_24:
            val_17 = val_17 + 1;
            if(val_17 != 1152921541957551728)
            {
                goto label_25;
            }
            
            goto label_26;
            label_5:
            val_12 = 0;
            val_8 = 0;
            val_11 = 0;
            val_10 = 0;
            label_26:
            PGCompany.DataObjects.丆丏丛丝丈三七丗东 val_9 = null;
            val_9 = val_9;
            val_9 = new PGCompany.DataObjects.丆丏丛丝丈三七丗东();
            if(val_9 != null)
            {
                    .Id = val_10;
                .Enabled = val_11 & 1;
                .NeedModifierTime = val_8 & 1;
            }
            else
            {
                    mem[16] = val_10;
                mem[24] = val_11 & 1;
                .NeedModifierTime = val_8 & 1;
            }
            
            .Type = val_12;
            return (PGCompany.DataObjects.丆丏丛丝丈三七丗东)val_9;
        }
        public 丆业丑丒上业丏丄丗()
        {
        
        }
    
    }

}
