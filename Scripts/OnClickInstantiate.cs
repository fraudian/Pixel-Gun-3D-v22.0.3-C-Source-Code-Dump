using UnityEngine;
public class OnClickInstantiate : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Prefab;
    public int InstantiateType;
    private string[] 丕业丅丗丝下丙业丑;
    public bool showGui;
    
    // Methods
    private void OnClick()
    {
        string val_10;
        float val_11;
        float val_12;
        float val_13;
        val_10 = this;
        if(丅丒丗丑丒丙丛不丆.一上下丆世丛丌丆丞() == false)
        {
                return;
        }
        
        if(this.InstantiateType != 1)
        {
                if(this.InstantiateType != 0)
        {
                return;
        }
        
            val_10 = this.Prefab.name;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = InputToEvent.inputHitPos, y = InputToEvent.inputHitPos.__il2cppRuntimeField_4, z = InputToEvent.inputHitPos.__il2cppRuntimeField_8}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_11 = val_3.x;
            val_12 = val_3.z;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            val_13 = val_4.y;
            UnityEngine.GameObject val_5 = 丅丒丗丑丒丙丛不丆.业丕丝丝万丕丛下三(丟丈一下东业一丝丆:  val_10, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_11, y = val_3.y, z = val_12}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_4.x, y = val_13, z = val_4.z, w = val_4.w}, 不丝丄丒丌丐一一与:  0);
            return;
        }
        
        val_10 = this.Prefab.name;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = InputToEvent.inputHitPos, y = InputToEvent.inputHitPos.__il2cppRuntimeField_4, z = InputToEvent.inputHitPos.__il2cppRuntimeField_8}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_11 = val_7.x;
        val_12 = val_7.z;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        val_13 = val_8.y;
        UnityEngine.GameObject val_9 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  val_10, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_11, y = val_7.y, z = val_12}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_8.x, y = val_13, z = val_8.z, w = val_8.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  0);
    }
    private void OnGUI()
    {
        if(this.showGui == false)
        {
                return;
        }
        
        int val_2 = UnityEngine.Screen.width - 180;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        this.InstantiateType = UnityEngine.GUILayout.Toolbar(selected:  this.InstantiateType, texts:  this.丕业丅丗丝下丙业丑, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.EndArea();
    }
    public OnClickInstantiate()
    {
        string[] val_1 = new string[2];
        val_1[0] = "Mine";
        val_1[1] = "Scene";
        this.丕业丅丗丝下丙业丑 = val_1;
    }

}
