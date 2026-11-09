using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class GMHEntityTab : SelectableButton
    {
        // Fields
        internal UIWidget widget;
        protected PGCompany.GameModeHub.GMHEntityView entityView;
        protected PGCompany.GameModeHub.三丙专上下万七丛东 丅丒不七丒丘与丟丅;
        
        // Properties
        internal PGCompany.GameModeHub.三丙专上下万七丛东 丙不一丒下三一七丙 { get; }
        
        // Methods
        internal PGCompany.GameModeHub.三丙专上下万七丛东 丆不且一丞不东丐下()
        {
            return (PGCompany.GameModeHub.三丙专上下万七丛东)this.丅丒不七丒丘与丟丅;
        }
        internal virtual void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世)
        {
            var val_2;
            this.丅丒不七丒丘与丟丅 = 不丕三丌万丈丟丆世;
            if((this.丅丒不七丒丘与丟丅.<丙丝万丈丟丕丛丑丗>k__BackingField.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "locked")) != false)
            {
                    val_2 = public System.Void SelectableButton::Disable();
            }
            else
            {
                    val_2 = public System.Void SelectableButton::Enable();
            }
            
            this.Enable();
        }
        public GMHEntityTab()
        {
        
        }
    
    }

}
