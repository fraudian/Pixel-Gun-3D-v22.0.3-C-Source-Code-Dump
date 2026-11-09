using UnityEngine;
internal sealed class PostSocialBtn : MonoBehaviour
{
    // Fields
    public bool isFacebook;
    
    // Methods
    private void Start()
    {
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void OnClick()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "PostSocialBtn");
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_11 = null;
        if(this.isFacebook != false)
        {
                val_12 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myTable == 0)
        {
                return;
        }
        
            val_13 = null;
            val_13 = null;
            GetComponent<NetworkStartTable>().丞丂丂丗丐丄七三东();
            return;
        }
        
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable == 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        GetComponent<NetworkStartTable>().丑业丘下丐东丏丛丛();
    }
    public PostSocialBtn()
    {
    
    }

}
