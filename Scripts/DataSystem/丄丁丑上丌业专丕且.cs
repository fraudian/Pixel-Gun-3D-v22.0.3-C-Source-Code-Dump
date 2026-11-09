using UnityEngine;

namespace DataSystem
{
    internal sealed class 丄丁丑上丌业专丕且 : IMessagePackFormatter<Rilisoft.OfferItem>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.OfferItem 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if(丙业与丙丗丝不丈东 != null)
            {
                    Rilisoft.OfferItemType val_1 = 丙业与丙丗丝不丈东.Type;
                string val_2 = 丙业与丙丗丝不丈东.Id;
                int val_3 = 丙业与丙丗丝不丈东.Count;
                1152921541994207200 = ???;
            }
        
        }
        public Rilisoft.OfferItem Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            return (Rilisoft.OfferItem)new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  且丛三下万丂专专业.reader.<Consumed>k__BackingField, 丞一丁业丄一一业且:  且丛三下万丂专专业.reader.<Consumed>k__BackingField, 丂丕丂丏专丂丄丕且:  -1267176128);
        }
        public 丄丁丑上丌业专丕且()
        {
        
        }
    
    }

}
