using UnityEngine;
internal sealed class BlackMarketPromorionLinkView : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject activeState;
    private UnityEngine.GameObject inactiveState;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.BM.世丘丈丑丘万丆丞丈 不丛丕丞三丐丅专三, PGCompany.BM.世丘丈丑丘万丆丞丈 上丗一三丙世丗丕丂)
    {
        var val_3;
        if(((上丗一三丙世丗丕丂 == null) || (不丛丕丞三丐丅专三 == null)) || (不丛丕丞三丐丅专三.丗丞丅且丙丈丂丙不() == true))
        {
            goto label_3;
        }
        
        if(不丛丕丞三丐丅专三.丗丙丐下丏丝丁丘三() == false)
        {
            goto label_4;
        }
        
        val_3 = 1;
        goto label_6;
        label_3:
        val_3 = 0;
        goto label_6;
        label_4:
        val_3 = 0;
        label_6:
        this.丈且东丑丂且万丒丅(丏业丟一东丂东丘丛:  0);
    }
    internal void 丈且东丑丂且万丒丅(int 丏业丟一东丂东丘丛)
    {
        var val_1;
        UnityEngine.GameObject val_2;
        UnityEngine.GameObject val_3;
        var val_4;
        if((丏业丟一东丂东丘丛 & 2147483648) != 0)
        {
            goto label_1;
        }
        
        if(丏业丟一东丂东丘丛 == 0)
        {
            goto label_2;
        }
        
        val_1 = 1;
        val_2 = this.activeState;
        goto label_5;
        label_1:
        val_2 = this.activeState;
        val_1 = 0;
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
        val_3 = this.inactiveState;
        val_4 = 0;
        goto label_8;
        label_2:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.activeState, 丏业丟一东丂东丘丛:  false);
        val_3 = this.inactiveState;
        val_4 = 1;
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
    }
    public BlackMarketPromorionLinkView()
    {
    
    }

}
