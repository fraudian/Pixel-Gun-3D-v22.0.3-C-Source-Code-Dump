using UnityEngine;
internal sealed class PiggyPromotionBanner : BannerWindowLobbyPurchase, 丑且丆万丏丝丘丙丟
{
    // Fields
    private static PiggyPromotionBanner 丝业丆丁业三丈丟东;
    private static System.Action 业丙丘丈七不下下丐;
    private static System.Action 丛丄业丘不丆丄三丞;
    private PiggyPromotionView _piggyPromotionView;
    
    // Methods
    internal static void 万专丆且七丈业丅丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PiggyPromotionBanner.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PiggyPromotionBanner.业丙丘丈七不下下丐 != 1152921505241034760);
    
    }
    internal static void 丟丑丟丑丂丄丕丆丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PiggyPromotionBanner.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PiggyPromotionBanner.业丙丘丈七不下下丐 != 1152921505241034760);
    
    }
    internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PiggyPromotionBanner.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PiggyPromotionBanner.丛丄业丘不丆丄三丞 != 1152921505241034768);
    
    }
    internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PiggyPromotionBanner.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PiggyPromotionBanner.丛丄业丘不丆丄三丞 != 1152921505241034768);
    
    }
    internal static bool 上丕世丄丟丗丑下不()
    {
        PiggyPromotionBanner val_5;
        var val_6;
        val_5 = PiggyPromotionBanner.丝业丆丁业三丈丟东;
        if(val_5 != 0)
        {
                val_5 = mem[PiggyPromotionBanner.丝业丆丁业三丈丟东 + 312];
            val_5 = PiggyPromotionBanner.丝业丆丁业三丈丟东._piggyPromotionView;
            if(val_5 != 0)
        {
                val_5 = mem[PiggyPromotionBanner.丝业丆丁业三丈丟东 + 312];
            val_5 = PiggyPromotionBanner.丝业丆丁业三丈丟东._piggyPromotionView;
            val_6 = 七与丘丘丈不丂丛丐() ^ 1;
            return (bool)val_6 & 1;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6 & 1;
    }
    internal static bool 丒丘丕且专丒丐东业()
    {
        PiggyPromotionBanner val_3 = PiggyPromotionBanner.丝业丆丁业三丈丟东;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_3 = mem[PiggyPromotionBanner.丝业丆丁业三丈丟东 + 312];
        val_3 = PiggyPromotionBanner.丝业丆丁业三丈丟东._piggyPromotionView;
        if(val_3 == 0)
        {
                return false;
        }
        
        if(null != 0)
        {
                return 七与丘丘丈不丂丛丐();
        }
        
        return 七与丘丘丈不丂丛丐();
    }
    protected override void OnEnable()
    {
        System.Action val_16;
        System.Action val_17;
        string val_18;
        new System.Action() = new System.Action(object:  this, method:  typeof(PiggyPromotionBanner).__il2cppRuntimeField_220);
        this._piggyPromotionView.add_hideRequst(丙业与丙丗丝不丈东:  new System.Action());
        if(this._piggyPromotionView != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            this._piggyPromotionView.Dispose();
        }
        
        if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().专丑三专万丘丂丟丝() != false)
        {
                Rilisoft.BackSystem val_5 = Rilisoft.BackSystem.丑七不且上丗丁一世();
            val_16 = "PiggyPromotionBanner_" + this.gameObject.name;
            val_17 = 0;
            val_18 = val_16;
        }
        else
        {
                System.Action val_10 = null;
            val_16 = val_10;
            val_10 = new System.Action(object:  this, method:  System.Void PiggyPromotionBanner::业且三东不丕专不七());
            val_17 = val_16;
            val_18 = "PiggyPromotionBanner_" + this.gameObject.name;
        }
        
        mem[1152921538542294904] = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_10, 与且专丈不万东一万:  val_18);
    }
    protected override void OnDisable()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(PiggyPromotionBanner).__il2cppRuntimeField_220);
        this._piggyPromotionView.remove_hideRequst(丙业与丙丗丝不丈东:  new System.Action());
        if(this == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.Dispose();
    }
    public override void Show()
    {
        var val_14;
        this.Show();
        PiggyPromotionBanner.丝业丆丁业三丈丟东 = this;
        if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丟丂且丈且丂世三丕() != false)
        {
                PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
            PGCompany.PiggyOffersAnalyticsController.丑七不且上丗丁一世().下丅与且丟世丗万丛();
            PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丐丒三下丛丟业业丑();
            PGCompany.StorePromotionConfig val_7 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丛下丆且丟丙与万丗();
            val_14 = val_7.丝与丘丘丅业一业丘(且世丒下丟不三丟丘:  val_7);
            if(PiggyPromotionBanner.业丙丘丈七不下下丐 == null)
        {
                return;
        }
        
            PiggyPromotionBanner.业丙丘丈七不下下丐.Invoke();
            return;
        }
        
        val_14 = ???;
        goto typeof(PiggyPromotionBanner).__il2cppRuntimeField_1D8;
    }
    public override void Hide()
    {
        this.Hide();
        if(PiggyPromotionBanner.丛丄业丘不丆丄三丞 != null)
        {
                PiggyPromotionBanner.丛丄业丘不丆丄三丞.Invoke();
        }
        
        PiggyPromotionBanner.丝业丆丁业三丈丟东 = 0;
    }
    public override void Back()
    {
        if(this._piggyPromotionView.ShowLastChanceBanner() != false)
        {
                return;
        }
        
        this.Back();
        this.HideSelf();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    private void 业且三东不丕专不七()
    {
        if((this._piggyPromotionView == 0) || (this._piggyPromotionView.ActiveLastChanceBanner == false))
        {
            goto typeof(PiggyPromotionBanner).__il2cppRuntimeField_218;
        }
    
    }
    private PGCompany.MainStore.东丆丒丄丂丆上丈业 丝与丘丘丅业一业丘(PGCompany.StorePromotionConfig 且世丒下丟不三丟丘)
    {
        var val_6;
        PGCompany.丄与丘丑业专丞七丅 val_13;
        .下丐丐丁与丂下世七 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
        PGCompany.StorePromotionSettings val_3 = 且世丒下丟不三丟丘.Settings;
        List.Enumerator<T> val_4 = val_3.ItemRewards.GetEnumerator();
        label_10:
        if(((-423417696) & 1) == 0)
        {
            goto label_5;
        }
        
        val_13 = val_6.丐丏七丌丕丗业且上().Clone();
        if((val_13 != null) && (null != null))
        {
                val_13 = 0;
        }
        
        (PGCompany.DataObjects.专丅一丄上丗且丑一)[1152921538543215856].下丐丐丁与丂下世七.Add(item:  val_13);
        goto label_10;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.MainStore.东丆丒丄丂丆上丈业 val_9 = new PGCompany.MainStore.东丆丒丄丂丆上丈业(上世丏丁世丟世丆业:  且世丒下丟不三丟丘, 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
        bool val_11 = val_9.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "promotion-collectable");
        val_9.七万三丟丞丆丞东业().Clear();
        return val_9;
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        if(this._piggyPromotionView == null)
        {
            
        }
    
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public PiggyPromotionBanner()
    {
    
    }

}
