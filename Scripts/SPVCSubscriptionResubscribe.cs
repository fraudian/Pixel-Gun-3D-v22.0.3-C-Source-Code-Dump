using UnityEngine;
internal sealed class SPVCSubscriptionResubscribe : SPViewComponentBase
{
    // Fields
    private UILabel aditionalTime;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        mem[1152921539237009608] = 且丘丏丁丑与丙与丁;
        Subscription20.丒丗业丑丛东上下一 val_2 = Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与());
        if((val_2 == 3) && (且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙() == 27))
        {
                float val_14 = 86400f;
            val_14 = ((float)Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().专三丞丄丕丐丟丝丏(丞世不丒下上上丝丑:  Subscription20.丑丆丑丛世丁七下东.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  val_2.七丈丒丒下下且万与())).丂丙丅丆丞下世丆业()) / val_14;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.aditionalTime, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12560"), arg0:  (float)UnityEngine.Mathf.FloorToInt(f:  val_14)));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public SPVCSubscriptionResubscribe()
    {
        val_1 = new PGBehaviour();
    }

}
