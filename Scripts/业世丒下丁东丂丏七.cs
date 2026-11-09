using UnityEngine;
public class 业世丒下丁东丂丏七
{
    // Fields
    private string 丏七丙不丁丁丒丒丗;
    private int 丒专丘丗专丝三丛丘;
    private string 三七一丁上且丐丝丌;
    
    // Methods
    public 业世丒下丁东丂丏七(string 三七一丁上且丐丝丌, string 丏七丙不丁丁丒丒丗, int 丒专丘丗专丝三丛丘)
    {
        val_1 = new System.Object();
        this.三七一丁上且丐丝丌 = 三七一丁上且丐丝丌;
        this.丏七丙不丁丁丒丒丗 = val_1;
        this.丒专丘丗专丝三丛丘 = 丒专丘丗专丝三丛丘;
    }
    public string 与丈上丐丄丛丏丈丌()
    {
        return (string)this.丏七丙不丁丁丒丒丗;
    }
    public int 业万世丂下丂业三丛()
    {
        return (int)this.丒专丘丗专丝三丛丘;
    }
    public string 与丕丘丒丄丗丄丟丘()
    {
        return (string)this.三七一丁上且丐丝丌;
    }
    public override string ToString()
    {
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.三七一丁上且丐丝丌 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.三七一丁上且丐丝丌 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.三七一丁上且丐丝丌;
        val_1[1] = " : ";
        val_1[2] = this.丏七丙不丁丁丒丒丗;
        val_1[3] = " : ";
        val_1[4] = this.丒专丘丗专丝三丛丘;
        return (string)+val_1;
    }

}
