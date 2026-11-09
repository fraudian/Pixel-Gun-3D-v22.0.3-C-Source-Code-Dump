using UnityEngine;
public class FortAttackController : OnlineModeController
{
    // Fields
    internal System.Collections.Generic.List<FortBotSet> allBotSets;
    private WaveSettings _waveSettings;
    internal 丝专专丛三丅丐丛丄 丟丁万上丌下丌万丈;
    internal 丕下丞上上丂丕丟不 不丆丌丁丌丁丞且与;
    internal 丕下丞上上丂丕丟不 丞万世上丝丌丘丘丄;
    private float 业丗丄不丕不丁丗与;
    private int 业丌专丁上丁丛世丗;
    internal bool 丄丆丄与丁不七下丟;
    private WorldPosIndicationItem 丒不丆丁丛丂丅丗下;
    private static System.Action<int> 丘丅一七丞丞丐丒丘;
    private float 丞上丘丐丑不业世丏;
    private float 三下专与丌且丌与专;
    private float _addTimeForDestroyDoor;
    private UnityEngine.Coroutine 丁丟丗七丞丝且丙丑;
    internal static readonly int 一下专东丒业与丅且;
    internal static readonly int 三丛七丑丛专丅丕丕;
    internal static readonly int 不丌丙丌丒丙三丕丙;
    private WorldPosIndicationItem_RoyaleSquad[] 万丂丂七且一丏丕且;
    private WorldPosIndicationItem_TankHealth 丄丕世丏丗丛丈七与;
    private UnityEngine.Color 丐丈世丈丄万下丈丟;
    private UnityEngine.Color 丂东丈下丏东丁丟万;
    private UnityEngine.Color 丁东丟丝丌东丁丁丄;
    private UnityEngine.Color 丌丗丄丄丙丄丈且丙;
    private UnityEngine.Color 不丅丆与丟丘丈丗东;
    private UnityEngine.Color 丟且一专丂上丝七丐;
    
    // Properties
    internal static int 丆丕丌业丗专七世丒 { get; }
    internal WaveSettings 且丗丙丈丝业七三丟 { get; }
    internal int 丒丝丌丘七业丁业世 { get; }
    internal int 丁丌丆丈不上丂丁专 { get; }
    public SiegeContainerGUI 世且不专上专丞丁一 { get; }
    private WorldPosIndicationItem 业万下世丁丆丄丞丆 { get; }
    
    // Methods
    internal static int 一一丕丏丈世丞世丟()
    {
        var val_8;
        var val_9;
        var val_10;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 0;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_9 = null;
        val_9 = null;
        if((val_8.ContainsKey(key:  GameConnect.七丝丕东丘丐丗不世)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丝丕东丘丐丗不世]);
    }
    internal WaveSettings 丒世丗不丝丘丈专专()
    {
        return (WaveSettings)this._waveSettings;
    }
    internal int 丒业丈不丈丘丛丘东()
    {
        return (int)this.业丌专丁上丁丛世丗;
    }
    internal int 且丒丆业一丑丒丕一()
    {
        if(this._waveSettings != null)
        {
                return (int)this._waveSettings.countWave;
        }
        
        return (int)this._waveSettings.countWave;
    }
    public SiegeContainerGUI get_containerUI()
    {
        InGameGUI val_2;
        var val_3;
        val_2 = InGameGUI.丙丞专丌丁丞与不丐;
        val_3 = 0;
        if(val_2 == 0)
        {
                return (SiegeContainerGUI)InGameGUIPart_FortAttack.__il2cppRuntimeField_byval_arg;
        }
        
        val_2 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 848];
        val_2 = InGameGUI.丙丞专丌丁丞与不丐.丕下丌七万丝丅三丘;
        return (SiegeContainerGUI)InGameGUIPart_FortAttack.__il2cppRuntimeField_byval_arg;
    }
    private WorldPosIndicationItem 世丞业丁业丆丈丘世()
    {
        if(this.丒不丆丁丛丂丅丗下 != 0)
        {
                return (WorldPosIndicationItem)mem[this.丒不丆丁丛丂丅丗下];
        }
        
        UnityEngine.Transform val_2 = transform;
        val_2.丕七下丗专丈三丄丈(丞丈且下且丙丞与丈: out  this.丒不丆丁丛丂丅丗下, 丞下万上三丘上与专:  val_2);
        return (WorldPosIndicationItem)mem[this.丒不丆丁丛丂丅丗下];
    }
    public static void add_OnStartWave(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  FortAttackController.丘丅一七丞丞丐丒丘, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void remove_OnStartWave(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  FortAttackController.丘丅一七丞丞丐丒丘, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal override void 东丞丒丗专业且专丒()
    {
        this.东丞丒丗专业且专丒();
        this.不丆丌丁丌丁丞且与.且七丙丄丘一丄上不();
        this.丞万世上丝丌丘丘丄.且七丙丄丘一丄上不();
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
    }
    public override void GlobalEndMod(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        object val_5;
        BaseConditionEndRound val_6;
        var val_7;
        val_6 = 丅丈丌丅专丐丈丞东;
        this.GlobalEndMod(丅丈丌丅专丐丈丞东:  val_6);
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        val_5 = 1;
        val_2.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  1);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_6 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_6.七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
    }
    internal override void 丝丐不东一一丁丌七()
    {
        var val_11;
        var val_16;
        var val_17;
        TimeGameController.丄丞丁丈与业上丞丟.丞丞下丒丅丅丛世丕();
        InGameGUI.remove_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::丏丑下丑且三业丄丄()));
        InGameGUI.add_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::丏丑下丑且三业丄丄()));
        if(TankController.丄丘七三上丕世丞业 == 0)
        {
            goto label_4;
        }
        
        TankController.丄丘七三上丕世丞业.remove_onEndReached(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::丐丕且丈世丘丄丒不()));
        typeof(DamageableObject).__il2cppRuntimeField_50 = TankController.丄丘七三上丕世丞业.丐丁丛丗专丛丆丄丞 ^ 1;
        if(TankController.丄丘七三上丕世丞业.丐丁丛丗专丛丆丄丞 == true)
        {
            goto label_12;
        }
        
        TankController.丄丘七三上丕世丞业.add_onEndReached(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::丐丕且丈世丘丄丒不()));
        goto label_12;
        label_4:
        typeof(DamageableObject).__il2cppRuntimeField_50 = 0;
        label_12:
        下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::丛东与丝丝丑丙丐业()));
        val_16 = 0;
        丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::世丟丄且丆丑东丛且()));
        List.Enumerator<T> val_9 = GetEnumerator();
        label_38:
        if(((-1443586976) & 1) == 0)
        {
            goto label_20;
        }
        
        if(val_11.丐丏七丌丕丗业且上() == null)
        {
            goto label_38;
        }
        
        if(null == null)
        {
            goto label_22;
        }
        
        if(null != null)
        {
            goto label_38;
        }
        
        val_17 = 0;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 == 0)
        {
            goto label_38;
        }
        
        if((null != 0) && (null == 0))
        {
                val_17 = 0;
        }
        
        if(val_14.Length == 0)
        {
                val_17 = 0;
        }
        
        new object[1][0] = FortDefenceLinkController.丄丘七三上丕世丞业.damageChest;
        goto label_38;
        label_22:
        if((null != 0) && (null == 0))
        {
                val_16 = 0;
        }
        
        if(val_15.Length == 0)
        {
                val_16 = 0;
        }
        
        new object[1][0] = FortDefenceLinkController.丄丘七三上丕世丞业.point;
        goto label_38;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝丐不东一一丁丌七();
        this.丙丅与万丟世一丙丂(丙业与丙丗丝不丈东:  0);
    }
    public override void Initialize()
    {
        this.Initialize();
        this.上丝业丏三丐丙丂丏();
    }
    internal override void 三丟丏东且与丗世专(bool 丂丘下万丈丘丅一丄 = False)
    {
        var val_1;
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.三丟丏东且与丗世专(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        val_1 = null;
        val_1 = null;
        FortGameFieldDecorationController.丄丘七三上丕世丞业.东丘下万与万丂与丏();
        FortGameFieldController.丄丘七三上丕世丞业.万不丄丟丑丗七万丗();
        TankEquipmentController.丄丘七三上丕世丞业.Initialize();
        TankController.丄丘七三上丕世丞业.三丆下七不上丏丂丞();
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        string val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        if((true != 0) && (this.丄丆丄与丁不七下丟 != false))
        {
                丂丛丆万丐丝下东丑();
        }
        
        val_14 = 1152921505107111936;
        ExitGames.Client.Photon.Hashtable val_2 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_15 = null;
        val_15 = null;
        if((val_2.ContainsKey(key:  GameConnect.丟丞丏丝与丙丁丛与)) == false)
        {
            goto label_24;
        }
        
        val_16 = null;
        val_16 = null;
        if((System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丞丏丝与丙丁丛与])) != 1)
        {
            goto label_24;
        }
        
        val_17 = 1;
        goto label_25;
        label_24:
        var val_8 = (1152921525484599408 == 1) ? 1 : 0;
        label_25:
        if(val_2 == null)
        {
            goto label_27;
        }
        
        if((val_8 & 1) == 0)
        {
            goto label_28;
        }
        
        label_31:
        val_2.七丘丈丛世与丘万丝(丛与丙丒丒下丌丟且:  true);
        val_2.丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  0);
        goto label_30;
        label_27:
        if((val_8 & 1) != 0)
        {
            goto label_31;
        }
        
        label_28:
        val_2.丒丆且丑业世丅三上();
        mem[1152921537523412328] = 1;
        label_30:
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(丂丘下万丈丘丅一丄 == true)
        {
                return;
        }
        
        System.Collections.Generic.List<与丈丛下世丕上丄丄> val_10 = FortGameFieldController.丄丘七三上丕世丞业.业不丆丂丞丏三丙丝();
        val_18 = 0;
        goto label_37;
        label_41:
        与丈丛下世丕上丄丄 val_11 = val_10.Item[0];
        val_14 = val_11.丞丅上丏丂且下丅与;
        UnityEngine.GameObject val_12 = val_8.下专丘丈丝丂丑丂万(丞丅上丏丂且下丅与:  val_14);
        val_18 = 1;
        label_37:
        if(val_18 < val_10.Count)
        {
            goto label_41;
        }
    
    }
    internal FortBotSet 一丝丞丆且上丛丆与(string 丈丑丟专丒世一丙下)
    {
        var val_6;
        string val_7;
        var val_8;
        val_7 = 丈丑丟专丒世一丙下;
        val_8 = 0;
        if((System.String.IsNullOrEmpty(value:  val_7)) == true)
        {
                return (FortBotSet)val_7.Item[0];
        }
        
        val_6 = 0;
        goto label_2;
        label_7:
        FortBotSet val_2 = this.allBotSets.Item[0];
        if((System.String.op_Equality(a:  val_2.id, b:  val_7)) == true)
        {
            goto label_5;
        }
        
        val_6 = 1;
        label_2:
        if(val_6 < this.allBotSets.Count)
        {
            goto label_7;
        }
        
        val_8 = 0;
        return (FortBotSet)val_7.Item[0];
        label_5:
        val_7 = this.allBotSets;
        return (FortBotSet)val_7.Item[0];
    }
    internal override void 丕且丅丞世三不七万()
    {
        var val_1;
        this.丕且丅丞世三不七万();
        this.丄丆丄与丁不七下丟 = true;
        丟丙不上丝丂丄丗三(丗丛丘万世丟丅不与:  false);
        val_1 = null;
        val_1 = null;
        丂丛丆万丐丝下东丑();
    }
    internal override bool 世丕丘不丁东与世丞()
    {
        return false;
    }
    private void 丐丕且丈世丘丄丒不()
    {
        System.Action val_4;
        FortDefenceLinkController val_5;
        val_4 = 1152921505327452160;
        if(TankController.丄丘七三上丕世丞业 != 0)
        {
                System.Action val_2 = null;
            val_4 = val_2;
            val_2 = new System.Action(object:  this, method:  System.Void FortAttackController::丐丕且丈世丘丄丒不());
            TankController.丄丘七三上丕世丞业.remove_onEndReached(丙业与丙丗丝不丈东:  val_2);
        }
        
        val_5 = FortDefenceLinkController.丄丘七三上丕世丞业;
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = mem[FortDefenceLinkController.丄丘七三上丕世丞业 + 72];
        val_5 = FortDefenceLinkController.丄丘七三上丕世丞业.damageDoor;
        typeof(DamageableObject).__il2cppRuntimeField_50 = 0;
    }
    internal override bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        var val_6 = null;
        if((丏业丟一东丂东丘丛.timeEndMatch & 1) == 0)
        {
                return false;
        }
        
        double val_5 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if((System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.专丝下世丄业丕丑七])) < 0)
        {
                return false;
        }
        
        return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    private System.Collections.IEnumerator 丐专且丗一丘丂万上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortAttackController.丅与东万丕下七丞丒();
    }
    internal override void 丁三丅东三丅丄丘丙()
    {
        this.丁三丅东三丅丄丘丙();
        InGameGUI.remove_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::丏丑下丑且三业丄丄()));
        if(TankController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        TankController.丄丘七三上丕世丞业.remove_onEndReached(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::丐丕且丈世丘丄丒不()));
    }
    internal FortPointSpawnInfo 一丟下三丄丅三丒丛(int 丞世不丒下上上丝丑)
    {
        var val_2;
        var val_7;
        var val_8;
        var val_9;
        List.Enumerator<T> val_1 = this._waveSettings.listFortPointInfo.GetEnumerator();
        label_4:
        if(((-1442123488) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_4 = val_2.GetAwaiter();
        val_7 = val_4._value._obj;
        val_8 = val_4._value._token;
        if(val_7 != 丞世不丒下上上丝丑)
        {
            goto label_4;
        }
        
        val_9 = 1;
        goto label_5;
        label_3:
        val_9 = 0;
        val_7 = 0;
        val_8 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_5 = (val_9 != 0) ? (val_7) : 0;
        var val_6 = (val_9 != 0) ? (val_8) : 0;
        return new FortPointSpawnInfo() {};
    }
    private void 丏丑下丑且三业丄丄()
    {
        if(IsDead() != true)
        {
                if(三丏丟不丆丅丞不丛() != maxHealth)
        {
                this.丛东与丝丝丑丙丐业();
            return;
        }
        
        }
        
        if(IsDead() == false)
        {
                return;
        }
        
        this.丛东与丝丝丑丙丐业();
        this.世丟丄且丆丑东丛且();
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
        this.专丂世丞丁丁丌丕下();
        this.丟丁万上丌下丌万丈.丙上丆且万丏与丁丐();
    }
    protected override void 丅丙与东丏丂丑丄丆()
    {
        this.丅丙与东丏丂丑丄丆();
        this.东丁专丐三业上业且();
    }
    private void 世丟丄且丆丑东丛且()
    {
        float val_15;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                UnityEngine.Color val_6 = UnityEngine.Color.white;
            val_15 = val_6.r;
            且丕万丑下业丙丂丗().Show(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8360"), arg0:  UnityEngine.Mathf.RoundToInt(f:  this._addTimeForDestroyDoor)), 丂三丟丂丈丐丆丗丟:  4f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_15, g = val_6.g, b = val_6.b, a = val_6.a});
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                if(TimeGameController.丄丞丁丈与业上丞丟 != 0)
        {
                val_15 = this._addTimeForDestroyDoor;
            TimeGameController.丄丞丁丈与业上丞丟.丈丗丁丐丟三丄世下(丆丐七丅丆丗丛上与:  val_15);
        }
        
        }
        
        if(FortDefenceLinkController.丄丘七三上丕世丞业 != 0)
        {
                if(FortDefenceLinkController.丄丘七三上丕世丞业.damageDoor != 0)
        {
                丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::丛东与丝丝丑丙丐业()));
            不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortAttackController::世丟丄且丆丑东丛且()));
        }
        
        }
        
        ActivateScenario = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丐七丆丐丏丁东丅专(), 丏业丟一东丂东丘丛:  true);
        丐专三丁丘丈丘丝丅(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void FortAttackController::下丆专丞丛丗丒东丆(float 丅专与丒丈丗丒丘丌)));
        下丆专丞丛丗丒东丆(丅专与丒丈丗丒丘丌:  val_15);
    }
    internal static UnityEngine.Texture 丘丈世丗丞丒丞丒丁(FortAttackController.丙丑丁一丁万丑丞丑 丞丆丆专丆与丄不上)
    {
        var val_3;
        var val_4;
        val_3 = 丞丆丆专丆与丄不上;
        val_4 = 0;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return (UnityEngine.Texture)val_4;
        }
        
        val_3 = (long)val_3;
        UnityEngine.Texture[] val_2 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (((long)(int)(丞丆丆专丆与丄不上)) << 3);
        val_4 = mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((long)(int)(丞丆丆专丆与丄不上)) << 3) + 32];
        return (UnityEngine.Texture)val_4;
    }
    private void 丛东与丝丝丑丙丐业()
    {
        string val_14;
        string val_15;
        val_14 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                InGameGUIPart_FortAttack.__il2cppRuntimeField_byval_arg.丑丁丒上丂丛丏上东(世丁万下丗专世万丅:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丐七丆丐丏丁东丅专(), 丏业丟一东丂东丘丛:  true);
        }
        
        float val_14 = 三丏丟不丆丅丞不丛();
        float val_4 = maxHealth;
        val_14 = val_14 / val_4;
        val_4 = val_14 * 100f;
        if((val_14 == 0f) && (三丏丟不丆丅丞不丛() > 0f))
        {
                val_15 = "1 %";
        }
        else
        {
                val_15 = (int)val_4.ToString() + " %"(" %");
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                UnityEngine.Color val_11 = UnityEngine.Color.red;
            val_14 = mem[FortDefenceLinkController.丄丘七三上丕世丞业 + 192];
            val_14 = FortDefenceLinkController.丄丘七三上丕世丞业.icon_door;
            丐七丆丐丏丁东丅专().丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  val_14, 上丕丈丞丌丘丅不与:  val_15, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a}, 丘丏丑丁专上世丄不:  true, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8086"), 三世丏且丑下专丟丟:  val_14);
        }
        
        this.丁丟丗七丞丝且丙丑 = this.StartCoroutine(routine:  this.丅丅丌上七丗三下丆());
    }
    private System.Collections.IEnumerator 丅丅丌上七丗三下丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortAttackController.丙不三世专不不丈且();
    }
    private void 下丆专丞丛丗丒东丆(float 丅专与丒丈丗丒丘丌)
    {
        InGameGUI val_9;
        float val_9 = CurrentCapturePoint;
        val_9 = val_9 / typeof(AltarePoint).__il2cppRuntimeField_34;
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == 0)
        {
                return;
        }
        
        val_9 = 丐七丆丐丏丁东丅专();
        UnityEngine.Color val_8 = UnityEngine.Color.green;
        val_9.丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  val_9, 上丕丈丞丌丘丅不与:  (int)val_9 * 100f.ToString()((int)val_9 * 100f.ToString()) + " %"(" %"), 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a}, 丘丏丑丁专上世丄不:  true, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8087"), 三世丏且丑下专丟丟:  FortDefenceLinkController.丄丘七三上丕世丞业.icon_chest);
    }
    private void 专丂世丞丁丁丌丕下()
    {
        UnityEngine.Object val_17;
        var val_18;
        var val_19;
        val_17 = this.containerUI;
        if(val_17 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        bool val_3 = UnityEngine.Object.op_Equality(x:  val_17, y:  0);
        if(val_3 == true)
        {
                return;
        }
        
        val_3.containerUI.UpdateTeam(丞丌丁万不东丅丐丒:  true);
        val_17 = TankController.丄丘七三上丕世丞业;
        bool val_5 = UnityEngine.Object.op_Inequality(x:  val_17, y:  0);
        if(val_5 == false)
        {
                return;
        }
        
        val_5.containerUI.SetCheckpointCount(丌丒丝东丌下丕丁丅:  typeof(TrainPathController).__il2cppRuntimeField_28.Count);
        bool val_8 = IsMovingForward();
        if(val_8 != false)
        {
                val_19 = UnityEngine.Mathf.Min(a:  3, b:  TankController.丄丘七三上丕世丞业.AttackPlayersOnTram());
        }
        else
        {
                val_19 = 0;
        }
        
        SiegeContainerGUI val_11 = val_8.containerUI;
        val_11.SetTramMoveSpeed(三丑丏世丂丆丕丈专:  0, 一丆丆丈丁丝丆丑丄:  IsMovingBack());
        SiegeContainerGUI val_14 = val_11.containerUI;
        一上丕丞丙一丈七丛 val_15 = TankController.丄丘七三上丕世丞业.GetCheckpointsProgress();
        val_14.UpdateProgress(上丕丈丞丌丘丅不与:  new 一上丕丞丙一丈七丛() {丆丄丘七东世丒丐七 = val_15.丆丄丘七东世丒丐七, 上丕丈丞丌丘丅不与 = val_15.上丕丈丞丌丘丅不与});
        val_17 = val_14.containerUI;
        val_17.UpdateUI(一丁且丐丑专且一上:  false, 丕丛三丈丂丕专下东:  0, 七丝丁上丑万万丛丝:  0, 万丆丈丁与世丛下不:  new 一上丕丞丙一丈七丛() {上丕丈丞丌丘丅不与 = 0f});
    }
    private void 东丁专丐三业上业且()
    {
        var val_5;
        if(TankController.丄丘七三上丕世丞业.tankObject == 0)
        {
                return;
        }
        
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        UnityEngine.Texture[] val_4 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((FortAttackController.不丌丙丌丒丙三丕丙) << 3);
        this.世丞业丁业丆丈丘世().丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (FortAttackController.不丌丙丌丒丙三丕丙) << 3) + 32]);
        this.与丟世丂丏丈万丁上();
    }
    private void 丕七下丗专丈三丄丈(out WorldPosIndicationItem 丞丈且下且丙丞与丈, UnityEngine.Transform 丞下万上三丘上与专)
    {
        丞丈且下且丙丞与丈 = 0;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        WorldPosIndicationItem val_2 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem>();
        丞丈且下且丙丞与丈 = val_2;
        val_2.万三丗丆下万丅上丈(丞下万上三丘上与专:  丞下万上三丘上与专, 丒专丌万丄一丒万丏:  0f);
    }
    private void 与丟世丂丏丈万丁上()
    {
        WorldPosIndicationItem_RoyaleSquad[] val_31;
        var val_32;
        WorldPosIndicationItem_RoyaleSquad[] val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        UnityEngine.GameObject val_43;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        this.专丟丅丆丄与丙丅丌();
        val_31 = this.万丂丂七且一丏丕且;
        if(val_31 == null)
        {
            goto label_7;
        }
        
        val_32 = 0;
        if(val_31 != null)
        {
            goto label_29;
        }
        
        goto label_9;
        label_7:
        WorldPosIndicationItem_RoyaleSquad[] val_3 = new WorldPosIndicationItem_RoyaleSquad[5];
        val_33 = val_3;
        val_34 = 0;
        this.万丂丂七且一丏丕且 = val_33;
        goto label_10;
        label_18:
        WorldPosIndicationItem_RoyaleSquad val_4 = val_3.下东丘东丟上七业丁();
        if(this.万丂丂七且一丏丕且 == null)
        {
            goto label_11;
        }
        
        if(val_4 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_4 == null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        this.万丂丂七且一丏丕且[0] = val_4;
        val_33 = this.万丂丂七且一丏丕且;
        val_34 = 1;
        label_10:
        if(val_34 < this.万丂丂七且一丏丕且.Length)
        {
            goto label_18;
        }
        
        val_32 = 0;
        goto label_19;
        label_30:
        bool val_5 = UnityEngine.Object.op_Equality(x:  this.万丂丂七且一丏丕且[0], y:  0);
        if(val_5 != false)
        {
                this.万丂丂七且一丏丕且[0] = val_5.下东丘东丟上七业丁();
        }
        
        val_32 = 1;
        label_19:
        val_31 = this.万丂丂七且一丏丕且;
        if(val_31 != null)
        {
            goto label_29;
        }
        
        label_9:
        label_29:
        if(val_32 < this.万丂丂七且一丏丕且.Length)
        {
            goto label_30;
        }
        
        val_35 = 0;
        goto label_31;
        label_38:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.万丂丂七且一丏丕且[0].gameObject, 丏业丟一东丂东丘丛:  false);
        val_35 = 1;
        label_31:
        if(val_35 < this.万丂丂七且一丏丕且.Length)
        {
            goto label_38;
        }
        
        val_36 = null;
        val_36 = null;
        val_37 = 0;
        goto label_41;
        label_111:
        if(Item[0] != 0)
        {
                NetworkStartTable val_10 = Item[0];
            if(val_10.丌丑丛业丈丘世丞丕 != 0)
        {
                val_38 = null;
            val_38 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_39 = null;
            val_39 = null;
            NetworkStartTable val_13 = Item[0];
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != val_13.丌丑丛业丈丘世丞丕)
        {
                NetworkStartTable val_15 = Item[0];
            if(val_15.丌丑丛业丈丘世丞丕.东丑丌丄丝世丞丘三 != false)
        {
                val_40 = null;
            WorldPosIndicationItem_RoyaleSquad val_33 = this.万丂丂七且一丏丕且[0];
            val_40 = null;
            var val_34 = 0;
            val_34 = val_34 + 1;
            if(丆丗丂三丐不东且丏() != true)
        {
                val_41 = null;
            val_41 = null;
            val_42 = null;
            val_42 = null;
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
        {
                BankController val_18 = BankController.丑七不且上丗丁一世();
            if(val_18.uiRoot.gameObject.activeInHierarchy != true)
        {
                NetworkStartTable val_21 = Item[0];
            if(val_21.丌丑丛业丈丘世丞丕.丐下丘丟丁丆丟丆丈() > 0f)
        {
                val_43 = val_33.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_43, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Vector3 val_24 = val_21.丌丑丛业丈丘世丞丕.myPlayerTransform.position;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  1f);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_33.丝东不丄且不丏业丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            float val_28 = val_21.丌丑丛业丈丘世丞丕.丐下丘丟丁丆丟丆丈();
            float val_29 = val_21.丌丑丛业丈丘世丞丕.丆丛不丄丂下且不丏();
            if(val_33 != null)
        {
                val_29 = val_28 / val_29;
            val_33.丝与丑与丘丝专与且(丛丁三世世丆七不业:  val_29);
        }
        else
        {
                val_29 = val_28 / val_29;
            0.丝与丑与丘丝专与且(丛丁三世世丆七不业:  val_29);
        }
        
            val_33.上丄丐丅三丄三丈丘(丛与丙丒丒下丌丟且:  false);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        val_37 = 1;
        label_41:
        if(val_37 < Count)
        {
            goto label_111;
        }
    
    }
    private WorldPosIndicationItem_RoyaleSquad 下东丘东丟上七业丁()
    {
        WorldPosIndicationItem_RoyaleSquad val_1 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_RoyaleSquad>();
        if(val_1 != null)
        {
                val_1.丗东丕且上丏业丝世(丛与丙丒丒下丌丟且:  true);
        }
        else
        {
                val_1.丗东丕且上丏业丝世(丛与丙丒丒下丌丟且:  true);
        }
        
        mem2[0] = 1;
        return val_1;
    }
    private void 专丟丅丆丄与丙丅丌()
    {
        var val_19;
        var val_20;
        var val_21;
        TankController val_22;
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(TankController.丄丘七三上丕世丞业.不丝丁丞万丈丆丏万() != false)
        {
                if(this.丄丕世丏丗丛丈七与 != 0)
        {
                this.丄丕世丏丗丛丈七与.gameObject.SetActive(value:  false);
        }
        
            丝丞丏丌丐丂丛专丒();
            return;
        }
        
        if(this.丄丕世丏丗丛丈七与 == 0)
        {
                this.丄丕世丏丗丛丈七与 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_TankHealth>();
            mem2[0] = 1;
            this.丄丕世丏丗丛丈七与.万三丗丆下万丅上丈(丞下万上三丘上与专:  TankObject.__il2cppRuntimeField_interfaceOffsets, 丒专丌万丄一丒万丏:  0f);
        }
        
        val_21 = null;
        float val_19 = maxHealth;
        val_21 = null;
        UnityEngine.Vector3 val_10 = 丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_11 = position;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丄丕世丏丗丛丈七与, 丏业丟一东丂东丘丛:  ((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) > 4f) ? 1 : 0);
        val_19 = typeof(TankDamageable).__il2cppRuntimeField_28 / val_19;
        val_22 = TankController.丄丘七三上丕世丞业;
        if(val_22 != null)
        {
                var val_14 = (TankController.丄丘七三上丕世丞业.丄丁丝丛丒专且丝丛 > 0f) ? 1 : 0;
        }
        else
        {
                val_22 = TankController.丄丘七三上丕世丞业;
        }
        
        this.丄丈万丏丛七七丙丗(丌三一专与一丕丗丗:  val_19, 一丞丗丘专业丘丁丝:  (typeof(TankDamageable).__il2cppRuntimeField_2C != 0) ? 1 : 0, 业丌专不世专丁丒丆:  (TankController.丄丘七三上丕世丞业.丄丁丝丛丒专且丝丛 > 0f) ? 1 : 0, 丟业世丁世丞世三丙:  val_22.丕丏丛丗丕下丆且丑());
    }
    private void 上丝业丏三丐丙丂丏()
    {
        UnityEngine.Color val_1 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortAttack_blue");
        this.丐丈世丈丄万下丈丟 = val_1;
        mem[1152921537527330068] = val_1.g;
        mem[1152921537527330072] = val_1.b;
        mem[1152921537527330076] = val_1.a;
        UnityEngine.Color val_2 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortAttack_damaged_15");
        this.丂东丈下丏东丁丟万 = val_2;
        mem[1152921537527330084] = val_2.g;
        mem[1152921537527330088] = val_2.b;
        mem[1152921537527330092] = val_2.a;
        UnityEngine.Color val_3 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortAttack_damaged_50");
        this.丁东丟丝丌东丁丁丄 = val_3;
        mem[1152921537527330100] = val_3.g;
        mem[1152921537527330104] = val_3.b;
        mem[1152921537527330108] = val_3.a;
        UnityEngine.Color val_4 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortAttack_green");
        this.丌丗丄丄丙丄丈且丙 = val_4;
        mem[1152921537527330116] = val_4.g;
        mem[1152921537527330120] = val_4.b;
        mem[1152921537527330124] = val_4.a;
        UnityEngine.Color val_5 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortAttack_grey");
        this.不丅丆与丟丘丈丗东 = val_5;
        mem[1152921537527330132] = val_5.g;
        mem[1152921537527330136] = val_5.b;
        mem[1152921537527330140] = val_5.a;
        UnityEngine.Color val_6 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortAttack_repair");
        this.丟且一专丂上丝七丐 = val_6;
        mem[1152921537527330148] = val_6.g;
        mem[1152921537527330152] = val_6.b;
        mem[1152921537527330156] = val_6.a;
    }
    internal void 丄丈万丏丛七七丙丗(float 丌三一专与一丕丗丗, bool 一丞丗丘专业丘丁丝, bool 业丌专不世专丁丒丆, bool 丟业世丁世丞世三丙)
    {
        WorldPosIndicationItem_TankHealth val_1;
        float val_2;
        WorldPosIndicationItem_TankHealth val_4;
        float val_5;
        UnityEngine.Color val_6;
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.Color val_11;
        val_1 = 丟业世丁世丞世三丙;
        val_2 = 丌三一专与一丕丗丗;
        if(一丞丗丘专业丘丁丝 == false)
        {
            goto label_1;
        }
        
        if(业丌专不世专丁丒丆 == false)
        {
            goto label_2;
        }
        
        this.丄丕世丏丗丛丈七与.七丂丛丛丒丛一丟丟(丟且三三丅专丛丁丟:  new UnityEngine.Color() {r = this.丟且一专丂上丝七丐, g = V9.16B, b = V10.16B, a = V11.16B}, 丑丅丛丒世万丘七丄:  new UnityEngine.Color() {r = this.丟且一专丂上丝七丐, g = V9.16B, b = V10.16B, a = V11.16B}, 一丞丗丘专业丘丁丝:  true, 业丌专不世专丁丒丆:  true);
        val_1 = 1152921505327452160;
        SetRadiusIndicatorColor(丌七东世丟丒世丌丆:  new UnityEngine.Color() {r = this.丟且一专丂上丝七丐, g = V9.16B, b = V10.16B, a = V11.16B});
        val_4 = this.丄丕世丏丗丛丈七与;
        val_5 = mem[TankController.丄丘七三上丕世丞业 + 80];
        val_5 = TankController.丄丘七三上丕世丞业.丄丁丝丛丒专且丝丛;
        if(val_4 != null)
        {
            goto label_24;
        }
        
        goto label_8;
        label_1:
        if(val_1 == false)
        {
            goto label_10;
        }
        
        val_6 = this.丐丈世丈丄万下丈丟;
        val_7 = 1152921537527462548;
        val_8 = 1152921537527462552;
        val_9 = 1152921537527462556;
        goto label_11;
        label_2:
        this.丄丕世丏丗丛丈七与.七丂丛丛丒丛一丟丟(丟且三三丅专丛丁丟:  new UnityEngine.Color() {r = this.丂东丈下丏东丁丟万, g = V9.16B, b = V10.16B, a = V11.16B}, 丑丅丛丒世万丘七丄:  new UnityEngine.Color() {r = this.丂东丈下丏东丁丟万, g = V9.16B, b = V10.16B, a = V11.16B}, 一丞丗丘专业丘丁丝:  true, 业丌专不世专丁丒丆:  false);
        val_5 = this.丂东丈下丏东丁丟万;
        SetRadiusIndicatorColor(丌七东世丟丒世丌丆:  new UnityEngine.Color() {r = val_5, g = V9.16B, b = V10.16B, a = V11.16B});
        val_4 = this.丄丕世丏丗丛丈七与;
        if(val_4 != null)
        {
            goto label_16;
        }
        
        goto label_16;
        label_10:
        val_6 = this.不丅丆与丟丘丈丗东;
        val_7 = 1152921537527462612;
        val_8 = 1152921537527462616;
        val_9 = 1152921537527462620;
        label_11:
        SetRadiusIndicatorColor(丌七东世丟丒世丌丆:  new UnityEngine.Color() {r = this.不丅丆与丟丘丈丗东.r, g = 5.624299E-18f, b = 5.624299E-18f, a = 5.624299E-18f});
        if(val_2 <= 0.5f)
        {
            goto label_18;
        }
        
        val_1 = this.丄丕世丏丗丛丈七与;
        if(this.丄丕世丏丗丛丈七与 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_18:
        val_1 = this.丄丕世丏丗丛丈七与;
        if(val_2 > 0.15f)
        {
                val_11 = this.丁东丟丝丌东丁丁丄;
        }
        else
        {
                val_11 = this.丂东丈下丏东丁丟万;
        }
        
        val_2 = this.丐丈世丈丄万下丈丟;
        label_20:
        this.丄丕世丏丗丛丈七与.七丂丛丛丒丛一丟丟(丟且三三丅专丛丁丟:  new UnityEngine.Color() {r = val_11, g = 5.624299E-18f, b = 5.624299E-18f, a = this.不丅丆与丟丘丈丗东.r}, 丑丅丛丒世万丘七丄:  new UnityEngine.Color() {r = val_2, g = V13.16B, b = V14.16B, a = V15.16B}, 一丞丗丘专业丘丁丝:  false, 业丌专不世专丁丒丆:  false);
        val_5 = val_2;
        val_4 = mem[this.丄丕世丏丗丛丈七与];
        if(val_4 != 0)
        {
            goto label_24;
        }
        
        label_8:
        label_24:
        label_16:
        val_4.丄一丗丟丅世丝下丏(丙业与丙丗丝不丈东:  val_5);
    }
    internal override bool 丄一下丒七丝与与万()
    {
        var val_5 = null;
        object val_3 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丞丏丝与丙丁丛与];
        return (bool)(null == 1) ? 1 : 0;
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        System.TimeSpan val_1 = X21.Elapsed;
        System.TimeSpan val_3 = X21.Elapsed;
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丈东丄丌丅丝不丂丘(丂丌丙丝且东丗丙万:  X21.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 与丛下丐丆丞万万下:  X23 + 118, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
    }
    internal override bool 世七丌丟丞且丛七且()
    {
        null = null;
        return (bool)(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count > 0) ? 1 : 0;
    }
    public FortAttackController()
    {
        this.丟丁万上丌下丌万丈 = new 丝专专丛三丅丐丛丄();
        this.不丆丌丁丌丁丞且与 = new 丕下丞上上丂丕丟不(丑丞丘丛丂丗不万东:  new 丅世一丈七丆业丝丘[4]);
        this.丞万世上丝丌丘丘丄 = new 丕下丞上上丂丕丟不(丑丞丘丛丂丗不万东:  new 丅世一丈七丆业丝丘[4]);
        this.业丌专丁上丁丛世丗 = 0;
        this.丞上丘丐丑不业世丏 = 15f;
        this.三下专与丌且丌与专 = 15f;
        this._addTimeForDestroyDoor = 30f;
    }
    private static FortAttackController()
    {
        FortAttackController.一下专东丒业与丅且 = 0;
        FortAttackController.三丛七丑丛专丅丕丕 = 1;
        FortAttackController.不丌丙丌丒丙三丕丙 = 3;
    }

}
