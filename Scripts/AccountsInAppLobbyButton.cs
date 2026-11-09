using UnityEngine;
public class AccountsInAppLobbyButton : MonoBehaviour
{
    // Fields
    private static AccountsInAppLobbyButton 丝业丆丁业三丈丟东;
    private UnityEngine.GameObject _hint;
    
    // Methods
    private void Awake()
    {
        if(AccountsInAppLobbyButton.丝业丆丁业三丈丟东 != 0)
        {
                return;
        }
        
        AccountsInAppLobbyButton.丝业丆丁业三丈丟东 = this;
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hint, 丏业丟一东丂东丘丛:  Rilisoft.七不丑丑下与丛丝丝.不丆丕丁万专东东且());
    }
    private bool 丝上丘丙丕丗下不下()
    {
        return Rilisoft.七不丑丑下与丛丝丝.不丆丕丁万专东东且();
    }
    public static bool HintIsShowing()
    {
        AccountsInAppLobbyButton val_3 = AccountsInAppLobbyButton.丝业丆丁业三丈丟东;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_3 = mem[AccountsInAppLobbyButton.丝业丆丁业三丈丟东 + 24];
        val_3 = AccountsInAppLobbyButton.丝业丆丁业三丈丟东._hint;
        if(val_3 == 0)
        {
                return false;
        }
        
        if(null != 0)
        {
                return activeInHierarchy;
        }
        
        return activeInHierarchy;
    }
    public AccountsInAppLobbyButton()
    {
    
    }

}
