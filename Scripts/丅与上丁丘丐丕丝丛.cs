using UnityEngine;
internal class 丅与上丁丘丐丕丝丛 : IComparer<SlotInfo>
{
    // Methods
    public int Compare(SlotInfo 丈丂丕下丏丈丞丗业, SlotInfo 丂丌丌丛丆丆丙丌丈)
    {
        var val_4;
        if(丈丂丕下丏丈丞丗业 == null)
        {
            goto label_0;
        }
        
        if(丂丌丌丛丆丆丙丌丈 == null)
        {
            goto label_1;
        }
        
        int val_1 = 丈丂丕下丏丈丞丗业.PositionInScroll;
        int val_2 = 丂丌丌丛丆丆丙丌丈.PositionInScroll;
        return (int)val_4;
        label_0:
        var val_3 = (丂丌丌丛丆丆丙丌丈 != 0) ? -1 : 0;
        return (int)val_4;
        label_1:
        val_4 = 1;
        return (int)val_4;
    }
    public 丅与上丁丘丐丕丝丛()
    {
    
    }

}
