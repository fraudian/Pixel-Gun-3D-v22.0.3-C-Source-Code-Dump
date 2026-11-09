using UnityEngine;
private sealed class 丑世丁三不丘丛一丑.丏丘丛丝丘东丙且丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.丑世丁三不丘丛一丑 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丑世丁三不丘丛一丑.丏丘丛丝丘东丙且丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_25;
        int val_26;
        var val_27;
        var val_28;
        var val_29;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((0.丐下丗丏不且丟丁丅() == null) || (0.丐下丗丏不且丟丁丅().三丝业丁东东丒下丁() == false))
        {
            goto label_6;
        }
        
        Progress.下丁下丂七丆丙七一 val_4 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_4.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  93);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_10;
        }
        
        val_25 = val_4.丐下丗丏不且丟丁丅();
        goto label_11;
        label_1:
        val_26 = 0;
        return (bool)val_26;
        label_10:
        val_25 = 0.丐下丗丏不且丟丁丅();
        label_11:
        val_25.丈丗丏丙丒丐丏丂丝(丙业与丙丗丝不丈东:  0.丐下丗丏不且丟丁丅().丄上丕丙丕丑丆丛丘());
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_27 = val_25.丐下丗丏不且丟丁丅();
        }
        else
        {
                val_27 = 0.丐下丗丏不且丟丁丅();
        }
        
        val_27.万丑专业丛丛且七丗(丙业与丙丗丝不丈东:  0.丐下丗丏不且丟丁丅().丞下丈七丈三丄不丙());
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_28 = val_27.丐下丗丏不且丟丁丅();
        }
        else
        {
                val_28 = 0.丐下丗丏不且丟丁丅();
        }
        
        val_28.下东丅下丛丗丅丂专(丙业与丙丗丝不丈东:  0.丐下丗丏不且丟丁丅().丟三七丛丑丁丒丗三());
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_29 = val_28.丐下丗丏不且丟丁丅();
        }
        else
        {
                val_29 = 0.丐下丗丏不且丟丁丅();
        }
        
        val_29.丛不丞上丝丏丐丑上(丙业与丙丗丝不丈东:  0.丐下丗丏不且丟丁丅().业丈丈专丗一丗丁与());
        丅丛丟上丁丆上丛专.不七不丙丏上与三一().丆丛丒丏丒东丅丆且(世丂七与丙与丞丐东:  0.丐下丗丏不且丟丁丅());
        0.丐下丗丏不且丟丁丅().丆丏万专丆上丞丟三(丙业与丙丗丝不丈东:  false);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        label_6:
        val_26 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
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
