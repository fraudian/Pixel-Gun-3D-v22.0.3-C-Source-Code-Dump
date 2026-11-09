using UnityEngine;
[Serializable]
public class X10Data
{
    // Fields
    public int BoughtNum;
    public System.Collections.Generic.List<int> CoinInappsNotBought;
    public long DateEnd;
    public long DateStart;
    internal string GuiStyle;
    public System.Collections.Generic.List<int> GemInappsNotBought;
    public string Id;
    public bool IsRunning;
    public int Period;
    public System.Collections.Generic.List<X10Rule> Rules;
    public bool SaughtCoins;
    public bool SaughtGems;
    
    // Methods
    public X10Data()
    {
    
    }

}
