using UnityEngine;
private sealed class InGameGUIPart_ArmRace.丌上业一丏不丏丆东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public InGameGUIPart_ArmRace 丝且与丝丒丟万丁专;
    private float 丙下丘丅且丑丗丈一;
    private float 丑东与丄丏丙下丒与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameGUIPart_ArmRace.丌上业一丏不丏丆东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_25;
        var val_26;
        UnityEngine.AudioSource val_27;
        float val_28;
        float val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        int val_36;
        var val_37;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_33;
        }
        
        val_25 = this;
        this.丙下丘丅且丑丗丈一 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_26 = null;
        val_26 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        label_6:
        var val_1 = (null == null) ? GameController.onlineMode : 0;
        val_27 = mem[onlineMode == null ? GameController.onlineMode : 0 + 536];
        val_27 = onlineMode == null ? GameController.onlineMode : 0 + 536;
        this.丑东与丄丏丙下丒与 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 80;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_10;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_11;
        }
        
        val_27 = this.丝且与丝丒丟万丁专.不丁丙丑丂丘专丈丆;
        goto label_12;
        label_1:
        val_25 = this.丙下丘丅且丑丗丈一;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_10:
        val_28 = mem[this.丙下丘丅且丑丗丈一];
        val_28 = val_25;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_11:
        val_27 = 123372728;
        label_12:
        val_27.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.soundChangeWeapon);
        val_28 = this.丙下丘丅且丑丗丈一;
        label_14:
        val_29 = this.丝且与丝丒丟万丁专.gunCellXstep;
        if(val_28 < 0)
        {
            goto label_16;
        }
        
        val_30 = null;
        val_30 = null;
        if(((丁丄一且丐丑丝丕丄() - 1) & 2147483648) != 0)
        {
            goto label_33;
        }
        
        val_31 = null;
        val_31 = null;
        val_25 = 1152921505189646336;
        val_32 = null;
        val_32 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_29;
        }
        
        }
        
        label_29:
        var val_6 = (null == null) ? GameController.onlineMode : 0;
        val_27 = mem[onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40];
        val_27 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 96 + 40;
        if((丁丄一且丐丑丝丕丄() - 1) >= val_27.Count)
        {
            goto label_33;
        }
        
        val_33 = null;
        val_33 = null;
        if(GameController.onlineMode == null)
        {
            goto label_36;
        }
        
        val_34 = null;
        if(null == val_34)
        {
            goto label_37;
        }
        
        label_36:
        val_35 = null;
        goto label_38;
        label_16:
        float val_9 = UnityEngine.Time.deltaTime;
        float val_25 = 1f;
        val_25 = val_25 / this.丑东与丄丏丙下丒与;
        val_25 = val_29 * val_25;
        val_9 = val_9 * val_25;
        val_25 = this.丙下丘丅且丑丗丈一 + val_9;
        val_29 = (val_25 > this.丝且与丝丒丟万丁专.gunCellXstep) ? (this.丝且与丝丒丟万丁专.gunCellXstep - this.丙下丘丅且丑丗丈一) : (val_9);
        val_9 = val_29 + this.丙下丘丅且丑丗丈一;
        this.丙下丘丅且丑丗丈一 = val_9;
        val_27 = 0;
        goto label_39;
        label_54:
        if(this.丝且与丝丒丟万丁专.cells.Item[0] != 0)
        {
            goto label_43;
        }
        
        if(this.丝且与丝丒丟万丁专.cells == null)
        {
            goto label_44;
        }
        
        val_25 = this.丝且与丝丒丟万丁专.cells.Item[0];
        goto label_45;
        label_43:
        UnityEngine.Transform val_15 = this.丝且与丝丒丟万丁专.cells.Item[0].transform;
        UnityEngine.Vector3 val_16 = val_15.localPosition;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_15.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        goto label_52;
        label_44:
        val_25 = this.丝且与丝丒丟万丁专.cells.Item[0];
        label_45:
        bool val_19 = this.丝且与丝丒丟万丁专.cells.Remove(item:  val_25);
        label_52:
        val_27 = 1;
        label_39:
        if(val_27 < this.丝且与丝丒丟万丁专.cells.Count)
        {
            goto label_54;
        }
        
        val_36 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_36;
        return (bool)val_36;
        label_37:
        val_35 = val_34;
        label_38:
        var val_21 = (val_34 == val_35) ? GameController.onlineMode : 0;
        val_37 = null;
        val_37 = null;
        val_27 = 丁丄一且丐丑丝丕丄();
        七专丟丒七丆下丂丛 val_24 = val_34 == val_35 ? GameController.onlineMode : 0 + 536 + 96 + 40.Item[val_27 - 1];
        this.丝且与丝丒丟万丁专.一且丄万丂一丌上七(丏丟万且丝丒丝丅东:  val_24.killsToUpgrade);
        label_33:
        val_36 = 0;
        return (bool)val_36;
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
