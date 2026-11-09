using UnityEngine;
public class EmojiChat : MonoBehaviour
{
    // Fields
    internal NetworkStartTable owner;
    public UnityEngine.GameObject bgLeft;
    public UnityEngine.GameObject bgRight;
    public UnityEngine.GameObject[] emojiObjects;
    public UnityEngine.GameObject[] slots;
    public UITweener tweenAnimation;
    private float 七丐不上专下丑丅丞;
    private float 丞专丙丗丘七丁丁丟;
    public bool show;
    private bool 丒专下丟丝七丆丆三;
    
    // Methods
    internal void 下丞丆业丘东丁下且(NetworkStartTable 丈丗与丞一上且上上, string 丛丆丆世下丛不丏东)
    {
        NetworkStartTable val_6;
        var val_7;
        val_6 = 丈丗与丞一上且上上;
        if(this.gameObject == 0)
        {
                return;
        }
        
        this.owner = val_6;
        this.show = true;
        this.丒专下丟丝七丆丆三 = false;
        this.gameObject.SetActive(value:  true);
        val_6 = this.tweenAnimation;
        this.七丐不上专下丑丅丞 = 2f;
        val_6.PlayForward();
        val_7 = 0;
        goto label_6;
        label_12:
        UnityEngine.GameObject val_6 = this.emojiObjects[0];
        string val_7 = 丛丆丆世下丛不丏东;
        val_6 = val_6.name.Equals(value:  val_7);
        val_7 = val_6;
        val_6.SetActive(value:  val_7);
        val_7 = 1;
        label_6:
        if(val_7 < this.emojiObjects.Length)
        {
            goto label_12;
        }
    
    }
    public void SetEmojiAlign(bool 专世丌丆丝丈丟丛丁)
    {
        if(this.bgLeft != 0)
        {
                this.bgLeft.SetActive(value:  专世丌丆丝丈丟丛丁);
        }
        
        if(this.bgRight == 0)
        {
                return;
        }
        
        this.bgRight.SetActive(value:  (~专世丌丆丝丈丟丛丁) & 1);
    }
    public void SetEmojiSlot(int 与丄不丌一世东丁丙)
    {
        var val_2 = 0;
        goto label_0;
        label_5:
        this.slots[0].SetActive(value:  (与丄不丌一世东丁丙 == val_2) ? 1 : 0);
        val_2 = 1;
        label_0:
        if(val_2 < this.slots.Length)
        {
            goto label_5;
        }
    
    }
    public void HideEmoji(bool 丌丝丌丁下丐丞丆一 = False)
    {
        bool val_1 = ~丌丝丌丁下丐丞丆一;
        val_1 = val_1 & 1;
        this.丒专下丟丝七丆丆三 = val_1;
        if((val_1 & 1) == 0)
        {
                this.丑七与一业丛丞丝丈();
            return;
        }
        
        this.tweenAnimation.PlayReverse();
        this.丞专丙丗丘七丁丁丟 = 0.3f;
    }
    private void 丑七与一业丛丞丝丈()
    {
        this.owner = 0;
        this.gameObject.SetActive(value:  false);
        this.show = false;
    }
    private void OnDisable()
    {
        this.丒专下丟丝七丆丆三 = false;
        this.丑七与一业丛丞丝丈();
    }
    private void Update()
    {
        if(this.show == false)
        {
            goto label_2;
        }
        
        if(this.丒专下丟丝七丆丆三 == true)
        {
            goto label_1;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.七丐不上专下丑丅丞 - val_1;
        this.七丐不上专下丑丅丞 = val_1;
        if(val_1 <= 0f)
        {
                this.HideEmoji(丌丝丌丁下丐丞丆一:  false);
        }
        
        label_2:
        if(this.丒专下丟丝七丆丆三 == false)
        {
                return;
        }
        
        label_1:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丞专丙丗丘七丁丁丟 - val_2;
        this.丞专丙丗丘七丁丁丟 = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        this.丑七与一业丛丞丝丈();
    }
    public EmojiChat()
    {
        this.七丐不上专下丑丅丞 = 2f;
        this.丞专丙丗丘七丁丁丟 = 5.510186E-41f;
    }

}
