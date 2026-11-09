using UnityEngine;
private sealed class BarFillPoint.丕丕丅丈丙世东丄上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BarFillPoint 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BarFillPoint.丕丕丅丈丙世东丄上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 <= 1)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(this.丝且与丝丒丟万丁专.filledSprite != 0)
        {
                UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专.StartPoint;
            UnityEngine.Vector3 val_4 = this.丝且与丝丒丟万丁专.EndPoint;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, t:  this.丝且与丝丒丟万丁专.filledSprite.fillAmount);
            this.丝且与丝丒丟万丁专.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        
            val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
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
