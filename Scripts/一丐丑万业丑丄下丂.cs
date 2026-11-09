using UnityEngine;
private sealed class EventStoreSkinBankViewItem.一丐丑万业丑丄下丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public EventStoreSkinBankViewItem 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EventStoreSkinBankViewItem.一丐丑万业丑丄下丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_11;
        int val_12;
        var val_13;
        System.Collections.Generic.IEnumerable<TSource> val_14;
        if((this.丗丏丅丕丆世丁专丟 == 2) || (this.丗丏丅丕丆世丁专丟 == 1))
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if(this.丝且与丝丒丟万丁专.Offer != null)
        {
                if(this.丝且与丝丒丟万丁专.Offer.世一丒专丛丏世丁丙() == false)
        {
            goto label_10;
        }
        
        }
        
        val_11 = 0;
        val_12 = 2;
        goto label_11;
        label_3:
        val_13 = 0;
        return (bool)val_13;
        label_10:
        if(this.丝且与丝丒丟万丁专.Offer.丑且一丐东三不丈丝() != 60)
        {
            goto label_15;
        }
        
        val_14 = this.丝且与丝丒丟万丁专.Offer.丏与丅专三丙与丘丒();
        if(val_14 == null)
        {
            goto label_18;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_14)) == false)
        {
            goto label_19;
        }
        
        val_14 = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  val_14);
        label_18:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_24;
        }
        
        goto label_21;
        label_15:
        this.丝且与丝丒丟万丁专.世世丈丒丒下一丐丅();
        goto label_26;
        label_19:
        val_14 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_24;
        }
        
        label_21:
        label_24:
        if(this.丝且与丝丒丟万丁专.下丁三一业万丐丘东 != val_14)
        {
                this.丝且与丝丒丟万丁专.丝一丅丆三东丂丞七();
        }
        else
        {
                this.丝且与丝丒丟万丁专.世世丈丒丒下一丐丅();
        }
        
        label_26:
        val_11 = this.三丛与七下专丅丕东;
        if(val_11 == null)
        {
                UnityEngine.WaitForSeconds val_10 = null;
            val_11 = val_10;
            val_10 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
            this.三丛与七下专丅丕东 = val_11;
        }
        
        val_12 = 1;
        label_11:
        val_13 = 1;
        this.丒上七丌业七丟与丐 = val_11;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_13;
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
