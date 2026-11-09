using UnityEngine;

namespace DataSystem
{
    internal sealed class 丙上丙丅丕东丗三丂 : IMessagePackFormatter<PGCompany.三东丏不丗世丅丌丄>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.三东丏不丗世丅丌丄 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            PGCompany.三东丏不丗世丅丌丄 val_3;
            var val_4;
            int val_5;
            val_3 = 丙业与丙丗丝不丈东;
            val_4 = null;
            if(val_3 != null)
            {
                    val_5 = val_3.业东丅东丌上丗丑不();
                val_3 = PGCompany.丁丑上丞业丞丟丛上.不丑不与丟丛丏丘丅(丈丄不七三万丄丁不:  val_3);
            }
            else
            {
                    val_5 = 丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东;
            }
        
        }
        public PGCompany.三东丏不丗世丅丌丄 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  -1267626752, 丂丕丂丏专丂丄丕且:  -1267626752);
            return (PGCompany.三东丏不丗世丅丌丄)((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_1)) != true) ? (val_1) : 0;
        }
        public 丙上丙丅丕东丗三丂()
        {
        
        }
    
    }

}
