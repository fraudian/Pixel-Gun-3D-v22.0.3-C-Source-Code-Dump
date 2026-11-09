using UnityEngine;
public class RilisoftAlphaToggle : MonoBehaviour
{
    // Fields
    private UIToggle 三丅丌丘三上丟丕东;
    private UISprite 万不下丟丐丂专丄与;
    public float alphaOffState;
    public float alphaOnState;
    
    // Methods
    private void Start()
    {
        UIToggle val_1 = this.GetComponent<UIToggle>();
        this.三丅丌丘三上丟丕东 = val_1;
        this.万不下丟丐丂专丄与 = val_1.GetComponent<UISprite>();
        if(this.三丅丌丘三上丟丕东 == 0)
        {
                return;
        }
        
        if(this.万不下丟丐丂专丄与 == 0)
        {
                return;
        }
        
        this.OnAlphaChange();
        EventDelegate val_6 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.三丅丌丘三上丟丕东.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void RilisoftAlphaToggle::OnAlphaChange()));
    }
    public void OnAlphaChange()
    {
        if(this.三丅丌丘三上丟丕东.value == false)
        {
            goto label_1;
        }
        
        if(this.万不下丟丐丂专丄与 != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.万不下丟丐丂专丄与.alpha = this.alphaOnState;
        return;
        label_1:
        if(this.万不下丟丐丂专丄与 != null)
        {
            goto label_3;
        }
        
        goto label_4;
    }
    private void OnDestroy()
    {
        if(this.三丅丌丘三上丟丕东 == 0)
        {
                return;
        }
        
        bool val_3 = EventDelegate.Remove(丝丘丑业丛万丞丌丝:  this.三丅丌丘三上丟丕东.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void RilisoftAlphaToggle::OnAlphaChange()));
    }
    public RilisoftAlphaToggle()
    {
    
    }

}
