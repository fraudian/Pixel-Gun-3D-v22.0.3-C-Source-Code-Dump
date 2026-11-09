using UnityEngine;
private sealed class 上丕丁专三丗丝万丆.丟不丑丄丁丅丕丗丁
{
    // Fields
    public Rilisoft.OfferItem 下丅丙一丂丗丅丝七;
    
    // Methods
    public 上丕丁专三丗丝万丆.丟不丑丄丁丅丕丗丁()
    {
    
    }
    internal bool 丗丛七与丝丑丑世东(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛)
    {
        if(东七上世万下丗丄丛.Item.Type != this.下丅丙一丂丗丅丝七.Type)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  东七上世万下丗丄丛.Item.Id, b:  this.下丅丙一丂丗丅丝七.Id);
    }

}
