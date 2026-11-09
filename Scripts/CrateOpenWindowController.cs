using UnityEngine;
public class CrateOpenWindowController : MonoBehaviour
{
    // Fields
    public UITexture crateIcon;
    public UILabel[] windowHeader;
    public UILabel animDetailCount1;
    public UILabel animDetailRarity1;
    public UnityEngine.GameObject[] detailContainers;
    public UILabel[] detailLabels;
    private UIBasicSprite[] detailIcons;
    public UIPanel animPanel;
    public UnityEngine.Animator detailsAnimator;
    public UIBasicSprite animationTexture1;
    public UIBasicSprite animationTexture2;
    public float animationDuration;
    public float animationSpeedMultiplyer;
    public PositionHolder posHolder;
    private bool 丟丑丕丑丅上丆丝丛;
    private UnityEngine.Coroutine 丟丒丘且丝丕万万一;
    private System.Collections.Generic.Dictionary<string, int> <丏世丟丈丆丈丅东丑>k__BackingField;
    private System.Collections.Generic.List<string> 丟丙业上三丈且专丒;
    private bool 丒上丏丏丅丕丗丛丞;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    private UIBasicSprite[] 东丗不丕丑丁丑丕且 { get; }
    private System.Collections.Generic.Dictionary<string, int> 丘丅不丙丞万丁专上 { get; set; }
    
    // Methods
    private UIBasicSprite[] 丝与丁丌丛下丛丈丕()
    {
        UIBasicSprite[] val_3;
        var val_4;
        if(this.丟丑丕丑丅上丆丝丛 != false)
        {
                val_3 = this.detailIcons;
            return val_3;
        }
        
        this.丟丑丕丑丅上丆丝丛 = true;
        val_3 = new UIBasicSprite[0];
        val_4 = 0;
        goto label_4;
        label_15:
        UIBasicSprite val_2 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.detailIcons[0]);
        if(val_3 == null)
        {
            goto label_8;
        }
        
        if(val_2 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_2 == null)
        {
            goto label_12;
        }
        
        label_9:
        label_12:
        val_4 = 1;
        val_3[0] = val_2;
        label_4:
        if(val_4 < this.detailIcons.Length)
        {
            goto label_15;
        }
        
        this.detailIcons = val_3;
        return val_3;
    }
    private System.Collections.IEnumerator 丞三三丑丞丂丐丝世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CrateOpenWindowController.东且丙丞丝世丘丂丙();
    }
    private void 丟丆东万一丝丌丟丂()
    {
        this.detailsAnimator.gameObject.SetActive(value:  false);
        this.丒上丏丏丅丕丗丛丞 = false;
    }
    private void 丌丂上丈三丈丈丏世()
    {
    
    }
    private void Awake()
    {
        this.东三世丙丁丒丝世丕();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void CrateOpenWindowController::HandleBackgroundTapped()), 与且专丈不万东一万:  "CrateOpenWindowController");
        this.animationTexture1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.animationTexture1);
        this.animationTexture2 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.animationTexture2);
    }
    private void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
    }
    public void HandleBackgroundTapped()
    {
        if(this.丒上丏丏丅丕丗丛丞 != false)
        {
                if(this.丟丒丘且丝丕万万一 != null)
        {
                this.StopCoroutine(routine:  this.丟丒丘且丝丕万万一);
            this.丟丒丘且丝丕万万一 = 0;
        }
        
            this.丟丆东万一丝丌丟丂();
            return;
        }
        
        this.丆世与丑丆丅丐万且();
    }
    private void 丆世与丑丆丅丐万且()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void 东三世丙丁丒丝世丕()
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
    private System.Collections.Generic.Dictionary<string, int> 丐丏丌万三下丞丑丗()
    {
        return (System.Collections.Generic.Dictionary<System.String, System.Int32>)this.<丏世丟丈丆丈丅东丑>k__BackingField;
    }
    private void 业丅万丙业丅东丛七(System.Collections.Generic.Dictionary<string, int> 丙业与丙丗丝不丈东)
    {
        this.<丏世丟丈丆丈丅东丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public CrateOpenWindowController()
    {
        this.丟丙业上三丈且专丒 = new System.Collections.Generic.List<System.String>();
    }

}
