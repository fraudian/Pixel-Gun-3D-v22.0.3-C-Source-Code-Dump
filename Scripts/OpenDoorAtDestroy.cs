using UnityEngine;
internal sealed class OpenDoorAtDestroy : PGBehaviour
{
    // Fields
    private DamageableObject _damageableObject;
    private TriggerOpenDungeonDoor _doors;
    private System.Collections.Generic.List<UnityEngine.Collider> _disableColliderOnOpen;
    private UnityEngine.AI.NavMeshObstacle[] _navMeshObstacles;
    
    // Methods
    private void Awake()
    {
        this.与一丝专丞丐上丝且();
    }
    private void 丒丛且七丐丂丕丑丐()
    {
        var val_3;
        this._doors.丒丛且七丐丂丕丑丐();
        List.Enumerator<T> val_1 = this._disableColliderOnOpen.GetEnumerator();
        label_5:
        if((1061709432 & 1) == 0)
        {
            goto label_3;
        }
        
        0.丐丏七丌丕丗业且上().enabled = false;
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_3 = 0;
        goto label_10;
        label_15:
        this._navMeshObstacles[0].enabled = false;
        val_3 = 1;
        label_10:
        if(val_3 < this._navMeshObstacles.Length)
        {
            goto label_15;
        }
    
    }
    private void 与一丝专丞丐上丝且()
    {
        if(this._damageableObject == 0)
        {
                return;
        }
        
        if(this._doors == 0)
        {
                return;
        }
        
        this._damageableObject.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void OpenDoorAtDestroy::丒丛且七丐丂丕丑丐()));
        if(this._damageableObject.三丏丟不丆丅丞不丛() > 0f)
        {
                if(this._damageableObject.IsDead() == false)
        {
            goto label_11;
        }
        
        }
        
        this.丒丛且七丐丂丕丑丐();
        return;
        label_11:
        this._doors.丑世上万丑专万丛万();
    }
    internal void 不丒世下丝万丙丟丆(DamageableObject 丅丞万丒不专丈专丕)
    {
        this._damageableObject = 丅丞万丒不专丈专丕;
        this.与一丝专丞丐上丝且();
    }
    internal void 不丂丄丂七丒丛丏丞(UnityEngine.Collider 丗丑东丛东下丈丆丕)
    {
        System.Collections.Generic.List<UnityEngine.Collider> val_2 = this._disableColliderOnOpen;
        if(val_2 == null)
        {
                System.Collections.Generic.List<UnityEngine.Collider> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<UnityEngine.Collider>();
            this._disableColliderOnOpen = val_2;
        }
        
        val_1.Add(item:  丗丑东丛东下丈丆丕);
    }
    public OpenDoorAtDestroy()
    {
        this._disableColliderOnOpen = new System.Collections.Generic.List<UnityEngine.Collider>();
    }

}
