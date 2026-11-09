using UnityEngine;

namespace PGCompany
{
    internal class ButtonSelectModule : MonoBehaviour
    {
        // Fields
        private PGCompany.ModuleInsertPanel _moduleInsertPanel;
        private PGCompany.ModuleSlotView _moduleSlotView;
        
        // Methods
        public void SelectModule()
        {
            if(this._moduleSlotView.丁世下丘丝丆不不丁() == null)
            {
                    return;
            }
            
            ButtonClickSound.丁业上丏不丕三丗不();
            this._moduleInsertPanel.丌丌丘丝一丂丅一丄(一专上丑丐丆丄上丟:  this._moduleSlotView);
        }
        public ButtonSelectModule()
        {
        
        }
    
    }

}
