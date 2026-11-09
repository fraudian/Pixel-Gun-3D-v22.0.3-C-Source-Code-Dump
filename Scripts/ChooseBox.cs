using UnityEngine;
internal sealed class ChooseBox : MonoBehaviour
{
    // Fields
    internal static ChooseBox 丄丘七三上丕世丞业;
    private System.Collections.Generic.List<UnityEngine.Texture> 上丐丟且丈丘丌丕不;
    private System.Collections.Generic.List<UnityEngine.Texture> 上丕万丒丙丑丏上东;
    public ChooseBoxNGUIController nguiController;
    private System.Collections.Generic.List<ChooseBoxItemOnClick> 丕丞下丄丈丗七一丕;
    public UnityEngine.Transform gridTransform;
    private System.Collections.Generic.Dictionary<int, ChooseBoxItemOnClick> 丝业丑万三丆丙丛万;
    private bool 丆丐丕丈业丛丆丐业;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    public void HandleCoinsShop()
    {
        ChooseBox.丘丞上世丗丘丏丐东 val_1 = new ChooseBox.丘丞上世丗丘丏丐东();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .丑丘丐丂不丐丒丟且 = 0;
        .丑丘丐丂不丐丒丟且 = new System.EventHandler(object:  val_1, method:  System.Void ChooseBox.丘丞上世丗丘丏丐东::一丏丗丆丈丐万与丕(object 专丙丏丄与丛下丛丒, System.EventArgs 丏一丕七丆丘一世丙));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (ChooseBox.丘丞上世丗丘丏丐东)[1152921525697150000].丑丘丐丂不丐丒丟且);
        this.nguiController.allInterfaceHolder.SetActive(value:  false);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  "TicketsCurrency", 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    private void Awake()
    {
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void ChooseBox::且不丅万丕丙丕丆且(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
    }
    private void 且不丅万丕丙丕丆且(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        var val_11;
        int val_12;
        UnityEngine.Object val_13;
        ChooseBoxItemOnClick val_14;
        System.Collections.Generic.Dictionary<System.Int32, ChooseBoxItemOnClick> val_15;
        val_11 = 七丐丅专且专七三丆;
        if(val_11 != 39)
        {
                return;
        }
        
        val_12 = this.nguiController.selectIndexMap;
        if(null == 1)
        {
            goto label_3;
        }
        
        if(null == null)
        {
                return;
        }
        
        if(null != 1)
        {
            goto label_8;
        }
        
        val_12 = val_12 + 1;
        var val_3 = (val_12 > (this.gridTransform.childCount - 1)) ? 0 : (val_12);
        goto label_8;
        label_3:
        val_12 = val_12 - 1;
        if((val_12 & 2147483648) != 0)
        {
                val_12 = this.gridTransform.childCount - 1;
        }
        
        label_8:
        if((this.丝业丑万三丆丙丛万.ContainsKey(key:  val_12)) == false)
        {
            goto label_11;
        }
        
        val_13 = this.丝业丑万三丆丙丛万.Item[val_12];
        if(val_13 == 0)
        {
                return;
        }
        
        val_14 = this.丝业丑万三丆丙丛万.Item[val_12];
        if(val_14 != null)
        {
            goto label_22;
        }
        
        goto label_18;
        label_11:
        val_15 = this.丝业丑万三丆丙丛万;
        val_14 = this.gridTransform.GetChild(index:  val_12).GetComponent<ChooseBoxItemOnClick>();
        val_15.Add(key:  val_12, value:  val_14);
        if(val_14 != null)
        {
            goto label_22;
        }
        
        label_18:
        label_22:
        val_14.OnClick();
    }
    private void 一丌丌丏丒东七下上()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = 0;
        goto label_1;
        label_21:
        val_11 = null;
        val_11 = null;
        下与业丆下三丅丅丝 val_1 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        UnityEngine.Object val_3 = UnityEngine.Resources.Load(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Boxes", 丌丗丏丏丛东专丁且:  val_1.与三丛丟丞与丕丝七));
        val_12 = 0;
        this.上丐丟且丈丘丌丕不.Add(item:  null);
        下与业丆下三丅丅丝 val_4 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Boxes", 丌丗丏丏丛东专丁且:  val_4.与三丛丟丞与丕丝七 + "_closed"));
        val_13 = 0;
        this.上丕万丒丙丑丏上东.Add(item:  null);
        val_10 = 1;
        label_1:
        val_14 = null;
        val_14 = null;
        if(val_10 < 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Count)
        {
            goto label_21;
        }
    
    }
    private void 七下丐与业上丁丈专()
    {
        this.上丐丟且丈丘丌丕不.Clear();
        UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
    }
    internal static string 丂丘丁丈七丟东世丐(string 丛一丝丛丏专一业且)
    {
        return System.String.Format(format:  "BoughtCampaignBox_{0}", arg0:  丛一丝丛丏专一业且);
    }
    private static bool 丘丑丌丘丏世丛丌东(string 丛一丝丛丏专一业且)
    {
        return 丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  ChooseBox.丂丘丁丈七丟东世丐(丛一丝丛丏专一业且:  丛一丝丛丏专一业且), 丝丒上丑一三丑丐丛:  true);
    }
    private static bool 丌丕丟丘丏专丟丂专(int 丒世东三世丞丌丕一)
    {
        null = null;
        下与业丆下三丅丅丝 val_1 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[丒世东三世丞丌丕一];
        if((ChooseBox.丞丗丝丏丁一丆不丄(丒世东三世丞丌丕一:  丒世东三世丞丌丕一)) == false)
        {
                return ChooseBox.丘丑丌丘丏世丛丌东(丛一丝丛丏专一业且:  val_1.丒丘丏上丙丟丑丕丈);
        }
        
        return true;
    }
    private static bool 丞丗丝丏丁一丆不丄(int 丒世东三世丞丌丕一)
    {
        int val_11;
        var val_12;
        string val_13;
        var val_14;
        var val_15;
        val_11 = 丒世东三世丞丌丕一;
        if((ChooseBox.丅丄丗丌丂七丙不丁(不丘丂东丛专东七东:  val_11)) != false)
        {
                if((ChooseBox.三三且丙且上丒专丅(丒世东三世丞丌丕一:  val_11)) == 0)
        {
            goto label_6;
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        下与业丆下三丅丅丝 val_4 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[val_11];
        val_13 = val_4.丒丘丏上丙丟丑丕丈;
        if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  val_13)) == null)
        {
                return (bool)val_14;
        }
        
        val_15 = null;
        val_15 = null;
        val_13 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三;
        下与业丆下三丅丅丝 val_7 = val_13.Item[val_11];
        不丛专丁世三专三丒 val_8 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  val_7.丒丘丏上丙丟丑丕丈);
        val_11 = val_8.上三丆丞丝丛丟丐不;
        var val_10 = (val_11.Count > 0) ? 1 : 0;
        return (bool)val_14;
        label_6:
        val_14 = 1;
        return (bool)val_14;
    }
    private static int 三三且丙且上丒专丅(int 丒世东三世丞丌丕一)
    {
        var val_8;
        int val_9;
        var val_10;
        var val_11;
        if(丒世东三世丞丌丕一 == 0)
        {
            goto label_1;
        }
        
        val_8 = null;
        val_8 = null;
        if((下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Count - 1) <= 丒世东三世丞丌丕一)
        {
            goto label_5;
        }
        
        if(丒世东三世丞丌丕一 != 3)
        {
            goto label_9;
        }
        
        val_9 = BalanceController.业丁且丑丕且丏丕一();
        return UnityEngine.Mathf.Max(a:  0, b:  val_9 - Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丒丈万丕丘世丈丘一());
        label_1:
        val_10 = 0;
        return (int)val_10;
        label_5:
        val_10 = 2147483647;
        return (int)val_10;
        label_9:
        val_11 = null;
        val_11 = null;
        下与业丆下三丅丅丝 val_6 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[丒世东三世丞丌丕一];
        val_9 = val_6.不万丈丙一丄丙丐丈;
        return UnityEngine.Mathf.Max(a:  0, b:  val_9 - Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丒丈万丕丘世丈丘一());
    }
    private void Start()
    {
        var val_13;
        System.EventHandler val_14;
        val_13 = null;
        val_13 = null;
        ChooseBox.丄丘七三上丕世丞业 = this;
        if(this.nguiController.startButton != 0)
        {
                Rilisoft.ButtonHandler val_2 = this.nguiController.startButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_2 != 0)
        {
                System.EventHandler val_4 = null;
            val_14 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  System.Void ChooseBox::丒丕专丟丈丙丝万业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_2.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        }
        
        if(this.nguiController.backButton != 0)
        {
                Rilisoft.ButtonHandler val_6 = this.nguiController.backButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_6 != 0)
        {
                System.EventHandler val_8 = null;
            val_14 = val_8;
            val_8 = new System.EventHandler(object:  this, method:  System.Void ChooseBox::丟东丌丌丕丐丞七专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_6.add_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        }
        
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丞万丈丌三丑丙丁丈(丙业与丙丗丝不丈东:  "Campaign");
        var val_13 = 0;
        val_13 = val_13 + 1;
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Clear();
        this.丑下丙丄丐丕三丙专();
    }
    private void 丑下丙丄丐丕三丙专()
    {
        var val_40;
        int val_41;
        UnityEngine.Object val_42;
        string val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        string val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        val_40 = null;
        val_40 = null;
        val_41 = this.gridTransform.childCount;
        int val_3 = System.Math.Min(val1:  下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Count, val2:  val_41);
        if(val_3 < 1)
        {
                return;
        }
        
        goto label_106;
        label_67:
        val_42 = X23.gameObject;
        val_42.SetActive(value:  false);
        if(X22 != 0)
        {
            goto label_97;
        }
        
        goto label_19;
        label_91:
        if(W24 <= 0)
        {
            goto label_13;
        }
        
        val_43 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1367");
        label_94:
        label_22:
        val_42 = val_42.GetComponent<UILabel>();
        val_42.text = System.String.Format(format:  val_43, arg0:  ???);
        if(X22 != 0)
        {
            goto label_97;
        }
        
        goto label_19;
        label_13:
        string val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1366");
        goto label_22;
        label_106:
        val_44 = null;
        val_44 = null;
        if(0 != (下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Count - 1))
        {
            goto label_26;
        }
        
        val_45 = null;
        goto label_43;
        label_26:
        if(0 == 0)
        {
            goto label_29;
        }
        
        val_46 = null;
        if((ChooseBox.丌丕丟丘丏专丟丂专(丒世东三世丞丌丕一:  0)) == false)
        {
            goto label_32;
        }
        
        goto label_36;
        label_29:
        val_47 = null;
        val_47 = null;
        label_36:
        下与业丆下三丅丅丝 val_12 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        val_48 = val_12.与三丛丟丞与丕丝七;
        val_43 = 1;
        goto label_41;
        label_32:
        val_45 = null;
        label_43:
        下与业丆下三丅丅丝 val_13 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        val_49 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Boxes", 丌丗丏丏丛东专丁且:  val_13.与三丛丟丞与丕丝七 + "_closed"));
        if(val_49 == null)
        {
            goto label_48;
        }
        
        val_43 = 0;
        goto label_49;
        label_48:
        val_50 = null;
        val_50 = null;
        下与业丆下三丅丅丝 val_17 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        val_48 = val_17.与三丛丟丞与丕丝七;
        val_43 = 0;
        label_41:
        val_49 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Boxes", 丌丗丏丏丛东专丁且:  val_48));
        label_49:
        UnityEngine.Transform val_20 = this.gridTransform.GetChild(index:  0);
        UITexture val_21 = val_20.GetComponent<UITexture>();
        val_42 = val_20.Find(n:  "NeedMoreStarsLabel");
        if(val_42 == 0)
        {
            goto label_62;
        }
        
        if((val_43 & 1) != 0)
        {
            goto label_67;
        }
        
        val_51 = null;
        val_51 = null;
        if(0 >= (下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Count - 1))
        {
            goto label_67;
        }
        
        val_42.gameObject.SetActive(value:  true);
        if((ChooseBox.三三且丙且上丒专丅(丒世东三世丞丌丕一:  0)) >= 1)
        {
                if((ChooseBox.丅丄丗丌丂七丙不丁(不丘丂东丛专东七东:  0)) == false)
        {
            goto label_73;
        }
        
        }
        
        val_52 = null;
        val_52 = null;
        下与业丆下三丅丅丝 val_30 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  val_30.丒丘丏上丙丟丑丕丈)) == null)
        {
            goto label_91;
        }
        
        val_53 = null;
        val_53 = null;
        下与业丆下三丅丅丝 val_33 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[0];
        不丛专丁世三专三丒 val_34 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  val_33.丒丘丏上丙丟丑丕丈);
        if(val_34.上三丆丞丝丛丟丐不.Count <= 0)
        {
            goto label_91;
        }
        
        label_73:
        string val_36 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0241");
        goto label_94;
        label_62:
        UnityEngine.Debug.LogWarning(message:  "Could not find “NeedMoreStarsLabel”.");
        if(val_20 != null)
        {
            goto label_97;
        }
        
        label_19:
        label_97:
        UnityEngine.Transform val_37 = val_20.Find(n:  "CaptionLabel");
        if(val_37 != 0)
        {
                val_37.gameObject.SetActive(value:  true);
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  "Could not find “CaptionLabel”.");
        }
        
        val_41 = 0 + 1;
        if(val_3 != val_41)
        {
            goto label_106;
        }
    
    }
    private void 丒丕专丟丈丙丝万业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.nguiController.selectIndexMap != 0)
        {
                if((ChooseBox.丌丕丟丘丏专丟丂专(丒世东三世丞丌丕一:  this.nguiController.selectIndexMap)) == false)
        {
                return;
        }
        
        }
        
        this.StartNBox(丏丟万且丝丒丝丅东:  this.nguiController.selectIndexMap);
    }
    public void StartNameBox(string 业不万不丞丞不丄业)
    {
        bool val_1 = 业不万不丞丞不丄业.Equals(value:  "Box_1");
        if(val_1 == false)
        {
            goto label_2;
        }
        
        label_20:
        val_1.StartNBox(丏丟万且丝丒丝丅东:  0);
        return;
        label_2:
        if((业不万不丞丞不丄业.Equals(value:  "Box_2")) == false)
        {
            goto label_4;
        }
        
        if((ChooseBox.丌丕丟丘丏专丟丂专(丒世东三世丞丌丕一:  1)) == false)
        {
                return;
        }
        
        goto label_20;
        label_4:
        if((业不万不丞丞不丄业.Equals(value:  "Box_3")) == false)
        {
            goto label_10;
        }
        
        if((ChooseBox.丌丕丟丘丏专丟丂专(丒世东三世丞丌丕一:  2)) == false)
        {
                return;
        }
        
        goto label_20;
        label_10:
        if((业不万不丞丞不丄业.Equals(value:  "Box_4")) == false)
        {
                return;
        }
        
        if((ChooseBox.丌丕丟丘丏专丟丂专(丒世东三世丞丌丕一:  3)) == false)
        {
                return;
        }
        
        goto label_20;
    }
    public void StartNBox(int 丏丟万且丝丒丝丅东)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_2 = null;
        val_2 = null;
        下与业丆下三丅丅丝 val_1 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[丏丟万且丝丒丝丅东];
        val_3 = null;
        val_3 = null;
        丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与 = val_1.丒丘丏上丙丟丑丕丈;
        val_4 = null;
        val_4 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
        val_5 = null;
        val_5 = null;
        LoadConnectScene.上三丕下一丅丘上丝 = 0;
        LoadConnectScene.丞丗专丝丙专丂上丗 = "ChooseLevel";
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        val_6 = null;
        val_6 = null;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟);
    }
    private void 丟东丌丌丕丐丞七专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丆丐丕丈业丛丆丐业 = true;
    }
    private void OnDestroy()
    {
        null = null;
        ChooseBox.丄丘七三上丕世丞业 = 0;
        丕七丌下与丙丅丆丅.丗丛丅丕丘且丅丈丟();
        if(UnityEngine.Application.platform != 8)
        {
                UnityEngine.PlayerPrefs.Save();
        }
        
        this.七下丐与业上丁丈专();
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void ChooseBox::且不丅万丕丙丕丆且(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    public void HandleUnlockButon()
    {
    
    }
    internal static void 上丄与丂不且丑丞丛()
    {
        var val_3;
        var val_4;
        UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
        val_3 = null;
        val_3 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
        val_4 = null;
        val_4 = null;
        LoadConnectScene.上三丕下一丅丘上丝 = 0;
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        LoadConnectScene.丞丗专丝丙专丂上丗 = 与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟);
    }
    private void Update()
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = this;
        if(this.丆丐丕丈业丛丆丐业 != false)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            ChooseBox.上丄与丂不且丑丞丛();
            this.丆丐丕丈业丛丆丐业 = false;
        }
        
        if(this.nguiController.startButton == 0)
        {
            goto label_8;
        }
        
        val_8 = this.nguiController.startButton.gameObject;
        val_9 = null;
        val_9 = null;
        if(this.nguiController.selectIndexMap != (下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Count - 1))
        {
            goto label_15;
        }
        
        if(val_8 != null)
        {
            goto label_30;
        }
        
        label_31:
        label_30:
        val_8.SetActive(value:  false);
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nguiController.unlockButton.gameObject, 丏业丟一东丂东丘丛:  false);
        val_8 = ???;
        val_7 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
        label_15:
        if((val_7 + 40 + 96) == 0)
        {
            goto label_24;
        }
        
        int val_7 = val_7 + 40 + 96;
        val_7 = ChooseBox.丌丕丟丘丏专丟丂专(丒世东三世丞丌丕一:  val_7);
        if(val_8 != 0)
        {
            goto label_30;
        }
        
        goto label_31;
        label_24:
        if(val_8 != 0)
        {
            goto label_30;
        }
        
        goto label_31;
    }
    private void OnEnable()
    {
        var val_6;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ChooseBox::丗三一丘丛专丞丐丗()), 与且专丈不万东一万:  "Choose Box");
        val_6 = null;
        val_6 = null;
        Rilisoft.LoadingTipsController.丌万丏与丞且丝丞东 = true;
        Rilisoft.LoadingTipsController.丗丐丏专丌丅丛丈七 = true;
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    internal static bool 丅丄丗丌丂七丙不丁(int 不丘丂东丛专东七东)
    {
        System.Collections.Generic.Dictionary<System.Int32, 丐丘丛三丙专业丕丄> val_9;
        var val_10;
        var val_11;
        System.Collections.Generic.Dictionary<System.Int32, 丐丘丛三丙专业丕丄> val_12;
        val_9 = 不丘丂东丛专东七东;
        if(val_9 == 0)
        {
            goto label_1;
        }
        
        val_10 = null;
        val_10 = null;
        下与业丆下三丅丅丝 val_2 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.Item[val_9 - 1];
        if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  val_2.丒丘丏上丙丟丑丕丈)) == null)
        {
                return (bool)val_11;
        }
        
        if(val_9 == 3)
        {
            goto label_10;
        }
        
        if(val_9 == 2)
        {
            goto label_11;
        }
        
        if(val_9 != 1)
        {
            goto label_12;
        }
        
        val_12 = val_4.上三丆丞丝丛丟丐不;
        if(val_12 == null)
        {
                val_12 = 0;
        }
        
        val_9 = 9;
        goto label_14;
        label_1:
        val_11 = 1;
        return (bool)val_11;
        label_10:
        val_9 = val_4.上三丆丞丝丛丟丐不;
        var val_6 = (val_9.Count > 4) ? 1 : 0;
        return (bool)val_11;
        label_11:
        val_12 = val_4.上三丆丞丝丛丟丐不;
        if(val_12 == null)
        {
                val_12 = 0;
        }
        
        val_9 = 6;
        label_14:
        var val_8 = (val_12.Count >= val_9) ? 1 : 0;
        return (bool)val_11;
        label_12:
        val_11 = 0;
        return (bool)val_11;
    }
    public ChooseBox()
    {
        this.上丐丟且丈丘丌丕不 = new System.Collections.Generic.List<UnityEngine.Texture>();
        this.上丕万丒丙丑丏上东 = new System.Collections.Generic.List<UnityEngine.Texture>();
        this.丝业丑万三丆丙丛万 = new System.Collections.Generic.Dictionary<System.Int32, ChooseBoxItemOnClick>();
    }
    private static ChooseBox()
    {
    
    }
    private void 丗三一丘丛专丞丐丗()
    {
        this.丆丐丕丈业丛丆丐业 = true;
    }

}
