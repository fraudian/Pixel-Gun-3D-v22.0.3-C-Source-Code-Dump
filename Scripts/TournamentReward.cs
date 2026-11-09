using UnityEngine;
[Serializable]
public class TournamentReward : ICloneable, ISerializationCallbackReceiver
{
    // Fields
    public int newLeague;
    public int newScores;
    public int resultPlace;
    public int resultScores;
    public int seasonId;
    internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> reward;
    private System.Collections.Generic.List<string> _reward;
    
    // Methods
    public object Clone()
    {
        int val_3;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_4;
        int val_5;
        TournamentReward val_1 = new TournamentReward();
        if(val_1 != null)
        {
                .newLeague = this.newLeague;
            .resultPlace = this.resultPlace;
            val_3 = this.newScores;
        }
        else
        {
                mem[16] = this.newLeague;
            mem[24] = this.resultPlace;
            val_3 = this.newScores;
        }
        
        .newScores = val_3;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = null;
        val_4 = val_2;
        val_2 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>(collection:  this.reward);
        if(val_1 != null)
        {
                .reward = val_4;
            .seasonId = this.seasonId;
            val_5 = this.resultScores;
        }
        else
        {
                mem[40] = val_4;
            val_4 = this.seasonId;
            mem[32] = val_4;
            val_5 = this.resultScores;
        }
        
        .resultScores = val_5;
        return (object)val_1;
    }
    public void OnBeforeSerialize()
    {
        var val_4;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.String> val_6;
        if(this.reward == null)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_6 = TournamentReward.<>c.<>9__8_0;
        if(val_6 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.String> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.String>(object:  TournamentReward.<>c.__il2cppRuntimeField_static_fields, method:  System.String TournamentReward.<>c::七业与丗一东丗丘丄(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            TournamentReward.<>c.<>9__8_0 = val_6;
        }
        
        this._reward = new System.Collections.Generic.List<System.String>(collection:  System.Linq.Enumerable.Select<PGCompany.三东丏不丗世丅丌丄, System.String>(source:  this.reward, selector:  val_1));
    }
    public void OnAfterDeserialize()
    {
        if(this._reward == null)
        {
                return;
        }
        
        this.reward = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>(collection:  System.Linq.Enumerable.Select<System.String, PGCompany.三东丏不丗世丅丌丄>(source:  this._reward, selector:  new System.Func<System.String, PGCompany.三东丏不丗世丅丌丄>(object:  0, method:  public static PGCompany.三东丏不丗世丅丌丄 PGCompany.三东丏不丗世丅丌丄::丂东专丙丒丏且丛丁(string 丞丕丒专一下丙业上))));
    }
    public TournamentReward()
    {
    
    }

}
