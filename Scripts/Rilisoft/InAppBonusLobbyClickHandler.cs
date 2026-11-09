using UnityEngine;

namespace Rilisoft
{
    public class InAppBonusLobbyClickHandler : MonoBehaviour
    {
        // Methods
        private void OnClick()
        {
            if((Rilisoft.InAppBonusLobbyController.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            Rilisoft.InAppBonusLobbyController.<不丁丄七丛不丆丁丕>k__BackingField.Click();
        }
        public InAppBonusLobbyClickHandler()
        {
        
        }
    
    }

}
