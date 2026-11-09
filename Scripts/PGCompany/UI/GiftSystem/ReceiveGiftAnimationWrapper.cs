using UnityEngine;

namespace PGCompany.UI.GiftSystem
{
    internal sealed class ReceiveGiftAnimationWrapper : PGBehaviour
    {
        // Fields
        private UnityEngine.Animator _animator;
        private static readonly int 丐丂专与丄专丆丁丁;
        private static readonly int 丗丏丛七丐丗丌且丝;
        private static readonly int 三丙丁丙业与丒丞丑;
        private const string 丁丞业丆万下丙不且 = "GiftBox_outro";
        internal System.Action 与丛上丞丈丏东万万;
        
        // Methods
        private void Awake()
        {
            this._animator = this.GetComponent<UnityEngine.Animator>();
        }
        private void Start()
        {
            this.丝丗上与丁下丐丐丞(丅丙丛丞下丟上下丗:  "GiftBox_outro");
        }
        private void 丝丗上与丁下丐丐丞(string 丅丙丛丞下丟上下丗)
        {
            goto label_3;
            label_11:
            UnityEngine.AnimationClip val_8 = this._animator.runtimeAnimatorController.animationClips[0];
            if((System.String.op_Inequality(a:  val_8.name, b:  丅丙丛丞下丟上下丗)) == true)
            {
                goto label_6;
            }
            
            UnityEngine.AnimationEvent[] val_5 = val_8.events;
            if(val_5.Length == 0)
            {
                goto label_9;
            }
            
            label_6:
            0 = 1;
            label_3:
            if(0 < val_2.Length)
            {
                goto label_11;
            }
            
            return;
            label_9:
            UnityEngine.AnimationEvent val_6 = new UnityEngine.AnimationEvent();
            float val_7 = val_8.length;
            if(val_6 != null)
            {
                    val_6.time = val_7;
            }
            else
            {
                    val_6.time = val_7;
            }
            
            val_6.functionName = "OnAnimationCloseEndEvent";
            val_8.AddEvent(evt:  val_6);
        }
        internal void 丗丂万丙丌一丁万丏()
        {
            goto label_0;
            label_7:
            UnityEngine.AnimatorControllerParameter val_1 = this._animator.GetParameter(index:  0);
            if(val_1.type == 9)
            {
                    this._animator.ResetTrigger(name:  val_1.name);
            }
            
            0 = 1;
            label_0:
            if(0 < this._animator.parameterCount)
            {
                goto label_7;
            }
        
        }
        internal void 丗三丕丝丘丆丂一丆()
        {
            null = null;
            this._animator.SetTrigger(id:  PGCompany.UI.GiftSystem.ReceiveGiftAnimationWrapper.丁丞业丆万下丙不且);
        }
        internal void 丟专与丄专且丂下且()
        {
            null = null;
            this._animator.SetTrigger(id:  PGCompany.UI.GiftSystem.ReceiveGiftAnimationWrapper.丗丏丛七丐丗丌且丝);
        }
        internal void 丄丂丌丅不丛世丘一()
        {
            null = null;
            this._animator.SetTrigger(id:  PGCompany.UI.GiftSystem.ReceiveGiftAnimationWrapper.三丙丁丙业与丒丞丑);
        }
        internal void OnAnimationCloseEndEvent()
        {
            if(this.与丛上丞丈丏东万万 == null)
            {
                    return;
            }
            
            this.与丛上丞丈丏东万万.Invoke();
        }
        public ReceiveGiftAnimationWrapper()
        {
        
        }
        private static ReceiveGiftAnimationWrapper()
        {
            PGCompany.UI.GiftSystem.ReceiveGiftAnimationWrapper.丁丞业丆万下丙不且 = UnityEngine.Animator.StringToHash(name:  "Unpack gift");
            PGCompany.UI.GiftSystem.ReceiveGiftAnimationWrapper.丗丏丛七丐丗丌且丝 = UnityEngine.Animator.StringToHash(name:  "Close gift");
            PGCompany.UI.GiftSystem.ReceiveGiftAnimationWrapper.三丙丁丙业与丒丞丑 = UnityEngine.Animator.StringToHash(name:  "Outro To Exit");
        }
    
    }

}
