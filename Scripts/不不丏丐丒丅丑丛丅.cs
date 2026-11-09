using UnityEngine;
private sealed class NewLobbyLevelAnimator.不不丏丐丒丅丑丛丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NewLobbyLevelAnimator 丝且与丝丒丟万丁专;
    private int 丙不丅丌丗上丂丕一;
    private UISprite 与丁下丆丏丟丐专丗;
    private float 丌丈丘丙丕丑丄丏丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NewLobbyLevelAnimator.不不丏丐丒丅丑丛丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_46;
        int val_48;
        var val_49;
        float val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        val_46 = this;
        if(this.丗丏丅丕丆世丁专丟 > 5)
        {
            goto label_1;
        }
        
        var val_45 = 106029516 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_45 = val_45 + 106029516;
        goto (106029516 + (this.丗丏丅丕丆世丁专丟) << 2 + 106029516);
        label_62:
        label_61:
        if(this.与丁下丆丏丟丐专丗.alpha < 0)
        {
            goto label_15;
        }
        
        val_48 = 1;
        this.丝且与丝丒丟万丁专.shines.Item[this.丙不丅丌丗上丂丕一].SetActive(value:  true);
        val_51 = this.丝且与丝丒丟万丁专.timeBetweenShineAndTip;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_51);
        this.丗丏丅丕丆世丁专丟 = 3;
        return (bool)val_48;
        label_1:
        val_48 = 0;
        return (bool)val_48;
        label_15:
        float val_46 = 0.04f;
        val_46 = this.与丁下丆丏丟丐专丗.alpha + val_46;
        this.与丁下丆丏丟丐专丗.alpha = val_46;
        val_52 = null;
        val_52 = null;
        val_51 = this.丝且与丝丒丟万丁专.buttonAlphaTime;
        float val_47 = 25f;
        val_47 = val_51 / val_47;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  FriendsController.丄丞丁丈与业上丞丟.MyWaitForSeconds(七且丆丞丌丘下世丑:  val_47));
        val_53 = 2;
        goto label_39;
        label_65:
        if(val_48.Item[0] != 2)
        {
            goto label_41;
        }
        
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丕丆三下丂丌丒三丗(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1)
        {
            goto label_49;
        }
        
        goto label_58;
        label_41:
        if(val_48.Item[0] != 1)
        {
            goto label_49;
        }
        
        val_54 = null;
        val_54 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_58;
        }
        
        val_55 = null;
        val_55 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.PromoOffersPanelShouldBeShown() == false)
        {
            goto label_58;
        }
        
        label_49:
        UISprite val_23 = MainMenuController.丄丞丁丈与业上丞丟.Item[0].GetComponent<UISprite>();
        mem2[0] = val_23;
        if(val_23 != null)
        {
            goto label_61;
        }
        
        goto label_62;
        label_58:
        val_49 = (val_8 + 40) + 1;
        mem2[0] = val_49;
        if(val_49 < Count)
        {
            goto label_65;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.东不丞丗丟丞世与丛(), 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.东不丞丗丟丞世与丛(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + 1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        val_56 = "[]";
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "AppsFlyer.TutorialStepsLogged")) != false)
        {
                string val_30 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "AppsFlyer.TutorialStepsLogged");
        }
        
        int val_34 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.东不丞丗丟丞世与丛(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        object val_35 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  ((System.String.IsNullOrEmpty(value:  val_30)) != true) ? "[]" : (val_30));
        System.Collections.Generic.List<System.Int32> val_36 = new System.Collections.Generic.List<System.Int32>(capacity:  2);
        if((null.Contains(item:  val_34)) != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.String> val_38 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            null.Add(key:  "step", value:  val_34.ToString());
            Rilisoft.丝丄三业丙专丛与不.且上万专丐三业上丙(丝丏业丅丈东业丝丒:  "af_gui_tutorial_completion", 丛东不丒丏丈丄且丕:  null);
            null.Add(item:  val_34);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "AppsFlyer.TutorialStepsLogged", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  null));
        }
        
        mem2[0] = 0;
        val_53 = 5;
        label_39:
        mem2[0] = 5;
        val_48 = 1;
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
