using UnityEngine;
public class ServerTime : MonoBehaviour
{
    // Methods
    private void OnGUI()
    {
        int val_1 = UnityEngine.Screen.width;
        var val_2 = (val_1 < 0) ? (val_1 + 1) : (val_1);
        val_2 = val_2 >> 1;
        val_2 = val_2 - 100;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        UnityEngine.GUILayout.Label(text:  System.String.Format(format:  "Time Offset: {0}", arg0:  丅丒丗丑丒丙丛不丆.一丛丘专七丄丗丝丕() - System.Environment.TickCount), options:  System.Array.Empty<System.String>());
        if((UnityEngine.GUILayout.Button(text:  "fetch", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                丅丒丗丑丒丙丛不丆.丒丄丒与下丌丏丒专();
        }
        
        UnityEngine.GUILayout.EndArea();
    }
    public ServerTime()
    {
    
    }

}
