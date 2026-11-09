using UnityEngine;
private sealed class ConnectScene.世东丐与且下下丟丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ConnectScene 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectScene.世东丐与且下下丟丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ConnectScene val_27;
        var val_28;
        object val_29;
        var val_30;
        int val_31;
        val_27 = this;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27 = this.丝且与丝丒丟万丁专;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_2 = new object[2];
            val_2[0] = "ConnectScene.LoadThenShowInterstitialCoroutine";
            val_2[1] = UnityEngine.Time.realtimeSinceStartup;
            UnityEngine.Debug.LogFormat(format:  "[{0}] realtimeSinceStartup: {1}", args:  val_2);
        }
        
        val_28 = static_value_081DACA8;
        val_28 = static_value_081DACA8;
        PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().不业不丘丌丑丒丐丐();
        if(PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丄丌世丌东丆丛丏丛() == false)
        {
            goto label_19;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_22;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return false;
        }
        
        val_29 = "[ConnectScene.LoadThenShowInterstitialCoroutine] Canceled. GuiActive: True";
        goto label_67;
        label_19:
        val_29 = "[ConnectScene.LoadThenShowInterstitialCoroutine] Canceled. IsInterstitialReady: False";
        label_67:
        label_56:
        UnityEngine.Debug.Log(message:  val_29);
        return false;
        label_22:
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
            goto label_45;
        }
        
        BannerWindowController val_12 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_12.viewedBannersCountInConnectScene == 0)
        {
            goto label_45;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return false;
        }
        
        BannerWindowController val_14 = BannerWindowController.与丅与丒丅专丙丐丗();
        string val_17 = "[ConnectScene.LoadThenShowInterstitialCoroutine] Canceled. viewedBannersCountInConnectScene: "("[ConnectScene.LoadThenShowInterstitialCoroutine] Canceled. viewedBannersCountInConnectScene: ") + val_14.viewedBannersCountInConnectScene.ToString(provider:  ConnectScene.丙专丝世不业下丂丈())(val_14.viewedBannersCountInConnectScene.ToString(provider:  ConnectScene.丙专丝世不业下丂丈()));
        goto label_56;
        label_45:
        if(Initializer.丑七不且上丗丁一世() == 0)
        {
            goto label_61;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return false;
        }
        
        goto label_67;
        label_61:
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                val_30 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_30 != null)
        {
                val_31 = val_23.viewedBannersCountInConnectScene;
        }
        else
        {
                val_30 = 92;
            val_31 = 0;
        }
        
            mem[92] = 1;
        }
        
        PGCompany.七丑一上且三世丝三<K, V> val_24 = PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不();
        val_24.set_Item(key:  "af_content_type", value:  "Interstitial");
        val_24.set_Item(key:  "af_content_id", value:  "Interstitial (ConnectScene)");
        Rilisoft.丝丄三业丙专丛与不.且上万专丐三业上丙(丝丏业丅丈东业丝丒:  "af_content_view_admob", 丛东不丒丏丈丄且丕:  val_24);
        PGCompany.七丑一上且三世丝三<K, V> val_25 = PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不();
        val_27.下与丞三丅丛丄七丕(三七一丁上且丐丝丌:  "DefaultInterstitial");
        this.丝且与丝丒丟万丁专.丂与丛上不丑东丒丘 = UnityEngine.Time.realtimeSinceStartup;
        return false;
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
