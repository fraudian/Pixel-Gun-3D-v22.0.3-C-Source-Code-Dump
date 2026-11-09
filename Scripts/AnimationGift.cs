using UnityEngine;
public class AnimationGift : MonoBehaviour
{
    // Fields
    internal static AnimationGift 丄丘七三上丕世丞业;
    private UnityEngine.Animator 丒上下丘丈万丛三丘;
    private bool 丗丟丑丆丕丑丗丅且;
    public Rilisoft.GiftLobbyHeader LobbyHeader;
    public UnityEngine.GameObject objGift;
    public UnityEngine.AudioClip soundClose;
    public UnityEngine.AudioClip soundGetGift;
    public UnityEngine.AudioClip soundOpen;
    private float 丗三丕丐与且下丐下;
    private static System.Action 丂丒与丆丕上东丐丐;
    
    // Methods
    internal static void 业丙丌丙与万上丐丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  AnimationGift.丂丒与丆丕上东丐丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AnimationGift.丂丒与丆丕上东丐丐 != 1152921505204133896);
    
    }
    internal static void 丁丞丄与七丘上丕丗(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  AnimationGift.丂丒与丆丕上东丐丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(AnimationGift.丂丒与丆丕上东丐丐 != 1152921505204133896);
    
    }
    private void Awake()
    {
        AnimationGift.丄丘七三上丕世丞业 = this;
        this.丒上下丘丈万丛三丘 = this.objGift.GetComponent<UnityEngine.Animator>();
        this.丄专丁丞丒丘丒世且(下下丏一丙不丘丌丞:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.LobbyHeader, 丏业丟一东丂东丘丛:  false);
    }
    private void OnEnable()
    {
        GiftBannerWindow.业三专丝丘丄丒丄三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::OpenGift()));
        GiftBannerWindow.东世世丂丗丙且上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CloseGift()));
        GiftBannerWindow.东世世丂丗丙且上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckStateGift()));
        GiftBannerWindow.丌七丘与丁丏丈三丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::OnOpenInfoGift()));
        GiftController.世丌专上丟丄三上丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckStateGift()));
        GiftController.不丂一三丈业一丁丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckVisibleGift()));
        MainMenuController.丄丈丝丕世丕且东丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AnimationGift::丞且丞丅丛三丕丄不()));
        FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckVisibleGift()));
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckVisibleGift()));
        MainMenuController.丗丝丗丗丒一丝丑丘(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void AnimationGift::丌上丟上世丁世丛丝(bool 下下丏一丙不丘丌丞)));
        ShopNGUIController.东丈且业万专丞丈丝(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void AnimationGift::丕三丄上世丟丆丑丌(bool 七七丑丙丙丛丌世不)));
    }
    private void 丕三丄上世丟丆丑丌(bool 七七丑丙丙丛丌世不)
    {
        if(七七丑丙丙丛丌世不 != false)
        {
                return;
        }
        
        this.CheckVisibleGift();
    }
    private void OnDisable()
    {
        GiftBannerWindow.丈专七丁专专丗万丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CloseGift()));
        GiftBannerWindow.丕东与一丛业上丐丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::OpenGift()));
        GiftBannerWindow.丈专七丁专专丗万丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckStateGift()));
        GiftBannerWindow.丐与丏东丑且专丈丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::OnOpenInfoGift()));
        GiftController.上上丂丙丒三丅丑与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckStateGift()));
        FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckVisibleGift()));
        GiftController.丟丆丏丕丞不上丞丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckVisibleGift()));
        MainMenuController.丌七丝与丂丒七丑丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AnimationGift::丞且丞丅丛三丕丄不()));
        MainMenuController.与专业七与丁世一世(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void AnimationGift::丌上丟上世丁世丛丝(bool 下下丏一丙不丘丌丞)));
        ShopNGUIController.丒不下丑与丝专丂七(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void AnimationGift::丕三丄上世丟丆丑丌(bool 七七丑丙丙丛丌世不)));
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void AnimationGift::CheckVisibleGift()));
    }
    private void 丁一丛丕丞丅丄与万()
    {
        AnimationGift.丄丘七三上丕世丞业 = 0;
    }
    private void 丞且丞丅丛三丕丄不()
    {
        this.CheckVisibleGift();
    }
    public void OpenGift()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丏丛丒丌世丄丗丁丒());
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && ((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.AudioSource>())) != false))
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.soundOpen)) != false)
        {
                this = this.soundOpen;
            this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this);
        }
        
        }
        
        Rilisoft.丞丛七上丕专丏丌丈.丑丗万丞与专三丅下();
    }
    private System.Collections.IEnumerator 丏丛丒丌世丄丗丁丒()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AnimationGift.东丘丌世丌一丞丌专();
    }
    public void OnOpenInfoGift()
    {
        if(this.丒上下丘丈万丛三丘 != 0)
        {
                this.丒上下丘丈万丛三丘.SetBool(name:  "IsOpen", value:  true);
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.AudioSource>())) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.soundGetGift)) == false)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.soundGetGift);
    }
    public void CloseGift()
    {
        if(this.丒上下丘丈万丛三丘 != 0)
        {
                this.丒上下丘丈万丛三丘.SetBool(name:  "IsOpen", value:  false);
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<UnityEngine.AudioSource>())) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.soundClose)) == false)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.soundClose);
    }
    public void CheckStateGift()
    {
        bool val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = 1152921505204236288;
        val_8 = null;
        val_8 = null;
        if(ButOpenGift.丄丘七三上丕世丞业 != 0)
        {
                val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            val_7 = GiftController.丆丕丝丒不丙且丐丗.CanGetTimerGift;
            ButOpenGift.丄丘七三上丕世丞业.IsCanGetGift = val_7;
        }
        
        if(this.丒上下丘丈万丛三丘 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        this.丒上下丘丈万丛三丘.SetBool(name:  "IsEnabled", value:  GiftController.丆丕丝丒不丙且丐丗.CanGetGift);
    }
    public void CheckVisibleGift()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_9 = null;
        val_9 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_25;
        }
        
        val_10 = null;
        val_10 = null;
        if(GiftController.丆丕丝丒不丙且丐丗.ActiveGift == false)
        {
            goto label_25;
        }
        
        val_11 = null;
        val_11 = null;
        if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeSelf) == true)
        {
            goto label_25;
        }
        
        val_12 = null;
        val_12 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.与丙七丞丞不丒丙丘() == false)
        {
            goto label_18;
        }
        
        label_25:
        this.丄专丁丞丒丘丒世且(下下丏一丙不丘丌丞:  false);
        return;
        label_18:
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() != false)
        {
                if(QuestsGSMAnager.丑七不且上丗丁一世().NumCompletedTasks < 4)
        {
            goto label_25;
        }
        
        }
        
        this.丄专丁丞丒丘丒世且(下下丏一丙不丘丌丞:  false);
        this.CheckStateGift();
    }
    public void ResetAnimation()
    {
        var val_5;
        var val_6;
        if(this.丒上下丘丈万丛三丘 != 0)
        {
                this.丒上下丘丈万丛三丘.SetBool(name:  "IsOpen", value:  false);
        }
        
        this.StopCoroutine(methodName:  "WaitOpenGift");
        val_5 = null;
        val_5 = null;
        if(ButOpenGift.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        this.丗丟丑丆丕丑丗丅且 = false;
        val_6 = null;
        val_6 = null;
        ButOpenGift.丄丘七三上丕世丞业.RemoveCanShowNickLabelChecker(丑上丈丞丗丄丒丈丕:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean AnimationGift::丞且丝丕七丘丐丘世()));
        ButOpenGift.丄丘七三上丕世丞业.AddCanShowNickLabelChecker(丑上丈丞丗丄丒丈丕:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean AnimationGift::丞且丝丕七丘丐丘世()));
    }
    public void StartAnimForGetGift()
    {
        if(this.丒上下丘丈万丛三丘 == 0)
        {
                return;
        }
        
        this.丒上下丘丈万丛三丘.SetBool(name:  "IsEnabled", value:  true);
    }
    public void StopAnimForGetGift()
    {
        this.CheckStateGift();
    }
    private void 丄专丁丞丒丘丒世且(bool 下下丏一丙不丘丌丞)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.objGift, 丏业丟一东丂东丘丛:  false);
    }
    private void WaitEndAnimShow()
    {
        var val_4;
        var val_5;
        this.CancelInvoke(methodName:  "WaitEndAnimShow");
        val_4 = null;
        val_4 = null;
        if(ButOpenGift.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        this.丗丟丑丆丕丑丗丅且 = true;
        val_5 = null;
        val_5 = null;
        ButOpenGift.丄丘七三上丕世丞业.RemoveCanShowNickLabelChecker(丑上丈丞丗丄丒丈丕:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean AnimationGift::丞且丝丕七丘丐丘世()));
        ButOpenGift.丄丘七三上丕世丞业.AddCanShowNickLabelChecker(丑上丈丞丗丄丒丈丕:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean AnimationGift::丞且丝丕七丘丐丘世()));
    }
    private void OnApplicationPause(bool 丄七丙不丟丛与丏丐)
    {
        if(丄七丙不丟丛与丏丐 != false)
        {
                return;
        }
        
        this.Invoke(methodName:  "CheckVisibleGift", time:  0.1f);
    }
    private void 不丄上上丐专丑丏上(string 七下不丁与业丈丆丑)
    {
        var val_4;
        goto label_1;
        label_6:
        val_4 = this.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true)[0].gameObject;
        val_4.layer = UnityEngine.LayerMask.NameToLayer(layerName:  七下不丁与业丈丆丑);
        0 = 1;
        label_1:
        if(0 < val_1.Length)
        {
            goto label_6;
        }
    
    }
    private void 丌上丟上世丁世丛丝(bool 下下丏一丙不丘丌丞)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = null;
        val_2 = null;
        if(ButOpenGift.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_3 = null;
        if(下下丏一丙不丘丌丞 != false)
        {
                val_4 = null;
            ButOpenGift.丄丘七三上丕世丞业.UpdateHUDStateGift();
            return;
        }
        
        val_5 = null;
        ButOpenGift.丄丘七三上丕世丞业.HideLabelTap();
    }
    private bool 丞且丝丕七丘丐丘世()
    {
        return (bool)this.丗丟丑丆丕丑丗丅且;
    }
    public AnimationGift()
    {
        this.丗丟丑丆丕丑丗丅且 = true;
        this.丗三丕丐与且下丐下 = 2f;
    }

}
