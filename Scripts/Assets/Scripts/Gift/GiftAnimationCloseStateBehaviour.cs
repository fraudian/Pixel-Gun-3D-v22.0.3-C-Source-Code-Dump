using UnityEngine;

namespace Assets.Scripts.Gift
{
    internal class GiftAnimationCloseStateBehaviour : StateMachineBehaviour
    {
        // Fields
        internal static bool IsFromTasks;
        
        // Methods
        public override void OnStateExit(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            var val_2;
            var val_3;
            ButOpenGift val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            this.OnStateEnter(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            丌上世不丗丁丐业丕.SetBool(name:  "INTERNAL_InGachaSM", value:  false);
            val_2 = 1152921505204236288;
            val_3 = null;
            val_3 = null;
            val_4 = ButOpenGift.丄丘七三上丕世丞业;
            val_5 = null;
            if(val_4 == 0)
            {
                goto label_6;
            }
            
            val_5 = null;
            if(Assets.Scripts.Gift.GiftAnimationCloseStateBehaviour.IsFromTasks == false)
            {
                goto label_9;
            }
            
            label_6:
            val_5 = null;
            if(Assets.Scripts.Gift.GiftAnimationCloseStateBehaviour.IsFromTasks == false)
            {
                goto label_16;
            }
            
            val_2 = 1152921505080860672;
            val_6 = null;
            val_6 = null;
            val_4 = MainMenuController.丄丞丁丈与业上丞丟;
            val_4.ShowSavePanel(丁丗丏东七不丞丒丄:  true);
            MainMenuController.丞且丙丛丞不世专七 = true;
            goto label_16;
            label_9:
            val_7 = null;
            val_7 = null;
            val_4 = ButOpenGift.丄丘七三上丕世丞业;
            val_4.CloseGift();
            label_16:
            val_8 = null;
            val_8 = null;
            Assets.Scripts.Gift.GiftAnimationCloseStateBehaviour.IsFromTasks = false;
        }
        public GiftAnimationCloseStateBehaviour()
        {
        
        }
        private static GiftAnimationCloseStateBehaviour()
        {
        
        }
    
    }

}
