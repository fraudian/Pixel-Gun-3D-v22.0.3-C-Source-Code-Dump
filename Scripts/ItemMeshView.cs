using UnityEngine;
internal sealed class ItemMeshView : PGBehaviour
{
    // Fields
    private UnityEngine.MeshRenderer meshRenderer;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnShow;
    private bool scaleInBounds;
    private UnityEngine.Transform boundTop;
    private UnityEngine.Transform boundBottom;
    private float minDistance;
    private PGCompany.丗丟丄丈东丝丕丄世 不丏丞丆专不丌万丑;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        this.丈且东丑丂且万丒丅(丞丘丞丏业且丛丏丘:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  丈丄不七三万丄丁不));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
    {
        this.不丏丞丆专不丌万丑 = 丞丘丞丏业且丛丏丘;
        if(丞丘丞丏业且丛丏丘.不业丙丒丂丞下丆丙() == 65)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShow, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            this.meshRenderer.material.mainTexture = this.不丏丞丆专不丌万丑;
            return;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShow, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void LateUpdate()
    {
        var val_28;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        val_28 = this;
        if(this.scaleInBounds == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_3 = this.boundTop.position;
        if(val_2.y > val_3.y)
        {
            goto label_4;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        UnityEngine.Vector3 val_6 = this.boundBottom.position;
        if(val_5.y >= 0)
        {
            goto label_7;
        }
        
        label_4:
        val_28 = this.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        val_32 = val_8.x;
        val_33 = val_8.y;
        val_34 = val_8.z;
        if(val_28 != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_7:
        UnityEngine.Vector3 val_9 = this.boundTop.position;
        UnityEngine.Vector3 val_11 = this.transform.position;
        UnityEngine.Vector3 val_13 = this.transform.position;
        UnityEngine.Vector3 val_15 = this.boundBottom.position;
        UnityEngine.Vector3 val_17 = this.transform.position;
        UnityEngine.Vector3 val_19 = this.transform.position;
        val_35 = val_15.z;
        val_36 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_37 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_15.y, z = val_35}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        float val_21 = UnityEngine.Mathf.Min(a:  val_36, b:  val_37);
        if(val_21 > this.minDistance)
        {
                UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
        }
        else
        {
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.one;
            val_37 = val_24.y;
            val_36 = val_24.x;
            val_35 = val_24.z;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_35}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, t:  val_21 / this.minDistance);
        }
        
        val_32 = val_27.x;
        val_33 = val_27.y;
        val_34 = val_27.z;
        label_11:
        this.transform.localScale = new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34};
    }
    public ItemMeshView()
    {
        this.minDistance = 0.001f;
    }

}
