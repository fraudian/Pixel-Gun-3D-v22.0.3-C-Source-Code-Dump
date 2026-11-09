using UnityEngine;
public class TramPath : MonoBehaviour
{
    // Fields
    public TramPath back;
    public TramPath next;
    public int myIndex;
    private UnityEngine.Color 三丝丛丆丁丘与丝东;
    private UnityEngine.Color 丟丝丐丗丄丗且上业;
    private UnityEngine.Color 万丝丐且不一丈丆一;
    public float distance;
    public float distancePoint;
    public bool isCheckpoint;
    public float checkpointAddTime;
    public bool wasReached;
    
    // Methods
    private void Awake()
    {
    
    }
    public TramPath()
    {
        this.三丝丛丆丁丘与丝东 = 0;
        mem[1152921540578300224] = 0;
        mem[1152921540578300232] = 0;
        this.丟丝丐丗丄丗且上业 = 0;
        mem[1152921540578300240] = 0;
        mem[1152921540578300248] = 0;
        this.万丝丐且不一丈丆一 = 0;
        mem[1152921540578300256] = 0;
        mem[1152921540578300264] = 0;
        this.checkpointAddTime = 60f;
    }

}
