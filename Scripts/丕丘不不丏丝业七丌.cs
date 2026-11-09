using UnityEngine;
public class 丕丘不不丏丝业七丌
{
    // Fields
    private const uint 业与丞不丒丞丕丏丗 = 1842502087;
    private const uint 丆丘丘丘丂世丏丌丈 = 1357980759;
    private const uint 丂七且上万丏丗丘丒 = 273326509;
    private static uint 丘丛丆七与丒世下丛;
    private uint 丆丛丑世下一丐且丕;
    private uint 丌丗丏丏丛东专丁且;
    private uint 丁丂专业丁丅丅丈丙;
    private uint 丐丆丂丒丁万丈丛丅;
    
    // Methods
    public 丕丘不不丏丝业七丌(uint 下下丏一丙不丘丌丞)
    {
        this.丌七业丏丐丗丄且业(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞);
    }
    public 丕丘不不丏丝业七丌()
    {
        null = null;
        丕丘不不丏丝业七丌.丘丛丆七与丒世下丛 = 丕丘不不丏丝业七丌.丘丛丆七与丒世下丛 + 1;
        this.丌七业丏丐丗丄且业(下下丏一丙不丘丌丞:  丕丘不不丏丝业七丌.丘丛丆七与丒世下丛);
    }
    public uint 专丛业上东丛世不丟()
    {
        uint val_1 = 0;
        val_1 = val_1 ^ this.丐丆丂丒丁万丈丛丅;
        val_1 = val_1 ^ (this.丐丆丂丒丁万丈丛丅 >> 19);
        this.丆丛丑世下一丐且丕 = this.丌丗丏丏丛东专丁且;
        this.丌丗丏丏丛东专丁且 = this.丁丂专业丁丅丅丈丙;
        this.丁丂专业丁丅丅丈丙 = this.丐丆丂丒丁万丈丛丅;
        this.丐丆丂丒丁万丈丛丅 = val_1;
        return val_1;
    }
    public int 三七与丈三丗丟丄一(int 七丝东丛东丝且丆不)
    {
        this.丆丛丑世下一丐且丕 = this.丌丗丏丏丛东专丁且;
        this.丌丗丏丏丛东专丁且 = this.丁丂专业丁丅丅丈丙;
        var val_2 = 0;
        val_2 = val_2 ^ this.丐丆丂丒丁万丈丛丅;
        uint val_1 = val_2 ^ (this.丐丆丂丒丁万丈丛丅 >> 19);
        var val_3 = (long)七丝东丛东丝且丆不;
        val_3 = val_1 / val_3;
        val_3 = val_1 - (val_3 * 七丝东丛东丝且丆不);
        this.丁丂专业丁丅丅丈丙 = this.丐丆丂丒丁万丈丛丅;
        this.丐丆丂丒丁万丈丛丅 = val_1;
        return (int)val_3;
    }
    public int 三七与丈三丗丟丄一(int 丒丛七丄世业东丝丁, int 七丝东丛东丝且丆不)
    {
        this.丆丛丑世下一丐且丕 = this.丌丗丏丏丛东专丁且;
        this.丌丗丏丏丛东专丁且 = this.丁丂专业丁丅丅丈丙;
        uint val_2 = 0;
        int val_1 = 七丝东丛东丝且丆不 - 丒丛七丄世业东丝丁;
        val_2 = val_2 ^ this.丐丆丂丒丁万丈丛丅;
        this.丁丂专业丁丅丅丈丙 = this.丐丆丂丒丁万丈丛丅;
        val_2 = val_2 ^ (this.丐丆丂丒丁万丈丛丅 >> 19);
        var val_3 = (long)val_1;
        val_3 = val_2 / val_3;
        val_3 = val_2 - (val_3 * val_1);
        val_3 = val_3 + 丒丛七丄世业东丝丁;
        this.丐丆丂丒丁万丈丛丅 = val_2;
        return (int)val_3;
    }
    public float 丗上世丐业世七丘不()
    {
        float val_2 = 2.328306E-10f;
        uint val_1 = 0;
        val_1 = val_1 ^ this.丐丆丂丒丁万丈丛丅;
        val_1 = val_1 ^ (this.丐丆丂丒丁万丈丛丅 >> 19);
        val_2 = (float)(double)val_1 * val_2;
        this.丆丛丑世下一丐且丕 = this.丌丗丏丏丛东专丁且;
        this.丌丗丏丏丛东专丁且 = this.丁丂专业丁丅丅丈丙;
        this.丁丂专业丁丅丅丈丙 = this.丐丆丂丒丁万丈丛丅;
        this.丐丆丂丒丁万丈丛丅 = val_1;
        return (float)val_2;
    }
    public float 丏丐与丄且丙丑丗丄()
    {
        float val_2 = 4.656613E-10f;
        uint val_1 = 0;
        val_1 = val_1 ^ this.丐丆丂丒丁万丈丛丅;
        val_1 = val_1 ^ (this.丐丆丂丒丁万丈丛丅 >> 19);
        val_2 = (float)val_1 * val_2;
        this.丆丛丑世下一丐且丕 = this.丌丗丏丏丛东专丁且;
        this.丌丗丏丏丛东专丁且 = this.丁丂专业丁丅丅丈丙;
        this.丁丂专业丁丅丅丈丙 = this.丐丆丂丒丁万丈丛丅;
        this.丐丆丂丒丁万丈丛丅 = val_1;
        return (float)val_2;
    }
    public double 丁东丌七丙丟且丄一()
    {
        double val_2 = 2.3283064370808E-10;
        uint val_1 = 0;
        val_1 = val_1 ^ this.丐丆丂丒丁万丈丛丅;
        val_1 = val_1 ^ (this.丐丆丂丒丁万丈丛丅 >> 19);
        val_2 = (double)val_1 * val_2;
        this.丆丛丑世下一丐且丕 = this.丌丗丏丏丛东专丁且;
        this.丌丗丏丏丛东专丁且 = this.丁丂专业丁丅丅丈丙;
        this.丁丂专业丁丅丅丈丙 = this.丐丆丂丒丁万丈丛丅;
        this.丐丆丂丒丁万丈丛丅 = val_1;
        return (double)val_2;
    }
    public double 与七三业三丄专丕丒()
    {
        double val_2 = 4.65661287416159E-10;
        uint val_1 = 0;
        val_1 = val_1 ^ this.丐丆丂丒丁万丈丛丅;
        val_1 = val_1 ^ (this.丐丆丂丒丁万丈丛丅 >> 19);
        val_2 = (double)val_1 * val_2;
        this.丆丛丑世下一丐且丕 = this.丌丗丏丏丛东专丁且;
        this.丌丗丏丏丛东专丁且 = this.丁丂专业丁丅丅丈丙;
        this.丁丂专业丁丅丅丈丙 = this.丐丆丂丒丁万丈丛丅;
        this.丐丆丂丒丁万丈丛丅 = val_1;
        return (double)val_2;
    }
    public void 丌七业丏丐丗丄且业(uint 下下丏一丙不丘丌丞)
    {
        uint val_2 = 1357980759 ^ (下下丏一丙不丘丌丞 >> 5);
        uint val_3 = 273326509 ^ (下下丏一丙不丘丌丞 >> 7);
        var val_5 = 4;
        this.丆丛丑世下一丐且丕 = 下下丏一丙不丘丌丞;
        this.丌丗丏丏丛东专丁且 = 下下丏一丙不丘丌丞 ^ 1842502087;
        this.丁丂专业丁丅丅丈丙 = val_2;
        this.丐丆丂丒丁万丈丛丅 = val_3;
        do
        {
            uint val_4 = 0;
            val_4 = val_4 ^ val_3;
            val_4 = val_4 ^ (val_3 >> 19);
            val_5 = val_5 - 1;
        }
        while(val_5 != 0);
        
        this.丆丛丑世下一丐且丕 = val_4;
        this.丌丗丏丏丛东专丁且 = val_2;
        this.丁丂专业丁丅丅丈丙 = val_3;
        this.丐丆丂丒丁万丈丛丅 = val_4;
    }
    private static 丕丘不不丏丝业七丌()
    {
    
    }

}
