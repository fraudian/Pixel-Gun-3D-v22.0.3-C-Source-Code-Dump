using UnityEngine;
internal abstract class 丆丘丆丞丙下丆丟丅
{
    // Fields
    private System.Action 丟丘丙丄丅万丏与丗;
    
    // Methods
    internal abstract string 丄且丙丂丆不一万七(); // 0
    internal abstract UnityEngine.Color 丝三世专丞不丈丘丕(); // 0
    internal virtual void 七丒丈丗与丟不丐东()
    {
        if(this.丟丘丙丄丅万丏与丗 == null)
        {
                return;
        }
        
        this.丟丘丙丄丅万丏与丗.Invoke();
    }
    internal abstract float 且丆丁丑万丁丁丌世(); // 0
    internal virtual void 七丗丈丒七丒丕世与(System.Action 丟丘丙丄丅万丏与丗, object[] 专丒丌丆下丐丞丟丞)
    {
        this.丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
    }
    protected 丆丘丆丞丙下丆丟丅()
    {
    
    }

}
