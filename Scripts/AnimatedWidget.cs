using UnityEngine;
public class AnimatedWidget : MonoBehaviour
{
    // Fields
    public float width;
    public float height;
    private UIWidget 丆不下丄丄且丞一丈;
    
    // Methods
    private void OnEnable()
    {
        this.丆不下丄丄且丞一丈 = this.GetComponent<UIWidget>();
        this.LateUpdate();
    }
    private void LateUpdate()
    {
        if(this.丆不下丄丄且丞一丈 == 0)
        {
                return;
        }
        
        this.丆不下丄丄且丞一丈.width = UnityEngine.Mathf.RoundToInt(f:  this.width);
        this.丆不下丄丄且丞一丈.height = UnityEngine.Mathf.RoundToInt(f:  this.height);
    }
    public AnimatedWidget()
    {
        this.width = 1f;
        this.height = 1f;
    }

}
