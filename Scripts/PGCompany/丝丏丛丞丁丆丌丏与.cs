using UnityEngine;

namespace PGCompany
{
    internal class 丝丏丛丞丁丆丌丏与 : 丕与万三东丞业不丅
    {
        // Fields
        internal PGCompany.丘一丂七丄与一东丕[] 丙一东业下丈丏丞丏;
        
        // Methods
        public override void 丑丈丆万丅上丞丗丐(ref System.Action<PGCompany.丆七丗丂世丞丗丙三, object> 且不丅万丕丙丕丆且, 丄丐世丆丛世丅上丛 专丒丌丆下丐丞丟丞)
        {
            PGCompany.丘一丂七丄与一东丕[] val_3;
            var val_4;
            var val_5;
            val_3 = this.丙一东业下丈丏丞丏;
            if((val_3 == null) || (this.丙一东业下丈丏丞丏.Length == 0))
            {
                goto label_2;
            }
            
            val_4 = 0;
            goto label_3;
            label_12:
            PGCompany.丘一丂七丄与一东丕 val_3 = this.丙一东业下丈丏丞丏[0];
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = 1152921555344889664;
            val_3 = this.丙一东业下丈丏丞丏;
            val_4 = 1;
            label_3:
            if(val_4 < this.丙一东业下丈丏丞丏.Length)
            {
                goto label_12;
            }
            
            label_2:
            this.且丙上三七丝下世不(且不丅万丕丙丕丆且: ref  System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object> val_2 = 且不丅万丕丙丕丆且, 七丐丅专且专七三丆:  25, 丙业与丙丗丝不丈东:  专丒丌丆下丐丞丟丞.丅丛丌丂丒一丁丑丁.丟丛丂不与丄丐专与);
        }
        public 丝丏丛丞丁丆丌丏与()
        {
            PGCompany.丘一丂七丄与一东丕[] val_1 = new PGCompany.丘一丂七丄与一东丕[4];
            PGCompany.七七世不不万业丘不 val_2 = new PGCompany.七七世不不万业丘不();
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
            val_1[1] = new PGCompany.丆且业上丛东丗丑下();
            val_1[2] = new PGCompany.下丙丐万三下下上世();
            val_1[3] = new PGCompany.一丞世万丂丗丈且且();
            this.丙一东业下丈丏丞丏 = val_1;
        }
    
    }

}
