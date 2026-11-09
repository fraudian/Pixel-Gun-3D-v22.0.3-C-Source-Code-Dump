using UnityEngine;

namespace MessagePack.Formatters.Rilisoft
{
    public sealed class 丌下丛丟丘业丅丒专 : IMessagePackFormatter<Rilisoft.GameEventItemData>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.GameEventItemData 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_14;
            var val_15;
            MessagePack.MessagePackWriter val_16;
            bool val_17;
            MessagePack.IFormatterResolver val_18;
            PGCompany.三东丏不丗世丅丌丄 val_19;
            var val_20;
            var val_21;
            val_14 = 丆与丛丅丂三万一丑;
            val_15 = 丙业与丙丗丝不丈东;
            val_16 = 1152921541909503760;
            val_17 = true;
            if(val_15 != null)
            {
                    val_18 = val_14.Resolver;
                val_19 = 丙业与丙丗丝不丈东.ItemParams;
                val_20 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.三东丏不丗世丅丌丄>(resolver:  val_18);
                var val_13 = 0;
                val_13 = val_13 + 1;
            }
            else
            {
                    val_16 = ???;
                val_15 = ???;
                val_18 = ???;
                val_14 = ???;
                val_20 = ???;
                val_19 = ???;
                val_17 = val_17 + ((X11) << 4);
                val_21 = val_17 + 296;
            }
            
            val_20.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_16, _span = new System.Span<System.Byte>() {_length = val_16}, _segment = new System.ArraySegment<System.Byte>() {_count = val_16}, _buffered = val_16, _bytesCommitted = val_16, _sequencePool = val_16, _rental = new Rental() {owner = val_16, <Value>k__BackingField = val_16}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_16}, <OldSpec>k__BackingField = val_16}, value:  null, options:  null);
            var val_14 = 0;
            val_14 = val_14 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_18).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_16, _span = new System.Span<System.Byte>() {_length = val_16}, _segment = new System.ArraySegment<System.Byte>() {_count = val_16}, _buffered = val_16, _bytesCommitted = val_16, _sequencePool = val_16, _rental = new Rental() {owner = val_16, <Value>k__BackingField = val_16}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_16}, <OldSpec>k__BackingField = val_16}, value:  null, options:  null);
        }
        public Rilisoft.GameEventItemData Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            int val_8;
            var val_9;
            PGCompany.三东丏不丗世丅丌丄 val_10;
            string val_11;
            int val_12;
            float val_13;
            val_9 = 0;
            if((1152921541909697712 & 1) != 0)
            {
                    return (Rilisoft.GameEventItemData)val_9;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541909697712 < 1)
            {
                goto label_5;
            }
            
            val_10 = 0;
            val_11 = 0;
            val_12 = 0;
            val_8 = 0;
            var val_13 = 0;
            val_13 = 0f;
            label_26:
            if(val_13 > 4)
            {
                goto label_25;
            }
            
            var val_10 = -18938204;
            val_10 = val_10 + 106070504;
            goto (-18938204 + 106070504);
            label_25:
            val_13 = val_13 + 1;
            if(val_13 != 1152921541909697712)
            {
                goto label_26;
            }
            
            goto label_27;
            label_5:
            val_8 = 0;
            val_12 = 0;
            val_11 = 0;
            val_10 = 0;
            val_13 = 0f;
            label_27:
            Rilisoft.GameEventItemData val_9 = null;
            val_9 = val_9;
            val_9 = new Rilisoft.GameEventItemData();
            if(val_9 != null)
            {
                    .ItemParams = val_10;
                .BgColor = val_11;
                .DropChance = val_13;
                .ExtSort = val_12;
            }
            else
            {
                    mem[40] = val_10;
                mem[48] = val_11;
                .DropChance = val_13;
                .ExtSort = val_12;
            }
            
            .SubType = val_8;
            return (Rilisoft.GameEventItemData)val_9;
        }
        public 丌下丛丟丘业丅丒专()
        {
        
        }
    
    }

}
