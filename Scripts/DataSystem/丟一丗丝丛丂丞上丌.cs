using UnityEngine;

namespace DataSystem
{
    internal sealed class 丟一丗丝丛丂丞上丌 : IMessagePackFormatter<Rilisoft.丒且丐三丁丅丕一业>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, Rilisoft.丒且丐三丁丅丕一业 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if(丙业与丙丗丝不丈东 != null)
            {
                    float val_1 = 丙业与丙丗丝不丈东.丝丙丐且丟丅三丛七();
            }
        
        }
        public Rilisoft.丒且丐三丁丅丕一业 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if(且丛三下万丂专专业.IsNil == true)
            {
                    return (Rilisoft.丒且丐三丁丅丕一业)0;
            }
            
            Rilisoft.丒且丐三丁丅丕一业 val_2 = null;
            0 = val_2;
            val_2 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  V0.16B);
            return (Rilisoft.丒且丐三丁丅丕一业)0;
        }
        public 丟一丗丝丛丂丞上丌()
        {
        
        }
    
    }

}
