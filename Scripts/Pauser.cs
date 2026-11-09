using UnityEngine;
internal sealed class Pauser : MonoBehaviour
{
    // Fields
    internal static Pauser 且三丝三七七丐丁丁;
    private System.Action 丑上七丅丒丄丕丁业;
    public bool pausedVar;
    
    // Properties
    internal bool 丆丕与三丝丙丑丛三 { get; set; }
    
    // Methods
    internal bool 丟三东与三丒丛下东()
    {
        return (bool)this.pausedVar;
    }
    internal void 专丂丐丝丏东与丏世(bool 丙业与丙丗丝不丈东)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        this.pausedVar = 丙业与丙丗丝不丈东;
        val_12 = null;
        val_12 = null;
        if(JoystickController.丗三丄与丂丟丌专东 == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(JoystickController.丘万丏三丏丑世丐丏 == 0)
        {
                return;
        }
        
        val_14 = null;
        if(this.pausedVar != false)
        {
                val_15 = null;
            JoystickController.丗三丄与丂丟丌专东.transform.parent.gameObject.SetActive(value:  false);
            val_16 = JoystickController.丘万丏三丏丑世丐丏.gameObject;
            val_17 = 0;
        }
        else
        {
                val_18 = null;
            JoystickController.丗三丄与丂丟丌专东.transform.parent.gameObject.SetActive(value:  true);
            val_16 = JoystickController.丘万丏三丏丑世丐丏.gameObject;
            val_17 = 1;
        }
        
        val_16.SetActive(value:  true);
    }
    private void Awake()
    {
        null = null;
        Pauser.且三丝三七七丐丁丁 = this;
    }
    private void OnDestroy()
    {
        null = null;
        Pauser.且三丝三七七丐丁丁 = 0;
    }
    public Pauser()
    {
    
    }
    private static Pauser()
    {
    
    }

}
