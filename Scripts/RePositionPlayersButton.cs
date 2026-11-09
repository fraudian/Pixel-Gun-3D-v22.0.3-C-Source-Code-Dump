using UnityEngine;
public class RePositionPlayersButton : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 positionInCommand;
    
    // Methods
    private void Start()
    {
        if(GameConnect.丑丌丛丈丅丅与不业() != 2)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 4)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
                return;
        }
        
        }
        
        }
        
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = val_4.localPosition;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = this.positionInCommand, y = V11.16B, z = V10.16B});
        val_4.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    public RePositionPlayersButton()
    {
    
    }

}
