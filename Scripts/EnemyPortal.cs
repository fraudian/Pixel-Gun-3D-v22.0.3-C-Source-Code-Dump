using UnityEngine;
public class EnemyPortal : MonoBehaviour
{
    // Fields
    private System.Action 丙业丕世丁丙丟万丑;
    
    // Methods
    public void add_OnHided(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丙业丕世丁丙丟万丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙业丕世丁丙丟万丑 != 1152921536451138472);
    
    }
    public void remove_OnHided(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丙业丕世丁丙丟万丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙业丕世丁丙丟万丑 != 1152921536451275048);
    
    }
    public void OnAnimationOff()
    {
        this.丄丛丌丞丟与世丗丕(丏业丟一东丂东丘丛:  false, 丟丘丙丄丅万丏与丗:  this.丙业丕世丁丙丟万丑);
    }
    public void Show(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_5;
        float val_6;
        val_5 = 业丒丝丗与丐丛丟丏.z;
        val_6 = 业丒丝丗与丐丛丟丏.x;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_6, y = 业丒丝丗与丐丛丟丏.y, z = val_5}, direction:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}})) != false)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.blue;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_6, y = 业丒丝丗与丐丛丟丏.y, z = val_5}, end:  new UnityEngine.Vector3() {x = val_6, y = 业丒丝丗与丐丛丟丏.y, z = val_5}, color:  new UnityEngine.Color() {r = val_3.r, g = val_3.b, a = 业丒丝丗与丐丛丟丏.y});
            val_5 = val_6;
            val_6 = val_5;
            this.transform.position = new UnityEngine.Vector3() {x = val_5, y = 业丒丝丗与丐丛丟丏.y, z = val_6};
        }
        
        this.丄丛丌丞丟与世丗丕(丏业丟一东丂东丘丛:  true, 丟丘丙丄丅万丏与丗:  0);
    }
    private void 丄丛丌丞丟与世丗丕(bool 丏业丟一东丂东丘丛, System.Action 丟丘丙丄丅万丏与丗)
    {
        this.gameObject.SetActive(value:  丏业丟一东丂东丘丛);
        if(丟丘丙丄丅万丏与丗 == null)
        {
                return;
        }
        
        丟丘丙丄丅万丏与丗.Invoke();
    }
    public EnemyPortal()
    {
        var val_2 = null;
        if((EnemyPortal.<>c.<>9__6_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.丙业丕世丁丙丟万丑 = EnemyPortal.<>c.<>9__6_0;
        return;
        label_3:
        EnemyPortal.<>c.<>9__6_0 = new System.Action(object:  EnemyPortal.<>c.__il2cppRuntimeField_static_fields, method:  System.Void EnemyPortal.<>c::丅丌丑丝丈专丁丈丞());
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }

}
