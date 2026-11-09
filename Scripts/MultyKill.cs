using UnityEngine;
public class MultyKill : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioSource multikillSound;
    public UITweener[] multikillTweens;
    public string currentStreak;
    public UnityEngine.GameObject[] allStreaks;
    internal bool 丐丟东下丘丟丐丗与;
    
    // Methods
    public void PlayStreak(string 丅丈丗丒上与下丁业, string 万丑丞一丝丌丐丒丘 = "", string 丄丙下丝丛丒七丂丘 = "")
    {
        var val_10;
        var val_11;
        if(this.丐丟东下丘丟丐丗与 == false)
        {
                return;
        }
        
        this.currentStreak = 丅丈丗丒上与下丁业;
        val_11 = 0;
        goto label_2;
        label_26:
        bool val_3 = this.allStreaks[0].gameObject.name.Equals(value:  this.currentStreak);
        if(val_3 != false)
        {
                DynamicStreak val_4 = this.allStreaks[0].GetComponent<DynamicStreak>();
            if(val_4 != 0)
        {
                val_4.Set(万丑丞一丝丌丐丒丘:  万丑丞一丝丌丐丒丘, 丄丙下丝丛丒七丂丘:  丄丙下丝丛丒七丂丘);
        }
        
        }
        
        val_10 = this.allStreaks[0].gameObject;
        this.allStreaks[0] = val_3 ^ val_10.activeSelf;
        if(this.allStreaks[0] != false)
        {
                val_10 = this.allStreaks[0].gameObject;
            val_10.SetActive(value:  val_3);
        }
        
        val_11 = 1;
        label_2:
        if(val_11 < this.allStreaks.Length)
        {
            goto label_26;
        }
        
        this.且丝丅丘丄七丈丒上();
    }
    private void 且丝丅丘丄七丈丒上()
    {
        UITweener val_2;
        var val_3;
        val_2 = this;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.multikillSound.Stop();
            this.multikillSound.Play();
        }
        
        val_3 = 0;
        goto label_6;
        label_10:
        val_2 = this.multikillTweens[0];
        val_2.PlayForward();
        val_3 = 1;
        label_6:
        if(val_3 < this.multikillTweens.Length)
        {
            goto label_10;
        }
    
    }
    public void StopStreak()
    {
        goto label_0;
        label_16:
        this.allStreaks[0] = (this.allStreaks[0].gameObject.name.Equals(value:  this.currentStreak)) ^ this.allStreaks[0].gameObject.activeSelf;
        if(this.allStreaks[0] != true)
        {
                this.allStreaks[0].gameObject.SetActive(value:  false);
        }
        
        0 = 1;
        label_0:
        if(0 < this.allStreaks.Length)
        {
            goto label_16;
        }
    
    }
    public MultyKill()
    {
        this.丐丟东下丘丟丐丗与 = true;
    }

}
