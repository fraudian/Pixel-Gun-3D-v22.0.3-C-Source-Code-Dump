using UnityEngine;
private sealed class FortDefenceLinkController.丄丟下业丕三丘丞三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FortDefenceLinkController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FortDefenceLinkController.丄丟下业丕三丘丞三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        float val_17;
        var val_18;
        var val_19;
        int val_20;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_30;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.七丌丁丒万专万七丟.Count >= 2)
        {
                val_17 = this.丝且与丝丒丟万丁专.七丌丁丒万专万七丟.Item[1];
            this.丝且与丝丒丟万丁专.damageDoor.三丁丆上上丒丐丏丗(世丙丟上丘上七万万:  val_17);
        }
        
        if(this.丝且与丝丒丟万丁专.七丌丁丒万专万七丟.Count >= 3)
        {
                val_17 = this.丝且与丝丒丟万丁专.七丌丁丒万专万七丟.Item[2];
            this.丝且与丝丒丟万丁专.damageChest.三丁丆上上丒丐丏丗(世丙丟上丘上七万万:  val_17);
        }
        
        List.Enumerator<T> val_5 = this.丝且与丝丒丟万丁专.listPointSpawn.GetEnumerator();
        label_18:
        if(((-1486335296) & 1) == 0)
        {
            goto label_13;
        }
        
        if(this.丝且与丝丒丟万丁专.七丌丁丒万专万七丟.Count < 1)
        {
            goto label_18;
        }
        
        val_7.丐丏七丌丕丗业且上().丄七丕且万专丅丞万(丟丆丆丝东世一丒丐:  this.丝且与丝丒丟万丁专.七丌丁丒万专万七丟.Item[0]);
        goto label_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_44:
        val_18 = null;
        val_18 = null;
        if(GameController.mode == 0)
        {
            goto label_48;
        }
        
        val_19 = null;
        val_19 = null;
        label_30:
        val_20 = 0;
        return (bool)val_20;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_12 = this.丝且与丝丒丟万丁专._listBonuseWithWeight.GetEnumerator();
        label_43:
        if(((-1486335328) & 1) == 0)
        {
            goto label_39;
        }
        
        string val_13 = val_7.丐丏七丌丕丗业且上();
        if((this.丝且与丝丒丟万丁专.丛万三丟丅丈业丕丘.ContainsKey(key:  val_13)) == true)
        {
            goto label_43;
        }
        
        this.丝且与丝丒丟万丁专.丛万三丟丅丈业丕丘.Add(key:  val_13, value:  val_13 >> 32);
        goto label_43;
        label_39:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_44;
        label_48:
        val_20 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_20;
        return (bool)val_20;
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
