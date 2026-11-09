using UnityEngine;
internal sealed class ClansTutorialController : PGBehaviour
{
    // Fields
    private static ClansTutorialController 丝业丆丁业三丈丟东;
    private System.Collections.Generic.Dictionary<ClansTutorialController.丙且丌业世万丂丝上, System.Action<UnityEngine.Transform>> 丏丗三丆丛丏与丝丙;
    private System.Collections.Generic.Dictionary<ClansTutorialController.丙且丌业世万丂丝上, Progress.不专丂万丐丄七上丗> 业丘一东丄丄七三与;
    private System.Collections.Generic.Dictionary<ClansTutorialController.丙且丌业世万丂丝上, Progress.与丄东丄丘丐丙丅业> 业万七万丈一丅业丂;
    private System.Collections.Generic.Dictionary<ClansTutorialController.丙且丌业世万丂丝上, string> 丘丒东丛万一丄丙丙;
    private System.Collections.Generic.Dictionary<ClansTutorialController.丙且丌业世万丂丝上, ClansTutorilStap> 下与丙丙万上丂丙丗;
    
    // Properties
    public static ClansTutorialController 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    public static ClansTutorialController get_Instance()
    {
        ClansTutorialController val_3 = ClansTutorialController.丝业丆丁业三丈丟东;
        if(val_3 != 0)
        {
                return (ClansTutorialController)ClansTutorialController.丝业丆丁业三丈丟东;
        }
        
        ClansTutorialController.丝业丆丁业三丈丟东 = ClansTutorialController.丗丂业不丅丌三丂丄();
        val_3 = ClansTutorialController.丝业丆丁业三丈丟东;
        val_3.丘上丐世丆丑且丞丒();
        return (ClansTutorialController)ClansTutorialController.丝业丆丁业三丈丟东;
    }
    private static ClansTutorialController 丗丂业不丅丌三丂丄()
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "ClansTutorialController(Don\'t destroy)");
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        val_1.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        val_1.transform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_1.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Object.DontDestroyOnLoad(target:  val_1);
        if(val_1 != null)
        {
                return val_1.AddComponent<ClansTutorialController>();
        }
        
        return val_1.AddComponent<ClansTutorialController>();
    }
    private void 丘上丐世丆丑且丞丒()
    {
        this.丈与与专丕丈丒丛丐();
        this.上丟丑世上丕丝专丆();
        this.丐丑丘丒丕丛丕不丆();
    }
    private void 丈与与专丕丈丒丛丐()
    {
        this.丏丗三丆丛丏与丝丙.set_Item(key:  2, value:  new System.Action<UnityEngine.Transform>(object:  this, method:  System.Void ClansTutorialController::一丟丆丞丂丕丙丌丗(UnityEngine.Transform 丈东丘丏与丌东东下)));
        this.丏丗三丆丛丏与丝丙.set_Item(key:  3, value:  new System.Action<UnityEngine.Transform>(object:  this, method:  System.Void ClansTutorialController::丙丌丄七丌丕一丌丕(UnityEngine.Transform 丈东丘丏与丌东东下)));
        this.丏丗三丆丛丏与丝丙.set_Item(key:  4, value:  new System.Action<UnityEngine.Transform>(object:  this, method:  System.Void ClansTutorialController::业丞一丒丞丗丏丐丝(UnityEngine.Transform 丈东丘丏与丌东东下)));
        this.丏丗三丆丛丏与丝丙.set_Item(key:  1, value:  new System.Action<UnityEngine.Transform>(object:  this, method:  System.Void ClansTutorialController::丐丆下丟三丗丐世丄(UnityEngine.Transform 丈东丘丏与丌东东下)));
        this.丏丗三丆丛丏与丝丙.set_Item(key:  5, value:  new System.Action<UnityEngine.Transform>(object:  this, method:  System.Void ClansTutorialController::丛业下丙丌不丆且东(UnityEngine.Transform 丈东丘丏与丌东东下)));
    }
    private void 上丟丑世上丕丝专丆()
    {
        this.业丘一东丄丄七三与.set_Item(key:  2, value:  44);
        this.业丘一东丄丄七三与.set_Item(key:  3, value:  45);
        this.业丘一东丄丄七三与.set_Item(key:  5, value:  54);
    }
    private void 丐丑丘丒丕丛丕不丆()
    {
        this.业万七万丈一丅业丂.set_Item(key:  1, value:  91);
    }
    internal bool 且上不下丙丏七业丗(ClansTutorialController.丙且丌业世万丂丝上 丁丅丈丌丟世丗丗丟)
    {
        if((this.下与丙丙万上丂丙丗.ContainsKey(key:  丁丅丈丌丟世丗丗丟)) == false)
        {
                return false;
        }
        
        UnityEngine.GameObject val_3 = this.下与丙丙万上丂丙丗.Item[丁丅丈丌丟世丗丗丟].gameObject;
        if(val_3 != null)
        {
                return val_3.activeSelf;
        }
        
        return val_3.activeSelf;
    }
    internal void 丐业一三专世丁丏世(ClansTutorialController.丙且丌业世万丂丝上 业丝丛且丛专丝业丁, UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        UnityEngine.Transform val_5 = 丈东丘丏与丌东东下;
        if((this.业丘一东丄丄七三与.ContainsKey(key:  业丝丛且丛专丝业丁)) != true)
        {
                if((this.业万七万丈一丅业丂.ContainsKey(key:  业丝丛且丛专丝业丁)) == false)
        {
            goto label_4;
        }
        
        }
        
        if((this.丘丆丘下且丗丒丟丄(业丝丛且丛专丝业丁:  业丝丛且丛专丝业丁)) == true)
        {
                return;
        }
        
        this.下丐丁丑丁下丘七不(业丝丛且丛专丝业丁:  业丝丛且丛专丝业丁, 丈东丘丏与丌东东下:  val_5 = 丈东丘丏与丌东东下);
        return;
        label_4:
        object[] val_4 = new object[1];
        val_5 = val_4;
        val_5[0] = 业丝丛且丛专丝业丁;
        UnityEngine.Debug.LogErrorFormat(format:  "_serverFlagConfig and _serverKeyConfig not contains key: {0}", args:  val_4);
    }
    internal void 下丐丁丑丁下丘七不(ClansTutorialController.丙且丌业世万丂丝上 业丝丛且丛专丝业丁, UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        UnityEngine.Transform val_5 = 丈东丘丏与丌东东下;
        if((this.丏丗三丆丛丏与丝丙.ContainsKey(key:  业丝丛且丛专丝业丁)) != false)
        {
                if(this.丏丗三丆丛丏与丝丙.Item[业丝丛且丛专丝业丁] == null)
        {
                return;
        }
        
            this.丏丗三丆丛丏与丝丙.Item[业丝丛且丛专丝业丁].Invoke(obj:  val_5 = 丈东丘丏与丌东东下);
            return;
        }
        
        object[] val_4 = new object[1];
        val_5 = val_4;
        val_5[0] = 业丝丛且丛专丝业丁;
        UnityEngine.Debug.LogErrorFormat(format:  "_mapActions not contains key: {0}", args:  val_4);
    }
    internal static bool 上且世丘丝三丄丈丗()
    {
        var val_8;
        var val_9;
        if((ClansTutorialController.Instance.丘丆丘下且丗丒丟丄(业丝丛且丛专丝业丁:  5)) != false)
        {
                val_8 = 1;
            return (bool)val_8;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance) != 0)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
            goto label_11;
        }
        
        }
        
        val_9 = null;
        val_9 = null;
        if(ClansController.万且丄丂丆丄一世七 != false)
        {
                val_8 = 0;
            return (bool)val_8;
        }
        
        label_11:
        val_8 = 1;
        ClansTutorialController.Instance.丞丗丌七丞丕丘且丈(三不丛丟业三且世七:  54, 丙业与丙丗丝不丈东:  true);
        return (bool)val_8;
    }
    internal bool 丘丆丘下且丗丒丟丄(ClansTutorialController.丙且丌业世万丂丝上 业丝丛且丛专丝业丁)
    {
        var val_7;
        if((this.业丘一东丄丄七三与.ContainsKey(key:  业丝丛且丛专丝业丁)) == false)
        {
            goto label_2;
        }
        
        Progress.不专丂万丐丄七上丗 val_2 = this.业丘一东丄丄七三与.Item[业丝丛且丛专丝业丁];
        if((val_2.三丅丕不上一下丞丕(三不丛丟业三且世七:  val_2)) == true)
        {
            goto label_8;
        }
        
        label_2:
        if((this.业万七万丈一丅业丂.ContainsKey(key:  业丝丛且丛专丝业丁)) == false)
        {
            goto label_6;
        }
        
        Progress.与丄东丄丘丐丙丅业 val_5 = this.业万七万丈一丅业丂.Item[业丝丛且丛专丝业丁];
        if((val_5.三丅丕不上一下丞丕(三不丛丟业三且世七:  val_5)) != 1)
        {
            goto label_8;
        }
        
        label_6:
        val_7 = 0;
        return (bool)val_7;
        label_8:
        val_7 = 1;
        return (bool)val_7;
    }
    private bool 三丅丕不上一下丞丕(Progress.不专丂万丐丄七上丗 三不丛丟业三且世七)
    {
        Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        if(val_1 != null)
        {
                return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  三不丛丟业三且世七);
        }
        
        return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  三不丛丟业三且世七);
    }
    private int 三丅丕不上一下丞丕(Progress.与丄东丄丘丐丙丅业 三不丛丟业三且世七)
    {
        return System.Convert.ToInt32(value:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  三不丛丟业三且世七), provider:  System.Globalization.CultureInfo.InvariantCulture);
    }
    private void 丌丁七丒丑丘丟丆丞(Progress.不专丂万丐丄七上丗 三不丛丟业三且世七)
    {
        this.丞丗丌七丞丕丘且丈(三不丛丟业三且世七:  三不丛丟业三且世七, 丙业与丙丗丝不丈东:  true);
    }
    private void 丞业丟三丂丄且上且(Progress.与丄东丄丘丐丙丅业 三不丛丟业三且世七)
    {
        this.丞丗丌七丞丕丘且丈(三不丛丟业三且世七:  三不丛丟业三且世七, 丙业与丙丗丝不丈东:  2);
    }
    private void 丙一丅万一丒丏三丏(ClansTutorilStap 丗与丛三丂丑丛丁丘)
    {
        if((this.下与丙丙万上丂丙丗.ContainsKey(key:  丗与丛三丂丑丛丁丘.<专丙丑业丟丝东丑世>k__BackingField)) == false)
        {
                return;
        }
        
        bool val_2 = this.下与丙丙万上丂丙丗.Remove(key:  丗与丛三丂丑丛丁丘.<专丙丑业丟丝东丑世>k__BackingField);
    }
    private void 丞丗丌七丞丕丘且丈(Progress.不专丂万丐丄七上丗 三不丛丟业三且世七, bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  三不丛丟业三且世七);
            return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄上丅丝不丆世万三(业丄七丙丛上专专丕:  三不丛丟业三且世七);
    }
    private void 丞丗丌七丞丕丘且丈(Progress.与丄东丄丘丐丙丅业 三不丛丟业三且世七, int 丙业与丙丗丝不丈东)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  三不丛丟业三且世七, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 一丟丆丞丂丕丙丌丗(UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        ClansTutorilStap val_1 = this.业丟三丏三丗与丐丑(业丝丛且丛专丝业丁:  2, 丈东丘丏与丌东东下:  丈东丘丏与丌东东下);
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.丈丒下丝业专丑一丗 = new System.Action<ClansTutorilStap>(object:  this, method:  System.Void ClansTutorialController::丙一丅万一丒丏三丏(ClansTutorilStap 丗与丛三丂丑丛丁丘));
        val_1.<专丙丑业丟丝东丑世>k__BackingField = 2;
        System.Action<Progress.不专丂万丐丄七上丗> val_4 = new System.Action<Progress.不专丂万丐丄七上丗>(object:  this, method:  System.Void ClansTutorialController::丌丁七丒丑丘丟丆丞(Progress.不专丂万丐丄七上丗 三不丛丟业三且世七));
        if(val_1 != null)
        {
                val_1.东丆专东上丆与丏丂 = 44;
            val_1.三下丌丈丄丅丟丈专 = val_4;
        }
        else
        {
                mem[80] = 44;
            mem[88] = val_4;
        }
        
        val_1.gameObject.SetActive(value:  true);
    }
    private void 丙丌丄七丌丕一丌丕(UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        ClansTutorilStap val_1 = this.业丟三丏三丗与丐丑(业丝丛且丛专丝业丁:  3, 丈东丘丏与丌东东下:  丈东丘丏与丌东东下);
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.丈丒下丝业专丑一丗 = new System.Action<ClansTutorilStap>(object:  this, method:  System.Void ClansTutorialController::丙一丅万一丒丏三丏(ClansTutorilStap 丗与丛三丂丑丛丁丘));
        val_1.<专丙丑业丟丝东丑世>k__BackingField = 3;
        System.Action<Progress.不专丂万丐丄七上丗> val_4 = new System.Action<Progress.不专丂万丐丄七上丗>(object:  this, method:  System.Void ClansTutorialController::丌丁七丒丑丘丟丆丞(Progress.不专丂万丐丄七上丗 三不丛丟业三且世七));
        if(val_1 != null)
        {
                val_1.东丆专东上丆与丏丂 = 45;
            val_1.三下丌丈丄丅丟丈专 = val_4;
        }
        else
        {
                mem[80] = 45;
            mem[88] = val_4;
        }
        
        val_1.gameObject.SetActive(value:  true);
    }
    private void 业丞一丒丞丗丏丐丝(UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        ClansTutorilStap val_1 = this.业丟三丏三丗与丐丑(业丝丛且丛专丝业丁:  4, 丈东丘丏与丌东东下:  丈东丘丏与丌东东下);
        if(val_1 == 0)
        {
                return;
        }
        
        System.Action<ClansTutorilStap> val_3 = new System.Action<ClansTutorilStap>(object:  this, method:  System.Void ClansTutorialController::丙一丅万一丒丏三丏(ClansTutorilStap 丗与丛三丂丑丛丁丘));
        if(val_1 != null)
        {
                val_1.<专丙丑业丟丝东丑世>k__BackingField = 4;
            val_1.丈丒下丝业专丑一丗 = val_3;
        }
        else
        {
                mem[76] = 4;
            mem[104] = val_3;
        }
        
        val_1.gameObject.SetActive(value:  true);
    }
    private void 丐丆下丟三丗丐世丄(UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        ClansTutorilStap val_1 = this.业丟三丏三丗与丐丑(业丝丛且丛专丝业丁:  1, 丈东丘丏与丌东东下:  丈东丘丏与丌东东下);
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.丈丒下丝业专丑一丗 = new System.Action<ClansTutorilStap>(object:  this, method:  System.Void ClansTutorialController::丙一丅万一丒丏三丏(ClansTutorilStap 丗与丛三丂丑丛丁丘));
        val_1.<专丙丑业丟丝东丑世>k__BackingField = 1;
        System.Action<Progress.与丄东丄丘丐丙丅业> val_4 = new System.Action<Progress.与丄东丄丘丐丙丅业>(object:  this, method:  System.Void ClansTutorialController::丞业丟三丂丄且上且(Progress.与丄东丄丘丐丙丅业 三不丛丟业三且世七));
        if(val_1 != null)
        {
                val_1.丅丄丑下丛与丅丁丅 = 91;
            val_1.丏一三专丟与丆专不 = val_4;
        }
        else
        {
                mem[84] = 91;
            mem[96] = val_4;
        }
        
        val_1.gameObject.SetActive(value:  true);
    }
    private void 丛业下丙丌不丆且东(UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        ClansTutorilStap val_1 = this.业丟三丏三丗与丐丑(业丝丛且丛专丝业丁:  5, 丈东丘丏与丌东东下:  丈东丘丏与丌东东下);
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.丈丒下丝业专丑一丗 = new System.Action<ClansTutorilStap>(object:  this, method:  System.Void ClansTutorialController::丙一丅万一丒丏三丏(ClansTutorilStap 丗与丛三丂丑丛丁丘));
        val_1.<专丙丑业丟丝东丑世>k__BackingField = 5;
        System.Action<Progress.不专丂万丐丄七上丗> val_4 = new System.Action<Progress.不专丂万丐丄七上丗>(object:  this, method:  System.Void ClansTutorialController::丌丁七丒丑丘丟丆丞(Progress.不专丂万丐丄七上丗 三不丛丟业三且世七));
        if(val_1 != null)
        {
                val_1.东丆专东上丆与丏丂 = 54;
            val_1.三下丌丈丄丅丟丈专 = val_4;
        }
        else
        {
                mem[80] = 54;
            mem[88] = val_4;
        }
        
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_1.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "NGUI"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_1.gameObject.SetActive(value:  true);
    }
    private ClansTutorilStap 业丟三丏三丗与丐丑(ClansTutorialController.丙且丌业世万丂丝上 业丝丛且丛专丝业丁, UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        UnityEngine.Object val_25;
        System.Collections.Generic.Dictionary<丙且丌业世万丂丝上, ClansTutorilStap> val_26;
        UnityEngine.Object val_27;
        string val_28;
        val_25 = 丈东丘丏与丌东东下;
        val_26 = this;
        if((this.下与丙丙万上丂丙丗.ContainsKey(key:  业丝丛且丛专丝业丁)) != false)
        {
                val_26 = this.下与丙丙万上丂丙丗;
            val_27 = val_26.Item[业丝丛且丛专丝业丁];
            if(val_27 == 0)
        {
                return (ClansTutorilStap)val_27;
        }
        
            val_26 = val_27.transform.parent;
            if(val_26 == val_25)
        {
                return (ClansTutorilStap)val_27;
        }
        
            val_27.transform.SetParent(p:  val_25);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_27.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            val_27.transform.rotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            val_27.transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            val_26 = val_27.gameObject;
            val_25 = val_25.gameObject.layer;
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_26, 不东丛三丂丌丑专丆:  val_25, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            return (ClansTutorilStap)val_27;
        }
        
        if((this.丘丒东丛万一丄丙丙.ContainsKey(key:  业丝丛且丛专丝业丁)) == false)
        {
            goto label_31;
        }
        
        ClansTutorilStap val_19 = UnityEngine.Resources.Load<ClansTutorilStap>(path:  this.丘丒东丛万一丄丙丙.Item[业丝丛且丛专丝业丁]);
        if(val_19 != 0)
        {
            goto label_35;
        }
        
        val_26 = this.丘丒东丛万一丄丙丙;
        val_25 = new object[1];
        val_25[0] = val_26.Item[业丝丛且丛专丝业丁];
        val_28 = "Not found ClansTutorilStap with path: {0}";
        goto label_43;
        label_31:
        object[] val_23 = new object[1];
        val_25 = val_23;
        val_25[0] = 业丝丛且丛专丝业丁;
        val_28 = "_configPathToPrefabs not contains key: {0}";
        label_43:
        UnityEngine.Debug.LogErrorFormat(format:  val_28, args:  val_23);
        val_27 = 0;
        return (ClansTutorilStap)val_27;
        label_35:
        val_27 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<ClansTutorilStap>(丑且不丕与专丄业丙:  val_19, 丈东丘丏与丌东东下:  val_25, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        return (ClansTutorilStap)val_27;
    }
    public ClansTutorialController()
    {
        this.丏丗三丆丛丏与丝丙 = new System.Collections.Generic.Dictionary<丙且丌业世万丂丝上, System.Action<UnityEngine.Transform>>();
        this.业丘一东丄丄七三与 = new System.Collections.Generic.Dictionary<丙且丌业世万丂丝上, Progress.不专丂万丐丄七上丗>();
        this.业万七万丈一丅业丂 = new System.Collections.Generic.Dictionary<丙且丌业世万丂丝上, Progress.与丄东丄丘丐丙丅业>();
        System.Collections.Generic.Dictionary<丙且丌业世万丂丝上, System.String> val_4 = new System.Collections.Generic.Dictionary<丙且丌业世万丂丝上, System.String>();
        if(val_4 != null)
        {
                val_4.Add(key:  2, value:  "Clans/Tutorial/NewClanTutorialView_ClanLobby");
        }
        else
        {
                val_4.Add(key:  2, value:  "Clans/Tutorial/NewClanTutorialView_ClanLobby");
        }
        
        val_4.Add(key:  1, value:  "Clans/Tutorial/NewClanTutorialView_Migration");
        if(val_4 != null)
        {
                val_4.Add(key:  3, value:  "Clans/Tutorial/NewClanTutorialView_ClanWar");
        }
        else
        {
                val_4.Add(key:  3, value:  "Clans/Tutorial/NewClanTutorialView_ClanWar");
        }
        
        val_4.Add(key:  4, value:  "Clans/Tutorial/NewClanTutorialView_Cycle");
        val_4.Add(key:  5, value:  "Clans/Tutorial/NewClanTutorialView_EnterClan");
        this.丘丒东丛万一丄丙丙 = val_4;
        this.下与丙丙万上丂丙丗 = new System.Collections.Generic.Dictionary<丙且丌业世万丂丝上, ClansTutorilStap>();
    }

}
