using UnityEngine;
private sealed class 丌丟专丒丟丂万东丄.东丛丅上丙丅三丑丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.Offers.丌丟专丒丟丂万东丄 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丗丕专丐丞丞下不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丌丟专丒丟丂万东丄.东丛丅上丙丅三丑丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_21;
        var val_22;
        int val_23;
        var val_24;
        Rilisoft.Offers.东下上东丅丂丘丗丙 val_25;
        int val_26;
        if((this.丗丏丅丕丆世丁专丟 - 1) < 2)
        {
            goto label_1;
        }
        
        if((this.丗丏丅丕丆世丁专丟 - 3) >= 2)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_5;
        }
        
        Progress.AdaptiveProgress val_4 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
        val_4.SeasonStartAt = 0;
        this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Clear();
        .SeasonId = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丌丗丏丝丈丒一一丞;
        Rilisoft.Offers.丌丟专丒丟丂万东丄.丙丕丘丒丆丅七万丗(丙业与丙丗丝不丈东:  new Progress.AdaptiveProgress());
        Progress.AdaptiveProgress val_6 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
        val_6.SeasonStartAt = FriendsController.丝丗专上三不丄丑丑();
        val_21 = FriendsController.丝丗专上三不丄丑丑();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁与丑丁丐丑下丌丏(世不下丟世一丝丐丗:  Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丌丗丏丝丈丒一一丞, 丂三丟丂丈丐丆丗丟:  val_21);
        val_22 = Progress.七七世万专丕丁上业.丑丙丏东丘丏专丐丕();
        Rilisoft.Offers.丌丟专丒丟丂万东丄.丙丕丘丒丆丅七万丗(丙业与丙丗丝不丈东:  val_22.丒丁上丟丑丁丄世丁());
        this.丝且与丝丒丟万丁专.东丌下丅丟丐下丙丏(丆丄丘丂业丛七丁且:  true);
        goto label_44;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.一丗七丌一世东丈丏 == null)
        {
            goto label_25;
        }
        
        label_40:
        val_23 = 2;
        this.丒上七丌业七丟与丐 = 0;
        goto label_37;
        label_2:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_27;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_22 = 1152921505501892608;
        val_24 = null;
        val_24 = null;
        val_25 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕;
        if(val_25 == null)
        {
            goto label_34;
        }
        
        val_25 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕;
        if(val_25 == null)
        {
            goto label_33;
        }
        
        if(Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丗丛下不丟丑业丆业 <= 0)
        {
            goto label_34;
        }
        
        this.丗丕专丐丞丞下不丒 = new UnityEngine.WaitForSecondsRealtime(time:  10f);
        goto label_44;
        label_27:
        val_26 = 0;
        return (bool)val_26;
        label_5:
        this.丒上七丌业七丟与丐 = 0;
        val_23 = 4;
        goto label_37;
        label_25:
        val_22 = 1152921505065418752;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_40;
        }
        
        Progress.AdaptiveProgress val_14 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
        if(val_14.SeasonStartAt < 1)
        {
            goto label_44;
        }
        
        Progress.AdaptiveProgress val_15 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
        val_21 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕;
        val_22 = (long)Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丗丛下不丟丑业丆业 + val_15.SeasonStartAt;
        var val_18 = val_22 - 1;
        val_18 = val_18 - FriendsController.丝丗专上三不丄丑丑();
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  UnityEngine.Mathf.Max(a:  0f, b:  (float)val_18));
        val_23 = 3;
        label_37:
        this.丗丏丅丕丆世丁专丟 = val_23;
        val_26 = 1;
        return (bool)val_26;
        label_44:
        val_26 = 1;
        this.丗丏丅丕丆世丁专丟 = val_26;
        this.丒上七丌业七丟与丐 = this.丗丕专丐丞丞下不丒;
        return (bool)val_26;
        label_34:
        val_26 = 0;
        this.丝且与丝丒丟万丁专.丗丐与七丐丞上丟丈 = 0;
        return (bool)val_26;
        label_33:
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
