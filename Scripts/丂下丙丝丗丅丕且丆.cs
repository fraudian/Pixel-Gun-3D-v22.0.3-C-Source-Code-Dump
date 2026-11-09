using UnityEngine;
private sealed class Player_move_c.丂下丙丝丗丅丕且丆 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丂下丙丝丗丅丕且丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_10;
        int val_11;
        var val_12;
        var val_13;
        val_10 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_41;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_10 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_11 = 1;
        this.丒上七丌业七丟与丐 = val_10;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        val_12 = null;
        val_12 = null;
        if(val_10 == null)
        {
            goto label_7;
        }
        
        if(与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == false)
        {
            goto label_8;
        }
        
        label_10:
        val_10.丅丐万丛不七丌三丗(丙业与丙丗丝不丈东:  0);
        goto label_41;
        label_7:
        if(与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == true)
        {
            goto label_10;
        }
        
        label_8:
        if(this.丝且与丝丒丟万丁专.世丁丟丛丄不专与丆 != 1)
        {
                val_10.专丐丏丒丘丟丁与丟(丞世不丒下上上丝丑:  this.丝且与丝丒丟万丁专.世丁丟丛丄不专与丆, 丟业下东与东专专业:  false);
        }
        
        this.丝且与丝丒丟万丁专.世丁丟丛丄不专与丆 = 0;
        val_13 = 1152921504848912384;
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈 != 0)
        {
                if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.blockedCollider != 0)
        {
                this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.blockedCollider.SetActive(value:  false);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈 != 0)
        {
                if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.blockedCollider2 != 0)
        {
                this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.blockedCollider2.SetActive(value:  false);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈 != 0)
        {
                if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.blockedColliderDater != 0)
        {
                this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.blockedColliderDater.SetActive(value:  false);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈 == 0)
        {
            goto label_41;
        }
        
        val_13 = 0;
        goto label_42;
        label_52:
        Rilisoft.ButtonHandler val_9 = this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.weaponToggles.upButtonsInShopPanel[0].GetComponent<Rilisoft.ButtonHandler>();
        val_13 = 1;
        val_9.isEnable = true;
        label_42:
        if(val_13 < this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.weaponToggles.upButtonsInShopPanel.Length)
        {
            goto label_52;
        }
        
        label_41:
        val_11 = 0;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Player_move_c.丂下丙丝丗丅丕且丆 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丂下丙丝丗丅丕且丆();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
