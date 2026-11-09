using UnityEngine;
public class 丆丟且不丟丗丙丏业 : 丕丛下丞不丕丏丒万
{
    // Fields
    private static UnityEngine.AndroidJavaObject 丁丏丕丗丐丌丒丕丝;
    private static readonly string 丗上且丈万丘七丝东;
    private const string 丝七丕丐丘丂丅万不 = "reward_amount";
    private const string 与丈丐丆下丕丙专七 = "reward_name";
    private const string 丏丌七丆丆东丒专丄 = "placement_name";
    
    // Methods
    public 丆丟且不丟丗丙丏业()
    {
        UnityEngine.Debug.Log(message:  "AndroidAgent ctr");
    }
    public UnityEngine.AndroidJavaObject 丞丏不丌丗一丙丕丅()
    {
        var val_5;
        var val_6;
        var val_8;
        var val_10;
        val_6 = null;
        val_6 = null;
        if(丆丟且不丟丗丙丏业.丏丌七丆丆东丒专丄 == null)
        {
                UnityEngine.AndroidJavaClass val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  丆丟且不丟丗丙丏业.丗上且丈万丘七丝东);
            val_8 = null;
            val_8 = null;
            丆丟且不丟丗丙丏业.丏丌七丆丆东丒专丄 = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
            if(val_5 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            val_1.Dispose();
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        return (UnityEngine.AndroidJavaObject)丆丟且不丟丗丙丏业.丏丌七丆丆东丒专丄;
    }
    public void 丁丝东丂丁东一下丅(bool 丁与丟万丄丒丗专丌)
    {
        string val_3;
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(丁与丟万丄丒丗专丌 == false)
        {
            goto label_2;
        }
        
        label_4:
        val_3 = "onPause";
        goto label_3;
        label_1:
        if(丁与丟万丄丒丗专丌 == true)
        {
            goto label_4;
        }
        
        label_2:
        val_3 = "onResume";
        label_3:
        val_1.Call(methodName:  val_3, args:  System.Array.Empty<System.Object>());
    }
    public void 丈七丘丂丗丁丆下丈(string 丏丒丐七七丂丂丙丅)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丏丒丐七七丂丂丙丅 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丏丒丐七七丂丂丙丅 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丏丒丐七七丂丂丙丅;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setMediationSegment", args:  val_2);
    }
    public string 东丞丌且世下东丟丘()
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        if(val_1 != null)
        {
                return val_1.Call<System.String>(methodName:  "getAdvertiserId", args:  System.Array.Empty<System.Object>());
        }
        
        return val_1.Call<System.String>(methodName:  "getAdvertiserId", args:  System.Array.Empty<System.Object>());
    }
    public void 万丟丄东丛丘七与丐()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "validateIntegration", args:  System.Array.Empty<System.Object>());
    }
    public void 丒丁万不丂丙丛不丁(bool 丂业丐东丑丅丏丐与)
    {
        bool val_1 = 丂业丐东丑丅丏丐与;
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "shouldTrackNetworkState", args:  val_3);
    }
    public bool 与上丛上丟不与丌丌(string 丁业专业专一专丑丟)
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丁业专业专一专丑丟 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丁业专业专一专丑丟 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丁业专业专一专丑丟;
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "setDynamicUserId", args:  val_2);
        }
        
        return val_1.Call<System.Boolean>(methodName:  "setDynamicUserId", args:  val_2);
    }
    public void 丐丁丅丝业丛丝丌业(bool 丝三丄专丗丞丄丄丌)
    {
        bool val_1 = 丝三丄专丗丞丄丄丌;
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setAdaptersDebug", args:  val_3);
    }
    public void 丆丙丘不丒丅丄丕丂(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
    {
        object[] val_2 = new object[2];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(下上丐丆丝丟丝丒不 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(下上丐丆丝丟丝丒不 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 下上丐丆丝丟丝丒不;
        val_2[1] = 丙业与丙丗丝不丈东;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setMetaData", args:  val_2);
    }
    public void 丆丙丘不丒丅丄丕丂(string 下上丐丆丝丟丝丒不, string[] 与上丐专丞与丗丕丐)
    {
        object[] val_2 = new object[2];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(下上丐丆丝丟丝丒不 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(下上丐丆丝丟丝丒不 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 下上丐丆丝丟丝丒不;
        val_2[1] = 与上丐专丞与丗丕丐;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setMetaData", args:  val_2);
    }
    public System.Nullable<int> 丙丏丙万专下丒万丐()
    {
        UnityEngine.Debug.Log(message:  "Unsupported Platform");
        return 0;
    }
    public void 与丟丐丈一丐专上七(string 万丄丅丝三丈丆世丟)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(万丄丅丝三丈丆世丟 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(万丄丅丝三丈丆世丟 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 万丄丅丝三丈丆世丟;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setUserId", args:  val_2);
    }
    public void 七东丐丟世丕丏丞且(string 万下丈世丏业丛丕不)
    {
        object[] val_2 = new object[3];
        val_2[0] = "Unity";
        val_2[1] = 丐上丐丐丆万丈丑万.丆丐丑上专且不丁下();
        val_2[2] = 丐上丐丐丆万丈丑万.丅丅丈丝丏丈丞丌丄();
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setPluginData", args:  val_2);
        string val_6 = "IntegrationHelper pluginVersion: "("IntegrationHelper pluginVersion: ") + 丐上丐丐丆万丈丑万.丆丐丑上专且不丁下();
        UnityEngine.Debug.Log(message:  val_6);
        object[] val_8 = new object[1];
        if(val_8 == null)
        {
            goto label_14;
        }
        
        if(万下丈世丏业丛丕不 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(万下丈世丏业丛丕不 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        val_8[0] = 万下丈世丏业丛丕不;
        val_6.丞丏不丌丗一丙丕丅().Call(methodName:  "init", args:  val_8);
    }
    public void 七东丐丟世丕丏丞且(string 万下丈世丏业丛丕不, string[] 丞不丅丗万东丞东丆)
    {
        object[] val_2 = new object[3];
        val_2[0] = "Unity";
        val_2[1] = 丐上丐丐丆万丈丑万.丆丐丑上专且不丁下();
        val_2[2] = 丐上丐丐丆万丈丑万.丅丅丈丝丏丈丞丌丄();
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setPluginData", args:  val_2);
        string val_6 = "IntegrationHelper pluginVersion: "("IntegrationHelper pluginVersion: ") + 丐上丐丐丆万丈丑万.丆丐丑上专且不丁下();
        UnityEngine.Debug.Log(message:  val_6);
        object[] val_8 = new object[2];
        if(val_8 == null)
        {
            goto label_14;
        }
        
        if(万下丈世丏业丛丕不 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(万下丈世丏业丛丕不 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        val_8[0] = 万下丈世丏业丛丕不;
        val_8[1] = 丞不丅丗万东丞东丆;
        val_6.丞丏不丌丗一丙丕丅().Call(methodName:  "init", args:  val_8);
    }
    public void 丟丘丐丑丐世与与一(string 万下丈世丏业丛丕不, string[] 丞不丅丗万东丞东丆)
    {
        object[] val_2 = new object[3];
        val_2[0] = "Unity";
        val_2[1] = 丐上丐丐丆万丈丑万.丆丐丑上专且不丁下();
        val_2[2] = 丐上丐丐丆万丈丑万.丅丅丈丝丏丈丞丌丄();
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setPluginData", args:  val_2);
        string val_6 = "IntegrationHelper pluginVersion: "("IntegrationHelper pluginVersion: ") + 丐上丐丐丆万丈丑万.丆丐丑上专且不丁下();
        UnityEngine.Debug.Log(message:  val_6);
        object[] val_8 = new object[2];
        if(val_8 == null)
        {
            goto label_14;
        }
        
        if(万下丈世丏业丛丕不 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(万下丈世丏业丛丕不 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        val_8[0] = 万下丈世丏业丛丕不;
        val_8[1] = 丞不丅丗万东丞东丆;
        val_6.丞丏不丌丗一丙丕丅().Call(methodName:  "initISDemandOnly", args:  val_8);
    }
    public void 丏万丒一丄丆丒丐丑()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "showRewardedVideo", args:  System.Array.Empty<System.Object>());
    }
    public void 丏万丒一丄丆丒丐丑(string 三七一丁上且丐丝丌)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(三七一丁上且丐丝丌 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(三七一丁上且丐丝丌 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 三七一丁上且丐丝丌;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "showRewardedVideo", args:  val_2);
    }
    public bool 丏世丏万不丟丘不丈()
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "isRewardedVideoAvailable", args:  System.Array.Empty<System.Object>());
        }
        
        return val_1.Call<System.Boolean>(methodName:  "isRewardedVideoAvailable", args:  System.Array.Empty<System.Object>());
    }
    public bool 丕与丙上丘且不丈与(string 三七一丁上且丐丝丌)
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(三七一丁上且丐丝丌 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(三七一丁上且丐丝丌 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 三七一丁上且丐丝丌;
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "isRewardedVideoPlacementCapped", args:  val_2);
        }
        
        return val_1.Call<System.Boolean>(methodName:  "isRewardedVideoPlacementCapped", args:  val_2);
    }
    public 业世丒下丁东丂丏七 丕丏丛丆丌一丐专丁(string 三七一丁上且丐丝丌)
    {
        System.Object[] val_10;
        var val_11;
        object[] val_2 = new object[1];
        val_10 = val_2;
        if(val_10 == null)
        {
            goto label_1;
        }
        
        if(三七一丁上且丐丝丌 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(三七一丁上且丐丝丌 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_10[0] = 三七一丁上且丐丝丌;
        string val_3 = this.丞丏不丌丗一丙丕丅().Call<System.String>(methodName:  "getPlacementInfo", args:  val_2);
        if(val_3 != null)
        {
                object val_4 = IronSourceJSON.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_3);
            val_10 = 0.Item["reward_name"];
            业世丒下丁东丂丏七 val_9 = null;
            val_11 = val_9;
            val_9 = new 业世丒下丁东丂丏七(三七一丁上且丐丝丌:  0.Item["placement_name"], 丏七丙不丁丁丒丒丗:  val_10, 丒专丘丗专丝三丛丘:  System.Convert.ToInt32(value:  0.Item["reward_amount"]));
            return (业世丒下丁东丂丏七)val_11;
        }
        
        val_11 = 0;
        return (业世丒下丁东丂丏七)val_11;
    }
    public void 丞七丛丛丒丛且业业(System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙)
    {
        string val_1 = IronSourceJSON.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丗丟上上丒丐丗丞丙);
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        val_1.丞丏不丌丗一丙丕丅().Call(methodName:  "setRewardedVideoServerParams", args:  val_3);
    }
    public void 丆丄七丒三丒七丐一()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "clearRewardedVideoServerParams", args:  System.Array.Empty<System.Object>());
    }
    public void 下且与与丈一与三东(string 丒丞丕丙丁丁丁丙丏)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丒丞丕丙丁丁丁丙丏 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丒丞丕丙丁丁丁丙丏 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丒丞丕丙丁丁丁丙丏;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "showISDemandOnlyRewardedVideo", args:  val_2);
    }
    public void 下丑丌与三不丁丌丄(string 丒丞丕丙丁丁丁丙丏)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丒丞丕丙丁丁丁丙丏 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丒丞丕丙丁丁丁丙丏 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丒丞丕丙丁丁丁丙丏;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "loadISDemandOnlyRewardedVideo", args:  val_2);
    }
    public bool 七且丐丒丆丌丄世不(string 丒丞丕丙丁丁丁丙丏)
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丒丞丕丙丁丁丁丙丏 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丒丞丕丙丁丁丁丙丏 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丒丞丕丙丁丁丁丙丏;
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "isISDemandOnlyRewardedVideoAvailable", args:  val_2);
        }
        
        return val_1.Call<System.Boolean>(methodName:  "isISDemandOnlyRewardedVideoAvailable", args:  val_2);
    }
    public void 丄丛且且与丈下丞七()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "loadInterstitial", args:  System.Array.Empty<System.Object>());
    }
    public void 世一丅丟七世丙丅三()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "showInterstitial", args:  System.Array.Empty<System.Object>());
    }
    public void 世一丅丟七世丙丅三(string 三七一丁上且丐丝丌)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(三七一丁上且丐丝丌 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(三七一丁上且丐丝丌 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 三七一丁上且丐丝丌;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "showInterstitial", args:  val_2);
    }
    public bool 丒丈丝丂丒丞与不且()
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "isInterstitialReady", args:  System.Array.Empty<System.Object>());
        }
        
        return val_1.Call<System.Boolean>(methodName:  "isInterstitialReady", args:  System.Array.Empty<System.Object>());
    }
    public bool 不上丌丈丈丗丐丌丝(string 三七一丁上且丐丝丌)
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(三七一丁上且丐丝丌 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(三七一丁上且丐丝丌 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 三七一丁上且丐丝丌;
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "isInterstitialPlacementCapped", args:  val_2);
        }
        
        return val_1.Call<System.Boolean>(methodName:  "isInterstitialPlacementCapped", args:  val_2);
    }
    public void 专万丑东丄丈丟且丐(string 丒丞丕丙丁丁丁丙丏)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丒丞丕丙丁丁丁丙丏 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丒丞丕丙丁丁丁丙丏 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丒丞丕丙丁丁丁丙丏;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "loadISDemandOnlyInterstitial", args:  val_2);
    }
    public void 丐且丐丕丂万丘与丐(string 丒丞丕丙丁丁丁丙丏)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丒丞丕丙丁丁丁丙丏 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丒丞丕丙丁丁丁丙丏 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丒丞丕丙丁丁丁丙丏;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "showISDemandOnlyInterstitial", args:  val_2);
    }
    public bool 丌且丐东与一丘世丒(string 丒丞丕丙丁丁丁丙丏)
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丒丞丕丙丁丁丁丙丏 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丒丞丕丙丁丁丁丙丏 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丒丞丕丙丁丁丁丙丏;
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "isISDemandOnlyInterstitialReady", args:  val_2);
        }
        
        return val_1.Call<System.Boolean>(methodName:  "isISDemandOnlyInterstitialReady", args:  val_2);
    }
    public void 且丏万丛丕丅丝丙专()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "showOfferwall", args:  System.Array.Empty<System.Object>());
    }
    public void 且丏万丛丕丅丝丙专(string 三七一丁上且丐丝丌)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(三七一丁上且丐丝丌 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(三七一丁上且丐丝丌 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 三七一丁上且丐丝丌;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "showOfferwall", args:  val_2);
    }
    public void 丞丁丌下不丂丂业丑()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "getOfferwallCredits", args:  System.Array.Empty<System.Object>());
    }
    public bool 丂丌丒与丏丕丈丛丝()
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "isOfferwallAvailable", args:  System.Array.Empty<System.Object>());
        }
        
        return val_1.Call<System.Boolean>(methodName:  "isOfferwallAvailable", args:  System.Array.Empty<System.Object>());
    }
    public void 丆与丈丄丆丁丝丞下(丟上丟丌丈丘丁七三 丟丒且一专丟丙下一, 丕丘丞丘丙丂东丁丟 业丒丝丗与丐丛丟丏)
    {
        this.丆与丈丄丆丁丝丞下(丟丒且一专丟丙下一:  丟丒且一专丟丙下一, 业丒丝丗与丐丛丟丏:  业丒丝丗与丐丛丟丏, 三七一丁上且丐丝丌:  "");
    }
    public void 丆与丈丄丆丁丝丞下(丟上丟丌丈丘丁七三 丟丒且一专丟丙下一, 丕丘丞丘丙丂东丁丟 业丒丝丗与丐丛丟丏, string 三七一丁上且丐丝丌)
    {
        object[] val_2 = new object[5];
        string val_3 = 丟丒且一专丟丙下一.丒丗丝不丕丈世丏丞();
        if(val_2 == null)
        {
            goto label_2;
        }
        
        if(val_3 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_3 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_2[0] = val_3;
        val_2[1] = 丟丒且一专丟丙下一.丌上业东丄不三丒丏();
        val_2[2] = 丟丒且一专丟丙下一.世万丞丒丈且三与丈();
        val_2[3] = 业丒丝丗与丐丛丟丏;
        val_2[4] = 三七一丁上且丐丝丌;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "loadBanner", args:  val_2);
    }
    public void 丈三丒丐丏世且丂专()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "destroyBanner", args:  System.Array.Empty<System.Object>());
    }
    public void 丒专不丒下丂丁丞万()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "displayBanner", args:  System.Array.Empty<System.Object>());
    }
    public void 七丗丂丛丅丛丂且丗()
    {
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "hideBanner", args:  System.Array.Empty<System.Object>());
    }
    public bool 丘与丐丄丙丗丞丈专(string 三七一丁上且丐丝丌)
    {
        UnityEngine.AndroidJavaObject val_1 = this.丞丏不丌丗一丙丕丅();
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(三七一丁上且丐丝丌 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(三七一丁上且丐丝丌 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 三七一丁上且丐丝丌;
        if(val_1 != null)
        {
                return val_1.Call<System.Boolean>(methodName:  "isBannerPlacementCapped", args:  val_2);
        }
        
        return val_1.Call<System.Boolean>(methodName:  "isBannerPlacementCapped", args:  val_2);
    }
    public void 且业下且丁上丂七丆(不丕世与不丞丗丝丛 丏丒丐七七丂丂丙丅)
    {
        string val_2 = IronSourceJSON.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丏丒丐七七丂丂丙丅.丞且一与专上丟丂丝());
        object[] val_4 = new object[1];
        if(val_4 == null)
        {
            goto label_2;
        }
        
        if(val_2 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_2 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_4[0] = val_2;
        val_2.丞丏不丌丗一丙丕丅().Call(methodName:  "setSegment", args:  val_4);
    }
    public void 丅丛丄丁万万丝丙丂(bool 丆一专丟下且丘丘且)
    {
        bool val_1 = 丆一专丟下且丘丘且;
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        this.丞丏不丌丗一丙丕丅().Call(methodName:  "setConsent", args:  val_3);
    }
    public void 世丏丌丐与下丏上一(string 丟不丘丆丅丄丑丂丈)
    {
        UnityEngine.Debug.Log(message:  "Unsupported Platform");
    }
    public void 三丑丘下专丞丝与丘(string 丟不丘丆丅丄丑丂丈)
    {
        UnityEngine.Debug.Log(message:  "Unsupported Platform");
    }
    public void 丒丁丐丒丄七下丂下(string 与三万丆丛丅丄丕丆, System.Collections.Generic.Dictionary<string, string> 且东丝丌东丛丄丁业)
    {
        string val_1 = IronSourceJSON.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  且东丝丌东丛丄丁业);
        object[] val_3 = new object[2];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(与三万丆丛丅丄丕丆 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(与三万丆丛丅丄丕丆 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = 与三万丆丛丅丄丕丆;
        val_3[1] = val_1;
        val_1.丞丏不丌丗一丙丕丅().Call(methodName:  "setAdRevenueData", args:  val_3);
    }
    private static 丆丟且不丟丗丙丏业()
    {
        丆丟且不丟丗丙丏业.丗上且丈万丘七丝东 = "com.ironsource.unity.androidbridge.AndroidBridge";
    }

}
