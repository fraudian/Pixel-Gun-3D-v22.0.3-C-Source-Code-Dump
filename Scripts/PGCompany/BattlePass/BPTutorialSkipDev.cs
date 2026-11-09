using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPTutorialSkipDev : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _skipTutorialObject;
        
        // Methods
        private void OnEnable()
        {
            this._skipTutorialObject.SetActive(value:  false);
        }
        public void U_SkipTutorial()
        {
        
        }
        public BPTutorialSkipDev()
        {
        
        }
    
    }

}
