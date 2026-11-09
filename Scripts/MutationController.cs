using UnityEngine;
internal sealed class MutationController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static MutationController 丆丕丝丒不丙且丐丗;
    private static bool 丟丅专东世丞一一不;
    private string 丙专丈与专一丙且丕;
    internal double 七业丏一丅丗丏丁不;
    internal int 下丕丌丁专丂东丞七;
    internal double 丘丘丞不三且丕丁丕;
    internal double 丝丐上丘丟且丗一不;
    internal double 丞专丏丙丅丗丙七七;
    internal double 丛丙专一七上下三丐;
    internal double 丝且下万万丟不丁一;
    internal string 丟丕且不与一七与丘;
    internal double 丗丞丁丟丄丆上丒下;
    private bool 丟下七丐与丟丒丐丞;
    private bool 丄丗丆丆且且万一上;
    private 下丐专一下不不上与 不丒丈一丄三不丝上;
    private CharactersTracker 三丄丂丈东丝丌丛丐;
    private float 丅一丂丕世丑丗七三;
    private float 三下丘下丂丅万丙丑;
    internal bool 丕丙一下丕上下丆丙;
    private UnityEngine.GameObject 丆万三丟业东专丏丘;
    internal double 七丙丟万丏与丆丆丂;
    internal double 专丛丐丂丐世丝丐上;
    private System.Collections.Generic.HashSet<string> 丑丐丕下世丑一丕丘;
    public static 丅世一丈七丆业丝丘[] MutationScoreEvents;
    private MutationController.丝丐下丅且丕丂与丘 丙丆丂丏丕专丅业丝;
    private bool 丂丄丁丕丆丞上三丂;
    private bool 丈专丛丄丙丁丁三丌;
    private int 丒丂丟丒与东丞七一;
    private bool 世丑丏丞丘东业丘一;
    private bool 业丂丞万万丝丞丆丒;
    private double 下专丂丗一丕一与一;
    private double 丄丄丌丗丞丝世丕世;
    private double 丄丅业丗三一万丘丅;
    
    // Properties
    internal bool 世世上丄丗三丆丂丑 { get; }
    internal MutationController.世丑丗三丙丒丈丒丏 丕且三不世丘三业万 { get; set; }
    internal int 上丑一与丙丁丅上丝 { get; set; }
    private float 业下丄丟丞丙一一一 { get; }
    internal static bool 丝丁丄丂丛下业不下 { get; }
    private int 丕丒丝七一七专丛丝 { get; }
    private int 丝丌丘上不不丙一丆 { get; }
    internal bool 丕丝专丗业上丁丆丗 { get; }
    internal bool 万丗上丄丞专上丅丝 { get; }
    internal bool 丌丄与丈丑丌上专丝 { get; }
    internal bool 丌丏专丈丐丟丕丞专 { get; }
    internal bool 丅丏且丕丈丁与丆丗 { get; }
    public float 下丕丌三丗一不丏专 { get; }
    public double 丏丟世丑丆世丆丌专 { get; }
    internal float 丌与丁不下丅丆丘丞 { get; }
    
    // Methods
    internal bool 上世上丏丛丛丆丘丟()
    {
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return false;
        }
        
        ChoiceCharacterUI val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏();
        if(val_2 != null)
        {
                return val_2.丕丗丛丄丂下世丐丕();
        }
        
        return val_2.丕丗丛丄丂下世丐丕();
    }
    private System.Collections.IEnumerator 丅三丘丏丘丌上丈丟(string 丗七专丝一七丏与丏, NetworkStartTable 丙丒七丄上与丏丙丙)
    {
        MutationController.丛下丙丁丁一万专丙 val_1 = new MutationController.丛下丙丁丁一万专丙();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丗七专丝一七丏与丏 = 丗七专丝一七丏与丏;
        }
        else
        {
                mem[40] = this;
            mem[48] = 丗七专丝一七丏与丏;
        }
        
        .丙丒七丄上与丏丙丙 = 丙丒七丄上与丏丙丙;
        return (System.Collections.IEnumerator)val_1;
    }
    public void ShowMessageNameBecameAMutant(string 丗七专丝一七丏与丏, NetworkStartTable 丙丒七丄上与丏丙丙)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丅三丘丏丘丌上丈丟(丗七专丝一七丏与丏:  丗七专丝一七丏与丏, 丙丒七丄上与丏丙丙:  丙丒七丄上与丏丙丙));
    }
    private void 丁丌丄业三丛丗下丁(string 丗七专丝一七丏与丏, string 三丒三丒一专丈万丑)
    {
        string[] val_1 = new string[5];
        val_1[0] = "ShowMessageNameBecameAMutant (";
        val_1[1] = 丗七专丝一七丏与丏;
        val_1[2] = ", ";
        val_1[3] = 三丒三丒一专丈万丑;
        val_1[4] = ")";
        UnityEngine.Debug.Log(message:  +val_1);
        HashSet.Enumerator<T> val_3 = this.丑丐丕下世丑一丕丘.GetEnumerator();
        label_21:
        if(((-577761240) & 1) == 0)
        {
            goto label_20;
        }
        
        if((System.String.op_Equality(a:  0.丐丏七丌丕丗业且上(), b:  三丒三丒一专丈万丑)) == false)
        {
            goto label_21;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this = this.丑丐丕下世丑一丕丘;
        bool val_6 = this.Add(item:  三丒三丒一专丈万丑);
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.ShowMessageNameBecameAMutant(丗七专丝一七丏与丏:  丗七专丝一七丏与丏);
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageNameBecameAMutant(丗七专丝一七丏与丏:  丗七专丝一七丏与丏);
    }
    private void 丁丁丏世一丄不丈七()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.ShowMessageNowYouAreAMutant();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageNowYouAreAMutant();
    }
    private void 丐世丕上七丏丒丗专()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.ShowMessageSoonBecameAMutant();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageSoonBecameAMutant();
    }
    private void 三丑丙丈丈丘世上三()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.HideMessageSoonBecameAMutant();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        HideMessageSoonBecameAMutant();
    }
    private void 丌下专丞丘下丌丞丂()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.ShowMessageSurvivorsAreDead();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageSurvivorsAreDead();
    }
    private void 下七丑三丐三丗丛丞()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.ShowMessageVictoryOfTheSurvivors();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageVictoryOfTheSurvivors();
    }
    private void 丐丂丙一丈丁万丆丘()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.ShowMessageYouAreAMutant();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageYouAreAMutant();
    }
    private void 七三业丝丄丞丈丄丞()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.ShowMessageYouAreASurvival();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageYouAreASurvival();
    }
    private void 丆丕丁不丗且丅一不()
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Mutation).__il2cppRuntimeField_28.ShowMessageYouSurvived();
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        ShowMessageYouSurvived();
    }
    internal MutationController.世丑丗三丙丒丈丒丏 丄上三丑丝丐专且上()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (世丑丗三丙丒丈丒丏)val_9;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.丌世万丙三丄丙且丗)) != false)
        {
                val_11 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            object val_7 = val_8.Item[GameConnect.丌世万丙三丄丙且丗];
            return (世丑丗三丙丒丈丒丏)val_9;
        }
        
        val_9 = 0;
        return (世丑丗三丙丒丈丒丏)val_9;
    }
    internal void 三不丅丕丟丛下一万(MutationController.世丑丗三丙丒丈丒丏 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丌世万丙三丄丙且丗, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal int 丅与丄丞丅丒丒业专()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (int)val_9;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.丟东丐丐丛丒丕丆七)) != false)
        {
                val_11 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            object val_7 = val_8.Item[GameConnect.丟东丐丐丛丒丕丆七];
            return (int)val_9;
        }
        
        val_9 = 0;
        return (int)val_9;
    }
    internal void 一不丂丌下专丕不丗(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丟东丐丐丛丒丕丆七, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private float 且不丘丆与上东丆丐()
    {
        var val_9;
        var val_10;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_9 = null;
            val_9 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.不丈与七丗丘下丌丅)) != false)
        {
                val_10 = null;
            val_10 = null;
            object val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.不丈与七丗丘下丌丅];
            if(val_7 != null)
        {
                return System.Single.Parse(s:  val_7);
        }
        
            return System.Single.Parse(s:  val_7);
        }
        
        }
        
        double val_8 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_8 = val_8 + this.丛丙专一七上下三丐;
        val_8 = val_8 + this.丗丞丁丟丄丆上丒下;
        return (float)(float)val_8;
    }
    public void SetMutationPlane(bool 丝丝不丝上丂三丌世)
    {
        UnityEngine.GameObject val_4;
        if(this.丆万三丟业东专丏丘 != 0)
        {
                if(丝丝不丝上丂三丌世 == true)
        {
                return;
        }
        
            UnityEngine.Object.Destroy(obj:  this.丆万三丟业东专丏丘);
            this.丆万三丟业东专丏丘 = 0;
            return;
        }
        
        if(丝丝不丝上丂三丌世 == false)
        {
                return;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "Mutation/MutationPlane");
        if(val_2 != null)
        {
                val_2 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_4 = 0;
        }
        
        this.丆万三丟业东专丏丘 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_4);
    }
    internal static bool 丑不专七丗丛丅与丟()
    {
        MutationController val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_8;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = MutationController.丆丕丝丒不丙且丐丗;
        if(val_5 == 0)
        {
            goto label_8;
        }
        
        val_7 = null;
        val_7 = null;
        if(MutationController.丆丕丝丒不丙且丐丗.goTimer <= 0f)
        {
            goto label_16;
        }
        
        val_8 = null;
        val_8 = null;
        val_5 = MutationController.丆丕丝丒不丙且丐丗;
        if(MutationController.丆丕丝丒不丙且丐丗.丙丆丂丏丕专丅业丝 != 2)
        {
            goto label_16;
        }
        
        val_9 = 1;
        return (bool)val_9;
        label_8:
        val_9 = 0;
        return (bool)val_9;
        label_16:
        val_10 = null;
        val_10 = null;
        var val_4 = (MutationController.丆丕丝丒不丙且丐丗.丙丆丂丏丕专丅业丝 == 3) ? 1 : 0;
        return (bool)val_9;
    }
    private void Awake()
    {
        var val_12;
        var val_13;
        System.Action<ExitGames.Client.Photon.Hashtable> val_14;
        var val_15;
        System.Delegate val_16;
        System.Action<System.Object[]> val_17;
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                this.FillAllValues();
            val_12 = null;
            val_12 = null;
            MutationController.丆丕丝丒不丙且丐丗 = this;
            val_13 = null;
            val_13 = null;
            val_15 = null;
            if(((System.Delegate.Combine(a:  GameConnect.世丄丄与丌业丑丕丈, b:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void MutationController::丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_15 = null;
            val_14 = 0;
        }
        
            GameConnect.世丄丄与丌业丑丕丈 = val_14;
            System.Action<System.Object[]> val_5 = null;
            val_16 = val_5;
            val_5 = new System.Action<System.Object[]>(object:  this, method:  System.Void MutationController::东丅丒丆丘七丐丌丐(object[] 业上上东丑东丞丗不));
            if(((System.Delegate.Combine(a:  GameConnect.与丝丌丌丛下且一丝, b:  val_5)) != null) && (null != null))
        {
                val_17 = 0;
        }
        
            GameConnect.与丝丌丌丛下且一丝 = val_17;
            if(this.三丄丂丈东丝丌丛丐 != 0)
        {
                return;
        }
        
            this.三丄丂丈东丝丌丛丐 = this.gameObject.AddComponent<CharactersTracker>();
            System.Action<System.String> val_10 = null;
            val_16 = val_10;
            val_10 = new System.Action<System.String>(object:  this, method:  System.Void MutationController::丟丐与上丂一业丕丕(string 丘丘丕丄丑丗丕一世));
            val_9.丝丟世丕丌万丕丙专 = val_16;
            return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        var val_6;
        System.Action<ExitGames.Client.Photon.Hashtable> val_7;
        var val_8;
        System.Action<System.Object[]> val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_8 = null;
        if(((System.Delegate.Remove(source:  GameConnect.世丄丄与丌业丑丕丈, value:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void MutationController::丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_8 = null;
            val_7 = 0;
        }
        
        GameConnect.世丄丄与丌业丑丕丈 = val_7;
        if(((System.Delegate.Remove(source:  GameConnect.与丝丌丌丛下且一丝, value:  new System.Action<System.Object[]>(object:  this, method:  System.Void MutationController::东丅丒丆丘七丐丌丐(object[] 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_9 = 0;
        }
        
        GameConnect.与丝丌丌丛下且一丝 = val_9;
        val_10 = null;
        val_10 = null;
        MutationController.丆丕丝丒不丙且丐丗 = 0;
    }
    internal bool 丄丂丏丌丕不世下七()
    {
        var val_6;
        if(((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0) && (NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏() != 0)) && (this.三丄丂丈东丝丌丛丐 != 0))
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != null)
        {
                ChoiceCharacterUI val_5 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏();
            if(val_5 != null)
        {
                val_5.上丛丌丆丑上七世三(世上世丝与不丕且七:  this.三丄丂丈东丝丌丛丐);
        }
        
        }
        
            val_6 = 1;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    public void FillAllValues()
    {
        var val_27;
        var val_28;
        object val_29;
        var val_30;
        var val_32;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_33;
        var val_34;
        var val_35;
        val_27 = null;
        val_27 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丂丆丏丄丝丆丂丕三)) != false)
        {
                val_28 = null;
            val_28 = null;
            val_29 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丂丆丏丄丝丆丂丕三];
        }
        else
        {
                val_29 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  134);
            ExitGames.Client.Photon.Hashtable val_9 = new ExitGames.Client.Photon.Hashtable();
            val_30 = null;
            val_30 = null;
            val_9.set_Item(key:  GameConnect.丂丆丏丄丝丆丂丕三, value:  val_29);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_9, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        this.丟下七丐与丟丒丐丞 = true;
        this.丙专丈与专一丙且丕 = true;
        val_32 = null;
        val_32 = null;
        val_33 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_33 != null)
        {
                val_33 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_33 == null)
        {
                val_33 = 0;
        }
        
            string val_13 = val_33.丕丅丌丐丙丈丄丁丅();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_13)) != false)
        {
                val_34 = null;
            val_34 = null;
            if((val_13.ContainsKey(key:  GameConnect.丈丝丂丐丟万丙丑丕.丕丅丌丐丙丈丄丁丅())) != false)
        {
                val_35 = null;
            val_35 = null;
            this.丙专丈与专一丙且丕 = GameConnect.丈丝丂丐丟万丙丑丕.丕丅丌丐丙丈丄丁丅();
        }
        
        }
        
        }
        
        this.七业丏一丅丗丏丁不 = val_18.mutationStartTime;
        this.下丕丌丁专丂东丞七 = val_19.mutantStartQuantity;
        this.丘丘丞不三且丕丁丕 = val_20.mutantImmortalTime;
        this.丝丐上丘丟且丗一不 = val_21.respawnTime;
        this.丞专丏丙丅丗丙七七 = val_22.choosingTime;
        this.丛丙专一七上下三丐 = val_23.matchTime;
        this.丟丕且不与一七与丘 = val_24.charPresetId;
        丄丐专丑丁丏丙东七 val_25 = GameConnect.丈丝丂丐丟万丙丑丕.Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕];
        this.丝且下万万丟不丁一 = val_25.suicidePenaltyTime;
        万且三丛丗丐且东丑.世丄丘丄丆且丌丙且(丕丛丁上丈丝与丘丟:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().Item[this.丟丕且不与一七与丘]);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    private void 丙丏丞七丅丄且七上()
    {
        UIPanel val_9;
        var val_10;
        val_9 = this;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丙丆丂丏丕专丅业丝 != 2)
        {
                return;
        }
        
        double val_2 = this.goTimer;
        if(val_2 < 0)
        {
                val_10 = mem[null + 408 + 8];
            if(val_2 != 0f)
        {
                val_10 = mem[null + 424 + 8];
        }
        
            this.丁丂下丙丐东丄三丞();
            double val_3 = this.goTimer;
            if(val_3 >= 0)
        {
                return;
        }
        
            val_9 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 24];
            val_9 = InGameGUI.丙丞专丌丁丞与不丐.rootMainPanel;
            if(val_3 >= 0)
        {
                return;
        }
        
            val_9 = ???;
        }
        else
        {
                this.丁一万丆与丝丑丞业();
        }
    
    }
    private void 丒丝丕丝三丈丛丈丆()
    {
        世丑丗三丙丒丈丒丏 val_6;
        var val_7;
        bool val_1 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(val_1 == false)
        {
                return;
        }
        
        int val_2 = val_1.丛业丈丅三丑丏七丛();
        if(val_2 != 0)
        {
                if(val_2.丟东丅丝丄丞七且丝() != 0)
        {
                return;
        }
        
            double val_5 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            double val_6 = this.丛丙专一七上下三丐;
            val_5 = (double)this.且不丘丆与上东丆丐() - val_5;
            val_6 = val_6 - this.专丛丐丂丐世丝丐上;
            if(val_5 >= 0)
        {
                return;
        }
        
            val_6 = 2;
            val_7 = 1;
        }
        else
        {
                val_6 = 2;
            val_7 = 2;
        }
        
        this.丆世且丑七上上世丝(且丅丕三不丛专一丘:  val_6, 丕丗丞丞丑丘丛丂且:  2);
    }
    private void Update()
    {
        var val_20;
        UnityEngine.GameObject val_44;
        var val_45;
        var val_46;
        string val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        string val_56;
        var val_57;
        var val_58;
        var val_59;
        PlayerBotInstance val_60;
        string val_61;
        string val_62;
        string val_63;
        var val_64;
        val_44 = this;
        this.丙丏丞七丅丄且七上();
        val_45 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_3;
        }
        
        if(this.丙丆丂丏丕专丅业丝 == 3)
        {
            goto label_4;
        }
        
        if(this.丙丆丂丏丕专丅业丝 != 2)
        {
            goto label_12;
        }
        
        this.丙不且与世丅丗上丌();
        goto label_12;
        label_3:
        this.丙丆丂丏丕专丅业丝 = 0;
        goto label_12;
        label_4:
        double val_45 = (double)UnityEngine.Time.deltaTime;
        val_45 = this.丄丄丌丗丞丝世丕世 + val_45;
        this.丄丄丌丗丞丝世丕世 = val_45;
        if((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false) && (this.下专丂丗一丕一与一 > 0f))
        {
                float val_4 = UnityEngine.Time.time;
            if(this.下专丂丗一丕一与一 < 0)
        {
                this.丄与丒丂丂丘专丝万();
        }
        
        }
        
        label_12:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_46 = null;
        val_46 = null;
        val_47 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_144;
        }
        
        val_48 = null;
        val_48 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_144;
        }
        
        val_49 = null;
        val_49 = null;
        bool val_8 = 且世专不丄丏七下万();
        if(this.丂丄丁丕丆丞上三丂 == false)
        {
            goto label_31;
        }
        
        label_144:
        label_129:
        if(this.丙丆丂丏丕专丅业丝 == 4)
        {
                val_44 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1304];
            val_44 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.modePanel;
            if(activeSelf != false)
        {
                val_44 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1304];
            val_44 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.modePanel;
            SetActive(value:  false);
        }
        
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_44 = 1152921505233256448;
        val_50 = null;
        val_50 = null;
        if(MutationController.丟丅专东世丞一一不 == false)
        {
                return;
        }
        
        val_44 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_51 = null;
        val_51 = null;
        if((val_44.ContainsKey(key:  GameConnect.丌下丈三丐丒丂丏丄)) == false)
        {
                return;
        }
        
        val_52 = null;
        val_52 = null;
        val_44 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丌下丈三丐丒丂丏丄];
        val_53 = 0;
        val_54 = 0;
        goto label_57;
        label_126:
        val_45 = 0;
        val_55 = null;
        val_55 = null;
        List.Enumerator<T> val_18 = GetEnumerator();
        label_72:
        if(((-574327856) & 1) == 0)
        {
            goto label_66;
        }
        
        string val_21 = val_20.丐丏七丌丕丗业且上();
        string val_46 = "PixelBookID";
        object val_22 = Item[val_46];
        if(val_22 != null)
        {
                val_46 = (null == null) ? (val_22) : 0;
        }
        else
        {
                val_56 = 0;
        }
        
        if(((System.String.op_Equality(a:  val_47, b:  val_56)) == false) || ((public NetworkStartTable List.Enumerator<NetworkStartTable>::get_Current()) != 0))
        {
            goto label_72;
        }
        
        val_57 = 1;
        val_58 = 1;
        goto label_74;
        label_66:
        val_58 = 0;
        val_57 = 1;
        label_74:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_57 != 1) && (564 == 564))
        {
                var val_47 = 0;
            val_47 = val_47 ^ 0;
            val_57 = val_57 + val_47;
        }
        else
        {
                if( != 0)
        {
                val_59 = 0;
        }
        
        }
        
        PlayerBotsManager val_24 = PlayerBotsManager.与一丅丝不丈业与丙();
        List.Enumerator<T> val_25 = val_24.与上且丗丄七丑丆丑.GetEnumerator();
        label_92:
        if(((-574327888) & 1) == 0)
        {
            goto label_87;
        }
        
        val_60 = val_20.丐丏七丌丕丗业且上();
        string val_48 = "PixelBookID";
        object val_27 = Item[val_48];
        if(val_27 != null)
        {
                val_48 = (null == null) ? (val_27) : 0;
        }
        else
        {
                val_61 = 0;
        }
        
        if((System.String.op_Equality(a:  val_47, b:  val_61)) == false)
        {
            goto label_92;
        }
        
        val_54 = val_57 + 1;
        val_47 = 1;
        mem2[0] = 657;
        goto label_94;
        label_87:
        val_60 = 0;
        val_47 = 0;
        val_54 = val_57 + 1;
        mem2[0] = 657;
        label_94:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_54 != 1) && ((-574327936 + ((val_57 + 1)) << 2) == 657))
        {
                var val_49 = 0;
            val_49 = val_49 ^ (val_54 >> 31);
            val_54 = val_54 + val_49;
        }
        
        if(( & ) != 1)
        {
            goto label_103;
        }
        
        val_45 = PlayerBotsManager.与一丅丝不丈业与丙();
        val_45.一丄一七上不丆下丆(丗丈东丕不丘三丞业:  null);
        goto label_114;
        label_103:
        if((( | ) & 1) != 0)
        {
            goto label_114;
        }
        
        PlayerBotsManager val_32 = PlayerBotsManager.与一丅丝不丈业与丙();
        if(val_32.与上且丗丄七丑丆丑.Count >= 1152921538392224032)
        {
            goto label_114;
        }
        
        PlayerBotsManager val_34 = PlayerBotsManager.与一丅丝不丈业与丙();
        val_47 = Item["PixelBookID"];
        val_45 = Item["Nickname"];
        if(val_34 == null)
        {
            goto label_119;
        }
        
        if(val_47 == null)
        {
            goto label_120;
        }
        
        label_123:
        var val_37 = (null == null) ? (val_47) : 0;
        if(val_45 == null)
        {
            goto label_121;
        }
        
        label_124:
        var val_38 = (null == null) ? (val_45) : 0;
        goto label_122;
        label_119:
        if(val_47 != null)
        {
            goto label_123;
        }
        
        label_120:
        val_62 = 0;
        if(val_45 != null)
        {
            goto label_124;
        }
        
        label_121:
        val_63 = 0;
        label_122:
        val_34.丈丑与丕丕丕丙丗业(三丒三丒一专丈万丑:  val_62, 丅业业丟不业丙丏丂:  val_63);
        label_114:
        val_53 = 1;
        label_57:
        if(val_53 < "Nickname")
        {
            goto label_126;
        }
        
        return;
        label_31:
        if(this.丄丄丌丗丞丝世丕世 >= this.丄丅业丗三一万丘丅)
        {
            goto label_127;
        }
        
        if(val_8 == false)
        {
            goto label_144;
        }
        
        if(this.丙丆丂丏丕专丅业丝 != 3)
        {
            goto label_129;
        }
        
        label_127:
        this.丂丄丁丕丆丞上三丂 = true;
        世丑丗三丙丒丈丒丏 val_39 = val_8.丄上三丑丝丐专且上();
        if(val_39 == 1)
        {
            goto label_130;
        }
        
        if(val_39 != 2)
        {
            goto label_144;
        }
        
        int val_40 = val_39.丅与丄丞丅丒丒业专();
        if(val_40 == 1)
        {
            goto label_141;
        }
        
        int val_41 = val_40.丅与丄丞丅丒丒业专();
        if(val_41 != 2)
        {
            goto label_144;
        }
        
        val_41.丌下专丞丘下丌丞丂();
        goto label_144;
        label_130:
        int val_42 = val_39.丅与丄丞丅丒丒业专();
        if(val_42 != 1)
        {
            goto label_135;
        }
        
        val_64 = null;
        val_64 = null;
        bool val_43 = typeof(Player_move_c).__il2cppRuntimeField_618.且世专不丄丏七下万();
        if(val_43 == true)
        {
            goto label_141;
        }
        
        val_43.丆丕丁不丗且丅一不();
        goto label_144;
        label_135:
        int val_44 = val_42.丅与丄丞丅丒丒业专();
        if(val_44 != 2)
        {
            goto label_144;
        }
        
        label_141:
        val_44.下七丑三丐三丗丛丞();
        goto label_144;
    }
    private void 与丒丈丁丟丅上丟丅()
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.Add(key:  GameConnect.丒东下丈且丕丌丞七, value:  2);
        丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 不丅专丛不东丈专三()
    {
        var val_12;
        var val_13;
        UnityEngine.Debug.LogError(message:  "SetBotsToMutants");
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_12 = 0;
        goto label_4;
        label_23:
        PlayerBotsManager val_3 = PlayerBotsManager.与一丅丝不丈业与丙();
        if(val_3.与上且丗丄七丑丆丑.Item[0] != 0)
        {
                PlayerBotsManager val_6 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotInstance val_7 = val_6.与上且丗丄七丑丆丑.Item[0];
            val_2.Add(key:  val_7.世丌丐丁丂一丘丂一.丈三世丞丕万丄七丂, value:  this.三丄丂丈东丝丌丛丐.丒丐丒丝丏万丂丂丁());
        }
        
        val_12 = 1;
        label_4:
        PlayerBotsManager val_8 = PlayerBotsManager.与一丅丝不丈业与丙();
        if(val_12 < val_8.与上且丗丄七丑丆丑.Count)
        {
            goto label_23;
        }
        
        ExitGames.Client.Photon.Hashtable val_10 = new ExitGames.Client.Photon.Hashtable();
        val_13 = null;
        val_13 = null;
        val_10.Add(key:  GameConnect.世丛业丙专东丕世丄, value:  val_2);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_10, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丙不且与世丅丗上丌()
    {
        var val_29;
        WeaponManager val_30;
        Player_move_c val_31;
        var val_32;
        var val_33;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > (double)this.且不丘丆与上东丆丐())
        {
                this.丆世且丑七上上世丝(且丅丕三不丛专一丘:  1, 丕丗丞丞丑丘丛丂且:  1);
        }
        
        }
        
        if(this.goTimer <= 0f)
        {
                this.丒丝丕丝三丈丛丈丆();
        }
        
        if((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false) && (this.丈专丛丄丙丁丁三丌 != false))
        {
                float val_6 = this.mutationStartTimer;
        }
        
        this.丈专丛丄丙丁丁三丌 = (this.mutationStartTimer >= 0f) ? 1 : 0;
        val_29 = null;
        val_29 = null;
        val_30 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_14;
        }
        
        val_30 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_30 == null)
        {
            goto label_15;
        }
        
        label_14:
        val_31 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_31 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_31 == 0)
        {
                return;
        }
        
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        if(与丆东世一丆丕丛丘() == false)
        {
            goto label_34;
        }
        
        if(this.mutationStartTimer >= 0f)
        {
            goto label_24;
        }
        
        bool val_14 = CharactersTracker.一丛丐丗丈东上东丄(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
        if(val_14 == false)
        {
            goto label_34;
        }
        
        val_14.与丒丈丁丟丅上丟丅();
        val_31 = this.三丄丂丈东丝丌丛丐;
        val_31.丄七丗上专丈一不丅();
        if(null != 0)
        {
            goto label_35;
        }
        
        goto label_30;
        label_24:
        bool val_16 = CharactersTracker.一丛丐丗丈东上东丄(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
        if(val_16 != true)
        {
                if(val_16.上世上丏丛丛丆丘丟() != true)
        {
                this.丂丏丏丂丞丁丐世丛();
        }
        
        }
        
        label_34:
        if(null != 0)
        {
            goto label_35;
        }
        
        label_30:
        label_35:
        if(且世专不丄丏七下万() != false)
        {
                bool val_20 = CharactersTracker.丆丗不丂丕丏丛七丐(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
            if(val_20 != false)
        {
                if(val_20.上世上丏丛丛丆丘丟() != true)
        {
                val_32 = null;
            val_32 = null;
            val_31 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_31 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            丒丛丑业世不七三东();
            this.丛丕丗丐与东业丝丒();
        }
        
        }
        
        }
        
        val_33 = this;
        if(this.goTimer <= 0f)
        {
            goto label_45;
        }
        
        if(this.世丑丏丞丘东业丘一 == true)
        {
            goto label_56;
        }
        
        val_33 = this;
        if(this.mutationStartTimer < 0f)
        {
            goto label_56;
        }
        
        this.世丑丏丞丘东业丘一 = true;
        val_33 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        bool val_24 = 与丆东世一丆丕丛丘();
        if(val_24 == false)
        {
            goto label_49;
        }
        
        val_24.丁丁丏世一丄不丈七();
        goto label_56;
        label_45:
        if(this.业丂丞万万丝丞丆丒 == true)
        {
            goto label_56;
        }
        
        val_33 = this;
        if(this.mutationStartTimer < 0f)
        {
            goto label_56;
        }
        
        this.业丂丞万万丝丞丆丒 = true;
        val_33 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        bool val_26 = 与丆东世一丆丕丛丘();
        if(val_26 == false)
        {
            goto label_54;
        }
        
        val_26.丐丂丙一丈丁万丆丘();
        goto label_56;
        label_49:
        val_24.七三业丝丄丞丈丄丞();
        goto label_56;
        label_54:
        val_26.丐世丕上七丏丒丗专();
        label_56:
        if(this.丒丂丟丒与东丞七一 == 0)
        {
                int val_27 = val_26.丟东丅丝丄丞七且丝();
            if(val_27 == 1)
        {
                val_27.三丑丙丈丈丘世上三();
        }
        
        }
        
        this.丒丂丟丒与东丞七一 = val_27.丟东丅丝丄丞七且丝();
        return;
        label_15:
    }
    private void 丙丗三不丟丛万三且()
    {
        string val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        NetworkStartTable val_19;
        一丏丆丂丅丐三一东 val_20;
        var val_24;
        string val_25;
        var val_26;
        val_14 = 1152921505189646336;
        val_15 = null;
        val_15 = null;
        丒丆且丑业世丅三上();
        if(GameController.onlineMode != null)
        {
                var val_1 = (null == null) ? GameController.onlineMode : 0;
        }
        
        0.丌不丂且丁丙丝万丄();
        if(null == 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        label_43:
        val_17 = null;
        if(this.mutationStartTimer >= 0f)
        {
            goto label_15;
        }
        
        val_18 = null;
        val_19 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_19 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        val_20 = 2;
        goto label_20;
        label_47:
        val_14 = 0;
        if((val_14.ContainsKey(key:  "PixelBookID")) == false)
        {
            goto label_39;
        }
        
        val_14 = val_14.Item["PixelBookID"];
        if(val_14 != null)
        {
                var val_12 = (null == null) ? (val_14) : 0;
        }
        else
        {
                val_25 = 0;
        }
        
        if((System.String.op_Equality(a:  val_25, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
        {
            goto label_43;
        }
        
        label_39:
        val_24 = 1;
        if( < 1152921505719563712)
        {
            goto label_47;
        }
        
        return;
        label_15:
        val_26 = null;
        val_19 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_19 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        val_20 = 3;
        label_20:
        下且七丒万下丅丘丅(丙业与丙丗丝不丈东:  val_20);
    }
    private int 丟东丅丝丄丞七且丝()
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = null;
        val_7 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count == 0)
        {
            goto label_4;
        }
        
        val_8 = null;
        val_8 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_9 = 0;
        goto label_12;
        label_14:
        if(X21 != 0)
        {
                val_9 = val_9 + 0.丐丏七丌丕丗业且上().且世专不丄丏七下万();
        }
        
        label_12:
        if(((-573426696) & 1) != 0)
        {
            goto label_14;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)val_9;
        label_4:
        val_9 = 0;
        return (int)val_9;
    }
    private int 丛业丈丅三丑丏七丛()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count == 0)
        {
            goto label_4;
        }
        
        val_9 = null;
        val_9 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_10 = 0;
        goto label_12;
        label_14:
        if(X21 != 0)
        {
                var val_7 = ((0.丐丏七丌丕丗业且上().丈丌丐丅一一且丏丛() & 255) == 1) ? (val_10 + 1) : (val_10);
        }
        
        label_12:
        if(((-573294216) & 1) != 0)
        {
            goto label_14;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)val_10;
        label_4:
        val_10 = 0;
        return (int)val_10;
    }
    private void 丟丐与上丂一业丕丕(string 丘丘丕丄丑丗丕一世)
    {
        var val_6;
        Player_move_c val_10;
        var val_11;
        Player_move_c val_12;
        var val_13;
        var val_14;
        var val_15;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        val_12 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_12 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_12 == 0)
        {
                return;
        }
        
        val_12 = 万且三丛丗丐且东丑.丑七不且上丗丁一世().丄丗丟丕三丑丗不丅();
        List.Enumerator<T> val_4 = val_12.GetEnumerator();
        label_14:
        if(((-573149472) & 1) == 0)
        {
            goto label_11;
        }
        
        val_12 = val_6.丐丏七丌丕丗业且上();
        if((val_7.m_stringLength.Equals(value:  丘丘丕丄丑丗丕一世)) == false)
        {
            goto label_14;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.不丒丈一丄三不丝上 = val_12;
        val_13 = null;
        val_13 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七 == null) || (null == 0))
        {
            goto label_24;
        }
        
        丗丗丝丏丁丌丏三世(七万丄七丅丅丕丝丑:  val_12);
        goto label_24;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_24:
        val_14 = null;
        val_14 = null;
        val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_10 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_15 = null;
        val_15 = null;
        val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_10 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        丝丟丑丐专丁丁七丑();
    }
    internal void 不丅丏与与三丒一万(float 丑业丗丑丒丘丆丁一, float 专不万世丗业三丘丁)
    {
        this.丅一丂丕世丑丗七三 = 丑业丗丑丒丘丆丁一;
        this.三下丘下丂丅万丙丑 = 专不万世丗业三丘丁;
    }
    internal void 与丟丁七万万下丈与(bool 丄丈且丂丕丐丅丐七)
    {
        if(丄丈且丂丕丐丅丐七 != false)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != null)
        {
                ChoiceCharacterUI val_1 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏();
            if(val_1 != null)
        {
                val_1.与丟丂丘丘一丗与三();
        }
        
        }
        
            val_1.丕丌专丕丟一丒上丌(丙业与丙丗丝不丈东:  true);
            return;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != null)
        {
                ChoiceCharacterUI val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏();
            if(val_2 != null)
        {
                val_2.丞丞丗丐丈丐丒丝丏(丌七不丏丝专专丁丒:  this.丅一丂丕世丑丗七三);
        }
        
        }
        
        val_2.丕丌专丕丟一丒上丌(丙业与丙丗丝不丈东:  true);
        Close();
    }
    internal void 丛丕丗丐与东业丝丒()
    {
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != null)
        {
                ChoiceCharacterUI val_1 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏();
            if(val_1 != null)
        {
                val_1.丞丞丗丐丈丐丒丝丏(丌七不丏丝专专丁丒:  (float)this.丝丐上丘丟且丗一不);
        }
        
        }
        
        val_1.丕丌专丕丟一丒上丌(丙业与丙丗丝不丈东:  true);
    }
    private void 丂丏丏丂丞丁丐世丛()
    {
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != null)
        {
                ChoiceCharacterUI val_1 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏();
            if(val_1 != null)
        {
                val_1.丛丅丝丆丝丞丟丗丌();
        }
        
        }
        
        val_1.丕丌专丕丟一丒上丌(丙业与丙丗丝不丈东:  true);
    }
    internal void 丕丌专丕丟一丒上丌(bool 丙业与丙丗丝不丈东)
    {
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏().丆丙丗三东专丐不上(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    internal void 丕丂不丌上世业丄丗()
    {
        if(this.三丄丂丈东丝丌丛丐 == null)
        {
                return;
        }
        
        this.三丄丂丈东丝丌丛丐.丙丏与丅专丟且丄丘(丆且丆上丝下丁且丆:  false);
    }
    internal void 丅丕丛丑三世丅世东()
    {
        this.东一丟丌丏且一丞丌(丝丝不丝上丂三丌世:  this.世业丗丄丁丝丒一丁());
    }
    internal void 业丆业且丁丒丁丈丈(bool 不丄丈丞丟丟且万东)
    {
        var val_4;
        var val_5;
        val_4 = 54981;
        if((this.上世上丏丛丛丆丘丟() == true) || (不丄丈丞丟丟且万东 == true))
        {
            goto label_2;
        }
        
        val_4 = InGameGUI.丙丞专丌丁丞与不丐.respawnWindowController;
        bool val_2 = isShown;
        if(val_2 == false)
        {
            goto label_5;
        }
        
        label_2:
        bool val_3 = val_2.上世上丏丛丛丆丘丟();
        if(val_3 != false)
        {
                val_3.丕丌专丕丟一丒上丌(丙业与丙丗丝不丈东:  false);
        }
        
        val_5 = null;
        val_5 = null;
        丟丙不上丝丂丄丗三();
        label_5:
        SetActive(value:  true);
    }
    private void 东一丟丌丏且一丞丌(MutationController.丝丐下丅且丕丂与丘 丝丝不丝上丂三丌世)
    {
        if(this.丙丆丂丏丕专丅业丝 == 丝丝不丝上丂三丌世)
        {
                return;
        }
        
        if((丝丝不丝上丂三丌世 & 255) <= 4)
        {
                var val_12 = 106017296 + ((丝丝不丝上丂三丌世 & 255)) << 2;
            val_12 = val_12 + 106017296;
        }
        else
        {
                this.丙丆丂丏丕专丅业丝 = 丝丝不丝上丂三丌世;
        }
    
    }
    private void 丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        var val_24;
        var val_25;
        string val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        string val_31;
        val_24 = 业上上东丑东丞丗不;
        val_25 = null;
        val_25 = null;
        val_26 = GameConnect.丐世丞业丁丄与丐上;
        val_27 = 1152921525484599408;
        bool val_1 = val_24.ContainsKey(key:  val_26);
        if(val_1 != false)
        {
                丝丐下丅且丕丂与丘 val_2 = val_1.世业丗丄丁丝丒一丁();
            if(((val_2 & 255) != this.丙丆丂丏丕专丅业丝) && (this.丙丆丂丏丕专丅业丝 != 0))
        {
                this.东一丟丌丏且一丞丌(丝丝不丝上丂三丌世:  val_2);
        }
        
        }
        
        val_28 = null;
        val_28 = null;
        if((val_24.ContainsKey(key:  GameConnect.世丛业丙专东丕世丄)) == false)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        val_24 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.世丛业丙专东丕世丄];
        if(val_24 == null)
        {
                return;
        }
        
        val_27 = 1152921505246248960;
        val_30 = 0;
        goto label_20;
        label_61:
        PlayerBotsManager val_8 = PlayerBotsManager.与一丅丝不丈业与丙();
        if(val_8.与上且丗丄七丑丆丑.Item[0] != 0)
        {
                PlayerBotsManager val_11 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotInstance val_12 = val_11.与上且丗丄七丑丆丑.Item[0];
            if(val_12.世丌丐丁丂一丘丂一 != 0)
        {
                PlayerBotsManager val_14 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotInstance val_15 = val_14.与上且丗丄七丑丆丑.Item[0];
            if((val_24.ContainsKey(key:  val_15.世丌丐丁丂一丘丂一.丈三世丞丕万丄七丂)) != false)
        {
                PlayerBotsManager val_17 = PlayerBotsManager.与一丅丝不丈业与丙();
            if(val_18.丅下万丏丘东丄丌万 != true)
        {
                PlayerBotsManager val_19 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotInstance val_20 = val_19.与上且丗丄七丑丆丑.Item[0];
            string val_24 = val_20.世丌丐丁丂一丘丂一.丈三世丞丕万丄七丂;
            object val_21 = val_24.Item[val_24];
            if(val_21 != null)
        {
                val_24 = (null == null) ? (val_21) : 0;
        }
        else
        {
                val_31 = 0;
        }
        
            val_17.与上且丗丄七丑丆丑.Item[0].ApplyCharacterProperties(丘丘丕丄丑丗丕一世:  val_31);
        }
        
        }
        
        }
        
        }
        
        val_30 = 1;
        label_20:
        PlayerBotsManager val_22 = PlayerBotsManager.与一丅丝不丈业与丙();
        val_26 = val_22.与上且丗丄七丑丆丑;
        if(val_30 < val_26.Count)
        {
            goto label_61;
        }
    
    }
    private void 东丅丒丆丘七丐丌丐(object[] 业上上东丑东丞丗不)
    {
        System.Collections.Generic.List<NetworkStartTable> val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_13 = 业上上东丑东丞丗不;
        val_14 = this;
        val_15 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        object val_13 = val_13[0];
        val_16 = 0;
        object val_14 = val_13[1];
        val_13 = 0;
        val_17 = null;
        val_17 = null;
        if((ContainsKey(key:  GameConnect.丒东下丈且丕丌丞七)) == false)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        if(Item[GameConnect.丒东下丈且丕丌丞七] == null)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        object val_5 = Item[GameConnect.丒东下丈且丕丌丞七];
        if(null != 2)
        {
                return;
        }
        
        if( == 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        val_13 = mem[GameController.onlineMode + 392];
        val_13 = GameController.onlineMode.丌丏丒上丆丏下与世;
        List.Enumerator<T> val_7 = GetEnumerator();
        val_15 = 1152921525927017152;
        label_35:
        if(((-571466888) & 1) == 0)
        {
            goto label_32;
        }
        
        val_13 = 0.丐丏七丌丕丗业且上();
        if(GameConnect.丒东下丈且丕丌丞七.owner != )
        {
            goto label_35;
        }
        
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.丅三丘丏丘丌上丈丟(丗七专丝一七丏与丏:  丁下不丛下且丌专丈(), 丙丒七丄上与丏丙丙:  val_13));
        label_32:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal MutationController.丝丐下丅且丕丂与丘 世业丗丄丁丝丒一丁()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_9 = null;
            val_9 = null;
            if((val_8.ContainsKey(key:  GameConnect.丐世丞业丁丄与丐上)) != false)
        {
                val_10 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            object val_7 = val_8.Item[GameConnect.丐世丞业丁丄与丐上];
            return (丝丐下丅且丕丂与丘)val_11;
        }
        
        }
        
        val_11 = 1;
        return (丝丐下丅且丕丂与丘)val_11;
    }
    internal bool 丁丁丏且三丗不且丘()
    {
        return (bool)(this.丙丆丂丏丕专丅业丝 == 4) ? 1 : 0;
    }
    internal bool 下丐万丞业且丈不丞()
    {
        return (bool)(this.丙丆丂丏丕专丅业丝 == 2) ? 1 : 0;
    }
    internal bool 丗丒丕专丛丆丈万一()
    {
        return (bool)(this.goTimer <= 0f) ? 1 : 0;
    }
    internal bool 七丌丌丐丘下丟丐丌()
    {
        var val_5;
        double val_5 = (double)this.且不丘丆与上东丆丐();
        val_5 = val_5 + 1.5;
        if((丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + this.丛丙专一七上下三丐) < 0)
        {
                var val_4 = (this.丙丆丂丏丕专丅业丝 == 2) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    internal bool 不丗丆丌丘一丙七丒()
    {
        return (bool)(this.mutationStartTimer >= 0f) ? 1 : 0;
    }
    public float get_mutationStartTimer()
    {
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_2 = (double)this.且不丘丆与上东丆丐() - val_2;
        val_2 = val_2 - this.丛丙专一七上下三丐;
        val_2 = val_2 + this.七业丏一丅丗丏丁不;
        return (float)(float)val_2;
    }
    public double get_goTimer()
    {
        double val_4 = (double)this.且不丘丆与上东丆丐();
        val_4 = (丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + this.丛丙专一七上下三丐) - val_4;
        val_4 = 0 - val_4;
        return (double)val_4;
    }
    internal float 丙世丑丅丒丑业与不()
    {
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_2 = (double)this.且不丘丆与上东丆丐() - val_2;
        return (float)(float)val_2;
    }
    internal void 且丒世万东丒丕丗万()
    {
        ExitGames.Client.Photon.Hashtable val_5;
        object val_6;
        var val_7;
        val_6 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        this.丟一丂丙丑丙丄且且();
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_5 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        double val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_3 = val_3 + this.丛丙专一七上下三丐;
        val_3 = val_3 + this.丗丞丁丟丄丆上丒下;
        val_2.set_Item(key:  GameConnect.不丈与七丗丘下丌丅, value:  val_3);
        val_6 = 2;
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  2);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丟一丂丙丑丙丄且且()
    {
        object val_28;
        与丅丕丈丘东丝世丟 val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        string val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_1 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_3 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>(collection:  丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁());
        与丅丕丈丘东丝世丟[] val_4 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        int val_27 = UnityEngine.Mathf.Min(a:  val_4.Length, b:  mem[1152921538396694376]);
        if(val_27 >= 1)
        {
                val_28 = 1152921525961926672;
            do
        {
            int val_7 = UnityEngine.Random.Range(min:  0, max:  val_3.Count);
            if(val_3 != null)
        {
                val_29 = val_3.Item[val_7];
        }
        else
        {
                val_29 = val_3.Item[val_7];
        }
        
            val_3.RemoveAt(index:  val_7);
            val_1.Add(item:  val_29);
            val_27 = val_27 - 1;
        }
        while(val_27 != 0);
        
        }
        
        val_30 = 1152921525961884688;
        val_31 = 1152921504974737408;
        val_32 = 0;
        goto label_12;
        label_19:
        ExitGames.Client.Photon.Hashtable val_10 = new ExitGames.Client.Photon.Hashtable();
        val_33 = null;
        val_33 = null;
        val_28 = 3;
        val_10.Add(key:  GameConnect.丒东下丈且丕丌丞七, value:  3);
        val_1.Item[0].丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_10, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_32 = 1;
        label_12:
        if(val_32 < val_1.Count)
        {
            goto label_19;
        }
        
        int val_13 = val_1.Count;
        object[] val_14 = new object[0];
        val_34 = 0;
        goto label_21;
        label_50:
        val_28 = val_1.Item[0];
        val_35 = null;
        val_35 = null;
        List.Enumerator<T> val_16 = GetEnumerator();
        goto label_30;
        label_37:
        if(owner == val_28)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_20 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "PixelBookID", value:  1152921525927017152);
            null.Add(key:  "Nickname", value:  3.丐丏七丌丕丗业且上());
            mem2[0] = null;
        }
        
        label_30:
        if(((-569903152) & 1) != 0)
        {
            goto label_37;
        }
        
        val_30 = 1152921525961884688;
        val_31 = 1152921504974737408;
        val_36 = 0;
        val_37 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                var val_28 = 0;
            val_28 = val_28 ^ 0;
             =  + val_28;
        }
        
        val_34 = 1;
        label_21:
        if(val_34 < val_1.Count)
        {
            goto label_50;
        }
        
        if(val_14.Length != 0)
        {
                ExitGames.Client.Photon.Hashtable val_22 = new ExitGames.Client.Photon.Hashtable();
            val_38 = null;
            val_38 = null;
            val_34 = GameConnect.丌下丈三丐丒丂丏丄;
            val_22.Add(key:  val_34, value:  val_14);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_22, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
        val_39 = 0;
        goto label_59;
        label_66:
        ExitGames.Client.Photon.Hashtable val_24 = new ExitGames.Client.Photon.Hashtable();
        val_40 = null;
        val_40 = null;
        val_24.Add(key:  GameConnect.丒东下丈且丕丌丞七, value:  1);
        val_34 = val_3.Item[0];
        val_34.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_24, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_39 = 1;
        label_59:
        if(val_39 < val_3.Count)
        {
            goto label_66;
        }
        
        if(mem[1152921538396694456] == 0)
        {
                return;
        }
        
        mem[1152921538396694456].不丝一丙丘且不且七();
    }
    private void 丁一万丆与丝丑丞业()
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丄丗丆丆且且万一上 != false)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.丙丈丌下丒专丝丄七(且且与丛七丗上丛三:  true);
        this.丄丗丆丆且且万一上 = true;
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        InGameGUIPart_Mutation.__il2cppRuntimeField_byval_arg.gameObject.SetActive(value:  false);
    }
    private void 丁丂下丙丐东丄三丞()
    {
        InGameGUI val_9;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丄丗丆丆且且万一上 == false)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.丙丈丌下丒专丝丄七(且且与丛七丗上丛三:  false);
        this.丄丗丆丆且且万一上 = false;
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == null)
        {
            goto label_25;
        }
        
        if(null == 0)
        {
            goto label_23;
        }
        
        InGameGUIPart_Mutation.__il2cppRuntimeField_byval_arg.gameObject.SetActive(value:  true);
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == null)
        {
            goto label_25;
        }
        
        label_23:
        gameObject.SetActive(value:  true);
        return;
        label_25:
    }
    private void 丆世且丑七上上世丝(MutationController.世丑丗三丙丒丈丒丏 且丅丕三不丛专一丘, int 丕丗丞丞丑丘丛丂且)
    {
        世丑丗三丙丒丈丒丏 val_5;
        var val_6;
        var val_7;
        val_5 = 且丅丕三不丛专一丘;
        val_6 = this;
        this.丁一万丆与丝丑丞业();
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  3);
        val_2.set_Item(key:  GameConnect.丌世万丙三丄丙且丗, value:  val_5);
        val_5 = GameConnect.丟东丐丐丛丒丕丆七;
        val_2.set_Item(key:  val_5, value:  丕丗丞丞丑丘丛丂且);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_6 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_6.七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
    }
    private void 丄与丒丂丂丘专丝万()
    {
        var val_5;
        var val_6;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_6 = null;
        val_6 = null;
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  4);
        val_2.set_Item(key:  GameConnect.不丈与七丗丘下丌丅, value:  0);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_5.七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
    }
    private void 万丆且东丟丛丁不丏()
    {
    
    }
    private void 丆上丛丆与专下丂丟()
    {
    
    }
    private void 丄丞丝丗丂丙一下丟()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  155, 专上丝且丂世丛丝丒:  1f);
    }
    private void 东一丞下丂丁丛丁东()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  156, 专上丝且丂世丛丝丒:  1f);
    }
    private void 丈下丕丒丟三丕下丄()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  160, 专上丝且丂世丛丝丒:  1f);
    }
    private void 三丘且三与丗不丗丄()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  157, 专上丝且丂世丛丝丒:  1f);
    }
    private void 丑丂丈业丄不丆丒世()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  158, 专上丝且丂世丛丝丒:  1f);
    }
    private void 丝专丐丛丐万丒丙丄()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  159, 专上丝且丂世丛丝丒:  1f);
    }
    private void 下与下丒业丑业丏下()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  161, 专上丝且丂世丛丝丒:  1f);
    }
    public MutationController()
    {
        this.七业丏一丅丗丏丁不 = 5;
        this.下丕丌丁专丂东丞七 = 1;
        this.丘丘丞不三且丕丁丕 = 5;
        this.丞专丏丙丅丗丙七七 = ;
        this.丛丙专一七上下三丐 = 120;
        this.丝且下万万丟不丁一 = 10;
        this.丗丞丁丟丄丆上丒下 = 6;
        this.七丙丟万丏与丆丆丂 = ;
        this.专丛丐丂丐世丝丐上 = 30;
        this.丑丐丕下世丑一丕丘 = new System.Collections.Generic.HashSet<System.String>();
        this.下专丂丗一丕一与一 = -1;
        this.丄丅业丗三一万丘丅 = 2;
    }
    private static MutationController()
    {
        MutationController.丟丅专东世丞一一不 = false;
        MutationController.MutationScoreEvents = new 丅世一丈七丆业丝丘[9];
    }

}
