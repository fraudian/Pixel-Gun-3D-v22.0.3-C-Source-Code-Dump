using UnityEngine;
internal sealed class SPVCSubscriptionView : SPViewComponentBase
{
    // Fields
    private UILabel description;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        mem[1152921539238343880] = 且丘丏丁丑与丙与丁;
        if(且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙() == 27)
        {
                int val_4 = Subscription20.丑丆丑丛世丁七下东.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  七丈丒丒下下且万与());
            float val_13 = 86400f;
            val_13 = ((float)Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().专三丞丄丕丐丟丝丏(丞世不丒下上上丝丑:  val_4).丂丙丅丆丞下世丆业()) / val_13;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.description, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4.下丘丐丞丗丂丛丗东()), arg0:  (float)UnityEngine.Mathf.FloorToInt(f:  val_13)));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public SPVCSubscriptionView()
    {
        val_1 = new PGBehaviour();
    }

}
