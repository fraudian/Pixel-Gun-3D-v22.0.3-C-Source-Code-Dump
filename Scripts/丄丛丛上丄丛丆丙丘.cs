using UnityEngine;
private sealed class CustomPanelConnectScene.丄丛丛上丄丛丆丙丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public CustomPanelConnectScene 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CustomPanelConnectScene.丄丛丛上丄丛丆丙丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        ConnectSceneSelectMap val_1 = 0.丝三丅丙且上丅丂丏();
        if(val_1.mapPreviewTexture.activeSelf != false)
        {
                ConnectSceneSelectMap val_3 = 0.丝三丅丙且上丅丂丏();
            val_3.mapPreviewTexture.SetActive(value:  false);
        }
        
        ConnectSceneSelectMap val_4 = 0.丝三丅丙且上丅丂丏();
        val_4.votePanelWidget.gameObject.SetActive(value:  false);
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.上上丂东不丐丈丌丞();
        label_1:
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
