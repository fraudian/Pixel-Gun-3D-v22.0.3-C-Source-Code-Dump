using UnityEngine;
public sealed class PlayerSavedStateListener : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal 丕丁丕上与丅不丙丄 三丗且三丌专丅丝东;
    private bool <丒丕丗丝丌丈丙不三>k__BackingField;
    
    // Properties
    internal bool 且丟丗丂丙丈丟三专 { get; set; }
    
    // Methods
    internal bool 丗丘丛丛丐一丗世丆()
    {
        return (bool)this.<丒丕丗丝丌丈丙不三>k__BackingField;
    }
    private void 丐下丞与不业下万丝(bool 丙业与丙丗丝不丈东)
    {
        this.<丒丕丗丝丌丈丙不三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        if((丞世不丒下上上丝丑 & 255) != 218)
        {
                return false;
        }
        
        this.丄上丏东万丌业丆丈(专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        return true;
    }
    private void 丄上丏东万丌业丆丈(object[] 专丒丌丆下丐丞丟丞)
    {
        System.Object[] val_4 = 专丒丌丆下丐丞丟丞;
        object val_4 = val_4[0];
        if(null != 1)
        {
                return;
        }
        
        val_4 = System.Convert.ToString(value:  val_4[1]);
        var val_6 = 0;
        val_6 = val_6 + 1;
        this.三丗且三丌专丅丝东 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        this.<丒丕丗丝丌丈丙不三>k__BackingField = true;
    }
    public PlayerSavedStateListener()
    {
    
    }

}
