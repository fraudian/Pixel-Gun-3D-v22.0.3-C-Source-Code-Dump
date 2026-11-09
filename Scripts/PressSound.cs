using UnityEngine;
public class PressSound : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioSource source;
    private float 丟丂万丒丙丛丙业丟;
    private bool 三丄不丏且专丘丐丞;
    
    // Methods
    private void 丛不上丛一丆丛丅下()
    {
        this.三丄不丏且专丘丐丞 = true;
        this.source.Play();
    }
    private void Update()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        if(this.三丄不丏且专丘丐丞 == false)
        {
            goto label_1;
        }
        
        if(this.丟丂万丒丙丛丙业丟 <= val_2.y)
        {
            goto label_4;
        }
        
        this.三丄不丏且专丘丐丞 = false;
        goto label_4;
        label_1:
        if(this.丟丂万丒丙丛丙业丟 < 0)
        {
                this.丛不上丛一丆丛丅下();
        }
        
        label_4:
        this.丟丂万丒丙丛丙业丟 = val_2.y;
    }
    public PressSound()
    {
    
    }

}
