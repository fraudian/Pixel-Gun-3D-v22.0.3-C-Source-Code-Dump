using UnityEngine;
[Serializable]
internal class 丈专丂丁丁东丌丁丅.GMERewardSavedConditions
{
    // Fields
    public string ConditionId;
    public PGCompany.GameModeEvents.GMERewardConditionProgress Progress;
    
    // Methods
    internal 丈专丂丁丁东丌丁丅.GMERewardSavedConditions()
    {
    
    }
    internal 丈专丂丁丁东丌丁丅.GMERewardSavedConditions(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardSavedConditions 丐丅三丆丑丕业业丞)
    {
        this.Progress = new PGCompany.GameModeEvents.GMERewardConditionProgress();
        this.且丅丗丂丗丌与且丝(丐丅三丆丑丕业业丞:  丐丅三丆丑丕业业丞);
    }
    internal void 且丅丗丂丗丌与且丝(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardSavedConditions 丐丅三丆丑丕业业丞)
    {
        PGCompany.GameModeEvents.GMERewardConditionProgress val_1;
        if(丐丅三丆丑丕业业丞 != null)
        {
                val_1 = this.Progress;
            this.ConditionId = 丐丅三丆丑丕业业丞.ConditionId;
        }
        else
        {
                val_1 = this.Progress;
            this.ConditionId = 11993091;
        }
        
        val_1.且丅丗丂丗丌与且丝(上丕丈丞丌丘丅不与:  丐丅三丆丑丕业业丞.Progress);
    }
    internal bool 不丞丁丘不丗丞丗不(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.GMERewardSavedConditions 丐丅三丆丑丕业业丞)
    {
        if((System.String.op_Equality(a:  this.ConditionId, b:  丐丅三丆丑丕业业丞.ConditionId)) == false)
        {
                return false;
        }
        
        if(this.Progress != null)
        {
                return this.Progress.不丞丁丘不丗丞丗不(上丕丈丞丌丘丅不与:  丐丅三丆丑丕业业丞.Progress);
        }
        
        return this.Progress.不丞丁丘不丗丞丗不(上丕丈丞丌丘丅不与:  丐丅三丆丑丕业业丞.Progress);
    }

}
