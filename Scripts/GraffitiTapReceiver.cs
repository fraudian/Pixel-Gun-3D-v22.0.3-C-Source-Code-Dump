using UnityEngine;
internal sealed class GraffitiTapReceiver : PGBehaviour
{
    // Fields
    private UISprite graffitiBtnSprite;
    private UIButton 丕且丕丏丘丙丞业七;
    private bool 丅丐一下丏上丞丞上;
    private bool 且丛丌丌丂丙七丁丙;
    private bool 丗与东丒丞七丘七丕;
    protected float 东丟万丄丘丗丑上世;
    internal UnityEngine.Rect 丟万丘下一丟业下丛;
    private static System.Action 三丕丅丅与不丆丞丝;
    
    // Methods
    internal static void 一丈一上与丑丘一丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  GraffitiTapReceiver.三丕丅丅与不丆丞丝, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丐与丄丄丏七丕与丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 41443;
        if(((1 & 2) != 0) && (33554944 == 0))
        {
                val_3 = null;
        }
        
        val_4 = System.Delegate.Remove(source:  GraffitiTapReceiver.三丕丅丅与不丆丞丝, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    private void Awake()
    {
        this.丕且丕丏丘丙丞业七 = this.GetComponent<UIButton>();
        GraffitiManager.丑丐丛丂丒专丙丌丈(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GraffitiTapReceiver::丐专丈丗丟万丌世丄(bool 丏业丟一东丂东丘丛)));
        EmojiPanel.丟丄三与专不丞丗丆(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GraffitiTapReceiver::世上丆七世丙七丏丗(bool 丏业丟一东丂东丘丛)));
    }
    private void Start()
    {
        this.丛丙丑丈丞业丐且丙();
    }
    private void OnDestroy()
    {
        GraffitiManager.世一丁丑丏三丌上丝(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GraffitiTapReceiver::丐专丈丗丟万丌世丄(bool 丏业丟一东丂东丘丛)));
        EmojiPanel.丅且丒业丌丁丒丏丈(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void GraffitiTapReceiver::世上丆七世丙七丏丗(bool 丏业丟一东丂东丘丛)));
    }
    private void Update()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        if(null == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(丛与上丆丅丑业且与() == null)
        {
                return;
        }
        
        if(this.丅丐一下丏上丞丞上 == false)
        {
                return;
        }
        
        val_6 = null;
        if(GraffitiManager.业三与一东东丐七丛() != true)
        {
                this.丅丐一下丏上丞丞上 = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丕且丕丏丘丙丞业七, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.丅丐一下丏上丞丞上 == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        GraffitiManager val_3 = 丛与上丆丅丑业且与();
        float val_4 = 1f;
        val_4 = val_4 - (val_3.<且七丌丐丐且丛三丐>k__BackingField);
        this.graffitiBtnSprite.fillAmount = val_4;
    }
    private void 丐专丈丗丟万丌世丄(bool 丏业丟一东丂东丘丛)
    {
        bool val_3;
        this.且丛丌丌丂丙七丁丙 = 丏业丟一东丂东丘丛;
        if(丏业丟一东丂东丘丛 == false)
        {
            goto label_0;
        }
        
        val_3 = this.丗与东丒丞七丘七丕;
        if(this.丕且丕丏丘丙丞业七 != null)
        {
            goto label_3;
        }
        
        goto label_2;
        label_0:
        val_3 = 0;
        if(this.丕且丕丏丘丙丞业七 != null)
        {
            goto label_3;
        }
        
        label_2:
        label_3:
        var val_2 = (val_3 != 0) ? 1 : 0;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private void 世上丆七世丙七丏丗(bool 丏业丟一东丂东丘丛)
    {
        this.丗与东丒丞七丘七丕 = 丏业丟一东丂东丘丛;
        bool val_3 = ((this.且丛丌丌丂丙七丁丙 == true) ? 1 : 0) & 丏业丟一东丂东丘丛;
        if(this.丕且丕丏丘丙丞业七 == null)
        {
            
        }
    
    }
    private void 丛丙丑丈丞业丐且丙()
    {
        UnityEngine.Camera val_6 = 不丌丂丁丄一与丆丙.丅丟东不三丘七丑丙(丝三丁东丈丒世丅业:  this.gameObject).transform.GetChild(index:  0).GetChild(index:  0).GetComponent<UnityEngine.Camera>();
        float val_16 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        if(val_6 == 0)
        {
                UnityEngine.Debug.LogError(message:  "camera not setted");
        }
        
        val_16 = this.东丟万丄丘丗丑上世 * val_16;
        val_16 = val_16 + val_16;
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector3 val_11 = val_6.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11.x, y:  val_11.y);
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_16, y:  val_16);
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, d:  0.5f);
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        InGameGUI.丙丞专丌丁丞与不丐.丒丅下丌丞丁丕丝丙 = 0;
        mem2[0] = 0;
        InGameGUI.丙丞专丌丁丞与不丐.__unknownFiledOffset_434 = 0;
    }
    private void OnClick()
    {
        InGameGUI val_6;
        var val_7;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_6 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_6.ExitingInCampaign == true)
        {
                return;
        }
        
        }
        
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        val_6 = Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗();
        if((val_6.Equals(value:  "New_tutor")) != false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        GraffitiTapReceiver.三丕丅丅与不丆丞丝.Invoke();
    }
    public GraffitiTapReceiver()
    {
        this.丅丐一下丏上丞丞上 = true;
        this.且丛丌丌丂丙七丁丙 = true;
        this.丗与东丒丞七丘七丕 = true;
        this.东丟万丄丘丗丑上世 = 40f;
    }
    private static GraffitiTapReceiver()
    {
        null = null;
        GraffitiTapReceiver.三丕丅丅与不丆丞丝 = new System.Action(object:  GraffitiTapReceiver.<>c.<>9, method:  System.Void GraffitiTapReceiver.<>c::丂业丄丟丏丛丟下丂());
    }

}
