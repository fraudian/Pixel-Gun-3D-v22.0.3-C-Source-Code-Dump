using UnityEngine;
[Serializable]
public class BalanceController.GroupedActionData
{
    // Fields
    public int startIndex;
    public int currentIndex;
    public int boughtCount;
    public System.Collections.Generic.List<string> cohorts;
    
    // Methods
    public override string ToString()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }
    public BalanceController.GroupedActionData()
    {
        this.cohorts = new System.Collections.Generic.List<System.String>();
    }

}
