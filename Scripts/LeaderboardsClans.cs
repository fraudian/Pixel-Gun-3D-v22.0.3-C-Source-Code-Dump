using UnityEngine;
public class LeaderboardsClans : PGBehaviour, 丑且丆万丏丝丘丙丟
{
    // Fields
    private const string 业丄丛且丝三丗丏丅 = "NguiWindows/Leaderboards_Clans";
    private static LeaderboardsClans <丄且丂丙丒且七丈丆>k__BackingField;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private System.Action 三丁丕丈丅丏丅丕丌;
    private UILabel topClansFooterLabel;
    private UnityEngine.GameObject topClansTabContainer;
    private DynamicWrapGrid topClansWrapGrid;
    private UnityEngine.Transform topClansNotInTopHidedTransform;
    private LeaderboardsTopClansWrapGridItem topClansNotInTopItem;
    private UnityEngine.Transform topClansNotInTopShowedTransform;
    private System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丟丕且东丂东丆丟丟;
    
    // Properties
    internal static LeaderboardsClans 丄丘七三上丕世丞业 { get; set; }
    internal static bool 丘丈万丌丆世且专且 { get; }
    
    // Methods
    internal static LeaderboardsClans 与一丅丝不丈业与丙()
    {
        return (LeaderboardsClans)LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField;
    }
    private static void 丑一上丟丙不东与业(LeaderboardsClans 丙业与丙丗丝不丈东)
    {
        LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 丑丙丗世丏丞万世丒()
    {
        if((LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField) == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_2 = LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField.gameObject;
        if(val_2 != null)
        {
                return val_2.activeInHierarchy;
        }
        
        return val_2.activeInHierarchy;
    }
    internal static void 丌万丗与七丄丕不丁(System.Action 丛丝与丂世丌丌丝丂)
    {
        var val_7;
        if((LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField) == 0)
        {
                val_7 = null;
            val_7 = null;
            LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕(丑与丞三且丛与丟业:  "NguiWindows/Leaderboards_Clans", 七万上丐一丈丏丏专:  gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<LeaderboardsClans>();
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField);
        if((LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField) != null)
        {
                三丁丕丈丅丏丅丕丌 = 丛丝与丂世丌丌丝丂;
        }
        else
        {
                三丁丕丈丅丏丅丕丌 = 丛丝与丂世丌丌丝丂;
        }
        
        LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField.万七丄东丞丅丆三东();
    }
    internal static void 丗丟万丂丘丈专丄丂()
    {
        if(LeaderboardsClans.丑丙丗世丏丞万世丒() == false)
        {
                return;
        }
        
        if(null != 0)
        {
                Invoke();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 万七丄东丞丅丆三东()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.topClansNotInTopItem.infoParentWillBeMainMenu = true;
        this.丛丅专丁上一丞丄丈();
    }
    internal void 丛丅专丁上一丞丄丈()
    {
        UnityEngine.Object val_4;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topClansTabContainer, 丏业丟一东丂东丘丛:  false);
        this.丗业业不上丅万丄专();
        val_4 = Rilisoft.Singleton<ClansVisitController>.Instance;
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = Rilisoft.Singleton<ClansVisitController>.Instance;
        val_3.丞丌丕丛丒丟丐丏下 = 1;
    }
    private void 丗业业不上丅万丄专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topClansTabContainer, 丏业丟一东丂东丘丛:  true);
        this.topClansFooterLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8395");
        this.七东一丅丘不丐三丗(丑万丅丕丟丞下专丑:  true);
        Rilisoft.Singleton<LeaderboardsController>.Instance.丐丅丝下与丌上业丑();
    }
    private void 且一丙丕万万专丒丌()
    {
        var val_4;
        if(LeaderboardsClans.丑丙丗世丏丞万世丒() == false)
        {
                return;
        }
        
        if(this.丟丕且东丂东丆丟丟 != null)
        {
                var val_3 = (this.丟丕且东丂东丆丟丟.Count == 0) ? 1 : 0;
        }
        else
        {
                val_4 = 1;
        }
        
        this.七东一丅丘不丐三丗(丑万丅丕丟丞下专丑:  true);
    }
    private void 七东一丅丘不丐三丗(bool 丑万丅丕丟丞下专丑 = False)
    {
        System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> val_25;
        var val_26;
        var val_27;
        val_25 = val_1.丂世丁下且丛专丄丕;
        if(val_25 == null)
        {
                Rilisoft.Singleton<LeaderboardsController>.Instance.丅丝丑丟与丂丅丈七();
            val_25 = val_1.丂世丁下且丛专丄丕;
        }
        
        this.丟丕且东丂东丆丟丟 = val_25;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<丞丂丘丒丟丞丑下丄>(丑东与丅丐丅丂丞业:  val_25)) != false)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.topClansWrapGrid.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this.topClansNotInTopItem == 0)
        {
                return;
        }
        
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.topClansNotInTopItem.gameObject, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_16;
        }
        
        val_26 = 0;
        goto label_17;
        label_24:
        if((System.String.op_Equality(a:  this.丟丕且东丂东丆丟丟.Item[0].业丐丐三丕一丗丛丁(), b:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁())) == true)
        {
            goto label_22;
        }
        
        val_26 = 1;
        label_17:
        if(val_26 < this.丟丕且东丂东丆丟丟.Count)
        {
            goto label_24;
        }
        
        goto label_29;
        label_16:
        val_27 = 0;
        goto label_26;
        label_22:
        this.丟丕且东丂东丆丟丟.set_Item(index:  0, value:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟());
        if(val_26 == 1)
        {
            goto label_29;
        }
        
        this.丒丕丛上丞东丅丒丄(丐丘下丅与丁丈丁丆:  false);
        goto label_30;
        label_29:
        val_27 = 1;
        label_26:
        this.丒丕丛上丞东丅丒丄(丐丘下丅与丁丈丁丆:  true);
        val_25 = 0;
        label_30:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.topClansWrapGrid.gameObject, 丏业丟一东丂东丘丛:  true);
        System.Collections.Generic.List<TSource> val_19 = System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  this.丟丕且东丂东丆丟丟));
        if(this.topClansWrapGrid == null)
        {
            goto label_34;
        }
        
        if(丑万丅丕丟丞下专丑 == false)
        {
            goto label_35;
        }
        
        label_38:
        this.topClansWrapGrid.SetContent(三丏丑不业丏不丂丈:  val_19, 业丛丛世上丈丘丄东:  false);
        this.topClansWrapGrid.ScrollToCenterOnItem(世万专丛与丐丌专不:  0);
        goto label_37;
        label_34:
        if(丑万丅丕丟丞下专丑 == true)
        {
            goto label_38;
        }
        
        label_35:
        this.topClansWrapGrid.UpdateContent(三丏丑不业丏不丂丈:  val_19);
        label_37:
        if(this.topClansNotInTopItem.Widget == 0)
        {
                return;
        }
        
        if(this.topClansWrapGrid.ScaledItemWidth == 1)
        {
                return;
        }
        
        this.topClansNotInTopItem.Widget.width = this.topClansWrapGrid.ScaledItemWidth;
    }
    private void 丒丕丛上丞东丅丒丄(bool 丐丘下丅与丁丈丁丆)
    {
        float val_12;
        this.topClansWrapGrid.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topClansNotInTopItem.gameObject, 丏业丟一东丂东丘丛:  丐丘下丅与丁丈丁丆);
        UnityEngine.Transform val_4 = this.topClansNotInTopItem.transform;
        if(丐丘下丅与丁丈丁丆 == false)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_5 = this.topClansNotInTopShowedTransform.position;
        val_12 = val_5.x;
        val_4.position = new UnityEngine.Vector3() {x = val_12, y = val_5.y, z = val_5.z};
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_14;
        }
        
        丞丂丘丒丟丞丑下丄 val_9 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(this.topClansNotInTopItem != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_7:
        UnityEngine.Vector3 val_10 = this.topClansNotInTopHidedTransform.position;
        val_12 = val_10.x;
        val_4.position = new UnityEngine.Vector3() {x = val_12, y = val_10.y, z = val_10.z};
        label_14:
        this.topClansWrapGrid.gameObject.SetActive(value:  true);
    }
    public void U_ToBattleClick()
    {
        PGCompany.丌不丞丐世丞三丘丌 val_1 = new PGCompany.丌不丞丐世丞三丘丌();
        if(val_1 != null)
        {
                .Type = 11;
        }
        else
        {
                mem[16] = 11;
        }
        
        .GameMode = 2;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_1)) == null)
        {
                return;
        }
        
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public void U_BackRequest()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        LeaderboardsClans.丗丟万丂丘丈专丄丂();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  LeaderboardsClans.<丄且丂丙丒且七丈丆>k__BackingField);
    }
    private bool 丝东丐丝东三丈世丝()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        LeaderboardsClans.丗丟万丂丘丈专丄丂();
        return true;
    }
    private void OnEnable()
    {
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void LeaderboardsClans::U_BackRequest()), 与且专丈不万东一万:  "Leaderboards");
        }
        
        LeaderboardsController.万丅丙七丛丘丙丝与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsClans::且一丙丕万万专丒丌()));
    }
    private void OnDisable()
    {
        if(this.且丂七丑丈丞丈三丑 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.且丂七丑丈丞丈三丑.Dispose();
            this.且丂七丑丈丞丈三丑 = 0;
        }
        
        LeaderboardsController.一丒一不丗丝不丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsClans::且一丙丕万万专丒丌()));
    }
    private void OnDestroy()
    {
        LeaderboardsController.一丒一不丗丝不丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsClans::且一丙丕万万专丒丌()));
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public LeaderboardsClans()
    {
    
    }

}
