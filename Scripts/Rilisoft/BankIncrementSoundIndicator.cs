using UnityEngine;

namespace Rilisoft
{
    public class BankIncrementSoundIndicator : MonoBehaviour
    {
        // Fields
        public UnityEngine.AudioClip ClipCoinAdded;
        public UnityEngine.AudioClip ClipCoinsAdded;
        public UnityEngine.AudioClip ClipGemAdded;
        public UnityEngine.AudioClip ClipGemsAdded;
        public float PlayDelay;
        private UnityEngine.AudioClip _clanSilverAdded;
        
        // Methods
        private void OnEnable()
        {
            CoinsMessage.下丗丑且专丝丈丁三(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.BankIncrementSoundIndicator::丛世丝业丘三专业专(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)));
            BankController.丗丂万世上世丂三丆(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Single>(object:  this, method:  System.Void Rilisoft.BankIncrementSoundIndicator::丆七丐丙上下丆丆世(int 丌丒丝东丌下丕丁丅, float 不丁丌丐业丑丟且不)));
        }
        private void OnDisable()
        {
            CoinsMessage.丐上丈丆专不不丑丟(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.BankIncrementSoundIndicator::丛世丝业丘三专业专(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)));
            BankController.丛不丝丂且丅丕丈丘(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Single>(object:  this, method:  System.Void Rilisoft.BankIncrementSoundIndicator::丆七丐丙上下丆丆世(int 丌丒丝东丌下丕丁丅, float 不丁丌丐业丑丟且不)));
        }
        private void 丛世丝业丘三专业专(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)
        {
            null = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
            {
                    if(GameConnect.上丏丈七丘丁与丅丏() == true)
            {
                goto label_6;
            }
            
            }
            
            label_6:
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.下丛丏七下丑丂丌丘(丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅, 丗专丕丑丝丕东三丆:  (丌丒丝东丌下丕丁丅 < 2) ? 1 : 0, 丕丕世且下一与丝与:  this.PlayDelay));
        }
        private void 丆七丐丙上下丆丆世(int 丌丒丝东丌下丕丁丅, float 不丁丌丐业丑丟且不)
        {
            var val_5;
            float val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
            {
                goto label_3;
            }
            
            val_6 = 0f;
            if(GameConnect.上丏丈七丘丁与丅丏() == true)
            {
                goto label_6;
            }
            
            label_3:
            val_6 = this.PlayDelay;
            label_6:
            val_7 = null;
            val_7 = null;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.下丛丏七下丑丂丌丘(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丗专丕丑丝丕东三丆:  (丌丒丝东丌下丕丁丅 < 2) ? 1 : 0, 丕丕世且下一与丝与:  val_6));
        }
        private System.Collections.IEnumerator 下丛丏七下丑丂丌丘(string 丏丂不专上丘丂不丅, bool 丗专丕丑丝丕东三丆, float 丕丕世且下一与丝与)
        {
            BankIncrementSoundIndicator.丅下丕丞丗一丈丁丗 val_1 = new BankIncrementSoundIndicator.丅下丕丞丗一丈丁丗();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丏丂不专上丘丂不丅 = 丏丂不专上丘丂不丅;
                .丗专丕丑丝丕东三丆 = 丗专丕丑丝丕东三丆;
            }
            else
            {
                    mem[56] = this;
                mem[40] = 丏丂不专上丘丂不丅;
                mem[48] = 丗专丕丑丝丕东三丆;
            }
            
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            return (System.Collections.IEnumerator)val_1;
        }
        public BankIncrementSoundIndicator()
        {
            this.PlayDelay = 0.1f;
        }
    
    }

}
