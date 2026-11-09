using UnityEngine;
public class FacebookInNetworkTableBtn : MonoBehaviour
{
    // Methods
    private void Start()
    {
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void OnClick()
    {
        var val_3;
        var val_4;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        GetComponent<NetworkStartTable>().丞丂丂丗丐丄七三东();
    }
    public FacebookInNetworkTableBtn()
    {
    
    }

}
