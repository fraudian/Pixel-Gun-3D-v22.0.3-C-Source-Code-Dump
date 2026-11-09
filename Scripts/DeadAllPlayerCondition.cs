using UnityEngine;
internal sealed class DeadAllPlayerCondition : BaseConditionEndRound
{
    // Methods
    internal override void 丅专下万丕丑丆丅丝(object[] 丗专丆万丏万丂丂丆)
    {
    
    }
    internal override void 下丌且丈丝丗丛上丌()
    {
        Player_move_c.丂丛与丒丙不丁丐丑(丙业与丙丗丝不丈东:  new System.Action<Player_move_c>(object:  this, method:  System.Void DeadAllPlayerCondition::丌丅丈且丑一丑丐丂(Player_move_c 丕丁丘丆万丄世专丛)));
    }
    internal override void 一丗一上丙丅下丑万()
    {
        Player_move_c.丟丏与丛东上丑丁丁(丙业与丙丗丝不丈东:  new System.Action<Player_move_c>(object:  this, method:  System.Void DeadAllPlayerCondition::丌丅丈且丑一丑丐丂(Player_move_c 丕丁丘丆万丄世专丛)));
    }
    private void 丌丅丈且丑一丑丐丂(Player_move_c 丕丁丘丆万丄世专丛)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_8:
        if(((-1513763880) & 1) == 0)
        {
            goto label_4;
        }
        
        if((0.丐丏七丌丕丗业且上().一丝丌丏万丐丌丆东() == true) || (0 != 0))
        {
            goto label_8;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_4:
        val_5 = public System.Void List.Enumerator<Player_move_c>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丛万丙丏丝丗丛丄丐();
    }
    public DeadAllPlayerCondition()
    {
    
    }

}
