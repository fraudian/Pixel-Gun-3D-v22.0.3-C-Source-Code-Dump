using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTutorialGoToBuyPrem : MonoBehaviour
    {
        // Methods
        private void OnClick()
        {
            if(PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世() != 0)
            {
                    PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().U_SkipStep();
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().U_BuyPremium();
        }
        public BPTutorialGoToBuyPrem()
        {
        
        }
    
    }

}
