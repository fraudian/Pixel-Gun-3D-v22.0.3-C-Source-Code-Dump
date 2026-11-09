using UnityEngine;
public class RotatorKillCam : MonoBehaviour
{
    // Fields
    internal static bool 丘丐三与东业丛丝丒;
    
    // Methods
    private void Start()
    {
        null = null;
        RotatorKillCam.丘丐三与东业丛丝丒 = false;
        万丌丅丗业丌上一丟();
    }
    private void OnEnable()
    {
        null = null;
        RotatorKillCam.丘丐三与东业丛丝丒 = false;
        万丌丅丗业丌上一丟();
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        null = null;
        RotatorKillCam.丘丐三与东业丛丝丒 = 丆且上丘世下丅且丞;
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        RPG_Camera val_2;
        float val_3;
        val_2 = RPG_Camera.instance;
        if(val_2 == 0)
        {
                return;
        }
        
        val_2 = RPG_Camera.instance;
        if(val_2 != null)
        {
                val_3 = mem[RPG_Camera.instance + 164];
            val_3 = RPG_Camera.instance.deltaMouseX;
        }
        else
        {
                val_2 = 164;
            val_3 = 0f;
        }
        
        丞且丅三三东不丄且.x = 丞且丅三三东不丄且.x + val_3;
        mem[164] = 丞且丅三三东不丄且.x;
    }
    private void 万丌丅丗业丌上一丟()
    {
        RPG_Camera val_2;
        var val_3;
        val_2 = RPG_Camera.instance;
        if(val_2 == 0)
        {
                return;
        }
        
        val_3 = null;
        if(RPG_Camera.instance == null)
        {
                val_3 = null;
        }
        
        RPG_Camera.instance.deltaMouseX = 0f;
        val_2 = RPG_Camera.instance;
        RPG_Camera.instance.mouseY = 15f;
    }
    public RotatorKillCam()
    {
    
    }
    private static RotatorKillCam()
    {
    
    }

}
