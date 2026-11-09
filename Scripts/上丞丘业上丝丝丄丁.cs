using UnityEngine;
private sealed class PlayerArrowToPortalController.上丞丘业上丝丝丄丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerArrowToPortalController 丝且与丝丒丟万丁专;
    public UnityEngine.Color 丕丟上万上且一丑三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerArrowToPortalController.上丞丘业上丝丝丄丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(this.丝且与丝丒丟万丁专.丛丂丘丈丏丟下丆世 == 0)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
            val_6 = this.丝且与丝丒丟万丁专.丛丂丘丈丏丟下丆世.GetChild(index:  0).GetChild(index:  0).GetComponent<UnityEngine.Renderer>().material;
            val_6.color = new UnityEngine.Color() {r = this.丕丟上万上且一丑三, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
