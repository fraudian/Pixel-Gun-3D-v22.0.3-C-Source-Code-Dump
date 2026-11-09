using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 东丘一丘一不丟下丕 : IMessagePackFormatter<PGCompany.DataObjects.七下上丁万东丑世业>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.七下上丁万东丑世业 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_16;
            var val_17;
            MessagePack.MessagePackWriter val_18;
            bool val_19;
            MessagePack.IFormatterResolver val_20;
            string val_21;
            var val_22;
            var val_23;
            val_16 = 丆与丛丅丂三万一丑;
            val_17 = 丙业与丙丗丝不丈东;
            val_18 = 1152921541953448960;
            val_19 = true;
            if(val_17 != null)
            {
                    val_20 = val_16.Resolver;
                val_21 = 丙业与丙丗丝不丈东.ItemIdTable;
                val_22 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_20);
                var val_15 = 0;
                val_15 = val_15 + 1;
            }
            else
            {
                    val_17 = ???;
                val_18 = ???;
                val_20 = ???;
                val_16 = ???;
                val_22 = ???;
                val_21 = ???;
                val_19 = val_19 + ((X11) << 4);
                val_23 = val_19 + 296;
            }
            
            val_22.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
            var val_16 = 0;
            val_16 = val_16 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<GiftCategoryType>(resolver:  val_20).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
            var val_17 = 0;
            val_17 = val_17 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<GiftSettingType>(resolver:  val_20).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_18, _span = new System.Span<System.Byte>() {_length = val_18}, _segment = new System.ArraySegment<System.Byte>() {_count = val_18}, _buffered = val_18, _bytesCommitted = val_18, _sequencePool = val_18, _rental = new Rental() {owner = val_18, <Value>k__BackingField = val_18}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_18}, <OldSpec>k__BackingField = val_18}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.七下上丁万东丑世业 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            var val_11;
            string val_12;
            GiftCategoryType val_13;
            GiftSettingType val_14;
            val_11 = 0;
            if((1152921541953651136 & 1) != 0)
            {
                    return (PGCompany.DataObjects.七下上丁万东丑世业)val_11;
            }
            
            val_10 = 丆与丛丅丂三万一丑.Security;
            val_10.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541953651136 < 1)
            {
                goto label_5;
            }
            
            val_12 = 0;
            val_13 = 0;
            val_14 = 0;
            label_34:
            if(0 > 5)
            {
                goto label_33;
            }
            
            var val_13 = -21439052;
            val_13 = val_13 + 106067380;
            goto (-21439052 + 106067380);
            label_33:
            val_10 = 0 + 1;
            if(val_10 != 1152921541953651136)
            {
                goto label_34;
            }
            
            goto label_35;
            label_5:
            val_14 = 0;
            val_13 = 0;
            val_12 = 0;
            label_35:
            PGCompany.DataObjects.七下上丁万东丑世业 val_12 = null;
            val_11 = val_12;
            val_12 = new PGCompany.DataObjects.七下上丁万东丑世业();
            if(val_11 != null)
            {
                    .ItemIdTable = val_12;
                .ItemIndexTable = 0;
                .ItemType = val_13;
                .Setting = val_14;
                .HasReceipt = false;
            }
            else
            {
                    mem[24] = 0;
                mem[32] = val_12;
                mem[40] = 0;
                .ItemType = val_13;
                mem[48] = val_14;
            }
            
            bool val_17 = false;
            val_17 = val_17 & 1;
            .ItemEnabled = val_17;
            return (PGCompany.DataObjects.七下上丁万东丑世业)val_11;
        }
        public 东丘一丘一不丟下丕()
        {
        
        }
    
    }

}
