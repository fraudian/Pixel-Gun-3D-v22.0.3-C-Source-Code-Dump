using UnityEngine;
public class ClanTankBuildBase : PGBehaviour
{
    // Fields
    public System.Collections.Generic.List<ClanTankPlaceableItemPoint> itemPoints;
    public ClanTankPlaceableItemPoint selectedItemPoint;
    public static ClanTankBuildBase instance;
    private System.Action 东下且上三丅且丅丗;
    public bool clickOnPointEnabled;
    private 世专丙丟且丗丄丆丌 丞丁三且世丈丑丞七;
    private readonly System.Collections.Generic.List<ClanTankEquipInfo> 丅丆丒且且业上丕丗;
    
    // Methods
    internal void 丈东丑丑丅丘丄丌丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.东下且上三丅且丅丗, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.东下且上三丅且丅丗 != 1152921536867741112);
    
    }
    internal void 业上丗丝丆丁丛丏丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.东下且上三丅且丅丗, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.东下且上三丅且丅丗 != 1152921536867877688);
    
    }
    private void Awake()
    {
        ClanTankBuildBase.instance = this;
        this.丅丆丒且且业上丕丗.Add(item:  new ClanTankEquipInfo(下丁丒丕丅丄丂丛丅:  0, 与下丕三丒东上丗上:  "tank_maingun_cannon"));
        this.丅丆丒且且业上丕丗.Add(item:  new ClanTankEquipInfo(下丁丒丕丅丄丂丛丅:  9, 与下丕三丒东上丗上:  "tank_texture_map_default"));
        this.丅丆丒且且业上丕丗.Add(item:  new ClanTankEquipInfo(下丁丒丕丅丄丂丛丅:  10, 与下丕三丒东上丗上:  "tank_tower_color_default"));
    }
    private void Start()
    {
        if(Base_BuildingUI.instance == 0)
        {
                return;
        }
        
        this.丞丁三且世丈丑丞七 = Base_BuildingUI_Controller.instance;
        this.UpdateView();
        Base_BuildingUI.instance.丌丐与丙东万上丛东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTankBuildBase::丆丆丆丆不丗丅丛丄()));
        Base_BuildingUI.instance.世业丐丏丗业丟一上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTankBuildBase::丆丆丆丆不丗丅丛丄()));
        Base_BuildingUI.instance.丐丗世三丝丞专三一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTankBuildBase::丞丌专丞上与一丆丂()));
        if(this.丞丁三且世丈丑丞七 == null)
        {
                return;
        }
        
        this.丞丁三且世丈丑丞七.丂丆丒丟七丐丒丘上(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanTankBuildBase::上丄丐丞丄与下丄丆(int 丈丘丝一丗下丈丐不)));
    }
    private void OnDestroy()
    {
        if((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != false)
        {
                if((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) != null)
        {
                return;
        }
        
        }
        
        if(this.丞丁三且世丈丑丞七 == null)
        {
                return;
        }
        
        this.丞丁三且世丈丑丞七.丛丝万丕丆丘一下与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanTankBuildBase::上丄丐丞丄与下丄丆(int 丈丘丝一丗下丈丐不)));
    }
    private void 上丄丐丞丄与下丄丆(int 丈丘丝一丗下丈丐不)
    {
        this.UpdateView();
    }
    private void 丞丌专丞上与一丆丂()
    {
        this.丌专丝七丘三丑丕下(业世丟丐丘丐专与不:  Base_BuildingUI.instance.selectedItemSettings);
    }
    private void 丌专丝七丘三丑丕下(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        PlaceableItemSettings val_7 = 业世丟丐丘丐专与不;
        if(this.selectedItemPoint == 0)
        {
                return;
        }
        
        if(this.selectedItemPoint.itemSettings == val_7)
        {
                return;
        }
        
        val_7 = ???;
        goto typeof(ClanTankPlaceableItemPoint).__il2cppRuntimeField_178;
    }
    private void 丅丈世一七丒且丌丁()
    {
        if(this.selectedItemPoint == 0)
        {
                return;
        }
        
        this.selectedItemPoint.SetupPlaced();
    }
    private void 丆丆丆丆不丗丅丛丄()
    {
        if(Base_BuildingUI.instance != null)
        {
            goto label_1;
        }
        
        Base_BuildingUI.instance = Base_BuildingUI.instance;
        if(Base_BuildingUI.instance == null)
        {
            goto label_2;
        }
        
        label_1:
        this.且丒万丞丕丏业业丄(七丆丒与丗丌丄且丂:  Base_BuildingUI.instance.selectedCategory, 丒丑丞丁世丌专不丈:  Base_BuildingUI.instance.selectedSubcategory);
        return;
        label_2:
    }
    private void 且丒万丞丕丏业业丄(string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈)
    {
        string val_12;
        var val_13;
        System.Func<ClanTankPlaceableItemPoint, System.Boolean> val_15;
        ClanTankBuildBase.三丅丞丒丕丅专一丅 val_1 = new ClanTankBuildBase.三丅丞丒丕丅专一丅();
        if(val_1 != null)
        {
                val_12 = val_1;
            .七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
        }
        else
        {
                val_12 = 16;
            mem[16] = 七丆丒与丗丌丄且丂;
        }
        
        .丒丑丞丁世丌专不丈 = 丒丑丞丁世丌专不丈;
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<ClanTankPlaceableItemPoint>(source:  this.itemPoints, predicate:  new System.Func<ClanTankPlaceableItemPoint, System.Boolean>(object:  val_1, method:  System.Boolean ClanTankBuildBase.三丅丞丒丕丅专一丅::业丈不一丅一丗与丝(ClanTankPlaceableItemPoint 三丟东丕丄丄下下丑)));
        val_13 = null;
        val_13 = null;
        val_15 = ClanTankBuildBase.<>c.<>9__17_1;
        if(val_15 == null)
        {
                System.Func<ClanTankPlaceableItemPoint, System.Boolean> val_4 = null;
            val_15 = val_4;
            val_4 = new System.Func<ClanTankPlaceableItemPoint, System.Boolean>(object:  ClanTankBuildBase.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanTankBuildBase.<>c::东且丒丝世丞丏丒丘(ClanTankPlaceableItemPoint 三丟东丕丄丄下下丑));
            ClanTankBuildBase.<>c.<>9__17_1 = val_15;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<ClanTankPlaceableItemPoint>(source:  val_3, predicate:  val_4);
        if((this.selectedItemPoint != 0) && ((System.String.op_Equality(a:  this.selectedItemPoint.category, b:  val_12)) != false))
        {
                if((System.String.op_Equality(a:  this.selectedItemPoint.subcategory, b:  (ClanTankBuildBase.三丅丞丒丕丅专一丅)[1152921536869197520].丒丑丞丁世丌专不丈)) != false)
        {
                return;
        }
        
        }
        
        this.OnSelectItemPoint(丌丐下丆七丒丒丑丕:  System.Linq.Enumerable.FirstOrDefault<ClanTankPlaceableItemPoint>(source:  ((System.Linq.Enumerable.Any<ClanTankPlaceableItemPoint>(source:  val_5)) != true) ? (val_5) : (val_3)));
    }
    public void OnSelectItemPoint(ClanTankPlaceableItemPoint 丌丐下丆七丒丒丑丕)
    {
        Base_BuildingUI val_2;
        ClanTankPlaceableItemPoint val_3;
        this.丅丈世一七丒且丌丁();
        this.selectedItemPoint = 丌丐下丆七丒丒丑丕;
        val_2 = Base_BuildingUI.instance;
        Base_BuildingUI.instance.selectedItemSettings = 丌丐下丆七丒丒丑丕.itemSettings;
        this.UpdateView();
        if(丌丐下丆七丒丒丑丕 == 0)
        {
            goto label_5;
        }
        
        val_2 = 丌丐下丆七丒丒丑丕.itemSettings;
        if(val_2 == null)
        {
            goto label_6;
        }
        
        if(Base_BuildingUI.instance != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_6:
        val_3 = this.selectedItemPoint;
        if(this.selectedItemPoint != null)
        {
            goto label_9;
        }
        
        val_3 = this.selectedItemPoint;
        if(val_3 == null)
        {
            goto label_10;
        }
        
        label_9:
        val_2 = this.selectedItemPoint.category;
        label_8:
        Base_BuildingUI.instance.丝且七丑不丘丘丏万(丌丄丗七丝丘与丆与:  false);
        label_5:
        if(this.东下且上三丅且丅丗 == null)
        {
                return;
        }
        
        this.东下且上三丅且丅丗.Invoke();
        return;
        label_10:
    }
    public void UpdateView()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        if(ClanTankBuildController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_9 = 0;
        goto label_6;
        label_17:
        ClanTankPlaceableItemPoint val_2 = this.itemPoints.Item[0];
        val_10 = null;
        val_10 = null;
        RootBuildingLevelData val_4 = 0.丒丑丛世丘业丗丑丛().丞丘丕丈丄丛且丝东();
        val_2.Active = (val_9 < val_4.buldSlots) ? 1 : 0;
        ClanTankPlaceableItemPoint val_6 = this.itemPoints.Item[0];
        val_9 = 1;
        label_6:
        if(val_9 < this.itemPoints.Count)
        {
            goto label_17;
        }
    
    }
    public void CollectItemPints()
    {
        System.Collections.Generic.List<ClanTankPlaceableItemPoint> val_5;
        var val_6;
        this.itemPoints.Clear();
        val_5 = System.Linq.Enumerable.ToList<ClanTankPlaceableItemPoint>(source:  this.GetComponentsInChildren<ClanTankPlaceableItemPoint>());
        this.itemPoints = val_5;
        val_6 = 0;
        goto label_2;
        label_6:
        ClanTankPlaceableItemPoint val_3 = this.itemPoints.Item[0];
        val_5 = this.itemPoints;
        val_6 = 1;
        label_2:
        if(val_6 < val_5.Count)
        {
            goto label_6;
        }
        
        this.OnSelectItemPoint(丌丐下丆七丒丒丑丕:  0);
    }
    public ClanTankPlaceableItemPoint GetPlaceablePointById(int 世丟丄丅丛世丝丑丕)
    {
        System.Collections.Generic.List<ClanTankPlaceableItemPoint> val_4;
        var val_5;
        var val_6;
        val_4 = 世丟丄丅丛世丝丑丕;
        val_5 = 0;
        goto label_1;
        label_6:
        ClanTankPlaceableItemPoint val_1 = this.itemPoints.Item[0];
        if(val_1.placeId == val_4)
        {
            goto label_4;
        }
        
        val_5 = 1;
        label_1:
        if(val_5 < this.itemPoints.Count)
        {
            goto label_6;
        }
        
        val_6 = 0;
        return (ClanTankPlaceableItemPoint)val_4.Item[0];
        label_4:
        val_4 = this.itemPoints;
        return (ClanTankPlaceableItemPoint)val_4.Item[0];
    }
    public ClanTankPlaceableItemPoint GetNearestPlaceableItemPoint(UnityEngine.Vector3 丝东丝万丟一丝业与)
    {
        var val_3;
        var val_10;
        var val_11;
        List.Enumerator<T> val_1 = this.itemPoints.GetEnumerator();
        val_10 = 0;
        goto label_10;
        label_11:
        string val_4 = val_3.丐丏七丌丕丗业且上();
        val_11 = val_4.gameObject;
        if(val_11.activeSelf != false)
        {
                val_11 = val_4.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_8 = val_11.position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = 丝东丝万丟一丝业与.x, y = 丝东丝万丟一丝业与.y, z = 丝东丝万丟一丝业与.z})) < 0)
        {
                val_10 = val_4;
        }
        
        }
        
        label_10:
        if(((-2096514608) & 1) != 0)
        {
            goto label_11;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (ClanTankPlaceableItemPoint)val_10;
    }
    internal void 丄丅丙一上丝丐丒丝(System.Collections.Generic.List<ClanTankEquipInfo> 一丐丗丁丞丆丅丟丄)
    {
        string val_3;
        System.Collections.Generic.List<ClanTankEquipInfo> val_15;
        var val_16;
        System.Collections.Generic.List<ClanTankPlaceableItemPoint> val_17;
        val_15 = 一丐丗丁丞丆丅丟丄;
        val_16 = this;
        val_17 = this.itemPoints;
        List.Enumerator<T> val_1 = val_17.GetEnumerator();
        label_6:
        if(((-2096349216) & 1) == 0)
        {
            goto label_2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_15 != null)
        {
            goto label_7;
        }
        
        goto label_12;
        label_7:
        if(val_15.Count != 0)
        {
            goto label_14;
        }
        
        label_12:
        val_15 = this.丅丆丒且且业上丕丗;
        label_14:
        List.Enumerator<T> val_6 = val_15.GetEnumerator();
        label_28:
        if(((-2096349248) & 1) == 0)
        {
            goto label_15;
        }
        
        string val_7 = val_3.丐丏七丌丕丗业且上();
        ClanTankPlaceableItemPoint val_8 = this.GetPlaceablePointById(世丟丄丅丛世丝丑丕:  val_7.m_stringLength);
        PlaceableItemSettings val_9 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  null);
        if(val_9 == null)
        {
                if(((System.String.IsNullOrEmpty(value:  val_9)) ^ 1) != false)
        {
                UnityEngine.Debug.LogError(message:  " setted unwnown item: "(" setted unwnown item: ") + 0);
        }
        
        }
        
        if(((val_9 == null) || (((UnityEngine.Object.op_Inequality(x:  val_8, y:  0)) ^ 1) == true)) || (val_8 != null))
        {
            goto label_28;
        }
        
        goto label_28;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ClanTankBuildBase()
    {
        this.itemPoints = new System.Collections.Generic.List<ClanTankPlaceableItemPoint>();
        this.clickOnPointEnabled = true;
        this.丅丆丒且且业上丕丗 = new System.Collections.Generic.List<ClanTankEquipInfo>();
    }

}
