using UnityEngine;
internal class ZoneSpawnDungeonMobSettings : MonoBehaviour
{
    // Fields
    public string nameZone;
    public 丙丟七丁世丌上丟丏 typeSpawn;
    public int maxSpawnFlask;
    public System.Collections.Generic.List<DungeonSpawnSettings> listPointSpawn;
    
    // Methods
    public ZoneSpawnDungeonMobSettings()
    {
        this.listPointSpawn = new System.Collections.Generic.List<DungeonSpawnSettings>();
    }

}
