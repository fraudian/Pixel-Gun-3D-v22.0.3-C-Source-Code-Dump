using UnityEngine;

namespace PGCompany
{
    internal class 万丞业丕世丝万丄丟 : 丕与万三东丞业不丅
    {
        // Fields
        internal PGCompany.丘一丂七丄与一东丕[] 丙一东业下丈丏丞丏;
        
        // Methods
        public override void 丑丈丆万丅上丞丗丐(ref System.Action<PGCompany.丆七丗丂世丞丗丙三, object> 且不丅万丕丙丕丆且, 丄丐世丆丛世丅上丛 专丒丌丆下丐丞丟丞)
        {
            PGCompany.丘一丂七丄与一东丕[] val_7;
            var val_8;
            var val_9;
            bool val_10;
            val_7 = this.丙一东业下丈丏丞丏;
            if((val_7 == null) || (this.丙一东业下丈丏丞丏.Length == 0))
            {
                goto label_2;
            }
            
            val_8 = 0;
            goto label_3;
            label_12:
            PGCompany.丘一丂七丄与一东丕 val_7 = this.丙一东业下丈丏丞丏[0];
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = 1152921555343220064;
            val_7 = this.丙一东业下丈丏丞丏;
            val_8 = 1;
            label_3:
            if(val_8 < this.丙一东业下丈丏丞丏.Length)
            {
                goto label_12;
            }
            
            label_2:
            val_10 = 专丒丌丆下丐丞丟丞.丅丛丌丂丒一丁丑丁.与丟丛丞丌丐专丈丑;
            if((val_10 & 1095216660480) != true)
            {
                    val_10 = 专丒丌丆下丐丞丟丞.丗丞业业丈丞丗丈专.与丟丛丞丌丐专丈丑;
                if((val_10 & 1095216660480) == false)
            {
                goto label_15;
            }
            
            }
            
            bool val_4 = val_10 & (-4294967296);
            label_15:
            val_10 = val_10 & 4294967295;
            val_4 = val_4 & 1095216660480;
            val_10 = val_10 | (val_10 & (-1099511627776));
            val_10 = val_10 | val_4;
            this.且丙上三七丝下世不(且不丅万丕丙丕丆且: ref  System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object> val_6 = 且不丅万丕丙丕丆且, 七丐丅专且专七三丆:  9, 丙业与丙丗丝不丈东:  val_10);
            this.且丙上三七丝下世不(且不丅万丕丙丕丆且: ref  val_6, 七丐丅专且专七三丆:  30, 丙业与丙丗丝不丈东:  专丒丌丆下丐丞丟丞.丅丛丌丂丒一丁丑丁.丟丛丂不与丄丐专与);
        }
        public 万丞业丕世丝万丄丟()
        {
            PGCompany.丘一丂七丄与一东丕[] val_1 = new PGCompany.丘一丂七丄与一东丕[2];
            PGCompany.七丑一不丕丂上一丂 val_2 = new PGCompany.七丑一不丕丂上一丂();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = new PGCompany.一丞世万丂丗丈且且();
            this.丙一东业下丈丏丞丏 = val_1;
        }
    
    }

}
