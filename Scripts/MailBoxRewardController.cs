using UnityEngine;
internal sealed class MailBoxRewardController : PGBehaviour
{
    // Fields
    internal static MailBoxRewardController 丄丞丁丈与业上丞丟;
    internal bool 丄丅丈丆丛三三世与;
    private MailBoxRewardWindow 七三丑上下不丞三丑;
    internal 丈丞丕丘丕丗与上一 三丐丞丝世丗一且丌;
    internal Rilisoft.丝丑丂丛万丐丈丘且 业不业丑丂丅三一丒;
    private bool 丏不丘丞丕丏专且丆;
    private static bool <上丆专丟下丌丟丄丐>k__BackingField;
    
    // Properties
    internal 丈丞丕丘丕丗与上一 丐丁丛不专万不丘丝 { get; }
    internal static bool 丂丄丄丐丕丆丈丈丏 { get; set; }
    
    // Methods
    internal 丈丞丕丘丕丗与上一 丕不丗且专丅世丂一()
    {
        return (丈丞丕丘丕丗与上一)this.三丐丞丝世丗一且丌;
    }
    internal static bool 丁丆丟东上且上丕丑()
    {
        return (bool)MailBoxRewardController.<上丆专丟下丌丟丄丐>k__BackingField;
    }
    private static void 专丂丗丛丐丑世丞丒(bool 丙业与丙丗丝不丈东)
    {
        MailBoxRewardController.<上丆专丟下丌丟丄丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        MailBoxRewardController.丄丞丁丈与业上丞丟 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
        专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MailBoxRewardController::丟三丐丈丄丗且丑丒()));
    }
    private void 丟三丐丈丄丗且丑丒()
    {
        this.丏不丘丞丕丏专且丆 = false;
        this.丄丅丈丆丛三三世与 = false;
        MailBoxRewardController.<上丆专丟下丌丟丄丐>k__BackingField = false;
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        if(东丗七丕丄不丐专丒 == false)
        {
            goto label_0;
        }
        
        if(this.丄丅丈丆丛三三世与 == false)
        {
                return;
        }
        
        if((this.一丈丄东丑丕丕丄业(丞丅上丏丂且下丅与:  this.业不业丑丂丅三一丒)) == false)
        {
            goto label_2;
        }
        
        this.三丐丞丝世丗一且丌.丟丒丛三上上且丞业(丂三丗丑丕丛丝业丌:  this.业不业丑丂丅三一丒, 丗七丟丈三不丕一三:  this.三丐丞丝世丗一且丌);
        this.丏不丘丞丕丏专且丆 = true;
        return;
        label_0:
        if(this.丄丅丈丆丛三三世与 == false)
        {
                return;
        }
        
        if(this.丏不丘丞丕丏专且丆 == false)
        {
                return;
        }
        
        this.丅丅丕一上丒上七七();
        this.丏不丘丞丕丏专且丆 = false;
        this.丄丅丈丆丛三三世与 = false;
        return;
        label_2:
        this.丏不丘丞丕丏专且丆 = false;
        this.丄丅丈丆丛三三世与 = false;
        this.三下丘丑丂丟丄七丙(丛与丙丒丒下丌丟且:  false);
    }
    private void 三下丘丑丂丟丄七丙(bool 丛与丙丒丒下丌丟且)
    {
        if(丛与丙丒丒下丌丟且 == false)
        {
            goto label_1;
        }
        
        三专业丙丏丆丟丒丑 val_1 = this.丏丈不丑上三七业丗();
        if((val_1 == null) || ((this.一丈丄东丑丕丕丄业(丞丅上丏丂且下丅与:  val_1.丞业丅万七万且丏丏())) == false))
        {
            goto label_3;
        }
        
        MailBoxRewardController.<上丆专丟下丌丟丄丐>k__BackingField = true;
        return;
        label_1:
        MailBoxRewardController.<上丆专丟下丌丟丄丐>k__BackingField = false;
        BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  52);
        return;
        label_3:
        MailBoxRewardController.<上丆专丟下丌丟丄丐>k__BackingField = false;
    }
    internal void 丛丅丏万三东七丑不(三专业丙丏丆丟丒丑 丟且丐七丄不丂丐丏)
    {
        var val_10;
        if(丟且丐七丄不丂丐丏 == null)
        {
                return;
        }
        
        if((this.一丈丄东丑丕丕丄业(丞丅上丏丂且下丅与:  丟且丐七丄不丂丐丏.丞业丅万七万且丏丏())) != false)
        {
                BankController.业丟不一三上七丆丕(丏丂不专上丘丂不丅:  丟且丐七丄不丂丐丏.丗七丟丈三不丕一三.东与三丌丅三丒丏业(), 丌丒丝东丌下丕丁丅:  丟且丐七丄不丂丐丏.丗七丟丈三不丕一三.丟丂丞不专丆万丒世(), 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  61, 丟世且丕丂丁万丒万:  0);
            val_10 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世();
            val_10.一丗丙丝丒丂丗三丁(丟不丄一丄丅一世丗:  7, 不且丐一丆丛丙丙丒:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  丟且丐七丄不丂丐丏.丗七丟丈三不丕一三.东与三丌丅三丒丏业(), 丂丕丂丏专丂丄丕且:  丟且丐七丄不丂丐丏.丗七丟丈三不丕一三.丟丂丞不专丆万丒世()));
            UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  7, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
        }
        
        this.丙万丆专丐丛丆丐七();
        this.万丌丆万专一丝专不(丞丅上丏丂且下丅与:  丟且丐七丄不丂丐丏.丞业丅万七万且丏丏());
        this.三下丘丑丂丟丄七丙(丛与丙丒丒下丌丟且:  false);
    }
    internal 三专业丙丏丆丟丒丑 丏丈不丑上三七业丗()
    {
        var val_15;
        var val_16;
        丈丞丕丘丕丗与上一 val_17;
        var val_18;
        var val_19;
        var val_20;
        string val_21;
        val_15 = null;
        val_15 = null;
        if(MailBoxMultiController.丄丞丁丈与业上丞丟 != 0)
        {
                val_16 = null;
            val_16 = null;
            val_17 = 0.丄一丅与丅丄丆丈与(丟丞东丄七丕丑丆丙:  MailBoxMultiController.丘东且丑丂三专丑与);
        }
        
        val_17 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  93);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = null;
        val_17 = val_5;
        val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_17 != null)
        {
                val_18 = 0;
        }
        else
        {
                val_18 = 1;
        }
        
        if(val_17.Count == 0)
        {
            goto label_21;
        }
        
        if((val_17.ContainsKey(key:  "r_id")) == false)
        {
            goto label_23;
        }
        
        val_19 = System.Convert.ToInt32(value:  val_17.Item["r_id"]);
        if( != 0)
        {
            goto label_27;
        }
        
        goto label_30;
        label_21:
        val_20 = 0;
        return (三专业丙丏丆丟丒丑)val_20;
        label_23:
        val_19 = 0;
        if( == 0)
        {
            goto label_30;
        }
        
        label_27:
        label_30:
        if((val_17.ContainsKey(key:  "r")) == false)
        {
            goto label_31;
        }
        
        object val_12 = val_17.Item["r"];
        if(val_12 == null)
        {
            goto label_35;
        }
        
        val_12 = (null == null) ? (val_12) : 0;
        goto label_36;
        label_31:
        val_17 = 0;
        goto label_37;
        label_35:
        val_21 = 0;
        label_36:
        val_17 = 丈丞丕丘丕丗与上一.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  val_21);
        label_37:
        三专业丙丏丆丟丒丑 val_14 = null;
        val_20 = val_14;
        val_14 = new 三专业丙丏丆丟丒丑(丁三丆上丆丗丒且丏:  val_17, 丞丅上丏丂且下丅与:  0);
        return (三专业丙丏丆丟丒丑)val_20;
    }
    internal void 丟丒丛三上上且丞业(int 丂三丗丑丕丛丝业丌, string 丗七丟丈三不丕一三)
    {
        var val_4;
        var val_5;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_1 != null)
        {
                val_1.Add(key:  "r_id", value:  丂三丗丑丕丛丝业丌);
        }
        else
        {
                val_1.Add(key:  "r_id", value:  丂三丗丑丕丛丝业丌);
        }
        
        val_1.Add(key:  "r", value:  丗七丟丈三不丕一三);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  93, 丙业与丙丗丝不丈东:  val_1);
        val_4 = null;
        val_4 = null;
        if(MailBoxMultiController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        0.七丕下丕丒丛万三丈(丟丞东丄七丕丑丆丙:  MailBoxMultiController.丘东且丑丂三专丑与, 丙业与丙丗丝不丈东:  val_1);
    }
    internal bool 一丈丄东丑丕丕丄业(int 丞丅上丏丂且下丅与)
    {
        var val_4;
        var val_6;
        var val_7;
        val_6 = 丞丅上丏丂且下丅与;
        System.Collections.Generic.List<System.Int32> val_1 = this.丗丝丝丐丁丛丐丕丁();
        List.Enumerator<T> val_2 = val_1.GetEnumerator();
        label_3:
        if(((-676586528) & 1) == 0)
        {
            goto label_2;
        }
        
        if(val_4.丙东专丂世丈丏丁丂() != val_6)
        {
            goto label_3;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_4.七专不丆丄丈三且丌(丑与丙丘丝丁丈丙丐:  val_1);
        val_7 = 0;
        return (bool)val_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_7 = 1;
        return (bool)val_7;
    }
    internal void 丌丈万丟丐丐丌下七(System.Collections.Generic.List<丗不专世丑七万丞与> 丂上丁丑丈上丛七专)
    {
        int val_12;
        var val_13;
        System.Collections.Generic.List<System.Int32> val_1 = this.丗丝丝丐丁丛丐丕丁();
        int val_12 = val_1.Count;
        goto label_12;
        label_18:
        val_12 = 0;
        val_13 = 0;
        goto label_4;
        label_11:
        丏不一丏丗丗丗丈丞 val_5 = 丂上丁丑丈上丛七专.Item[0].丐东专丁三丙丟丆丅();
        var val_7 = (val_1.Item[val_12] == ) ? 1 : 0;
        val_7 = val_13 | val_7;
        val_13 = val_7 | ((丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  -676447936)) ^ 1);
        val_12 = 1;
        label_4:
        if(val_12 < 丂上丁丑丈上丛七专.Count)
        {
            goto label_11;
        }
        
        if(val_13 != true)
        {
                val_12 = val_1.Item[val_12];
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丆丐丑万三不丅丐丂(三丐三丞丘丕不丒专:  val_12);
            val_1.RemoveAt(index:  val_12);
        }
        
        label_12:
        val_12 = val_12 - 1;
        if((val_12 & 2147483648) == 0)
        {
            goto label_18;
        }
        
        if((1 & 1) == 0)
        {
                return;
        }
        
        val_1.万三丌上上丂三丏丏(一丐丗丁丞丆丅丟丄:  val_1);
    }
    private void 万三丌上上丂三丏丏(System.Collections.Generic.List<int> 一丐丗丁丞丆丅丟丄)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(MailBoxMultiController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        0.七丕下丕丒丛万三丈(丟丞东丄七丕丑丆丙:  MailBoxMultiController.丝万丐丟丛丄七上万, 丙业与丙丗丝不丈东:  一丐丗丁丞丆丅丟丄);
    }
    internal void 万丌丆万专一丝专不(int 丞丅上丏丂且下丅与)
    {
        var val_5;
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        val_8 = this.丗丝丝丐丁丛丐丕丁();
        if(val_8 == null)
        {
                System.Collections.Generic.List<System.Int32> val_2 = null;
            val_8 = val_2;
            val_2 = new System.Collections.Generic.List<System.Int32>();
            if(val_8 == null)
        {
            goto label_8;
        }
        
        }
        
        label_8:
        List.Enumerator<T> val_3 = val_2.GetEnumerator();
        val_9 = 1152921525710254080;
        label_4:
        if(((-676182960) & 1) == 0)
        {
            goto label_3;
        }
        
        if(val_5.丙东专丂世丈丏丁丂() != 丞丅上丏丂且下丅与)
        {
            goto label_4;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(0 == 0)
        {
            
        }
        
        val_2.Add(item:  丞丅上丏丂且下丅与);
        val_9 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_9.三七丟丗下丟三与专(三丐三丞丘丕不丒专:  丞丅上丏丂且下丅与);
        val_9.万三丌上上丂三丏丏(一丐丗丁丞丆丅丟丄:  val_2);
    }
    internal System.Collections.Generic.List<int> 丗丝丝丐丁丛丐丕丁()
    {
        var val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.IEnumerable<T> val_13;
        val_10 = null;
        val_10 = null;
        val_11 = 0;
        if(MailBoxMultiController.丄丞丁丈与业上丞丟 != 0)
        {
                val_12 = null;
            val_12 = null;
            object val_2 = 0.丄一丅与丅丄丆丈与(丟丞东丄七丕丑丆丙:  MailBoxMultiController.丝万丐丟丛丄七上万);
            val_11 = 0;
        }
        
        System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Int32>(source:  Progress.七七世万专丕丁上业.丟丐下丑万且丑丙丏().丈丏丁东上与东丙丕());
        val_13 = val_5;
        if(val_13 == null)
        {
                return val_5.万丙丞丂世丌丛七下(丟丙不丙业与丗七丄:  null);
        }
        
        if(val_13 != null)
        {
                return (System.Collections.Generic.List<System.Int32>);
        }
        
        System.Collections.Generic.List<System.Int32> val_6 = new System.Collections.Generic.List<System.Int32>();
        System.Collections.Generic.List<System.Int32> val_7 = new System.Collections.Generic.List<System.Int32>();
        val_6.AddRange(collection:  val_13);
        val_6.AddRange(collection:  val_6.万丙丞丂世丌丛七下(丟丙不丙业与丗七丄:  null));
        return 丞东丑专丛丆丄丝世.东上东丈七丗丐丒不(丝丘丑业丛万丞丌丝:  val_6);
    }
    private System.Collections.Generic.List<int> 万丙丞丂世丌丛七下(System.Collections.Generic.List<object> 丟丙不丙业与丗七丄)
    {
        var val_4;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        List.Enumerator<T> val_2 = 丟丙不丙业与丗七丄.GetEnumerator();
        label_8:
        if(((-675868864) & 1) == 0)
        {
            goto label_2;
        }
        
        int val_6 = System.Convert.ToInt32(value:  val_4.丐丏七丌丕丗业且上());
        if((val_1.Contains(item:  val_6)) == true)
        {
            goto label_8;
        }
        
        val_1.Add(item:  val_6);
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    private void 七专不丆丄丈三且丌(System.Collections.Generic.List<int> 丑与丙丘丝丁丈丙丐)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(MailBoxMultiController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        0.七丕下丕丒丛万三丈(丟丞东丄七丕丑丆丙:  MailBoxMultiController.丝万丐丟丛丄七上万, 丙业与丙丗丝不丈东:  丑与丙丘丝丁丈丙丐);
    }
    internal void 丙万丆专丐丛丆丐七()
    {
        var val_5;
        var val_6;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  93, 丙业与丙丗丝不丈东:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        val_5 = null;
        val_5 = null;
        if(MailBoxMultiController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        0.七丕下丕丒丛万三丈(丟丞东丄七丕丑丆丙:  MailBoxMultiController.丘东且丑丂三专丑与, 丙业与丙丗丝不丈东:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
    }
    internal void 丅丅丕一上丒上七七()
    {
        if(MailBoxRewardController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        bool val_2 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
        if(val_2 == true)
        {
                return;
        }
        
        三专业丙丏丆丟丒丑 val_3 = val_2.丏丈不丑上三七业丗();
        if(val_3 == null)
        {
                return;
        }
        
        bool val_5 = this.一丈丄东丑丕丕丄业(丞丅上丏丂且下丅与:  val_3.丞业丅万七万且丏丏());
        if(val_5 != false)
        {
                this.三下丘丑丂丟丄七丙(丛与丙丒丒下丌丟且:  true);
            return;
        }
        
        val_5.丙万丆专丐丛丆丐七();
    }
    public MailBoxRewardController()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
        this.业不业丑丂丅三一丒 = val_1;
        mem[1152921538291229944] = val_1.上万三丆专丏丒丗业;
    }

}
