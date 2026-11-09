using UnityEngine;
internal class FortGameFieldController : PGBehaviour
{
    // Fields
    private UnityEngine.Transform _fieldPivot;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丑丁丄万业丛丗丁上;
    private System.Collections.Generic.List<FortGameFieldController.与丈丛下世丕上丄丄> 与东丘下三丙七专丑;
    internal static FortGameFieldController 丄丘七三上丕世丞业;
    
    // Properties
    internal System.Collections.Generic.List<FortGameFieldController.与丈丛下世丕上丄丄> 三世业丘丝七丑专万 { get; }
    internal int 丛丆丟世丏丑丈丌丂 { get; }
    
    // Methods
    internal System.Collections.Generic.List<FortGameFieldController.与丈丛下世丕上丄丄> 业不丆丂丞丏三丙丝()
    {
        return (System.Collections.Generic.List<与丈丛下世丕上丄丄>)this.与东丘下三丙七专丑;
    }
    internal int 丌丛业东七丑丐丞专()
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
        if((val_8.ContainsKey(key:  GameConnect.丌丌世丒丙丟丈丅丒)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丌丌世丒丙丟丈丅丒]);
    }
    private void Awake()
    {
        FortGameFieldController.丄丘七三上丕世丞业 = this;
    }
    internal int 丝丐丁上三业丂东三(string 丞丅上丏丂且下丅与)
    {
        string val_5;
        var val_6;
        var val_7;
        val_5 = 丞丅上丏丂且下丅与;
        val_6 = 0;
        goto label_1;
        label_5:
        与丈丛下世丕上丄丄 val_1 = this.与东丘下三丙七专丑.Item[0];
        if((System.String.op_Equality(a:  val_1.丞丅上丏丂且下丅与, b:  val_5)) == true)
        {
            goto label_3;
        }
        
        val_6 = 1;
        label_1:
        if(val_6 < this.与东丘下三丙七专丑.Count)
        {
            goto label_5;
        }
        
        val_7 = 0;
        return (int)val_7;
        label_3:
        val_5 = this.与东丘下三丙七专丑;
        与丈丛下世丕上丄丄 val_4 = val_5.Item[0];
        val_7 = val_4.丕丙万不丆丟三丆丝;
        return (int)val_7;
    }
    internal void 万不丄丟丑丗七万丗()
    {
        var val_19;
        string val_57;
        var val_58;
        System.Collections.Generic.List<UnityEngine.GameObject> val_59;
        UnityEngine.Object val_60;
        var val_61;
        var val_62;
        string val_64;
        UnityEngine.Object val_66;
        var val_68;
        var val_69;
        val_57 = this;
        val_58 = 0;
        goto label_1;
        label_10:
        if(X21.Item[0] != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丑丁丄万业丛丗丁上.Item[0]);
        }
        
        val_58 = 1;
        label_1:
        val_59 = this.丑丁丄万业丛丗丁上;
        if(val_58 < this.丑丁丄万业丛丗丁上.Count)
        {
            goto label_10;
        }
        
        val_59.Clear();
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_20;
        }
        
        val_60 = 1152921505066536960;
        val_61 = null;
        val_61 = null;
        val_59 = GameConnect.丛丁丐丟三世三丟丐;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_59)) == false)
        {
            goto label_20;
        }
        
        val_62 = null;
        val_62 = null;
        val_59 = GameConnect.丛丁丐丟三世三丟丐;
        val_64 = 世丛丝上丒丈丑东丟.与丏专三丈丒丐东丈(丏业丅一丝与世上丘:  (null == null) ? 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_59] : 0);
        goto label_28;
        label_20:
        val_64 = 0;
        label_28:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_64)) == true)
        {
                return;
        }
        
        var val_56 = 0;
        val_56 = val_56 + 1;
        this.与东丘下三丙七专丑.Clear();
        List.Enumerator<T> val_17 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().GetEnumerator();
        label_84:
        if((1848937840 & 1) == 0)
        {
            goto label_41;
        }
        
        string val_20 = val_19.丐丏七丌丕丗业且上();
        PlaceableItemSettings val_21 = val_20.ItemSettings;
        if(((val_21 == null) || (val_21.uploadItemNames == null)) || (val_21.uploadItemNames.Count == 0))
        {
            goto label_84;
        }
        
        if(val_21.IsGuard == false)
        {
            goto label_47;
        }
        
        this.与东丘下三丙七专丑.Add(item:  new 与丈丛下世丕上丄丄() {丞丅上丏丂且下丅与 = val_21.uploadItemNames.Item[0], 丕丙万不丆丟三丆丝 = val_20});
        goto label_84;
        label_47:
        val_66 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "FortField\\FortItemsContent\\InGame\\" + val_21.uploadItemNames.Item[0]);
        if((val_66 != 0) || ((System.String.IsNullOrEmpty(value:  this.与东丘下三丙七专丑)) == true))
        {
            goto label_57;
        }
        
        丗一丂丈丅三丌东丅 val_31 = 丄与东丕丑丗丌七上.丑七不且上丗丁一世().丐下下丅与上东丙丑(丈丟且丐上不世专丁:  this.与东丘下三丙七专丑);
        if(val_31 == null)
        {
            goto label_57;
        }
        
        if((((丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_31.三丙且下一专上东与())) == null) || (val_33.uploadItemNames == null)) || (val_33.uploadItemNames.Count == 0))
        {
            goto label_84;
        }
        
        val_66 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "FortField\\FortItemsContent\\InGame\\" + val_33.uploadItemNames.Item[0]);
        label_57:
        if(val_66 == 0)
        {
            goto label_84;
        }
        
        UnityEngine.GameObject val_39 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_66);
        UnityEngine.Transform val_41 = this._fieldPivot.transform;
        UnityEngine.Vector3 val_42 = val_41.position;
        val_19 = 0;
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_39.transform.position = new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z};
        UnityEngine.Quaternion val_45 = UnityEngine.Quaternion.Euler(x:  0f, y:  (float)val_41, z:  0f);
        val_39.transform.localRotation = new UnityEngine.Quaternion() {x = val_45.x, y = val_45.y, z = val_45.z, w = val_45.w};
        FortEquipObject val_46 = val_39.GetComponent<FortEquipObject>();
        if(val_46 != 0)
        {
                if(val_46 != null)
        {
                val_46.丕丙万不丆丟三丆丝 = val_20;
        }
        else
        {
                mem[88] = val_20;
        }
        
            val_46.一丏丌丐丌三专上上 = this.与东丘下三丙七专丑;
        }
        
        this.丑丁丄万业丛丗丁上.Add(item:  val_39);
        goto label_84;
        label_41:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.List<FortEquipObject> val_48 = new System.Collections.Generic.List<FortEquipObject>();
        val_59 = 0;
        goto label_126;
        label_147:
        FortEquipObject val_50 = ???.Item[0].GetComponent<FortEquipObject>();
        if(val_50 != 0)
        {
                val_48.Add(item:  val_50);
            if(val_50 != null)
        {
                val_60 = FortDefenceLinkController.丄丘七三上丕世丞业.GetTeleport();
            if(val_60 != 0)
        {
                val_68 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_60, 丏业丟一东丂东丘丛:  true);
            mem2[0] = val_60;
            val_52.myDublicatePortal = ;
        }
        
        }
        
        }
        
        val_59 = 1;
        label_126:
        if(val_59 < (???.Count))
        {
            goto label_147;
        }
        
        val_69 = null;
        val_69 = null;
        val_57 = FortEquipmentController.丝丘丞不丂丆不丘且;
        val_57.SetEquipForFortDefence(一东丟丈丐丟丂丆上:  val_48);
    }
    public FortGameFieldController()
    {
        this.丑丁丄万业丛丗丁上 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.与东丘下三丙七专丑 = new System.Collections.Generic.List<与丈丛下世丕上丄丄>();
    }

}
