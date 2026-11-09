using UnityEngine;
private sealed class GameEventOpenChestBase.丑上丘业丛丗丏丛丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventOpenChestBase 丝且与丝丒丟万丁专;
    private Rilisoft.DroppedItemData 丘丗且丁一丂丛丂丌;
    private Rilisoft.GameEventItemContainer 与丞丘丑丛且业七丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventOpenChestBase.丑上丘业丛丗丏丛丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.DroppedItemData val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
        if((this.丝且与丝丒丟万丁专.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
        {
            goto label_7;
        }
        
        Rilisoft.GameEventType val_2 = this.丝且与丝丒丟万丁专.<丅丝丌丝丁丏丙东丞>k__BackingField.不业丙丒丂丞下丆丙();
        if(val_8 != null)
        {
            goto label_26;
        }
        
        label_27:
        label_26:
        System.Collections.Generic.List<Rilisoft.DroppedItemData> val_3 = val_8.业业丌不丄丏丈上一(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = false});
        if(val_3 == null)
        {
            goto label_9;
        }
        
        val_8 = System.Linq.Enumerable.Last<Rilisoft.DroppedItemData>(source:  val_3);
        this.丘丗且丁一丂丛丂丌 = val_8;
        Rilisoft.GameEventItemContainer val_5 = val_8.一一一不万专东下业();
        this.与丞丘丑丛且业七丘 = val_5;
        if(val_5 == null)
        {
            goto label_11;
        }
        
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_14:
        val_8 = this.丝且与丝丒丟万丁专._spinView;
        if((val_8 & 1) != 0)
        {
                this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_9 = 1;
            return (bool)val_9;
        }
        
        this.丝且与丝丒丟万丁专.世丟丈丐丘丟丈丝丙 = 0;
        this.丝且与丝丒丟万丁专.丐丆丟东丈丞业东丛.SetItem(下丅丙一丂丗丅丝七:  this.丘丗且丁一丂丛丂丌.丘丗下业东世万丂专());
        System.Action val_7 = null;
        val_8 = val_7;
        val_7 = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.GameEventOpenChestBase::世丟丞丆与丅丞东丙());
        this.丝且与丝丒丟万丁专.丐丆丟东丈丞业东丛.ShowAsReward(丌不丞丁七丂万上丏:  val_7);
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_7:
        if(val_8 != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_11:
        UnityEngine.Debug.LogError(message:  "SavedDroppedItem container is null");
        val_9 = 0;
        label_9:
        this.丝且与丝丒丟万丁专.世丟丈丐丘丟丈丝丙 = 0;
        return (bool)val_9;
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
