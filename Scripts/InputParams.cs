using UnityEngine;
internal sealed class InputParams : PGBehaviour
{
    // Fields
    private UILabel _label;
    private UIInput _input;
    
    // Methods
    internal void 丒丁丅一下丂专万不(string 丕丗丘丑丛与丑业丒)
    {
        this._label.text = 丕丗丘丑丛与丑业丒;
        this._input.value = "";
    }
    internal string 万丌丂上丈三丗丟丑()
    {
        if(this._input != null)
        {
                return this._input.value;
        }
        
        return this._input.value;
    }
    public InputParams()
    {
    
    }

}
