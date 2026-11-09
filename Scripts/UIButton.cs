using UnityEngine;
public class UIButton : UIButtonColor
{
    // Fields
    public static UIButton current;
    public bool dragHighlight;
    public string hoverSprite;
    public string pressedSprite;
    public string disabledSprite;
    public UnityEngine.Sprite hoverSprite2D;
    public UnityEngine.Sprite pressedSprite2D;
    public UnityEngine.Sprite disabledSprite2D;
    public bool pixelSnap;
    public System.Collections.Generic.List<EventDelegate> onClick;
    private UISprite 丂丑丌丂丝专丗丆东;
    private UI2DSprite 不丑丞丙万丌丟丁丆;
    private string 丏丑丞丒丏丌万丘东;
    private UnityEngine.Sprite 丑丒丘七丄专上丞丏;
    private UnityEngine.Collider 一丝丛七丈三世且世;
    private bool 东丒且丕丈万不丒专;
    private UnityEngine.Collider2D 丛丂丐丟丕丄丞不不;
    private bool 丞丁专与丐且万丝丁;
    
    // Properties
    private UnityEngine.Collider 上七七三专上不丈丐 { get; }
    private UnityEngine.Collider2D 下专不七丈丗丘丒丑 { get; }
    public override bool 丆丛丆丞下丅丂且丝 { get; set; }
    public string 丝丞丏万三丈丙丈丅 { get; set; }
    public UnityEngine.Sprite 七且七东丅万丈丞上 { get; set; }
    
    // Methods
    private UnityEngine.Collider 丘丞丟一丄专丘上丝()
    {
        UnityEngine.Collider val_3;
        if(this.东丒且丕丈万不丒专 != false)
        {
                val_3 = this.一丝丛七丈三世且世;
            return val_2;
        }
        
        UnityEngine.Collider val_2 = this.gameObject.GetComponent<UnityEngine.Collider>();
        this.一丝丛七丈三世且世 = val_2;
        this.东丒且丕丈万不丒专 = true;
        return val_2;
    }
    private UnityEngine.Collider2D 专业世丛丌丙丁丕丑()
    {
        UnityEngine.Collider2D val_3;
        if(this.丞丁专与丐且万丝丁 != false)
        {
                val_3 = this.丛丂丐丟丕丄丞不不;
            return val_2;
        }
        
        UnityEngine.Collider2D val_2 = this.gameObject.GetComponent<UnityEngine.Collider2D>();
        this.丛丂丐丟丕丄丞不不 = val_2;
        this.丞丁专与丐且万丝丁 = true;
        return val_2;
    }
    public override bool get_isEnabled()
    {
        var val_9;
        if(this.enabled != false)
        {
                if(this.丘丞丟一丄专丘上丝() != 0)
        {
                if(this.丘丞丟一丄专丘上丝().enabled != false)
        {
                val_9 = 1;
            return (bool)val_9;
        }
        
        }
        
            if(this.专业世丛丌丙丁丕丑() != 0)
        {
                UnityEngine.Collider2D val_8 = this.专业世丛丌丙丁丕丑();
            if(val_8 != null)
        {
                return val_8.enabled;
        }
        
            return val_8.enabled;
        }
        
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    public override void set_isEnabled(bool 丙业与丙丗丝不丈东)
    {
        T val_15;
        bool val_16;
        var val_17;
        var val_18;
        val_16 = 丙业与丙丗丝不丈东;
        if((this ^ val_16 & 1) == 0)
        {
                return;
        }
        
        if(this.丘丞丟一丄专丘上丝() == 0)
        {
            goto label_4;
        }
        
        val_15 = this.丘丞丟一丄专丘上丝();
        val_15.enabled = val_16;
        val_17 = 0;
        var val_7 = (val_16 != true) ? 0 : 3;
        goto label_6;
        label_10:
        val_15 = this.GetComponents<UIButton>()[0];
        val_17 = 1;
        label_6:
        if(val_17 < val_6.Length)
        {
            goto label_10;
        }
        
        return;
        label_4:
        if(this.专业世丛丌丙丁丕丑() == 0)
        {
            goto label_14;
        }
        
        val_15 = this.专业世丛丌丙丁丕丑();
        val_15.enabled = val_16;
        val_18 = 0;
        var val_13 = (val_16 != true) ? 0 : 3;
        goto label_16;
        label_20:
        val_15 = this.GetComponents<UIButton>()[0];
        val_18 = 1;
        label_16:
        if(val_18 < val_12.Length)
        {
            goto label_20;
        }
        
        return;
        label_14:
        this.enabled = val_16;
    }
    public string get_normalSprite()
    {
        if(W8 != 0)
        {
                return (string)this.丏丑丞丒丏丌万丘东;
        }
        
        return (string)this.丏丑丞丒丏丌万丘东;
    }
    public void set_normalSprite(string 丙业与丙丗丝不丈东)
    {
        UISprite val_5 = this.丂丑丌丂丝专丗丆东;
        if((val_5 != 0) && ((System.String.IsNullOrEmpty(value:  this.丏丑丞丒丏丌万丘东)) != true))
        {
                val_5 = this.丏丑丞丒丏丌万丘东;
            if((System.String.op_Equality(a:  val_5, b:  this.丂丑丌丂丝专丗丆东.spriteName)) != false)
        {
                this.丏丑丞丒丏丌万丘东 = 丙业与丙丗丝不丈东;
            this.与专丟业下且丕不丈(丄世业且下业上丄丟:  丙业与丙丗丝不丈东);
            不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this.丂丑丌丂丝专丗丆东);
            return;
        }
        
        }
        
        this.丏丑丞丒丏丌万丘东 = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Sprite get_normalSprite2D()
    {
        if(W8 != 0)
        {
                return (UnityEngine.Sprite)this.丑丒丘七丄专上丞丏;
        }
        
        return (UnityEngine.Sprite)this.丑丒丘七丄专上丞丏;
    }
    public void set_normalSprite2D(UnityEngine.Sprite 丙业与丙丗丝不丈东)
    {
        UI2DSprite val_3 = this.不丑丞丙万丌丟丁丆;
        if(val_3 != 0)
        {
                val_3 = this.丑丒丘七丄专上丞丏;
            if(val_3 == this.不丑丞丙万丌丟丁丆.mSprite)
        {
                this.丑丒丘七丄专上丞丏 = 丙业与丙丗丝不丈东;
            this.与专丟业下且丕不丈(丄世业且下业上丄丟:  丙业与丙丗丝不丈东);
            不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this.丂丑丌丂丝专丗丆东);
            return;
        }
        
        }
        
        this.丑丒丘七丄专上丞丏 = 丙业与丙丗丝不丈东;
    }
    protected override void 丅丒丐且丘丝丝丄且()
    {
        var val_6;
        var val_7;
        var val_8;
        this.丅丒丐且丘丝丝丄且();
        if(true == 0)
        {
            goto label_1;
        }
        
        val_7 = 0;
        goto label_3;
        label_1:
        val_8 = this;
        val_7 = 0;
        this.丂丑丌丂丝专丗丆东 = 0;
        goto label_6;
        label_3:
        val_8 = this;
        this.丂丑丌丂丝专丗丆东 = ;
        val_6 = 0;
        label_6:
        this.不丑丞丙万丌丟丁丆 = ;
        if( != 0)
        {
                this.丏丑丞丒丏丌万丘东 = this.丂丑丌丂丝专丗丆东.spriteName;
        }
        
        if(this.不丑丞丙万丌丟丁丆 == 0)
        {
                return;
        }
        
        this.丑丒丘七丄专上丞丏 = this.不丑丞丙万丌丟丁丆.mSprite;
    }
    protected override void OnEnable()
    {
        var val_7;
        var val_14;
        var val_15;
        var val_16;
        val_14 = this;
        if((val_14 & 1) != 0)
        {
                if(null == null)
        {
                return;
        }
        
            UnityEngine.Object val_14 = this.gameObject;
            val_14 = UnityEngine.Object.op_Equality(x:  UICamera.hoveredObject, y:  val_14);
            val_15 = ???;
        }
        else
        {
                val_16 = val_7;
        }
    
    }
    protected override void 专丌丟下上东丞不丙()
    {
        var val_3;
        if((this & 1) == 0)
        {
                return;
        }
        
        if(this.dragHighlight != true)
        {
                val_3 = null;
            val_3 = null;
            if(UICamera.currentTouch.万东丂丒且丅丛丑丕 != this.gameObject)
        {
                return;
        }
        
        }
        
        this.专丌丟下上东丞不丙();
    }
    protected override void 世丆丕丌丒下丆万上()
    {
        var val_3;
        if((this & 1) == 0)
        {
                return;
        }
        
        if(this.dragHighlight != true)
        {
                val_3 = null;
            val_3 = null;
            if(UICamera.currentTouch.万东丂丒且丅丛丑丕 != this.gameObject)
        {
                return;
        }
        
        }
        
        this.世丆丕丌丒下丆万上();
    }
    protected virtual void OnClick()
    {
        UIButton val_2 = this;
        if(UIButton.current != 0)
        {
                return;
        }
        
        if((val_2 & 1) == 0)
        {
                return;
        }
        
        UIButton.current = val_2;
        val_2 = this.onClick;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_2);
        UIButton.current = 0;
    }
    public override void SetState(UIButtonColor.丙丟与丐三丐万万丆 丏业丟一东丂东丘丛, bool 丌丄丗七丝丘与丆与)
    {
        UISprite val_21;
        UI2DSprite val_23;
        丌丄丗七丝丘与丆与 = 丌丄丗七丝丘与丆与;
        this.SetState(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛, 丌丝丌丁下丐丞丆一:  丌丄丗七丝丘与丆与);
        val_21 = this.丂丑丌丂丝专丗丆东;
        if(val_21 != 0)
        {
                if(丏业丟一东丂东丘丛 > 3)
        {
                return;
        }
        
            var val_21 = 106047236 + (丏业丟一东丂东丘丛) << 2;
            val_21 = val_21 + 106047236;
        }
        else
        {
                val_23 = this.不丑丞丙万丌丟丁丆;
            if(val_23 == 0)
        {
                return;
        }
        
            if(丏业丟一东丂东丘丛 > 3)
        {
                return;
        }
        
            var val_22 = 106047220 + (丏业丟一东丂东丘丛) << 2;
            val_22 = val_22 + 106047220;
        }
    
    }
    protected void 与专丟业下且丕不丈(string 丄世业且下业上丄丟)
    {
        if(this.丂丑丌丂丝专丗丆东 == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  丄世业且下业上丄丟)) == true)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  this.丂丑丌丂丝专丗丆东.spriteName, b:  丄世业且下业上丄丟)) == false)
        {
                return;
        }
        
        this.丂丑丌丂丝专丗丆东.spriteName = 丄世业且下业上丄丟;
        if(this.pixelSnap == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(UISprite).__il2cppRuntimeField_358;
    }
    protected void 与专丟业下且丕不丈(UnityEngine.Sprite 丄世业且下业上丄丟)
    {
        UI2DSprite val_10;
        if(丄世业且下业上丄丟 == 0)
        {
                return;
        }
        
        val_10 = this.不丑丞丙万丌丟丁丆;
        if(val_10 == 0)
        {
                return;
        }
        
        val_10 = this.不丑丞丙万丌丟丁丆.mSprite;
        if(val_10 == 丄世业且下业上丄丟)
        {
                return;
        }
        
        val_10 = this.不丑丞丙万丌丟丁丆;
        val_10.sprite2D = 丄世业且下业上丄丟;
        if(this.pixelSnap == false)
        {
                return;
        }
        
        this = ???;
        val_10 = ???;
        goto typeof(UI2DSprite).__il2cppRuntimeField_358;
    }
    public UIButton()
    {
        this.onClick = new System.Collections.Generic.List<EventDelegate>();
    }

}
