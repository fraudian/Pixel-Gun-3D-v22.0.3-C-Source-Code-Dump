using UnityEngine;
public class OnOpenModuleChestUI : MonoBehaviour
{
    // Fields
    private static System.Action 万下且丏丗下与丂丗;
    private static System.Action 丗丟丟业丑世丁下一;
    private UnityEngine.GameObject holder;
    private PositionHolder positionHolder;
    private PGCompany.InventoryItemView itemView;
    private UnityEngine.Transform chestObjectHolder;
    private UnityEngine.Transform rewardAnimationStartPoint;
    private float animateRewardDelay;
    private System.Collections.Generic.List<UILabel> headerLabels;
    private ModuleChestAnimationController 上丟下丂丙丛丕丌且;
    private UnityEngine.GameObject modulesTutorialHint;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> 丟丟且丄丑丝丑丒丅;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private static OnOpenModuleChestUI <不丒专丐业丑业丐丅>k__BackingField;
    private UnityEngine.Transform 丙下与丈丌丛丌丄上;
    private UnityEngine.AudioClip 三丗丕丒万与三世上;
    
    // Properties
    internal static OnOpenModuleChestUI 丐丕丝上丅丈丐丞专 { get; set; }
    private UnityEngine.AudioClip 丙万丐丌七三丐丘丞 { get; }
    private UnityEngine.AudioClip 丛丁丌丗丂丞丅丌丕 { get; }
    
    // Methods
    internal static void 丒下丟丏三丛丄不丈(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  OnOpenModuleChestUI.万下且丏丗下与丂丗, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 一下七丄专丛三丝丐(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  OnOpenModuleChestUI.万下且丏丗下与丂丗, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丗丑与与丗丞三丂一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  OnOpenModuleChestUI.丗丟丟业丑世丁下一, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(OnOpenModuleChestUI.丗丟丟业丑世丁下一 != 1152921505221599240);
    
    }
    internal static void 丘东不万与上东世上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  OnOpenModuleChestUI.丗丟丟业丑世丁下一, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(OnOpenModuleChestUI.丗丟丟业丑世丁下一 != 1152921505221599240);
    
    }
    internal static OnOpenModuleChestUI 丒丙丈下业丞丄丅丛()
    {
        return (OnOpenModuleChestUI)OnOpenModuleChestUI.<不丒专丐业丑业丐丅>k__BackingField;
    }
    private static void 丌三丅丞东世不上三(OnOpenModuleChestUI 丙业与丙丗丝不丈东)
    {
        OnOpenModuleChestUI.<不丒专丐业丑业丐丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 三丞丕丙下丘不丛不(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三, UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        bool val_32;
        var val_33;
        var val_34;
        this.丙下与丈丌丛丌丄上 = 丈东丘丏与丌东东下.transform.parent;
        丈东丘丏与丌东东下.transform.SetParent(p:  丈东丘丏与丌东东下);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  丈东丘丏与丌东东下.transform);
        int val_8 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  丈东丘丏与丌东东下.gameObject, 不东丛三丂丌丑专丆:  丈东丘丏与丌东东下.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_32 = true;
        this.holder.SetActive(value:  true);
        val_33 = null;
        OnOpenModuleChestUI.<不丒专丐业丑业丐丅>k__BackingField = this;
        if(this.headerLabels != null)
        {
                val_32 = this.headerLabels;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_32, 丕丗丘丑丛与丑业丒:  丐下丝丘丑丟丟丗丌.七业丑不七丐业丟丂());
            val_33 = null;
        }
        
        if(OnOpenModuleChestUI.万下且丏丗下与丂丗 != null)
        {
                OnOpenModuleChestUI.万下且丏丗下与丂丗.Invoke();
        }
        
        this.丈丝世丛且丄丄丈丙();
        ModuleChestAnimationController val_12 = UnityEngine.Resources.Load<ModuleChestAnimationController>(path:  "ModuleChests/ModuleChest_"("ModuleChests/ModuleChest_") + 丐下丝丘丑丟丟丗丌.业上丙丞丐丄丆丅七());
        this.上与丟丗一上丛丌专(上业丟世三与七七三:  上业丟世三与七七三);
        if(val_12 != 0)
        {
                ModuleChestAnimationController val_14 = UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_12, parent:  this.chestObjectHolder);
            this.上丟下丂丙丛丕丌且 = val_14;
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_14.transform);
            bool val_16 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
            if(val_16 != false)
        {
                UnityEngine.AudioSource val_18 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_16.上丈不一丟丞世丆丘());
        }
        
            this.上丟下丂丙丛丕丌且.丌万丗与七丄丕不丁(丑丙丙丕与丂丐丘一:  new System.Action(object:  this, method:  System.Void OnOpenModuleChestUI::上下丒丏丁丌下丌上()));
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "No asset found for module cest: "("No asset found for module cest: ") + 丐下丝丘丑丟丟丗丌.业上丙丞丐丄丆丅七());
            UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  this.丝三丘上丂丑丞丗丈());
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void OnOpenModuleChestUI::Hide()), 与且专丈不万东一万:  "OnOpenModuleChestUI");
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 3)
        {
                val_34 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.modulesTutorialHint, 丏业丟一东丂东丘丛:  (业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 2) ? 1 : 0);
    }
    private void 丁丞丗丟万不丄下专()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丝三丘上丂丑丞丗丈());
    }
    private void 丈丝世丛且丄丄丈丙()
    {
        if(this.上丟下丂丙丛丕丌且 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.上丟下丂丙丛丕丌且.gameObject);
        }
        
        List.Enumerator<T> val_3 = this.丟丟且丄丑丝丑丒丅.GetEnumerator();
        label_12:
        if(((-788114536) & 1) == 0)
        {
            goto label_8;
        }
        
        UnityEngine.Object.Destroy(obj:  0.丐丏七丌丕丗业且上().gameObject);
        goto label_12;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丟丟且丄丑丝丑丒丅.Clear();
    }
    private void 上与丟丗一上丛丌专(System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三)
    {
        var val_10;
        this.positionHolder.state = 上业丟世三与七七三.Count - 1;
        this.positionHolder.LoadState();
        val_10 = 0;
        goto label_4;
        label_22:
        this.itemView.gameObject.SetActive(value:  false);
        PGCompany.InventoryItemView val_5 = UnityEngine.Object.Instantiate<PGCompany.InventoryItemView>(original:  this.itemView, parent:  this.positionHolder.obj[0].transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_5.transform);
        Rilisoft.OfferItem val_7 = 上业丟世三与七七三.Item[0];
        if(val_5 != null)
        {
                val_5.Setup(丏且丕丄丁丟丆丏丁:  val_7);
        }
        else
        {
                val_5.Setup(丏且丕丄丁丟丆丏丁:  val_7);
        }
        
        val_5.gameObject.SetActive(value:  true);
        this.丟丟且丄丑丝丑丒丅.Add(item:  val_5);
        val_10 = 1;
        label_4:
        if(val_10 < 上业丟世三与七七三.Count)
        {
            goto label_22;
        }
    
    }
    private System.Collections.IEnumerator 丝三丘上丂丑丞丗丈()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new OnOpenModuleChestUI.丟丄丛丐丂上丒世东();
    }
    private UnityEngine.AudioClip 上丈不一丟丞世丆丘()
    {
        return UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "OpenModChest");
    }
    private UnityEngine.AudioClip 丂丅东丕丘万与七丒()
    {
        UnityEngine.AudioClip val_3;
        if(this.三丗丕丒万与三世上 == 0)
        {
                this.三丗丕丒万与三世上 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "ModFallSound");
            return val_3;
        }
        
        val_3 = this.三丗丕丒万与三世上;
        return val_3;
    }
    public void Hide()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        OnOpenModuleChestUI.<不丒专丐业丑业丐丅>k__BackingField = 0;
        this.holder.SetActive(value:  false);
        if(OnOpenModuleChestUI.丗丟丟业丑世丁下一 != null)
        {
                OnOpenModuleChestUI.丗丟丟业丑世丁下一.Invoke();
        }
        
        this.transform.SetParent(p:  this.丙下与丈丌丛丌丄上);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.transform);
    }
    public OnOpenModuleChestUI()
    {
        this.animateRewardDelay = 0.5f;
        this.丟丟且丄丑丝丑丒丅 = new System.Collections.Generic.List<PGCompany.InventoryItemView>();
    }
    private void 上下丒丏丁丌下丌上()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丝三丘上丂丑丞丗丈());
    }

}
