using UnityEngine;
public sealed class FeedbackMenuController : MonoBehaviour
{
    // Fields
    private FeedbackMenuController.丙丟与丐三丐万万丆 丗下丘世三七一专丕;
    public UIButton faqButton;
    public UIButton termsFuseButton;
    public UIButton sendFeedbackButton;
    public UIButton backButton;
    public UnityEngine.GameObject textFAQScroll;
    public UnityEngine.GameObject textTermsOfUse;
    private UILabel _versionLabel;
    private static FeedbackMenuController <不丁丄七丛不丆丁丕>k__BackingField;
    
    // Properties
    internal static FeedbackMenuController 丆丕丝丒不丙且丐丗 { get; set; }
    public FeedbackMenuController.丙丟与丐三丐万万丆 上丅丑丌丑丏丏丙东 { get; set; }
    
    // Methods
    internal static FeedbackMenuController 丑七不且上丗丁一世()
    {
        return (FeedbackMenuController)FeedbackMenuController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(FeedbackMenuController 丙业与丙丗丝不丈东)
    {
        FeedbackMenuController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        FeedbackMenuController.<不丁丄七丛不丆丁丕>k__BackingField = this;
    }
    private void Start()
    {
        var val_23;
        System.Func<UIButton, System.Boolean> val_25;
        var val_29;
        var val_30;
        this.CurrentState = 0;
        UIButton[] val_1 = new UIButton[2];
        val_1[0] = this.faqButton;
        val_1[1] = this.termsFuseButton;
        val_23 = null;
        val_23 = null;
        val_25 = FeedbackMenuController.<>c.<>9__14_0;
        if(val_25 == null)
        {
                System.Func<UIButton, System.Boolean> val_2 = null;
            val_25 = val_2;
            val_2 = new System.Func<UIButton, System.Boolean>(object:  FeedbackMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FeedbackMenuController.<>c::一丞丏世丞丙丆丏丏(UIButton 丌丗丏丏丛东专丁且));
            FeedbackMenuController.<>c.<>9__14_0 = val_25;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Where<UIButton>(source:  val_1, predicate:  val_2).GetEnumerator();
        label_34:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_23;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        Rilisoft.ButtonHandler val_10 = val_5.Current.GetComponent<Rilisoft.ButtonHandler>();
        if(val_10 == 0)
        {
            goto label_34;
        }
        
        new System.EventHandler() = new System.EventHandler(object:  this, method:  System.Void FeedbackMenuController::丛与丛丐丙丝丅丁东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        val_10.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler());
        goto label_34;
        label_23:
        val_29 = 0;
        val_30 = 0;
        if(val_5 == null)
        {
            
        }
        else
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            val_5.Dispose();
        }
        
        if(this.sendFeedbackButton != 0)
        {
                Rilisoft.ButtonHandler val_15 = this.sendFeedbackButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_15 != 0)
        {
                val_15.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void FeedbackMenuController::一丛丆丆丕丝东万丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.backButton != 0)
        {
                Rilisoft.ButtonHandler val_19 = this.backButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_19 != 0)
        {
                val_19.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void FeedbackMenuController::专丗丄七丏丕丂丗丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this._versionLabel == 0)
        {
                return;
        }
        
        this._versionLabel.text = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).Version(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).Version) + ".0";
    }
    private void 丞丆七丁世与丗万万()
    {
        var val_4;
        MainMenuController val_5;
        var val_6;
        var val_7;
        this.gameObject.SetActive(value:  false);
        val_4 = null;
        val_4 = null;
        val_5 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 24];
        val_5 = MainMenuController.丄丞丁丈与业上丞丟 + 24;
        if(val_5 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        MainMenuController.丄丞丁丈与业上丞丟 + 24.SetActive(value:  true);
    }
    private void 专丗丄七丏丕丂丗丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丞丆七丁世与丗万万();
    }
    internal static void 上丌丂且世不丁丈丛(System.Action 丕丒上丄丒业丕丕丐)
    {
        if(丕丒上丄丒业丕丕丐 == null)
        {
                return;
        }
        
        丕丒上丄丒业丕丕丐.Invoke();
    }
    private void 一丛丆丆丕丝东万丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        System.Action val_4;
        val_2 = null;
        val_2 = null;
        val_4 = FeedbackMenuController.<>c.<>9__18_0;
        if(val_4 == null)
        {
                System.Action val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action(object:  FeedbackMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FeedbackMenuController.<>c::专丄丈丟一丂丈丏不());
            FeedbackMenuController.<>c.<>9__18_0 = val_4;
            if(val_4 == null)
        {
                return;
        }
        
        }
        
        val_1.Invoke();
    }
    private void 丛与丛丐丙丝丅丁东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_9;
        UnityEngine.Object val_10;
        丙丟与丐三丐万万丆 val_11;
        val_9 = 不丟丗丏丛丕不丁丌;
        if(val_9 == null)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_4;
        }
        
        val_9 = 0;
        goto label_4;
        label_1:
        label_4:
        UnityEngine.GameObject val_2 = val_9.gameObject;
        if(this.faqButton == 0)
        {
            goto label_11;
        }
        
        val_10 = this.faqButton.gameObject;
        if(val_2 != val_10)
        {
            goto label_11;
        }
        
        val_11 = 0;
        goto label_12;
        label_11:
        val_10 = this.termsFuseButton;
        if(val_10 == 0)
        {
                return;
        }
        
        val_10 = this.termsFuseButton.gameObject;
        if(val_2 != val_10)
        {
                return;
        }
        
        val_11 = 1;
        label_12:
        this.CurrentState = val_11;
    }
    public FeedbackMenuController.丙丟与丐三丐万万丆 get_CurrentState()
    {
        return (丙丟与丐三丐万万丆)this.丗下丘世三七一专丕;
    }
    public void set_CurrentState(FeedbackMenuController.丙丟与丐三丐万万丆 丙业与丙丗丝不丈东)
    {
        UIButton val_30;
        if(this.faqButton != 0)
        {
                var val_2 = (丙业与丙丗丝不丈东 != 0) ? 1 : 0;
            UnityEngine.Transform val_5 = this.faqButton.gameObject.transform.Find(n:  "SpriteLabel");
            if(val_5 != 0)
        {
                val_5.gameObject.SetActive(value:  (丙业与丙丗丝不丈东 != 0) ? 1 : 0);
        }
        
            UnityEngine.Transform val_11 = this.faqButton.gameObject.transform.Find(n:  "ChekmarkLabel");
            if(val_11 != 0)
        {
                val_11.gameObject.SetActive(value:  (丙业与丙丗丝不丈东 == 0) ? 1 : 0);
        }
        
            this.textFAQScroll.SetActive(value:  (丙业与丙丗丝不丈东 == 0) ? 1 : 0);
        }
        
        val_30 = this.termsFuseButton;
        if(val_30 != 0)
        {
                UnityEngine.Transform val_20 = this.termsFuseButton.gameObject.transform.Find(n:  "SpriteLabel");
            if(val_20 != 0)
        {
                val_20.gameObject.SetActive(value:  (丙业与丙丗丝不丈东 != 1) ? 1 : 0);
        }
        else
        {
                UnityEngine.Debug.Log(message:  "_spriteLabel=null");
        }
        
            UnityEngine.Transform val_25 = this.termsFuseButton.gameObject.transform.Find(n:  "ChekmarkLabel");
            if(val_25 != 0)
        {
                val_25.gameObject.SetActive(value:  (丙业与丙丗丝不丈东 == 1) ? 1 : 0);
        }
        else
        {
                UnityEngine.Debug.Log(message:  "_spriteLabel=null");
        }
        
            val_30 = this.textTermsOfUse;
            val_30.SetActive(value:  (丙业与丙丗丝不丈东 == 1) ? 1 : 0);
        }
        
        this.丗下丘世三七一专丕 = 丙业与丙丗丝不丈东;
    }
    public FeedbackMenuController()
    {
    
    }

}
