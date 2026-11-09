using UnityEngine;
public class ColliderCollisions : MonoBehaviour
{
    // Fields
    public bool isCollision;
    public UnityEngine.Transform thisTransform;
    private int 不丒丟丐丄丘下与丁;
    
    // Methods
    private void Awake()
    {
        this.thisTransform = this.transform;
    }
    private void Update()
    {
        this.不丒丟丐丄丘下与丁 = 0;
        this.isCollision = (this.不丒丟丐丄丘下与丁 > 0) ? 1 : 0;
    }
    private void OnTriggerStay(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((System.String.op_Equality(a:  丘丛丏丘丝七世七丅.tag, b:  "Area")) == true)
        {
                return;
        }
        
        int val_3 = this.不丒丟丐丄丘下与丁;
        val_3 = val_3 + 1;
        this.不丒丟丐丄丘下与丁 = val_3;
    }
    public ColliderCollisions()
    {
    
    }

}
