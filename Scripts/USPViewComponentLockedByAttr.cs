using UnityEngine;
internal sealed class USPViewComponentLockedByAttr : SPViewComponentBase
{
    // Fields
    private UIBasicSprite icon;
    private UILabel textLabel;
    private UILabel count;
    
    // Methods
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        string val_6;
        UILabel val_11;
        int val_12;
        val_11 = this;
        if(103167 == 0)
        {
                return;
        }
        
        if(103167.不丑三丌丈丞丈一丆() == null)
        {
                return;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<PGCompany.Attributes.丝万专丆丂丘丌世丟>(source:  不丑三丌丈丞丈一丆())) == null)
        {
                return;
        }
        
        val_12 = val_3.AttributeIndex;
        System.Nullable<PGCompany.AttributeSystem.丛丅丘东丗丒万丝丝> val_4 = PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丂上上上且不丄丕丛(丂世丒下丁三丄东丆:  val_12, 丙业与丙丗丝不丈东:  val_3.Value);
        if(val_6.HasValue == false)
        {
                return;
        }
        
        val_12 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  public PGCompany.AttributeSystem.丛丅丘东丗丒万丝丝 System.Nullable<PGCompany.AttributeSystem.丛丅丘东丗丒万丝丝>::get_Value());
        val_11 = this.textLabel;
        val_11.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6);
    }
    public USPViewComponentLockedByAttr()
    {
    
    }

}
