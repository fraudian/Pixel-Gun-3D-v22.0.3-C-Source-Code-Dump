using UnityEngine;
internal struct RatingSystem.丁上且上一丆丘与业
{
    // Fields
    internal RatingSystem.RatingLeague 丈丘丙丛丗不七专丟;
    internal RatingSystem.RatingLeague 丈丐丒丐丕丛东丑业;
    private int 丗丛世世丙丝丌与丑;
    private int 丙东与与万丌丟专丛;
    internal int 丂丆与与丐丕丘不丌;
    internal int 不丐丈丁一丘丄丐丅;
    
    // Properties
    internal int 丕丞丂一专东三丑世 { get; }
    internal bool 与三世与不丞专丌丏 { get; }
    internal bool 丆且上丘世下丅且丞 { get; }
    
    // Methods
    internal RatingSystem.丁上且上一丆丘与业(RatingSystem.RatingLeague 丞丄丕专三丁丙一上, int 专丑丕丄丗丂一丝且, int 丏丞丙丒世七丈丕丞)
    {
        this.丂丆与与丐丕丘不丌 = 丞丄丕专三丁丙一上;
        this.不丐丈丁一丘丄丐丅 = 丞丄丕专三丁丙一上;
        mem[1152921536054677320] = 专丑丕丄丗丂一丝且;
        mem[1152921536054677324] = 专丑丕丄丗丂一丝且;
        mem[1152921536054677328] = 丏丞丙丒世七丈丕丞;
        mem[1152921536054677332] = 丏丞丙丒世七丈丕丞;
    }
    internal RatingSystem.丁上且上一丆丘与业(RatingSystem.RatingLeague 丈丘丙丛丗不七专丟, RatingSystem.RatingLeague 丈丐丒丐丕丛东丑业, int 丗丛世世丙丝丌与丑, int 丙东与与万丌丟专丛, int 丂丆与与丐丕丘不丌, int 不丐丈丁一丘丄丐丅)
    {
        this.丂丆与与丐丕丘不丌 = 丈丘丙丛丗不七专丟;
        this.不丐丈丁一丘丄丐丅 = 丈丐丒丐丕丛东丑业;
        mem[1152921536054801608] = 丗丛世世丙丝丌与丑;
        mem[1152921536054801612] = 丙东与与万丌丟专丛;
        mem[1152921536054801616] = 丂丆与与丐丕丘不丌;
        mem[1152921536054801620] = 不丐丈丁一丘丄丐丅;
    }
    internal RatingSystem.丁上且上一丆丘与业 下丆世上丏丈下丏丑(RatingSystem.RatingLeague 丙丑七万丆万丆且丌, int 丅丅下丟丑专下与一, int 丈丐世下丞与丂专丏)
    {
        丁上且上一丆丘与业 val_0;
        val_0.丈丘丙丛丗不七专丟 = this.丂丆与与丐丕丘不丌;
        mem[1152921536054974164] = 丙丑七万丆万丆且丌;
        val_0.丈丐丒丐丕丛东丑业 = ;
        mem[1152921536054974172] = 丅丅下丟丑专下与一;
        val_0.丗丛世世丙丝丌与丑 = ;
        val_0.丙东与与万丌丟专丛 = 丈丐世下丞与丂专丏;
        return val_0;
    }
    internal int 下丕丕业丙业丛丘世()
    {
        return (int)W9 - W8;
    }
    internal bool 下丄与丙下丛丝丁丒()
    {
        int val_3 = this.丂丆与与丐丕丘不丌;
        int val_2 = this.不丐丈丁一丘丄丐丅;
        val_2 = val_2 + (val_2 << 1);
        val_3 = val_3 + (val_3 << 1);
        return (bool)(val_2 > val_3) ? 1 : 0;
    }
    internal bool 三丝专丆丝下丕东丙()
    {
        int val_3 = this.丂丆与与丐丕丘不丌;
        int val_2 = this.不丐丈丁一丘丄丐丅;
        val_2 = val_2 + (val_2 << 1);
        val_3 = val_3 + (val_3 << 1);
        return (bool)(val_2 < val_3) ? 1 : 0;
    }
    private int 丂丂丛专丘丒东丝三()
    {
        return (int)this.不丐丈丁一丘丄丐丅 + (this.不丐丈丁一丘丄丐丅 << 1);
    }
    private int 万丘东丞丌丕且万丈()
    {
        return (int)this.丂丆与与丐丕丘不丌 + (this.丂丆与与丐丕丘不丌 << 1);
    }

}
