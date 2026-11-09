using UnityEngine;
internal class BonusCreationZone : MonoBehaviour
{
    // Fields
    public UnityEngine.BoxCollider boxCollider;
    internal UnityEngine.Transform 万东万丆专丌丕丐丗;
    
    // Methods
    private void Awake()
    {
        var val_2;
        this.万东万丆专丌丕丐丗 = this.transform;
        val_2 = null;
        val_2 = null;
        BonusController.上丒丒七丙专业丘丗.Add(item:  this);
    }
    private void OnDestroy()
    {
        null = null;
        bool val_1 = BonusController.上丒丒七丙专业丘丗.Remove(item:  this);
    }
    public BonusCreationZone()
    {
    
    }

}
