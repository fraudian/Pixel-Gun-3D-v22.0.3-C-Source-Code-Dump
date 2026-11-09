using UnityEngine;
internal sealed class CompetitionConnectWindow : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject sharedBackground;
    private UnityEngine.GameObject clicksBlocker;
    private UnityEngine.GameObject connectionStateView;
    private UILabel connectionTitleLabel;
    private UILabel connectionDescription;
    private UnityEngine.GameObject searchingStateView;
    private MatchMakingMember[] membersIcons;
    private WidgetLayout membersLayout;
    private Rilisoft.ButtonHandler SearchingCancelButton;
    private UnityEngine.GameObject gameIsReadyStateView;
    private UILabel timerLabel;
    private Rilisoft.ButtonHandler acceptButton;
    private UnityEngine.AudioClip alarmAudio;
    private UnityEngine.GameObject lateStateView;
    private UILabel lateMessageLabel;
    private Rilisoft.ButtonHandler lateOkButton;
    private UnityEngine.GameObject serverUnavailableView;
    private UnityEngine.GameObject leaveConfirmView;
    private Rilisoft.ButtonHandler leaveYesButton;
    private Rilisoft.ButtonHandler leaveNoButton;
    private UnityEngine.GameObject searchLastMatchView;
    private UnityEngine.GameObject reconnectView;
    private Rilisoft.ButtonHandler reconnectYesButton;
    private Rilisoft.ButtonHandler reconnectNoButton;
    private UnityEngine.GameObject matchEndView;
    private Rilisoft.ButtonHandler matchEndOkButton;
    private PenaltyConfirmDialog confirmDialog;
    private CompetitionConnectWindow.丙丟与丐三丐万万丆 丟丄丈上丌东丑丝三;
    private CompetitionConnectWindow.丙丟与丐三丐万万丆 丐业丙丂丛丞丝丗三;
    private CompetitionConnectWindow.丙丟与丐三丐万万丆 且七丂丙丌丛万丈且;
    private float 丑丄一丝世业专丛不;
    private bool 丑丈丕丁不丌丒业丘;
    private int 丛世丆且丆万丆丒万;
    private System.Action 丟万上三丙下丞丝丐;
    private bool 专与万丏丐丞丝万丌;
    private bool 丐与不丆丕丝丅丏一;
    private System.IDisposable 万且下世业丑专七业;
    private 七丆丐丕一丐丅丆丞 与东丟丛七丝专丝丈;
    private 丈且且世丏丟丅丒业 下且丒不三东丄下万;
    private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅;
    private int 下丞七丒业丂丈丘下;
    private Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌;
    private static bool 丘世业万丌丆专专丄;
    private static CompetitionConnectWindow.丑丈丟丟下丞世万丐 专万三万一丂丟丑丂;
    private static string 且丌且七东丌丝丕丛;
    
    // Properties
    internal static bool 丄丟丞丐万专万丂丘 { get; }
    internal static bool 与专丂且上世丞万丟 { get; }
    
    // Methods
    internal static bool 世世丂东丁丈丞丂世()
    {
        null = null;
        return (bool)CompetitionConnectWindow.丘世业万丌丆专专丄;
    }
    internal static bool 三丛丂丂专丕上丅世()
    {
        null = null;
        return (bool)(CompetitionConnectWindow.专万三万一丂丟丑丂 != 0) ? 1 : 0;
    }
    internal static void 不下丁一专业上东业()
    {
        var val_8;
        var val_9;
        string val_10;
        var val_11;
        var val_12;
        val_8 = PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丑七不且上丗丁一世().业丄丑七上专万七丘();
        val_9 = null;
        val_9 = null;
        val_10 = 0;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  CompetitionConnectWindow.且丌且七东丌丝丕丛)) != false)
        {
                val_11 = null;
            val_11 = null;
            val_10 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  CompetitionConnectWindow.且丌且七东丌丝丕丛);
        }
        
        if((val_8 == null) || (val_8.且丁丙丑丄丁丄与丑() == null))
        {
            goto label_12;
        }
        
        val_8 = val_8.且丁丙丑丄丁丄与丑();
        if((val_8.Equals(value:  val_10)) == false)
        {
            goto label_14;
        }
        
        label_12:
        label_19:
        CompetitionConnectWindow.专万三万一丂丟丑丂 = 0;
        return;
        label_14:
        val_12 = null;
        val_12 = null;
        CompetitionConnectWindow.丘世业万丌丆专专丄 = true;
        goto label_19;
    }
    private void 三下丛丕丙且丅丛三()
    {
        System.Action<System.String> val_7;
        System.Action<System.Int32> val_8;
        if(this.与东丟丛七丝专丝丈 != null)
        {
            goto label_1;
        }
        
        七丆丐丕一丐丅丆丞 val_1 = new 七丆丐丕一丐丅丆丞();
        this.与东丟丛七丝专丝丈 = val_1;
        val_7 = System.Delegate.Combine(a:  (七丆丐丕一丐丅丆丞)[1152921536970501920].丄不丗丂世丗七丁丐, b:  new System.Action<System.String>(object:  this, method:  System.Void CompetitionConnectWindow::丈丗丄且丘丈丘万业(string 丛下丄业丈东丆一丄)));
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_7 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_7 == null)
        {
            goto label_7;
        }
        
        label_4:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_7:
        .丄不丗丂世丗七丁丐 = val_7;
        val_8 = System.Delegate.Combine(a:  this.与东丟丛七丝专丝丈.丑丛丝丙丗丄丄丏丙, b:  new System.Action<System.Int32>(object:  this, method:  System.Void CompetitionConnectWindow::丑丟丈业丟丂世不丕(int 丌丒丝东丌下丕丁丅)));
        if(this.与东丟丛七丝专丝丈 == null)
        {
            goto label_9;
        }
        
        if(val_8 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_8 == null)
        {
            goto label_13;
        }
        
        label_10:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_13:
        this.与东丟丛七丝专丝丈.丑丛丝丙丗丄丄丏丙 = val_8;
        label_1:
        this.丝丅七丑上丟业不东();
        this.专与万丏丐丞丝万丌 = false;
        this.丐与不丆丕丝丅丏一 = false;
    }
    private void 丕丏丑下丘万丞上万()
    {
        System.Action<System.String> val_7;
        System.Action val_8;
        if(this.下且丒不三东丄下万 != null)
        {
            goto label_1;
        }
        
        丈且且世丏丟丅丒业 val_1 = new 丈且且世丏丟丅丒业();
        this.下且丒不三东丄下万 = val_1;
        val_7 = System.Delegate.Combine(a:  (丈且且世丏丟丅丒业)[1152921536970689696].丄不丗丂世丗七丁丐, b:  new System.Action<System.String>(object:  this, method:  System.Void CompetitionConnectWindow::业丞丆一一丞一丈丞(string 丂三丐业世丟丞丁丄)));
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_7 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_7 == null)
        {
            goto label_7;
        }
        
        label_4:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_7:
        .丄不丗丂世丗七丁丐 = val_7;
        val_8 = System.Delegate.Combine(a:  this.下且丒不三东丄下万.丘丂丗三东丟丟七七, b:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::三下专丑丗丐丕与与()));
        if(this.下且丒不三东丄下万 == null)
        {
            goto label_9;
        }
        
        if(val_8 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_8 == null)
        {
            goto label_13;
        }
        
        label_10:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_13:
        this.下且丒不三东丄下万.丘丂丗三东丟丟七七 = val_8;
        label_1:
        this.丝丅七丑上丟业不东();
    }
    private void 三下专丑丗丐丕与与()
    {
        this.丟丄丈上丌东丑丝三 = 12;
    }
    private void 业丞丆一一丞一丈丞(string 丂三丐业世丟丞丁丄)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂三丐业世丟丞丁丄)) != false)
        {
                this.丝丛丅专上业与丞七(丟丄下上丈丗丙丞世:  false);
            return;
        }
        
        this.丟丄丈上丌东丑丝三 = 11;
    }
    internal void 东丒丛丏丝与丝上上(bool 丘东丈丁丑丁丏东丝)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        CompetitionConnectWindow.丘世业万丌丆专专丄 = false;
        if(丘东丈丁丑丁丏东丝 != false)
        {
                与丟丆一七丛丆且丟 val_2 = PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丑七不且上丗丁一世().业丄丑七上专万七丘();
            if(val_2 == null)
        {
                return;
        }
        
            this.丟丄丈上丌东丑丝三 = 10;
            this.gameObject.SetActive(value:  true);
            this.丕丏丑下丘万丞上万();
            this.下且丒不三东丄下万.丈丏业一不下与丄万 = val_2;
            this.下且丒不三东丄下万.丁不丁丌丆丂丛丁丞();
            return;
        }
        
        val_5 = null;
        val_5 = null;
        CompetitionConnectWindow.专万三万一丂丟丑丂 = 0;
    }
    internal void 丘丌丄万丞一万丐丅(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅, Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑, int 下丞七丒业丂丈丘下)
    {
        this.三下丛丕丙且丅丛三();
        this.丐且丘丑与万丞丑丅 = 丐且丘丑与万丞丑丅;
        this.下丞七丒业丂丈丘下 = 下丞七丒业丂丈丘下;
        this.丐业丙丂丛丞丝丗三 = 0;
        this.丟万上三丙下丞丝丐 = 0;
        System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_1 = 丐且丘丑与万丞丑丅.业丄丄且丕丕不一万();
        if(((-1995381128) & 1) != 0)
        {
                业丞丟万不丄丂丘丑 = val_1.HasValue.丙东专丂世丈丏丁丂();
        }
        
        this.上且丗一丏丏万丅丌 = 业丞丟万不丄丂丘丑;
        if(丐且丘丑与万丞丑丅 != null)
        {
                int val_4 = 丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七();
        }
        
        this.与东丟丛七丝专丝丈.丘上丐世丆丑且丞丒(丞与丈丐业丞七业万:  丟丌丁且且世丈丈丟.不丛丁且丘丑上丕七(丂丛丑东不丅丈一东:  业丞丟万不丄丂丘丑), 万七东专三不业丈丛:  this.上且丗一丏丏万丅丌, 丛丝丁丗且丘丂与万:  下丞七丒业丂丈丘下, 一上丒丐丝七丕丗一:  new System.Nullable<System.Int32>() {HasValue = false});
        this.丟丁且丛一东丂丘丐(丄丏丞丂七世丕丙丞:  false);
        this.gameObject.SetActive(value:  true);
        this.专丛丕且丒东丟丏丄(与业丄丂丂丆下上丞:  GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  this.上且丗一丏丏万丅丌));
    }
    internal bool 丙东丞丛丝丅世七三()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeInHierarchy;
        }
        
        return val_1.activeInHierarchy;
    }
    internal void 丅丆丘丄丙一一丐丙(System.Action 丞丕不丙万世丘丙上)
    {
        if(this.丟丄丈上丌东丑丝三 != 9)
        {
                this.且七丂丙丌丛万丈且 = this.丟丄丈上丌东丑丝三;
        }
        
        this.丑丄一丝世业专丛不 = -1f;
        this.丟丄丈上丌东丑丝三 = 9;
        this.丂丝丕不丄丝丄不丂();
        this.丟万上三丙下丞丝丐 = 丞丕不丙万世丘丙上;
    }
    internal void 丆世与丑丆丅丐万且()
    {
        this.丞东丝万三丆丕丁下(不丟丗丏丛丕不丁丌:  null, 丁且丁丝丅丒丘不世:  null);
    }
    private void 丝丂丈丏丗丘且丒东()
    {
        var val_2;
        this.丄与专丝丄丅丒丏不();
        this.gameObject.SetActive(value:  false);
        val_2 = static_value_081DACA8;
        val_2 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.丏丐不三丘丌不丟不();
    }
    private void 丙丈丑丈一丑不丑丛()
    {
        System.Action<System.String> val_6;
        System.Action<System.Int32> val_7;
        if(this.与东丟丛七丝专丝丈 == null)
        {
            goto label_1;
        }
        
        if(((System.Delegate.Remove(source:  this.与东丟丛七丝专丝丈.丄不丗丂世丗七丁丐, value:  new System.Action<System.String>(object:  this, method:  System.Void CompetitionConnectWindow::丈丗丄且丘丈丘万业(string 丛下丄业丈东丆一丄)))) != null) && (null != null))
        {
                val_6 = 0;
        }
        
        this.与东丟丛七丝专丝丈.丄不丗丂世丗七丁丐 = val_6;
        val_7 = System.Delegate.Remove(source:  this.与东丟丛七丝专丝丈.丑丛丝丙丗丄丄丏丙, value:  new System.Action<System.Int32>(object:  this, method:  System.Void CompetitionConnectWindow::丑丟丈业丟丂世不丕(int 丌丒丝东丌下丕丁丅)));
        if(this.与东丟丛七丝专丝丈 == null)
        {
            goto label_5;
        }
        
        if(val_7 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_7 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_9:
        this.与东丟丛七丝专丝丈.丑丛丝丙丗丄丄丏丙 = val_7;
        this.与东丟丛七丝专丝丈 = 0;
        label_1:
        this.与丆丈丗丄丒东丈丘();
        this.且七丂丙丌丛万丈且 = 0;
    }
    private void 丌丙世上丒丗东且万()
    {
        System.Action<System.String> val_6;
        System.Action val_7;
        var val_8;
        if(this.下且丒不三东丄下万 == null)
        {
            goto label_1;
        }
        
        if(((System.Delegate.Remove(source:  this.下且丒不三东丄下万.丄不丗丂世丗七丁丐, value:  new System.Action<System.String>(object:  this, method:  System.Void CompetitionConnectWindow::业丞丆一一丞一丈丞(string 丂三丐业世丟丞丁丄)))) != null) && (null != null))
        {
                val_6 = 0;
        }
        
        this.下且丒不三东丄下万.丄不丗丂世丗七丁丐 = val_6;
        val_7 = System.Delegate.Remove(source:  this.下且丒不三东丄下万.丘丂丗三东丟丟七七, value:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::三下专丑丗丐丕与与()));
        if(this.下且丒不三东丄下万 == null)
        {
            goto label_5;
        }
        
        if(val_7 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_7 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_9:
        this.下且丒不三东丄下万.丘丂丗三东丟丟七七 = val_7;
        this.下且丒不三东丄下万 = 0;
        label_1:
        this.与丆丈丗丄丒东丈丘();
        this.且七丂丙丌丛万丈且 = 0;
        val_8 = null;
        val_8 = null;
        CompetitionConnectWindow.专万三万一丂丟丑丂 = 0;
    }
    private void 丝丅七丑上丟业不东()
    {
        var val_10;
        System.Action<System.Boolean> val_11;
        var val_12;
        丑丕与三丟且三丈丌 val_13;
        var val_14;
        System.Action<System.String> val_15;
        var val_16;
        System.Action val_17;
        val_10 = null;
        val_10 = null;
        val_12 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void CompetitionConnectWindow::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_12 = null;
            val_11 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_11;
        val_14 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂与丁东业上丄丛一, b:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CompetitionConnectWindow::OnFailedToConnect(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_14 = null;
            val_13 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_13;
        val_16 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丒丁七万丌一与丞丂, b:  new System.Action<System.String>(object:  this, method:  System.Void CompetitionConnectWindow::丒丁七万丌一与丞丂(string 丂七东不不丈一丐不)))) != null) && (null != null))
        {
                val_16 = null;
            val_15 = 0;
        }
        
        GameConnect.丒丁七万丌一与丞丂 = val_15;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::丂丐与丞丗丒丘丑上()))) != null) && (null != null))
        {
                val_17 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_17;
    }
    private void 与丆丈丗丄丒东丈丘()
    {
        var val_10;
        System.Action<System.Boolean> val_11;
        var val_12;
        丑丕与三丟且三丈丌 val_13;
        var val_14;
        System.Action<System.String> val_15;
        var val_16;
        System.Action val_17;
        val_10 = null;
        val_10 = null;
        val_12 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void CompetitionConnectWindow::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_12 = null;
            val_11 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_11;
        val_14 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂与丁东业上丄丛一, value:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CompetitionConnectWindow::OnFailedToConnect(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_14 = null;
            val_13 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_13;
        val_16 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丒丁七万丌一与丞丂, value:  new System.Action<System.String>(object:  this, method:  System.Void CompetitionConnectWindow::丒丁七万丌一与丞丂(string 丂七东不不丈一丐不)))) != null) && (null != null))
        {
                val_16 = null;
            val_15 = 0;
        }
        
        GameConnect.丒丁七万丌一与丞丂 = val_15;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::丂丐与丞丗丒丘丑上()))) != null) && (null != null))
        {
                val_17 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_17;
    }
    private void 丂丐与丞丗丒丘丑上()
    {
        this.OnConnectionFail();
    }
    private void 丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)
    {
        this.与丆丈丗丄丒东丈丘();
        丅丒丗丑丒丙丛不丆.下与业丒丝丕丙丘丙();
        if(this.与东丟丛七丝专丝丈 != null)
        {
                this.丑丈丕丁不丌丒业丘 = false;
            this.丑丄一丝世业专丛不 = 3f;
            this.与东丟丛七丝专丝丈.丈丕丄丅丛丐三一东();
            this.丙丈丑丈一丑不丑丛();
            this.丂丝丕不丄丝丄不丂();
            this.connectionTitleLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11430");
            this.connectionDescription.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11431");
            this.丟丄丈上丌东丑丝三 = 4;
            return;
        }
        
        if(this.下且丒不三东丄下万 == null)
        {
                return;
        }
        
        this.不丌丆丈丘丗三丝丑();
    }
    private void 不丌丆丈丘丗三丝丑()
    {
        this.丟丄丈上丌东丑丝三 = 12;
        if(this.下且丒不三东丄下万 != null)
        {
                this.下且丒不三东丄下万.丈丕丄丅丛丐三一东();
        }
        
        this.丌丙世上丒丗东且万();
    }
    private void OnFailedToConnect(int 丗丟上上丒丐丗丞丙)
    {
        this.OnConnectionFail();
    }
    private void 丒丁七万丌一与丞丂(string 丂七东不不丈一丐不)
    {
        this.OnConnectionFail();
    }
    private void 丈丗丄且丘丈丘万业(string 丛下丄业丈东丆一丄)
    {
        UnityEngine.Debug.Log(message:  "Room is ready!");
        this.丑丈丕丁不丌丒业丘 = true;
        if(this.丟丄丈上丌东丑丝三 == 1)
        {
                return;
        }
        
        this.专一丆业丝七丆七下();
    }
    private void 丑丟丈业丟丂世不丕(int 丌丒丝东丌下丕丁丅)
    {
        UnityEngine.Debug.Log(message:  "Count change! "("Count change! ") + 丌丒丝东丌下丕丁丅.ToString());
        this.丛世丆且丆万丆丒万 = 丌丒丝东丌下丕丁丅;
        this.丄七一丆丑一丌丆专();
    }
    private void 丗丄且丌下世上丈与(CompetitionConnectWindow.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且)
    {
        var val_16;
        this.丐业丙丂丛丞丝丗三 = 与丆丌丂丟丛丘丑且;
        丙丟与丐三丐万万丆 val_1 = this.丟丄丈上丌东丑丝三 - 1;
        if(val_1 >= 12)
        {
            goto label_0;
        }
        
        val_1 = val_1 & 65535;
        val_1 = 4015 >> val_1;
        if((val_1 & 1) != 0)
        {
            goto label_1;
        }
        
        label_0:
        if(this.clicksBlocker != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        this.clicksBlocker.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 13) ? 1 : 0);
        this.sharedBackground.SetActive(value:  (this.丟丄丈上丌东丑丝三 != 13) ? 1 : 0);
        val_16 = 1;
        this.connectionStateView.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 2) ? 1 : 0);
        this.searchingStateView.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 5) ? 1 : 0);
        this.gameIsReadyStateView.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 6) ? 1 : 0);
        this.lateStateView.SetActive(value:  ((this.丟丄丈上丌东丑丝三 - 7) < 2) ? 1 : 0);
        this.serverUnavailableView.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 3) ? 1 : 0);
        this.leaveConfirmView.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 9) ? 1 : 0);
        this.searchLastMatchView.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 10) ? 1 : 0);
        this.reconnectView.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 11) ? 1 : 0);
        this.matchEndView.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 12) ? 1 : 0);
        this.confirmDialog.gameObject.SetActive(value:  (this.丟丄丈上丌东丑丝三 == 13) ? 1 : 0);
        return;
        label_1:
        if(this.clicksBlocker != null)
        {
            goto label_17;
        }
        
        goto label_18;
    }
    private void 专丛丕且丒东丟丏丄(int 与业丄丂丂丆下上丞)
    {
        var val_3 = 0;
        goto label_0;
        label_6:
        this.membersIcons[0].gameObject.SetActive(value:  (val_3 < 与业丄丂丂丆下上丞) ? 1 : 0);
        val_3 = 1;
        label_0:
        if(val_3 < this.membersIcons.Length)
        {
            goto label_6;
        }
        
        this.membersLayout.Reposition();
    }
    private void 丄七一丆丑一丌丆专()
    {
        var val_2 = 0;
        goto label_0;
        label_5:
        this.membersIcons[0].丐丐丗丁东与丒丈丏(丙业与丙丗丝不丈东:  (val_2 < this.丛世丆且丆万丆丒万) ? 1 : 0);
        val_2 = 1;
        label_0:
        if(val_2 < this.membersIcons.Length)
        {
            goto label_5;
        }
    
    }
    private void 万丙丞丝三丑下业专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)
    {
        this.丄与专丝丄丅丒丏不();
        this.丞东丝万三丆丕丁下(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丁且丁丝丅丒丘不世:  丁且丁丝丅丒丘不世);
        if(this.丟万上三丙下丞丝丐 == null)
        {
                return;
        }
        
        this.丟万上三丙下丞丝丐.Invoke();
    }
    private void 上下丝世东七世丒世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)
    {
        this.丄与专丝丄丅丒丏不();
        this.丟丄丈上丌东丑丝三 = this.且七丂丙丌丛万丈且;
    }
    private void 丞东丝万三丆丕丁下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)
    {
        this.与丆丈丗丄丒东丈丘();
        if(this.与东丟丛七丝专丝丈 != null)
        {
                this.与东丟丛七丝专丝丈.下上丟丛下上万丞丐();
        }
        
        this.丙丈丑丈一丑不丑丛();
        this.gameObject.SetActive(value:  false);
    }
    private void 东不丏丂丂丝丟丞丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)
    {
        this.丝丂丈丏丗丘且丒东();
    }
    private void 与丝世一上一丒丙丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)
    {
        this.丒丁且业专丟丙丂不(丂丘下万丈丘丅一丄:  false);
    }
    private void 丁一丂丏丑丕丟专东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丅丛丒丌丈专万丐丄();
    }
    private void 丞上业世世一不一丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丟丄丈上丌东丑丝三 = 13;
        this.confirmDialog.且丕丈与丒丑丑业丝 = new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::丅丛丒丌丈专万丐丄());
        this.confirmDialog.丆上丙丝上上业业且 = new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::丒丛丌丑三丙七丘丘());
        this.confirmDialog.丐丗一万丌丗丄与不();
    }
    private void 丒丛丌丑三丙七丘丘()
    {
        this.丟丄丈上丌东丑丝三 = 11;
    }
    private void 丅丛丒丌丈专万丐丄()
    {
        string val_3;
        var val_4;
        if((this.下且丒不三东丄下万 != null) && (this.下且丒不三东丄下万.丈丏业一不下与丄万 != null))
        {
                val_3 = this.下且丒不三东丄下万.丈丏业一不下与丄万.且丁丙丑丄丁丄与丑();
        }
        else
        {
                val_3 = 0;
        }
        
        val_4 = null;
        val_4 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  CompetitionConnectWindow.且丌且七东丌丝丕丛, 下下丏一丙不丘丌丞:  val_3);
        this.丌丙世上丒丗东且万();
        this.gameObject.SetActive(value:  false);
    }
    private void 丑不与丁业丝丑专上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丒丁且业专丟丙丂不(丂丘下万丈丘丅一丄:  true);
    }
    private void 丁万丞世七丟业丛三()
    {
        this.丌丙世上丒丗东且万();
        this.gameObject.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        if(this.SearchingCancelButton != 0)
        {
                this.SearchingCancelButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::丞东丝万三丆丕丁下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.lateOkButton != 0)
        {
                this.lateOkButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::东不丏丂丂丝丟丞丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.acceptButton != 0)
        {
                this.acceptButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::与丝世一上一丒丙丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.leaveNoButton != 0)
        {
                this.leaveNoButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::上下丝世东七世丒世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.leaveYesButton != 0)
        {
                this.leaveYesButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::万丙丞丝三丑下业专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        this.丄与专丝丄丅丒丏不();
        this.丙丈丑丈一丑不丑丛();
        业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::东且且业丅一丐七上()));
        Progress.下丁下丂七丆丙七一.业丕丞万三东上丆丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::丗一丐一丛丐与且不()));
    }
    private void Awake()
    {
        if(this.SearchingCancelButton != 0)
        {
                this.SearchingCancelButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::丞东丝万三丆丕丁下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.lateOkButton != 0)
        {
                this.lateOkButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::东不丏丂丂丝丟丞丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.acceptButton != 0)
        {
                this.acceptButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::与丝世一上一丒丙丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.leaveNoButton != 0)
        {
                this.leaveNoButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::上下丝世东七世丒世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.leaveYesButton != 0)
        {
                this.leaveYesButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::万丙丞丝三丑下业专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丁且丁丝丅丒丘不世)));
        }
        
        if(this.reconnectYesButton != 0)
        {
                this.reconnectYesButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::丑不与丁业丝丑专上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.reconnectNoButton != 0)
        {
                this.reconnectNoButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::丞上业世世一不一丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.matchEndOkButton != 0)
        {
                this.matchEndOkButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CompetitionConnectWindow::丁一丂丏丑丕丟专东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::东且且业丅一丐七上()));
        Progress.下丁下丂七丆丙七一.丛丑丈丞丈三丂下丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::丗一丐一丛丐与且不()));
    }
    private void 丗一丐一丛丐与且不()
    {
        if(this.丙东丞丛丝丅世七三() == false)
        {
                return;
        }
        
        this.丞东丝万三丆丕丁下(不丟丗丏丛丕不丁丌:  null, 丁且丁丝丅丒丘不世:  null);
    }
    private void 东且且业丅一丐七上()
    {
        if(this.丙东丞丛丝丅世七三() == false)
        {
                return;
        }
        
        this.OnConnectionFail();
    }
    private void 三丙丆且东且丞丟三()
    {
        if(this.丐与不丆丕丝丅丏一 != false)
        {
                return;
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        if(this.丐且丘丑与万丞丑丅.七丂丌丈丄专丄三世() == true)
        {
                return;
        }
        
        this.丐与不丆丕丝丅丏一 = true;
        this.丞丁丏世下丕丄丏丌();
    }
    private void Update()
    {
        bool val_6;
        string val_7;
        val_6 = static_value_082C36EA;
        val_7 = this;
        val_6 = true;
        this.三丙丆且东且丞丟三();
        if(this.丟丄丈上丌东丑丝三 != this.丐业丙丂丛丞丝丗三)
        {
                this.丗丄且丌下世上丈与(与丆丌丂丟丛丘丑且:  this.丟丄丈上丌东丑丝三);
        }
        
        if(this.丑丄一丝世业专丛不 <= 0f)
        {
            goto label_2;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丑丄一丝世业专丛不 - val_1;
        this.丑丄一丝世业专丛不 = val_1;
        if(val_1 <= 0f)
        {
            goto label_3;
        }
        
        if(this.丟丄丈上丌东丑丝三 != 6)
        {
                return;
        }
        
        val_7 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11426"), arg0:  System.String.Format(format:  "{0:N0}", arg0:  this.丑丄一丝世业专丛不));
        this.timerLabel.text = val_7;
        return;
        label_2:
        if(this.丟丄丈上丌东丑丝三 != 3)
        {
                return;
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
                return;
        }
        
        this.丑丄一丝世业专丛不 = 3f;
        return;
        label_3:
        this.七丅丂且业丂丆专万();
    }
    private void 七丅丂且业丂丆专万()
    {
        丙丟与丐三丐万万丆 val_17 = this.丟丄丈上丌东丑丝三;
        val_17 = val_17 - 1;
        if(val_17 > 5)
        {
                return;
        }
        
        var val_18 = 106024288 + ((this.丟丄丈上丌东丑丝三 - 1)) << 2;
        val_18 = val_18 + 106024288;
        goto (106024288 + ((this.丟丄丈上丌东丑丝三 - 1)) << 2 + 106024288);
    }
    private void 丟丁且丛一东丂丘丐(bool 丄丏丞丂七世丕丙丞 = False)
    {
        this.丟丄丈上丌东丑丝三 = 1;
        this.丑丄一丝世业专丛不 = (丄丏丞丂七世丕丙丞 != true) ? 3f : 5f;
        this.丑丈丕丁不丌丒业丘 = false;
        this.丛世丆且丆万丆丒万 = 0;
        this.丂丝丕不丄丝丄不丂();
        this.connectionTitleLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0564");
        this.connectionDescription.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11422");
    }
    private void 丂丝丕不丄丝丄不丂()
    {
        if(this.万且下世业丑专七业 != null)
        {
                return;
        }
        
        this.万且下世业丑专七业 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::丕丛丁丝丛下且丈七()), 与且专丈不万东一万:  0);
    }
    private void 丄与专丝丄丅丒丏不()
    {
        if(this.万且下世业丑专七业 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.万且下世业丑专七业.Dispose();
        }
        
        this.万且下世业丑专七业 = 0;
    }
    private void 丕丛丁丝丛下且丈七()
    {
    
    }
    private void 丒丁且业专丟丙丂不(bool 丂丘下万丈丘丅一丄 = False)
    {
        this.丟丄丈上丌东丑丝三 = 2;
        this.丂丝丕不丄丝丄不丂();
        this.connectionTitleLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11423");
        this.connectionDescription.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11422");
        if(丂丘下万丈丘丅一丄 != false)
        {
                if(this.下且丒不三东丄下万 == null)
        {
                return;
        }
        
            this.下且丒不三东丄下万.上丂丆丆且丏东丝且(丌丁丅丌东丐丗丛丈:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::丁万丞世七丟业丛三()));
            return;
        }
        
        if(this.与东丟丛七丝专丝丈 == null)
        {
                return;
        }
        
        this.与东丟丛七丝专丝丈.上丂丆丆且丏东丝且(丌丁丅丌东丐丗丛丈:  new System.Action(object:  this, method:  System.Void CompetitionConnectWindow::不且不丛专丏丂七丁()), 丐且丘丑与万丞丑丅:  this.丐且丘丑与万丞丑丅);
    }
    private void 不且不丛专丏丂七丁()
    {
        this.丙丈丑丈一丑不丑丛();
        this.gameObject.SetActive(value:  false);
    }
    private void OnConnectionFail()
    {
        this.与丆丈丗丄丒东丈丘();
        if(this.与东丟丛七丝专丝丈 != null)
        {
                this.丟丄丈上丌东丑丝三 = 3;
            this.与东丟丛七丝专丝丈.丈丕丄丅丛丐三一东();
            this.丙丈丑丈一丑不丑丛();
            this.丂丝丕不丄丝丄不丂();
            this.丑丄一丝世业专丛不 = -1f;
            return;
        }
        
        if(this.下且丒不三东丄下万 == null)
        {
                return;
        }
        
        this.不丌丆丈丘丗三丝丑();
    }
    private void 一东丞丈丈丑下业丁()
    {
        this.丟丄丈上丌东丑丝三 = 5;
        this.丄七一丆丑一丌丆专();
    }
    private void 专一丆业丝七丆七下()
    {
        this.丂丝丕不丄丝丄不丂();
        this.丟丄丈上丌东丑丝三 = 6;
        this.丑丄一丝世业专丛不 = 10f;
        if(this.专与万丏丐丞丝万丌 == true)
        {
                return;
        }
        
        if(TapticPlugin.丛专丟下专丆丈三丘.一丏一丗下丕丝丒丗() != false)
        {
                TapticPlugin.丛专丟下专丆丈三丘.丌万且与丝丁业丝世(丆丂东丙业丛下丝丌:  1);
        }
        
        if(this.alarmAudio != 0)
        {
                UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.alarmAudio);
        }
        
        this.专与万丏丐丞丝万丌 = true;
    }
    private void 丗丗丆丕东丙丛下世()
    {
        this.丟丄丈上丌东丑丝三 = 7;
        if(this.lateMessageLabel == 0)
        {
                return;
        }
        
        this.lateMessageLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11427");
    }
    private void 丞丁丏世下丕丄丏丌()
    {
        this.丟丄丈上丌东丑丝三 = 8;
        if(this.lateMessageLabel != 0)
        {
                this.lateMessageLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11690");
        }
        
        this.丑丄一丝世业专丛不 = -1f;
        this.丄与专丝丄丅丒丏不();
        this.与丆丈丗丄丒东丈丘();
        if(this.与东丟丛七丝专丝丈 != null)
        {
                this.与东丟丛七丝专丝丈.下上丟丛下上万丞丐();
        }
        
        this.丙丈丑丈一丑不丑丛();
    }
    public CompetitionConnectWindow()
    {
    
    }
    private static CompetitionConnectWindow()
    {
        CompetitionConnectWindow.丘世业万丌丆专专丄 = false;
        CompetitionConnectWindow.专万三万一丂丟丑丂 = 2;
        CompetitionConnectWindow.且丌且七东丌丝丕丛 = "abrtrm";
    }

}
