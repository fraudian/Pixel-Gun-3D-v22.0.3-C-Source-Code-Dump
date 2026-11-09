using UnityEngine;
public class RealTime : MonoBehaviour
{
    // Properties
    public static float 丂三丟丂丈丐丆丗丟 { get; }
    public static float 丑丗丘与丈不七东丛 { get; }
    
    // Methods
    public static float get_time()
    {
        return UnityEngine.Time.unscaledTime;
    }
    public static float get_deltaTime()
    {
        return UnityEngine.Time.unscaledDeltaTime;
    }
    public RealTime()
    {
    
    }

}
