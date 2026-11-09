using UnityEngine;
private sealed class TcpClient.<>c__DisplayClass58_0
{
    // Fields
    public System.Threading.ManualResetEvent mre;
    
    // Methods
    public TcpClient.<>c__DisplayClass58_0()
    {
    
    }
    internal void <Connect>b__0(System.IAsyncResult res)
    {
        bool val_1 = this.mre.Set();
    }

}
