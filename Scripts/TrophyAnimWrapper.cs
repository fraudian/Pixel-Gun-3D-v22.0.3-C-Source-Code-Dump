using UnityEngine;
public class TrophyAnimWrapper : MonoBehaviour
{
    // Fields
    public bool abtest;
    public UnityEngine.Animator anim;
    
    // Methods
    public void A_ShowTrophy()
    {
        if(this.abtest != false)
        {
                return;
        }
        
        this.anim.SetTrigger(name:  "Show");
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丑丌丏丙上丂丒丞三();
    }
    public void A_TrophyUp()
    {
        if(this.abtest != false)
        {
                return;
        }
        
        this.anim.SetTrigger(name:  "Up");
    }
    public void A_TrophyDown()
    {
        if(this.abtest != false)
        {
                return;
        }
        
        this.anim.SetTrigger(name:  "Down");
    }
    public void A_HideTrophy()
    {
        if(this.abtest != false)
        {
                return;
        }
        
        this.anim.SetTrigger(name:  "Hide");
    }
    public TrophyAnimWrapper()
    {
    
    }

}
