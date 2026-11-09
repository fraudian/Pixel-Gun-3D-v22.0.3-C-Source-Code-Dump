using UnityEngine;
internal class SquareField : MonoBehaviour
{
    // Fields
    internal float minDistanceDelta;
    internal float distanceDelta;
    internal const float 三七丈丐下丞丕上专 = 1;
    internal System.Collections.Generic.Dictionary<UnityEngine.GameObject, FortBuildingPlace> 世东万丗世丗丈丈丞;
    private System.Action<UnityEngine.GameObject> 丗不世丙丏丅丄丂下;
    private UnityEngine.GameObject 丅业丁丆丂业一丐专;
    private float _cellSize;
    private UnityEngine.Transform _objectsPlacePoint;
    private UnityEngine.Transform _tankGameObject;
    private FortFieldObjectUI _selectedObjectUi;
    internal static SquareField 丄丘七三上丕世丞业;
    internal UnityEngine.Vector3 世东世丞丝丘丂业上;
    internal SquareFieldCell 万七丐丅丐世业业丆;
    private float lerpSpeed;
    private float lerpHeightSpeed;
    private float delta;
    internal bool 丂上世丂下万与丟丁;
    private readonly System.Collections.Generic.Dictionary<SquareFieldCellSize, UnityEngine.GameObject> 丑丝丌丑一业丌丞七;
    
    // Properties
    internal PlaceableItemSettings 丈丛专丕下下丄丝丑 { get; }
    public UnityEngine.GameObject 丑三下丘丗丁丘丛三 { get; set; }
    
    // Methods
    internal void 丐丗丗丅丐世七万七(System.Action<UnityEngine.GameObject> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗不世丙丏丅丄丂下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不世丙丏丅丄丂下 != 1152921539189870504);
    
    }
    internal void 丁专一世丆丄丟丝上(System.Action<UnityEngine.GameObject> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗不世丙丏丅丄丂下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不世丙丏丅丄丂下 != 1152921539190007080);
    
    }
    internal PlaceableItemSettings 丛丐业三丏丏丕丘丏()
    {
        UnityEngine.Object val_4;
        var val_5;
        val_4 = this;
        val_5 = 0;
        if(this.丅业丁丆丂业一丐专 == 0)
        {
                return 0;
        }
        
        val_4 = this.丅业丁丆丂业一丐专.GetComponent<SquareFieldSelectableCell>();
        val_5 = 0;
        if(val_4 == 0)
        {
                return 0;
        }
        
        return 0;
    }
    public UnityEngine.GameObject get_SelectedObject()
    {
        return (UnityEngine.GameObject)this.丅业丁丆丂业一丐专;
    }
    public void set_SelectedObject(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        this.丅业丁丆丂业一丐专 = 丙业与丙丗丝不丈东;
        if(this.丗不世丙丏丅丄丂下 == null)
        {
                return;
        }
        
        this.丗不世丙丏丅丄丂下.Invoke(obj:  丙业与丙丗丝不丈东);
    }
    private void Awake()
    {
        SquareField.丄丘七三上丕世丞业 = this;
    }
    private void OnEnable()
    {
        if(this._selectedObjectUi != 0)
        {
                this._selectedObjectUi.丝一丅丆三东丂丞七();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._tankGameObject, 丏业丟一东丂东丘丛:  Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan);
        if(this._tankGameObject.gameObject.activeSelf == false)
        {
                return;
        }
        
        this._tankGameObject.GetComponent<ClanTankBuildBase>().丄丅丙一上丝丐丒丝(一丐丗丁丞丆丅丟丄:  Rilisoft.Singleton<ClansVisitController>.Instance.不世丗七不下丑丕丆());
    }
    private void Update()
    {
        var val_16;
        UnityEngine.Vector3 val_17;
        float val_18;
        UnityEngine.Vector3 val_19;
        val_16 = this;
        if(this.万七丐丅丐世业业丆 == 0)
        {
                return;
        }
        
        val_17 = this.万七丐丅丐世业业丆._coordinate;
        val_19 = this.世东世丞丝丘丂业上;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_17, y = V9.16B, z = V13.16B}, rhs:  new UnityEngine.Vector3() {x = val_19, y = V10.16B, z = V11.16B})) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.万七丐丅丐世业业丆.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_8 = this.万七丐丅丐世业业丆.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.世东世丞丝丘丂业上, y = V11.16B, z = val_19}, t:  (((System.Math.Abs(val_17 - S9)) < 0) ? this.lerpSpeed : this.lerpHeightSpeed) * UnityEngine.Time.deltaTime);
        val_18 = val_11.x;
        val_17 = val_11.y;
        UnityEngine.Vector3 val_13 = this.万七丐丅丐世业业丆.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = this.世东世丞丝丘丂业上, y = V11.16B, z = val_19});
        if(val_14.x < 0)
        {
                val_17 = this.世东世丞丝丘丂业上;
            this.万七丐丅丐世业业丆.丈丒不丑三丄丏丅丌(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_17, y = val_11.z, z = val_18});
            return;
        }
        
        val_19 = this.distanceDelta;
        if(val_14.x < 0)
        {
                this.万七丐丅丐世业业丆.丈丒不丑三丄丏丅丌(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_11.z});
            return;
        }
        
        val_16 = this.万七丐丅丐世业业丆.丌丟丄业且三丛丕丄();
        val_16.position = new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_11.z};
    }
    internal void 下丗丒丕一与丏不丁(SquareFieldCell 丌丝万上丅丒一丈丘, UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        if(丌丝万上丅丒一丈丘 == 0)
        {
                return;
        }
        
        this.万七丐丅丐世业业丆 = 丌丝万上丅丒一丈丘;
        this.世东世丞丝丘丂业上 = 下业丕七东丌丝下且;
        mem[1152921539191038940] = 下业丕七东丌丝下且.y;
        mem[1152921539191038944] = 下业丕七东丌丝下且.z;
    }
    internal System.Collections.Generic.List<T> 丌丆丘丟丛丝丙丌丘<T>()
    {
        goto label_2;
        label_10:
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this._objectsPlacePoint.GetChild(index:  0), y:  0);
        0 = 1;
        label_2:
        if(0 < this._objectsPlacePoint.childCount)
        {
            goto label_10;
        }
        
        return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 48;
    }
    internal void 丝世丛三丌不丂与丗(UnityEngine.Vector3 丑丕专万丝七丄丞且, SquareFieldCellSize 与丆丆东丌丈丏世丄, int 七丅丗丆丒丌丑丝不, PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        UnityEngine.Object val_29;
        var val_30;
        UnityEngine.Object val_31;
        var val_32;
        var val_33;
        if(this.丅业丁丆丂业一丐专 != 0)
        {
                this.丐丒丒丏丈丄丘丑丘(万且万且丑丗且丌丆:  this.丅业丁丆丂业一丐专);
        }
        
        val_29 = this.丈丟丂丐一丝一丈丞(与丆丆东丌丈丏世丄:  与丆丆东丌丈丏世丄);
        if(val_29 == 0)
        {
                return;
        }
        
        val_29 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_29, parent:  this._objectsPlacePoint);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        val_29.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        val_29.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        this.SelectedObject = val_29;
        FortFieldSetupUtility.丄丘七三上丕世丞业.丌丄丛丒丙丄丟丞丘(七丁万不丐丂上世万:  this.丅业丁丆丂业一丐专.transform);
        val_30 = "FortField\\FortItemsContent\\InGame\\";
        if((System.String.op_Equality(a:  业世丟丐丘丐专与不.SubcategoryName, b:  "FortSupport")) != true)
        {
                string val_14 = ((System.String.op_Equality(a:  业世丟丐丘丐专与不.SubcategoryName, b:  "FortTraps")) != true) ? (val_30) : "FortField\\FortItemsContent\\";
        }
        
        SquareFieldCell val_15 = val_29.GetComponent<SquareFieldCell>();
        if(val_15 == 0)
        {
                return;
        }
        
        if((业世丟丐丘丐专与不.uploadItemNames == null) || (业世丟丐丘丐专与不.uploadItemNames.Count == 0))
        {
            goto label_28;
        }
        
        val_31 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_14 + 业世丟丐丘丐专与不.uploadItemNames.Item[0]);
        if(val_31 == 0)
        {
                val_31 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_14 + "unknown_item");
        }
        
        if(val_31 == 0)
        {
            goto label_35;
        }
        
        val_32 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_31);
        if(val_15 != null)
        {
            goto label_42;
        }
        
        goto label_39;
        label_35:
        UnityEngine.Debug.LogError(message:  "Cant load object: "("Cant load object: ") + val_14 + "unknown_item");
        label_28:
        val_32 = 0;
        if(val_15 != null)
        {
            goto label_42;
        }
        
        label_39:
        label_42:
        val_33 = 0;
        if( != 0)
        {
                丐丌与丘丂丆丆丑丕(丞丈丌且东丆丅丗万:  true);
        }
        
        this.丈丂丒下不丘丄丄七();
        this.业七丘丒丅丏丝丛丘(万且万且丑丗且丌丆:  val_29);
    }
    internal void 业东丘丅上丙上专丝(UnityEngine.Vector3 丑丕专万丝七丄丞且, SquareFieldCellSize 与丆丆东丌丈丏世丄, int 七丅丗丆丒丌丑丝不, PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        UnityEngine.Object val_27;
        float val_28;
        var val_29;
        UnityEngine.Object val_30;
        var val_31;
        val_27 = this.丈丟丂丐一丝一丈丞(与丆丆东丌丈丏世丄:  与丆丆东丌丈丏世丄);
        if(val_27 == 0)
        {
                return;
        }
        
        if((业世丟丐丘丐专与不.cellSize == 4) && ((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != true))
        {
                UnityEngine.Vector3 val_5 = FortFieldTurretPlatformController.instance.GetNearestPlatfrom(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 丑丕专万丝七丄丞且.x, y = 丑丕专万丝七丄丞且.y, z = 丑丕专万丝七丄丞且.z});
            val_28 = val_5.y;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_28, z = val_5.z}, b:  new UnityEngine.Vector3() {x = 丑丕专万丝七丄丞且.x, y = 丑丕专万丝七丄丞且.y, z = 丑丕专万丝七丄丞且.z})) > 0.1f)
        {
                this.丂上世丂下万与丟丁 = true;
            return;
        }
        
        }
        
        UnityEngine.GameObject val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_27, parent:  this._objectsPlacePoint);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_7.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        val_28 = val_11.y;
        val_7.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_28, z = val_11.z, w = val_11.w};
        val_29 = "FortField\\FortItemsContent\\InGame\\";
        val_27 = mem[val_15 != true ? val_29 : "FortField\\FortItemsContent\\"];
        val_27 = ((System.String.op_Equality(a:  业世丟丐丘丐专与不.SubcategoryName, b:  "FortTraps")) != true) ? (val_29) : "FortField\\FortItemsContent\\";
        SquareFieldCell val_17 = val_7.GetComponent<SquareFieldCell>();
        if(val_17 == 0)
        {
                return;
        }
        
        if((业世丟丐丘丐专与不.uploadItemNames == null) || (业世丟丐丘丐专与不.uploadItemNames.Count == 0))
        {
            goto label_29;
        }
        
        val_30 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_27 + 业世丟丐丘丐专与不.uploadItemNames.Item[0]);
        if(val_30 == 0)
        {
                val_30 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_27 + "unknown_item");
        }
        
        val_31 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_30);
        if(val_17 != null)
        {
            goto label_38;
        }
        
        goto label_37;
        label_29:
        val_31 = 0;
        if(val_17 != null)
        {
            goto label_38;
        }
        
        label_37:
        label_38:
        if(val_17 == null)
        {
            
        }
    
    }
    private UnityEngine.GameObject 丈丟丂丐一丝一丈丞(SquareFieldCellSize 与丆丆东丌丈丏世丄)
    {
        if((this.丑丝丌丑一业丌丞七.ContainsKey(key:  与丆丆东丌丈丏世丄)) != false)
        {
                if(this.丑丝丌丑一业丌丞七 != null)
        {
                return this.丑丝丌丑一业丌丞七.Item[与丆丆东丌丈丏世丄];
        }
        
            return this.丑丝丌丑一业丌丞七.Item[与丆丆东丌丈丏世丄];
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "FortField\\Prefabs\\FortBuildCell{0}", arg0:  与丆丆东丌丈丏世丄));
        this.丑丝丌丑一业丌丞七.Add(key:  与丆丆东丌丈丏世丄, value:  val_3);
        return val_3;
    }
    internal bool 丁业丙丘丑丙且专丐()
    {
        if(this.丅业丁丆丂业一丐专 != 0)
        {
                0 = this.丅业丁丆丂业一丐专.GetComponent<SquareFieldSelectableCell>();
        }
        
        if(0 != 0)
        {
                if(this.丅一丑丂丐丕丗丄丄() == false)
        {
            goto label_10;
        }
        
        }
        
        return false;
        label_10:
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.世东世丞丝丘丂业上, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) > 0.1f)
        {
                0.丈丒不丑三丄丏丅丌(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = this.世东世丞丝丘丂业上, y = 0.1f, z = V9.16B});
        }
        
        0.丐丌与丘丂丆丆丑丕(丞丈丌且东丆丅丗万:  false);
        this.SelectedObject = 0;
        FortFieldSetupUtility.丄丘七三上丕世丞业.丛丁丗一丛万东下东();
        this.丈丂丒下不丘丄丄七();
        ClanFieldBuildController.丑七不且上丗丁一世().万丘丂丕丌丐东丐丄();
        if((UnityEngine.Object.op_Implicit(exists:  Base_BuildingUI.instance)) == false)
        {
                return false;
        }
        
        Base_BuildingUI.instance.丝且七丑不丘丘丏万(丌丄丗七丝丘与丆与:  false);
        return false;
    }
    internal void 业七丘丒丅丏丝丛丘(UnityEngine.GameObject 万且万且丑丗且丌丆)
    {
        FortFieldSetupUtility val_8;
        if(PGCompany.丂丘丞丂丏七丁丄不.丄专东丒丒专丒不业() == false)
        {
                return;
        }
        
        if(万且万且丑丗且丌丆 == 0)
        {
                return;
        }
        
        SquareFieldSelectableCell val_3 = 万且万且丑丗且丌丆.GetComponent<SquareFieldSelectableCell>();
        if(val_3 == 0)
        {
                return;
        }
        
        if(mem[137134148] == 0)
        {
                return;
        }
        
        val_3.丙且七丛一上丆下丁();
        this.万七丐丅丐世业业丆 = 0;
        this.世东世丞丝丘丂业上 = mem[137134148];
        mem[1152921539192201888] = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
        val_8 = FortFieldSetupUtility.丄丘七三上丕世丞业;
        val_8.丌丄丛丒丙丄丟丞丘(七丁万不丐丂上世万:  val_3.丌丟丄业且三丛丕丄());
        val_3.丐丌与丘丂丆丆丑丕(丞丈丌且东丆丅丗万:  true);
        this.SelectedObject = val_3.gameObject;
        val_3.丕丕业七丙七丅丈丄();
        this.丈丂丒下不丘丄丄七();
        val_3.万丕万与东且丅丌与();
        this = Base_BuildingUI.instance;
        if((UnityEngine.Object.op_Implicit(exists:  this)) == false)
        {
                return;
        }
        
        Base_BuildingUI.instance.丛世丟丁丅下丌丅丐(丌丄丗七丝丘与丆与:  false);
    }
    internal void 丐丒丒丏丈丄丘丑丘(UnityEngine.GameObject 万且万且丑丗且丌丆)
    {
        UnityEngine.Object val_10;
        var val_11;
        FortFieldSetupUtility val_12;
        val_10 = 万且万且丑丗且丌丆;
        val_11 = this;
        val_12 = FortFieldSetupUtility.丄丘七三上丕世丞业;
        val_12.丛丁丗一丛万东下东();
        if(val_10 != null)
        {
                val_10 = val_10.GetComponent<SquareFieldSelectableCell>();
        }
        
        if(val_10 == 0)
        {
                return;
        }
        
        val_12 = this.丌丆丘丟丛丝丙丌丘<SquareFieldSelectableCell>();
        if((val_12.Contains(item:  val_10)) == false)
        {
                return;
        }
        
        val_12 = val_10.gameObject.transform;
        val_12.SetParent(p:  0);
        UnityEngine.Object.DestroyImmediate(obj:  val_10.gameObject);
        this.SelectedObject = 0;
        this.丈丂丒下不丘丄丄七();
        ClanFieldBuildController.丑七不且上丗丁一世().万丘丂丕丌丐东丐丄();
        val_11 = 1152921505159561216;
        if((UnityEngine.Object.op_Implicit(exists:  Base_BuildingUI.instance)) == false)
        {
                return;
        }
        
        Base_BuildingUI.instance.丝且七丑不丘丘丏万(丌丄丗七丝丘与丆与:  false);
    }
    internal bool 七东一下丌万丁东一(bool 丂万丅万丑东丒丒丘)
    {
        UnityEngine.Object val_14;
        Base_BuildingUI val_15;
        UnityEngine.Object val_16;
        var val_17;
        var val_18;
        float val_19;
        float val_20;
        float val_21;
        UnityEngine.Vector3 val_22;
        var val_23;
        val_14 = 丂万丅万丑东丒丒丘;
        val_15 = this;
        val_16 = 0;
        if(this.丅业丁丆丂业一丐专 != 0)
        {
                val_16 = this.丅业丁丆丂业一丐专.GetComponent<SquareFieldSelectableCell>();
        }
        
        if((val_16 != 0) && (val_16.世万丆三一丌且丟一() != false))
        {
                FortFieldSetupUtility.丄丘七三上丕世丞业.丛丁丗一丛万东下东();
            SquareFieldPhysicsCell val_5 = val_16.三不丂与万丝业与丌();
            val_17 = 0;
        }
        else
        {
                val_18 = 0;
            return (bool)val_18;
        }
        
        if((this.丌丆丘丟丛丝丙丌丘<SquareFieldSelectableCell>().Contains(item:  null)) != false)
        {
                if(val_14 != false)
        {
                val_14 = gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  val_14);
        }
        else
        {
                val_19 = val_2.世专七丘万丌一丟丗;
            val_20 = V9.16B;
            val_21 = V8.16B;
            丈丒不丑三丄丏丅丌(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21});
        }
        
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.世东世丞丝丘丂业上, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) > 0.1f)
        {
                val_22 = this.世东世丞丝丘丂业上;
            val_16.丈丒不丑三丄丏丅丌(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_22, y = V9.16B, z = this.世东世丞丝丘丂业上});
        }
        
        if(val_16 != null)
        {
                val_23 = 0;
            val_16.丐丌与丘丂丆丆丑丕(丞丈丌且东丆丅丗万:  false);
        }
        else
        {
                val_23 = 0;
            0.丐丌与丘丂丆丆丑丕(丞丈丌且东丆丅丗万:  false);
        }
        
        this.SelectedObject = 0;
        this.丈丂丒下不丘丄丄七();
        ClanFieldBuildController.丑七不且上丗丁一世().万丘丂丕丌丐东丐丄();
        val_15 = Base_BuildingUI.instance;
        if((UnityEngine.Object.op_Implicit(exists:  val_15)) != false)
        {
                val_15 = Base_BuildingUI.instance;
            val_15.丝且七丑不丘丘丏万(丌丄丗七丝丘与丆与:  false);
        }
        
        val_18 = 1;
        return (bool)val_18;
    }
    internal void 丝丐丈业丘丂丐丁丞()
    {
        Base_BuildingUI val_5;
        UnityEngine.Object val_6;
        float val_7;
        float val_8;
        float val_9;
        var val_10;
        val_5 = this;
        if(this.丅业丁丆丂业一丐专 != null)
        {
                val_6 = this.丅业丁丆丂业一丐专.GetComponent<SquareFieldSelectableCell>();
        }
        else
        {
                val_6 = 0;
        }
        
        if(val_6 == 0)
        {
                return;
        }
        
        this.世东世丞丝丘丂业上 = 123372728;
        mem[1152921539192683296] = 123372728;
        if(val_6 != 0)
        {
                val_7 = 1.64395E-34f;
            val_8 = 0f;
            val_9 = 1.64395E-34f;
        }
        else
        {
                val_7 = 1.64395E-34f;
            val_8 = 0f;
            val_9 = 1.64395E-34f;
        }
        
        val_6.丈丒不丑三丄丏丅丌(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9});
        ClanFieldBuildController.丑七不且上丗丁一世().业七东丆丐一丛丈丏();
        if(val_6 != 0)
        {
                val_10 = 0;
            val_6.丐丌与丘丂丆丆丑丕(丞丈丌且东丆丅丗万:  false);
        }
        else
        {
                val_10 = 0;
            0.丐丌与丘丂丆丆丑丕(丞丈丌且东丆丅丗万:  false);
        }
        
        FortFieldSetupUtility.丄丘七三上丕世丞业.丛丁丗一丛万东下东();
        this.SelectedObject = 0;
        this.丈丂丒下不丘丄丄七();
        val_5 = Base_BuildingUI.instance;
        if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
        {
                return;
        }
        
        Base_BuildingUI.instance.丝且七丑不丘丘丏万(丌丄丗七丝丘与丆与:  false);
    }
    internal void 丏丛不下一丝专丕丙()
    {
        FortFieldSetupUtility.丄丘七三上丕世丞业.丛丁丗一丛万东下东();
        List.Enumerator<T> val_2 = this.丌丆丘丟丛丝丙丌丘<SquareFieldSelectableCell>().GetEnumerator();
        label_10:
        if((226234632 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        val_3.gameObject.transform.SetParent(p:  0);
        UnityEngine.Object.DestroyImmediate(obj:  val_3.gameObject);
        goto label_10;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丈丂丒下不丘丄丄七();
    }
    internal void 丈丂丒下不丘丄丄七()
    {
        List.Enumerator<T> val_2 = this.丌丆丘丟丛丝丙丌丘<SquareFieldCell>().GetEnumerator();
        label_4:
        if((226383512 & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() != null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this._selectedObjectUi == 0)
        {
                return;
        }
        
        this = this._selectedObjectUi;
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝丘与不丐丞七世丑(UnityEngine.Vector3 丒丈丘业丛丁丏丙丘)
    {
        if(this.丅业丁丆丂业一丐专 == 0)
        {
                return;
        }
        
        this = this.丅业丁丆丂业一丐专.GetComponent<SquareFieldSelectableCell>();
        if(this == 0)
        {
                return;
        }
        
        this.丈丌丝丐丆不且万不(丙业与丙丗丝不丈东:  null + ((丒丈丘业丛丁丏丙丘.x > 0f) ? 89 : 90));
    }
    internal static UnityEngine.Vector3 丏东七万丞丆丅丒丕(UnityEngine.Vector3 下业丕七东丌丝下且, float 丟七丘一丈万业专下)
    {
        double val_11;
        SquareField val_12;
        double val_13;
        float val_9 = (float)System.Math.Truncate(d:  (double)下业丕七东丌丝下且.x);
        val_9 = 下业丕七东丌丝下且.x - val_9;
        if(System.Math.Abs(val_9) > SquareField.丄丘七三上丕世丞业.delta)
        {
                float val_3 = UnityEngine.Mathf.Sign(f:  下业丕七东丌丝下且.x);
            val_3 = val_3 * ((float)UnityEngine.Mathf.CeilToInt(f:  System.Math.Abs(下业丕七东丌丝下且.x)));
            val_11 = (double)val_3;
        }
        else
        {
                val_11 = System.Math.Truncate(d:  (double)下业丕七东丌丝下且.x);
        }
        
        float val_12 = (float)System.Math.Truncate(d:  (double)下业丕七东丌丝下且.z);
        val_12 = 下业丕七东丌丝下且.z - val_12;
        val_12 = SquareField.丄丘七三上丕世丞业;
        if(System.Math.Abs(val_12) > SquareField.丄丘七三上丕世丞业.delta)
        {
                val_12 = UnityEngine.Mathf.CeilToInt(f:  System.Math.Abs(下业丕七东丌丝下且.z));
            float val_7 = UnityEngine.Mathf.Sign(f:  下业丕七东丌丝下且.z);
            val_7 = val_7 * (float)val_12;
            val_13 = (double)val_7;
        }
        else
        {
                val_13 = (double)下业丕七东丌丝下且.z;
            double val_8 = System.Math.Truncate(d:  val_13);
        }
        
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal static UnityEngine.Vector3 上丅专世不丗东丑丛(UnityEngine.Vector3 丗丒且世丆专丄三专, float 丟七丘一丈万业专下)
    {
        丗丒且世丆专丄三专.x = 丗丒且世丆专丄三专.x / 丟七丘一丈万业专下;
        丗丒且世丆专丄三专.z = ((float)UnityEngine.Mathf.RoundToInt(f:  丗丒且世丆专丄三专.z / 丟七丘一丈万业专下)) * 丟七丘一丈万业专下;
        float val_4 = ((float)UnityEngine.Mathf.RoundToInt(f:  丗丒且世丆专丄三专.x)) * 丟七丘一丈万业专下;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal FortBuildingPlace 丝丈丌上丝一丑丙丘(UnityEngine.GameObject 丁丂丝不丟丛丟一丂)
    {
        UnityEngine.Object val_5;
        if((this.世东万丗世丗丈丈丞.ContainsKey(key:  丁丂丝不丟丛丟一丂)) != false)
        {
                val_5 = this.世东万丗世丗丈丈丞.Item[丁丂丝不丟丛丟一丂];
            return (FortBuildingPlace)val_5;
        }
        
        val_5 = 丁丂丝不丟丛丟一丂.GetComponent<FortBuildingPlace>();
        if(val_5 == 0)
        {
                return (FortBuildingPlace)val_5;
        }
        
        this.世东万丗世丗丈丈丞.Add(key:  丁丂丝不丟丛丟一丂, value:  val_5);
        return (FortBuildingPlace)val_5;
    }
    private bool 丅一丑丂丐丕丗丄丄()
    {
        var val_6;
        var val_19;
        if(this.万七丐丅丐世业业丆 == 0)
        {
            goto label_3;
        }
        
        ClanFieldBuildController val_2 = ClanFieldBuildController.丑七不且上丗丁一世();
        Dictionary.Enumerator<TKey, TValue> val_3 = val_2.专丁丑世业丌丏丁丛.GetEnumerator();
        label_21:
        if((227079584 & 1) == 0)
        {
            goto label_8;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        if((val_7._value._obj.丐丏七丌丕丗业且上() == 0) || (val_7._value._obj.丐丏七丌丕丗业且上().transform == this.万七丐丅丐世业业丆.transform))
        {
            goto label_21;
        }
        
        UnityEngine.Vector3 val_16 = val_7._value._obj.丐丏七丌丕丗业且上().transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = this.世东世丞丝丘丂业上, y = V11.16B, z = V12.16B})) >= 0)
        {
            goto label_21;
        }
        
        val_19 = 1;
        goto label_22;
        label_8:
        val_19 = 0;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_19;
        label_3:
        val_19 = 0;
        return (bool)val_19;
    }
    public SquareField()
    {
        this.minDistanceDelta = 2.5f;
        this.distanceDelta = 25f;
        this.世东万丗世丗丈丈丞 = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, FortBuildingPlace>();
        this._cellSize = 1f;
        this.lerpSpeed = 15f;
        this.lerpHeightSpeed = 5f;
        this.delta = 0.8f;
        this.丑丝丌丑一业丌丞七 = new System.Collections.Generic.Dictionary<SquareFieldCellSize, UnityEngine.GameObject>();
    }

}
