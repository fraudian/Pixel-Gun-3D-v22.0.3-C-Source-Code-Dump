using UnityEngine;
public class Lightning : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject child;
    public float lightningMaxTime;
    public float lightningMinTime;
    public UnityEngine.GameObject sound;
    
    // Methods
    private void Start()
    {
        if(this.child == 0)
        {
                return;
        }
        
        if(this.sound != 0)
        {
                this.sound.SetActive(value:  false);
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.与丝不与丟丅丁丙丅());
    }
    private System.Collections.IEnumerator 与丝不与丟丅丁丙丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new Lightning.万丑世丐丂丛丘不上();
    }
    public Lightning()
    {
        this.lightningMaxTime = 90f;
        this.lightningMinTime = 30f;
    }

}
