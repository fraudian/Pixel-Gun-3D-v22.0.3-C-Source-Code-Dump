using UnityEngine;
private sealed class 丁丅业三七丗丁丏丙.丝丛世业七丙丐丝丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.Generic.List<System.Threading.CancellationTokenSource> 丞丌丌丌丑三丛丒业;
    public UIWidget 世丌丌丙丞丟下东丞;
    public float 丄万丒三丛一且丟丑;
    public float 一丟丞丆丟丑丕东不;
    public float 丌东丌专丗与与丞丄;
    public float 丏丏不上世一丛丏丏;
    private float 丌丂专丕东丈丙且丐;
    private System.Threading.CancellationTokenSource 丏丟丛丏丝丂七丑丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丁丅业三七丗丁丏丙.丝丛世业七丙丐丝丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<System.Threading.CancellationTokenSource> val_7;
        System.Threading.CancellationTokenSource val_8;
        int val_9;
        float val_10;
        int val_11;
        float val_12;
        float val_13;
        float val_14;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丌丂专丕东丈丙且丐 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Threading.CancellationTokenSource val_1 = new System.Threading.CancellationTokenSource();
        val_7 = this.丞丌丌丌丑三丛丒业;
        val_8 = this.丏丟丛丏丝丂七丑丒;
        this.丏丟丛丏丝丂七丑丒 = val_1;
        val_9 = 1152921539145866112;
        val_7.Add(item:  val_1);
        goto label_4;
        label_1:
        val_9 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        val_8 = this.丏丟丛丏丝丂七丑丒;
        label_4:
        System.Threading.CancellationToken val_2 = mem[this.丏丟丛丏丝丂七丑丒].Token;
        if((179311112 & 1) == 0)
        {
            goto label_6;
        }
        
        val_7 = this.丏丟丛丏丝丂七丑丒;
        bool val_3 = this.丞丌丌丌丑三丛丒业.Remove(item:  val_7);
        val_10 = this.丄万丒三丛一且丟丑;
        label_2:
        val_11 = 0;
        return (bool)val_11;
        label_6:
        val_12 = this.丌丂专丕东丈丙且丐;
        if(val_12 < this.一丟丞丆丟丑丕东不)
        {
                val_13 = this.丌东丌专丗与与丞丄;
            val_14 = this.丏丏不上世一丛丏丏;
        }
        else
        {
                val_12 = 0f;
            val_13 = this.丏丏不上世一丛丏丏;
            val_14 = this.丌东丌专丗与与丞丄;
            this.丏丏不上世一丛丏丏 = this.丌东丌专丗与与丞丄;
            this.丌丂专丕东丈丙且丐 = 0f;
            this.丌东丌专丗与与丞丄 = this.丏丏不上世一丛丏丏;
        }
        
        float val_5 = UnityEngine.Mathf.Lerp(a:  val_13, b:  val_14, t:  val_12 / this.一丟丞丆丟丑丕东不);
        val_10 = this.丌丂专丕东丈丙且丐;
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = val_10 + val_6;
        val_11 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丌丂专丕东丈丙且丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
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
