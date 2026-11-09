using UnityEngine;
public class EventStoreBannerWindow : BannerWindow
{
    // Fields
    private UIBasicSprite _busTexture;
    private UILabel _timeLeftLabel;
    private System.Collections.Generic.List<UILabel> _headerLabels;
    private UILabel _descriptionLabel;
    private static Rilisoft.且丈丞一丞丟与上七 丂丌不上丐丄丟丙丘;
    private static Rilisoft.且丈丞一丞丟与上七 东下与不丅丕丟丄丂;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private int 万且丛东专丝且与丌;
    private 丕世专丒丁不丁丅丁 丟丁丙丈丆与东丄七;
    
    // Properties
    public static bool 丕世一与业丅万专丑 { get; }
    
    // Methods
    public static bool get_CanShow()
    {
        Rilisoft.且丈丞一丞丟与上七 val_16;
        string val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_16 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
        if((val_16.且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40)) == false)
        {
                return false;
        }
        
        val_16 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "season");
        if(val_16 < 1)
        {
                return false;
        }
        
        PGCompany.EventHub.丄丟丐丂丌丆万丁丅 val_6 = PGCompany.EventHub.EventHubBanner.丝丏上且丄丗丛丕世();
        val_17 = 0;
        if(val_6 != null)
        {
                val_17 = val_6.丌丙丒三专丘丛业丂();
        }
        
        if((System.String.op_Equality(a:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().不丒七丘丏丆丛上丕(世七七丟丑丁丂与丞:  40), b:  val_17)) == true)
        {
                return false;
        }
        
        val_18 = null;
        val_18 = null;
        if(EventStoreBannerWindow.丂丌不上丐丄丟丙丘.世三丞丅丑丌丈丈一() == val_16)
        {
                val_19 = null;
            val_19 = null;
            if(EventStoreBannerWindow.东下与不丅丕丟丄丂.世三丞丅丑丌丈丈一() == 2)
        {
                return false;
        }
        
        }
        
        System.TimeSpan val_11 = EventStoreBannerWindow.丛万丈丕丁丅专丌东();
        if(val_11._ticks.TotalMinutes < 0)
        {
                return false;
        }
        
        val_20 = null;
        val_20 = null;
        if(EventStoreBannerWindow.丂丌不上丐丄丟丙丘.世三丞丅丑丌丈丈一() != val_16)
        {
                return false;
        }
        
        val_21 = null;
        val_21 = null;
        val_16 = EventStoreBannerWindow.东下与不丅丕丟丄丂;
        if(val_16.世三丞丅丑丌丈丈一() <= 1)
        {
                if(val_11._ticks.TotalDays <= 2)
        {
                return false;
        }
        
        }
        
        return false;
    }
    internal static void 专万万一丁业丘下丕()
    {
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  25, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    protected override void OnEnable()
    {
        var val_12;
        int val_13;
        var val_14;
        this.OnEnable();
        System.TimeSpan val_1 = EventStoreBannerWindow.丛万丈丕丁丅专丌东();
        if(val_1._ticks.TotalDays <= 2)
        {
            goto label_3;
        }
        
        val_12 = null;
        val_12 = null;
        var val_4 = (EventStoreBannerWindow.东下与不丅丕丟丄丂.世三丞丅丑丌丈丈一() == 1) ? (1 + 1) : 1;
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_3:
        val_13 = 2;
        label_8:
        this.万且丛东专丝且与丌 = val_13;
        val_14 = null;
        if(EventStoreBannerWindow.CanShow == false)
        {
            goto label_11;
        }
        
        this.丌专丏专业丌不丂丝();
        if(this.丐丆七且丞丏下三丙 == null)
        {
            goto label_12;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        goto label_16;
        label_11:
        this.U_Hide();
        return;
        label_16:
        this.丐丆七且丞丏下三丙.Dispose();
        label_12:
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void EventStoreBannerWindow::U_Hide()), 与且专丈不万东一万:  0);
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
    }
    protected override void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.OnDisable();
    }
    public override void HideSelf()
    {
        this.HideSelf();
    }
    private void 丌专丏专业丌不丂丝()
    {
        UnityEngine.Object val_19;
        var val_20;
        UILabel val_21;
        System.Collections.Generic.List<UILabel> val_22;
        UILabel val_23;
        string val_24;
        if(this._busTexture != 0)
        {
                val_19 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/car_event_{0}", arg0:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().不丒七丘丏丆丛上丕(世七七丟丑丁丂与丞:  40).ToLower()));
            if(val_19 == 0)
        {
                val_20 = "basic";
            if("basic" == null)
        {
                val_20 = "basic";
        }
        
            val_19 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/car_event_{0}", arg0:  ToLower()));
        }
        
        }
        
        System.TimeSpan val_11 = EventStoreBannerWindow.丛万丈丕丁丅专丌东();
        val_21 = this._timeLeftLabel;
        if(val_21 != 0)
        {
                val_21 = this._timeLeftLabel;
            val_21.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6776"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_11._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        }
        
        if(this.万且丛东专丝且与丌 != 2)
        {
                if(this.万且丛东专丝且与丌 != 1)
        {
                return;
        }
        
            val_22 = this._headerLabels;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_22, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6785"));
            val_23 = this._descriptionLabel;
            val_24 = "Key_6787";
        }
        else
        {
                val_22 = this._headerLabels;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_22, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6786"));
            val_23 = this._descriptionLabel;
            val_24 = "Key_6788";
        }
        
        val_23.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_24);
    }
    private static System.TimeSpan 丛万丈丕丁丅专丌东()
    {
        System.Collections.Generic.IEnumerable<TSource> val_13;
        var val_17;
        var val_18;
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  0);
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
                return (System.TimeSpan)val_10.HasValue;
        }
        
        val_13 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40);
        if(val_13 == null)
        {
                return (System.TimeSpan)val_10.HasValue;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_13)) == false)
        {
                return (System.TimeSpan)val_10.HasValue;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_13 = val_13.GetEnumerator();
        goto label_23;
        label_29:
        var val_17 = 0;
        val_17 = val_17 + 1;
        System.Nullable<System.TimeSpan> val_10 = val_13.Current.丙世丑丅丒丑业与不();
        if((1665584016 & 1) != 0)
        {
                double val_11 = val_10.HasValue.TotalSeconds;
            double val_12 = val_1._ticks.TotalSeconds;
        }
        
        label_23:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_13.MoveNext() == true)
        {
            goto label_29;
        }
        
        val_17 = 0;
        val_18 = 0;
        if(val_13 == null)
        {
            
        }
        else
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_13.Dispose();
        }
        
        if( != 1)
        {
                return (System.TimeSpan)val_10.HasValue;
        }
        
        if( == false)
        {
                return (System.TimeSpan)val_10.HasValue;
        }
        
        return (System.TimeSpan)val_10.HasValue;
    }
    public void U_Hide()
    {
        var val_2 = null;
        EventStoreBannerWindow.丂丌不上丐丄丟丙丘.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "season"));
        EventStoreBannerWindow.东下与不丅丕丟丄丂.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  this.万且丛东专丝且与丌);
    }
    public void U_HideAndOpenBank()
    {
        var val_7;
        var val_8;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                .丛丟丌丝丈丞上丕丈 = 0;
            .丛丟丌丝丈丞上丕丈 = new System.EventHandler(object:  new EventStoreBannerWindow.三丅丞丒丕丅专一丅(), method:  System.Void EventStoreBannerWindow.三丅丞丒丕丅专一丅::丞三世丒且丛不专专(object 丟业丏且丟七丞一丆, System.EventArgs 业丝丑丆上丆丌丙业));
            BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (EventStoreBannerWindow.三丅丞丒丕丅专一丅)[1152921536337516400].丛丟丌丝丈丞上丕丈);
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丟一业丒丟丝丙且丞;
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  "EventStore", 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丟一业丒丟丝丙且丞);
        }
        
        this.U_Hide();
    }
    private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new EventStoreBannerWindow.丛丙上丒丗丒丕丒丕();
    }
    public EventStoreBannerWindow()
    {
    
    }
    private static EventStoreBannerWindow()
    {
        EventStoreBannerWindow.丂丌不上丐丄丟丙丘 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "EventStoreBannerWindow_lastShowSeason");
        EventStoreBannerWindow.东下与不丅丕丟丄丂 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "EventStoreBannerWindow_lastShowStage");
    }

}
