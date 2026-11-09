using UnityEngine;
private sealed class NetworkStartTableNGUIController.东丑三丄与丄丏丌丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.东丑三丄与丄丏丌丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        NetworkStartTableNGUIController val_49;
        int val_50;
        var val_51;
        var val_52;
        bool val_53;
        bool val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        System.Collections.IEnumerator val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_117;
        }
        
        val_49 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(ProgressRoadView.IsActive != false)
        {
                val_50 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_50;
            return (bool)val_50;
        }
        
        UnityEngine.AsyncOperation val_2 = UnityEngine.Resources.UnloadUnusedAssets();
        if(val_49 != null)
        {
                val_49.三与丁丞丂丗丅丆丁(丝三丄专丗丞丄丄丌:  true, 下丈下七一万丆丁丕:  0);
        }
        else
        {
                0.三与丁丞丂丗丅丆丁(丝三丄专丗丞丄丄丌:  true, 下丈下七一万丆丁丕:  0);
        }
        
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetTrigger(name:  "RewardTaken");
        if(this.丝且与丝丒丟万丁专.下丄三丒丟丄丂丑世 != true)
        {
                if(val_49.一丈丛丘与丕丛丝东() == false)
        {
            goto label_117;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丙丏丏丛丁与丘三丝 = 0;
        this.丝且与丝丒丟万丁专.下丄三丒丟丄丂丑世 = false;
        this.丝且与丝丒丟万丁专.上丏丙东丁不丕丁丟 = false;
        if((GameConnect.丑丌丛丈丅丅与不业() != 17) && (GameConnect.丑丌丛丈丅丅与不业() != 16))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 8)
        {
                this.丝且与丝丒丟万丁专.三与万丝丒一丏丝七 = false;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丌一丏丘丞东与上世 = false;
        val_51 = null;
        val_51 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_52 = null;
            val_52 = null;
            if(GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 != true)
        {
                if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_53 = 0;
        }
        else
        {
                val_53 = (~GameConnect.东丒七专丂世丝丏丗()) & 1;
        }
        
            val_49.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  val_53, 丅丆东丏丙丝丅丆丟:  this.丝且与丝丒丟万丁专.MapSelectPanel, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  this.丝且与丝丒丟万丁专.下丂丐上东上丑上东);
            if((this.丝且与丝丒丟万丁专.specialRewardProgress != 0) && (this.丝且与丝丒丟万丁专.specialRewardProgress.一丑丄且丆与不丒丝() != null))
        {
                if(this.丝且与丝丒丟万丁专.specialRewardProgress.丞丂业丄丞与专丛丒() != null)
        {
                val_54 = this.丝且与丝丒丟万丁专.MapSelectPanel.activeSelf;
            this.丝且与丝丒丟万丁专.specialRewardProgress.下与丞三丅丛丄七丕(东丅丞丁丗万且丁丗:  val_54);
        }
        
        }
        
        }
        
        }
        
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_42;
        }
        
        this.丝且与丝丒丟万丁专.duelUI.丂世丈丅丟且丆丑丝();
        goto label_176;
        label_42:
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_47;
        }
        
        if((TeamDuelController.丅丌丛丏丞上万丛丕 + 160) == 0)
        {
            goto label_176;
        }
        
        this.丝且与丝丒丟万丁专.teamDuelUI.丂世丈丅丟且丆丑丝();
        val_55 = null;
        val_55 = null;
        this.丝且与丝丒丟万丁专.ranksTable.丟丛万丗丙丁且不不();
        goto label_57;
        label_47:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_60;
        }
        
        this.丝且与丝丒丟万丁专.siegeEndInterfacePanel.SetActive(value:  true);
        val_56 = 1152921505295769600;
        val_57 = 0;
        goto label_62;
        label_69:
        val_58 = null;
        val_58 = null;
        val_54 = mem[SiegeController.三三万丆下一丗万丛 + 264];
        val_54 = SiegeController.三三万丆下一丗万丛 + 264;
        this.丝且与丝丒丟万丁专.siegeEndWinnerLabel[0].text = val_54;
        val_57 = 1;
        label_62:
        if(val_57 < this.丝且与丝丒丟万丁专.siegeEndWinnerLabel.Length)
        {
            goto label_69;
        }
        
        goto label_70;
        label_60:
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_73;
        }
        
        this.丝且与丝丒丟万丁专.dungeonsEndInterfacePanel.SetActive(value:  true);
        val_56 = 1152921505058603008;
        val_57 = 0;
        goto label_75;
        label_84:
        val_59 = null;
        val_59 = null;
        val_54 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (DungeonsController.丄丘七三上丕世丞业.丕丈业丟丆七上专丟 == true) ? "Key_7105" : "Key_7129");
        this.丝且与丝丒丟万丁专.dungeonEndWinnerLabel[0].text = val_54;
        val_57 = 1;
        label_75:
        if(val_57 < this.丝且与丝丒丟万丁专.dungeonEndWinnerLabel.Length)
        {
            goto label_84;
        }
        
        label_70:
        val_60 = null;
        val_60 = null;
        this.丝且与丝丒丟万丁专.ranksTable.丟丛万丗丙丁且不不();
        if(val_49 == null)
        {
            goto label_92;
        }
        
        label_57:
        this.丝且与丝丒丟万丁专.丁丘丟万丙万且丆专 = false;
        goto label_93;
        label_92:
        mem[353] = 0;
        label_93:
        val_49.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  false);
        label_176:
        val_61 = null;
        val_61 = null;
        if(((GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false) && (GameConnect.一与东丝万上三丆丏() != true)) && (GameConnect.业丛丛丂一丆丕丗丟() != true))
        {
                this.丝且与丝丒丟万丁专.backButtonInHunger.SetActive(value:  false);
            if(this.丝且与丝丒丟万丁专.CompetitionContinueButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.CompetitionContinueButton.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        val_62 = null;
        val_62 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable == 0)
        {
                if(val_49 != null)
        {
                val_63 = val_49.丑专东专世丁与上丙();
        }
        else
        {
                val_63 = 0.丑专东专世丁与上丙();
        }
        
            UnityEngine.Coroutine val_28 = val_49.StartCoroutine(routine:  val_63);
        }
        
        label_117:
        val_50 = 0;
        return (bool)val_50;
        label_73:
        if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
            goto label_122;
        }
        
        this.丝且与丝丒丟万丁专.backButtonInHunger.SetActive(value:  true);
        val_64 = null;
        val_64 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_133;
        }
        
        }
        
        }
        
        label_180:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.randomBtn, 丏业丟一东丂东丘丛:  (0 != 0) ? 1 : 0);
        goto label_176;
        label_122:
        if(val_49.一丈丛丘与丕丛丝东() == false)
        {
            goto label_137;
        }
        
        this.丝且与丝丒丟万丁专.backButtonInHunger.SetActive(value:  true);
        val_65 = null;
        val_65 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_148;
        }
        
        }
        
        }
        
        label_184:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.randomBtn, 丏业丟一东丂东丘丛:  (0 != 0) ? 1 : 0);
        if((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.一业上七丟业且业丙() != true))
        {
                if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_176;
        }
        
        }
        
        }
        
        val_66 = null;
        val_66 = null;
        this.丝且与丝丒丟万丁专.spectatorModeBtnPnl.SetActive(value:  丞下丗丞一业丏上不());
        goto label_176;
        label_137:
        this.丝且与丝丒丟万丁专.finishedInterface.SetActive(value:  false);
        val_49.丐丅丑丞丆丝上丈丝();
        if(val_49.丘业丞丗上且一丏下() != true)
        {
                if(this.丝且与丝丒丟万丁专.丞丗丆万丆丗丘丕丙 != null)
        {
                val_49.StopCoroutine(routine:  this.丝且与丝丒丟万丁专.丞丗丆万丆丗丘丕丙);
        }
        
            this.丝且与丝丒丟万丁专.丞丗丆万丆丗丘丕丙 = val_49.StartCoroutine(routine:  val_49.且丄丄专东下丈丈七());
        }
        
        val_67 = null;
        val_67 = null;
        东世不一丒丁一丈东();
        goto label_176;
        label_133:
        val_68 = null;
        val_68 = null;
        bool val_50 = GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七;
        val_50 = val_50 ^ 1;
        bool val_46 = val_50 & 255;
        goto label_180;
        label_148:
        val_69 = null;
        val_69 = null;
        bool val_51 = GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七;
        val_51 = val_51 ^ 1;
        bool val_47 = val_51 & 255;
        goto label_184;
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
