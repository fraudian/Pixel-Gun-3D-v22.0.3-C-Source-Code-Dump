using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHModeTab : GMHEntityTab
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> enableIfFirst;
        private System.Collections.Generic.List<UnityEngine.GameObject> enableIfMiddle;
        private GMHModeRewardsView gmhModeRewardsView;
        
        // Properties
        internal PGCompany.GameModeHub.丗丙丈下上丞不丅丑 一丗丟丛丈专丙三丌 { get; }
        internal PGCompany.GameModeHub.GMHModeSelector 丈丁丛下七丙丐且七 { get; }
        
        // Methods
        internal PGCompany.GameModeHub.丗丙丈下上丞不丅丑 丘丛丆丕且丂业世丌()
        {
            var val_2 = 0;
            return (PGCompany.GameModeHub.丗丙丈下上丞不丅丑);
        }
        internal PGCompany.GameModeHub.GMHModeSelector 丘丛丂丛东丏丌丟且()
        {
            var val_2;
            if(true != 0)
            {
                    var val_1 = (38161477 == null) ? true : 0;
                return (PGCompany.GameModeHub.GMHModeSelector)val_2;
            }
            
            val_2 = 0;
            return (PGCompany.GameModeHub.GMHModeSelector)val_2;
        }
        internal override void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世)
        {
            System.Collections.Generic.List<UnityEngine.GameObject> val_4;
            var val_5;
            var val_6;
            this.丈且东丑丂且万丒丅(不丕三丌万丈丟丆世:  不丕三丌万丈丟丆世);
            if((System.Linq.Enumerable.First<SelectableButton>(source:  static_value_082C9050)) == this)
            {
                    丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfFirst, 丏业丟一东丂东丘丛:  true);
                val_4 = this.enableIfMiddle;
                val_5 = 0;
            }
            else
            {
                    丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfFirst, 丏业丟一东丂东丘丛:  false);
                val_4 = this.enableIfMiddle;
                val_5 = 1;
            }
            
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
            if(this.gmhModeRewardsView == null)
            {
                goto label_10;
            }
            
            if(不丕三丌万丈丟丆世 != null)
            {
                goto label_11;
            }
            
            goto label_13;
            label_10:
            if(不丕三丌万丈丟丆世 == null)
            {
                goto label_13;
            }
            
            label_11:
            label_13:
            val_6 = 0;
            this.gmhModeRewardsView.丈且东丑丂且万丒丅(丂丛丑东不丅丈一东:  null);
        }
        public override void OnClick()
        {
            if(((this.丘丛丆丕且丂业世丌().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "locked")) != false) && (this.丘丛丂丛东丏丌丟且() != 0))
            {
                    PGCompany.GameModeHub.GMHModeSelector val_5 = this.丘丛丂丛东丏丌丟且();
                if(val_5.丅下且专丅世丒下七 != null)
            {
                    val_5.丅下且专丅世丒下七.Invoke(obj:  this.丘丛丆丕且丂业世丌());
            }
            
            }
            
            this.OnClick();
        }
        public GMHModeTab()
        {
            val_1 = new SelectableButton();
        }
    
    }

}
