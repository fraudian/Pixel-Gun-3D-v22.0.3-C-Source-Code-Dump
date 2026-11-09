using UnityEngine;
public class TargetFinderController : MonoBehaviour, 丄丐丁上丐丅丄世丙
{
    // Fields
    private UnityEngine.LayerMask notTargetLayers;
    private 丅一丝丟丒丝东丅不 丄丕丗东丛丙丄丒丏;
    private UnityEngine.Transform 世丑与专丂丝世业万;
    private UnityEngine.Camera 丙与丝丘世上东且丁;
    private float 丛丆丐丛下丆丑丁丛;
    private TouchPadController 不丝丌丒丅丒丟一丆;
    internal 丗丅丑专一上专不丘 丝丐丁丞业东丛丏七;
    internal Player_move_c playerController;
    private WeaponSounds 专丑一业业下且丅丗;
    private int 丞上丑不三丑万丙丑;
    private UnityEngine.Vector3 丏丅丙丌与不丅丒七;
    private float 丌七丒世丄上丞丞丁;
    private System.Action 且丝丅丞丏丌丗下丄;
    private System.Action 丌丒三世一万丁丙不;
    private 万丝丅丗且丒丝丌丟 与丌万东丝丄丐下世;
    private 万丝丅丗且丒丝丌丟 丑丄丙上丏三丘东上;
    private 万丝丅丗且丒丝丌丟 丙丘不世丘丏丅丕三;
    private float 丗专丈东丁丐丒世丂;
    
    // Properties
    private WeaponSounds 东丁丘丅三七丌丂丄 { get; }
    public 丅一丝丟丒丝东丅不 丘与丈丘丒丂丁丛丟 { get; }
    public float 丄丒丝丘丟丄上且丘 { get; }
    
    // Methods
    private WeaponSounds 一丈世丙丏丈三丛丁()
    {
        WeaponSounds val_5;
        Player_move_c val_6;
        val_5 = this;
        if(this.丞上丑不三丑万丙丑 == UnityEngine.Time.frameCount)
        {
                val_5 = this.专丑一业业下且丅丗;
            return (WeaponSounds)this.专丑一业业下且丅丗;
        }
        
        val_6 = this.playerController;
        if(val_6 == null)
        {
            goto label_2;
        }
        
        if(this.playerController.东丗丒丝丐且丞丄丏 == false)
        {
            goto label_8;
        }
        
        label_7:
        WeaponSounds val_2 = val_6.业丁不丒丑丂丏三下();
        goto label_4;
        label_2:
        if(this.playerController == null)
        {
            goto label_5;
        }
        
        val_6 = this.playerController;
        if(this.playerController.东丗丒丝丐且丞丄丏 == true)
        {
            goto label_7;
        }
        
        label_8:
        label_4:
        this.专丑一业业下且丅丗 = val_6.丙不丅丕三丂业东丕();
        this.丞上丑不三丑万丙丑 = UnityEngine.Time.frameCount;
        return (WeaponSounds)this.专丑一业业下且丅丗;
        label_5:
        if(this.playerController.东丗丒丝丐且丞丄丏 == true)
        {
            goto label_7;
        }
        
        goto label_8;
    }
    public void add_TargetChaged(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.且丝丅丞丏丌丗下丄, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.且丝丅丞丏丌丗下丄 != 1152921539895777864);
    
    }
    public void remove_TargetChaged(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.且丝丅丞丏丌丗下丄, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.且丝丅丞丏丌丗下丄 != 1152921539895914440);
    
    }
    public void add_TargetMissed(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丌丒三世一万丁丙不, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌丒三世一万丁丙不 != 1152921539896051024);
    
    }
    public void remove_TargetMissed(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丌丒三世一万丁丙不, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌丒三世一万丁丙不 != 1152921539896187600);
    
    }
    public 丅一丝丟丒丝东丅不 get_Target()
    {
        return (丅一丝丟丒丝东丅不)this.丄丕丗东丛丙丄丒丏;
    }
    public float get_RadiusPercent()
    {
        return (float)this.丛丆丐丛下丆丑丁丛;
    }
    private void Start()
    {
        var val_10;
        if(this.playerController.mySkinName.firstPersonControl.丌且下丕下下丌万丞 != false)
        {
                this.丝丐丁丞业东丛丏七 = this.GetComponent<丗丅丑专一上专不丘>();
            val_10 = null;
            val_10 = null;
            this.不丝丌丒丅丒丟一丆 = JoystickController.丘万丏三丏丑世丐丏;
            BaseCamera val_2 = this.playerController.丝丙与东丈不丙三丟();
            this.世丑与专丂丝世业万 = val_2.且与东丕专七万丕不;
            this.丙与丝丘世上东且丁 = this.playerController.丝丙与东丈不丙三丟().camera;
            int val_5 = UnityEngine.Screen.width;
            int val_6 = UnityEngine.Screen.height;
            var val_7 = (val_5 < 0) ? (val_5 + 1) : (val_5);
            val_7 = val_7 >> 1;
            var val_9 = ((val_6 < 0) ? (val_6 + 1) : (val_6)) >> 1;
            this.丏丅丙丌与不丅丒七 = 0;
            mem[1152921539896586044] = 0;
            this.丈丌上一丝丟丑下丈();
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  this);
    }
    private void 专三丗丂丁丝不丒东()
    {
        this.丈丌上一丝丟丑下丈();
    }
    private void 丏丂世丑业七万丐且(万丝丅丗且丒丝丌丟 丞丆七丄丒下丏丂丗)
    {
        丗丅丑专一上专不丘 val_7;
        if(this.与丌万东丝丄丐下世 == 丞丆七丄丒下丏丂丗)
        {
            goto label_1;
        }
        
        if(丞丆七丄丒下丏丂丗 != null)
        {
                val_7 = this.丝丐丁丞业东丛丏七;
            this.丙丘不世丘丏丅丕三 = 丞丆七丄丒下丏丂丗;
            var val_8 = 0;
            val_8 = val_8 + 1;
        }
        else
        {
                this.丗专丈东丁丐丒世丂 = 0f;
            this.与丌万东丝丄丐下世 = 0;
            mem[1152921539896883824] = 0;
            return;
        }
        
        if(val_7.InRect == false)
        {
            goto label_9;
        }
        
        if(this.丙丘不世丘丏丅丕三 == null)
        {
                return;
        }
        
        if(this.与丌万东丝丄丐下世 == 丞丆七丄丒下丏丂丗)
        {
                return;
        }
        
        if(this.丑丄丙上丏三丘东上 == 丞丆七丄丒下丏丂丗)
        {
            goto label_12;
        }
        
        label_1:
        this.丑丄丙上丏三丘东上 = 丞丆七丄丒下丏丂丗;
        this.丗专丈东丁丐丒世丂 = 0f;
        return;
        label_12:
        一三专丈世丑丆丑丐 val_3 = PlayerCoreSettingsStorager.dynamicSettings;
        if(this.丗专丈东丁丐丒世丂 <= val_3.丁三丅不丁丑丁丂丗)
        {
            goto label_16;
        }
        
        label_9:
        this.与丌万东丝丄丐下世 = 丞丆七丄丒下丏丂丗;
        this.丈丌上一丝丟丑下丈();
        丅一丝丟丒丝东丅不 val_4 = new 丅一丝丟丒丝东丅不();
        float val_6 = this.一丈世丙丏丈三丛丁().丁丕丕七丁丏专丟业();
        if(val_4 != null)
        {
                .丌七丒世丄上丞丞丁 = val_6;
        }
        else
        {
                mem[24] = val_6;
        }
        
        .丞下万上三丘上与专 = 丞丆七丄丒下丏丂丗;
        this.SetTarget(东一丁世丑丞业丄丐:  val_4);
        return;
        label_16:
        float val_7 = UnityEngine.Time.deltaTime;
        val_7 = this.丗专丈东丁丐丒世丂 + val_7;
        this.丗专丈东丁丐丒世丂 = val_7;
    }
    private void Update()
    {
        var val_12;
        var val_13;
        if(GameConnect.下丅丏丄丕丐丞丞丁() != true)
        {
                if(this.一丈世丙丏丈三丛丁() == 0)
        {
                return;
        }
        
        }
        
        if(this.playerController == 0)
        {
                return;
        }
        
        if(this.不丝丌丒丅丒丟一丆 == 0)
        {
                return;
        }
        
        if(this.playerController.万丝一万丐且丌业丛 != false)
        {
                return;
        }
        
        if((与丂丏丛丞丞丒丟丄.七一三丄丝丒上三且() != false) && (this.playerController.丏万丂专丂丌下丈世() != false))
        {
                this.丏丂世丑业七万丐且(丞丆七丄丒下丏丂丗:  this.playerController.丙万丅下丂业东丄丒);
            val_12 = 0;
        }
        else
        {
                this.丈丌上一丝丟丑下丈();
            return;
        }
        
        if( != 0)
        {
                return;
        }
        
        val_13 = 0;
        if( != 0)
        {
                return;
        }
        
        this.三丙丗丕不下业丞丈();
        this.丝且丐丝丝丕丒七丂();
    }
    private void 三丙丗丕不下业丞丈()
    {
        var val_8;
        var val_34;
        万丝丅丗且丒丝丌丟 val_35;
        var val_36;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_44;
        var val_45;
        UnityEngine.Transform val_46;
        UnityEngine.Camera val_47;
        val_34 = this;
        if(this.丄丕丗东丛丙丄丒丏 != null)
        {
                val_35 = this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专;
        }
        else
        {
                val_35 = 0;
        }
        
        val_36 = 0;
        if( != 0)
        {
                var val_36 = 0;
            val_36 = val_36 + 1;
            if(this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专.isTargetDead == false)
        {
                return;
        }
        
        }
        
        val_38 = null;
        val_38 = null;
        Dictionary.Enumerator<TKey, TValue> val_5 = 丘丛丞且一丅丁丏丐.专丛下丘丆丘丑下丈.GetEnumerator();
        label_76:
        if((930688432 & 1) == 0)
        {
            goto label_19;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        if(val_9._value._obj.丐丏七丌丕丗业且上().gameObject.activeInHierarchy == false)
        {
            goto label_76;
        }
        
        if((丘丛丞且一丅丁丏丐.丗丏丌一一业且业丘(丛丌丕丐世丑丂七丂:  val_9._value._obj.丐丏七丌丕丗业且上(), 上丁丆不东丕万丂丏:  this.playerController)) == false)
        {
            goto label_76;
        }
        
        val_39 = 0;
        if( == 0)
        {
            goto label_76;
        }
        
        object val_40 = val_9._value._obj;
        if((val_9._value._obj + 286) == 0)
        {
            goto label_36;
        }
        
        var val_37 = val_9._value._obj + 176;
        var val_38 = 0;
        val_37 = val_37 + 8;
        label_35:
        if(((val_9._value._obj + 176 + 8) + -8) == null)
        {
            goto label_34;
        }
        
        val_38 = val_38 + 1;
        val_37 = val_37 + 16;
        if(val_38 < (val_9._value._obj + 286))
        {
            goto label_35;
        }
        
        goto label_36;
        label_34:
        var val_39 = val_37;
        val_39 = val_39 + 4;
        val_40 = val_40 + val_39;
        val_40 = val_40 + 296;
        label_36:
        if(val_9._value._obj.isTargetDead == true)
        {
            goto label_76;
        }
        
        object val_44 = val_9._value._obj;
        if((val_9._value._obj + 286) == 0)
        {
            goto label_42;
        }
        
        var val_41 = val_9._value._obj + 176;
        var val_42 = 0;
        val_41 = val_41 + 8;
        label_41:
        if(((val_9._value._obj + 176 + 8) + -8) == null)
        {
            goto label_40;
        }
        
        val_42 = val_42 + 1;
        val_41 = val_41 + 16;
        if(val_42 < (val_9._value._obj + 286))
        {
            goto label_41;
        }
        
        goto label_42;
        label_40:
        var val_43 = val_41;
        val_43 = val_43 + 3;
        val_44 = val_44 + val_43;
        val_41 = val_44 + 296;
        label_42:
        UnityEngine.Vector3 val_19 = val_9._value._obj.targetTransform.position;
        object val_48 = val_9._value._obj;
        if((val_9._value._obj + 286) == 0)
        {
            goto label_48;
        }
        
        var val_45 = val_9._value._obj + 176;
        var val_46 = 0;
        val_45 = val_45 + 8;
        label_47:
        if(((val_9._value._obj + 176 + 8) + -8) == null)
        {
            goto label_46;
        }
        
        val_46 = val_46 + 1;
        val_45 = val_45 + 16;
        if(val_46 < (val_9._value._obj + 286))
        {
            goto label_47;
        }
        
        goto label_48;
        label_46:
        var val_47 = val_45;
        val_47 = val_47 + 4;
        val_48 = val_48 + val_47;
        val_42 = val_48 + 296;
        label_48:
        if((this.丌丟万一丆丘丐与东(丈七丅上丟丑专丅丝:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, 丒东三丌专丗三丂丟:  val_9._value._obj.isTargetDead)) == false)
        {
            goto label_76;
        }
        
        UnityEngine.Vector3 val_24 = this.transform.position;
        if(((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z})) > this.一丈世丙丏丈三丛丁().AutoAimDistance) || ((this.playerController.丘丈世丒丝与丅世专(上不一丗下世丂丞与:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, 东丆丝丌丅丙上一且:  val_9._value._obj)) == false))
        {
            goto label_76;
        }
        
        var val_49 = 0;
        val_49 = val_49 + 1;
        丘丐丗丐七丑丏丒丗 val_30 = this.丝丐丁丞业东丛丏七.Settings;
        val_44 = 0;
        object val_53 = val_9._value._obj;
        if((val_9._value._obj + 286) == 0)
        {
            goto label_70;
        }
        
        var val_51 = val_9._value._obj + 176;
        var val_52 = 0;
        val_51 = val_51 + 8;
        label_69:
        if(((val_9._value._obj + 176 + 8) + -8) == null)
        {
            goto label_68;
        }
        
        val_52 = val_52 + 1;
        val_51 = val_51 + 16;
        if(val_52 < (val_9._value._obj + 286))
        {
            goto label_69;
        }
        
        goto label_70;
        label_68:
        val_53 = val_53 + (((val_9._value._obj + 176 + 8)) << 4);
        val_45 = val_53 + 296;
        label_70:
        val_46 = this.世丑与专丂丝世业万;
        val_47 = this.丙与丝丘世上东且丁;
        val_46 = val_46;
        val_47 = val_47;
        UnityEngine.Rect val_33 = SupportAimController.AimHelpRect(丁丂专业丁丅丅丈丙:  val_9._value._obj.aimCollider, 与三丕东七丟丝丈万:  CurrentSharedContainer, 丈七丅上丟丑专丅丝:  val_46, 丙与丝丘世上东且丁:  val_47, 丕业丅丄丟丄专丌丂:  0);
        UnityEngine.Vector3 val_34 = SupportAimController.CenterOfScreen;
        if((930688400 & 1) == 0)
        {
            goto label_76;
        }
        
        new 丅一丝丟丒丝东丅不() = new 丅一丝丟丒丝东丅不();
        .丞下万上三丘上与专 = ;
        this.SetTarget(东一丁世丑丞业丄丐:  new 丅一丝丟丒丝东丅不());
        goto label_76;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丝且丐丝丝丕丒七丂()
    {
        var val_23;
        万丝丅丗且丒丝丌丟 val_26;
        var val_28;
        if(this.丄丕丗东丛丙丄丒丏 == null)
        {
                return;
        }
        
        val_23 = 0;
        if( == 0)
        {
                return;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        UnityEngine.Vector3 val_5 = this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专.targetTransform.position;
        var val_28 = 0;
        val_28 = val_28 + 1;
        if((this.丌丟万一丆丘丐与东(丈七丅上丟丑专丅丝:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丒东三丌专丗三丂丟:  this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专.isTargetDead)) == false)
        {
            goto label_40;
        }
        
        UnityEngine.Vector3 val_11 = this.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) > this.一丈世丙丏丈三丛丁().AutoAimDistance)
        {
            goto label_40;
        }
        
        val_26 = this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专;
        if((this.playerController.丘丈世丒丝与丅世专(上不一丗下世丂丞与:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 东丆丝丌丅丙上一且:  val_26)) == false)
        {
            goto label_40;
        }
        
        if((this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专 == null) || (null != null))
        {
            goto label_34;
        }
        
        if(this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专 != null)
        {
                if(null == null)
        {
            goto label_37;
        }
        
        }
        
        label_37:
        var val_16 = (null == null) ? this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专 : 0;
        val_26 = mem[typeof(万丝丅丗且丒丝丌丟) == null ? this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专 : 0 + 888];
        val_26 = typeof(万丝丅丗且丒丝丌丟) == null ? this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专 : 0 + 888;
        if((丘丛丞且一丅丁丏丐.丗丏丌一一业且业丘(丛丌丕丐世丑丂七丂:  val_26, 上丁丆不东丕万丂丏:  this.playerController)) == false)
        {
            goto label_40;
        }
        
        label_34:
        var val_29 = 0;
        val_29 = val_29 + 1;
        val_28 = this.丝丐丁丞业东丛丏七.Settings;
        if(val_28 != null)
        {
                val_28 = 0;
        }
        
        var val_30 = 0;
        val_30 = val_30 + 1;
        val_26 = this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专.aimCollider;
        UnityEngine.Rect val_25 = SupportAimController.AimHelpRect(丁丂专业丁丅丅丈丙:  val_26, 与三丕东七丟丝丈万:  val_28.CurrentSharedContainer, 丈七丅上丟丑专丅丝:  this.世丑与专丂丝世业万, 丙与丝丘世上东且丁:  this.丙与丝丘世上东且丁, 丕业丅丄丟丄专丌丂:  0);
        UnityEngine.Vector3 val_26 = SupportAimController.CenterOfScreen;
        if(( & 1) != 0)
        {
                return;
        }
        
        label_40:
        this.丈丌上一丝丟丑下丈();
    }
    private void SetTarget(丅一丝丟丒丝东丅不 东一丁世丑丞业丄丐)
    {
        if(东一丁世丑丞业丄丐 == null)
        {
                return;
        }
        
        this.丄丕丗东丛丙丄丒丏 = 东一丁世丑丞业丄丐;
        this.且丝丅丞丏丌丗下丄.Invoke();
    }
    private void 丈丌上一丝丟丑下丈()
    {
        this.丄丕丗东丛丙丄丒丏.丞下万上三丘上与专 = 0;
        if(this.丄丕丗东丛丙丄丒丏 != null)
        {
                this.丄丕丗东丛丙丄丒丏.且丛上丕业丂丒与一 = 3.402823E+38f;
            this.丄丕丗东丛丙丄丒丏.丘专丛丑世三丛业丟 = 9.183409E-41f;
        }
        else
        {
                mem[32] = 2155872256;
            mem[28] = 2155872256;
        }
        
        this.丄丕丗东丛丙丄丒丏.丌七丒世丄上丞丞丁 = -1.175494E-38f;
        this.丌丒三世一万丁丙不.Invoke();
    }
    private bool 丌丟万一丆丘丐与东(UnityEngine.Vector3 丈七丅上丟丑专丅丝, bool 丒东三丌专丗三丂丟)
    {
        UnityEngine.Transform val_6;
        float val_7;
        var val_8;
        val_6 = 丒东三丌专丗三丂丟;
        UnityEngine.Vector3 val_1 = this.世丑与专丂丝世业万.position;
        val_7 = val_1.y;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丈七丅上丟丑专丅丝.x, y = 丈七丅上丟丑专丅丝.y, z = 丈七丅上丟丑专丅丝.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_7, z = val_1.z});
        if(val_6 != false)
        {
                val_8 = 0;
            return (bool)((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_7, z = val_3.z})) > 0.7f) ? 1 : 0;
        }
        
        val_6 = this.世丑与专丂丝世业万;
        UnityEngine.Vector3 val_3 = val_6.forward;
        val_7 = val_3.y;
        return (bool)((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_7, z = val_3.z})) > 0.7f) ? 1 : 0;
    }
    public TargetFinderController()
    {
        var val_4;
        System.Action val_6;
        System.Action val_9;
        this.丄丕丗东丛丙丄丒丏 = new 丅一丝丟丒丝东丅不();
        this.丛丆丐丛下丆丑丁丛 = -1.175494E-38f;
        this.丞上丑不三丑万丙丑 = 0;
        this.丌七丒世丄上丞丞丁 = -1.175494E-38f;
        val_4 = null;
        val_4 = null;
        val_6 = TargetFinderController.<>c.<>9__37_0;
        if(val_6 == null)
        {
                System.Action val_2 = null;
            val_6 = val_2;
            val_2 = new System.Action(object:  TargetFinderController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TargetFinderController.<>c::丗三丝丝丛世上丐专());
            val_4 = null;
            TargetFinderController.<>c.<>9__37_0 = val_6;
        }
        
        this.且丝丅丞丏丌丗下丄 = val_6;
        val_4 = null;
        val_9 = TargetFinderController.<>c.<>9__37_1;
        if(val_9 == null)
        {
                System.Action val_3 = null;
            val_9 = val_3;
            val_3 = new System.Action(object:  TargetFinderController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TargetFinderController.<>c::丙丈东下业东丑七丆());
            TargetFinderController.<>c.<>9__37_1 = val_9;
        }
        
        this.丌丒三世一万丁丙不 = val_9;
    }

}
