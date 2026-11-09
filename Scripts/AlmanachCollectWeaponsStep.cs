using UnityEngine;
[Serializable]
internal class AlmanachCollectWeaponsStep
{
    // Fields
    public int id;
    public int neededCount;
    public Rilisoft.OfferItem reward;
    
    // Properties
    internal bool IsCompleted { get; }
    public int collectedCount { get; set; }
    
    // Methods
    internal bool get_IsCompleted()
    {
        return (bool)(this.collectedCount >= this.neededCount) ? 1 : 0;
    }
    public int get_collectedCount()
    {
        Progress.丆丏上下丁丏一丙丐 val_1 = Progress.七七世万专丕丁上业.丐丌丆业丞丒丙丐丘();
        if((val_1.丑业丑丟丘丕三世专.ContainsKey(key:  this.id.ToString())) == false)
        {
                return 0;
        }
        
        Progress.丆丏上下丁丏一丙丐 val_4 = Progress.七七世万专丕丁上业.丐丌丆业丞丒丙丐丘();
        if(val_4.丑业丑丟丘丕三世专 != null)
        {
                return val_4.丑业丑丟丘丕三世专.Item[this.id.ToString()];
        }
        
        return val_4.丑业丑丟丘丕三世专.Item[this.id.ToString()];
    }
    public void set_collectedCount(int 丙业与丙丗丝不丈东)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().且世丘丂且三丆七丘(丝丒丛丄不丑丗业丙:  this, 丌丒丝东丌下丕丁丅:  丙业与丙丗丝不丈东);
    }
    public AlmanachCollectWeaponsStep()
    {
    
    }

}
