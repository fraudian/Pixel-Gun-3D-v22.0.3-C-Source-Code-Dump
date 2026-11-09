using UnityEngine;
public sealed class SpeedupEggButton : PGBehaviour
{
    // Fields
    private UILabel price;
    private UILabel time;
    private float 丆丂丆丁七丝丗一七;
    private PGCompany.丕下丆丑万世业丈丟 丄丈世业七丐三上东;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕)
    {
        this.丄丈世业七丐三上东 = 世丕丘丈丙世业东丕;
        this.丝一丅丆三东丂丞七();
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.丆丂丆丁七丝丗一七;
        if(val_1 <= 1f)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        if(this.丄丈世业七丐三上东 == null)
        {
                return;
        }
        
        if(this.丄丈世业七丐三上东.丈下丂丆不丕丐丌丂() == null)
        {
                return;
        }
        
        this.price.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丄丈世业七丐三上东.丈下丂丆不丕丐丌丂().丂丁丏一丙丛业且丌());
        this.time.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.丄丈世业七丐三上东.丛与丏丏七丟与世专(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        this.丆丂丆丁七丝丗一七 = UnityEngine.Time.realtimeSinceStartup;
    }
    public SpeedupEggButton()
    {
    
    }

}
