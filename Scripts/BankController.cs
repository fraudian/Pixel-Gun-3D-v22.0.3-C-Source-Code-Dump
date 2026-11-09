using UnityEngine;
internal sealed class BankController : MonoBehaviour
{
    // Fields
    internal const int 东丏丈东丌一丅丛专 = 0;
    internal const int 七丌丐丆丙丞丑业下 = 0;
    internal static bool 三与丈且丘丆丂与丒;
    internal static bool 丂七上业下丆丄东丄;
    internal static bool 丕下三丂世下丟东丁;
    private static BankController 丝业丆丁业三丈丟东;
    private System.Nullable<bool> 业丈不丟世万丈不一;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<bool> 丌且丝丄丂丛且丛世;
    private readonly System.Collections.Generic.List<BankView.BankViewTab> 丐七丌七丌丒专不丏;
    internal PreviewOfferPackController PreviewOfferPackController;
    internal System.Collections.Generic.List<BankView.BankViewTab> 东丄丗丄丙丌上业下;
    private System.IDisposable 丐丆七且丞丏下三丙;
    public Rilisoft.BankBannersHolder _bannersHolder;
    private int 不丅万丛丝上三不与;
    private string 业丝七下丑下业七丑;
    private bool 丆丐丕丈业丛丆丐业;
    private bool 丟丙丙万与东业丑丗;
    public UnityEngine.AudioListener audioListenerForClans;
    public AbstractBankView bankViewCommon;
    private System.Collections.Generic.List<string> 上不丈丘与丆上七丕;
    private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丅且一七世丄丛三丁;
    public UnityEngine.AudioClip deniedClip;
    private bool 丝丘业丗丝世万下万;
    private AbstractBankView 丅与丂丏丄丟丆丄丘;
    private string 丕丂丞丛丑与丛专丁;
    private float 万万丁下一丄七不丁;
    private bool 万丆丒七丑不丈世丈;
    private float 丞与丏七丈丒七丈万;
    public UnityEngine.GameObject uiRoot;
    private static System.Action<int> 丛东丕丑下丂丆丑丒;
    private static System.Action<int, float> 丂万与丟丅丄丂七下;
    private static System.Action<int, float> 丑三丕不万与与丁万;
    private static System.Action<int, float> 丙丑不丄不丗不丟丒;
    private static System.Action<int> 丝丑丅丟三丈丏丌东;
    private static System.Action<int> 丗丝专丗七业专专丛;
    private static System.Action 丆七丂丂丂一三世丘;
    private static System.Action 丅丆丟不丅丘丆丝丝;
    private static System.Action 三丕业东丛丐三丑丗;
    private System.EventHandler 世丐与一丛业丆专丝;
    private Rilisoft.业丙丘丆东丈丕丂丄 丅丒丏丘世丏上上世;
    
    // Properties
    internal bool 丝丟业专丕丌一丆丌 { get; set; }
    internal System.Collections.Generic.List<BankView.BankViewTab> 丂与丂丗不不丗三丑 { get; }
    internal System.Collections.Generic.List<BankView.BankViewTab> 专丝上丒丈丐且业丝 { get; }
    private AbstractBankView 丄东专丅七丙丒丗下 { get; }
    internal AbstractBankView 丁丘世丒丅丑丐上丛 { get; set; }
    internal bool 不丁丄丌丒上丅丂丟 { get; }
    internal bool 丝丑与丆上丂与丟世 { get; }
    internal static BankController 丆丕丝丒不丙且丐丗 { get; }
    private float 东东丈丌丒上丂丟丂 { get; set; }
    
    // Methods
    internal bool 专丒丙丑丗七一世世()
    {
        var val_2;
        if(((-1030561972) & 1) != 0)
        {
                bool val_1 = this.业丈不丟世万丈不一.GetValueOrDefault();
        }
        else
        {
                val_2 = 0;
        }
        
        val_2 = val_2 & 1;
        return (bool)val_2;
    }
    internal void 丟七丒丝三专且丑七(bool 丙业与丙丗丝不丈东)
    {
        if((this.业丈不丟世万丈不一 & 1) != 0)
        {
                if((this.业丈不丟世万丈不一 ^ 丙业与丙丗丝不丈东 & 1) == 0)
        {
                return;
        }
        
        }
        
        bool val_2 = 丙业与丙丗丝不丈东;
        this.业丈不丟世万丈不一 = 0;
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
                return;
        }
        
        if(this.丅与丂丏丄丟丆丄丘 == null)
        {
                return;
        }
        
        this.丅与丂丏丄丟丆丄丘.丙丕丕下丅丐丙丅丕();
    }
    internal System.Collections.Generic.List<BankView.BankViewTab> 世丂丅下丅且上丂丝()
    {
        return System.Linq.Enumerable.ToList<BankViewTab>(source:  this.丐七丌七丌丒专不丏);
    }
    internal System.Collections.Generic.List<BankView.BankViewTab> 业丗丆丂专下三丑丗()
    {
        return System.Linq.Enumerable.ToList<BankViewTab>(source:  this.东丄丗丄丙丌上业下);
    }
    internal bool 丞不万丁七下东丗一(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        var val_2;
        if((this.东丄丗丄丙丌上业下.Contains(item:  丐丅丒专丛丏上与业)) != false)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.东丄丗丄丙丌上业下.Add(item:  丐丅丒专丛丏上与业);
        if(this.丅与丂丏丄丟丆丄丘 != null)
        {
                this.丅与丂丏丄丟丆丄丘.丙丕丕下丅丐丙丅丕();
        }
        
        val_2 = 1;
        return (bool)val_2;
    }
    internal bool 丅丟丞丂丄丁丆丆丈(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        var val_3;
        if((this.东丄丗丄丙丌上业下.Contains(item:  丐丅丒专丛丏上与业)) != false)
        {
                bool val_2 = this.东丄丗丄丙丌上业下.Remove(item:  丐丅丒专丛丏上与业);
            if(this.丅与丂丏丄丟丆丄丘 != null)
        {
                this.丅与丂丏丄丟丆丄丘.丙丕丕下丅丐丙丅丕();
        }
        
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    internal void 下丏三下丟丌万丘七()
    {
        this.东丄丗丄丙丌上业下 = System.Linq.Enumerable.ToList<BankViewTab>(source:  this.丐七丌七丌丒专不丏);
    }
    internal void 丏三三不一丘上七且(System.Collections.Generic.List<BankView.BankViewTab> 丐万丂丞万丌丐丞世)
    {
        System.Collections.Generic.List<BankViewTab> val_5 = 丐万丂丞万丌丐丞世;
        if(val_5 == null)
        {
                System.Collections.Generic.List<BankViewTab> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Collections.Generic.List<BankViewTab>();
        }
        
        this.东丄丗丄丙丌上业下 = val_5;
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
                return;
        }
        
        if(this.丅与丂丏丄丟丆丄丘 == null)
        {
                return;
        }
    
    }
    internal bool 丁且上丘业且七丌专(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        if(this.东丄丗丄丙丌上业下 != null)
        {
                if((System.Linq.Enumerable.Any<BankViewTab>(source:  this.东丄丗丄丙丌上业下)) == true)
        {
            goto label_2;
        }
        
        }
        
        this.下丏三下丟丌万丘七();
        label_2:
        if(this.东丄丗丄丙丌上业下 != null)
        {
                return this.东丄丗丄丙丌上业下.Contains(item:  丐丅丒专丛丏上与业);
        }
        
        return this.东丄丗丄丙丌上业下.Contains(item:  丐丅丒专丛丏上与业);
    }
    internal void 丈丄丁与丝丌丛与世(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        var val_6;
        var val_7;
        var val_8;
        if(丈丄不七三万丄丁不 == null)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if((System.String.op_Equality(a:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                val_7 = 1;
        }
        else
        {
                val_8 = null;
            val_8 = null;
        }
        
        this.丈丄丁与丝丌丛与世(丐丅丒专丛丏上与业:  ((System.String.op_Equality(a:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? 2 : 0);
    }
    internal void 丈丄丁与丝丌丛与世(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        BankViewTab val_8;
        var val_9;
        val_8 = 丐丅丒专丛丏上与业;
        val_9 = 0;
        if( == 0)
        {
                return;
        }
        
        var val_4 = ((丏万丘丙丐七丒丄丕(丐丅丒专丛丏上与业:  val_8)) != true) ? (val_8) : (0 + 1);
        if(GetEnabledTab() == )
        {
                return;
        }
        
        GoToTab(丐丅丒专丛丏上与业:  null, 七业业世丅一丁不丛:  0);
    }
    private AbstractBankView 丑丘丏专丟丕一一丏()
    {
        return (AbstractBankView)this.bankViewCommon;
    }
    internal AbstractBankView 丅丘专丅丏丏丆业三()
    {
        return (AbstractBankView)this.丅与丂丏丄丟丆丄丘;
    }
    private void 丆丄东丈东丐下丗下(AbstractBankView 丙业与丙丗丝不丈东)
    {
        this.丅与丂丏丄丟丆丄丘 = 丙业与丙丗丝不丈东;
    }
    internal bool 上丙丆不丂丂丄一丂()
    {
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_2 = this.丅与丂丏丄丟丆丄丘.gameObject;
        if(val_2 != null)
        {
                return val_2.activeInHierarchy;
        }
        
        return val_2.activeInHierarchy;
    }
    internal bool 上丌业丘下丞丂下丐()
    {
        return (bool)this.丟丙丙万与东业丑丗;
    }
    internal static BankController 丑七不且上丗丁一世()
    {
        null = null;
        return (BankController)BankController.丝业丆丁业三丈丟东;
    }
    private float 丗丆与丞下丛丕世不()
    {
        return (float)this.万万丁下一丄七不丁;
    }
    private void 与丆丗丛上东丅丝且(float 丙业与丙丗丝不丈东)
    {
        this.万万丁下一丄七不丁 = 丙业与丙丗丝不丈东;
    }
    internal static void 丕丝丌丅七丌三万丛(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.丛东丕丑下丂丆丑丒, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丛东丕丑下丂丆丑丒 != 1152921505210576912);
    
    }
    internal static void 丘与丗丆专丘丞丂丞(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.丛东丕丑下丂丆丑丒, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丛东丕丑下丂丆丑丒 != 1152921505210576912);
    
    }
    internal static void 丆丗丛与世丈业三丕(System.Action<int, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.丂万与丟丅丄丂七下, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丂万与丟丅丄丂七下 != 1152921505210576920);
    
    }
    internal static void 专东丟丅不丂丅丝且(System.Action<int, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.丂万与丟丅丄丂七下, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丂万与丟丅丄丂七下 != 1152921505210576920);
    
    }
    internal static void 丗丂万世上世丂三丆(System.Action<int, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.丑三丕不万与与丁万, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丑三丕不万与与丁万 != 1152921505210576928);
    
    }
    internal static void 丛不丝丂且丅丕丈丘(System.Action<int, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.丑三丕不万与与丁万, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丑三丕不万与与丁万 != 1152921505210576928);
    
    }
    internal static void 不丝与丙丗丁丞专丅(System.Action<int, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.丙丑不丄不丗不丟丒, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丙丑不丄不丗不丟丒 != 1152921505210576936);
    
    }
    internal static void 丂丕与业不上丙丒且(System.Action<int, float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.丙丑不丄不丗不丟丒, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丙丑不丄不丗不丟丒 != 1152921505210576936);
    
    }
    internal static void 与丆丗丞丟七丙与七(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.丝丑丅丟三丈丏丌东, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丝丑丅丟三丈丏丌东 != 1152921505210576944);
    
    }
    internal static void 专万丒丛三丗专丈业(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.丝丑丅丟三丈丏丌东, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丝丑丅丟三丈丏丌东 != 1152921505210576944);
    
    }
    internal static void 世丘丏且丅丒丝七丈(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.丗丝专丗七业专专丛, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丗丝专丗七业专专丛 != 1152921505210576952);
    
    }
    internal static void 丝丅丙且且丈丑丐丝(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.丗丝专丗七业专专丛, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丗丝专丗七业专专丛 != 1152921505210576952);
    
    }
    internal static void 业一且丄下丏丑且丒(out int 丒专丑上且丟丌丝七, out int 万丄丞丘上丏丒七丆)
    {
        丒专丑上且丟丌丝七 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  "TicketsCurrency", arg1:  0), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        万丄丞丘上丏丒七丆 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  "TicketsCurrency", arg1:  1), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    internal static int 丈丐业丈丄丕丕三世()
    {
        BankController.业一且丄下丏丑且丒(丒专丑上且丟丌丝七: out  0, 万丄丞丘上丏丒七丆: out  0);
        return 0;
    }
    internal static void 东丂下丞世丒丆丝丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.丆七丂丂丂一三世丘, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丆七丂丂丂一三世丘 != 1152921505210576960);
    
    }
    internal static void 且丆专丗与下专丞丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.丆七丂丂丂一三世丘, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丆七丂丂丂一三世丘 != 1152921505210576960);
    
    }
    internal static void 丅七丕下丏专上世丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.丅丆丟不丅丘丆丝丝, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丅丆丟不丅丘丆丝丝 != 1152921505210576968);
    
    }
    internal static void 业丅丐与丗三七一且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.丅丆丟不丅丘丆丝丝, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.丅丆丟不丅丘丆丝丝 != 1152921505210576968);
    
    }
    internal static void 丁下丂丒万一下七且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BankController.三丕业东丛丐三丑丗, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.三丕业东丛丐三丑丗 != 1152921505210576976);
    
    }
    internal static void 与丄丅丘且丟世丗丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BankController.三丕业东丛丐三丑丗, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BankController.三丕业东丛丐三丑丗 != 1152921505210576976);
    
    }
    internal static void 且丗丛丏丂丒世丒业()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = BankController.三丕业东丛丐三丑丗;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = BankController.三丕业东丛丐三丑丗;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    internal static bool 丈专丄丐专丗专与丙(丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞, bool 不丐下上且万丈七丒 = True, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 世丁丙世丄一万丆三 = 0)
    {
        var val_14;
        var val_15;
        string val_16;
        val_14 = 不丐下上且万丈七丒;
        if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业())) == false)
        {
            goto label_2;
        }
        
        string val_4 = Rilisoft.三一丈七且丄与丝东.丝丌丛丂且一丑上丌(丈上下与丌丘丅丙丒:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业());
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == false)
        {
            goto label_8;
        }
        
        UnityEngine.Debug.LogError(message:  "Add event currency fail: current event not setted");
        val_15 = 0;
        return (bool)val_15;
        label_2:
        if(丒世丘丘上丆丝东丞 == null)
        {
            goto label_14;
        }
        
        val_16 = 丒世丘丘上丆丝东丞.东与三丌丅三丒丏业();
        goto label_15;
        label_8:
        if(val_14 != false)
        {
                val_14 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_14.丝丟丈丂世且七丆丆(丞且丅三三东不丄且:  -丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世(), 丟丟丄专上丟丁丐丝:  val_4, 世丁丙世丄一万丆三:  0);
        }
        
        label_27:
        if(丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世() != 0)
        {
                BankController.且丗丛丏丂丒世丒业();
        }
        
        val_15 = 1;
        return (bool)val_15;
        label_14:
        val_16 = 0.东与三丌丅三丒丏业();
        label_15:
        bool val_13 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丑丌丗丄丅丑丌下(丏丂不专上丘丂不丅:  val_16, 丘专丌上丈东丕丏丘:  丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世(), 世丁丙世丄一万丆三:  世丁丙世丄一万丆三);
        if(丒世丘丘上丆丝东丞 != null)
        {
            goto label_27;
        }
        
        goto label_27;
    }
    internal static bool 丑丏与东丁丐丑丞丞(丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞)
    {
        var val_8;
        if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业())) == false)
        {
                return (bool)((Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业())) >= 丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世()) ? 1 : 0;
        }
        
        val_8 = 0;
        return (bool)((Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业())) >= 丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世()) ? 1 : 0;
    }
    internal static void 七三上丛下丙东三三()
    {
    
    }
    internal void 丌丏丕下丐专丁丝丈(System.EventHandler 丙业与丙丗丝不丈东)
    {
        if(this.bankViewCommon != 0)
        {
                this.bankViewCommon.add_BackButtonPressed(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        
        this.且丁丈丂丟专丆一业(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    internal void 万一丂不丟丟丄丕丝(System.EventHandler 丙业与丙丗丝不丈东)
    {
        if(this.bankViewCommon != 0)
        {
                this.bankViewCommon.remove_BackButtonPressed(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        
        this.丙丌万七一丒丂三与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    internal void 丑万七一上丕业丗丒(bool 丝三丄专丗丞丄丄丌, string 丆丟七丝丏业丅上丄, bool 丁丕丈丏且丕丒丞丏 = False, string 世丁丙世丄一万丆三 = "")
    {
        if(丝三丄专丗丞丄丄丌 != false)
        {
                if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  丆丟七丝丏业丅上丄, 万丆丛世丈上丕东丗:  this.业丗丆丂专下三丑丗(), 世丁丙世丄一万丆三:  世丁丙世丄一万丆三, 丙丙专丝专上丅丛丏:  丁丕丈丏且丕丒丞丏, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
            return;
        }
        
        }
        
        丝三丄专丗丞丄丄丌 = 丝三丄专丗丞丄丄丌;
        丁丕丈丏且丕丒丞丏 = 丁丕丈丏且丕丒丞丏;
        this.上丂丐且专丂丘丘业(丝三丄专丗丞丄丄丌:  丝三丄专丗丞丄丄丌, 丆丟七丝丏业丅上丄:  丆丟七丝丏业丅上丄, 丁丕丈丏且丕丒丞丏:  丁丕丈丏且丕丒丞丏, 世丁丙世丄一万丆三:  世丁丙世丄一万丆三);
    }
    internal void 上丂丐且专丂丘丘业(bool 丝三丄专丗丞丄丄丌, string 丆丟七丝丏业丅上丄, bool 丁丕丈丏且丕丒丞丏 = False, string 世丁丙世丄一万丆三 = "")
    {
        var val_19;
        System.Action val_20;
        var val_21;
        System.Action<System.Boolean> val_23;
        var val_24;
        var val_25;
        var val_26;
        MainMenuController val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        if(丝三丄专丗丞丄丄丌 == false)
        {
            goto label_1;
        }
        
        Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且丛丕业丞万东七丒(丁丅丈丌丟世丗丗丟:  new System.Nullable<OfferModule>() {HasValue = false}, 丙三丈与东三东世丏:  false, 丆丄丘丂业丛七丁且:  true);
        val_19 = null;
        val_19 = null;
        val_20 = BankController.丆七丂丂丂一三世丘;
        if(val_20 != null)
        {
                val_20 = BankController.丆七丂丂丂一三世丘;
            if(val_20 == null)
        {
                val_20 = 0;
        }
        
            val_20.Invoke();
        }
        
        if((((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11) || (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)) || (coinsShop.七三丗丏丑丗三丆世() == true)) || (Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅() == true))
        {
            goto label_35;
        }
        
        UnityEngine.Debug.Log(message:  "[BankController] SetInterfaceEnable_dWithDesiredCurrency => Authentica_teForced");
        val_21 = null;
        val_21 = null;
        val_23 = BankController.<>c.<>9__94_0;
        if(val_23 == null)
        {
                System.Action<System.Boolean> val_8 = null;
            val_23 = val_8;
            val_8 = new System.Action<System.Boolean>(object:  BankController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BankController.<>c::七上丅丞三丝丙专丑(bool 丐万丗丒下七丟丁三));
            BankController.<>c.<>9__94_0 = val_23;
        }
        
        Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丛丗上丝业下不丈丟(业丏丈世世世丞丒世:  val_8, 与且专丏丅世丐丐丑:  true);
        goto label_35;
        label_1:
        val_24 = null;
        val_24 = null;
        if(BankController.丅丆丟不丅丘丆丝丝 != null)
        {
                this.丏三三不一丘上七且(丐万丂丞万丌丐丞世:  0);
            val_25 = null;
            val_25 = null;
            BankController.丅丆丟不丅丘丆丝丝.Invoke();
        }
        
        label_35:
        val_26 = null;
        val_26 = null;
        val_27 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_27 != 0)
        {
                val_28 = null;
            val_28 = null;
            val_27 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_27.一丑丟世丛丌丁下不() != true)
        {
                val_29 = null;
            if(丝三丄专丗丞丄丄丌 != false)
        {
                val_30 = null;
            this.万丆丒七丑不丈世丈 = MainMenuController.丄丞丁丈与业上丞丟.gameObject.activeSelf;
            val_27 = MainMenuController.丄丞丁丈与业上丞丟.gameObject;
            val_31 = 0;
        }
        else
        {
                val_32 = null;
            val_27 = MainMenuController.丄丞丁丈与业上丞丟.gameObject;
        }
        
            val_27.SetActive(value:  (this.万丆丒七丑不丈世丈 == true) ? 1 : 0);
        }
        
        }
        
        this.丁不业丒专丌丘丙专(业丄业丕丑丞丒丑丏:  this.bankViewCommon, 丙业与丙丗丝不丈东:  丝三丄专丗丞丄丄丌, 丆丟七丝丏业丅上丄:  丆丟七丝丏业丅上丄, 丁丕丈丏且丕丒丞丏:  丁丕丈丏且丕丒丞丏);
    }
    private void 丁不业丒专丌丘丙专(AbstractBankView 业丄业丕丑丞丒丑丏, bool 丙业与丙丗丝不丈东, string 丆丟七丝丏业丅上丄, bool 丁丕丈丏且丕丒丞丏)
    {
        var val_22;
        object val_23;
        var val_25;
        bool val_26;
        var val_27;
        var val_28;
        var val_29;
        val_23 = this;
        if((丙业与丙丗丝不丈东 != true) && (this.丐丆七且丞丏下三丙 != null))
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        this.丟丙丙万与东业丑丗 = true;
        if(this.audioListenerForClans == 0)
        {
            goto label_9;
        }
        
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_10;
        }
        
        val_25 = null;
        val_25 = null;
        val_26 = UnityEngine.Object.op_Inequality(x:  MainMenuController.丄丞丁丈与业上丞丟, y:  0);
        if(this.audioListenerForClans != null)
        {
            goto label_55;
        }
        
        label_56:
        label_55:
        this.audioListenerForClans.enabled = val_26;
        label_9:
        int val_23 = this.不丅万丛丝上三不与;
        val_23 = val_23 + 1;
        this.不丅万丛丝上三不与 = val_23;
        if(丙业与丙丗丝不丈东 != false)
        {
                if(this.丝丘业丗丝世万下万 != true)
        {
                this.丝丘业丗丝世万下万 = true;
            this.丞与丏七丈丒七丈万 = UnityEngine.Time.realtimeSinceStartup;
        }
        
            this.上丏业世不东且丁且(丄丙丞丁世上丄与与:  0);
        }
        
        if(业丄业丕丑丞丒丑丏 != this.丅与丂丏丄丟丆丄丘)
        {
                if(this.丅与丂丏丄丟丆丄丘 != 0)
        {
                this.丅与丂丏丄丟丆丄丘.gameObject.SetActive(value:  false);
            this.丅与丂丏丄丟丆丄丘 = 0;
        }
        
        }
        
        if(业丄业丕丑丞丒丑丏 != 0)
        {
                if(丙业与丙丗丝不丈东 != false)
        {
                业丄业丕丑丞丒丑丏.DesiredCurrency = 丆丟七丝丏业丅上丄;
            业丄业丕丑丞丒丑丏.CurrencyThatNotEnough = (丁丕丈丏且丕丒丞丏 != true) ? 丆丟七丝丏业丅上丄 : 0;
        }
        
            业丄业丕丑丞丒丑丏.gameObject.SetActive(value:  丙业与丙丗丝不丈东);
            this.丅与丂丏丄丟丆丄丘 = (丙业与丙丗丝不丈东 != true) ? 业丄业丕丑丞丒丑丏 : 0;
        }
        
        this.uiRoot.SetActive(value:  丙业与丙丗丝不丈东);
        if(丙业与丙丗丝不丈东 != true)
        {
                ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        }
        
        FreeAwardShowHandler.万上业丄丈丁上东丟(丘丅七丝丒丐丝专七:  丙业与丙丗丝不丈东);
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_46;
        }
        
        val_27 = null;
        val_27 = null;
        coinsShop.专丆专上丗万世丒七.与不丌丗上不且专丗(丑丞东万丁丂丏万丙:  "BankController.SetInterface_EnabledCore()", 七丆丟丗世丟且丒丆:  false);
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
            goto label_46;
        }
        
        val_28 = 0;
        val_29 = 0;
        goto label_48;
        label_46:
        val_29 = 0;
        val_28 = 0;
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_49;
        }
        
        label_48:
        if(this.丐丆七且丞丏下三丙 == null)
        {
            goto label_50;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        goto label_54;
        label_10:
        if(this.audioListenerForClans != null)
        {
            goto label_55;
        }
        
        goto label_56;
        label_54:
        this.丐丆七且丞丏下三丙.Dispose();
        label_50:
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void BankController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Bank");
        label_49:
        if(东丗上丁下业一丂丂.专七与丏丞丁丅丈丟() != false)
        {
                ActivityIndicator.丁与丏东且与万丝下();
        }
        
        this.丟丙丙万与东业丑丗 = false;
        if(val_29 == 1)
        {
            goto label_65;
        }
        
        if((val_28 == 0) || (425 == 425))
        {
            goto label_67;
        }
        
        label_68:
        val_22 = ???;
        val_23 = ???;
        val_28 = ???;
        val_29 = ???;
        val_26 = ???;
        label_65:
        if(val_28 != 0)
        {
            goto label_68;
        }
        
        label_67:
        var val_21 = val_22 - 80;
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        this.丆丐丕丈业丛丆丐业 = true;
    }
    private void Awake()
    {
        BalanceController.丕丑丅丌丅一丅丏丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BankController::三丈丘丐世东七业丑()));
        一下丛与丛丛万万丏.丙且丝丕丙丟丁下丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void BankController::七丐丙丒不七业丏上(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
        Rilisoft.丗下丙丅且丐丞丙世.丒一丟东丛丌丏丏业(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.业丙丘丆东丈丕丂丄>(object:  this, method:  System.Void BankController::丘且且不世一丐丒丞(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)));
        丅且东丙业丏丛东丛.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BankController::丘丟万丌丄三丏丈业()));
    }
    private void 丘丟万丌丄三丏丈业()
    {
        if(this.上丙丆不丂丂丄一丂() == false)
        {
                return;
        }
        
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(AbstractBankView).__il2cppRuntimeField_198;
    }
    private void 七丐丙丒不七业丏上(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        this.万万丁下一丄七不丁 = -3.402823E+38f;
    }
    private void Start()
    {
        null = null;
        BankController.丝业丆丁业三丈丟东 = this;
        X10Manager.丄专丂专丑一丂丙丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BankController::丅丏丕丛且丒丒三七()));
        if(this.bankViewCommon != 0)
        {
                this.bankViewCommon.add_PurchaseButtonPressed(丙业与丙丗丝不丈东:  new System.Action<AbstractBankViewItem>(object:  this, method:  System.Void BankController::丕一丑丛且丌丑世丒(AbstractBankViewItem 下丅丙一丂丗丅丝七)));
            this.bankViewCommon.add_InfoButtonPressed(丙业与丙丗丝不丈东:  new System.Action<AbstractBankViewItem>(object:  this, method:  System.Void BankController::丞丐三丞下丈丅丌丌(AbstractBankViewItem 下丅丙一丂丗丅丝七)));
        }
        
        this.丟七丒丝三专且丑七(丙业与丙丗丝不丈东:  false);
    }
    private void 丅丏丕丛且丒丒三七()
    {
        if(this.上丙丆不丂丂丄一丂() == false)
        {
                return;
        }
        
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(AbstractBankView).__il2cppRuntimeField_198;
    }
    private void 三丈丘丐世东七业丑()
    {
        AbstractBankView val_14;
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_15;
        var val_16;
        var val_18;
        System.Collections.Generic.List<System.String> val_20;
        val_14 = this;
        if(BalanceController.下丂万丐丄丅七一东() != null)
        {
                val_15 = null;
            val_15 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>(collection:  BalanceController.下丂万丐丄丅七一东());
        }
        else
        {
                val_15 = 0;
        }
        
        this.丅且一七世丄丛三丁 = val_15;
        System.Collections.Generic.IEnumerable<Rilisoft.业丙丘丆东丈丕丂丄> val_5 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40);
        if(val_5 == null)
        {
            goto label_17;
        }
        
        val_16 = null;
        val_16 = null;
        val_15 = BankController.<>c.<>9__102_0;
        if(val_15 == null)
        {
                val_15 = null;
            val_15 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  BankController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankController.<>c::丑丈丙丅丗丛下丏下(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            BankController.<>c.<>9__102_0 = val_15;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_5, predicate:  null);
        if((val_7 == null) || ((System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_7)) == false))
        {
            goto label_17;
        }
        
        val_18 = null;
        val_18 = null;
        val_15 = BankController.<>c.<>9__102_1;
        if(val_15 == null)
        {
                val_15 = null;
            val_15 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.String>(object:  BankController.<>c.__il2cppRuntimeField_static_fields, method:  System.String BankController.<>c::丑一丘丟下丄丞丛丁(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            BankController.<>c.<>9__102_1 = val_15;
        }
        
        System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.业丙丘丆东丈丕丂丄, System.String>(source:  val_7, selector:  null));
        goto label_23;
        label_17:
        val_20 = 0;
        label_23:
        this.上不丈丘与丆上七丕 = val_20;
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
                return;
        }
        
        if(this.上丙丆不丂丂丄一丂() == false)
        {
                return;
        }
        
        val_14 = this.丅与丂丏丄丟丆丄丘;
    }
    private void 丘且且不世一丐丒丞(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
    {
        this.万万丁下一丄七不丁 = -3.402823E+38f;
    }
    private void 与丏丟业丒丂一三一()
    {
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
                return;
        }
        
        this = this.丅与丂丏丄丟丆丄丘;
    }
    private void 丄万专丏丛丅丟丞丗()
    {
    
    }
    private void 上丏业世不东且丁且(System.Action 丄丙丞丁世上丄与与)
    {
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_13;
        System.Collections.Generic.IEnumerable<TSource> val_14;
        var val_15;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_17;
        var val_19;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.String> val_21;
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = BalanceController.下丂万丐丄丅七一东();
        if((一下丛与丛丛万万丏.丘丐丁丑丂业丒丟丘(丈丂丕下丏丈丞丗业:  val_1, 丂丌丌丛丆丆丙丌丈:  this.丅且一七世丄丛三丁)) != true)
        {
                if(丄丙丞丁世上丄与与 != null)
        {
                丄丙丞丁世上丄与与.Invoke();
        }
        
            if(val_1 != null)
        {
                System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_3 = null;
            val_13 = val_3;
            val_3 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>(collection:  val_1);
        }
        else
        {
                val_13 = 0;
        }
        
            this.丅且一七世丄丛三丁 = val_13;
        }
        
        val_14 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40);
        if(val_14 != null)
        {
                val_15 = null;
            val_15 = null;
            val_17 = BankController.<>c.<>9__106_0;
            if(val_17 == null)
        {
                System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_6 = null;
            val_17 = val_6;
            val_6 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  BankController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankController.<>c::丗万万丟万丈丆下专(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            BankController.<>c.<>9__106_0 = val_17;
        }
        
            val_14 = System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_14, predicate:  val_6);
            if(val_14 != null)
        {
                val_19 = null;
            val_19 = null;
            val_21 = BankController.<>c.<>9__106_1;
            if(val_21 == null)
        {
                System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.String> val_8 = null;
            val_21 = val_8;
            val_8 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.String>(object:  BankController.<>c.__il2cppRuntimeField_static_fields, method:  System.String BankController.<>c::丌丟丘丑与且世上丏(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            BankController.<>c.<>9__106_1 = val_21;
        }
        
            val_14 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.业丙丘丆东丈丕丂丄, System.String>(source:  val_14, selector:  val_8));
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丂丆世世丕丅丕丅上<System.String>(丏丆丑丗七丄丙丝与:  this.上不丈丘与丆上七丕, 丒丈丙丐丏丕丆万丗:  val_14)) == true)
        {
                return;
        }
        
        if(丄丙丞丁世上丄与与 != null)
        {
                丄丙丞丁世上丄与与.Invoke();
        }
        
        if(val_14 == null)
        {
                return;
        }
        
        this.上不丈丘与丆上七丕 = System.Linq.Enumerable.ToList<System.String>(source:  val_14);
    }
    private void 丗丂不且丝丑不丂不()
    {
        new System.Action() = new System.Action(object:  this, method:  System.Void BankController::专丅丛七且丏丐丆三());
        this.上丏业世不东且丁且(丄丙丞丁世上丄与与:  new System.Action());
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 == true)
        {
                return;
        }
        
        this.万万丁下一丄七不丁 = UnityEngine.Time.realtimeSinceStartup;
    }
    private void Update()
    {
        var val_24;
        bool val_25;
        var val_26;
        var val_27;
        var val_28;
        if(this.上丙丆不丂丂丄一丂() == false)
        {
            goto label_1;
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() != 1)
        {
            goto label_4;
        }
        
        float val_3 = UnityEngine.Time.realtimeSinceStartup;
        val_3 = val_3 - this.万万丁下一丄七不丁;
        if(val_3 <= 10f)
        {
            goto label_5;
        }
        
        label_4:
        this.丗丂不且丝丑不丂不();
        label_5:
        int val_13 = System.String.alignConst;
        if((((FreeAwardController.丑七不且上丗丁一世() == 0) || ((System.String.op_Inequality(a:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐(), b:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗())) == true)) || (FriendsController.丝丗专上三不丄丑丑() == 1)) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  164)) == false))
        {
            goto label_16;
        }
        
        if((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丒丒丟丄业丆丆三丐(丁丂丕与丁丒丕丟丞: out  val_13)) == true)
        {
            goto label_50;
        }
        
        if(this.丌且丝丄丂丛且丛世.世三丞丅丑丌丈丈一() == false)
        {
            goto label_22;
        }
        
        val_24 = "Time tampering detected.";
        goto label_50;
        label_1:
        val_25 = this.丆丐丕丈业丛丆丐业;
        goto label_24;
        label_16:
        label_51:
        this.丟七丒丝三专且丑七(丙业与丙丗丝不丈东:  false);
        label_50:
        if((System.String.IsNullOrEmpty(value:  val_13)) != true)
        {
                this.丟七丒丝三专且丑七(丙业与丙丗丝不丈东:  false);
            if((System.String.op_Inequality(a:  val_13, b:  this.丕丂丞丛丑与丛专丁)) != false)
        {
                object[] val_20 = new object[1];
            val_20[0] = val_13;
            UnityEngine.Debug.LogFormat(format:  (UnityEngine.Application.isEditor != true) ? "<color=magenta>Dismissing interstitial. {0}</color>" : "Dismissing interstitial. {0}", args:  val_20);
            this.丕丂丞丛丑与丛专丁 = val_13;
        }
        
        }
        
        this.下丘业下上业不丘丗(丂与丝专丟三丐丁一:  this.bankViewCommon);
        val_25 = this;
        if(this.世丐与一丛业丆专丝 == null)
        {
                return;
        }
        
        if(this.丆丐丕丈业丛丆丐业 == false)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        this.世丐与一丛业丆专丝.Invoke(sender:  this, e:  System.EventArgs.Empty);
        label_24:
        this.丆丐丕丈业丛丆丐业 = false;
        return;
        label_22:
        System.Nullable<System.DateTime> val_21 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(((-1022237960) & 1) == 0)
        {
            goto label_39;
        }
        
        val_27 = null;
        val_27 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
            goto label_51;
        }
        
        val_28 = null;
        val_28 = null;
        if(SquadController.丄丘七三上丕世丞业.inSquad == false)
        {
            goto label_51;
        }
        
        val_24 = "In Squad creation interface";
        goto label_50;
        label_39:
        val_24 = "Server time not received.";
        goto label_50;
    }
    private void LateUpdate()
    {
        var val_3;
        var val_4;
        if(this.上丙丆不丂丂丄一丂() == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        if(this.丟丙丙万与东业丑丗 != false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
    }
    private void 下丘业下上业不丘丗(AbstractBankView 丂与丝专丟三丐丁一)
    {
        coinsShop val_14;
        var val_15;
        var val_16;
        var val_17;
        UnityEngine.GameObject val_18;
        var val_19;
        bool val_20;
        if(丂与丝专丟三丐丁一 == 0)
        {
                return;
        }
        
        val_15 = 丂与丝专丟三丐丁一.gameObject;
        if(val_15.activeSelf == false)
        {
                return;
        }
        
        if(coinsShop.世丒丏上丘丁与丟丁() == false)
        {
            goto label_9;
        }
        
        if(丂与丝专丟三丐丁一 == null)
        {
            goto label_10;
        }
        
        丂与丝专丟三丐丁一.ConnectionProblemLabelEnabled = false;
        val_16 = 0;
        丂与丝专丟三丐丁一.CrackersWarningLabelEnabled = true;
        goto label_11;
        label_9:
        val_17 = null;
        val_17 = null;
        val_14 = coinsShop.专丆专上丗万世丒七;
        if(val_14 == 0)
        {
                return;
        }
        
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  StoreKitEventListener.三丘丈不丝丕丞东丌());
        val_18 = 丂与丝专丟三丐丁一.touchBlockObject;
        val_19 = 0;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  StoreKitEventListener.三丘丈不丝丕丞东丌());
        if(coinsShop.七三丗丏丑丗三丆世() == false)
        {
            goto label_26;
        }
        
        丂与丝专丟三丐丁一.ConnectionProblemLabelEnabled = false;
        goto label_27;
        label_10:
        0.ConnectionProblemLabelEnabled = false;
        val_16 = 0;
        0.CrackersWarningLabelEnabled = true;
        label_11:
        val_20 = 0;
        goto label_29;
        label_26:
        float val_11 = UnityEngine.Time.realtimeSinceStartup;
        val_11 = val_11 - this.丞与丏七丈丒七丈万;
        if(val_11 > 3f)
        {
                val_19 = 0;
            丂与丝专丟三丐丁一.ConnectionProblemLabelEnabled = true;
        }
        
        丂与丝专丟三丐丁一.PurchaseSuccessfulLabelEnabled = false;
        label_27:
        val_20 = StoreKitEventListener.丙丞丂丛东丞丟七不();
        label_29:
        丂与丝专丟三丐丁一.PurchaseSuccessfulLabelEnabled = val_20;
    }
    private void OnDestroy()
    {
        丅且东丙业丏丛东丛.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BankController::丘丟万丌丄三丏丈业()));
        X10Manager.东丑三丐业业业丄业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BankController::丅丏丕丛且丒丒三七()));
        if(this.bankViewCommon != 0)
        {
                this.bankViewCommon.remove_PurchaseButtonPressed(丙业与丙丗丝不丈东:  new System.Action<AbstractBankViewItem>(object:  this, method:  System.Void BankController::丕一丑丛且丌丑世丒(AbstractBankViewItem 下丅丙一丂丗丅丝七)));
            this.bankViewCommon.remove_InfoButtonPressed(丙业与丙丗丝不丈东:  new System.Action<AbstractBankViewItem>(object:  this, method:  System.Void BankController::丞丐三丞下丈丅丌丌(AbstractBankViewItem 下丅丙一丂丗丅丝七)));
        }
        
        BalanceController.不丄丌丝丘丕丝丁丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BankController::三丈丘丐世东七业丑()));
        一下丛与丛丛万万丏.丁丘世丁丝七且一丁(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void BankController::七丐丙丒不七业丏上(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
        Rilisoft.丗下丙丅且丐丞丙世.丘丙丏三世七丄一丘(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.业丙丘丆东丈丕丂丄>(object:  this, method:  System.Void BankController::丘且且不世一丐丒丞(Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)));
    }
    private void 丕一丑丛且丌丑世丒(AbstractBankViewItem 下丅丙一丂丗丅丝七)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_46 = this;
        BankController.丗且丝下东丘丆一万(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
    }
    private static void 丗且丝下东丘丆一万(AbstractBankViewItem 下丅丙一丂丗丅丝七)
    {
        var val_30;
        var val_31;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_33;
        var val_34;
        var val_37;
        int val_38;
        var val_39;
        object val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        string val_47;
        var val_48;
        var val_49;
        val_30 = 1152921505272713216;
        if(StoreKitEventListener.三丘丈不丝丕丞东丌() != false)
        {
                UnityEngine.Debug.Log(message:  "Cannot perform request while purchase is in progress.");
        }
        
        val_31 = null;
        val_31 = null;
        if(coinsShop.专丆专上丗万世丒七 == 0)
        {
            goto label_10;
        }
        
        if(下丅丙一丂丗丅丝七 == null)
        {
            goto label_11;
        }
        
        val_33 = 下丅丙一丂丗丅丝七.InappBonusParameters;
        val_34 = null;
        goto label_14;
        label_10:
        UnityEngine.Debug.LogErrorFormat(format:  "HandlePurchase_ButtonPressed coinsShop.thisScript == null", args:  System.Array.Empty<System.Object>());
        return;
        label_11:
        val_33 = 下丅丙一丂丗丅丝七.InappBonusParameters;
        一丅丌丁丙丈丙上丙 val_6 = 下丅丙一丂丗丅丝七.purchaseInfo.不业丙丒丂丞下丆丙();
        int val_7 = 下丅丙一丂丗丅丝七.purchaseInfo.业东丅东丌上丗丑不();
        if(val_6 == 0)
        {
            goto label_19;
        }
        
        if(val_6 != 1)
        {
            goto label_44;
        }
        
        val_37 = null;
        val_37 = null;
        System.Int32[] val_9 = 丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + (((long)(int)(val_7)) << 2);
        val_38 = mem[(丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + ((long)(int)(val_7)) << 2) + 32];
        val_38 = (丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + ((long)(int)(val_7)) << 2) + 32;
        if((丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  223, 世丈三丐丞一丒丛不:  val_38)) != 10)
        {
            goto label_44;
        }
        
        val_39 = null;
        val_39 = null;
        System.String[] val_11 = StoreKitEventListener.丒丕丗丑丕且丌丁丂 + (((long)(int)(val_7)) << 3);
        val_40 = mem[(StoreKitEventListener.丒丕丗丑丕且丌丁丂 + ((long)(int)(val_7)) << 3) + 32];
        val_40 = (StoreKitEventListener.丒丕丗丑丕且丌丁丂 + ((long)(int)(val_7)) << 3) + 32;
        val_41 = 丏丄丑上丛不丈且万.丒丂且不业丕丈丌一().丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  val_7);
        val_42 = 1;
        goto label_36;
        label_19:
        val_43 = null;
        val_43 = null;
        System.Int32[] val_15 = 丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + (((long)(int)(val_7)) << 2);
        val_38 = mem[(丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + ((long)(int)(val_7)) << 2) + 32];
        val_38 = (丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + ((long)(int)(val_7)) << 2) + 32;
        if((丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  247, 世丈三丐丞一丒丛不:  val_38)) != 10)
        {
            goto label_44;
        }
        
        val_44 = null;
        val_44 = null;
        System.String[] val_17 = StoreKitEventListener.业丝丐三上丈丛丂专 + (((long)(int)(val_7)) << 3);
        val_40 = mem[(StoreKitEventListener.业丝丐三上丈丛丂专 + ((long)(int)(val_7)) << 3) + 32];
        val_40 = (StoreKitEventListener.业丝丐三上丈丛丂专 + ((long)(int)(val_7)) << 3) + 32;
        val_41 = 丏丄丑上丛不丈且万.三丁七丞丐丆与丏三().丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  val_7);
        val_42 = 0;
        label_36:
        float val_29 = (float)val_41;
        val_29 = val_29 * 10f;
        int val_20 = UnityEngine.Mathf.RoundToInt(f:  val_29);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_21 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_30 = 1152921516595677584;
        null.Add(key:  "ID", value:  val_40);
        null.Add(key:  "action", value:  "multiplier");
        val_45 = null;
        if((val_42 & 1) != 0)
        {
                val_46 = null;
            val_47 = 1152921505171281160;
        }
        else
        {
                val_48 = null;
            val_47 = 1152921505171281152;
        }
        
        int val_22 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        val_38 = 0;
        null.Add(key:  val_47, value:  0);
        val_33 = null;
        label_44:
        if(下丅丙一丂丗丅丝七 == null)
        {
            goto label_112;
        }
        
        val_34 = null;
        label_14:
        label_112:
        val_49 = null;
        val_49 = null;
        coinsShop.专丆专上丗万世丒七.丌丆丙与丛专上东丌(一丒丆业丅七丛且丏:  下丅丙一丂丗丅丝七.purchaseInfo, 丈上上丟丟丏万丐且:  null);
    }
    private void 丞丐三丞下丈丅丌丌(AbstractBankViewItem 下丅丙一丂丗丅丝七)
    {
        object val_50;
        var val_83;
        object val_100;
        string val_101;
        string val_102;
        var val_103;
        AbstractBankViewItem val_104;
        System.Func<TSource, System.Boolean> val_105;
        var val_106;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_108;
        var val_109;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_111;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_113;
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_114;
        string val_115;
        string val_116;
        string val_117;
        var val_118;
        var val_119;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_120;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_121;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_122;
        var val_123;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_124;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_125;
        var val_126;
        var val_127;
        var val_128;
        var val_129;
        var val_130;
        var val_131;
        var val_133;
        var val_134;
        var val_137;
        Rilisoft.BankBannersHolder val_138;
        var val_139;
        var val_140;
        BankController.丛丘丗世丙丅下上与 val_1 = null;
        val_100 = val_1;
        val_1 = new BankController.丛丘丗世丙丅下上与();
        .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
        if(this._bannersHolder == 0)
        {
                return;
        }
        
        .丑丟业不丗丕丈丈一 = 0;
        val_101 = "";
        val_102 = "";
        Rilisoft.业丙丘丆东丈丕丂丄 val_3 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.Offer;
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七 == null)
        {
            goto label_6;
        }
        
        if(val_3 == null)
        {
            goto label_7;
        }
        
        label_11:
        .丑丟业不丗丕丈丈一 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.Offer;
        label_76:
        if(val_100 == null)
        {
            goto label_193;
        }
        
        label_192:
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一 != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_6:
        if(val_3 != null)
        {
            goto label_11;
        }
        
        label_7:
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters == null)
        {
            goto label_76;
        }
        
        val_103 = 1152921516630043280;
        bool val_7 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.ContainsKey(key:  "offer-id");
        System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters;
        if(val_8 == null)
        {
            goto label_16;
        }
        
        if(val_7 == false)
        {
            goto label_17;
        }
        
        label_75:
        object val_9 = val_8.Item["offer-id"];
        val_101 = "";
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == true)
        {
            goto label_76;
        }
        
        .丑丟业不丗丕丈丈一 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_9);
        if(val_100 != null)
        {
            goto label_192;
        }
        
        label_193:
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一 == null)
        {
            goto label_26;
        }
        
        label_27:
        val_104 = 0.丑且一丐东三不丈丝();
        if(val_104 != 40)
        {
            goto label_29;
        }
        
        val_105 = 0;
        System.Collections.Generic.List<Rilisoft.OfferItem> val_14 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一.丏与丅专三丙与丘丒();
        if(val_14 == null)
        {
            goto label_110;
        }
        
        val_105 = public static System.Boolean System.Linq.Enumerable::Any<Rilisoft.OfferItem>(System.Collections.Generic.IEnumerable<TSource> source);
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_14)) == false)
        {
            goto label_110;
        }
        
        val_103 = 1152921505210626048;
        val_106 = null;
        val_106 = null;
        val_108 = BankController.<>c.<>9__115_0;
        if(val_108 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_16 = null;
            val_108 = val_16;
            val_16 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BankController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankController.<>c::业丗丕丞丑丞业三丞(Rilisoft.OfferItem 东七上世万下丗丄丛));
            BankController.<>c.<>9__115_0 = val_108;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_14, predicate:  val_16)) == false)
        {
            goto label_37;
        }
        
        val_109 = null;
        val_109 = null;
        val_111 = BankController.<>c.<>9__115_1;
        if(val_111 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_18 = null;
            val_111 = val_18;
            val_18 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BankController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankController.<>c::丅万丗丆丒专下丅丛(Rilisoft.OfferItem 东七上世万下丗丄丛));
            BankController.<>c.<>9__115_1 = val_111;
        }
        
        val_105 = val_111;
        Rilisoft.OfferItem val_19 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_14, predicate:  val_18);
        goto label_43;
        label_26:
        val_104 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七;
        if(val_104.InappBonusParameters == null)
        {
            goto label_45;
        }
        
        System.Func<BannerWindow, System.Boolean> val_21 = null;
        val_104 = val_21;
        val_21 = new System.Func<BannerWindow, System.Boolean>(object:  val_1, method:  System.Boolean BankController.丛丘丗世丙丅下上与::上丒丙丅丈丐不丕丘(BannerWindow 丈丁丅丈丌三丕七丗));
        ButtonClickSound.丁业上丏不丕三丗不();
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一 != null)
        {
                val_102 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一;
        }
        
        val_100 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        PGCompany.Analytics.一业丗丆世世上丁且.丙丑丟丆丑世丁专丅(丆丛丑世下一丐且丕:  val_100, 丁丅丈丌丟世丗丗丟:  3, 丐丅丒专丛丏上与业:  val_102, 世丁丙世丄一万丆三:  val_101);
        label_181:
        this._bannersHolder.ShowBanner(丌丅丕一丛丛丄一万:  18, 下丒丕丕世三七丕丄:  val_21, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        return;
        label_29:
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一.丑且一丐东三不丈丝() == 110)
        {
                this.一丄一东丐丆丌丄丒();
            return;
        }
        
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一.丑且一丐东三不丈丝() != 130)
        {
            goto label_56;
        }
        
        BankController.丗丝丙一丄丌且丁丑 val_25 = new BankController.丗丝丙一丄丌且丁丑();
        Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_27 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_27 == null)
        {
            goto label_60;
        }
        
        val_113 = val_27.丗不丞一且丟丈丈丗();
        if(val_25 == null)
        {
            goto label_61;
        }
        
        label_117:
        .七丄丆丘丒与丐丘丅 = val_113;
        if(val_113 != null)
        {
            goto label_62;
        }
        
        return;
        label_45:
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        PGCompany.丘丒下东丗丏丁丅业 val_29 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.Product;
        Rilisoft.OfferItem val_30 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_29.Items);
        if(val_30 != null)
        {
                if(val_30.Type == 1160)
        {
                System.Func<BannerWindow, System.Boolean> val_32 = null;
            val_104 = val_32;
            val_32 = new System.Func<BannerWindow, System.Boolean>(object:  val_1, method:  System.Boolean BankController.丛丘丗世丙丅下上与::丕丘一丏丅且丅丐不(BannerWindow 丈丁丅丈丌三丕七丗));
            ButtonClickSound.丁业上丏不丕三丗不();
            this._bannersHolder.ShowBanner(丌丅丕一丛丛丄一万:  36, 下丒丕丕世三七丕丄:  val_32, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        
        }
        
        val_114 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        string val_34 = val_30.Id;
        goto label_74;
        label_16:
        if(val_7 == true)
        {
            goto label_75;
        }
        
        label_17:
        if((val_8.ContainsKey(key:  "ID")) == false)
        {
            goto label_76;
        }
        
        val_116 = System.String.Format(format:  "{0}", arg0:  (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.Item["ID"]);
        if(((BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.ContainsKey(key:  "action")) != false)
        {
                val_116 = val_116 + System.String.Format(format:  "_{0}", arg0:  (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.Item["action"])(System.String.Format(format:  "_{0}", arg0:  (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.Item["action"]));
        }
        
        val_117 = val_116 + "[";
        val_118 = null;
        val_118 = null;
        if(((BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.ContainsKey(key:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
            goto label_127;
        }
        
        val_119 = null;
        val_119 = null;
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.Item[与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄] != null)
        {
            goto label_95;
        }
        
        goto label_95;
        label_56:
        if((BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一.丑且一丐东三不丈丝() != 140)
        {
            goto label_97;
        }
        
        BankController.三丂丐三下且丘丛万 val_52 = new BankController.三丂丐三下且丘丛万();
        Rilisoft.Offers.丑与不丞丕丟世世丗 val_54 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_54 == null)
        {
            goto label_101;
        }
        
        val_120 = val_54.丗不丞一且丟丈丈丗();
        if(val_52 == null)
        {
            goto label_102;
        }
        
        label_122:
        .七丄丆丘丒与丐丘丅 = val_120;
        if(val_120 != null)
        {
            goto label_103;
        }
        
        return;
        label_37:
        val_105 = public static Rilisoft.OfferItem System.Linq.Enumerable::FirstOrDefault<Rilisoft.OfferItem>(System.Collections.Generic.IEnumerable<TSource> source);
        label_43:
        val_104 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_14);
        if(val_104 == null)
        {
            goto label_110;
        }
        
        .丅万丗上三不丙丆丒 = Rilisoft.Offers.上一丈丏三丒三丙不.丙丈一丒三丁七丝一(丟专丑丈七与上七丞:  val_14);
        val_105 = this.uiRoot.transform;
        Rilisoft.ItemViewer val_60 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  val_105, 丏且丕丄丁丟丆丏丁:  val_104, 丗丟上上丒丐丗丞丙:  new ItemViewer.丕丈丏丑丌丂且万不(), 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
        goto label_110;
        label_97:
        ButtonClickSound.丁业上丏不丕三丗不();
        val_105 = 18;
        this._bannersHolder.ShowBanner(丌丅丕一丛丛丄一万:  18, 下丒丕丕世三七丕丄:  new System.Func<BannerWindow, System.Boolean>(object:  val_1, method:  System.Boolean BankController.丛丘丗世丙丅下上与::世丂丑上不丏三丟与(BannerWindow 丈丁丅丈丌三丕七丗)), 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        label_110:
        val_114 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        val_115 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].丑丟业不丗丕丈丈一;
        label_74:
        val_100 = val_115;
        PGCompany.Analytics.一业丗丆世世上丁且.丙丑丟丆丑世丁专丅(丆丛丑世下一丐且丕:  val_114, 丁丅丈丌丟世丗丗丟:  3, 丐丅丒专丛丏上与业:  val_100, 世丁丙世丄一万丆三:  "");
        return;
        label_60:
        val_121 = 0;
        if(val_25 != null)
        {
            goto label_117;
        }
        
        label_61:
        .七丄丆丘丒与丐丘丅 = val_121;
        val_122 = (BankController.丗丝丙一丄丌且丁丑)[1152921537946282336].七丄丆丘丒与丐丘丅;
        if(val_122 == null)
        {
                return;
        }
        
        label_62:
        if((System.Linq.Enumerable.Any<PGCompany.丒丌业一丕丘丐世专>(source:  val_122)) == false)
        {
                return;
        }
        
        BankController.丒丈万七丒东丑七丘 val_64 = new BankController.丒丈万七丒东丑七丘();
        if(val_64 == null)
        {
            goto label_120;
        }
        
        val_123 = val_64;
        .东丟且丗且三专丙丁 = val_25;
        goto label_121;
        label_101:
        val_124 = 0;
        if(val_52 != null)
        {
            goto label_122;
        }
        
        label_102:
        .七丄丆丘丒与丐丘丅 = val_124;
        val_125 = (BankController.三丂丐三下且丘丛万)[1152921537946413408].七丄丆丘丒与丐丘丅;
        if(val_125 == null)
        {
                return;
        }
        
        label_103:
        if((System.Linq.Enumerable.Any<PGCompany.丒丌业一丕丘丐世专>(source:  val_125)) == false)
        {
                return;
        }
        
        BankController.丑丝丌丙不丐丘世东 val_66 = new BankController.丑丝丌丙不丐丘世东();
        if(val_66 == null)
        {
            goto label_125;
        }
        
        val_126 = val_66;
        .丕丅丏丁丅东且七丌 = val_52;
        goto label_126;
        label_95:
        if((-1020482288) >= 1)
        {
                val_50 = null;
            val_117 = val_117 + System.String.Format(format:  "COINS_{0}", arg0:  val_50)(System.String.Format(format:  "COINS_{0}", arg0:  val_50));
        }
        
        label_127:
        val_127 = null;
        val_127 = null;
        if(((BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.ContainsKey(key:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                val_128 = null;
            val_128 = null;
            if((-1020482288) >= 1)
        {
                val_50 = null;
            val_117 = val_117 + System.String.Format(format:  ",GEMS_{0}", arg0:  val_50)(System.String.Format(format:  ",GEMS_{0}", arg0:  val_50));
        }
        
        }
        
        if(((BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.ContainsKey(key:  "bonuses")) == false)
        {
            goto label_195;
        }
        
        object val_78 = (BankController.丛丘丗世丙丅下上与)[1152921537946151264].下丅丙一丂丗丅丝七.InappBonusParameters.Item["bonuses"];
        if(val_78 == null)
        {
            goto label_195;
        }
        
        List.Enumerator<T> val_79 = val_78.GetEnumerator();
        val_129 = 0;
        val_130 = 0;
        label_173:
        if(((-1020482320) & 1) == 0)
        {
            goto label_149;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_82 = val_50.丐丏七丌丕丗业且上().GetEnumerator();
        val_131 = val_117;
        goto label_155;
        label_158:
        ConfiguredValueTaskAwaiter val_86 = val_83.GetAwaiter();
        string val_89 = val_117 + System.String.Format(format:  ",{0}_{1}", arg0:  val_86._value._obj.丐丏七丌丕丗业且上(), arg1:  val_86._value._obj)(System.String.Format(format:  ",{0}_{1}", arg0:  val_86._value._obj.丐丏七丌丕丗业且上(), arg1:  val_86._value._obj));
        label_155:
        if(((-1020482368) & 1) != 0)
        {
            goto label_158;
        }
        
        val_133 = 0;
        val_134 =  + 1;
        mem2[0] = 704;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_134 == 1) || ((1152921537946101728 + ((val_130 + 1)) << 2) != 704))
        {
            goto label_170;
        }
        
        var val_100 = 0;
        val_100 = val_100 ^ (val_134 >> 31);
        val_134 = val_134 + val_100;
        goto label_173;
        label_170:
        if( == 0)
        {
            goto label_173;
        }
        
        goto label_173;
        label_120:
        val_123 = 24;
        mem[24] = val_25;
        label_121:
        .丗丈丒丐丌丙丏丆世 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丒丌业一丕丘丐世专>(source:  .七丄丆丘丒与丐丘丅, predicate:  new System.Func<PGCompany.丒丌业一丕丘丐世专, System.Boolean>(object:  val_1, method:  System.Boolean BankController.丛丘丗世丙丅下上与::丐不专丆七丌三丁东(PGCompany.丒丌业一丕丘丐世专 七丏丄丅丌业与且丙)));
        System.Func<BannerWindow, System.Boolean> val_95 = null;
        val_137 = val_95;
        val_95 = new System.Func<BannerWindow, System.Boolean>(object:  val_64, method:  System.Boolean BankController.丒丈万七丒东丑七丘::且丅业三丒与七丒不(BannerWindow 丈丁丅丈丌三丕七丗));
        val_138 = this._bannersHolder;
        if(val_138 != null)
        {
            goto label_181;
        }
        
        goto label_181;
        label_125:
        val_126 = 24;
        mem[24] = val_52;
        label_126:
        .丗丈丒丐丌丙丏丆世 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丒丌业一丕丘丐世专>(source:  .七丄丆丘丒与丐丘丅, predicate:  new System.Func<PGCompany.丒丌业一丕丘丐世专, System.Boolean>(object:  val_1, method:  System.Boolean BankController.丛丘丗世丙丅下上与::专下丛丆万一丌三丛(PGCompany.丒丌业一丕丘丐世专 七丏丄丅丌业与且丙)));
        System.Func<BannerWindow, System.Boolean> val_98 = null;
        val_137 = val_98;
        val_98 = new System.Func<BannerWindow, System.Boolean>(object:  val_66, method:  System.Boolean BankController.丑丝丌丙不丐丘世东::与丅丏与丞下丌丆与(BannerWindow 丈丁丅丈丌三丕七丗));
        val_138 = this._bannersHolder;
        goto label_181;
        label_149:
        val_139 = 0;
        val_140 = val_130 + 1;
        mem2[0] = 732;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_140 == 1)
        {
            goto label_189;
        }
        
        if(( == false) || ((1152921537946101728 + ((val_130 + 1)) << 2) == 732))
        {
            goto label_195;
        }
        
        label_194:
        label_195:
        string val_99 = val_117 + "]";
        if(val_100 != null)
        {
            goto label_192;
        }
        
        goto label_193;
        label_189:
        if( == true)
        {
            goto label_194;
        }
        
        goto label_195;
    }
    internal void 一丄一东丐丆丌丄丒()
    {
        if(东下丗世丘上丞世丛.丆不丁万丌丕丟与下() == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        this = this._bannersHolder;
        this.ShowBanner(丌丅丕一丛丛丄一万:  47, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    internal void 专万万一丁业丘下丕(BannerWindowType 丌丅丕一丛丛丄一万, System.Func<BannerWindow, bool> 下丒丕丕世三七丕丄, PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this._bannersHolder.ShowBanner(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 下丒丕丕世三七丕丄:  下丒丕丕世三七丕丄, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    internal static void 业丟不一三上七丆丕(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 丄东三丕丟丅不丌丄 = 0, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 丟世且丕丂丁万丒万 = 0)
    {
        var val_17;
        var val_18;
        val_17 = null;
        val_17 = null;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
        {
                BankController.丒丘上丟下丅丑丅丄(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丛丞万三下丘七丌丅:  丛丞万三下丘七丌丅, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东, 丄东三丕丟丅不丌丄:  丄东三丕丟丅不丌丄, 丟世且丕丂丁万丒万:  丟世且丕丂丁万丒万);
            return;
        }
        
        val_18 = null;
        val_18 = null;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                BankController.丐丙东东不丛丂上丛(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丛丞万三下丘七丌丅:  丛丞万三下丘七丌丅, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东, 丄东三丕丟丅不丌丄:  丄东三丕丟丅不丌丄, 丟世且丕丂丁万丒万:  丟世且丕丂丁万丒万);
            return;
        }
        
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "EventCurrency")) != false)
        {
                bool val_7 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丛丞万三下丘七丌丅:  丛丞万三下丘七丌丅, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东, 丟丟丄专上丟丁丐丝:  0);
            return;
        }
        
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "BattlePassCurrency")) != false)
        {
                bool val_10 = BankController.东一且丝万一丆七丘(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 三上丆世丞丏丁一上:  0, 丛丞万三下丘七丌丅:  丛丞万三下丘七丌丅, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
            return;
        }
        
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "CraftCurrency")) != false)
        {
                bool val_13 = BankController.三上丗丆丕东三一丘(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 三上丆世丞丏丁一上:  0, 丛丞万三下丘七丌丅:  丛丞万三下丘七丌丅, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
            return;
        }
        
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "Coupons")) == false)
        {
                return;
        }
        
        bool val_16 = BankController.丟三世丛东三丝丁丌(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 三上丆世丞丏丁一上:  0, 丛丞万三下丘七丌丅:  丛丞万三下丘七丌丅, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
    }
    internal static void 丒丘上丟下丅丑丅丄(int 丌丒丝东丌下丕丁丅, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 丄东三丕丟丅不丌丄 = 0, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 丟世且丕丂丁万丒万 = 0)
    {
        var val_6;
        var val_7;
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                val_6 = null;
            val_6 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丗世丈丂丒丞专上丟:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  丄东三丕丟丅不丌丄, 丛丞万三下丘七丌丅:  丛丞万三下丘七丌丅);
            Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
            return;
        }
        
        val_7 = null;
        val_7 = null;
        bool val_5 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丑丌丗丄丅丑丌下(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丘专丌上丈东丕丏丘:  (丌丒丝东丌下丕丁丅 < 0) ? (-丌丒丝东丌下丕丁丅) : 丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  丟世且丕丂丁万丒万);
    }
    internal static void 丐丙东东不丛丂上丛(int 丌丒丝东丌下丕丁丅, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 丄东三丕丟丅不丌丄 = 0, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 丟世且丕丂丁万丒万 = 0)
    {
        string val_6;
        bool val_7;
        var val_8;
        var val_9;
        var val_10;
        System.Action<System.Int32> val_11;
        val_6 = 丟世且丕丂丁万丒万;
        val_7 = 丛丞万三下丘七丌丅;
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                Progress.下丁下丂七丆丙七一 val_1 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_8 = null;
            val_8 = null;
            val_1.业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丗世丈丂丒丞专上丟:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  丄东三丕丟丅不丌丄, 丛丞万三下丘七丌丅:  val_7);
            val_6 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  val_6, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        }
        else
        {
                val_9 = null;
            val_9 = null;
            bool val_5 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丑丌丗丄丅丑丌下(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丘专丌上丈东丕丏丘:  (丌丒丝东丌下丕丁丅 < 0) ? (-丌丒丝东丌下丕丁丅) : 丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  val_6);
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = BankController.丝丑丅丟三丈丏丌东;
        if(val_11 == null)
        {
                return;
        }
        
        val_11 = BankController.丝丑丅丟三丈丏丌东;
        if(val_11 == null)
        {
                val_11 = 0;
        }
        
        val_11.Invoke(obj:  丌丒丝东丌下丕丁丅);
    }
    internal static int 丒丈丁七丗丁丗一丐()
    {
        var val_2;
        Progress.丑丅专一业丙丝丄丁 val_1 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        val_2 = null;
        val_2 = null;
        if(val_1 != null)
        {
                return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        }
        
        return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
    }
    internal static int 七丐三丑上丘且丛丛()
    {
        var val_2;
        Progress.丑丅专一业丙丝丄丁 val_1 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        val_2 = null;
        val_2 = null;
        if(val_1 != null)
        {
                return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        }
        
        return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
    }
    internal static System.Collections.IEnumerator 世丌丄与丁丈且且丂(string 丏丂不专上丘丂不丅)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丏丂不专上丘丂不丅 = 丏丂不专上丘丂不丅;
        return (System.Collections.IEnumerator)new BankController.与且丒东丒丛丗上丂();
    }
    private void 且丁丈丂丟专丆一业(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.世丐与一丛业丆专丝, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世丐与一丛业丆专丝 != 1152921537947955232);
    
    }
    private void 丙丌万七一丒丂三与(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.世丐与一丛业丆专丝, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.世丐与一丛业丆专丝 != 1152921537948091808);
    
    }
    internal static string 丙不丒丒且世丆下丐(string 丏丂不专上丘丂不丅, int 世与丂且丘丐万丗丞)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = UnityEngine.Mathf.Clamp(value:  世与丂且丘丐万丗丞, min:  1, max:  7);
        val_9 = null;
        val_9 = null;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                val_10 = "Textures/Bank/Coins_Shop_Gem_";
            return (string)System.String.Format(format:  "{0}{1}", arg0:  (val_4 != true) ? "Textures/Bank/Coins_Shop_Coupons_" : 0, arg1:  (val_4 != true) ? 2 : (val_8));
        }
        
        val_11 = null;
        val_11 = null;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
        {
                val_10 = "Textures/Bank/Coins_Shop_";
            return (string)System.String.Format(format:  "{0}{1}", arg0:  (val_4 != true) ? "Textures/Bank/Coins_Shop_Coupons_" : 0, arg1:  (val_4 != true) ? 2 : (val_8));
        }
        
        bool val_4 = System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "Coupons");
        return (string)System.String.Format(format:  "{0}{1}", arg0:  (val_4 != true) ? "Textures/Bank/Coins_Shop_Coupons_" : 0, arg1:  (val_4 != true) ? 2 : (val_8));
    }
    internal static string 东专丞丄丙业专丁丝(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                val_7 = "Key_0951";
            return System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丒丝东丌下丕丁丅), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? "Key_0275" : 0));
        }
        
        val_8 = null;
        val_8 = null;
        return System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丒丝东丌下丕丁丅), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != true) ? "Key_0275" : 0));
    }
    internal void 丏丈丁丌丈丅丙且丒(Rilisoft.业丙丘丆东丈丕丂丄 不专一业下丞丝丑丗)
    {
        if(不专一业下丞丝丑丗 == null)
        {
                return;
        }
        
        if(不专一业下丞丝丑丗.丁专丗万三上丟三丆() == null)
        {
                return;
        }
        
        this.丅丒丏丘世丏上上世 = 不专一业下丞丝丑丗;
        this.PreviewOfferPackController.业东丑丅丆三丕丏一(不专一业下丞丝丑丗:  不专一业下丞丝丑丗);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._bannersHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.bankViewCommon, 丏业丟一东丂东丘丛:  false);
        this = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(this == 0)
        {
                return;
        }
        
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  false, 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
    }
    internal void 上丌万丛东丒丝丞丁(bool 丑三三下一丝丞丐世)
    {
        if(丑三三下一丝丞丐世 != false)
        {
                Rilisoft.业丙丘丆东丈丕丂丄 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丐上丙世丂丅丝不丈(丁丅丈丌丟世丗丗丟:  120);
            if((val_2 != null) && (val_2 == this.丅丒丏丘世丏上上世))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._bannersHolder, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        this.丅丒丏丘世丏上上世 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.bankViewCommon, 丏业丟一东丂东丘丛:  true);
    }
    internal static int 七丞且七一丑下丒丞()
    {
        Progress.丑丅专一业丙丝丄丁 val_1 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        if(val_1 != null)
        {
                return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  "BattlePassCurrency");
        }
        
        return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  "BattlePassCurrency");
    }
    internal static bool 东一且丝万一丆七丘(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        bool val_2 = BankController.东一且丝万一丆七丘(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 三上丆世丞丏丁一上:  三上丆世丞丏丁一上, 丕丕世且下一与丝与:  (丛丞万三下丘七丌丅 != true) ? 0f : -1f, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        return true;
    }
    internal static bool 东一且丝万一丆七丘(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, float 丕丕世且下一与丝与, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  "BattlePassCurrency", 丗世丈丂丒丞专上丟:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  三上丆世丞丏丁一上, 丛丞万三下丘七丌丅:  false);
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "BattlePassCurrency", 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        }
        
        if(丕丕世且下一与丝与 < 0f)
        {
                return true;
        }
        
        BankController.丒丙东不上丟丑业丏(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丕丕世且下一与丝与:  丕丕世且下一与丝与);
        return true;
    }
    internal static bool 丄丑专万业丗下万丈(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 三上丆世丞丏丁一上)
    {
        bool val_2 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丑丌丗丄丅丑丌下(丏丂不专上丘丂不丅:  "BattlePassCurrency", 丘专丌上丈东丕丏丘:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  三上丆世丞丏丁一上);
        return true;
    }
    private static void 丒丙东不上丟丑业丏(int 丌丒丝东丌下丕丁丅, float 丕丕世且下一与丝与 = 0)
    {
        null = null;
        if(BankController.丂万与丟丅丄丂七下 == null)
        {
                return;
        }
        
        BankController.丂万与丟丅丄丂七下.Invoke(arg1:  丌丒丝东丌下丕丁丅, arg2:  丕丕世且下一与丝与);
    }
    internal static bool 丛丅世丘丁三世丁丘(out int 丐丏业不下丟丂世丞, out int 东丟丑万丐丏三七万, string 丟丟丄专上丟丁丐丝)
    {
        string val_8;
        object val_9;
        val_8 = 丟丟丄专上丟丁丐丝;
        丐丏业不下丟丂世丞 = 0;
        东丟丑万丐丏三七万 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) != false)
        {
                val_8 = Rilisoft.三一丈七且丄与丝东.丝丌丛丂且一丑上丌(且下丕七丙丗丄不七:  100);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) != false)
        {
                val_9 = 0;
            return (bool)val_9;
        }
        
        }
        
        丐丏业不下丟丂世丞 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}_{2}", arg0:  "EventCurrency", arg1:  val_8, arg2:  0), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        val_9 = 1;
        东丟丑万丐丏三七万 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}_{2}", arg0:  "EventCurrency", arg1:  val_8, arg2:  val_9), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        return (bool)val_9;
    }
    internal static int 且七七丝丏与丏丌丆(string 丟丟丄专上丟丁丐丝)
    {
        string val_5 = 丟丟丄专上丟丁丐丝;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5 = 丟丟丄专上丟丁丐丝)) != false)
        {
                val_5 = Rilisoft.三一丈七且丄与丝东.丝丌丛丂且一丑上丌(且下丕七丙丗丄不七:  100);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) != false)
        {
                return 0;
        }
        
        }
        
        Progress.丕丞七世丒丐下七一 val_4 = Progress.七七世万专丕丁上业.不世丗丞丙丅丐丙丁();
        if(val_4 != null)
        {
                return val_4.三业丈世丐丒丐丒丅(丟丟丄专上丟丁丐丝:  val_5);
        }
        
        return val_4.三业丈世丐丒丐丒丅(丟丟丄专上丟丁丐丝:  val_5);
    }
    internal static bool 上且丅专丟丄且丅上(int 丌丒丝东丌下丕丁丅, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0, string 丟丟丄专上丟丁丐丝)
    {
        string val_5;
        var val_6;
        val_5 = 丟丟丄专上丟丁丐丝;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) != false)
        {
                val_5 = Rilisoft.三一丈七且丄与丝东.丝丌丛丂且一丑上丌(且下丕七丙丗丄不七:  100);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) != false)
        {
                UnityEngine.Debug.LogError(message:  "Add event currency fail: current event not setted");
            val_6 = 0;
            return (bool)val_6;
        }
        
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丝丟丈丂世且七丆丆(丞且丅三三东不丄且:  丌丒丝东丌下丕丁丅, 丟丟丄专上丟丁丐丝:  val_5, 世丁丙世丄一万丆三:  0);
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "EventCurrency", 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        }
        
        if(丛丞万三下丘七丌丅 != false)
        {
                BankController.丂上三丄丞下业丌世(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
        }
        
        val_6 = 1;
        return (bool)val_6;
    }
    internal static bool 下三丕丒专丐丄不丈(string 丟丟丄专上丟丁丐丝)
    {
        var val_3;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丟丟丄专上丟丁丐丝)) != false)
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下三丕丒专丐丄不丈(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
        val_3 = 1;
        return (bool)val_3;
    }
    private static void 丂上三丄丞下业丌世(int 丌丒丝东丌下丕丁丅)
    {
        null = null;
        if(BankController.丛东丕丑下丂丆丑丒 == null)
        {
                return;
        }
        
        BankController.丛东丕丑下丂丆丑丒.Invoke(obj:  丌丒丝东丌下丕丁丅);
    }
    internal static int 万丗东七与上丗专丅()
    {
        Progress.丑丅专一业丙丝丄丁 val_1 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        if(val_1 != null)
        {
                return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  "CraftCurrency");
        }
        
        return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  "CraftCurrency");
    }
    internal static bool 三上丗丆丕东三一丘(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        bool val_2 = BankController.三上丗丆丕东三一丘(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 三上丆世丞丏丁一上:  三上丆世丞丏丁一上, 丕丕世且下一与丝与:  (丛丞万三下丘七丌丅 != true) ? 0f : -1f, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        return true;
    }
    internal static bool 三上丗丆丕东三一丘(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, float 丕丕世且下一与丝与, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  "CraftCurrency", 丗世丈丂丒丞专上丟:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  三上丆世丞丏丁一上, 丛丞万三下丘七丌丅:  false);
        Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "CraftCurrency", 丅丅丞丙丁丕丌世东:  0);
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "CraftCurrency", 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        }
        
        if(丕丕世且下一与丝与 >= 0f)
        {
                BankController.一丗丑丗丐丄丟丟丒(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丕丕世且下一与丝与:  丕丕世且下一与丝与);
        }
        
        BankController.且丗丛丏丂丒世丒业();
        return true;
    }
    internal static bool 世丗丙丘丐丈丛丏丙(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 三上丆世丞丏丁一上)
    {
        bool val_2 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丑丌丗丄丅丑丌下(丏丂不专上丘丂不丅:  "CraftCurrency", 丘专丌上丈东丕丏丘:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  三上丆世丞丏丁一上);
        return true;
    }
    private static void 一丗丑丗丐丄丟丟丒(int 丌丒丝东丌下丕丁丅, float 丕丕世且下一与丝与 = 0)
    {
        null = null;
        if(BankController.丑三丕不万与与丁万 == null)
        {
                return;
        }
        
        BankController.丑三丕不万与与丁万.Invoke(arg1:  丌丒丝东丌下丕丁丅, arg2:  丕丕世且下一与丝与);
    }
    internal static bool 丈专丐万丑专丒丗丂(丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三)
    {
        var val_4;
        if(万丐丏丐丒万不丟三 != null)
        {
                var val_3 = ((BankController.丞下丂下东东丅一七(万丐丏丐丒万不丟三:  万丐丏丐丒万不丟三)) >= 万丐丏丐丒万不丟三.丟丂丞不专丆万丒世()) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal static int 丞下丂下东东丅一七(丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三)
    {
        if(万丐丏丐丒万不丟三 == null)
        {
                return 0;
        }
        
        return BankController.丞下丂下东东丅一七(丏丂不专上丘丂不丅:  万丐丏丐丒万不丟三.东与三丌丅三丒丏业());
    }
    internal static int 丞下丂下东东丅一七(string 丏丂不专上丘丂不丅)
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
        {
                return BankController.丒丈丁七丗丁丗一丐();
        }
        
        val_8 = null;
        val_8 = null;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                return BankController.七丐三丑上丘且丛丛();
        }
        
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "CraftCurrency")) != false)
        {
                return BankController.万丗东七与上丗专丅();
        }
        
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "Coupons")) != false)
        {
                return BankController.丈三丝丌且丘丄专丗();
        }
        
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "BattlePassCurrency")) != false)
        {
                return BankController.七丞且七一丑下丒丞();
        }
        
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "EventCurrency")) == false)
        {
                return 0;
        }
        
        return BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  0);
    }
    internal static int 丈三丝丌且丘丄专丗()
    {
        Progress.丑丅专一业丙丝丄丁 val_1 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        if(val_1 != null)
        {
                return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  "Coupons");
        }
        
        return val_1.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  "Coupons");
    }
    internal static bool 丗上一上丙丅丐专丝(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        bool val_1 = BankController.丗上一上丙丅丐专丝(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 三上丆世丞丏丁一上:  三上丆世丞丏丁一上, 丕丕世且下一与丝与:  null, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        return true;
    }
    internal static bool 丗上一上丙丅丐专丝(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, float 丕丕世且下一与丝与, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  "ClanSilver", 丗世丈丂丒丞专上丟:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  三上丆世丞丏丁一上, 丛丞万三下丘七丌丅:  false);
        Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "ClanSilver", 丅丅丞丙丁丕丌世东:  0);
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "ClanSilver", 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        }
        
        BankController.且丗丛丏丂丒世丒业();
        return true;
    }
    internal static bool 不丞丑丙上三万三丕(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 三上丆世丞丏丁一上)
    {
        bool val_2 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丑丌丗丄丅丑丌下(丏丂不专上丘丂不丅:  "ClanSilver", 丘专丌上丈东丕丏丘:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  三上丆世丞丏丁一上);
        return true;
    }
    internal static bool 丘丛丕丐下丗世丅丆(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        bool val_1 = BankController.丘丛丕丐下丗世丅丆(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 三上丆世丞丏丁一上:  三上丆世丞丏丁一上, 丕丕世且下一与丝与:  null, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        return true;
    }
    internal static bool 丘丛丕丐下丗世丅丆(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, float 丕丕世且下一与丝与, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  "ClanLootBoxPoints");
        val_1.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  丌丒丝东丌下丕丁丅);
        PGCompany.丗丟丄丈东丝丕丄世 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_1, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "ClanLootBoxPoints", 丅丅丞丙丁丕丌世东:  0);
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "ClanLootBoxPoints", 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        }
        
        BankController.且丗丛丏丂丒世丒业();
        return true;
    }
    internal static bool 上丛丙与且不丁丗丙(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 三上丆世丞丏丁一上)
    {
        PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  "ClanLootBoxPoints");
        val_1.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  丌丒丝东丌下丕丁丅);
        PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().下且上丛丞一东不不(丈丄不七三万丄丁不:  val_1, 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
        return true;
    }
    internal static bool 丟三世丛东三丝丁丌(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, bool 丛丞万三下丘七丌丅 = True, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        bool val_2 = BankController.丟三世丛东三丝丁丌(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 三上丆世丞丏丁一上:  三上丆世丞丏丁一上, 丕丕世且下一与丝与:  (丛丞万三下丘七丌丅 != true) ? 0f : -1f, 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        return true;
    }
    internal static bool 丟三世丛东三丝丁丌(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 三上丆世丞丏丁一上, float 丕丕世且下一与丝与, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东 = 0)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  "Coupons", 丗世丈丂丒丞专上丟:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  三上丆世丞丏丁一上, 丛丞万三下丘七丌丅:  false);
        Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "Coupons", 丅丅丞丙丁丕丌世东:  0);
        if(丌丒丝东丌下丕丁丅 >= 1)
        {
                Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  丌丒丝东丌下丕丁丅, 丅不一丞丘丕丄丈丏:  "Coupons", 丅丅丞丙丁丕丌世东:  丅丅丞丙丁丕丌世东);
        }
        
        if(丕丕世且下一与丝与 >= 0f)
        {
                BankController.且一丈丑丁丌丂丐不(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丕丕世且下一与丝与:  丕丕世且下一与丝与);
        }
        
        BankController.且丗丛丏丂丒世丒业();
        return true;
    }
    internal static bool 一丛丕丅专丙丆不七(int 丌丒丝东丌下丕丁丅, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 三上丆世丞丏丁一上)
    {
        bool val_2 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丑丌丗丄丅丑丌下(丏丂不专上丘丂不丅:  "Coupons", 丘专丌上丈东丕丏丘:  丌丒丝东丌下丕丁丅, 世丁丙世丄一万丆三:  三上丆世丞丏丁一上);
        return true;
    }
    private static void 且一丈丑丁丌丂丐不(int 丌丒丝东丌下丕丁丅, float 丕丕世且下一与丝与 = 0)
    {
        null = null;
        if(BankController.丙丑不丄不丗不丟丒 == null)
        {
                return;
        }
        
        BankController.丙丑不丄不丗不丟丒.Invoke(arg1:  丌丒丝东丌下丕丁丅, arg2:  丕丕世且下一与丝与);
    }
    public BankController()
    {
        var val_5;
        System.Func<System.Boolean> val_7;
        this.业丈不丟世万丈不一 = 0;
        val_5 = null;
        val_5 = null;
        val_7 = BankController.<>c.<>9__161_0;
        if(val_7 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  BankController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankController.<>c::三丛丅与丙丁丒万丗());
            BankController.<>c.<>9__161_0 = val_7;
        }
        
        this.丌且丝丄丂丛且丛世 = new Rilisoft.七丞丞丅东丞专丙丝<System.Boolean>(丙丂丌且丌世丒丐三:  val_1);
        System.Collections.Generic.List<BankViewTab> val_3 = new System.Collections.Generic.List<BankViewTab>();
        if(val_3 != null)
        {
                val_3.Add(item:  4);
            val_3.Add(item:  5);
            val_3.Add(item:  1);
            val_3.Add(item:  2);
        }
        else
        {
                val_3.Add(item:  4);
            val_3.Add(item:  5);
            val_3.Add(item:  1);
            val_3.Add(item:  2);
        }
        
        val_3.Add(item:  7);
        this.丐七丌七丌丒专不丏 = val_3;
        this.东丄丗丄丙丌上业下 = new System.Collections.Generic.List<BankViewTab>();
        this.业丝七下丑下业七丑 = System.String.alignConst;
        this.万万丁下一丄七不丁 = -3.402823E+38f;
        this.丕丂丞丛丑与丛专丁 = System.String.alignConst;
    }
    private static BankController()
    {
        BankController.丂七上业下丆丄东丄 = true;
        BankController.丕下三丂世下丟东丁 = false;
        BankController.丛东丕丑下丂丆丑丒 = 0;
        BankController.丂万与丟丅丄丂七下 = 0;
        BankController.丑三丕不万与与丁万 = 0;
        BankController.丙丑不丄不丗不丟丒 = 0;
        BankController.丝丑丅丟三丈丏丌东 = 0;
        BankController.丗丝专丗七业专专丛 = 0;
    }
    private void 专丅丛七且丏丐丆三()
    {
        if(this.上丙丆不丂丂丄一丂() == false)
        {
                return;
        }
        
        if(this.丅与丂丏丄丟丆丄丘 == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(AbstractBankView).__il2cppRuntimeField_198;
    }

}
