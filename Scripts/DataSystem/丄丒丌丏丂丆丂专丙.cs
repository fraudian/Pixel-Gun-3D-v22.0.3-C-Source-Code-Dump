using UnityEngine;

namespace DataSystem
{
    internal sealed class 丄丒丌丏丂丆丂专丙 : IMessagePackFormatter<PGCompany.DataObjects.IntInterval>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.DataObjects.IntInterval 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            if(丙业与丙丗丝不丈东 != null)
            {
                    int val_1 = 丙业与丙丗丝不丈东.From;
                int val_2 = 丙业与丙丗丝不丈东.To;
                1152921541996812736 = ???;
            }
        
        }
        public PGCompany.DataObjects.IntInterval Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            return (PGCompany.DataObjects.IntInterval)new PGCompany.DataObjects.IntInterval(丈丗与丞一上且上上:  -1264578784, 专丂丕丗丗东世丞下:  -1264578784);
        }
        public 丄丒丌丏丂丆丂专丙()
        {
        
        }
    
    }

}
