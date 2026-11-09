using UnityEngine;
private sealed class RenderTextureForBlur.三丙丈世三丒丄丘业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RenderTextureForBlur 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RenderTextureForBlur.三丙丈世三丒丄丘业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = null;
        val_5 = null;
        float val_5 = 1f;
        float val_6 = (float)UnityEngine.Screen.height;
        val_5 = val_5 - IphoneXCameraScaler.且下丒丘丙丒丈丏万;
        val_6 = val_5 * val_6;
        val_6 = val_6 + 0.5f;
        int val_2 = UnityEngine.Mathf.RoundToInt(f:  val_6);
        int val_3 = UnityEngine.Screen.width;
        this.丝且与丝丒丟万丁专.丟三丟三丅专丂丄丂.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
        this.丝且与丝丒丟万丁专.丟三丟三丅专丂丄丂.Apply();
        this.丝且与丝丒丟万丁专.mat.mainTexture = this.丝且与丝丒丟万丁专.丟三丟三丅专丂丄丂;
        label_3:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
