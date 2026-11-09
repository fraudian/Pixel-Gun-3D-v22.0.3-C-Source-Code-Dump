using UnityEngine;
public class HighlightOwnedGameObj : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject PointerPrefab;
    public float Offset;
    private UnityEngine.Transform 丑丂丏业丂丅丘业丄;
    
    // Methods
    private void Update()
    {
        UnityEngine.Transform val_12;
        UnityEngine.Transform val_13;
        val_12 = this;
        if(this.photonView.isMine != false)
        {
                UnityEngine.Transform val_4 = this.gameObject.transform;
            val_13 = this.丑丂丏业丂丅丘业丄;
            if(val_13 == 0)
        {
                val_13 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.PointerPrefab).transform;
            val_13.parent = val_4;
            this.丑丂丏业丂丅丘业丄 = val_13;
        }
        
            UnityEngine.Vector3 val_8 = val_4.position;
            val_8.y = val_8.y + this.Offset;
            this.丑丂丏业丂丅丘业丄.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_12 = this.丑丂丏业丂丅丘业丄;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
            val_12.rotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            return;
        }
        
        val_13 = 1152921504848912384;
        if(this.丑丂丏业丂丅丘业丄 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.丑丂丏业丂丅丘业丄.gameObject);
        this.丑丂丏业丂丅丘业丄 = 0;
    }
    public HighlightOwnedGameObj()
    {
        this.Offset = 0.5f;
    }

}
