using UnityEngine;

namespace MessagePack.Formatters.PGCompany.DataObjects
{
    internal sealed class 丁丟一不丑丑丟世丂 : IMessagePackFormatter<PGCompany.DataObjects.专丅一丄上丗且丑一>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.专丅一丄上丗且丑一 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_20;
            var val_21;
            MessagePack.MessagePackWriter val_22;
            bool val_23;
            MessagePack.IFormatterResolver val_24;
            var val_25;
            string val_26;
            var val_27;
            var val_28;
            var val_29;
            val_20 = 丆与丛丅丂三万一丑;
            val_21 = 丙业与丙丗丝不丈东;
            val_22 = 1152921541959877920;
            val_23 = true;
            if(val_21 != null)
            {
                    val_24 = val_20.Resolver;
                val_25 = 1152921541903713024;
                val_26 = 丙业与丙丗丝不丈东.丄丑丘专丄七不专丆;
                val_27 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.String>(resolver:  val_24);
                val_28 = 1152921504968347648;
                var val_19 = 0;
                val_19 = val_19 + 1;
            }
            else
            {
                    val_22 = ???;
                val_20 = ???;
                val_24 = ???;
                val_21 = ???;
                val_27 = ???;
                val_26 = ???;
                val_28 = ???;
                val_25 = ???;
                val_23 = val_23 + ((X11) << 4);
                val_29 = val_23 + 296;
            }
            
            val_27.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<UnityEngine.Keyframe[]>(resolver:  val_24);
            var val_20 = 0;
            val_20 = val_20 + 1;
            var val_21 = 0;
            val_21 = val_21 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
            var val_22 = 0;
            val_22 = val_22 + 1;
            MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<PGCompany.三东丏不丗世丅丌丄>(resolver:  val_24).Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_22, _span = new System.Span<System.Byte>() {_length = val_22}, _segment = new System.ArraySegment<System.Byte>() {_count = val_22}, _buffered = val_22, _bytesCommitted = val_22, _sequencePool = val_22, _rental = new Rental() {owner = val_22, <Value>k__BackingField = val_22}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_22}, <OldSpec>k__BackingField = val_22}, value:  null, options:  null);
        }
        public PGCompany.DataObjects.专丅一丄上丗且丑一 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_12;
            string val_13;
            string val_14;
            System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_15;
            PGCompany.三东丏不丗世丅丌丄 val_16;
            val_12 = 0;
            if((1152921541960088304 & 1) != 0)
            {
                    return (PGCompany.DataObjects.专丅一丄上丗且丑一)val_12;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541960088304 < 1)
            {
                goto label_5;
            }
            
            val_13 = 0;
            val_14 = 0;
            val_15 = 0;
            val_16 = 0;
            var val_21 = 0;
            label_39:
            if(val_21 > 3)
            {
                goto label_38;
            }
            
            var val_16 = -35374504;
            val_16 = val_16 + 106046012;
            goto (-35374504 + 106046012);
            label_38:
            val_21 = val_21 + 1;
            if(val_21 != 1152921541960088304)
            {
                goto label_39;
            }
            
            goto label_40;
            label_5:
            val_16 = 0;
            val_15 = 0;
            val_14 = 0;
            val_13 = 0;
            label_40:
            PGCompany.DataObjects.专丅一丄上丗且丑一 val_15 = null;
            val_12 = val_15;
            val_15 = new PGCompany.DataObjects.专丅一丄上丗且丑一();
            if(val_12 != null)
            {
                    .丄丑丘专丄七不专丆 = val_13;
                .丘丏丐丞丈专三且世 = val_14;
                .下丐丐丁与丂下世七 = val_15;
            }
            else
            {
                    mem[16] = val_13;
                mem[24] = val_14;
                mem[32] = val_15;
            }
            
            .丑丗不丝上丑上七丅 = val_16;
            return (PGCompany.DataObjects.专丅一丄上丗且丑一)val_12;
        }
        public 丁丟一不丑丑丟世丂()
        {
        
        }
    
    }

}
