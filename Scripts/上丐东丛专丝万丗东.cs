using UnityEngine;
private sealed class GameEventSetsViewChestContentField.上丐东丛专丝万丗东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventSetsViewChestContentField 丝且与丝丒丟万丁专;
    private Rilisoft.GameEventSetsViewChestContentField.丛丄丁业且世丝丂丅 丄丌丂东丘丗一万且;
    private Rilisoft.GameEventItem 丘丗且丁一丂丛丂丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventSetsViewChestContentField.上丐东丛专丝万丗东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GameEventSetsViewChestContentField.丛丄丁业且世丝丂丅 val_28;
        Rilisoft.与专丒丞丐一丒丂东 val_29;
        int val_30;
        var val_31;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丝且与丝丒丟万丁专.Parameter.丒世业三丘丝不下丕() == true) || (this.丝且与丝丒丟万丁专.Parameter.丒业丌丕七丛丆丒丄() == true))
        {
            goto label_7;
        }
        
        Rilisoft.GameEventItem val_6 = this.丝且与丝丒丟万丁专.Parameter.下丅下下专丒业丝一();
        this.丘丗且丁一丂丛丂丌 = val_6;
        if(val_6 == null)
        {
            goto label_9;
        }
        
        GameEventSetsViewChestContentField.丛丄丁业且世丝丂丅 val_7 = new GameEventSetsViewChestContentField.丛丄丁业且世丝丂丅();
        val_28 = this;
        this.丄丌丂东丘丗一万且 = val_7;
        mem[1152921542805322912] = 0;
        mem[1152921542805322920] = this.丘丗且丁一丂丛丂丌;
        val_7.丂三丗丐丆丌丌丏七(丗丛丑不丕丟万丒丆:  false);
        mem[1152921542805322880] = 1;
        val_7.ShowAsReward(丌不丞丁七丂万上丏:  new System.Action(object:  val_7, method:  System.Void GameEventSetsViewChestContentField.丛丄丁业且世丝丂丅::丛丞业丙丗下专丂丕()));
        goto label_13;
        label_1:
        val_28 = this.丄丌丂东丘丗一万且;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_13:
        val_29 = mem[this.丄丌丂东丘丗一万且];
        if((mem[this.丄丌丂东丘丗一万且] + 16) == 0)
        {
            goto label_15;
        }
        
        val_30 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_30;
        return (bool)val_30;
        label_2:
        val_30 = 0;
        return (bool)val_30;
        label_15:
        mem2[0] = 0;
        label_9:
        Progress.下丁下丂七丆丙七一 val_9 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_9.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  39);
        if(this.丘丗且丁一丂丛丂丌 == null)
        {
            goto label_21;
        }
        
        Rilisoft.上专业三丟丁丞专下 val_10 = val_9.且丌三丙丙与与丝世();
        val_31 = 0;
        goto label_26;
        label_21:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_26:
        PGCompany.Analytics.一业丗丆世世上丁且.丈上丑丗丆丆丞丐万(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 世专丑与丞丞与丙丂:  丟丂丞不专丆万丒世(), 丄东世不与不丐不专:  this.丘丗且丁一丂丛丂丌.Data.Count, 与丕丒丗一万丒丆丑:  东不七丏上丑丈专下().丟丂丞不专丆万丒世(), 丏七丙不丁丁丒丒丗:  this.丘丗且丁一丂丛丂丌.Data.Id, 丅且三万丘丙业丙丗:  X26.丅丙丛丑丌丆丌丕丒());
        label_28:
        this.丝且与丝丒丟万丁专.Parameter.一丈丘七丙丙丁三丕();
        Rilisoft.与专丒丞丐一丒丂东 val_22 = this.丝且与丝丒丟万丁专.Parameter;
        val_22.丗丄丐万丏业丏丑万();
        System.Collections.Generic.List<Rilisoft.GameEventItem> val_23 = new System.Collections.Generic.List<Rilisoft.GameEventItem>();
        val_23.Add(item:  this.丘丗且丁一丂丛丂丌);
        val_28 = this.丝且与丝丒丟万丁专.Parameter.业上丙丞丐丄丆丅七();
        val_22.上丐上丐专丞丆丞丁(丑七不与丛丆一丂丞:  val_23, 丐东业丕丕丂丗丅丙:  val_28, 丄丆丂下不丝东丂一:  false);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        this.丘丗且丁一丂丛丂丌 = 0;
        label_7:
        val_29 = this.丝且与丝丒丟万丁专.Parameter;
        this.丝且与丝丒丟万丁专._chestCompleteView.Setup(与且专丈不万东一万:  val_29);
        this.丝且与丝丒丟万丁专._chestCompleteView.ShowWindow();
        val_30 = 0;
        this.丝且与丝丒丟万丁专.丌专丑东丙丕丟丌丗 = 0;
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
