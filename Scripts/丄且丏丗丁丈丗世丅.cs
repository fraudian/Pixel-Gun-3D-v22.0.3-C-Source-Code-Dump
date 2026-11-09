using UnityEngine;
private sealed class BattlePassController.丄且丏丗丁丈丗世丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BattlePassController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassController.丄且丏丗丁丈丗世丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_20;
        UnityEngine.WaitForSeconds val_21;
        int val_22;
        var val_23;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_2;
        }
        
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void BattlePassController::丈丁下与丞丆丝与丝()));
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void BattlePassController::丈丁下与丞丆丝与丝()));
        System.Action val_4 = null;
        val_20 = 1152921536370633008;
        val_4 = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void BattlePassController::丌丗丛丙专业丞丐下());
        PGCompany.BattlePass.BPTutorialController.不一丁丐万丏丑丆东(丙业与丙丗丝不丈东:  val_4);
        PGCompany.BattlePass.BPTutorialController.丝丑丄不丄丏丞丂丞(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void BattlePassController::丌丗丛丙专业丞丐下()));
        goto label_5;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        label_5:
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_7;
        }
        
        val_20 = 1152921516934571616;
        if(this.丝且与丝丒丟万丁专.丟业丆丐一东丞丞丂.Count < 1)
        {
            goto label_23;
        }
        
        if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
        {
                if(BattlePassRootUI.丑七不且上丗丁一世().gameObject.activeInHierarchy == true)
        {
            goto label_23;
        }
        
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_23;
        }
        
        goto label_26;
        label_29:
        string val_14 = this.丝且与丝丒丟万丁专.丟业丆丐一东丞丞丂.Item[0];
        if(val_14 != null)
        {
                this.丝且与丝丒丟万丁专.丟业丆丐一东丞丞丂.RemoveAt(index:  0);
            this.丝且与丝丒丟万丁专.七丞丝丈三丛世上丏(丅业丙丞且丐一丙丆:  val_14);
        }
        
        label_26:
        if(this.丝且与丝丒丟万丁专.丟业丆丐一东丞丞丂.Count > 0)
        {
            goto label_29;
        }
        
        label_23:
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_16 = this.丝且与丝丒丟万丁专.丛东丛丕东丟丂丈丝();
        if(val_16 == null)
        {
            goto label_30;
        }
        
        if(val_16.与丁丂三下丛丘丁丅() == false)
        {
            goto label_38;
        }
        
        val_16.丗丘丒丅丄不丕不丏();
        goto label_38;
        label_2:
        val_21 = 0;
        val_22 = 1;
        goto label_33;
        label_6:
        val_23 = 0;
        return (bool)val_23;
        label_7:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_38;
        }
        
        goto label_38;
        label_30:
        if(this.丝且与丝丒丟万丁专.丘丞世丒世七丆且东 != null)
        {
                if(this.丝且与丝丒丟万丁专.丘丞世丒世七丆且东.丕丐丏万丏七丒三七() != false)
        {
                this.丝且与丝丒丟万丁专.丘丞世丒世七丆且东.世丄且丒丌丟丕世丛();
        }
        
        }
        
        label_38:
        val_21 = this.丝且与丝丒丟万丁专.万丄丒丐东丂丁七丙;
        if(val_21 == null)
        {
                UnityEngine.WaitForSeconds val_19 = null;
            val_21 = val_19;
            val_19 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
            this.丝且与丝丒丟万丁专.万丄丒丐东丂丁七丙 = val_21;
        }
        
        val_22 = 2;
        label_33:
        val_23 = 1;
        this.丒上七丌业七丟与丐 = val_21;
        this.丗丏丅丕丆世丁专丟 = val_22;
        return (bool)val_23;
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
