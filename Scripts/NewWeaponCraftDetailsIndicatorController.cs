using UnityEngine;
public class NewWeaponCraftDetailsIndicatorController : MonoBehaviour
{
    // Fields
    public UILabel label;
    public UILabel label3digit;
    private float 丌丗丟一丐丞丈世上;
    
    // Methods
    private void Start()
    {
        this.丙丟丄下万丙丗丑万();
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 + (-0.5f);
        if(val_1 < 0)
        {
                return;
        }
        
        this.丙丟丄下万丙丗丑万();
    }
    private void 丙丟丄下万丙丗丑万()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.label.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.label3digit.gameObject, 丏业丟一东丂东丘丛:  false);
        this.丌丗丟一丐丞丈世上 = UnityEngine.Time.realtimeSinceStartup;
    }
    public NewWeaponCraftDetailsIndicatorController()
    {
        this.丌丗丟一丐丞丈世上 = -3.402823E+38f;
    }

}
