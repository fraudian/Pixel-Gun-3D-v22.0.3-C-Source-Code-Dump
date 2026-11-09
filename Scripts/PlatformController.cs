using UnityEngine;
public class PlatformController : MonoBehaviour
{
    // Fields
    public float duration;
    public UnityEngine.Vector3 fromPoint;
    public byte index;
    public UnityEngine.Transform thisTransform;
    public UnityEngine.Vector3 toPoint;
    public bool tramPlatform;
    private bool 下丙三三丂丆丈下不;
    
    // Methods
    private void Start()
    {
        this.thisTransform = this.transform;
        this.七下三万丝不丈世丕();
    }
    private void Update()
    {
        this.七下三万丝不丈世丕();
    }
    private void 七下三万丝不丈世丕()
    {
        float val_7;
        float val_9;
        float val_10;
        float val_11;
        if(this.tramPlatform == true)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > 0f)
        {
                double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            val_7 = this.duration;
        }
        else
        {
                float val_3 = UnityEngine.Time.time;
            val_7 = this.duration;
        }
        
        val_3 = val_3 / val_7;
        val_7 = val_3 + val_3;
        if((System.Single.IsNaN(f:  val_7)) != false)
        {
                return;
        }
        
        if(val_7 > 1f)
        {
                float val_5 = val_7 + (-1f);
            val_9 = this.toPoint;
            val_10 = V10.16B;
            val_11 = V14.16B;
        }
        else
        {
                val_9 = this.fromPoint;
            val_10 = V10.16B;
            val_11 = V14.16B;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11}, b:  new UnityEngine.Vector3() {x = this.toPoint, y = V11.16B, z = V12.16B}, t:  val_7);
        this.thisTransform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        var val_3;
        Player_move_c val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_4 = this.index;
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丄且丒丟丌东丒东丌(七丛丌丞丐丆丐专丛:  val_4);
        this.下丙三三丂丆丈下不 = true;
    }
    private void OnTriggerExit(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        var val_3;
        Player_move_c val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_4 = this.index;
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.不丄丏不业且专丂丌(七丛丌丞丐丆丐专丛:  val_4);
        this.下丙三三丂丆丈下不 = false;
    }
    private void OnDisable()
    {
        var val_1;
        if(this.下丙三三丂丆丈下不 == false)
        {
                return;
        }
        
        this.下丙三三丂丆丈下不 = false;
        val_1 = null;
        val_1 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.不丄丏不业且专丂丌(七丛丌丞丐丆丐专丛:  this.index);
    }
    public PlatformController()
    {
    
    }

}
