using UnityEngine;
public sealed class BuySmileBannerController : BannerWindow
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    internal static string 丁丒丝丘丛丑与丏丗()
    {
        var val_5;
        var val_6;
        FriendsWindowGUI val_7;
        var val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_6 = null;
            val_6 = null;
            val_7 = FriendsWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_7.上丙丆不丂丂丄一丂() != false)
        {
                val_8 = "Friends";
            return (string)(val_7 == 0) ? "Sandbox" : "Lobby";
        }
        
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = ChatViewrController.丄丞丁丈与业上丞丟;
        return (string)(val_7 == 0) ? "Sandbox" : "Lobby";
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void BuySmileBannerController::OnCloseClick()), 与且专丈不万东一万:  "Buy Smiley Banner");
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
    private void 丕丈丝丅且丙业丕丆()
    {
        var val_6;
        var val_7;
        System.Func<FriendsWindowGUI, System.Boolean> val_9;
        var val_10;
        var val_11;
        var val_12;
        val_6 = null;
        val_6 = null;
        val_7 = null;
        val_7 = null;
        val_9 = BuySmileBannerController.<>c.<>9__4_0;
        if(val_9 == null)
        {
                System.Func<FriendsWindowGUI, System.Boolean> val_1 = null;
            val_9 = val_1;
            val_1 = new System.Func<FriendsWindowGUI, System.Boolean>(object:  BuySmileBannerController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BuySmileBannerController.<>c::丌丐丌上丅不丙丝丗(FriendsWindowGUI 与丕丁三万专世不丅));
            BuySmileBannerController.<>c.<>9__4_0 = val_9;
        }
        
        if((Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<FriendsWindowGUI, System.Boolean>(丄三丅七丆丛与与上:  FriendsWindowGUI.丆丕丝丒不丙且丐丗, 东丑丈丅丌万东丅且:  val_1)) == true)
        {
            goto label_22;
        }
        
        val_10 = null;
        val_10 = null;
        if(ChatViewrController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_13;
        }
        
        label_22:
        this.OnCloseClick();
        return;
        label_13:
        val_11 = null;
        val_11 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if(SquadController.丄丘七三上丕世丞业.inSquad == true)
        {
            goto label_22;
        }
    
    }
    public void OnCloseClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.gameObject.SetActive(value:  false);
    }
    internal void 且东丕丏业丌丗上丑(StickersPackItem 丅七丘上上丁丄丁丅)
    {
        BuySmileBannerController val_20;
        object val_21;
        val_20 = this;
        BuySmileBannerController.丘丞上世丗丘丏丐东 val_1 = null;
        val_21 = val_1;
        val_1 = new BuySmileBannerController.丘丞上世丗丘丏丐东();
        if(val_21 == null)
        {
            goto label_1;
        }
        
        .丅七丘上上丁丄丁丅 = 丅七丘上上丁丄丁丅;
        .丝且与丝丒丟万丁专 = val_20;
        if(丅七丘上上丁丄丁丅 != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        丈丞丕丘丕丗与上一 val_4 = 丏丄丑上丛不丈且万.丅专一丘专丁丂丞与(下上丐丆丝丟丝丒不:  StickersController.丄丌丘丏上与业丘且(业丄七丙丛上专专丕:  丅七丘上上丁丄丁丅.三丈丈丒世丈专七一()));
        if(val_4 == null)
        {
            goto label_7;
        }
        
        int val_5 = val_4.丟丂丞不专丆万丒世();
        goto label_8;
        label_1:
        mem[16] = 丅七丘上上丁丄丁丅;
        mem[24] = val_20;
        if(mem[16] != 0)
        {
            goto label_9;
        }
        
        goto label_10;
        label_7:
        int val_6 = 0.丟丂丞不专丆万丒世();
        label_8:
        string val_7 = val_4.东与三丌丅三丒丏业();
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_4.与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_15;
        }
        
        }
        
        val_20 = this.transform.root.gameObject;
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_20, 丒世丘丘上丆丝东丞:  val_4, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void BuySmileBannerController.丘丞上世丗丘丏丐东::丈世丅丕丝丒丙丟丟()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  95);
        return;
        label_15:
        UnityEngine.Debug.LogError(message:  "Buy Stickers Pack (not enough currency) -> GoToMainStore");
        val_21 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
        val_21.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_4.东与三丌丅三丒丏业(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    public BuySmileBannerController()
    {
    
    }

}
