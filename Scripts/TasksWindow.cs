using UnityEngine;
public class TasksWindow : MonoBehaviour
{
    // Fields
    public UISprite indicator;
    public UILabel indicatorPercents;
    public UnityEngine.GameObject taskWindow;
    public UnityEngine.GameObject needStars;
    public UIButton doTaskBtn;
    public Rilisoft.ButtonHandler backBtn;
    public UnityEngine.GameObject taskItem;
    public UIBasicSprite taskItemIcon;
    public Rilisoft.ButtonHandler taskItemButton;
    public UILabel taskItemDescription;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private bool 丆上丕一世丆与下丛;
    internal static System.Collections.Generic.Dictionary<string, string[]> 东丕东丞上丕三世丗;
    
    // Properties
    private UIBasicSprite 丙万丟丗丂丙丝丁不 { get; }
    
    // Methods
    private UIBasicSprite 丅丙丘业丌丏丗不业()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.taskItemIcon);
        this.taskItemIcon = val_1;
        return val_1;
    }
    private void Awake()
    {
        this.backBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void TasksWindow::丛丟丛一不丝不专丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void Update()
    {
    
    }
    public void HandleGoCoConnectScene()
    {
        var val_1;
        this.HideWindow();
        val_1 = null;
        val_1 = null;
        MainMenuController.丄丞丁丈与业上丞丟.OnClickMultiplyerButtonCore(三丂东专丕专业丏万:  false);
    }
    public void HandleDoTaskButtonClick()
    {
        var val_65;
        string val_66;
        var val_67;
        System.String[] val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        float val_73;
        float val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "QuestsGSMAnager.STARS_GS_KEY", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) <= 0)
        {
            goto label_3;
        }
        
        val_65 = null;
        val_65 = null;
        HideSmallHint();
        this.HideWindow();
        丈万丆丒上丅且上丛 val_3 = QuestsGSMAnager.丑七不且上丗丁一世().ActiveTask;
        if(val_3 == null)
        {
                return;
        }
        
        val_66 = 1152921505328144384;
        if((TasksWindow.丅丒丞丑丝丞丏丆一(万东丆丞东且丘且丒:  val_3)) == false)
        {
            goto label_14;
        }
        
        TasksWindow.三丅丞丒丕丅专一丅 val_5 = new TasksWindow.三丅丞丒丕丅专一丅();
        val_67 = null;
        val_67 = null;
        System.String[] val_6 = TasksWindow.东丕东丞上丕三世丗.Item[val_3.下丄丈不与世丐业专];
        if(val_5 == null)
        {
            goto label_18;
        }
        
        val_68 = val_5;
        .下丈下业丝上丟上丅 = val_6;
        goto label_19;
        label_3:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.taskWindow, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.needStars, 丏业丟一东丂东丘丛:  true);
        val_69 = null;
        val_69 = null;
        HideSmallHint();
        return;
        label_14:
        QuestsGSMAnager.丑七不且上丗丁一世().CompleteActiveTask();
        if((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "inkubators")) != false)
        {
                NurseryGuiController.丘丏丑丕丙东丗丏下(丙业与丙丗丝不丈东:  true);
        }
        
        if((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "gacha")) != false)
        {
                if(AnimationGift.丄丘七三上丕世丞业 != 0)
        {
                AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
        }
        
            val_70 = null;
            val_70 = null;
            Assets.Scripts.Gift.GiftAnimationOpenStateBehaviour.IsFromTasks = true;
            val_71 = null;
            val_71 = null;
            Assets.Scripts.Gift.GiftAnimationCloseStateBehaviour.IsFromTasks = true;
            val_72 = null;
            val_72 = null;
            MainMenuController.丄丞丁丈与业上丞丟.SaveShowPanelAndClose();
            MainMenuController.丞且丙丛丞不世专七 = false;
            QuestTasksGSCraftController val_12 = UnityEngine.Object.Instantiate<QuestTasksGSCraftController>(original:  UnityEngine.Resources.Load<QuestTasksGSCraftController>(path:  "SelectCraftItem"));
            val_12.transform.parent = transform.parent;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_12.gameObject, 不东丛三丂丌丑专丆:  gameObject.layer);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            val_12.transform.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.identity;
            val_12.transform.localRotation = new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w};
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.one;
            val_73 = val_24.x;
            val_74 = val_24.z;
            val_12.transform.localScale = new UnityEngine.Vector3() {x = val_73, y = val_24.y, z = val_74};
            val_66 = val_3.下丄丈不与世丐业专;
            val_12.ShowNoVariants(东一七丟与丗三丐不:  val_66);
            PlayShowGift();
        }
        
        if((((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "newsbox")) != true) && ((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "ad_chest")) != true)) && ((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "flag_piedestal")) != true))
        {
                if((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "igrovoy_avtomat")) != true)
        {
                if((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "radar")) == false)
        {
                return;
        }
        
        }
        
        }
        
        val_75 = null;
        val_75 = null;
        Rilisoft.LobbyItemZoomOutStateBehaviour.IsFromTasks = true;
        val_76 = null;
        val_76 = null;
        Rilisoft.LobbyItemZoomInStateBehaviour.IsFromTasks = true;
        val_77 = null;
        val_77 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.mainPanel, 丏业丟一东丂东丘丛:  false);
        MainMenuController.丞且丙丛丞不世专七 = false;
        QuestTasksGSCraftController val_31 = UnityEngine.Object.Instantiate<QuestTasksGSCraftController>(original:  UnityEngine.Resources.Load<QuestTasksGSCraftController>(path:  "SelectCraftItem"));
        val_31.transform.parent = transform.parent;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_31.gameObject, 不东丛三丂丌丑专丆:  gameObject.layer);
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.zero;
        val_31.transform.localPosition = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
        UnityEngine.Quaternion val_41 = UnityEngine.Quaternion.identity;
        val_31.transform.localRotation = new UnityEngine.Quaternion() {x = val_41.x, y = val_41.y, z = val_41.z, w = val_41.w};
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.one;
        val_31.transform.localScale = new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z};
        val_31.ShowNoVariants(东一七丟与丗三丐不:  val_3.下丄丈不与世丐业专);
        PlayTaskGSMoveAnimation(东一七丟与丗三丐不:  val_3.下丄丈不与世丐业专);
        return;
        label_18:
        val_68 = 16;
        mem[16] = val_6;
        label_19:
        .上且丕丞丞丁东东丟 = 1;
        val_78 = null;
        val_78 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.mainPanel, 丏业丟一东丂东丘丛:  false);
        QuestTasksGSCraftController val_49 = UnityEngine.Object.Instantiate<QuestTasksGSCraftController>(original:  UnityEngine.Resources.Load<QuestTasksGSCraftController>(path:  "SelectCraftItem"));
        val_49.transform.parent = transform.parent;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_49.gameObject, 不东丛三丂丌丑专丆:  gameObject.layer);
        UnityEngine.Vector3 val_57 = UnityEngine.Vector3.zero;
        val_49.transform.localPosition = new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z};
        UnityEngine.Quaternion val_59 = UnityEngine.Quaternion.identity;
        val_49.transform.localRotation = new UnityEngine.Quaternion() {x = val_59.x, y = val_59.y, z = val_59.z, w = val_59.w};
        UnityEngine.Vector3 val_61 = UnityEngine.Vector3.one;
        val_73 = val_61.x;
        val_74 = val_61.z;
        val_49.transform.localScale = new UnityEngine.Vector3() {x = val_73, y = val_61.y, z = val_74};
        val_49.Show(东一七丟与丗三丐不:  val_3.下丄丈不与世丐业专, 下丈下业丝上丟上丅:  val_68);
        PlayLobbyItemZoom(下丅丙一丂丗丅丝七:  System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_5, method:  System.Boolean TasksWindow.三丅丞丒丕丅专一丅::丒世丛丆上与东丆丆(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟))));
        val_79 = null;
        val_79 = null;
        Rilisoft.LobbyItemZoomOutStateBehaviour.IsFromTasks = true;
        val_66 = 1152921505467121664;
        val_80 = null;
        val_80 = null;
        Rilisoft.LobbyItemZoomInStateBehaviour.IsFromTasks = true;
        if((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "Shtab")) != false)
        {
                val_81 = null;
            val_81 = null;
            ShowSmallHint(丒丘丏上丙丟丑丕丈:  "choosebuild", 丘丂丘丂丁丌丂丏丘:  0);
        }
        
        if((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "budka")) != false)
        {
                val_82 = null;
            val_82 = null;
            ShowSmallHint(丒丘丏上丙丟丑丕丈:  "choosebuild_budka", 丘丂丘丂丁丌丂丏丘:  0);
        }
        
        if((System.String.op_Equality(a:  val_3.下丄丈不与世丐业专, b:  "landscape")) == false)
        {
                return;
        }
        
        val_83 = null;
        val_83 = null;
        ShowSmallHint(丒丘丏上丙丟丑丕丈:  "choosebuild_budka", 丘丂丘丂丁丌丂丏丘:  0);
    }
    private void 丛丟丛一不丝不专丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丆上丕一世丆与下丛 != false)
        {
                return;
        }
        
        this.HideWindow();
    }
    private void 丝东丐丝东三丈世丝()
    {
        if(this.丆上丕一世丆与下丛 != false)
        {
                return;
        }
        
        this.HideWindow();
    }
    public void ShowWindow()
    {
        UILabel val_34;
        UnityEngine.Object val_35;
        丈万丆丒上丅且上丛 val_36;
        var val_37;
        var val_39;
        var val_40;
        int val_41;
        val_34 = this;
        TasksWindow.丒业丛丟专丛丒与东 val_1 = new TasksWindow.丒业丛丟专丛丒与东();
        this.gameObject.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.taskWindow, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.needStars, 丏业丟一东丂东丘丛:  false);
        val_35 = QuestsGSMAnager.丑七不且上丗丁一世();
        if(val_35 == 0)
        {
                return;
        }
        
        val_36 = QuestsGSMAnager.丑七不且上丗丁一世().ActiveTask;
        if(val_1 != null)
        {
                val_37 = val_1;
            .万不且且丛丆东丒业 = val_36;
        }
        else
        {
                val_37 = 16;
            mem[16] = val_36;
            val_36 = mem[16];
        }
        
        if(this.taskItem == null)
        {
            goto label_14;
        }
        
        if(val_36 == 0)
        {
            goto label_15;
        }
        
        label_29:
        this.taskItem.SetActive(value:  true);
        this.taskItemDescription.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6 + 16);
        if((TasksWindow.丅丒丞丑丝丞丏丆一(万东丆丞东且丘且丒:  mem[16])) == false)
        {
            goto label_24;
        }
        
        UnityEngine.Texture val_15 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean TasksWindow.丒业丛丟专丛丒与东::业丌丁丕与丕丙丁丅(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟))).丙三专万丛丟万丝丘());
        if(this.丅丙丘业丌丏丗不业() != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_14:
        if(val_36 != 0)
        {
            goto label_29;
        }
        
        label_15:
        this.taskItem.SetActive(value:  false);
        goto label_30;
        label_24:
        UIBasicSprite val_16 = this.丅丙丘业丌丏丗不业();
        UnityEngine.Texture val_18 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "TaskGSIcons/task_icon_{0}", arg0:  val_6 + 32));
        label_28:
        label_30:
        decimal val_21 = System.Decimal.op_Implicit(value:  QuestsGSMAnager.丑七不且上丗丁一世().NumCompletedTasks);
        decimal val_22 = System.Decimal.op_Implicit(value:  QuestsGSMAnager.丌七丅且丕丗丒丈丆.Length);
        decimal val_23 = System.Decimal.Divide(d1:  new System.Decimal() {flags = val_21.flags, hi = val_21.hi, lo = val_21.lo, mid = val_21.mid}, d2:  new System.Decimal() {flags = val_22.flags, hi = val_22.hi, lo = val_22.lo, mid = val_22.mid});
        val_35 = val_23.lo;
        int val_34 = val_21.lo;
        val_34 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_21.flags, hi = val_21.hi, lo = val_34, mid = val_21.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.indicator.gameObject, 丏业丟一东丂东丘丛:  val_34);
        if(this.indicator.gameObject.activeSelf == false)
        {
            goto label_45;
        }
        
        val_40 = null;
        val_40 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_21.flags, hi = val_21.hi, lo = val_21.lo, mid = val_21.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
        {
            goto label_48;
        }
        
        val_41 = 0;
        if(this.indicator != null)
        {
            goto label_53;
        }
        
        goto label_50;
        label_48:
        val_39 = 0;
        decimal val_29 = System.Decimal.Multiply(d1:  new System.Decimal() {flags = val_23.flags, hi = val_23.hi, lo = val_35, mid = val_23.mid}, d2:  new System.Decimal());
        val_41 = System.Decimal.ToInt32(d:  new System.Decimal() {flags = val_29.flags, hi = val_29.hi, lo = val_29.lo, mid = val_29.mid});
        if(this.indicator != null)
        {
            goto label_53;
        }
        
        label_50:
        label_53:
        this.indicator.width = val_41;
        label_45:
        val_34 = this.indicatorPercents;
        decimal val_31 = System.Decimal.Multiply(d1:  new System.Decimal() {flags = val_23.flags, hi = val_23.hi, lo = val_35, mid = val_23.mid}, d2:  new System.Decimal());
        val_34.text = System.String.Format(format:  "{0}%", arg0:  System.Decimal.ToInt32(d:  new System.Decimal() {flags = val_31.flags, hi = val_31.hi, lo = val_31.lo, mid = val_31.mid}));
    }
    public void HideWindow()
    {
        this.gameObject.SetActive(value:  false);
    }
    private void OnEnable()
    {
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void TasksWindow::丝东丐丝东三丈世丝()), 与且专丈不万东一万:  "Tasks Window");
        this.丆上丕一世丆与下丛 = false;
        if(QuestsGSMAnager.丑七不且上丗丁一世().ActiveTask != null)
        {
                丈万丆丒上丅且上丛 val_8 = QuestsGSMAnager.丑七不且上丗丁一世().ActiveTask;
            if((System.String.op_Equality(a:  val_8.下丄丈不与世丐业专, b:  "Shtab")) != false)
        {
                val_25 = null;
            val_25 = null;
            ShowSmallHint(丒丘丏上丙丟丑丕丈:  "dotask", 丘丂丘丂丁丌丂丏丘:  0);
            this.丆上丕一世丆与下丛 = true;
        }
        
        }
        
        if(QuestsGSMAnager.丑七不且上丗丁一世().ActiveTask != null)
        {
                丈万丆丒上丅且上丛 val_13 = QuestsGSMAnager.丑七不且上丗丁一世().ActiveTask;
            if((System.String.op_Equality(a:  val_13.下丄丈不与世丐业专, b:  "budka")) != false)
        {
                val_26 = null;
            val_26 = null;
            ShowSmallHint(丒丘丏上丙丟丑丕丈:  "dotask_budka", 丘丂丘丂丁丌丂丏丘:  0);
            this.丆上丕一世丆与下丛 = true;
        }
        
        }
        
        if(QuestsGSMAnager.丑七不且上丗丁一世().ActiveTask != null)
        {
                丈万丆丒上丅且上丛 val_18 = QuestsGSMAnager.丑七不且上丗丁一世().ActiveTask;
            if((System.String.op_Equality(a:  val_18.下丄丈不与世丐业专, b:  "inkubators")) != false)
        {
                val_27 = null;
            val_27 = null;
            ShowSmallHint(丒丘丏上丙丟丑丕丈:  "task_inkubators_in_tasks", 丘丂丘丂丁丌丂丏丘:  0);
            this.丆上丕一世丆与下丛 = true;
        }
        
        }
        
        val_28 = null;
        val_28 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        string val_21 = MainMenuController.丄丞丁丈与业上丞丟.丗丘丞丛丁七丆专丌();
        if((System.String.IsNullOrEmpty(value:  val_21)) != false)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        ShowSmallHint(丒丘丏上丙丟丑丕丈:  val_21, 丘丂丘丂丁丌丂丏丘:  this.transform);
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    internal static bool 丅丒丞丑丝丞丏丆一(丈万丆丒上丅且上丛 万东丆丞东且丘且丒)
    {
        if((System.String.op_Equality(a:  万东丆丞东且丘且丒.下丄丈不与世丐业专, b:  "Shtab")) == true)
        {
                return true;
        }
        
        if((System.String.op_Equality(a:  万东丆丞东且丘且丒.下丄丈不与世丐业专, b:  "budka")) == false)
        {
                return System.String.op_Equality(a:  万东丆丞东且丘且丒.下丄丈不与世丐业专, b:  "landscape");
        }
        
        return true;
    }
    public TasksWindow()
    {
    
    }
    private static TasksWindow()
    {
        System.Collections.Generic.Dictionary<System.String, System.String[]> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String[]>();
        string[] val_2 = new string[3];
        val_2[0] = "base_military_1";
        val_2[1] = "base_military_2";
        val_2[2] = "base_heaven_1";
        val_1.Add(key:  "Shtab", value:  val_2);
        string[] val_3 = new string[3];
        val_3[0] = "kennel_military_1";
        val_3[1] = "kennel_base_1";
        val_3[2] = "kennel_heaven_1";
        val_1.Add(key:  "budka", value:  val_3);
        string[] val_4 = new string[3];
        val_4[0] = "terrain_military_1";
        val_4[1] = "terrain_military_2";
        val_4[2] = "terrain_military_3";
        val_1.Add(key:  "landscape", value:  val_4);
        TasksWindow.东丕东丞上丕三世丗 = val_1;
    }

}
