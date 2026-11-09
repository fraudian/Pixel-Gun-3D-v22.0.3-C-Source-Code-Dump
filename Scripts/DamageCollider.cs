using UnityEngine;
public class DamageCollider : MonoBehaviour
{
    // Fields
    public float damagePercent;
    public float frequency;
    public WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    private bool 专丒丄丌丂丙丟世丅;
    private float 世丟万丒丄丏丒丂丛;
    private UnityEngine.Transform 丛丄与丌丛万业丝丞;
    
    // Methods
    public void RegisterPlayer()
    {
        this.专丒丄丌丂丙丟世丅 = true;
        this.世丟万丒丄丏丒丂丛 = this.frequency;
        this.丝丘三丗丝且丑丏世();
    }
    public void UnregisterPlayer()
    {
        this.专丒丄丌丂丙丟世丅 = false;
    }
    private void OnDisable()
    {
        this.专丒丄丌丂丙丟世丅 = false;
    }
    private void Start()
    {
        this.丛丄与丌丛万业丝丞 = this.transform;
    }
    private void 丝丘三丗丝且丑丏世()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        float val_5 = typeof(Player_move_c).__il2cppRuntimeField_600.maxHealth;
        val_5 = val_5 * (this.damagePercent * 0.01f);
        业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  val_5, 丗东丏与上丆丌不且:  1, 与丘丂下丘丁丅与东:  this.typeDead, 丞丂丂丁丝丄万一丞:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丝三丛且丘不丌丙下:  "", 丞丗且下世丐业丌丙:  0);
    }
    private void Update()
    {
        var val_3;
        var val_4;
        var val_5;
        if(this.专丒丄丌丂丙丟世丅 == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
        }
        
        this.专丒丄丌丂丙丟世丅 = false;
    }
    public DamageCollider()
    {
        this.damagePercent = 5f;
    }

}
