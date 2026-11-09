using UnityEngine;
internal class EnemyCreationZone : MonoBehaviour
{
    // Fields
    internal UnityEngine.Transform 万东万丆专丌丕丐丗;
    public UnityEngine.BoxCollider boxCollider;
    
    // Methods
    private void Awake()
    {
        var val_2;
        this.万东万丆专丌丕丐丗 = this.transform;
        val_2 = null;
        val_2 = null;
        丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Add(item:  this);
    }
    private void OnDestroy()
    {
        null = null;
        bool val_1 = 丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Remove(item:  this);
    }
    public EnemyCreationZone()
    {
    
    }

}
