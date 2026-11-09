using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPDailyRewardView : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform 丙丄下丛且丕丙丗丗;
        private UnityEngine.GameObject _panel;
        private UILabel _countLabel;
        
        // Methods
        public void SwithOn(UnityEngine.Transform 丗东三与上上丂丟丅)
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if((val_2 == null) || (BattlePassRootUI.丑七不且上丗丁一世() == 0))
            {
                goto label_7;
            }
            
            BattlePassRootUI val_5 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_5.丒丂业丒一丏丝丟丆 == false)
            {
                goto label_11;
            }
            
            label_7:
            this.gameObject.SetActive(value:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._panel, 丏业丟一东丂东丘丛:  false);
            return;
            label_11:
            this.gameObject.SetActive(value:  val_2.丐七丝丝丌丛上丑丑());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._panel, 丏业丟一东丂东丘丛:  val_2.丐七丝丝丌丛上丑丑());
            PGCompany.BattlePass.BPData val_12 = val_2.丁专丗万三上丟三丆();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._countLabel, 丕丗丘丑丛与丑业丒:  val_12._dailyExp);
            this.丙丄下丛且丕丙丗丗 = 丗东三与上上丂丟丅;
        }
        public void U_GiveReward()
        {
            UnityEngine.Transform val_14;
            var val_15;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if((val_2 != null) && (val_2.丐七丝丝丌丛上丑丑() != false))
            {
                    val_14 = val_2.业丈丅丂且丁与丄丂();
                val_15 = null;
                val_15 = null;
                PGCompany.BattlePass.BattlePassLevelView.世丑上丝上且丌丌丟 = PGCompany.BattlePass.BattlePassSettings.不丈丑丑丆丁上下丛();
                val_2.与业上丑丛丅且丙丐();
                不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  PGCompany.BattlePass.BattlePassSettings.Instance.GiveBPExpStartAudioClip).丟丅丐万业丑下丗丅();
                if(val_2.业丈丅丂且丁与丄丂() == val_14)
            {
                    val_14 = this.丙丄下丛且丕丙丗丗;
                PGCompany.BattlePass.BPData val_13 = val_2.丁专丗万三上丟三丆();
                this.业丁丞不业丘下七丄(丞下万上三丘上与专:  val_14, 丄万不且丂丛丘业丐:  val_13._dailyExp);
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._panel, 丏业丟一东丂东丘丛:  false);
        }
        private void OnDisable()
        {
            this.丟丅丐万业丑下丗丅();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._panel, 丏业丟一东丂东丘丛:  false);
        }
        private void 丟丅丐万业丑下丗丅()
        {
            BattlePassRootUI val_8 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8 = BattlePassRootUI.丑七不且上丗丁一世().丈丁丄丈丏下丁丞丅();
            if(val_8 == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().丈丁丄丈丏下丁丞丅().丌丄丏下七丁专丂世();
        }
        private void 业丁丞不业丘下七丄(UnityEngine.Transform 丞下万上三丘上与专, int 丄万不且丂丛丘业丐)
        {
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世().丈丁丄丈丏下丁丞丅() == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_9 = this.transform.position;
            BattlePassRootUI.丑七不且上丗丁一世().丈丁丄丈丏下丁丞丅().三且世三丂七丐一丟(丈万丏丈上丑不丅上:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丞下万上三丘上与专:  丞下万上三丘上与专, 丄万不且丂丛丘业丐:  丄万不且丂丛丘业丐);
        }
        public BPDailyRewardView()
        {
        
        }
    
    }

}
