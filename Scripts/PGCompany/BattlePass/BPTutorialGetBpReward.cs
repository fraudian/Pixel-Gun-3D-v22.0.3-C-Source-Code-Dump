using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTutorialGetBpReward : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _animObject;
        private UnityEngine.Coroutine 业丛东丌丄丝下三三;
        
        // Methods
        private void OnClick()
        {
            var val_15;
            var val_16;
            System.Collections.Generic.IEnumerable<PGCompany.BattlePass.BPReward> val_3 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丑万丘丈业丁丟丏七();
            if(val_3 == null)
            {
                goto label_35;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = val_3.GetEnumerator();
            label_21:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().专业丙丛丌专下丛丂(丗七丟丈三不丕一三:  val_5.Current, 丂丅丑七丌不丄上丞:  true);
            goto label_21;
            label_13:
            val_15 = 0;
            val_16 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_5.Dispose();
            }
            
            label_35:
            if(this.业丛东丌丄丝下三三 != null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._animObject, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  this.丘丘不丌七丆世世不());
        }
        private void OnEnable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._animObject, 丏业丟一东丂东丘丛:  false);
        }
        private void OnDisable()
        {
            if(this.业丛东丌丄丝下三三 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.业丛东丌丄丝下三三);
            this.业丛东丌丄丝下三三 = 0;
        }
        private System.Collections.IEnumerator 丘丘不丌七丆世世不()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BPTutorialGetBpReward.丘丗丁丗东东丈丁丒();
        }
        public BPTutorialGetBpReward()
        {
        
        }
    
    }

}
