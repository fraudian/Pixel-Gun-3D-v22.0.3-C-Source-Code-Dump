using UnityEngine;
private sealed class InfoWindowController.丞丏丙丐与东业且不 : InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    private readonly string 丌丄丘专三丄丞丐七;
    private readonly int 丁三丆上丆丗丒且丏;
    
    // Methods
    internal InfoWindowController.丞丏丙丐与东业且不(AchieveBox 不丌丗丂丆业丂丏世, int 丗七丟丈三不丕一三, string 丐一业丏上七丆下丌)
    {
        int val_2 = val_1;
        val_1 = new System.Object();
        mem[1152921538057916152] = 不丌丗丂丆业丂丏世;
        this.丁三丆上丆丗丒且丏 = 丗七丟丈三不丕一三;
        if(val_2 == null)
        {
                val_2 = System.String.alignConst;
        }
        
        this.丌丄丘专三丄丞丐七 = val_2;
    }
    public override void 一丌一丞世不下丄专()
    {
        bool val_20;
        string val_3 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4786"), arg0:  this.丁三丆上丆丗丒且丏);
        bool val_4 = System.String.Equals(a:  this.丌丄丘专三丄丞丐七, b:  "coins", comparisonType:  4);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        if(val_5._offerwallRewardCoinsParent != 0)
        {
                InfoWindowController val_7 = InfoWindowController.丑七不且上丗丁一世();
            val_7._offerwallRewardCoinsParent.SetActive(value:  val_4);
        }
        
        if(val_4 != false)
        {
                InfoWindowController val_9 = InfoWindowController.丑七不且上丗丁一世();
            if(val_9._offerwallRewardCoins != 0)
        {
                InfoWindowController val_11 = InfoWindowController.丑七不且上丗丁一世();
            val_11._offerwallRewardCoins.Text = val_3;
        }
        
        }
        
        val_20 = System.String.Equals(a:  this.丌丄丘专三丄丞丐七, b:  "gems", comparisonType:  4);
        InfoWindowController val_13 = InfoWindowController.丑七不且上丗丁一世();
        if(val_13._offerwallRewardGemsParent != 0)
        {
                InfoWindowController val_15 = InfoWindowController.丑七不且上丗丁一世();
            val_15._offerwallRewardGemsParent.SetActive(value:  val_20);
        }
        
        if(val_20 != false)
        {
                InfoWindowController val_17 = InfoWindowController.丑七不且上丗丁一世();
            val_20 = val_17._offerwallRewardGems;
            if(val_20 != 0)
        {
                InfoWindowController val_19 = InfoWindowController.丑七不且上丗丁一世();
            val_20 = val_19._offerwallRewardGems;
            val_20.Text = val_3;
        }
        
        }
        
        this.ShowBox();
    }

}
