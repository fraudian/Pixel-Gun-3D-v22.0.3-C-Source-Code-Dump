using UnityEngine;
internal sealed class 丆与丞丈下丄丐专丛
{
    // Fields
    private static 丆与丞丈下丄丐专丛 世丒丞七专三与万丕;
    private bool 业万丒世丏丑丅丌不;
    private 丆与丞丈下丄丐专丛.丙丟与丐三丐万万丆 丗下丘世三七一专丕;
    private static bool 丁下丅丟丘丄丅丙丙;
    
    // Properties
    public static 丆与丞丈下丄丐专丛 丆丕丝丒不丙且丐丗 { get; }
    private string 丟七世丛上丛丅万一 { get; }
    internal static string 业丂上专世丌万七丑 { get; }
    internal 丆与丞丈下丄丐专丛.丙丟与丐三丐万万丆 上丅丑丌丑丏丏丙东 { get; set; }
    
    // Methods
    public static 丆与丞丈下丄丐专丛 丑七不且上丗丁一世()
    {
        丆与丞丈下丄丐专丛 val_3;
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(丆与丞丈下丄丐专丛.世丒丞七专三与万丕 == null)
        {
                丆与丞丈下丄丐专丛 val_1 = new 丆与丞丈下丄丐专丛();
            val_5 = null;
            val_5 = null;
            丆与丞丈下丄丐专丛.世丒丞七专三与万丕 = val_1;
            val_3 = 丆与丞丈下丄丐专丛.世丒丞七专三与万丕;
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void 丆与丞丈下丄丐专丛::丝业丌丙世三丏不丟()));
            val_4 = null;
        }
        
        val_4 = null;
        return (丆与丞丈下丄丐专丛)丆与丞丈下丄丐专丛.世丒丞七专三与万丕;
    }
    private string 丑丁丞上丛专丛七丘()
    {
        return System.String.Format(format:  "TIME_SEND_EMAIL_KEY{0}", arg0:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
    }
    internal static string 丕丅丌丁丆丙业丁万()
    {
        return System.String.Format(format:  "SEND_EMAIL_NAME_KEY{0}", arg0:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
    }
    internal 丆与丞丈下丄丐专丛.丙丟与丐三丐万万丆 万丘三丘下与与且业()
    {
        丙丟与丐三丐万万丆 val_15;
        if(this.业万丒世丏丑丅丌不 != false)
        {
                val_15 = this.丗下丘世三七一专丕;
            return val_15;
        }
        
        bool val_2 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  33);
        if(val_2 != false)
        {
                val_15 = 2;
        }
        else
        {
                bool val_4 = 丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_2.丑丁丞上丛专丛七丘());
            if(val_4 != true)
        {
                string val_5 = val_4.丑丁丞上丛专丛七丘();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_5, 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
            if((System.DateTime.TryParse(s:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_5.丑丁丞上丛专丛七丘()), provider:  System.Globalization.CultureInfo.InvariantCulture, styles:  0, result: out  new System.DateTime())) != false)
        {
                System.DateTime val_10 = System.DateTime.UtcNow;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10.dateData}, t2:  new System.DateTime())) != false)
        {
                System.DateTime val_12 = System.DateTime.UtcNow;
            System.TimeSpan val_13 = val_12.dateData.Subtract(value:  new System.DateTime());
            if(val_13._ticks.TotalHours <= 24)
        {
            goto label_26;
        }
        
        }
        
        }
        
            val_15 = 0;
        }
        
        label_26:
        this.丗下丘世三七一专丕 = val_15;
        this.业万丒世丏丑丅丌不 = true;
        return val_15;
    }
    private void 丒丟丛丂丆三三丙丑(丆与丞丈下丄丐专丛.丙丟与丐三丐万万丆 丙业与丙丗丝不丈东)
    {
        this.丗下丘世三七一专丕 = 丙业与丙丗丝不丈东;
    }
    internal void 丝业丌丙世三丏不丟()
    {
        this.业万丒世丏丑丅丌不 = false;
    }
    internal void 丆世丗业丙一丂丑丘(string 丛不丞丟丅丐丙丞丂)
    {
        CoroutineRunner val_1 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_3 = val_1.StartCoroutine(routine:  val_1.丕丄丛万专专丁丝业(丛不丞丟丅丐丙丞丂:  丛不丞丟丅丐丙丞丂));
    }
    private System.Collections.IEnumerator 丕丄丛万专专丁丝业(string 丛不丞丟丅丐丙丞丂)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丛不丞丟丅丐丙丞丂 = 丛不丞丟丅丐丙丞丂;
        return (System.Collections.IEnumerator)new 丆与丞丈下丄丐专丛.且不丄丄一丙丂一丙();
    }
    private static void 丈丌丘专专丛专丞丑(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
        {
                丆与丞丈下丄丐专丛.丑七不且上丗丁一世().专丏万丙业丒不一丁(东丛丁业丝一丁一丁:  System.Convert.ToInt32(value:  丑与丂丌世丕丆一丗.Item["err_code"]));
            return;
        }
        
        丆与丞丈下丄丐专丛.丑七不且上丗丁一世().东丕丒丙丕丅且丝丒();
        Rilisoft.一丟专且三万丞丁丂.专丕丒万业一丑丗丙(丝丏业丅丈东业丝丒:  "Send Verification Email");
    }
    private void 专丏万丙业丒不一丁(int 东丛丁业丝一丁一丁)
    {
        var val_11;
        var val_12;
        var val_13;
        this.丗下丘世三七一专丕 = 0;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.丑丁丞上丛专丛七丘(), 下下丏一丙不丘丌丞:  System.String.alignConst);
        val_11 = null;
        val_11 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if(typeof(SettingsController).__il2cppRuntimeField_208.gameObject.activeSelf == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        typeof(SettingsController).__il2cppRuntimeField_208.丄世丒丗一东丘丒丂().丁丒下丕丁丐下一丄();
        EmailInputPanel val_6 = typeof(SettingsController).__il2cppRuntimeField_208.丄世丒丗一东丘丒丂();
        val_6.errorPanel.SetActive(value:  true);
        EmailInputPanel val_7 = typeof(SettingsController).__il2cppRuntimeField_208.丄世丒丗一东丘丒丂();
        val_7.error1400.SetActive(value:  (东丛丁业丝一丁一丁 != 1800) ? 1 : 0);
        EmailInputPanel val_9 = typeof(SettingsController).__il2cppRuntimeField_208.丄世丒丗一东丘丒丂();
        val_9.error1800.SetActive(value:  (东丛丁业丝一丁一丁 == 1800) ? 1 : 0);
        typeof(SettingsController).__il2cppRuntimeField_208.丈丝丞业丗且丑且万();
    }
    private void 东丕丒丙丕丅且丝丒()
    {
        var val_10;
        MainMenuController val_11;
        var val_12;
        var val_13;
        System.DateTime val_2 = System.DateTime.UtcNow;
        System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.丑丁丞上丛专丛七丘(), 下下丏一丙不丘丌丞:  val_2.dateData);
        this.丗下丘世三七一专丕 = 1;
        val_10 = null;
        val_10 = null;
        val_11 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_11 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = typeof(SettingsController).__il2cppRuntimeField_208.gameObject;
        if(val_11.activeSelf == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        typeof(SettingsController).__il2cppRuntimeField_208.丈丝丞业丗且丑且万();
        EmailInputPanel val_7 = typeof(SettingsController).__il2cppRuntimeField_208.丄世丒丗一东丘丒丂();
        val_7.inputPanel.SetActive(value:  false);
        EmailInputPanel val_8 = typeof(SettingsController).__il2cppRuntimeField_208.丄世丒丗一东丘丒丂();
        val_8.sucessPanel.SetActive(value:  true);
        val_11 = typeof(PGCompany.MainMenuMainPanel).__il2cppRuntimeField_28.gameObject;
        val_11.SetActive(value:  false);
    }
    internal void 丌七三丛丛丞丒丅丙(string 七丙不丅丛丘丗万与)
    {
        var val_5;
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  33)) != false)
        {
                return;
        }
        
        val_5 = "https://deep.pixelgun3d.com/subscribe?code=";
        if(("https://deep.pixelgun3d.com/subscribe?code=") == null)
        {
                val_5 = "https://deep.pixelgun3d.com/subscribe?code=";
        }
        
        this.三下丟丝上丐丕丂丌(专丏不丏东丏丈丆上:  七丙不丅丛丘丗万与.Substring(startIndex:  Length), 与丏丄业丏一丟与丝:  true);
    }
    internal void 丌丙万业不丏七丄三(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        object val_3 = 0;
        if(丑与丂丌世丕丆一丗 == null)
        {
                return;
        }
        
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  33)) == true)
        {
                return;
        }
        
        if((丑与丂丌世丕丆一丗.TryGetValue(key:  "code", value: out  val_3)) == false)
        {
                return;
        }
        
        this.三下丟丝上丐丕丂丌(专丏不丏东丏丈丆上:  val_3, 与丏丄业丏一丟与丝:  false);
    }
    internal void 三下丟丝上丐丕丂丌(string 专丏不丏东丏丈丆上, bool 与丏丄业丏一丟与丝 = True)
    {
        null = null;
        丆与丞丈下丄丐专丛.丁下丅丟丘丄丅丙丙 = 与丏丄业丏一丟与丝;
        CoroutineRunner val_2 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_4 = val_2.StartCoroutine(routine:  val_2.三业丐业东丁丂丗上(专丏不丏东丏丈丆上:  专丏不丏东丏丈丆上));
    }
    private System.Collections.IEnumerator 三业丐业东丁丂丗上(string 专丏不丏东丏丈丆上)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .专丏不丏东丏丈丆上 = 专丏不丏东丏丈丆上;
        return (System.Collections.IEnumerator)new 丆与丞丈下丄丐专丛.丕丂七世万丏与东丘();
    }
    private static void 丏丙丕丕丛丐专丆与(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_4;
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
        {
                val_4 = null;
            val_4 = null;
            if(((System.Convert.ToInt32(value:  丑与丂丌世丕丆一丗.Item["err_code"])) == 1801) && (丆与丞丈下丄丐专丛.丁下丅丟丘丄丅丙丙 != false))
        {
                丆与丞丈下丄丐专丛.丈丄一丘丞世丌丈丆();
            val_4 = null;
        }
        
            val_4 = null;
            丆与丞丈下丄丐专丛.丁下丅丟丘丄丅丙丙 = false;
            return;
        }
        
        丆与丞丈下丄丐专丛.下丅丄丟三丝丄丟不();
    }
    private static void 丈丄一丘丞世丌丈丆()
    {
        if(Rilisoft.SubscriptionEmailWindow.不七丘丁上不业丐专() != false)
        {
                return;
        }
        
        Rilisoft.SubscriptionEmailErrorWindow.丈业丙丈丆丈丛丆专(丙业与丙丗丝不丈东:  true);
    }
    internal static void 下丅丄丟三丝丄丟不()
    {
        MainMenuController val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        if((val_8.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  33)) == true)
        {
                return;
        }
        
        Rilisoft.SubscriptionEmailWindow.与丒丛东七丈专且丒(丙业与丙丗丝不丈东:  true);
        val_9 = null;
        val_9 = null;
        val_8 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_8 == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = typeof(SettingsController).__il2cppRuntimeField_208.gameObject;
        if(val_8.activeSelf == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        typeof(SettingsController).__il2cppRuntimeField_208.丄世丒丗一东丘丒丂().gameObject.SetActive(value:  false);
    }
    internal void 丌丑丈丟丝丙万丙丗()
    {
        var val_11;
        var val_12;
        MainMenuController val_13;
        var val_14;
        var val_15;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  165);
        val_11 = null;
        val_11 = null;
        int val_2 = BalanceController.丟不丌七丝七东丞业.丟丂丞不专丆万丒世();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  BalanceController.丟不丌七丝七东丞业.东与三丌丅三丒丏业(), 丗世丈丂丒丞专上丟:  BalanceController.丟不丌七丝七东丞业.丟丂丞不专丆万丒世(), 世丁丙世丄一万丆三:  22, 丛丞万三下丘七丌丅:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  33);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        this.丗下丘世三七一专丕 = 2;
        val_12 = null;
        val_12 = null;
        val_13 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_13 == 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_13 = typeof(SettingsController).__il2cppRuntimeField_208.gameObject;
        if(val_13.activeSelf == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        typeof(SettingsController).__il2cppRuntimeField_208.丈丝丞业丗且丑且万();
    }
    public 丆与丞丈下丄丐专丛()
    {
    
    }
    private static 丆与丞丈下丄丐专丛()
    {
    
    }

}
