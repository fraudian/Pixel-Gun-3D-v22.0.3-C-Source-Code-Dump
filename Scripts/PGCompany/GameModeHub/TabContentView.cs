using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class TabContentView : PGBehaviour
    {
        // Fields
        private System.Action 丁与下万丄丑丐丗丐;
        private PGCompany.GameModeHub.TabView 且丆丂丝世上万丂与;
        private UILabel nameLabel;
        
        // Properties
        internal PGCompany.GameModeHub.TabView 一丐丛丏东上专丆丐 { get; }
        
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
            while(this.丁与下万丄丑丐丗丐 != 1152921560506636408);
        
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
            while(this.丁与下万丄丑丐丗丐 != 1152921560506772984);
        
        }
        internal PGCompany.GameModeHub.TabView 丁丟丛丑丑与与丝万()
        {
            return (PGCompany.GameModeHub.TabView)this.且丆丂丝世上万丂与;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.TabView 丐丅丒专丛丏上与业)
        {
            this.且丆丂丝世上万丂与 = 丐丅丒专丛丏上与业;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  丐丅丒专丛丏上与业.tabId);
            if(this.丁与下万丄丑丐丗丐 == null)
            {
                    return;
            }
            
            this.丁与下万丄丑丐丗丐.Invoke();
        }
        public TabContentView()
        {
        
        }
    
    }

}
