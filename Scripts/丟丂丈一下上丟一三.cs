using UnityEngine;
private sealed class FreeAwardChestWeaponController.丗丛丘丑丐不丌丑丙.丟丂丈一下上丟一三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FreeAwardChestWeaponController.丗丛丘丑丐不丌丑丙 丝且与丝丒丟万丁专;
    private FreeAwardChestWeaponController.世世丝丏丙丞丙丏丁 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreeAwardChestWeaponController.丗丛丘丑丐不丌丑丙.丟丂丈一下上丟一三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        FreeAwardChestWeaponController val_20;
        int val_21;
        UnityEngine.GameObject val_22;
        UnityEngine.Transform val_23;
        世世丝丏丙丞丙丏丁 val_24;
        val_20 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new FreeAwardChestWeaponController.世世丝丏丙丞丙丏丁();
        val_21 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_20 = this.丝且与丝丒丟万丁专.丝且与丝丒丟万丁专;
        val_21 = this.丝且与丝丒丟万丁专.丝且与丝丒丟万丁专._weaponAnimation;
        if(val_21 == null)
        {
                return (bool)val_21;
        }
        
        bool val_3 = val_21.Play(animation:  "Idle");
        label_3:
        val_21 = 0;
        return (bool)val_21;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_22 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Weapons/"("Weapons/") + this.丝且与丝丒丟万丁专.丆丐七世世且丏丐业.三与丛丑且丐丈业丌());
        WeaponSounds val_7 = val_22.GetComponent<WeaponSounds>();
        this.丄丌丂东丘丗一万且.且丅丟丛丛万丝下上 = this.丝且与丝丒丟万丁专.丝且与丝丒丟万丁专.gameObject.layer;
        val_23 = this.丝且与丝丒丟万丁专.丝且与丝丒丟万丁专._weaponParent;
        this.丄丌丂东丘丗一万且.丈东丘丏与丌东东下 = val_23;
        if(val_7 != 0)
        {
                if((System.String.IsNullOrEmpty(value:  val_7.armoryPreviewName)) == false)
        {
            goto label_21;
        }
        
        }
        
        val_23 = this.丝且与丝丒丟万丁专.丆丐七世世且丏丐业;
        丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_22, 丌专业且丛丏丞丝且:  new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  this.丄丌丂东丘丗一万且, 丛丌丙世专世东丕下:  System.Void FreeAwardChestWeaponController.世世丝丏丙丞丙丏丁::丝丙业丗与丘丙丑丕(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌)), 七丆丒与丗丌丄且丂:  val_23.丒万丕七专不丏丞丌(), 丐丑七万丌丂专与丌:  val_7);
        goto label_23;
        label_21:
        val_24 = this.丄丌丂东丘丗一万且;
        if(this.丄丌丂东丘丗一万且 != null)
        {
            goto label_24;
        }
        
        val_24 = this.丄丌丂东丘丗一万且;
        if(val_24 == null)
        {
            goto label_25;
        }
        
        label_24:
        val_22 = this.丄丌丂东丘丗一万且.丈东丘丏与丌东东下;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_20 = val_7.rotationShop;
        val_20 = val_20 + (-20f);
        val_14.y = val_14.y + (-127f);
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        float val_21 = val_7.scaleShop;
        val_21 = val_21 / 133f;
        丄丝不丂丕七万丘且.丒七丂丁丁东专且丕(丛丟三丘丛且业丈丏:  val_7, 丈东丘丏与丌东东下:  val_22, 且丅丟丛丛万丝下上:  this.丄丌丂东丘丗一万且.且丅丟丛丛万丝下上, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w}, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        label_23:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.丝且与丝丒丟万丁专._weaponAnimation.gameObject, 丏业丟一东丂东丘丛:  true);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.丝且与丝丒丟万丁专._weaponAnimation.Item["Start"].length);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_21 = 1;
        return (bool)val_21;
        label_25:
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
