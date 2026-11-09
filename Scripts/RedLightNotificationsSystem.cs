using UnityEngine;
internal sealed class RedLightNotificationsSystem : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject messagePreStart;
    private UnityEngine.GameObject stopRunContainer;
    private UnityEngine.GameObject messageStop;
    private UnityEngine.GameObject messageRun;
    private UnityEngine.GameObject messageNowYouDied;
    private UnityEngine.GameObject labelYouMoved;
    private UnityEngine.GameObject labelTimeOut;
    private UnityEngine.GameObject labelYouDied;
    private UnityEngine.GameObject labelYouDiedCentered;
    private UnityEngine.GameObject messageYouScored;
    private UILabel[] placeLabels;
    private double 东丐丄丁丞丟东上丂;
    
    // Methods
    private void Awake()
    {
        if(RedLightController.Instance == 0)
        {
                return;
        }
        
        if(RedLightController.Instance.goTimer > 0f)
        {
                return;
        }
        
        if((RedLightController.Instance.丈丏与丅丏丘丟七万 & 1) == 0)
        {
                this.ShowMessageRun();
            return;
        }
        
        this.ShowMessageStop();
    }
    public void HideAllMessages()
    {
        this.messagePreStart.SetActive(value:  false);
        this.stopRunContainer.SetActive(value:  false);
        this.messageStop.SetActive(value:  false);
        this.messageRun.SetActive(value:  false);
        this.messageNowYouDied.SetActive(value:  false);
        this.messageYouScored.SetActive(value:  false);
        this.东丐丄丁丞丟东上丂 = -1;
    }
    public void SetStatusMessageContainer(bool 下丁丞丝丛一丘丐丒)
    {
        下丁丞丝丛一丘丐丒 = 下丁丞丝丛一丘丐丒;
        this.stopRunContainer.SetActive(value:  下丁丞丝丛一丘丐丒);
    }
    public void HideMessagePreStart()
    {
        this.messagePreStart.SetActive(value:  false);
    }
    public void ShowMessagePreStart()
    {
        this.HideAllMessages();
        this.messagePreStart.SetActive(value:  true);
        float val_2 = (float)RedLightController.Instance.七丙丟万丏与丆丆丂;
        val_2 = UnityEngine.Time.time + val_2;
        this.东丐丄丁丞丟东上丂 = (double)val_2;
    }
    public void ShowMessageStop()
    {
        this.messageStop.SetActive(value:  true);
        this.东丐丄丁丞丟东上丂 = -1;
    }
    public void ShowMessageRun()
    {
        this.messageRun.SetActive(value:  true);
        this.东丐丄丁丞丟东上丂 = -1;
    }
    public void HideMessageStop()
    {
        this.messageStop.SetActive(value:  false);
    }
    public void HideMessageRun()
    {
        this.messageRun.SetActive(value:  false);
    }
    public void ShowMessageNowYouDied(RedLightController.万与专世三世丝业丏 且丆丝世上丐上不万)
    {
        var val_2;
        var val_3;
        this.HideAllMessages();
        if(且丆丝世上丐上不万 == 2)
        {
            goto label_1;
        }
        
        if(且丆丝世上丐上不万 == 1)
        {
            goto label_2;
        }
        
        if(且丆丝世上丐上不万 != 0)
        {
            goto label_3;
        }
        
        this.labelYouMoved.SetActive(value:  true);
        val_2 = 0;
        goto label_6;
        label_1:
        this.labelYouMoved.SetActive(value:  false);
        this.labelTimeOut.SetActive(value:  false);
        this.labelYouDied.SetActive(value:  false);
        val_3 = 1;
        goto label_11;
        label_2:
        this.labelYouMoved.SetActive(value:  false);
        val_2 = 1;
        label_6:
        this.labelTimeOut.SetActive(value:  true);
        this.labelYouDied.SetActive(value:  true);
        val_3 = 0;
        label_11:
        this.labelYouDiedCentered.SetActive(value:  false);
        label_3:
        this.messageNowYouDied.SetActive(value:  true);
        float val_2 = (float)RedLightController.Instance.七丙丟万丏与丆丆丂;
        val_2 = UnityEngine.Time.time + val_2;
        this.东丐丄丁丞丟东上丂 = (double)val_2;
    }
    public void ShowMessageYouScored(int 且七丙丁与丌丗与上)
    {
        UILabel val_6;
        var val_7;
        this.HideAllMessages();
        val_7 = 0;
        goto label_3;
        label_8:
        val_6 = this.placeLabels[0];
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_6, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12673"), arg0:  且七丙丁与丌丗与上 + 1.ToString()));
        val_7 = 1;
        label_3:
        if(val_7 < this.placeLabels.Length)
        {
            goto label_8;
        }
        
        this.messageYouScored.SetActive(value:  true);
        float val_6 = (float)RedLightController.Instance.七丙丟万丏与丆丆丂;
        val_6 = UnityEngine.Time.time + val_6;
        this.东丐丄丁丞丟东上丂 = (double)val_6;
    }
    private void OnEnable()
    {
        this.messageNowYouDied.SetActive(value:  false);
        this.messagePreStart.SetActive(value:  false);
        this.messageYouScored.SetActive(value:  false);
    }
    private void Update()
    {
        if((this.messagePreStart.gameObject.activeSelf != false) && (RedLightController.Instance != 0))
        {
                if(RedLightController.Instance.goTimer <= 0f)
        {
                this.messagePreStart.SetActive(value:  false);
        }
        
        }
        
        float val_5 = UnityEngine.Time.time;
        if(this.东丐丄丁丞丟东上丂 >= 0)
        {
                return;
        }
        
        if(this.东丐丄丁丞丟东上丂 == (-1))
        {
                return;
        }
        
        this.HideAllMessages();
    }
    public RedLightNotificationsSystem()
    {
        this.东丐丄丁丞丟东上丂 = -1;
    }

}
