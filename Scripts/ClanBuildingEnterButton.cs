using UnityEngine;
internal class ClanBuildingEnterButton : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject state_Locked;
    private UnityEngine.GameObject state_Unlocked;
    private PGCompany.TimerUI unlockTimer;
    internal PGCompany.丏丌丝丕丐七丈且丒 丛不丈不丙丟不三上;
    private ClanBuildingEnterButton.丙丙世七丆丝七丗丐 丝丘丆世丞上丆丙丑;
    private ClanBuildingEnterButton.丙丙世七丆丝七丗丐 且上丘丄丘业丐丅业;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.丏丌丝丕丐七丈且丒 上丟专三丙丅丆丛且)
    {
        this.丛不丈不丙丟不三上 = 上丟专三丙丅丆丛且;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        this.丝丘丆世丞上丆丙丑 = this.且上丘丄丘业丐丅业;
        this.且上丘丄丘业丐丅业 = this.不业丌三丅丟丌下丌();
        this.不东丈丕不丝一东丙();
        if(this.且上丘丄丘业丐丅业 != 2)
        {
                if(this.且上丘丄丘业丐丅业 != 1)
        {
                return;
        }
        
            this.丒且万丝上万丒丒下();
            return;
        }
        
        this.丑丆不三与丅丐下专();
    }
    private ClanBuildingEnterButton.丙丙世七丆丝七丗丐 不业丌三丅丟丌下丌()
    {
        int val_6;
        PGCompany.丏丌丝丕丐七丈且丒 val_7;
        val_6 = this;
        val_7 = this.丛不丈不丙丟不三上;
        if(val_7 == null)
        {
                return (丙丙世七丆丝七丗丐)((PGCompany.七丄三丝丐业丄丅丝.丝丒丟丑丐丘七上丕(丘丗丈东下业丟丟丑:  val_6 = this.丛不丈不丙丟不三上.业东丅东丌上丗丑不())) <= 0) ? (1 + 1) : 1;
        }
        
        if((PGCompany.七丄三丝丐业丄丅丝.丞丄丝丕不一万世丛(丘丗丈东下业丟丟丑:  val_7.业东丅东丌上丗丑不())) != false)
        {
                val_7 = 2;
            return (丙丙世七丆丝七丗丐)((PGCompany.七丄三丝丐业丄丅丝.丝丒丟丑丐丘七上丕(丘丗丈东下业丟丟丑:  val_6)) <= 0) ? (1 + 1) : 1;
        }
        
        return (丙丙世七丆丝七丗丐)((PGCompany.七丄三丝丐业丄丅丝.丝丒丟丑丐丘七上丕(丘丗丈东下业丟丟丑:  val_6)) <= 0) ? (1 + 1) : 1;
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Locked, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Unlocked, 丏业丟一东丂东丘丛:  false);
    }
    private void 丒且万丝上万丒丒下()
    {
        int val_4;
        System.Action val_5;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Locked, 丏业丟一东丂东丘丛:  true);
        int val_2 = PGCompany.七丄三丝丐业丄丅丝.丝丒丟丑丐丘七上丕(丘丗丈东下业丟丟丑:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不());
        this.unlockTimer.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  "Key_9171");
        if(val_2 >= 1)
        {
                val_4 = val_2;
            val_5 = new System.Action(object:  this, method:  System.Void ClanBuildingEnterButton::丝一丅丆三东丂丞七());
        }
        else
        {
                val_4 = val_2;
            val_5 = 0;
        }
        
        this.unlockTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_4, 三丘丄丕丂丏东不丛:  val_5, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
    }
    private void 丑丆不三与丅丐下专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Unlocked, 丏业丟一东丂东丘丛:  true);
    }
    public void U_EnterButtonPressed()
    {
        this.丝一丅丆三东丂丞七();
        if(this.且上丘丄丘业丐丅业 != 2)
        {
                if(this.且上丘丄丘业丐丅业 != 1)
        {
                return;
        }
        
            this = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9105"), arg0:  PGCompany.七丄三丝丐业丄丅丝.三万丑丏丅业丂丞东(丘丗丈东下业丟丟丑:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不()));
            InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  this, 丂三丟丂丈丐丆丗丟:  (float)PGCompany.七丄三丝丐业丄丅丝.丝丒丟丑丐丘七上丕(丘丗丈东下业丟丟丑:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不()), 丛丒丟一万上丒丁七:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9101"));
            return;
        }
        
        this.丛不丈不丙丟不三上.丑丆丞业丗丐丂丏丄();
    }
    public ClanBuildingEnterButton()
    {
    
    }

}
