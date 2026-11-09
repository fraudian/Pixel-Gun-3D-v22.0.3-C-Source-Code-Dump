using UnityEngine;
[Serializable]
internal class LeaderboardEventController.RewardParameters : ISerializationCallbackReceiver
{
    // Fields
    public int EventId;
    public int Place;
    public int Score;
    public System.Collections.Generic.Dictionary<string, object> RewardConfig;
    private string _serializationDictionary;
    
    // Methods
    internal LeaderboardEventController.RewardParameters(int 丟丟丄专上丟丁丐丝, int 且丒丛与丞世丙丕丌, int 万且丒下丕丝专丟上, System.Collections.Generic.Dictionary<string, object> 丈丞三丈与丄丞丕世)
    {
        val_1 = new System.Object();
        this.EventId = 丟丟丄专上丟丁丐丝;
        this.Place = 且丒丛与丞世丙丕丌;
        this.Score = 万且丒下丕丝专丟上;
        this.RewardConfig = val_1;
    }
    public void OnBeforeSerialize()
    {
        if(this.RewardConfig == null)
        {
                return;
        }
        
        this._serializationDictionary = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.RewardConfig);
    }
    public void OnAfterDeserialize()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
        if((System.String.IsNullOrEmpty(value:  this._serializationDictionary)) == true)
        {
                return;
        }
        
        if((Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  this._serializationDictionary)) != null)
        {
                val_5 = 0;
        }
        
        this.RewardConfig = val_5;
    }

}
