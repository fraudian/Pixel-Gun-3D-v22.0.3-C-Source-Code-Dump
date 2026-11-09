using UnityEngine;
public class ImposterVoteChatUi : PGBehaviour
{
    // Fields
    private 丙下丝丅丝丑丏丁且 丛丄上世丒丝丂丗丑;
    private string 东丛业专丄丒丟万丞;
    private float 七与专丂东丁丁上世;
    private WidgetLayoutBearingWidget _widgetLayout;
    private UIScrollView _scroll;
    private UnityEngine.GameObject _myMessagePrefab;
    private UnityEngine.GameObject _notMyMessagePrefab;
    private UIInputRilisoft _textInput;
    private UnityEngine.GameObject _ghostChatInfoObject;
    private UnityEngine.GameObject _smilesPanel;
    private UnityEngine.GameObject _smilesButton;
    private SmilesPanelUi _smilesPanelUi;
    private UIButton _sendMessageButton;
    private UILabel _sendButtonTimer;
    private readonly System.Collections.Generic.List<UnityEngine.GameObject> 丝世丆丈三三丙东万;
    private readonly System.Collections.Generic.List<丆与七世东不东丂丙> 上丑不丐且丑丑丄丂;
    
    // Methods
    internal void 丌万丗与七丄丕不丁(丙下丝丅丝丑丏丁且 丟丞丄万丂丗丟丆七)
    {
        var val_10;
        this.丛丄上世丒丝丂丗丑 = 丟丞丄万丂丗丟丆七;
        丟丞丄万丂丗丟丆七.丞一丙丈丘丕丐丑上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ImposterVoteChatUi::丈丂丝丌丆丘下丛丁()));
        this.七与专丂东丁丁上世 = -1f;
        this.东丛业专丄丒丟万丞 = System.String.alignConst;
        this._smilesPanelUi.add_OnSmileClicked(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ImposterVoteChatUi::丕丐万丄丟丏专三万(string 丗丕万丕丌丈丈丒丕)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._myMessagePrefab, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notMyMessagePrefab, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._smilesButton, 丏业丟一东丂东丘丛:  StickersController.不丕丗且丝与七丗丒());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._sendButtonTimer, 丏业丟一东丂东丘丛:  false);
        this._widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
        this._textInput.value = System.String.alignConst;
        this._textInput.defaultText = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1481");
        NetworkStartTable val_7 = this._textInput.丆三丗专丕丄与丏与();
        if(val_7 != 0)
        {
                val_10 = (~val_7.丑丈上东丗丐丆世上()) & 1;
        }
        else
        {
                val_10 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._ghostChatInfoObject, 丏业丟一东丂东丘丛:  false);
        this.丈丂丝丌丆丘下丛丁();
    }
    private void 丕丐万丄丟丏专三万(string 丗丕万丕丌丈丈丒丕)
    {
        var val_3;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丗丕万丕丌丈丈丒丕)) != false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        this.与丒七丏丕不丂丁三(丄丙下丝丛丒七丂丘:  与丂丏丛丞丞丒丟丄.丏三丒丄东丟丈丙丄 + 丗丕万丕丌丈丈丒丕);
        this.U_CloseSmiles();
    }
    private void 丟世丐丞丝丙丒丌专()
    {
        this._widgetLayout.Reposition();
        this._scroll.ResetPosition();
    }
    private void 丈丂丝丌丆丘下丛丁()
    {
        var val_30;
        System.Func<丆与七世东不东丂丙, System.Double> val_32;
        UnityEngine.Object val_36;
        var val_37;
        var val_38;
        ImposterVoteChatUi.业丂七丏丟丕丌丂世 val_1 = new ImposterVoteChatUi.业丂七丏丟丕丌丂世();
        val_30 = null;
        val_30 = null;
        val_32 = ImposterVoteChatUi.<>c.<>9__19_0;
        if(val_32 == null)
        {
                System.Func<丆与七世东不东丂丙, System.Double> val_3 = null;
            val_32 = val_3;
            val_3 = new System.Func<丆与七世东不东丂丙, System.Double>(object:  ImposterVoteChatUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Double ImposterVoteChatUi.<>c::丈丏丆丆丑丘丄丏三(丆与七世东不东丂丙 三丟东丕丄丄下下丑));
            ImposterVoteChatUi.<>c.<>9__19_0 = val_32;
        }
        
        丆与七世东不东丂丙 val_5 = System.Linq.Enumerable.LastOrDefault<丆与七世东不东丂丙>(source:  this.上丑不丐且丑丑丄丂);
        if(val_5 == null)
        {
            goto label_7;
        }
        
        if(val_1 != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        .且三丞丅丄世丄丑丏 = val_5.丝丗专上三不丄丑丑();
        var val_33 = 0;
        val_33 = val_33 + 1;
        goto label_13;
        label_7:
        if(val_1 != null)
        {
            goto label_14;
        }
        
        goto label_15;
        label_13:
        System.Collections.Generic.IEnumerator<T> val_10 = System.Linq.Enumerable.Where<丆与七世东不东丂丙>(source:  System.Linq.Enumerable.OrderBy<丆与七世东不东丂丙, System.Double>(source:  this.丛丄上世丒丝丂丗丑.丘丅与且丞专上万丝(), keySelector:  val_3), predicate:  new System.Func<丆与七世东不东丂丙, System.Boolean>(object:  val_1, method:  System.Boolean ImposterVoteChatUi.业丂七丏丟丕丌丂世::丙丌丘专丁七下丕丂(丆与七世东不东丂丙 三丟东丕丄丄下下丑))).GetEnumerator();
        label_58:
        var val_34 = 0;
        val_34 = val_34 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_21;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        T val_14 = val_10.Current;
        NetworkStartTable val_15 = val_14.与丁丞丗丆下下专丝();
        if(val_15.丌且下丕下下丌万丞 != false)
        {
                val_36 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._myMessagePrefab, 丈东丘丏与丌东东下:  this._widgetLayout.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        else
        {
                val_36 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._notMyMessagePrefab, 丈东丘丏与丌东东下:  this._widgetLayout.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        
        if(val_36 == 0)
        {
            goto label_58;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_36, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector3 val_22 = val_36.transform.localPosition;
        val_36.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        val_36.name = System.String.Format(format:  "messageGO_{0:D4}", arg0:  this.丝世丆丈三三丙东万.Count);
        ImposterVoteChatMessageUi val_26 = val_36.GetComponent<ImposterVoteChatMessageUi>();
        if(val_26 == 0)
        {
            goto label_58;
        }
        
        val_26.一丞一丝丘丕且丒丆(丄丅七一丞丟丅丘世:  val_14);
        this.丝世丆丈三三丙东万.Add(item:  val_36);
        this.上丑不丐且丑丑丄丂.Add(item:  val_14);
        this._widgetLayout.AddElement(丞丂三且三七丈丗丘:  val_26.丕不三丝专丐丁专与(), 丅丆东丏丙丝丅丆丟:  val_26.丅与丌专丟一丝业三());
        goto label_58;
        label_21:
        val_37 = 0;
        val_38 = 0;
        if(val_10 == null)
        {
            
        }
        else
        {
                var val_36 = 0;
            val_36 = val_36 + 1;
            val_10.Dispose();
        }
        
        UnityEngine.Coroutine val_32 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  1f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void ImposterVoteChatUi::丟世丐丞丝丙丒丌专()));
    }
    private void OnDisable()
    {
        if(this.丛丄上世丒丝丂丗丑 != null)
        {
                this.丛丄上世丒丝丂丗丑.丌丆丄丁丑丑丗三万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ImposterVoteChatUi::丈丂丝丌丆丘下丛丁()));
        }
        
        this._smilesPanelUi.remove_OnSmileClicked(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ImposterVoteChatUi::丕丐万丄丟丏专三万(string 丗丕万丕丌丈丈丒丕)));
    }
    public void Close()
    {
        if(this.丛丄上世丒丝丂丗丑 == null)
        {
                return;
        }
        
        this.丛丄上世丒丝丂丗丑.不七丅丙丏上丛丒丗();
    }
    public void U_OnInputTextSubmit()
    {
        this.与丒七丏丕不丂丁三(丄丙下丝丛丒七丂丘:  this._textInput.value);
        this._textInput.value = System.String.alignConst;
    }
    private void 与丒七丏丕不丂丁三(string 丄丙下丝丛丒七丂丘)
    {
        if(this.七与专丂东丁丁上世 > 0f)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄丙下丝丛丒七丂丘)) != false)
        {
                return;
        }
        
        string val_3 = 丄丙下丝丛丒七丂丘.Trim(trimChars:  new char[3]);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3)) == false)
        {
            goto label_8;
        }
        
        System.Collections.IEnumerator val_5 = this.七丝丁丁丗丅丙丒丐();
        goto label_9;
        label_8:
        if((System.String.op_Equality(a:  val_3, b:  this.东丛业专丄丒丟万丞)) == false)
        {
            goto label_10;
        }
        
        label_9:
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.下丁丛丝丈三丂丞专());
        this._textInput.RemoveFocus();
        return;
        label_10:
        this.丛丄上世丒丝丂丗丑.丆丘丟且一丕丏世丒(丕丗丘丑丛与丑业丒:  val_3);
        this.东丛业专丄丒丟万丞 = val_3;
        this.七与专丂东丁丁上世 = 2f;
    }
    private System.Collections.IEnumerator 七丝丁丁丗丅丙丒丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ImposterVoteChatUi.丂丅与丌不与七丙丘();
    }
    private System.Collections.IEnumerator 下丁丛丝丈三丂丞专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ImposterVoteChatUi.七东丅上专一丒丑下();
    }
    private NetworkStartTable 丆三丗专丕丄与丏与()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = 0;
        goto label_1;
        label_23:
        val_10 = null;
        val_10 = null;
        NetworkStartTable val_1 = Item[0];
        if(val_1.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_8;
        }
        
        val_11 = null;
        val_11 = null;
        NetworkStartTable val_3 = Item[0];
        if((val_3.丄丈丑丐丆丞丘与丗.owner.Equals(丘丛丏丘丝七世七丅:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())) == true)
        {
            goto label_18;
        }
        
        label_8:
        val_9 = 1;
        label_1:
        val_12 = null;
        val_12 = null;
        if(val_9 < Count)
        {
            goto label_23;
        }
        
        val_13 = 0;
        return (NetworkStartTable)Item[0];
        label_18:
        val_14 = null;
        val_14 = null;
        return (NetworkStartTable)Item[0];
    }
    public void U_SmileClick()
    {
        if(StickersController.不丕丗且丝与七丗丒() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._smilesPanel, 丏业丟一东丂东丘丛:  true);
    }
    public void U_CloseSmiles()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._smilesPanel, 丏业丟一东丂东丘丛:  false);
    }
    public void U_OpenSmilesShop()
    {
    
    }
    private void Update()
    {
        this.丝丕丛丞丏三与下万();
        this.丛下七丝丆下丗下丁();
        if(this.七与专丂东丁丁上世 <= (-1f))
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = this.七与专丂东丁丁上世 - val_1;
        this.七与专丂东丁丁上世 = val_1;
    }
    private void 丛下七丝丆下丗下丁()
    {
        if(this.七与专丂东丁丁上世 > 0f)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._sendButtonTimer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._sendButtonTimer, 丕丗丘丑丛与丑业丒:  System.Math.Min(val1:  (int)this.七与专丂东丁丁上世 + 1, val2:  2));
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._sendButtonTimer, 丏业丟一东丂东丘丛:  false);
    }
    private void 丝丕丛丞丏三与下万()
    {
        if(this.七与专丂东丁丁上世 > 0f)
        {
            
        }
    
    }
    public ImposterVoteChatUi()
    {
        this.丝世丆丈三三丙东万 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.上丑不丐且丑丑丄丂 = new System.Collections.Generic.List<丆与七世东不东丂丙>();
    }

}
