using UnityEngine;

namespace RilisoftBot
{
    internal class CubeBossAnimationController : MonoBehaviour
    {
        // Fields
        private RilisoftBot.CubeBossAnimationController.丄丞丂丑东上丝丁丛 丝丘一丂业与丙世业;
        public RilisoftBot.BotAiController controller;
        public RilisoftBot.SwitchLogicBaseBot baseLogic;
        public UnityEngine.Animation animation;
        private RilisoftBot.CubeBossAnimationController.丄丞丂丑东上丝丁丛 丈丙七丕丘丟丌业丛;
        private float 丂三丟丂丈丐丆丗丟;
        public System.Collections.Generic.List<RilisoftBot.CubeBossAnimationController.CubeBossSide> listBossSide;
        
        // Methods
        private void OnEnable()
        {
            this.baseLogic.万丁丒世丁丗丐丐专(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void RilisoftBot.CubeBossAnimationController::丄下丏丌丈东世上不(RilisoftBot.BaseBot 丗丝丝专丞七丌丂东)));
            this.baseLogic.一且业丏世丞丂丙丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RilisoftBot.CubeBossAnimationController::东丅业不上丗专丝丑()));
        }
        private void OnDisable()
        {
            this.baseLogic.丗上上不七丙丏丒丝(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void RilisoftBot.CubeBossAnimationController::丄下丏丌丈东世上不(RilisoftBot.BaseBot 丗丝丝专丞七丌丂东)));
            this.baseLogic.丝专业下丌丟世一丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RilisoftBot.CubeBossAnimationController::东丅业不上丗专丝丑()));
        }
        private void 丅丒丒丛丙东一一业()
        {
            System.Collections.IEnumerator val_1 = this.丅丒丒丛丙东一一业(丈丙七丕丘丟丌业丛:  this.丈丙七丕丘丟丌业丛);
        }
        internal void 丄下丏丌丈东世上不(RilisoftBot.BaseBot 丗丝丝专丞七丌丂东)
        {
            var val_6;
            System.Collections.Generic.List<CubeBossSide> val_7;
            val_6 = this;
            val_7 = this.listBossSide;
            List.Enumerator<T> val_1 = val_7.GetEnumerator();
            label_6:
            if((2029973480 & 1) == 0)
            {
                goto label_2;
            }
            
            val_7 = 0.丐丏七丌丕丗业且上();
            if(X22 != 丗丝丝专丞七丌丂东)
            {
                goto label_6;
            }
            
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丅丒丒丛丙东一一业(丈丙七丕丘丟丌业丛:  val_2.m_stringLength));
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 丄下丏丌丈东世上不(RilisoftBot.CubeBossAnimationController.丄丞丂丑东上丝丁丛 丑丆世万丞丄丞丈世)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丅丒丒丛丙东一一业(丈丙七丕丘丟丌业丛:  丑丆世万丞丄丞丈世));
        }
        internal void 东丅业不上丗专丝丑()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丅丒丒丛丙东一一业(丈丙七丕丘丟丌业丛:  2));
        }
        internal System.Collections.IEnumerator 丅丒丒丛丙东一一业(RilisoftBot.CubeBossAnimationController.丄丞丂丑东上丝丁丛 丈丙七丕丘丟丌业丛)
        {
            CubeBossAnimationController.与丈丛丁万丙与丒丈 val_1 = new CubeBossAnimationController.与丈丛丁万丙与丒丈();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丈丙七丕丘丟丌业丛 = 丈丙七丕丘丟丌业丛;
            return (System.Collections.IEnumerator)val_1;
        }
        public CubeBossAnimationController()
        {
            this.listBossSide = new System.Collections.Generic.List<CubeBossSide>();
        }
    
    }

}
