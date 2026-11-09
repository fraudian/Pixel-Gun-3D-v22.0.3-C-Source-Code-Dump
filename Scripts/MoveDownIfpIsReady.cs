using UnityEngine;
public class MoveDownIfpIsReady : MonoBehaviour
{
    // Fields
    public UISprite upReadySprite;
    public UnityEngine.Transform myTransform;
    private float 丄丅且丄丙下丑世丄;
    
    // Methods
    private void Update()
    {
        if(this.upReadySprite == 0)
        {
                return;
        }
        
        if(this.upReadySprite.gameObject == 0)
        {
                return;
        }
        
        float val_4 = UnityEngine.Time.realtimeSinceStartup;
        val_4 = val_4 - this.丄丅且丄丙下丑世丄;
        if(val_4 < 0.5f)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.myTransform.localPosition;
        var val_7 = (this.upReadySprite.enabled != true) ? 26f : 64f;
        UnityEngine.Vector3 val_8 = this.myTransform.localPosition;
        this.myTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.丄丅且丄丙下丑世丄 = UnityEngine.Time.realtimeSinceStartup;
    }
    public MoveDownIfpIsReady()
    {
    
    }

}
