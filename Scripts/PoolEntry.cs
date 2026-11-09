using UnityEngine;
[Serializable]
internal class PoolManager.PoolEntry
{
    // Fields
    public string poolName;
    public UnityEngine.GameObject weakPrefab;
    public UnityEngine.GameObject strongPrefab;
    public int count;
    public bool reusable;
    
    // Methods
    public PoolManager.PoolEntry()
    {
    
    }

}
