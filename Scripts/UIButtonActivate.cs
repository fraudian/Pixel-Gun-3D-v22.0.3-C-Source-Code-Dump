using UnityEngine;
public class UIButtonActivate : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject target;
    public bool state;
    
    // Methods
    private void OnClick()
    {
        if(this.target == 0)
        {
                return;
        }
        
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.target, 丏业丟一东丂东丘丛:  (this.state == true) ? 1 : 0);
    }
    public UIButtonActivate()
    {
        this.state = true;
    }

}
