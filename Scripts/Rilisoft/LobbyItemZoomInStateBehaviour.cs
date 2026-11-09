using UnityEngine;

namespace Rilisoft
{
    internal class LobbyItemZoomInStateBehaviour : StateMachineBehaviour
    {
        // Fields
        internal static bool IsFromTasks;
        
        // Methods
        public override void OnStateEnter(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            this.OnStateEnter(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            丌上世不丗丁丐业丕.SetBool(name:  "INTERNAL_InItemsSM", value:  true);
        }
        public override void OnStateExit(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            var val_2;
            var val_3;
            this.OnStateEnter(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_2 = null;
                val_2 = null;
                if(Rilisoft.LobbyItemZoomInStateBehaviour.IsFromTasks != true)
            {
                    Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.OnZoomIn();
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            Rilisoft.LobbyItemZoomInStateBehaviour.IsFromTasks = false;
        }
        public LobbyItemZoomInStateBehaviour()
        {
        
        }
        private static LobbyItemZoomInStateBehaviour()
        {
        
        }
    
    }

}
