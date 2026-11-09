using UnityEngine;
public class ShopShootingController : MonoBehaviour
{
    // Fields
    private string Layer;
    private float shotStubSpeed;
    private bool 丕丗丕丗丙与丕丟万;
    private UnityEngine.AudioSource 丞下上且一上丙不丏;
    private int 不丙且专七丟丅下丕;
    private float 丌东东丙丐三丌丏东;
    internal System.Func<CharacterInterfaceV2> 专丒下丛丄丁丁万丐;
    private float 丌丞丂丑业丝下丄业;
    private int 丐世专丙丟下丟丅七;
    private UnityEngine.Animation 丐丞丑一丟丕世专丅;
    private float 三东丂三丒丌不丝丁;
    private FlashFire[] 下丛丗丑不不与丒与;
    public System.Func<UnityEngine.GameObject> CurrentWeaponObjectGetter;
    private UnityEngine.Vector3[] 丌且七一丘且丏丈世;
    private WeaponSounds 丆业七丌丁丕一丐七;
    private float endIdleCrossFadeTimeout;
    private int 丌世下丝东丈专丛丄;
    private float 丑业东且丏丌与专丝;
    private ShopShootingController.上丒业世丝业万业丒 东不丞业丅东丅下丆;
    private UnityEngine.GameObject invisibleParticle;
    private float 丕与丝万与丏丒丘丟;
    private string 丗丗丁丘与丄丆丁世;
    private int 丁上丏世丛丙丗世丑;
    private UnityEngine.Transform onGroundEffectPoint;
    private UnityEngine.Coroutine 丙且七业不丝上丈东;
    private UnityEngine.GameObject 不丐丐东丅一丛丙丛;
    public bool PlayIdleSound;
    private ShopShootingController.丛与丁丆业世丛丁下[] 且丈丌丗丝丆上丏丝;
    private float rocketLifeTime;
    private UnityEngine.Coroutine 丌丕丅丅丗丗丞专丌;
    private UnityEngine.Coroutine 丂丑业丄世丄丂丐一;
    private ShopShootButtonController shootButton;
    private bool noProfileAnim;
    private const string 丙上丐三业丞丞丏丂 = "Shoot";
    private float startIdleCrossFadeTimeout;
    private int 丐三丛丅与丕丙丟万;
    private int 丈丙七丄三一三丕丑;
    
    // Properties
    internal UnityEngine.Transform 丕丂东一与丘三不专 { get; }
    internal bool 上丏丏三丆丁丟下三 { get; set; }
    internal ShopShootButtonController 丛丁丕不丒丐丞丈丗 { get; set; }
    private bool 丏上一东丛世丑三丙 { get; set; }
    
    // Methods
    internal UnityEngine.Transform 丕丌七丂丈丌丄万万()
    {
        return (UnityEngine.Transform)this.onGroundEffectPoint;
    }
    internal bool 丙丏七丁东丒丅与丈()
    {
        return (bool)this.noProfileAnim;
    }
    internal void 丁丙丞丁业丄丄丅东(bool 丙业与丙丗丝不丈东)
    {
        this.noProfileAnim = 丙业与丙丗丝不丈东;
    }
    internal ShopShootButtonController 东丗丂不丄一丆丞三()
    {
        return (ShopShootButtonController)this.shootButton;
    }
    internal void 丏丒丆三丈丄丅且一(ShopShootButtonController 丙业与丙丗丝不丈东)
    {
        this.shootButton = 丙业与丙丗丝不丈东;
    }
    private bool 丛不丈丒不丞丙与丑()
    {
        return (bool)this.丕丗丕丗丙与丕丟万;
    }
    private void 业丆丂万丒丂万七丒(bool 丙业与丙丗丝不丈东)
    {
        UnityEngine.GameObject val_9;
        System.Func<CharacterInterfaceV2> val_10;
        var val_11;
        var val_1 = (this.丕丗丕丗丙与丕丟万 == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        val_9 = this.invisibleParticle;
        if(val_9 == 0)
        {
                return;
        }
        
        val_10 = this.专丒下丛丄丁丁万丐;
        this.丕丗丕丗丙与丕丟万 = 丙业与丙丗丝不丈东;
        if(val_10 == null)
        {
                val_11 = null;
            val_11 = null;
            val_10 = ShopShootingController.<>c.<>9__47_0;
            if(val_10 != null)
        {
                this.专丒下丛丄丁丁万丐 = val_10;
        }
        else
        {
                System.Func<CharacterInterfaceV2> val_4 = null;
            val_10 = val_4;
            val_4 = new System.Func<CharacterInterfaceV2>(object:  ShopShootingController.<>c.__il2cppRuntimeField_static_fields, method:  CharacterInterfaceV2 ShopShootingController.<>c::丏上与不丂丕与世丙());
            ShopShootingController.<>c.<>9__47_0 = val_10;
            this.专丒下丛丄丁丁万丐 = val_10;
        }
        
        }
        
        val_4.Invoke().gameObject.SetActive(value:  (this.丕丗丕丗丙与丕丟万 == false) ? 1 : 0);
        this.invisibleParticle.SetActive(value:  (this.丕丗丕丗丙与丕丟万 == true) ? 1 : 0);
    }
    private bool 丞东一丗丑丌丂丗丌(string 丒丘丏上丙丟丑丕丈)
    {
        string val_5;
        var val_6;
        val_5 = 丒丘丏上丙丟丑丕丈;
        if((this.丐丞丑一丟丕世专丅.IsPlaying(name:  val_5)) != false)
        {
                val_5 = this.丐丞丑一丟丕世专丅.Item[val_5];
            var val_4 = (val_5.wrapMode != 2) ? 1 : 0;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private bool 丗不东一丅与丙专业()
    {
        var val_5;
        if((this.丆业七丌丁丕一丐七 != 0) && (this.丐丞丑一丟丕世专丅 != 0))
        {
                if((this.丞东一丗丑丌丂丗丌(丒丘丏上丙丟丑丕丈:  "Shoot")) != true)
        {
                if((this.丞东一丗丑丌丂丗丌(丒丘丏上丙丟丑丕丈:  "Shoot1")) == false)
        {
                return this.丞东一丗丑丌丂丗丌(丒丘丏上丙丟丑丕丈:  "Shoot2");
        }
        
        }
        
            val_5 = 1;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    private float 丈三丁丝丐三丗一丅()
    {
        float val_4 = this.丆业七丌丁丕一丐七.meleeAttackTimeModifier;
        val_4 = (this.丐丞丑一丟丕世专丅.Item[(this.丆业七丌丁丕一丐七.isDoubleShot == true) ? "Shoot1" : "Shoot"].length) * val_4;
        return (float)val_4;
    }
    private void 专一上丏丅丞丈与丂(int 丘丒丌下丕专且七专)
    {
        UnityEngine.Object val_5;
        FlashFire val_6;
        val_5 = 丘丒丌下丕专且七专;
        val_6 = this.下丛丗丑不不与丒与[(long)val_5];
        if(val_6 == 0)
        {
                return;
        }
        
        FlashFire val_5 = this.下丛丗丑不不与丒与[(long)val_5];
        val_6 = this.下丛丗丑不不与丒与[(long)(int)(丘丒丌下丕专且七专)][0].gunFlashObj;
        if(val_6 == 0)
        {
                return;
        }
        
        FlashFire val_6 = this.下丛丗丑不不与丒与[(long)val_5];
        val_5 = this.下丛丗丑不不与丒与[(long)(int)(丘丒丌下丕专且七专)][0].gunFlashObj.GetComponent<ShopGunFlashReposition>();
        if(val_5 == 0)
        {
                return;
        }
        
        val_5.Reposition();
    }
    private UnityEngine.Vector3 东丂七丆且丞丟丕东(int 丘丌丆上丞万丒与与)
    {
        var val_4;
        var val_5;
        if((丘丌丆上丞万丒与与 >= 1) && (this.丆业七丌丁丕一丐七.bulletSpawnPoints.Count > 丘丌丆上丞万丒与与))
        {
                val_4 = 1152921535679084048;
            val_5 = 丘丌丆上丞万丒与与;
        }
        else
        {
                val_4 = 1152921535679084048;
            val_5 = 0;
        }
        
        if(this.丆业七丌丁丕一丐七.bulletSpawnPoints.Item[0].transform != null)
        {
                return 0.position;
        }
        
        return 0.position;
    }
    internal void Reset()
    {
        if(this.丐丞丑一丟丕世专丅 == 0)
        {
                return;
        }
        
        this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  8);
    }
    private void 丄丅丙丏丂丘三丈世(ShopShootingController.上丒业世丝业万业丒 丏业丟一东丂东丘丛)
    {
        上丒业世丝业万业丒 val_20;
        上丒业世丝业万业丒 val_21;
        WeaponSounds val_23;
        val_20 = 丏业丟一东丂东丘丛;
        val_21 = this.东不丞业丅东丅下丆;
        if(val_21 != 4)
        {
            goto label_1;
        }
        
        if(this.丆业七丌丁丕一丐七.isLoopShoot == true)
        {
            goto label_3;
        }
        
        val_21 = this.东不丞业丅东丅下丆;
        label_1:
        if(val_21 != 2)
        {
            goto label_7;
        }
        
        label_3:
        if(this.丞下上且一上丙不丏 != 0)
        {
                this.丞下上且一上丙不丏.Stop();
        }
        
        label_7:
        if(val_20 > 8)
        {
            goto label_49;
        }
        
        var val_20 = 106014588 + (丏业丟一东丂东丘丛) << 2;
        val_20 = val_20 + 106014588;
        goto (106014588 + (丏业丟一东丂东丘丛) << 2 + 106014588);
        label_49:
        if(this.丆业七丌丁丕一丐七.isBurstShooting == false)
        {
            goto label_55;
        }
        
        if(val_20 != 3)
        {
            goto label_52;
        }
        
        val_20 = 3;
        this.丐三丛丅与丕丙丟万 = this.丆业七丌丁丕一丐七.countShootInBurst;
        goto label_56;
        label_52:
        int val_21 = this.丐三丛丅与丕丙丟万;
        val_21 = val_21 - 1;
        if(val_20 < 3)
        {
            goto label_55;
        }
        
        this.丐三丛丅与丕丙丟万 = val_21;
        val_20 = 4;
        goto label_56;
        label_55:
        this.丐三丛丅与丕丙丟万 = 0;
        label_56:
        val_23 = this.丆业七丌丁丕一丐七;
        if(((val_20 - 3) >= 2) && (val_23.丕丗丒不一且丛业丟() != false))
        {
                val_23 = this.丐丞丑一丟丕世专丅;
            if(val_23 != 0)
        {
                val_23 = this.丐丞丑一丟丕世专丅;
            val_23.wrapMode = 0;
        }
        
        }
        
        this.东不丞业丅东丅下丆 = val_20;
    }
    private void 万下丅专丐丝丝七与()
    {
        float val_37;
        float val_38;
        var val_39;
        UnityEngine.Animation val_40;
        string val_41;
        UnityEngine.Vector3[] val_42;
        var val_43;
        System.Collections.Generic.List<BulletSpawnPoint> val_44;
        UnityEngine.Vector3[] val_45;
        this.丐丞丑一丟丕世专丅 = this.丆业七丌丁丕一丐七.丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>();
        if(this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁() != null)
        {
                val_37 = 1f;
            var val_8 = (this.丆业七丌丁丕一丐七.丕丗丒不一且丛业丟() != true) ? (val_37) : BalanceController.一丝丙丙不一丞丕丟(丟丈一下东业一丝丆:  this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁().业东丅东丌上丗丑不());
            if((this.丐丞丑一丟丕世专丅.GetClip(name:  "Reload")) != 0)
        {
                val_37 = BalanceController.不丟丄丗七丙丕世丆(丟丈一下东业一丝丆:  this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁().业东丅东丌上丗丑不());
            this.丐丞丑一丟丕世专丅.Item["Reload"].speed = val_37;
        }
        
            val_39 = this.丆业七丌丁丕一丐七;
            int val_15 = val_39.AmmoInClip;
        }
        else
        {
                val_38 = this.shotStubSpeed;
            val_39 = 100;
        }
        
        this.丐世专丙丟下丟丅七 = 100;
        if(this.丐丞丑一丟丕世专丅 == null)
        {
            goto label_23;
        }
        
        if(this.丆业七丌丁丕一丐七.isDoubleShot == false)
        {
            goto label_24;
        }
        
        label_28:
        this.丐丞丑一丟丕世专丅.Item["Shoot1"].speed = val_38;
        val_40 = this.丐丞丑一丟丕世专丅;
        val_41 = "Shoot2";
        goto label_27;
        label_23:
        if(this.丆业七丌丁丕一丐七.isDoubleShot == true)
        {
            goto label_28;
        }
        
        label_24:
        if((this.丐丞丑一丟丕世专丅.GetClip(name:  "Shoot")) == 0)
        {
            goto label_31;
        }
        
        val_40 = this.丐丞丑一丟丕世专丅;
        val_41 = "Shoot";
        label_27:
        val_37 = val_38;
        val_40.Item[val_41].speed = val_37;
        label_31:
        if(this.丆业七丌丁丕一丐七.bulletSpawnPoints.Count < 1)
        {
            goto label_36;
        }
        
        int val_21 = this.丆业七丌丁丕一丐七.bulletSpawnPoints.Count;
        this.下丛丗丑不不与丒与 = new FlashFire[0];
        val_42 = 1152921535679084048;
        val_43 = 0;
        goto label_39;
        label_51:
        BulletSpawnPoint val_23 = this.丆业七丌丁丕一丐七.bulletSpawnPoints.Item[0];
        if(this.下丛丗丑不不与丒与 == null)
        {
            goto label_43;
        }
        
        if(val_23.flashFire != null)
        {
            goto label_44;
        }
        
        goto label_47;
        label_43:
        if(val_23.flashFire == null)
        {
            goto label_47;
        }
        
        label_44:
        label_47:
        this.下丛丗丑不不与丒与[0] = val_23.flashFire;
        this.专一上丏丅丞丈与丂(丘丒丌下丕专且七专:  0);
        val_43 = 1;
        label_39:
        val_44 = this.丆业七丌丁丕一丐七.bulletSpawnPoints;
        if(val_43 < val_44.Count)
        {
            goto label_51;
        }
        
        goto label_52;
        label_36:
        FlashFire[] val_25 = new FlashFire[1];
        this.下丛丗丑不不与丒与 = val_25;
        val_44 = this.丆业七丌丁丕一丐七.GetComponent<FlashFire>();
        val_25[0] = val_44;
        this.专一上丏丅丞丈与丂(丘丒丌下丕专且七专:  0);
        label_52:
        this.丌世下丝东丈专丛丄 = this.丆业七丌丁丕一丐七.isDoubleShot;
        this.丕与丝万与丏丒丘丟 = this.丐丞丑一丟丕世专丅.Item["Profile"].normalizedTime;
        this.丑业东且丏丌与专丝 = 0f;
        if(this.丆业七丌丁丕一丐七._innerPars == 0)
        {
            goto label_67;
        }
        
        InnerWeaponPars val_31 = this.丆业七丌丁丕一丐七._innerPars;
        if(val_31.bonesRoot == null)
        {
            goto label_67;
        }
        
        InnerWeaponPars val_32 = this.丆业七丌丁丕一丐七._innerPars;
        val_45 = new UnityEngine.Vector3[0];
        val_44 = 0;
        this.丌且七一丘且丏丈世 = val_45;
        goto label_71;
        label_80:
        val_42 = this.丌且七一丘且丏丈世;
        InnerWeaponPars val_34 = this.丆业七丌丁丕一丐七._innerPars;
        UnityEngine.Vector3 val_35 = val_34.bonesRoot[0].localScale;
        val_38 = val_35.x;
        var val_36 = val_42 + (0 * 12);
        mem2[0] = val_38;
        mem2[0] = val_35.y;
        mem2[0] = val_35.z;
        val_45 = this.丌且七一丘且丏丈世;
        val_44 = 1;
        label_71:
        if(val_44 < this.丌且七一丘且丏丈世.Length)
        {
            goto label_80;
        }
        
        label_67:
        this.丈丙七丄三一三丕丑 = 0;
    }
    private void 丌与下且七丐丞丆业(UnityEngine.GameObject 丁丂丏与丗上丗一丆)
    {
        var val_5;
        var val_6;
        System.Action<UnityEngine.Transform> val_8;
        System.Collections.Generic.List<UnityEngine.GameObject> val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        null.Add(item:  丁丂丏与丗上丗一丆);
        val_5 = 0;
        goto label_2;
        label_12:
        val_6 = null;
        val_6 = null;
        val_8 = ShopShootingController.<>c.<>9__56_0;
        if(val_8 == null)
        {
                val_8 = null;
            val_8 = new System.Action<UnityEngine.Transform>(object:  ShopShootingController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopShootingController.<>c::丁丕丛丕丌东丒丑下(UnityEngine.Transform 丙丒七丄上与丏丙丙));
            ShopShootingController.<>c.<>9__56_0 = val_8;
        }
        
        Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  null.Item[0], 丌专业且丛丏丞丝且:  null);
        val_5 = 1;
        label_2:
        if(val_5 < null.Count)
        {
            goto label_12;
        }
    
    }
    private System.Collections.IEnumerator 七下世丗且丗三业且(int 丂下丁上丌丕丒丙丄, float 丝丗业丘丏与上东丆, float 业丒三且三万丐丟上 = 0)
    {
        ShopShootingController.丘丁丟丆丏丈丐丙下 val_1 = new ShopShootingController.丘丁丟丆丏丈丐丙下();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丂下丁上丌丕丒丙丄 = 丂下丁上丌丕丒丙丄;
            .丝丗业丘丏与上东丆 = 丝丗业丘丏与上东丆;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丂下丁上丌丕丒丙丄;
            mem[48] = 丝丗业丘丏与上东丆;
        }
        
        .业丒三且三万丐丟上 = 业丒三且三万丐丟上;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 且丗丑丆下丑丘世丏(int 丂下丁上丌丕丒丙丄, float 丕丕世且下一与丝与, int 丈丗一世丈丁专与丟, float 一丐丞丝下丙三丟丄, float 丝丗业丘丏与上东丆, float 业丒三且三万丐丟上)
    {
        ShopShootingController.丆东丘一丂丑丂一丆 val_1 = new ShopShootingController.丆东丘一丂丑丂一丆();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丂下丁上丌丕丒丙丄 = 丂下丁上丌丕丒丙丄;
            .丈丗一世丈丁专与丟 = 丈丗一世丈丁专与丟;
            .一丐丞丝下丙三丟丄 = 一丐丞丝下丙三丟丄;
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            .丝丗业丘丏与上东丆 = 丝丗业丘丏与上东丆;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丂下丁上丌丕丒丙丄;
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            mem[56] = 丈丗一世丈丁专与丟;
            .一丐丞丝下丙三丟丄 = 一丐丞丝下丙三丟丄;
            mem[48] = 丝丗业丘丏与上东丆;
        }
        
        .业丒三且三万丐丟上 = 业丒三且三万丐丟上;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 与下丛丝丐下世丕丐(int 丂下丁上丌丕丒丙丄, int 丈丗一世丈丁专与丟, float 一丐丞丝下丙三丟丄)
    {
        ShopShootingController.万丁丗与丄世丕丝丙 val_1 = new ShopShootingController.万丁丗与丄世丕丝丙();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丂下丁上丌丕丒丙丄 = 丂下丁上丌丕丒丙丄;
            .丈丗一世丈丁专与丟 = 丈丗一世丈丁专与丟;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丂下丁上丌丕丒丙丄;
            .丈丗一世丈丁专与丟 = 丈丗一世丈丁专与丟;
        }
        
        .一丐丞丝下丙三丟丄 = 一丐丞丝下丙三丟丄;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丆丑丐不丝上七上丝(int 丂下丁上丌丕丒丙丄, bool 三丑且丆与万丞丂世 = False)
    {
    
    }
    private void 与东丐丌丒丕丕丛东(string 专丝丌万东七丕丗丌, int 丟丘丆七三丐丂丏丏, UnityEngine.Vector3 下七丆丑万丙丂三下, UnityEngine.Quaternion 上丗东丒丁不丒丛丄)
    {
        var val_16;
        float val_17;
        UnityEngine.Object val_18;
        if(((System.String.op_Inequality(a:  this.丗丗丁丘与丄丆丁世, b:  "")) == false) || ((System.String.op_Inequality(a:  this.丗丗丁丘与丄丆丁世, b:  专丝丌万东七丕丗丌)) == false))
        {
            goto label_2;
        }
        
        val_16 = 0;
        goto label_3;
        label_21:
        if(this.且丈丌丗丝丆上丏丝[0] != null)
        {
                丛与丁丆业世丛丁下 val_17 = this.且丈丌丗丝丆上丏丝[0];
            if(this.且丈丌丗丝丆上丏丝[0x0][0].下丐三丆丝与不丗丕 != 0)
        {
                丛与丁丆业世丛丁下 val_18 = this.且丈丌丗丝丆上丏丝[0];
            UnityEngine.Object.Destroy(obj:  this.且丈丌丗丝丆上丏丝[0x0][0].下丐三丆丝与不丗丕);
        }
        
            this.且丈丌丗丝丆上丏丝[0] = 0;
        }
        
        val_16 = 1;
        label_3:
        if(val_16 < this.且丈丌丗丝丆上丏丝.Length)
        {
            goto label_21;
        }
        
        label_2:
        this.丗丗丁丘与丄丆丁世 = 专丝丌万东七丕丗丌;
        if(this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏] == null)
        {
            goto label_24;
        }
        
        丛与丁丆业世丛丁下 val_20 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        if(this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].下丐三丆丝与不丗丕 != 0)
        {
            goto label_30;
        }
        
        label_24:
        this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏] = new ShopShootingController.丛与丁丆业世丛丁下();
        丛与丁丆业世丛丁下 val_21 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        val_17 = 下七丆丑万丙丂三下.x;
        this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].下丐三丆丝与不丗丕 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Rays/"("Rays/") + 专丝丌万东七丕丗丌), position:  new UnityEngine.Vector3() {x = val_17, y = 下七丆丑万丙丂三下.y, z = 下七丆丑万丙丂三下.z}, rotation:  new UnityEngine.Quaternion() {x = 上丗东丒丁不丒丛丄.x, y = 上丗东丒丁不丒丛丄.y, z = 上丗东丒丁不丒丛丄.z, w = 上丗东丒丁不丒丛丄.w});
        丛与丁丆业世丛丁下 val_22 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].下丐三丆丝与不丗丕, 不东丛三丂丌丑专丆:  this.丁上丏世丛丙丗世丑);
        丛与丁丆业世丛丁下 val_23 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].与与专丟丗东丌与丆 = -1.175494E-38f;
        丛与丁丆业世丛丁下 val_24 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        FreezerRay val_9 = this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].下丐三丆丝与不丗丕.GetComponent<FreezerRay>();
        if(val_9 != 0)
        {
                丛与丁丆业世丛丁下 val_25 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
            this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].与与专丟丗东丌与丆 = val_9.lifetime;
            UnityEngine.Object.Destroy(obj:  val_9);
        }
        
        丛与丁丆业世丛丁下 val_26 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        val_18 = this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].下丐三丆丝与不丗丕.GetComponent<RayAndExplosionsStackItem>();
        if(val_18 == 0)
        {
            goto label_76;
        }
        
        丛与丁丆业世丛丁下 val_27 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        val_17 = val_11.timeDeactivate;
        if(this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].与与专丟丗东丌与丆 > val_17)
        {
                丛与丁丆业世丛丁下 val_28 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
            this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].与与专丟丗东丌与丆 = val_11.timeDeactivate;
        }
        
        UnityEngine.Object.Destroy(obj:  val_18);
        goto label_76;
        label_30:
        丛与丁丆业世丛丁下 val_29 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].下丐三丆丝与不丗丕.transform.position = new UnityEngine.Vector3() {x = 下七丆丑万丙丂三下.x, y = 下七丆丑万丙丂三下.y, z = 下七丆丑万丙丂三下.z};
        丛与丁丆业世丛丁下 val_30 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        val_17 = 上丗东丒丁不丒丛丄.x;
        this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].下丐三丆丝与不丗丕.transform.rotation = new UnityEngine.Quaternion() {x = val_17, y = 上丗东丒丁不丒丛丄.y, z = 上丗东丒丁不丒丛丄.z, w = 上丗东丒丁不丒丛丄.w};
        丛与丁丆业世丛丁下 val_31 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        val_18 = this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].下丐三丆丝与不丗丕;
        val_18.SetActive(value:  true);
        label_76:
        丛与丁丆业世丛丁下 val_32 = this.且丈丌丗丝丆上丏丝[(long)丟丘丆七三丐丂丏丏];
        this.且丈丌丗丝丆上丏丝[(long)(int)(丟丘丆七三丐丂丏丏)][0].丐三丒丌七与万丂下 = UnityEngine.Time.realtimeSinceStartup;
    }
    private System.Collections.IEnumerator 东丅丑丌丐上上三东(float 丕丕世且下一与丝与, string 丁下不下业世下丛丐)
    {
        ShopShootingController.丏丄丛丝世上下下且 val_1 = new ShopShootingController.丏丄丛丝世上下下且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        }
        else
        {
                mem[40] = this;
            mem[32] = 丕丕世且下一与丝与;
        }
        
        .丁下不下业世下丛丐 = 丁下不下业世下丛丐;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丒丛丂丐丈丟丞上丐(float 丕丕世且下一与丝与, string 丁下不下业世下丛丐)
    {
        this.丝丐丆丐不丝丅专一();
        if((System.String.IsNullOrEmpty(value:  丁下不下业世下丛丐)) == true)
        {
                return;
        }
        
        this.丙且七业不丝上丈东 = this.StartCoroutine(routine:  this.东丅丑丌丐上上三东(丕丕世且下一与丝与:  丕丕世且下一与丝与, 丁下不下业世下丛丐:  丁下不下业世下丛丐));
    }
    private void 丝丐丆丐不丝丅专一()
    {
        if(this.丙且七业不丝上丈东 != null)
        {
                this.StopCoroutine(routine:  this.丙且七业不丝上丈东);
            this.丙且七业不丝上丈东 = 0;
        }
        
        if(this.不丐丐东丅一丛丙丛 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.不丐丐东丅一丛丙丛);
    }
    private void 丂丝东丞丝万三丘与()
    {
        UnityEngine.MonoBehaviour val_54;
        string val_55;
        var val_56;
        float val_57;
        var val_58;
        WeaponSounds val_59;
        WeaponSounds val_60;
        float val_61;
        int val_62;
        WeaponSounds val_63;
        var val_64;
        UnityEngine.Animation val_66;
        var val_67;
        string val_68;
        UnityEngine.Animation val_69;
        string val_70;
        int val_71;
        WeaponSounds val_72;
        WeaponSounds val_73;
        val_54 = this;
        val_55 = "Shoot";
        val_56 = this.丌世下丝东丈专丛丄 - 1;
        if()
        {
                val_55 = val_55 + this.丌世下丝东丈专丛丄.ToString();
        }
        else
        {
                val_56 = 0;
        }
        
        if(this.丆业七丌丁丕一丐七.isLoopShoot != true)
        {
                val_57 = 1f;
            this.万丙丘丗丆业丐万世(丆与丈丏丟七丁东丛:  this.丆业七丌丁丕一丐七.丁与东东丂三丈丙世(), 丛丝丗不丞丛丕七丏:  false, 与丁万东丌丑下丏丕:  val_57);
        }
        
        if(this.丆业七丌丁丕一丐七.丕丗丒不一且丛业丟() != false)
        {
                if((this.丐丞丑一丟丕世专丅.IsPlaying(name:  "Shoot")) == true)
        {
            goto label_9;
        }
        
        }
        
        bool val_6 = this.丐丞丑一丟丕世专丅.Play(animation:  val_55);
        label_9:
        if(((this.丆业七丌丁丕一丐七.isMelee == true) || (this.丆业七丌丁丕一丐七.bazooka == true)) || (this.丆业七丌丁丕一丐七.seriesShoot == true))
        {
            goto label_37;
        }
        
        if(this.丆业七丌丁丕一丐七.isDoubleSyncShot == false)
        {
            goto label_18;
        }
        
        val_58 = 0;
        goto label_19;
        label_29:
        if(this.下丛丗丑不不与丒与[0] != 0)
        {
                this.下丛丗丑不不与丒与[0].StartGunFlash();
        }
        
        val_58 = 1;
        label_19:
        if(val_58 < this.下丛丗丑不不与丒与.Length)
        {
            goto label_29;
        }
        
        goto label_37;
        label_18:
        if((this.下丛丗丑不不与丒与[0] != 0) && (val_56 < this.下丛丗丑不不与丒与.Length))
        {
                this.下丛丗丑不不与丒与[0].StartGunFlash();
        }
        
        label_37:
        val_59 = this.丆业七丌丁丕一丐七;
        if(val_59 == null)
        {
            goto label_41;
        }
        
        if(this.丆业七丌丁丕一丐七.bazooka == false)
        {
            goto label_42;
        }
        
        label_46:
        val_60 = this.丆业七丌丁丕一丐七;
        val_61 = this.丆业七丌丁丕一丐七.bazookaDelay;
        if(val_60 == null)
        {
            goto label_43;
        }
        
        val_62 = this.丆业七丌丁丕一丐七.countInSeriaBazooka;
        val_63 = val_60;
        goto label_65;
        label_41:
        if(this.丆业七丌丁丕一丐七 == null)
        {
            goto label_154;
        }
        
        val_59 = this.丆业七丌丁丕一丐七;
        if(this.丆业七丌丁丕一丐七.bazooka == true)
        {
            goto label_46;
        }
        
        label_42:
        if(this.丆业七丌丁丕一丐七.railgun != true)
        {
                if(this.丆业七丌丁丕一丐七.freezer == false)
        {
            goto label_49;
        }
        
        }
        
        if(this.丆业七丌丁丕一丐七.isDoubleSyncShot == false)
        {
            goto label_51;
        }
        
        val_64 = 0;
        goto label_52;
        label_62:
        FlashFire val_57 = this.下丛丗丑不不与丒与[0];
        UnityEngine.Vector3 val_10 = this.下丛丗丑不不与丒与[0x0][0].gunFlashObj.transform.position;
        val_61 = val_10.x;
        UnityEngine.Quaternion val_12 = this.丆业七丌丁丕一丐七.transform.rotation;
        val_57 = val_61;
        this.与东丐丌丒丕丕丛东(专丝丌万东七丕丗丌:  this.丆业七丌丁丕一丐七.railName, 丟丘丆七三丐丂丏丏:  0, 下七丆丑万丙丂三下:  new UnityEngine.Vector3() {x = val_57, y = val_10.y, z = val_10.z}, 上丗东丒丁不丒丛丄:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w});
        val_64 = 1;
        label_52:
        val_62 = this.下丛丗丑不不与丒与;
        if(val_64 < this.下丛丗丑不不与丒与.Length)
        {
            goto label_62;
        }
        
        goto label_169;
        label_43:
        val_63 = this.丆业七丌丁丕一丐七;
        val_62 = this.丆业七丌丁丕一丐七.countInSeriaBazooka;
        if(val_63 == null)
        {
            goto label_64;
        }
        
        val_60 = val_63;
        goto label_65;
        label_51:
        val_62 = this.丆业七丌丁丕一丐七.railName;
        FlashFire val_58 = this.下丛丗丑不不与丒与[0];
        UnityEngine.Vector3 val_14 = this.下丛丗丑不不与丒与[0x0][0].gunFlashObj.transform.position;
        val_61 = val_14.x;
        UnityEngine.Quaternion val_16 = this.丆业七丌丁丕一丐七.transform.rotation;
        val_57 = val_61;
        this.与东丐丌丒丕丕丛东(专丝丌万东七丕丗丌:  val_62, 丟丘丆七三丐丂丏丏:  0, 下七丆丑万丙丂三下:  new UnityEngine.Vector3() {x = val_57, y = val_14.y, z = val_14.z}, 上丗东丒丁不丒丛丄:  new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w});
        goto label_169;
        label_64:
        val_60 = this.丆业七丌丁丕一丐七;
        if(val_60 == null)
        {
            goto label_154;
        }
        
        label_65:
        if(this.丆业七丌丁丕一丐七.fanRocketShoot != false)
        {
                if(this.丆业七丌丁丕一丐七 != null)
        {
            goto label_78;
        }
        
        }
        
        label_78:
        val_57 = val_61;
        this.丌丕丅丅丗丗丞专丌 = this.StartCoroutine(routine:  this.且丗丑丆下丑丘世丏(丂下丁上丌丕丒丙丄:  0, 丕丕世且下一与丝与:  val_57, 丈丗一世丈丁专与丟:  val_62, 一丐丞丝下丙三丟丄:  this.丆业七丌丁丕一丐七.stepTimeInSeriaBazooka, 丝丗业丘丏与上东丆:  this.三东丂三丒丌不丝丁, 业丒三且三万丐丟上:  0f));
        label_169:
        if(this.丆业七丌丁丕一丐七.一与上丙一丙丅丐业() == 0)
        {
                return;
        }
        
        MinigunController val_21 = this.丆业七丌丁丕一丐七.一与上丙一丙丅丐业();
        if(val_21.instantMinigun == false)
        {
                return;
        }
        
        val_61 = this.丆业七丌丁丕一丐七.丛丆丑丁下丆丘丏丝();
        if(this.丆业七丌丁丕一丐七.一与上丙一丙丅丐业().丐丅世世万丒东丕且() <= 0f)
        {
            goto label_90;
        }
        
        val_62 = this.丆业七丌丁丕一丐七.isDoubleShot;
        if(this.丐丞丑一丟丕世专丅 == null)
        {
            goto label_91;
        }
        
        if(val_62 == false)
        {
            goto label_92;
        }
        
        label_105:
        val_57 = this.丐丞丑一丟丕世专丅.Item["Shoot1"].length / val_61;
        this.丐丞丑一丟丕世专丅.Item["Shoot1"].speed = val_57;
        val_66 = this.丐丞丑一丟丕世专丅;
        val_67 = this.丐丞丑一丟丕世专丅.Item["Shoot2"];
        val_68 = "Shoot2";
        goto label_98;
        label_90:
        if(this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁() == null)
        {
            goto label_99;
        }
        
        val_61 = BalanceController.一丝丙丙不一丞丕丟(丟丈一下东业一丝丆:  this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁().业东丅东丌上丗丑不());
        goto label_104;
        label_91:
        if(val_62 == true)
        {
            goto label_105;
        }
        
        label_92:
        if((this.丐丞丑一丟丕世专丅.GetClip(name:  "Shoot")) == 0)
        {
            goto label_123;
        }
        
        val_66 = this.丐丞丑一丟丕世专丅;
        val_67 = this.丐丞丑一丟丕世专丅.Item["Shoot"];
        val_68 = "Shoot";
        label_98:
        val_62 = val_66.Item[val_68];
        float val_37 = val_62.length;
        val_37 = val_37 / val_61;
        goto label_113;
        label_99:
        val_61 = this.shotStubSpeed;
        this.丐世专丙丟下丟丅七 = 100;
        label_104:
        val_62 = this.丆业七丌丁丕一丐七.isDoubleShot;
        if(this.丐丞丑一丟丕世专丅 == null)
        {
            goto label_115;
        }
        
        if(val_62 == false)
        {
            goto label_116;
        }
        
        label_120:
        this.丐丞丑一丟丕世专丅.Item["Shoot1"].speed = val_61;
        val_69 = this.丐丞丑一丟丕世专丅;
        val_70 = "Shoot2";
        goto label_119;
        label_115:
        if(val_62 == true)
        {
            goto label_120;
        }
        
        label_116:
        if((this.丐丞丑一丟丕世专丅.GetClip(name:  "Shoot")) == 0)
        {
            goto label_123;
        }
        
        val_69 = this.丐丞丑一丟丕世专丅;
        val_70 = "Shoot";
        label_119:
        label_113:
        val_69.Item[val_70].speed = val_61;
        label_123:
        val_54 = this.丆业七丌丁丕一丐七.一与上丙一丙丅丐业();
        if(val_54 != null)
        {
                val_71 = val_42.currentInstantShoot;
        }
        else
        {
                val_54 = 184;
            val_71 = 130653168;
        }
        
        mem[184] = 130653169;
        return;
        label_49:
        string val_43 = this.丆业七丌丁丕一丐七.三与丛丑且丐丈业丌();
        if(((val_43.丘丏丞丅丐丛丑且丐(丒丘丏上丙丟丑丕丈:  val_43)) == 0) || (this.丆业七丌丁丕一丐七.isSectorsAOE == false))
        {
            goto label_134;
        }
        
        this.丒丛丂丐丈丟丞上丐(丕丕世且下一与丝与:  this.丈三丁丝丐三丗一丅(), 丁下不下业世下丛丐:  this.丆业七丌丁丕一丐七.三与丛丑且丐丈业丌());
        goto label_169;
        label_134:
        val_72 = this.丆业七丌丁丕一丐七;
        if(val_72 == null)
        {
            goto label_137;
        }
        
        if(this.丆业七丌丁丕一丐七.isMelee == true)
        {
            goto label_141;
        }
        
        goto label_139;
        label_137:
        if(this.丆业七丌丁丕一丐七 == null)
        {
            goto label_140;
        }
        
        val_72 = this.丆业七丌丁丕一丐七;
        if(this.丆业七丌丁丕一丐七.isMelee == true)
        {
            goto label_141;
        }
        
        label_139:
        if((((this.丆业七丌丁丕一丐七.flamethrower == true) || (this.丆业七丌丁丕一丐七.isChargeOrbital == true)) || (this.丆业七丌丁丕一丐七.snowStorm == true)) || (this.丆业七丌丁丕一丐七.shocker == true))
        {
            goto label_169;
        }
        
        if((this.丆业七丌丁丕一丐七.seriesShoot == false) || (this.丆业七丌丁丕一丐七.countInSeriaBazooka < 1))
        {
            goto label_152;
        }
        
        val_73 = this.丆业七丌丁丕一丐七;
        if(this.丆业七丌丁丕一丐七 != null)
        {
            goto label_153;
        }
        
        val_73 = this.丆业七丌丁丕一丐七;
        if(val_73 == null)
        {
            goto label_154;
        }
        
        label_153:
        this.丂丑业丄世丄丂丐一 = this.StartCoroutine(routine:  this.与下丛丝丐下世丕丐(丂下丁上丌丕丒丙丄:  0, 丈丗一世丈丁专与丟:  this.丆业七丌丁丕一丐七.countInSeriaBazooka, 一丐丞丝下丙三丟丄:  this.丆业七丌丁丕一丐七.stepTimeInSeriaBazooka));
        goto label_169;
        label_140:
        val_72 = 0;
        label_141:
        if(val_72._innerPars == 0)
        {
            goto label_169;
        }
        
        InnerWeaponPars val_52 = this.丆业七丌丁丕一丐七._innerPars;
        if(val_52.trailShowEffectInShop == false)
        {
            goto label_169;
        }
        
        Player_move_c.丙丕业丝七与世三丑(丄丏丅与丙丆丞丒丏:  this.丆业七丌丁丕一丐七, 世丅上丅丆丕下丒万:  0, 丄上丐不专丁丄丏丐:  this);
        goto label_169;
        label_152:
        if(this.丆业七丌丁丕一丐七.isDoubleSyncShot == false)
        {
            goto label_169;
        }
        
        var val_59 = 0;
        do
        {
            val_59 = val_59 + 1;
        }
        while(val_59 < this.下丛丗丑不不与丒与.Length);
        
        goto label_169;
        label_154:
    }
    private UnityEngine.GameObject 丘丏丞丅丐丛丑且丐(string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.GameObject val_2 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "OnGroundWeaponEffects/"("OnGroundWeaponEffects/") + 丒丘丏上丙丟丑丕丈 + "_OnGroundEffect");
        return (UnityEngine.GameObject)(val_2 != 0) ? 0 : (val_2);
    }
    private void 丘东丛丙且不万世专()
    {
        UnityEngine.GameObject val_3;
        var val_4;
        val_3 = this;
        this.业丆丂万丒丂万七丒(丙业与丙丗丝不丈东:  false);
        this.丝丐丆丐不丝丅专一();
        this.丌且七一丘且丏丈世 = 0;
        if(this.丌丕丅丅丗丗丞专丌 != null)
        {
                this.StopCoroutine(routine:  this.丌丕丅丅丗丗丞专丌);
        }
        
        if(this.丂丑业丄世丄丂丐一 != null)
        {
                this.StopCoroutine(routine:  this.丂丑业丄世丄丂丐一);
        }
        
        val_4 = 0;
        goto label_3;
        label_13:
        val_3 = 0;
        if(this.且丈丌丗丝丆上丏丝[val_3] != null)
        {
                val_3 = this.且丈丌丗丝丆上丏丝[0x0][0].下丐三丆丝与不丗丕;
            if(val_3 != 0)
        {
                val_3 = this.且丈丌丗丝丆上丏丝[0x0][0].下丐三丆丝与不丗丕;
            if(val_3.activeSelf != false)
        {
                val_3 = this.且丈丌丗丝丆上丏丝[0x0][0].下丐三丆丝与不丗丕;
            val_3.SetActive(value:  false);
        }
        
        }
        
        }
        
        val_4 = 1;
        label_3:
        if(val_4 < this.且丈丌丗丝丆上丏丝.Length)
        {
            goto label_13;
        }
    
    }
    private void Start()
    {
        this.丁上丏世丛丙丗世丑 = UnityEngine.LayerMask.NameToLayer(layerName:  this.Layer);
        this.丞下上且一上丙不丏 = this.GetComponent<UnityEngine.AudioSource>();
    }
    private void OnDisable()
    {
        this.丘东丛丙且不万世专();
    }
    private void Update()
    {
        UnityEngine.GameObject val_48;
        var val_49;
        System.Func<UnityEngine.GameObject> val_51;
        var val_52;
        bool val_53;
        上丒业世丝业万业丒 val_54;
        上丒业世丝业万业丒 val_55;
        UnityEngine.Object val_56;
        float val_57;
        float val_59;
        上丒业世丝业万业丒 val_60;
        var val_61;
        var val_62;
        int val_63;
        var val_64;
        int val_65;
        上丒业世丝业万业丒 val_66;
        上丒业世丝业万业丒 val_67;
        上丒业世丝业万业丒 val_68;
        var val_69;
        val_48 = this;
        if(this.CurrentWeaponObjectGetter == null)
        {
                val_49 = null;
            val_49 = null;
            val_51 = ShopShootingController.<>c.<>9__70_0;
            if(val_51 == null)
        {
                System.Func<UnityEngine.GameObject> val_1 = null;
            val_51 = val_1;
            val_1 = new System.Func<UnityEngine.GameObject>(object:  ShopShootingController.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject ShopShootingController.<>c::丌与专丞三丂丂丒丗());
            ShopShootingController.<>c.<>9__70_0 = val_51;
        }
        
            this.CurrentWeaponObjectGetter = val_51;
        }
        
        this.且东丌且业世丟不丒();
        if(this.CurrentWeaponObjectGetter.Invoke() == 0)
        {
                this.业丆丂万丒丂万七丒(丙业与丙丗丝不丈东:  false);
            return;
        }
        
        this.丟一世丂丙东丅丕丒();
        if(this.shootButton != 0)
        {
                val_53 = this.shootButton.<丈且丞丟丏七丈丑丝>k__BackingField;
        }
        else
        {
                val_53 = 0;
        }
        
        val_54 = this.东不丞业丅东丅下丆;
        var val_5 = (val_54 == 0) ? 1 : 0;
        val_5 = val_53 & val_5;
        if(val_5 != 0)
        {
                this.万下丅专丐丝丝七与();
            this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  1);
            val_54 = this.东不丞业丅东丅下丆;
        }
        
        if(val_54 != 4)
        {
                if(val_54 != 2)
        {
            goto label_23;
        }
        
        }
        
        if((val_53 == 0) && (this.丗不东一丅与丙专业() != true))
        {
                if(this.丆业七丌丁丕一丐七.isCharging != false)
        {
                this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  3);
            this.业丆丂万丒丂万七丒(丙业与丙丗丝不丈东:  false);
        }
        else
        {
                this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  8);
        }
        
        }
        
        label_23:
        val_55 = this.东不丞业丅东丅下丆;
        if(val_55 == 2)
        {
                val_56 = this.丆业七丌丁丕一丐七.且且东专三丛专上东();
            if(this.丞下上且一上丙不丏.clip == val_56)
        {
                if(this.丞下上且一上丙不丏.isPlaying != false)
        {
                if(this.丞下上且一上丙不丏.loop == true)
        {
                return;
        }
        
        }
        
        }
        
            if(this.丞下上且一上丙不丏 != 0)
        {
                this.丞下上且一上丙不丏.Stop();
        }
        
            val_57 = 1f;
            this.万丙丘丗丆业丐万世(丆与丈丏丟七丁东丛:  this.丆业七丌丁丕一丐七.且且东专三丛专上东(), 丛丝丗不丞丛丕七丏:  true, 与丁万东丌丑下丏丕:  val_57);
            val_59 = (UnityEngine.Time.realtimeSinceStartup - this.丌丞丂丑业丝下丄业) / this.丆业七丌丁丕一丐七.chargeTime;
            this.三东丂三丒丌不丝丁 = val_59;
            if(val_59 >= val_57)
        {
                if(this.丆业七丌丁丕一丐七.invisWhenCharged != false)
        {
                this.业丆丂万丒丂万七丒(丙业与丙丗丝不丈东:  true);
        }
        
            this.三东丂三丒丌不丝丁 = 1f;
            if(this.丆业七丌丁丕一丐七.chargeLoop != true)
        {
                val_59 = 0f;
            this.丐丞丑一丟丕世专丅.Item["Charge"].speed = val_59;
        }
        
        }
        
            if(this.丆业七丌丁丕一丐七.chargeLoop != false)
        {
                val_52 = "Charge";
            if((this.丐丞丑一丟丕世专丅.IsPlaying(name:  "Charge")) != true)
        {
                bool val_18 = this.丐丞丑一丟丕世专丅.Play(animation:  "Charge");
        }
        
        }
        
            val_55 = this.东不丞业丅东丅下丆;
        }
        
        val_55 = val_55 - 3;
        if(val_55 > 3)
        {
            goto label_126;
        }
        
        if(this.丆业七丌丁丕一丐七.一与上丙一丙丅丐业() != 0)
        {
                this.丆业七丌丁丕一丐七.一与上丙一丙丅丐业().丐丁不丅丁丝丑业丏();
        }
        
        if(this.丗不东一丅与丙专业() == true)
        {
            goto label_126;
        }
        
        if(this.丆业七丌丁丕一丐七.isBurstShooting == false)
        {
            goto label_62;
        }
        
        val_59 = this.丌东东丙丐三丌丏东;
        if(val_59 == 0f)
        {
            goto label_62;
        }
        
        val_57 = UnityEngine.Time.realtimeSinceStartup;
        val_59 = this.丆业七丌丁丕一丐七.delayInBurstShooting;
        if((val_57 - this.丌东东丙丐三丌丏东) <= val_59)
        {
            goto label_126;
        }
        
        label_62:
        val_60 = this.东不丞业丅东丅下丆;
        if(val_60 == 3)
        {
            goto label_65;
        }
        
        if(val_60 != 5)
        {
            goto label_66;
        }
        
        if((this.丆业七丌丁丕一丐七.AmmoInClip >= 1) && (this.丆业七丌丁丕一丐七.isShotMelee != true))
        {
                if(this.丆业七丌丁丕一丐七.isMelee == false)
        {
            goto label_159;
        }
        
        }
        
        label_159:
        this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  8);
        return;
        label_65:
        this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  4);
        if(this.丞下上且一上丙不丏 != 0)
        {
                this.丞下上且一上丙不丏.Stop();
        }
        
        if(this.丆业七丌丁丕一丐七.isLoopShoot != false)
        {
                val_59 = 1f;
            this.万丙丘丗丆业丐万世(丆与丈丏丟七丁东丛:  this.丆业七丌丁丕一丐七.丁与东东丂三丈丙世(), 丛丝丗不丞丛丕七丏:  true, 与丁万东丌丑下丏丕:  val_59);
        }
        
        val_60 = this.东不丞业丅东丅下丆;
        label_66:
        if(val_60 != 6)
        {
            goto label_80;
        }
        
        val_61 = 7;
        goto label_81;
        label_80:
        if(this.丆业七丌丁丕一丐七.一与上丙一丙丅丐业() != 0)
        {
                if(this.丆业七丌丁丕一丐七.一与上丙一丙丅丐业().丐与七丄七丈丞丁业() == false)
        {
            goto label_88;
        }
        
        }
        
        this.丂丝东丞丝万三丘与();
        val_62 = 1;
        goto label_89;
        label_88:
        val_62 = 0;
        label_89:
        if(this.丌世下丝东丈专丛丄 >= 1)
        {
                int val_32 = this.丌世下丝东丈专丛丄 + 1;
            this.丌世下丝东丈专丛丄 = val_32;
            if(val_32 > (UnityEngine.Mathf.Max(a:  2, b:  this.下丛丗丑不不与丒与.Length)))
        {
                this.丌世下丝东丈专丛丄 = 1;
        }
        
        }
        
        if(this.丆业七丌丁丕一丐七.isBurstShooting != false)
        {
                if(this.不丙且专七丟丅下丕 < this.丆业七丌丁丕一丐七.countShootInBurst)
        {
                val_63 = this.不丙且专七丟丅下丕;
        }
        else
        {
                val_63 = 0;
            this.不丙且专七丟丅下丕 = 0;
            this.丌东东丙丐三丌丏东 = 0f;
        }
        
            int val_34 = val_63 + 1;
            this.不丙且专七丟丅下丕 = val_34;
            if(val_34 >= this.丆业七丌丁丕一丐七.countShootInBurst)
        {
                this.丌东东丙丐三丌丏东 = UnityEngine.Time.realtimeSinceStartup;
        }
        
        }
        
        if(this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁() == null)
        {
            goto label_124;
        }
        
        if(this.丆业七丌丁丕一丐七.AmmoInClip >= 1)
        {
                if(this.丆业七丌丁丕一丐七.isShotMelee == false)
        {
            goto label_107;
        }
        
        }
        
        val_64 = 0;
        goto label_108;
        label_107:
        bool val_49 = this.丆业七丌丁丕一丐七.isMelee;
        val_49 = val_49 ^ 1;
        val_64 = val_49 & 255;
        label_108:
        val_64 = val_64 & val_62;
        if(val_64 == false)
        {
            goto label_124;
        }
        
        if(this.丆业七丌丁丕一丐七.isCharging != false)
        {
                val_57 = this.三东丂三丒丌不丝丁;
            val_59 = val_57 * (float)this.丆业七丌丁丕一丐七.chargeMax;
            val_65 = (int)val_59;
        }
        else
        {
                val_65 = 1;
        }
        
        val_65 = this.丐世专丙丟下丟丅七 - val_65;
        this.丐世专丙丟下丟丅七 = val_65;
        if(this.丆业七丌丁丕一丐七.丕丗丒不一且丛业丟() == false)
        {
            goto label_116;
        }
        
        if(this.丐世专丙丟下丟丅七 <= 1)
        {
            goto label_117;
        }
        
        goto label_124;
        label_116:
        val_57 = (float)this.丐世专丙丟下丟丅七;
        val_59 = 0f;
        if(this.丈丙七丄三一三丕丑 <= 1)
        {
                float val_50 = (float)this.丆业七丌丁丕一丐七.AmmoInClip;
            val_50 = val_50 / 3f;
            val_59 = (float)this.丆业七丌丁丕一丐七.AmmoInClip - val_50;
        }
        
        if(val_59 < val_57)
        {
            goto label_124;
        }
        
        label_117:
        this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  6);
        label_124:
        if(this.丆业七丌丁丕一丐七.isCharging == false)
        {
            goto label_126;
        }
        
        val_61 = 5;
        label_81:
        this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  5);
        label_126:
        val_66 = this.东不丞业丅东丅下丆;
        if(val_66 != 1)
        {
            goto label_127;
        }
        
        val_59 = this.丑业东且丏丌与专丝;
        if(val_59 <= this.startIdleCrossFadeTimeout)
        {
            goto label_128;
        }
        
        if(this.丐世专丙丟下丟丅七 <= 0)
        {
            goto label_129;
        }
        
        label_142:
        label_143:
        this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  (this.丆业七丌丁丕一丐七.isCharging == false) ? (2 + 1) : 2);
        label_128:
        val_66 = this.东不丞业丅东丅下丆;
        label_127:
        if((val_66 != 7) || ((this.丐丞丑一丟丕世专丅.IsPlaying(name:  "Reload")) == true))
        {
            goto label_133;
        }
        
        int val_51 = this.丈丙七丄三一三丕丑;
        this.丐世专丙丟下丟丅七 = this.丆业七丌丁丕一丐七.AmmoInClip;
        val_51 = val_51 + 1;
        this.丈丙七丄三一三丕丑 = val_51;
        if(val_53 == 0)
        {
            goto label_135;
        }
        
        val_67 = 3;
        goto label_136;
        label_129:
        if(((this.丆业七丌丁丕一丐七.AmmoInClip == 0) || (this.丆业七丌丁丕一丐七.isMelee == true)) || (this.丆业七丌丁丕一丐七.isShotMelee == true))
        {
            goto label_142;
        }
        
        goto label_143;
        label_135:
        val_67 = 8;
        label_136:
        this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  val_67);
        label_133:
        val_68 = this.东不丞业丅东丅下丆;
        if(val_68 == 8)
        {
                this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  0);
            val_68 = this.东不丞业丅东丅下丆;
        }
        
        if(val_68 != 8)
        {
                if(val_68 != 1)
        {
            goto label_146;
        }
        
        }
        
        val_57 = this.丑业东且丏丌与专丝;
        float val_45 = UnityEngine.Time.deltaTime;
        val_45 = val_57 + val_45;
        this.丑业东且丏丌与专丝 = val_45;
        label_146:
        val_69 = 0;
        goto label_147;
        label_158:
        val_48 = 0;
        val_53 = this.且丈丌丗丝丆上丏丝[val_48];
        if(val_53 != null)
        {
                val_48 = this.且丈丌丗丝丆上丏丝[0x0][0].下丐三丆丝与不丗丕;
            if(val_48 != 0)
        {
                val_48 = this.且丈丌丗丝丆上丏丝[0x0][0].下丐三丆丝与不丗丕;
            if(val_48.activeSelf != false)
        {
                float val_48 = UnityEngine.Time.realtimeSinceStartup;
            val_48 = val_48 - this.且丈丌丗丝丆上丏丝[0x0][0].丐三丒丌七与万丂下;
            if(val_48 > this.且丈丌丗丝丆上丏丝[0x0][0].与与专丟丗东丌与丆)
        {
                val_48 = this.且丈丌丗丝丆上丏丝[0x0][0].下丐三丆丝与不丗丕;
            val_48.SetActive(value:  false);
        }
        
        }
        
        }
        
        }
        
        val_69 = 1;
        label_147:
        if(val_69 < this.且丈丌丗丝丆上丏丝.Length)
        {
            goto label_158;
        }
    
    }
    private void 丟一世丂丙东丅丕丒()
    {
        var val_6;
        WeaponSounds val_2 = this.CurrentWeaponObjectGetter.Invoke().GetComponent<WeaponSounds>();
        if(val_2 == 0)
        {
                this.丘东丛丙且不万世专();
            return;
        }
        
        if(val_2 == this.丆业七丌丁丕一丐七)
        {
                return;
        }
        
        this.丆业七丌丁丕一丐七 = val_2;
        this.丘东丛丙且不万世专();
        this.丄丅丙丏丂丘三丈世(丏业丟一东丂东丘丛:  0);
        val_6 = null;
        val_6 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丌上丏丁下丞丐丏万().三三丝丑丕丏丘业丒();
    }
    private void 且东丌且业世丟不丒()
    {
        var val_10;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_10 = UnityEngine.Object.op_Inequality(x:  this.丆业七丌丁丕一丐七, y:  0);
        }
        else
        {
                val_10 = 0;
        }
        
        if(this.丞下上且一上丙不丏.loop == false)
        {
                return;
        }
        
        if(this.丞下上且一上丙不丏.clip == 0)
        {
                return;
        }
        
        if((val_10 == 0) && (this.丞下上且一上丙不丏.isPlaying != false))
        {
                this.丞下上且一上丙不丏.Stop();
        }
        
        if((val_10 & (~this.丞下上且一上丙不丏.isPlaying)) == false)
        {
                return;
        }
        
        this.丞下上且一上丙不丏.Play();
    }
    private void LateUpdate()
    {
        var val_6 = 1152921504848912384;
        if(this.丆业七丌丁丕一丐七 == 0)
        {
                return;
        }
        
        if(this.丌且七一丘且丏丈世 == null)
        {
                return;
        }
        
        if(this.丆业七丌丁丕一丐七._innerPars == 0)
        {
                return;
        }
        
        InnerWeaponPars val_4 = this.丆业七丌丁丕一丐七._innerPars;
        if(val_4.bonesRoot == null)
        {
                return;
        }
        
        val_6 = 0;
        goto label_12;
        label_21:
        InnerWeaponPars val_5 = this.丆业七丌丁丕一丐七._innerPars;
        var val_6 = this.丌且七一丘且丏丈世 + (0 * 12);
        val_5.bonesRoot[0].localScale = new UnityEngine.Vector3() {x = (0 * 12) + this.丌且七一丘且丏丈世 + 32, y = (0 * 12) + this.丌且七一丘且丏丈世 + 32 + 4, z = (0 * 12) + this.丌且七一丘且丏丈世 + 40};
        val_6 = 1;
        label_12:
        if(val_6 < this.丌且七一丘且丏丈世.Length)
        {
            goto label_21;
        }
    
    }
    private void 万丙丘丗丆业丐万世(UnityEngine.AudioClip 丆与丈丏丟七丁东丛, bool 丛丝丗不丞丛丕七丏 = False, float 与丁万东丌丑下丏丕 = 1)
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this.丞下上且一上丙不丏 == 0)
        {
                return;
        }
        
        this.丞下上且一上丙不丏.clip = 丆与丈丏丟七丁东丛;
        this.丞下上且一上丙不丏.loop = 丛丝丗不丞丛丕七丏;
        if(this.丞下上且一上丙不丏 == null)
        {
            goto label_9;
        }
        
        if(丛丝丗不丞丛丕七丏 == false)
        {
            goto label_10;
        }
        
        label_11:
        this.丞下上且一上丙不丏.Play();
        return;
        label_9:
        if(丛丝丗不丞丛丕七丏 == true)
        {
            goto label_11;
        }
        
        label_10:
        this.丞下上且一上丙不丏.PlayOneShot(clip:  丆与丈丏丟七丁东丛, volumeScale:  与丁万东丌丑下丏丕);
    }
    public ShopShootingController()
    {
        this.shotStubSpeed = 1f;
        this.三东丂三丒丌不丝丁 = 1f;
        this.endIdleCrossFadeTimeout = 0.3f;
        this.Layer = "NGUIShopWorld";
        this.PlayIdleSound = true;
        this.丗丗丁丘与丄丆丁世 = "";
        this.且丈丌丗丝丆上丏丝 = new 丛与丁丆业世丛丁下[4];
        this.rocketLifeTime = 3f;
        this.startIdleCrossFadeTimeout = 0.05f;
    }

}
