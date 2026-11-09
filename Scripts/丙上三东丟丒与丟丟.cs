using UnityEngine;
internal sealed class 丙上三东丟丒与丟丟 : 专丗上丌丗与丞下丄
{
    // Fields
    private System.Action 丁业三上丛丐且专东;
    
    // Methods
    internal 丙上三东丟丒与丟丟(System.Action 丁业三上丛丐且专东)
    {
        this.丁业三上丛丐且专东 = 丁业三上丛丐且专东;
    }
    internal override void 三丑丛丄万丟丄丞丁()
    {
        if(this.丁业三上丛丐且专东 == null)
        {
                return;
        }
        
        this.丁业三上丛丐且专东.Invoke();
    }
    internal override void 丌丄丏下七丁专丂世()
    {
    
    }

}
