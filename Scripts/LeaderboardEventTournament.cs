using UnityEngine;
[Serializable]
internal sealed class LeaderboardEventTournament
{
    // Fields
    private string _id;
    private int _dataTimestamp;
    private int _seasonEndTimestamp;
    private int _eventId;
    private System.Collections.Generic.List<TournamentPlayer> _topPlayers;
    
    // Properties
    internal string Id { get; }
    internal int DataTimestamp { get; }
    internal int SeasonEndTimestamp { get; }
    public int EventId { get; }
    internal System.Collections.Generic.List<TournamentPlayer> TopPlayers { get; }
    
    // Methods
    internal string get_Id()
    {
        return (string)this._id;
    }
    internal int get_DataTimestamp()
    {
        return (int)this._dataTimestamp;
    }
    internal int get_SeasonEndTimestamp()
    {
        return (int)this._seasonEndTimestamp;
    }
    public int get_EventId()
    {
        return (int)this._eventId;
    }
    internal System.Collections.Generic.List<TournamentPlayer> get_TopPlayers()
    {
        return (System.Collections.Generic.List<TournamentPlayer>)this._topPlayers;
    }
    internal LeaderboardEventTournament(int 丟丟丄专上丟丁丐丝, System.Collections.Generic.List<TournamentPlayer> 丗丗丁丌且丂丌世与)
    {
        this._id = "";
        val_1 = new System.Object();
        this._eventId = 丟丟丄专上丟丁丐丝;
        this._topPlayers = val_1;
    }
    internal LeaderboardEventTournament(string 丞丅上丏丂且下丅与, int 世且三七世丂丈丆一, int 丟不上三世丁丁丈专, int 丟丟丄专上丟丁丐丝, System.Collections.Generic.List<TournamentPlayer> 丗丗丁丌且丂丌世与)
    {
        this._id = "";
        val_1 = new System.Object();
        this._id = 丞丅上丏丂且下丅与;
        this._dataTimestamp = 世且三七世丂丈丆一;
        this._seasonEndTimestamp = 丟不上三世丁丁丈专;
        this._eventId = 丟丟丄专上丟丁丐丝;
        this._topPlayers = val_1;
        this.丛丂且丆不不万丛丐();
    }
    internal void 不下丌丆东丑丈丕丝(string 丞丅上丏丂且下丅与, int 世且三七世丂丈丆一, int 丟不上三世丁丁丈专, System.Collections.Generic.List<TournamentPlayer> 丗丗丁丌且丂丌世与, System.Collections.Generic.List<string> 东丗丌七丌不一业丟)
    {
        .东丗丌七丌不一业丟 = 东丗丌七丌不一业丟;
        this._id = 丞丅上丏丂且下丅与;
        this._dataTimestamp = 世且三七世丂丈丆一;
        this._seasonEndTimestamp = 丟不上三世丁丁丈专;
        this.业丒丈丏一万不丏世(丞丒丁三丕丄丅丈万:  丗丗丁丌且丂丌世与);
        int val_3 = this._topPlayers.RemoveAll(match:  new System.Predicate<TournamentPlayer>(object:  new LeaderboardEventTournament.三丅丞丒丕丅专一丅(), method:  System.Boolean LeaderboardEventTournament.三丅丞丒丕丅专一丅::丙丘世不下丅七丛丒(TournamentPlayer 三丟东丕丄丄下下丑)));
        this.丛丂且丆不不万丛丐();
    }
    internal bool 丆丂世丟上且上丆丆(int 万且丒下丕丝专丟上)
    {
        System.Collections.Generic.List<TournamentPlayer> val_6;
        var val_7;
        if((this.丟丏丕三丝上丛丑世(丞丅上丏丂且下丅与:  FriendsController.不丝丕丒丂丆丘丙丙())) == null)
        {
            goto label_3;
        }
        
        if(val_2.score >= 万且丒下丕丝专丟上)
        {
            goto label_4;
        }
        
        val_2.score = 万且丒下丕丝专丟上;
        goto label_5;
        label_3:
        val_6 = this._topPlayers;
        .id = FriendsController.不丝丕丒丂丆丘丙丙();
        .nickname = ProfileController.丆三丂丂丆上丆丕专();
        .score = 万且丒下丕丝专丟上;
        val_6.Add(item:  new TournamentPlayer());
        label_5:
        this.丛丂且丆不不万丛丐();
        val_7 = 1;
        return (bool)val_7;
        label_4:
        val_7 = 0;
        return (bool)val_7;
    }
    private void 业丒丈丏一万不丏世(System.Collections.Generic.List<TournamentPlayer> 丞丒丁三丕丄丅丈万)
    {
        var val_3;
        int val_4;
        string val_5;
        val_3 = this;
        List.Enumerator<T> val_1 = 丞丒丁三丕丄丅丈万.GetEnumerator();
        label_5:
        if(((-1785533720) & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() != null)
        {
                val_4 = val_2.m_stringLength;
        }
        else
        {
                val_4 = 11993091;
            val_5 = 28563616;
        }
        
        this.丐丐下下丝丈丈与丟(丞丅上丏丂且下丅与:  val_4, 不丆业丏上丐与丌业:  val_5, 万且丒下丕丝专丟上:  0);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丐丐下下丝丈丈与丟(string 丞丅上丏丂且下丅与, string 不丆业丏上丐与丌业, int 万且丒下丕丝专丟上)
    {
        if((this.丟丏丕三丝上丛丑世(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与)) != null)
        {
                if((System.String.IsNullOrEmpty(value:  不丆业丏上丐与丌业)) != true)
        {
                val_1.nickname = 不丆业丏上丐与丌业;
        }
        
            if(万且丒下丕丝专丟上 < 1)
        {
                return;
        }
        
            val_1.score = 万且丒下丕丝专丟上;
            return;
        }
        
        TournamentPlayer val_4 = new TournamentPlayer();
        if(val_4 != null)
        {
                .id = 丞丅上丏丂且下丅与;
            .nickname = 不丆业丏上丐与丌业;
        }
        else
        {
                mem[16] = 丞丅上丏丂且下丅与;
            mem[24] = 不丆业丏上丐与丌业;
        }
        
        .score = 万且丒下丕丝专丟上 & (~(万且丒下丕丝专丟上 >> 31));
        this._topPlayers.Add(item:  val_4);
    }
    private TournamentPlayer 丟丏丕三丝上丛丑世(string 丞丅上丏丂且下丅与)
    {
        string val_4;
        var val_5;
        val_4 = 丞丅上丏丂且下丅与;
        List.Enumerator<T> val_1 = this._topPlayers.GetEnumerator();
        label_4:
        if(((-1785248248) & 1) == 0)
        {
            goto label_2;
        }
        
        val_5 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  val_4)) == false)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (TournamentPlayer);
    }
    private void 丛丂且丆不不万丛丐()
    {
        this._topPlayers.Sort(comparer:  new LeaderboardEventTournament.一业东丄丅丘七丘七());
    }

}
