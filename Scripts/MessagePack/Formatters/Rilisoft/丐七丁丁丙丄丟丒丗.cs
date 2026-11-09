using UnityEngine;

namespace MessagePack.Formatters.Rilisoft
{
    public sealed class 丐七丁丁丙丄丟丒丗 : IMessagePackFormatter<Rilisoft.GameEventChestPriceContainer>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.GameEventChestPriceContainer 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if(丙业与丙丗丝不丈东 != null)
            {
                    MessagePack.IFormatterResolver val_1 = 丆与丛丅丂三万一丑.Resolver;
                1152921541904472464 = ???;
            }
        
        }
        public Rilisoft.GameEventChestPriceContainer Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if((1152921541904645872 & 1) != 0)
            {
                    return (Rilisoft.GameEventChestPriceContainer)0;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541904645872 >= 1)
            {
                    do
            {
            
            }
            while(!=0);
            
            }
            
            Rilisoft.GameEventChestPriceContainer val_3 = null;
            0 = val_3;
            val_3 = new Rilisoft.GameEventChestPriceContainer();
            return (Rilisoft.GameEventChestPriceContainer)0;
        }
        public 丐七丁丁丙丄丟丒丗()
        {
        
        }
    
    }

}
