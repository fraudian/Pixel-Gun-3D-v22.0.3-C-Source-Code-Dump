using UnityEngine;
public class ImposterVoteUI : MonoBehaviour
{
    // Fields
    public UILabel voteTimer;
    public UILabel voteLabel;
    public UnityEngine.GameObject confirmSkipContainer;
    public Rilisoft.ButtonHandler skipBtn;
    public Rilisoft.ButtonHandler confirmSkipBtn;
    public Rilisoft.ButtonHandler cancelSkipBtn;
    public UIButton skipButtonUiButton;
    public ImposterVoteCell[] voteCells;
    internal ImposterVoteController 丒专丈丛下丒一丒丛;
    public UIGrid votedPlayersGrid;
    public ImposterVotedIconCell votedPlayerItem;
    internal System.Collections.Generic.List<ImposterVotedIconCell> 不丆丗丒丆业万丈丁;
    private bool 七七丝丄丛丗不丙七;
    
    // Properties
    public string 丙丑东丁不丄丝七专 { get; }
    
    // Methods
    public string get_TimerLocalization()
    {
        ImposterVoteController val_4;
        string val_5;
        val_4 = this;
        if(this.丒专丈丛下丒一丒丛.万丝一业丝丄不丗业() != false)
        {
                val_5 = "Key_10069";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5 = "Key_10071");
        }
        
        if(this.丒专丈丛下丒一丒丛.丝上业丘万丁业东丅() != false)
        {
                val_5 = "Key_10070";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5);
        }
        
        val_4 = this.丒专丈丛下丒一丒丛;
        if(val_4.万东七下不丆丈东丑() == false)
        {
                return (string)System.String.alignConst;
        }
        
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5);
    }
    private void Awake()
    {
        var val_8;
        UnityEngine.Object val_9;
        val_8 = null;
        val_8 = null;
        if(GameController.onlineMode != null)
        {
                var val_1 = (null == null) ? GameController.onlineMode : 0;
        }
        else
        {
                val_9 = 0;
        }
        
        if(val_9 == 0)
        {
                return;
        }
        
        this.丒专丈丛下丒一丒丛 = 313;
        this.skipBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ImposterVoteUI::HandleSkipButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.confirmSkipBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ImposterVoteUI::HandleConfirmSkipButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.cancelSkipBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ImposterVoteUI::HandleCancelSkipButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        System.Collections.Generic.List<ImposterVotedIconCell> val_6 = new System.Collections.Generic.List<ImposterVotedIconCell>();
        this.不丆丗丒丆业万丈丁 = val_6;
        val_6.Add(item:  this.votedPlayerItem);
        this.votedPlayerItem.gameObject.SetActive(value:  false);
    }
    private void Update()
    {
        this.voteLabel.text = this.TimerLocalization;
        this.voteTimer.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6529"), arg0:  UnityEngine.Mathf.CeilToInt(f:  this.丒专丈丛下丒一丒丛.专丏丞丂东丒丏丐下()));
        this.丞世丕丞丌丑丐专万();
        this.万专丗丏专丏丒丆下();
    }
    private void 万专丗丏专丏丒丆下()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        if(丑丈上东丗丐丆世上() == false)
        {
            goto label_5;
        }
        
        val_6 = this.丒专丈丛下丒一丒丛;
        if(val_6.万丝一业丝丄不丗业() == false)
        {
            goto label_7;
        }
        
        label_5:
        label_11:
        val_6 = this.skipButtonUiButton;
        label_12:
        val_4 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_1F8;
        label_7:
        if((val_4 + 88) == 0)
        {
                val_6 = 0;
        }
        
        if(val_6.丞不丌丗丈丅丌下丄() != 1)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    internal void 丂丏丏东丟下丌三七()
    {
        var val_5;
        this.丁与丗丑万丒丙丟业();
        this.丞世丕丞丌丑丐专万();
        this.votedPlayersGrid.gameObject.SetActive(value:  false);
        val_5 = 0;
        goto label_3;
        label_8:
        this.不丆丗丒丆业万丈丁.Item[0].gameObject.SetActive(value:  false);
        val_5 = 1;
        label_3:
        if(val_5 < this.不丆丗丒丆业万丈丁.Count)
        {
            goto label_8;
        }
    
    }
    internal void 丗丈万丈东且三丅丄(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<与丅丕丈丘东丝世丟>> 且丒丕东丁丗丏业万)
    {
        var val_11;
        var val_12;
        var val_13;
        val_11 = 0;
        goto label_1;
        label_41:
        ImposterVoteCell val_11 = this.voteCells[0];
        if(this.voteCells[0x0][0].丈丌丄世丟下丁丐丞 != null)
        {
                ImposterVoteCell val_12 = this.voteCells[0];
            if(this.voteCells[0x0][0].丈丌丄世丟下丁丐丞.不且上一上丐三万丛 != 0)
        {
                ImposterVoteCell val_13 = this.voteCells[0];
            if(this.voteCells[0x0][0].丈丌丄世丟下丁丐丞.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner != null)
        {
                ImposterVoteCell val_14 = this.voteCells[0];
            if((且丒丕东丁丗丏业万.ContainsKey(key:  this.voteCells[0x0][0].丈丌丄世丟下丁丐丞.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁())) != false)
        {
                ImposterVoteCell val_16 = this.voteCells[0];
            this.voteCells[0].与丏万丅丏丑丆丗丈(丁丟丌专三上丐丕丙:  且丒丕东丁丗丏业万.Item[this.voteCells[0x0][0].丈丌丄世丟下丁丐丞.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁()]);
        }
        
        }
        
        }
        
        }
        
        val_11 = 1;
        label_1:
        if(val_11 < this.voteCells.Length)
        {
            goto label_41;
        }
        
        val_12 = null;
        val_12 = null;
        if((且丒丕东丁丗丏业万.ContainsKey(key:  ImposterVoteController.专丟七上丁世丕且丟)) == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        this.一丞丗丁且丁万丕七(丁丟丌专三上丐丕丙:  且丒丕东丁丗丏业万.Item[ImposterVoteController.专丟七上丁世丕且丟]);
    }
    internal void 一丞丗丁且丁万丕七(System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丁丟丌专三上丐丕丙)
    {
        System.Collections.Generic.List<ImposterVotedIconCell> val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        UnityEngine.Object val_30;
        this.votedPlayersGrid.gameObject.SetActive(value:  true);
        int val_23 = UnityEngine.Mathf.Max(a:  0, b:  丁丟丌专三上丐丕丙.Count - this.不丆丗丒丆业万丈丁.Count);
        if(val_23 >= 1)
        {
                do
        {
            val_23 = this.不丆丗丒丆业万丈丁;
            val_23.Add(item:  不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.votedPlayersGrid.gameObject, 丑且不丕与专丄业丙:  this.votedPlayerItem.gameObject).GetComponent<ImposterVotedIconCell>());
            val_23 = val_23 - 1;
        }
        while(val_23 != 0);
        
        }
        
        val_24 = 1152921526258896048;
        val_25 = 0;
        goto label_15;
        label_52:
        if(val_25 >= 丁丟丌专三上丐丕丙.Count)
        {
            goto label_17;
        }
        
        val_26 = 0;
        goto label_18;
        label_31:
        val_26 = 1;
        label_18:
        val_27 = null;
        val_27 = null;
        if(val_26 >= Count)
        {
            goto label_23;
        }
        
        val_28 = null;
        val_28 = null;
        NetworkStartTable val_12 = Item[1];
        if(val_12.丄丈丑丐丆丞丘与丗.owner != 丁丟丌专三上丐丕丙.Item[0])
        {
            goto label_31;
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = Item[1];
        goto label_36;
        label_17:
        this.不丆丗丒丆业万丈丁.Item[0].gameObject.SetActive(value:  false);
        goto label_49;
        label_23:
        val_30 = 0;
        label_36:
        val_23 = UnityEngine.Object.op_Inequality(x:  val_30, y:  0);
        UnityEngine.GameObject val_20 = this.不丆丗丒丆业万丈丁.Item[0].gameObject;
        if(val_20 == null)
        {
            goto label_45;
        }
        
        if(val_23 == false)
        {
            goto label_46;
        }
        
        label_50:
        val_20.SetActive(value:  true);
        val_24 = 1152921526258896048;
        val_23 = this.不丆丗丒丆业万丈丁.Item[0];
        val_23.业业专丌不业世一丞(不且上一上丐三万丛:  val_30);
        goto label_49;
        label_45:
        if(val_23 == true)
        {
            goto label_50;
        }
        
        label_46:
        val_20.SetActive(value:  false);
        val_24 = 1152921526258896048;
        label_49:
        val_25 = 1;
        label_15:
        if(val_25 < this.不丆丗丒丆业万丈丁.Count)
        {
            goto label_52;
        }
        
        this.七七丝丄丛丗不丙七 = true;
    }
    private void LateUpdate()
    {
        if(this.七七丝丄丛丗不丙七 == false)
        {
                return;
        }
        
        this.七七丝丄丛丗不丙七 = false;
    }
    internal void 丞世丕丞丌丑丐专万()
    {
        var val_5;
        丈万且丗丂丝丙一东 val_11;
        var val_12;
        System.Collections.Generic.List<丈万且丗丂丝丙一东> val_1 = new System.Collections.Generic.List<丈万且丗丂丝丙一东>();
        Dictionary.Enumerator<TKey, TValue> val_2 = this.丒专丈丛下丒一丒丛.imposterMode.上丄丈丙丐丘丙丁与.GetEnumerator();
        val_11 = 1152921525491118128;
        label_6:
        if((199506560 & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        val_1.Add(item:  val_6._value._obj);
        goto label_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_1.Sort(comparison:  new System.Comparison<丈万且丗丂丝丙一东>(object:  0, method:  static System.Int32 ImposterVoteUI::丏与丂东下不丅丂万(丈万且丗丂丝丙一东 三丟东丕丄丄下下丑, 丈万且丗丂丝丙一东 丒丒丄丁且丄丆丂丌)));
        val_12 = 0;
        goto label_13;
        label_26:
        val_11 = this.voteCells[0].gameObject;
        if(val_12 < val_1.Count)
        {
                val_11.SetActive(value:  true);
            val_11 = val_1.Item[0];
            this.voteCells[0].业业专丌不业世一丞(专丞上七七且丝七丗:  val_11);
        }
        else
        {
                val_11.SetActive(value:  false);
        }
        
        val_12 = 1;
        label_13:
        if(val_12 < this.voteCells.Length)
        {
            goto label_26;
        }
    
    }
    internal void 丈丅丄丐丕且丐丝专(丈万且丗丂丝丙一东 专丞上七七且丝七丗, bool 丈丞丞且丑与丗下丅)
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = 43682;
        if((专丞上七七且丝七丗 != null) && (丈丞丞且丑与丗下丅 != true))
        {
                val_6 = 专丞上七七且丝七丗;
            if(val_6.万丌丏丘丂丈丗丅丂() == true)
        {
                return;
        }
        
        }
        
        if(this.丒专丈丛下丒一丒丛 == null)
        {
                val_6 = 0;
        }
        
        if(val_6.丞不丌丗丈丅丌下丄() != 1)
        {
                return;
        }
        
        if(this.丒专丈丛下丒一丒丛.丝上业丘万丁业东丅() == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(丑丈上东丗丐丆世上() == false)
        {
                return;
        }
        
        val_8 = 0;
        goto label_13;
        label_30:
        ImposterVoteCell val_6 = this.voteCells[0];
        if(this.voteCells[0x0][0].丈丌丄世丟下丁丐丞 == null)
        {
            goto label_17;
        }
        
        ImposterVoteCell val_7 = this.voteCells[0];
        if(this.voteCells[0x0][0].丈丌丄世丟下丁丐丞 == 专丞上七七且丝七丗)
        {
            goto label_21;
        }
        
        label_17:
        this.voteCells[0].丒世东专丝业丒丙专();
        goto label_25;
        label_21:
        this.voteCells[0].东且世丌丏丁三丛丅();
        label_25:
        val_8 = 1;
        label_13:
        if(val_8 < this.voteCells.Length)
        {
            goto label_30;
        }
        
        this.confirmSkipContainer.SetActive(value:  丈丞丞且丑与丗下丅);
    }
    internal void 丁与丗丑万丒丙丟业()
    {
        goto label_0;
        label_5:
        this.voteCells[0].丒世东专丝业丒丙专();
        0 = 1;
        label_0:
        if(0 < this.voteCells.Length)
        {
            goto label_5;
        }
        
        this.confirmSkipContainer.SetActive(value:  false);
    }
    internal void 丘丏丁丄丌丕上丁丛(丈万且丗丂丝丙一东 专丞上七七且丝七丗, bool 丈丞丞且丑与丗下丅)
    {
        this.丁与丗丑万丒丙丟业();
        if(丈丞丞且丑与丗下丅 != false)
        {
                this.丒专丈丛下丒一丒丛.丏丒丏世丒丌三丂业();
            return;
        }
        
        if(专丞上七七且丝七丗.不且上一上丐三万丛 == 0)
        {
                return;
        }
        
        this.丒专丈丛下丒一丒丛.且丙与东丞与丐丞专(不且上一上丐三万丛:  专丞上七七且丝七丗.不且上一上丐三万丛);
    }
    private static int 丏与丂东下不丅丂万(丈万且丗丂丝丙一东 三丟东丕丄丄下下丑, 丈万且丗丂丝丙一东 丒丒丄丁且丄丆丂丌)
    {
        var val_1;
        if(三丟东丕丄丄下下丑.专丞专丆丄丛丞三丕 == false)
        {
            goto label_1;
        }
        
        if(丒丒丄丁且丄丆丂丌 != null)
        {
            goto label_3;
        }
        
        goto label_3;
        label_1:
        if(丒丒丄丁且丄丆丂丌.专丞专丆丄丛丞三丕 == true)
        {
            goto label_5;
        }
        
        if(三丟东丕丄丄下下丑.专丞专丆丄丛丞三丕 == false)
        {
            goto label_14;
        }
        
        label_3:
        if(丒丒丄丁且丄丆丂丌.专丞专丆丄丛丞三丕 == false)
        {
            goto label_7;
        }
        
        if(三丟东丕丄丄下下丑.专丞专丆丄丛丞三丕 == false)
        {
            goto label_14;
        }
        
        if((丒丒丄丁且丄丆丂丌.专丞专丆丄丛丞三丕 == false) || (三丟东丕丄丄下下丑.七一一丘下丈专与且 <= 丒丒丄丁且丄丆丂丌.七一一丘下丈专与且))
        {
            goto label_10;
        }
        
        label_5:
        val_1 = 0;
        return (int)val_1;
        label_10:
        if(((三丟东丕丄丄下下丑.专丞专丆丄丛丞三丕 == false) || (丒丒丄丁且丄丆丂丌.专丞专丆丄丛丞三丕 == false)) || (三丟东丕丄丄下下丑.七一一丘下丈专与且 >= 0))
        {
            goto label_14;
        }
        
        label_7:
        val_1 = 1;
        return (int)val_1;
        label_14:
        val_1 = 0;
        return (int)val_1;
    }
    public void HandleSkipButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丈丅丄丐丕且丐丝专(专丞上七七且丝七丗:  0, 丈丞丞且丑与丗下丅:  true);
    }
    public void HandleConfirmSkipButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丘丏丁丄丌丕上丁丛(专丞上七七且丝七丗:  0, 丈丞丞且丑与丗下丅:  true);
    }
    public void HandleCancelSkipButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丁与丗丑万丒丙丟业();
    }
    public ImposterVoteUI()
    {
        this.不丆丗丒丆业万丈丁 = new System.Collections.Generic.List<ImposterVotedIconCell>();
    }

}
