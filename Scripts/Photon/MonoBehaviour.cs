using UnityEngine;

namespace Photon
{
    public class MonoBehaviour : MonoBehaviour
    {
        // Fields
        private PhotonView 丗丕丄东上丐丝丈丌;
        
        // Properties
        public PhotonView 丄丈丑丐丆丞丘与丗 { get; }
        
        // Methods
        public PhotonView get_photonView()
        {
            PhotonView val_3;
            if(this.丗丕丄东上丐丝丈丌 == 0)
            {
                    this.丗丕丄东上丐丝丈丌 = PhotonView.Get(丑丅丈东丐丐丕丞丙:  this);
                return val_3;
            }
            
            val_3 = this.丗丕丄东上丐丝丈丌;
            return val_3;
        }
        public MonoBehaviour()
        {
        
        }
    
    }

}
