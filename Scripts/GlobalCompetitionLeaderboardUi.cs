using UnityEngine;
public sealed class GlobalCompetitionLeaderboardUi : PGBehaviour
{
    // Fields
    private PanelWithLeagueButtons _panelWithLeagueButtons;
    private DynamicWrapGrid _dynamicWrapGrid;
    private UIPanel _topPlayersPanel;
    private UnityEngine.GameObject _notInTopContainer;
    private UIPanel _notInTopPanel;
    private UILabel _notInTopText;
    private UILabel _notInTopScore;
    private UnityEngine.GameObject _notInTopScoreContainer;
    private UnityEngine.GameObject _notInTopPlaceContainer;
    private UILabel _headerLabel;
    private float 下丗万下丙丈丞丄丁;
    private float 丑与丗丄一丛七丒丅;
    
    // Methods
    private void OnEnable()
    {
        this._panelWithLeagueButtons.buttonSelected = new System.Action<LeagueIconWithBackground>(object:  this, method:  System.Void GlobalCompetitionLeaderboardUi::丈丈万世丄一丏丁丘(LeagueIconWithBackground 万且万且丑丗且丌丆));
        LeaderboardsController.万丅丙七丛丘丙丝与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GlobalCompetitionLeaderboardUi::与丗丞专丞下丁与业()));
    }
    private void OnDisable()
    {
        LeaderboardsController.一丒一不丗丝不丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GlobalCompetitionLeaderboardUi::与丗丞专丞下丁与业()));
    }
    public void Open()
    {
        this._panelWithLeagueButtons.CreateButtons();
    }
    private void 丈丈万世丄一丏丁丘(LeagueIconWithBackground 万且万且丑丗且丌丆)
    {
        this.丝丏丘下与丘专与上(丙丑七万丆万丆且丌:  万且万且丑丗且丌丆.丈三与世丟下丅丄专());
        this.世专丑丄丝丑丂东丟(丞丅上丏丂且下丅与:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        Rilisoft.Singleton<LeaderboardsController>.Instance.丂丐丂丌丂丂丄七丒(丙丑七万丆万丆且丌:  万且万且丑丗且丌丆.丈三与世丟下丅丄专());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._headerLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11692"), arg0:  LeaguesGUIController.丅且万专丁丘不三丑(丙丑七万丆万丆且丌:  万且万且丑丗且丌丆.丈三与世丟下丅丄专())));
    }
    private void 丝丏丘下与丘专与上(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        System.Collections.Generic.IEnumerable<TSource> val_23;
        var val_24;
        System.Func<TournamentPlayer, System.Int32> val_26;
        bool val_28;
        var val_31;
        var val_32;
        System.Collections.Generic.List<TournamentPlayer> val_4 = 0;
        System.Collections.Generic.List<Competition.丘东不专不丒丕万丄> val_1 = new System.Collections.Generic.List<Competition.丘东不专不丒丕万丄>();
        bool val_5 = Rilisoft.Singleton<LeaderboardsController>.Instance.一与七丗丝不东丙且().TryGetValue(key:  丙丑七万丆万丆且丌, value: out  val_4);
        val_23 = val_4;
        if(val_23 == 0)
        {
                System.Collections.Generic.List<TournamentPlayer> val_6 = null;
            val_23 = val_6;
            val_6 = new System.Collections.Generic.List<TournamentPlayer>();
        }
        
        val_24 = null;
        val_24 = null;
        val_26 = GlobalCompetitionLeaderboardUi.<>c.<>9__16_0;
        if(val_26 == null)
        {
                System.Func<TournamentPlayer, System.Int32> val_7 = null;
            val_26 = val_7;
            val_7 = new System.Func<TournamentPlayer, System.Int32>(object:  GlobalCompetitionLeaderboardUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GlobalCompetitionLeaderboardUi.<>c::丛丁万上三下下世丅(TournamentPlayer 三丟东丕丄丄下下丑));
            GlobalCompetitionLeaderboardUi.<>c.<>9__16_0 = val_26;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        System.Collections.Generic.IEnumerator<T> val_10 = System.Linq.Enumerable.OrderByDescending<TournamentPlayer, System.Int32>(source:  val_6, keySelector:  val_7).GetEnumerator();
        val_28 = 1152921504686346240;
        label_29:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_19;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        T val_14 = val_10.Current;
        new Competition.丘东不专不丒丕万丄() = new Competition.丘东不专不丒丕万丄();
        if(new Competition.丘东不专不丒丕万丄() != null)
        {
                .丞丅上丏丂且下丅与 = val_14 + 16;
            .丛三三与丁丘丄丑下 = val_14 + 24;
            .且丒丛与丞世丙丕丌 = val_14 + 36;
            .万且丒下丕丝专丟上 = val_14 + 32;
        }
        else
        {
                mem[16] = val_14 + 16;
            mem[24] = val_14 + 24;
            .且丒丛与丞世丙丕丌 = val_14 + 36;
            mem[32] = val_14 + 32;
        }
        
        .上丌丑丑丂世一不丙 = false;
        val_1.Add(item:  new Competition.丘东不专不丒丕万丄());
        goto label_29;
        label_19:
        val_31 = 0;
        val_32 = 0;
        if(val_10 == null)
        {
            
        }
        else
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            val_10.Dispose();
        }
        
        int val_18 = 100 - val_1.Count;
        if(val_18 >= 1)
        {
                val_28 = true;
            do
        {
            int val_20 = val_1.Count + 1;
            Competition.丘东不专不丒丕万丄 val_21 = new Competition.丘东不专不丒丕万丄();
            if(val_21 != null)
        {
                .且丒丛与丞世丙丕丌 = val_20;
        }
        else
        {
                .且丒丛与丞世丙丕丌 = val_20;
        }
        
            .上丌丑丑丂世一不丙 = val_28;
            val_1.Add(item:  val_21);
            val_18 = val_18 - 1;
        }
        while(val_18 != 0);
        
        }
        
        this._dynamicWrapGrid.SetContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_1)), 业丛丛世上丈丘丄东:  false);
        this.丄丝上丑万丒且丞专(丁丟丌专三上丐丕丙:  val_1, 世东丞三上丟丝丛丙:  TournamentController.丐丒丑丆丒且东与世(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌));
        this.丆丏丁丑丁与不东丟(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌);
    }
    private void 丆丏丁丑丁与不东丟(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        if((TournamentController.丐丒丑丆丒且东与世(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌)) != false)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._notInTopScore, 丕丗丘丑丛与丑业丒:  TournamentController.专丌丙丘三万下丙丑(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notInTopPlaceContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notInTopScoreContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._notInTopText, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11693"));
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notInTopPlaceContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notInTopScoreContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._notInTopText, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11702"));
    }
    private void 东丘丙且丐丛丏丝业(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        System.Collections.Generic.IEnumerable<TSource> val_23;
        var val_24;
        System.Func<TournamentPlayer, System.Int32> val_26;
        bool val_28;
        var val_31;
        var val_32;
        System.Collections.Generic.List<TournamentPlayer> val_4 = 0;
        System.Collections.Generic.List<Competition.丘东不专不丒丕万丄> val_1 = new System.Collections.Generic.List<Competition.丘东不专不丒丕万丄>();
        bool val_5 = Rilisoft.Singleton<LeaderboardsController>.Instance.一与七丗丝不东丙且().TryGetValue(key:  丙丑七万丆万丆且丌, value: out  val_4);
        val_23 = val_4;
        if(val_23 == 0)
        {
                System.Collections.Generic.List<TournamentPlayer> val_6 = null;
            val_23 = val_6;
            val_6 = new System.Collections.Generic.List<TournamentPlayer>();
        }
        
        val_24 = null;
        val_24 = null;
        val_26 = GlobalCompetitionLeaderboardUi.<>c.<>9__18_0;
        if(val_26 == null)
        {
                System.Func<TournamentPlayer, System.Int32> val_7 = null;
            val_26 = val_7;
            val_7 = new System.Func<TournamentPlayer, System.Int32>(object:  GlobalCompetitionLeaderboardUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GlobalCompetitionLeaderboardUi.<>c::一上丑丅丛丛丏丄丗(TournamentPlayer 三丟东丕丄丄下下丑));
            GlobalCompetitionLeaderboardUi.<>c.<>9__18_0 = val_26;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        System.Collections.Generic.IEnumerator<T> val_10 = System.Linq.Enumerable.OrderByDescending<TournamentPlayer, System.Int32>(source:  val_6, keySelector:  val_7).GetEnumerator();
        val_28 = 1152921504686346240;
        label_29:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_19;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        T val_14 = val_10.Current;
        new Competition.丘东不专不丒丕万丄() = new Competition.丘东不专不丒丕万丄();
        if(new Competition.丘东不专不丒丕万丄() != null)
        {
                .丞丅上丏丂且下丅与 = val_14 + 16;
            .丛三三与丁丘丄丑下 = val_14 + 24;
            .且丒丛与丞世丙丕丌 = val_14 + 36;
            .万且丒下丕丝专丟上 = val_14 + 32;
        }
        else
        {
                mem[16] = val_14 + 16;
            mem[24] = val_14 + 24;
            .且丒丛与丞世丙丕丌 = val_14 + 36;
            mem[32] = val_14 + 32;
        }
        
        .上丌丑丑丂世一不丙 = false;
        val_1.Add(item:  new Competition.丘东不专不丒丕万丄());
        goto label_29;
        label_19:
        val_31 = 0;
        val_32 = 0;
        if(val_10 == null)
        {
            
        }
        else
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            val_10.Dispose();
        }
        
        int val_18 = 100 - val_1.Count;
        if(val_18 >= 1)
        {
                val_28 = true;
            do
        {
            int val_20 = val_1.Count + 1;
            Competition.丘东不专不丒丕万丄 val_21 = new Competition.丘东不专不丒丕万丄();
            if(val_21 != null)
        {
                .且丒丛与丞世丙丕丌 = val_20;
        }
        else
        {
                .且丒丛与丞世丙丕丌 = val_20;
        }
        
            .上丌丑丑丂世一不丙 = val_28;
            val_1.Add(item:  val_21);
            val_18 = val_18 - 1;
        }
        while(val_18 != 0);
        
        }
        
        this._dynamicWrapGrid.UpdateContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_1)));
        this.丄丝上丑万丒且丞专(丁丟丌专三上丐丕丙:  val_1, 世东丞三上丟丝丛丙:  TournamentController.丐丒丑丆丒且东与世(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌));
        this.丆丏丁丑丁与不东丟(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌);
    }
    private void 与丗丞专丞下丁与业()
    {
        RatingLeague val_1 = this._panelWithLeagueButtons.GetSelectedLeague();
        if(val_1 == 1)
        {
                return;
        }
        
        this.东丘丙且丐丛丏丝业(丙丑七万丆万丆且丌:  val_1);
        this.世专丑丄丝丑丂东丟(丞丅上丏丂且下丅与:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
    }
    private void 世专丑丄丝丑丂东丟(string 丞丅上丏丂且下丅与)
    {
        string val_6 = 丞丅上丏丂且下丅与;
        GlobalCompetitionLeaderboardUi.丒业丛丟专丛丒与东 val_1 = new GlobalCompetitionLeaderboardUi.丒业丛丟专丛丒与东();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .丞丅上丏丂且下丅与 = val_6;
        if(val_6 != null)
        {
            goto label_2;
        }
        
        return;
        label_1:
        mem[16] = val_6;
        val_6 = mem[16];
        if(val_6 == 0)
        {
                return;
        }
        
        label_2:
        val_6 = this._dynamicWrapGrid.ContentList;
        object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  val_6, predicate:  new System.Func<System.Object, System.Boolean>(object:  val_1, method:  System.Boolean GlobalCompetitionLeaderboardUi.丒业丛丟专丛丒与东::丟丏丄三丝七不下丈(object 三丟东丕丄丄下下丑)));
        if(val_4 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        this._dynamicWrapGrid.ScrollToCenterOnItem(丙丈下丕丑专上丕丛:  (null == null) ? (val_4) : 0);
    }
    private void 丄丝上丑万丒且丞专(System.Collections.Generic.List<Competition.丘东不专不丒丕万丄> 丁丟丌专三上丐丕丙, bool 世东丞三上丟丝丛丙)
    {
        System.Func<Competition.丘东不专不丒丕万丄, System.Boolean> val_5;
        var val_6;
        System.Func<Competition.丘东不专不丒丕万丄, System.Boolean> val_8;
        UnityEngine.GameObject val_9;
        var val_10;
        var val_11;
        val_5 = 世东丞三上丟丝丛丙;
        val_6 = null;
        val_6 = null;
        val_8 = GlobalCompetitionLeaderboardUi.<>c.<>9__21_0;
        if(val_8 == null)
        {
                System.Func<Competition.丘东不专不丒丕万丄, System.Boolean> val_1 = null;
            val_8 = val_1;
            val_1 = new System.Func<Competition.丘东不专不丒丕万丄, System.Boolean>(object:  GlobalCompetitionLeaderboardUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GlobalCompetitionLeaderboardUi.<>c::世丛丏一业东丕不丑(Competition.丘东不专不丒丕万丄 三丟东丕丄丄下下丑));
            GlobalCompetitionLeaderboardUi.<>c.<>9__21_0 = val_8;
        }
        
        if(((System.Linq.Enumerable.Count<Competition.丘东不专不丒丕万丄>(source:  丁丟丌专三上丐丕丙, predicate:  val_1)) > 49) || (val_5 == false))
        {
            goto label_7;
        }
        
        val_9 = this._notInTopContainer;
        val_10 = null;
        goto label_10;
        label_7:
        val_11 = null;
        val_11 = null;
        val_5 = GlobalCompetitionLeaderboardUi.<>c.<>9__21_1;
        if(val_5 == null)
        {
                System.Func<Competition.丘东不专不丒丕万丄, System.Boolean> val_3 = null;
            val_5 = val_3;
            val_3 = new System.Func<Competition.丘东不专不丒丕万丄, System.Boolean>(object:  GlobalCompetitionLeaderboardUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GlobalCompetitionLeaderboardUi.<>c::丟丑一丈世业下丟一(Competition.丘东不专不丒丕万丄 三丟东丕丄丄下下丑));
            GlobalCompetitionLeaderboardUi.<>c.<>9__21_1 = val_5;
        }
        
        val_9 = this._notInTopContainer;
        if((System.Linq.Enumerable.Any<Competition.丘东不专不丒丕万丄>(source:  丁丟丌专三上丐丕丙, predicate:  val_3)) == false)
        {
            goto label_16;
        }
        
        val_10 = null;
        label_10:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  false);
        this.丈世丝丂上丙丆丄丝();
        return;
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
        this.丅世丛七丈三丙丌丒(丘丒丗丛丛且丞东丞:  this._notInTopPanel);
    }
    private void 丅世丛七丈三丙丌丒(UIPanel 丘丒丗丛丛且丞东丞)
    {
        this.丟丑与专丝丁丐丗下();
        UnityEngine.Vector4 val_1 = this._topPlayersPanel.baseClipRegion;
        float val_6 = this.丑与丗丄一丛七丒丅;
        float val_4 = this._topPlayersPanel.width;
        float val_7 = this.下丗万下丙丈丞丄丁;
        val_6 = val_6 + (丘丒丗丛丛且丞东丞.height * 0.5f);
        val_7 = val_7 - 丘丒丗丛丛且丞东丞.height;
        if(this._topPlayersPanel == null)
        {
            
        }
    
    }
    private void 丈世丝丂上丙丆丄丝()
    {
        this.丟丑与专丝丁丐丗下();
        UnityEngine.Vector4 val_1 = this._topPlayersPanel.baseClipRegion;
        float val_2 = this._topPlayersPanel.width;
        if(this._topPlayersPanel == null)
        {
            
        }
    
    }
    private void 丟丑与专丝丁丐丗下()
    {
        if(this.下丗万下丙丈丞丄丁 != 0f)
        {
                return;
        }
        
        this.下丗万下丙丈丞丄丁 = this._topPlayersPanel.height;
        UnityEngine.Vector4 val_2 = this._topPlayersPanel.baseClipRegion;
        this.丑与丗丄一丛七丒丅 = val_2.y;
    }
    public GlobalCompetitionLeaderboardUi()
    {
    
    }

}
