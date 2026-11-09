using UnityEngine;
internal sealed class synchCamAndPlayer : MonoBehaviour
{
    // Fields
    private bool 丌且下丕下下丌万丞;
    private PhotonView photonView;
    public UnityEngine.Transform gameObjectPlayerTrasform;
    private bool 丁丑丅丏丒不七上丁;
    private bool 丝丙七丒且丂丝与丏;
    private Player_move_c 专丞上七七且丝七丗;
    
    // Methods
    private void OnEnable()
    {
        if(GameConnect.丁丁丗丐东丄丞一丛() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
                return;
        }
        
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void Start()
    {
        var val_4;
        bool val_5;
        val_4 = null;
        val_4 = null;
        val_5 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        this.丁丑丅丏丒不七上丁 = val_5;
        this.丝丙七丒且丂丝与丏 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
        if((与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false) && (val_5 != false))
        {
                val_5 = this.丁丑丅丏丒不七上丁;
            this.丌且下丕下下丌万丞 = this.photonView.isMine;
        }
        
        if(val_5 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_7;
        }
        
        }
        
        this.enabled = false;
        goto label_8;
        label_7:
        this.SendMessage(methodName:  "SetActiveFalse");
        label_8:
        this.专丞上七七且丝七丗 = this.photonView.GetComponent<Player_move_c>();
    }
    private void 丗丂万丒丞且与丛专()
    {
    
    }
    internal void 且上丌与丟世一不丘(bool 丘丄丆不丛丗上三上)
    {
    
    }
    private void Update()
    {
        var val_6;
        UnityEngine.Quaternion val_2 = this.gameObjectPlayerTrasform.rotation;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        if(this.专丞上七七且丝七丗 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        UnityEngine.Quaternion val_5 = this.专丞上七七且丝七丗.myWeaponTransform.rotation;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
    }
    public synchCamAndPlayer()
    {
    
    }

}
