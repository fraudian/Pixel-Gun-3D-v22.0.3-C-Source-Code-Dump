using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTotorialGoToChallenges : MonoBehaviour
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
            
            PGCompany.BattlePass.BattlePassChallangesUI.丟丄丐一七东不丁且(丙业与丙丗丝不丈东:  1);
            BattlePassRootUI.丑七不且上丗丁一世().ChangeState(专丂丕丗丗东世丞下:  2);
        }
        public BPTotorialGoToChallenges()
        {
        
        }
    
    }

}
