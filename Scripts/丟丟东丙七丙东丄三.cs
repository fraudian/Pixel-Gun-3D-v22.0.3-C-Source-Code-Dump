using UnityEngine;
private sealed class Rocket.丟丟东丙七丙东丄三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rocket 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.丟丟东丙七丙东丄三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_28;
        System.Collections.Generic.List<UnityEngine.Transform> val_29;
        var val_30;
        var val_31;
        var val_32;
        PhotonView val_34;
        var val_35;
        var val_36;
        float val_37;
        float val_38;
        float val_39;
        var val_40;
        int val_42;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丞丟丛与且万七七丆 = false;
        val_28 = null;
        val_28 = null;
        UnityEngine.Vector3 val_2 = typeof(Player_move_c).__il2cppRuntimeField_498.transform.position;
        this.丝且与丝丒丟万丁专.丁丁丏东专丂且万丅 = val_2;
        mem2[0] = val_2.y;
        mem2[0] = val_2.z;
        System.Collections.Generic.List<UnityEngine.Transform> val_3 = null;
        val_29 = val_3;
        val_3 = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.丝且与丝丒丟万丁专.丞七且丄丟下东丕一 = val_29;
        goto label_79;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_29 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_29 == 0)
        {
            goto label_79;
        }
        
        val_30 = 1152921505286238208;
        val_31 = null;
        val_31 = null;
        val_29 = 丙不丅丕三丂业东丕();
        if(val_29 == this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不())
        {
            goto label_21;
        }
        
        val_32 = null;
        val_32 = null;
        if(((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)) || (this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false))
        {
            goto label_64;
        }
        
        val_34 = this.丝且与丝丒丟万丁专.丄丈丑丐丆丞丘与丗;
        val_29 = new object[2];
        val_29[0] = "";
        UnityEngine.Vector3 val_9 = this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟.position;
        val_35 = null;
        goto label_34;
        label_21:
        if(this.丝且与丝丒丟万丁专.丞丟丛与且万七七丆 == false)
        {
            goto label_35;
        }
        
        val_36 = null;
        val_36 = null;
        UnityEngine.Vector3 val_11 = typeof(Player_move_c).__il2cppRuntimeField_498.transform.position;
        val_29 = this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟;
        val_37 = val_11.x;
        val_38 = val_11.z;
        UnityEngine.Vector3 val_12 = val_29.position;
        val_30 = 1152921504838316032;
        val_39 = val_12.y;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_37, y = val_11.y, z = val_38}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_39, z = val_12.z})) >= 0)
        {
            goto label_79;
        }
        
        if((this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不() != 0) && (this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.useShootReturn != false))
        {
                if((this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不().丌丙丆下专丝丑且丈().IsPlaying(name:  "Reload")) != true)
        {
                this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不().丌丙丆下专丝丑且丈().Stop();
            bool val_23 = this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不().丌丙丆下专丝丑且丈().Play(animation:  "ShootReturn");
        }
        
        }
        
        val_40 = null;
        val_40 = null;
        if(((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)) || (this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false))
        {
            goto label_64;
        }
        
        val_34 = this.丝且与丝丒丟万丁专.丄丈丑丐丆丞丘与丗;
        object[] val_24 = new object[2];
        val_29 = val_24;
        val_29[0] = "";
        UnityEngine.Vector3 val_25 = this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟.position;
        val_35 = null;
        label_34:
        val_29[1] = val_25;
        val_34.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  14, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_24);
        label_64:
        this.丝且与丝丒丟万丁专.丝丄一丟丈丂三丞丆();
        label_2:
        val_42 = 0;
        return (bool)val_42;
        label_35:
        UnityEngine.Vector3 val_26 = this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟.position;
        val_39 = val_26.y;
        val_29 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        val_37 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.丝且与丝丒丟万丁专.丁丁丏东专丂且万丅, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_39, z = val_26.z});
        if(val_37 > this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.boomerangDistance)
        {
                this.丝且与丝丒丟万丁专.丅三丐上与丌丙丕丐();
        }
        
        label_79:
        val_42 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_42;
        return (bool)val_42;
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
