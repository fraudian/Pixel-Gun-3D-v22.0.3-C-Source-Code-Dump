using UnityEngine;
private sealed class TouchPadController.与丈丅下丁三丝丆专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TouchPadController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TouchPadController.与丈丅下丁三丝丆专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        UnityEngine.Object val_11;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.丈一丕七专不丐专世();
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.不上丂丂一丝丘丌丗();
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_3:
        0.丈一丕七专不丐专世();
        label_4:
        val_11 = 0;
        if(this.丝且与丝丒丟万丁专.touchCollider == val_11)
        {
                val_11 = public UnityEngine.BoxCollider UnityEngine.Component::GetComponent<UnityEngine.BoxCollider>();
            this.丝且与丝丒丟万丁专.touchCollider = this.丝且与丝丒丟万丁专.GetComponent<UnityEngine.BoxCollider>();
        }
        
        UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专._uiRoot.position;
        float val_11 = val_3.x;
        float val_10 = 384f;
        val_10 = (S9 - val_11) * val_10;
        val_10 = val_10 + val_10;
        val_11 = ((float)UnityEngine.Mathf.FloorToInt(f:  val_10)) + 0.5f;
        float val_12 = -164f;
        val_12 = val_11 + val_12;
        val_11 = (东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != true) ? (val_12) : (val_11);
        UnityEngine.Vector3 val_7 = this.丝且与丝丒丟万丁专.touchCollider.size;
        UnityEngine.Vector3 val_8 = this.丝且与丝丒丟万丁专.touchCollider.size;
        this.丝且与丝丒丟万丁专.touchCollider.size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_9 = this.丝且与丝丒丟万丁专.touchCollider.center;
        this.丝且与丝丒丟万丁专.touchCollider.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_10 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
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
