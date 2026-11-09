using UnityEngine;
internal sealed class CamPlayerObzorController : MonoBehaviour
{
    // Fields
    private bool 丌且下丕下下丌万丞;
    public UnityEngine.GameObject playerGameObject;
    
    // Methods
    private void Start()
    {
        var val_8 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                if((this.transform.parent.GetComponent<PhotonView>().isMine) != true)
        {
                this.丌且下丕下下丌万丞 = true;
        }
        
        }
        
        if(this.丌且下丕下下丌万丞 != false)
        {
                this.SendMessage(methodName:  "SetActiveFalse");
        }
        else
        {
                this.enabled = false;
        }
        
        SkinName val_7 = this.transform.parent.GetComponent<SkinName>();
        this.playerGameObject = val_7.playerGameObject;
    }
    private void Update()
    {
        UnityEngine.Quaternion val_3 = this.playerGameObject.transform.rotation;
        UnityEngine.Quaternion val_5 = this.transform.rotation;
        UnityEngine.Quaternion val_7 = this.transform.rotation;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
    }
    public CamPlayerObzorController()
    {
    
    }

}
