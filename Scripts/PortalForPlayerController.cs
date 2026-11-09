using UnityEngine;
public sealed class PortalForPlayerController : MonoBehaviour
{
    // Fields
    public PortalForPlayerController myDublicatePortal;
    public bool teleportByAction;
    public bool disableDefaultSound;
    public string teleportEffectName;
    public float howLongEffectIsEnabled;
    private UnityEngine.Transform 丐丈丙且业丗丛专丅;
    
    // Methods
    private void Start()
    {
        this.丐丈丙且业丗丛专丅 = this.transform.GetChild(index:  0);
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_10;
        var val_11;
        var val_12;
        val_10 = 丘丛丏丘丝七世七丅.gameObject.name;
        if((val_10.Equals(value:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_10 = 丘丛丏丘丝七世七丅.transform.parent;
        if(val_10 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_10 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject & 1) == 0)
        {
                return;
        }
        
        if(this.teleportByAction != false)
        {
                val_12 = null;
            val_12 = null;
            丑丂丒丐一丙丆三丄(丙业与丙丗丝不丈东:  this);
            return;
        }
        
        this.Teleport();
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_12;
        var val_13;
        var val_14;
        var val_15;
        val_12 = 丘丛丏丘丝七世七丅.gameObject.name;
        if((val_12.Equals(value:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_12 = 丘丛丏丘丝七世七丅.transform.parent;
        if(val_12 == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        val_12 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_12 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject & 1) == 0)
        {
                return;
        }
        
        if(this.teleportByAction == false)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(丄世一且专丈丌东专() != this)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        丑丂丒丐一丙丆三丄(丙业与丙丗丝不丈东:  0);
    }
    public void Teleport()
    {
        Player_move_c val_17;
        var val_18;
        var val_19;
        float val_20;
        float val_21;
        var val_22;
        Player_move_c val_23;
        float val_24;
        float val_25;
        float val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_17 = this;
        val_18 = null;
        val_18 = null;
        val_19 = null;
        val_19 = null;
        UnityEngine.Vector3 val_2 = transform.position;
        val_20 = val_2.x;
        val_21 = val_2.z;
        UnityEngine.Vector3 val_4 = this.myDublicatePortal.丐丈丙且业丗丛专丅.position;
        transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        mem2[0] = 1;
        mem2[0] = 1;
        UnityEngine.Quaternion val_6 = this.丐丈丙且业丗丛专丅.transform.rotation;
        float val_18 = val_6.y;
        UnityEngine.Quaternion val_8 = this.myDublicatePortal.丐丈丙且业丗丛专丅.transform.rotation;
        val_22 = null;
        float val_17 = 360f;
        val_17 = val_8.y + val_17;
        val_22 = null;
        val_18 = ((val_8.y < 0) ? (val_17) : val_8.y) - val_18;
        val_18 = val_18 + (-180f);
        val_24 = 0f;
        val_25 = 0f;
        val_26 = val_18;
        transform.Rotate(xAngle:  val_24, yAngle:  val_26, zAngle:  val_25);
        if(this.disableDefaultSound != true)
        {
                val_27 = null;
            val_27 = null;
            下万丟万且七不丏丕();
        }
        
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.teleportEffectName)) != false)
        {
                val_28 = null;
            val_28 = null;
            val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_24 = val_20;
            val_26 = val_2.y;
            val_25 = val_21;
            且丁专丛丈东丒上丁(世丕丘东丄且丌丟丙:  new UnityEngine.Vector3() {x = val_24, y = val_26, z = val_25}, 丝世丑丗世丟丄丈丗:  this.teleportEffectName, 丙丞丏下世业丅万丟:  this.howLongEffectIsEnabled);
        }
        
        val_29 = null;
        val_29 = null;
        if(丙世丞丈丁丝丙丌丞().世丘丝丕丌与丟丟业() != 0)
        {
                val_30 = null;
            val_30 = null;
            UnityEngine.Vector3 val_16 = this.myDublicatePortal.丐丈丙且业丗丛专丅.transform.forward;
            val_20 = val_16.x;
            val_21 = val_16.z;
            丙世丞丈丁丝丙丌丞().丛与丏与专东一丂不(丌丆丈丅丑世丗丞与:  new UnityEngine.Vector3() {x = val_20, y = val_16.y, z = val_21});
        }
        
        val_31 = null;
        val_31 = null;
        val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        丑丂丒丐一丙丆三丄(丙业与丙丗丝不丈东:  0);
    }
    public PortalForPlayerController()
    {
        this.howLongEffectIsEnabled = 5f;
    }

}
