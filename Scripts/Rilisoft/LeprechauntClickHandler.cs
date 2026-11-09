using UnityEngine;

namespace Rilisoft
{
    public class LeprechauntClickHandler : MonoBehaviour
    {
        // Methods
        private void OnClick()
        {
            if((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance) == 0)
            {
                    return;
            }
            
            Rilisoft.LeprechauntLobbyView.丆丕丝丒不丙且丐丗.Tap();
        }
        public LeprechauntClickHandler()
        {
        
        }
    
    }

}
