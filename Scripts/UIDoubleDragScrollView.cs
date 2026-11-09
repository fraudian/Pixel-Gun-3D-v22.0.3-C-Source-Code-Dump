using UnityEngine;
public class UIDoubleDragScrollView : MonoBehaviour
{
    // Fields
    public UIScrollView verticalScrollView;
    public UIScrollView horizontalScrollView;
    public float checkThreshold;
    private bool 不世丌丝且三上丏丌;
    private bool 丏丂上上丄一专丁业;
    private bool 专东上三丑东丌且丁;
    private UnityEngine.Vector2 丝下专丐专与丗三三;
    
    // Methods
    private void Start()
    {
        this.不世丌丝且三上丏丌 = true;
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        UnityEngine.GameObject val_10;
        var val_11;
        var val_12;
        var val_13;
        if(this.enabled != false)
        {
                val_10 = this.gameObject;
            if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_10)) != false)
        {
                val_10 = 万东丂丒且丅丛丑丕;
            this.verticalScrollView.Press(万东丂丒且丅丛丑丕:  val_10);
            this.horizontalScrollView.Press(万东丂丒且丅丛丑丕:  val_10);
        }
        
        }
        
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_7;
        }
        
        if(this.丏丂上上丄一专丁业 == false)
        {
            goto label_8;
        }
        
        val_11 = null;
        goto label_15;
        label_7:
        this.丏丂上上丄一专丁业 = false;
        label_8:
        val_10 = 1152921505096622080;
        UnityEngine.Vector2 val_4 = UICamera.lastEventPosition;
        this.丝下专丐专与丗三三 = val_4;
        mem[1152921540647578276] = val_4.y;
        val_12 = null;
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_13;
        }
        
        val_11 = null;
        label_15:
        bool val_6 = UICamera.丅丒世丆业丑丏丁丈.Add(item:  this.gameObject);
        return;
        label_13:
        val_13 = null;
        bool val_8 = UICamera.丅丒世丆业丑丏丁丈.Remove(item:  this.gameObject);
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
            goto label_7;
        }
        
        if(this.专东上三丑东丌且丁 == false)
        {
            goto label_4;
        }
        
        label_9:
        this.verticalScrollView.Drag();
        if(this.专东上三丑东丌且丁 == false)
        {
            goto label_8;
        }
        
        if(this.丏丂上上丄一专丁业 == true)
        {
            goto label_7;
        }
        
        goto label_8;
        label_4:
        if(this.丏丂上上丄一专丁业 == false)
        {
            goto label_9;
        }
        
        label_8:
        this.horizontalScrollView.Drag();
        label_7:
        if(this.丏丂上上丄一专丁业 == true)
        {
                return;
        }
        
        UnityEngine.Vector2 val_2 = UICamera.lastEventPosition;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = this.丝下专丐专与丗三三, y = V9.16B});
        float val_6 = System.Math.Abs(val_3.x);
        float val_7 = System.Math.Abs(val_3.y);
        if(((val_7 > val_6) ? (val_7) : (val_6)) <= this.checkThreshold)
        {
                return;
        }
        
        this.专东上三丑东丌且丁 = (val_7 > val_6) ? 1 : 0;
        this.丏丂上上丄一专丁业 = true;
    }
    private void OnScroll(float 丞且丅三三东不丄且)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.verticalScrollView)) == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        this.verticalScrollView.Scroll(丞且丅三三东不丄且:  丞且丅三三东不丄且);
    }
    public void OnPan(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.verticalScrollView)) == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        this.verticalScrollView.OnPan(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    private void OnDisable()
    {
        null = null;
        bool val_2 = UICamera.丅丒世丆业丑丏丁丈.Remove(item:  this.gameObject);
    }
    public UIDoubleDragScrollView()
    {
        this.checkThreshold = 6f;
    }

}
