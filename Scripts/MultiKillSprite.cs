using UnityEngine;
public class MultiKillSprite : MonoBehaviour
{
    // Methods
    private void Start()
    {
        var val_7;
        if(GameConnect.丑丌丛丈丅丅与不业() != 4)
        {
                return;
        }
        
        val_7 = this.transform;
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        UnityEngine.Vector3 val_6 = this.transform.localPosition;
        val_7.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Update()
    {
    
    }
    public MultiKillSprite()
    {
    
    }

}
