using UnityEngine;
public class PlayerBotPath : MonoBehaviour
{
    // Fields
    internal System.Collections.Generic.List<PlayerBotPathPoint> points;
    internal PlayerBotPathWayPoint startWayPoint;
    internal PlayerBotPathWayPoint finishWayPoint;
    
    // Methods
    public PlayerBotPath()
    {
        this.points = new System.Collections.Generic.List<PlayerBotPathPoint>();
    }

}
