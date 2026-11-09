using UnityEngine;
public class PolygonModeController : GameModeController
{
    // Methods
    internal void 万不丛丐一丟丄一万()
    {
        goto typeof(PolygonModeController).__il2cppRuntimeField_258;
    }
    internal void 丛丕丆下丕三业丟三()
    {
        X19.丟丙不上丝丂丄丗三(丗丛丘万世丟丅不与:  true);
    }
    protected override void 丕丗东且一且且丘丂()
    {
        var val_9;
        UnityEngine.GameObject val_3 = 丟丆丗丌下且丅丌丈(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()).gameObject;
        val_3.丂丌丂丘丘上丘丌与(专丞上七七且丝七丗:  val_3);
        SkinName val_4 = val_3.GetComponent<SkinName>();
        val_9 = null;
        val_9 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = val_4.firstPersonControl.playerCamera.camera;
        var val_10 = 0;
        val_10 = val_10 + 1;
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.丑与世丙与丗丛且丆(丕丕世且下一与丝与:  0.01f).GetEnumerator());
    }
    internal void 丂丌丂丘丘上丘丌与(UnityEngine.GameObject 专丞上七七且丝七丗)
    {
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_12 = val_1.x;
        val_13 = val_1.y;
        val_14 = val_1.z;
        val_15 = 0f;
        if((PolygonController.一下一万丄丅丘且丑 != 0) && ((PolygonController.一下一万丄丅丘且丑 + 24) != 0))
        {
                UnityEngine.Transform val_3 = PolygonController.一下一万丄丅丘且丑.下专丟世丏丏世世专();
            UnityEngine.Vector3 val_4 = val_3.position;
            val_12 = val_4.x;
            val_13 = val_4.y;
            val_14 = val_4.z;
            UnityEngine.Quaternion val_5 = val_3.rotation;
            val_15 = val_5.y;
        }
        
        专丞上七七且丝七丗.transform.position = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_15, z:  0f);
        专丞上七七且丝七丗.transform.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
    }
    public PolygonModeController()
    {
    
    }

}
