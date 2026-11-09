using UnityEngine;
internal class 专丑丐东下与万世万.丑下丏丅与丐丆专三 : 业且丗丐丛丆丈丙丈
{
    // Methods
    public bool 东一三一万且丕世不(PGCompany.三东丏不丗世丅丌丄 丗丟上上丒丐丗丞丙)
    {
        var val_5;
        var val_6;
        val_5 = 丗丟上上丒丐丗丞丙;
        if(val_5 == null)
        {
            goto label_9;
        }
        
        int val_1 = val_5.业东丅东丌上丗丑不();
        if(val_1 == 7015)
        {
            goto label_2;
        }
        
        if(val_1 != 3015)
        {
            goto label_5;
        }
        
        val_5 = Rilisoft.Singleton<BattlePassController>.Instance;
        if(val_5.专丁丟丏丁丏不丗三() == true)
        {
            goto label_5;
        }
        
        label_9:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        if(上且丁万与丌下丐上.丑与七丁丏丘丁丂且() == false)
        {
            goto label_9;
        }
        
        label_5:
        val_6 = 1;
        return (bool)val_6;
    }
    public 专丑丐东下与万世万.丑下丏丅与丐丆专三()
    {
    
    }

}
