using UnityEngine;
public class FullScreenOption : MonoBehaviour
{
    // Methods
    private void Update()
    {
        int val_6;
        var val_7;
        var val_8;
        if((UnityEngine.Input.GetKeyDown(key:  30)) == false)
        {
                return;
        }
        
        if(UnityEngine.Screen.fullScreen != false)
        {
                val_6 = 1280;
            val_7 = 720;
            val_8 = 0;
        }
        else
        {
                UnityEngine.Resolution val_3 = UnityEngine.Screen.currentResolution;
            UnityEngine.Resolution val_5 = UnityEngine.Screen.currentResolution;
            val_7 = ;
            val_8 = 1;
            val_6 = val_3.m_Width.GetHashCode();
        }
        
        UnityEngine.Screen.SetResolution(width:  val_6, height:  1513317392, fullscreen:  true);
    }
    public FullScreenOption()
    {
    
    }

}
