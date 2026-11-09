using UnityEngine;
private sealed class BPTutorialGetChallengeReward.丛丟丒丒业丈丘世丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BPTutorialGetChallengeReward 丝且与丝丒丟万丁专;
    public PGCompany.BattlePass.BPChallengeRememberedReward 丗七丟丈三不丕一三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPTutorialGetChallengeReward.丛丟丒丒业丈丘世丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        var val_29;
        PGCompany.BattlePass.BPTutorialGetChallengeReward val_30;
        var val_31;
        int val_32;
        val_29 = this;
        val_30 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丝且与丝丒丟万丁专._rewardAttractor == 0) || ((System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  this.丗七丟丈三不丕一三.Rewards).Type) != 1100))
        {
            goto label_9;
        }
        
        if(PGCompany.BattlePass.BattlePassSettings.Instance != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_9 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  PGCompany.BattlePass.BattlePassSettings.Instance.GiveBPExpStartAudioClip);
        }
        
        }
        
        val_31 = null;
        val_31 = null;
        PGCompany.BattlePass.BattlePassLevelView.世丑上丝上且丌丌丟 = PGCompany.BattlePass.BattlePassSettings.不丈丑丑丆丁上下丛();
        val_30 = this.丗七丟丈三不丕一三.Rewards.Item[0].Count;
        this.丝且与丝丒丟万丁专._rewardAttractor.GiveReward(丌丒丝东丌下丕丁丅:  val_30);
        if(PGCompany.BattlePass.BattlePassLevelView.上且七丑与丕丘丒丅 == null)
        {
            goto label_70;
        }
        
        List.Enumerator<T> val_13 = 0.GetEnumerator();
        label_37:
        if(((-282194160) & 1) == 0)
        {
            goto label_29;
        }
        
        string val_16 = val_15.丐丏七丌丕丗业且上();
        if(val_16 == 0)
        {
            goto label_37;
        }
        
        val_16.AddFakeProgress(上丕丈丞丌丘丅不与:  this.丗七丟丈三不丕一三.Rewards.Item[0].Count);
        goto label_37;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  30);
        BPChallengesController.丑七不且上丗丁一世().世丗丟丆丒丈万丕丈(丞丅上丏丂且下丅与:  this.丗七丟丈三不丕一三.Id);
        this.丝且与丝丒丟万丁专.丐丁丆丈丁世丁上丙 = 0;
        if(PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世() != 0)
        {
                PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().U_SkipStep();
        }
        
        val_29 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_29.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        label_2:
        val_32 = 0;
        return (bool)val_32;
        label_9:
        val_29 = BPChallengesController.丑七不且上丗丁一世();
        val_29.世丗丟丆丒丈万丕丈(丞丅上丏丂且下丅与:  this.丗七丟丈三不丕一三.Id);
        val_32 = 0;
        this.丝且与丝丒丟万丁专.丐丁丆丈丁世丁上丙 = 0;
        return (bool)val_32;
        label_29:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_70:
        val_32 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.丗丏丅丕丆世丁专丟 = val_32;
        return (bool)val_32;
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
