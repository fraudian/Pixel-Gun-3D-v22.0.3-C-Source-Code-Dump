using UnityEngine;
public class LoadingTipsView : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Container;
    public PGCompany.BattlePass.BattlePassChallengeView bpChallengeView;
    internal PixelPassTaskView pixelPassTaskView;
    internal GuiApplyersGroup ppGuiApplyersGroup;
    internal UnityEngine.GameObject ppRobot;
    internal UnityEngine.GameObject bpRobot;
    public MapEventPauseUI eventCointainer;
    public EventTournamentTipUI tournamentContainer;
    private bool 丈专与丙丟不且丙丁;
    private bool 业丈七下丂丝世丛丈;
    public UITexture ObjectImage;
    public UILabel TipText;
    
    // Methods
    private void OnEnable()
    {
        PGCompany.PixelPass.丘丏丅丆丑下业丙七 val_1 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
        if(val_1 == null)
        {
                return;
        }
        
        PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_2 = val_1.丘丗不丂世丘三三丙();
        if(val_2 == null)
        {
                return;
        }
        
        PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.下丒与丈世七丈丑丒(丈丂七世丟丞丂丗丒:  val_2, 专与万丐七丌丐丁丂:  this.ppGuiApplyersGroup);
    }
    internal void 东丆丛丁丞丞且丂丌(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_6;
        UnityEngine.GameObject val_7;
        val_6 = 丐且丘丑与万丞丑丅;
        val_7 = this.Container;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.bpChallengeView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pixelPassTaskView, 丏业丟一东丂东丘丛:  false);
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = val_6.丌不丅不丞东万专专();
        if(((-708363800) & 1) == 0)
        {
                return;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_6.丌不丅不丞东万专专();
        if((-708363800) != 2)
        {
                if((-708363800) != 1)
        {
                return;
        }
        
            this.eventCointainer.gameObject.SetActive(value:  true);
            val_7 = this.tournamentContainer;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  false);
            this.eventCointainer.丄丈丕丒世丒世丆下(丐且丘丑与万丞丑丅:  val_6);
            return;
        }
        
        this.eventCointainer.gameObject.SetActive(value:  false);
        val_7 = this.tournamentContainer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  true);
        val_6 = val_6.七丑丅丘上丏世世丄();
        this.tournamentContainer.三丛丆上丈丆丗丆专(丕丗丘丑丛与丑业丒:  val_6);
    }
    public void SetTip(Rilisoft.丄丕丏东丆丌七与且 丆丛东丒丞一丈丘丆)
    {
        string val_12;
        UnityEngine.GameObject val_13;
        var val_14;
        this.eventCointainer.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.bpChallengeView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pixelPassTaskView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Container, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tournamentContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ObjectImage.gameObject, 丏业丟一东丂东丘丛:  false);
        if(丆丛东丒丞一丈丘丆 == null)
        {
                return;
        }
        
        UnityEngine.Coroutine val_5 = CoroutineRunner.Instance.StartCoroutine(routine:  this.业丏丌丂东且三丙丟(下上丐丆丝丟丝丒不:  丆丛东丒丞一丈丘丆.丗丅上丙丅与丒丞丗));
        val_12 = 丆丛东丒丞一丈丘丆.丌丛丏丂丞丒万下丂;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_12)) != true)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ObjectImage.gameObject, 丏业丟一东丂东丘丛:  true);
            val_12 = this.ObjectImage;
            UnityEngine.Texture val_9 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "LoadingTipsIcons/"("LoadingTipsIcons/") + 丆丛东丒丞一丈丘丆.丌丛丏丂丞丒万下丂);
        }
        
        if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ppRobot, 丏业丟一东丂东丘丛:  true);
            val_13 = this.bpRobot;
            val_14 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ppRobot, 丏业丟一东丂东丘丛:  false);
            val_13 = this.bpRobot;
            val_14 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Container, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丕不丝下丞丌不丆丆(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丟专三丙丒丄丂下与)
    {
        PGCompany.BattlePass.BattlePassChallengeView val_8;
        this.eventCointainer.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Container, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tournamentContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ObjectImage.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pixelPassTaskView, 丏业丟一东丂东丘丛:  false);
        val_8 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_8 == null)
        {
                return;
        }
        
        if(val_8.丗丄上丑丑丅丐丒丌() == true)
        {
                return;
        }
        
        if(val_8.专丁丟丏丁丏不丗三() == false)
        {
                return;
        }
        
        val_8 = this.bpChallengeView;
        if(val_8 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.bpChallengeView, 丏业丟一东丂东丘丛:  true);
        this.bpChallengeView.Setup(与且专丈不万东一万:  丟专三丙丒丄丂下与);
    }
    internal void 丒丁丂丛东下世丁丅(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)
    {
        PixelPassTaskView val_6;
        this.eventCointainer.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Container, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tournamentContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ObjectImage.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.bpChallengeView, 丏业丟一东丂东丘丛:  false);
        val_6 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
        if(val_6.丈万丙东东丒丏丆丝() == false)
        {
                return;
        }
        
        val_6 = this.pixelPassTaskView;
        if(val_6 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pixelPassTaskView, 丏业丟一东丂东丘丛:  true);
        this.pixelPassTaskView.丈且东丑丂且万丒丅(万不且且丛丆东丒业:  万不且且丛丆东丒业);
    }
    private System.Collections.IEnumerator 业丏丌丂东且三丙丟(string 下上丐丆丝丟丝丒不)
    {
        LoadingTipsView.丂丁丏丕丏丂丕丞丞 val_1 = new LoadingTipsView.丂丁丏丕丏丂丕丞丞();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .下上丐丆丝丟丝丒不 = 下上丐丆丝丟丝丒不;
        return (System.Collections.IEnumerator)val_1;
    }
    public LoadingTipsView()
    {
    
    }

}
