using UnityEngine;
internal sealed class 丝专专丛三丅丐丛丄
{
    // Fields
    internal System.Collections.Generic.Dictionary<string, 丈万且丗丂丝丙一东> 业丌七业业七丞与丄;
    
    // Methods
    internal void 业丒丈丏一万不丏世(NetworkStartTable 不且上一上丐三万丛)
    {
        string val_7;
        NetworkStartTable val_8 = 不且上一上丐三万丛;
        if((System.String.IsNullOrEmpty(value:  不且上一上丐三万丛.丈三世丞丕万丄七丂)) == true)
        {
                return;
        }
        
        val_7 = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
        if((val_7.Equals(value:  "-1")) == true)
        {
                return;
        }
        
        val_7 = System.String.Format(format:  "{0}-{1}", arg0:  不且上一上丐三万丛.丈三世丞丕万丄七丂, arg1:  不且上一上丐三万丛.业丏三七专东丁丕丂);
        if((this.业丌七业业七丞与丄.ContainsKey(key:  val_7)) != false)
        {
                this.业丌七业业七丞与丄.Item[val_7].丑七下业与丕丛丅丕(不且上一上丐三万丛:  val_8 = 不且上一上丐三万丛);
            return;
        }
        
        val_8 = this.业丌七业业七丞与丄;
        val_8.Add(key:  val_7, value:  new 丈万且丗丂丝丙一东(不且上一上丐三万丛:  val_8));
    }
    internal void 丙上丆且万丏与丁丐()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 0;
        goto label_1;
        label_14:
        val_4 = null;
        val_4 = null;
        if(val_1.一七不三丌专三丆一 != false)
        {
                if(val_1.丗丈东丕不丘三丞业.isScenarioBot == true)
        {
            goto label_9;
        }
        
        }
        
        this.业丒丈丏一万不丏世(不且上一上丐三万丛:  Item[0]);
        label_9:
        val_3 = 1;
        label_1:
        val_5 = null;
        val_5 = null;
        if(val_3 < Count)
        {
            goto label_14;
        }
    
    }
    internal void 且七丙丄丘一丄上不()
    {
        this.业丌七业业七丞与丄.Clear();
    }
    public 丝专专丛三丅丐丛丄()
    {
        this.业丌七业业七丞与丄 = new System.Collections.Generic.Dictionary<System.String, 丈万且丗丂丝丙一东>(capacity:  10);
    }

}
