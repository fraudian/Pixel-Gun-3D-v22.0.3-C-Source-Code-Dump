using UnityEngine;

namespace Rilisoft
{
    internal class FreeAwardClickHandler : MonoBehaviour
    {
        // Methods
        private void OnClick()
        {
            if(FreeAwardShowHandler.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            FreeAwardShowHandler.丑七不且上丗丁一世().OnClick();
        }
        public FreeAwardClickHandler()
        {
        
        }
    
    }

}
