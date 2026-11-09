using UnityEngine;
private sealed class GameEventLobbyButtonHandler.东东丗丑专丞世丞与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventLobbyButtonHandler 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventLobbyButtonHandler.东东丗丑专丞世丞与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.TextGroup val_14;
        int val_15;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  1f);
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        val_14 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丝丌丄丘丞东丕世且(丟丟丄专上丟丁丐丝:  this.丝且与丝丒丟万丁专.EventId);
        UnityEngine.GameObject val_4 = this.丝且与丝丒丟万丁专._body.gameObject;
        if(val_14 == false)
        {
            goto label_9;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        Rilisoft.丛且世丐丆上七业丁 val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  this.丝且与丝丒丟万丁专.EventId);
        val_14 = this.丝且与丝丒丟万丁专._eventNameText;
        val_14.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6.丑丐丏丌丑下一丑丒());
        System.Nullable<System.TimeSpan> val_9 = val_6.丙世丑丅丒丑业与不();
        if(( & 1) == 0)
        {
            goto label_27;
        }
        
        val_14 = this.丝且与丝丒丟万丁专._timerLabel;
        System.Nullable<System.TimeSpan> val_11 = val_6.丙世丑丅丒丑业与不();
        val_14.text = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0984"), arg1:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        goto label_27;
        label_2:
        val_15 = 0;
        return (bool)val_15;
        label_9:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
        label_27:
        val_15 = 1;
        this.丗丏丅丕丆世丁专丟 = val_15;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
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
