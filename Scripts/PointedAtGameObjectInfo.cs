using UnityEngine;
public class PointedAtGameObjectInfo : MonoBehaviour
{
    // Methods
    private void OnGUI()
    {
        UnityEngine.Object val_15;
        object val_16;
        val_15 = InputToEvent.goPointedAt;
        if(val_15 == 0)
        {
                return;
        }
        
        val_15 = 万上丈专丐专丞丛丛.丄丕业丅三丒丌七丈(丝三丁东丈丒世丅业:  InputToEvent.goPointedAt);
        if(val_15 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
        val_8.y = (float)UnityEngine.Screen.height - val_8.y;
        val_8.y = val_8.y + (-15f);
        float val_15 = 5f;
        val_15 = val_6.x + val_15;
        if(val_15.isMine != false)
        {
                val_16 = "mine";
        }
        else
        {
                val_16 = "owner: "("owner: ") + val_4.ownerId;
        }
        
        val_15 = System.String.Format(format:  "ViewID {0} {1}{2}", arg0:  val_15.viewID, arg1:  (val_15.isSceneView != true) ? "scene " : "", arg2:  val_16);
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_15);
    }
    public PointedAtGameObjectInfo()
    {
    
    }

}
