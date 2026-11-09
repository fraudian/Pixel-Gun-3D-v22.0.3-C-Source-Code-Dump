using UnityEngine;
[Serializable]
internal class SpawnDungeonMobeSetting.PointSpawnDungeonSettings
{
    // Fields
    public 丙丟七丁世丌上丟丏 typeSpawnDungeonTask;
    public 丐七不丝丆丐丂丐下 typeComplaexity;
    public System.Collections.Generic.List<SpawnDungeonMobeSetting.AreaInfo> chaseListArea;
    public System.Collections.Generic.List<SpawnDungeonMobeSetting.AreaInfo> patrolListArea;
    public float radiusCaptured;
    public System.Collections.Generic.List<float> pointForPlayer;
    public float timeForGivePoints;
    public float maxCapturePoint;
    public UnityEngine.Vector3 centerPoint;
    public bool checkWeight;
    public string nameMob;
    
    // Methods
    public SpawnDungeonMobeSetting.PointSpawnDungeonSettings()
    {
        this.chaseListArea = new System.Collections.Generic.List<AreaInfo>();
        this.patrolListArea = new System.Collections.Generic.List<AreaInfo>();
    }

}
