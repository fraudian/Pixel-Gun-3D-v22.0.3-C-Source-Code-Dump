using UnityEngine;
public class ClanTankBuildController : PGBehaviour
{
    // Fields
    internal static ClanTankBuildController 丄丘七三上丕世丞业;
    private static System.Action<int> 上丄丐丞丄与下丄丆;
    private bool 丘七丒丕东下丐丞丑;
    private System.Action 上丌丑丆丞丛丘丞丗;
    internal ClanTankPlaceableItemPoint 丛且与一丟不且丆世;
    internal System.Collections.Generic.Dictionary<ClanTankPlaceableItemPoint, PlaceableItemSettings> 与且丘东丒一上业东;
    private Rilisoft.丝丑丂丛万丐丈丘且 上丝东丈丂丐丌丅与;
    internal static float 丝丅专丅丙丑丝三丒;
    
    // Properties
    private static string 丛业丐丈三丏丘世丆 { get; }
    internal 世专丙丟且丗丄丆丌 下丁下丌丟丒世丙丕 { get; }
    internal int 丌世丙七丒丑与丝丗 { get; set; }
    internal int 世东丂丈七丐丐一丁 { get; set; }
    internal int 丙世丈丏丝丄七业丙 { get; }
    
    // Methods
    private static string 三丄丈丞一专丝丛丛()
    {
        return "clan.tank-"("clan.tank-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
    }
    internal static void 且丌三业上丌丌七丟(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ClanTankBuildController.上丄丐丞丄与下丄丆, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ClanTankBuildController.上丄丐丞丄与下丄丆 != 1152921505163452424);
    
    }
    internal static void 业丞丕业一七丅丅丒(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ClanTankBuildController.上丄丐丞丄与下丄丆, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ClanTankBuildController.上丄丐丞丄与下丄丆 != 1152921505163452424);
    
    }
    internal void 业万丟丄且丒下上一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上丌丑丆丞丛丘丞丗, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丌丑丆丞丛丘丞丗 != 1152921536934008176);
    
    }
    internal void 丄丆丝丁丒不丐丟丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上丌丑丆丞丛丘丞丗, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丌丑丆丞丛丘丞丗 != 1152921536934144752);
    
    }
    internal 世专丙丟且丗丄丆丌 丒丑丛世丘业丗丑丛()
    {
        return 丂丘丗丗与且丌丁丙.丗专丕丌下专东丅丈();
    }
    internal int 一丁丐专丗七丁与丌()
    {
        RootBuildingLevelData val_2 = this.丒丑丛世丘业丗丑丛().丞丘丕丈丄丛且丝东();
    }
    internal void 丘世丟丟三丒丒且专(int 丙业与丙丗丝不丈东)
    {
    
    }
    internal int 丑丐且且丙丙丒专七()
    {
    
    }
    internal void 业丁一业丐丐与专丕(int 丙业与丙丗丝不丈东)
    {
        int val_3 = UnityEngine.Mathf.Clamp(value:  丙业与丙丗丝不丈东, min:  0, max:  Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙().一丁丐专丗七丁与丌());
        this.上丝东丈丂丐丌丅与 = 0;
        mem[1152921536934733456] = 0;
    }
    internal int 丄丛丁丕世丞丞三三()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = this.上丝东丈丂丐丌丅与;
        val_2 = this.一丁丐专丗七丁与丌() - val_2;
        return (int)val_2;
    }
    private void Awake()
    {
        null = null;
        ClanTankBuildController.丄丘七三上丕世丞业 = this;
        System.Action val_1 = new System.Action(object:  this, method:  System.Void ClanTankBuildController::不业丛丑丝丘东丘丅());
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  val_1);
        val_1.丒丑丛世丘业丗丑丛().丂丆丒丟七丐丒丘上(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanTankBuildController::上丗丏丒万丏丑丄万(int 丈丘丝一丗下丈丐不)));
    }
    private void Start()
    {
        this.Load();
        this.丘七丒丕东下丐丞丑 = true;
    }
    private void OnDestroy()
    {
        System.Action val_1 = new System.Action(object:  this, method:  System.Void ClanTankBuildController::不业丛丑丝丘东丘丅());
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  val_1);
        val_1.丒丑丛世丘业丗丑丛().丛丝万丕丆丘一下与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanTankBuildController::上丗丏丒万丏丑丄万(int 丈丘丝一丗下丈丐不)));
    }
    private void 上丗丏丒万丏丑丄万(int 丈丘丝一丗下丈丐不)
    {
        null = null;
        if(ClanTankBuildController.上丄丐丞丄与下丄丆 == null)
        {
                return;
        }
        
        ClanTankBuildController.上丄丐丞丄与下丄丆.Invoke(obj:  丈丘丝一丗下丈丐不);
    }
    internal bool 丄丄东丐丒丄丗丄且(PlaceableItemSettings 业世丟丐丘丐专与不, ClanTankPlaceableItemPoint 丌丐下丆七丒丒丑丕)
    {
        UnityEngine.Object val_4;
        object val_5;
        var val_6;
        val_4 = 丌丐下丆七丒丒丑丕;
        if(val_4 == 0)
        {
                val_4 = mem[ClanTankBuildBase.instance + 80];
            val_4 = ClanTankBuildBase.instance.selectedItemPoint;
        }
        
        if(val_4 != 0)
        {
            goto label_7;
        }
        
        val_5 = "itemPoint == null";
        goto label_10;
        label_7:
        if((IL2CPP_Property{name:与丆与丂丄丞丒丏丑, type: System.Boolean, class: System.Boolean}) == 0)
        {
            goto label_12;
        }
        
        bool val_3 = this.与且丘东丒一上业东.ContainsKey(key:  val_4);
        if(this.与且丘东丒一上业东 == null)
        {
            goto label_14;
        }
        
        if(val_3 == false)
        {
            goto label_15;
        }
        
        label_20:
        this.与且丘东丒一上业东.set_Item(key:  val_4, value:  业世丟丐丘丐专与不);
        goto label_16;
        label_12:
        val_5 = "itemPoint is inactive!";
        label_10:
        UnityEngine.Debug.LogError(message:  val_5);
        val_6 = 0;
        return (bool)val_6;
        label_14:
        if(val_3 == true)
        {
            goto label_20;
        }
        
        label_15:
        this.与且丘东丒一上业东.Add(key:  val_4, value:  业世丟丐丘丐专与不);
        label_16:
        this.丘下上丝丅丄丆丏东();
        val_6 = 1;
        return (bool)val_6;
    }
    internal bool 世丆万丟不丗丝丂丕(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        ClanTankPlaceableItemPoint val_5;
        var val_6;
        val_5 = mem[ClanTankBuildBase.instance + 80];
        val_5 = ClanTankBuildBase.instance.selectedItemPoint;
        if(val_5 != 0)
        {
                val_5 = this.与且丘东丒一上业东;
            if((val_5.ContainsKey(key:  ClanTankBuildBase.instance.selectedItemPoint)) != false)
        {
                val_5 = mem[ClanTankBuildBase.instance + 80];
            val_5 = ClanTankBuildBase.instance.selectedItemPoint;
            var val_4 = (this.与且丘东丒一上业东.Item[val_5] == 业世丟丐丘丐专与不) ? 1 : 0;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    internal bool 丐丒丒丏丈丄丘丑丘(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        var val_3;
        if((this.世丆万丟不丗丝丂丕(业世丟丐丘丐专与不:  业世丟丐丘丐专与不)) != false)
        {
                bool val_2 = this.与且丘东丒一上业东.Remove(key:  ClanTankBuildBase.instance.selectedItemPoint);
            this.丘下上丝丅丄丆丏东();
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    internal void 丘下上丝丅丄丆丏东()
    {
        var val_5;
        var val_6;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_10:
        if(((-2030697160) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_5 = public System.Boolean System.Collections.Generic.Dictionary<ClanTankPlaceableItemPoint, PlaceableItemSettings>::ContainsKey(ClanTankPlaceableItemPoint key);
        if((this.与且丘东丒一上业东.ContainsKey(key:  val_2)) == false)
        {
            goto label_5;
        }
        
        val_5 = public PlaceableItemSettings System.Collections.Generic.Dictionary<ClanTankPlaceableItemPoint, PlaceableItemSettings>::get_Item(ClanTankPlaceableItemPoint key);
        val_6 = this.与且丘东丒一上业东.Item[val_2];
        if(val_2 != null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_5:
        val_6 = 0;
        if(val_2 != null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丕丂丂丙三丕丒上丄();
        if(this.上丌丑丆丞丛丘丞丗 == null)
        {
                return;
        }
        
        this.上丌丑丆丞丛丘丞丗.Invoke();
    }
    private void 丕丂丂丙三丕丒上丄()
    {
        var val_6;
        var val_13;
        var val_14;
        float val_15;
        val_13 = this;
        this.业丁一业丐丐与专丕(丙业与丙丗丝不丈东:  this.一丁丐专丗七丁与丌());
        System.Collections.Generic.Dictionary<PlaceableItemSettings, System.Single> val_2 = new System.Collections.Generic.Dictionary<PlaceableItemSettings, System.Single>();
        Dictionary.Enumerator<TKey, TValue> val_3 = this.与且丘东丒一上业东.GetEnumerator();
        label_13:
        if(((-2030556544) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        if((val_2.ContainsKey(key:  val_7._value._obj)) != false)
        {
                float val_10 = val_2.Item[val_7._value._obj];
            val_14 = null;
            val_14 = null;
            val_10 = val_10 * ClanTankBuildController.丝丅专丅丙丑丝三丒;
            val_2.set_Item(key:  val_7._value._obj, value:  val_10);
            val_15 = val_2.Item[val_7._value._obj];
        }
        else
        {
                val_15 = (float)val_7._value._obj.Energy;
            val_2.Add(key:  val_7._value._obj, value:  val_15);
        }
        
        this.业丁一业丐丐与专丕(丙业与丙丗丝不丈东:  this.上丝东丈丂丐丌丅与 - (int)val_15);
        goto label_13;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static void 丘丐丗丌丆丏世一不(System.Collections.Generic.List<ClanTankEquipInfo> 一丐丗丁丞丆丅丟丄)
    {
        var val_4;
        var val_29;
        System.Collections.Generic.List<PGCompany.一不丆三丛与上上下> val_1 = new System.Collections.Generic.List<PGCompany.一不丆三丛与上上下>();
        List.Enumerator<T> val_2 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
        label_17:
        if(((-2030358496) & 1) == 0)
        {
            goto label_2;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_8 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  X22).丝丆丂丆不丟丌丕丝().丑丐丙丄丅世世丑丒();
        new PGCompany.一不丆三丛与上上下() = new PGCompany.一不丆三丛与上上下();
        new PGCompany.一不丆三丛与上上下().丗丘万丛与万丘丗下(丙业与丙丗丝不丈东:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁());
        new PGCompany.一不丆三丛与上上下().东三七丟一不丑东丕(丙业与丙丗丝不丈东:  val_8.业东丅东丌上丗丑不());
        new PGCompany.一不丆三丛与上上下().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_8.丂丁丏一丙丛业且丌());
        new PGCompany.一不丆三丛与上上下().东丒万业丌丂丌且丕(丙业与丙丗丝不丈东:  val_4.丐丏七丌丕丗业且上());
        val_1.Add(item:  new PGCompany.一不丆三丛与上上下());
        goto label_17;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_29 = 1152921524404748272;
        List.Enumerator<T> val_15 = val_1.GetEnumerator();
        label_51:
        if(((-2030358528) & 1) == 0)
        {
            goto label_39;
        }
        
        string val_16 = val_4.丐丏七丌丕丗业且上();
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_16.业东丅东丌上丗丑不());
        new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_16.丂丁丏一丙丛业且丌());
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丐丌与丏丂东业业上().丁上丟上不丘七不万(下丅丙一丂丗丅丝七:  new PGCompany.三东丏不丗世丅丌丄());
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_16.业东丅东丌上丗丑不());
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丐丌与丏丂东业业上().丝世世丙业丅丅东三(下丅丙一丂丗丅丝七:  new PGCompany.三东丏不丗世丅丌丄(), 丈丘丝一丗下丈丐不:  val_16.丈一下下丞世三丑丄());
        goto label_51;
        label_39:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        ClanTankBuildController.东丆七丘丆丘业下丘(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
    }
    internal static void 东丆七丘丆丘业下丘(System.Collections.Generic.List<ClanTankEquipInfo> 一丐丗丁丞丆丅丟丄)
    {
        string val_23;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        val_23 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((Rilisoft.Singleton<ClansController>.Instance.丞一不下一丁丞东一(丄丒且丙三丆丟与丏:  val_23, 丕万丐东与一丈万与:  0)) == true)
        {
                return;
        }
        
        val_23 = 1152921505163448320;
        if((ClanTankBuildController.丅万丛丒与丒丙丝丒(丐丕丆丟丗丑三丙业:  一丐丗丁丞丆丅丟丄, 丁丅丞丆丏丂业丁丆:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丒丗不丙业丟丄丏丂())) != false)
        {
                return;
        }
        
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丒丗不丙业丟丄丏丂().Clear();
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丒丗不丙业丟丄丏丂().AddRange(collection:  一丐丗丁丞丆丅丟丄);
        ClanTankBuildController.丞丆业专丈一丒丙丁(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丘且丘七丈丗丘七().东丝丗丟丘丟丝丞丏(且丟丅丄丒丑丂丁世:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟(), 丝丝丗丒且丂丆万丗:  一丐丗丁丞丆丅丟丄, 丑专上世丁丁丌丂下:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丒三丕不七丁丅丈());
    }
    internal static void 丞丆业专丈一丒丙丁(System.Collections.Generic.List<ClanTankEquipInfo> 一丐丗丁丞丆丅丟丄)
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ClanTankBuildController.三丄丈丞一专丝丛丛(), 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄));
    }
    internal static System.Collections.Generic.List<ClanTankEquipInfo> 丅丁七丐丕丆七丐上()
    {
        var val_8;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                val_8 = System.Linq.Enumerable.ToList<ClanTankEquipInfo>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丒丗不丙业丟丄丏丂());
            return (System.Collections.Generic.List<ClanTankEquipInfo>)val_8;
        }
        
        System.Collections.Generic.List<ClanTankEquipInfo> val_7 = null;
        val_8 = val_7;
        val_7 = new System.Collections.Generic.List<ClanTankEquipInfo>();
        return (System.Collections.Generic.List<ClanTankEquipInfo>)val_8;
    }
    internal static System.Collections.Generic.List<ClanTankEquipInfo> 丕万七丏七丈三丟丆()
    {
        var val_7;
        string val_2 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  ClanTankBuildController.三丄丈丞一专丝丛丛(), 丞丌丑丛上丕丙丕下:  "[]");
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_7 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(val_7 != null)
        {
                return (System.Collections.Generic.List<ClanTankEquipInfo>)val_7;
        }
        
        System.Collections.Generic.List<ClanTankEquipInfo> val_5 = null;
        val_7 = val_5;
        val_5 = new System.Collections.Generic.List<ClanTankEquipInfo>();
        return (System.Collections.Generic.List<ClanTankEquipInfo>)val_7;
    }
    internal void 丂且不业丂专丛丆东()
    {
        var val_5;
        System.Collections.Generic.List<ClanTankEquipInfo> val_1 = new System.Collections.Generic.List<ClanTankEquipInfo>();
        Dictionary.Enumerator<TKey, TValue> val_2 = this.与且丘东丒一上业东.GetEnumerator();
        label_9:
        if(((-2029418576) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if(val_6._value._obj == 0)
        {
            goto label_9;
        }
        
        string val_7 = val_6._value._obj.丐丏七丌丕丗业且上();
        new ClanTankEquipInfo() = new ClanTankEquipInfo(下丁丒丕丅丄丂丛丅:  W21, 与下丕三丒东上丗上:  ???);
        .ServerLevel = val_6._value._obj.Upgrade;
        val_1.Add(item:  new ClanTankEquipInfo());
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        ClanTankBuildController.东丆七丘丆丘业下丘(一丐丗丁丞丆丅丟丄:  val_1);
    }
    internal void Load()
    {
        this.与且丘东丒一上业东.Clear();
        System.Collections.Generic.List<ClanTankEquipInfo> val_1 = ClanTankBuildController.丅丁七丐丕丆七丐上();
        if((val_1 != null) && (val_1.Count >= 1))
        {
                var val_11 = 0;
            do
        {
            ClanTankEquipInfo val_3 = val_1.Item[0];
            ClanTankPlaceableItemPoint val_4 = ClanTankBuildBase.instance.GetPlaceablePointById(世丟丄丅丛世丝丑丕:  val_3.placeId);
            ClanTankEquipInfo val_5 = val_1.Item[0];
            PlaceableItemSettings val_6 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_5.itemSettingsId);
            ClanTankEquipInfo val_7 = val_1.Item[0];
            bool val_8 = System.String.IsNullOrEmpty(value:  val_7.itemSettingsId);
            if((val_6 != null) && (val_4 != 0))
        {
                this.与且丘东丒一上业东.Add(key:  val_4, value:  val_6);
        }
        
            val_11 = val_11 + 1;
        }
        while(val_11 < val_1.Count);
        
        }
        
        this.丘下上丝丅丄丆丏东();
    }
    internal PlaceableItemSettings 下世丗丂丐丐丑专丞(ClanTankPlaceableItemPoint 丅专与丒丈丗丒丘丌)
    {
        var val_3;
        if((this.与且丘东丒一上业东.ContainsKey(key:  丅专与丒丈丗丒丘丌)) != false)
        {
                PlaceableItemSettings val_2 = this.与且丘东丒一上业东.Item[丅专与丒丈丗丒丘丌];
            return (PlaceableItemSettings)val_3;
        }
        
        val_3 = 0;
        return (PlaceableItemSettings)val_3;
    }
    internal int 丆丙丟丒丞丐丅七一(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        var val_4;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.与且丘东丒一上业东.GetEnumerator();
        val_4 = 0;
        goto label_2;
        label_3:
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        label_2:
        if(((-2028942248) & 1) != 0)
        {
            goto label_3;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)((-2028942264) == 业世丟丐丘丐专与不) ? (val_4 + 1) : (val_4);
    }
    internal void 七世东丝一丗丝丌丂()
    {
        ClanTankBuildController.丞丆业专丈一丒丙丁(一丐丗丁丞丆丅丟丄:  0);
        this.Load();
    }
    private void 不业丛丑丝丘东丘丅()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "Menu_Custom")) != true)
        {
                if(this.丘七丒丕东下丐丞丑 == false)
        {
                return;
        }
        
            this.丘七丒丕东下丐丞丑 = false;
        }
        
        this.Load();
    }
    internal static bool 丅万丛丒与丒丙丝丒(System.Collections.Generic.IEnumerable<ClanTankEquipInfo> 丐丕丆丟丗丑三丙业, System.Collections.Generic.IEnumerable<ClanTankEquipInfo> 丁丅丞丆丏丂业丁丆)
    {
        return 丞东丑专丛丆丄丝世.丂丆世世丕丅丕丅上<ClanTankEquipInfo>(丏丆丑丗七丄丙丝与:  丐丕丆丟丗丑三丙业, 丒丈丙丐丏丕丆万丗:  丁丅丞丆丏丂业丁丆, 丈丕丛与丏丏不丆七:  new 丛丂世丟丘丏万丛业());
    }
    internal int 丞东丆丝丞下丆世丆(PlaceableItemSettings 与不丕丆丈不丙丟丛)
    {
        return (int)(int)(float)ClanTankBuildController.丙东丙丕下丌万丘丂(与不丕丆丈不丙丟丛:  与不丕丆丈不丙丟丛, 丌丒丝东丌下丕丁丅:  this.丆丙丟丒丞丐丅七一(业世丟丐丘丐专与不:  与不丕丆丈不丙丟丛));
    }
    internal int 世丗丄丄丛丕业丕丅(PlaceableItemSettings 与不丕丆丈不丙丟丛)
    {
        PlaceableItemSettings val_3 = 与不丕丆丈不丙丟丛;
        val_3 = (this.丆丙丟丒丞丐丅七一(业世丟丐丘丐专与不:  val_3)) - 1;
        return (int)(int)(float)ClanTankBuildController.丙东丙丕下丌万丘丂(与不丕丆丈不丙丟丛:  与不丕丆丈不丙丟丛, 丌丒丝东丌下丕丁丅:  val_3);
    }
    internal static int 丙东丙丕下丌万丘丂(PlaceableItemSettings 与不丕丆丈不丙丟丛, int 丌丒丝东丌下丕丁丅)
    {
        float val_2 = ClanTankBuildController.上上丗丗丏丞万丁丞(与不丕丆丈不丙丟丛:  null, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
        val_2 = val_2 * (float)与不丕丆丈不丙丟丛.Energy;
        return (int)(int)val_2;
    }
    internal static float 上上丗丗丏丞万丁丞(PlaceableItemSettings 与不丕丆丈不丙丟丛, int 丌丒丝东丌下丕丁丅)
    {
        null = null;
    }
    internal void 丅丑丒丟丆丛丁三东()
    {
        this.丘下上丝丅丄丆丏东();
    }
    public ClanTankBuildController()
    {
        this.与且丘东丒一上业东 = new System.Collections.Generic.Dictionary<ClanTankPlaceableItemPoint, PlaceableItemSettings>();
    }
    private static ClanTankBuildController()
    {
        ClanTankBuildController.丝丅专丅丙丑丝三丒 = 2f;
    }

}
