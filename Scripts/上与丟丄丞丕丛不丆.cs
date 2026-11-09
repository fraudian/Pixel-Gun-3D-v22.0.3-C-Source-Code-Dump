using UnityEngine;
private sealed class JoinRoomFromFrends.上与丟丄丞丕丛不丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private SceneInfo 丂不丟三丏丏丒上且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JoinRoomFromFrends.上与丟丄丞丕丛不丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        bool val_36;
        bool val_37;
        int val_38;
        var val_39;
        var val_40;
        WeaponManager val_41;
        var val_42;
        丂丗世丏下专七丅不 val_43;
        var val_44;
        var val_45;
        var val_46;
        UnityEngine.Texture val_47;
        var val_48;
        var val_49;
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
        val_32 = null;
        val_32 = null;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        val_33 = null;
        val_33 = null;
        val_34 = 1152921504848912384;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_14;
        }
        
        val_35 = null;
        val_35 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
        {
            goto label_14;
        }
        
        val_36 = 0;
        val_37 = 1;
        goto label_17;
        label_1:
        val_38 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_38;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_19;
        label_3:
        val_38 = 0;
        return (bool)val_38;
        label_14:
        val_37 = false;
        val_36 = true;
        label_17:
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = val_36;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = val_37;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        val_39 = null;
        val_39 = null;
        val_40 = null;
        val_40 = null;
        this.丂不丟三丏丏丒上且 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆]));
        GameConnect.七七丈东丅上丝丒万 = true;
        val_41 = 1152921505286238208;
        val_42 = null;
        val_42 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_37;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_9 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_9 == null)
        {
            goto label_40;
        }
        
        val_43 = val_9.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
        if(val_43 != 1)
        {
            goto label_46;
        }
        
        label_40:
        if(this.丂不丟三丏丏丒上且 != 0)
        {
                val_43 = this.丂不丟三丏丏丒上且.AvaliableWeapon;
        }
        else
        {
                val_43 = 0;
        }
        
        label_46:
        val_44 = null;
        val_44 = null;
        val_41 = WeaponManager.丟丗丄业丘丗业丗七;
        val_41.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  (GameConnect.丑丌丛丈丅丅与不业() == 31) ? 105 : (val_43));
        label_37:
        UnityEngine.Debug.Log(message:  "Move To Game Scene");
        label_19:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_56;
        }
        
        val_45 = null;
        val_45 = null;
        UnityEngine.Debug.Log(message:  "map="("map=") + 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆]);
        UnityEngine.Debug.Log(message:  this.丂不丟三丏丏丒上且.丙且上丒不下丑下丞());
        string[] val_20 = new string[5];
        val_20[0] = "LevelLoadings";
        val_34 = "";
        val_20[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : (val_34);
        val_20[2] = "/Loading_";
        val_20[3] = (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Mine_" : (val_34);
        val_20[4] = this.丂不丟三丏丏丒上且.丙且上丒不下丑下丞();
        UnityEngine.Object val_27 = UnityEngine.Resources.Load(path:  +val_20);
        val_46 = null;
        val_46 = null;
        if(val_27 == null)
        {
            goto label_90;
        }
        
        var val_28 = (null == null) ? (val_27) : 0;
        goto label_91;
        label_56:
        this.丒上七丌业七丟与丐 = 0;
        val_38 = 1;
        this.丗丏丅丕丆世丁专丟 = val_38;
        return (bool)val_38;
        label_90:
        val_47 = 0;
        label_91:
        LoadConnectScene.上三丕下一丅丘上丝 = val_47;
        val_48 = null;
        val_48 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = LoadConnectScene.上三丕下一丅丘上丝;
        LoadConnectScene.丞丗专丝丙专丂上丗 = this.丂不丟三丏丏丒上且.丙且上丒不下丑下丞();
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        val_49 = null;
        val_49 = null;
        val_41 = 与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟;
        this.丒上七丌业七丟与丐 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  val_41, 丂丛丑东不丅丈一东:  0);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_38 = 1;
        return (bool)val_38;
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
