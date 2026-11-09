using UnityEngine;
private sealed class PopUpWeaponWindow.东三丒丞且业丟丂上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PopUpWeaponWindow 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PopUpWeaponWindow.东三丒丞且业丟丂上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_23;
        int val_24;
        var val_25;
        var val_26;
        val_23 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_37;
        }
        
        val_24 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_25 = null;
        val_25 = null;
        this.丝且与丝丒丟万丁专.openCloseTouchButton.丝下丝丏世丝丈下丅(丄一丌丝不三丙丗上:  15, 丁丝且业丛丘丘专上:  JoystickController.丘万丏三丏丑世丐丏.transform);
        下丂世丂不丛专一一 val_3 = 下丂世丂不丛专一一.丏丛丌世专丒丆不世(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业());
        var val_23 = val_3;
        val_26 = val_3;
        val_23 = this.丝且与丝丒丟万丁专.weaponsListGameObject.GetComponent<UIPanel>();
        if(val_23 != 0)
        {
                float val_9 = (float)val_23 / val_23.width;
            this.丝且与丝丒丟万丁专.weaponsListGameObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_12 = this.丝且与丝丒丟万丁专.weaponsListGameObject.transform.localPosition;
            val_23 = val_23 + val_26;
            val_9 = val_9 * val_23.height;
            val_26 = this.丝且与丝丒丟万丁专.openCloseTouchButton.transform;
            UnityEngine.Vector3 val_20 = val_26.localPosition;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((float)-val_23) * 0.5f) * ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f), y = (val_9 - (float)val_26) * (-0.5f), z = 0f}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            this.丝且与丝丒丟万丁专.weaponsListGameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            val_23 = this.丝且与丝丒丟万丁专.tweenAlphaForPanel;
            if(val_23 != 0)
        {
                val_23 = this.丝且与丝丒丟万丁专.tweenAlphaForPanel;
            val_24 = 0;
            this.丝且与丝丒丟万丁专.tweenAlphaForPanel.to = V0.16B;
            return (bool)val_24;
        }
        
        }
        
        label_37:
        val_24 = 0;
        return (bool)val_24;
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
