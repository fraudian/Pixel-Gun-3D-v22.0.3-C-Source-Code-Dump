using UnityEngine;
public static class 东丄丟丏丅与丏丟七
{
    // Methods
    public static void 丝与丒丞丒丛丑世丟(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丏业丟一东丂东丘丛)
    {
        丏业丟一东丂东丘丛 = 丏业丟一东丂东丘丛;
        丝三丁东丈丒世丅业.SetActive(value:  丏业丟一东丂东丘丛);
    }
    private static void 一与丙业丐三丙丟丆(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        var val_8;
        丙丒七丄上与丏丙丙.gameObject.SetActive(value:  true);
        val_8 = 0;
        label_7:
        if(val_8 >= 丙丒七丄上与丏丙丙.GetChildCount())
        {
            goto label_4;
        }
        
        val_8 = val_8 + 1;
        if((丙丒七丄上与丏丙丙.GetChild(index:  0).gameObject.activeSelf) == false)
        {
            goto label_7;
        }
        
        return;
        label_4:
        int val_6 = 丙丒七丄上与丏丙丙.GetChildCount();
        if(val_6 < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.Transform val_7 = 丙丒七丄上与丏丙丙.GetChild(index:  0);
            val_8 = 0 + 1;
        }
        while(val_6 != val_8);
    
    }
    private static void Deactivate(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        丙丒七丄上与丏丙丙.gameObject.SetActive(value:  false);
    }
    public static void 不上丕不丞业一丗丂(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丏业丟一东丂东丘丛)
    {
        UnityEngine.Transform val_1 = 丝三丁东丈丒世丅业.transform;
        if(丏业丟一东丂东丘丛 != false)
        {
                东丄丟丏丅与丏丟七.一与丙业丐三丙丟丆(丙丒七丄上与丏丙丙:  val_1);
            return;
        }
        
        东丄丟丏丅与丏丟七.Deactivate(丙丒七丄上与丏丙丙:  val_1);
    }
    public static UnityEngine.GameObject 丗上世丑丘业丆七一(UnityEngine.GameObject 丈东丘丏与丌东东下)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
        if(丈东丘丏与丌东东下 == 0)
        {
                return val_1;
        }
        
        UnityEngine.Transform val_3 = val_1.transform;
        val_3.parent = 丈东丘丏与丌东东下.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_3.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
        val_3.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_3.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        val_1.layer = 丈东丘丏与丌东东下.layer;
        return val_1;
    }
    public static UnityEngine.GameObject 丗上世丑丘业丆七一(UnityEngine.GameObject 丈东丘丏与丌东东下, UnityEngine.GameObject 丑且不丕与专丄业丙)
    {
        UnityEngine.Object val_10;
        var val_11;
        val_10 = 丈东丘丏与丌东东下;
        val_11 = 1152921504848912384;
        UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        if(val_1 == 0)
        {
                return val_1;
        }
        
        if(val_10 == 0)
        {
                return val_1;
        }
        
        val_11 = val_1.transform;
        val_11.parent = val_10.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_11.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        val_11.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        val_11.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        val_10 = val_10.layer;
        val_1.layer = val_10;
        return val_1;
    }
    public static void Destroy(UnityEngine.Object 万且万且丑丗且丌丆)
    {
        if(万且万且丑丗且丌丆 == 0)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                UnityEngine.Object.Destroy(obj:  万且万且丑丗且丌丆);
            return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  万且万且丑丗且丌丆);
    }
    public static void 丟丘下万世世丐丆丅(UnityEngine.Object 万且万且丑丗且丌丆)
    {
        if(万且万且丑丗且丌丆 == 0)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  万且万且丑丗且丌丆);
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  万且万且丑丗且丌丆);
    }

}
