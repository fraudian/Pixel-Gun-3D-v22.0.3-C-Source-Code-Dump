using UnityEngine;
private sealed class TramObject.七东万丂丂上丑丑丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TramObject 丝且与丝丒丟万丁专;
    public float 丄东丙丄丞三万世丂;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TramObject.七东万丂丂上丑丑丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        var val_10;
        int val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_21;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.不丆丏丄丐且丗丆丟 != 0)
        {
                this.丝且与丝丒丟万丁专.不丆丏丄丐且丗丆丟.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.startAttackSound);
        }
        
        val_10 = this.丝且与丝丒丟万丁专._animation.Item["attack"];
        this.丝且与丝丒丟万丁专.丒丌丅丁不丏丅七下 = val_10.length;
        this.丝且与丝丒丟万丁专.丏丞下丄一丟东丑丛();
        UnityEngine.WaitForSeconds val_6 = null;
        float val_9 = 0.68f;
        val_9 = this.丝且与丝丒丟万丁专._animation.Item["attack"].length * val_9;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  val_9);
        val_11 = 1;
        this.丒上七丌业七丟与丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.不丆丏丄丐且丗丆丟 != 0)
        {
                this.丝且与丝丒丟万丁专.不丆丏丄丐且丗丆丟.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.attackSound);
        }
        
        val_10 = 1152921505295769600;
        val_12 = null;
        val_12 = null;
        if(SiegeController.三三万丆下一丗万丛.isRoundEnding != true)
        {
                val_13 = null;
            val_13 = null;
            FortEquipmentController.丝丘丞不丂丆不丘且.UpdateGateHealth(丄东丙丄丞三万世丂:  this.丄东丙丄丞三万世丂);
            val_14 = null;
            val_14 = null;
            val_9 = SiegeController.三三万丆下一丗万丛;
            val_9.ShowFortHit();
        }
        
        label_21:
        val_11 = 0;
        return (bool)val_11;
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
