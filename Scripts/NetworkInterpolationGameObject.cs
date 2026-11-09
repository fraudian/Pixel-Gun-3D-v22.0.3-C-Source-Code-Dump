using UnityEngine;
internal sealed class NetworkInterpolationGameObject : MonoBehaviour
{
    // Fields
    private UnityEngine.Quaternion 丘丐丐不丐丁丛且丝;
    
    // Methods
    private void Awake()
    {
        var val_1 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        }
        
        this.enabled = false;
    }
    private void Update()
    {
    
    }
    public NetworkInterpolationGameObject()
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        this.丘丐丐不丐丁丛且丝 = val_1;
        mem[1152921530962052220] = val_1.y;
        mem[1152921530962052224] = val_1.z;
        mem[1152921530962052228] = val_1.w;
    }

}
