using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTutorialGoToBattle : MonoBehaviour
    {
        // Methods
        private void OnClick()
        {
            if(PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世() != 0)
            {
                    PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().U_SkipStep();
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().GoBattleRequest(丟专三丙丒丄丂下与:  0);
        }
        public BPTutorialGoToBattle()
        {
        
        }
    
    }

}
