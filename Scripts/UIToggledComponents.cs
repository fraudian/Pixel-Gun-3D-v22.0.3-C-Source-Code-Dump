using UnityEngine;
public class UIToggledComponents : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.MonoBehaviour> activate;
    public System.Collections.Generic.List<UnityEngine.MonoBehaviour> deactivate;
    private UnityEngine.MonoBehaviour target;
    private bool inverse;
    
    // Methods
    private void Awake()
    {
        System.Collections.Generic.List<UnityEngine.MonoBehaviour> val_7;
        if(this.target != 0)
        {
                if(this.activate.Count == 0)
        {
                if(this.deactivate.Count == 0)
        {
            goto label_7;
        }
        
        }
        
            this.target = 0;
        }
        
        label_14:
        UIToggle val_4 = this.GetComponent<UIToggle>();
        EventDelegate val_6 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_4.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void UIToggledComponents::Toggle()));
        return;
        label_7:
        if(this.inverse != false)
        {
                val_7 = this.deactivate;
        }
        else
        {
                val_7 = this.activate;
        }
        
        val_7.Add(item:  this.target);
        goto label_14;
    }
    public void Toggle()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if(this.enabled == false)
        {
                return;
        }
        
        val_10 = 0;
        goto label_2;
        label_9:
        val_11 = null;
        val_11 = null;
        UIToggle.current.丐不丝丁丙下七丗丐
        UIToggle.current.startsActive
        this.activate.Item[0].enabled = (((UIToggle.current.不世丌丝且三上丏丌 == false) ? UIToggle.current.startsActive : UIToggle.current.丐不丝丁丙下七丗丐) != 0) ? 1 : 0;
        val_10 = 1;
        label_2:
        if(val_10 < this.activate.Count)
        {
            goto label_9;
        }
        
        val_12 = 0;
        goto label_10;
        label_17:
        val_13 = null;
        val_13 = null;
        UIToggle.current.丐不丝丁丙下七丗丐
        UIToggle.current.startsActive
        this.deactivate.Item[0].enabled = (((UIToggle.current.不世丌丝且三上丏丌 == false) ? UIToggle.current.startsActive : UIToggle.current.丐不丝丁丙下七丗丐) == 0) ? 1 : 0;
        val_12 = 1;
        label_10:
        if(val_12 < this.deactivate.Count)
        {
            goto label_17;
        }
    
    }
    public UIToggledComponents()
    {
    
    }

}
