using UnityEngine;
public class AudioSourseOnOff : MonoBehaviour
{
    // Fields
    private UnityEngine.AudioSource[] 丐三世丛丙一丟且丐;
    
    // Methods
    private void Awake()
    {
        UnityEngine.AudioSource[] val_5;
        var val_6;
        bool val_7;
        val_5 = this.GetComponents<UnityEngine.AudioSource>();
        this.丐三世丛丙一丟且丐 = val_5;
        val_6 = 0;
        goto label_1;
        label_13:
        val_7 = 0;
        if(this.丐三世丛丙一丟且丐[val_7] != 0)
        {
                val_7 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
            this.丐三世丛丙一丟且丐[val_7].enabled = val_7;
        }
        
        val_5 = this.丐三世丛丙一丟且丐;
        val_6 = 1;
        label_1:
        if(val_6 < this.丐三世丛丙一丟且丐.Length)
        {
            goto label_13;
        }
    
    }
    private void Update()
    {
        var val_7;
        bool val_8;
        val_7 = 0;
        goto label_1;
        label_19:
        val_8 = 0;
        if(this.丐三世丛丙一丟且丐[val_8] != 0)
        {
                if(this.丐三世丛丙一丟且丐[val_8].enabled ^ 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_8 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
            this.丐三世丛丙一丟且丐[val_8].enabled = val_8;
        }
        
        }
        
        val_7 = 1;
        label_1:
        if(val_7 < this.丐三世丛丙一丟且丐.Length)
        {
            goto label_19;
        }
    
    }
    public AudioSourseOnOff()
    {
    
    }

}
