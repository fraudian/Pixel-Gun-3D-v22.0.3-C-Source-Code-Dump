using UnityEngine;
internal sealed class RewardETControllerUi : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _generalPanelGo;
    private UILabel _scoreHeaderLabel;
    private UnityEngine.GameObject _goldCont;
    private UILabel _goldLabel;
    private UnityEngine.GameObject _greenCont;
    private UILabel _greenLabel;
    private UnityEngine.GameObject _redCont;
    private UILabel _redLabel;
    private WidgetLayout _widgetLayout;
    private string _locKeyPlaceHeader;
    private OfferItemView _offerItemViewPrefab;
    private System.Collections.Generic.List<OfferItemView> 丑丘七丄万丐三下世;
    private System.Collections.Generic.List<LeaderboardEventController.RewardParameters> 丘丞丘丘一下丌上七;
    private UnityEngine.Coroutine 丅东三丒且丅丄丐丒;
    
    // Methods
    private void Awake()
    {
        LeaderboardEventController.丂且丁世一不丈丑丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RewardETControllerUi::丘上丐世丆丑且丞丒()));
        LeaderboardEventController.丆业丑三一丝丒一丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RewardETControllerUi::丘上丐世丆丑且丞丒()));
        OfferItemView.丂东东丌世与与上丛(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void RewardETControllerUi::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
        OfferItemView.万万且丞与万业丈丌(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void RewardETControllerUi::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
        this._generalPanelGo.SetActive(value:  false);
        this.丘上丐世丆丑且丞丒();
    }
    internal bool 丑且丁丄丛丐一丌三()
    {
        var val_7;
        MainMenuController val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_7 = null;
        val_7 = null;
        val_8 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_8 == 0)
        {
            goto label_34;
        }
        
        val_9 = null;
        val_9 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.connectScene == 0)
        {
            goto label_11;
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 560];
        val_8 = MainMenuController.丄丞丁丈与业上丞丟.connectScene;
        if(activeInHierarchy == true)
        {
            goto label_16;
        }
        
        label_11:
        val_11 = null;
        val_11 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.世丆丂上丛丈丅丘东 == 0)
        {
            goto label_27;
        }
        
        val_12 = null;
        val_12 = null;
        val_8 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 568];
        val_8 = MainMenuController.丄丞丁丈与业上丞丟.世丆丂上丛丈丅丘东;
        if(activeInHierarchy == false)
        {
            goto label_27;
        }
        
        label_16:
        val_13 = 1;
        return (bool)val_13;
        label_27:
        val_14 = null;
        val_14 = null;
        val_8 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
        val_8 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
        if(val_8 != 0)
        {
                val_15 = null;
            val_15 = null;
            if(null != 0)
        {
                return activeInHierarchy;
        }
        
            return activeInHierarchy;
        }
        
        label_34:
        val_13 = 0;
        return (bool)val_13;
    }
    private void OnDestroy()
    {
        LeaderboardEventController.丂且丁世一不丈丑丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RewardETControllerUi::丘上丐世丆丑且丞丒()));
        OfferItemView.丂东东丌世与与上丛(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void RewardETControllerUi::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
        if(this.丅东三丒且丅丄丐丒 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.丅东三丒且丅丄丐丒);
        this.丅东三丒且丅丄丐丒 = 0;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        if(this._generalPanelGo.activeSelf == true)
        {
                return;
        }
        
        if(this.丅东三丒且丅丄丐丒 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丅东三丒且丅丄丐丒);
        }
        
        this.丅东三丒且丅丄丐丒 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丈丙丐丑与丞丆丌丁());
    }
    private System.Collections.IEnumerator 丈丙丐丑与丞丆丌丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RewardETControllerUi.且专丞丁丂丅东上丝();
    }
    public void Show()
    {
        UnityEngine.GameObject val_9;
        var val_10;
        if((this.丘丞丘丘一下丌上七 == null) || (this.丘丞丘丘一下丌上七.Count == 0))
        {
            goto label_2;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  174);
        if((this.丘丌丄万丞一万丐丅(丑丁专世丛丏上丂不:  this.丘丞丘丘一下丌上七.Item[0])) == false)
        {
            goto label_7;
        }
        
        LeaderboardEventController.丑丐丄丆丛丁丟丗丅.丗万业不丛与丕丟丒(丟丟丄专上丟丁丐丝:  val_2.EventId);
        System.Collections.Generic.List<System.Int32> val_6 = new System.Collections.Generic.List<System.Int32>();
        val_6.Add(item:  val_2.EventId);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万业专不下丅三上专(丒丐业丐丌东丑不丌:  val_6);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        val_9 = this._generalPanelGo;
        val_10 = 1;
        goto label_16;
        label_2:
        val_9 = this._generalPanelGo;
        val_10 = 0;
        label_16:
        val_9.SetActive(value:  false);
        return;
        label_7:
        this._generalPanelGo.SetActive(value:  false);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private bool 丘丌丄万丞一万丐丅(LeaderboardEventController.RewardParameters 丑丁专世丛丏上丂不)
    {
        UILabel val_21;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_22;
        val_21 = this._scoreHeaderLabel;
        val_21.text = System.String.Format(format:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_7949"), arg0:  丑丁专世丛丏上丂不.Score);
        val_22 = 丑丁专世丛丏上丂不.RewardConfig;
        if(val_22 == null)
        {
                return (bool)val_22;
        }
        
        if((val_22.ContainsKey(key:  "type")) != false)
        {
                val_21 = 丑丁专世丛丏上丂不.RewardConfig;
            if((val_21.ContainsKey(key:  "value")) != false)
        {
                System.Collections.Generic.List<PGCompany.GameModeEvents.丙丄丅一丒丒丗丗七> val_5 = new System.Collections.Generic.List<PGCompany.GameModeEvents.丙丄丅一丒丒丗丗七>();
            val_21 = 丑丁专世丛丏上丂不.RewardConfig;
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丕丁丕丆世丆丌一丂(丞世丏业且世丝丐丈:  val_21, 与世丗且丟丁不专丏:  new System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈>() {HasValue = false}, 丟丟丄专上丟丁丐丝:  丑丁专世丛丏上丂不.EventId, 上业丟世三与七七三: ref  0, 丛丂东一丕丙三上与: ref  val_5);
            val_22 = val_5;
            if(val_22 == 0)
        {
                return (bool)val_22;
        }
        
            if(val_5.Count == 0)
        {
                return (bool)val_22;
        }
        
            val_21 = val_5.Item[0];
            if(val_21.三丛丗丛业不丂丐且() == null)
        {
                return (bool)val_22;
        }
        
            val_21 = val_5.Item[0].三丛丗丛业不丂丐且();
            val_22 = val_21;
            if(val_22.Count == 0)
        {
                return (bool)val_22;
        }
        
            PGCompany.Analytics.一业丗丆世世上丁且.丄丄三丌丐丛与丙丕(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 三专七丗且专丞专丟:  丑丁专世丛丏上丂不.Place, 丏万业与丈丗丝丝且:  PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.三丗丈丄丏丂丁丆下(丆业丗丁丕且上下丙:  丑丁专世丛丏上丂不.EventId), 丘丏丝不一丈丐丕丝:  val_5.Item[0].三丛丗丛业不丂丐且());
            this.丂丕丟丞且丛业三不(丛丂东一丕丙三上与:  val_5, 且丒丛与丞世丙丕丌:  丑丁专世丛丏上丂不.Place);
            val_21 = val_5.Item[0];
            this.东丆丞东一丕丒东东(万丘丁丏丛丏业丘丑:  val_21.三丛丗丛业不丂丐且());
            System.Collections.Generic.List<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗> val_20 = val_5.Item[0].三丛丗丛业不丂丐且();
            val_20.丛丆世丏丒丕丅丁东(万丘丁丏丛丏业丘丑:  val_20);
            PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.且丆丂丒丙专丐丒与(丑丐丗三丒世丏东丅:  丑丁专世丛丏上丂不.EventId);
            PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.丂丈与丙丑专东丟下(丑丐丗三丒世丏东丅:  丑丁专世丛丏上丂不.EventId);
            val_22 = 1;
            return (bool)val_22;
        }
        
        }
        
        val_22 = 0;
        return (bool)val_22;
    }
    private void 丂丕丟丞且丛业三不(System.Collections.Generic.List<PGCompany.GameModeEvents.丙丄丅一丒丒丗丗七> 丛丂东一丕丙三上与, int 且丒丛与丞世丙丕丌)
    {
        UILabel val_3;
        int val_1 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.丑世丄丒丌东下丑丙(丛丂东一丕丙三上与:  丛丂东一丕丙三上与, 且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
        if(val_1 == 1)
        {
            goto label_3;
        }
        
        if(val_1 != 0)
        {
            goto label_4;
        }
        
        this._goldCont.SetActive(value:  true);
        this._greenCont.SetActive(value:  false);
        this._redCont.SetActive(value:  false);
        val_3 = this._goldLabel;
        goto label_12;
        label_3:
        this._goldCont.SetActive(value:  false);
        this._greenCont.SetActive(value:  true);
        this._redCont.SetActive(value:  false);
        val_3 = this._greenLabel;
        goto label_12;
        label_4:
        this._goldCont.SetActive(value:  false);
        this._greenCont.SetActive(value:  false);
        this._redCont.SetActive(value:  true);
        val_3 = this._redLabel;
        label_12:
        val_3.text = 且丒丛与丞世丙丕丌.ToString();
    }
    private void 丛丆世丏丒丕丅丁东(System.Collections.Generic.List<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗> 万丘丁丏丛丏业丘丑)
    {
        List.Enumerator<T> val_1 = 万丘丁丏丛丏业丘丑.GetEnumerator();
        label_6:
        if(((-1782434456) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2.丂丑丞丝且万丐万丟() == null)
        {
            goto label_6;
        }
        
        丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_2.丂丑丞丝且万丐万丟(), 丁且丟不七下丆丒丟:  true, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  false, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  36, 不丐丅丁丂七丐丘丛:  0, 丁七丐丁丙丄丙不东:  false);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 东丆丞东一丕丒东东(System.Collections.Generic.List<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗> 万丘丁丏丛丏业丘丑)
    {
        var val_9;
        this.丑一丘丁丌丛三丙丄(丌丒丝东丌下丕丁丅:  万丘丁丏丛丏业丘丑.Count);
        val_9 = 0;
        goto label_2;
        label_13:
        if(万丘丁丏丛丏业丘丑.Item[0] != null)
        {
                this.丑丘七丄万丐三下世.Item[0].gameObject.SetActive(value:  true);
            this.丑丘七丄万丐三下世.Item[0].Setup(与且专丈不万东一万:  万丘丁丏丛丏业丘丑.Item[0].丂丑丞丝且万丐万丟());
        }
        
        val_9 = 1;
        label_2:
        if(val_9 < 万丘丁丏丛丏业丘丑.Count)
        {
            goto label_13;
        }
        
        this._widgetLayout.CollectWidgets();
        this._widgetLayout.Reposition();
    }
    private void 丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)
    {
        if(丆万丞丅专三丟丄下 == 0)
        {
                return;
        }
        
        if(丆万丞丅专三丟丄下.Context == null)
        {
                return;
        }
        
        if((this.丑丘七丄万丐三下世.Contains(item:  丆万丞丅专三丟丄下)) == false)
        {
                return;
        }
        
        if(丆万丞丅专三丟丄下.Context.Type == 1130)
        {
                return;
        }
        
        Rilisoft.ItemViewer val_8 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丏且丕丄丁丟丆丏丁:  丆万丞丅专三丟丄下.Context, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
    }
    private void 丑一丘丁丌丛三丙丄(int 丌丒丝东丌下丕丁丅)
    {
        int val_15;
        System.Collections.Generic.List<OfferItemView> val_16;
        System.Collections.Generic.List<OfferItemView> val_17;
        var val_18;
        WidgetLayout val_19;
        val_15 = 丌丒丝东丌下丕丁丅;
        if(this.丑丘七丄万丐三下世.Count <= val_15)
        {
            goto label_2;
        }
        
        goto label_3;
        label_8:
        this.丑丘七丄万丐三下世.Item[val_15].gameObject.SetActive(value:  false);
        val_15 = val_15 + 1;
        label_3:
        val_16 = this.丑丘七丄万丐三下世;
        if(val_15 < val_16.Count)
        {
            goto label_8;
        }
        
        return;
        label_2:
        val_16 = this.丑丘七丄万丐三下世;
        if(val_16.Count >= val_15)
        {
                return;
        }
        
        val_17 = this.丑丘七丄万丐三下世;
        val_18 = val_15 - val_17.Count;
        if(val_18 > 0)
        {
                val_19 = this._widgetLayout;
            do
        {
            OfferItemView val_8 = UnityEngine.Object.Instantiate<OfferItemView>(original:  this._offerItemViewPrefab, parent:  this._widgetLayout.transform);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            val_8.transform.rotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            this.丑丘七丄万丐三下世.Add(item:  val_8);
            val_17 = mem[this._widgetLayout];
            val_17.AddElement(世丌丌丙丞丟下东丞:  val_8.丁丏世七三丗与丏与());
            val_18 = val_18 - 1;
        }
        while(val_18 != 0);
        
        }
        else
        {
                val_19 = this._widgetLayout;
        }
        
        mem[this._widgetLayout].Reposition();
    }
    public RewardETControllerUi()
    {
        this.丑丘七丄万丐三下世 = new System.Collections.Generic.List<OfferItemView>();
    }

}
