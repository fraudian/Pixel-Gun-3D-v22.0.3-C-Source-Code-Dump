using UnityEngine;
internal sealed class FortFieldDecorationItemsController : MonoBehaviour
{
    // Fields
    internal static FortFieldDecorationItemsController 丄丘七三上丕世丞业;
    private const string 丏丐丘不丗丙丗与丂 = "FortField\\FortItemsContent\\";
    internal System.Collections.Generic.List<FortFieldItemInfo> 丗不东丑东丒丟世丞;
    internal FortFieldItemInfo 七万上丁丄丙上上丗;
    private System.Collections.Generic.List<FortFieldItemInfo> 丝丆上业丝一与丁业;
    private string 三专丕丈与丅世丙丙;
    private bool 且丄丏上丐丛世且丗;
    
    // Properties
    private static string 丛业丐丈三丏丘世丆 { get; }
    
    // Methods
    private static string 三丄丈丞一专丝丛丛()
    {
        return "clan.fort-decor-"("clan.fort-decor-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
    }
    private void Awake()
    {
        FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂 = this;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        this.且丄丏上丐丛世且丗 = System.String.op_Equality(a:  val_1.m_Handle.name, b:  "FortFieldBuild");
    }
    private void Start()
    {
        if(Base_BuildingUI_Controller.instance != 0)
        {
                世业丐丏丗业丟一上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldDecorationItemsController::一三万丟世丂丕丙丈()));
        }
        
        if(((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != false) && ((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) != null))
        {
                丞丂丘丒丟丞丑下丄 val_8 = Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan;
        }
        
        this.万丞丈丌万丟丐丆丘(三丅丁一东丟专丌三:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丟与且丙七丙丞下丏());
    }
    internal static System.Collections.Generic.List<FortFieldItemInfo> 丐丙世丞丝与七丒下()
    {
        var val_6;
        string val_1 = FortFieldDecorationItemsController.东东且丝丕丐丞丟三();
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_6 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(val_6 != null)
        {
                return (System.Collections.Generic.List<FortFieldItemInfo>)val_6;
        }
        
        System.Collections.Generic.List<FortFieldItemInfo> val_4 = null;
        val_6 = val_4;
        val_4 = new System.Collections.Generic.List<FortFieldItemInfo>();
        return (System.Collections.Generic.List<FortFieldItemInfo>)val_6;
    }
    internal void 万丞丈丌万丟丐丆丘(System.Collections.Generic.List<FortFieldItemInfo> 三丅丁一东丟专丌三)
    {
        var val_7;
        var val_13;
        if(三丅丁一东丟专丌三 != null)
        {
                if(三丅丁一东丟专丌三.Count >= 1)
        {
                do
        {
            FortFieldItemInfo val_2 = 三丅丁一东丟专丌三.Item[0];
            this.东丌丟三丞世一一丑(业世丟丐丘丐专与不:  丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_2.name), 东且丄专丞丆丂业一:  false);
            val_13 = 0 + 1;
        }
        while(val_13 < 三丅丁一东丟专丌三.Count);
        
        }
        
        }
        
        List.Enumerator<T> val_5 = this.丝丆上业丝一与丁业.GetEnumerator();
        label_15:
        if((1836701728 & 1) == 0)
        {
            goto label_8;
        }
        
        new FortFieldDecorationItemsController.丒丛丁与丅东丒不七() = new System.Object();
        .丄不丒业不一丗丅丙 = val_7.丐丏七丌丕丗业且上();
        System.Predicate<FortFieldItemInfo> val_10 = new System.Predicate<FortFieldItemInfo>(object:  new FortFieldDecorationItemsController.丒丛丁与丅东丒不七(), method:  System.Boolean FortFieldDecorationItemsController.丒丛丁与丅东丒不七::丟东丌丌丙丗上丝万(FortFieldItemInfo 三丟东丕丄丄下下丑));
        if((this.丗不东丑东丒丟世丞.Exists(match:  null)) == true)
        {
            goto label_15;
        }
        
        this.东丌丟三丞世一一丑(业世丟丐丘丐专与不:  丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  (FortFieldDecorationItemsController.丒丛丁与丅东丒不七)[1152921536508384384].丄不丒业不一丗丅丙.name), 东且丄专丞丆丂业一:  false);
        goto label_15;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 东丌丟三丞世一一丑(PlaceableItemSettings 业世丟丐丘丐专与不, bool 东且丄专丞丆丂业一 = False)
    {
        PlaceableItemSettings val_15;
        var val_16;
        var val_17;
        string val_18;
        val_15 = 业世丟丐丘丐专与不;
        val_16 = this;
        FortFieldDecorationItemsController.世东丒与丞七不不东 val_1 = new FortFieldDecorationItemsController.世东丒与丞七不不东();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_17 = val_1;
        .业世丟丐丘丐专与不 = val_15;
        if(val_15 != null)
        {
            goto label_2;
        }
        
        return;
        label_1:
        val_17 = 16;
        mem[16] = val_15;
        val_15 = mem[16];
        if(val_15 == 0)
        {
                return;
        }
        
        label_2:
        val_15 = this.丗不东丑东丒丟世丞.FindIndex(match:  new System.Predicate<FortFieldItemInfo>(object:  val_1, method:  System.Boolean FortFieldDecorationItemsController.世东丒与丞七不不东::丕丘丙世丟万丁丕丌(FortFieldItemInfo 三丟东丕丄丄下下丑)));
        if(val_15 != 1)
        {
                FortFieldItemInfo val_4 = this.丗不东丑东丒丟世丞.Item[val_15];
            val_18 = val_4.name;
            if((System.String.op_Equality(a:  val_18, b:  业世丟丐丘丐专与不 + 88)) != false)
        {
                if(东且丄专丞丆丂业一 == false)
        {
                return;
        }
        
        }
        
        }
        
        if(val_1 != null)
        {
                this.丂丝丌一丕丕丄丛丞(业世丟丐丘丐专与不:  mem[16]);
            this.七万上丁丄丙上上丗 = 0;
        }
        else
        {
                this.丂丝丌一丕丕丄丛丞(业世丟丐丘丐专与不:  mem[16]);
            this.七万上丁丄丙上上丗 = 0;
        }
        
        val_18 = mem[业世丟丐丘丐专与不 + 88];
        val_18 = 业世丟丐丘丐专与不 + 88;
        FortFieldItemInfo val_7 = new FortFieldItemInfo();
        .subcategoryName = mem[16].SubcategoryName;
        .name = val_18;
        if(val_15 != 1)
        {
                this.丗不东丑东丒丟世丞.set_Item(index:  val_15, value:  val_7);
        }
        else
        {
                this.丗不东丑东丒丟世丞.Add(item:  val_7);
        }
        
        if(ClanFieldBuildController.丑七不且上丗丁一世() != 0)
        {
                ClanFieldBuildController.丑七不且上丗丁一世().丄下不丈丐丘丅丏丗();
        }
        
        val_16 = Rilisoft.Singleton<ClansVisitController>.Instance;
        if(val_16.IsVisitClan == false)
        {
                return;
        }
        
        丞丂丘丒丟丞丑下丄 val_14 = Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan;
    }
    private void 丂丝丌一丕丕丄丛丞(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        UnityEngine.Material[] val_38;
        string val_39;
        string val_40;
        var val_41;
        var val_42;
        var val_43;
        val_38 = 1152921505144864768;
        if(null == 0)
        {
            goto label_2;
        }
        
        label_19:
        val_39 = 业世丟丐丘丐专与不.SubcategoryName;
        if((ContainsKey(key:  val_39)) == false)
        {
                return;
        }
        
        if(this.七万上丁丄丙上上丗 != null)
        {
                if((System.String.op_Equality(a:  this.七万上丁丄丙上上丗.name, b:  业世丟丐丘丐专与不.name)) == true)
        {
                return;
        }
        
        }
        
        if(null == 0)
        {
            goto label_10;
        }
        
        label_21:
        val_39 = 业世丟丐丘丐专与不.SubcategoryName;
        FortFieldItemPlace val_5 = Item[val_39];
        if(业世丟丐丘丐专与不.uploadItemType != 1)
        {
            goto label_14;
        }
        
        if((this.且丄丏上丐丛世且丗 == false) || ((System.String.op_Equality(a:  业世丟丐丘丐专与不.SubcategoryName, b:  "FortField")) == false))
        {
            goto label_16;
        }
        
        val_39 = UnityEngine.Shader.Find(name:  this.三专丕丈与丅世丙丙);
        goto label_17;
        label_2:
        FortFieldDecorationPlaces.丄丘七三上丕世丞业.丝丑丁不下专丌且丅();
        if(业世丟丐丘丐专与不 != null)
        {
            goto label_19;
        }
        
        goto label_19;
        label_10:
        FortFieldDecorationPlaces.丄丘七三上丕世丞业.丝丑丁不下专丌且丅();
        if(业世丟丐丘丐专与不 != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_16:
        val_39 = 0;
        label_17:
        val_38 = this.丑丈丅丟丑丄七丕丑(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
        val_40 = 0;
        label_27:
        if(val_40 >= val_9.Length)
        {
            goto label_23;
        }
        
        val_40 = val_40 + 1;
        if(val_38[0] != 0)
        {
            goto label_27;
        }
        
        val_38 = this.丟丆世丘世三丝丅且(七丐丌上上万丘三丆:  业世丟丐丘丐专与不.SubcategoryName);
        label_23:
        val_41 = 0;
        goto label_29;
        label_48:
        if(val_5.objects.Item[0] == 0)
        {
            goto label_37;
        }
        
        UnityEngine.MeshRenderer val_16 = val_5.objects.Item[0].GetComponent<UnityEngine.MeshRenderer>();
        val_16.materials = val_38;
        if(0 == 0)
        {
            goto label_37;
        }
        
        val_42 = 0;
        goto label_38;
        label_45:
        val_43 = 0;
        val_16.materials[val_43].shader = val_39;
        val_42 = 1;
        label_38:
        val_40 = val_16.materials;
        if(val_42 < val_18.Length)
        {
            goto label_45;
        }
        
        label_37:
        val_41 = 1;
        label_29:
        if(val_41 < val_5.objects.Count)
        {
            goto label_48;
        }
        
        label_14:
        if(业世丟丐丘丐专与不.uploadItemType != 0)
        {
                return;
        }
        
        string val_20 = "FortField\\FortItemsContent\\" + 业世丟丐丘丐专与不.subcategory + "\\";
        val_38 = 1152921524279436720;
        val_39 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_20 + 业世丟丐丘丐专与不.uploadItemNames.Item[0]);
        if(val_39 == 0)
        {
                val_39 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_20 + "unknown_item");
            if(val_39 == 0)
        {
                return;
        }
        
        }
        
        UnityEngine.SceneManagement.Scene val_28 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_38 = 0;
        goto label_58;
        label_73:
        UnityEngine.GameObject val_32 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_39, parent:  val_5.places.Item[0]);
        val_5.丏与丘不丅世世丒一(丞世不丒下上上丝丑:  0);
        val_5.丏丁丏丗丄万业丑丁(丝丄丈丈业丆丘且丁:  val_32, 丞世不丒下上上丝丑:  0);
        if((System.String.op_Equality(a:  val_28.m_Handle.name, b:  "FortFieldBuild")) != false)
        {
                T[] val_33 = val_32.GetComponentsInChildren<FortFieldShowCategoryUtility>();
            if((val_33 != null) && (val_33.Length >= 1))
        {
                do
        {
            val_43 = 0;
            T val_41 = val_33[val_43];
            if(业世丟丐丘丐专与不 != null)
        {
                val_40 = 业世丟丐丘丐专与不.CategoryName;
        }
        else
        {
                val_40 = 0.CategoryName;
        }
        
            mem2[0] = val_40;
            mem2[0] = 业世丟丐丘丐专与不.SubcategoryName;
        }
        while((val_43 + 1) < val_33.Length);
        
        }
        
        }
        
        val_38 = 1;
        label_58:
        if(val_38 < val_5.places.Count)
        {
            goto label_73;
        }
    
    }
    private UnityEngine.Material[] 丟丆世丘世三丝丅且(string 七丐丌上上万丘三丆)
    {
        .七丐丌上上万丘三丆 = 七丐丌上上万丘三丆;
        int val_3 = this.丝丆上业丝一与丁业.FindIndex(match:  new System.Predicate<FortFieldItemInfo>(object:  new FortFieldDecorationItemsController.丕丛业丁丏下一七丘(), method:  System.Boolean FortFieldDecorationItemsController.丕丛业丁丏下一七丘::丈东丝专业丗三丘丟(FortFieldItemInfo 三丟东丕丄丄下下丑)));
        if(val_3 != 1)
        {
                FortFieldItemInfo val_4 = this.丝丆上业丝一与丁业.Item[val_3];
            PlaceableItemSettings val_5 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_4.name);
            return val_5.丑丈丅丟丑丄七丕丑(业世丟丐丘丐专与不:  val_5);
        }
        
        UnityEngine.Material[] val_6 = new UnityEngine.Material[1];
    }
    private UnityEngine.Material[] 丑丈丅丟丑丄七丕丑(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        var val_8;
        UnityEngine.Material val_9;
        int val_1 = 业世丟丐丘丐专与不.uploadItemNames.Count;
        UnityEngine.Material[] val_2 = new UnityEngine.Material[0];
        val_8 = 0;
        label_15:
        if(val_8 >= 业世丟丐丘丐专与不.uploadItemNames.Count)
        {
                return val_2;
        }
        
        val_9 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "FortField\\FortItemsContent\\" + 业世丟丐丘丐专与不.subcategory + "\\" + 业世丟丐丘丐专与不.uploadItemNames.Item[0]);
        if(val_2 == null)
        {
            goto label_6;
        }
        
        if(val_9 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_9 == null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_2[0] = val_9;
        if(val_8 >= val_2.Length)
        {
                val_9 = mem[val_2[0x0] + 32];
            val_9 = val_2[0x0] + 32;
        }
        
        val_8 = val_8 + 1;
        if(val_9 != 0)
        {
            goto label_15;
        }
        
        return val_2;
    }
    private static void 丘专下丟丕万世下丕(System.Collections.Generic.List<FortFieldItemInfo> 丑七不与丛丆一丂丞)
    {
        string val_14 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((Rilisoft.Singleton<ClansController>.Instance.丞一不下一丁丞东一(丄丒且丙三丆丟与丏:  val_14 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丕万丐东与一丈万与:  0)) == true)
        {
                return;
        }
        
        val_14 = 1152921530862937872;
        if((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != false)
        {
                if((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) != null)
        {
                return;
        }
        
        }
        
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丟与且丙七丙丞下丏().Clear();
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丟与且丙七丙丞下丏().AddRange(collection:  丑七不与丛丆一丂丞);
        FortFieldDecorationItemsController.丞丆业专丈一丒丙丁(一丐丗丁丞丆丅丟丄:  丑七不与丛丆一丂丞);
        FortFieldDecorationItemsController.丄与上丘业丌丙一丄(一丐丗丁丞丆丅丟丄:  丑七不与丛丆一丂丞);
    }
    internal void 七丞丒专万且丟丞丅()
    {
        var val_14;
        var val_15;
        val_14 = this;
        val_15 = 1152921530862937872;
        if((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != false)
        {
                if((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) != null)
        {
                return;
        }
        
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        System.Collections.Generic.List<FortFieldItemInfo> val_7 = new System.Collections.Generic.List<FortFieldItemInfo>();
        val_15 = 0;
        goto label_7;
        label_11:
        val_7.Add(item:  this.丗不东丑东丒丟世丞.Item[0]);
        val_15 = 1;
        label_7:
        if(val_15 < this.丗不东丑东丒丟世丞.Count)
        {
            goto label_11;
        }
        
        val_14 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if((FortFieldDecorationItemsController.丅万丛丒与丒丙丝丒(丐丕丆丟丗丑三丙业:  val_14.丟与且丙七丙丞下丏(), 丁丅丞丆丏丂业丁丆:  val_7)) != false)
        {
                return;
        }
        
        FortFieldDecorationItemsController.丘专下丟丕万世下丕(丑七不与丛丆一丂丞:  val_7);
    }
    internal static string 东东且丝丕丐丞丟三()
    {
        return 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  FortFieldDecorationItemsController.三丄丈丞一专丝丛丛(), 丞丌丑丛上丕丙丕下:  "[]");
    }
    public void SetTemporaryItem(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        string val_3;
        this.丂丝丌一丕丕丄丛丞(业世丟丐丘丐专与不:  业世丟丐丘丐专与不);
        if(业世丟丐丘丐专与不 != null)
        {
                val_3 = 业世丟丐丘丐专与不.name;
        }
        else
        {
                val_3 = 0;
        }
        
        .subcategoryName = 业世丟丐丘丐专与不.SubcategoryName;
        .name = val_3;
        this.七万上丁丄丙上上丗 = new FortFieldItemInfo();
    }
    private void 一三万丟世丂丕丙丈()
    {
        if(this.七万上丁丄丙上上丗 == null)
        {
                return;
        }
        
        FortFieldItemInfo val_3 = this.丗不东丑东丒丟世丞.Item[this.丗不东丑东丒丟世丞.FindIndex(match:  new System.Predicate<FortFieldItemInfo>(object:  this, method:  System.Boolean FortFieldDecorationItemsController::丅丕万丕丁丝东上丟(FortFieldItemInfo 三丟东丕丄丄下下丑)))];
        this.东丌丟三丞世一一丑(业世丟丐丘丐专与不:  丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_3.name), 东且丄专丞丆丂业一:  true);
        this.七万上丁丄丙上上丗 = 0;
    }
    internal static void 丞丆业专丈一丒丙丁(System.Collections.Generic.List<FortFieldItemInfo> 一丐丗丁丞丆丅丟丄)
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  FortFieldDecorationItemsController.三丄丈丞一专丝丛丛(), 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  一丐丗丁丞丆丅丟丄));
    }
    private static void 丄与上丘业丌丙一丄(System.Collections.Generic.List<FortFieldItemInfo> 一丐丗丁丞丆丅丟丄)
    {
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().万丙丘东不丏丒丏丞().丞丈上丙丞丗丑丝与(且丟丅丄丒丑丂丁世:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟(), 丞不与丌丝业丏丈丂:  一丐丗丁丞丆丅丟丄);
    }
    internal static void 下丞丏一丁丒丞下丏(string 一丐丗丁丞丆丅丟丄)
    {
        DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_5 = 0;
        val_5 = val_5 + 1;
        Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘丙丂专丙丟丆专与(丙业与丙丗丝不丈东:  val_1);
        FortFieldDecorationItemsController.丘专下丟丕万世下丕(丑七不与丛丆一丂丞:  val_1);
    }
    internal static bool 丅万丛丒与丒丙丝丒(System.Collections.Generic.IEnumerable<FortFieldItemInfo> 丐丕丆丟丗丑三丙业, System.Collections.Generic.IEnumerable<FortFieldItemInfo> 丁丅丞丆丏丂业丁丆)
    {
        return 丞东丑专丛丆丄丝世.丂丆世世丕丅丕丅上<FortFieldItemInfo>(丏丆丑丗七丄丙丝与:  丐丕丆丟丗丑三丙业, 丒丈丙丐丏丕丆万丗:  丁丅丞丆丏丂业丁丆, 丈丕丛与丏丏不丆七:  new 七一丕下丐丒且丞丞());
    }
    internal static FortFieldItemInfo 七丂丆丘丂丟丛丘一(System.Collections.Generic.List<FortFieldItemInfo> 丑七不与丛丆一丂丞)
    {
        var val_5;
        var val_6;
        val_5 = 0;
        goto label_1;
        label_6:
        FortFieldItemInfo val_1 = 丑七不与丛丆一丂丞.Item[0];
        if((System.String.op_Equality(a:  val_1.subcategoryName, b:  "1_FortFortBase")) == true)
        {
                return (FortFieldItemInfo)丑七不与丛丆一丂丞.Item[0];
        }
        
        val_5 = 1;
        label_1:
        if(val_5 < 丑七不与丛丆一丂丞.Count)
        {
            goto label_6;
        }
        
        val_6 = 0;
        return (FortFieldItemInfo)丑七不与丛丆一丂丞.Item[0];
    }
    internal static int 七丂丆丘丂丟丛丘一(System.Collections.Generic.List<int> 丑七不与丛丆一丂丞)
    {
        goto label_1;
        label_8:
        if((System.String.op_Equality(a:  丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞世不丒下上上丝丑:  丑七不与丛丆一丂丞.Item[0]).SubcategoryName, b:  "1_FortFortBase")) == true)
        {
            goto label_6;
        }
        
        0 = 1;
        label_1:
        if(0 < 丑七不与丛丆一丂丞.Count)
        {
            goto label_8;
        }
        
        return 0;
        label_6:
        if(丑七不与丛丆一丂丞 != null)
        {
                return 丑七不与丛丆一丂丞.Item[0];
        }
        
        return 丑七不与丛丆一丂丞.Item[0];
    }
    public FortFieldDecorationItemsController()
    {
        this.丗不东丑东丒丟世丞 = new System.Collections.Generic.List<FortFieldItemInfo>();
        System.Collections.Generic.List<FortFieldItemInfo> val_2 = new System.Collections.Generic.List<FortFieldItemInfo>();
        .subcategoryName = "FortFortBase";
        .name = "fort_defaultfort";
        val_2.Add(item:  new FortFieldItemInfo());
        .subcategoryName = "FortGate";
        .name = "fort_defaultgates";
        val_2.Add(item:  new FortFieldItemInfo());
        .subcategoryName = "FortWalls";
        .name = "fort_defaultwalls";
        val_2.Add(item:  new FortFieldItemInfo());
        .subcategoryName = "FortField";
        .name = "fort_desert";
        val_2.Add(item:  new FortFieldItemInfo());
        .subcategoryName = "FortRoad";
        .name = "fort_footpath";
        val_2.Add(item:  new FortFieldItemInfo());
        .subcategoryName = "FortSky";
        .name = "fort_cloudy_day";
        val_2.Add(item:  new FortFieldItemInfo());
        .subcategoryName = "FortWater";
        .name = "fort_moat_water";
        val_2.Add(item:  new FortFieldItemInfo());
        this.丝丆上业丝一与丁业 = val_2;
        this.三专丕丈与丅世丙丙 = "Cubic/FortTerrainAlphaByDistance";
    }
    private bool 丅丕万丕丁丝东上丟(FortFieldItemInfo 三丟东丕丄丄下下丑)
    {
        if(this.七万上丁丄丙上上丗 != null)
        {
                return System.String.op_Equality(a:  三丟东丕丄丄下下丑.subcategoryName, b:  this.七万上丁丄丙上上丗.subcategoryName);
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.subcategoryName, b:  this.七万上丁丄丙上上丗.subcategoryName);
    }

}
