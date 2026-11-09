using UnityEngine;
[Serializable]
public class BPData.Content
{
    // Fields
    public int Exp;
    public int Level;
    private PGCompany.BattlePass.BPData.丗丛下丛丑专丈丌丗 _reward;
    
    // Properties
    public System.Collections.Generic.List<string> RewardsFree { get; set; }
    public System.Collections.Generic.List<string> RewardsPaid { get; set; }
    public bool FreeIsCool { get; set; }
    public bool PaidIsCool { get; set; }
    
    // Methods
    public System.Collections.Generic.List<string> get_RewardsFree()
    {
        if(this._reward != null)
        {
                return (System.Collections.Generic.List<System.String>)this._reward.RewardsFree;
        }
        
        return (System.Collections.Generic.List<System.String>)this._reward.RewardsFree;
    }
    public void set_RewardsFree(System.Collections.Generic.List<string> 丙业与丙丗丝不丈东)
    {
        int val_1 = 丙业与丙丗丝不丈东.Count;
        this._reward.RewardsFree = 丙业与丙丗丝不丈东;
    }
    public System.Collections.Generic.List<string> get_RewardsPaid()
    {
        if(this._reward != null)
        {
                return (System.Collections.Generic.List<System.String>)this._reward.RewardsPaid;
        }
        
        return (System.Collections.Generic.List<System.String>)this._reward.RewardsPaid;
    }
    public void set_RewardsPaid(System.Collections.Generic.List<string> 丙业与丙丗丝不丈东)
    {
        this._reward.RewardsPaid = 丙业与丙丗丝不丈东;
    }
    public bool get_FreeIsCool()
    {
        if(this._reward != null)
        {
                return (bool)this._reward.FreeIsCool;
        }
        
        return (bool)this._reward.FreeIsCool;
    }
    public void set_FreeIsCool(bool 丙业与丙丗丝不丈东)
    {
        this._reward.FreeIsCool = 丙业与丙丗丝不丈东;
    }
    public bool get_PaidIsCool()
    {
        if(this._reward != null)
        {
                return (bool)this._reward.PaidIsCool;
        }
        
        return (bool)this._reward.PaidIsCool;
    }
    public void set_PaidIsCool(bool 丙业与丙丗丝不丈东)
    {
        this._reward.PaidIsCool = 丙业与丙丗丝不丈东;
    }
    public BPData.Content()
    {
        this._reward = new BPData.丗丛下丛丑专丈丌丗();
    }

}
