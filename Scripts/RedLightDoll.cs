using UnityEngine;
internal sealed class RedLightDoll : PGBehaviour
{
    // Fields
    private UnityEngine.Animation 丗丝七下与东丆丂专;
    private string 丝一世丄丁与丑丂丛;
    private string 世世万丏专丄丁丗万;
    
    // Methods
    private void Awake()
    {
        this.丗丝七下与东丆丂专 = this.GetComponent<UnityEngine.Animation>();
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public void PlayAttack()
    {
        UnityEngine.AnimationClip val_7;
        if((System.String.op_Equality(a:  this.丗丝七下与东丆丂专.clip.name, b:  this.丝一世丄丁与丑丂丛)) != false)
        {
                return;
        }
        
        if(this.丗丝七下与东丆丂专 != null)
        {
                val_7 = this.丗丝七下与东丆丂专.GetClip(name:  this.丝一世丄丁与丑丂丛);
        }
        else
        {
                val_7 = 0.GetClip(name:  this.丝一世丄丁与丑丂丛);
        }
        
        this.丗丝七下与东丆丂专.clip = val_7;
        bool val_6 = this.丗丝七下与东丆丂专.Play();
    }
    public void PlayPeace()
    {
        UnityEngine.AnimationClip val_7;
        if((System.String.op_Equality(a:  this.丗丝七下与东丆丂专.clip.name, b:  this.世世万丏专丄丁丗万)) != false)
        {
                return;
        }
        
        if(this.丗丝七下与东丆丂专 != null)
        {
                val_7 = this.丗丝七下与东丆丂专.GetClip(name:  "Peace");
        }
        else
        {
                val_7 = 0.GetClip(name:  "Peace");
        }
        
        this.丗丝七下与东丆丂专.clip = val_7;
        bool val_6 = this.丗丝七下与东丆丂专.Play();
    }
    public RedLightDoll()
    {
        this.丝一世丄丁与丑丂丛 = "Attack_50";
        this.世世万丏专丄丁丗万 = "Peace";
    }

}
