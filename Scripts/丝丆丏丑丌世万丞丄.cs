using UnityEngine;
private sealed class BotAiController.丝丆丏丑丌世万丞丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.BotAiController 丝且与丝丒丟万丁专;
    private bool 丟三丞一丗丗丏东丅;
    private UnityEngine.WaitForSeconds 丁专不丅丟丁东丄丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BotAiController.丝丆丏丑丌世万丞丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RilisoftBot.BaseBot val_14;
        int val_15;
        float val_17;
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
        
        this.丟三丞一丗丗丏东丅 = false;
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.isStationary = true;
        UnityEngine.Coroutine val_3 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丐专丒上七丒丆丁丁(丆丐七丅丆丗丛上与:  0.2f));
        val_14 = this.丝且与丝丒丟万丁专.丗丛一丁丌与丟东丙;
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = 0;
        this.丝且与丝丒丟万丁专.isStationary = false;
        return (bool)val_15;
        label_2:
        var val_14 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_14:
        UnityEngine.Vector3 val_4 = this.丝且与丝丒丟万丁专.丟丂丟丁丈专丅万世();
        val_17 = val_4.x;
        bool val_5 = this.丝且与丝丒丟万丁专.上丙丁丕丑丌丂下丅.Warp(newPosition:  new UnityEngine.Vector3() {x = val_17, y = val_4.y, z = val_4.z});
        bool val_6 = val_5;
        this.丟三丞一丗丗丏东丅 = val_6;
        if(val_6 == true)
        {
            goto label_13;
        }
        
        val_14 = val_14 + 1;
        if(val_14 < 4)
        {
            goto label_14;
        }
        
        label_13:
        if(val_5 != true)
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            val_17 = val_7.x;
            bool val_8 = this.丝且与丝丒丟万丁专.上丙丁丕丑丌丂下丅.Warp(newPosition:  new UnityEngine.Vector3() {x = val_17, y = val_7.y, z = val_7.z});
        }
        
        UnityEngine.Coroutine val_10 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丐专丒上七丒丆丁丁(丆丐七丅丆丗丛上与:  0.2f));
        val_14 = this.丝且与丝丒丟万丁专.丗丛一丁丌与丟东丙;
        val_14.TryPlayAudioClip(丆与丈丏丟七丁东丛:  this.丝且与丝丒丟万丁专.teleportEnd);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_15 = 1;
        this.丒上七丌业七丟与丐 = this.丁专不丅丟丁东丄丐;
        return (bool)val_15;
        label_3:
        val_15 = 0;
        return (bool)val_15;
        label_6:
        mem[240] = 1;
        UnityEngine.Coroutine val_12 = 0.StartCoroutine(routine:  0.丐专丒上七丒丆丁丁(丆丐七丅丆丗丛上与:  0.2f));
        val_14 = 28563616;
        label_7:
        val_14.TryPlayAudioClip(丆与丈丏丟七丁东丛:  this.丝且与丝丒丟万丁专.teleportStart);
        UnityEngine.WaitForSeconds val_13 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        val_15 = 1;
        this.丁专不丅丟丁东丄丐 = val_13;
        this.丒上七丌业七丟与丐 = val_13;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
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
