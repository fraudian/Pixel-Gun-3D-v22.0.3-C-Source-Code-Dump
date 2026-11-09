using UnityEngine;
internal class LootBoxUI_Listener : PGBehaviour
{
    // Fields
    protected LootBoxRewardsView lootBoxView;
    private UnityEngine.Transform chestPoint;
    private UnityEngine.GameObject chestCamera;
    protected System.Collections.Generic.List<UnityEngine.GameObject> enableOnOpenChest;
    protected System.Collections.Generic.List<UnityEngine.GameObject> disableOnOpenChest;
    private string historyKey;
    protected UnityEngine.GameObject DropItemsHistoryButton;
    protected ItemHistoryView DropItemsHistoryView;
    private SimpleBunner HintPanel;
    protected ModuleChestAnimationController 上丟下丂丙丛丕丌且;
    protected System.IDisposable 专丏业专不丂一丂丛;
    private 丅七下丏与丙不丐下 丗丄丈丒丘七丈丞与;
    private float chestMoveParam;
    private UnityEngine.Vector3 chestPosition_Normal;
    private UnityEngine.Vector3 chestPosition_Animation;
    
    // Properties
    internal 丅七下丏与丙不丐下 丄丆下丟丕丄专七业 { get; }
    
    // Methods
    internal 丅七下丏与丙不丐下 丙一业丛上丏丒丛一()
    {
        return (丅七下丏与丙不丐下)this.丗丄丈丒丘七丈丞与;
    }
    protected virtual void OnEnable()
    {
        goto typeof(LootBoxUI_Listener).__il2cppRuntimeField_198;
    }
    protected virtual void OnDisable()
    {
        MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  MenuBackgroundMusic.丄一丙三丄专丛一丆(), 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  false, 丆与丈丏丟七丁东丛:  0);
    }
    internal virtual void 不丗东丁丌丈世丂丂()
    {
        goto typeof(LootBoxUI_Listener).__il2cppRuntimeField_198;
    }
    protected virtual void 丑丏上丈丒丂且丞丛()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_1C0);
        this.lootBoxView.丅与丆上东下丏丑世(丙业与丙丗丝不丈东:  new System.Action());
        this.lootBoxView.不丂业丆下不丗万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_1D0));
        this.lootBoxView.丗上与丕下丂上丂七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_1E0));
        this.lootBoxView.东丟丑丙不丌丝丄且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_1F0));
        this.lootBoxView.不业七且丁丌丒丄丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_200));
        this.lootBoxView.一丗丏专丐丟丂丑且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_230));
        this.lootBoxView.丒丑丁丛丕丕不下一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_240));
        this.lootBoxView.丒丟三丛丑丟丗一业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LootBoxUI_Listener::一万丕丑世丆七丟世()));
    }
    protected virtual void 丌丞下万丈丒丑万丅()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_1C0);
        this.lootBoxView.丁世万丌丄且丌丅丌(丙业与丙丗丝不丈东:  new System.Action());
        this.lootBoxView.丑丂丁丘且万东丙东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_1D0));
        this.lootBoxView.业且丒上三丅丆丌一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_1E0));
        this.lootBoxView.丟丝丐专丁丈丄一丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_1F0));
        this.lootBoxView.专三丘一三丆一万不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_200));
        this.lootBoxView.丌不丙东丛丈丌丂与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_230));
        this.lootBoxView.丗丟且丐丕丈丁丅丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_Listener).__il2cppRuntimeField_240));
        this.lootBoxView.丆且丂丒丗不丕丟丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LootBoxUI_Listener::一万丕丑世丆七丟世()));
    }
    protected virtual void 丈丗且丂业丁下丒丆()
    {
        if((System.String.IsNullOrEmpty(value:  this.historyKey)) != true)
        {
                System.String.Format(format:  "LootBox_DropItemsHistory_{0}", arg0:  this.lootBoxView.丞七与丌丘不不丈专.丟不丛丑一丗丄业丟().业东丅东丌上丗丑不()) = "LootBox_DropItemsHistory_" + this.historyKey;
        }
        
        this.丗丄丈丒丘七丈丞与 = new 丅七下丏与丙不丐下(丐三业丘不丘丟三丅:  1, 专丅下与三丗丝丆丙:  System.String.Format(format:  "LootBox_DropItemsHistory_{0}", arg0:  this.lootBoxView.丞七与丌丘不不丈专.丟不丛丑一丗丄业丟().业东丅东丌上丗丑不()), 一下丒丞丑丞七丙且:  50);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnOpenChest, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnOpenChest, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.DropItemsHistoryButton, 丏业丟一东丂东丘丛:  (this.丗丄丈丒丘七丈丞与.丝上三丌丙七三七丏().Count > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.chestCamera, 丏业丟一东丂东丘丛:  true);
        this.chestPoint.localPosition = new UnityEngine.Vector3() {x = this.chestPosition_Normal, y = V9.16B, z = V10.16B};
    }
    protected virtual void 丕丛三丈丄专丅三丆()
    {
        System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> val_5;
        this.一万丕丑世丆七丟世();
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnOpenChest, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnOpenChest, 丏业丟一东丂东丘丛:  false);
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        val_5 = this.lootBoxView.<世七丐与东下与丞业>k__BackingField.丏一丕丁丞专专丟上;
        List.Enumerator<T> val_2 = val_5.GetEnumerator();
        label_9:
        if(((-1232462248) & 1) == 0)
        {
            goto label_6;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        val_1.Add(item:  val_3.m_stringLength);
        goto label_9;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        bool val_4 = this.丗丄丈丒丘七丈丞与.丁且丒丙丛一丅东世(丄丄丆不丂丗丛丙专:  val_1, 业丟丏丈丄丙万一下:  true);
    }
    protected virtual void 丗丒丏丁丂丁七一丒()
    {
    
    }
    protected virtual void 三七不丂丂东丈丙丄()
    {
    
    }
    protected virtual void 丁丟业丕丝丑丌丟专()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnOpenChest, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnOpenChest, 丏业丟一东丂东丘丛:  true);
        this.丁丅丟丆丂丗专丕丄();
        PGCompany.LootBoxSystem.世七丈丆丐丕专业丗 val_1 = this.lootBoxView.丞七与丌丘不不丈专.丏丘下丞丘不丑万丏();
        if(val_1.丈下专丂丑不丑丗丁 == 0)
        {
                return;
        }
        
        PGCompany.LootBoxSystem.世七丈丆丐丕专业丗 val_2 = this.lootBoxView.丞七与丌丘不不丈专.丏丘下丞丘不丑万丏();
        UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  val_2.丈下专丂丑不丑丗丁, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
    }
    protected void 一万丕丑世丆七丟世()
    {
        this.丁丅丟丆丂丗专丕丄();
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "ConnectSceneChestEventUI");
    }
    protected void 丁丅丟丆丂丗专丕丄()
    {
        if(this.专丏业专不丂一丂丛 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.专丏业专不丂一丂丛.Dispose();
    }
    protected virtual void 上丙丄丌不丄与丏丆()
    {
        if(this.上丟下丂丙丛丕丌且 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.上丟下丂丙丛丕丌且.gameObject);
        }
        
        ModuleChestAnimationController val_3 = this.下丕丅丁丑丞三万丘(七丁丑丗丐专丌丝丗:  this.lootBoxView.丞七与丌丘不不丈专);
        this.上丟下丂丙丛丕丌且 = val_3;
        if(val_3 == null)
        {
                return;
        }
        
        val_3.transform.SetParent(p:  this.chestPoint);
        if(this.上丟下丂丙丛丕丌且 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.上丟下丂丙丛丕丌且.transform);
        if(this.上丟下丂丙丛丕丌且 == null)
        {
                return;
        }
        
        this.上丟下丂丙丛丕丌且.丌专丄丆丐与且不丙();
    }
    private ModuleChestAnimationController 下丕丅丁丑丞三万丘(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 七丁丑丗丐专丌丝丗)
    {
        UnityEngine.Object val_14;
        var val_15;
        val_14 = 七丁丑丗丐专丌丝丗;
        if(val_14 != null)
        {
                if(val_14.丟不丛丑一丗丄业丟() == null)
        {
                return (ModuleChestAnimationController)UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_14 = UnityEngine.Resources.Load<ModuleChestAnimationController>(path:  string val_7 = "Lootbox/"("Lootbox/") + val_14.丟不丛丑一丗丄业丟().世丒丗万丐与丞丗丂()));
        }
        
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14.丟不丛丑一丗丄业丟().世丒丗万丐与丞丗丂())) != false)
        {
                UnityEngine.Debug.LogError(message:  "cant GetLootBoxPrefab, chestName nullable or empty");
        }
        
            if(val_14 != 0)
        {
                return (ModuleChestAnimationController)UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_14);
        }
        
            UnityEngine.Debug.LogError(message:  "cant GetLootBoxPrefab, prefab " + val_7 + " not found");
            val_14 = UnityEngine.Resources.Load<ModuleChestAnimationController>(path:  "Lootbox/Default");
            if(val_14 != 0)
        {
                return (ModuleChestAnimationController)UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_14);
        }
        
            UnityEngine.Debug.LogError(message:  "cant GetLootBoxPrefab, prefab LootBox_Default not found");
        }
        
        val_15 = 0;
        return (ModuleChestAnimationController)UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_14);
    }
    public virtual void U_OpenChest()
    {
        if(this.lootBoxView == null)
        {
            
        }
    
    }
    public virtual void ShowDropItemsHistoryView()
    {
        if(this.lootBoxView.万丝专丌丌三丟丆丄 != false)
        {
                return;
        }
        
        if(this.DropItemsHistoryView == null)
        {
                return;
        }
        
        this.DropItemsHistoryView.下与丞三丅丛丄七丕(丁丗与丁丟丕与世丝:  this.丗丄丈丒丘七丈丞与);
    }
    public virtual void HideDropItemsHistoryView()
    {
        if(this.DropItemsHistoryView == null)
        {
                return;
        }
        
        this.DropItemsHistoryView.Hide();
    }
    public virtual void U_ShowHintPanel()
    {
        if(this.HintPanel == null)
        {
                return;
        }
        
        goto typeof(SimpleBunner).__il2cppRuntimeField_188;
    }
    public virtual void U_HideHintPanel()
    {
        if(this.HintPanel == null)
        {
                return;
        }
        
        goto typeof(SimpleBunner).__il2cppRuntimeField_198;
    }
    protected virtual void Update()
    {
        UnityEngine.Vector3 val_5;
        UnityEngine.Vector3 val_1 = this.chestPoint.localPosition;
        if(this.lootBoxView.万丝专丌丌三丟丆丄 != false)
        {
                val_5 = this.chestPosition_Animation;
        }
        else
        {
                val_5 = this.chestPosition_Normal;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_5, y = V12.16B, z = V13.16B}, t:  UnityEngine.Time.unscaledDeltaTime * this.chestMoveParam);
        this.chestPoint.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public LootBoxUI_Listener()
    {
        this.chestMoveParam = 4f;
    }

}
