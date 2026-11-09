using UnityEngine;
public class GeneralBannerWindow : MonoBehaviour
{
    // Fields
    private System.Action <丟不不丆下丏丟丌丌>k__BackingField;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    
    // Properties
    public System.Action 丄且丗世丆丛丗业丄 { get; set; }
    
    // Methods
    public System.Action get_OnCloseCustomAction()
    {
        return (System.Action)this.<丟不不丆下丏丟丌丌>k__BackingField;
    }
    public void set_OnCloseCustomAction(System.Action 丙业与丙丗丝不丈东)
    {
        this.<丟不不丆下丏丟丌丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public virtual void HandleClose()
    {
        this.丑下丞丁丒丗丂世丗();
        if((this.<丟不不丆下丏丟丌丌>k__BackingField) == null)
        {
                return;
        }
        
        this.<丟不不丆下丏丟丌丌>k__BackingField.Invoke();
    }
    private void 丑下丞丁丒丗丂世丗()
    {
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    protected virtual void 丆下丟七专丁丕丕万()
    {
        this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void GeneralBannerWindow::业上丗不万丐与与丄()), 与且专丈不万东一万:  System.String.Format(format:  "{0} Controller", arg0:  this.gameObject.name));
    }
    protected virtual void 丁丝与丞与丝三业丆()
    {
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
    }
    protected virtual void 下丁丕丅与丛下丙专()
    {
        goto typeof(GeneralBannerWindow).__il2cppRuntimeField_168;
    }
    private void Start()
    {
        goto typeof(GeneralBannerWindow).__il2cppRuntimeField_178;
    }
    private void OnDestroy()
    {
        goto typeof(GeneralBannerWindow).__il2cppRuntimeField_188;
    }
    public GeneralBannerWindow()
    {
    
    }
    private void 业上丗不万丐与与丄()
    {
        goto typeof(GeneralBannerWindow).__il2cppRuntimeField_198;
    }

}
