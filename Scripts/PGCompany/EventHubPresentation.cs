using UnityEngine;

namespace PGCompany
{
    public sealed class EventHubPresentation : PGBehaviour
    {
        // Fields
        private int 丂世丅下万丞一丄丑;
        public PGCompany.EventHubPresentationAnimationWrapper animationWrapper;
        public bool fog;
        public UnityEngine.Color fogColor;
        public UnityEngine.Color ambientLignt;
        public System.Action OnSkipButtonClick;
        public UnityEngine.GameObject _skipLabel;
        
        // Methods
        private void OnEnable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._skipLabel, 丏业丟一东丂东丘丛:  false);
            this.丂世丅下万丞一丄丑 = 0;
        }
        public void U_SkipButtonClick()
        {
            int val_2 = this.丂世丅下万丞一丄丑 + 1;
            this.丂世丅下万丞一丄丑 = val_2;
            if(this.丂世丅下万丞一丄丑 == 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._skipLabel, 丏业丟一东丂东丘丛:  true);
                val_2 = this.丂世丅下万丞一丄丑;
            }
            
            if(val_2 != 2)
            {
                    return;
            }
            
            if(this.OnSkipButtonClick == null)
            {
                    return;
            }
            
            this.OnSkipButtonClick.Invoke();
        }
        public EventHubPresentation()
        {
        
        }
    
    }

}
