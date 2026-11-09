using UnityEngine;
private sealed class ZombieCreator.业三不七丞与丐丏丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ZombieCreator 丝且与丝丒丟万丁专;
    private UnityEngine.GameObject 丌上七丗丗丛丌业专;
    private ObjectPrerenderer 三不一丆专丌丙七丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ZombieCreator.业三不七丞与丐丏丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_26;
        UnityEngine.GameObject val_27;
        val_26 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "ObjectPrerenderer");
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        if(val_1 == null)
        {
            goto label_7;
        }
        
        var val_3 = (null == null) ? (val_1) : 0;
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三不一丆专丌丙七丌.Render_();
        val_26 = this.丌上七丗丗丛丌业专;
        UnityEngine.Object.Destroy(obj:  val_26);
        return false;
        label_7:
        val_27 = 0;
        label_8:
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_27, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        this.丌上七丗丗丛丌业专 = val_4;
        ObjectPrerenderer val_5 = val_4.GetComponentInChildren<ObjectPrerenderer>();
        this.三不一丆专丌丙七丌 = val_5;
        if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
        {
                return false;
        }
        
        UnityEngine.GameObject val_10 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝且与丝丒丟万丁专.与丝丈丑丝丕丘丏丅.transform.GetChild(index:  0).gameObject);
        val_10.transform.parent = this.三不一丆专丌丙七丌.transform;
        val_10.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        int val_15 = this.三不一丆专丌丙七丌.gameObject.layer;
        if(val_10 != null)
        {
                val_10.layer = val_15;
        }
        else
        {
                val_10.layer = val_15;
        }
        
        ZombieCreator.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_10, 丁东丑丞与下丛丐东:  val_10.layer);
        if(this.丝且与丝丒丟万丁专.weaponBonus != 0)
        {
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
            UnityEngine.GameObject val_19 = BonusCreator.三丟七丑世世不与上(丂丈丗丄不丅丅丙丒:  this.丝且与丝丒丟万丁专.weaponBonus, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_19.transform.parent = this.三不一丆专丌丙七丌.transform;
            val_19.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            int val_24 = this.三不一丆专丌丙七丌.gameObject.layer;
            if(val_19 != null)
        {
                val_19.layer = val_24;
        }
        else
        {
                0.layer = val_24;
        }
        
            ZombieCreator.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_19, 丁东丑丞与下丛丐东:  val_19.layer);
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
