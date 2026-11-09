using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTutorialGoToMainBpUI : MonoBehaviour
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
            
            BattlePassRootUI.丑七不且上丗丁一世().ChangeState(专丂丕丗丗东世丞下:  1);
        }
        public BPTutorialGoToMainBpUI()
        {
        
        }
    
    }

}
