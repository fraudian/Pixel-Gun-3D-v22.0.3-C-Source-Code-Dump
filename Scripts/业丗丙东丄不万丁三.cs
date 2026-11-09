using UnityEngine;
internal class 业丗丙东丄不万丁三
{
    // Fields
    internal Rilisoft.丝丑丂丛万丐丈丘且[] 丝丙一丁下世丆与丑;
    
    // Properties
    internal int 东丅不丄丈一丘七东 { get; }
    internal int 不下下丞三一丘丗丐 { get; set; }
    
    // Methods
    internal 业丗丙东丄不万丁三(int[] 与且丙丘上丞丘丙业)
    {
        Rilisoft.丝丑丂丛万丐丈丘且[] val_3 = new Rilisoft.丝丑丂丛万丐丈丘且[0];
        this.丝丙一丁下世丆与丑 = val_3;
        if(与且丙丘上丞丘丙业.Length < 1)
        {
                return;
        }
        
        goto label_3;
        label_7:
        val_3 = this.丝丙一丁下世丆与丑;
        label_3:
        int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        long val_4 = 0;
        int val_3 = 与且丙丘上丞丘丙业[0];
        val_3[0] = 0;
        val_3[0] = 0;
        val_4 = val_4 + 1;
        if(val_4 < 与且丙丘上丞丘丙业.Length)
        {
            goto label_7;
        }
    
    }
    internal 业丗丙东丄不万丁三(int 丝丂丘丄丅且三丌三)
    {
        this.丝丙一丁下世丆与丑 = new Rilisoft.丝丑丂丛万丐丈丘且[0];
    }
    internal bool 丟不下下且业丛丄丏(int 丆丗丐世丐丆不丁丑)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        return (bool)this.丟不下下且业丛丄丏(丆一与丌丙丕丝且丏:  new Rilisoft.丝丑丂丛万丐丈丘且());
    }
    internal bool 丟不下下且业丛丄丏(Rilisoft.丝丑丂丛万丐丈丘且 丆一与丌丙丕丝且丏)
    {
        int val_1 = System.Array.IndexOf<Rilisoft.丝丑丂丛万丐丈丘且>(array:  this.丝丙一丁下世丆与丑, value:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = 丆一与丌丙丕丝且丏.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = 丆一与丌丙丕丝且丏.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = 丆一与丌丙丕丝且丏.上万三丆专丏丒丗业});
        val_1 = (val_1 >> 31) ^ 1;
        return (bool)val_1;
    }
    internal int 丛丄三万丁丙丐丞丂()
    {
        if(this.丝丙一丁下世丆与丑 != null)
        {
                return (int)this.丝丙一丁下世丆与丑.Length;
        }
        
        return (int)this.丝丙一丁下世丆与丑.Length;
    }
    internal int 丂丑丞丝且万丐万丟(int 丞世不丒下上上丝丑)
    {
    
    }
    internal void 丘丕丈下东一丑上丗(int 丞世不丒下上上丝丑, int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丝丙一丁下世丆与丑[((long)(int)(丞世不丒下上上丝丑)) << 4] = 0;
        this.丝丙一丁下世丆与丑[((long)(int)(丞世不丒下上上丝丑)) << 4] = 0;
    }

}
