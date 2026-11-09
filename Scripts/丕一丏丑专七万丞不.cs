using UnityEngine;
private sealed class StoreKitEventListener.丕一丏丑专七万丞不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Prime31.GooglePurchase 丛上丌丂业七不三世;
    public com.amazon.device.iap.cpt.PurchaseReceipt 丛丌丗丄三丞业与与;
    public StoreKitEventListener 丝且与丝丒丟万丁专;
    public string 万一下七丈丈丗世丐;
    private string 丅不上丄专下丐丏丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StoreKitEventListener.丕一丏丑专七万丞不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 49;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        com.amazon.device.iap.cpt.PurchaseReceipt val_11;
        string val_12;
        int val_13;
        var val_14;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        if(StoreKitEventListener.东与丆东七丏丘丂与() == true)
        {
            goto label_4;
        }
        
        this.一世丕丕业且且丅丌();
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_7;
        }
        
        val_11 = this.丛丌丗丄三丞业与与;
        this.丝且与丝丒丟万丁专.丗丂丝丏丙三与丑丅(丛丌丗丄三丞业与与:  val_11, 万丄丅丝三丈丆世丟:  this.万一下七丈丈丗世丐);
        goto label_10;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_10;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丛上丌丂业七不三世 == null)
        {
            goto label_11;
        }
        
        val_12 = this.丛上丌丂业七不三世.orderId;
        goto label_12;
        label_7:
        val_11 = this.丛上丌丂业七不三世;
        this.丝且与丝丒丟万丁专.不丘下且丒不且丆丒(丛上丌丂业七不三世:  val_11);
        label_10:
        val_13 = 0;
        return (bool)val_13;
        label_11:
        val_12 = this.丛丌丗丄三丞业与与.ReceiptId;
        label_12:
        this.丅不上丄专下丐丏丈 = val_12;
        val_14 = null;
        val_14 = null;
        val_12 = this.丅不上丄专下丐丏丈;
        StoreKitEventListener.丙丑上丗丝东业业丏.Add(item:  val_12);
        this.丗丏丅丕丆世丁专丟 = -3;
        label_4:
        val_11 = CoroutineRunner.Instance;
        if(val_11 != 0)
        {
                val_11 = CoroutineRunner.Instance;
            this.丒上七丌业七丟与丐 = val_11.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丏三三丆丈上丟三不(七且丆丞丌丘下世丑:  1f));
            val_13 = 1;
            this.丗丏丅丕丆世丁专丟 = val_13;
            return (bool)val_13;
        }
        
        UnityEngine.Debug.LogError(message:  "Amazon/Android WaitForX3And_GiveCurrency CoroutineRunner.Instance == null ");
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_13 = 1;
        return (bool)val_13;
    }
    private void 一世丕丕业且且丅丌()
    {
        var val_2;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_2 = null;
        val_2 = null;
        bool val_1 = StoreKitEventListener.丙丑上丗丝东业业丏.Remove(item:  this.丅不上丄专下丐丏丈);
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
