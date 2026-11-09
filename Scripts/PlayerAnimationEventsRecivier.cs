using UnityEngine;
public class PlayerAnimationEventsRecivier : MonoBehaviour
{
    // Fields
    private PlayerAnimationWrapper animationWrapper;
    
    // Methods
    public void OnLanding()
    {
        if(this.animationWrapper == 0)
        {
                return;
        }
        
        this.animationWrapper.OnLanding();
    }
    public PlayerAnimationEventsRecivier()
    {
    
    }

}
