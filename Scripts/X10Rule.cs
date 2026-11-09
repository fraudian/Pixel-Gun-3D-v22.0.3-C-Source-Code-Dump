using UnityEngine;
[Serializable]
public class X10Rule
{
    // Fields
    public int CoinsFirstInappCost;
    public int DollarsSpent;
    public int GemsFirstInappCost;
    
    // Properties
    public bool GemsEnabled { get; }
    public bool CoinsEnabled { get; }
    
    // Methods
    public bool get_GemsEnabled()
    {
        int val_2 = this.GemsFirstInappCost;
        val_2 = val_2 >> 31;
        return (bool)val_2 ^ 1;
    }
    public bool get_CoinsEnabled()
    {
        int val_2 = this.CoinsFirstInappCost;
        val_2 = val_2 >> 31;
        return (bool)val_2 ^ 1;
    }
    public X10Rule()
    {
    
    }

}
