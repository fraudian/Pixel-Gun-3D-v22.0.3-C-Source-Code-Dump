using UnityEngine;
public class ShowStatusWhenConnecting : MonoBehaviour
{
    // Fields
    public UnityEngine.GUISkin Skin;
    
    // Methods
    private void OnGUI()
    {
        if(this.Skin != 0)
        {
                UnityEngine.GUI.skin = this.Skin;
        }
        
        float val_16 = (float)UnityEngine.Screen.width;
        val_16 = val_16 + (-400f);
        float val_4 = (float)UnityEngine.Screen.height + (-100f);
        val_16 = val_16 * 0.5f;
        val_4 = val_4 * 0.5f;
        UnityEngine.GUIStyle val_6 = UnityEngine.GUI.skin.box;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, style:  val_6);
        UnityEngine.GUILayout.Label(text:  "Connecting" + val_6.七丌丂丞丙丛丏丗丛(), style:  UnityEngine.GUI.skin.customStyles[0], options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Label(text:  "Status: "("Status: ") + 丅丒丗丑丒丙丛不丆.丒丏丆专丝业丙一丌(), options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.EndArea();
        if(丅丒丗丑丒丙丛不丆.一上下丆世丛丌丆丞() == false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private string 七丌丂丞丙丛丏丗丛()
    {
        string val_4 = "";
        float val_4 = 3f;
        val_4 = UnityEngine.Time.timeSinceLevelLoad * val_4;
        int val_5 = UnityEngine.Mathf.FloorToInt(f:  val_4);
        if(val_5 < 1)
        {
                return (string)val_4;
        }
        
        do
        {
            val_5 = val_5 - 1;
            val_4 = val_4 + " .";
        }
        while(val_5 != 0);
        
        return (string)val_4;
    }
    public ShowStatusWhenConnecting()
    {
    
    }

}
