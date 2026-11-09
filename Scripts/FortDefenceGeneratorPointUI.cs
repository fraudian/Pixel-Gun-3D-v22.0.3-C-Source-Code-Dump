using UnityEngine;
internal sealed class FortDefenceGeneratorPointUI : PGBehaviour
{
    // Fields
    private UISprite _backSprite;
    private UILabel _numberGenerator;
    private DamageableObject 七一丕上丄上万不不;
    private UnityEngine.GameObject _animationObject;
    private UISprite _line;
    private UnityEngine.Transform _cutter;
    private TweenScale _tweenScale;
    private string 一丒一丄业丌丘专且;
    private string 世一丛丝丏丆与丆丛;
    private string 丟丌三世丕丕专业丒;
    private string 不三丂世丝与丑三且;
    private UnityEngine.Vector3 上丗丑东丁万丂世世;
    private bool 丐丛三东丛万丗一丌;
    private float 丒丛丂丒丐丆丝丑东;
    private float 丆丅丘且且专上丂三;
    private float 下丑东丗丑丁丂丝丌;
    private float 万丛丐下丕丝七业丑;
    private bool 丅上丌丏丂一上丌丐;
    
    // Properties
    public UISprite 丟丞万且丛下专丑丌 { get; }
    
    // Methods
    internal bool 丛世上丂丒丆丅下丏()
    {
        if(this.七一丕上丄上万不不 == 0)
        {
                return false;
        }
        
        if(this.七一丕上丄上万不不 != null)
        {
                return this.七一丕上丄上万不不.IsDead();
        }
        
        return this.七一丕上丄上万不不.IsDead();
    }
    public UISprite get_Line()
    {
        return (UISprite)this._line;
    }
    internal DamageableObject 丕丌一丁丌丒丘丈丗()
    {
        return (DamageableObject)this.七一丕上丄上万不不;
    }
    internal void 丌丞丑丗丅丄七世丘(bool 丈业丅东丕下且三丒)
    {
        this.丐丛三东丛万丗一丌 = 丈业丅东丕下且三丒;
    }
    internal void 世丂丕丁丙丙且业丄(DamageableObject 丂丈丙且丈丗三丆丕)
    {
        DamageableObject val_15 = this.七一丕上丄上万不不;
        if(val_15 != 0)
        {
                this.七一丕上丄上万不不.丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorPointUI::上专世丌丑与丕丛丕()));
            val_15 = this.七一丕上丄上万不不;
            val_15.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorPointUI::丕丕丞不丆业东下丒()));
        }
        
        this.七一丕上丄上万不不 = 丂丈丙且丈丗三丆丕;
        if(丂丈丙且丈丗三丆丕 != 0)
        {
                this.七一丕上丄上万不不.下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorPointUI::上专世丌丑与丕丛丕()));
            System.Action val_6 = null;
            val_15 = val_6;
            val_6 = new System.Action(object:  this, method:  System.Void FortDefenceGeneratorPointUI::丕丕丞不丆业东下丒());
            this.七一丕上丄上万不不.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  val_6);
            if(this._cutter != 0)
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_15 = this.七一丕上丄上万不不;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.上丗丑东丁万丂世世, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, t:  this.七一丕上丄上万不不.三丏丟不丆丅丞不丛() / val_15.maxHealth);
            this._cutter.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        
        }
        
        UnityEngine.Color val_13 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  this.一丒一丄业丌丘专且);
        this._backSprite.color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        if(this.七一丕上丄上万不不.IsDead() == false)
        {
                return;
        }
        
        this.丕丕丞不丆业东下丒();
    }
    private void 上专世丌丑与丕丛丕()
    {
        this.丒丛丂丒丐丆丝丑东 = this.丆丅丘且且专上丂三;
        if(this._cutter == 0)
        {
                return;
        }
        
        if(this.七一丕上丄上万不不 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.上丗丑东丁万丂世世, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, t:  this.七一丕上丄上万不不.三丏丟不丆丅丞不丛() / this.七一丕上丄上万不不.maxHealth);
        this._cutter.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    private void Update()
    {
        this.丁丗且丂且丘与一专();
    }
    private void 丕丕丞不丆业东下丒()
    {
        this.丕丁丕业世丈与丅业();
        if(this._animationObject != 0)
        {
                this._animationObject.SetActive(value:  true);
        }
        
        if(this._numberGenerator != 0)
        {
                this._numberGenerator.text = "X";
        }
        
        UnityEngine.Color val_3 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  this.世一丛丝丏丆与丆丛);
        this._backSprite.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    private void 丁丗且丂且丘与一专()
    {
        if(this.丒丛丂丒丐丆丝丑东 <= 0f)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this._tweenScale)) != false)
        {
                this._tweenScale.enabled = true;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丒丛丂丒丐丆丝丑东 - val_2;
        this.丒丛丂丒丐丆丝丑东 = val_2;
        if(val_2 <= 0f)
        {
                this.丕丁丕业世丈与丅业();
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.万丛丐下丕丝七业丑 + val_3;
        this.万丛丐下丕丝七业丑 = val_3;
        if(val_3 < this.下丑东丗丑丁丂丝丌)
        {
                return;
        }
        
        bool val_7 = this.丅上丌丏丂一上丌丐;
        this.万丛丐下丕丝七业丑 = 0f;
        val_7 = val_7 ^ 1;
        this.丅上丌丏丂一上丌丐 = val_7;
        if(this._backSprite == 0)
        {
                return;
        }
        
        UnityEngine.Color val_6 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  (this.丅上丌丏丂一上丌丐 == true) ? this.世一丛丝丏丆与丆丛 : this.一丒一丄业丌丘专且);
        this._backSprite.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
    }
    private void 丕丁丕业世丈与丅业()
    {
        float val_5;
        float val_6;
        UnityEngine.Color val_1 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  this.一丒一丄业丌丘专且);
        val_5 = val_1.r;
        val_6 = val_1.b;
        this._backSprite.color = new UnityEngine.Color() {r = val_5, g = val_1.g, b = val_6, a = val_1.a};
        if((UnityEngine.Object.op_Implicit(exists:  this._tweenScale)) != false)
        {
                this._tweenScale.enabled = false;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            val_5 = val_4.x;
            val_6 = val_4.z;
            this._tweenScale.transform.localScale = new UnityEngine.Vector3() {x = val_5, y = val_4.y, z = val_6};
        }
        
        this.丅上丌丏丂一上丌丐 = false;
        this.万丛丐下丕丝七业丑 = 0f;
        this.丒丛丂丒丐丆丝丑东 = 0f;
    }
    public FortDefenceGeneratorPointUI()
    {
        this.一丒一丄业丌丘专且 = "FortDefGen_blue";
        this.世一丛丝丏丆与丆丛 = "FortDefGen_light_red";
        this.丟丌三世丕丕专业丒 = "FortDefGen_dark_red";
        this.不三丂世丝与丑三且 = "FortDefGen_orange";
        this.上丗丑东丁万丂世世 = 0;
        mem[1152921540105655672] = 0;
        this.丆丅丘且且专上丂三 = Infinityf;
        this.下丑东丗丑丁丂丝丌 = 0.5f;
    }

}
