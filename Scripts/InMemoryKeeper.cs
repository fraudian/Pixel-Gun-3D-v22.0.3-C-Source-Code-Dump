using UnityEngine;
public class InMemoryKeeper : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.GameObject> objectsToKeepInMemory;
    
    // Methods
    private void Start()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        this.objectsToKeepInMemory.Add(item:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Rocket"));
        this.objectsToKeepInMemory.AddRange(collection:  UnityEngine.Resources.LoadAll<UnityEngine.GameObject>(path:  "Rays/"));
        this.objectsToKeepInMemory.AddRange(collection:  UnityEngine.Resources.LoadAll<UnityEngine.GameObject>(path:  "Explosions/"));
    }
    public InMemoryKeeper()
    {
        this.objectsToKeepInMemory = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
