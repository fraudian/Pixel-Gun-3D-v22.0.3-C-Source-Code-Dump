using UnityEngine;
[Serializable]
public class NJGMapBase.MapLevel
{
    // Fields
    public string level;
    public System.Collections.Generic.List<NJG.NJGMapBase.MapZone> zones;
    public bool folded;
    public bool itemsFolded;
    public bool deleteRequest;
    
    // Methods
    public NJGMapBase.MapLevel()
    {
        this.level = "Level";
        this.zones = new System.Collections.Generic.List<MapZone>();
        this.folded = true;
        this.itemsFolded = true;
    }

}
