using UnityEngine;
private abstract class ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁 : 丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟>
{
    // Fields
    private readonly Rilisoft.ReusableRewardedVideo <丅丝丌丝丁丏丙东丞>k__BackingField;
    
    // Properties
    protected Rilisoft.ReusableRewardedVideo 丄丄一丐东丐丝丗七 { get; }
    
    // Methods
    protected ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁(Rilisoft.ReusableRewardedVideo 下丒丗丛丙丆丄丈专)
    {
        if(下丒丗丛丙丆丄丈专 != 0)
        {
                this.<丅丝丌丝丁丏丙东丞>k__BackingField = 下丒丗丛丙丆丄丈专;
            return;
        }
        
        System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "rewardedVideo");
    }
    protected Rilisoft.ReusableRewardedVideo 丄丌一七丈万万丌丐()
    {
        return (Rilisoft.ReusableRewardedVideo)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }

}
