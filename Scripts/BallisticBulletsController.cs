using UnityEngine;
internal class BallisticBulletsController : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject bulletPrefab;
    private System.Collections.Generic.List<BallisticBullet> 丟下丑且丟万丈丘上;
    private int 下丌上丟专丌丑与三;
    private static BallisticBulletsController 丄丘七三上丕世丞业;
    
    // Methods
    private void Awake()
    {
        BallisticBulletsController.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        BallisticBulletsController.丄丘七三上丕世丞业 = 0;
    }
    public static void CreateBullet(WeaponSounds 丌丝下丄业一丄不三, UnityEngine.Vector3 丈万丏丈上丑不丅上, UnityEngine.Vector3 丁丒东丟丙一丄下丝, UnityEngine.Vector3 东世与专丟丁一丒丛, bool 三丄不丛不丁丑丂丆, UnityEngine.RaycastHit 丂七丑世丏丐丅不丌)
    {
        var val_5;
        float val_6;
        val_5 = 1152921536295389200;
        val_6 = 丁丒东丟丙一丄下丝.z;
        if(BallisticBulletsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_6 = 东世与专丟丁一丒丛.y;
        BallisticBulletsController.丄丘七三上丕世丞业.丄丆专一万丞上丁丛(丌丝下丄业一丄不三:  丌丝下丄业一丄不三, 丈万丏丈上丑不丅上:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = 丈万丏丈上丑不丅上.y, z = 丈万丏丈上丑不丅上.z}, 丁丒东丟丙一丄下丝:  new UnityEngine.Vector3() {x = 丁丒东丟丙一丄下丝.x, y = 丁丒东丟丙一丄下丝.y, z = val_6}, 东世与专丟丁一丒丛:  new UnityEngine.Vector3() {x = 东世与专丟丁一丒丛.x, y = val_6, z = 丂七丑世丏丐丅不丌.m_Point.x}, 三丄不丛不丁丑丂丆:  三丄不丛不丁丑丂丆, 丂七丑世丏丐丅不丌:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 丂七丑世丏丐丅不丌.m_Point.x}, m_Normal = new UnityEngine.Vector3() {y = 丂七丑世丏丐丅不丌.m_Normal.y}, m_Distance = 丂七丑世丏丐丅不丌.m_Distance, m_UV = new UnityEngine.Vector2()});
    }
    private void 丄丆专一万丞上丁丛(WeaponSounds 丌丝下丄业一丄不三, UnityEngine.Vector3 丈万丏丈上丑不丅上, UnityEngine.Vector3 丁丒东丟丙一丄下丝, UnityEngine.Vector3 东世与专丟丁一丒丛, bool 三丄不丛不丁丑丂丆, UnityEngine.RaycastHit 丂七丑世丏丐丅不丌)
    {
        UnityEngine.Object val_16;
        int val_1 = this.下丌上丟专丌丑与三 + 1;
        int val_4 = (val_1 > (this.丟下丑且丟万丈丘上.Count - 1)) ? 0 : (val_1);
        if(val_4 < this.丟下丑且丟万丈丘上.Count)
        {
                val_16 = this.丟下丑且丟万丈丘上.Item[val_4];
        }
        else
        {
                val_16 = 0;
        }
        
        if((val_16 != 0) && (0 == 0))
        {
                if(1 == 0)
        {
            goto label_22;
        }
        
        }
        
        BallisticBullet val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bulletPrefab, parent:  this.transform).GetComponent<BallisticBullet>();
        val_11.gameObject.SetActive(value:  false);
        this.丟下丑且丟万丈丘上.Insert(index:  val_4, item:  val_11);
        if(val_11 != null)
        {
                label_22:
            val_11.StartBullet(丌丝下丄业一丄不三:  丌丝下丄业一丄不三, 丈万丏丈上丑不丅上:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = 丈万丏丈上丑不丅上.y, z = 丈万丏丈上丑不丅上.z}, 丁丒东丟丙一丄下丝:  new UnityEngine.Vector3() {x = 丁丒东丟丙一丄下丝.x, y = 丁丒东丟丙一丄下丝.y, z = 丁丒东丟丙一丄下丝.z}, 东世与专丟丁一丒丛:  new UnityEngine.Vector3() {x = 东世与专丟丁一丒丛.x, y = 东世与专丟丁一丒丛.y, z = 丂七丑世丏丐丅不丌.m_Point.x}, 三丄不丛不丁丑丂丆:  三丄不丛不丁丑丂丆, 丂七丑世丏丐丅不丌:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 丂七丑世丏丐丅不丌.m_Point.x}, m_Normal = new UnityEngine.Vector3() {y = 丂七丑世丏丐丅不丌.m_Normal.y}, m_Distance = 丂七丑世丏丐丅不丌.m_Distance, m_UV = new UnityEngine.Vector2()});
        }
        else
        {
                0.StartBullet(丌丝下丄业一丄不三:  丌丝下丄业一丄不三, 丈万丏丈上丑不丅上:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = 丈万丏丈上丑不丅上.y, z = 丈万丏丈上丑不丅上.z}, 丁丒东丟丙一丄下丝:  new UnityEngine.Vector3() {x = 丁丒东丟丙一丄下丝.x, y = 丁丒东丟丙一丄下丝.y, z = 丁丒东丟丙一丄下丝.z}, 东世与专丟丁一丒丛:  new UnityEngine.Vector3() {x = 东世与专丟丁一丒丛.x, y = 东世与专丟丁一丒丛.y, z = 丂七丑世丏丐丅不丌.m_Point.x}, 三丄不丛不丁丑丂丆:  三丄不丛不丁丑丂丆, 丂七丑世丏丐丅不丌:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 丂七丑世丏丐丅不丌.m_Point.x}, m_Normal = new UnityEngine.Vector3() {y = 丂七丑世丏丐丅不丌.m_Normal.y}, m_Distance = 丂七丑世丏丐丅不丌.m_Distance, m_UV = new UnityEngine.Vector2()});
        }
        
        if(val_11.丘丄丆不丛丗上三上 != true)
        {
                if(val_11.丆丟业东丈不三丟丗 == null)
        {
                return;
        }
        
        }
        
        this.下丌上丟专丌丑与三 = val_4;
    }
    public BallisticBulletsController()
    {
        this.丟下丑且丟万丈丘上 = new System.Collections.Generic.List<BallisticBullet>(capacity:  100);
        this.下丌上丟专丌丑与三 = 0;
    }

}
