using UnityEngine;
public class SynchNetworkAnimation : MonoBehaviour
{
    // Fields
    private UnityEngine.Animation 丐丐七专三且世三七;
    private UnityEngine.AnimationState 上万丗丕丝丂丒下三;
    
    // Methods
    private void Start()
    {
        var val_13 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        UnityEngine.Animation val_1 = this.GetComponent<UnityEngine.Animation>();
        this.丐丐七专三且世三七 = val_1;
        UnityEngine.AnimationState val_4 = val_1.Item[val_1.clip.name];
        this.上万丗丕丝丂丒下三 = val_4;
        float val_7 = this.丐丐七专三且世三七.clip.length;
        float val_13 = (float)丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_13 = val_13 / this.丐丐七专三且世三七.clip.length;
        val_4.normalizedTime = val_13;
        bool val_10 = this.丐丐七专三且世三七.Play();
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.丕丕业七丙七丅丈丄());
    }
    private System.Collections.IEnumerator 丕丕业七丙七丅丈丄()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SynchNetworkAnimation.丕丈专丗丆丝一丛丄();
    }
    public SynchNetworkAnimation()
    {
    
    }

}
