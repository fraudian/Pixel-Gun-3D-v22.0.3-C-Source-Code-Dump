using UnityEngine;
private sealed class 丁上七且七丛丟世丕.丁万丙一专且丝丟七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 丁上七且七丛丟世丕 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丁上七且七丛丟世丕.丁万丙一专且丝丟七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        丁上七且七丛丟世丕 val_39;
        var val_40;
        var val_41;
        UnityEngine.Object val_42;
        var val_43;
        int val_44;
        var val_45;
        var val_46;
        float val_47;
        var val_48;
        float val_49;
        float val_50;
        var val_52;
        UnityEngine.GameObject val_53;
        var val_54;
        var val_61;
        var val_62;
        val_39 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_24;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        mem2[0] = new UnityEngine.GameObject[0];
        val_40 = 1152921505286238208;
        val_41 = null;
        val_41 = null;
        val_42 = 丙不丅丕三丂业东丕();
        if(val_42 == 0)
        {
            goto label_24;
        }
        
        val_43 = null;
        val_43 = null;
        val_42 = 丙不丅丕三丂业东丕();
        if(val_42.丏丒丟世丑七丑丅丐() == null)
        {
                return (bool)val_44;
        }
        
        val_45 = null;
        val_45 = null;
        val_42 = 丙不丅丕三丂业东丕().丏丒丟世丑七丑丅丐();
        if(val_7.Length == 0)
        {
            goto label_24;
        }
        
        val_46 = 0;
        val_47 = 1f;
        goto label_25;
        label_53:
        val_48 = null;
        val_48 = null;
        UnityEngine.Transform val_39 = 丙不丅丕三丂业东丕().丏丒丟世丑七丑丅丐()[0];
        UnityEngine.Vector3 val_10 = val_39.position;
        val_49 = val_10.y;
        UnityEngine.Quaternion val_11 = val_39.rotation;
        val_50 = val_11.x;
        Rocket val_12 = Player_move_c.丞专一丙丁丒万三丏(专丑一业业下且丅丗:  this.丝且与丝丒丟万丁专.丌丝下丄业一丄不三, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_10.x, y = val_49, z = val_10.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_50, y = val_11.y, z = val_11.z, w = val_11.w}, 丑三一万丆不丁万丏:  val_47, 丗丑丞丗七业丆丙丁:  1, 不丐丂丂丘丞丁丑丌:  0);
        if(val_39.丙丕丞且丕不丘丙丑() != null)
        {
                val_12.丈丒丄丝丐专丐丙丌 = val_39.丙丕丞且丕不丘丙丑().丁丒丝丈丈丒丞丘下(丅丏三七丁丑丞丄丏:  val_12.photonView);
            var val_17 = (val_12 == 0) ? 1 : 0;
        }
        else
        {
                if(val_12 != null)
        {
                val_52 = 0;
        }
        else
        {
                val_52 = 1;
        }
        
        }
        
        val_53 = val_12.gameObject;
        if(X24 == 0)
        {
            goto label_44;
        }
        
        if(val_53 != null)
        {
            goto label_45;
        }
        
        goto label_48;
        label_44:
        if(val_53 == null)
        {
            goto label_48;
        }
        
        label_45:
        label_48:
        mem2[0] = val_53;
        val_12.transform.parent = val_39;
        val_46 = 1;
        label_25:
        if(val_46 < (X24 + 0))
        {
            goto label_53;
        }
        
        val_44 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_44;
        return (bool)val_44;
        label_1:
        val_53 = 1152921535689396112;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_50 = 150f;
        val_52 = 1152921505066536960;
        val_54 = 0;
        System.Collections.Generic.List<Rocket> val_31 = new System.Collections.Generic.List<Rocket>();
        val_61 = 0;
        goto label_88;
        label_98:
        UnityEngine.Rigidbody.__il2cppRuntimeField_byval_arg.transform.parent = 0;
        val_31.Add(item:  UnityEngine.Transform.__il2cppRuntimeField_byval_arg.GetComponent<Rocket>());
        val_61 = 1;
        label_88:
        if(val_61 < null)
        {
            goto label_98;
        }
        
        val_40 = 1152921535707315184;
        val_39 = 0;
        goto label_99;
        label_108:
        val_42 = 0;
        goto label_100;
        label_106:
        if(val_39 != val_42)
        {
                if(val_31 != null)
        {
                val_62 = val_31.Item[0];
        }
        else
        {
                val_62 = val_31.Item[0];
        }
        
            val_53 = val_31.Item[0];
            val_62.丝不业东丁丒丂业东(丒丝东且三下丛丂丕:  val_53);
        }
        
        val_42 = 1;
        label_100:
        if(val_42 < val_31.Count)
        {
            goto label_106;
        }
        
        val_39 = 1;
        label_99:
        if(val_39 < val_31.Count)
        {
            goto label_108;
        }
        
        label_24:
        val_44 = 0;
        return (bool)val_44;
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
