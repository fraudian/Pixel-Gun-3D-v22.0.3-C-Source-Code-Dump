using UnityEngine;
private sealed class Player_move_c.上不东且丟专与东丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.上不东且丟专与东丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        if(this.丗丏丅丕丆世丁专丟 > 3)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丆丐丕丈业丛丆丐业 == false)
        {
            goto label_3;
        }
        
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Escape] presed in PlayerMoveC");
        }
        
        this.丝且与丝丒丟万丁专.丆丐丕丈业丛丆丐业 = false;
        this.丝且与丝丒丟万丁专.丕丐万丄上丄丒丙七 = true;
        label_28:
        label_27:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 3;
        return (bool)val_6;
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_3:
        this.丝且与丝丒丟万丁专.丕丐万丄上丄丒丙七 = false;
        if((this.丝且与丝丒丟万丁专.丕丐万丄上丄丒丙七 == false) || (((this.丝且与丝丒丟万丁专.业丘世丆且世丄丟丈() == true) || (this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.且丆丅丏丌丗丛丄丌 == true)) || (this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丑丞丒丟丞丟丆丁一 == true)))
        {
            goto label_28;
        }
        
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈 == 0)
        {
            goto label_27;
        }
        
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.pausePanel != 0)
        {
            goto label_22;
        }
        
        goto label_27;
        label_22:
        if(this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.blockedCollider.activeSelf == false)
        {
            goto label_26;
        }
        
        goto label_27;
        label_26:
        this.丝且与丝丒丟万丁专.世世丞丒丈丗丁丝丗();
        goto label_28;
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
