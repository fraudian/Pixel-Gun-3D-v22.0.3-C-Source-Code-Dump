using UnityEngine;
[Serializable]
internal class SabotageImposterModeController.SabotageTask
{
    // Fields
    public SabotageImposterModeController.三与丕东丗东丏丞业 sabotageType;
    public int secondsForComplete;
    public string localizationKey;
    public string localizationText;
    public System.Collections.Generic.List<PlayerTaskImposterMode> tasks;
    public bool isDeadly;
    internal bool sabotageIsActive;
    internal int roomIndex;
    public System.Collections.Generic.List<OpenCloseDoorTriggerByPlayers> roomDoors;
    
    // Methods
    public SabotageImposterModeController.SabotageTask()
    {
    
    }

}
