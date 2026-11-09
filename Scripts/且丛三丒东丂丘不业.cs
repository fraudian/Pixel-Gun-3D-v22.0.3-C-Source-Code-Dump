using UnityEngine;
private sealed class BonusCreator.且丛三丒东丂丘不业 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public BonusCreator 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BonusCreator.且丛三丒东丂丘不业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ZombieCreator val_39;
        int val_40;
        float val_41;
        var val_42;
        UnityEngine.Transform val_43;
        var val_44;
        float val_45;
        var val_46;
        var val_47;
        var val_48;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_39 = this.丝且与丝丒丟万丁专.丏丗与丝丗丈丌丛丝;
        if(this.丝且与丝丒丟万丁专.丏丗与丝丗丈丌丛丝.stopGeneratingBonuses == false)
        {
            goto label_4;
        }
        
        val_40 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_40;
        label_1:
        val_40 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_40;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_41 = this.丝且与丝丒丟万丁专.weaponCreationInterval;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  val_41);
        goto label_58;
        label_4:
        int val_39 = 丟丌丁且且世丈丈丟.丆丂丆丂上丄下丒丒();
        val_39 = val_39 - this.丝且与丝丒丟万丁专.丏丗与丝丗丈丌丛丝.丌丟且丛丄丒万丈丑();
        if((val_39 <= 0) && (GameConnect.上丏丈七丘丁与丅丏() != false))
        {
                if(this.丝且与丝丒丟万丁专.丏丗与丝丗丈丌丛丝.bossShowm == false)
        {
                return (bool)val_40;
        }
        
        }
        
        val_42 = null;
        val_42 = null;
        BonusCreationZone val_8 = BonusController.上丒丒七丙专业丘丗.Item[UnityEngine.Random.Range(min:  0, max:  BonusController.上丒丒七丙专业丘丗.Count)];
        UnityEngine.Vector3 val_9 = val_8.boxCollider.size;
        val_43 = val_8.万东万丆专丌丕丐丗;
        UnityEngine.Vector3 val_10 = val_43.localScale;
        UnityEngine.Vector3 val_11 = val_8.boxCollider.size;
        UnityEngine.Vector3 val_12 = val_8.万东万丆专丌丕丐丗.localScale;
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_9.x * val_10.x, y:  val_11.z * val_12.z);
        UnityEngine.Vector3 val_16 = val_8.万东万丆专丌丕丐丗.position;
        UnityEngine.Vector3 val_17 = val_8.万东万丆专丌丕丐丗.position;
        float val_40 = 0.5f;
        float val_18 = val_15.x * val_40;
        val_18 = val_16.x - val_18;
        val_40 = val_15.y * val_40;
        val_40 = val_17.z - val_40;
        float val_19 = 0.x;
        UnityEngine.Vector3 val_21 = val_8.万东万丆专丌丕丐丗.position;
        float val_23 = val_19 + (UnityEngine.Random.Range(min:  0f, max:  val_19));
        float val_24 = val_21.x + (UnityEngine.Random.Range(min:  0f, max:  val_21.x));
        val_41 = this.丝且与丝丒丟万丁专.丐世丁丅丟丑七丂丟();
        label_48:
        val_44 = 0;
        val_45 = 0f;
        goto label_30;
        label_35:
        val_44 = 1;
        val_45 = val_45 + (1.152922E+18f);
        label_30:
        if(val_44 >= this.丝且与丝丒丟万丁专.上七丆丞丁丟不丘上)
        {
            goto label_33;
        }
        
        float val_41 = 1.152922E+18f;
        val_41 = val_45 + val_41;
        if((UnityEngine.Random.Range(min:  0f, max:  val_41)) >= 0)
        {
            goto label_35;
        }
        
        goto label_36;
        label_33:
        val_44 = 0;
        label_36:
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_39;
        }
        
        val_46 = null;
        val_46 = null;
        val_47 = null;
        val_47 = null;
        val_43 = WeaponManager.丟丗丄业丘丗业丗七.丘一丄丕不专上三丅().Item[0].三与丛丑且丐丈业丌();
        if((ZombieCreator.上万丆七丙丙三丟专.Contains(item:  val_43)) == false)
        {
            goto label_48;
        }
        
        label_39:
        val_48 = null;
        val_48 = null;
        UnityEngine.GameObject val_35 = BonusCreator.下不三上与丂丅三世(丆与丕丕丂下丟一丈:  WeaponManager.丟丗丄业丘丗业丗七.丘一丄丕不专上三丅().Item[0].三与丛丑且丐丈业丌(), 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_39 = this.丝且与丝丒丟万丁专.丏丄万丐丙丕世丐丐;
        if(val_39 > ((GameConnect.丌专丌万一下丕专上() != true) ? 3 : 5))
        {
                val_39 = this.丝且与丝丒丟万丁专.丏丄万丐丙丕世丐丐;
            if((val_39 != null) && (null != null))
        {
                val_39 = 0;
        }
        
            UnityEngine.Object.Destroy(obj:  val_39);
        }
        
        label_58:
        val_40 = 1;
        this.丗丏丅丕丆世丁专丟 = val_40;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_40;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new BonusCreator.且丛三丒东丂丘不业();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
