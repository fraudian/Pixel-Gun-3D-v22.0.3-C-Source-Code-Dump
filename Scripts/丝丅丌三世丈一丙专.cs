using UnityEngine;
private sealed class LobbyItemEffectPerInterval.丝丅丌三世丈一丙专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LobbyItemEffectPerInterval 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丗丕专丐丞丞下不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyItemEffectPerInterval.丝丅丌三世丈一丙专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSecondsRealtime val_27;
        string val_28;
        string val_29;
        int val_30;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSecondsRealtime val_1 = null;
        val_27 = val_1;
        val_1 = new UnityEngine.WaitForSecondsRealtime(time:  1f);
        this.丗丕专丐丞丞下不丒 = val_27;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(0 == 0)
        {
            goto label_44;
        }
        
        if(0.不专丌丅且丝丗丞下() == false)
        {
            goto label_7;
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_44;
        }
        
        val_28 = X22.业上丙丞丐丄丆丅七();
        val_27 = Progress.七七世万专丕丁上业.下业一丒丗三丝丆丂().丘与丗丏一且丁丞丂(万专万世丂丌丌下万:  val_28);
        if(val_27 <= 0)
        {
                val_27 = FriendsController.丝丗专上三不丄丑丑();
            val_29 = X23.业上丙丞丐丄丆丅七();
            val_28 = val_29;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().不不丂上丑丕丗丟丘(万专万世丂丌丌下万:  val_28, 丂三丟丂丈丐丆丗丟:  val_27);
        }
        
        if((this.丝且与丝丒丟万丁专.世三丞丅丑丌丈丈一() + (val_27 << )) >= FriendsController.丝丗专上三不丄丑丑())
        {
            goto label_44;
        }
        
        val_29 = 1152921505359773696;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  141);
        if((this.丝且与丝丒丟万丁专 & 1) != 0)
        {
                var val_27 = (long)val_27;
            long val_15 = this.丝且与丝丒丟万丁专.世三丞丅丑丌丈丈一();
            long val_16 = FriendsController.丝丗专上三不丄丑丑() - val_27;
            val_27 = val_16 - ((val_16 / val_15) * val_15);
            val_27 = FriendsController.丝丗专上三不丄丑丑() - val_27;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().不不丂上丑丕丗丟丘(万专万世丂丌丌下万:  val_27.业上丙丞丐丄丆丅七(), 丂三丟丂丈丐丆丗丟:  val_27);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        goto label_44;
        label_2:
        val_30 = 0;
        return (bool)val_30;
        label_7:
        val_27 = Progress.七七世万专丕丁上业.下业一丒丗三丝丆丂();
        if((val_27.丘与丗丏一且丁丞丂(万专万世丂丌丌下万:  X22.业上丙丞丐丄丆丅七())) >= 1)
        {
                val_27 = val_27.业上丙丞丐丄丆丅七();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().不不丂上丑丕丗丟丘(万专万世丂丌丌下万:  val_27, 丂三丟丂丈丐丆丗丟:  0);
        }
        
        label_44:
        val_30 = 1;
        this.丗丏丅丕丆世丁专丟 = val_30;
        this.丒上七丌业七丟与丐 = this.丗丕专丐丞丞下不丒;
        return (bool)val_30;
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
