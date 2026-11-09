using UnityEngine;
private sealed class WeaponBonusItem.丐丘丑丘下丟万与业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponBonusItem 丝且与丝丒丟万丁专;
    private WeaponBonusItem.世丘丛上丞丆丟丟丐 丄丌丂东丘丗一万且;
    public int 丗万丛丙上丟上万三;
    public int 东七丛丝丑专世丏三;
    private UnityEngine.ResourceRequest 不且丐丝丞七专下东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponBonusItem.丐丘丑丘下丟万与业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_22;
        WeaponBonusItem val_23;
        int val_24;
        var val_25;
        UnityEngine.ResourceRequest val_26;
        UnityEngine.GameObject val_28;
        var val_29;
        WeaponBonusItem.世丘丛上丞丆丟丟丐 val_30;
        int val_31;
        int val_32;
        var val_33;
        UnityEngine.GameObject val_34;
        val_22 = this;
        val_23 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_24 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_24;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        WeaponBonusItem.世丘丛上丞丆丟丟丐 val_1 = new WeaponBonusItem.世丘丛上丞丆丟丟丐();
        this.丄丌丂东丘丗一万且 = val_1;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        if(val_23 != null)
        {
            goto label_9;
        }
        
        goto label_6;
        label_1:
        val_25 = val_22;
        val_26 = this.不且丐丝丞七专下东;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_26 != null)
        {
            goto label_8;
        }
        
        val_26 = 0;
        goto label_8;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_23 != null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        if((System.String.IsNullOrEmpty(value:  this.丝且与丝丒丟万丁专.weaponPrefabName)) == true)
        {
            goto label_11;
        }
        
        float val_22 = this.丝且与丝丒丟万丁专.丛丞丆且丕丑丄丗上;
        val_22 = val_22 * val_22;
        if(this.丝且与丝丒丟万丁专.丟万三下专与与丄丘 > val_22)
        {
            goto label_11;
        }
        
        UnityEngine.ResourceRequest val_4 = UnityEngine.Resources.LoadAsync(path:  "Weapons/"("Weapons/") + this.丝且与丝丒丟万丁专.weaponPrefabName);
        val_25 = val_22;
        this.不且丐丝丞七专下东 = val_4;
        if(val_4 == null)
        {
                return (bool)val_24;
        }
        
        label_8:
        if(val_4.isDone == false)
        {
            goto label_13;
        }
        
        val_28 = this.不且丐丝丞七专下东.asset;
        if(val_28 != null)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        val_29 = val_22;
        val_30 = this.丄丌丂东丘丗一万且;
        val_28 = 0;
        goto label_17;
        label_11:
        val_24 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
        label_13:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_24 = 1;
        return (bool)val_24;
        label_16:
        val_29 = val_22;
        val_30 = this.丄丌丂东丘丗一万且;
        label_17:
        this.丄丌丂东丘丗一万且.丛丟三丘丛且业丈丏 = val_28.GetComponent<WeaponSounds>();
        if(val_23 != null)
        {
                this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七 = mem[1152921540696030344];
            val_31 = this.丗万丛丙上丟上万三;
            val_32 = this.东七丛丝丑专世丏三;
        }
        else
        {
                mem[80] = mem[1152921540696030344];
            val_31 = this.丗万丛丙上丟上万三;
            val_32 = this.东七丛丝丑专世丏三;
        }
        
        val_23.RemoveWeaponPreview(丗万丛丙上丟上万三:  val_31, 东七丛丝丑专世丏三:  val_32);
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_33 = null;
            val_33 = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != true)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Object val_23 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LoadGameObjectFX/Bonus_Guns_Rays/Guns_Ray_{0}", arg0:  mem[1152921540696030344].丌上丗丕不七世丅丁().ToString()));
            UnityEngine.Vector3 val_13 = this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟.position;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.identity;
            UnityEngine.Object val_15 = UnityEngine.Object.Instantiate(original:  val_23, position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, rotation:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w});
            if(val_15 != null)
        {
                val_23 = (null == null) ? (val_15) : 0;
        }
        else
        {
                val_34 = 0;
        }
        
            this.丝且与丝丒丟万丁专.丅丅丌丕世丙不丑丄 = val_34;
            val_34.layer = val_23.gameObject.layer;
            ZombieCreator.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.丅丅丌丕世丙不丑丄, 丁东丑丞与下丛丐东:  val_23.gameObject.layer);
        }
        
        }
        
        丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32> val_20 = null;
        val_23 = val_20;
        val_20 = new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void WeaponBonusItem.世丘丛上丞丆丟丟丐::丘丗丘丁丝七丄下丂(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌));
        val_22 = mem[mem[1152921540696030344] + 72];
        val_22 = mem[1152921540696030344] + 72;
        丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_28, 丌专业且丛丏丞丝且:  val_20, 七丆丒与丗丌丄且丂:  val_22 - 1, 丐丑七万丌丂专与丌:  mem[1152921540696030344]);
        val_24 = 0;
        return (bool)val_24;
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
