using UnityEngine;
public class WorldTextsForMapContainer : MonoBehaviour
{
    // Fields
    public static WorldTextsForMapContainer instance;
    public bool UpdatePositionsOnMapAtRuntime;
    public WorldTextForMap[] worldTexts;
    
    // Methods
    private void Awake()
    {
        this.UpdatePositionsOnMapAtRuntime = false;
        WorldTextsForMapContainer.instance = this;
        this.worldTexts = this.GetComponentsInChildren<WorldTextForMap>();
    }
    private void OnDestroy()
    {
        WorldTextsForMapContainer.instance = 0;
    }
    public WorldTextsForMapContainer()
    {
    
    }

}
