using UnityEngine;
public class EnableNotifier : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<EventDelegate> onEnable;
    public bool isSoundFX;
    public bool lateUpdate;
    private bool 丟东丙下与不专丟丆;
    
    // Methods
    private void OnEnable()
    {
        if(this.isSoundFX != false)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        }
        else
        {
                if(this.lateUpdate != false)
        {
                this.丟东丙下与不专丟丆 = true;
            return;
        }
        
        }
        
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onEnable);
    }
    private void LateUpdate()
    {
        if(this.丟东丙下与不专丟丆 == false)
        {
                return;
        }
        
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onEnable);
        this.丟东丙下与不专丟丆 = false;
    }
    public EnableNotifier()
    {
        this.onEnable = new System.Collections.Generic.List<EventDelegate>();
    }

}
