using UnityEngine;
internal class PixelPassTaskCellViewBase : PGBehaviour
{
    // Fields
    private PGCompany.TimerUI timerUi;
    private UIWidget holder;
    private int holderSize;
    private 丕丐丟丒丆丒丟丅丈 丅万七丐丗下业世丆;
    
    // Properties
    internal 丕丐丟丒丆丒丟丅丈 七丌丁与业丌丘东丝 { get; }
    
    // Methods
    internal 丕丐丟丒丆丒丟丅丈 下万三丁丈万专丙业()
    {
        return (丕丐丟丒丆丒丟丅丈)this.丅万七丐丗下业世丆;
    }
    internal virtual void 丈且东丑丂且万丒丅(丕丐丟丒丆丒丟丅丈 世丝专丝与丑业丑万)
    {
        this.丅万七丐丗下业世丆 = 世丝专丝与丑业丑万;
        goto typeof(PixelPassTaskCellViewBase).__il2cppRuntimeField_178;
    }
    internal virtual void 丝一丅丆三东丂丞七()
    {
        this.holder.width = this.holderSize;
        this.holder.ResetAndUpdateAnchors();
    }
    public PixelPassTaskCellViewBase()
    {
    
    }

}
