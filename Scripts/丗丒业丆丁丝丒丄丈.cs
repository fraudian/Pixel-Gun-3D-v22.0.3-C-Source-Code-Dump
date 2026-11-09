using UnityEngine;
private sealed class PromoActionsGUIController.丗丒业丆丁丝丒丄丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PromoActionsGUIController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PromoActionsGUIController.丗丒业丆丁丝丒丄丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丅且东丙业丏丛东丛.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void PromoActionsGUIController::丏业且丅丁丅丟不世()));
        StickersController.且业东丛东且丏丕丌(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  public System.Void PromoActionsGUIController::MarkUpdateOnEnable()));
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = 0;
        this.丝且与丝丒丟万丁专.上丄丕丑丟丅万一东 = true;
        return (bool)val_3;
        label_2:
        val_3 = 0;
        return (bool)val_3;
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
