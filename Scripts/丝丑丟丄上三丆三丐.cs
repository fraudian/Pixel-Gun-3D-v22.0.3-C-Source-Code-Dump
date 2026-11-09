using UnityEngine;
private sealed class GiftController.丝丑丟丄上三丆三丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GiftController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftController.丝丑丟丄上三丆三丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GiftController val_7;
        System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        val_7 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_8.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_3;
        }
        
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  val_7, method:  System.Void GiftController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> val_6 = null;
        val_8 = val_6;
        val_6 = new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  val_7, method:  System.Void GiftController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  val_6);
        if(val_7 == null)
        {
            goto label_6;
        }
        
        val_7.万丟万专七丕丙丆世();
        goto label_7;
        label_3:
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_6:
        0.万丟万专七丕丙丆世();
        label_7:
        val_7.丛不丄与丅丘丙丁与();
        label_1:
        val_9 = 0;
        return (bool)val_9;
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
