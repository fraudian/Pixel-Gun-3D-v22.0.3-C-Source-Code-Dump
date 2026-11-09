using UnityEngine;
internal sealed class BlackMarketPromotionView : StorePromotionView
{
    // Fields
    private static System.Action<BlackMarketPromotionView> 世丙丄一丂世不万丁;
    private PGCompany.BM.世丘丈丑丘万丆丞丈 <丆丏业丙丒且万丈丂>k__BackingField;
    private BlackMarketPromorionLinkView link_BottomForward;
    private BlackMarketPromorionLinkView link_Forward;
    private BlackMarketPromorionLinkView link_Down;
    private System.Collections.Generic.List<UILabel> levelRequired;
    private UnityEngine.GameObject refreshGlow;
    private ItemCountView countView;
    private UnityEngine.GameObject state_Purchased;
    private UnityEngine.GameObject state_NotPurchased;
    private UILabel blackMarketPoints;
    private UnityEngine.GameObject blackMarketPointsHolder;
    private UnityEngine.GameObject inEventStore;
    private UnityEngine.GameObject state_LockedByLevel;
    private UILabel bmLevelLabel;
    private UnityEngine.GameObject state_LockedByRank;
    private UISprite rankIcon;
    private UILabel clanRankLabel;
    private UnityEngine.GameObject state_LockedByLinks;
    private UILabel lokedByLinksLabel;
    private BlackMarketPromotionView.丏丂万万丞丞丆一上 万丟丞不丂上专七丝;
    private BlackMarketPromotionView.丏丂万万丞丞丆一上 丅丞一丘丁丙丏丘丐;
    
    // Properties
    internal PGCompany.BM.世丘丈丑丘万丆丞丈 与丙三业丟丟丛丁丕 { get; set; }
    
    // Methods
    internal static void 与且丑一丈丘且丙丄(System.Action<BlackMarketPromotionView> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  BlackMarketPromotionView.世丙丄一丂世不万丁, b:  丙业与丙丗丝不丈东);
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
    internal static void 七丏丙世丝丒丈七丄(System.Action<BlackMarketPromotionView> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  BlackMarketPromotionView.世丙丄一丂世不万丁, value:  丙业与丙丗丝不丈东);
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
    internal PGCompany.BM.世丘丈丑丘万丆丞丈 专专丄丅万且万丞三()
    {
        return (PGCompany.BM.世丘丈丑丘万丆丞丈)this.<丆丏业丙丒且万丈丂>k__BackingField;
    }
    private void 丕丁丄不丗世丕丁丒(PGCompany.BM.世丘丈丑丘万丆丞丈 丙业与丙丗丝不丈东)
    {
        this.<丆丏业丙丒且万丈丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public BlackMarketPromotionView.丏丂万万丞丞丆一上 GetCurrentUiState()
    {
        PGCompany.BM.世丘丈丑丘万丆丞丈 val_8;
        PGCompany.BM.世丘丈丑丘万丆丞丈 val_9;
        val_8 = this;
        val_9 = this.<丆丏业丙丒且万丈丂>k__BackingField;
        if(val_9 == null)
        {
                return (丏丂万万丞丞丆一上)((val_8.丄三丑下丁丕一一丂() & true) != 0) ? (4 + 1) : 4;
        }
        
        if(val_9.丗丞丅且丙丈丂丙不() != false)
        {
                val_9 = 3;
            return (丏丂万万丞丞丆一上)((val_8.丄三丑下丁丕一一丂() & true) != 0) ? (4 + 1) : 4;
        }
        
        if((this.<丆丏业丙丒且万丈丂>k__BackingField.丗丙丐下丏丝丁丘三()) != false)
        {
                val_9 = 1;
            return (丏丂万万丞丞丆一上)((val_8.丄三丑下丁丕一一丂() & true) != 0) ? (4 + 1) : 4;
        }
        
        bool val_3 = this.<丆丏业丙丒且万丈丂>k__BackingField.专丒丟丝与丏业专一();
        val_8 = this.<丆丏业丙丒且万丈丂>k__BackingField;
        if(val_8 == null)
        {
            goto label_7;
        }
        
        if(val_3 == false)
        {
                return (丏丂万万丞丞丆一上)((val_8.丄三丑下丁丕一一丂() & true) != 0) ? (4 + 1) : 4;
        }
        
        label_10:
        var val_5 = (val_8.与专丂丒丐丑不世一() != true) ? 6 : 2;
        return (丏丂万万丞丞丆一上)((val_8.丄三丑下丁丕一一丂() & true) != 0) ? (4 + 1) : 4;
        label_7:
        if(val_3 == true)
        {
            goto label_10;
        }
        
        return (丏丂万万丞丞丆一上)((val_8.丄三丑下丁丕一一丂() & true) != 0) ? (4 + 1) : 4;
    }
    public void StupLinksView()
    {
        BlackMarketPromorionLinkView val_11;
        if((this.<丆丏业丙丒且万丈丂>k__BackingField.下专万丌丞与与一丈()) == 3)
        {
                if(this.丅丞一丘丁丙丏丘丐 != 1)
        {
            goto label_3;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.link_BottomForward)) != false)
        {
                val_11 = this.link_BottomForward;
            val_11.丈且东丑丂且万丒丅(不丛丕丞三丐丅专三:  this.<丆丏业丙丒且万丈丂>k__BackingField, 上丗一三丙世丗丕丂:  this.<丆丏业丙丒且万丈丂>k__BackingField.丙丙专丕不丒万丛丌());
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.link_Forward)) != false)
        {
                val_11 = this.link_Forward;
            val_11.丈且东丑丂且万丒丅(不丛丕丞三丐丅专三:  this.<丆丏业丙丒且万丈丂>k__BackingField, 上丗一三丙世丗丕丂:  this.<丆丏业丙丒且万丈丂>k__BackingField.丐丅丕丈丐与丂专丟());
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.link_Down)) == false)
        {
                return;
        }
        
        this.link_Down.丈且东丑丂且万丒丅(不丛丕丞三丐丅专三:  this.<丆丏业丙丒且万丈丂>k__BackingField, 上丗一三丙世丗丕丂:  this.<丆丏业丙丒且万丈丂>k__BackingField.丅丅专丞丆丞且丂专());
        return;
        label_3:
        val_11 = 1152921504848912384;
        if((UnityEngine.Object.op_Implicit(exists:  this.link_BottomForward)) != false)
        {
                this.link_BottomForward.丈且东丑丂且万丒丅(丏业丟一东丂东丘丛:  0);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.link_Forward)) != false)
        {
                this.link_Forward.丈且东丑丂且万丒丅(丏业丟一东丂东丘丛:  0);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.link_Down)) == false)
        {
                return;
        }
        
        this.link_Down.丈且东丑丂且万丒丅(丏业丟一东丂东丘丛:  0);
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        if(且丘丏丁丑与丙与丁 != null)
        {
                this.<丆丏业丙丒且万丈丂>k__BackingField = 且丘丏丁丑与丙与丁;
        }
        else
        {
                UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Promotion {0} is not BlackMarketPromotion!", arg0:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与()));
        }
        
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        且丘丏丁丑与丙与丁.不业丗丌下丐丝丞丘(丙业与丙丗丝不丈东:  new System.Action<PGCompany.InventoryItemView>(object:  this, method:  System.Void BlackMarketPromotionView::丙万下丅不丕万丘丄(PGCompany.InventoryItemView 万且万且丑丗且丌丆)));
        且丘丏丁丑与丙与丁.丁七丛东丐丈上丟丌(丙业与丙丗丝不丈东:  new System.Action<PGCompany.InventoryItemView>(object:  this, method:  System.Void BlackMarketPromotionView::丙万下丅不丕万丘丄(PGCompany.InventoryItemView 万且万且丑丗且丌丆)));
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        this.万丟丞不丂上专七丝 = this.丅丞一丘丁丙丏丘丐;
        this.丅丞一丘丁丙丏丘丐 = this.GetCurrentUiState();
        this.不东丈丕不丝一东丙();
        if(this.丅丞一丘丁丙丏丘丐 <= 6)
        {
                var val_5 = 106032980;
            val_5 = (106032980 + (this.丅丞一丘丁丙丏丘丐) << 2) + val_5;
        }
        else
        {
                this.StupLinksView();
            PGCompany.三东丏不丗世丅丌丄 val_3 = this.<丆丏业丙丒且万丈丂>k__BackingField.丄丏丒丞世东丗上专();
            return (bool)this.丝一丅丆三东丂丞七();
        }
    
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Purchased, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotPurchased, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByLevel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByRank, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByLinks, 丏业丟一东丂东丘丛:  false);
        this.ToggleRefreshGlow(丛丅丘一丏丙且丌上:  false);
        if((this.<丆丏业丙丒且万丈丂>k__BackingField) == null)
        {
                return;
        }
        
        this = this.levelRequired;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this, 丕丗丘丑丛与丑业丒:  this.<丆丏业丙丒且万丈丂>k__BackingField.丅丝丕不丛丟丕丐丆());
    }
    private void 丄丟不丏丗丕丗业丌()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Purchased, 丏业丟一东丂东丘丛:  true);
    }
    private void 丏丁与且丘丏丆丞丂()
    {
        UnityEngine.GameObject val_7;
        var val_8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotPurchased, 丏业丟一东丂东丘丛:  true);
        if(((this.<丆丏业丙丒且万丈丂>k__BackingField.丗丏丏上丟丐东丄丛()) >= 1) && (PGCompany.七丄三丝丐业丄丅丝.世丟丈丌丝东丂丆丁().丁丟丈丌丑丅丞世丏() != false))
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.blackMarketPoints, 丕丗丘丑丛与丑业丒:  this.<丆丏业丙丒且万丈丂>k__BackingField.丗丏丏上丟丐东丄丛());
            val_7 = this.blackMarketPointsHolder;
            val_8 = 1;
        }
        else
        {
                val_7 = this.blackMarketPointsHolder;
            val_8 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  false);
        if(this.万丟丞不丂上专七丝 == 5)
        {
                UnityEngine.Debug.LogError(message:  "Play UnlockByLinks Animation");
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inEventStore, 丏业丟一东丂东丘丛:  this.<丆丏业丙丒且万丈丂>k__BackingField.与专丂丒丐丑不世一());
    }
    private void 三丌丏七丒三丌专丁()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inEventStore, 丏业丟一东丂东丘丛:  true);
        if((this.<丆丏业丙丒且万丈丂>k__BackingField.丗丏丏上丟丐东丄丛()) >= 1)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.blackMarketPoints, 丕丗丘丑丛与丑业丒:  this.<丆丏业丙丒且万丈丂>k__BackingField.丗丏丏上丟丐东丄丛());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blackMarketPointsHolder, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blackMarketPointsHolder, 丏业丟一东丂东丘丛:  false);
    }
    private void 丈丛丈丐丐东上丁下()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByLevel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.bmLevelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9109"), arg0:  this.<丆丏业丙丒且万丈丂>k__BackingField.丅丝丕不丛丟丕丐丆()));
    }
    private void 丒丒与丑上丏丂丞丏()
    {
        UISprite val_6;
        string val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByRank, 丏业丟一东丂东丘丛:  true);
        PGCompany.丟丁丅万与丏丙三下 val_2 = 丌丅且丗七丘丅丛丑.丄专丆业世专丕专与(专世专丟丝丌与丘上:  this.<丆丏业丙丒且万丈丂>k__BackingField.丈不丑万七丕丝丌丅());
        if(val_2 != null)
        {
                val_6 = this.rankIcon;
            val_7 = val_2.丟丗丛丌一丁世东丑();
        }
        else
        {
                val_6 = this.rankIcon;
            val_7 = "";
        }
        
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  val_6, 万丑丞一丝丌丐丒丘:  val_7);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanRankLabel, 丕丗丘丑丛与丑业丒:  "# Need Rank:"("# Need Rank:") + this.<丆丏业丙丒且万丈丂>k__BackingField.丈不丑万七丕丝丌丅()(this.<丆丏业丙丒且万丈丂>k__BackingField.丈不丑万七丕丝丌丅()));
    }
    private void 丑东丌丐丏丆丒一三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByLinks, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.lokedByLinksLabel, 丕丗丘丑丛与丑业丒:  "Unlock links first");
    }
    public void ToggleRefreshGlow(bool 丛丅丘一丏丙且丌上)
    {
        UnityEngine.GameObject val_1;
        var val_2;
        UnityEngine.GameObject val_3;
        if((丛丅丘一丏丙且丌上 != false) && (this.丅丞一丘丁丙丏丘丐 == 2))
        {
                val_1 = this.refreshGlow;
            val_2 = 1;
            val_3 = val_1;
        }
        else
        {
                val_1 = this.refreshGlow;
            val_3 = val_1;
            val_2 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
    }
    private void 丙万下丅不丕万丘丄(PGCompany.InventoryItemView 万且万且丑丗且丌丆)
    {
        if(BlackMarketPromotionView.世丙丄一丂世不万丁 == null)
        {
                return;
        }
        
        BlackMarketPromotionView.世丙丄一丂世不万丁.Invoke(obj:  this);
    }
    public void U_ShowLockedByRank()
    {
        if(this.丅丞一丘丁丙丏丘丐 != 4)
        {
                return;
        }
        
        int val_5 = this.<丆丏业丙丒且万丈丂>k__BackingField.丈不丑万七丕丝丌丅();
        string val_2 = 丌丅且丗七丘丅丛丑.丌丂丄丆专丄丞万丅(专世专丟丝丌与丘上:  val_5);
        val_5 = (val_2 == null) ? "" : (val_2);
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9180"), arg0:  val_5));
    }
    public BlackMarketPromotionView()
    {
    
    }

}
