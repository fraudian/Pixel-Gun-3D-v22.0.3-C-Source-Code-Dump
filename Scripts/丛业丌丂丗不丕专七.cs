using UnityEngine;
private sealed class Rocket.丛业丌丂丗不丕专七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rocket 丝且与丝丒丟万丁专;
    public int 丁丞丕三丝东万下丞;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    private bool 丙丙丗七丟丅下下丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.丛业丌丂丗不丕专七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rocket val_35;
        string val_36;
        string val_37;
        var val_38;
        UnityEngine.ResourceRequest val_39;
        bool val_40;
        UnityEngine.GameObject val_41;
        var val_42;
        val_35 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_36 = this.丁丞丕三丝东万下丞.ToString();
        if((this.丝且与丝丒丟万丁专.丝丞世丅丏丝丅一与.ContainsKey(key:  val_36)) == false)
        {
            goto label_5;
        }
        
        val_37 = this.丁丞丕三丝东万下丞.ToString();
        RocketSettings val_4 = this.丝且与丝丒丟万丁专.丝丞世丅丏丝丅一与.Item[val_37];
        this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 = val_4;
        val_35 = val_4.gameObject;
        val_35.SetActive(value:  true);
        label_2:
        val_38 = 0;
        return (bool)val_38;
        label_1:
        val_39 = this.丅丒丑丄丞丑下丈丕;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_10;
        label_5:
        val_39 = this;
        this.丅丒丑丄丞丑下丈丕 = UnityEngine.Resources.LoadAsync<UnityEngine.GameObject>(path:  "Rockets/Rocket_"("Rockets/Rocket_") + this.丁丞丕三丝东万下丞.ToString());
        if(val_35.下业丑万丟丁与丕不() == 0)
        {
            goto label_13;
        }
        
        val_40 = this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞;
        if(val_40 == false)
        {
            goto label_18;
        }
        
        WeaponSounds val_11 = val_35.下业丑万丟丁与丕不();
        val_40 = val_11.isMelee;
        if(val_40 == false)
        {
            goto label_18;
        }
        
        WeaponSounds val_12 = val_35.下业丑万丟丁与丕不();
        val_40 = val_12.isLightning;
        goto label_18;
        label_13:
        val_40 = false;
        label_18:
        this.丙丙丗七丟丅下下丘 = val_40;
        if(val_40 == 0)
        {
            goto label_19;
        }
        
        label_10:
        val_37 = this.丅丒丑丄丞丑下丈丕;
        if((val_37.isDone == true) || (this.丙丙丗七丟丅下下丘 == true))
        {
            goto label_22;
        }
        
        if(val_35 != null)
        {
            goto label_61;
        }
        
        goto label_61;
        label_22:
        if(this.丙丙丗七丟丅下下丘 == true)
        {
            goto label_28;
        }
        
        val_36 = this.丁丞丕三丝东万下丞.ToString();
        if((this.丝且与丝丒丟万丁专.丝丞世丅丏丝丅一与.ContainsKey(key:  val_36)) == false)
        {
            goto label_28;
        }
        
        val_37 = this.丁丞丕三丝东万下丞.ToString();
        RocketSettings val_17 = this.丝且与丝丒丟万丁专.丝丞世丅丏丝丅一与.Item[val_37];
        this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 = val_17;
        val_17.gameObject.SetActive(value:  true);
        goto label_61;
        label_28:
        UnityEngine.Object val_19 = this.丅丒丑丄丞丑下丈丕.asset;
        if(val_19 != null)
        {
                var val_20 = (null == null) ? (val_19) : 0;
        }
        else
        {
                val_41 = 0;
        }
        
        val_37 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_41);
        val_37.transform.SetParent(p:  val_35.transform);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
        val_37.transform.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_28 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        val_37.transform.localRotation = new UnityEngine.Quaternion() {x = val_28.x, y = val_28.y, z = val_28.z, w = val_28.w};
        val_37.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        RocketSettings val_30 = val_37.GetComponent<RocketSettings>();
        if(val_35 != null)
        {
                val_42 = val_35;
            this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 = val_30;
        }
        else
        {
                val_42 = 40;
            mem[40] = val_30;
        }
        
        val_36 = mem[40];
        this.丝且与丝丒丟万丁专.丝丞世丅丏丝丅一与.Add(key:  this.丁丞丕三丝东万下丞.ToString(), value:  val_36);
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 != true)
        {
                UnityEngine.BoxCollider val_32 = val_37.GetComponent<UnityEngine.BoxCollider>();
            if(val_32 != 0)
        {
                val_32.enabled = false;
        }
        
        }
        
        label_61:
        if(this.丝且与丝丒丟万丁专.不与万丌一丈下丑丈 != true)
        {
                this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.gameObject.SetActive(value:  false);
            this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 = 0;
        }
        
        val_38 = 0;
        this.丅丒丑丄丞丑下丈丕 = 0;
        return (bool)val_38;
        label_19:
        this.丗丏丅丕丆世丁专丟 = 1;
        this.丒上七丌业七丟与丐 = this.丅丒丑丄丞丑下丈丕;
        return (bool)val_38;
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
