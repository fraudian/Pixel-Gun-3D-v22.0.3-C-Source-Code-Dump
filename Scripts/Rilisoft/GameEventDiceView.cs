using UnityEngine;

namespace Rilisoft
{
    public class GameEventDiceView : MonoBehaviour, 世丙丘下丝丗上下丏<int>, 丗丘丄丌丞丘丟丞世
    {
        // Fields
        private const string 丞三三丐丏东丆丈丝 = "Value";
        private const string 与且丙不不丏丑丄丏 = "Drop";
        private UnityEngine.Coroutine 丁专专丞丘丘丙丟三;
        private UnityEngine.GameObject _body;
        private UnityEngine.Animator _animator;
        private int <丅丝丌丝丁丏丙东丞>k__BackingField;
        
        // Properties
        public int 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public void PlayAnimation(Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒 丅与丐与丝丆专一专, System.Action 世丅丙世不三丈世丅)
        {
            if(this.丁专专丞丘丘丙丟三 != null)
            {
                    this.StopCoroutine(routine:  this.丁专专丞丘丘丙丟三);
            }
            
            this.丁专专丞丘丘丙丟三 = this.StartCoroutine(routine:  this.一七丞东丂丅上丅东(世丅丙世不三丈世丅:  世丅丙世不三丈世丅));
        }
        public void Setup(int 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
        }
        private System.Collections.IEnumerator 一七丞东丂丅上丅东(System.Action 世丅丙世不三丈世丅)
        {
            GameEventDiceView.丐丙丟丌一业一丝一 val_1 = new GameEventDiceView.丐丙丟丌一业一丝一();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .世丅丙世不三丈世丅 = 世丅丙世不三丈世丅;
            return (System.Collections.IEnumerator)val_1;
        }
        public int get_Context()
        {
            return (int)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(int 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public GameEventDiceView()
        {
        
        }
    
    }

}
