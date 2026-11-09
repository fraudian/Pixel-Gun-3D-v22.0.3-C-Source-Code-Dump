using UnityEngine;
public class UITextList : MonoBehaviour
{
    // Fields
    public UILabel textLabel;
    public UIProgressBar scrollBar;
    public UITextList.丄丏东专与世三丂一 style;
    public int paragraphHistory;
    protected char[] 丞丌下丆下丈丏丂丛;
    protected float 丈世丙业业七丟不丒;
    protected int 且丙丈东丝丝丟业丅;
    protected int 丒丘丞丏丙丒上与下;
    protected int 专业丁丆不东丙丞不;
    private 丒丞丕丕七丁丗丟丛<UITextList.丐三丄丗丕丝丏丌丐> 丟丁丙丂世丏丕丘上;
    private static System.Collections.Generic.Dictionary<string, 丒丞丕丕七丁丗丟丛<UITextList.丐三丄丗丕丝丏丌丐>> 丏丒丙丞丐丈不世七;
    
    // Properties
    protected 丒丞丕丕七丁丗丟丛<UITextList.丐三丄丗丕丝丏丌丐> 丄且与世丆丄下丒丏 { get; }
    public bool 丕且七业丙万丕丛丞 { get; }
    public float 世丕丞三一丞世与万 { get; set; }
    protected float 丂东下万且专丗专丁 { get; }
    protected int 丘七丛世且且丈世与 { get; }
    
    // Methods
    protected 丒丞丕丕七丁丗丟丛<UITextList.丐三丄丗丕丝丏丌丐> 丈丘丟下丞专三业世()
    {
        var val_6;
        System.Collections.Generic.Dictionary<System.String, 丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐>> val_7;
        var val_8;
        丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐> val_2 = this.丟丁丙丂世丏丕丘上;
        if(val_2 != null)
        {
                return (丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐>)this.丟丁丙丂世丏丕丘上;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = UITextList.丏丒丙丞丐丈不世七;
        if((val_7.TryGetValue(key:  this.name, value: out  val_2)) == true)
        {
                return (丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐>)this.丟丁丙丂世丏丕丘上;
        }
        
        this.丟丁丙丂世丏丕丘上 = new 丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐>();
        val_8 = null;
        val_8 = null;
        val_7 = UITextList.丏丒丙丞丐丈不世七;
        val_7.Add(key:  this.name, value:  this.丟丁丙丂世丏丕丘上);
        return (丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐>)this.丟丁丙丂世丏丕丘上;
    }
    public bool get_isValid()
    {
        if(this.textLabel == 0)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  this.textLabel.ambigiousFont, y:  0);
    }
    public float get_scrollValue()
    {
        return (float)this.丈世丙业业七丟不丒;
    }
    public void set_scrollValue(float 丙业与丙丗丝不丈东)
    {
        float val_1 = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
        if(this.isValid == false)
        {
                return;
        }
        
        if(this.丈世丙业业七丟不丒 == val_1)
        {
                return;
        }
        
        if(this.scrollBar != 0)
        {
                this.scrollBar.value = val_1;
            return;
        }
        
        this.丈世丙业业七丟不丒 = val_1;
        this.丘不丕不丒世东世且();
    }
    protected float 丟丑丕丁丏世与丒丁()
    {
        if(this.textLabel == 0)
        {
                return 20f;
        }
        
        this = this.textLabel.fontSize;
        float val_3 = this.textLabel.effectiveSpacingY;
        val_3 = val_3 + (float)this;
        return 20f;
    }
    protected int 专丞丏丂专且与丞丆()
    {
        if(this.isValid == false)
        {
                return 0;
        }
        
        float val_5 = (float)this.textLabel;
        val_5 = val_5 / this.丟丑丕丁丏世与丒丁();
        return UnityEngine.Mathf.Max(a:  0, b:  this.且丙丈东丝丝丟业丅 - (UnityEngine.Mathf.FloorToInt(f:  val_5)));
    }
    public void Clear()
    {
        this.丈丘丟下丞专三业世().世业丒万丘丆专丘丐();
        this.丘不丕不丒世东世且();
    }
    private void Start()
    {
        if(this.textLabel == 0)
        {
                this.textLabel = this.GetComponentInChildren<UILabel>();
        }
        
        if(this.scrollBar != 0)
        {
                EventDelegate val_5 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.scrollBar.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UITextList::不丏三下丟丞丞丄丘()));
        }
        
        this.textLabel.overflowMethod = 1;
        if(this.style == 1)
        {
                this.textLabel.pivot = 6;
        }
        else
        {
                this.textLabel.pivot = 0;
        }
        
        this.scrollValue = 0f;
    }
    private void Update()
    {
        if(this.isValid == false)
        {
                return;
        }
        
        if((W8 == this.丒丘丞丏丙丒上与下) && (W8 == this.专业丁丆不东丙丞不))
        {
                return;
        }
        
        this.与世丄万丈丈上丆下();
    }
    public void OnScroll(float 下下丏一丙不丘丌丞)
    {
        int val_1 = this.专丞丏丂专且与丞丆();
        if(val_1 == 0)
        {
                return;
        }
        
        float val_2 = this.丟丑丕丁丏世与丒丁();
        val_2 = val_2 * 下下丏一丙不丘丌丞;
        val_2 = val_2 / (float)val_1;
        val_2 = this.丈世丙业业七丟不丒 - val_2;
        this.scrollValue = val_2;
    }
    public void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        int val_1 = this.专丞丏丂专且与丞丆();
        if(val_1 == 0)
        {
                return;
        }
        
        float val_2 = this.丟丑丕丁丏世与丒丁();
        val_2 = 丞且丅三三东不丄且.y / val_2;
        val_2 = val_2 / (float)val_1;
        val_2 = this.丈世丙业业七丟不丒 + val_2;
        this.scrollValue = val_2;
    }
    private void 不丏三下丟丞丞丄丘()
    {
        this.丈世丙业业七丟不丒 = UIProgressBar.current.value;
        this.丘不丕不丒世东世且();
    }
    public void Add(string 丕丗丘丑丛与丑业丒)
    {
        this.业丏丗丐丂业东丂丗(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 万丌与丁东且一丘上:  false);
    }
    protected void 业丏丗丐丂业东丂丗(string 丕丗丘丑丛与丑业丒, bool 万丌与丁东且一丘上)
    {
        丐三丄丗丕丝丏丌丐 val_4;
        丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐> val_1 = this.丈丘丟下丞专三业世();
        if(true >= this.paragraphHistory)
        {
            goto label_2;
        }
        
        UITextList.丐三丄丗丕丝丏丌丐 val_2 = null;
        val_4 = val_2;
        val_2 = new UITextList.丐三丄丗丕丝丏丌丐();
        if(val_4 != null)
        {
            goto label_7;
        }
        
        goto label_4;
        label_2:
        val_4 = this.丟丁丙丂世丏丕丘上.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        this.丟丁丙丂世丏丕丘上.丄不丆丑丑丂丈丐丈(丞世不丒下上上丝丑:  0);
        if(val_4 != null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_3.丕丗丘丑丛与丑业丒 = 丕丗丘丑丛与丑业丒;
        this.丟丁丙丂世丏丕丘上.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_4);
        this.与世丄万丈丈上丆下();
    }
    protected void 与世丄万丈丈上丆下()
    {
        UILabel val_12;
        var val_13;
        var val_14;
        var val_15;
        if(this.isValid == false)
        {
                return;
        }
        
        val_12 = this.textLabel;
        if(val_12 == null)
        {
            goto label_2;
        }
        
        this.丒丘丞丏丙丒上与下 = true;
        goto label_3;
        label_2:
        this.丒丘丞丏丙丒上与下 = true;
        if(this.textLabel == null)
        {
            goto label_4;
        }
        
        val_12 = this.textLabel;
        label_3:
        this.专业丁丆不东丙丞不 = true;
        label_40:
        val_12.UpdateNGUIText();
        val_13 = null;
        val_13 = null;
        val_14 = 0;
        丐丄七丙丁丆丁专丏.一丕世万丙丛丆丆丙 = 1000000;
        丐丄七丙丁丆丁专丏.一丞丏且三上丞丝丟 = 1000000;
        this.且丙丈东丝丝丟业丅 = 0;
        goto label_7;
        label_19:
        bool val_3 = 丐丄七丙丁丆丁专丏.丌丌丐丌丑丞万且丛(丕丗丘丑丛与丑业丒:  丒丞丕丕七丁丗丟丛<T>.__il2cppRuntimeField_byval_arg + 16, 丆万丁丛丝三丅丅东: out  0, 丆丄上三上丘丆一世:  false, 世丅丆丟世丞上世世:  true, 丐丅且丞丒下丐业三:  false);
        char[] val_4 = new char[1];
        val_4[0] = '
        ';
        丒丞丕丕七丁丗丟丛<T>.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_18 = val_2.Split(separator:  val_4);
        int val_12 = val_5.Length;
        val_14 = 1;
        val_12 = this.且丙丈东丝丝丟业丅 + val_12;
        this.且丙丈东丝丝丟业丅 = val_12;
        label_7:
        丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐> val_6 = this.丈丘丟下丞专三业世();
        if(val_14 < val_12)
        {
            goto label_19;
        }
        
        this.且丙丈东丝丝丟业丅 = 0;
        if(this.丟丁丙丂世丏丕丘上 >= 1)
        {
                var val_13 = 0;
            do
        {
            val_14 = mem[丒丞丕丕七丁丗丟丛<T>.__il2cppRuntimeField_byval_arg + 24];
            val_14 = 丒丞丕丕七丁丗丟丛<T>.__il2cppRuntimeField_byval_arg + 24;
            val_13 = val_13 + 1;
            this.且丙丈东丝丝丟业丅 = (this.且丙丈东丝丝丟业丅 + 丒丞丕丕七丁丗丟丛<T>.__il2cppRuntimeField_byval_arg + 24 + 24);
        }
        while(this.丟丁丙丂世丏丕丘上 != val_13);
        
        }
        
        if(this.scrollBar != 0)
        {
                val_15 = 0;
            if( != 0)
        {
                if(this.且丙丈东丝丝丟业丅 != 0)
        {
                float val_14 = (float)this.且丙丈东丝丝丟业丅;
            val_14 = (float)this.专丞丏丂专且与丞丆() / val_14;
        }
        
            barSize = 1f - val_14;
        }
        
        }
        
        this.丘不丕不丒世东世且();
        return;
        label_4:
        this.专业丁丆不东丙丞不 = true;
        if(this.textLabel != null)
        {
            goto label_40;
        }
        
        goto label_40;
    }
    protected void 丘不丕不丒世东世且()
    {
        UILabel val_15;
        int val_16;
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        string val_21;
        val_15 = this;
        if(this.isValid == false)
        {
                return;
        }
        
        val_16 = this.且丙丈东丝丝丟业丅;
        if(this.textLabel == null)
        {
            goto label_2;
        }
        
        if(val_16 == 0)
        {
            goto label_3;
        }
        
        label_30:
        float val_14 = (float)this.textLabel;
        val_14 = val_14 / this.丟丑丕丁丏世与丒丁();
        val_17 = UnityEngine.Mathf.FloorToInt(f:  val_14);
        float val_15 = this.丈世丙业业七丟不丒;
        val_15 = val_15 * ((float)UnityEngine.Mathf.Max(a:  0, b:  this.且丙丈东丝丝丟业丅 - val_17));
        int val_6 = UnityEngine.Mathf.RoundToInt(f:  val_15);
        System.Text.StringBuilder val_7 = null;
        val_18 = 0;
        val_16 = val_7;
        val_7 = new System.Text.StringBuilder();
        val_19 = this.丈丘丟下丞专三业世();
        if((null < 1) || (val_17 < 1))
        {
            goto label_25;
        }
        
        var val_17 = 0;
        val_20 = val_6 & (~(val_6 >> 31));
        label_26:
        if(val_17 >= null)
        {
                val_18 = 0;
        }
        
        var val_16 = 0;
        val_19 = (long)丒丞丕丕七丁丗丟丛<T>.__il2cppRuntimeField_byval_arg + 24 + 24;
        label_24:
        val_18 = 0;
        val_20 = val_20 - 1;
        val_16 = val_16 + 1;
        if(val_16 < val_19)
        {
                if( > 0)
        {
            goto label_24;
        }
        
        }
        
        val_17 = val_17 + 1;
        if(val_17 < null)
        {
                if( > 0)
        {
            goto label_26;
        }
        
        }
        
        label_25:
        val_15 = this.textLabel;
        val_21 = val_16;
        goto label_29;
        label_2:
        if(val_16 != 0)
        {
            goto label_30;
        }
        
        label_3:
        val_21 = "";
        label_29:
        this.textLabel.text = val_21;
    }
    public UITextList()
    {
        this.paragraphHistory = 100;
        char[] val_1 = new char[1];
        val_1[0] = '
        ';
        this.丞丌下丆下丈丏丂丛 = val_1;
    }
    private static UITextList()
    {
        UITextList.丏丒丙丞丐丈不世七 = new System.Collections.Generic.Dictionary<System.String, 丒丞丕丕七丁丗丟丛<丐三丄丗丕丝丏丌丐>>();
    }

}
