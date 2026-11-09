using UnityEngine;
public class PropertyInfoScreenController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject description;
    public UnityEngine.GameObject descriptionMelee;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    
    // Methods
    public virtual void Show(bool 丒丘上丏丕丒一丒与)
    {
        this.gameObject.SetActive(value:  true);
        (丒丘上丏丕丒一丒与 != true) ? this.descriptionMelee : this.description.SetActive(value:  true);
        (丒丘上丏丕丒一丒与 != true) ? this.description : this.descriptionMelee.SetActive(value:  false);
    }
    public virtual void Hide()
    {
        this.gameObject.SetActive(value:  false);
    }
    private void OnEnable()
    {
        if(this.且丂七丑丈丞丈三丑 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.且丂七丑丈丞丈三丑.Dispose();
        }
        
        this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PropertyInfoScreenController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Property Info");
    }
    private void OnDisable()
    {
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
        this.且丂七丑丈丞丈三丑 = 0;
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        goto typeof(PropertyInfoScreenController).__il2cppRuntimeField_178;
    }
    public PropertyInfoScreenController()
    {
    
    }

}
