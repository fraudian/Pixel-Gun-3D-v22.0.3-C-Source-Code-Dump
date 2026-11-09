using UnityEngine;
internal sealed class ImposterModeRoomTasks : PGBehaviour
{
    // Fields
    internal System.Collections.Generic.List<PlayerTaskImposterMode> roomTasks;
    
    // Methods
    internal void 丝丟丗丞丛丒丏丙世()
    {
        var val_2 = null;
        if((ImposterModeRoomTasks.<>c.<>9__1_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.roomTasks.ForEach(action:  ImposterModeRoomTasks.<>c.<>9__1_0);
        return;
        label_3:
        ImposterModeRoomTasks.<>c.<>9__1_0 = new System.Action<PlayerTaskImposterMode>(object:  ImposterModeRoomTasks.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ImposterModeRoomTasks.<>c::业丆下丛且丘丁七丑(PlayerTaskImposterMode 万不且且丛丆东丒业));
        if(this.roomTasks != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    internal void 丌七业丏丐丗丄且业(System.Random 丂丆且一丛丙丑七丒)
    {
        .丂丆且一丛丙丑七丒 = 丂丆且一丛丙丑七丒;
        this.roomTasks.ForEach(action:  new System.Action<PlayerTaskImposterMode>(object:  new ImposterModeRoomTasks.丛与丒丞丁丛上丄丆(), method:  System.Void ImposterModeRoomTasks.丛与丒丞丁丛上丄丆::丟丘丏丗丛上丗丌上(PlayerTaskImposterMode 万不且且丛丆东丒业)));
    }
    internal PlayerTaskImposterMode 丌丟丈丕丛丑业不三(System.Collections.Generic.List<PlayerTaskImposterMode.丌不丕丁丁东且丈丑> 三下一丈专丈丂东世)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        System.Collections.Generic.List<PlayerTaskImposterMode> val_1 = new System.Collections.Generic.List<PlayerTaskImposterMode>();
        val_13 = 0;
        goto label_1;
        label_12:
        val_14 = 0;
        val_15 = 1;
        goto label_2;
        label_7:
        PlayerTaskImposterMode val_2 = this.roomTasks.Item[0];
        val_15 = val_15 & ((val_2.taskType != 三下一丈专丈丂东世.Item[0]) ? 1 : 0);
        val_14 = 1;
        label_2:
        if(val_14 < 三下一丈专丈丂东世.Count)
        {
            goto label_7;
        }
        
        if((val_15 & 1) != 0)
        {
                val_1.Add(item:  this.roomTasks.Item[0]);
        }
        
        val_13 = 1;
        label_1:
        if(val_13 < this.roomTasks.Count)
        {
            goto label_12;
        }
        
        if(val_1.Count != 0)
        {
                PlayerTaskImposterMode val_12 = val_1.Item[UnityEngine.Random.Range(min:  0, max:  val_1.Count - 1)];
            return (PlayerTaskImposterMode)val_16;
        }
        
        val_16 = 0;
        return (PlayerTaskImposterMode)val_16;
    }
    public ImposterModeRoomTasks()
    {
    
    }

}
