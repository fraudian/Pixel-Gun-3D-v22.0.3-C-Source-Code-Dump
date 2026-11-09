using UnityEngine;
private sealed class 丌丟专丒丟丂万东丄.丏三一丕丌丑世丄上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.Offers.丌丟专丒丟丂万东丄 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丌丟专丒丟丂万东丄.丏三一丕丌丑世丄上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        int val_10;
        int val_11;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Clear();
        val_9 = null;
        val_9 = null;
        .SeasonId = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丌丗丏丝丈丒一一丞;
        Rilisoft.Offers.丌丟专丒丟丂万东丄.丙丕丘丒丆丅七万丗(丙业与丙丗丝不丈东:  new Progress.AdaptiveProgress());
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        val_10 = 1152921505065418752;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_12;
        }
        
        Progress.AdaptiveProgress val_3 = Rilisoft.Offers.丌丟专丒丟丂万东丄.业丑丁丆丕丆丂丅万();
        val_3.SeasonStartAt = FriendsController.丝丗专上三不丄丑丑();
        val_10 = mem[Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕 + 16];
        val_10 = Rilisoft.Offers.丌丟专丒丟丂万东丄.丒丄丅丟丞丅丄七丕.丌丗丏丝丈丒一一丞;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁与丑丁丐丑下丌丏(世不下丟世一丝丐丗:  val_10, 丂三丟丂丈丐丆丗丟:  FriendsController.丝丗专上三不丄丑丑());
        Rilisoft.Offers.丌丟专丒丟丂万东丄.丙丕丘丒丆丅七万丗(丙业与丙丗丝不丈东:  Progress.七七世万专丕丁上业.丑丙丏东丘丏专丐丕().丒丁上丟丑丁丄世丁());
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_25;
        }
        
        this.丝且与丝丒丟万丁专.东丌下丅丟丐下丙丏(丆丄丘丂业丛七丁且:  true);
        goto label_26;
        label_2:
        val_11 = 0;
        return (bool)val_11;
        label_12:
        val_11 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
        label_25:
        0.东丌下丅丟丐下丙丏(丆丄丘丂业丛七丁且:  true);
        label_26:
        val_11 = 0;
        this.丝且与丝丒丟万丁专.一丗七丌一世东丈丏 = 0;
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
