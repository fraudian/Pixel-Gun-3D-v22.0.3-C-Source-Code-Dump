using UnityEngine;

namespace PGCompany.Components
{
    internal class SPViewABTest : SPViewComponentBase
    {
        // Fields
        private bool _bCohort;
        private bool _allwaysEnabledForSilver;
        
        // Methods
        public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            UnityEngine.GameObject val_10;
            bool val_11;
            if((this._allwaysEnabledForSilver != false) && ((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "source.silver")) != false))
            {
                    val_10 = this.gameObject;
                val_11 = 1;
            }
            else
            {
                    bool val_4 = PGCompany.MainStore.世东丒丅下丙丂万丏.丂丑专丑丕丟专丌三();
                var val_5 = (this._bCohort == true) ? 1 : 0;
                bool val_6 = val_4 | val_5;
                val_5 = val_4 & val_5;
                val_6 = val_6 ^ 1;
                val_10 = this.gameObject;
                val_11 = val_5 | val_6;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  val_11);
        }
        public SPViewABTest()
        {
        
        }
    
    }

}
