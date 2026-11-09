using UnityEngine;
private sealed class AuthSceneController.丆上七业专业丛下丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AuthSceneController 丝且与丝丒丟万丁专;
    private PGCompany.丌丐丝三丗世丆世上 三下丌专丗且不七丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.丆上七业专业丛下丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.AuthorizationScene.AuthSceneLoginGui val_7;
        PGCompany.丌丐丝三丗世丆世上 val_8;
        int val_9;
        val_7 = this;
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
            goto label_18;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        PGCompany.丌丐丝三丗世丆世上 val_1 = new PGCompany.丌丐丝三丗世丆世上();
        val_8 = this.三下丌专丗且不七丑;
        this.三下丌专丗且不七丑 = val_1;
        val_1.且丅丟丂三丆丏七丛();
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._authInterface.丄丘丗丞丟丘丒丗业(世丁丙世丄一万丆三:  1);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        ActivityIndicator.与丛上丆丐丞丗东七(丙业与丙丗丝不丈东:  false);
        ActivityIndicator.不丌世万丌丘丘丒上 + 80.SetActive(value:  false);
        val_7 = this.丝且与丝丒丟万丁专.<丐丆上丄丌丕与丛业>k__BackingField;
        if(val_7 == 0)
        {
            goto label_18;
        }
        
        val_7 = this.丝且与丝丒丟万丁专.<丐丆上丄丌丕与丛业>k__BackingField.gameObject;
        UnityEngine.Object.Destroy(obj:  val_7);
        goto label_18;
        label_2:
        val_8 = this.三下丌专丗且不七丑;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_5:
        if(mem[this.三下丌专丗且不七丑].七上丕且丝万一不丂() == false)
        {
            goto label_20;
        }
        
        if(mem[this.三下丌专丗且不七丑].丛丗丏丑七丁东丒与() == false)
        {
            goto label_22;
        }
        
        label_18:
        val_9 = 0;
        return (bool)val_9;
        label_20:
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_22:
        ConnectionLostChecker.下丗万丆世丄丝不丕(丙业与丙丗丝不丈东:  false);
        0.丞丞万三丌丙丗丄且();
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  1.5f);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_9 = 1;
        return (bool)val_9;
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
