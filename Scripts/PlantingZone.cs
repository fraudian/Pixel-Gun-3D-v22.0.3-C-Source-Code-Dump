using UnityEngine;
internal sealed class PlantingZone : ZoneWithActivePlayers
{
    // Fields
    internal string ZoneIndex;
    private ZoneActionSounds zoneSounds;
    private bool 丆丌专丐丌丛丞丝丈;
    private bool 丅丆与丄丂三丑丄专;
    private bool 丆世东丝丏丘上丂丐;
    private UnityEngine.Vector3 万丙下三丕专丅且专;
    private string 丕一上丈与丞东与一;
    private const string 丝丟丁丄丗丗丒丛世 = "bomb";
    private const string 丝丘丅东七丏丏丝丕 = "disarm";
    private WorldPosIndicatonItem_Filling 东丄与丛丂丘丝三丝;
    
    // Properties
    internal bool 丆丟与丌丏不丅丈东 { get; }
    internal bool 东一万一丆丆丒丛上 { get; }
    internal bool 下丞且丐世万东且一 { get; }
    private WorldPosIndicatonItem_Filling 丂丅丆丑丄专丐丑丄 { get; }
    
    // Methods
    internal bool 上三丙专丁丂丞三与()
    {
        return (bool)this.丆丌专丐丌丛丞丝丈;
    }
    internal bool 丙丟丑与丝丑丆丁丆()
    {
        return (bool)this.丅丆与丄丂三丑丄专;
    }
    internal bool 世丒丑世丌丌丆丑丑()
    {
        return (bool)this.丆世东丝丏丘上丂丐;
    }
    private WorldPosIndicatonItem_Filling 丑丐丛丅丘丄下丟世()
    {
        if(this.东丄与丛丂丘丝三丝 != 0)
        {
                return (WorldPosIndicatonItem_Filling)this.东丄与丛丂丘丝三丝;
        }
        
        this.丕七下丗专丈三丄丈();
        return (WorldPosIndicatonItem_Filling)this.东丄与丛丂丘丝三丝;
    }
    private void 丕七下丗专丈三丄丈()
    {
        UnityEngine.Object val_13;
        UnityEngine.Transform val_14;
        val_13 = this;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        this.东丄与丛丂丘丝三丝 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicatonItem_Filling>();
        string val_3 = "Point_" + this.ZoneIndex + "_bomb";
        this.丕一上丈与丞东与一 = val_3;
        this.东丄与丛丂丘丝三丝.与丕与丝丑丐丁丐丕(丒丘丏上丙丟丑丕丈:  val_3);
        val_14 = this.transform;
        this.东丄与丛丂丘丝三丝.万三丗丆下万丅上丈(丞下万上三丘上与专:  val_14, 丒专丌万丄一丒万丏:  2.4f);
        val_13 = this.东丄与丛丂丘丝三丝.GetComponent<UIPanel>();
        if(val_13 == 0)
        {
                return;
        }
        
        val_13 = ???;
        val_14 = ???;
        goto typeof(UIPanel).__il2cppRuntimeField_1A8;
    }
    private void 丕下且丞丞上丛丗丒()
    {
        var val_13;
        if(this.丑丐丛丅丘丄下丟世() == 0)
        {
                return;
        }
        
        if((PlantTheBombController.丆丕丝丒不丙且丐丗 == 0) || (PlantTheBombController.丆丕丝丒不丙且丐丗.三丘专东丐下丂三丑 != 1))
        {
            goto label_15;
        }
        
        string val_6 = "Point_" + this.ZoneIndex + "_" + (PlantTheBombController.丆丕丝丒不丙且丐丗.isMyTeamBomberRole != true) ? "bomb" : "disarm"((PlantTheBombController.丆丕丝丒不丙且丐丗.isMyTeamBomberRole != true) ? "bomb" : "disarm");
        if(PlantTheBombController.丆丕丝丒不丙且丐丗 == null)
        {
                val_13 = 0;
        }
        
        if(val_13.丟不丏丈丗丘丕丐丒() == false)
        {
            goto label_11;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.丌且丆丆东丐专万七() != this)
        {
            goto label_15;
        }
        
        UnityEngine.Color val_10 = UnityEngine.Color.red;
        goto label_17;
        label_15:
        UnityEngine.Color val_11 = UnityEngine.Color.black;
        label_17:
        this.上业丂与万丐万与丙(丙业与丙丗丝不丈东:  false, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a}, 丝万且业丏丘业业东:  System.String.alignConst);
        return;
        label_11:
        UnityEngine.Color val_12 = UnityEngine.Color.white;
        goto label_17;
    }
    private void 上业丂与万丐万与丙(bool 丙业与丙丗丝不丈东, UnityEngine.Color 丑丞丈丗丄丙丟万丄, string 丝万且业丏丘业业东)
    {
        bool val_10 = 丙业与丙丗丝不丈东;
        if(this.丑丐丛丅丘丄下丟世() == 0)
        {
                return;
        }
        
        this.丑丐丛丅丘丄下丟世().gameObject.SetActive(value:  val_10 = 丙业与丙丗丝不丈东);
        if(val_10 == false)
        {
                return;
        }
        
        this.丑丐丛丅丘丄下丟世().丛丟专丕世下丒丛七(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
        this.丑丐丛丅丘丄下丟世().丝与丑与丘丝专与且(丛丁三世世丆七不业:  1f);
        val_10 = this.丕一上丈与丞东与一;
        if((丝万且业丏丘业业东.Equals(value:  val_10)) == true)
        {
                return;
        }
        
        val_10 = this.丑丐丛丅丘丄下丟世();
        val_10.与丕与丝丑丐丁丐丕(丒丘丏上丙丟丑丕丈:  丝万且业丏丘业业东);
        this.丕一上丈与丞东与一 = 丝万且业丏丘业业东;
    }
    internal override void 与七丌专丌与丆丌丒(int 业上上丏丄不上丅丈)
    {
        this.与七丌专丌与丆丌丒(业上上丏丄不上丅丈:  业上上丏丄不上丅丈);
        if(this.zoneSounds == 0)
        {
                return;
        }
        
        this.zoneSounds.三丈七七丈丞东丗东();
    }
    protected override void 专丈下丐不业万七丗(bool 东丝丁下丁东且丑业)
    {
        bool val_1 = 东丝丁下丁东且丑业;
        this.专丈下丐不业万七丗(东丝丁下丁东且丑业:  val_1);
        if(val_1 == true)
        {
                return;
        }
        
        if(this.丆丌专丐丌丛丞丝丈 == false)
        {
                return;
        }
        
        this.丐与丕丛丕丈万丟且();
    }
    internal void 丑丞丕丂丒上丅丑万()
    {
        if(this.zoneSounds == 0)
        {
                return;
        }
        
        this.zoneSounds.丘丁丘东与丛丁上三();
    }
    internal float 专丙丅丏丆丂且三业()
    {
        PlantTheBombController val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        val_7 = 0f;
        if((下一且丄不与丑东丅(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
                return (float)val_7;
        }
        
        val_8 = null;
        val_8 = null;
        val_5 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        float val_5 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.上丘丒丁七丒丂丘丘;
        val_5 = (UnityEngine.Time.time - (this.不世丏东丅丁丆丟东(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC))) / val_5;
        if(val_5 < 0)
        {
                return (float)val_7;
        }
        
        return (float)val_7;
    }
    internal void 丝丙丌丟丄丝下业专()
    {
        var val_3;
        if(this.丅丆与丄丂三丑丄专 == false)
        {
                return;
        }
        
        this.丆丌专丐丌丛丞丝丈 = true;
        val_3 = null;
        val_3 = null;
        UnityEngine.Vector3 val_2 = transform.position;
        this.万丙下三丕专丅且专 = val_2;
        mem[1152921538608790280] = val_2.y;
        mem[1152921538608790284] = val_2.z;
    }
    internal void 丐与丕丛丕丈万丟且()
    {
        this.丆丌专丐丌丛丞丝丈 = false;
        PlantTheBombController.丆丕丝丒不丙且丐丗.三丛丁万丟东东丅万(业丂万丈丝七一与专:  this);
    }
    internal override void Reset()
    {
        this.Reset();
        this.丆丌专丐丌丛丞丝丈 = true;
        this.丅丆与丄丂三丑丄专 = true;
        this.丆世东丝丏丘上丂丐 = false;
    }
    internal void 丐一上与丙上丁丐丕()
    {
        this.丆世东丝丏丘上丂丐 = true;
    }
    internal void 丏丘且丈丝丙丄丈专()
    {
        this.丆丌专丐丌丛丞丝丈 = false;
        this.丅丆与丄丂三丑丄专 = false;
        X19.世业丒万丘丆专丘丐();
    }
    private void Update()
    {
        bool val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        if(this.zoneSounds != 0)
        {
                val_15 = this.东丟下专七且与一三();
            this.zoneSounds.丐七丌下三专专丆丑(丙业与丙丗丝不丈东:  val_15);
        }
        
        WorldPosIndicatonItem_Filling val_4 = this.丑丐丛丅丘丄下丟世();
        if(val_4 != 0)
        {
                this.丕下且丞丞上丛丗丒();
        }
        
        if(this.世三丕丒丗丅丁一丙() == false)
        {
                return;
        }
        
        if(this.丆丌专丐丌丛丞丝丈 == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if((val_4.下一且丄不与丑东丅(专丞上七七且丝七丗:  val_15)) == false)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        if(丗丞业丐丛三上丄丕() == true)
        {
            goto label_19;
        }
        
        val_18 = null;
        val_18 = null;
        UnityEngine.Transform val_9 = transform;
        UnityEngine.Vector3 val_10 = val_9.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = this.万丙下三丕专丅且专, y = V11.16B, z = V10.16B});
        if(val_11.x <= 0.01f)
        {
            goto label_27;
        }
        
        label_19:
        this.丐与丕丛丕丈万丟且();
        return;
        label_27:
        val_19 = null;
        val_19 = null;
        if((UnityEngine.Time.time - (val_9.不世丏东丅丁丆丟东(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC))) < (float)PlantTheBombController.丆丕丝丒不丙且丐丗.上丘丒丁七丒丂丘丘)
        {
                return;
        }
        
        PlantTheBombController.丆丕丝丒不丙且丐丗.丅三丐且丕上丞丆丞();
        this.丏丘且丈丝丙丄丈专();
    }
    public PlantingZone()
    {
        this.丅丆与丄丂三丑丄专 = true;
    }

}
