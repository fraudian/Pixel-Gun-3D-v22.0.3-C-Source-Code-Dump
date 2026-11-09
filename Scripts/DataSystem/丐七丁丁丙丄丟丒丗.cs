using UnityEngine;

namespace DataSystem
{
    internal sealed class 丐七丁丁丙丄丟丒丗 : IMessagePackFormatter<Rilisoft.GameEventChestPriceContainer>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.GameEventChestPriceContainer 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if(丙业与丙丗丝不丈东 != null)
            {
                    1152921541998148288 = ???;
            }
        
        }
        public Rilisoft.GameEventChestPriceContainer Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if((且丛三下万丂专专业.reader.<Consumed>k__BackingField) == 0)
            {
                    return (Rilisoft.GameEventChestPriceContainer)1152921541998305312;
            }
            
            return Rilisoft.GameEventChestPriceContainer.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  且丛三下万丂专专业.reader.<Consumed>k__BackingField);
        }
        public 丐七丁丁丙丄丟丒丗()
        {
        
        }
    
    }

}
