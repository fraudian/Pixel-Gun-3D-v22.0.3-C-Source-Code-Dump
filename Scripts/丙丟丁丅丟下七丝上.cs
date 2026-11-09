using UnityEngine;
private sealed class InGameConnection.丙丟丁丅丟下七丝上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public InGameConnection 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameConnection.丙丟丁丅丟下七丝上(int 丗丏丅丕丆世丁专丟)
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
        WeaponManager val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        UnityEngine.Texture val_44;
        var val_45;
        var val_46;
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
        if(this.丝且与丝丒丟万丁专.东且丅世七一丐丙专 == 3)
        {
            goto label_17;
        }
        
        val_31 = 1152921505066536960;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_1 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_1 == null)
        {
            goto label_8;
        }
        
        val_32 = val_1.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
        goto label_9;
        label_1:
        val_33 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_33;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_11;
        label_3:
        val_33 = 0;
        return (bool)val_33;
        label_8:
        val_32 = 0;
        label_9:
        val_34 = null;
        val_34 = null;
        val_35 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_35 != 0)
        {
                if(this.丝且与丝丒丟万丁专.专七丗丅业丟丂七上 != 0)
        {
                val_36 = null;
            val_36 = null;
            if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  this.丝且与丝丒丟万丁专.专七丗丅业丟丂七上.丙且上丒不下丑下丞())) != false)
        {
                val_37 = null;
            val_37 = null;
            val_32 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[this.丝且与丝丒丟万丁专.专七丗丅业丟丂七上.丙且上丒不下丑下丞()];
        }
        
        }
        
            val_38 = null;
            val_38 = null;
            val_35 = WeaponManager.丟丗丄业丘丗业丗七;
            val_35.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  (GameConnect.丑丌丛丈丅丅与不业() == 31) ? 105 : (val_32));
        }
        
        label_17:
        UnityEngine.Debug.Log(message:  "Move To Game Scene");
        label_11:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_39;
        }
        
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        val_39 = null;
        val_39 = null;
        val_40 = null;
        val_40 = null;
        SceneInfo val_16 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]));
        string[] val_17 = new string[6];
        val_17[0] = "LevelLoadings";
        val_17[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "";
        val_17[2] = "/Loading_";
        val_17[3] = (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Mine_" : "";
        val_17[4] = val_16.丙且上丒不下丑下丞();
        val_41 = "";
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_42 = null;
            val_42 = null;
        }
        
        val_17[5] = (GameConnect.丙丙东七丙丞专丛不 == true) ? "_squad" : (val_41);
        UnityEngine.Object val_26 = UnityEngine.Resources.Load(path:  +val_17);
        val_43 = null;
        val_43 = null;
        if(val_26 == null)
        {
            goto label_81;
        }
        
        var val_27 = (null == null) ? (val_26) : 0;
        goto label_82;
        label_39:
        this.丒上七丌业七丟与丐 = 0;
        val_33 = 1;
        this.丗丏丅丕丆世丁专丟 = val_33;
        return (bool)val_33;
        label_81:
        val_44 = 0;
        label_82:
        LoadConnectScene.上三丕下一丅丘上丝 = val_44;
        val_31 = 1152921505079742464;
        val_45 = null;
        val_45 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = LoadConnectScene.上三丕下一丅丘上丝;
        LoadConnectScene.丞丗专丝丙专丂上丗 = val_16.丙且上丒不下丑下丞();
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        val_46 = null;
        val_46 = null;
        val_35 = 与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟;
        this.丒上七丌业七丟与丐 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  val_35, 丂丛丑东不丅丈一东:  0);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_33 = 1;
        return (bool)val_33;
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
