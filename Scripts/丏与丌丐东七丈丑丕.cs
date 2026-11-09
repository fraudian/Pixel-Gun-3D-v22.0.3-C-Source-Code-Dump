using UnityEngine;
internal class 丏与丌丐东七丈丑丕 : IEnumerator
{
    // Fields
    private int 丗与与丌丈与一丁丆;
    private System.Collections.Generic.List<丞丅与与丈丕丟丑丘> 丑丘七丄万丐三下世;
    
    // Properties
    public 丞丅与与丈丕丟丑丘 下世丛三七丐业丄下 { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丏与丌丐东七丈丑丕(System.Collections.Generic.List<丞丅与与丈丕丟丑丘> 上业丟世三与七七三)
    {
        this.丑丘七丄万丐三下世 = 上业丟世三与七七三;
        this.丗与与丌丈与一丁丆 = 0;
    }
    public 丞丅与与丈丕丟丑丘 丒丒丆丙与且丅不丌()
    {
        return (丞丅与与丈丕丟丑丘)this.丑丘七丄万丐三下世.Item[this.丗与与丌丈与一丁丆];
    }
    public void Reset()
    {
        this.丗与与丌丈与一丁丆 = 0;
    }
    public bool MoveNext()
    {
        int val_1 = this.丗与与丌丈与一丁丆 + 1;
        this.丗与与丌丈与一丁丆 = val_1;
        return (bool)(val_1 < this.丑丘七丄万丐三下世.Count) ? 1 : 0;
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return this.丒丒丆丙与且丅不丌();
    }

}
