using UnityEngine;
internal sealed class SPViewComponentPiggyPromotion : SPViewComponentBase
{
    // Fields
    private UILabel levelLabel;
    private UnityEngine.GameObject state_purchased;
    private UnityEngine.GameObject state_notPurchased;
    private System.Collections.Generic.List<SPViewComponentBase> viewCompnentsToUpdate;
    private PGCompany.MainStore.东丆丒丄丂丆上丈业 丑丘丙上丁丌一丗万;
    
    // Methods
    private void OnEnable()
    {
        PGCompany.Piggy.业世且丐丕专丛专丐.丕东上三且一丙专与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void SPViewComponentPiggyPromotion::丕丒下丛专三东专丁(int 下丝丘丁专丐丅丛丝)));
        PGCompany.Piggy.业世且丐丕专丛专丐.丂与下三丌一丙丏一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPiggyPromotion::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.下不不上丒与一丁专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPiggyPromotion::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.万丞下世东且专丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPiggyPromotion::丑丈丆万丅上丞丗丐()));
    }
    private void OnDisable()
    {
        PGCompany.Piggy.业世且丐丕专丛专丐.丑丐丅丕七一丞丗且(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void SPViewComponentPiggyPromotion::丕丒下丛专三东专丁(int 下丝丘丁专丐丅丛丝)));
        PGCompany.Piggy.业世且丐丕专丛专丐.丐不丈丟丛丌万世丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPiggyPromotion::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.丂且丆丙一丈丙丛万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPiggyPromotion::丑丈丆万丅上丞丗丐()));
        PGCompany.Piggy.业世且丐丕专丛专丐.三丗丆丕丟上丈万三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPiggyPromotion::丑丈丆万丅上丞丗丐()));
    }
    private void 丕丒下丛专三东专丁(int 下丝丘丁专丐丅丛丝)
    {
        if(this.丑丘丙上丁丌一丗万 == null)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void 丑丈丆万丅上丞丗丐()
    {
        if(this.丑丘丙上丁丌一丗万 == null)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        PGCompany.MainStore.东丆丒丄丂丆上丈业 val_2;
        mem[1152921539231009752] = 且丘丏丁丑与丙与丁;
        if(且丘丏丁丑与丙与丁 != null)
        {
                var val_1 = (null == null) ? 且丘丏丁丑与丙与丁 : 0;
        }
        else
        {
                val_2 = 0;
        }
        
        this.丑丘丙上丁丌一丗万 = val_2;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        int val_3;
        UnityEngine.GameObject val_10;
        var val_11;
        List.Enumerator<T> val_1 = this.viewCompnentsToUpdate.GetEnumerator();
        label_4:
        if((264585696 & 1) == 0)
        {
            goto label_2;
        }
        
        if(val_3.丐丏七丌丕丗业且上() == null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_3 = this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10431"), arg0:  val_3));
        if((this.丑丘丙上丁丌一丗万.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "state.purchased")) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_purchased, 丏业丟一东丂东丘丛:  true);
            val_10 = this.state_notPurchased;
            val_11 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_purchased, 丏业丟一东丂东丘丛:  false);
            val_10 = this.state_notPurchased;
            val_11 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
    }
    public SPViewComponentPiggyPromotion()
    {
        this.viewCompnentsToUpdate = new System.Collections.Generic.List<SPViewComponentBase>();
        this = new PGBehaviour();
    }

}
