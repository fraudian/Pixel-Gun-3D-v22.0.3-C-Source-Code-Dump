using UnityEngine;
public class PlayerBotPathWayPoint : MonoBehaviour
{
    // Fields
    internal float radius;
    internal int weight;
    internal bool isDefence;
    internal System.Collections.Generic.List<PlayerBotPath> startedPaths;
    internal System.Collections.Generic.List<PlayerBotPathWayPoint> reachableWayPoints;
    private System.Collections.Generic.List<UnityEngine.Vector3[]> 丈丞丌七丑丈丕丟丛;
    internal UnityEngine.Transform 丛丄与丌丛万业丝丞;
    internal UnityEngine.Color 丏与丐且丏丘下东上;
    private UnityEngine.Color 与一丞七丞丛丌丆丏;
    private UnityEngine.Color 丅丄七上丁世丏七丗;
    
    // Methods
    public UnityEngine.Vector3 randomPoint(float 上七不丈下下丛丘与)
    {
        UnityEngine.Vector3 val_1 = this.丛丄与丌丛万业丝丞.position;
        float val_7 = this.radius * (UnityEngine.Mathf.PerlinNoise(x:  上七不丈下下丛丘与, y:  上七不丈下下丛丘与));
        float val_8 = (this.radius * (UnityEngine.Mathf.PerlinNoise(x:  上七不丈下下丛丘与, y:  上七不丈下下丛丘与))) * (UnityEngine.Mathf.Sign(f:  上七不丈下下丛丘与));
        val_7 = val_7 * (UnityEngine.Mathf.Sign(f:  上七不丈下下丛丘与));
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_10 = this.丛丄与丌丛万业丝丞.position;
        UnityEngine.Color val_11 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, end:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, color:  new UnityEngine.Color() {r = val_11.r, g = val_11.b, b = 5f, a = val_10.y}, duration:  0f);
        return new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
    }
    private void Awake()
    {
        this.丛丄与丌丛万业丝丞 = this.transform;
    }
    public PlayerBotPathWayPoint()
    {
        this.radius = 2f;
        this.weight = 1;
        this.startedPaths = new System.Collections.Generic.List<PlayerBotPath>();
        this.reachableWayPoints = new System.Collections.Generic.List<PlayerBotPathWayPoint>();
        this.丈丞丌七丑丈丕丟丛 = new System.Collections.Generic.List<UnityEngine.Vector3[]>();
        this.丏与丐且丏丘下东上 = 0;
        mem[1152921538648035276] = 0;
        mem[1152921538648035284] = 0;
        this.与一丞七丞丛丌丆丏 = 0;
        mem[1152921538648035292] = 0;
        mem[1152921538648035300] = 0;
        this.丅丄七上丁世丏七丗 = 0;
        mem[1152921538648035308] = 0;
        mem[1152921538648035316] = 0;
    }

}
