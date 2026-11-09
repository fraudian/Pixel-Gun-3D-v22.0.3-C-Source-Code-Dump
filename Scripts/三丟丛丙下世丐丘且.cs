using UnityEngine;
private sealed class BonusPromotionsView.三丟丛丙下世丐丘且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BonusPromotionsView 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BonusPromotionsView.三丟丛丙下世丐丘且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BonusPromotionsView val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = this.丝且与丝丒丟万丁专;
        if((StoreKitEventListener.三丘丈不丝丕丞东丌() == true) || (PixelTime.丝丗专上三不丄丑丑() < 1))
        {
            goto label_7;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._purchaseIndicator, 丏业丟一东丂东丘丛:  false);
        this.丝且与丝丒丟万丁专.三丂丐丈丄专丛不专 = 0;
        val_3.丈且东丑丂且万丒丅();
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_7:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
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
