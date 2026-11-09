using UnityEngine;
private sealed class JoinToFriendRoomController.丂丂上丛专三丐丑三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private string 丁丕丅一万三丄且丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JoinToFriendRoomController.丂丂上丛专三丐丑三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        bool val_34;
        bool val_35;
        int val_36;
        var val_37;
        var val_38;
        var val_39;
        WeaponManager val_40;
        丂丗世丏下专七丅不 val_41;
        var val_42;
        var val_43;
        var val_44;
        UnityEngine.Texture val_45;
        var val_46;
        var val_47;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_30 = null;
        val_30 = null;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        val_31 = null;
        val_31 = null;
        val_32 = 1152921504848912384;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_14;
        }
        
        val_33 = null;
        val_33 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
        {
            goto label_14;
        }
        
        val_34 = 0;
        val_35 = 1;
        goto label_17;
        label_1:
        val_36 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_36;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_38;
        label_3:
        val_36 = 0;
        return (bool)val_36;
        label_14:
        val_35 = false;
        val_34 = true;
        label_17:
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = val_34;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = val_35;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        val_37 = null;
        val_37 = null;
        val_38 = null;
        val_38 = null;
        SceneInfo val_7 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆]));
        this.丁丕丅一万三丄且丐 = val_7.丙且上丒不下丑下丞();
        val_39 = null;
        val_39 = null;
        val_40 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_40 == 0)
        {
            goto label_38;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_10 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_10 == null)
        {
            goto label_41;
        }
        
        val_41 = val_10.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
        if(val_41 != 1)
        {
            goto label_47;
        }
        
        label_41:
        if(val_7 != 0)
        {
                val_41 = val_7.AvaliableWeapon;
        }
        else
        {
                val_41 = 0;
        }
        
        label_47:
        val_42 = null;
        val_42 = null;
        val_40 = WeaponManager.丟丗丄业丘丗业丗七;
        val_40.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  (GameConnect.丑丌丛丈丅丅与不业() == 31) ? 105 : (val_41));
        label_38:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_55;
        }
        
        val_43 = null;
        val_43 = null;
        GameConnect.七七丈东丅上丝丒万 = true;
        UnityEngine.Debug.Log(message:  "map = "("map = ") + 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆]);
        UnityEngine.Debug.Log(message:  this.丁丕丅一万三丄且丐);
        string[] val_20 = new string[5];
        val_20[0] = "LevelLoadings";
        val_32 = "";
        val_20[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : (val_32);
        val_20[2] = "/Loading_";
        val_20[3] = (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Mine_" : (val_32);
        val_20[4] = this.丁丕丅一万三丄且丐;
        UnityEngine.Object val_26 = UnityEngine.Resources.Load(path:  +val_20);
        val_44 = null;
        val_44 = null;
        if(val_26 == null)
        {
            goto label_87;
        }
        
        var val_27 = (null == null) ? (val_26) : 0;
        goto label_88;
        label_55:
        this.丒上七丌业七丟与丐 = 0;
        val_36 = 1;
        this.丗丏丅丕丆世丁专丟 = val_36;
        return (bool)val_36;
        label_87:
        val_45 = 0;
        label_88:
        LoadConnectScene.上三丕下一丅丘上丝 = val_45;
        val_46 = null;
        val_46 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = LoadConnectScene.上三丕下一丅丘上丝;
        LoadConnectScene.丞丗专丝丙专丂上丗 = this.丁丕丅一万三丄且丐;
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        val_47 = null;
        val_47 = null;
        val_40 = 与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟;
        this.丒上七丌业七丟与丐 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  val_40, 丂丛丑东不丅丈一东:  0);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_36 = 1;
        return (bool)val_36;
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
