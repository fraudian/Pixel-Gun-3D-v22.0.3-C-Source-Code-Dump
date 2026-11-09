using UnityEngine;

namespace Rilisoft
{
    internal class LobbyItemZoomOutStateBehaviour : StateMachineBehaviour
    {
        // Fields
        internal static bool IsFromTasks;
        
        // Methods
        public override void OnStateExit(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            var val_2;
            var val_3;
            UnityEngine.GameObject val_4;
            var val_5;
            this.OnStateEnter(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            丌上世不丗丁丐业丕.SetBool(name:  "INTERNAL_InItemsSM", value:  false);
            val_2 = null;
            val_2 = null;
            if(Rilisoft.LobbyItemZoomOutStateBehaviour.IsFromTasks != false)
            {
                    val_3 = null;
                val_3 = null;
                val_4 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_4 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
                val_5 = null;
                val_5 = null;
                Rilisoft.LobbyItemZoomOutStateBehaviour.IsFromTasks = false;
                return;
            }
            
            val_4 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            val_4.OnZoomOut();
        }
        public LobbyItemZoomOutStateBehaviour()
        {
        
        }
        private static LobbyItemZoomOutStateBehaviour()
        {
        
        }
    
    }

}
