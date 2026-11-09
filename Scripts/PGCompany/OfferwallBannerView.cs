using UnityEngine;

namespace PGCompany
{
    internal sealed class OfferwallBannerView : MonoBehaviour
    {
        // Fields
        private Rilisoft.InAppBonusLobbyScrollView 业丘丘丕专丞丅丈丙;
        private UIButton _watchButton;
        
        // Properties
        internal Rilisoft.InAppBonusLobbyScrollView 上丛不专丂丐丝丛一 { get; }
        
        // Methods
        internal Rilisoft.InAppBonusLobbyScrollView 丂三专丂丂下丙丆丏()
        {
            Rilisoft.InAppBonusLobbyScrollView val_3;
            if(this.业丘丘丕专丞丅丈丙 == 0)
            {
                    this.业丘丘丕专丞丅丈丙 = this.GetComponentInParent<Rilisoft.InAppBonusLobbyScrollView>();
                return val_3;
            }
            
            val_3 = this.业丘丘丕专丞丅丈丙;
            return val_3;
        }
        public void OnButtonClicked()
        {
        
        }
        public OfferwallBannerView()
        {
        
        }
    
    }

}
