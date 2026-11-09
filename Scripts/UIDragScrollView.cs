using UnityEngine;
public class UIDragScrollView : MonoBehaviour
{
    // Fields
    public UIScrollView scrollView;
    private UIScrollView draggablePanel;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UIScrollView 丈世丙业业七丟不丒;
    private bool 丁不三丞丏丑且丒丑;
    private bool 不世丌丝且三上丏丌;
    
    // Methods
    private void OnEnable()
    {
        this.丐一丗丛丕世丘东丁 = this.transform;
        if(this.scrollView == 0)
        {
                if(this.draggablePanel != 0)
        {
                this.scrollView = this.draggablePanel;
            this.draggablePanel = 0;
        }
        
        }
        
        if(this.不世丌丝且三上丏丌 == false)
        {
                return;
        }
        
        if(this.丁不三丞丏丑且丒丑 != true)
        {
                if(this.丈世丙业业七丟不丒 != 0)
        {
                return;
        }
        
        }
        
        this.丑万不丅丑丅丌东业();
    }
    private void Start()
    {
        this.不世丌丝且三上丏丌 = true;
        this.丑万不丅丑丅丌东业();
    }
    private void 丑万不丅丑丅丌东业()
    {
        UIScrollView val_5;
        UIScrollView val_1 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIScrollView>(丄上七丟不丗丕下丟:  this.丐一丗丛丕世丘东丁);
        val_5 = this.scrollView;
        if(val_5 == 0)
        {
            goto label_5;
        }
        
        if(this.丁不三丞丏丑且丒丑 == false)
        {
            goto label_9;
        }
        
        val_5 = this.scrollView;
        if(val_1 == val_5)
        {
            goto label_9;
        }
        
        label_5:
        this.scrollView = val_1;
        goto label_10;
        label_9:
        val_5 = this.scrollView;
        if(val_5 != val_1)
        {
            goto label_13;
        }
        
        label_10:
        this.丁不三丞丏丑且丒丑 = true;
        label_13:
        this.丈世丙业业七丟不丒 = this.scrollView;
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        UIScrollView val_12;
        UnityEngine.Object val_13;
        var val_14;
        var val_15;
        var val_16;
        if(this.丁不三丞丏丑且丒丑 == false)
        {
            goto label_1;
        }
        
        val_12 = this;
        if(this.丈世丙业业七丟不丒 == this.scrollView)
        {
            goto label_5;
        }
        
        this.丁不三丞丏丑且丒丑 = false;
        this.丈世丙业业七丟不丒 = this.scrollView;
        goto label_5;
        label_1:
        val_12 = this.scrollView;
        label_5:
        val_13 = mem[this.scrollView];
        if(((UnityEngine.Object.op_Implicit(exists:  val_13)) == false) || (this.enabled == false))
        {
            goto label_12;
        }
        
        val_13 = this.gameObject;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_13)) == false)
        {
            goto label_12;
        }
        
        val_13 = mem[this.scrollView];
        val_13.Press(万东丂丒且丅丛丑丕:  万东丂丒且丅丛丑丕);
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_14;
        }
        
        val_14 = null;
        goto label_19;
        label_12:
        val_15 = null;
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_17;
        }
        
        val_14 = null;
        label_19:
        bool val_8 = UICamera.丅丒世丆业丑丏丁丈.Add(item:  this.gameObject);
        return;
        label_17:
        val_16 = null;
        goto label_23;
        label_14:
        if(this.丁不三丞丏丑且丒丑 != false)
        {
                UIScrollView val_9 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIScrollView>(丄上七丟不丗丕下丟:  this.丐一丗丛丕世丘东丁);
            mem2[0] = val_9;
            this.丈世丙业业七丟不丒 = val_9;
        }
        
        val_16 = null;
        label_23:
        bool val_11 = UICamera.丅丒世丆业丑丏丁丈.Remove(item:  this.gameObject);
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.scrollView)) == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        this.scrollView.Drag();
    }
    private void OnScroll(float 丞且丅三三东不丄且)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.scrollView)) == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        this.scrollView.Scroll(丞且丅三三东不丄且:  丞且丅三三东不丄且);
    }
    public void OnPan(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.scrollView)) == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        this.scrollView.OnPan(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    private void OnDisable()
    {
        null = null;
        bool val_2 = UICamera.丅丒世丆业丑丏丁丈.Remove(item:  this.gameObject);
    }
    public UIDragScrollView()
    {
    
    }

}
