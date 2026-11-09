using UnityEngine;
private class LeaderboardEventTournament.一业东丄丅丘七丘七 : IComparer<TournamentPlayer>
{
    // Methods
    public int Compare(TournamentPlayer 三丟东丕丄丄下下丑, TournamentPlayer 丒丒丄丁且丄丆丂丌)
    {
        var val_2;
        if(三丟东丕丄丄下下丑.score <= 丒丒丄丁且丄丆丂丌.score)
        {
                return (int)(三丟东丕丄丄下下丑.score < 丒丒丄丁且丄丆丂丌.score) ? 1 : 0;
        }
        
        val_2 = 0;
        return (int)(三丟东丕丄丄下下丑.score < 丒丒丄丁且丄丆丂丌.score) ? 1 : 0;
    }
    public LeaderboardEventTournament.一业东丄丅丘七丘七()
    {
    
    }

}
