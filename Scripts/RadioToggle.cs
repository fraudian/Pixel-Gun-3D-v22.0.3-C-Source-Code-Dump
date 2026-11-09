using UnityEngine;
public class RadioToggle : RadioButton
{
    // Fields
    private UnityEngine.GameObject OnSelectedObj;
    private UnityEngine.GameObject OnUnselectedObj;
    
    // Methods
    protected override void 丒三七丌丂丛丈七丗()
    {
        if(this.OnSelectedObj != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.OnSelectedObj, 丏业丟一东丂东丘丛:  this.state);
        }
        
        if(this.OnUnselectedObj == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.OnUnselectedObj, 丏业丟一东丂东丘丛:  (~this.state) & 1);
    }
    public RadioToggle()
    {
        this = new UnityEngine.MonoBehaviour();
    }

}
