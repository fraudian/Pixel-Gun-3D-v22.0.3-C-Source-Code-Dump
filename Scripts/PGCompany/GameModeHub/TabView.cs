using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class TabView : SelectableButton
    {
        // Fields
        private System.Action 丁与下万丄丑丐丗丐;
        private UILabel nameLabel;
        internal string tabId;
        internal string tabContent;
        
        // Methods
        internal void 丅与丆上东下丏丑世(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丁与下万丄丑丐丗丐, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁与下万丄丑丐丗丐 != 1152921560508644744);
        
        }
        internal void 丁世万丌丄且丌丅丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丁与下万丄丑丐丗丐, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁与下万丄丑丐丗丐 != 1152921560508781320);
        
        }
        internal void 丈且东丑丂且万丒丅(string 不下上丙三与业丌三)
        {
            this.tabId = 不下上丙三与业丌三;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  不下上丙三与业丌三);
            if(this.丁与下万丄丑丐丗丐 == null)
            {
                    return;
            }
            
            this.丁与下万丄丑丐丗丐.Invoke();
        }
        public TabView()
        {
        
        }
    
    }

}
