using UnityEngine;
internal sealed class MarathonButtonController : PGBehaviour
{
    // Fields
    private WidgetLayout layout;
    private UnityEngine.GameObject marathonHolder;
    private UnityEngine.GameObject notificationHolder;
    private UILabel notificationLabel;
    private readonly UnityEngine.WaitForSeconds 一丌丁丄丝丞七丗不;
    
    // Methods
    private void Start()
    {
    
    }
    private void OnDestroy()
    {
    
    }
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丟七丄丘七丛世丒丁()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丐且丌丟丛万丗丙丑(丈下与且下万丛丅与 丘业丕不丏丂丌丙且)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.marathonHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notificationHolder, 丏业丟一东丂东丘丛:  false);
        this.layout.Reposition();
    }
    private System.Collections.IEnumerator 业丏丈一东丘丏丏下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MarathonButtonController.丑丁丟丝丝下一不丙();
    }
    public void U_ButtonPressed()
    {
        PGCompany.Marathon.且丐丝七丅一丟丕丈.丑七不且上丗丁一世().世丕丁七丒世丌丌丅();
    }
    public MarathonButtonController()
    {
        this.一丌丁丄丝丞七丗不 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
    }

}
