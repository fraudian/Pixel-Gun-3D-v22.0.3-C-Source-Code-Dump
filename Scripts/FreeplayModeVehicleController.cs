using UnityEngine;
internal sealed class FreeplayModeVehicleController : PhotonEventBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal readonly float 丂丙丆丝丄丗与不丗;
    internal FreeplayVehicleSpawnSelector 与丄丕专丞丅下不七;
    private FreeplayCarsharingSpawnsController 丒丕与丅丅丆上上丈;
    private float 丂丈一万世丙万东下;
    private TransportControllerBase 丑丙不丗丝万丌丒三;
    private System.Collections.Generic.HashSet<FreeplayVehicleOwner> 丄丕与三一丗丆业丕;
    private System.Collections.Generic.HashSet<FreeplayVehicleOwner> 七丑丄丁丌业丛专丙;
    private TransportControllerBase 丒下丌丙丅三丑丆专;
    
    // Properties
    internal FreeplayCarsharingSpawnsController 丒丌丐业丂丐业丛丑 { get; }
    internal TransportControllerBase 丅丅下丒丄下丕下丗 { get; }
    internal string 丗丟专丂业丂下丒丏 { get; }
    internal float 一丕丛丛丗丌丘业丞 { get; }
    internal float 丆世丁丗丕世且专丅 { get; }
    internal float 丂上丟不丕上丞丝三 { get; }
    
    // Methods
    internal FreeplayCarsharingSpawnsController 业不丞丏七丄丁丛东()
    {
        FreeplayCarsharingSpawnsController val_3;
        if(this.丒丕与丅丅丆上上丈 == 0)
        {
                this.丒丕与丅丅丆上上丈 = this.与丄丕专丞丅下不七.GetComponent<FreeplayCarsharingSpawnsController>();
            return val_3;
        }
        
        val_3 = this.丒丕与丅丅丆上上丈;
        return val_3;
    }
    internal TransportControllerBase 丂一丞丝丄丑与丝丄()
    {
        return (TransportControllerBase)this.丑丙不丗丝万丌丒三;
    }
    internal string 与丐且丌丏专不与丘()
    {
        TransportControllerBase val_2;
        string val_3;
        val_2 = this;
        if(this.丑丙不丗丝万丌丒三 == 0)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        val_2 = this.丑丙不丗丝万丌丒三;
        val_3 = this.丑丙不丗丝万丌丒三.不丞丒下丕丙东东且;
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }
    internal float 丂丄丁世丄三丆丈丑()
    {
        if(this.丑丙不丗丝万丌丒三 == 0)
        {
                return 0f;
        }
        
        this = ???;
        goto typeof(TransportControllerBase).__il2cppRuntimeField_288;
    }
    internal float 与丅三世七下丈丛丒()
    {
        if(this.丑丙不丗丝万丌丒三 == 0)
        {
                return 0f;
        }
        
        this = ???;
        goto typeof(TransportControllerBase).__il2cppRuntimeField_2A8;
    }
    internal float 丏丛万丆丝丌丏丟下()
    {
        return (float)this.丂丈一万世丙万东下;
    }
    internal void 专丘丁丆丕丝丘一业(FreeplayVehicleOwner 丝丘下丄丈丗丈丄丘)
    {
        System.Collections.Generic.HashSet<FreeplayVehicleOwner> val_11;
        string val_12;
        if(丝丘下丄丈丗丈丄丘.丏下丏丂丛下东丞丙 != false)
        {
                FreeplayCarsharingSpawnsController val_1 = this.业不丞丏七丄丁丛东();
            if(val_1 == null)
        {
                return;
        }
        
            val_1.三丂世丄丝丟丅丂丗(七三丁丄三一且丘上:  丝丘下丄丈丗丈丄丘);
            return;
        }
        
        val_12 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        if(丝丘下丄丈丗丈丄丘.ownerId == val_12.业丐丐三丕一丗丛丁())
        {
                TransportControllerBase val_4 = 丝丘下丄丈丗丈丄丘.GetComponent<TransportControllerBase>();
            if(val_4 == 1)
        {
                val_12 = 丛且丗丌丏下七下丈.丗丘丌丘七丏丝下七();
            val_4.SetVehicleParams(丏丆丕丏丘业东万下:  val_12, 丌丐丟丟丆丁丌丌丝:  丛且丗丌丏下七下丈.丑丈业上万一丁丛丂(七丙丈丆丕丄丐业丟:  val_12), 下万下丌且丙七丝丆:  true);
        }
        
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.世丄丈丘且不上世丏(丝丘下丄丈丗丈丄丘:  val_4));
            return;
        }
        
        val_11 = this.丄丕与三一丗丆业丕;
        if((val_11.Contains(item:  丝丘下丄丈丗丈丄丘)) != false)
        {
                return;
        }
        
        bool val_10 = this.丄丕与三一丗丆业丕.Add(item:  丝丘下丄丈丗丈丄丘);
    }
    internal void 丗一丆三丗丐丘丄下(FreeplayVehicleOwner 丝丘下丄丈丗丈丄丘)
    {
        System.Collections.Generic.HashSet<FreeplayVehicleOwner> val_6;
        if((this.丄丕与三一丗丆业丕.Contains(item:  丝丘下丄丈丗丈丄丘)) != false)
        {
                bool val_2 = this.丄丕与三一丗丆业丕.Remove(item:  丝丘下丄丈丗丈丄丘);
        }
        
        val_6 = this.七丑丄丁丌业丛专丙;
        if((val_6.Contains(item:  丝丘下丄丈丗丈丄丘)) != false)
        {
                val_6 = this.七丑丄丁丌业丛专丙;
            bool val_4 = val_6.Remove(item:  丝丘下丄丈丗丈丄丘);
        }
        
        if(丝丘下丄丈丗丈丄丘.丏下丏丂丛下东丞丙 == false)
        {
                return;
        }
        
        this.业不丞丏七丄丁丛东().万专一丁下不且与且(七三丁丄三一且丘上:  丝丘下丄丈丗丈丄丘);
    }
    internal System.Collections.IEnumerator 世丄丈丘且不上世丏(TransportControllerBase 丝丘下丄丈丗丈丄丘)
    {
        FreeplayModeVehicleController.专丆一丈东东丄下业 val_1 = new FreeplayModeVehicleController.专丆一丈东东丄下业();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丝丘下丄丈丗丈丄丘 = 丝丘下丄丈丗丈丄丘;
        return (System.Collections.IEnumerator)val_1;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        var val_3;
        int val_4;
        val_2 = 丞世不丒下上上丝丑;
        if((val_2 & 255) != 0)
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        val_4 = 专丒丌丆下丐丞丟丞.Length;
        if(val_4 == 0)
        {
                val_4 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        object val_3 = 专丒丌丆下丐丞丟丞[1];
        this.丒丆丐丛丐七东丆世(业七世丆丐丄丕上丂:  21884928, 丏下丅丐丝三专丌丆:  new UnityEngine.Vector3() {x = 3.782474E-38f});
        val_3 = 1;
        return (bool)val_3;
    }
    internal bool 丕丐丙丞上三下不丏()
    {
        var val_6;
        var val_7;
        if(this.丂丈一万世丙万东下 > 0f)
        {
                val_6 = 0;
            return (bool)val_6;
        }
        
        this.丂丈一万世丙万东下 = this.丂丙丆丝丄丗与不丗;
        this.专丆丕丝丝丛世丄上();
        object[] val_1 = new object[2];
        val_1[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        val_7 = null;
        val_7 = null;
        UnityEngine.Vector3 val_5 = transform.position;
        val_1[1] = val_5;
        this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  0, 丈丅丘丐三丂丗且丌:  2, 丕业丑万一丞丞东三:  false, 丗丟上上丒丐丗丞丙:  val_1);
        val_6 = 1;
        return (bool)val_6;
    }
    internal void 丝丂与丒丟丕丙不丅()
    {
        this.丂丈一万世丙万东下 = this.丂丙丆丝丄丗与不丗;
    }
    internal void 专丆丕丝丝丛世丄上()
    {
        if(this.丑丙不丗丝万丌丒三 == 0)
        {
                return;
        }
        
        this.丑丙不丗丝万丌丒三 = 0;
        丘三丘丁专丆业丄业(丝丘下丄丈丗丈丄丘:  0);
    }
    private UnityEngine.Transform 丏七丏一丐丂下丈与(UnityEngine.Vector3 丈七丅上丟丑专丅丝)
    {
        if(this.与丄丕专丞丅下不七 == 0)
        {
                return 0;
        }
        
        if(this.与丄丕专丞丅下不七 != null)
        {
                return this.与丄丕专丞丅下不七.丆三业丏丕丏且丆丒(丈七丅上丟丑专丅丝:  new UnityEngine.Vector3() {x = 丈七丅上丟丑专丅丝.x, y = 丈七丅上丟丑专丅丝.y, z = 丈七丅上丟丑专丅丝.z});
        }
        
        return this.与丄丕专丞丅下不七.丆三业丏丕丏且丆丒(丈七丅上丟丑专丅丝:  new UnityEngine.Vector3() {x = 丈七丅上丟丑专丅丝.x, y = 丈七丅上丟丑专丅丝.y, z = 丈七丅上丟丑专丅丝.z});
    }
    private void 丒丆丐丛丐七东丆世(int 业七世丆丐丄丕上丂, UnityEngine.Vector3 丏下丅丐丝三专丌丆)
    {
        UnityEngine.Transform val_1 = this.丏七丏一丐丂下丈与(丈七丅上丟丑专丅丝:  new UnityEngine.Vector3() {x = 丏下丅丐丝三专丌丆.x, y = 丏下丅丐丝三专丌丆.y, z = 丏下丅丐丝三专丌丆.z});
        if(val_1 == 0)
        {
                return;
        }
        
        object[] val_3 = new object[1];
        val_3[0] = 业七世丆丐丄丕上丂;
        UnityEngine.GameObject val_4 = 业丛丙丛丗世丑丑丂.丄七丝丏丈丗业世业(丁丅丈丌丟世丗丗丟:  1, 丂丁万丞万丆三一丒:  val_1, 丂东丄丏丕丕丅上一:  0, 一丐丗丁丞丆丅丟丄:  val_3);
    }
    private void 丝丕不丄且丅与与丑()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_19 = 1152921505286238208;
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_628 == 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456) == 0)
        {
                return;
        }
        
        if(this.丒下丌丙丅三丑丆专 == 0)
        {
                val_23 = null;
            val_23 = null;
            val_24 = null;
            val_24 = null;
            this.丒下丌丙丅三丑丆专 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224;
            UnityEngine.GameObject val_5 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 224.gameObject;
            val_5.万业东一丅下七丘丛(丝丘下丄丈丗丈丄丘:  val_5);
            return;
        }
        
        if(this.丒下丌丙丅三丑丆专 == 0)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        if((this.七丑丄丁丌业丛专丙.Contains(item:  this.丒下丌丙丅三丑丆专.万东丂七东丁与业东())) == true)
        {
            goto label_54;
        }
        
        FreeplayVehicleOwner val_9 = this.丒下丌丙丅三丑丆专.万东丂七东丁与业东();
        if(val_9.丏下丏丂丛下东丞丙 == true)
        {
            goto label_54;
        }
        
        FreeplayVehicleOwner val_10 = this.丒下丌丙丅三丑丆专.万东丂七东丁与业东();
        val_19 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        if(val_10.ownerId != val_19)
        {
            goto label_60;
        }
        
        label_54:
        val_19 = this.丒下丌丙丅三丑丆专.万东丂七东丁与业东();
        this.丘世下丄丐丏专与三(不下业丞丌世专且丈:  this.丒下丌丙丅三丑丆专.gameObject, 专丝与业专万丘一不:  val_19.丟丝丐且且丁丏丝上(丞丅上丏丂且下丅与:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁()));
        label_60:
        this.丒下丌丙丅三丑丆专 = 0;
    }
    private void Update()
    {
        var val_9;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        if(this.丂丈一万世丙万东下 > 0f)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.丂丈一万世丙万东下 - val_1;
            this.丂丈一万世丙万东下 = val_1;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        val_32 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
                return;
        }
        
        if(InGameGUIPart_Freeplay.__il2cppRuntimeField_byval_arg == 0)
        {
                return;
        }
        
        this.丝丕不丄且丅与与丑();
        System.Collections.Generic.HashSet<FreeplayVehicleOwner> val_6 = new System.Collections.Generic.HashSet<FreeplayVehicleOwner>();
        HashSet.Enumerator<T> val_7 = this.七丑丄丁丌业丛专丙.GetEnumerator();
        label_27:
        if(((-1420587968) & 1) == 0)
        {
            goto label_18;
        }
        
        string val_10 = val_9.丐丏七丌丕丗业且上();
        val_33 = null;
        val_33 = null;
        if(GameController.mode != null)
        {
                if(null == null)
        {
            goto label_22;
        }
        
        }
        
        if(GameController.mode != null)
        {
                label_22:
            var val_11 = (null == null) ? GameController.mode : 0;
        }
        else
        {
                val_34 = 0;
        }
        
        if((val_34.丘七丈丅丐丄丐丗万(七三丁丄三一且丘上:  val_10)) == true)
        {
            goto label_27;
        }
        
        bool val_13 = val_6.Add(item:  val_10);
        goto label_27;
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        HashSet.Enumerator<T> val_14 = val_6.GetEnumerator();
        label_40:
        if(((-1420587968) & 1) == 0)
        {
            goto label_36;
        }
        
        string val_15 = val_9.丐丏七丌丕丗业且上();
        bool val_16 = this.七丑丄丁丌业丛专丙.Remove(item:  val_15);
        bool val_17 = this.丄丕与三一丗丆业丕.Add(item:  val_15);
        UnityEngine.GameObject val_18 = val_15.gameObject;
        val_18.万业东一丅下七丘丛(丝丘下丄丈丗丈丄丘:  val_18);
        goto label_40;
        label_36:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_6.Clear();
        HashSet.Enumerator<T> val_19 = this.丄丕与三一丗丆业丕.GetEnumerator();
        label_60:
        if(((-1420587968) & 1) == 0)
        {
            goto label_51;
        }
        
        string val_20 = val_9.丐丏七丌丕丗业且上();
        val_35 = null;
        val_35 = null;
        if(GameController.mode != null)
        {
                if(null == null)
        {
            goto label_55;
        }
        
        }
        
        if(GameController.mode != null)
        {
                label_55:
            var val_21 = (null == null) ? GameController.mode : 0;
        }
        else
        {
                val_36 = 0;
        }
        
        if((val_36.丘七丈丅丐丄丐丗万(七三丁丄三一且丘上:  val_20)) == false)
        {
            goto label_60;
        }
        
        bool val_23 = val_6.Add(item:  val_20);
        goto label_60;
        label_51:
        val_37 = 0;
        val_32 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (351 != 351))
        {
            goto label_67;
        }
        
        val_37 = 0;
        if(val_6 != null)
        {
            goto label_71;
        }
        
        goto label_69;
        label_67:
        if( != 0)
        {
                val_32 = 0;
        }
        
        if(val_6 != null)
        {
            goto label_71;
        }
        
        label_69:
        label_71:
        HashSet.Enumerator<T> val_24 = val_6.GetEnumerator();
        label_82:
        if(((-1420587968) & 1) == 0)
        {
            goto label_72;
        }
        
        string val_25 = val_9.丐丏七丌丕丗业且上();
        bool val_26 = this.丄丕与三一丗丆业丕.Remove(item:  val_25);
        bool val_27 = this.七丑丄丁丌业丛专丙.Add(item:  val_25);
        if(this.丒下丌丙丅三丑丆专 != 0)
        {
                if(this.丒下丌丙丅三丑丆专 == val_25)
        {
            goto label_82;
        }
        
        }
        
        this.丘世下丄丐丏专与三(不下业丞丌世专且丈:  val_25.gameObject, 专丝与业专万丘一不:  false);
        goto label_82;
        label_72:
        mem2[0] = 465;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((0 + 1) != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921537545997328 + ((0 + 1)) << 2) == 465)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    internal void 万业东一丅下七丘丛(UnityEngine.GameObject 丝丘下丄丈丗丈丄丘)
    {
        if(丝丘下丄丈丗丈丄丘 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        InGameGUIPart_Freeplay.__il2cppRuntimeField_byval_arg.RemoveMiniMapIcon(业丟丏上丛与不一丝:  丝丘下丄丈丗丈丄丘);
    }
    internal void 丘世下丄丐丏专与三(UnityEngine.GameObject 不下业丞丌世专且丈, bool 专丝与业专万丘一不 = True)
    {
        专丝与业专万丘一不 = 专丝与业专万丘一不;
        this.丘世下丄丐丏专与三(不下业丞丌世专且丈:  不下业丞丌世专且丈.GetComponent<TransportControllerBase>(), 专丝与业专万丘一不:  专丝与业专万丘一不);
    }
    internal void 丘世下丄丐丏专与三(TransportControllerBase 不下业丞丌世专且丈, bool 专丝与业专万丘一不 = True)
    {
        var val_7;
        if(不下业丞丌世专且丈 == 0)
        {
                return;
        }
        
        if(不下业丞丌世专且丈 != 3)
        {
            goto label_6;
        }
        
        label_15:
        if(this != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        this.丘世下丄丐丏专与三(丝丘下丄丈丗丈丄丘:  不下业丞丌世专且丈.gameObject, 丁丅丈丌丟世丗丗丟:  (专丝与业专万丘一不 != true) ? 28 : 30);
        return;
        label_6:
        if(不下业丞丌世专且丈 == 2)
        {
                UnityEngine.GameObject val_4 = 不下业丞丌世专且丈.gameObject;
            val_7 = 26;
        }
        else
        {
                UnityEngine.GameObject val_5 = 不下业丞丌世专且丈.gameObject;
            if(不下业丞丌世专且丈 != 4)
        {
            goto label_15;
        }
        
            val_7 = 31;
        }
        
        var val_6 = ((专丝与业专万丘一不 & true) != 0) ? (val_7 + 1) : (val_7);
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    internal void 丘世下丄丐丏专与三(UnityEngine.GameObject 丝丘下丄丈丗丈丄丘, int 丁丅丈丌丟世丗丗丟)
    {
        if(丝丘下丄丈丗丈丄丘 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        InGameGUIPart_Freeplay.__il2cppRuntimeField_byval_arg.丛丘丗丆丌丏不丑专(万不且且丛丆东丒业:  丝丘下丄丈丗丈丄丘, 丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟);
    }
    internal void 丘世下丄丐丏专与三()
    {
        if(this.丑丙不丗丝万丌丒三 == 0)
        {
                return;
        }
        
        this.丘世下丄丐丏专与三(不下业丞丌世专且丈:  this.丑丙不丗丝万丌丒三, 专丝与业专万丘一不:  true);
    }
    public FreeplayModeVehicleController()
    {
        this.丂丙丆丝丄丗与不丗 = 60f;
        this.丄丕与三一丗丆业丕 = new System.Collections.Generic.HashSet<FreeplayVehicleOwner>();
        this.七丑丄丁丌业丛专丙 = new System.Collections.Generic.HashSet<FreeplayVehicleOwner>();
    }
    private bool 一下不丅业丙丏下丁()
    {
        bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丑丙不丗丝万丌丒三.不丞丒下丕丙东东且);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }

}
