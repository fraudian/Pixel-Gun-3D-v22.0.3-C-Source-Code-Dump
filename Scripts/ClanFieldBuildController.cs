using UnityEngine;
internal class ClanFieldBuildController : MonoBehaviour
{
    // Fields
    private static System.Action<int> 上丄丐丞丄与下丄丆;
    private bool 丗专丟丈丁丑业专丒;
    private System.Action 专且丏与丂上丙丘丌;
    internal System.Collections.Generic.Dictionary<UnityEngine.GameObject, PlaceableItemSettings> 专丁丑世业丌丏丁丛;
    private Rilisoft.丝丑丂丛万丐丈丘且 上丝东丈丂丐丌丅与;
    private SquareField _field;
    private SquareFieldTouch _fieldTouch;
    private static ClanFieldBuildController <不丁丄七丛不丆丁丕>k__BackingField;
    internal static float 丝丅专丅丙丑丝三丒;
    
    // Properties
    internal 世专丙丟且丗丄丆丌 下丁下丌丟丒世丙丕 { get; }
    public int 丌世丙七丒丑与丝丗 { get; set; }
    internal int 世东丂丈七丐丐一丁 { get; set; }
    public int 丙世丈丏丝丄七业丙 { get; }
    internal UnityEngine.GameObject 七丅丁丝丁丘丛丕丂 { get; }
    internal SquareField 丛业丛丑丈三丛丟业 { get; }
    internal SquareFieldTouch 不万丅丑一丒三下丝 { get; }
    internal static ClanFieldBuildController 丆丕丝丒不丙且丐丗 { get; set; }
    
    // Methods
    internal static void 且丌三业上丌丌七丟(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  ClanFieldBuildController.上丄丐丞丄与下丄丆, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 业丞丕业一七丅丅丒(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  ClanFieldBuildController.上丄丐丞丄与下丄丆, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal void 丂丑丏上丑丕丏与丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.专且丏与丂上丙丘丌, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专且丏与丂上丙丘丌 != 1152921536487407888);
    
    }
    internal void 三丛丗丘丞丕丒丝七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.专且丏与丂上丙丘丌, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专且丏与丂上丙丘丌 != 1152921536487544464);
    
    }
    internal 世专丙丟且丗丄丆丌 丒丑丛世丘业丗丑丛()
    {
        return 丂丘丗丗与且丌丁丙.丕上丒丅丝丛丒丐丅();
    }
    public int get_MaxBuildEnergy()
    {
        RootBuildingLevelData val_2 = this.丒丑丛世丘业丗丑丛().丞丘丕丈丄丛且丝东();
    }
    public void set_MaxBuildEnergy(int 丙业与丙丗丝不丈东)
    {
    
    }
    internal int 丑丐且且丙丙丒专七()
    {
    
    }
    internal void 业丁一业丐丐与专丕(int 丙业与丙丗丝不丈东)
    {
        int val_3 = UnityEngine.Mathf.Clamp(value:  丙业与丙丗丝不丈东, min:  0, max:  Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙().MaxBuildEnergy);
        this.上丝东丈丂丐丌丅与 = 0;
        mem[1152921536488133160] = 0;
    }
    public int get_UsedBuildEnergy()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = this.上丝东丈丂丐丌丅与;
        val_2 = this.MaxBuildEnergy - val_2;
        return (int)val_2;
    }
    internal UnityEngine.GameObject 丑东业且专丗丕丙丕()
    {
        if(this._field != null)
        {
                return this._field.SelectedObject;
        }
        
        return this._field.SelectedObject;
    }
    internal SquareField 丙丆丅丐丝丄与七丒()
    {
        return (SquareField)this._field;
    }
    internal SquareFieldTouch 东丈万与丄丟丞三丆()
    {
        return (SquareFieldTouch)this._fieldTouch;
    }
    internal static ClanFieldBuildController 丑七不且上丗丁一世()
    {
        null = null;
        return (ClanFieldBuildController)ClanFieldBuildController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(ClanFieldBuildController 丙业与丙丗丝不丈东)
    {
        null = null;
        ClanFieldBuildController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        ClanFieldBuildController.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        this._field.丐丗丗丅丐世七万七(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void ClanFieldBuildController::丒丅丕上丁丂丄丕丂(UnityEngine.GameObject 七丁万不丐丂上世万)));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanFieldBuildController::不业丛丑丝丘东丘丅()));
        Base_BuildingUI_Controller.instance.业丆丝不七一七世丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanFieldBuildController::专七七不万丘丑丅丐()));
        Base_BuildingUI_Controller.instance.丒丑丛世丘业丗丑丛().丂丆丒丟七丐丒丘上(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanFieldBuildController::上丗丏丒万丏丑丄万(int 丈丘丝一丗下丈丐不)));
    }
    private void Start()
    {
        this.丟丄丙与丌丂丆专丞();
        this.丗专丟丈丁丑业专丒 = true;
    }
    private void OnDestroy()
    {
        ClanFieldBuildController.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
        this._field.丁专一世丆丄丟丝上(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void ClanFieldBuildController::丒丅丕上丁丂丄丕丂(UnityEngine.GameObject 七丁万不丐丂上世万)));
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanFieldBuildController::不业丛丑丝丘东丘丅()));
        Base_BuildingUI_Controller.instance.世东丂一丄三下业丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanFieldBuildController::专七七不万丘丑丅丐()));
        Base_BuildingUI_Controller.instance.丒丑丛世丘业丗丑丛().丛丝万丕丆丘一下与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanFieldBuildController::上丗丏丒万丏丑丄万(int 丈丘丝一丗下丈丐不)));
    }
    private void 上丗丏丒万丏丑丄万(int 丈丘丝一丗下丈丐不)
    {
        null = null;
        if(ClanFieldBuildController.上丄丐丞丄与下丄丆 == null)
        {
                return;
        }
        
        ClanFieldBuildController.上丄丐丞丄与下丄丆.Invoke(obj:  丈丘丝一丗下丈丐不);
    }
    internal void 万丘丂丕丌丐东丐丄()
    {
        Rilisoft.Singleton<ClansController>.Instance.丏丅七丗丂专丒丌丏().业丐丑丂丞丈与丁丘(上丘丕与丌且七万丟:  this._field);
    }
    internal void 丕与世万不丒丌三丂()
    {
        Rilisoft.Singleton<ClansController>.Instance.丏丅七丗丂专丒丌丏().丐专丞一丏丅丐下丆(上丘丕与丌且七万丟:  this._field);
    }
    internal void 丟丄丙与丌丂丆专丞()
    {
        Rilisoft.Singleton<ClansController>.Instance.丏丅七丗丂专丒丌丏().专丐丝丗丐世上万专(上丘丕与丌且七万丟:  this._field);
        this.业七东丆丐一丛丈丏();
    }
    internal void 与丟丝上丟三丝东丐()
    {
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐());
        if((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != false)
        {
                if((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) != null)
        {
                ClansVisitController val_7 = Rilisoft.Singleton<ClansVisitController>.Instance;
            val_7.丕丁不丅丒丑丁丁世 = true;
        }
        
        }
        
        if((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != false)
        {
                return;
        }
        
        FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂.七丞丒专万且丟丞丅();
        this.丕与世万不丒丌三丂();
    }
    public void U_SaveObjects()
    {
        this.丕与世万不丒丌三丂();
    }
    public void U_LoadObjects()
    {
        this.丟丄丙与丌丂丆专丞();
    }
    public void U_BackToLobby()
    {
        this.与丟丝上丟三丝东丐();
    }
    internal void 且丕丝丆与丒世东丂(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        float val_10;
        SquareFieldCellSize val_14;
        PlaceableItemSettings val_15;
        float val_16;
        val_15 = 业世丟丐丘丐专与不;
        if(val_15 != null)
        {
                丑业专丄七与与丕上 val_13 = 业世丟丐丘丐专与不.itemType;
            val_13 = val_13 & 4294967294;
            if(val_13 == 2)
        {
                return;
        }
        
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            val_16 = val_1.x;
            val_14 = UnityEngine.Camera.main;
            int val_3 = UnityEngine.Screen.width;
            int val_4 = UnityEngine.Screen.height;
            var val_5 = (val_3 < 0) ? (val_3 + 1) : (val_3);
            val_5 = val_5 >> 1;
            var val_7 = ((val_4 < 0) ? (val_4 + 1) : (val_4)) >> 1;
            UnityEngine.Ray val_8 = val_14.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            if((1818809744 & 1) != 0)
        {
                UnityEngine.Vector3 val_11 = SquareField.丏东七万丞丆丅丒丕(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 0f, y = val_10, z = 0f}, 丟七丘一丈万业专下:  1f);
            val_14 = 业世丟丐丘丐专与不.cellSize;
            val_16 = val_11.x;
            this._field.丝世丛三丌不丂与丗(丑丕专万丝七丄丞且:  new UnityEngine.Vector3() {x = val_16, y = val_11.y, z = val_11.z}, 与丆丆东丌丈丏世丄:  val_14, 七丅丗丆丒丌丑丝不:  89, 业世丟丐丘丐专与不:  val_15);
        }
        
            val_15 = Base_BuildingUI.instance;
            if((UnityEngine.Object.op_Implicit(exists:  val_15)) == false)
        {
                return;
        }
        
            val_15 = Base_BuildingUI.instance;
            val_15.丛世丟丁丅下丌丅丐(丌丄丗七丝丘与丆与:  false);
            return;
        }
        
        this.CancelSelectedItem();
    }
    internal void 三三丝丆丁下一与一()
    {
        var val_13;
        if(this._field.丛丐业三丏丏丕丘丏() != null)
        {
                if(ClanFieldBuildController.丑七不且上丗丁一世() != 0)
        {
                ClanFieldBuildController val_5 = ClanFieldBuildController.丑七不且上丗丁一世();
            val_13 = val_5.上丝东丈丂丐丌丅与;
        }
        else
        {
                val_13 = 0;
        }
        
            PlaceableItemSettings val_9 = this._field.丛丐业三丏丏丕丘丏();
            PGCompany.Analytics.一业丗丆世世上丁且.东一不东业与下世丆(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  0, 七丐丅专且专七三丆:  4, 东丝丅专丝丈一丘下:  0, 上丕丟丌上丐丝上上:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上上三七丟丝与丆与(), 丒丘丏上丙丟丑丕丈:  val_9.name, 下丗丁丒丘东丂不丑:  this._field.丛丐业三丏丏丕丘丏().SubcategoryName, 丒世丘丘上丆丝东丞:  0, 丂下丛丝丆丂七丏丘:  0);
        }
        
        if(this._field.丁业丙丘丑丙且专丐() == false)
        {
                return;
        }
        
        CameraMoverDirectoryManager.丄丘七三上丕世丞业.一一丟丑丏丑且三丒();
        this.业七东丆丐一丛丈丏();
    }
    internal void 丏丁不丒东丟丌丐与()
    {
        var val_14;
        UnityEngine.GameObject val_15;
        if(this._field.丛丐业三丏丏丕丘丏() != null)
        {
                if(ClanFieldBuildController.丑七不且上丗丁一世() != 0)
        {
                ClanFieldBuildController val_5 = ClanFieldBuildController.丑七不且上丗丁一世();
            val_14 = val_5.上丝东丈丂丐丌丅与;
        }
        else
        {
                val_14 = 0;
        }
        
            PlaceableItemSettings val_9 = this._field.丛丐业三丏丏丕丘丏();
            PGCompany.Analytics.一业丗丆世世上丁且.东一不东业与下世丆(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  0, 七丐丅专且专七三丆:  5, 东丝丅专丝丈一丘下:  0, 上丕丟丌上丐丝上上:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上上三七丟丝与丆与(), 丒丘丏上丙丟丑丕丈:  val_9.name, 下丗丁丒丘东丂不丑:  this._field.丛丐业三丏丏丕丘丏().SubcategoryName, 丒世丘丘上丆丝东丞:  0, 丂下丛丝丆丂七丏丘:  0);
        }
        
        if(this._field != null)
        {
                val_15 = this._field.SelectedObject;
        }
        else
        {
                val_15 = 0.SelectedObject;
        }
        
        this._field.丐丒丒丏丈丄丘丑丘(万且万且丑丗且丌丆:  val_15);
        CameraMoverDirectoryManager.丄丘七三上丕世丞业.一一丟丑丏丑且三丒();
        this.业七东丆丐一丛丈丏();
    }
    public void CancelSelectedItem()
    {
        if((this.丐且丄东丒三业不丝(下丐三丆丝与不丗丕:  this._field.SelectedObject)) != false)
        {
                this._field.丝丐丈业丘丂丐丁丞();
            return;
        }
        
        this.丏丁不丒东丟丌丐与();
    }
    public void ReplaceBySelectedItem()
    {
        UnityEngine.GameObject val_5 = this._field.SelectedObject;
        val_5 = (this.丐且丄东丒三业不丝(下丐三丆丝与不丗丕:  val_5)) ^ 1;
        if((this._field.七东一下丌万丁东一(丂万丅万丑东丒丒丘:  val_5)) == false)
        {
                return;
        }
        
        CameraMoverDirectoryManager.丄丘七三上丕世丞业.一一丟丑丏丑且三丒();
        this.业七东丆丐一丛丈丏();
    }
    private void 丒丅丕上丁丂丄丕丂(UnityEngine.GameObject 七丁万不丐丂上世万)
    {
    
    }
    internal void 业七东丆丐一丛丈丏()
    {
        this.专丁丑世业丌丏丁丛.Clear();
        List.Enumerator<T> val_2 = this._field.丌丆丘丟丛丝丙丌丘<SquareFieldCell>().GetEnumerator();
        label_8:
        if((1819845224 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        this.专丁丑世业丌丏丁丛.Add(key:  val_3.gameObject, value:  val_3);
        goto label_8;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.专七七不万丘丑丅丐();
        if(this.专且丏与丂上丙丘丌 == null)
        {
                return;
        }
        
        this.专且丏与丂上丙丘丌.Invoke();
    }
    internal void 丄下不丈丐丘丅丏丗()
    {
        if(this.专且丏与丂上丙丘丌 == null)
        {
                return;
        }
        
        this.专且丏与丂上丙丘丌.Invoke();
    }
    private void 专七七不万丘丑丅丐()
    {
        var val_6;
        var val_13;
        var val_14;
        float val_15;
        val_13 = this;
        this.业丁一业丐丐与专丕(丙业与丙丗丝不丈东:  this.MaxBuildEnergy);
        System.Collections.Generic.Dictionary<PlaceableItemSettings, System.Single> val_2 = new System.Collections.Generic.Dictionary<PlaceableItemSettings, System.Single>();
        Dictionary.Enumerator<TKey, TValue> val_3 = this.专丁丑世业丌丏丁丛.GetEnumerator();
        label_13:
        if((1820124464 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        if((val_2.ContainsKey(key:  val_7._value._obj)) != false)
        {
                float val_10 = val_2.Item[val_7._value._obj];
            val_14 = null;
            val_14 = null;
            val_10 = val_10 * ClanFieldBuildController.丝丅专丅丙丑丝三丒;
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
    internal int 丞东丆丝丞下丆世丆(PlaceableItemSettings 与不丕丆丈不丙丟丛)
    {
        return (int)(int)(float)ClanFieldBuildController.丙东丙丕下丌万丘丂(与不丕丆丈不丙丟丛:  与不丕丆丈不丙丟丛, 丌丒丝东丌下丕丁丅:  this.丆丙丟丒丞丐丅七一(业世丟丐丘丐专与不:  与不丕丆丈不丙丟丛));
    }
    internal int 世丗丄丄丛丕业丕丅(PlaceableItemSettings 与不丕丆丈不丙丟丛)
    {
        PlaceableItemSettings val_3 = 与不丕丆丈不丙丟丛;
        val_3 = (this.丆丙丟丒丞丐丅七一(业世丟丐丘丐专与不:  val_3)) - 1;
        return (int)(int)(float)ClanFieldBuildController.丙东丙丕下丌万丘丂(与不丕丆丈不丙丟丛:  与不丕丆丈不丙丟丛, 丌丒丝东丌下丕丁丅:  val_3);
    }
    internal static int 丙东丙丕下丌万丘丂(PlaceableItemSettings 与不丕丆丈不丙丟丛, int 丌丒丝东丌下丕丁丅)
    {
        float val_2 = ClanFieldBuildController.上上丗丗丏丞万丁丞(与不丕丆丈不丙丟丛:  null, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
        val_2 = val_2 * (float)与不丕丆丈不丙丟丛.Energy;
        return (int)(int)val_2;
    }
    internal static float 上上丗丗丏丞万丁丞(PlaceableItemSettings 与不丕丆丈不丙丟丛, int 丌丒丝东丌下丕丁丅)
    {
        null = null;
    }
    internal int 丆丙丟丒丞丐丅七一(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        string val_8;
        var val_9;
        var val_10;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.专丁丑世业丌丏丁丛.GetEnumerator();
        val_8 = 1152921536491724528;
        val_9 = 0;
        goto label_2;
        label_3:
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        label_2:
        if((1820747992 & 1) != 0)
        {
            goto label_3;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_10 = 0;
        goto label_9;
        label_14:
        FortFieldItemInfo val_4 = FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂 + 24.Item[0];
        val_8 = val_4.name;
        val_9 = ((1820747976 == 业世丟丐丘丐专与不) ? (val_9 + 1) : (val_9)) + (System.String.op_Equality(a:  val_8, b:  业世丟丐丘丐专与不.name));
        val_10 = 1;
        label_9:
        if(val_10 < (FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂 + 24.Count))
        {
            goto label_14;
        }
        
        return (int)val_9;
    }
    internal bool 丐且丄东丒三业不丝(UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
        if(下丐三丆丝与不丗丕 == 0)
        {
                return false;
        }
        
        if(this.专丁丑世业丌丏丁丛 != null)
        {
                return this.专丁丑世业丌丏丁丛.ContainsKey(key:  下丐三丆丝与不丗丕);
        }
        
        return this.专丁丑世业丌丏丁丛.ContainsKey(key:  下丐三丆丝与不丗丕);
    }
    internal void 丅丑丒丟丆丛丁三东()
    {
        this.业七东丆丐一丛丈丏();
    }
    private void 不业丛丑丝丘东丘丅()
    {
        if(this.丗专丟丈丁丑业专丒 == false)
        {
                return;
        }
        
        this.丗专丟丈丁丑业专丒 = false;
        this.丟丄丙与丌丂丆专丞();
    }
    public ClanFieldBuildController()
    {
        this.专丁丑世业丌丏丁丛 = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, PlaceableItemSettings>();
    }
    private static ClanFieldBuildController()
    {
        ClanFieldBuildController.丝丅专丅丙丑丝三丒 = 2f;
    }

}
