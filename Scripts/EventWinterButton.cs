using UnityEngine;
public class EventWinterButton : RadioButton
{
    // Fields
    public bool isCollected;
    private bool UseQueue;
    private int Queue;
    private UIBasicSprite[] itemTextures;
    private UILabel[] detailLabels;
    private UnityEngine.GameObject[] activeIfCollected;
    private UnityEngine.GameObject[] activeIf_Not_Collected;
    private UnityEngine.GameObject[] activeIfSelected;
    private UnityEngine.GameObject[] activeIf_Not_Selected;
    private UnityEngine.GameObject[] activeIfSelectedQ;
    private UnityEngine.GameObject[] activeIf_Not_SelectedQ;
    private UISprite[] _raritySprite;
    private UnityEngine.GameObject[] _badges;
    private UnityEngine.GameObject[] _newIndicators;
    private Rilisoft.与专丒丞丐一丒丂东 <与世丁丌丕丅丕丙业>k__BackingField;
    private bool 丑丙丏丞丌丂丆丝万;
    
    // Properties
    public Rilisoft.与专丒丞丐一丒丂东 丆业东丁丙丁丘丞丑 { get; set; }
    private UIBasicSprite[] 丒业上七丂丂一丙专 { get; }
    
    // Methods
    public Rilisoft.与专丒丞丐一丒丂东 get_SettedChest()
    {
        return (Rilisoft.与专丒丞丐一丒丂东)this.<与世丁丌丕丅丕丙业>k__BackingField;
    }
    private void 上世一丗世丈丄丑丛(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
    {
        this.<与世丁丌丕丅丕丙业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private UIBasicSprite[] 丕丄下与业丟东万业()
    {
        UIBasicSprite[] val_4;
        var val_5;
        if(this.丑丙丏丞丌丂丆丝万 == false)
        {
            goto label_1;
        }
        
        this.丑丙丏丞丌丂丆丝万 = false;
        val_4 = new UIBasicSprite[0];
        val_5 = 0;
        goto label_3;
        label_18:
        UIBasicSprite val_4 = this.itemTextures[0];
        if(val_4 == 0)
        {
            goto label_8;
        }
        
        UIBasicSprite val_3 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  val_4);
        if(val_4 == null)
        {
            goto label_11;
        }
        
        if(val_3 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_3 == null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        val_4[0] = val_3;
        label_8:
        val_5 = 1;
        label_3:
        if(val_5 < this.itemTextures.Length)
        {
            goto label_18;
        }
        
        this.itemTextures = val_4;
        return val_4;
        label_1:
        val_4 = this.itemTextures;
        return val_4;
    }
    protected override void 丒三七丌丂丛丈七丗()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        bool val_18;
        var val_19;
        var val_20;
        val_14 = 0;
        goto label_1;
        label_11:
        if(this.activeIfCollected[0] != 0)
        {
                this.activeIfCollected[0].SetActive(value:  (this.isCollected == true) ? 1 : 0);
        }
        
        val_14 = 1;
        label_1:
        if(val_14 < this.activeIfCollected.Length)
        {
            goto label_11;
        }
        
        val_15 = 0;
        goto label_12;
        label_22:
        if(this.activeIf_Not_Collected[0] != 0)
        {
                this.activeIf_Not_Collected[0].SetActive(value:  (this.isCollected == false) ? 1 : 0);
        }
        
        val_15 = 1;
        label_12:
        if(val_15 < this.activeIf_Not_Collected.Length)
        {
            goto label_22;
        }
        
        if(this.UseQueue != false)
        {
                val_16 = null;
            val_16 = null;
            if(RadioButton.一丆丆与丝丙七世丏.Count == this.Queue)
        {
                this.与丗丄丙丗下业丛丕();
            return;
        }
        
        }
        
        val_17 = 0;
        goto label_28;
        label_38:
        if(this.activeIfSelectedQ[0] != 0)
        {
                this.activeIfSelectedQ[0].SetActive(value:  false);
        }
        
        val_17 = 1;
        label_28:
        if(val_17 < this.activeIfSelectedQ.Length)
        {
            goto label_38;
        }
        
        val_18 = 0;
        goto label_39;
        label_49:
        if(this.activeIf_Not_SelectedQ[0] != 0)
        {
                this.activeIf_Not_SelectedQ[0].SetActive(value:  false);
        }
        
        val_18 = 1;
        label_39:
        if(val_18 < this.activeIf_Not_SelectedQ.Length)
        {
            goto label_49;
        }
        
        val_19 = 0;
        goto label_50;
        label_60:
        val_18 = 0;
        if(this.activeIfSelected[val_18] != 0)
        {
                val_18 = this.state;
            this.activeIfSelected[val_18].SetActive(value:  val_18);
        }
        
        val_19 = 1;
        label_50:
        if(val_19 < this.activeIfSelected.Length)
        {
            goto label_60;
        }
        
        val_20 = 0;
        goto label_61;
        label_71:
        val_18 = 0;
        if(this.activeIf_Not_Selected[val_18] != 0)
        {
                val_18 = this.state;
            this.activeIf_Not_Selected[val_18].SetActive(value:  (~val_18) & 1);
        }
        
        val_20 = 1;
        label_61:
        if(val_20 < this.activeIf_Not_Selected.Length)
        {
            goto label_71;
        }
    
    }
    private void 与丗丄丙丗下业丛丕()
    {
        var val_9;
        bool val_10;
        var val_11;
        var val_12;
        val_9 = 0;
        goto label_1;
        label_11:
        if(this.activeIfSelected[0] != 0)
        {
                this.activeIfSelected[0].SetActive(value:  false);
        }
        
        val_9 = 1;
        label_1:
        if(val_9 < this.activeIfSelected.Length)
        {
            goto label_11;
        }
        
        val_10 = 0;
        goto label_12;
        label_22:
        if(this.activeIf_Not_Selected[0] != 0)
        {
                this.activeIf_Not_Selected[0].SetActive(value:  false);
        }
        
        val_10 = 1;
        label_12:
        if(val_10 < this.activeIf_Not_Selected.Length)
        {
            goto label_22;
        }
        
        val_11 = 0;
        goto label_23;
        label_33:
        val_10 = 0;
        if(this.activeIfSelectedQ[val_10] != 0)
        {
                val_10 = this.state;
            this.activeIfSelectedQ[val_10].SetActive(value:  val_10);
        }
        
        val_11 = 1;
        label_23:
        if(val_11 < this.activeIfSelectedQ.Length)
        {
            goto label_33;
        }
        
        val_12 = 0;
        goto label_34;
        label_44:
        val_10 = 0;
        if(this.activeIf_Not_SelectedQ[val_10] != 0)
        {
                val_10 = this.state;
            this.activeIf_Not_SelectedQ[val_10].SetActive(value:  (~val_10) & 1);
        }
        
        val_12 = 1;
        label_34:
        if(val_12 < this.activeIf_Not_SelectedQ.Length)
        {
            goto label_44;
        }
    
    }
    public void Setup(Rilisoft.与专丒丞丐一丒丂东 丐下丝丘丑丟丟丗丌)
    {
        System.Collections.Generic.IEnumerable<T> val_21;
        UnityEngine.Color val_22;
        System.Action<T> val_23;
        var val_24;
        bool val_25;
        this.<与世丁丌丕丅丕丙业>k__BackingField = 丐下丝丘丑丟丟丗丌;
        if(丐下丝丘丑丟丟丗丌 == null)
        {
                return;
        }
        
        val_21 = this.丕丄下与业丟东万业();
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UIBasicSprite>(丌丛丏业世丄丞三丌:  val_21, 七丐丅专且专七三丆:  new System.Action<UIBasicSprite>(object:  this, method:  System.Void EventWinterButton::世专丝丗丂丆丑丞丌(UIBasicSprite 丙丒七丄上与丏丙丙)));
        if(this.detailLabels != null)
        {
                EventWinterButton.上三且上丁业与与丑 val_3 = null;
            val_21 = val_3;
            val_3 = new EventWinterButton.上三且上丁业与与丑();
            val_22 = 1152921504622075904;
            .丕丗丘丑丛与丑业丒 = System.String.Format(format:  "{0}/{1}", arg0:  this.<与世丁丌丕丅丕丙业>k__BackingField.丑专丐丐丏丆东丘万(), arg1:  this.<与世丁丌丕丅丕丙业>k__BackingField.东丂七不丄丑丄丆七());
            System.Action<UILabel> val_7 = null;
            val_23 = val_7;
            val_7 = new System.Action<UILabel>(object:  val_3, method:  System.Void EventWinterButton.上三且上丁业与与丑::一丄业丐丄丒下丏丞(UILabel 丐三丞七丝丅不万丛));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.detailLabels, 七丐丅专且专七三丆:  val_7);
        }
        
        if((this._raritySprite != null) && (this._raritySprite.Length != 0))
        {
                EventWinterButton.丑丛丑万与丆丝丞丐 val_8 = null;
            val_21 = val_8;
            val_8 = new EventWinterButton.丑丛丑万与丆丝丞丐();
            三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏());
            if(val_10 != null)
        {
                val_24 = (long)val_10;
        }
        else
        {
                val_24 = 5;
        }
        
            val_22 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5];
            .丑丞丈丗丄丙丟万丄 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5];
            mem[1152921525998129956] = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5];
            mem[1152921525998129960] = val_22;
            mem[1152921525998129964] = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5];
            System.Action<UISprite> val_12 = null;
            val_23 = val_12;
            val_12 = new System.Action<UISprite>(object:  val_8, method:  System.Void EventWinterButton.丑丛丑万与丆丝丞丐::丙丛上丏上丘丟丛丘(UISprite 丏丛与丅丛丌万专丌));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UISprite>(丌丛丏业世丄丞三丌:  this._raritySprite, 七丐丅专且专七三丆:  val_12);
        }
        
        if(this._newIndicators == null)
        {
            goto label_23;
        }
        
        EventWinterButton.丈业丄丕丏丒与丂丙 val_13 = null;
        val_21 = val_13;
        val_13 = new EventWinterButton.丈业丄丕丏丒与丂丙();
        if(丐下丝丘丑丟丟丗丌.丄丌万丘与专丝业丗() != true)
        {
                if((this.<与世丁丌丕丅丕丙业>k__BackingField.七丝丝丈七三丝丘一()) == false)
        {
            goto label_26;
        }
        
        }
        
        if(val_21 != null)
        {
            goto label_35;
        }
        
        label_36:
        label_35:
        .丒七丄丈丗丂三丑丌 = false;
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  this._newIndicators, 七丐丅专且专七三丆:  new System.Action<UnityEngine.GameObject>(object:  val_13, method:  System.Void EventWinterButton.丈业丄丕丏丒与丂丙::丑丁上世不丁且三丂(UnityEngine.GameObject 丄三丅七丆丛与与上)));
        label_23:
        if((this.<与世丁丌丕丅丕丙业>k__BackingField.丒世业三丘丝不下丕()) != false)
        {
                val_25 = 1;
        }
        else
        {
                val_25 = this.<与世丁丌丕丅丕丙业>k__BackingField.七丝丝丈七三丝丘一();
        }
        
        this.isCollected = val_25;
        this.世丗上丒业丛丝上丈();
        return;
        label_26:
        Rilisoft.与专丒丞丐一丒丂东 val_23 = this.<与世丁丌丕丅丕丙业>k__BackingField;
        val_23 = (~val_23.丒世业三丘丝不下丕()) & 1;
        if(val_21 != null)
        {
            goto label_35;
        }
        
        goto label_36;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
    }
    protected override void OnClick()
    {
        this.OnClick();
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        Rilisoft.AbstractGameEventGui val_5 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_5 == null)
        {
                return;
        }
        
        var val_6 = (null == null) ? (val_5) : 0;
        if(null != null)
        {
                return;
        }
        
        val_6.世丟丝与丏丆且丄丌();
        if((this.state & this.state) == false)
        {
                return;
        }
        
        val_6.U_ShowSelectedChestContext();
    }
    private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new EventWinterButton.下专丁丕三世丒丄下();
    }
    public EventWinterButton()
    {
        this.丑丙丏丞丌丂丆丝万 = true;
    }
    private void 世专丝丗丂丆丑丞丌(UIBasicSprite 丙丒七丄上与丏丙丙)
    {
        UIBasicSprite val_8 = 丙丒七丄上与丏丙丙;
        if(val_8 == 0)
        {
                return;
        }
        
        UnityEngine.Texture val_2 = this.<与世丁丌丕丅丕丙业>k__BackingField.东七丗丝丟丈下世丛();
        val_8 = ???;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
    }

}
