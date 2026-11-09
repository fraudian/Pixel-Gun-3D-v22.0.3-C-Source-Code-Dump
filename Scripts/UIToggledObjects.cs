using UnityEngine;
public class UIToggledObjects : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.GameObject> activate;
    public System.Collections.Generic.List<UnityEngine.GameObject> deactivate;
    private UnityEngine.GameObject target;
    private bool inverse;
    
    // Methods
    private void Awake()
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_7;
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
        EventDelegate val_6 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_4.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void UIToggledObjects::Toggle()));
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
        var val_9;
        var val_10;
        var val_11;
        val_9 = null;
        val_9 = null;
        UIToggle.current.丐不丝丁丙下七丗丐
        UIToggle.current.startsActive
        var val_1 = (UIToggle.current.不世丌丝且三上丏丌 == false) ? UIToggle.current.startsActive : UIToggle.current.丐不丝丁丙下七丗丐;
        if(this.enabled == false)
        {
                return;
        }
        
        val_10 = 0;
        goto label_5;
        label_8:
        UnityEngine.GameObject val_4 = this.activate.Item[0];
        val_4.丅专下万丕丑丆丅丝(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  (val_1 != 0) ? 1 : 0);
        val_10 = 1;
        label_5:
        if(val_10 < this.activate.Count)
        {
            goto label_8;
        }
        
        val_11 = 0;
        goto label_9;
        label_12:
        UnityEngine.GameObject val_7 = this.deactivate.Item[0];
        val_7.丅专下万丕丑丆丅丝(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  (val_1 == 0) ? 1 : 0);
        val_11 = 1;
        label_9:
        if(val_11 < this.deactivate.Count)
        {
            goto label_12;
        }
    
    }
    private void 丅专下万丕丑丆丅丝(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丏业丟一东丂东丘丛)
    {
        if(丝三丁东丈丒世丅业 == 0)
        {
                return;
        }
        
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    public UIToggledObjects()
    {
    
    }

}
