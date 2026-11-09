using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 世丁丙丅丌下丛丙三 : IMessagePackFormatter<PGCompany.丄丑一专丒业东丝丐>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丄丑一专丒业东丝丐 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_10;
            MessagePack.MessagePackWriter val_11;
            bool val_12;
            System.Collections.Generic.List<专专三东下丒丝丘且> val_13;
            var val_14;
            var val_15;
            val_10 = 丆与丛丅丂三万一丑;
            val_11 = 1152921541924115776;
            val_12 = true;
            if(丙业与丙丗丝不丈东 != null)
            {
                    val_13 = 丙业与丙丗丝不丈东.OfferSettings;
                val_14 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<专专三东下丒丝丘且>>(resolver:  val_10.Resolver);
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
        public PGCompany.丄丑一专丒业东丝丐 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_6;
            System.Collections.Generic.List<专专三东下丒丝丘且> val_7;
            val_6 = 0;
            if((1152921541924301504 & 1) != 0)
            {
                    return (PGCompany.丄丑一专丒业东丝丐)val_6;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            if(1152921541924301504 >= 1)
            {
                    val_7 = 0;
                var val_8 = 0;
                do
            {
                if(val_8 != 0)
            {
                
            }
            else
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_7 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<System.Collections.Generic.List<专专三东下丒丝丘且>>(resolver:  丆与丛丅丂三万一丑.Resolver).Deserialize(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField}, options:  丆与丛丅丂三万一丑);
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 != 1152921541924301504);
            
            }
            else
            {
                    val_7 = 0;
            }
            
            PGCompany.丄丑一专丒业东丝丐 val_6 = null;
            val_6 = val_6;
            val_6 = new PGCompany.丄丑一专丒业东丝丐();
            .OfferSettings = val_7;
            return (PGCompany.丄丑一专丒业东丝丐)val_6;
        }
        public 世丁丙丅丌下丛丙三()
        {
        
        }
    
    }

}
