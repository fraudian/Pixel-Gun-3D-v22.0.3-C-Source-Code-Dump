using UnityEngine;
public class ManualPhotonViewAllocator : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    public UnityEngine.GameObject Prefab;
    
    // Methods
    public void AllocateManualPhotonView()
    {
        if((万上丈专丐专丞丛丛.丄丕业丅三丒丌七丈(丝三丁东丈丒世丅业:  this.gameObject)) == 0)
        {
                UnityEngine.Debug.LogError(message:  "Can\'t do manual instantiation without PhotonView component.");
            return;
        }
        
        int val_4 = 丅丒丗丑丒丙丛不丆.丛一业丗丒丒丘丝业();
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    internal void InstantiateRpc(int 世上丕丐丈世上不丏)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = InputToEvent.inputHitPos, y = InputToEvent.inputHitPos.__il2cppRuntimeField_4, z = InputToEvent.inputHitPos.__il2cppRuntimeField_8}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.Prefab, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        万上丈专丐专丞丛丛.丄丕业丅三丒丌七丈(丝三丁东丈丒世丅业:  val_3).viewID = 世上丕丐丈世上不丏;
        OnClickDestroy val_5 = val_3.GetComponent<OnClickDestroy>();
        val_5.DestroyByRpc = true;
    }
    public ManualPhotonViewAllocator()
    {
    
    }

}
