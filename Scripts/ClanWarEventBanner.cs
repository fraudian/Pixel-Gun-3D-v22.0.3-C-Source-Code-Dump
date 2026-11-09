using UnityEngine;
internal sealed class ClanWarEventBanner : BannerWindow
{
    // Fields
    private static System.Collections.Generic.List<int> 丆丁业丒丆万世丁专;
    private static int 丒丛一三丕东丁与丅;
    internal static PGCompany.丟与丞丗丌丂万丕丝 丕丂丁万丒上下丞东;
    private System.IDisposable 与丕东丑丌丆与东丕;
    private PGCompany.丟与丞丗丌丂万丕丝 且七业丅丆与丏丘丆;
    private UILabel _eventId_DEV;
    private UnityEngine.GameObject _raidNowContainer;
    private UnityEngine.GameObject _raidSoonContainer;
    private UnityEngine.GameObject _siegeNowContainer;
    private PGCompany.TimerUI _raidSoonTimer;
    private PGCompany.TimerUI _raidNowTimer;
    private System.Collections.Generic.List<UILabel> _raidShilds;
    private PGCompany.TimerUI _siegeNowTimer;
    private UILabel _siegeShilds;
    private UILabel _siegeSilver;
    
    // Properties
    internal static System.Collections.Generic.List<int> 丝丟与丐丁东丕业丅 { get; }
    private static string 且丐万一丌一丄七下 { get; }
    
    // Methods
    internal static System.Collections.Generic.List<int> 丌丂且丙丛东一且丒()
    {
        var val_1 = null;
        if(ClanWarEventBanner.丆丁业丒丆万世丁专 == null)
        {
                ClanWarEventBanner.丂上三专丑丄丈上不();
            val_1 = null;
        }
        
        val_1 = null;
        return (System.Collections.Generic.List<System.Int32>)ClanWarEventBanner.丆丁业丒丆万世丁专;
    }
    private static string 丂七丈丁专丑丐丌丈()
    {
        return "ClanWarEventBanner_ShownBanners_" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
    }
    internal static void 丂上三专丑丄丈上不()
    {
        var val_6 = 0;
        val_6 = val_6 + 1;
        ClanWarEventBanner.丆丁业丒丆万世丁专 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(ClanWarEventBanner.丆丁业丒丆万世丁专 != null)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  ClanWarEventBanner.丂七丈丁专丑丐丌丈()) = null;
        丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  ClanWarEventBanner.丂七丈丁专丑丐丌丈()) = new System.Collections.Generic.List<System.Int32>();
        ClanWarEventBanner.丆丁业丒丆万世丁专 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  ClanWarEventBanner.丂七丈丁专丑丐丌丈());
    }
    internal static void 业丏丕专与不丄丁不()
    {
        var val_4 = null;
        var val_5 = 0;
        val_5 = val_5 + 1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ClanWarEventBanner.丂七丈丁专丑丐丌丈(), 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  ClanWarEventBanner.丆丁业丒丆万世丁专));
    }
    internal static void 丅丐一丄万业专丈丘(PGCompany.丟与丞丗丌丂万丕丝 丆丞丁下上丟丗丏丈)
    {
        if(丆丞丁下上丟丗丏丈 == null)
        {
                return;
        }
        
        ClanWarEventBanner.丌丂且丙丛东一且丒().Add(item:  丆丞丁下上丟丗丏丈.业上丙丞丐丄丆丅七());
        ClanWarEventBanner.业丏丕专与不丄丁不();
    }
    internal static void 丐下丒丟专东丏七丆()
    {
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ClanWarEventBanner.丂七丈丁专丑丐丌丈(), 下下丏一丙不丘丌丞:  "");
        ClanWarEventBanner.丂上三专丑丄丈上不();
    }
    internal static bool 丈一世三与专三专丛(PGCompany.丟与丞丗丌丂万丕丝 丆丞丁下上丟丗丏丈)
    {
        if(丆丞丁下上丟丗丏丈 == null)
        {
                return true;
        }
        
        System.Collections.Generic.List<System.Int32> val_1 = ClanWarEventBanner.丌丂且丙丛东一且丒();
        if(val_1 != null)
        {
                return val_1.Contains(item:  丆丞丁下上丟丗丏丈.业上丙丞丐丄丆丅七());
        }
        
        return val_1.Contains(item:  丆丞丁下上丟丗丏丈.业上丙丞丐丄丆丅七());
    }
    internal static PGCompany.丟与丞丗丌丂万丕丝 上下专万下丂上丅丘()
    {
        PGCompany.丟与丞丗丌丂万丕丝 val_12;
        var val_13;
        string val_14;
        ClanWarEventBanner.丂上三专丑丄丈上不();
        PGCompany.丟与丞丗丌丂万丕丝 val_2 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万(且下丕七丙丗丄不七:  2);
        val_12 = val_2;
        if((ClanWarEventBanner.丈一世三与专三专丛(丆丞丁下上丟丗丏丈:  val_2)) == false)
        {
            goto label_4;
        }
        
        val_12 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑丄丅丛专一丄一不(且下丕七丙丗丄不七:  2);
        int val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丈丏丗万丑丕丗东丘(且下丕七丙丗丄不七:  2);
        if((val_7 < 1) || ((ClanWarEventBanner.丈一世三与专三专丛(丆丞丁下上丟丗丏丈:  val_12)) == true))
        {
            goto label_10;
        }
        
        val_13 = null;
        val_13 = null;
        if(val_7 <= ClanWarEventBanner.丒丛一三丕东丁与丅)
        {
            goto label_13;
        }
        
        label_10:
        val_12 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万(且下丕七丙丗丄不七:  1);
        if((ClanWarEventBanner.丈一世三与专三专丛(丆丞丁下上丟丗丏丈:  val_12)) == false)
        {
            goto label_17;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "GetEventForBanner: No event for banner");
        val_12 = 0;
        return val_12;
        label_4:
        val_14 = "GetEventForBanner: Raid Now";
        goto label_20;
        label_17:
        val_14 = "GetEventForBanner: Siege Now";
        goto label_20;
        label_13:
        val_14 = "GetEventForBanner: Raid Soon";
        label_20:
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  val_14);
        return val_12;
    }
    internal static System.ValueTuple<PGCompany.丟与丞丗丌丂万丕丝, bool> 丐专丟丏丑且与东下()
    {
        var val_14;
        var val_15;
        var val_16;
        PGCompany.丟与丞丗丌丂万丕丝 val_17;
        var val_18;
        var val_19;
        val_14 = null;
        val_14 = null;
        if(MainMenuController.丂世丗丌丌一丐丝丛 != false)
        {
                return 0;
        }
        
        val_15 = null;
        val_15 = null;
        if(SquadPanelGUI.丄丘七三上丕世丞业 != 0)
        {
                val_16 = null;
            val_16 = null;
            if(SquadPanelGUI.丄丘七三上丕世丞业.isActive == true)
        {
                return 0;
        }
        
        }
        
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丞丕业丞丆丘下三()) == false)
        {
                return 0;
        }
        
        if((ClansTutorialController.Instance.丘丆丘下且丗丒丟丄(业丝丛且丛专丝业丁:  1)) == false)
        {
                return 0;
        }
        
        if((ClansTutorialController.Instance.丘丆丘下且丗丒丟丄(业丝丛且丛专丝业丁:  2)) == false)
        {
                return 0;
        }
        
        if((ClansTutorialController.Instance.丘丆丘下且丗丒丟丄(业丝丛且丛专丝业丁:  3)) == false)
        {
                return 0;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "TryShowBanner...");
        ClanWarEventBanner.丕丂丁万丒上下丞东 = ClanWarEventBanner.上下专万下丂上丅丘();
        val_17 = ClanWarEventBanner.丕丂丁万丒上下丞东;
        if(val_17 == null)
        {
                return 0;
        }
        
        val_17 = ClanWarEventBanner.丕丂丁万丒上下丞东;
        if((val_17 != null) && (mem[val_10] == null))
        {
                if(val_17.丅业东万丌丕上丌丄() != false)
        {
                if((ClanWarEventBanner.丈丕丞丘上丏三丕世(丆且丏下且丛丈七不:  val_17)) == false)
        {
            goto label_31;
        }
        
        }
        
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  49, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        val_18 = null;
        val_18 = null;
        return 0;
        label_31:
        val_19 = null;
        val_19 = null;
        return 0;
    }
    public override void Show()
    {
        object val_10;
        var val_11;
        PGCompany.丟与丞丗丌丂万丕丝 val_12;
        System.IDisposable val_13;
        var val_15;
        val_10 = this;
        this.Show();
        val_11 = null;
        val_11 = null;
        val_12 = ClanWarEventBanner.丕丂丁万丒上下丞东;
        if(val_12 == null)
        {
            goto label_3;
        }
        
        val_12 = ClanWarEventBanner.丕丂丁万丒上下丞东;
        this.丈且东丑丂且万丒丅(丆丞丁下上丟丗丏丈:  val_12);
        ClanWarEventBanner.丅丐一丄万业专丈丘(丆丞丁下上丟丗丏丈:  ClanWarEventBanner.丕丂丁万丒上下丞东);
        ClanWarEventBanner.丕丂丁万丒上下丞东 = 0;
        val_13 = this.与丕东丑丌丆与东丕;
        if(val_13 == null)
        {
            goto label_6;
        }
        
        val_15 = null;
        var val_10 = 0;
        val_10 = val_10 + 1;
        goto label_10;
        label_3:
        val_13 = ???;
        val_10 = ???;
        goto typeof(ClanWarEventBanner).__il2cppRuntimeField_1D8;
        label_10:
        val_13.Dispose();
        label_6:
        new System.Action() = new System.Action(object:  val_10, method:  val_10 + 528);
        mem2[0] = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "ClanWarEventBanner");
    }
    private void 丈且东丑丂且万丒丅(PGCompany.丟与丞丗丌丂万丕丝 丆丞丁下上丟丗丏丈)
    {
        var val_8;
        object val_11;
        object val_32;
        UILabel val_33;
        PGCompany.TimerUI val_34;
        var val_35;
        var val_36;
        object val_37;
        val_32 = this;
        this.且七业丅丆与丏丘丆 = 丆丞丁下上丟丗丏丈;
        val_33 = this._eventId_DEV;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_33, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._raidNowContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._raidSoonContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._siegeNowContainer, 丏业丟一东丂东丘丛:  false);
        if(丆丞丁下上丟丗丏丈 == null)
        {
            goto label_3;
        }
        
        if(丆丞丁下上丟丗丏丈.不业丙丒丂丞下丆丙() != 2)
        {
            goto label_4;
        }
        
        label_9:
        if((丆丞丁下上丟丗丏丈 & 1) == 0)
        {
            goto label_5;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._raidNowContainer, 丏业丟一东丂东丘丛:  true);
        val_34 = this._raidNowTimer;
        val_35 = 丆丞丁下上丟丗丏丈;
        int val_2 = val_35.丘丒不不丌丘下丒一();
        goto label_8;
        label_3:
        val_33 = 0.不业丙丒丂丞下丆丙();
        if(val_33 == 2)
        {
            goto label_9;
        }
        
        label_4:
        if(丆丞丁下上丟丗丏丈.不业丙丒丂丞下丆丙() != 1)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._siegeNowContainer, 丏业丟一东丂东丘丛:  true);
        this._siegeNowTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  丆丞丁下上丟丗丏丈.丘丒不不丌丘下丒一(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  public System.Void BannerWindow::HideSelf()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        PGCompany.ClanWarEventConfig val_7 = 丆丞丁下上丟丗丏丈.世丈丁业丛上丘丗丐();
        List.Enumerator<T> val_9 = val_8.GetEnumerator();
        val_36 = 0;
        val_37 = 0;
        goto label_22;
        label_24:
        string val_12 = val_11.丐丏七丌丕丗业且上();
        if(val_12.不业丙丒丂丞下丆丙() == 1220)
        {
                val_37 = val_12.丂丁丏一丙丛业且丌() + val_37;
        }
        
        if(val_12.不业丙丒丂丞下丆丙() == 1200)
        {
                val_36 = val_12.丂丁丏一丙丛业且丌() + val_36;
        }
        
        label_22:
        if((1658711184 & 1) != 0)
        {
            goto label_24;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_43;
        label_5:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._raidSoonContainer, 丏业丟一东丂东丘丛:  true);
        val_34 = this._raidSoonTimer;
        val_35 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        label_8:
        val_34.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_35.丈丏丗万丑丕丗东丘(且下丕七丙丗丄不七:  2), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  public System.Void BannerWindow::HideSelf()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        PGCompany.ClanWarEventConfig val_20 = 丆丞丁下上丟丗丏丈.世丈丁业丛上丘丗丐();
        List.Enumerator<T> val_21 = val_8.GetEnumerator();
        val_37 = 1152921525631264896;
        val_33 = 0;
        goto label_33;
        label_35:
        string val_22 = val_11.丐丏七丌丕丗业且上();
        if(val_22.不业丙丒丂丞下丆丙() == 1220)
        {
                val_33 = val_22.丂丁丏一丙丛业且丌() + val_33;
        }
        
        label_33:
        if((1658711184 & 1) != 0)
        {
            goto label_35;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_51;
        label_43:
        val_33 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8632"), arg0:  val_37);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._siegeShilds, 丕丗丘丑丛与丑业丒:  val_33);
        val_32 = this._siegeSilver;
        val_11 = 1152921525631263872;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_32, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8631"), arg0:  val_11));
        return;
        label_51:
        val_32 = this._raidShilds;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_32, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8632"), arg0:  val_33));
    }
    public void GoToRaid()
    {
        PGCompany.丟与丞丗丌丂万丕丝 val_9;
        var val_10;
        var val_11;
        var val_12;
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Go To Raid");
        this.HideSelf();
        val_9 = this.且七业丅丆与丏丘丆;
        if((val_9 & 1) == 0)
        {
                return;
        }
        
        val_9 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_9.丌丞丕业丞丆丘下三() == false)
        {
                return;
        }
        
        val_10 = null;
        if(ClanWarUI.丈丐丞丐上丑且丕万() != false)
        {
                ClanWarUI.丑七不且上丗丁一世().U_GoToFortDefence();
            return;
        }
        
        val_9 = Rilisoft.ClansLobbyGui.丑七不且上丗丁一世();
        if(val_9 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        ClanWarUI.丂丄万丑不丙丆七一 = true;
        val_9 = Rilisoft.ClansLobbyGui.丑七不且上丗丁一世();
        if(val_9.OpenClanWar() == true)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        ClanWarUI.丂丄万丑不丙丆七一 = false;
    }
    public void GoToSiege()
    {
        PGCompany.丟与丞丗丌丂万丕丝 val_9;
        var val_10;
        var val_11;
        var val_12;
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Go To Siege");
        this.HideSelf();
        val_9 = this.且七业丅丆与丏丘丆;
        if((val_9 & 1) == 0)
        {
                return;
        }
        
        val_9 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_9.丌丞丕业丞丆丘下三() == false)
        {
                return;
        }
        
        val_10 = null;
        if(ClanWarUI.丈丐丞丐上丑且丕万() != false)
        {
                ClanWarUI.丑七不且上丗丁一世().U_GoToFortDefence();
            return;
        }
        
        val_9 = Rilisoft.ClansLobbyGui.丑七不且上丗丁一世();
        if(val_9 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        ClanWarUI.七丈且七七丘丛东上 = true;
        val_9 = Rilisoft.ClansLobbyGui.丑七不且上丗丁一世();
        if(val_9.OpenClanWar() == true)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        ClanWarUI.七丈且七七丘丛东上 = false;
    }
    public void U_Hide()
    {
        this.HideSelf();
    }
    public override void Hide()
    {
        if(this.与丕东丑丌丆与东丕 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.与丕东丑丌丆与东丕.Dispose();
        }
        
        this.Hide();
    }
    public ClanWarEventBanner()
    {
    
    }
    private static ClanWarEventBanner()
    {
        ClanWarEventBanner.丒丛一三丕东丁与丅 = 7200;
        ClanWarEventBanner.丕丂丁万丒上下丞东 = 0;
    }
    internal static bool 丈丕丞丘上丏三丕世(PGCompany.一丏不三且丆专东东 丆且丏下且丛丈七不)
    {
        丞丂丘丒丟丞丑下丄 val_4 = 0;
        PGCompany.Clans.Network.丞丝世上丏与丂丒上 val_2 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑();
        bool val_5 = val_2.丂丕万一丄一丂丗丒.TryGetValue(key:  丆且丏下且丛丈七不.丂丅丏丘世且丅丗三(), value: out  val_4);
        return (bool)(val_4 != 0) ? 1 : 0;
    }

}
