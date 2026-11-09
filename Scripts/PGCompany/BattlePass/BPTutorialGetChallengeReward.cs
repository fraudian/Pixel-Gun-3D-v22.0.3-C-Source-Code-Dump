using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTutorialGetChallengeReward : MonoBehaviour
    {
        // Fields
        private UnityEngine.Coroutine 丐丁丆丈丁世丁上丙;
        private ParticleAtraktor _rewardAttractor;
        private UnityEngine.GameObject _doneButton;
        private UnityEngine.GameObject _claimButton;
        
        // Methods
        private void OnClick()
        {
            this.U_Claim();
        }
        public void U_Claim()
        {
            UnityEngine.Object val_10;
            var val_11;
            System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean> val_13;
            val_10 = this;
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_2 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
            if(val_2 != null)
            {
                    val_11 = null;
                val_11 = null;
                val_13 = BPTutorialGetChallengeReward.<>c.<>9__5_0;
                if(val_13 == null)
            {
                    System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean> val_3 = null;
                val_13 = val_3;
                val_3 = new System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean>(object:  BPTutorialGetChallengeReward.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPTutorialGetChallengeReward.<>c::丛丑丅丑丟丅丏丄不(PGCompany.BattlePass.BPChallengeRememberedReward 东七上世万下丗丄丛));
                BPTutorialGetChallengeReward.<>c.<>9__5_0 = val_13;
            }
            
                PGCompany.BattlePass.BPChallengeRememberedReward val_4 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_2, predicate:  val_3);
                if(val_4 != null)
            {
                    this.丐丁丆丈丁世丁上丙 = this.StartCoroutine(routine:  this.东七万一丞丗丁且下(丗七丟丈三不丕一三:  val_4));
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._claimButton, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._doneButton, 丏业丟一东丂东丘丛:  true);
            }
            
            }
            
            if(this.丐丁丆丈丁世丁上丙 != null)
            {
                    return;
            }
            
            val_10 = PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世();
            if(val_10 == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().U_SkipStep();
        }
        private System.Collections.IEnumerator 东七万一丞丗丁且下(PGCompany.BattlePass.BPChallengeRememberedReward 丗七丟丈三不丕一三)
        {
            BPTutorialGetChallengeReward.丛丟丒丒业丈丘世丁 val_1 = new BPTutorialGetChallengeReward.丛丟丒丒业丈丘世丁();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丗七丟丈三不丕一三 = 丗七丟丈三不丕一三;
            return (System.Collections.IEnumerator)val_1;
        }
        private void OnDisable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._doneButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._claimButton, 丏业丟一东丂东丘丛:  true);
            if(this.丐丁丆丈丁世丁上丙 != null)
            {
                    this.StopCoroutine(routine:  this.丐丁丆丈丁世丁上丙);
                this.丐丁丆丈丁世丁上丙 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rewardAttractor, 丏业丟一东丂东丘丛:  false);
        }
        public BPTutorialGetChallengeReward()
        {
        
        }
    
    }

}
