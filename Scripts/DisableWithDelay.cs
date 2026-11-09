using UnityEngine;
internal class DisableWithDelay : MonoBehaviour
{
    // Fields
    private UnityEngine.Coroutine 且丈丕专丒丝丏且丑;
    
    // Methods
    internal void 下三与丙丒一丞丐丒(float 丕丕世且下一与丝与)
    {
        if(this.且丈丕专丒丝丏且丑 != null)
        {
                this.StopCoroutine(routine:  this.且丈丕专丒丝丏且丑);
            this.且丈丕专丒丝丏且丑 = 0;
        }
        
        this.且丈丕专丒丝丏且丑 = this.StartCoroutine(routine:  this.丄上丑七丏丑与丛丙(丕丕世且下一与丝与:  丕丕世且下一与丝与));
    }
    private System.Collections.IEnumerator 丄上丑七丏丑与丛丙(float 丕丕世且下一与丝与)
    {
        DisableWithDelay.世丏丒东且东丆丑丆 val_1 = new DisableWithDelay.世丏丒东且东丆丑丆();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    public DisableWithDelay()
    {
    
    }

}
