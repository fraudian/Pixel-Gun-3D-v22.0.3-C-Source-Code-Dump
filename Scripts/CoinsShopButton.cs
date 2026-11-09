using UnityEngine;
public class CoinsShopButton : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject eventX3;
    
    // Methods
    private void Start()
    {
        this.与丏丟业丒丂一三一();
    }
    private void OnEnable()
    {
        this.与丏丟业丒丂一三一();
    }
    private void 与丏丟业丒丂一三一()
    {
        bool val_6;
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌() != false)
        {
                val_6 = 1;
        }
        else
        {
                val_6 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().丐且丘业丙丅丛丝丛();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventX3, 丏业丟一东丂东丘丛:  val_6);
    }
    public CoinsShopButton()
    {
    
    }

}
