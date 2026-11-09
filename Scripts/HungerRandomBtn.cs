using UnityEngine;
public class HungerRandomBtn : MonoBehaviour
{
    // Fields
    private UIButton 下丒丘丅丌丏丛丗丆;
    
    // Methods
    private void Awake()
    {
        this.下丒丘丅丌丏丛丗丆 = this.GetComponent<UIButton>();
    }
    private void OnClick()
    {
        UnityEngine.GameObject val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                val_7 = BankController.丑七不且上丗丁一世();
            if(val_7.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_8 = null;
        val_8 = null;
        val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 88];
        val_7 = WeaponManager.丟丗丄业丘丗业丗七.myTable;
        if(val_7 == 0)
        {
                return;
        }
        
        val_9 = null;
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_10 = null;
            丘丐丞上世丏一且业();
            return;
        }
        
        val_11 = null;
        丘丘万丟丂丟丈丅丕();
    }
    private void Update()
    {
        this.丑不丗三丕丌万丁丙();
    }
    private void 丑不丗三丕丌万丁丙()
    {
        if(this.下丒丘丅丌丏丛丗丆 == 0)
        {
                return;
        }
        
        bool val_3 = 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public HungerRandomBtn()
    {
    
    }

}
