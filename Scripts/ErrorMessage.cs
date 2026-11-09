using UnityEngine;
internal sealed class ErrorMessage : PGBehaviour
{
    // Fields
    private UILabel messageTextLabel;
    private float 丘东丏丆丑丐与丆丝;
    private float 丄丝世万丙丂丛丁丈;
    
    // Methods
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丘东丏丆丑丐与丆丝 + val_1;
        this.丘东丏丆丑丐与丆丝 = val_1;
        if(val_1 < this.丄丝世万丙丂丛丁丈)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public void SetMessageText(string 丄丐丒下丌丅业丌丕)
    {
        this.丘东丏丆丑丐与丆丝 = 0f;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.messageTextLabel, 丕丗丘丑丛与丑业丒:  丄丐丒下丌丅业丌丕);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.AudioSource>().Play();
    }
    public ErrorMessage()
    {
        this.丄丝世万丙丂丛丁丈 = 1f;
    }

}
