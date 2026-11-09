using UnityEngine;
private sealed class LevelCompleteScript.丄丒业丝丁上丌业业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LevelCompleteScript 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCompleteScript.丄丒业丝丁上丌业业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_39;
        object val_54;
        var val_78;
        FriendsController val_79;
        var val_80;
        var val_81;
        int val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        System.Action val_89;
        var val_90;
        var val_91;
        var val_92;
        System.Action val_94;
        var val_95;
        System.Func<System.String> val_97;
        var val_98;
        var val_99;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        var val_104;
        System.Func<System.String> val_106;
        var val_107;
        var val_108;
        var val_109;
        var val_110;
        var val_111;
        var val_112;
        var val_113;
        var val_114;
        var val_115;
        var val_116;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_78 = null;
        val_78 = null;
        val_79 = FriendsController.丄丞丁丈与业上丞丟;
        if(val_79 == 0)
        {
            goto label_6;
        }
        
        val_80 = null;
        val_80 = null;
        val_79 = TempItemsController.丄丞丁丈与业上丞丟;
        if(val_79 != 0)
        {
            goto label_342;
        }
        
        label_6:
        val_81 = 0;
        val_82 = 1;
        goto label_12;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_16;
        }
        
        label_342:
        val_83 = null;
        val_83 = null;
        val_79 = FriendsController.丄丞丁丈与业上丞丟.MyWaitForSeconds(七且丆丞丌丘下世丑:  1f);
        val_82 = 2;
        label_12:
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_79);
        val_84 = 1;
        this.丗丏丅丕丆世丁专丟 = val_82;
        return (bool)val_84;
        label_13:
        val_84 = 0;
        return (bool)val_84;
        label_16:
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
            goto label_342;
        }
        
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且() == true)
        {
            goto label_342;
        }
        
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
            goto label_342;
        }
        
        }
        
        if(((this.丝且与丝丒丟万丁专.loadingPanel.activeInHierarchy == true) || (ExchangeWindow.与丌上丄丌丐丟丟丈() == true)) || (this.丝且与丝丒丟万丁专.RentWindowPoint.childCount != 0))
        {
            goto label_342;
        }
        
        if(this.丝且与丝丒丟万丁专.丞丑丞丘丐丛三丄下 != false)
        {
                if(this.丝且与丝丒丟万丁专.下不世丙丌丐丄丞丛 <= 1)
        {
            goto label_56;
        }
        
        }
        
        if((this.丝且与丝丒丟万丁专.丏业一丙且丑丝丙丅 == false) || (this.丝且与丝丒丟万丁专.下不世丙丌丐丄丞丛 > 1))
        {
            goto label_342;
        }
        
        this.丝且与丝丒丟万丁专.丏业一丙且丑丝丙丅 = false;
        val_85 = null;
        val_85 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  "AllSecretsForBoxRewardWindowIsShown_" + 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, value:  1);
        if(FacebookController.且丈丄一丁丞丒丑东() != true)
        {
                if(TwitterController.上业丗丛三丕丒丗丙() == false)
        {
            goto label_342;
        }
        
        }
        
        val_86 = null;
        val_86 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
        {
            goto label_342;
        }
        
        UnityEngine.GameObject val_25 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/AllSecretsNGUI"));
        RewardWindowBase val_26 = val_25.GetComponent<RewardWindowBase>();
        val_26.丟丁丑丆丅一丙丂丂(丙业与丙丗丝不丈东:  0);
        val_87 = null;
        val_87 = null;
        val_89 = LevelCompleteScript.<>c.<>9__110_2;
        if(val_89 == null)
        {
                val_89 = new System.Action();
            val_89 = new System.Action(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelCompleteScript.<>c::一丒丝丄业丛丄丘不());
            LevelCompleteScript.<>c.<>9__110_2 = val_89;
        }
        
        if(val_26 == null)
        {
            goto label_79;
        }
        
        val_26.shareAction = val_89;
        goto label_80;
        label_56:
        this.丝且与丝丒丟万丁专.丞丑丞丘丐丛三丄下 = false;
        val_90 = null;
        val_90 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  "AllStarsForBoxRewardWindowIsShown_" + 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, value:  1);
        if(FacebookController.且丈丄一丁丞丒丑东() != true)
        {
                if(TwitterController.上业丗丛三丕丒丗丙() == false)
        {
            goto label_342;
        }
        
        }
        
        val_91 = null;
        val_91 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
        {
            goto label_342;
        }
        
        UnityEngine.GameObject val_32 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/AllStarsNGUI"));
        RewardWindowBase val_33 = val_32.GetComponent<RewardWindowBase>();
        val_33.丟丁丑丆丅一丙丂丂(丙业与丙丗丝不丈东:  0);
        val_92 = null;
        val_92 = null;
        val_94 = LevelCompleteScript.<>c.<>9__110_0;
        if(val_94 == null)
        {
                val_94 = new System.Action();
            val_94 = new System.Action(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelCompleteScript.<>c::万下丑丟丆上丒丆七());
            LevelCompleteScript.<>c.<>9__110_0 = val_94;
        }
        
        if(val_33 != null)
        {
                val_33.shareAction = val_94;
        }
        else
        {
                mem[280] = val_94;
        }
        
        val_33.HasReward = false;
        val_95 = null;
        val_95 = null;
        val_97 = LevelCompleteScript.<>c.<>9__110_1;
        if(val_97 == null)
        {
                val_97 = null;
            val_97 = new System.Func<System.String>(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.String LevelCompleteScript.<>c::丐丟七丁七丕丄丅丟());
            LevelCompleteScript.<>c.<>9__110_1 = val_97;
        }
        
        val_33.twitterStatus = null;
        val_33.EventTitle = "All Stars";
        AllStarsRewardSettings val_36 = val_32.GetComponent<AllStarsRewardSettings>();
        List.Enumerator<T> val_37 = val_36.headerLabels.GetEnumerator();
        label_146:
        if(((-213421200) & 1) == 0)
        {
            goto label_113;
        }
        
        string val_40 = val_39.丐丏七丌丕丗业且上();
        val_98 = null;
        val_98 = null;
        val_99 = null;
        val_99 = null;
        下与业丆下三丅丅丝 val_41 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  val_41.丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_120;
        }
        
        val_40.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1543");
        goto label_146;
        label_120:
        val_100 = null;
        val_100 = null;
        val_101 = null;
        val_101 = null;
        下与业丆下三丅丅丝 val_44 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[1];
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  val_44.丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_131;
        }
        
        val_40.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1544");
        goto label_146;
        label_131:
        val_102 = null;
        val_102 = null;
        val_103 = null;
        val_103 = null;
        下与业丆下三丅丅丝 val_47 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[2];
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  val_47.丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_146;
        }
        
        val_40.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1545");
        goto label_146;
        label_79:
        mem[280] = val_89;
        label_80:
        val_26.HasReward = false;
        val_104 = null;
        val_104 = null;
        val_106 = LevelCompleteScript.<>c.<>9__110_3;
        if(val_106 == null)
        {
                val_106 = null;
            val_106 = new System.Func<System.String>(object:  LevelCompleteScript.<>c.__il2cppRuntimeField_static_fields, method:  System.String LevelCompleteScript.<>c::世丝丏业七不丞丛一());
            LevelCompleteScript.<>c.<>9__110_3 = val_106;
        }
        
        val_26.twitterStatus = null;
        val_26.EventTitle = "All Coins";
        AllSecretsRewardSettings val_51 = val_25.GetComponent<AllSecretsRewardSettings>();
        List.Enumerator<T> val_52 = val_51.headerLabels.GetEnumerator();
        label_190:
        if(((-213421200) & 1) == 0)
        {
            goto label_157;
        }
        
        string val_55 = val_54.丐丏七丌丕丗业且上();
        val_107 = null;
        val_107 = null;
        val_108 = null;
        val_108 = null;
        下与业丆下三丅丅丝 val_56 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  val_56.丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_164;
        }
        
        val_55.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1540");
        goto label_190;
        label_164:
        val_109 = null;
        val_109 = null;
        val_110 = null;
        val_110 = null;
        下与业丆下三丅丅丝 val_59 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[1];
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  val_59.丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_175;
        }
        
        val_55.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1541");
        goto label_190;
        label_175:
        val_111 = null;
        val_111 = null;
        val_112 = null;
        val_112 = null;
        下与业丆下三丅丅丝 val_62 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[2];
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, b:  val_62.丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_190;
        }
        
        val_55.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1542");
        goto label_190;
        label_113:
        val_113 = 0;
        val_114 = 0;
        goto label_191;
        label_157:
        val_115 = 0;
        val_116 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_273;
        }
        
        if( == 0)
        {
            goto label_277;
        }
        
        if(1177 != 1177)
        {
            goto label_275;
        }
        
        goto label_277;
        label_273:
        if( == 0)
        {
            goto label_277;
        }
        
        label_275:
        label_277:
        val_25.transform.parent = this.丝且与丝丒丟万丁专.RentWindowPoint;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_25, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Default"));
        val_39 = 0;
        val_25.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_69 = UnityEngine.Quaternion.identity;
        val_25.transform.localRotation = new UnityEngine.Quaternion() {x = val_69.x, y = val_69.y, z = val_69.z, w = val_69.w};
        val_54 = 0;
        val_25.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_342;
        label_191:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_306;
        }
        
        if( == 0)
        {
            goto label_310;
        }
        
        if(1177 != 657)
        {
            goto label_308;
        }
        
        goto label_310;
        label_306:
        if( == 0)
        {
            goto label_310;
        }
        
        label_308:
        label_310:
        val_25.transform.parent = this.丝且与丝丒丟万丁专.RentWindowPoint;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_25, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Default"));
        val_39 = 0;
        val_25.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_75 = UnityEngine.Quaternion.identity;
        val_25.transform.localRotation = new UnityEngine.Quaternion() {x = val_75.x, y = val_75.y, z = val_75.z, w = val_75.w};
        val_54 = 0;
        val_25.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_342;
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
