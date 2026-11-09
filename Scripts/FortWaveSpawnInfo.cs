using UnityEngine;
[Serializable]
public struct FortWaveSpawnInfo
{
    // Fields
    public System.Collections.Generic.List<FortSubWaveSpawnInfo> subWaveSpawnInfo;
    public float delayWave;
    
    // Properties
    public int countMob { get; }
    
    // Methods
    public int get_countMob()
    {
        mem2[0] = null;
        mem2[0] = null;
        mem2[0] = null;
        return (int)new FortWaveSpawnInfo();
    }

}
