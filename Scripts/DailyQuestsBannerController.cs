using UnityEngine;
internal sealed class DailyQuestsBannerController : BannerWindow
{
    // Fields
    internal static DailyQuestsBannerController 丆丕丝丒不丙且丐丗;
    private System.IDisposable 丐丆七且丞丏下三丙;
    public UISprite blockingFon;
    public DailyQuestItem[] DailyQuests;
    public bool inBannerSystem;
    public UnityEngine.GameObject noQuestsLabel;
    public UITable questsTable;
    public UILabel skipHint;
    
    // Methods
    private void Awake()
    {
        DailyQuestsBannerController.丆丕丝丒不丙且丐丗 = this;
    }
    private void OnDestroy()
    {
    
    }
    private void 丁上三不丅丅丈丈七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Refreshing after quest system update.");
    }
    public void Show()
    {
        if(this.inBannerSystem != false)
        {
                if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                return;
        }
        
        }
        
        this.gameObject.SetActive(value:  true);
    }
    public void Hide()
    {
        if(this.inBannerSystem != false)
        {
                BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
            return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void OnEnable()
    {
        ExpController.丈丂东丘丙世不七丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DailyQuestsBannerController::丁丟丅万三丕专丒丄()));
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void DailyQuestsBannerController::Hide()), 与且专丈不万东一万:  "Quest Banner");
    }
    private void OnDisable()
    {
        ExpController.丛丘丅与丞丁万不丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DailyQuestsBannerController::丁丟丅万三丕专丒丄()));
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void Update()
    {
        var val_7;
        if(this.blockingFon == 0)
        {
                return;
        }
        
        if(ExpController.丑七不且上丗丁一世() == 0)
        {
            goto label_8;
        }
        
        var val_6 = (ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且() != true) ? 100000 : 100;
        if(this.blockingFon != null)
        {
            goto label_14;
        }
        
        goto label_13;
        label_8:
        val_7 = 100;
        if(this.blockingFon != null)
        {
            goto label_14;
        }
        
        label_13:
        label_14:
        this.blockingFon.depth = 100;
    }
    public void UpdateItems()
    {
    
    }
    private void 丁丟丅万三丕专丒丄()
    {
        if(this.inBannerSystem != false)
        {
                if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
                return;
        }
        
            BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindowNoShowNext();
            return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public DailyQuestsBannerController()
    {
        this.inBannerSystem = true;
    }

}
