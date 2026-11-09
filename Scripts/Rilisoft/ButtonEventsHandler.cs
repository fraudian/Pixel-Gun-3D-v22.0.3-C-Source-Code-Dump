using UnityEngine;

namespace Rilisoft
{
    public class ButtonEventsHandler : MonoBehaviour
    {
        // Fields
        public UnityEngine.Events.UnityEvent OnClickEvent;
        
        // Methods
        private void OnClick()
        {
            if(this.OnClickEvent == null)
            {
                    return;
            }
            
            this.OnClickEvent.Invoke();
        }
        public ButtonEventsHandler()
        {
            this.OnClickEvent = new UnityEngine.Events.UnityEvent();
        }
    
    }

}
