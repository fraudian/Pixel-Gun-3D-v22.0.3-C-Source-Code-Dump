using UnityEngine;
private sealed class AppsMenu.丐丘丝丕丙丟专丝丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AppsMenu 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AppsMenu.丐丘丝丕丙丟专丝丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        AppsMenu val_33;
        int val_34;
        string val_35;
        var val_36;
        System.Action<System.String> val_38;
        System.Collections.IEnumerator val_39;
        val_33 = this.丝且与丝丒丟万丁专;
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
            goto label_74;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        0.丏东丅一丏东丆丌且();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start AppsMenu");
        val_34 = 1;
        this.丝且与丝丒丟万丁专.丛丐专丂丒丌丌丒丛 = false;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_34;
        return (bool)val_34;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start one frame");
        if((UnityEngine.Application.platform != 11) || (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2))
        {
            goto label_52;
        }
        
        val_35 = 1152921505034694656;
        val_36 = null;
        val_36 = null;
        val_38 = AppsMenu.<>c.<>9__38_0;
        if(val_38 == null)
        {
                System.Action<System.String> val_3 = null;
            val_38 = val_3;
            val_3 = new System.Action<System.String>(object:  AppsMenu.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AppsMenu.<>c::丙东丕丘丁丞丁丈丐(string 专万丟三世业丙丈且));
            AppsMenu.<>c.<>9__38_0 = val_38;
        }
        
        东丝丕上不一下丄万 val_4 = 丅丘万丛丙丂丟与丗.专七丘丙且丝下丆丅();
        if((val_4.<丛丈丐且丄丆丆丕丞>k__BackingField) == 0)
        {
                UnityEngine.Debug.Log(message:  "actualPackageInfo.SignatureHash == null");
            val_35 = AppsMenu.丟丌丂丝丆丆专七丑(丁丁万丟丙丕一丘下:  225);
            val_3.Invoke(obj:  val_35);
        }
        
        if(0 == 1)
        {
            goto label_26;
        }
        
        if((0 == 0) || (241 == 241))
        {
            goto label_78;
        }
        
        label_77:
        label_78:
        string val_6 = val_4.<丛丈丐且丄丆丆丕丞>k__BackingField.丐丏七丌丕丗业且上();
        if((System.String.Compare(strA:  val_6, strB:  与丂丏丛丞丞丒丟丄.丂专丈丕丕与丘丝与(), comparisonType:  4)) == 0)
        {
            goto label_31;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Verification FakeBundleDetected:    "("Verification FakeBundleDetected:    ") + val_6);
        val_3.Invoke(obj:  AppsMenu.丟丌丂丝丆丆专七丑(丁丁万丟丙丕一丘下:  225));
        if(val_33 != null)
        {
            goto label_81;
        }
        
        label_82:
        label_81:
        if((System.String.IsNullOrEmpty(value:  this.丝且与丝丒丟万丁专.intendedSignatureHash)) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "String.IsNullOrEmpty(intendedSignatureHash)");
            val_3.Invoke(obj:  AppsMenu.丟丌丂丝丆丆专七丑(丁丁万丟丙丕一丘下:  225));
        }
        
        if((System.String.Compare(strA:  val_4.<丛丈丐且丄丆丆丕丞>k__BackingField, strB:  this.丝且与丝丒丟万丁专.intendedSignatureHash, comparisonType:  4)) == 0)
        {
            goto label_44;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Verification FakeSignatureDetected:    "("Verification FakeSignatureDetected:    ") + val_4.<丛丈丐且丄丆丆丕丞>k__BackingField(val_4.<丛丈丐且丄丆丆丕丞>k__BackingField));
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "gfts", 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) | 64, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        val_3.Invoke(obj:  AppsMenu.丟丌丂丝丆丆专七丑(丁丁万丟丙丕一丘下:  225));
        goto label_52;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Debug.Log(message:  "[A_ppsM_enu] S_tart => Finished coroutine W_aitForObbResolved");
        Rilisoft.Singleton<KillrateController>.Instance.上丛丌丆丑上七世三();
        PlayerLikeController.丙丌专东丌丏东丗丕();
        AppsMenu.丈丏丆丂万丏与丒万();
        0.上丛丅丙一专三东丛();
        东丗上丁下业一丂丂.丆丒一专且业七丟丈 = 东丗上丁下业一丂丂.业丟丗万下三丄一专();
        val_39 = 1152921505207164928;
        UnityEngine.Application.targetFrameRate = (丟丌丁且且世丈丈丟.丆丛丏丛丟丁丁万三() != true) ? 60 : 30;
        float val_33 = (float)UnityEngine.Screen.width;
        val_33 = val_33 / (float)UnityEngine.Screen.height;
        if(val_33 > 2.333333f)
        {
                float val_34 = (float)UnityEngine.Screen.height;
            val_34 = val_34 * 21f;
            val_34 = val_34 / 9f;
            UnityEngine.Screen.SetResolution(width:  UnityEngine.Mathf.RoundToInt(f:  val_34), height:  UnityEngine.Mathf.RoundToInt(f:  (float)UnityEngine.Screen.height), fullscreen:  false);
        }
        
        丟丌丁且且世丈丈丟.丞丄丗丟丂丆万上七(丙业与丙丗丝不丈东:  0);
        if(this.丝且与丝丒丟万丁专.丛丐专丂丒丌丌丒丛 != false)
        {
                VersionBlocker.东丄丒丏且丘世一丟();
        }
        else
        {
                val_33 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance;
            val_33.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "Loading");
        }
        
        label_74:
        val_34 = 0;
        return (bool)val_34;
        label_26:
        if(0 != 0)
        {
            goto label_77;
        }
        
        goto label_78;
        label_31:
        UnityEngine.Debug.Log(message:  "Package check passed.");
        if(val_33 != null)
        {
            goto label_81;
        }
        
        goto label_82;
        label_44:
        UnityEngine.Debug.Log(message:  "Signature check passed.");
        label_52:
        UnityEngine.Debug.Log(message:  "[A_ppsM_enu] S_tart => Starting coroutine W_aitForObbResolved...");
        if(val_33 != null)
        {
                val_39 = val_33.丒丅丂三丞丒丕七丌();
        }
        else
        {
                val_39 = 0.丒丅丂三丞丒丕七丌();
        }
        
        this.丒上七丌业七丟与丐 = val_33.StartCoroutine(routine:  val_39);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_34 = 1;
        return (bool)val_34;
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
