using UnityEngine;
internal class SniperScopeMovement : MonoBehaviour
{
    // Fields
    internal UnityEngine.Vector2 东且丁丆丛丁丏丘且;
    private UnityEngine.Vector2 世与丗丏丟丂丕三万;
    private UnityEngine.Vector2 丛丘丒且丝万万三东;
    private UnityEngine.Vector2 丝丙丑丐业丐丕丆丟;
    private UnityEngine.Vector2 丕丘丑丙与丆丘丞丁;
    private UnityEngine.Vector2 丗丁丌丆东东业丆丘;
    private UnityEngine.Vector2 丄丙丒丛丒丞丗专丑;
    private bool 丏丒丆丝万与丁丁丟;
    private float 且丘丌不丟丆万与上;
    private SniperScopeMovement.TargetPoint 丙世丙七丅丆三丝三;
    private bool 丘且世下且丏丟丗丐;
    private float 丒一丒丏丄世万丏丝;
    private float 专丒业不丂丘三世丏;
    
    // Properties
    private float 丟丏丕丘丐上万丐丄 { get; }
    private float 丗业业丒丒丕丛丒丗 { get; }
    private float 丒丕与丝丛业不丒丏 { get; }
    private float 七不丝与业丈丟丛东 { get; }
    private float 丞一丁丑丟丁丑丘丏 { get; }
    private float 丛丐丒万丞世丞丗不 { get; }
    private float 丗不丌丁上丝下且丗 { get; }
    private float 七丅业不三与丟丌丆 { get; }
    private WeaponSounds 与丏丂一丅七丟万丑 { get; }
    
    // Methods
    private float 东丘万丞丏东丞业世()
    {
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.丁下世丑丟七丗万丒(), y:  0);
        if(val_2 == false)
        {
                return 1f;
        }
        
        WeaponSounds val_3 = val_2.丁下世丑丟七丗万丒();
        bool val_4 = val_3.三世丗丆丕万丐且三.ContainsKey(key:  19);
        if(val_4 == false)
        {
                return 1f;
        }
        
        WeaponSounds val_5 = val_4.丁下世丑丟七丗万丒();
        if(val_5.三世丗丆丕万丐且三 != null)
        {
                return val_5.三世丗丆丕万丐且三.Item[19];
        }
        
        return val_5.三世丗丆丕万丐且三.Item[19];
    }
    private float 丝丑七丐丌丑丘上丑()
    {
        float val_6;
        var val_7;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.丁下世丑丟七丗万丒(), y:  0);
        if((val_2 != false) && (val_3.considerScopeValues != false))
        {
                WeaponSounds val_4 = val_2.丁下世丑丟七丗万丒().丁下世丑丟七丗万丒();
            val_6 = val_4.scopeCircleRadius;
        }
        else
        {
                val_7 = null;
            val_7 = null;
            PlayerCoreSettingsStorager.recoildAndScopeSettings.丕与下丒万丛丛丕丒
        }
        
        float val_5 = this.东丘万丞丏东丞业世();
        val_5 = PlayerCoreSettingsStorager.recoildAndScopeSettings.丕与下丒万丛丛丕丒 * val_5;
        return (float)val_5;
    }
    private float 丏丙业丘丈丁丅丐丞()
    {
        float val_6;
        var val_7;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.丁下世丑丟七丗万丒(), y:  0);
        if((val_2 != false) && (val_3.considerScopeValues != false))
        {
                WeaponSounds val_4 = val_2.丁下世丑丟七丗万丒().丁下世丑丟七丗万丒();
            val_6 = val_4.scopePointsSpeed;
        }
        else
        {
                val_7 = null;
            val_7 = null;
            PlayerCoreSettingsStorager.recoildAndScopeSettings.丙七专丏专丈与丝丞
        }
        
        float val_5 = this.东丘万丞丏东丞业世();
        val_5 = PlayerCoreSettingsStorager.recoildAndScopeSettings.丙七专丏专丈与丝丞 * val_5;
        return (float)val_5;
    }
    private float 不丄丒丕上不东丏丑()
    {
        float val_6;
        var val_7;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.丁下世丑丟七丗万丒(), y:  0);
        if((val_2 != false) && (val_3.considerScopeValues != false))
        {
                WeaponSounds val_4 = val_2.丁下世丑丟七丗万丒().丁下世丑丟七丗万丒();
            val_6 = val_4.scopeMovementSpeed;
        }
        else
        {
                val_7 = null;
            val_7 = null;
            PlayerCoreSettingsStorager.recoildAndScopeSettings.丘丅丐一丙丅上丁七
        }
        
        float val_5 = this.东丘万丞丏东丞业世();
        val_5 = PlayerCoreSettingsStorager.recoildAndScopeSettings.丘丅丐一丙丅上丁七 * val_5;
        return (float)val_5;
    }
    private float 丆东丏丟丆丈业丟丒()
    {
        float val_5;
        var val_6;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.丁下世丑丟七丗万丒(), y:  0);
        if(val_2 != false)
        {
                if(val_3.considerScopeValues != false)
        {
                WeaponSounds val_4 = val_2.丁下世丑丟七丗万丒().丁下世丑丟七丗万丒();
            val_5 = val_4.scopeTrashHoldForDistanceToPoint;
            return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.丏万七万丛三丕七丌;
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.丏万七万丛三丕七丌
        return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.丏万七万丛三丕七丌;
    }
    private float 三丞一丞丄专不丏且()
    {
        float val_5;
        var val_6;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.丁下世丑丟七丗万丒(), y:  0);
        if(val_2 != false)
        {
                if(val_3.considerScopeValues != false)
        {
                WeaponSounds val_4 = val_2.丁下世丑丟七丗万丒().丁下世丑丟七丗万丒();
            val_5 = val_4.scopeStartValueSpeedIncreace;
            return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.七下专丐丝一丒一三;
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.七下专丐丝一丒一三
        return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.七下专丐丝一丒一三;
    }
    private float 专丆丐丆丝丟丙丐与()
    {
        float val_5;
        var val_6;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.丁下世丑丟七丗万丒(), y:  0);
        if(val_2 != false)
        {
                if(val_3.considerScopeValues != false)
        {
                WeaponSounds val_4 = val_2.丁下世丑丟七丗万丒().丁下世丑丟七丗万丒();
            val_5 = val_4.scopeStartValueSpeedIncreace;
            return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.三丏丘丆三丗丁丁丒;
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.三丏丘丆三丗丁丁丒
        return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.三丏丘丆三丗丁丁丒;
    }
    private float 七三丆丒丑专世专且()
    {
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丏丙业丘丈丁丅丐丞() * val_2;
        val_2 = this.专丒业不丂丘三世丏 + val_2;
        float val_3 = (val_2 > 360f) ? 0f : (val_2);
        this.专丒业不丂丘三世丏 = val_3;
        return val_3;
    }
    private WeaponSounds 丁下世丑丟七丗万丒()
    {
        var val_3;
        WeaponManager val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_4 == 0)
        {
                return 0;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return 0;
        }
        
        val_6 = null;
        val_6 = null;
        if(null != 0)
        {
                return 丙不丅丕三丂业东丕();
        }
        
        return 丙不丅丕三丂业东丕();
    }
    internal void Awake()
    {
        this.Reset();
    }
    internal void OnEnable()
    {
        this.Reset();
    }
    internal void Reset()
    {
        var val_5;
        this.专丒业不丂丘三世丏 = UnityEngine.Random.Range(min:  0f, max:  340f);
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.东且丁丆丛丁丏丘且 = val_2;
        mem[1152921539177754908] = val_2.y;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.世与丗丏丟丂丕三万 = val_3;
        mem[1152921539177754916] = val_3.y;
        this.丙世丙七丅丆三丝三 = 1;
        this.且丘丌不丟丆万与上 = this.三丞一丞丄专不丏且();
        val_5 = null;
        val_5 = null;
        this.丘且世下且丏丟丗丐 = false;
        this.丒一丒丏丄世万丏丝 = PlayerCoreSettingsStorager.recoildAndScopeSettings.丟丂丝丑丝丅不一一;
    }
    private void Update()
    {
        float val_50;
        float val_51;
        UnityEngine.Vector2 val_53;
        float val_54;
        if(this.丏丒丆丝万与丁丁丟 == true)
        {
                return;
        }
        
        this.世与丗丏丟丂丕三万 = this.东且丁丆丛丁丏丘且;
        mem[1152921539177871012] = ???;
        float val_50 = this.丏丙业丘丈丁丅丐丞();
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_50 * val_2;
        val_2 = this.专丒业不丂丘三世丏 + val_2;
        float val_51 = 0f;
        float val_3 = (val_2 > 360f) ? (val_51) : (val_2);
        val_2 = val_3 * 3.141593f;
        this.专丒业不丂丘三世丏 = val_3;
        val_50 = val_2 / 180f;
        float val_4 = this.丝丑七丐丌丑丘上丑();
        float val_6 = this.丝丑七丐丌丑丘上丑();
        val_51 = val_6 * val_50;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_4 * val_50, y:  val_51);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.丄丙丒丛丒丞丗专丑, y = val_4}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        float val_54 = -360f;
        this.丛丘丒且丝万万三东 = val_8;
        mem[1152921539177871020] = val_8.y;
        float val_9 = val_3 + 90f;
        val_9 = (val_9 > 360f) ? (val_9 + val_54) : (val_9);
        val_9 = val_9 * 3.141593f;
        float val_11 = val_9 / 180f;
        float val_52 = this.丝丑七丐丌丑丘上丑();
        val_52 = (val_52 * 0.5f) * val_11;
        float val_15 = this.丝丑七丐丌丑丘上丑() * 0.5f;
        val_15 = val_15 * val_11;
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_52, y:  val_15);
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.丄丙丒丛丒丞丗专丑, y = val_6}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        this.丕丘丑丙与丆丘丞丁 = val_17;
        mem[1152921539177871036] = val_17.y;
        float val_53 = val_3;
        val_53 = val_53 + 180f;
        float val_18 = val_53 + val_54;
        val_54 = (val_53 > 360f) ? (val_18) : (val_53);
        val_53 = val_54 * 3.141593f;
        float val_19 = val_53 / 180f;
        float val_55 = this.丝丑七丐丌丑丘上丑();
        val_55 = val_55 * val_19;
        val_18 = this.丝丑七丐丌丑丘上丑() * val_19;
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_55, y:  val_18);
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.丄丙丒丛丒丞丗专丑, y = val_6}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        this.丝丙丑丐业丐丕丆丟 = val_23;
        mem[1152921539177871028] = val_23.y;
        float val_56 = 90f;
        float val_57 = val_54;
        val_56 = val_54 + val_56;
        val_57 = val_56 + val_57;
        val_56 = (val_56 > 360f) ? (val_57) : (val_56);
        val_56 = val_56 * 3.141593f;
        float val_24 = val_56 / 180f;
        float val_58 = this.丝丑七丐丌丑丘上丑();
        val_50 = 0.5f;
        val_58 = (val_58 * val_50) * val_24;
        float val_28 = this.丝丑七丐丌丑丘上丑() * val_50;
        val_28 = val_28 * val_24;
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_58, y:  val_28);
        val_51 = val_29.x;
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.丄丙丒丛丒丞丗专丑, y = val_6}, b:  new UnityEngine.Vector2() {x = val_51, y = val_29.y});
        this.丗丁丌丆东东业丆丘 = val_30;
        mem[1152921539177871044] = val_30.y;
        UnityEngine.Vector2 val_33 = UnityEngine.Vector2.zero;
        TargetPoint val_59 = this.丙世丙七丅丆三丝三;
        val_53 = val_33.x;
        val_54 = val_33.y;
        val_59 = val_59 - 1;
        if(val_59 <= 3)
        {
                var val_60 = 106033908 + ((this.丙世丙七丅丆三丝三 - 1)) << 2;
            val_60 = val_60 + 106033908;
        }
        else
        {
                UnityEngine.Vector3 val_44 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.东且丁丆丛丁丏丘且});
            UnityEngine.Vector3 val_45 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {y = val_54});
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.SlerpUnclamped(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, t:  (this.不丄丒丕上不东丏丑() * this.丁丅三下丅丕丒丗丌()) * UnityEngine.Time.deltaTime);
            UnityEngine.Vector2 val_49 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z});
            this.东且丁丆丛丁丏丘且 = val_49;
            mem[1152921539177871004] = val_49.y;
        }
    
    }
    private float 丁丅三下丅丕丒丗丌()
    {
        var val_4;
        var val_5;
        if(this.丝丟丝丑丗且下丞与() != true)
        {
                if(this.丘且世下且丏丟丗丐 == false)
        {
            goto label_2;
        }
        
        }
        
        this.丘且世下且丏丟丗丐 = true;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丒一丒丏丄世万丏丝 - val_2;
        this.丒一丒丏丄世万丏丝 = val_2;
        if(val_2 <= 0f)
        {
                this.Reset();
        }
        
        val_4 = null;
        val_4 = null;
        return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.东不七与丒不丁世丛;
        label_2:
        val_5 = null;
        val_5 = null;
        this.丒一丒丏丄世万丏丝 = PlayerCoreSettingsStorager.recoildAndScopeSettings.丟丂丝丑丝丅不一一;
        float val_3 = this.专丆丐丆丝丟丙丐与();
        val_3 = this.且丘丌不丟丆万与上 + val_3;
        this.且丘丌不丟丆万与上 = val_3;
        return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.东不七与丒不丁世丛;
    }
    private bool 丝丟丝丑丗且下丞与()
    {
        var val_6;
        var val_7;
        WeaponManager val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_6 = null;
        val_6 = null;
        val_7 = 1152921504848912384;
        val_8 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_8 != 0)
        {
                val_9 = null;
            val_9 = null;
            val_8 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_8 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_8 != 0)
        {
                val_10 = null;
            val_10 = null;
            UnityEngine.Vector2 val_3 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丁丕下丛专丏丅丂专();
            val_7 = 1152921505320529920;
            val_11 = null;
            val_11 = null;
            if(System.Math.Abs(val_3.x) >= PlayerCoreSettingsStorager.recoildAndScopeSettings.不丐三丘与丏丈丘且)
        {
                return (bool)val_14;
        }
        
            val_12 = null;
            val_12 = null;
            UnityEngine.Vector2 val_4 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丁丕下丛专丏丅丂专();
            val_13 = null;
            val_13 = null;
            val_8 = PlayerCoreSettingsStorager.recoildAndScopeSettings;
            var val_5 = (System.Math.Abs(val_4.y) >= PlayerCoreSettingsStorager.recoildAndScopeSettings.不丐三丘与丏丈丘且) ? 1 : 0;
            return (bool)val_14;
        }
        
        }
        
        val_14 = 0;
        return (bool)val_14;
    }
    internal void 世上专丐丂业世世丂(bool 世下丐丌一丗一丞丌)
    {
        if(世下丐丌一丗一丞丌 != false)
        {
                this.丏丒丆丝万与丁丁丟 = true;
            this.Reset();
            return;
        }
        
        if(this.丏丒丆丝万与丁丁丟 == false)
        {
                return;
        }
        
        this.Reset();
        this.丏丒丆丝万与丁丁丟 = false;
    }
    internal UnityEngine.Vector2 丙一万不一丛且丄下()
    {
        return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.东且丁丆丛丁丏丘且, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.世与丗丏丟丂丕三万, y = V8.16B});
    }
    private float 且东万三且东丛丐丛(float 一不丅与丟丌丏丟东)
    {
        float val_1 = -360f;
        val_1 = 一不丅与丟丌丏丟东 + val_1;
        一不丅与丟丌丏丟东 = (一不丅与丟丌丏丟东 > 360f) ? (val_1) : 一不丅与丟丌丏丟东;
        return (float)一不丅与丟丌丏丟东;
    }
    private void 东与丞丒丛丁丛世丛()
    {
    
    }
    public SniperScopeMovement()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丛丘丒且丝万万三东 = val_1;
        mem[1152921539178659116] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.丝丙丑丐业丐丕丆丟 = val_2;
        mem[1152921539178659124] = val_2.y;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.丕丘丑丙与丆丘丞丁 = val_3;
        mem[1152921539178659132] = val_3.y;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.丗丁丌丆东东业丆丘 = val_4;
        mem[1152921539178659140] = val_4.y;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        this.丄丙丒丛丒丞丗专丑 = val_5;
        mem[1152921539178659148] = val_5.y;
        this.且丘丌不丟丆万与上 = 1f;
        this.丙世丙七丅丆三丝三 = 1;
    }

}
