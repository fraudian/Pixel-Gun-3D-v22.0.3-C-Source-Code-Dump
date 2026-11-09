using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 丞丟丙丈三丅丈丘丝 : IMessagePackFormatter<PGCompany.丘与丈世不丕丕丅丑.丒丛丄丈七丐且丈丌>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丘与丈世不丕丕丅丑.丒丛丄丈七丐且丈丌 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            MessagePack.MessagePackWriter val_11;
            bool val_12;
            System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, PGCompany.DataObjects.IntInterval> val_13;
            var val_14;
            var val_15;
            val_10 = 丆与丛丅丂三万一丑;
            val_11 = 1152921541925176192;
            val_12 = true;
            if(丙业与丙丗丝不丈东 != null)
            {
                    val_13 = 丙业与丙丗丝不丈东.PaymentStates;
                val_14 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, PGCompany.DataObjects.IntInterval>>(resolver:  val_10.Resolver);
                var val_9 = 0;
                val_9 = val_9 + 1;
            }
            else
            {
                    val_11 = ???;
                val_10 = ???;
                val_14 = ???;
                val_13 = ???;
                val_12 = val_12 + ((X11) << 4);
                val_15 = val_12 + 296;
            }
            
            val_14.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_11, _span = new System.Span<System.Byte>() {_length = val_11}, _segment = new System.ArraySegment<System.Byte>() {_count = val_11}, _buffered = val_11, _bytesCommitted = val_11, _sequencePool = val_11, _rental = new Rental() {owner = val_11, <Value>k__BackingField = val_11}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_11}, <OldSpec>k__BackingField = val_11}, value:  null, options:  null);
        }
        public PGCompany.丘与丈世不丕丕丅丑.丒丛丄丈七丐且丈丌 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            int val_6;
            var val_7;
            System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, PGCompany.DataObjects.IntInterval> val_8;
            val_7 = 0;
            if((1152921541925361920 & 1) != 0)
            {
                    return (丒丛丄丈七丐且丈丌)val_7;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541925361920 < 1)
            {
                goto label_5;
            }
            
            val_6 = 0;
            val_8 = 0;
            var val_8 = 0;
            label_17:
            if(val_8 != 1)
            {
                    if(val_8 != 0)
            {
                goto label_16;
            }
            
                val_6 = 1152921541925361920;
            }
            else
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_8 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.Dictionary<Rilisoft.PlayerPaymentType, PGCompany.DataObjects.IntInterval>>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            }
            
            label_16:
            val_8 = val_8 + 1;
            if(val_8 != 1152921541925361920)
            {
                goto label_17;
            }
            
            goto label_18;
            label_5:
            val_8 = 0;
            val_6 = 0;
            label_18:
            丘与丈世不丕丕丅丑.丒丛丄丈七丐且丈丌 val_6 = null;
            val_7 = val_6;
            val_6 = new 丘与丈世不丕丕丅丑.丒丛丄丈七丐且丈丌();
            if(val_7 != null)
            {
                    .PaymentStatePeriod = val_6;
            }
            else
            {
                    mem[16] = val_6;
            }
            
            .PaymentStates = val_8;
            return (丒丛丄丈七丐且丈丌)val_7;
        }
        public 丞丟丙丈三丅丈丘丝()
        {
        
        }
    
    }

}
