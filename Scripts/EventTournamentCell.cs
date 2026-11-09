using UnityEngine;
internal class EventTournamentCell : EndlessScrollCellDynamic
{
    // Fields
    private UIGrid _revardGrid;
    private UIGrid _playerScoreCellsGrid;
    private PlayerScoreUi _prefabPlayerScoreUi;
    private OfferItemView _prefabReward;
    private UnityEngine.GameObject _rewardBoxGo;
    private UIWidget _rewardContainerWidget;
    private UIWidget _playerScoresContainerWidget;
    private System.Collections.Generic.List<PlayerScoreUi> 业下丞专丂丑上且万;
    private System.Collections.Generic.List<OfferItemView> 丑丘七丄万丐三下世;
    
    // Methods
    private void Awake()
    {
        OfferItemView.丂东东丌世与与上丛(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void EventTournamentCell::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
        OfferItemView.万万且丞与万业丈丌(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void EventTournamentCell::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
    }
    private void OnDestroy()
    {
        OfferItemView.丂东东丌世与与上丛(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void EventTournamentCell::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
    }
    private void 丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)
    {
        if(丆万丞丅专三丟丄下 == 0)
        {
                return;
        }
        
        if((this.丑丘七丄万丐三下世.Contains(item:  丆万丞丅专三丟丄下)) == false)
        {
                return;
        }
        
        if(丆万丞丅专三丟丄下.Context == null)
        {
                return;
        }
        
        if(丆万丞丅专三丟丄下.Context.Type == 1130)
        {
                return;
        }
        
        Rilisoft.ItemViewer val_8 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丏且丕丄丁丟丆丏丁:  丆万丞丅专三丟丄下.Context, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
    }
    private void 丗东丂东丈丌丑丈丆(int 东丅专丒丙下丟丛丁, int 万丅丅丂一丗丗丗下)
    {
        this.丗东丂东丈丌丑丈丆<OfferItemView>(丌丒丝东丌下丕丁丅:  东丅专丒丙下丟丛丁, 丈丆丕与丒丌丘丕且:  this.丑丘七丄万丐三下世, 丑且不丕与专丄业丙:  this._prefabReward, 丈东丘丏与丌东东下:  this._revardGrid.transform);
        this.丗东丂东丈丌丑丈丆<PlayerScoreUi>(丌丒丝东丌下丕丁丅:  万丅丅丂一丗丗丗下, 丈丆丕与丒丌丘丕且:  this.业下丞专丂丑上且万, 丑且不丕与专丄业丙:  this._prefabPlayerScoreUi, 丈东丘丏与丌东东下:  this._playerScoreCellsGrid.transform);
    }
    private void 丗东丂东丈丌丑丈丆<T>(int 丌丒丝东丌下丕丁丅, System.Collections.Generic.List<T> 丈丆丕与丒丌丘丕且, T 丑且不丕与专丄业丙, UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = 丈东丘丏与丌东东下;
        val_8 = 丌丒丝东丌下丕丁丅;
        if(丈丆丕与丒丌丘丕且 > val_8)
        {
            goto label_2;
        }
        
        if(丈丆丕与丒丌丘丕且 >= val_8)
        {
                return;
        }
        
        val_9 = val_8 - 丈丆丕与丒丌丘丕且;
        if(val_9 < 1)
        {
                return;
        }
        
        do
        {
            val_8 = 丑且不丕与专丄业丙;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            val_8.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
            val_9 = val_9 - 1;
        }
        while(val_9 != 0);
        
        return;
        label_24:
        val_7 = 丈丆丕与丒丌丘丕且.gameObject;
        val_7.SetActive(value:  false);
        val_8 = val_8 + 1;
        label_2:
        if(val_8 < 丈丆丕与丒丌丘丕且)
        {
            goto label_24;
        }
    
    }
    internal void 丈且东丑丂且万丒丅(丂丟丙丌丞七东丑丁 丘丟丒丘下专丂丒业)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(丘丟丒丘下专丂丒业 == null)
        {
            goto label_2;
        }
        
        label_15:
        val_1.SetActive(value:  true);
        this.丗东丂东丈丌丑丈丆(东丅专丒丙下丟丛丁:  丘丟丒丘下专丂丒业.丂丌丕与业丛专丗专.Count, 万丅丅丂一丗丗丗下:  丘丟丒丘下专丂丒业.丏一东一丅丕下丕专.Count);
        this._rewardBoxGo.SetActive(value:  (this.Index == 0) ? 1 : 0);
        UnityEngine.GameObject val_6 = this._revardGrid.gameObject;
        val_6.SetActive(value:  (this.Index != 0) ? 1 : 0);
        if(this.Index != 0)
        {
                this.东丆丞东一丕丒东东(丘丟丒丘下专丂丒业:  丘丟丒丘下专丂丒业);
        }
        
        this.丘丈专丏丒丏丈下丐(丘丟丒丘下专丂丒业:  丘丟丒丘下专丂丒业);
        val_6.height = UnityEngine.Mathf.CeilToInt(f:  (float)this._rewardContainerWidget.height + (丘丟丒丘下专丂丒业.丏一东一丅丕下丕专.Count * this._playerScoresContainerWidget.height));
        this.UpdateRects();
        return;
        label_1:
        if(丘丟丒丘下专丂丒业 != null)
        {
            goto label_15;
        }
        
        label_2:
        val_1.SetActive(value:  false);
    }
    private void 东丆丞东一丕丒东东(丂丟丙丌丞七东丑丁 丘丟丒丘下专丂丒业)
    {
        goto label_1;
        label_11:
        this.丑丘七丄万丐三下世.Item[0].gameObject.SetActive(value:  true);
        this.丑丘七丄万丐三下世.Item[0].Setup(与且专丈不万东一万:  丘丟丒丘下专丂丒业.丂丌丕与业丛专丗专.Item[0].丂丑丞丝且万丐万丟());
        0 = 1;
        label_1:
        if(0 < 丘丟丒丘下专丂丒业.丂丌丕与业丛专丗专.Count)
        {
            goto label_11;
        }
        
        if(this._revardGrid == null)
        {
            
        }
    
    }
    private void 丘丈专丏丒丏丈下丐(丂丟丙丌丞七东丑丁 丘丟丒丘下专丂丒业)
    {
        var val_12;
        string val_13;
        val_12 = 0;
        goto label_2;
        label_24:
        this.业下丞专丂丑上且万.Item[0].gameObject.SetActive(value:  true);
        PlayerScoreUi val_3 = this.业下丞专丂丑上且万.Item[0];
        if(val_3.上世丄不丐丁丟丅丒 != false)
        {
                LeaderboardEventControllerUi.丆丕丝丒不丙且丐丗.三丛七下业东丏丘丈(七上世丗丄一业丅且:  0);
        }
        
        TournamentPlayer val_5 = 丘丟丒丘下专丂丒业.丏一东一丅丕下丕专.Item[0];
        val_13 = val_5.id;
        TournamentPlayer val_6 = 丘丟丒丘下专丂丒业.丏一东一丅丕下丕专.Item[0];
        TournamentPlayer val_8 = 丘丟丒丘下专丂丒业.丏一东一丅丕下丕专.Item[0];
        this.业下丞专丂丑上且万.Item[0].丈且东丑丂且万丒丅(且丒丛与丞世丙丕丌:  丘丟丒丘下专丂丒业.七丑一丙丂丘且丏丆 + val_12, 丞丅上丏丂且下丅与:  val_13, 不丆业丏上丐与丌业:  val_6.nickname, 万且丒下丕丝专丟上:  val_8.score);
        PlayerScoreUi val_9 = this.业下丞专丂丑上且万.Item[0];
        if(val_9.上世丄不丐丁丟丅丒 != false)
        {
                val_13 = this.业下丞专丂丑上且万.Item[0];
            LeaderboardEventControllerUi.丆丕丝丒不丙且丐丗.三丛七下业东丏丘丈(七上世丗丄一业丅且:  val_13);
        }
        
        val_12 = 1;
        label_2:
        if(val_12 < 丘丟丒丘下专丂丒业.丏一东一丅丕下丕专.Count)
        {
            goto label_24;
        }
        
        if(this._playerScoreCellsGrid == null)
        {
            
        }
    
    }
    public EventTournamentCell()
    {
        this.业下丞专丂丑上且万 = new System.Collections.Generic.List<PlayerScoreUi>();
        this.丑丘七丄万丐三下世 = new System.Collections.Generic.List<OfferItemView>();
    }

}
