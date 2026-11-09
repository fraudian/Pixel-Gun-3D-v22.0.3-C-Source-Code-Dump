using UnityEngine;
internal class TankEquipmentController : BaseEquipmentController
{
    // Fields
    internal static TankEquipmentController 丄丘七三上丕世丞业;
    private readonly string 丏丐丘不丗丙丗与丂;
    public bool equipInitialized;
    private System.Collections.Generic.List<float> 且丕七丘丝丗下丒且;
    private System.Collections.Generic.List<float> 丝丘世下专丂七与丁;
    internal float speedMultipler;
    internal DamageableTankResist 七丟不世东丛丈与东;
    
    // Properties
    internal int 丂丞丂丝七丑丏不丆 { get; }
    
    // Methods
    internal int 丞丆下丒丗丒丘七丐()
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
        if((val_8.ContainsKey(key:  GameConnect.且丗丄丏丗丝不且不)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.且丗丄丏丗丝不且不]);
    }
    public static string GetTankEquipment(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
    {
        if(且丟丅丄丒丑丂丁世 == null)
        {
                return (string)System.String.alignConst;
        }
        
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  且丟丅丄丒丑丂丁世.丒丗不丙业丟丄丏丂());
    }
    private void Awake()
    {
        TankEquipmentController.丄丘七三上丕世丞业 = this;
        mem[1152921540476001000] = this.GetComponent<PhotonView>();
    }
    public void Initialize()
    {
        DamageableTankResist val_14;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        int val_20;
        val_14 = this;
        if(==0)
        {
            goto label_1;
        }
        
        val_16 = 0;
        goto label_2;
        label_9:
        UnityEngine.Object.Destroy(obj:  mem[137105440].gameObject);
        val_16 = 1;
        label_2:
        if(val_16 < null)
        {
            goto label_9;
        }
        
        mem[1152921540476153968] = 0;
        label_1:
        val_17 = 1152921505107111936;
        val_18 = null;
        val_18 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丌丟丁丞丆且丂丈丗)) == false)
        {
            goto label_16;
        }
        
        val_19 = null;
        ExitGames.Client.Photon.Hashtable val_14 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_19 = null;
        object val_7 = val_14.Item[GameConnect.丌丟丁丞丆且丂丈丗];
        if(val_7 == null)
        {
            goto label_23;
        }
        
        val_14 = (null == null) ? (val_7) : 0;
        goto label_25;
        label_16:
        val_20 = System.String.alignConst;
        goto label_25;
        label_23:
        val_20 = 0;
        label_25:
        if((System.String.IsNullOrEmpty(value:  val_20)) != true)
        {
                val_17 = 1152921504691564544;
            System.Collections.Generic.List<ClanTankEquipInfo> val_9 = new System.Collections.Generic.List<ClanTankEquipInfo>();
            DataSystem.丈且丈上不下且丝丒 val_10 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_15 = 0;
            val_15 = val_15 + 1;
            this.万丒丒丒丝丛万丒东(一丐丗丁丞丆丅丟丄:  val_10);
            this.丆三丂不丆下不业丅(一丐丗丁丞丆丅丟丄:  val_10);
        }
        
        if(TankController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        if(TankController.丄丘七三上丕世丞业.tankObject == 0)
        {
                return;
        }
        
        typeof(TankObject).__il2cppRuntimeField_28 = this.speedMultipler;
        val_14 = this.七丟不世东丛丈与东;
        typeof(TankDamageable).__il2cppRuntimeField_38 = val_14;
    }
    private void 万丒丒丒丝丛万丒东(System.Collections.Generic.List<ClanTankEquipInfo> 一丐丗丁丞丆丅丟丄)
    {
        var val_31;
        UnityEngine.Object val_32;
        string val_33;
        System.Collections.Generic.List<T> val_34;
        System.Collections.Generic.List<FortEquipObject> val_1 = new System.Collections.Generic.List<FortEquipObject>();
        val_31 = 0;
        goto label_1;
        label_51:
        ClanTankEquipInfo val_2 = 一丐丗丁丞丆丅丟丄.Item[0];
        val_32 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_2.itemSettingsId);
        val_33 = 一丐丗丁丞丆丅丟丄.Item[0];
        if(val_33 == null)
        {
            goto label_7;
        }
        
        if(val_32 != null)
        {
            goto label_8;
        }
        
        goto label_35;
        label_7:
        if(val_32 == null)
        {
            goto label_35;
        }
        
        label_8:
        val_33 = val_4.itemSettingsId;
        ClanTankEquipInfo val_5 = 一丐丗丁丞丆丅丟丄.Item[0];
        ClanTankTurretPoint val_6 = 丝丌且东东上丌丙丟(世丟丄丅丛世丝丑丕:  val_5.placeId);
        if(((val_6 == 0) || (val_3.uploadItemNames == null)) || (val_3.uploadItemNames.Count == 0))
        {
            goto label_35;
        }
        
        val_32 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  mem[1152921540476421632] + val_3.uploadItemNames.Item[0]);
        if((val_32 != 0) || ((System.String.IsNullOrEmpty(value:  val_33)) == true))
        {
            goto label_26;
        }
        
        丗一丂丈丅三丌东丅 val_15 = 丄与东丕丑丗丌七上.丑七不且上丗丁一世().丐下下丅与上东丙丑(丈丟且丐上不世专丁:  val_33);
        if(val_15 == null)
        {
            goto label_26;
        }
        
        val_32 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_15.三丙且下一专上东与());
        if(((val_32 == null) || (val_17.uploadItemNames == null)) || (val_17.uploadItemNames.Count == 0))
        {
            goto label_35;
        }
        
        val_32 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  mem[1152921540476421632] + val_17.uploadItemNames.Item[0]);
        label_26:
        if(val_32 != 0)
        {
                UnityEngine.GameObject val_24 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_32, parent:  val_6.丌丟丄业且三丛丕丄());
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.zero;
            val_24.transform.localPosition = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
            val_34 = val_1;
            if(val_34 == 0)
        {
                val_34 = val_1;
        }
        
            val_1.Add(item:  val_24.GetComponent<FortEquipObject>());
            ClanTankEquipInfo val_29 = 一丐丗丁丞丆丅丟丄.Item[0];
            val_32 = val_29.ServerLevel;
            if((val_24.GetComponent<FortEquipObject>()) != null)
        {
                val_28.丕丙万不丆丟三丆丝 = val_32;
        }
        else
        {
                mem[88] = val_32;
        }
        
            val_28.一丏丌丐丌三专上上 = val_33;
        }
        
        label_35:
        val_31 = 1;
        label_1:
        if(val_31 < 一丐丗丁丞丆丅丟丄.Count)
        {
            goto label_51;
        }
        
        this.SetEquip(一东丟丈丐丟丂丆上:  val_1);
    }
    private void 丆三丂不丆下不业丅(System.Collections.Generic.List<ClanTankEquipInfo> 一丐丗丁丞丆丅丟丄)
    {
        goto label_1;
        label_15:
        ClanTankEquipInfo val_1 = 一丐丗丁丞丆丅丟丄.Item[0];
        PlaceableItemSettings val_2 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_1.itemSettingsId);
        ClanTankEquipInfo val_3 = 一丐丗丁丞丆丅丟丄.Item[0];
        bool val_5 = UnityEngine.Object.op_Equality(x:  GetMaterialChangePointByPlaceId(世丟丄丅丛世丝丑丕:  val_3.placeId), y:  0);
        0 = 1;
        label_1:
        if(0 < 一丐丗丁丞丆丅丟丄.Count)
        {
            goto label_15;
        }
    
    }
    public void SetEquip(System.Collections.Generic.List<FortEquipObject> 一东丟丈丐丟丂丆上)
    {
        mem[1152921540476854512] = 一东丟丈丐丟丂丆上.ToArray();
        this.不丌上丁丙东上丟东();
        this.equipInitialized = true;
    }
    protected override void 丑丂业且下上丝丈世(float 丙丁丈丐万丆丟与下, float[] 世丙丟上丘上七万万, float[] 丈且上丆东丞丏万且)
    {
        var val_11;
        var val_12;
        float val_13;
        System.Collections.Generic.List<System.Single> val_14;
        var val_15;
        var val_16;
        if(this.且丕七丘丝丗下丒且.Count != 世丙丟上丘上七万万.Length)
        {
                this.且丕七丘丝丗下丒且.Clear();
            this.且丕七丘丝丗下丒且.AddRange(collection:  世丙丟上丘上七万万);
            this.丝丘世下专丂七与丁.Clear();
            this.丝丘世下专丂七与丁.AddRange(collection:  丈且上丆东丞丏万且);
        }
        
        val_11 = 1152921504838422528;
        val_12 = 0;
        goto label_8;
        label_15:
        val_13 = UnityEngine.Mathf.Min(a:  this.且丕七丘丝丗下丒且.Item[0], b:  世丙丟上丘上七万万[0]);
        this.且丕七丘丝丗下丒且.set_Item(index:  0, value:  val_13);
        val_12 = 1;
        label_8:
        if(val_12 < this.且丕七丘丝丗下丒且.Count)
        {
            goto label_15;
        }
        
        val_14 = 1152921504622448640;
        val_15 = 0;
        goto label_16;
        label_24:
        val_11 = 0;
        val_13 = System.Math.Min(val1:  this.丝丘世下专丂七与丁.Item[0], val2:  丈且上丆东丞丏万且[val_11]);
        this.丝丘世下专丂七与丁.set_Item(index:  0, value:  val_13);
        val_15 = 1;
        label_16:
        if(val_15 < this.丝丘世下专丂七与丁.Count)
        {
            goto label_24;
        }
        
        val_16 = 0;
        this.equipInitialized = true;
    }
    public TankEquipmentController()
    {
        this.丏丐丘不丗丙丗与丂 = "FortField\\TankItemsContent\\InGame\\";
        this.且丕七丘丝丗下丒且 = new System.Collections.Generic.List<System.Single>();
        this.丝丘世下专丂七与丁 = new System.Collections.Generic.List<System.Single>();
        this.speedMultipler = 1f;
    }

}
