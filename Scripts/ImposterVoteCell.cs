using UnityEngine;
public sealed class ImposterVoteCell : MonoBehaviour
{
    // Fields
    public UILabel playerName;
    public UITextureMasked playerTexture;
    public UnityEngine.GameObject lsObj;
    public UnityEngine.GameObject voteObj;
    public UnityEngine.GameObject traitorObj;
    public UnityEngine.GameObject killedObj;
    public UnityEngine.GameObject voteBtnsContainer;
    public UnityEngine.GameObject disabledObj;
    public UIGrid votedPlayersGrid;
    public ImposterVotedIconCell votedPlayerItem;
    public Rilisoft.ButtonHandler voteBtn;
    public Rilisoft.ButtonHandler okVoteBtn;
    public Rilisoft.ButtonHandler cancelVoteBtn;
    public UnityEngine.Color defaulNameColor;
    public UnityEngine.Color imposterNameColor;
    public UnityEngine.Color mineNameColor;
    internal 丈万且丗丂丝丙一东 丈丌丄世丟下丁丐丞;
    internal System.Collections.Generic.List<ImposterVotedIconCell> 丕丅丌丅三丁丈三丗;
    private ImposterVoteUI 东东且三丝丛丌三丏;
    private string 丞三丗丕七丄不丞业;
    private bool 丝与丆丞东丘丈东丘;
    private 丈万且丗丂丝丙一东 丏丆丆丙丆丞丛丁且;
    private bool 七七丝丄丛丗不丙七;
    
    // Methods
    private void Start()
    {
        if(this.丝与丆丞东丘丈东丘 != false)
        {
                return;
        }
        
        this.上丛丌丆丑上七世三();
    }
    private void 上丛丌丆丑上七世三()
    {
        this.丝与丆丞东丘丈东丘 = true;
        this.voteBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ImposterVoteCell::HandleVoteButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.okVoteBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ImposterVoteCell::HandleConfirmVoteButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.cancelVoteBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ImposterVoteCell::HandleCancelVoteButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.东东且三丝丛丌三丏 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丗一三丒丄丄一丙丅();
        System.Collections.Generic.List<ImposterVotedIconCell> val_5 = new System.Collections.Generic.List<ImposterVotedIconCell>();
        this.丕丅丌丅三丁丈三丗 = val_5;
        val_5.Add(item:  this.votedPlayerItem);
        this.votedPlayerItem.gameObject.SetActive(value:  false);
    }
    internal void 业业专丌不业世一丞(丈万且丗丂丝丙一东 专丞上七七且丝七丗)
    {
        var val_42;
        var val_43;
        NetworkStartTable val_44;
        var val_45;
        var val_46;
        UnityEngine.GameObject val_47;
        bool val_48;
        bool val_49;
        UnityEngine.Color val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        if(this.丝与丆丞东丘丈东丘 != true)
        {
                this.上丛丌丆丑上七世三();
        }
        
        if(this.东东且三丝丛丌三丏.丒专丈丛下丒一丒丛.万东七下不丆丈东丑() != false)
        {
                if(this.丏丆丆丙丆丞丛丁且 == 专丞上七七且丝七丗)
        {
            goto label_5;
        }
        
        }
        
        this.votedPlayersGrid.gameObject.SetActive(value:  false);
        val_42 = 1152921526258896048;
        val_43 = 0;
        goto label_8;
        label_13:
        this.丕丅丌丅三丁丈三丗.Item[0].gameObject.SetActive(value:  false);
        val_43 = 1;
        label_8:
        if(val_43 < this.丕丅丌丅三丁丈三丗.Count)
        {
            goto label_13;
        }
        
        label_5:
        this.丈丌丄世丟下丁丐丞 = 专丞上七七且丝七丗;
        this.traitorObj.SetActive(value:  false);
        this.lsObj.SetActive(value:  false);
        this.playerName.text = 专丞上七七且丝七丗.丒丘丏上丙丟丑丕丈;
        if((System.String.op_Inequality(a:  this.丞三丗丕七丄不丞业, b:  专丞上七七且丝七丗.与丟丅七丞且且丛丕)) != false)
        {
                this.丞三丗丕七丄不丞业 = 专丞上七七且丝七丗.与丟丅七丞且且丛丕;
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.playerTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/{0}_icon1_big", arg0:  专丞上七七且丝七丗.与丟丅七丞且且丛丕)));
        }
        
        if(专丞上七七且丝七丗.万丌丏丘丂丈丗丅丂() != false)
        {
                if(this.voteBtnsContainer.activeSelf != false)
        {
                this.丒世东专丝业丒丙专();
        }
        
        }
        
        val_44 = 专丞上七七且丝七丗.不且上一上丐三万丛;
        if(val_44 == 0)
        {
            goto label_26;
        }
        
        val_44 = 专丞上七七且丝七丗.万丌丏丘丂丈丗丅丂();
        val_45 = null;
        val_45 = null;
        if(丟东丘丏上世且上丕() == false)
        {
            goto label_31;
        }
        
        val_46 = 专丞上七七且丝七丗.不且上一上丐三万丛.丟东丘丏上世且上丕();
        goto label_33;
        label_26:
        this.lsObj.SetActive(value:  false);
        this.traitorObj.SetActive(value:  false);
        this.voteObj.SetActive(value:  false);
        this.killedObj.SetActive(value:  true);
        val_47 = this.disabledObj;
        val_48 = 1;
        goto label_72;
        label_31:
        val_46 = 0;
        label_33:
        bool val_15 = val_44;
        this.killedObj.SetActive(value:  val_15);
        if(val_15 == false)
        {
            goto label_41;
        }
        
        val_49 = 1;
        if(this.disabledObj != null)
        {
            goto label_46;
        }
        
        goto label_43;
        label_41:
        val_49 = this.东东且三丝丛丌三丏.丒专丈丛下丒一丒丛.万丝一业丝丄不丗业();
        if(this.disabledObj != null)
        {
            goto label_46;
        }
        
        label_43:
        label_46:
        this.disabledObj.SetActive(value:  val_49);
        if(val_46 != 0)
        {
                val_50 = this.imposterNameColor;
            val_51 = 1152921526259180292;
            val_52 = 1152921526259180296;
            val_53 = 1152921526259180300;
        }
        else
        {
                if(专丞上七七且丝七丗.丟丌下三七丁与丟丑() != false)
        {
                val_50 = this.mineNameColor;
            val_51 = 1152921526259180308;
            val_52 = 1152921526259180312;
            val_53 = 1152921526259180316;
        }
        else
        {
                val_50 = this.defaulNameColor;
            val_51 = 1152921526259180276;
            val_52 = 1152921526259180280;
            val_53 = 1152921526259180284;
        }
        
        }
        
        this.playerName.color = new UnityEngine.Color() {r = this.defaulNameColor.r, g = 3.184645E-22f, b = 3.184645E-22f, a = 3.184645E-22f};
        if(专丞上七七且丝七丗.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_61;
        }
        
        val_54 = null;
        val_54 = null;
        if((专丞上七七且丝七丗.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丑上丐且丟丂东丐丅)) == false)
        {
            goto label_61;
        }
        
        val_55 = null;
        val_55 = null;
        object val_24 = 专丞上七七且丝七丗.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆().Item[GameConnect.丑上丐且丟丂东丐丅];
        goto label_68;
        label_61:
        val_42 = 0;
        label_68:
        this.voteObj.SetActive(value:  (val_42 != 1) ? 1 : 0);
        if(val_44 == false)
        {
            goto label_70;
        }
        
        val_47 = this.lsObj;
        val_48 = 0;
        goto label_72;
        label_70:
        val_56 = null;
        val_56 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丙世丁丆丆丗一丞丈)) != false)
        {
                val_57 = null;
            val_57 = null;
            object val_31 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丙世丁丆丆丗一丞丈];
        }
        else
        {
                val_42 = 0;
        }
        
        if(专丞上七七且丝七丗.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_89;
        }
        
        if(this.lsObj != null)
        {
            goto label_103;
        }
        
        label_104:
        label_103:
        val_58 = this.lsObj;
        val_58.SetActive(value:  (专丞上七七且丝七丗.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁() == val_42) ? 1 : 0);
        if(this.东东且三丝丛丌三丏 == null)
        {
                val_58 = 0;
        }
        
        if(this.东东且三丝丛丌三丏.丒专丈丛下丒一丒丛 == null)
        {
                val_58 = 0;
        }
        
        val_47 = this.traitorObj;
        val_44 = val_58.丞不丌丗丈丅丌下丄();
        if(专丞上七七且丝七丗.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_98;
        }
        
        if(val_47 != null)
        {
            goto label_105;
        }
        
        label_106:
        label_105:
        val_48 = (专丞上七七且丝七丗.不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁() == val_44) ? 1 : 0;
        label_72:
        val_47.SetActive(value:  val_48);
        return;
        label_89:
        if(this.lsObj != null)
        {
            goto label_103;
        }
        
        goto label_104;
        label_98:
        if(val_47 != null)
        {
            goto label_105;
        }
        
        goto label_106;
    }
    internal void 与丏万丅丏丑丆丗丈(System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丁丟丌专三上丐丕丙)
    {
        System.Collections.Generic.List<ImposterVotedIconCell> val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        UnityEngine.Object val_30;
        this.丏丆丆丙丆丞丛丁且 = this.丈丌丄世丟下丁丐丞;
        this.votedPlayersGrid.gameObject.SetActive(value:  true);
        int val_23 = UnityEngine.Mathf.Max(a:  0, b:  丁丟丌专三上丐丕丙.Count - this.丕丅丌丅三丁丈三丗.Count);
        if(val_23 >= 1)
        {
                do
        {
            val_23 = this.丕丅丌丅三丁丈三丗;
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
        this.丕丅丌丅三丁丈三丗.Item[0].gameObject.SetActive(value:  false);
        goto label_49;
        label_23:
        val_30 = 0;
        label_36:
        val_23 = UnityEngine.Object.op_Inequality(x:  val_30, y:  0);
        UnityEngine.GameObject val_20 = this.丕丅丌丅三丁丈三丗.Item[0].gameObject;
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
        val_23 = this.丕丅丌丅三丁丈三丗.Item[0];
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
        if(val_25 < this.丕丅丌丅三丁丈三丗.Count)
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
    public void HandleVoteButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.东东且三丝丛丌三丏.丈丅丄丐丕且丐丝专(专丞上七七且丝七丗:  this.丈丌丄世丟下丁丐丞, 丈丞丞且丑与丗下丅:  false);
    }
    public void HandleConfirmVoteButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.东东且三丝丛丌三丏.丘丏丁丄丌丕上丁丛(专丞上七七且丝七丗:  this.丈丌丄世丟下丁丐丞, 丈丞丞且丑与丗下丅:  false);
    }
    public void HandleCancelVoteButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.东东且三丝丛丌三丏.丁与丗丑万丒丙丟业();
    }
    internal void 东且世丌丏丁三丛丅()
    {
        this.voteBtnsContainer.SetActive(value:  true);
    }
    internal void 丒世东专丝业丒丙专()
    {
        this.voteBtnsContainer.SetActive(value:  false);
    }
    public ImposterVoteCell()
    {
        this.丞三丗丕七丄不丞业 = System.String.alignConst;
    }

}
