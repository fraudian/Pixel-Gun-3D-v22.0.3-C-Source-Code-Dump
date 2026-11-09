using UnityEngine;

namespace ExitGames.Client.GUI
{
    public class GizmoTypeDrawer
    {
        // Methods
        public static void Draw(UnityEngine.Vector3 center, ExitGames.Client.GUI.GizmoType type, UnityEngine.Color color, float size)
        {
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
            if(type > 3)
            {
                    return;
            }
            
            var val_2 = 106021768 + (type) << 2;
            val_2 = val_2 + 106021768;
            goto (106021768 + (type) << 2 + 106021768);
        }
        public GizmoTypeDrawer()
        {
        
        }
    
    }

}
