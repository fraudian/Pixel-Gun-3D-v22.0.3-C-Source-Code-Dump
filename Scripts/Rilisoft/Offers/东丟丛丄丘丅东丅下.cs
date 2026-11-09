using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 东丟丛丄丘丅东丅下 : 丈万丈丅丌丏丞丂丐
    {
        // Fields
        private PGCompany.ItemSystem.丒三丟丝丗与不丈丞 万丞丕丕丒丒丆丙丄;
        
        // Methods
        public 东丟丛丄丘丅东丅下(PGCompany.ItemSystem.丒三丟丝丗与不丈丞 下丈丑丑且与丘丞丛, Rilisoft.业丙丘丆东丈丕丂丄 丙丌丛丗丙东丟专丟)
        {
            this.万丞丕丕丒丒丆丙丄 = 下丈丑丑且与丘丞丛;
        }
        public override bool 东一三一万且丕世不()
        {
            var val_5;
            var val_13;
            var val_15;
            世丕三丙七丆丁丂丒 val_2 = this.三丌丘丏丝丘丟下七().丛丗丑丞丟丄且丘七();
            List.Enumerator<T> val_3 = val_2.且东丌丏丐丝丕万业.GetEnumerator();
            label_14:
            if((446370496 & 1) == 0)
            {
                goto label_4;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  val_6.Type, 丞丅上丏丂且下丅与:  val_6.Id);
            val_13 = 0;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_13 = 0;
            if((this.万丞丕丕丒丒丆丙丄.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  new PGCompany.三东丏不丗世丅丌丄().丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_6.Count))) == true)
            {
                goto label_14;
            }
            
            val_15 = 0;
            goto label_15;
            label_4:
            val_15 = 1;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_15;
        }
    
    }

}
