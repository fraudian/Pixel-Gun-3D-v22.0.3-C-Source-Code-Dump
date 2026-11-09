using UnityEngine;
internal sealed class SPVCSubscriptionMain : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject state_Subscribe;
    private UnityEngine.GameObject state_CollectReward;
    private UnityEngine.GameObject state_Resubscribe;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableInLobby;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_8;
        UnityEngine.GameObject val_9;
        mem[1152921539236679016] = 且丘丏丁丑与丙与丁;
        if(且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙() != 27)
        {
            goto label_2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Subscribe, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CollectReward, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Resubscribe, 丏业丟一东丂东丘丛:  false);
        Subscription20.丒丗业丑丛东上下一 val_3 = Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与());
        if(val_3 == 3)
        {
            goto label_6;
        }
        
        if(val_3 == 2)
        {
            goto label_7;
        }
        
        if(val_3 != 1)
        {
            goto label_8;
        }
        
        val_8 = null;
        val_9 = this.state_Subscribe;
        goto label_16;
        label_2:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        return;
        label_6:
        val_8 = null;
        val_9 = this.state_Resubscribe;
        goto label_16;
        label_7:
        val_8 = null;
        val_9 = this.state_CollectReward;
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableInLobby, 丏业丟一东丂东丘丛:  MainStoreView.丈丐丞丐上丑且丕万());
    }
    public SPVCSubscriptionMain()
    {
        val_1 = new PGBehaviour();
    }

}
