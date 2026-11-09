using UnityEngine;
internal sealed class 专丟丈上丕七丌丝上 : 丄世丕丈一丈东丆丐
{
    // Fields
    private 不丈业丘丑上丟丈丁[] 专且丁丈不不丙专丙;
    
    // Methods
    public 专丟丈上丕七丌丝上(System.Collections.Generic.Dictionary<string, object> 丒丐丈下丛丛丒丈丏, 与七丙丌丈丅上丝不 丈丞丏三丒丁丗丘东)
    {
        this.专且丁丈不不丙专丙 = 丈丞丏三丒丁丗丘东.丘丐一丁东且丕世丝(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
    }
    internal int 一与丞与丗丌三丙丁(int 专世专丟丝丌与丘上)
    {
        不丈业丘丑上丟丈丁[] val_1;
        var val_2;
        var val_3;
        不丈业丘丑上丟丈丁 val_4;
        val_1 = this;
        val_2 = 0;
        goto label_0;
        label_12:
        val_3 = 0;
        label_9:
        不丈业丘丑上丟丈丁 val_1 = this.专且丁丈不不丙专丙[0];
        if(val_3 >= (mem[this.专且丁丈不不丙专丙[0x0][1] + 24]))
        {
            goto label_4;
        }
        
        不丈业丘丑上丟丈丁 val_2 = this.专且丁丈不不丙专丙[0];
        val_3 = val_3 + 1;
        if((this.专且丁丈不不丙专丙[0x0][1].业万上丆丐丞且丒七 + 32) != 专世专丟丝丌与丘上)
        {
            goto label_9;
        }
        
        goto label_10;
        label_4:
        val_2 = 1;
        label_0:
        if(val_2 < this.专且丁丈不不丙专丙.Length)
        {
            goto label_12;
        }
        
        val_4 = 0;
        return (int)val_4;
        label_10:
        val_1 = this.专且丁丈不不丙专丙;
        val_4 = val_1[0];
        return (int)val_4;
    }
    internal override int 三七世丝不丑丅丈丆()
    {
        if(this.专且丁丈不不丙专丙 != null)
        {
                return (int)this.专且丁丈不不丙专丙.Length;
        }
        
        return (int)this.专且丁丈不不丙专丙.Length;
    }
    internal override int 丈丏一丌丗丂业丟丕(int 丈丘丝一丗下丈丐不, int 专世专丟丝丌与丘上)
    {
        int val_2 = this.一与丞与丗丌三丙丁(专世专丟丝丌与丘上:  专世专丟丝丌与丘上);
        val_2 = val_2 + ((this.丛丕丐丏丒一业专世(丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不)) * 10);
        return (int)val_2;
    }

}
