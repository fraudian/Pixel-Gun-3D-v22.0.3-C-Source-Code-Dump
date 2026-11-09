using UnityEngine;
public class FortPortalForPlayerController : FortEquipObject
{
    // Fields
    public FortPortalForPlayerController myDublicatePortal;
    public UnityEngine.Transform myPointOut;
    
    // Methods
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_19;
        Player_move_c val_20;
        var val_21;
        var val_22;
        var val_23;
        val_20 = this;
        if(GameConnect.七丂万专且丏丘一丙() == true)
        {
                return;
        }
        
        val_19 = 丘丛丏丘丝七世七丅.gameObject.name;
        if((val_19.Equals(value:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_19 = 丘丛丏丘丝七世七丅.transform.parent;
        if(val_19 == 0)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        val_19 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_19 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject & 1) == 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_19 = this.myDublicatePortal.myPointOut;
        UnityEngine.Vector3 val_12 = val_19.position;
        transform.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        mem2[0] = 1;
        UnityEngine.Quaternion val_14 = this.myPointOut.transform.rotation;
        float val_20 = val_14.y;
        UnityEngine.Quaternion val_16 = this.myDublicatePortal.myPointOut.transform.rotation;
        val_23 = null;
        float val_19 = 360f;
        val_19 = val_16.y + val_19;
        val_23 = null;
        val_20 = ((val_16.y < 0) ? (val_19) : val_16.y) - val_20;
        val_20 = val_20 + (-180f);
        transform.Rotate(xAngle:  0f, yAngle:  val_20, zAngle:  0f);
        val_20 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_20 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        下万丟万且七不丏丕();
    }
    public FortPortalForPlayerController()
    {
    
    }

}
