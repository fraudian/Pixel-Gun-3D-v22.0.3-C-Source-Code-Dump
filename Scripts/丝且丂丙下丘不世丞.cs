using UnityEngine;
private sealed class ReplaceAdmobPerelivController.丝且丂丙下丘不世丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ReplaceAdmobPerelivController 丝且与丝丒丟万丁专;
    public System.Collections.Generic.IReadOnlyList<string> 丞上不丈专丛丞丐与;
    public int 丞世不丒下上上丝丑;
    public System.Collections.Generic.IReadOnlyList<string> 丘丅丂三丏世专丑丟;
    private UnityEngine.WWW 丛不一丈丙业丟丒一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReplaceAdmobPerelivController.丝且丂丙下丘不世丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_20;
        var val_22;
        int val_24;
        var val_26;
        object val_27;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.<丑丌专丐业且丑且丛>k__BackingField = true;
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_20 = 0;
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_22 = 0;
        if(this.丝且与丝丒丟万丁专 == 0)
        {
            goto label_35;
        }
        
        bool val_3 = System.String.IsNullOrEmpty(value:  this.丛不一丈丙业丟丒一.error);
        if(this.丛不一丈丙业丟丒一 == null)
        {
            goto label_13;
        }
        
        if(val_3 == false)
        {
            goto label_14;
        }
        
        label_37:
        if((UnityEngine.Object.op_Implicit(exists:  this.丛不一丈丙业丟丒一.texture)) == false)
        {
            goto label_17;
        }
        
        if(this.丛不一丈丙业丟丒一.texture.width <= 19)
        {
            goto label_20;
        }
        
        this.丝且与丝丒丟万丁专.丟且一万丆下丁东且 = this.丛不一丈丙业丟丒一.texture;
        if(this.丘丅丂三丏世专丑丟 == null)
        {
            goto label_23;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_22 = 0;
        goto label_27;
        label_2:
        val_24 = 0;
        return (bool)val_24;
        label_8:
        int val_27 = this.丞上不丈专丛丞丐与.Count;
        val_27 = this.丞世不丒下上上丝丑 - ((this.丞世不丒下上上丝丑 / val_27) * val_27);
        var val_28 = 0;
        val_28 = val_28 + 1;
        val_20 = 0;
        val_24 = 1;
        UnityEngine.WWW val_15 = Rilisoft.与丄丁丄丙丞下下丙.三专世丝丝丈丂东与(七丙不丅丛丘丗万与:  0.丑东世丒丞东万丗丏(上丝专丂丒一丄业东:  this.丞上不丈专丛丞丐与.Item[val_27]), 丝丌丝不丟丞丑丑丗:  true);
        this.丛不一丈丙业丟丒一 = val_15;
        if(val_15 == null)
        {
            goto label_35;
        }
        
        this.丒上七丌业七丟与丐 = val_15;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
        label_13:
        if(val_3 == true)
        {
            goto label_37;
        }
        
        label_14:
        val_26 = "[ReplaceAdmobPerelivController.LoadDataCoroutine]: "("[ReplaceAdmobPerelivController.LoadDataCoroutine]: ") + this.丛不一丈丙业丟丒一.error;
        goto label_40;
        label_17:
        val_27 = "[ReplaceAdmobPerelivController.LoadDataCoroutine] imageRequest.texture: null";
        goto label_58;
        label_20:
        val_27 = "[ReplaceAdmobPerelivController.LoadDataCoroutine] imageRequest.texture.width";
        label_58:
        label_40:
        UnityEngine.Debug.LogWarning(message:  val_27);
        label_35:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_65;
        }
        
        label_66:
        label_65:
        val_24 = 0;
        this.丝且与丝丒丟万丁专.<丑丌专丐业且丑且丛>k__BackingField = false;
        return (bool)val_24;
        label_23:
        UnityEngine.Debug.LogWarning(message:  "[ReplaceAdmobPerelivController.LoadDataCoroutine] redirectUrls: null");
        goto label_65;
        label_27:
        if(this.丘丅丂三丏世专丑丟.Count == 0)
        {
            goto label_58;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        val_22 = 0;
        int val_30 = this.丘丅丂三丏世专丑丟.Count;
        val_30 = this.丞世不丒下上上丝丑 - ((this.丞世不丒下上上丝丑 / val_30) * val_30);
        var val_31 = 0;
        val_31 = val_31 + 1;
        val_22 = 0;
        T val_24 = this.丘丅丂三丏世专丑丟.Item[val_30];
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_64;
        }
        
        this.丝且与丝丒丟万丁专.丂丟下丌东万专下丝 = val_24;
        goto label_65;
        label_64:
        mem[32] = val_24;
        goto label_66;
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
