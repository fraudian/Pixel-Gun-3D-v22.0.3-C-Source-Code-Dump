using UnityEngine;
private sealed class GoblinAutoCollectorClanLobby.丒丒丟丂丞丌三丐七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GoblinAutoCollectorClanLobby 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GoblinAutoCollectorClanLobby.丒丒丟丂丞丌三丐七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_26;
        int val_27;
        int val_28;
        object val_29;
        val_26 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_26;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27 = 一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与();
        if((this.丝且与丝丒丟万丁专._headerIdle != 0) && (this.丝且与丝丒丟万丁专._headerIdle.gameObject.activeSelf != false))
        {
                if(this.丝且与丝丒丟万丁专._headerIdle.gameObject.activeInHierarchy != false)
        {
                this.丝且与丝丒丟万丁专._headerIdle.丈且东丑丂且万丒丅(丂三丟丂丈丐丆丗丟:  val_27);
        }
        
        }
        
        if(((this.丝且与丝丒丟万丁专._headerFear == 0) || (this.丝且与丝丒丟万丁专._headerFear.gameObject.activeSelf == false)) || (this.丝且与丝丒丟万丁专._headerFear.gameObject.activeInHierarchy == false))
        {
            goto label_27;
        }
        
        this.丝且与丝丒丟万丁专._headerFear.丈且东丑丂且万丒丅(丂三丟丂丈丐丆丗丟:  val_27);
        goto label_27;
        label_1:
        val_28 = 0;
        goto label_28;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27 = 一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与();
        if((this.丝且与丝丒丟万丁专._headerIdle != 0) && (this.丝且与丝丒丟万丁专._headerIdle.gameObject.activeSelf != false))
        {
                if(this.丝且与丝丒丟万丁专._headerIdle.gameObject.activeInHierarchy != false)
        {
                this.丝且与丝丒丟万丁专._headerIdle.丈且东丑丂且万丒丅(丂三丟丂丈丐丆丗丟:  val_27);
        }
        
        }
        
        if((this.丝且与丝丒丟万丁专._headerFear != 0) && (this.丝且与丝丒丟万丁专._headerFear.gameObject.activeSelf != false))
        {
                if(this.丝且与丝丒丟万丁专._headerFear.gameObject.activeInHierarchy != false)
        {
                this.丝且与丝丒丟万丁专._headerFear.丈且东丑丂且万丒丅(丂三丟丂丈丐丆丗丟:  val_27);
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丞上世丈丂丟不世一();
        label_27:
        if(val_27 > 0)
        {
                丕世专丒丁不丁丅丁 val_23 = null;
            val_29 = val_23;
            val_23 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  1f);
            val_28 = 1;
        }
        else
        {
                if(this.丝且与丝丒丟万丁专.gameObject != 0)
        {
                this.丝且与丝丒丟万丁专.且三丛三丟不业丛一(丙业与丙丗丝不丈东:  false);
        }
        
            val_29 = 0;
            val_28 = 2;
            this.丝且与丝丒丟万丁专.丟丁东丘丝丙丑上万 = 0;
        }
        
        val_26 = 1;
        this.丒上七丌业七丟与丐 = val_29;
        label_28:
        this.丗丏丅丕丆世丁专丟 = val_28;
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
