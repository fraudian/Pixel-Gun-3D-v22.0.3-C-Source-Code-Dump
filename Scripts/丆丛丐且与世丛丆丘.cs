using UnityEngine;
private sealed class Player_move_c.丆丛丐且与世丛丆丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    private string 业丁一丁丌丕万丙丌;
    private System.Collections.IEnumerator 三且丙丘丙与万丙世;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丆丛丐且与世丛丆丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_23;
        var val_24;
        var val_26;
        int val_29;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_59;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((GameConnect.丑丌丛丈丅丅与不业() != 16) && (this.丝且与丝丒丟万丁专.丟丌下三七丁与丟丑() != false))
        {
                val_23 = null;
            val_23 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_24 = null;
            val_24 = null;
            typeof(NetworkStartTable).__il2cppRuntimeField_1B0.Reset();
            typeof(NetworkStartTable).__il2cppRuntimeField_1B0.Restart();
        }
        
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_27;
        }
        
        }
        
        System.Diagnostics.Stopwatch val_6 = new System.Diagnostics.Stopwatch();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_28;
        }
        
        this.丝且与丝丒丟万丁专.世丌丁丘上丈且丗丙 = val_6;
        if(val_6 != null)
        {
            goto label_66;
        }
        
        label_67:
        label_66:
        val_6.Start();
        label_27:
        UnityEngine.Vector3 val_7 = this.丝且与丝丒丟万丁专.bodyCollayder.center;
        this.丝且与丝丒丟万丁专.丏一丏丁七丆丙不且 = val_7;
        mem2[0] = val_7.y;
        mem2[0] = val_7.z;
        this.丝且与丝丒丟万丁专.一丄丗丕丐丝丙下丟 = this.丝且与丝丒丟万丁专.bodyCollayder.radius;
        this.丝且与丝丒丟万丁专.万七且七与世且丁东 = this.丝且与丝丒丟万丁专.bodyCollayder.height;
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                this.丝且与丝丒丟万丁专.mySkinName.character.radius = 0.15f;
        }
        
        this.业丁一丁丌丕万丙丌 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}.Start()", arg0:  this.丝且与丝丒丟万丁专.GetType());
        var val_26 = 0;
        val_26 = val_26 + 1;
        goto label_46;
        label_1:
        int val_27 = this.丟丗丒丟丝丘丞丝丏;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27 = val_27 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_27;
        goto label_47;
        label_46:
        this.三且丙丘丙与万丙世 = this.丝且与丝丒丟万丁专.丒丙且丌丆丙丞万丙().GetEnumerator();
        this.丟丗丒丟丝丘丞丝丏 = 0;
        label_47:
        string val_18 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "Step {0}", arg0:  this.丟丗丒丟丝丘丞丝丏);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                val_26 = UnityEngine.Application.isEditor ^ 1;
        }
        else
        {
                val_26 = 0;
        }
        
        var val_21 = val_26 & 1;
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(this.三且丙丘丙与万丙世.MoveNext() == false)
        {
            goto label_59;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        goto label_64;
        label_59:
        val_29 = 0;
        return (bool)val_29;
        label_64:
        this.丒上七丌业七丟与丐 = this.三且丙丘丙与万丙世.Current;
        val_29 = 1;
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_29;
        label_28:
        mem[832] = val_6;
        if(mem[832] != 0)
        {
            goto label_66;
        }
        
        goto label_67;
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
