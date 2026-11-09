using UnityEngine;

namespace Assets.Scripts.Gift
{
    internal class GiftAnimationOpenStateBehaviour : StateMachineBehaviour
    {
        // Fields
        internal static bool IsFromTasks;
        private float _callCallbackAfter;
        
        // Methods
        public override void OnStateEnter(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            var val_3;
            this.OnStateEnter(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            丌上世不丗丁丐业丕.SetBool(name:  "INTERNAL_InGachaSM", value:  true);
            if(this._callCallbackAfter <= 0f)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if(Assets.Scripts.Gift.GiftAnimationOpenStateBehaviour.IsFromTasks == true)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this._callCallbackAfter, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void Assets.Scripts.Gift.GiftAnimationOpenStateBehaviour::丒万业丛丏东专世丟()));
        }
        public override void OnStateExit(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            var val_1;
            this.OnStateEnter(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            val_1 = null;
            if(this._callCallbackAfter > 0f)
            {
                
            }
            else
            {
                    val_1 = null;
                if(Assets.Scripts.Gift.GiftAnimationOpenStateBehaviour.IsFromTasks != true)
            {
                    this.丒万业丛丏东专世丟();
                val_1 = null;
            }
            
            }
            
            Assets.Scripts.Gift.GiftAnimationOpenStateBehaviour.IsFromTasks = false;
        }
        private void 丒万业丛丏东专世丟()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if(GiftBannerWindow.丄丘七三上丕世丞业.gameObject.activeInHierarchy != false)
            {
                    val_7 = null;
                val_7 = null;
                GiftBannerWindow.丄丘七三上丕世丞业.OpenBannerWindow(丈丈不丒丗与丝不丗:  true);
                GiftBannerWindow.丄丘七三上丕世丞业.丗丅专丌丒丗且丞丟();
                return;
            }
            
            MainMenuHeroCamera.丑七不且上丗丁一世().PlayCloseGift();
        }
        private void 丗丅专丌丒丗且丞丟()
        {
            var val_6;
            var val_7;
            if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() == false)
            {
                    return;
            }
            
            val_6 = QuestsGSMAnager.丑七不且上丗丁一世();
            if(val_6.ActiveTask != null)
            {
                    return;
            }
            
            val_6 = QuestsGSMAnager.丑七不且上丗丁一世();
            if(val_6.NumCompletedTasks != 4)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            ShowSmallHint(丒丘丏上丙丟丑丕丈:  "do_training_gacha", 丘丂丘丂丁丌丂丏丘:  0);
        }
        public GiftAnimationOpenStateBehaviour()
        {
        
        }
        private static GiftAnimationOpenStateBehaviour()
        {
        
        }
    
    }

}
