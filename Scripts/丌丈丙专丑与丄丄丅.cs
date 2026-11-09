using UnityEngine;
private sealed class Player_move_c.丌丈丙专丑与丄丄丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    private float 丄丆丆丟丑不丑下丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丌丈丙专丑与丄丄丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        不丘丄丝丗丒丙一丌 val_9;
        var val_12;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            this.丄丆丆丟丑不丑下丄 = 0f;
        }
        else
        {
                this.丗丏丅丕丆世丁专丟 = 0;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆;
        if(val_9 == null)
        {
                return false;
        }
        
        val_9 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆;
        return false;
        label_36:
        丆上不业丈丐且业丏(丏不丂丆且三丞丆丏:  2, 丛丅丘一丏丙且丌上:  false, 丗丄万丄丌丕丈丈三:  "");
        do
        {
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 1;
            return false;
        }
        while((this.丝且与丝丒丟万丁专.丕丞丑丝与丄东业上(丏不丂丆且三丞丆丏:  2)) == true);
        
        val_12 = null;
        val_12 = null;
        string val_7 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆.业上丙丞丐丄丆丅七();
        goto label_36;
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
