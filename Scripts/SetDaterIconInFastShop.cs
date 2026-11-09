using UnityEngine;
public class SetDaterIconInFastShop : MonoBehaviour
{
    // Fields
    public string daterIconName;
    
    // Methods
    private void Awake()
    {
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return;
        }
        
        this.GetComponent<UISprite>().spriteName = this.daterIconName;
    }
    public SetDaterIconInFastShop()
    {
    
    }

}
