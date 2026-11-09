using UnityEngine;
public class AimCrosshairController : MonoBehaviour
{
    // Fields
    public UISprite aimUpSprite;
    public UISprite aimDownSprite;
    public UISprite aimRightSprite;
    public UISprite aimLeftSprite;
    public UISprite aimCenterSprite;
    public UISprite aimUpLeftSprite;
    public UISprite aimDownLeftSprite;
    public UISprite aimDownRightSprite;
    public UISprite aimUpRightSprite;
    public UnityEngine.GameObject headshotHitmarker;
    public System.Collections.Generic.List<UITexture> headshotHitmarkerSprites;
    public System.Collections.Generic.List<UITexture> headshotHitmarkerPlusSprites;
    private float headshotHitmarkerTime;
    private float 三且万丂与丝丂不丆;
    private bool 丞丟丂丟上丈丂七东;
    private UnityEngine.Color 丒丑专丗世丞一专且;
    public UnityEngine.GameObject aimHit;
    public TweenScale aimHitTweenScale;
    public TweenAlpha aimHitTweenAlpha;
    public float crosshairColorLerpSpeed;
    public System.Collections.Generic.List<UITexture> aimHitSprites;
    public System.Collections.Generic.List<UITexture> aimHitPlusSprites;
    private System.Collections.Generic.List<PositionConsider> 丙丑专三业东不业七;
    public System.Collections.Generic.List<int> crosshairsToSetPlusAimHit;
    private float 丄丏上三七与上专与;
    public UnityEngine.Color _aimHitColor;
    public UnityEngine.Color _aimKillColor;
    public UISprite aimRect;
    public UILabel aimAutoShootDistance;
    internal UnityEngine.GameObject 三丟丙不且下丅上丌;
    internal UnityEngine.GameObject 丝丅三三丝丅丗三与;
    internal UnityEngine.GameObject 丈东七丈一丂丗丄且;
    internal UnityEngine.GameObject 丕丛丏一与丁与一丗;
    internal UnityEngine.GameObject 丛丅与丄一三与丌且;
    internal UnityEngine.GameObject 丑丏专丏丞不丂不丏;
    internal UnityEngine.GameObject 丂东专下丑丝丛丑丁;
    internal UnityEngine.GameObject 丆专丐下世与专丙丂;
    internal UnityEngine.GameObject 丏一世丙专不不丄丝;
    private UnityEngine.Vector2[] 丝丕丘丛丆丑一万丘;
    private UnityEngine.Vector2[] 丒丟万一丁丐丘丌世;
    private CrosshairData.aimSprite 东丒丁丆一丒丌下丘;
    private CrosshairData.aimSprite 七丆丁丅丞下丅丄下;
    private CrosshairData.aimSprite 丈东丈丂丆东七丒丗;
    private CrosshairData.aimSprite 丐丙丟丝丏丕丙万丄;
    private CrosshairData.aimSprite 丒丈不丑丅丒一不丌;
    private CrosshairData.aimSprite 丘丑上丙一丗丂丂丒;
    private CrosshairData.aimSprite 丁丂丐丅丒与丁丐万;
    private CrosshairData.aimSprite 万上丅丁东丒且一丅;
    private CrosshairData.aimSprite 且七丕丄万世业丈万;
    private CrosshairData.aimSprite 丂三专东专丁丄万丁;
    private CrosshairData.aimSprite 丗东上丛世丘业丒不;
    private CrosshairData.aimSprite 丞丒上丐上丞业丝丘;
    private bool 不三业一丘丞丁丝三;
    private bool 丟丛世下万丌丌下东;
    private bool 一且三丟业丞丞丑丟;
    private UnityEngine.Color 丄与丏且丟世丞丟专;
    private bool 世丐东丑业丐三不且;
    private bool 三上与且丑丕丗丒丙;
    private bool 丒丁上丝下丈丙世业;
    private UnityEngine.Coroutine 一上丒不丈丁七丟丗;
    private UnityEngine.WaitForSeconds 丕一丒丝丒丝下专丙;
    private UnityEngine.Coroutine 三丙丐丛丂丄且与三;
    
    // Methods
    private void Awake()
    {
        this.三丟丙不且下丅上丌 = this.aimUpSprite.gameObject;
        this.丝丅三三丝丅丗三与 = this.aimDownSprite.gameObject;
        this.丈东七丈一丂丗丄且 = this.aimRightSprite.gameObject;
        this.丕丛丏一与丁与一丗 = this.aimLeftSprite.gameObject;
        this.丛丅与丄一三与丌且 = this.aimCenterSprite.gameObject;
        this.丑丏专丏丞不丂不丏 = this.aimUpLeftSprite.gameObject;
        this.丂东专下丑丝丛丑丁 = this.aimDownLeftSprite.gameObject;
        this.丆专丐下世与专丙丂 = this.aimDownRightSprite.gameObject;
        this.丏一世丙专不不丄丝 = this.aimUpRightSprite.gameObject;
        this.丙丑专三业东不业七.Clear();
        List.Enumerator<T> val_10 = this.aimHitSprites.GetEnumerator();
        label_15:
        if(((-896036680) & 1) == 0)
        {
            goto label_12;
        }
        
        this.丙丑专三业东不业七.Add(item:  0.丐丏七丌丕丗业且上().GetComponent<PositionConsider>());
        goto label_15;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_13 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  24);
        if(val_13 == null)
        {
                return;
        }
        
        if((val_13.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool")) == false)
        {
                return;
        }
        
        this.丒丁上丝下丈丙世业 = true;
        this.丑专丝一丏上丆丐业(下下东且万业丞丅丒:  false);
    }
    private void Update()
    {
        var val_28;
        var val_29;
        float val_30;
        float val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        float val_43;
        var val_44;
        var val_45;
        Player_move_c val_46;
        var val_47;
        float val_48;
        var val_49;
        var val_50;
        var val_51;
        val_28 = null;
        val_28 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗() == 0)
        {
                return;
        }
        
        val_30 = this.三且万丂与丝丂不丆;
        if(val_30 > 0f)
        {
                val_32 = val_30 - UnityEngine.Time.deltaTime;
            this.三且万丂与丝丂不丆 = val_32;
            val_33 = 1;
        }
        else
        {
                val_33 = 0;
        }
        
        this.与且丟丟丞上业下丅(下下东且万业丞丅丒:  false);
        val_34 = null;
        val_34 = null;
        val_35 = null;
        val_35 = null;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == true)
        {
            goto label_26;
        }
        
        val_36 = null;
        val_36 = null;
        if(TrainingController.丙专丆丏七丕丄上丗 == true)
        {
            goto label_46;
        }
        
        label_26:
        if(GameConnect.丁丁丗丐东丄丞一丛() == true)
        {
            goto label_46;
        }
        
        val_37 = null;
        val_37 = null;
        val_38 = null;
        val_38 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
                val_38 = 0;
        }
        
        if(null == 0)
        {
                val_38 = 0;
        }
        
        val_38 = 0;
        val_38 = 0;
        if(this.与上丐世世丄丑丏丂() == false)
        {
            goto label_47;
        }
        
        label_46:
        this.丑专丝一丏上丆丐业(下下东且万业丞丅丒:  false);
        label_127:
        val_39 = null;
        val_39 = null;
        if((UnityEngine.Object.op_Implicit(exists:  WeaponManager.丟丗丄业丘丗业丗七)) == false)
        {
                return;
        }
        
        val_40 = null;
        val_40 = null;
        if((UnityEngine.Object.op_Implicit(exists:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
                return;
        }
        
        val_41 = null;
        val_41 = null;
        val_30 = 1f;
        if((且丂一丁丆丒与丁业() != true) && (与丂丏丛丞丞丒丟丄.丑与业不丘与丑万丟() != false))
        {
                val_42 = null;
            val_42 = null;
            三丈丟与丏丘丈丐万 val_13 = WeaponManager.丟丗丄业丘丗业丗七.一丗上丆三东上丄丛();
            val_43 = 0.5f;
            if(丅且不三丅丂上丈丅().且丈丗丗丞且丑丐专() > val_43)
        {
                val_44 = null;
            val_44 = null;
            if(val_13.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() != 2)
        {
            goto label_128;
        }
        
        }
        
            val_45 = null;
            val_45 = null;
            val_46 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_46 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_32 = 0.7f;
            val_43 = 1f;
            var val_18 = (val_13.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == 2) ? (val_43) : (val_32);
        }
        
        label_128:
        val_47 = null;
        val_47 = null;
        if(Player_move_c.不丟丟一丈万丒万丒 != 0)
        {
            goto label_95;
        }
        
        val_48 = 1f;
        goto label_126;
        label_95:
        if(this.一上丒不丈丁七丟丗 != null)
        {
                this.StopCoroutine(routine:  this.一上丒不丈丁七丟丗);
            this.一上丒不丈丁七丟丗 = 0;
        }
        
        val_49 = null;
        val_49 = null;
        val_46 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_46 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if((Player_move_c.不丟丟一丈万丒万丒 + 1536.IsEnemyTo(专丞上七七且丝七丗:  val_46)) == false)
        {
            goto label_105;
        }
        
        val_50 = null;
        val_50 = null;
        UnityEngine.Vector3 val_22 = transform.position;
        UnityEngine.Vector3 val_24 = Player_move_c.不丟丟一丈万丒万丒.transform.position;
        WeaponSounds val_26 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_26.isMelee == false)
        {
            goto label_119;
        }
        
        val_51 = null;
        val_51 = null;
        float val_27 = GetAutoFireDistance();
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z})) >= 0)
        {
            goto label_124;
        }
        
        label_119:
        val_48 = 0f;
        goto label_126;
        label_105:
        val_48 = 0.32f;
        goto label_126;
        label_124:
        val_48 = 0.3f;
        label_126:
        this.SetCrosshairColor(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        return;
        label_47:
        this.丑专丝一丏上丆丐业(下下东且万业丞丅丒:  true);
        this.上不不丆与上不丆丄();
        goto label_127;
    }
    private bool 与上丐世世丄丑丏丂()
    {
        InGameGUI val_4;
        var val_5;
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                val_4 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_4 != 0)
        {
                if(typeof(InGameGUIPart_Imposter).__il2cppRuntimeField_28.isWorldMapOpened != false)
        {
                val_5 = 1;
            return (bool)val_5;
        }
        
        }
        
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    private void 丑专丝一丏上丆丐业(bool 下下东且万业丞丅丒)
    {
        bool val_2 = ((this.丒丁上丝下丈丙世业 == false) ? 1 : 0) & 下下东且万业丞丅丒;
        var val_3 = (this.一且三丟业丞丞丑丟 == true) ? 1 : 0;
        val_3 = val_3 ^ val_2;
        if(val_3 != true)
        {
                return;
        }
        
        this.一且三丟业丞丞丑丟 = val_2;
        this.aimCenterSprite.enabled = val_2;
        this.aimDownSprite.enabled = val_2;
        this.aimUpSprite.enabled = val_2;
        this.aimLeftSprite.enabled = val_2;
        this.aimRightSprite.enabled = val_2;
        this.aimUpLeftSprite.enabled = val_2;
        this.aimUpRightSprite.enabled = val_2;
        this.aimDownLeftSprite.enabled = val_2;
        this.aimDownRightSprite.enabled = val_2;
    }
    private void 与且丟丟丞上业下丅(bool 下下东且万业丞丅丒)
    {
        bool val_3;
        var val_1 = (this.丞丟丂丟上丈丂七东 == true) ? 1 : 0;
        val_1 = val_1 ^ 下下东且万业丞丅丒;
        if(val_1 == false)
        {
                return;
        }
        
        val_3 = 下下东且万业丞丅丒;
        this.丞丟丂丟上丈丂七东 = val_3;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.headshotHitmarker, 丏业丟一东丂东丘丛:  val_3);
        if(下下东且万业丞丅丒 == false)
        {
                return;
        }
        
        if(this.三上与且丑丕丗丒丙 == true)
        {
                return;
        }
        
        this.三上与且丑丕丗丒丙 = true;
    }
    private void 一一丗东东世专丞东(UnityEngine.Color 丁业三丟下丟不丕且)
    {
        var val_4 = this;
        if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = this.丒丑专丗世丞一专且, g = 丁业三丟下丟不丕且.g, b = 丁业三丟下丟不丕且.b, a = 丁业三丟下丟不丕且.a}, rhs:  new UnityEngine.Color() {r = 丁业三丟下丟不丕且.r, g = 丁业三丟下丟不丕且.g, b = 丁业三丟下丟不丕且.b, a = 丁业三丟下丟不丕且.a})) == true)
        {
                return;
        }
        
        this.丒丑专丗世丞一专且 = 丁业三丟下丟不丕且;
        mem[1152921538071407624] = 丁业三丟下丟不丕且.g;
        mem[1152921538071407628] = 丁业三丟下丟不丕且.b;
        mem[1152921538071407632] = 丁业三丟下丟不丕且.a;
        List.Enumerator<T> val_2 = this.headshotHitmarkerSprites.GetEnumerator();
        label_5:
        if(((-895189960) & 1) == 0)
        {
            goto label_3;
        }
        
        0.丐丏七丌丕丗业且上().color = new UnityEngine.Color() {r = 丁业三丟下丟不丕且.r, g = 丁业三丟下丟不丕且.g, b = 丁业三丟下丟不丕且.b, a = 丁业三丟下丟不丕且.a};
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 东专下万丞丈专丛丞()
    {
        this.三且万丂与丝丂不丆 = this.headshotHitmarkerTime;
    }
    private void 上不不丆与上不丆丄()
    {
        var val_29;
        var val_30;
        var val_31;
        WeaponManager val_32;
        float val_35;
        UnityEngine.Vector2[] val_36;
        var val_37;
        val_29 = null;
        val_29 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_30 = null;
            val_30 = null;
            val_31 = null;
            val_31 = null;
            WeaponSounds val_2 = 业丁不丒丑丂丏三下();
            val_32 = WeaponManager.丟丗丄业丘丗业丗七;
            UnityEngine.Vector2 val_4 = 业丁不丒丑丂丏三下().世丆丈丐东东丁丁丗();
            float val_5 = val_2.tekKoof * val_4.y;
            val_5 = val_5 * 0.5f;
            val_35 = val_5 + 12f;
            this.三丟丙不且下丅上丌.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丏一世丙专不不丄丝.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丈东七丈一丂丗丄且.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丆专丐下世与专丙丂.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丝丅三三丝丅丗三与.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丂东专下丑丝丛丑丁.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丕丛丏一与丁与一丗.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_36 = this.丑丏专丏丞不丂不丏.transform;
            if(val_36 != null)
        {
            goto label_36;
        }
        
        }
        else
        {
                val_37 = null;
            val_37 = null;
            WeaponSounds val_14 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            float val_29 = val_14.三且丞万与世丏与一;
            WeaponSounds val_15 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            UnityEngine.Vector2 val_17 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗().世丆丈丐东东丁丁丗();
            float val_30 = val_17.y;
            val_29 = val_29 * val_15.丌丑下丆东与东业丆;
            val_30 = val_29 * val_30;
            val_35 = val_30 * 0.5f;
            val_17.y = (-this.丝丕丘丛丆丑一万丘[1]) - val_35;
            this.丝丅三三丝丅丗三与.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_20 = val_35 + this.丝丕丘丛丆丑一万丘[2];
            this.三丟丙不且下丅上丌.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_34 = -this.丝丕丘丛丆丑一万丘[3];
            val_34 = val_34 - val_35;
            this.丕丛丏一与丁与一丗.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_37 = -this.丝丕丘丛丆丑一万丘[4];
            val_37 = val_37 - val_35;
            float val_38 = -this.丝丕丘丛丆丑一万丘[4];
            val_38 = val_38 - val_35;
            this.丂东专下丑丝丛丑丁.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_40 = this.丝丕丘丛丆丑一万丘[5];
            float val_41 = -this.丝丕丘丛丆丑一万丘[5];
            val_41 = val_41 - val_35;
            val_40 = val_35 + val_40;
            this.丑丏专丏丞不丂不丏.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_42 = this.丝丕丘丛丆丑一万丘[3];
            val_42 = val_35 + val_42;
            this.丈东七丈一丂丗丄且.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_26 = val_35 + this.丝丕丘丛丆丑一万丘[4];
            float val_45 = -this.丝丕丘丛丆丑一万丘[4];
            val_45 = val_45 - val_35;
            this.丆专丐下世与专丙丂.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_32 = this.丝丕丘丛丆丑一万丘;
            val_36 = this.丝丕丘丛丆丑一万丘;
            UnityEngine.Vector2 val_47 = val_36[5];
            float val_28 = val_35 + val_32[5];
            val_47 = val_35 + val_47;
        }
        
        label_36:
        this.丏一世丙专不不丄丝.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public void SetCrosshairColor(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = this.丄与丏且丟世丞丟专, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a}, rhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a})) != false)
        {
                return;
        }
        
        this.丄与丏且丟世丞丟专 = 丑丞丈丗丄丙丟万丄;
        mem[1152921538072976848] = 丑丞丈丗丄丙丟万丄.g;
        mem[1152921538072976852] = 丑丞丈丗丄丙丟万丄.b;
        mem[1152921538072976856] = 丑丞丈丗丄丙丟万丄.a;
        this.aimCenterSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.aimDownSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.aimUpSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.aimLeftSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.aimRightSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.aimUpLeftSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.aimUpRightSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.aimDownLeftSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.aimDownRightSprite.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    public void SetCrosshair(WeaponSounds 丄丏丅与丙丆丞丒丏)
    {
        var val_9;
        UnityEngine.Vector2 val_42;
        var val_43;
        var val_44;
        var val_45;
        val_42 = 1152921504848912384;
        if(丄丏丅与丙丆丞丒丏 == 0)
        {
                return;
        }
        
        WeaponCustomCrosshair val_2 = 丄丏丅与丙丆丞丒丏.GetComponent<WeaponCustomCrosshair>();
        bool val_3 = GameConnect.丟丆丏上丌一丝丟业();
        if(val_3 == false)
        {
            goto label_7;
        }
        
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimCenterSprite, 丂丐丄丁丆与丈丂上:  this.丁丂丐丅丒与丁丐万, 丑丞丙丟丒业专一专:  false);
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownSprite, 丂丐丄丁丆与丈丂上:  this.万上丅丁东丒且一丅, 丑丞丙丟丒业专一专:  false);
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpSprite, 丂丐丄丁丆与丈丂上:  this.且七丕丄万世业丈万, 丑丞丙丟丒业专一专:  false);
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimLeftSprite, 丂丐丄丁丆与丈丂上:  this.丂三专东专丁丄万丁, 丑丞丙丟丒业专一专:  false);
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimRightSprite, 丂丐丄丁丆与丈丂上:  this.丂三专东专丁丄万丁, 丑丞丙丟丒业专一专:  true);
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpLeftSprite, 丂丐丄丁丆与丈丂上:  this.丞丒上丐上丞业丝丘, 丑丞丙丟丒业专一专:  false);
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpRightSprite, 丂丐丄丁丆与丈丂上:  this.丞丒上丐上丞业丝丘, 丑丞丙丟丒业专一专:  true);
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownLeftSprite, 丂丐丄丁丆与丈丂上:  this.丗东上丛世丘业丒不, 丑丞丙丟丒业专一专:  false);
        val_3.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownRightSprite, 丂丐丄丁丆与丈丂上:  this.丗东上丛世丘业丒不, 丑丞丙丟丒业专一专:  true);
        this.丝丕丘丛丆丑一万丘[0] = this.丁丂丐丅丒与丁丐万.offset;
        this.丝丕丘丛丆丑一万丘[0] = this.丁丂丐丅丒与丁丐万;
        this.丝丕丘丛丆丑一万丘[1] = this.万上丅丁东丒且一丅.offset;
        this.丝丕丘丛丆丑一万丘[1] = this.万上丅丁东丒且一丅;
        this.丝丕丘丛丆丑一万丘[2] = this.且七丕丄万世业丈万.offset;
        this.丝丕丘丛丆丑一万丘[2] = this.且七丕丄万世业丈万;
        this.丝丕丘丛丆丑一万丘[3] = this.丂三专东专丁丄万丁.offset;
        this.丝丕丘丛丆丑一万丘[3] = this.丂三专东专丁丄万丁;
        this.丝丕丘丛丆丑一万丘[4] = this.丗东上丛世丘业丒不.offset;
        this.丝丕丘丛丆丑一万丘[4] = this.丗东上丛世丘业丒不;
        this.丝丕丘丛丆丑一万丘[5] = this.丞丒上丐上丞业丝丘.offset;
        this.丝丕丘丛丆丑一万丘[5] = new UnityEngine.Vector2();
        this.丟丛世下万丌丌下东 = false;
        val_43 = 0;
        goto label_26;
        label_31:
        if(this.crosshairsToSetPlusAimHit.Item[0] == val_2.DataId)
        {
                this.丟丛世下万丌丌下东 = true;
        }
        
        val_43 = 1;
        label_26:
        if(val_43 < this.crosshairsToSetPlusAimHit.Count)
        {
            goto label_31;
        }
        
        List.Enumerator<T> val_7 = this.aimHitSprites.GetEnumerator();
        val_44 = 1152921536698870736;
        label_35:
        if(((-892398048) & 1) == 0)
        {
            goto label_33;
        }
        
        var val_11 = (this.丟丛世下万丌丌下东 == true) ? 0f : 1f;
        if(val_9.丐丏七丌丕丗业且上() != null)
        {
            goto label_35;
        }
        
        goto label_35;
        label_7:
        bool val_12 = UnityEngine.Object.op_Inequality(x:  val_2, y:  0);
        if(val_12 == false)
        {
            goto label_38;
        }
        
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimCenterSprite, 丂丐丄丁丆与丈丂上:  val_13.center, 丑丞丙丟丒业专一专:  false);
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownSprite, 丂丐丄丁丆与丈丂上:  val_14.down, 丑丞丙丟丒业专一专:  false);
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpSprite, 丂丐丄丁丆与丈丂上:  val_15.up, 丑丞丙丟丒业专一专:  false);
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimLeftSprite, 丂丐丄丁丆与丈丂上:  val_16.left, 丑丞丙丟丒业专一专:  false);
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimRightSprite, 丂丐丄丁丆与丈丂上:  val_17.left, 丑丞丙丟丒业专一专:  true);
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpLeftSprite, 丂丐丄丁丆与丈丂上:  val_18.leftUp, 丑丞丙丟丒业专一专:  false);
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpRightSprite, 丂丐丄丁丆与丈丂上:  val_19.leftUp, 丑丞丙丟丒业专一专:  true);
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownLeftSprite, 丂丐丄丁丆与丈丂上:  val_20.leftDown, 丑丞丙丟丒业专一专:  false);
        val_2.Data.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownRightSprite, 丂丐丄丁丆与丈丂上:  val_21.leftDown, 丑丞丙丟丒业专一专:  true);
        CrosshairData val_22 = val_2.Data;
        this.丝丕丘丛丆丑一万丘[0] = val_22.center.offset;
        this.丝丕丘丛丆丑一万丘[0] = val_22.center;
        CrosshairData val_23 = val_2.Data;
        this.丝丕丘丛丆丑一万丘[1] = val_23.down.offset;
        this.丝丕丘丛丆丑一万丘[1] = val_23.down;
        CrosshairData val_24 = val_2.Data;
        this.丝丕丘丛丆丑一万丘[2] = val_24.up.offset;
        this.丝丕丘丛丆丑一万丘[2] = val_24.up;
        CrosshairData val_25 = val_2.Data;
        this.丝丕丘丛丆丑一万丘[3] = val_25.left.offset;
        this.丝丕丘丛丆丑一万丘[3] = val_25.left;
        CrosshairData val_26 = val_2.Data;
        this.丝丕丘丛丆丑一万丘[4] = val_26.leftDown.offset;
        this.丝丕丘丛丆丑一万丘[4] = val_26.leftDown;
        CrosshairData val_27 = val_2.Data;
        this.丝丕丘丛丆丑一万丘[5] = val_27.leftUp.offset;
        this.丝丕丘丛丆丑一万丘[5] = new UnityEngine.Vector2();
        this.丟丛世下万丌丌下东 = false;
        val_45 = 0;
        goto label_87;
        label_92:
        if(this.crosshairsToSetPlusAimHit.Item[0] == val_2.DataId)
        {
                this.丟丛世下万丌丌下东 = true;
        }
        
        val_45 = 1;
        label_87:
        if(val_45 < this.crosshairsToSetPlusAimHit.Count)
        {
            goto label_92;
        }
        
        List.Enumerator<T> val_31 = this.aimHitSprites.GetEnumerator();
        val_44 = 1152921536698870736;
        label_96:
        if(((-892398048) & 1) == 0)
        {
            goto label_94;
        }
        
        var val_33 = (this.丟丛世下万丌丌下东 == true) ? 0f : 1f;
        if(val_9.丐丏七丌丕丗业且上() != null)
        {
            goto label_96;
        }
        
        goto label_96;
        label_38:
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimCenterSprite, 丂丐丄丁丆与丈丂上:  this.东丒丁丆一丒丌下丘, 丑丞丙丟丒业专一专:  false);
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownSprite, 丂丐丄丁丆与丈丂上:  this.七丆丁丅丞下丅丄下, 丑丞丙丟丒业专一专:  false);
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpSprite, 丂丐丄丁丆与丈丂上:  this.丈东丈丂丆东七丒丗, 丑丞丙丟丒业专一专:  false);
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimLeftSprite, 丂丐丄丁丆与丈丂上:  this.丐丙丟丝丏丕丙万丄, 丑丞丙丟丒业专一专:  false);
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimRightSprite, 丂丐丄丁丆与丈丂上:  this.丐丙丟丝丏丕丙万丄, 丑丞丙丟丒业专一专:  true);
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpLeftSprite, 丂丐丄丁丆与丈丂上:  this.丘丑上丙一丗丂丂丒, 丑丞丙丟丒业专一专:  false);
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimUpRightSprite, 丂丐丄丁丆与丈丂上:  this.丘丑上丙一丗丂丂丒, 丑丞丙丟丒业专一专:  true);
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownLeftSprite, 丂丐丄丁丆与丈丂上:  this.丒丈不丑丅丒一不丌, 丑丞丙丟丒业专一专:  false);
        val_12.业丟与丆丌上万一上(与丄丈丘丟丕丏丐丁:  this.aimDownRightSprite, 丂丐丄丁丆与丈丂上:  this.丒丈不丑丅丒一不丌, 丑丞丙丟丒业专一专:  true);
        this.丝丕丘丛丆丑一万丘[0] = this.东丒丁丆一丒丌下丘.offset;
        this.丝丕丘丛丆丑一万丘[0] = this.东丒丁丆一丒丌下丘;
        this.丝丕丘丛丆丑一万丘[1] = this.七丆丁丅丞下丅丄下.offset;
        this.丝丕丘丛丆丑一万丘[1] = this.七丆丁丅丞下丅丄下;
        this.丝丕丘丛丆丑一万丘[2] = this.丈东丈丂丆东七丒丗.offset;
        this.丝丕丘丛丆丑一万丘[2] = this.丈东丈丂丆东七丒丗;
        this.丝丕丘丛丆丑一万丘[3] = this.丐丙丟丝丏丕丙万丄.offset;
        this.丝丕丘丛丆丑一万丘[3] = this.丐丙丟丝丏丕丙万丄;
        this.丝丕丘丛丆丑一万丘[4] = this.丒丈不丑丅丒一不丌.offset;
        this.丝丕丘丛丆丑一万丘[4] = this.丒丈不丑丅丒一不丌;
        val_42 = this.丘丑上丙一丗丂丂丒.offset;
        this.丝丕丘丛丆丑一万丘[5] = val_42;
        this.丝丕丘丛丆丑一万丘[5] = this.丘丑上丙一丗丂丂丒;
        goto label_137;
        label_33:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_126;
        label_94:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_42 = this.aimHitPlusSprites;
        List.Enumerator<T> val_34 = val_42.GetEnumerator();
        label_123:
        if(((-892398048) & 1) == 0)
        {
            goto label_128;
        }
        
        var val_36 = (this.丟丛世下万丌丌下东 == true) ? 1f : 0f;
        if(val_9.丐丏七丌丕丗业且上() != null)
        {
            goto label_123;
        }
        
        goto label_123;
        label_126:
        val_42 = this.aimHitPlusSprites;
        List.Enumerator<T> val_37 = val_42.GetEnumerator();
        label_130:
        if(((-892398048) & 1) == 0)
        {
            goto label_128;
        }
        
        var val_39 = (this.丟丛世下万丌丌下东 == true) ? 1f : 0f;
        if(val_9.丐丏七丌丕丗业且上() != null)
        {
            goto label_130;
        }
        
        goto label_130;
        label_128:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_2.DataId == 2)
        {
                this.不三业一丘丞丁丝三 = true;
        }
        else
        {
                this.不三业一丘丞丁丝三 = false;
        }
        
        label_137:
        this.上不不丆与上不丆丄();
    }
    private void 业丟与丆丌上万一上(UISprite 与丄丈丘丟丕丏丐丁, CrosshairData.aimSprite 丂丐丄丁丆与丈丂上, bool 丑丞丙丟丒业专一专 = False)
    {
        UnityEngine.Vector2 val_8;
        float val_9;
        bool val_1 = System.String.IsNullOrEmpty(value:  丂丐丄丁丆与丈丂上.spriteName);
        UnityEngine.GameObject val_2 = 与丄丈丘丟丕丏丐丁.gameObject;
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_1 == false)
        {
            goto label_4;
        }
        
        label_5:
        val_2.SetActive(value:  false);
        return;
        label_3:
        if(val_1 == true)
        {
            goto label_5;
        }
        
        label_4:
        val_2.SetActive(value:  true);
        与丄丈丘丟丕丏丐丁.spriteName = 丂丐丄丁丆与丈丂上.spriteName;
        与丄丈丘丟丕丏丐丁.width = UnityEngine.Mathf.RoundToInt(f:  丂丐丄丁丆与丈丂上.spriteSize);
        int val_4 = UnityEngine.Mathf.RoundToInt(f:  丂丐丄丁丆与丈丂上.spriteSize);
        if(与丄丈丘丟丕丏丐丁 != null)
        {
                与丄丈丘丟丕丏丐丁.height = val_4;
        }
        else
        {
                与丄丈丘丟丕丏丐丁.height = val_4;
        }
        
        val_8 = 丂丐丄丁丆与丈丂上.offset;
        if(丑丞丙丟丒业专一专 != false)
        {
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_8, y:  -S9);
            val_8 = val_6.x;
            val_9 = val_6.y;
        }
        
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8, y = val_9});
        与丄丈丘丟丕丏丐丁.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    internal void 与丂丄丄万丁丅丑丞(bool 万丝一万丐且丌业丛, bool 世丕与丙丄丙不丄丝)
    {
        var val_3;
        var val_21;
        var val_22;
        var val_23;
        float val_25;
        float val_26;
        bool val_21 = 世丕与丙丄丙不丄丝;
        List.Enumerator<T> val_1 = this.aimHitSprites.GetEnumerator();
        label_3:
        if(((-890997504) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        goto label_3;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        List.Enumerator<T> val_5 = this.aimHitPlusSprites.GetEnumerator();
        val_21 = val_21 ^ 1;
        label_11:
        if(((-890997504) & 1) == 0)
        {
            goto label_8;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  val_21);
        goto label_11;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        val_21 = 0;
        if(this.丟丛世下万丌丌下东 == false)
        {
            goto label_16;
        }
        
        val_22 = 1152921525976704464;
        goto label_17;
        label_21:
        val_25 = mem[万丝一万丐且丌业丛 != true ? 1152921538075600244 : 1152921538075600228];
        val_25 = (万丝一万丐且丌业丛 != true) ? 1152921538075600244 : 1152921538075600228;
        val_26 = mem[万丝一万丐且丌业丛 != true ? 1152921538075600248 : 1152921538075600232];
        val_26 = (万丝一万丐且丌业丛 != true) ? 1152921538075600248 : 1152921538075600232;
        this.aimHitPlusSprites.Item[0].color = new UnityEngine.Color() {r = (万丝一万丐且丌业丛 != true) ? this._aimKillColor : this._aimHitColor, g = (万丝一万丐且丌业丛 != true) ? 1152921538075600240 : 1152921538075600224, b = val_25, a = val_26};
        val_21 = 1;
        label_17:
        if(val_21 < this.aimHitPlusSprites.Count)
        {
            goto label_21;
        }
        
        goto label_22;
        label_16:
        val_23 = 1152921525976704464;
        goto label_23;
        label_29:
        val_25 = mem[万丝一万丐且丌业丛 != true ? 1152921538075600244 : 1152921538075600228];
        val_25 = (万丝一万丐且丌业丛 != true) ? 1152921538075600244 : 1152921538075600228;
        val_26 = mem[万丝一万丐且丌业丛 != true ? 1152921538075600248 : 1152921538075600232];
        val_26 = (万丝一万丐且丌业丛 != true) ? 1152921538075600248 : 1152921538075600232;
        this.aimHitSprites.Item[0].color = new UnityEngine.Color() {r = (万丝一万丐且丌业丛 != true) ? this._aimKillColor : this._aimHitColor, g = (万丝一万丐且丌业丛 != true) ? 1152921538075600240 : 1152921538075600224, b = val_25, a = val_26};
        this.丙丑专三业东不业七.Item[0].丛一万丐世丈不丕丝(丙业与丙丗丝不丈东:  false);
        val_21 = 1;
        label_23:
        if(val_21 < this.aimHitSprites.Count)
        {
            goto label_29;
        }
        
        label_22:
        this.aimHitTweenAlpha.PlayForward();
    }
    internal void 丅丐丈丆与丆丂丈丛(bool 丄丁丑丞丅一三丌丆)
    {
    
    }
    internal void 丛丐丒上丒丘丆丕与(bool 万丐七下丂丂丛世丞, bool 且世与七东丕丈丗丁, bool 世丕与丙丄丙不丄丝 = False)
    {
        bool val_11;
        var val_12;
        val_11 = 万丐七下丂丂丛世丞;
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
                return;
        }
        
        if(世丕与丙丄丙不丄丝 == true)
        {
            goto label_10;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_3 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  9);
        if(val_3 == null)
        {
            goto label_10;
        }
        
        val_12 = val_3.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool");
        goto label_11;
        label_10:
        val_12 = 0;
        label_11:
        if(与丂丏丛丞丞丒丟丄.丞丐业业与丟万丂丞() != false)
        {
                if(且世与七东丕丈丗丁 == false)
        {
            goto label_15;
        }
        
        }
        
        AimCrosshairController.上丑丐丕东三丝东上(丂一上丄世丂丟丒七:  世丕与丙丄丙不丄丝, 业七不丕丑三丈丘丆:  val_12 & 1);
        goto label_16;
        label_15:
        FirstPersonControlSharp.NeedHitTaptick();
        label_16:
        val_11 = val_11;
        this.与丂丄丄万丁丅丑丞(万丝一万丐且丌业丛:  val_11, 世丕与丙丄丙不丄丝:  世丕与丙丄丙不丄丝);
        if(val_11 != false)
        {
                UnityEngine.Color val_9 = UnityEngine.Color.red;
        }
        else
        {
                UnityEngine.Color val_10 = UnityEngine.Color.white;
        }
        
        this.一一丗东东世专丞东(丁业三丟下丟不丕且:  new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a});
        if(世丕与丙丄丙不丄丝 == false)
        {
                return;
        }
        
        this.三且万丂与丝丂不丆 = this.headshotHitmarkerTime;
    }
    private System.Collections.IEnumerator 丑丒丗丗丅东丈一丌(UnityEngine.Color 丑丞丈丗丄丙丟万丄, System.Action 业丏丈世世世丞丒世)
    {
        AimCrosshairController.丕丝丐业东与业世丒 val_1 = new AimCrosshairController.丕丝丐业东与业世丒();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丑丞丈丗丄丙丟万丄 = 丑丞丈丗丄丙丟万丄;
        mem[1152921538076041772] = 丑丞丈丗丄丙丟万丄.g;
        mem[1152921538076041776] = 丑丞丈丗丄丙丟万丄.b;
        mem[1152921538076041780] = 丑丞丈丗丄丙丟万丄.a;
        .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丁丌丙上丟丛三丛专(UnityEngine.GameObject 七丕上万丈丞与丝一)
    {
        AimCrosshairController.丙丁丁丁不专丏丙万 val_1 = new AimCrosshairController.丙丁丁丁不专丏丙万();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .七丕上万丈丞与丝一 = 七丕上万丈丞与丝一;
        return (System.Collections.IEnumerator)val_1;
    }
    private void OnDestroy()
    {
        if(this.三丙丐丛丂丄且与三 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.三丙丐丛丂丄且与三);
        this.三丙丐丛丂丄且与三 = 0;
    }
    private void OnDisable()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.SetCrosshairColor(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
    }
    public AimCrosshairController()
    {
        this.headshotHitmarkerSprites = new System.Collections.Generic.List<UITexture>();
        this.headshotHitmarkerPlusSprites = new System.Collections.Generic.List<UITexture>();
        this.headshotHitmarkerTime = 0.25f;
        UnityEngine.Color val_3 = UnityEngine.Color.red;
        this.丒丑专丗世丞一专且 = val_3;
        mem[1152921538076574952] = val_3.g;
        mem[1152921538076574956] = val_3.b;
        mem[1152921538076574960] = val_3.a;
        this.crosshairColorLerpSpeed = 0.5f;
        this.aimHitSprites = new System.Collections.Generic.List<UITexture>();
        this.aimHitPlusSprites = new System.Collections.Generic.List<UITexture>();
        this.丙丑专三业东不业七 = new System.Collections.Generic.List<PositionConsider>();
        this.crosshairsToSetPlusAimHit = new System.Collections.Generic.List<System.Int32>();
        this.丄丏上三七与上专与 = 1f;
        this.丝丕丘丛丆丑一万丘 = new UnityEngine.Vector2[6];
        this.丒丟万一丁丐丘丌世 = new UnityEngine.Vector2[4];
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  0f, y:  0f);
        this.东丒丁丆一丒丌下丘 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  0f, y:  8f);
        this.七丆丁丅丞下丅丄下 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "pricel_v", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0f, y:  8f);
        this.丈东丈丂丆东七丒丗 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "pricel_v", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
        UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  8f, y:  0f);
        this.丐丙丟丝丏丕丙万丄 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "pricel_h", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  8f, y:  8f);
        this.丒丈不丑丅丒一不丌 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  8f, y:  8f);
        this.丘丑上丙一丗丂丂丒 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
        UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  0f, y:  0f);
        this.丁丂丐丅丒与丁丐万 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
        UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  0f, y:  8f);
        this.万上丅丁东丒且一丅 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y});
        UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_35 = new UnityEngine.Vector2(x:  0f, y:  8f);
        this.且七丕丄万世业丈万 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_34.x, y = val_34.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_35.x, y = val_35.y});
        UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  10f, y:  22f);
        UnityEngine.Vector2 val_38 = new UnityEngine.Vector2(x:  25f, y:  0f);
        this.丂三专东专丁丄万丁 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "aim_6", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_38.x, y = val_38.y});
        UnityEngine.Vector2 val_40 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_41 = new UnityEngine.Vector2(x:  8f, y:  8f);
        this.丗东上丛世丘业丒不 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y});
        UnityEngine.Vector2 val_43 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_44 = new UnityEngine.Vector2(x:  8f, y:  8f);
        this.丞丒上丐上丞业丝丘 = new CrosshairData.aimSprite(丒丘丏上丙丟丑丕丈:  "", 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_43.x, y = val_43.y}, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y});
        this.一且三丟业丞丞丑丟 = true;
        UnityEngine.Color val_46 = UnityEngine.Color.white;
        this.丄与丏且丟世丞丟专 = val_46;
        mem[1152921538076575280] = val_46.g;
        mem[1152921538076575284] = val_46.b;
        mem[1152921538076575288] = val_46.a;
        this.丕一丒丝丒丝下专丙 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
    }
    internal static void 上丑丐丕东三丝东上(bool 丂一上丄世丂丟丒七, bool 业七不丕丑三丈丘丆)
    {
        if(丂一上丄世丂丟丒七 != false)
        {
            
        }
        else
        {
                if(业七不丕丑三丈丘丆 != false)
        {
                return;
        }
        
        }
        
        FirstPersonControlSharp.TapticHit(丐不丁专业丌七东丕:  0.5f, 丘丞丌丙上万丒上丁:  0.5f);
    }

}
