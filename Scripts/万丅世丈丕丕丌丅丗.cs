using UnityEngine;
internal class 万丅世丈丕丕丌丅丗
{
    // Fields
    internal NetworkStartTable 不且上一上丐三万丛;
    public string 丆世丘丒丒丏上且丗;
    public string 丛三三与丁丘丄丑下;
    public bool 万丝一万丐且丌业丛;
    public int 丒东丑丟世与下且丟;
    
    // Methods
    internal 万丅世丈丕丕丌丅丗(NetworkStartTable 不且上一上丐三万丛, int 丒东丑丟世与下且丟)
    {
        this.不且上一上丐三万丛 = 不且上一上丐三万丛;
        this.丒东丑丟世与下且丟 = 丒东丑丟世与下且丟;
        this.丑丁不万丈丟万且业();
    }
    public void 丑丁不万丈丟万且业()
    {
        NetworkStartTable val_3;
        NetworkStartTable val_4;
        bool val_5;
        val_3 = this;
        if(this.不且上一上丐三万丛 == 0)
        {
                return;
        }
        
        val_4 = this.不且上一上丐三万丛;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        this.丆世丘丒丒丏上且丗 = this.不且上一上丐三万丛.丈三世丞丕万丄七丂;
        goto label_5;
        label_4:
        this.丆世丘丒丒丏上且丗 = this.不且上一上丐三万丛.丈三世丞丕万丄七丂;
        if(this.不且上一上丐三万丛 == null)
        {
            goto label_6;
        }
        
        val_4 = this.不且上一上丐三万丛;
        label_5:
        this.丛三三与丁丘丄丑下 = this.不且上一上丐三万丛.丂丈丐不丏万三七丐;
        label_15:
        this.万丝一万丐且丌业丛 = this.不且上一上丐三万丛.与丛下丐丆丞万万下;
        label_16:
        if(this.不且上一上丐三万丛.丌丑丛业丈丘世丞丕 == 0)
        {
                return;
        }
        
        if(this.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.万丝一万丐且丌业丛 != false)
        {
                val_5 = 1;
        }
        else
        {
                val_3 = this.不且上一上丐三万丛;
            val_5 = this.不且上一上丐三万丛.与丛下丐丆丞万万下;
        }
        
        mem[1152921540397859768] = val_5;
        return;
        label_6:
        this.丛三三与丁丘丄丑下 = this.不且上一上丐三万丛.丂丈丐不丏万三七丐;
        if(this.不且上一上丐三万丛 != null)
        {
            goto label_15;
        }
        
        this.万丝一万丐且丌业丛 = this.不且上一上丐三万丛.与丛下丐丆丞万万下;
        if(this.不且上一上丐三万丛 != null)
        {
            goto label_16;
        }
    
    }

}
