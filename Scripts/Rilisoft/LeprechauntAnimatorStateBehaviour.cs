using UnityEngine;

namespace Rilisoft
{
    public class LeprechauntAnimatorStateBehaviour : StateMachineBehaviour
    {
        // Fields
        private string _stateName;
        
        // Methods
        public override void OnStateExit(UnityEngine.Animator 丌上世不丗丁丐业丕, UnityEngine.AnimatorStateInfo 不丅丗丈世丏东七丅, int 丞丅下丙丏丘丟丁不)
        {
            this.OnStateExit(animator:  丌上世不丗丁丐业丕, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = 不丅丗丈世丏东七丅.m_Name, m_Length = 不丅丗丈世丏东七丅.m_Length, m_Loop = 不丅丗丈世丏东七丅.m_Loop}, layerIndex:  丞丅下丙丏丘丟丁不);
            if(Rilisoft.LeprechauntLobbyView.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            this = this._stateName;
            Rilisoft.LeprechauntLobbyView.丆丕丝丒不丙且丐丗.OnAnimatorStateExit(丕丆丂丛丐三丙丐万:  this);
        }
        public LeprechauntAnimatorStateBehaviour()
        {
        
        }
    
    }

}
