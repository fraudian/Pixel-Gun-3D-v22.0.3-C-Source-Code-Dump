using UnityEngine;
public class ScenMapBounds : ScriptableObject
{
    // Fields
    public UnityEngine.Bounds bounds;
    public float miniMapZoom;
    public float worldMapZoom;
    public float miniMapTextMultiplier;
    
    // Methods
    public ScenMapBounds()
    {
        this.miniMapZoom = 1f;
        this.worldMapZoom = 1f;
        this.miniMapTextMultiplier = 1f;
    }

}
