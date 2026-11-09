using UnityEngine;
private sealed class GamepadStateNotify.丏丙且丅丙丛三丗丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private GamepadUiController 专丕丁丌丙世上一丟;
    private UITexture 丕不一东万一丘丌东;
    private float 丒不丌一丟丂专丏丅;
    private float 专一专丐丂丆丛丁丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GamepadStateNotify.丏丙且丅丙丛三丗丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GamepadDisconnectIndicator val_5;
        int val_6;
        float val_8;
        float val_9;
        float val_10;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.专丕丁丌丙世上一丟 = GamepadUiController.丆丕丝丒不丙且丐丗;
        this.丕不一东万一丘丌东 = GamepadDisconnectIndicator.__il2cppRuntimeField_generic_class;
        this.专丕丁丌丙世上一丟.RendererCamera.enabled = true;
        val_6 = 1;
        this.专丕丁丌丙世上一丟.DisconnectedIndicator.丏丝世丆且一专一丗(丙业与丙丗丝不丈东:  true);
        this.丕不一东万一丘丌东.alpha = 1f;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  3f);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_2 * 0.5f;
        val_8 = this.专一专丐丂丆丛丁丄 + val_2;
        this.专一专丐丂丆丛丁丄 = val_8;
        if(val_8 < 0)
        {
            goto label_12;
        }
        
        this.专丕丁丌丙世上一丟.RendererCamera.enabled = false;
        val_5 = this.专丕丁丌丙世上一丟.DisconnectedIndicator;
        val_5.丏丝世丆且一专一丗(丙业与丙丗丝不丈东:  false);
        label_3:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Color val_3 = this.丕不一东万一丘丌东.color;
        val_9 = 0f;
        this.丒不丌一丟丂专丏丅 = val_3.a;
        this.专一专丐丂丆丛丁丄 = 0f;
        label_12:
        float val_4 = UnityEngine.Mathf.Lerp(a:  this.丒不丌一丟丂专丏丅, b:  0f, t:  val_9);
        val_10 = 0f;
        this.丕不一东万一丘丌东.color = new UnityEngine.Color() {r = val_10, g = 0f, b = 0f, a = 0f};
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
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
