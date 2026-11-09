using UnityEngine;
public class AnimationCallback : MonoBehaviour
{
    // Fields
    public UnityEngine.Events.UnityEvent onAnimCallBack;
    
    // Methods
    public void OnAnimCallBack()
    {
        this.onAnimCallBack.Invoke();
    }
    public AnimationCallback()
    {
    
    }

}
