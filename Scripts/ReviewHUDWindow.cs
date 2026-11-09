using UnityEngine;
internal sealed class ReviewHUDWindow : MonoBehaviour
{
    // Fields
    private static ReviewHUDWindow 丝业丆丁业三丈丟东;
    internal static bool 丆丄丗七丂丐世丂七;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private bool 不一丒丒东业丈丞专;
    public StarReview[] arrStarByOrder;
    public UIButton btnSendMsg;
    public int countStarForReview;
    public UIInput inputMsg;
    private bool 且丘丙与丆丙丁业世;
    private bool 万丞丞丟丟万丒丞世;
    public UILabel lbTitle5Stars;
    public UnityEngine.GameObject objThanks;
    public UnityEngine.GameObject objWindowEnterMsg;
    public UnityEngine.GameObject objWindowGoToStore;
    public UnityEngine.GameObject objWindowRating;
    
    // Properties
    internal static ReviewHUDWindow 丆丕丝丒不丙且丐丗 { get; }
    public string 且丂丞丞丘与丟东丗 { get; }
    public bool 丞与与丟专万丑丒丆 { get; set; }
    
    // Methods
    internal static ReviewHUDWindow 丑七不且上丗丁一世()
    {
        var val_5;
        ReviewHUDWindow val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        val_6 = ReviewHUDWindow.丝业丆丁业三丈丟东;
        if(val_6 != 0)
        {
                return (ReviewHUDWindow)ReviewHUDWindow.丝业丆丁业三丈丟东;
        }
        
        val_7 = null;
        val_6 = InfoWindowController.丑七不且上丗丁一世().gameObject.GetComponentInChildren<ReviewHUDWindow>();
        val_7 = null;
        ReviewHUDWindow.丝业丆丁业三丈丟东 = val_6;
        return (ReviewHUDWindow)ReviewHUDWindow.丝业丆丁业三丈丟东;
    }
    public string get_TitleTextTranslate()
    {
        return "";
    }
    public bool get_NeedShowThanks()
    {
        return (bool)this.不一丒丒东业丈丞专;
    }
    public void set_NeedShowThanks(bool 丙业与丙丗丝不丈东)
    {
        this.不一丒丒东业丈丞专 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        var val_2;
        StarReview[] val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        ReviewHUDWindow.丝业丆丁业三丈丟东 = this;
        val_3 = this.arrStarByOrder;
        if(val_3 == null)
        {
                return;
        }
        
        val_4 = 1;
        goto label_4;
        label_13:
        StarReview val_2 = this.arrStarByOrder[136162552];
        this.arrStarByOrder[1152921505252691968][0].numOrderStar = 1152921505252691968;
        StarReview val_3 = this.arrStarByOrder[136162552];
        this.arrStarByOrder[1152921505252691968][0].lbNumStar.text = val_4.ToString();
        val_3 = this.arrStarByOrder;
        val_4 = 2;
        label_4:
        if(1 < this.arrStarByOrder.Length)
        {
            goto label_13;
        }
    
    }
    private void OnEnable()
    {
        this.丘业东丘下世世专丘();
    }
    private void OnDestroy()
    {
        null = null;
        ReviewHUDWindow.丝业丆丁业三丈丟东 = 0;
    }
    public void ShowWindowRating()
    {
        var val_6;
        int val_7;
        var val_8;
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                BannerWindowController val_3 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_3.viewedBannersCountInConnectScene != 0)
        {
                return;
        }
        
            val_6 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_6 != null)
        {
                val_7 = val_4.viewedBannersCountInConnectScene;
        }
        else
        {
                val_6 = 92;
            val_7 = 0;
        }
        
            mem[92] = 1;
        }
        
        val_8 = null;
        ReviewController.七世丝东万不丂丈且();
        if(ReviewController.丘丐丒丒三一丒丗丁() == false)
        {
                return;
        }
        
        this.且丐专七丈丑丕东丙();
    }
    internal void 丙业丈丄丕丏下丕丑(StarReview 丑上东丘丂专丗丈不)
    {
        StarReview[] val_3;
        var val_4;
        var val_5;
        if(丑上东丘丂专丗丈不 != 0)
        {
                int val_3 = 丑上东丘丂专丗丈不.numOrderStar;
            val_3 = val_3 + 1;
            this.countStarForReview = val_3;
        }
        
        val_3 = this.arrStarByOrder;
        if(val_3 == null)
        {
                return;
        }
        
        val_4 = 0;
        goto label_6;
        label_20:
        if(丑上东丘丂专丗丈不 != 0)
        {
                if(val_4 <= 丑上东丘丂专丗丈不.numOrderStar)
        {
            goto label_11;
        }
        
        }
        
        StarReview val_4 = this.arrStarByOrder[0];
        val_5 = 0;
        goto label_15;
        label_11:
        val_5 = 1;
        label_15:
        this.arrStarByOrder[0].一丘三丆下三丆与丕(下下丏一丙不丘丌丞:  true);
        val_3 = this.arrStarByOrder;
        val_4 = 1;
        label_6:
        if(val_4 < this.arrStarByOrder.Length)
        {
            goto label_20;
        }
    
    }
    public void OnChangeMsgReview()
    {
        this.丑七丝专专丒丝不丆(下下丏一丙不丘丌丞:  true);
    }
    public void OnClickStarRating()
    {
        int val_1 = this.countStarForReview;
        val_1 = val_1 - 1;
        if(val_1 <= 3)
        {
                this.丕丟丐东丆丘世东丄();
            return;
        }
        
        this.丙丑不与丆下三丂丙(世丅一丆一丒丘七上:  true);
    }
    public void OnSendMsgWithRating()
    {
        this.丙丑不与丆下三丂丙(世丅一丆一丒丘七上:  true);
    }
    private void 丙丑不与丆下三丂丙(bool 世丅一丆一丒丘七上 = True)
    {
        int val_7;
        int val_8;
        string val_9;
        bool val_10;
        var val_11;
        this.专丁七丈丁不丒七丕();
        if(世丅一丆一丒丘七上 == false)
        {
                return;
        }
        
        val_7 = this.countStarForReview;
        if(val_7 < 1)
        {
                return;
        }
        
        if(this.且丘丙与丆丙丁业世 != false)
        {
                val_8 = this.countStarForReview;
            val_9 = this.inputMsg.value;
        }
        else
        {
                val_9 = "";
        }
        
        if(val_7 == 5)
        {
                Rilisoft.丝丄三业丙专丛与不.东三丆丁三下七丑上(丝丏业丅丈东业丝丒:  "5star_rating", 丗丟上上丒丐丗丞丙:  0);
            val_8 = this.countStarForReview;
        }
        
        Rilisoft.一丟专且三万丞丁丂.且且丏业丛丄丟丁丕(下与丛万与丑丅三与:  true, 三东上丝丟丑丁丌丄:  val_8, 一丒七且丕丗一丙丒:  ((val_8 != 5) ? 1 : 0) & ((this.且丘丙与丆丙丁业世 == true) ? 1 : 0));
        if(this.万丞丞丟丟万丒丞世 != false)
        {
                val_10 = 0;
        }
        else
        {
                val_8 = this.countStarForReview;
            val_10 = (~(ReviewController.一一上不东万世丂丘(丈丐世下丞与丂专丏:  val_8, 丄丝丁专丄丑丟三丆:  val_9))) & 1;
        }
        
        this.不一丒丒东业丈丞专 = val_10;
        val_11 = null;
        val_11 = null;
        ReviewHUDWindow.丆丄丗七丂丐世丂七 = true;
        this.丘业东丘下世世专丘();
    }
    public void OnClickClose()
    {
        null = null;
        ReviewHUDWindow.丆丄丗七丂丐世丂七 = false;
        Rilisoft.一丟专且三万丞丁丂.且且丏业丛丄丟丁丕(下与丛万与丑丅三与:  (this.countStarForReview != 0) ? 1 : 0, 三东上丝丟丑丁丌丄:  this.countStarForReview, 一丒七且丕丗一丙丒:  false);
        this.丙丑不与丆下三丂丙(世丅一丆一丒丘七上:  false);
    }
    private void 专丁七丈丁不丒七丕()
    {
        null = null;
        ReviewHUDWindow.丆丄丗七丂丐世丂七 = false;
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowRating)) != false)
        {
                this.objWindowRating.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowEnterMsg)) != false)
        {
                this.objWindowEnterMsg.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowGoToStore)) != false)
        {
                this.objWindowGoToStore.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objThanks)) != false)
        {
                this.objThanks.SetActive(value:  false);
        }
        
        this.不且东不七一一万丑();
    }
    private void 丕丟丐东丆丘世东丄()
    {
        this.丑七丝专专丒丝不丆(下下丏一丙不丘丌丞:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowRating)) != false)
        {
                this.objWindowRating.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowEnterMsg)) == false)
        {
                return;
        }
        
        this.objWindowEnterMsg.SetActive(value:  true);
        InfoWindowController.丑七不且上丗丁一世().丞丙下丑丗丑丝业丁();
    }
    private void 丝丂丕丏与专丐丙丅()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                return;
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ReviewHUDWindow::OnClickClose()), 与且专丈不万东一万:  "Review HUD (Window with 5 stars)");
    }
    private void 且丐专七丈丑丕东丙()
    {
        var val_9;
        int val_10;
        var val_11;
        var val_12;
        val_9 = static_value_081DACA8;
        val_9 = static_value_081DACA8;
        val_10 = 1152921505133842432;
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                val_11 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_11 != null)
        {
                val_10 = val_3.viewedBannersCountInConnectScene;
        }
        else
        {
                val_11 = 92;
            val_10 = 0;
        }
        
            mem[92] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        ReviewHUDWindow.丆丄丗七丂丐世丂七 = true;
        this.countStarForReview = 0;
        this.丙业丈丄丕丏下丕丑(丑上东丘丂专丗丈不:  0);
        ReviewController.专丙不与丗丕丈业丂(丙业与丙丗丝不丈东:  true);
        ReviewController.丝丑与丑丈丌七丂七(丙业与丙丗丝不丈东:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.lbTitle5Stars)) != false)
        {
                val_10 = "";
            this.lbTitle5Stars.text = val_10;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowRating)) != false)
        {
                this.objWindowRating.SetActive(value:  true);
            InfoWindowController.丑七不且上丗丁一世().丞丙下丑丗丑丝业丁();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowEnterMsg)) != false)
        {
                this.objWindowEnterMsg.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowGoToStore)) != false)
        {
                this.objWindowGoToStore.SetActive(value:  false);
        }
        
        this.丝丂丕丏与专丐丙丅();
    }
    private void 丈不丞与下与专丅一()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowRating)) != false)
        {
                this.objWindowRating.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objWindowEnterMsg)) == false)
        {
                return;
        }
        
        this.objWindowGoToStore.SetActive(value:  true);
        InfoWindowController.丑七不且上丗丁一世().丞丙下丑丗丑丝业丁();
    }
    private void 丘业东丘下世世专丘()
    {
        if(this.不一丒丒东业丈丞专 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.不一丌与三丝丐丑专());
    }
    private System.Collections.IEnumerator 不一丌与三丝丐丑专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ReviewHUDWindow.且丆丒东世丏世丕丈();
    }
    public void OnCloseThanks()
    {
        var val_2;
        if(this.objThanks != 0)
        {
                this.万丞丞丟丟万丒丞世 = false;
            this.objThanks.SetActive(value:  false);
        }
        
        val_2 = null;
        val_2 = null;
        ReviewHUDWindow.丆丄丗七丂丐世丂七 = false;
        this.不且东不七一一万丑();
    }
    private void 丑七丝专专丒丝不丆(bool 下下丏一丙不丘丌丞)
    {
        UIButton val_2;
        丙丟与丐三丐万万丆 val_3;
        this.且丘丙与丆丙丁业世 = 下下丏一丙不丘丌丞;
        if(this.btnSendMsg == null)
        {
            goto label_0;
        }
        
        if(下下丏一丙不丘丌丞 == false)
        {
            goto label_1;
        }
        
        label_4:
        this.btnSendMsg.enabled = true;
        val_2 = this.btnSendMsg;
        val_3 = 0;
        goto label_3;
        label_0:
        if(下下丏一丙不丘丌丞 == true)
        {
            goto label_4;
        }
        
        label_1:
        this.btnSendMsg.enabled = false;
        val_2 = this.btnSendMsg;
        val_3 = 3;
        label_3:
        val_2.state = val_3;
    }
    private void 一上丐丝丂东丟丒丌()
    {
        this.arrStarByOrder = this.GetComponentsInChildren<StarReview>(includeInactive:  true);
    }
    private void 不且东不七一一万丑()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    public ReviewHUDWindow()
    {
    
    }
    private static ReviewHUDWindow()
    {
    
    }

}
