using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTutorialConnectSceneButton : MonoBehaviour
    {
        // Methods
        private void OnClick()
        {
            var val_5;
            if(PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世() != 0)
            {
                    PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().U_SkipStep();
            }
            
            val_5 = null;
            val_5 = null;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.connectScene, 丏业丟一东丂东丘丛:  false);
            PGCompany.BattlePass.BattlePassChallangesUI.丟丄丐一七东不丁且(丙业与丙丗丝不丈东:  1);
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  2);
            PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一 = 9999;
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 2;
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  31, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        public BPTutorialConnectSceneButton()
        {
        
        }
    
    }

}
