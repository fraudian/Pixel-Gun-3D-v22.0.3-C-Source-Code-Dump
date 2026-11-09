using UnityEngine;

namespace PGCompany.GameplayLoop
{
    internal class 丝丛丗丄丝丅丘丌东 : 业丒丅丂丗丁业上且
    {
        // Methods
        public 丝丛丗丄丝丅丘丌东()
        {
            mem[1152921560179477856] = 1;
        }
        internal override bool 丑丏丙丑且丞丈丝业(bool 丘丄一丘丁丞丘丆且)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(GiftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            if(GiftController.丆丕丝丒不丙且丐丗 != null)
            {
                    return GiftController.丆丕丝丒不丙且丐丗.ActiveGift;
            }
            
            return GiftController.丆丕丝丒不丙且丐丗.ActiveGift;
        }
        internal override bool 万丑万上丕丆不丒七(string 下丅丙一丂丗丅丝七, bool 丘丄一丘丁丞丘丆且)
        {
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_18;
            var val_19;
            val_13 = 丘丄一丘丁丞丘丆且;
            bool val_1 = val_13;
            if(((this & 1) == 0) || ((this & 1) == 0))
            {
                goto label_2;
            }
            
            var val_13 = 0;
            label_17:
            val_14 = null;
            val_14 = null;
            System.String[] val_2 = GiftController.丆丕丝丒不丙且丐丗.下上丈专丘丒丈上东();
            val_15 = null;
            if(val_13 >= val_2.Length)
            {
                goto label_7;
            }
            
            val_16 = null;
            val_13 = GiftController.丆丕丝丒不丙且丐丗.下上丈专丘丒丈上东()[0];
            if((System.String.op_Equality(a:  val_13, b:  下丅丙一丂丗丅丝七)) == true)
            {
                goto label_13;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_6 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丐丆丅丝丂丄下业业(丄丗一三丟丘丞丐丌:  val_13);
            val_13 = val_13 + 1;
            if((System.String.op_Equality(a:  (val_6 == 0) ? 0 : (val_6).业上丙丞丐丄丆丅七(), b:  下丅丙一丂丗丅丝七)) == false)
            {
                goto label_17;
            }
            
            label_13:
            val_18 = 1;
            return (bool)val_18;
            label_2:
            val_18 = 0;
            return (bool)val_18;
            label_7:
            val_19 = null;
            var val_12 = ((System.Array.IndexOf<System.String>(array:  GiftController.丆丕丝丒不丙且丐丗.下上丈专丘丒丈上东(), value:  下丅丙一丂丗丅丝七)) != 1) ? 1 : 0;
            return (bool)val_18;
        }
        internal override bool 且下丑丂丂丌丘丛丘(string 下丅丙一丂丗丅丝七)
        {
            var val_4;
            GiftController val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            val_5 = GiftController.丆丕丝丒不丙且丐丗;
            if(val_5 != 0)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = GiftController.丆丕丝丒不丙且丐丗.丌业丏丄与世三丁不();
                GiftSettingType val_3 = GiftController.丆丕丝丒不丙且丐丗.丆丈丞东丙丞丂丘丏(丞丅上丏丂且下丅与:  下丅丙一丂丗丅丝七);
                if(val_3 != 1)
            {
                    if(val_5 != val_3)
            {
                    return false;
            }
            
            }
            
            }
            
            if(val_3 != 0)
            {
                    return 0.Contains(item:  下丅丙一丂丗丅丝七);
            }
            
            return 0.Contains(item:  下丅丙一丂丗丅丝七);
        }
        internal override string 丒丅三丕丙丏丌丕不()
        {
            return "basic";
        }
    
    }

}
