using UnityEngine;
public class CleanUpAndDoAction : MonoBehaviour
{
    // Fields
    public UnityEngine.Texture riliFon;
    public UnityEngine.Texture blackPixel;
    internal static System.Action 七丐丅专且专七三丆;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new CleanUpAndDoAction.丌三三一下丘丑下七();
    }
    private void OnGUI()
    {
        int val_1 = UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  this.blackPixel, scaleMode:  0);
        UnityEngine.Rect val_3 = AppsMenu.七丄丞万业丒世下上();
        UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_Height}, image:  this.riliFon, scaleMode:  0);
    }
    public CleanUpAndDoAction()
    {
    
    }

}
