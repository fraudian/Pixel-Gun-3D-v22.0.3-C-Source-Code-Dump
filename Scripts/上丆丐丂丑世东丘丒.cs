using UnityEngine;
private sealed class 一一丘丆丗下丗下七.上丆丐丂丑世东丘丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 丟丟且且丙丌下丅丗 万丅丝丈上丅丘丈丘;
    public 一一丘丆丗下丗下七 丝且与丝丒丟万丁专;
    private ExitGames.Client.Photon.PhotonPing 三下丌专丗且不七丑;
    private float 丁东东且丑丕丁丆且;
    private int 下上东业丅专与下上;
    private string 丝东东丅业世万七世;
    private UnityEngine.WaitForSeconds 一丘丏丌丛丟上丘丘;
    private int 世丙世且丆丑与专下;
    private bool 且丅丏下丞丏丐丗万;
    private System.Diagnostics.Stopwatch 东丆丕丁丗丐丒丐丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 一一丘丆丗下丗下七.上丆丐丂丑世东丘丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        一一丘丆丗下丗下七 val_30;
        int val_35;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_28 = 106022060 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_30 = this.丝且与丝丒丟万丁专;
            val_28 = val_28 + 106022060;
        }
        else
        {
                val_35 = 0;
            return (bool);
        }
    
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
