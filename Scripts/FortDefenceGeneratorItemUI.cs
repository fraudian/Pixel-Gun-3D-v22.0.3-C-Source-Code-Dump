using UnityEngine;
internal sealed class FortDefenceGeneratorItemUI : PGBehaviour
{
    // Fields
    public UIWidget widget;
    private UITexture _background;
    private UITexture _mainIcon;
    private UILabel _name;
    private UISprite _lineSprite;
    private UISprite _leftLine;
    private UISprite _rightLine;
    private UILabel _countPlayer;
    private UISprite _colorPlayerInfo;
    private UnityEngine.Color 不丑丗丒且世丟丈一;
    private FortDefenceGeneratorUI.丙且丐丐专下丘与丛 丐丙丒丈丄不一丈与;
    public FortDefenceGeneratorItemUI nextItem;
    public FortDefenceGeneratorItemUI prevItem;
    public bool destroy;
    private float 丒丛丂丒丐丆丝丑东;
    private float 丆丅丘且且专上丂三;
    private float 下丑东丗丑丁丂丝丌;
    private float 万丛丐下丕丝七业丑;
    private bool 丅上丌丏丂一上丌丐;
    public int countEnemy;
    
    // Methods
    internal void 东丌丟三丞世一一丑(FortDefenceGeneratorUI.丙且丐丐专下丘与丛 下丅丙一丂丗丅丝七, bool 与世丏下东丕丝丞七, bool 专丛丆专专世丙丙丕)
    {
        System.Action val_31;
        float val_32;
        float val_33;
        mem[1152921540099868560] = 0;
        if(this.丐丙丒丈丄不一丈与 != 0)
        {
                this.丐丙丒丈丄不一丈与.丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorItemUI::丁一丏丄且丛上世且()));
            System.Action val_3 = null;
            val_31 = val_3;
            val_3 = new System.Action(object:  this, method:  System.Void FortDefenceGeneratorItemUI::丕丕丞不丆业东下丒());
            this.丐丙丒丈丄不一丈与.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  val_3);
        }
        
        if(this.丐丙丒丈丄不一丈与 != 0)
        {
                System.Action val_5 = null;
            val_31 = val_5;
            val_5 = new System.Action(object:  this, method:  System.Void FortDefenceGeneratorItemUI::丕丕丞不丆业东下丒());
            this.丐丙丒丈丄不一丈与.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  val_5);
        }
        
        if(this.丐丙丒丈丄不一丈与 != 0)
        {
                System.Action<System.Int32> val_7 = null;
            val_31 = val_7;
            val_7 = new System.Action<System.Int32>(object:  this, method:  System.Void FortDefenceGeneratorItemUI::与丏七丟丂东丄一丁(int 丌丒丝东丌下丕丁丅));
            this.丐丙丒丈丄不一丈与.remove_OnChangeMobCount(丙业与丙丗丝不丈东:  val_7);
        }
        
        if(下丅丙一丂丗丅丝七.丅丞万丒不专丈专丕 != 0)
        {
                val_31 = 1152921504615739392;
            下丅丙一丂丗丅丝七.丅丞万丒不专丈专丕.下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorItemUI::丁一丏丄且丛上世且()));
            下丅丙一丂丗丅丝七.丅丞万丒不专丈专丕.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorItemUI::丕丕丞不丆业东下丒()));
        }
        
        if(下丅丙一丂丗丅丝七.丅丞万丒不专丈专丕 != 0)
        {
                下丅丙一丂丗丅丝七.丅丞万丒不专丈专丕.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorItemUI::七丈专丐丛下丄不丛()));
        }
        
        if(this._background != 0)
        {
                val_32 = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.r;
            val_33 = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.b;
            this._background.color = new UnityEngine.Color() {r = val_32, g = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.g, b = val_33, a = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.a};
        }
        
        if(this._mainIcon != 0)
        {
                if((System.String.IsNullOrEmpty(value:  下丅丙一丂丗丅丝七.丛丐丌丙丈七丛丛东)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._mainIcon, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._mainIcon, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Texture val_17 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Textures/"("Textures/") + 下丅丙一丂丗丅丝七.丛丐丌丙丈七丛丛东);
        }
        
        }
        
        if(this._name != 0)
        {
                if((System.String.IsNullOrEmpty(value:  下丅丙一丂丗丅丝七.世丟丝不丈丕丅丘丁)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._name, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._name, 丏业丟一东丂东丘丛:  true);
            this._name.text = 下丅丙一丂丗丅丝七.世丟丝不丈丕丅丘丁;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._leftLine.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._rightLine.gameObject, 丏业丟一东丂东丘丛:  false);
        if((与世丏下东丕丝丞七 == true) || (专丛丆专专世丙丙丕 == true))
        {
            goto label_52;
        }
        
        if(this._lineSprite == 0)
        {
            goto label_77;
        }
        
        this._lineSprite.color = new UnityEngine.Color() {r = val_32, g = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.g, b = val_33, a = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.a};
        if(this._lineSprite != null)
        {
            goto label_79;
        }
        
        label_80:
        label_79:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._lineSprite.gameObject, 丏业丟一东丂东丘丛:  (与世丏下东丕丝丞七 == false) ? 1 : 0);
        goto label_77;
        label_52:
        if(与世丏下东丕丝丞七 == false)
        {
            goto label_61;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._lineSprite.gameObject, 丏业丟一东丂东丘丛:  false);
        if(this._leftLine == 0)
        {
            goto label_77;
        }
        
        this._leftLine.color = new UnityEngine.Color() {r = val_32, g = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.g, b = val_33, a = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.a};
        if(this._leftLine != null)
        {
            goto label_79;
        }
        
        goto label_80;
        label_61:
        if(专丛丆专专世丙丙丕 == false)
        {
            goto label_77;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._lineSprite.gameObject, 丏业丟一东丂东丘丛:  false);
        if(this._rightLine == 0)
        {
            goto label_77;
        }
        
        this._rightLine.color = new UnityEngine.Color() {r = val_32, g = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.g, b = val_33, a = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.a};
        if(this._rightLine != null)
        {
            goto label_79;
        }
        
        goto label_80;
        label_77:
        if(this._lineSprite != 0)
        {
                this._lineSprite.add_OnChangeMobCount(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void FortDefenceGeneratorItemUI::与丏七丟丂东丄一丁(int 丌丒丝东丌下丕丁丅)));
        }
        
        this.不丑丗丒且世丟丈一 = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.r;
        mem[1152921540099868372] = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.g;
        mem[1152921540099868380] = 下丅丙一丂丗丅丝七.不丑丗丒且世丟丈一.a;
        this.下业丘专业丁与丕丗(丌丒丝东丌下丕丁丅:  0);
        this.丟丗丑丝丙丕丅丏丏(丛且丝七丁与丕丒不:  false);
    }
    private void OnDestroy()
    {
        if(137109504 != 0)
        {
                remove_OnChangeMobCount(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void FortDefenceGeneratorItemUI::与丏七丟丂东丄一丁(int 丌丒丝东丌下丕丁丅)));
        }
        
        if(this.丐丙丒丈丄不一丈与 == 0)
        {
                return;
        }
        
        this.丐丙丒丈丄不一丈与.丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorItemUI::丁一丏丄且丛上世且()));
        this.丐丙丒丈丄不一丈与.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorItemUI::丕丕丞不丆业东下丒()));
    }
    private void 丁一丏丄且丛上世且()
    {
        this.丒丛丂丒丐丆丝丑东 = this.丆丅丘且且专上丂三;
    }
    private void 丕丕丞不丆业东下丒()
    {
        var val_12;
        UnityEngine.Color val_13;
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.Color val_17;
        var val_18;
        var val_19;
        var val_20;
        UnityEngine.Color val_21;
        var val_22;
        var val_23;
        var val_24;
        UnityEngine.Color val_25;
        var val_26;
        var val_27;
        var val_28;
        double val_29;
        double val_30;
        val_12 = this;
        this.destroy = true;
        this.丕丁丕业世丈与丅业();
        if(this.countEnemy > 0)
        {
                val_13 = this.不丑丗丒且世丟丈一;
            val_14 = 1152921540100446244;
            val_15 = 1152921540100446248;
            val_16 = 1152921540100446252;
        }
        else
        {
                val_13 = 1152921540100446320;
            val_14 = 1152921540100446324;
            val_15 = 1152921540100446328;
            val_16 = 1152921540100446332;
        }
        
        this._background.color = new UnityEngine.Color() {r = 1.257883E-13f, g = 1.257883E-13f, b = 1.257883E-13f, a = 1.257883E-13f};
        if(this.countEnemy > 0)
        {
                val_17 = this.不丑丗丒且世丟丈一;
            val_18 = 1152921540100446244;
            val_19 = 1152921540100446248;
            val_20 = 1152921540100446252;
        }
        else
        {
                val_17 = 1152921540100446320;
            val_18 = 1152921540100446324;
            val_19 = 1152921540100446328;
            val_20 = 1152921540100446332;
        }
        
        this._lineSprite.color = new UnityEngine.Color() {r = 1.257883E-13f, g = 1.257883E-13f, b = 1.257883E-13f, a = 1.257883E-13f};
        if(this.countEnemy > 0)
        {
                val_21 = this.不丑丗丒且世丟丈一;
            val_22 = 1152921540100446244;
            val_23 = 1152921540100446248;
            val_24 = 1152921540100446252;
        }
        else
        {
                val_21 = 1152921540100446320;
            val_22 = 1152921540100446324;
            val_23 = 1152921540100446328;
            val_24 = 1152921540100446332;
        }
        
        this._rightLine.color = new UnityEngine.Color() {r = 1.257883E-13f, g = 1.257883E-13f, b = 1.257883E-13f, a = 1.257883E-13f};
        if(this.countEnemy > 0)
        {
                val_25 = this.不丑丗丒且世丟丈一;
            val_26 = 1152921540100446244;
            val_27 = 1152921540100446248;
            val_28 = 1152921540100446252;
        }
        else
        {
                val_25 = 1152921540100446320;
            val_26 = 1152921540100446324;
            val_27 = 1152921540100446328;
            val_28 = 1152921540100446332;
        }
        
        this._leftLine.color = new UnityEngine.Color() {r = 1.257883E-13f, g = 1.257883E-13f, b = 1.257883E-13f, a = 1.257883E-13f};
        if(==0)
        {
                return;
        }
        
        if(this._name != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._name, 丏业丟一东丂东丘丛:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._mainIcon, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Texture val_3 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Textures/"("Textures/") + 1);
        val_12 = ???;
        val_29 = ???;
        val_30 = ???;
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
    }
    private void 七丈专丐丛下丄不丛()
    {
        this._lineSprite.color = new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B};
        this._rightLine.color = new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B};
        this._leftLine.color = new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    private void Update()
    {
        this.丁丗且丂且丘与一专();
        this.丈东与丄丏丏丐丐不();
    }
    private void 丁丗且丂且丘与一专()
    {
        float val_4;
        UnityEngine.Color val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = this.丒丛丂丒丐丆丝丑东;
        if(val_4 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_4 - val_1;
        this.丒丛丂丒丐丆丝丑东 = val_1;
        if(val_1 <= 0f)
        {
                this.丕丁丕业世丈与丅业();
        }
        
        val_4 = this.万丛丐下丕丝七业丑;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_4 + val_2;
        this.万丛丐下丕丝七业丑 = val_2;
        if(val_2 < this.下丑东丗丑丁丂丝丌)
        {
                return;
        }
        
        bool val_4 = this.丅上丌丏丂一上丌丐;
        this.万丛丐下丕丝七业丑 = 0f;
        val_4 = val_4 ^ 1;
        this.丅上丌丏丂一上丌丐 = val_4;
        if(this._background == 0)
        {
                return;
        }
        
        if(this.丅上丌丏丂一上丌丐 != false)
        {
                val_5 = 1152921540100856032;
            val_6 = 1152921540100856036;
            val_7 = 1152921540100856040;
            val_8 = 1152921540100856044;
        }
        else
        {
                val_5 = this.不丑丗丒且世丟丈一;
            val_6 = 1152921540100855972;
            val_7 = 1152921540100855976;
            val_8 = 1152921540100855980;
        }
        
        this._background.color = new UnityEngine.Color() {r = this.不丑丗丒且世丟丈一.r, g = 1.257883E-13f, b = 1.257883E-13f, a = 1.257883E-13f};
    }
    private void 丕丁丕业世丈与丅业()
    {
        this._background.color = new UnityEngine.Color() {r = this.不丑丗丒且世丟丈一, g = V9.16B, b = V10.16B, a = V11.16B};
        this.丅上丌丏丂一上丌丐 = false;
        this.万丛丐下丕丝七业丑 = 0f;
        this.丒丛丂丒丐丆丝丑东 = 0f;
    }
    private void 下业丘专业丁与丕丗(int 丌丒丝东丌下丕丁丅)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._countPlayer, 丏业丟一东丂东丘丛:  (丌丒丝东丌下丕丁丅 > 0) ? 1 : 0);
        this._countPlayer.text = 丌丒丝东丌下丕丁丅.ToString();
    }
    private void 与丏七丟丂东丄一丁(int 丌丒丝东丌下丕丁丅)
    {
        this.countEnemy = 丌丒丝东丌下丕丁丅;
    }
    private void 丟丗丑丝丙丕丅丏丏(bool 丛且丝七丁与丕丒不)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        if(this._colorPlayerInfo == 0)
        {
                return;
        }
        
        if(丛且丝七丁与丕丒不 != false)
        {
                val_2 = 1152921540101353252;
            val_3 = 1152921540101353256;
            val_4 = 1152921540101353260;
            val_5 = 1152921540101353264;
        }
        else
        {
                val_2 = 1152921540101353236;
            val_3 = 1152921540101353240;
            val_4 = 1152921540101353244;
            val_5 = 1152921540101353248;
        }
        
        this._colorPlayerInfo.color = new UnityEngine.Color() {r = 1.257883E-13f, g = 1.257883E-13f, b = 1.257883E-13f, a = 1.257883E-13f};
    }
    private void 丈东与丄丏丏丐丐不()
    {
        if(this.prevItem != 0)
        {
                if(this.prevItem.destroy == false)
        {
                return;
        }
        
        }
        
        if(this.countEnemy < 1)
        {
                if((this.丂世丆丄丌下丌丛且(下丅丙一丂丗丅丝七:  this)) != true)
        {
                if((this.专丄丙丗丈丂业一丝(下丅丙一丂丗丅丝七:  this)) == false)
        {
            goto label_9;
        }
        
        }
        
        }
        
        label_9:
        this.丁丄丈丑下丄丁下丄(一丝丁一下不丑七丆:  true);
    }
    private bool 丂世丆丄丌下丌丛且(FortDefenceGeneratorItemUI 下丅丙一丂丗丅丝七)
    {
        FortDefenceGeneratorItemUI val_3;
        FortDefenceGeneratorItemUI val_4;
        var val_5;
        val_3 = 下丅丙一丂丗丅丝七;
        goto label_0;
        label_10:
        val_3 = 下丅丙一丂丗丅丝七.prevItem;
        label_0:
        if(下丅丙一丂丗丅丝七.prevItem.prevItem == 0)
        {
            goto label_5;
        }
        
        val_4 = 下丅丙一丂丗丅丝七.prevItem.prevItem;
        if(下丅丙一丂丗丅丝七.prevItem.prevItem.countEnemy > 0)
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 下丅丙一丂丗丅丝七.prevItem.prevItem;
        if(val_4 != 0)
        {
            goto label_10;
        }
        
        val_5 = 0;
        return (bool)val_5;
        label_7:
        val_5 = 1;
        return (bool)val_5;
    }
    private bool 专丄丙丗丈丂业一丝(FortDefenceGeneratorItemUI 下丅丙一丂丗丅丝七)
    {
        FortDefenceGeneratorItemUI val_3;
        FortDefenceGeneratorItemUI val_4;
        var val_5;
        val_3 = 下丅丙一丂丗丅丝七;
        goto label_0;
        label_10:
        val_3 = 下丅丙一丂丗丅丝七.nextItem;
        label_0:
        if(下丅丙一丂丗丅丝七.nextItem.nextItem == 0)
        {
            goto label_5;
        }
        
        val_4 = 下丅丙一丂丗丅丝七.nextItem.nextItem;
        if(下丅丙一丂丗丅丝七.nextItem.nextItem.countEnemy > 0)
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 下丅丙一丂丗丅丝七.nextItem.nextItem;
        if(val_4 != 0)
        {
            goto label_10;
        }
        
        val_5 = 0;
        return (bool)val_5;
        label_7:
        val_5 = 1;
        return (bool)val_5;
    }
    private void 丁丄丈丑下丄丁下丄(bool 一丝丁一下不丑七丆)
    {
        var val_4;
        var val_5;
        var val_6;
        if(一丝丁一下不丑七丆 == false)
        {
            goto label_0;
        }
        
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.不丑丗丒且世丟丈一}, rhs:  new UnityEngine.Color())) == false)
        {
                return;
        }
        
        val_4 = W8;
        val_5 = W9;
        val_6 = W10;
        this.不丑丗丒且世丟丈一 = new UnityEngine.Color();
        mem[1152921540101928100] = ???;
        mem[1152921540101928104] = ???;
        mem[1152921540101928108] = ???;
        if(this._background != null)
        {
            goto label_3;
        }
        
        goto label_3;
        label_0:
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.不丑丗丒且世丟丈一}, rhs:  new UnityEngine.Color())) == false)
        {
                return;
        }
        
        this.不丑丗丒且世丟丈一 = new UnityEngine.Color();
        mem[1152921540101928100] = ???;
        mem[1152921540101928104] = ???;
        mem[1152921540101928108] = ???;
        if(this.destroy == false)
        {
            goto label_5;
        }
        
        if(this._background != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        label_3:
        this._background.color = new UnityEngine.Color() {r = V11.16B, g = V10.16B, b = V9.16B, a = V8.16B};
        if(this.destroy == false)
        {
                return;
        }
        
        this._lineSprite.color = new UnityEngine.Color() {r = this.不丑丗丒且世丟丈一, g = V9.16B, b = V10.16B, a = V11.16B};
        this._rightLine.color = new UnityEngine.Color() {r = this.不丑丗丒且世丟丈一, g = V9.16B, b = V10.16B, a = V11.16B};
        this._leftLine.color = new UnityEngine.Color() {r = this.不丑丗丒且世丟丈一, g = V9.16B, b = V10.16B, a = V11.16B};
        return;
        label_5:
        if(this._background != null)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    public FortDefenceGeneratorItemUI()
    {
        this.丆丅丘且且专上丂三 = Infinityf;
        this.下丑东丗丑丁丂丝丌 = 0.5f;
    }

}
