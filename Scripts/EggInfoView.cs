using UnityEngine;
internal sealed class EggInfoView : PGBehaviour
{
    // Fields
    private PGCompany.丕下丆丑万世业丈丟 丄丈世业七丐三上东;
    private UnityEngine.GameObject trainingHintToIncubator;
    private HatchEggUI hatchEggUI;
    private HatchingEggRefsHolder eggExample;
    private HatchingEggRefsHolder 七丅丄丞丞丄丈专丝;
    private PGCompany.InventoryItemView eggItemView;
    private ItemListUI itemListUI;
    private UnityEngine.GameObject button_HatchFree;
    private UnityEngine.GameObject button_HatchPaid;
    private UnityEngine.GameObject button_StartTimer;
    private UnityEngine.GameObject button_StartTimerDisabled;
    private UnityEngine.GameObject button_SpeedUpAd;
    private UnityEngine.GameObject button_SpeedUpPaid;
    private PGCompany.InventoryItemView hatchPrice;
    private PGCompany.InventoryItemView speedUpPrice;
    private UILabel button_SpeedUpAd_Label;
    private UILabel button_StartTimer_Label;
    private UILabel button_HatchPaid_Label;
    private PGCompany.TimerUI button_SpeedUpPaid_TimerUI;
    private EggDropView eggDropView;
    private PGCompany.Ads.丂丐与不丘不下丂上 业丈丌丌七丛丆丝上;
    
    // Properties
    public PGCompany.丕下丆丑万世业丈丟 丕下丆丑万世业丈丟 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    
    // Methods
    public PGCompany.丕下丆丑万世业丈丟 get_ItemEgg()
    {
        return (PGCompany.丕下丆丑万世业丈丟)this.丄丈世业七丐三上东;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    private void OnDestroy()
    {
        PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EggInfoView::丐下一丒不上丒业不()));
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EggInfoView::丐下一丒不上丒业不()));
        if(this.业丈丌丌七丛丆丝上 != null)
        {
                this.业丈丌丌七丛丆丝上.Dispose();
        }
        
        this.业丈丌丌七丛丆丝上 = 0;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕)
    {
        this.丄丈世业七丐三上东 = 世丕丘丈丙世业东丕;
        this.丕丒丐丁丗丗东丐丗();
        if(this.丄丈世业七丐三上东.三七世丌专丆与丄世() != null)
        {
                this.七丅丄丞丞丄丈专丝.eggRenderer.material.mainTexture = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Rilisoft.EggsManager.与不丛丛业丁七丏丛(三万万丒丏丒不丐丙:  this.丄丈世业七丐三上东.三七世丌专丆与丄世()));
        }
        
        this.丝一丅丆三东丂丞七();
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EggInfoView::丐下一丒不上丒业不()));
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EggInfoView::丐下一丒不上丒业不()));
        PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EggInfoView::丐下一丒不上丒业不()));
        PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EggInfoView::丐下一丒不上丒业不()));
    }
    internal void 丝一丅丆三东丂丞七()
    {
        if(this.丄丈世业七丐三上东 == null)
        {
                return;
        }
        
        this.eggItemView.Setup(与且专丈不万东一万:  this.丄丈世业七丐三上东);
        this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.丄丈世业七丐三上东.丗三与丁丝万三丄业());
        this.丙丑丘业丕丗丗不丘();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.trainingHintToIncubator, 丏业丟一东丂东丘丛:  false);
        this.eggDropView.丄丈世业七丐三上东 = this.丄丈世业七丐三上东;
        this.eggDropView.丝一丅丆三东丂丞七();
    }
    private void 丞一下下丝丛且三丛()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_HatchFree, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_SpeedUpAd, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_SpeedUpPaid, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_HatchPaid, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_StartTimer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_StartTimerDisabled, 丏业丟一东丂东丘丛:  false);
    }
    private void 丙丑丘业丕丗丗不丘()
    {
        object val_48;
        UnityEngine.GameObject val_49;
        var val_50;
        var val_51;
        bool val_52;
        bool val_53;
        bool val_54;
        val_48 = this;
        this.丞一下下丝丛且三丛();
        if(this.丄丈世业七丐三上东.七丄业丅专上丌丅丙() != false)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_HatchFree, 丏业丟一东丂东丘丛:  (PixelTime.丝丗专上三不丄丑丑() >> 63) ^ 1);
        }
        
        }
        
        int val_6 = this.丄丈世业七丐三上东.丛与丏丏七丟与世专();
        val_49 = this.button_SpeedUpPaid_TimerUI.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_49, 丏业丟一东丂东丘丛:  (val_6 > 0) ? 1 : 0);
        if(val_6 >= 1)
        {
                val_50 = null;
            val_50 = null;
            float val_43 = Rilisoft.EggsManager.下一丌业丘丄丙丟丟;
            float val_10 = val_43 * 2290644854;
            val_10 = val_10 >> 32;
            val_43 = val_10 + val_43;
            val_10 = val_43 >> 5;
            val_43 = val_10 + (val_43 >> 31);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.button_SpeedUpAd_Label, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4044"), arg0:  val_43));
            this.speedUpPrice.Setup(丈丄不七三万丄丁不:  this.丄丈世业七丐三上东.丈下丂丆不丕丐丌丂());
            if((与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true) && ((PixelTime.丝丗专上三不丄丑丑() & 9223372036854775808) == 0))
        {
                val_51 = PGCompany.丞丁丌不丌不丄丆丟.下丘丘丏专丏三丂丞(丏丞专丏业丗丝七丝: out  0);
        }
        else
        {
                val_51 = 0;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_SpeedUpAd, 丏业丟一东丂东丘丛:  false);
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                val_52 = 0;
        }
        else
        {
                val_52 = (PixelTime.丝丗专上三不丄丑丑() >> 63) ^ 1;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_SpeedUpPaid, 丏业丟一东丂东丘丛:  val_52);
            val_49 = this.丄丈世业七丐三上东.丛与丏丏七丟与世专();
            this.button_SpeedUpPaid_TimerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_49, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void EggInfoView::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  PGCompany.业专丝专丑东丂丐丑.丁不丂丕丌丌丙丛丅(世丕丘丈丙世业东丕:  this.丄丈世业七丐三上东), 与丌一丑且丗三丙一:  new System.Action(object:  this, method:  System.Void EggInfoView::丞丌丈七三业七丅丅()));
        }
        
        if(this.丄丈世业七丐三上东.七丄业丅专上丌丅丙() == true)
        {
                return;
        }
        
        if(this.丄丈世业七丐三上东.丛与丏丏七丟与世专() > 0)
        {
                return;
        }
        
        this.hatchPrice.Setup(丈丄不七三万丄丁不:  this.丄丈世业七丐三上东.三丌世丕下丌业丕一());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.button_HatchPaid_Label, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9375"));
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                val_53 = 0;
        }
        else
        {
                val_53 = (PixelTime.丝丗专上三不丄丑丑() >> 63) ^ 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_HatchPaid, 丏业丟一东丂东丘丛:  val_53);
        PGCompany.丕下丆丑万世业丈丟 val_32 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丁世丌丝丙丞丑丄世();
        if(val_32 == null)
        {
            goto label_65;
        }
        
        val_49 = this.丄丈世业七丐三上东.丅丙丛丑丌丆丌丕丒();
        if(val_49 != val_32.丅丙丛丑丌丆丌丕丒())
        {
            goto label_67;
        }
        
        label_65:
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                val_49 = 0;
        }
        else
        {
                val_49 = (PixelTime.丝丗专上三不丄丑丑() >> 63) ^ 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_StartTimer, 丏业丟一东丂东丘丛:  val_49);
        val_48 = this.button_StartTimer_Label;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_48, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.丄丈世业七丐三上东.丂丞东与专丂丅丁丏(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        return;
        label_67:
        val_48 = this.button_StartTimerDisabled;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                val_54 = 0;
        }
        else
        {
                val_54 = (PixelTime.丝丗专上三不丄丑丑() >> 63) ^ 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_48, 丏业丟一东丂东丘丛:  val_54);
    }
    public void U_HatchFree()
    {
        if(PixelTime.丝丗专上三不丄丑丑() > 0)
        {
                丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_HatchFree");
            this.hatchEggUI.丘下丘业丈万丙丐专(世丕丘丈丙世业东丕:  this.丄丈世业七丐三上东, 业下丘丗丌东丈不丒:  0);
            return;
        }
        
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
    }
    public void U_HatchPaid()
    {
        object val_9;
        PGCompany.三东丏不丗世丅丌丄 val_10;
        val_9 = this;
        if(PixelTime.丝丗专上三不丄丑丑() <= 0)
        {
            goto label_3;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_HatchPaid");
        val_10 = this.丄丈世业七丐三上东.三丌世丕下丌业丕一();
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_10, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_6;
        }
        
        val_10 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance;
        val_10.丌丘丞上丑丈丂丞丄(世丕丘丈丙世业东丕:  this.丄丈世业七丐三上东, 丒世丘丘上丆丝东丞:  this.丄丈世业七丐三上东.三丌世丕下丌业丕一(), 丑万丞丟丂丐丁三丛:  new System.Action(object:  this, method:  System.Void EggInfoView::丗丒不丑丝下丒丆下()), 丘丐东丄丁万丞丅丟:  0);
        return;
        label_3:
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
        return;
        label_6:
        val_9 = this.hatchEggUI;
        val_9.万丞丌七丈丄丙东万(与专丁丈丆丌丐丌丝:  this.丄丈世业七丐三上东.三丌世丕下丌业丕一(), 丙丙专丝专上丅丛丏:  true);
    }
    public void U_HatchSpeedUpPaid()
    {
        object val_9;
        PGCompany.三东丏不丗世丅丌丄 val_10;
        val_9 = this;
        if(PixelTime.丝丗专上三不丄丑丑() <= 0)
        {
            goto label_3;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_HatchSpeedUpPaid");
        val_10 = this.丄丈世业七丐三上东.丈下丂丆不丕丐丌丂();
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_10, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_6;
        }
        
        val_10 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance;
        val_10.世业丟丆丞丗丆万丅(世丕丘丈丙世业东丕:  this.丄丈世业七丐三上东, 丒世丘丘上丆丝东丞:  this.丄丈世业七丐三上东.丈下丂丆不丕丐丌丂(), 丑万丞丟丂丐丁三丛:  new System.Action(object:  this, method:  System.Void EggInfoView::丄丒丛世三丆一丙丕()), 丘丐东丄丁万丞丅丟:  0);
        return;
        label_3:
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
        return;
        label_6:
        val_9 = this.hatchEggUI;
        val_9.万丞丌七丈丄丙东万(与专丁丈丆丌丐丌丝:  this.丄丈世业七丐三上东.丈下丂丆不丕丐丌丂(), 丙丙专丝专上丅丛丏:  true);
    }
    public void U_HatchSpeedUpAd()
    {
        object val_20;
        PGCompany.Ads.丂丐与不丘不下丂上 val_21;
        string val_7 = 0;
        EggInfoView.丂丄丕业东丆丄三三 val_1 = null;
        val_20 = val_1;
        val_1 = new EggInfoView.丂丄丕业东丆丄三三();
        .丝且与丝丒丟万丁专 = this;
        if(PixelTime.丝丗专上三不丄丑丑() <= 0)
        {
            goto label_4;
        }
        
        if(EggInfoView.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[EggInfoView.U_HatchSpeedUpAd]");
        }
        
        bool val_5 = this.一丑丄东丑上丄专丂(丛下丛下丑丞与世下: out  (EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].丛下丛下丑丞与世下);
        val_21 = (EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].丛下丛下丑丞与世下;
        if((val_21.丆下丟三丅丞业丝丘(下丒丗丛丙丆丄丈专: out  (EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].下丒丗丛丙丆丄丈专, 丅丏七一且且世丘世: out  val_7)) == false)
        {
            goto label_9;
        }
        
        UIPanel val_9 = mem[(EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].下丒丗丛丙丆丄丈专].GetComponentInChildren<UIPanel>(includeInactive:  true);
        if(val_9 != 0)
        {
                if(val_9.depth <= 999998)
        {
                丞东丑专丛丆丄丝世.业丆丌且上东丂东丗(万且万且丑丗且丌丆:  mem[(EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].下丒丗丛丙丆丄丈专].gameObject, 丙业与丙丗丝不丈东:  999998 + 1);
        }
        
        }
        
        System.DateTimeOffset val_15 = System.DateTimeOffset.FromUnixTimeSeconds(seconds:  PixelTime.丝丗专上三不丄丑丑());
        .东丆丒东不丕丑万丂 = ;
        bool val_16 = (EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].下丒丗丛丙丆丄丈专.丝不丒三下万丅不丛(丅上专丁丘丈不丞丒:  "hatchSpeedup");
        System.DateTime val_17 = System.DateTime.Now;
        mem[(EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].下丒丗丛丙丆丄丈专].不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime() {dateData = val_17.dateData}, 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
        (EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].下丒丗丛丙丆丄丈专.add_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void EggInfoView.丂丄丕业东丆丄三三::一三丝丟丌东东一丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_19 = null;
        val_21 = val_19;
        val_19 = new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  val_1, method:  System.Void EggInfoView.丂丄丕业东丆丄三三::丟丐丑丛七丝万丄丏(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且));
        (EggInfoView.丂丄丕业东丆丄三三)[1152921526194009520].下丒丗丛丙丆丄丈专.add_EnterIdle(丙业与丙丗丝不丈东:  val_19);
        return;
        label_4:
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
        return;
        label_9:
        val_20 = "[EggInfoView.U_HatchSpeedUpAd] TryGetRewardedVideo failed: "("[EggInfoView.U_HatchSpeedUpAd] TryGetRewardedVideo failed: ") + val_7;
        UnityEngine.Debug.LogWarning(message:  val_20);
    }
    public void U_StratTimer()
    {
        if(PixelTime.丝丗专上三不丄丑丑() > 0)
        {
                丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_StratTimer");
            this.丄丈世业七丐三上东.丞丝下丄丆且丌丈丐();
            this.丝一丅丆三东丂丞七();
            return;
        }
        
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
    }
    private void 丕丒丐丁丗丗东丐丗()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.eggExample, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.七丅丄丞丞丄丈专丝, 丏业丟一东丂东丘丛:  false);
        if(this.七丅丄丞丞丄丈专丝 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.七丅丄丞丞丄丈专丝.gameObject);
        }
        
        HatchingEggRefsHolder val_5 = UnityEngine.Object.Instantiate<HatchingEggRefsHolder>(original:  this.eggExample, parent:  this.eggExample.transform.parent);
        this.七丅丄丞丞丄丈专丝 = val_5;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
    }
    private bool 一丑丄东丑上丄专丂(out PGCompany.Ads.丂丐与不丘不下丂上 丛下丛下丑丞与世下)
    {
        UnityEngine.Object val_8;
        PGCompany.Ads.丂丐与不丘不下丂上 val_9;
        var val_10;
        if(this.业丈丌丌七丛丆丝上 != null)
        {
                if(this.业丈丌丌七丛丆丝上.丆丞且专丈世丞丞业() == false)
        {
            goto label_2;
        }
        
        }
        
        HatchEggUIBanner val_2 = this.GetComponentInParent<HatchEggUIBanner>();
        if(val_2 == null)
        {
            goto label_3;
        }
        
        val_8 = val_2.transform.parent.gameObject;
        goto label_6;
        label_2:
        val_9 = this.业丈丌丌七丛丆丝上;
        goto label_7;
        label_3:
        val_8 = 0;
        label_6:
        if(val_8 != 0)
        {
            goto label_10;
        }
        
        val_9 = 0;
        val_10 = 0;
        goto label_11;
        label_10:
        PGCompany.Ads.丂丐与不丘不下丂上 val_7 = null;
        val_9 = val_7;
        val_7 = new PGCompany.Ads.丂丐与不丘不下丂上(丙丁丘丙丝且丄上丌:  val_8);
        this.业丈丌丌七丛丆丝上 = val_9;
        label_7:
        val_10 = 1;
        label_11:
        丛下丛下丑丞与世下 = val_9;
        return (bool)val_10;
    }
    private void 丐下一丒不上丒业不()
    {
        this.丝一丅丆三东丂丞七();
    }
    public EggInfoView()
    {
    
    }
    private void 丞丌丈七三业七丅丅()
    {
        this.speedUpPrice.Setup(丈丄不七三万丄丁不:  this.丄丈世业七丐三上东.丈下丂丆不丕丐丌丂());
    }
    private void 丗丒不丑丝下丒丆下()
    {
        this.hatchEggUI.丘下丘业丈万丙丐专(世丕丘丈丙世业东丕:  this.丄丈世业七丐三上东, 业下丘丗丌东丈不丒:  1);
    }
    private void 丄丒丛世三丆一丙丕()
    {
        this.hatchEggUI.丘下丘业丈万丙丐专(世丕丘丈丙世业东丕:  this.丄丈世业七丐三上东, 业下丘丗丌东丈不丒:  2);
    }

}
