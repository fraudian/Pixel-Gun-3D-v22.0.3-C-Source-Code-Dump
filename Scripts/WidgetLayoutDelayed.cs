using UnityEngine;
internal sealed class WidgetLayoutDelayed : PGBehaviour
{
    // Fields
    private WidgetLayout widgetLayout;
    private float stepDelay;
    private UnityEngine.Coroutine 丈专丛丞万世丕丞丄;
    
    // Methods
    public void Animate()
    {
        if(this.丈专丛丞万世丕丞丄 != null)
        {
                this.StopCoroutine(routine:  this.丈专丛丞万世丕丞丄);
        }
        
        this.丈专丛丞万世丕丞丄 = this.StartCoroutine(routine:  this.下丗不丞丄业与世下());
    }
    private void OnDisable()
    {
        if(this.丈专丛丞万世丕丞丄 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丈专丛丞万世丕丞丄);
    }
    private System.Collections.IEnumerator 下丗不丞丄业与世下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WidgetLayoutDelayed.专与丄丒世丝丙丟丂();
    }
    public WidgetLayoutDelayed()
    {
        this.stepDelay = 0.2f;
    }

}
