using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects.ManualOffers
{
    public sealed class 业丙丏丈丆丌丒丄业 : IMessagePackFormatter<PGCompany.DataObjects.ManualOffers.丈丆一与丆丁丝东七>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.ManualOffers.丈丆一与丆丁丝东七 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_14;
            var val_15;
            MessagePack.MessagePackWriter val_16;
            bool val_17;
            MessagePack.IFormatterResolver val_18;
            System.Collections.Generic.List<PGCompany.DataObjects.ManualOffers.一丌三世丏且丈三且> val_19;
            var val_20;
            var val_21;
            val_14 = 丆与丛丅丂三万一丑;
            val_15 = 丙业与丙丗丝不丈东;
            val_16 = 1152921541968523504;
            val_17 = true;
            if(val_15 != null)
            {
                    val_18 = val_14.Resolver;
                val_19 = 丙业与丙丗丝不丈东.ManualOffersSettings;
                val_20 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.DataObjects.ManualOffers.一丌三世丏且丈三且>>(resolver:  val_18);
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
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.String>>>(resolver:  val_18).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_16, _span = new System.Span<System.Byte>() {_length = val_16}, _segment = new System.ArraySegment<System.Byte>() {_count = val_16}, _buffered = val_16, _bytesCommitted = val_16, _sequencePool = val_16, _rental = new Rental() {owner = val_16, <Value>k__BackingField = val_16}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_16}, <OldSpec>k__BackingField = val_16}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.ManualOffers.丈丆一与丆丁丝东七 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_8;
            System.Collections.Generic.List<PGCompany.DataObjects.ManualOffers.一丌三世丏且丈三且> val_9;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.String>> val_10;
            val_8 = 0;
            if((1152921541968717456 & 1) != 0)
            {
                    return (PGCompany.DataObjects.ManualOffers.丈丆一与丆丁丝东七)val_8;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541968717456 < 1)
            {
                goto label_5;
            }
            
            val_9 = 0;
            val_10 = 0;
            var val_12 = 0;
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
            val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.DataObjects.ManualOffers.一丌三世丏且丈三且>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            goto label_23;
            label_21:
            val_10 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.Int32, System.String>>>(resolver:  val_2).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            label_23:
            val_12 = val_12 + 1;
            if(val_12 != 1152921541968717456)
            {
                goto label_24;
            }
            
            goto label_25;
            label_5:
            val_10 = 0;
            val_9 = 0;
            label_25:
            PGCompany.DataObjects.ManualOffers.丈丆一与丆丁丝东七 val_9 = null;
            val_8 = val_9;
            val_9 = new PGCompany.DataObjects.ManualOffers.丈丆一与丆丁丝东七();
            if(val_8 != null)
            {
                    .ManualOffersSettings = val_9;
            }
            else
            {
                    mem[16] = val_9;
            }
            
            .Translations = val_10;
            return (PGCompany.DataObjects.ManualOffers.丈丆一与丆丁丝东七)val_8;
        }
        public 业丙丏丈丆丌丒丄业()
        {
        
        }
    
    }

}
