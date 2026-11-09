using UnityEngine;
private sealed class CraftScrollItemView.与丙丗且丞丂丏丞丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.CraftScrollItemView 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CraftScrollItemView.与丙丗且丞丂丏丞丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_18;
        丈丞丕丘丕丗与上一 val_19;
        int val_20;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_18 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        this.三丛与七下专丅丕东 = val_18;
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
        if(this.丝且与丝丒丟万丁专._item == null)
        {
            goto label_34;
        }
        
        if(this.丝且与丝丒丟万丁专._item.丑丆丑三且丛上且丟() == false)
        {
            goto label_7;
        }
        
        System.Nullable<System.Int64> val_3 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
        if(this.丝且与丝丒丟万丁专._item == null)
        {
            goto label_10;
        }
        
        if(( & 1) == 0)
        {
            goto label_11;
        }
        
        label_19:
        this.丝且与丝丒丟万丁专._labelCraftTimer.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.丝且与丝丒丟万丁专._item.下丞丘丏丂丕丄丐丘(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_18 = this.丝且与丝丒丟万丁专._btnSpeedUp;
        val_19 = this.丝且与丝丒丟万丁专._item.且丕三丙七且且东下();
        if(val_18 != null)
        {
            goto label_26;
        }
        
        goto label_17;
        label_2:
        val_20 = 0;
        return (bool)val_20;
        label_10:
        if(( & 1) != 0)
        {
            goto label_19;
        }
        
        label_11:
        this.丝且与丝丒丟万丁专._labelCraftTimer.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.丝且与丝丒丟万丁专._item.丅丞上丘丆下上丘丅(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_18 = this.丝且与丝丒丟万丁专._btnSpeedUp;
        丈丞丕丘丕丗与上一 val_12 = null;
        val_19 = val_12;
        val_12 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  this.丝且与丝丒丟万丁专._item.丙丕丞且丕不丘丙丑().丑丘上七业丏丅丄丁().东与三丌丅三丒丏业());
        if(val_18 != null)
        {
            goto label_26;
        }
        
        label_17:
        label_26:
        val_18.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_12, 万丐丁三且下丞丈丌:  0);
        label_7:
        if(this.丝且与丝丒丟万丁专.与丛上丌丆七丒丅东 != false)
        {
                val_18 = this.丝且与丝丒丟万丁专._objNew;
            if(val_18.activeInHierarchy != false)
        {
                val_18 = this.丝且与丝丒丟万丁专.丁丏世七三丗与丏与();
            if(val_18 != 0)
        {
                val_18 = this.丝且与丝丒丟万丁专.丁丏世七三丗与丏与();
            if(val_18.isVisible != false)
        {
                this.丝且与丝丒丟万丁专.与丛上丌丆七丒丅东 = false;
        }
        
        }
        
        }
        
        }
        
        label_34:
        val_20 = 1;
        this.丗丏丅丕丆世丁专丟 = val_20;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_20;
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
