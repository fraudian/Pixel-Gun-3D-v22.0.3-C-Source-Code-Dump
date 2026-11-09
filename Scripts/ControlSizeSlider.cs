using UnityEngine;
internal sealed class ControlSizeSlider : MonoBehaviour
{
    // Fields
    public UISlider slider;
    private System.EventHandler<ControlSizeSlider.三与丝丛丙东丌丙世> 一丙丝丟丁三丘且丆;
    
    // Methods
    public void add_EnabledChanged(System.EventHandler<ControlSizeSlider.三与丝丛丙东丌丙世> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.一丙丝丟丁三丘且丆, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丙丝丟丁三丘且丆 != 1152921537031480480);
    
    }
    public void remove_EnabledChanged(System.EventHandler<ControlSizeSlider.三与丝丛丙东丌丙世> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.一丙丝丟丁三丘且丆, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丙丝丟丁三丘且丆 != 1152921537031617056);
    
    }
    private void OnEnable()
    {
        if(this.一丙丝丟丁三丘且丆 == null)
        {
                return;
        }
        
        .<丛丌且业丆丑丗丘丄>k__BackingField = true;
        this.一丙丝丟丁三丘且丆.Invoke(sender:  this.slider, e:  new ControlSizeSlider.三与丝丛丙东丌丙世());
    }
    private void OnDisable()
    {
        if(this.一丙丝丟丁三丘且丆 == null)
        {
                return;
        }
        
        .<丛丌且业丆丑丗丘丄>k__BackingField = false;
        this.一丙丝丟丁三丘且丆.Invoke(sender:  this.slider, e:  new ControlSizeSlider.三与丝丛丙东丌丙世());
    }
    public ControlSizeSlider()
    {
    
    }

}
