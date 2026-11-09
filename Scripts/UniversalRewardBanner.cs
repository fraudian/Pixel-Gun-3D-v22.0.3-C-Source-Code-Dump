using UnityEngine;
internal sealed class UniversalRewardBanner : BannerWindowWithBack
{
    // Fields
    private static System.Action 七丝丕丅与且丘业万;
    private static System.Action 与业丑丅丁丌丛丑丒;
    private static bool <不丟东上丂丘一不万>k__BackingField;
    private UniversalRewardView universalRewardView;
    
    // Properties
    internal static bool 丅业东万丌丕上丌丄 { get; set; }
    
    // Methods
    internal static void 丒丏丏丛丕丐丂丛丐(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  UniversalRewardBanner.七丝丕丅与且丘业万, b:  丙业与丙丗丝不丈东);
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
    internal static void 丝七丘丌丝业一丟丁(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  UniversalRewardBanner.七丝丕丅与且丘业万, value:  丙业与丙丗丝不丈东);
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
    internal static void 一与与一世丑丒与丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  UniversalRewardBanner.与业丑丅丁丌丛丑丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(UniversalRewardBanner.与业丑丅丁丌丛丑丒 != 1152921505282248712);
    
    }
    internal static void 丟丂万与万与丆丄丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  UniversalRewardBanner.与业丑丅丁丌丛丑丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(UniversalRewardBanner.与业丑丅丁丌丛丑丒 != 1152921505282248712);
    
    }
    internal static bool 丈丐丞丐上丑且丕万()
    {
        return (bool)UniversalRewardBanner.<不丟东上丂丘一不万>k__BackingField;
    }
    private static void 七丝丆丂丞丙丆丟三(bool 丙业与丙丗丝不丈东)
    {
        UniversalRewardBanner.<不丟东上丂丘一不万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    protected override void Awake()
    {
        this.universalRewardView.丞丌丑丐丑丆上丗丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalRewardBanner::丗世丒丁不且不丐丏()));
        this.Awake();
    }
    protected override void OnEnable()
    {
        UniversalRewardBanner.<不丟东上丂丘一不万>k__BackingField = true;
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        UniversalRewardBanner.<不丟东上丂丘一不万>k__BackingField = false;
        this.OnDisable();
    }
    protected override void OnDestroy()
    {
        this.universalRewardView.丛不丝丗一丏三专丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalRewardBanner::丗世丒丁不且不丐丏()));
        this.OnDestroy();
    }
    public override void Show()
    {
        var val_3;
        与丏下丒与丙丟丝一 val_10;
        this.Show();
        UniversalRewardController.与丏下丒与丙丟丝一 val_1 = null;
        val_10 = val_1;
        val_1 = new UniversalRewardController.与丏下丒与丙丟丝一();
        PGCompany.丆下丐丁丏世丈上丟 val_2 = this.丑丐丙丄丅世世丑丒();
        if(val_3 == 0)
        {
            goto label_1;
        }
        
        PGCompany.丆下丐丁丏世丈上丟 val_4 = this.丑丐丙丄丅世世丑丒();
        val_10 = val_3;
        goto label_2;
        label_1:
        System.Collections.Generic.Dictionary<丈下专丂丑不丑丗丁, System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>> val_6 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().丕世七丗丁万且世专();
        丈下专丂丑不丑丗丁 val_8 = System.Linq.Enumerable.FirstOrDefault<丈下专丂丑不丑丗丁>(source:  val_6.Keys);
        if(val_10 == null)
        {
            goto label_5;
        }
        
        .且丒丛与丞世丙丕丌 = val_8;
        if(val_6 != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        .丆丌丙丛丄丂丘丟丟 = val_6.Item[val_8];
        label_2:
        this.universalRewardView.Setup(丗丐丝丗丞丏丝丕丄:  val_1);
        if(UniversalRewardBanner.与业丑丅丁丌丛丑丒 == null)
        {
                return;
        }
        
        UniversalRewardBanner.与业丑丅丁丌丛丑丒.Invoke();
        return;
        label_5:
        mem[16] = val_8;
        if(val_6 != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    public override void Back()
    {
        this.universalRewardView.Clear();
        this.HideSelf();
        this.Back();
        if(UniversalRewardBanner.七丝丕丅与且丘业万 == null)
        {
                return;
        }
        
        UniversalRewardBanner.七丝丕丅与且丘业万.Invoke();
    }
    private void 丗世丒丁不且不丐丏()
    {
        goto typeof(UniversalRewardBanner).__il2cppRuntimeField_218;
    }
    public UniversalRewardBanner()
    {
    
    }

}
