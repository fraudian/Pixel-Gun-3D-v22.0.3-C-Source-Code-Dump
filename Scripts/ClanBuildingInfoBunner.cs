using UnityEngine;
public class ClanBuildingInfoBunner : SimpleBunner
{
    // Fields
    private UILabel titleLabel;
    private UILabel descriptionLabel;
    private ClanBuildingEnterButton enterButton;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.丏丌丝丕丐七丈且丒 上丟专三丙丅丆丛且)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  上丟专三丙丅丆丛且.七业丑不七丐业丟丂());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  上丟专三丙丅丆丛且.东且丏丆万与东丙万());
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  上丟专三丙丅丆丛且.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.enterButton, 丏业丟一东丂东丘丛:  true);
            this.enterButton.丛不丈不丙丟不三上 = 上丟专三丙丅丆丛且;
            this.enterButton.丝一丅丆三东丂丞七();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.enterButton, 丏业丟一东丂东丘丛:  false);
    }
    public ClanBuildingInfoBunner()
    {
    
    }

}
