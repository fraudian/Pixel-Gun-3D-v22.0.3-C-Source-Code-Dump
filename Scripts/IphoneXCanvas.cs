using UnityEngine;
public class IphoneXCanvas : MonoBehaviour
{
    // Methods
    private void Start()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        val_6 = this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_3 = val_6.rect;
        val_7 = null;
        val_7 = null;
        float val_6 = IphoneXCameraScaler.不丅七丘丈不丌丝丏;
        val_6 = val_3.m_XMin * val_6;
        float val_8 = 0f;
        val_3.m_XMin.x = val_8;
        float val_7 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
        val_7 = 1f - val_7;
        val_8 = val_8 * val_7;
        val_8 = val_8 + val_8;
        val_8 = val_8 * IphoneXCameraScaler.且下丒丘丙丒丈丏万;
        val_6.SetSizeWithCurrentAnchors(axis:  0, size:  val_8);
        val_6.SetSizeWithCurrentAnchors(axis:  1, size:  val_8);
        float val_4 = val_3.m_XMin.System.IConvertible.ToSingle(provider:  0);
        float val_9 = 0.5f;
        val_4 = val_4 * val_9;
        val_9 = val_4 + val_4;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4, y:  val_9);
        val_6.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    public IphoneXCanvas()
    {
    
    }

}
