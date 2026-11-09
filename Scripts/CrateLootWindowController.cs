using UnityEngine;
public class CrateLootWindowController : MonoBehaviour
{
    // Fields
    public UILabel price;
    public UISprite currencyIcon;
    public UITexture crateIcon;
    public UILabel boltsLoot;
    public UILabel tapeLoot;
    public UILabel uniquieLoot;
    public UnityEngine.GameObject uniqueLootContainer;
    public UIScrollView detailsScroll;
    public UIScrollView itemsScroll;
    public UIWrapContent detailsWrapContent;
    public UIWrapContent itemsWrapContent;
    public UICenterOnChild detailsCenterOnChild;
    public UICenterOnChild itemsCenterOnChild;
    public CrateLootItemView detailViewPrototype;
    public CrateLootItemView itemViewPrototype;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    public void Setup(string 不丁丗世丌丛丐三丐)
    {
    
    }
    private void Awake()
    {
        this.东三世丙丁丒丝世丕();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void CrateLootWindowController::HandleBackgroundTapped()), 与且专丈不万东一万:  "CrateLootWindowController");
    }
    private void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
    }
    public void HandleBackgroundTapped()
    {
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
    public CrateLootWindowController()
    {
    
    }

}
