using UnityEngine;
[Serializable]
public class ButtonPressEffectEntry
{
    // Fields
    private UnityEngine.Transform target;
    private UnityEngine.Vector3 notPressedPosition;
    private UnityEngine.Vector3 pressedPosition;
    
    // Methods
    internal void 丅专下万丕丑丆丅丝(bool 万东丂丒且丅丛丑丕)
    {
        if(this.target == 0)
        {
                return;
        }
        
        this.target.localPosition = new UnityEngine.Vector3() {x = (万东丂丒且丅丛丑丕 != true) ? this.pressedPosition : this.notPressedPosition, y = (万东丂丒且丅丛丑丕 != true) ? 1152921539859125144 : 1152921539859125132, z = (万东丂丒且丅丛丑丕 != true) ? 1152921539859125148 : 1152921539859125136};
    }
    public ButtonPressEffectEntry()
    {
    
    }

}
