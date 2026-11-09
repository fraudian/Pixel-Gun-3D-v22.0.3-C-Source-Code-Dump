using UnityEngine;
public class DuelBetItem : MonoBehaviour
{
    // Fields
    public UILabel betLabel;
    public Rilisoft.ButtonHandler btnAccept;
    public Rilisoft.ButtonHandler btnBet;
    public UnityEngine.GameObject isBet;
    public UnityEngine.GameObject isOffer;
    public UnityEngine.GameObject isSelected;
    public UnityEngine.GameObject isEnemyOffer;
    public UIBasicSprite myTexture;
    public UnityEngine.GameObject gemCurrency;
    public UnityEngine.GameObject coinCurrency;
    public UnityEngine.GameObject eventCurrency;
    public UITexture eventIconTexture;
    private int 业七丂丈七世与东丑;
    
    // Methods
    public void InitializeBet(int 丞世不丒下上上丝丑, Rilisoft.上专业三丟丁丞专下 东丁与一丝丑丅业丑, string 丝丏业丅丈东业丝丒)
    {
        UITexture val_23;
        string val_24;
        var val_25;
        val_23 = this;
        this.业七丂丈七世与东丑 = 丞世不丒下上上丝丑;
        this.betLabel.text = 东丁与一丝丑丅业丑.且丙东丞一丐万丕万().丟丂丞不专丆万丒世().ToString();
        this.gemCurrency.SetActive(value:  true);
        if(this.myTexture != null)
        {
                this.myTexture = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.myTexture);
        }
        
        int val_5 = 丞世不丒下上上丝丑 + 1;
        string val_6 = System.String.Format(format:  "OfferIcons/{0}_chest_{1}", arg0:  丝丏业丅丈东业丝丒, arg1:  val_5);
        val_24 = val_6;
        if((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_6)) == 0)
        {
                val_24 = System.String.Format(format:  "OfferIcons/{0}_chest_{1}", arg0:  "default", arg1:  val_5);
        }
        
        if((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_24)) == 0)
        {
                UnityEngine.Debug.LogError(message:  "texture by path `" + val_24 + "` not found");
        }
        
        string val_14 = 东丁与一丝丑丅业丑.且丙东丞一丐万丕万().东与三丌丅三丒丏业();
        val_25 = null;
        val_25 = null;
        string val_23 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        val_23 = System.String.op_Equality(a:  val_14, b:  val_23);
        this.gemCurrency.SetActive(value:  val_23);
        string val_24 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        val_24 = System.String.op_Equality(a:  val_14, b:  val_24);
        this.coinCurrency.SetActive(value:  val_24);
        string val_25 = "EventCurrency";
        val_25 = System.String.op_Equality(a:  val_14, b:  val_25);
        this.eventCurrency.SetActive(value:  val_25);
        if((System.String.op_Equality(a:  val_14, b:  "EventCurrency")) == false)
        {
                return;
        }
        
        val_23 = this.eventIconTexture;
        UnityEngine.Texture2D val_22 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().丐与丄世三丐不丁丛());
    }
    public void ShowAcceptBetBtn(bool 丛与丙丒丒下丌丟且)
    {
        this.btnBet.gameObject.SetActive(value:  false);
        this.btnAccept.gameObject.SetActive(value:  丛与丙丒丒下丌丟且);
    }
    public void UpdateBet(bool 丄专丕丈万丈不丑且, bool 丟丈丟丌丕且东世三, bool 丟丝丁丌丞业业丘丅, bool 丅丏东专三丌丑丏丏, bool 七丑丕一业三专丆一)
    {
        bool val_6 = 七丑丕一业三专丆一;
        bool val_5 = 丅丏东专三丌丑丏丏;
        bool val_7 = 丟丝丁丌丞业业丘丅;
        this.isBet.SetActive(value:  val_5);
        val_5 = val_5 ^ 1;
        val_6 = val_5 & val_6;
        this.isOffer.SetActive(value:  val_6);
        val_7 = val_5 & val_7;
        this.isEnemyOffer.SetActive(value:  val_7);
        this.isSelected.SetActive(value:  丄专丕丈万丈不丑且);
    }
    private void OnClick()
    {
        int val_1;
        var val_2;
        val_1 = this.业七丂丈七世与东丑;
        if(val_1 == 1)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        val_1 = this.业七丂丈七世与东丑;
        DuelController.丄丘七三上丕世丞业.OpenBet(万丙丈丙丄丅丝专上:  val_1);
    }
    public DuelBetItem()
    {
        this.业七丂丈七世与东丑 = 0;
    }

}
