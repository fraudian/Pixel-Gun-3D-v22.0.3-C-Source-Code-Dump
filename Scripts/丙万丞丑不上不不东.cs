using UnityEngine;
private sealed class PlayerBotEntity.丙万丞丑不上不不东 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public PlayerBotEntity 丝且与丝丒丟万丁专;
    private string 丟万丐丂丈一丈东不;
    private Rocket[] 丞业丁丌业丟丁丛专;
    private int 丟丗丒丟丝丘丞丝丏;
    private Rocket 业一东丌丕七七一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerBotEntity.丙万丞丑不上不不东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Object[] val_59;
        float val_61;
        int val_62;
        Rocket val_64;
        RocketSettings val_65;
        var val_66;
        float val_68;
        float val_69;
        float val_71;
        Rocket[] val_72;
        int val_73;
        WeaponSounds val_74;
        float val_75;
        val_59 = this;
        if(this.丗丏丅丕丆世丁专丟 > 5)
        {
            goto label_1;
        }
        
        var val_59 = 106021336 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_59 = val_59 + 106021336;
        goto (106021336 + (this.丗丏丅丕丆世丁专丟) << 2 + 106021336);
        label_1:
        val_62 = 0;
        return (bool)val_62;
        label_114:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_74 = this.丝且与丝丒丟万丁专.丆东丛业丟丛丌丆丌();
        }
        else
        {
                val_74 = 0.丆东丛业丟丛丌丆丌();
        }
        
        UnityEngine.Vector3 val_39 = this.丝且与丝丒丟万丁专.丆东丛业丟丛丌丆丌().丞丗丒丒丗丘东丗丝().position;
        val_71 = val_39.z;
        UnityEngine.Quaternion val_40 = UnityEngine.Quaternion.identity;
        val_68 = val_40.y;
        val_69 = val_40.w;
        val_64 = val_59;
        this.业一东丌丕七七一万 = this.丝且与丝丒丟万丁专.丞专一丙丁丒万三丏(丌丝下丄业一丄不三:  val_74, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_71}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_40.x, y = val_68, z = val_40.z, w = val_69}, 丑三一万丆不丁万丏:  1f, 丗丑丞丗七业丆丙丁:  1);
        val_61 = this.丝且与丝丒丟万丁专.丐专下三丙三世且万.丁丒丝丈丈丒丞丘下(丅丏三七丁丑丞丄丏:  0);
        val_41.丈丒丄丝丐专丐丙丌 = val_61;
        val_65 = mem[val_41 + 40];
        val_65 = val_41.丅丕丟七丌丘丆丌上;
        if(val_65 != 0)
        {
            goto label_107;
        }
        
        val_66 = 2;
        this.丒上七丌业七丟与丐 = 0;
        goto label_108;
        label_107:
        val_64 = val_59;
        this.丞业丁丌业丟丁丛专[] = this.业一东丌丕七七一万;
        val_72 = this.丞业丁丌业丟丁丛专;
        this.业一东丌丕七七一万 = 0;
        val_73 = this.丟丗丒丟丝丘丞丝丏 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_73;
        if(val_73 < this.丞业丁丌业丟丁丛专.Length)
        {
            goto label_114;
        }
        
        mem[1152921538669531488].transform.parent.gameObject.SetActive(value:  true);
        label_159:
        object[] val_47 = new object[2];
        if(val_47 == null)
        {
            goto label_121;
        }
        
        if( == true)
        {
            goto label_122;
        }
        
        goto label_125;
        label_121:
        if( == false)
        {
            goto label_125;
        }
        
        label_122:
        label_125:
        val_47[0] = null;
        val_47[1] = 0;
        this.丝且与丝丒丟万丁专.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  151, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_47);
        val_75 = 150f;
        if((mem[1152921538669531480] + 32 + 40) != 0)
        {
                val_75 = mem[1152921538669531480] + 32 + 40.与丕丒丂丗一且不丁();
        }
        
        UnityEngine.Rigidbody val_50 = mem[1152921538669531480] + 32.GetComponent<UnityEngine.Rigidbody>();
        val_50.isKinematic = false;
        float val_61 = -1f;
        var val_51 = 0 + 1;
        float val_60 = (float)(ulong)(val_51 >> 1) & 2147483647;
        val_60 = val_60 * 15f;
        val_61 = val_60 * val_61;
        UnityEngine.Quaternion val_53 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_61 + (-1.5f), z:  0f);
        val_68 = val_53.z;
        UnityEngine.Vector3 val_55 = this.丝且与丝丒丟万丁专.丕丁丘丆万丄世专丛.myTransform.forward;
        val_69 = val_55.x;
        val_61 = val_55.z;
        UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Multiply(d:  val_75, a:  new UnityEngine.Vector3() {x = val_69, y = val_55.y, z = val_61});
        UnityEngine.Vector3 val_57 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_53.x, y = val_53.y, z = val_68, w = val_53.w}, point:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
        val_71 = val_57.y;
        if(val_50 != null)
        {
                val_50.AddForce(force:  new UnityEngine.Vector3() {x = val_57.x, y = val_71, z = val_57.z});
        }
        else
        {
                val_50.AddForce(force:  new UnityEngine.Vector3() {x = val_57.x, y = val_71, z = val_57.z});
        }
        
        val_50.useGravity = false;
        val_65 = mem[mem[1152921538669531480] + 32];
        val_65 = mem[1152921538669531480] + 32;
        val_65.万丏世丆丁万丏丞丟(业丘东且七丕丞东不:  true);
        if(val_51 != 3)
        {
            goto label_159;
        }
        
        this.丞业丁丌业丟丁丛专 = 0;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        val_66 = 5;
        label_108:
        this.丗丏丅丕丆世丁专丟 = 5;
        val_62 = 1;
        return (bool)val_62;
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
        this = new PlayerBotEntity.丙万丞丑不上不不东();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
