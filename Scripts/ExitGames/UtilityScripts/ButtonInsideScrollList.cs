using UnityEngine;

namespace ExitGames.UtilityScripts
{
    public class ButtonInsideScrollList : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        private UnityEngine.UI.ScrollRect scrollRect;
        
        // Methods
        private void Start()
        {
            this.scrollRect = this.GetComponentInParent<UnityEngine.UI.ScrollRect>();
        }
        private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.scrollRect == 0)
            {
                    return;
            }
            
            this.scrollRect.enabled = false;
        }
        private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.scrollRect == 0)
            {
                    return;
            }
            
            if(this.scrollRect.enabled != false)
            {
                    return;
            }
            
            this.scrollRect.enabled = true;
        }
        public ButtonInsideScrollList()
        {
        
        }
    
    }

}
