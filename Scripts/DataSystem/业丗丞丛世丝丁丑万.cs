using UnityEngine;

namespace DataSystem
{
    internal sealed class 业丗丞丛世丝丁丑万 : IMessagePackFormatter<丈丞丕丘丕丗与上一>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, 丈丞丕丘丕丗与上一 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_3;
            int val_4;
            val_3 = 丙业与丙丗丝不丈东;
            if(val_3 != null)
            {
                    val_4 = val_3.东与三丌丅三丒丏业();
                val_3 = val_3.丟丂丞不专丆万丒世();
            }
            else
            {
                    val_4 = System.String.alignConst;
            }
        
        }
        public 丈丞丕丘丕丗与上一 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if((System.String.IsNullOrEmpty(value:  且丛三下万丂专专业.reader.<Consumed>k__BackingField)) == true)
            {
                    return (丈丞丕丘丕丗与上一)0;
            }
            
            丈丞丕丘丕丗与上一 val_2 = null;
            0 = val_2;
            val_2 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  -1265013024, 丏丂不专上丘丂不丅:  且丛三下万丂专专业.reader.<Consumed>k__BackingField);
            return (丈丞丕丘丕丗与上一)0;
        }
        public 业丗丞丛世丝丁丑万()
        {
        
        }
    
    }

}
