using UnityEngine;
private sealed class BPChallengeViewAwarder.丙一上丛丙丟三丐世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BPChallengeViewAwarder 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三东丈丌丈丅专丁不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPChallengeViewAwarder.丙一上丛丙丟三丐世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        var val_23;
        var val_24;
        int val_25;
        Rilisoft.丝丑丂丛万丐丈丘且 val_26;
        UnityEngine.WaitForSeconds val_27;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三东丈丌丈丅专丁不 = 0;
        goto label_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_23 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(((this.丝且与丝丒丟万丁专.丌与丄丑丄业丁丘丄.Count < 1) || ((this.丝且与丝丒丟万丁专.<丒丌世丁与丟丁东东>k__BackingField) == true)) || ((val_23 == null) || (BattlePassRootUI.丑七不且上丗丁一世() == 0)))
        {
            goto label_14;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  37);
        List.Enumerator<T> val_7 = this.丝且与丝丒丟万丁专.丌与丄丑丄业丁丘丄.GetEnumerator();
        val_24 = 0;
        goto label_19;
        label_2:
        val_25 = 0;
        return (bool)val_25;
        label_27:
        string val_10 = val_9.丐丏七丌丕丗业且上();
        val_10.丄三丐丌丁丐且丁万();
        if(val_10.三丝丄丈丆丂专丄东() == 10)
        {
                PGCompany.BattlePass.BPData val_12 = X21.丁专丗万三上丟三丆();
            val_26 = val_12._blockPointForViewNewDailyChallenges;
        }
        else
        {
                PGCompany.BattlePass.BPData val_13 = X21.丁专丗万三上丟三丆();
            val_26 = val_13._blockPointForViewNewCommonChallenges;
        }
        
        label_19:
        if(((-414755824) & 1) != 0)
        {
            goto label_27;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(137142272 >= 1)
        {
                bool val_15 = BankController.东一且丝万一丆七丘(丌丒丝东丌下丕丁丅:  137142272, 三上丆世丞丏丁一上:  21, 丕丕世且下一与丝与:  PGCompany.BattlePass.BattlePassSettings.丌下丌丂东下业丄丆(), 丅丅丞丙丁丕丌世东:  0);
            val_23 = BattlePassRootUI.丑七不且上丗丁一世().丈丝丁丕一丐丛丄丄();
            UnityEngine.Vector3 val_18 = X23 + 40.position;
            val_23.三且世三丂七丐一丟(丈万丏丈上丑不丅上:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, 丞下万上三丘上与专:  X23 + 48, 丄万不且丂丛丘业丐:  137142272);
        }
        
        X23 + 32.Clear();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  54);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        label_14:
        val_27 = this.三东丈丌丈丅专丁不;
        if(val_27 == null)
        {
                UnityEngine.WaitForSeconds val_21 = null;
            val_27 = val_21;
            val_21 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
            this.三东丈丌丈丅专丁不 = val_27;
        }
        
        val_25 = 1;
        this.丒上七丌业七丟与丐 = val_27;
        this.丗丏丅丕丆世丁专丟 = val_25;
        return (bool)val_25;
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
