using UnityEngine;
internal sealed class ExpView : MonoBehaviour
{
    // Fields
    internal static ExpView 丄丘七三上丕世丞业;
    private LevelUpBanner 丛丁丁丁丌七丑丐专;
    private 专丑丈丙七丗世丆下 七丑一丄东丅三一丈;
    private Rilisoft.PrefabHandler _levelUpPanelPrefab;
    internal UnityEngine.GameObject LevelUpPanelsContainer;
    private Rilisoft.专丕丝丏丒一一万丏<LevelUpBanner> 下丄丄丝丂一丁丌丅;
    private UnityEngine.GameObject _expProgressContainer;
    private UnityEngine.GameObject _raitingProgressContainer;
    public UnityEngine.GameObject ratingPanel;
    public UIRoot interfaceHolder;
    public UnityEngine.Camera experienceCamera;
    public UISprite experienceFrame;
    
    // Properties
    internal bool 丅不不丟丙世且三丞 { get; }
    internal LevelUpBanner 丝不丐丘丞万丘业且 { get; }
    private Rilisoft.专丕丝丏丒一一万丏<LevelUpBanner> 下丛三丙丞丂丈丄丙 { get; }
    internal bool 丆丄三丌丆七丟丗不 { get; set; }
    internal 专丑丈丙七丗世丆下 世下丄丈一丞丞丕丞 { get; }
    
    // Methods
    internal bool 丐丛丁丅丟丆丟业丂()
    {
        Rilisoft.专丕丝丏丒一一万丏<LevelUpBanner> val_1 = this.丐丄下一丞丝丐丒丆();
        if(val_1 != null)
        {
                return val_1.丅专七丞东丐丒丒丗();
        }
        
        return val_1.丅专七丞东丐丒丒丗();
    }
    internal LevelUpBanner 丌世丘丁丁三丆丕七()
    {
        var val_5;
        var val_6;
        val_5 = this;
        if(this.丐丄下一丞丝丐丒丆().丅专七丞东丐丒丒丗() != false)
        {
                val_5 = this.丐丄下一丞丝丐丒丆();
            LevelUpBanner val_4 = val_5.世三丞丅丑丌丈丈一();
            return (LevelUpBanner)val_6;
        }
        
        val_6 = 0;
        return (LevelUpBanner)val_6;
    }
    private Rilisoft.专丕丝丏丒一一万丏<LevelUpBanner> 丐丄下一丞丝丐丒丆()
    {
        Rilisoft.专丕丝丏丒一一万丏<LevelUpBanner> val_3 = this.下丄丄丝丂一丁丌丅;
        if(val_3 != null)
        {
                return val_3;
        }
        
        Rilisoft.专丕丝丏丒一一万丏<LevelUpBanner> val_2 = null;
        val_3 = val_2;
        val_2 = new Rilisoft.专丕丝丏丒一一万丏<LevelUpBanner>(丆万丕丏与丈与丒丗:  this._levelUpPanelPrefab.ResourcePath, 丆丏七丟不丒与七专:  this.LevelUpPanelsContainer);
        this.下丄丄丝丂一丁丌丅 = val_3;
        return val_3;
    }
    internal bool 七丂下丗丏与丕丂下()
    {
        if(this._expProgressContainer != null)
        {
                return this._expProgressContainer.activeSelf;
        }
        
        return this._expProgressContainer.activeSelf;
    }
    internal void 上专丌专丁丏且丆一(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._expProgressContainer, 丏业丟一东丂东丘丛:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._raitingProgressContainer, 丏业丟一东丂东丘丛:  val_1);
    }
    internal 专丑丈丙七丗世丆下 上丞丏丏东且丒且丂()
    {
        专丑丈丙七丗世丆下 val_2 = this.七丑一丄东丅三一丈;
        if(val_2 != null)
        {
                return val_2;
        }
        
        专丑丈丙七丗世丆下 val_1 = null;
        val_2 = val_1;
        val_1 = new 专丑丈丙七丗世丆下();
        this.七丑一丄东丅三一丈 = val_2;
        return val_2;
    }
    private void Awake()
    {
        null = null;
        ExpView.丄丘七三上丕世丞业 = this;
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丈丏丕丞一丗丏丄丅(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void ExpView::东一丆不丝七丌丌一(Rilisoft.且丙业丂丞一丈丙七 东丞丙专下七丞且东)));
        this.三丁丘且不万丅丗三();
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ExpView::三丁丘且不万丅丗三()));
    }
    internal void 三丁丘且不万丅丗三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ratingPanel, 丏业丟一东丂东丘丛:  丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament"));
    }
    internal void 业丗万丒业丁丁丂丁()
    {
        UnityEngine.Debug.LogError(message:  "ExpView  ShowLevelUpPanel");
        LevelUpBanner val_2 = this.丐丄下一丞丝丐丒丆().世三丞丅丑丌丈丈一();
        this.丛丁丁丁丌七丑丐专 = val_2;
        val_2.丛不丒丌七丏丕业业(丆与丛丅丂三万一丑:  this.上丞丏丏东且丒且丂());
        ExpController.上专丟丙业丒且丕丘(世丞丑上丅与世丁世:  this.丛丁丁丁丌七丑丐专.gameObject);
    }
    internal void 不一丒丟丄丂下丅七(int 业丈丙丌上丛与丏丞, int 丑丒下三业丗丘丛丁)
    {
    
    }
    private void OnDestroy()
    {
        null = null;
        ExpView.丄丘七三上丕世丞业 = 0;
    }
    public ExpView()
    {
    
    }
    private static ExpView()
    {
    
    }
    private void 东一丆不丝七丌丌一(Rilisoft.且丙业丂丞一丈丙七 东丞丙专下七丞且东)
    {
        this.丐丄下一丞丝丐丒丆().丙不丂丝丒丐专丝丆();
    }

}
