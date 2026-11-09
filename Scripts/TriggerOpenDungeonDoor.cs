using UnityEngine;
internal class TriggerOpenDungeonDoor : SubscribeOnTriggerObject
{
    // Fields
    private System.Collections.Generic.List<OpenCloseDoor> _listDoors;
    private System.Collections.Generic.List<UnityEngine.AudioSource> _source;
    private System.Collections.Generic.List<UnityEngine.GameObject> _listEffects;
    
    // Methods
    protected override void 一上上专丂丅丄丗丄(int 丅上丁不丛丁上七丈)
    {
        this.丒丛且七丐丂丕丑丐();
    }
    internal void 丒丛且七丐丂丕丑丐()
    {
        var val_3;
        System.Collections.Generic.List<UnityEngine.GameObject> val_10;
        System.Action<UnityEngine.AudioSource> val_11;
        var val_12;
        var val_14;
        val_10 = this;
        List.Enumerator<T> val_1 = this._listDoors.GetEnumerator();
        val_11 = 1152921540062313680;
        label_4:
        if((1095776080 & 1) == 0)
        {
            goto label_2;
        }
        
        val_3.丐丏七丌丕丗业且上().StartOpenDoor();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false) || (this._source == null)) || (this._source.Count < 1))
        {
            goto label_13;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = TriggerOpenDungeonDoor.<>c.<>9__4_0;
        if(val_11 == null)
        {
            goto label_16;
        }
        
        label_31:
        this._source.ForEach(action:  val_11);
        label_13:
        if(this._listEffects == null)
        {
                return;
        }
        
        if(this._listEffects.Count < 1)
        {
                return;
        }
        
        val_10 = this._listEffects;
        val_14 = null;
        val_14 = null;
        if((TriggerOpenDungeonDoor.<>c.<>9__4_1) == null)
        {
            goto label_22;
        }
        
        label_27:
        val_10.ForEach(action:  TriggerOpenDungeonDoor.<>c.<>9__4_1);
        return;
        label_22:
        TriggerOpenDungeonDoor.<>c.<>9__4_1 = new System.Action<UnityEngine.GameObject>(object:  TriggerOpenDungeonDoor.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TriggerOpenDungeonDoor.<>c::丝三不下一丅丑丆三(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(val_10 != null)
        {
            goto label_27;
        }
        
        goto label_27;
        label_16:
        TriggerOpenDungeonDoor.<>c.<>9__4_0 = new System.Action<UnityEngine.AudioSource>(object:  TriggerOpenDungeonDoor.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TriggerOpenDungeonDoor.<>c::业一专丂丈丈丁丄丈(UnityEngine.AudioSource 三丟东丕丄丄下下丑));
        if(this._source != null)
        {
            goto label_31;
        }
        
        goto label_31;
    }
    internal void 丑世上万丑专万丛万()
    {
        List.Enumerator<T> val_1 = this._listDoors.GetEnumerator();
        label_4:
        if((1095929064 & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().StartCloseDoor();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public TriggerOpenDungeonDoor()
    {
        this._listDoors = new System.Collections.Generic.List<OpenCloseDoor>();
        this._source = new System.Collections.Generic.List<UnityEngine.AudioSource>();
        this._listEffects = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
