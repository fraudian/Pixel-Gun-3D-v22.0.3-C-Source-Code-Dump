using UnityEngine;

namespace Rilisoft
{
    public class OnClickAction : MonoBehaviour
    {
        // Fields
        private UnityEngine.Events.UnityEvent _events;
        
        // Methods
        private void OnClick()
        {
            if(this._events == null)
            {
                    return;
            }
            
            this._events.Invoke();
        }
        public OnClickAction()
        {
        
        }
    
    }

}
