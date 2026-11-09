using UnityEngine;
internal abstract class SubscribeOnTriggerObject : MonoBehaviour
{
    // Fields
    private TriggerObject _triggerObject;
    private PhotonView _photonView;
    
    // Properties
    internal PhotonView 万上世上丑丘丑且丄 { get; }
    
    // Methods
    internal PhotonView 丛丘丟业下丐专丕丑()
    {
        PhotonView val_3;
        if(this._photonView == 0)
        {
                this._photonView = this.GetComponent<PhotonView>();
            return val_3;
        }
        
        val_3 = this._photonView;
        return val_3;
    }
    private void Awake()
    {
        if(this._triggerObject == 0)
        {
                return;
        }
        
        this._triggerObject.专三丅且丌丏万丕丆(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  typeof(SubscribeOnTriggerObject).__il2cppRuntimeField_170));
    }
    private void OnDestroy()
    {
        if(this._triggerObject == 0)
        {
                return;
        }
        
        this._triggerObject.三丛丐丄丑丗丏丞上(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  typeof(SubscribeOnTriggerObject).__il2cppRuntimeField_170));
    }
    protected abstract void 一上上专丂丅丄丗丄(int 丅上丁不丛丁上七丈); // 0
    internal void 丟丏且丌丅丝丞丛丅(PhotonView 丄丈丑丐丆丞丘与丗)
    {
        this._photonView = 丄丈丑丐丆丞丘与丗;
    }
    protected SubscribeOnTriggerObject()
    {
    
    }

}
