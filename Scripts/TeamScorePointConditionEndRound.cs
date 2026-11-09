using UnityEngine;
internal sealed class TeamScorePointConditionEndRound : BaseConditionEndRound
{
    // Fields
    private float maxScorePoints;
    private float 业业七丘且丗一丝万;
    
    // Methods
    internal override void 丅专下万丕丑丆丅丝(object[] 丗专丆万丏万丂丂丆)
    {
        object val_1 = 丗专丆万丏万丂丂丆[0];
        this.maxScorePoints = null;
    }
    internal override void 下丌且丈丝丗丛上丌()
    {
        this.业业七丘且丗一丝万 = 0f;
    }
    internal override void 一丗一上丙丅下丑万()
    {
        this.业业七丘且丗一丝万 = 0f;
    }
    internal void 专三七丞丂三丏丄东(float 丕世丏下丒丂丏丟东)
    {
        this.业业七丘且丗一丝万 = 丕世丏下丒丂丏丟东;
        if(this.maxScorePoints > 丕世丏下丒丂丏丟东)
        {
                return;
        }
        
        this.丛万丙丏丝丗丛丄丐();
    }
    private void 专丄丏丞丈丞丞不丒()
    {
        if(this.业业七丘且丗一丝万 < this.maxScorePoints)
        {
                return;
        }
        
        this.丛万丙丏丝丗丛丄丐();
    }
    public TeamScorePointConditionEndRound()
    {
    
    }

}
