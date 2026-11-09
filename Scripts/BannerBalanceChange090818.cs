using UnityEngine;
public class BannerBalanceChange090818 : MonoBehaviour
{
    // Fields
    public UILabel coinCount;
    public UILabel gemsCount;
    public UnityEngine.GameObject firstBanner;
    public UnityEngine.GameObject secondBanner;
    public UnityEngine.GameObject tapAnywhereToClose;
    public UnityEngine.GameObject button;
    public UnityEngine.GameObject rewardContainer;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private void Awake()
    {
        this.东三世丙丁丒丝世丕();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void BannerBalanceChange090818::HandleOk()), 与且专丈不万东一万:  "BannerBalanceChange090818");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.firstBanner, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.secondBanner, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
    }
    public void HandleOk()
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
    public BannerBalanceChange090818()
    {
    
    }

}
