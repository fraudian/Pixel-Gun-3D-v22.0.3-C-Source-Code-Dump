using UnityEngine;
[Serializable]
public class ScopeViewGameEventSettings
{
    // Fields
    public ScopeViewGameEventGuiItem eventGuiItem;
    private string eventName;
    public 业丗丕丟三丝丘三丗.丗丄丐丈丛丛三丗丏 eventType;
    public bool followTargetPosition;
    public float hideSmoothTime;
    public int maxGuiItemsCount;
    public float maxTargetDistance;
    public float showSmoothTime;
    public 业丗丕丟三丝丘三丗.下丂丈下丛丌丛丈丞 showType;
    
    // Methods
    public ScopeViewGameEventSettings()
    {
        this.maxGuiItemsCount = 5;
    }

}
