using UnityEngine;
public class NucBomb : MonoBehaviour
{
    // Fields
    public float BeforeActivate;
    public float BeforeDestroy;
    private UnityEngine.AudioSource 与业丒业下丌丞丅丄;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NucBomb.丈丌丗丗上丕丘丁丐();
    }
    private void FixedUpdate()
    {
        UnityEngine.AudioSource val_5;
        if(this.与业丒业下丌丞丅丄 == 0)
        {
                val_5 = this.GetComponent<UnityEngine.AudioSource>();
            this.与业丒业下丌丞丅丄 = val_5;
        }
        else
        {
                val_5 = this.与业丒业下丌丞丅丄;
        }
        
        val_5.mute = (~与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗()) & 1;
    }
    public NucBomb()
    {
        this.BeforeActivate = 12f;
        this.BeforeDestroy = 90f;
    }

}
