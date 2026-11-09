using UnityEngine;
private sealed class PortalEnemyEffectsManager.丕丌丛丑七丈丈下万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.Renderer 三丑丛丘与丛丟世东;
    public RilisoftBot.PortalEnemyEffectsManager 丝且与丝丒丟万丁专;
    private UnityEngine.Material 丘不丌一上丂丗业上;
    private float 专世丑三丅一业上一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PortalEnemyEffectsManager.丕丌丛丑七丈丈下万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_16;
        var val_17;
        int val_18;
        float val_19;
        float val_20;
        UnityEngine.Material val_21;
        UnityEngine.Renderer val_22;
        float val_23;
        float val_24;
        val_16 = 0;
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
                return (bool)val_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丘不丌一上丂丗业上 = this.三丑丛丘与丛丟世东.material;
        if((this.三丑丛丘与丛丟世东.gameObject.GetComponent<BotChangeDamageMaterial>()) == 0)
        {
            goto label_9;
        }
        
        string val_7 = System.String.Format(format:  "{0}_Level{1}", arg0:  this.丝且与丝丒丟万丁专.丑下万丛丟下丟丕不.name, arg1:  丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一());
        val_17 = 0;
        goto label_18;
        label_1:
        val_18 = 0;
        goto label_19;
        label_2:
        val_19 = this.专世丑三丅一业上一;
        val_20 = 1f;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_19 < 0)
        {
            goto label_20;
        }
        
        val_21 = this.丘不丌一上丂丗业上;
        this.三丑丛丘与丛丟世东.material = val_21;
        val_18 = 2;
        goto label_22;
        label_9:
        val_22 = this.三丑丛丘与丛丟世东;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_18:
        if( != 0)
        {
                this.丘不丌一上丂丗业上.mainTexture = ;
        }
        
        val_22 = this.三丑丛丘与丛丟世东;
        label_24:
        val_22.material = new UnityEngine.Material(source:  this.丝且与丝丒丟万丁专.丛丑东丕丛丒专丟丙);
        val_21 = this.丘不丌一上丂丗业上.mainTexture;
        this.三丑丛丘与丛丟世东.material.mainTexture = val_21;
        val_20 = 0.25f;
        this.三丑丛丘与丛丟世东.material.SetFloat(name:  "_Burn", value:  val_20);
        val_23 = 0f;
        this.专世丑三丅一业上一 = 0f;
        label_20:
        val_23 = val_23 + UnityEngine.Time.deltaTime;
        this.专世丑三丅一业上一 = val_23;
        val_24 = val_23 * 1.25f;
        this.三丑丛丘与丛丟世东.material.SetFloat(name:  "_Burn", value:  val_24);
        val_18 = 1;
        label_22:
        val_16 = 1;
        this.丒上七丌业七丟与丐 = 0;
        label_19:
        this.丗丏丅丕丆世丁专丟 = val_18;
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
