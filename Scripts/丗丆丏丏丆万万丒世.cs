using UnityEngine;
private sealed class MainMenuController.丗丆丏丏丆万万丒世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 丒不丙万万不丕丞与;
    public 与丂丏丛丞丞丒丟丄.丘丑丏业专丞业丆三 丁丟丑丆三丆业一丅;
    public bool 世不丛业丟丝与丆丙;
    public string 丑丐丗三丒世丏东丅;
    public bool 丛丑丂丛丙一上专丆;
    public bool 丌与一丌且一不七丆;
    public bool 丝丅与业且一丛丒一;
    public Rilisoft.七丕丟丏三丈一丄世 丅与丏与丙东世丌世;
    private SceneInfo 丂不丟三丏丏丒上且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.丗丆丏丏丆万万丒世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_31;
        var val_32;
        int val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        丂丗世丏下专七丅不 val_46;
        var val_47;
        var val_48;
        var val_49;
        UnityEngine.Texture val_50;
        var val_51;
        var val_52;
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
        ShopNGUIController.上万丐丞丂丐丌丛丆(丁丅丟丒丙丐丅与丂:  false);
        val_31 = null;
        val_31 = null;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = this.丒不丙万万不丕丞与;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = this.丁丟丑丆三丆业一丅;
        if(this.世不丛业丟丝与丆丙 == false)
        {
            goto label_8;
        }
        
        val_31 = null;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = true;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        val_32 = null;
        val_32 = null;
        MainMenuController.专丑丙丞丙万丗东丒 = this.丑丐丗三丒世丏东丅;
        goto label_13;
        label_1:
        val_33 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_33;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_61;
        label_3:
        val_33 = 0;
        return (bool)val_33;
        label_8:
        val_34 = null;
        val_34 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_35 = null;
            val_35 = null;
            val_36 = MainMenuController.丄丞丁丈与业上丞丟.一丑丟世丛丌丁下不();
        }
        else
        {
                val_36 = 0;
        }
        
        val_36 = val_36 | this.丛丑丂丛丙一上专丆;
        val_36 = val_36 | this.丌与一丌且一不七丆;
        if(val_36 == false)
        {
            goto label_26;
        }
        
        val_37 = null;
        val_37 = null;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        label_116:
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        goto label_29;
        label_26:
        val_38 = null;
        val_38 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_38;
        }
        
        val_39 = null;
        val_39 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
        {
            goto label_38;
        }
        
        val_40 = 1;
        goto label_39;
        label_38:
        val_41 = null;
        val_41 = null;
        val_40 = (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  与丂丏丛丞丞丒丟丄.丘且丝万丙丕丙丁丙))) & 1;
        label_39:
        val_42 = null;
        val_40 = val_40 | this.丝丅与业且一丛丒一;
        if(val_40 == false)
        {
            goto label_44;
        }
        
        val_37 = null;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = true;
        label_29:
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        label_13:
        val_43 = null;
        val_43 = null;
        val_44 = null;
        val_44 = null;
        this.丂不丟三丏丏丒上且 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆]));
        GameConnect.七七丈东丅上丝丒万 = true;
        val_45 = null;
        val_45 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_61;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_12 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_12 == null)
        {
            goto label_64;
        }
        
        val_46 = val_12.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
        if(val_46 != 1)
        {
            goto label_70;
        }
        
        label_64:
        if(this.丂不丟三丏丏丒上且 != 0)
        {
                val_46 = this.丂不丟三丏丏丒上且.AvaliableWeapon;
        }
        else
        {
                val_46 = 0;
        }
        
        label_70:
        val_47 = null;
        val_47 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  (GameConnect.丑丌丛丈丅丅与不业() == 31) ? 105 : (val_46));
        label_61:
        val_48 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_78;
        }
        
        if(this.丅与丏与丙东世丌世 != 100)
        {
                GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  this.丅与丏与丙东世丌世);
        }
        
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        string[] val_18 = new string[5];
        val_18[0] = "LevelLoadings";
        val_18[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "";
        val_18[2] = "/Loading_";
        val_18[3] = (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Mine_" : "";
        val_18[4] = this.丂不丟三丏丏丒上且.丙且上丒不下丑下丞();
        UnityEngine.Object val_25 = UnityEngine.Resources.Load(path:  +val_18);
        val_48 = 1152921505079582720;
        val_49 = null;
        val_49 = null;
        if(val_25 == null)
        {
            goto label_107;
        }
        
        var val_26 = (null == null) ? (val_25) : 0;
        goto label_108;
        label_78:
        this.丒上七丌业七丟与丐 = 0;
        val_33 = 1;
        this.丗丏丅丕丆世丁专丟 = val_33;
        return (bool)val_33;
        label_107:
        val_50 = 0;
        label_108:
        LoadConnectScene.上三丕下一丅丘上丝 = val_50;
        val_51 = null;
        val_51 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = LoadConnectScene.上三丕下一丅丘上丝;
        LoadConnectScene.丞丗专丝丙专丂上丗 = this.丂不丟三丏丏丒上且.丙且上丒不下丑下丞();
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        this.丒上七丌业七丟与丐 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  "PromScene", 丂丛丑东不丅丈一东:  0);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_33 = 1;
        return (bool)val_33;
        label_44:
        val_52 = null;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = true;
        goto label_116;
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
