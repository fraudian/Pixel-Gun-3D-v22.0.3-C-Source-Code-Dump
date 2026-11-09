using UnityEngine;
internal abstract class StorePromotionExtendUIAbstract : PGBehaviour
{
    // Fields
    internal static bool 丘丄丒丟丗丄丑丟与;
    public PGCompany.InventoryItemView InventoryItemView;
    public PGCompany.InventoryItemView InventoryItemViewPrice;
    private UILabel _extendLabel;
    protected PGCompany.东丑丆丗丏丐丟下丄 丂丅七与丘丞丟万丕;
    private static System.Action<int> 丅丒丐且丘丝丝丄且;
    private System.Action 一丝丌丝丄丛丏丒万;
    protected System.IDisposable 东三世丝丒三一丈丛;
    
    // Methods
    internal static void 丏东丌丌丗丙丆世丛(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  StorePromotionExtendUIAbstract.丅丒丐且丘丝丝丄且, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(StorePromotionExtendUIAbstract.丅丒丐且丘丝丝丄且 != 1152921505272078344);
    
    }
    internal static void 东丝业丄丛丅东丌丅(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  StorePromotionExtendUIAbstract.丅丒丐且丘丝丝丄且, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(StorePromotionExtendUIAbstract.丅丒丐且丘丝丝丄且 != 1152921505272078344);
    
    }
    private void 丟丘不丑丐丅丙丏丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.一丝丌丝丄丛丏丒万, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丝丌丝丄丛丏丒万 != 1152921539299854552);
    
    }
    private void 丞世三世七丙丂丁七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.一丝丌丝丄丛丏丒万, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丝丌丝丄丛丏丒万 != 1152921539299991128);
    
    }
    protected virtual void OnEnable()
    {
    
    }
    protected virtual void OnDisable()
    {
    
    }
    internal virtual void 丘上丐世丆丑且丞丒(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Action 丞丟万丝七丁丈丌丝)
    {
        PGCompany.三东丏不丗世丅丌丄 val_4;
        this.丂丅七与丘丞丟万丕 = 丐丆丝业丙丈下世丁;
        this.InventoryItemView.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丐丆丝业丙丈下世丁));
        val_4 = 丐丆丝业丙丈下世丁;
        this.InventoryItemViewPrice.Setup(丈丄不七三万丄丁不:  val_4);
        PGCompany.三东丏不丗世丅丌丄 val_2 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丐丆丝业丙丈下世丁);
        if(val_2 == null)
        {
                return;
        }
        
        val_4 = this.丂丅七与丘丞丟万丕;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._extendLabel, 丕丗丘丑丛与丑业丒:  val_4);
        if(StorePromotionExtendUIAbstract.丅丒丐且丘丝丝丄且 != null)
        {
                StorePromotionExtendUIAbstract.丅丒丐且丘丝丝丄且.Invoke(obj:  val_2.业东丅东丌上丗丑不());
        }
        
        this.一丝丌丝丄丛丏丒万 = 丞丟万丝七丁丈丌丝;
    }
    internal void 丞业丅丛丐丌丗丝丌(System.Action 丞丟万丝七丁丈丌丝)
    {
        this.一丝丌丝丄丛丏丒万 = 丞丟万丝七丁丈丌丝;
    }
    public virtual void Purchase()
    {
        PGCompany.三东丏不丗世丅丌丄 val_12;
        var val_13;
        var val_14;
        if(this.丂丅七与丘丞丟万丕 == null)
        {
                return;
        }
        
        val_12 = this.丂丅七与丘丞丟万丕.且丏三丞丝丟丘丅丕();
        if(this.丂丅七与丘丞丟万丕 == null)
        {
            goto label_2;
        }
        
        if(val_12 == false)
        {
            goto label_3;
        }
        
        label_4:
        this.丂丅七与丘丞丟万丕.丈丙且一万丟丕万下();
        return;
        label_2:
        if(val_12 == true)
        {
            goto label_4;
        }
        
        label_3:
        if(((this.丂丅七与丘丞丟万丕 == null) || (this.丂丅七与丘丞丟万丕.业东丅东丌上丗丑不() == 10015)) || (this.丂丅七与丘丞丟万丕.业东丅东丌上丗丑不() == 11015))
        {
            goto label_11;
        }
        
        val_12 = this.丂丅七与丘丞丟万丕;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_12, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_14;
        }
        
        label_11:
        StorePromotionExtendUIAbstract.丘丄丒丟丗丄丑丟与 = true;
        this.丂丅七与丘丞丟万丕.丏丝丘七丕与世丅丆();
        return;
        label_14:
        val_13 = null;
        val_13 = null;
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  StorePromotionExtendUIAbstract.<>c.<>9, method:  System.Void StorePromotionExtendUIAbstract.<>c::与丄且丝东丌丐业东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_14 = null;
        val_14 = null;
        BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  PGCompany.ClanStoreMainUI.丑丝专丐与与业丏丗);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  this.丂丅七与丘丞丟万丕.业上丙丞丐丄丆丅七(), 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    public virtual void Hide()
    {
        if(this.一丝丌丝丄丛丏丒万 == null)
        {
                return;
        }
        
        this.一丝丌丝丄丛丏丒万.Invoke();
    }
    protected StorePromotionExtendUIAbstract()
    {
    
    }

}
