using UnityEngine;
public class testMem : MonoBehaviour
{
    // Methods
    private void Start()
    {
        if(meminfo.getMemInfo() != false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Could not get Memory Info");
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
        {
                return;
        }
        
        PGCompany.七丞丝丏业丞丂丆上.一丐丛专下丞七丌万();
    }
    private void OnGUI()
    {
        var val_24;
        int val_2 = UnityEngine.Screen.height - 50;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Get MemInfo")) != false)
        {
                bool val_4 = meminfo.getMemInfo();
        }
        
        int val_6 = UnityEngine.Screen.height - 50;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "native Gc Collect")) != false)
        {
                meminfo.gc_Collect();
        }
        
        val_24 = null;
        val_24 = null;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "memtotal: "("memtotal: ") + ToString() + " kb");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "memfree: "("memfree: ") + ToString() + " kb");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "active: "("active: ") + ToString() + " kb");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "inactive: "("inactive: ") + ToString() + " kb");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "cached: "("cached: ") + ToString() + " kb");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "swapcached: "("swapcached: ") + ToString() + " kb");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "swaptotal: "("swaptotal: ") + ToString() + " kb");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "swapfree: "("swapfree: ") + ToString() + " kb");
    }
    public testMem()
    {
    
    }

}
