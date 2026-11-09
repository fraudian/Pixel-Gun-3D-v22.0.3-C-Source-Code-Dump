using UnityEngine;
public class LabelClampExtended : MonoBehaviour
{
    // Fields
    public int widgetMaxWidth;
    public bool UseEllipsis;
    public bool shrink;
    private string 丏丘丂世一与专丂丙;
    private bool 一且丐一世丌丝丛丛;
    public bool NextFrameCallback;
    public UnityEngine.Events.UnityEvent onResize;
    private UILabel 丞丛万三丑丂丗一丞;
    
    // Properties
    private UILabel 七丐丞丑丑丕世丙七 { get; }
    
    // Methods
    private UILabel 丂丟丒上丕丁七七一()
    {
        UILabel val_3;
        if((UnityEngine.Object.op_Implicit(exists:  this.丞丛万三丑丂丗一丞)) != false)
        {
                val_3 = this.丞丛万三丑丂丗一丞;
            return val_2;
        }
        
        UILabel val_2 = this.GetComponent<UILabel>();
        this.丞丛万三丑丂丗一丞 = val_2;
        return val_2;
    }
    private void LateUpdate()
    {
        if(this.一且丐一世丌丝丛丛 != false)
        {
                this.丕上丙丈丛一世丈丟();
        }
        
        if(this.丂丟丒上丕丁七七一() == 0)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  this.丏丘丂世一与专丂丙, b:  this.丂丟丒上丕丁七七一().text)) == false)
        {
                return;
        }
        
        this.丏丘丂世一与专丂丙 = this.丂丟丒上丕丁七七一().text;
        this.丗丛丝三丅丈上丕世();
    }
    private void 丗丛丝三丅丈上丕世()
    {
        丐丏上丂丐丂丝世丐 val_12;
        this.丂丟丒上丕丁七七一().overflowEllipsis = (this.UseEllipsis == true) ? 1 : 0;
        this.丂丟丒上丕丁七七一().overflowMethod = 2;
        this.丂丟丒上丕丁七七一().ProcessText();
        this.丂丟丒上丕丁七七一().ResetAndUpdateAnchors();
        if(this.丂丟丒上丕丁七七一().width <= this.widgetMaxWidth)
        {
            goto label_5;
        }
        
        UILabel val_8 = this.丂丟丒上丕丁七七一();
        if(val_8 == null)
        {
            goto label_6;
        }
        
        if(this.shrink == false)
        {
            goto label_7;
        }
        
        label_9:
        val_12 = 0;
        goto label_8;
        label_6:
        if(this.shrink == true)
        {
            goto label_9;
        }
        
        label_7:
        val_12 = 1;
        label_8:
        val_8.overflowMethod = val_12;
        this.丂丟丒上丕丁七七一().width = this.widgetMaxWidth;
        this.丂丟丒上丕丁七七一().ProcessText();
        this.丂丟丒上丕丁七七一().ResetAndUpdateAnchors();
        label_5:
        if(this.NextFrameCallback != false)
        {
                this.onResize.Invoke();
            return;
        }
        
        this.一且丐一世丌丝丛丛 = true;
    }
    private void 丕上丙丈丛一世丈丟()
    {
        this.一且丐一世丌丝丛丛 = false;
        this.onResize.Invoke();
    }
    public LabelClampExtended()
    {
        this.widgetMaxWidth = 100;
        this.onResize = new UnityEngine.Events.UnityEvent();
    }

}
