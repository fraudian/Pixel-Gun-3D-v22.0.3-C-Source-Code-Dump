using UnityEngine;
private sealed class FriendProfileView.丛丘世万业专丌下东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FriendProfileView 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List.Enumerator<string> 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendProfileView.丛丘世万业专丌下东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_2;
        List.Enumerator<System.String> val_3;
        List.Enumerator<System.String> val_12;
        var val_13;
        object val_14;
        int val_15;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_50;
        }
        
        val_12 = this.与业丕业业业丌丟丐;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.与七三丟丝三丙丌万.Clear();
        List.Enumerator<T> val_1 = this.丝且与丝丒丟万丁专.丅下丕不丑丁三上丅.GetEnumerator();
        val_12 = this.与业丕业业业丌丟丐;
        mem[1152921537311060808] = val_2;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_3;
        label_3:
        val_13 = 1152921519126358176;
        label_8:
        if((val_12 & 1) == 0)
        {
            goto label_7;
        }
        
        val_14 = UnityEngine.Resources.LoadAsync<UnityEngine.GameObject>(path:  "LobbyItemsContent/"("LobbyItemsContent/") + val_12.丐丏七丌丕丗业且上());
        if(val_14 == null)
        {
            goto label_8;
        }
        
        this.丝且与丝丒丟万丁专.与七三丟丝三丙丌万.Add(item:  val_14);
        val_15 = 1;
        this.丒上七丌业七丟与丐 = val_14;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_7:
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        val_14 = 1152921504848912384;
        if((this.丝且与丝丒丟万丁专.panelSeeLobby != 0) && (this.丝且与丝丒丟万丁专.panelSeeLobby.activeInHierarchy != false))
        {
                val_13 = 1152921505471328256;
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_14 = this.丝且与丝丒丟万丁专.丅下丕不丑丁三上丅;
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.与丅丒丝七丛丑丅丞(与丝东万丙丞丝丟七:  val_14, 丒丞丐丘且不且丟东:  false, 丆且丌丟丅一丙东丁:  false);
            val_15 = 0;
            return (bool)val_15;
        }
        
        }
        
        label_50:
        val_15 = 0;
        return (bool)val_15;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.与业丕业业业丌丟丐);
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
