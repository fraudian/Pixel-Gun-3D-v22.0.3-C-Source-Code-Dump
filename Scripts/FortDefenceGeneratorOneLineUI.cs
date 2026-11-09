using UnityEngine;
internal sealed class FortDefenceGeneratorOneLineUI : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<FortDefenceGeneratorPointUI> _listGeneratorsUI;
    private FortDefenceGeneratorOneLineItemUI _generatorItem;
    private UISprite _enemyComingBackgroundIcon;
    private System.Collections.Generic.List<FortDamageableGenerator> 下丛与万丞业丟丑三;
    private UnityEngine.Transform _bossIcon;
    private UnityEngine.Transform _startPoint;
    private UnityEngine.Transform _endPoint;
    private string 一丒一丄业丌丘专且;
    private string 世一丛丝丏丆与丆丛;
    private string 丟丌三世丕丕专业丒;
    private string 不三丂世丝与丑三且;
    private System.Func<float> 万丆丛丝丑世三丕一;
    private float 丘丅丆业世丂丝丝丐;
    private float 七三丗丙丏丘丘丅上;
    private bool 丛丂一下万三且丕丆;
    
    // Properties
    private float 世丆东丝丒丒丘丗丐 { get; }
    
    // Methods
    private void Start()
    {
        UnityEngine.Color val_1 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  this.世一丛丝丏丆与丆丛);
        this._enemyComingBackgroundIcon.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    internal void 世丂丕丁丙丙且业丄(System.Collections.Generic.List<DamageableObject> 丆丒丕丒七丝丐丙丟)
    {
        var val_7;
        DamageableObject val_8;
        val_7 = 0;
        goto label_1;
        label_10:
        val_8 = 丆丒丕丒七丝丐丙丟.Item[0];
        this._listGeneratorsUI.Item[0].世丂丕丁丙丙且业丄(丂丈丙且丈丗三丆丕:  val_8);
        if(val_7 == (this._listGeneratorsUI.Count - 1))
        {
                val_8 = 丆丒丕丒七丝丐丙丟.Item[0];
            this._generatorItem.世丂丕丁丙丙且业丄(丂丈丙且丈丗三丆丕:  val_8);
        }
        
        val_7 = 1;
        label_1:
        if(val_7 < this._listGeneratorsUI.Count)
        {
            goto label_10;
        }
    
    }
    internal void 七丂丅丗不丟丏丒七(System.Collections.Generic.List<FortDamageableGenerator> 丐业丗万丂丛下丁下, DamageableObject 丂丞丅丁丕丁上丁丏)
    {
        var val_9;
        var val_10;
        DamageableObject val_11;
        var val_12;
        this.下丛与万丞业丟丑三 = 丐业丗万丂丛下丁下;
        System.Collections.Generic.List<DamageableObject> val_1 = new System.Collections.Generic.List<DamageableObject>();
        val_9 = 0;
        goto label_1;
        label_10:
        if(val_9 == (丐业丗万丂丛下丁下.Count - 1))
        {
                val_10 = public System.Void System.Collections.Generic.List<DamageableObject>::Add(DamageableObject item);
            val_11 = 丂丞丅丁丕丁上丁丏;
        }
        else
        {
                FortDamageableGenerator val_4 = 丐业丗万丂丛下丁下.Item[0];
            val_10 = public System.Void System.Collections.Generic.List<DamageableObject>::Add(DamageableObject item);
            val_11 = val_4._damageableObject;
        }
        
        val_1.Add(item:  val_11);
        val_9 = 1;
        label_1:
        if(val_9 < 丐业丗万丂丛下丁下.Count)
        {
            goto label_10;
        }
        
        this.世丂丕丁丙丙且业丄(丆丒丕丒七丝丐丙丟:  val_1);
        List.Enumerator<T> val_6 = this.下丛与万丞业丟丑三.GetEnumerator();
        label_14:
        if((1136327480 & 1) == 0)
        {
            goto label_12;
        }
        
        System.Action<System.Int32> val_8 = new System.Action<System.Int32>(object:  this, method:  System.Void FortDefenceGeneratorOneLineUI::丘东丌丕万丕丆世丘(int 丌丒丝东丌下丕丁丅));
        0.丐丏七丌丕丗业且上().add_OnChangeMobCount(丙业与丙丗丝不丈东:  null);
        goto label_14;
        label_12:
        val_12 = public System.Void List.Enumerator<FortDamageableGenerator>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丘东丌丕万丕丆世丘(丌丒丝东丌下丕丁丅:  0);
    }
    private void OnDestroy()
    {
        object val_4 = this;
        List.Enumerator<T> val_1 = this.下丛与万丞业丟丑三.GetEnumerator();
        label_4:
        if((1136484552 & 1) == 0)
        {
            goto label_2;
        }
        
        System.Action<System.Int32> val_3 = new System.Action<System.Int32>(object:  this, method:  System.Void FortDefenceGeneratorOneLineUI::丘东丌丕万丕丆世丘(int 丌丒丝东丌下丕丁丅));
        0.丐丏七丌丕丗业且上().remove_OnChangeMobCount(丙业与丙丗丝不丈东:  null);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丘东丌丕万丕丆世丘(int 丌丒丝东丌下丕丁丅)
    {
        var val_2;
        var val_3;
        bool val_14;
        var val_15;
        float val_16;
        float val_17;
        List.Enumerator<T> val_1 = this.下丛与万丞业丟丑三.GetEnumerator();
        label_4:
        if((1136657936 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_2 < 1)
        {
            goto label_4;
        }
        
        val_14 = 1;
        goto label_5;
        label_2:
        val_14 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_15 = 0;
        goto label_10;
        label_26:
        FortDefenceGeneratorPointUI val_6 = this._listGeneratorsUI.Item[0];
        if(val_6 == null)
        {
            goto label_12;
        }
        
        if((0 & 1) == 0)
        {
            goto label_13;
        }
        
        label_16:
        UnityEngine.Color val_7 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  mem[this.一丒一丄业丌丘专且]);
        val_16 = val_7.r;
        val_17 = val_7.b;
        val_6._line.color = new UnityEngine.Color() {r = val_16, g = val_7.g, b = val_17, a = val_7.a};
        goto label_15;
        label_12:
        if((0 & 1) != 0)
        {
            goto label_16;
        }
        
        label_13:
        FortDefenceGeneratorPointUI val_9 = this._listGeneratorsUI.Item[0];
        if(val_6.丛世上丂丒丆丅下丏() == false)
        {
            goto label_19;
        }
        
        UnityEngine.Color val_10 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  this.丟丌三世丕丕专业丒);
        val_16 = val_10.r;
        val_17 = val_10.b;
        val_9._line.color = new UnityEngine.Color() {r = val_16, g = val_10.g, b = val_17, a = val_10.a};
        goto label_21;
        label_19:
        UnityEngine.Color val_11 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  ( != 0) ? this.不三丂世丝与丑三且 : this.一丒一丄业丌丘专且);
        val_16 = val_11.r;
        val_17 = val_11.b;
        val_9._line.color = new UnityEngine.Color() {r = val_16, g = val_11.g, b = val_17, a = val_11.a};
        FortDefenceGeneratorPointUI val_12 = this._listGeneratorsUI.Item[0];
        val_12.丐丛三东丛万丗一丌 = ;
        label_15:
        label_21:
        val_15 = 1;
        label_10:
        if(val_15 < this._listGeneratorsUI.Count)
        {
            goto label_26;
        }
    
    }
    private float 专丒东业丐东下丝丅()
    {
        if(this.万丆丛丝丑世三丕一 == null)
        {
                return 0f;
        }
        
        return this.万丆丛丝丑世三丕一.Invoke();
    }
    internal void 丐丛丑丐丌丏专且丕(System.Func<float> 丗与丘不且万丟丙丑)
    {
        this.万丆丛丝丑世三丕一 = 丗与丘不且万丟丙丑;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._bossIcon, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丑丄丐三丑丁丒丙丕()
    {
        this.万丆丛丝丑世三丕一 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._bossIcon, 丏业丟一东丂东丘丛:  false);
    }
    private void Update()
    {
        float val_7;
        if(this.万丆丛丝丑世三丕一 != null)
        {
                UnityEngine.Vector3 val_1 = this._startPoint.position;
            UnityEngine.Vector3 val_2 = this._endPoint.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, t:  this.专丒东业丐东下丝丅());
            val_7 = val_4.x;
            this._bossIcon.position = new UnityEngine.Vector3() {x = val_7, y = val_4.y, z = val_4.z};
        }
        
        if(this.丛丂一下万三且丕丆 == false)
        {
                return;
        }
        
        float val_7 = this.丘丅丆业世丂丝丝丐;
        float val_5 = UnityEngine.Time.deltaTime;
        val_7 = val_7 + val_5;
        this.丘丅丆业世丂丝丝丐 = val_7;
        val_5 = val_7 / this.七三丗丙丏丘丘丅上;
        val_7 = UnityEngine.Mathf.Clamp(value:  val_5, min:  0f, max:  1f);
        this._enemyComingBackgroundIcon.fillAmount = val_7;
        if(this.丘丅丆业世丂丝丝丐 < this.七三丗丙丏丘丘丅上)
        {
                return;
        }
        
        this._enemyComingBackgroundIcon.fillAmount = 1f;
        this.丛丂一下万三且丕丆 = false;
    }
    internal void 丛丒且丑东丟丅丁丕(float 丂三丟丂丈丐丆丗丟)
    {
        this.丘丅丆业世丂丝丝丐 = 0f;
        this.七三丗丙丏丘丘丅上 = 丂三丟丂丈丐丆丗丟;
        this.丛丂一下万三且丕丆 = true;
    }
    public FortDefenceGeneratorOneLineUI()
    {
        this._listGeneratorsUI = new System.Collections.Generic.List<FortDefenceGeneratorPointUI>();
        this.下丛与万丞业丟丑三 = new System.Collections.Generic.List<FortDamageableGenerator>();
        this.一丒一丄业丌丘专且 = "FortDefGen_blue";
        this.世一丛丝丏丆与丆丛 = "FortDefGen_light_red";
        this.丟丌三世丕丕专业丒 = "FortDefGen_dark_red";
        this.不三丂世丝与丑三且 = "FortDefGen_orange";
    }

}
