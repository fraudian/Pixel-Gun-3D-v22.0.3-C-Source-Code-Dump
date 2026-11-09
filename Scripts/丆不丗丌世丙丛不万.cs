using UnityEngine;
private sealed class RentalPanelViewModel.丆不丗丌世丙丛不万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.RentalPanelViewModel 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RentalPanelViewModel.丆不丗丌世丙丛不万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专._timerLabel != 0)
        {
            goto label_9;
        }
        
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        if(this.丝且与丝丒丟万丁专.丐与业与三丌上与且() == true)
        {
            goto label_10;
        }
        
        this.丒上七丌业七丟与丐 = PGCompany.RentalPanelViewModel.丙丑万丂丁东且丏业();
        val_5 = 1;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_10:
        this.丒上七丌业七丟与丐 = PGCompany.RentalPanelViewModel.丂丒三一丈一业丘丝();
        val_5 = 1;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_5;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
