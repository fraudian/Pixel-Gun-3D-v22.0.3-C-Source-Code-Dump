using UnityEngine;
private sealed class ConnectScene.世丄丌业世丅世专丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 丄七丙不丟丛与丏丐;
    public ConnectScene 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectScene.世丄丌业世丅世专丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ConnectScene val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丄七丙不丟丛与丏丐 == false)
        {
            goto label_3;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.lanScan;
        val_6.StopBroadCasting();
        return false;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6.七丘专丕上一丝丌丈();
        val_7 = static_value_081DACA8;
        val_7 = static_value_081DACA8;
        val_8 = mem[static_value_081DACA8 + 184];
        val_8 = static_value_081DACA8 + 184;
        val_8 = mem[static_value_081DACA8 + 184];
        val_8 = static_value_081DACA8 + 184;
        if(((static_value_081DACA8 + 184 + 16) != 0) && (this.丝且与丝丒丟万丁专.丛丂丘三丐丐丕世丂 != true))
        {
                val_9 = static_value_081DACA8;
            val_9 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  35, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  true);
        }
        
        val_6.丆丑与下业丆专且丄();
        val_6 = 丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世();
        if(val_6.丆丒丗丌丗丏丐与丐() == false)
        {
                return false;
        }
        
        val_6 = 丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世();
        val_6.丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  false);
        return false;
        label_3:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
