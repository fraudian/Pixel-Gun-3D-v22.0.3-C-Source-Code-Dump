using UnityEngine;
internal sealed class FrameStopwatchScript : MonoBehaviour
{
    // Fields
    private readonly System.Diagnostics.Stopwatch 丏下丞丑丗业且丟且;
    
    // Methods
    public float GetSecondsSinceFrameStarted()
    {
        float val_2 = 1000f;
        val_2 = (float)this.丏下丞丑丗业且丟且.ElapsedMilliseconds / val_2;
        return (float)val_2;
    }
    internal void Start()
    {
        this.丏下丞丑丗业且丟且.Start();
    }
    internal void Update()
    {
        this.丏下丞丑丗业且丟且.Reset();
        this.丏下丞丑丗业且丟且.Start();
    }
    public FrameStopwatchScript()
    {
        this.丏下丞丑丗业且丟且 = new System.Diagnostics.Stopwatch();
    }

}
