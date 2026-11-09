using UnityEngine;
[Serializable]
internal class SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings
{
    // Fields
    public string nameZone;
    public UnityEngine.Vector3 centerPoint;
    public 丙丟七丁世丌上丟丏 typeSpawn;
    public int maxSpawnFlask;
    public System.Collections.Generic.List<SpawnDungeonMobeSetting.PointSpawnDungeonSettings> listPointSpawnDungeonMob;
    
    // Methods
    public SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings()
    {
        this.maxSpawnFlask = 10;
        this.listPointSpawnDungeonMob = new System.Collections.Generic.List<PointSpawnDungeonSettings>();
    }

}
