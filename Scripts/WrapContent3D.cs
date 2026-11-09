using UnityEngine;
public class WrapContent3D : MonoBehaviour
{
    // Fields
    internal static byte[] 丏一丝丗丞万丛丒丒;
    public UnityEngine.Transform[] wrappedObjects;
    public float maxDistance;
    public float deltaX;
    public UnityEngine.Transform center;
    
    // Methods
    internal static void 丐丑业丗丒世丗万三()
    {
        var val_6;
        if(WrapContent3D.丏一丝丗丞万丛丒丒 != null)
        {
                return;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  System.IO.Path.Combine(path1:  "Graphics", path2:  "3dOptions"));
        val_6 = 0;
        byte[] val_4 = new byte[32];
        WrapContent3D.丏一丝丗丞万丛丒丒 = val_4;
        if( == 0)
        {
                return;
        }
        
        System.Array.Copy(sourceArray:  (UnityEngine.Object.__il2cppRuntimeField_typeHierarchy + (PGCompany.SkinManager.Scripts.GraphicsOptions.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 24, sourceIndex:  34, destinationArray:  val_4, destinationIndex:  0, length:  32);
    }
    private void Update()
    {
        var val_11;
        float val_12;
        val_11 = 0;
        goto label_1;
        label_18:
        UnityEngine.Vector3 val_1 = this.wrappedObjects[0].position;
        float val_12 = val_1.x;
        UnityEngine.Vector3 val_2 = this.center.position;
        val_2.x = val_12 - val_2.x;
        val_12 = val_2.x / 0.002604167f;
        val_12 = this.maxDistance;
        val_12 = this.maxDistance;
        val_12 = this.maxDistance;
        float val_13 = System.Math.Abs(val_12);
        val_12 = (this.maxDistance - val_13) / val_12;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, t:  0.7f - (UnityEngine.Mathf.Clamp01(value:  val_12)));
        this.wrappedObjects[0].localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        this.wrappedObjects[0].gameObject.SetActive(value:  (val_13 < 0) ? 1 : 0);
        val_11 = 1;
        label_1:
        if(val_11 < this.wrappedObjects.Length)
        {
            goto label_18;
        }
    
    }
    public WrapContent3D()
    {
    
    }

}
