using UnityEngine;
public class ShopPositionParams : MonoBehaviour
{
    // Fields
    public int tier;
    public int league;
    public float scaleShop;
    public UnityEngine.Vector3 positionShop;
    public UnityEngine.Vector3 rotationShop;
    public string localizeKey;
    
    // Properties
    public int 专丂丗东丞七丐丙丑 { get; }
    public string 丟丒世业且丌丕不丆 { get; }
    public string 丑丌且丒下丈丘丑丗 { get; }
    
    // Methods
    public int get_League()
    {
        return (int)this.league - 1;
    }
    public string get_shopName()
    {
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.localizeKey);
    }
    public string get_shopNameNonLocalized()
    {
        string val_1 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  this.localizeKey);
        if(val_1 != null)
        {
                return val_1.ToUpper();
        }
        
        return val_1.ToUpper();
    }
    public ShopPositionParams()
    {
        this.tier = 11;
        this.league = 1;
        this.scaleShop = 150f;
    }

}
