using UnityEngine;
internal sealed class MainStoreBanner : BannerWindowWithBack
{
    // Fields
    private static System.Action 丛丄业丘不丆丄三丞;
    private MainStoreView mainStoreView;
    private bool 丞一一一专丑与专业;
    private bool 丞与丒丕下丁丙世丆;
    
    // Methods
    internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  MainStoreBanner.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
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
    internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  MainStoreBanner.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
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
    private void 丆且丐丑东丏不不丑()
    {
        goto typeof(MainStoreBanner).__il2cppRuntimeField_218;
    }
    private void 丑丏上丈丒丂且丞丛()
    {
        coinsShop.丌丘丙丂且丅丞丂世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStoreBanner::丆且丐丑东丏不不丑()));
    }
    private void 丌丞下万丈丒丑万丅()
    {
        coinsShop.丅丞丏丐丛不丈东万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStoreBanner::丆且丐丑东丏不不丑()));
    }
    public override void Show()
    {
        string val_2;
        string val_4;
        PGCompany.专丟专世丅丂丁且专 val_6;
        string val_8;
        bool val_10;
        this.Show();
        this.丌丞下万丈丒丑万丅();
        this.丑丏上丈丒丂且丞丛();
        PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
        PGCompany.丆下丐丁丏世丈上丟 val_3 = this.丑丐丙丄丅世世丑丒();
        PGCompany.丆下丐丁丏世丈上丟 val_5 = this.丑丐丙丄丅世世丑丒();
        PGCompany.丆下丐丁丏世丈上丟 val_7 = this.丑丐丙丄丅世世丑丒();
        PGCompany.丆下丐丁丏世丈上丟 val_9 = this.丑丐丙丄丅世世丑丒();
        this.mainStoreView.丈且东丑丂且万丒丅(丌丟丝丟丆丂世丝丆:  new PGCompany.丕丐世下万丛丛丅丞() {丒专丈丗丆不业丁业 = val_2, 丝丈丞不东丄下丄世 = val_4, 丙丁丑丙丆丐丂业丈 = val_6, 丆丁且丆丘丞丅丒不 = val_10, 且业与与丒一丌与业 = val_8});
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上();
        }
        
        if(FreeAwardController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        FreeAwardController val_14 = FreeAwardController.丑七不且上丗丁一世();
        if(val_14.renderCamera != 0)
        {
                FreeAwardController val_16 = FreeAwardController.丑七不且上丗丁一世();
            this.丞一一一专丑与专业 = val_16.renderCamera.enabled;
            FreeAwardController val_19 = FreeAwardController.丑七不且上丗丁一世();
            val_19.renderCamera.enabled = true;
        }
        
        if(FreeAwardController.丑七不且上丗丁一世().三下丒丅丟丞丁七一() == 0)
        {
                return;
        }
        
        this.丞与丒丕下丁丙世丆 = FreeAwardController.丑七不且上丗丁一世().三下丒丅丟丞丁七一().enabled;
        this = FreeAwardController.丑七不且上丗丁一世().三下丒丅丟丞丁七一();
        this.enabled = true;
    }
    public override void Back()
    {
        System.EventArgs val_25;
        var val_26;
        var val_27;
        ClanLobbyItemController val_28;
        var val_29;
        var val_30;
        this.mainStoreView.丛丄业丘不丆丄三丞();
        this.mainStoreView.世业丒万丘丆专丘丐();
        this.丌丞下万丈丒丑万丅();
        this.Back();
        val_25 = 1152921505086132224;
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                val_26 = null;
            val_26 = null;
            val_25 = System.EventArgs.Empty;
            NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丞丘东丂丐一丑与且(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  val_25);
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_27 = null;
            val_27 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  true);
        }
        
        this.HideSelf();
        if(FreeAwardController.丑七不且上丗丁一世() != 0)
        {
                FreeAwardController val_5 = FreeAwardController.丑七不且上丗丁一世();
            if(val_5.renderCamera != 0)
        {
                FreeAwardController val_7 = FreeAwardController.丑七不且上丗丁一世();
            val_25 = this.丞一一一专丑与专业;
            val_7.renderCamera.enabled = (val_25 == true) ? 1 : 0;
        }
        
            if(FreeAwardController.丑七不且上丗丁一世().三下丒丅丟丞丁七一() != 0)
        {
                FreeAwardController.丑七不且上丗丁一世().三下丒丅丟丞丁七一().enabled = (this.丞与丒丕下丁丙世丆 == true) ? 1 : 0;
        }
        
        }
        
        val_28 = ClanLobbyItemController.丄丘七三上丕世丞业;
        if(val_28 == 0)
        {
            goto label_50;
        }
        
        val_28 = ClanLobbyItemController.丄丘七三上丕世丞业;
        if(ClanLobbyItemController.丄丘七三上丕世丞业.丌业丞世且三三丕东 == false)
        {
            goto label_50;
        }
        
        val_25 = 1152921505471328256;
        val_28 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(val_28 == 0)
        {
            goto label_50;
        }
        
        val_28 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_28 == 0)
        {
            goto label_50;
        }
        
        val_29 = null;
        val_29 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_45;
        }
        
        val_30 = null;
        val_30 = null;
        val_28 = ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject;
        if(val_28.activeSelf == true)
        {
            goto label_50;
        }
        
        label_45:
        ClanLobbyItemController.丄丘七三上丕世丞业.HideClanLobbyItems();
        val_28 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        val_28.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业(), 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
        label_50:
        if(MainStoreBanner.丛丄业丘不丆丄三丞 == null)
        {
                return;
        }
        
        MainStoreBanner.丛丄业丘不丆丄三丞.Invoke();
    }
    public MainStoreBanner()
    {
    
    }

}
