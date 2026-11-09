using UnityEngine;
public class CableCarStarter : PGBehaviour
{
    // Fields
    private UnityEngine.Vector3 丛上丙丄丄七丈且丅;
    private CableCar 丟丏丝丆七丈世丛丙;
    
    // Properties
    internal UnityEngine.Vector3 七丝丑丐东丅丒丁丂 { get; }
    internal UnityEngine.Vector3 丂七丅一一丒且万丕 { get; }
    
    // Methods
    private void Awake()
    {
        this.丟丏丝丆七丈世丛丙 = this.GetComponentInParent<CableCar>();
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        var val_4;
        Player_move_c val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        if(this.丟丏丝丆七丈世丛丙 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.SetCurrentCableCar(丁丂专业丁丅丅丈丙:  this.丟丏丝丆七丈世丛丙);
        丑丒东业丕专丈与丆(丘七丐下一丐丒丗下:  true, 专丞上七七且丝七丗:  0);
    }
    internal UnityEngine.Vector3 一专东丅丅丄一丁七()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.丛上丙丄丄七丈且丅, y = V11.16B, z = V10.16B});
    }
    internal UnityEngine.Vector3 下丏丟丁丌丒丝丘丝()
    {
        if(this.丟丏丝丆七丈世丛丙 == 0)
        {
                return UnityEngine.Vector3.zero;
        }
        
        if(this.丟丏丝丆七丈世丛丙.endCollider == 0)
        {
                return UnityEngine.Vector3.zero;
        }
        
        if(this.丟丏丝丆七丈世丛丙.endCollider != null)
        {
                return this.丟丏丝丆七丈世丛丙.endCollider.下丏丟丁丌丒丝丘丝();
        }
        
        return this.丟丏丝丆七丈世丛丙.endCollider.下丏丟丁丌丒丝丘丝();
    }
    public CableCarStarter()
    {
        this.丛上丙丄丄七丈且丅 = 0;
        mem[1152921525572321008] = 0;
    }

}
