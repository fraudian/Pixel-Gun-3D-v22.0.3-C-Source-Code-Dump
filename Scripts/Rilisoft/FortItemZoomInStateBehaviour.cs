using UnityEngine;

namespace Rilisoft
{
    internal class FortItemZoomInStateBehaviour : StateMachineBehaviour
    {
        // Methods
        public override void OnStateEnter(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            this.OnStateEnter(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            丌上世不丗丁丐业丕.SetBool(name:  "INTERNAL_InItemsSM", value:  true);
        }
        public override void OnStateExit(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            var val_2;
            Rilisoft.FortCraftController val_3;
            var val_4;
            this.OnStateEnter(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            val_2 = null;
            val_2 = null;
            val_3 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
            val_3.OnZoomIn();
        }
        public FortItemZoomInStateBehaviour()
        {
        
        }
    
    }

}
