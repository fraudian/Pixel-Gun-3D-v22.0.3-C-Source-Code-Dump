using UnityEngine;
private sealed class ConnectScene.业丗且与业丞丏丐丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ConnectScene 丝且与丝丒丟万丁专;
    public BtnCategory 丟丒丞丐丐丘丒丄东;
    private UnityEngine.GameObject 上专丘专丑丂丁与不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectScene.业丗且与业丞丏丐丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_15;
        int val_16;
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
        this.上专丘专丑丂丁与不 = this.丝且与丝丒丟万丁专.丌不七业丈丘丅丛丕();
        UIWidget val_2 = this.丟丒丞丐丐丘丒丄东.GetComponent<UIWidget>();
        if(val_2 == 0)
        {
            goto label_8;
        }
        
        UnityEngine.Vector2 val_4 = val_2.pivotOffset;
        var val_5 = (val_4.x == 0f) ? -1f : 1f;
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.上专丘专丑丂丁与不.SetActive(value:  false);
        label_3:
        val_16 = 0;
        return (bool)val_16;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_16 = 1;
        this.丟丒丞丐丐丘丒丄东.isEnable = true;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1.4f);
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_16;
        label_8:
        val_15 = -1f;
        label_10:
        this.上专丘专丑丂丁与不.transform.SetParent(p:  this.丝且与丝丒丟万丁专.connectSceneMainMenu.categoryButtonsController.transform.parent);
        UnityEngine.Vector3 val_12 = this.丟丒丞丐丐丘丒丄东.transform.position;
        this.上专丘专丑丂丁与不.transform.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        this.上专丘专丑丂丁与不.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_16 = 1;
        this.上专丘专丑丂丁与不.SetActive(value:  true);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
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
