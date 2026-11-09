using UnityEngine;
internal sealed class SPVCSubscriptionCollectReward : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject sub_state_Active;
    private UnityEngine.GameObject sub_state_Expired;
    private UnityEngine.GameObject nextRewardTimerHolder;
    private PGCompany.TimerUI nextRewardTimer;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        mem[1152921539236145384] = 且丘丏丁丑与丙与丁;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        long val_17;
        UnityEngine.GameObject val_18;
        UnityEngine.GameObject val_19;
        var val_20;
        if(((Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  七丈丒丒下下且万与())) != 2) || (X21.不业丙丒丂丞下丆丙() != 27))
        {
            goto label_4;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nextRewardTimerHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sub_state_Active, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sub_state_Expired, 丏业丟一东丂东丘丛:  false);
        Subscription20.丘丛不东丒丆丁丑丁 val_7 = Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().专三丞丄丕丐丟丝丏(丞世不丒下上上丝丑:  Subscription20.丑丆丑丛世丁七下东.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  X21.七丈丒丒下下且万与()));
        val_17 = PixelTime.丙丅丅业丟丁世丁丗();
        Subscription20.专不万丏丝下丗万万 val_9 = val_7.丄丆专丁丕丆丐丝丝(丝丙一丝丈丂不丙一:  val_17);
        if(val_9 == 3)
        {
            goto label_12;
        }
        
        if(val_9 != 2)
        {
            goto label_26;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sub_state_Active, 丏业丟一东丂东丘丛:  true);
        val_17 = PixelTime.丙丅丅业丟丁世丁丗();
        if((val_7.业丆七丙丝丌丁万丏(丝丙一丝丈丂不丙一:  val_17)) == false)
        {
            goto label_26;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.nextRewardTimerHolder, 丏业丟一东丂东丘丛:  true);
        val_17 = this.nextRewardTimer;
        if(val_17 == null)
        {
            goto label_26;
        }
        
        val_17.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_7.丁丏万丄丆丅下丙丗(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗()), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void SPVCSubscriptionCollectReward::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        goto label_26;
        label_4:
        val_18 = this.gameObject;
        val_19 = val_18;
        val_20 = 0;
        goto label_29;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sub_state_Expired, 丏业丟一东丂东丘丛:  true);
        label_26:
        val_18 = this.gameObject;
        val_20 = 1;
        val_19 = val_18;
        label_29:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_19, 丏业丟一东丂东丘丛:  true);
    }
    public SPVCSubscriptionCollectReward()
    {
        val_1 = new PGBehaviour();
    }

}
