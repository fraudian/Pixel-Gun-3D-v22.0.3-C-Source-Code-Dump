using UnityEngine;
private sealed class ShopNGUIController.丄丘业丘业丞不丈丑
{
    // Fields
    public ShopCategoryButton 不丛丌丂丘丆丘丒下;
    
    // Methods
    public ShopNGUIController.丄丘业丘业丞不丈丑()
    {
    
    }
    internal void 丆丌三丐三下业丌丅(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 东丘一一丐丆下丁丆, int 丌丂丆丄丅丞上丝且, int 且与丘与丐万丒七丒)
    {
        float val_12;
        var val_13;
        float val_14;
        var val_15;
        UnityEngine.Texture2D val_16;
        var val_17;
        丏丗上丙上世东东且.transform.parent = this.不丛丌丂丘丆丘丒下.modelPoint;
        UnityEngine.Transform val_2 = 丏丗上丙上世东东且.transform;
        UnityEngine.Vector3 val_3 = this.不丛丌丂丘丆丘丒下.modelPoint.localPosition;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 上下七丗丞丁不万丏.x, y = 上下七丗丞丁不万丏.y, z = 上下七丗丞丁不万丏.z}, d:  0.5f);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        if(val_2 != null)
        {
                val_12 = val_5.y;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_12, z = val_5.z};
            UnityEngine.Vector3 val_6 = val_2.localPosition;
            val_13 = val_6.x;
        }
        else
        {
                val_12 = val_5.y;
            0.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_12, z = val_5.z};
            UnityEngine.Vector3 val_7 = 0.localPosition;
            val_13 = val_7.x;
        }
        
        UnityEngine.Vector3 val_8 = val_2.localPosition;
        if(val_2 != null)
        {
                val_14 = 0f;
            val_2.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_14};
        }
        else
        {
                val_14 = 0f;
            0.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_14};
        }
        
        val_2.Rotate(eulers:  new UnityEngine.Vector3() {x = 丁丂专丑丙丞七专与.x, y = 丁丂专丑丙丞七专与.y, z = 丁丂专丑丙丞七专与.z}, relativeTo:  0);
        float val_12 = 东丘一一丐丆下丁丆;
        val_12 = val_12 * 0.5f;
        val_2.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_15 = null;
        val_15 = null;
        val_16 = SkinsController.丌七丞东丟丌世且不;
        if(val_16 != 0)
        {
                val_17 = null;
            val_17 = null;
            val_16 = SkinsController.丌七丞东丟丌世且不;
            Player_move_c.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  丏丗上丙上世东东且, 丐丅丁丂丐下丘世丄:  val_16, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
        }
        
        val_2.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_2.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        val_2.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }

}
