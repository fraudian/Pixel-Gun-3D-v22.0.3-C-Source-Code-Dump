using UnityEngine;

namespace PGCompany
{
    internal sealed class 丄丑丗业丕丌万丆丘 : 丞丘丟丝丗丒三丛丁
    {
        // Methods
        internal override void 三丛丁丆东世丁丏三()
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = this.上万丈丒丅万丘丙一();
            if(val_1 == null)
            {
                    return;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_1, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        internal override bool 丑丕丈丈不不且丑且()
        {
            if(this.上万丈丒丅万丘丙一() == null)
            {
                    return (bool)(this.世丈丁业丛上丘丗丐().丏与丌丈丟万专丕丞() > 0) ? 1 : 0;
            }
            
            return (bool)(this.世丈丁业丛上丘丗丐().丏与丌丈丟万专丕丞() > 0) ? 1 : 0;
        }
        internal override string 丛丂丄下七东下七世()
        {
            var val_6;
            int val_7;
            val_6 = this;
            if((val_6 & 1) != 0)
            {
                    val_6 = this.世丈丁业丛上丘丗丐();
                string val_5 = System.String.Format(format:  "{0}:{1}", arg0:  this.世丈丁业丛上丘丗丐().不业丙丒丂丞下丆丙(), arg1:  val_6.丏与丌丈丟万专丕丞());
                return (string)val_7;
            }
            
            val_7 = System.String.alignConst;
            return (string)val_7;
        }
        public override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 0;
        }
        public override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/hummers");
        }
        public override string 七业丑不七丐业丟丂()
        {
            return (string)System.String.alignConst;
        }
        public override string 东且丏丆万与东丙万()
        {
            return (string)System.String.alignConst;
        }
        public override string 不丑不与丟丛丏丘丅()
        {
            return (string)this.世丈丁业丛上丘丗丐().丏与丌丈丟万专丕丞().ToString();
        }
        internal PGCompany.三东丏不丗世丅丌丄 上万丈丒丅万丘丙一()
        {
            int val_8;
            var val_9;
            val_8 = this;
            PGCompany.丏丌丝丕丐七丈且丒 val_2 = PGCompany.ClanGovernorController.丑七不且上丗丁一世().丞东丗丕三且丈丑丘();
            if(val_2 != null)
            {
                    val_9 = val_2.丞万丒丌丈东丄业下().丑丐丙丄丅世世丑丒().与下不与丐丈丁丈万();
                val_8 = this.世丈丁业丛上丘丗丐().丏与丌丈丟万专丕丞();
                val_9.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_8);
                return (PGCompany.三东丏不丗世丅丌丄)val_9;
            }
            
            val_9 = 0;
            return (PGCompany.三东丏不丗世丅丌丄)val_9;
        }
        public 丄丑丗业丕丌万丆丘()
        {
        
        }
    
    }

}
