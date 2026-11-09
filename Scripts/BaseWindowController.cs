using UnityEngine;
public class BaseWindowController : MonoBehaviour
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    public virtual void Hide()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    protected virtual void Awake()
    {
        this.东三世丙丁丒丝世丕();
        new System.Action() = new System.Action(object:  this, method:  typeof(BaseWindowController).__il2cppRuntimeField_170);
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "BaseWindowController");
    }
    protected virtual void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
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
    public BaseWindowController()
    {
    
    }

}
