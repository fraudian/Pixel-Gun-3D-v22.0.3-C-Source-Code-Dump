using UnityEngine;
private sealed class GameEventGui.丕且七七下丑且丌不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventGui 丝且与丝丒丟万丁专;
    private Rilisoft.DroppedItemData 丘丗且丁一丂丛丂丌;
    private System.Collections.Generic.List<Rilisoft.GameEventItemData> 丑世丕丝一丙丅丈上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventGui.丕且七七下丑且丌不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.DroppedItemData val_41;
        int val_42;
        var val_43;
        Rilisoft.AbstractGameEventView val_44;
        var val_45;
        System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItemData> val_47;
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
        if(this.丝且与丝丒丟万丁专.Context != null)
        {
                Rilisoft.GameEventType val_3 = this.丝且与丝丒丟万丁专.Context.不业丙丒丂丞下丆丙();
        }
        
        val_41 = 0;
        System.Collections.Generic.List<Rilisoft.DroppedItemData> val_5 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().业业丌不丄丏丈上一(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = false});
        if(val_5 == null)
        {
                return (bool)val_42;
        }
        
        val_41 = System.Linq.Enumerable.ToList<Rilisoft.DroppedItemData>(source:  val_5);
        if(val_41 == null)
        {
            goto label_12;
        }
        
        if(val_41.Count == 1)
        {
            goto label_13;
        }
        
        val_43 = val_41.Count;
        goto label_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_16;
        }
        
        goto label_16;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_12:
        val_44 = 1152921542706239648;
        if(0.Count != 1)
        {
            goto label_19;
        }
        
        label_13:
        val_41 = val_41.Item[0];
        this.丘丗且丁一丂丛丂丌 = val_41;
        Rilisoft.GameEventItemContainer val_11 = val_41.一一一不万专东下业();
        if(val_11 == null)
        {
            goto label_45;
        }
        
        int val_12 = val_11.Id;
        label_18:
        val_41 = this.丝且与丝丒丟万丁专._mainView;
        if((val_41 & 1) != 0)
        {
                val_42 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_42;
            return (bool)val_42;
        }
        
        if((this.丘丗且丁一丂丛丂丌.ContainerId != 99999) || (this.丘丗且丁一丂丛丂丌.ItemData.Type != 300))
        {
            goto label_31;
        }
        
        UnityEngine.Transform val_15 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "NguiWindows/PetRenameWindows"));
        val_15.parent = this.丝且与丝丒丟万丁专.transform;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
        val_15.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
        if(val_15 == null)
        {
            goto label_38;
        }
        
        val_15.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        goto label_39;
        label_31:
        this.丝且与丝丒丟万丁专.RewardView.SetItem(下丅丙一丂丗丅丝七:  this.丘丗且丁一丂丛丂丌.丘丗下业东世万丂专());
        val_41 = this.丝且与丝丒丟万丁专.RewardView;
        val_41.ShowAsReward(丌不丞丁七丂万上丏:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.GameEventGui::丟丛业丂丅丂丝丘万()));
        goto label_43;
        label_19:
        val_43 = 0.Count;
        label_14:
        Rilisoft.GameEventItemContainer val_24 = val_41.Item[val_43 - 1].一一一不万专东下业();
        if(val_24 == null)
        {
            goto label_45;
        }
        
        val_45 = null;
        val_45 = null;
        val_47 = GameEventGui.<>c.<>9__53_0;
        if(val_47 == null)
        {
                System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItemData> val_25 = null;
            val_47 = val_25;
            val_25 = new System.Func<Rilisoft.DroppedItemData, Rilisoft.GameEventItemData>(object:  GameEventGui.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.GameEventItemData GameEventGui.<>c::世丐且丈丝万丗丌上(Rilisoft.DroppedItemData 丐丆丂丒丁万丈丛丅));
            GameEventGui.<>c.<>9__53_0 = val_47;
        }
        
        System.Collections.Generic.List<TSource> val_27 = System.Linq.Enumerable.ToList<Rilisoft.GameEventItemData>(source:  System.Linq.Enumerable.Select<Rilisoft.DroppedItemData, Rilisoft.GameEventItemData>(source:  val_41, selector:  val_25));
        this.丑世丕丝一丙丅丈上 = val_27;
        System.Collections.Generic.List<TSource> val_31 = System.Linq.Enumerable.ToList<Rilisoft.GameEventItemData>(source:  System.Linq.Enumerable.Take<Rilisoft.GameEventItemData>(source:  val_27, count:  val_41.Count - 1));
        val_44 = this.丝且与丝丒丟万丁专._mainView;
        int val_32 = val_24.Id;
        label_16:
        val_41 = this.丝且与丝丒丟万丁专._mainView;
        if((val_41 & 1) != 0)
        {
                this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_42 = 1;
            return (bool)val_42;
        }
        
        this.丝且与丝丒丟万丁专._rewardsView.SetItems(丑七不与丛丆一丂丞:  this.丑世丕丝一丙丅丈上, 丒丄丒丌上丂下专丑:  true);
        val_41 = this.丝且与丝丒丟万丁专._rewardsView;
        val_41.ShowAsReward(丌不丞丁七丂万上丏:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.GameEventGui::丟丛业丂丅丂丝丘万()));
        val_42 = 0;
        this.丑世丕丝一丙丅丈上 = 0;
        return (bool)val_42;
        label_45:
        UnityEngine.Debug.LogError(message:  "SavedDroppedItem container is null");
        label_3:
        val_42 = 0;
        return (bool)val_42;
        label_38:
        val_15.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        label_39:
        val_44 = UnityEngine.LayerMask.NameToLayer(layerName:  "Banners");
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_15.gameObject, 不东丛三丂丌丑专丆:  val_44, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_41 = val_15.GetComponent<PetRenameWindov>();
        System.Action val_37 = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.GameEventGui::丟丛业丂丅丂丝丘万());
        if(val_41 != null)
        {
                val_41.丒与丏一丞丈丙丛上(丌不丞丁七丂万上丏:  val_37);
        }
        else
        {
                val_41.丒与丏一丞丈丙丛上(丌不丞丁七丂万上丏:  val_37);
        }
        
        val_36.丂下丕东丗专丆丐且 = "Key_3915";
        val_41.丈且东丑丂且万丒丅(上东丞世三世且丈丌:  new PGCompany.世丒丗丅丛丕不万丂(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  this.丘丗且丁一丂丛丂丌.ItemData.Id)));
        label_43:
        val_42 = 0;
        this.丘丗且丁一丂丛丂丌 = 0;
        return (bool)val_42;
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
