using UnityEngine;
public class Dragon : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject child;
    private UnityEngine.AudioSource 丁且万不丐万丈丘与;
    public UnityEngine.GameObject wingsFirst;
    public UnityEngine.GameObject wingsSecond;
    
    // Methods
    private void Start()
    {
        if(this.child == 0)
        {
                return;
        }
        
        if(this.wingsFirst == 0)
        {
                return;
        }
        
        if(this.wingsSecond == 0)
        {
                return;
        }
        
        this.丁且万不丐万丈丘与 = this.child.GetComponent<UnityEngine.AudioSource>();
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.万丗与丞下丑七丂七());
    }
    private System.Collections.IEnumerator 万丗与丞下丑七丂七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new Dragon.丄丛丘与专七丙丟世();
    }
    public Dragon()
    {
    
    }

}
