using UnityEngine;
public class PlayerBodyAttachment : PGBehaviour
{
    // Fields
    private UnityEngine.Transform 丆丏七丟不丒与七专;
    public bool onlyLocalRotation;
    
    // Methods
    private void LateUpdate()
    {
        if(this.丆丏七丟不丒与七专 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.丌丟丄业且三丛丕丄();
        if(this.丆丏七丟不丒与七专 == null)
        {
            goto label_4;
        }
        
        if(this.onlyLocalRotation == false)
        {
            goto label_5;
        }
        
        label_7:
        UnityEngine.Quaternion val_3 = this.丆丏七丟不丒与七专.localRotation;
        val_2.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        return;
        label_4:
        if(this.onlyLocalRotation == true)
        {
            goto label_7;
        }
        
        label_5:
        UnityEngine.Vector3 val_4 = this.丆丏七丟不丒与七专.position;
        val_2.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Quaternion val_6 = this.丆丏七丟不丒与七专.rotation;
        this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
    }
    public void AttachTo(UnityEngine.Transform 专丂丕丗丗东世丞下)
    {
        this.丆丏七丟不丒与七专 = 专丂丕丗丗东世丞下;
    }
    public PlayerBodyAttachment()
    {
    
    }

}
