using UnityEngine;
private sealed class MainMenuController.丄丁业丌丆丏万丟丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MainMenuController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.丄丁业丌丆丏万丟丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_51;
        FriendsController val_52;
        var val_53;
        var val_54;
        int val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_51 = null;
        val_51 = null;
        val_52 = FriendsController.丄丞丁丈与业上丞丟;
        if(val_52 == 0)
        {
            goto label_6;
        }
        
        val_53 = null;
        val_53 = null;
        val_52 = TempItemsController.丄丞丁丈与业上丞丟;
        if(val_52 != 0)
        {
            goto label_176;
        }
        
        label_6:
        val_54 = 0;
        val_55 = 1;
        goto label_12;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        业丈不上丟万一丕丏 val_3 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
        if(val_3.丌丗丑业丁上丆万七() != false)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_176;
        }
        
        }
        
        if((this.丝且与丝丒丟万丁专.丑东丑丟上丘下七丘() == true) || (val_3.activeInHierarchy == true))
        {
            goto label_176;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
            goto label_176;
        }
        
        }
        
        val_56 = null;
        val_56 = null;
        if(SeasonEndView.世丑丗上丘丟丐丂丕 == false)
        {
            goto label_35;
        }
        
        label_176:
        val_57 = null;
        val_57 = null;
        val_52 = FriendsController.丄丞丁丈与业上丞丟.MyWaitForSeconds(七且丆丞丌丘下世丑:  1f);
        val_55 = 2;
        label_12:
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_52);
        val_58 = 1;
        this.丗丏丅丕丆世丁专丟 = val_55;
        return (bool)val_58;
        label_13:
        val_58 = 0;
        return (bool)val_58;
        label_35:
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
            goto label_176;
        }
        
        }
        
        val_59 = null;
        val_59 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 == 0)
        {
            goto label_50;
        }
        
        val_60 = null;
        val_60 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专.gameObject.activeInHierarchy == true)
        {
            goto label_176;
        }
        
        label_50:
        val_61 = null;
        val_61 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_60;
        }
        
        val_62 = null;
        val_62 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
        {
            goto label_176;
        }
        
        label_60:
        if(Rilisoft.ClansLobbyGui.丑七不且上丗丁一世() != 0)
        {
                if(Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().gameObject.activeInHierarchy == true)
        {
            goto label_176;
        }
        
        }
        
        val_63 = null;
        val_63 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_75;
        }
        
        val_64 = null;
        val_64 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
            goto label_176;
        }
        
        label_75:
        if(this.丝且与丝丒丟万丁专.RentExpiredPoint.childCount != 0)
        {
            goto label_176;
        }
        
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "Banner_CompensationCalculated170818Key", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 1)
        {
            goto label_84;
        }
        
        UnityEngine.GameObject val_31 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/BannerBalanceChange090818"));
        val_31.transform.parent = this.丝且与丝丒丟万丁专.RentExpiredPoint;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_31, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Banners"));
        val_31.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_36 = UnityEngine.Quaternion.identity;
        val_31.transform.localRotation = new UnityEngine.Quaternion() {x = val_36.x, y = val_36.y, z = val_36.z, w = val_36.w};
        val_31.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_176;
        label_84:
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "ShouldInformAboutFire_V4", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) >= 1)
        {
                if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "_12_5_Banner_shown_key_V4", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 0)
        {
            goto label_105;
        }
        
        }
        
        if(((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "IsTrophiesM_igrationSeptembe_r2018OccuredKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) < 1) || ((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "IsTrophies_MigrationS_eptember2018_Banner_Shown_Key", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0))
        {
            goto label_176;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "IsTrophies_MigrationS_eptember2018_Banner_Shown_Key", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        UnityEngine.GameObject val_43 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/NewTournamentBanner"));
        val_43.transform.parent = this.丝且与丝丒丟万丁专.RentExpiredPoint;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_43, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Banners"));
        val_43.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_48 = UnityEngine.Quaternion.identity;
        val_43.transform.localRotation = new UnityEngine.Quaternion() {x = val_48.x, y = val_48.y, z = val_48.z, w = val_48.w};
        val_43.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_176;
        label_105:
        this.丝且与丝丒丟万丁专.ShowNewBalanceBanner_12_5();
        goto label_176;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
