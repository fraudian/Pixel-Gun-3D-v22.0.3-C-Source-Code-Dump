using UnityEngine;
public sealed class EventTournamentTipUI : PGBehaviour
{
    // Fields
    public UILabel descriptionLabel;
    public UILabel scoreLabel;
    public bool updateOnEnable;
    
    // Methods
    private void OnEnable()
    {
        var val_4;
        if(this.updateOnEnable != false)
        {
                val_4 = null;
            val_4 = null;
            this.丒丅丕一东丘丙且丛(丛丂下丗丏丅丏丑丌:  GameConnect.丈丝丂丐丟万丙丑丕);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  this.与万专丂丑下万东丕());
    }
    private bool 与万专丂丑下万东丕()
    {
        var val_5;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_6;
        bool val_7;
        var val_8;
        if(FriendsController.丝丗专上三不丄丑丑() >= 1)
        {
                val_5 = null;
            val_5 = null;
            val_6 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_6 != null)
        {
                val_6 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_6 == null)
        {
                val_6 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_6.丌不丅不丞东万专专();
            val_7 = 0;
            if(val_2.HasValue.丙东专丂世丈丏丁丂() != 2)
        {
                return (bool)val_7;
        }
        
            if(( & 1) == 0)
        {
                return (bool)val_7;
        }
        
            val_8 = null;
            val_8 = null;
            val_7 = true;
            if(GameConnect.丈丝丂丐丟万丙丑丕.七丂丌丈丄专丄三世() == true)
        {
                return (bool)val_7;
        }
        
            this.updateOnEnable = val_7;
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    internal void 丒丅丕一东丘丙且丛(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丛丂下丗丏丅丏丑丌)
    {
        bool val_8;
        if(丛丂下丗丏丅丏丑丌 != null)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = 丛丂下丗丏丅丏丑丌.丌不丅不丞东万专专();
            if((-1288353256) == 2)
        {
                val_8 = this.与万专丂丑下万东丕();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  val_8);
            if(val_8 == false)
        {
                return;
        }
        
            this.三丛丆上丈丆丗丆专(丕丗丘丑丛与丑业丒:  丛丂下丗丏丅丏丑丌.七丑丅丘上丏世世丄());
            this.丒东专丒一一专丛丛(业丌七业业七丞与丄:  丛丂下丗丏丅丏丑丌.丄不丘丛丝丘丈丟丟());
            return;
        }
        
        }
        
        this = this.丅与丌专丟一丝业三();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this, 丏业丟一东丂东丘丛:  false);
    }
    internal void 三丛丆上丈丆丗丆专(string 丕丗丘丑丛与丑业丒)
    {
        this.descriptionLabel.text = 丕丗丘丑丛与丑业丒;
    }
    internal void 丒东专丒一一专丛丛(int 业丌七业业七丞与丄)
    {
        this.scoreLabel.text = 业丌七业业七丞与丄.ToString();
    }
    public EventTournamentTipUI()
    {
    
    }

}
