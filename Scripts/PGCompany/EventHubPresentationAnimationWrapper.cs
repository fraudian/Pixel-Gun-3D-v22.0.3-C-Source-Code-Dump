using UnityEngine;

namespace PGCompany
{
    public sealed class EventHubPresentationAnimationWrapper : PGBehaviour
    {
        // Fields
        internal PGCompany.EventHubPresentationAnimationWrapper.丝丂丕下丄丞东三上 丟下丞三丘丑丝业丟;
        
        // Methods
        public void PresentationEndAnimationEvent()
        {
            if(this.丟下丞三丘丑丝业丟 == null)
            {
                    return;
            }
            
            this.丟下丞三丘丑丝业丟.Invoke();
        }
        private void OnDestroy()
        {
            this.丟下丞三丘丑丝业丟 = 0;
        }
        public EventHubPresentationAnimationWrapper()
        {
        
        }
    
    }

}
