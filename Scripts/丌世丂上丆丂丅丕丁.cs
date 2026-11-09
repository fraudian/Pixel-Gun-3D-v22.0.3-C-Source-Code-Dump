using UnityEngine;
private sealed class VideoPlayerWindow.丌世丂上丆丂丅丕丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public VideoPlayerWindow 丝且与丝丒丟万丁专;
    private float 与丘丗丑丟丌丂上丕;
    private float 丝丅丛丏丕专不丆一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VideoPlayerWindow.丌世丂上丆丂丅丕丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_30;
        VideoPlayerWindow val_39;
        var val_40;
        var val_41;
        var val_42;
        System.Collections.Generic.List<System.String> val_43;
        var val_44;
        UnityEngine.GameObject val_45;
        var val_46;
        int val_48;
        System.Collections.Generic.List<System.String> val_49;
        var val_50;
        object val_52;
        var val_53;
        var val_54;
        int val_55;
        var val_56;
        var val_57;
        val_39 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_67;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        ReplaceAdmobPerelivController val_1 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        val_1.丌东专且丑世专丐不 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.skipButton, 丏业丟一东丂东丘丛:  false);
        this.与丘丗丑丟丌丂上丕 = 1f;
        this.丝丅丛丏丕专不丆一 = 0f;
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        val_40 = null;
        val_40 = null;
        if((MainMenuController.丄丞丁丈与业上丞丟 == null) || (InfoWindowController.丑七不且上丗丁一世() == null))
        {
            goto label_21;
        }
        
        val_41 = null;
        val_41 = null;
        if((ExpView.丄丘七三上丕世丞业 == null) || (ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑() == null))
        {
            goto label_21;
        }
        
        this.丝且与丝丒丟万丁专.且丂丏一三丟且丂丟.Clear();
        val_42 = null;
        val_42 = null;
        val_43 = 1152921519068975536;
        this.丝且与丝丒丟万丁专.且丂丏一三丟且丂丟.Add(item:  gameObject);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        this.丝且与丝丒丟万丁专.且丂丏一三丟且丂丟.Add(item:  val_5.camera.gameObject);
        ConnectScene val_7 = GetComponent<ConnectScene>();
        this.丝且与丝丒丟万丁专.且丂丏一三丟且丂丟.Add(item:  val_7.Camera);
        val_44 = null;
        val_44 = null;
        val_45 = mem[ExpView.丄丘七三上丕世丞业 + 48];
        val_45 = ExpView.丄丘七三上丕世丞业.LevelUpPanelsContainer;
        this.丝且与丝丒丟万丁专.且丂丏一三丟且丂丟.Add(item:  val_45);
        if(this.丝且与丝丒丟万丁专.丂上丛东专丁不万丒.isPlaying != false)
        {
                val_46 = null;
            val_46 = null;
            if((UnityEngine.Object.op_Implicit(exists:  MainMenuController.丄丞丁丈与业上丞丟.bannerContainer)) == false)
        {
            goto label_98;
        }
        
        }
        
        if(ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑().丛丅不丈七丄丅上丒() == null)
        {
            goto label_98;
        }
        
        val_45 = val_11.videoPaths;
        var val_40 = 0;
        val_40 = val_40 + 1;
        goto label_58;
        label_21:
        val_45 = 1152921505319997440;
        val_39 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        if(val_39 != 0)
        {
                val_39 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
            val_39.世丌东丗丛丞丙丘丘(丙业与丙丗丝不丈东:  true);
        }
        
        if(this.丝丅丛丏丕专不丆一 >= this.与丘丗丑丟丌丂上丕)
        {
            goto label_67;
        }
        
        float val_15 = UnityEngine.Time.deltaTime;
        val_15 = this.丝丅丛丏丕专不丆一 + val_15;
        this.丝丅丛丏丕专不丆一 = val_15;
        UnityEngine.WaitForSeconds val_16 = null;
        val_39 = val_16;
        val_16 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_48 = 1;
        this.丒上七丌业七丟与丐 = val_39;
        this.丗丏丅丕丆世丁专丟 = val_48;
        return (bool)val_48;
        label_58:
        val_43 = val_11.redirectUrls;
        int val_42 = val_45.Count;
        int val_19 = val_43.Count;
        if(val_19 <= 0)
        {
            goto label_70;
        }
        
        int val_41 = val_42;
        val_49 = val_11.redirectUrls;
        val_43 = UnityEngine.Random.Range(min:  0, max:  val_41);
        val_50 = public System.String System.Collections.Generic.List<System.String>::get_Item(int index);
        val_41 = val_43 - ((val_43 / val_19) * val_19);
        this.丝且与丝丒丟万丁专.丈丞下下丒丘与丈丛 = val_49.Item[val_41];
        val_42 = val_43 - ((val_43 / val_42) * val_42);
        var val_43 = 0;
        val_43 = val_43 + 1;
        val_50 = 0;
        goto label_77;
        label_70:
        val_52 = "LoadVideo: fakeInterstitialConfig.redirectUrls.Count == 0";
        goto label_80;
        label_77:
        val_45 = UnityEngine.Resources.Load<UnityEngine.Video.VideoClip>(path:  val_45.Item[val_42]);
        if(val_45 == null)
        {
            goto label_81;
        }
        
        val_53 = null;
        val_53 = null;
        AdmobPerelivWindow.一一三丘丒且与丄万 = this.丝且与丝丒丟万丁专.丈丞下下丒丘与丈丛;
        val_39.Show();
        PGCompany.Analytics.一业丗丆世世上丁且.丛丛丈世丅丘丙丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "fakeInterstitial", 丟丛丑丒丆丛东下丌:  System.String.alignConst, 丗七丟丈三不丕一三:  0, 丝丟专丒丅丁丝丘丅:  0);
        List.Enumerator<T> val_28 = this.丝且与丝丒丟万丁专.且丂丏一三丟且丂丟.GetEnumerator();
        val_49 = 1152921519068956112;
        label_93:
        if((1691136400 & 1) == 0)
        {
            goto label_90;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_30.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_93;
        label_81:
        val_52 = "LoadVideo: video clip not found";
        label_80:
        UnityEngine.Debug.LogWarning(message:  val_52);
        goto label_98;
        label_90:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.redirectPanel, 丏业丟一东丂东丘丛:  true);
        val_54 = null;
        val_54 = null;
        val_43 = GetComponent<UnityEngine.Camera>();
        this.丝且与丝丒丟万丁专.丂上丛东专丁不万丒.targetCamera = val_43;
        this.丝且与丝丒丟万丁专.丂上丛东专丁不万丒.clip = val_45;
        this.丝且与丝丒丟万丁专.丂上丛东专丁不万丒.Play();
        this.丝且与丝丒丟万丁专.丂上丛东专丁不万丒.add_loopPointReached(value:  new VideoPlayer.EventHandler(object:  val_39, method:  System.Void VideoPlayerWindow::丑丌丁东丈丈丅丂三(UnityEngine.Video.VideoPlayer 丑东与丅丐丅丂丞业)));
        if((val_11.timerForSkip & 1) != 0)
        {
                val_55 = val_11.timerForSkip;
        }
        else
        {
                val_55 = this.丝且与丝丒丟万丁专.丆丁丁丘丘业七专七;
        }
        
        this.丝且与丝丒丟万丁专.丁丘丌丟丘七丁丑丟 = val_55;
        UnityEngine.Coroutine val_35 = val_39.StartCoroutine(routine:  val_39.七丒丐丁丌丑丐七丅());
        val_45 = 1152921505083416576;
        val_56 = null;
        val_56 = null;
        if(MenuBackgroundMusic.丌丂一丛下丒丞丛东.七丗东丑不一丌丞一() != false)
        {
                val_57 = null;
            val_57 = null;
            MenuBackgroundMusic.丌丂一丛下丒丞丛东.丌丄丏下七丁专丂世();
            this.丝且与丝丒丟万丁专.丐上丄丒与丝丁业丝 = true;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  false);
            this.丝且与丝丒丟万丁专.丄丏下一丙三丂丘下 = true;
        }
        
        ReplaceAdmobPerelivController val_38 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        val_38.丌东专且丑世专丐不 = true;
        label_98:
        val_39 = ReplaceAdmobPerelivController.丂丞丛丙东丗丈业丑();
        val_39.世丌东丗丛丞丙丘丘(丙业与丙丗丝不丈东:  false);
        label_67:
        val_48 = 0;
        return (bool)val_48;
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
