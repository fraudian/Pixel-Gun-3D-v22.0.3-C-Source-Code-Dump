using UnityEngine;
internal sealed class DisableHardwareBack : PGBehaviour
{
    // Fields
    private System.IDisposable 东三世丝丒三一丈丛;
    
    // Methods
    private void OnEnable()
    {
        if(this.东三世丝丒三一丈丛 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  0);
    }
    private void OnDisable()
    {
        if(this.东三世丝丒三一丈丛 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    public DisableHardwareBack()
    {
    
    }

}
