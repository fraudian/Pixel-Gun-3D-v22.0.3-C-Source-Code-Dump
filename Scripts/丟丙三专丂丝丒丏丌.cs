using UnityEngine;
public class 丟丙三专丂丝丒丏丌
{
    // Fields
    private bool 丘与丐与丂丞丙丒丐;
    private int 丐丏丙丞世东丑丏丝;
    
    // Methods
    internal void 丙丕丒丕一丕与丆世()
    {
        var val_29;
        var val_30;
        string val_31;
        var val_32;
        var val_33;
        SceneInfo val_34;
        var val_35;
        var val_36;
        if(与丂丏丛丞丞丒丟丄.丐丏丏丏与且万丝丄() != false)
        {
                if((((GameConnect.丑丌丛丈丅丅与不业() != 2) && (GameConnect.丑丌丛丈丅丅与不业() != 0)) && (GameConnect.丑丌丛丈丅丅与不业() != 1)) && (GameConnect.丑丌丛丈丅丅与不业() != 4))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 33)
        {
            goto label_21;
        }
        
        }
        
        }
        
            val_29 = NetworkStartTable.与一专丒东丏丘专丕() ^ 1;
        }
        else
        {
                label_21:
            val_29 = 0;
        }
        
        if(((val_29 & (~GameConnect.丕上丐丄三上丝专万())) == false) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null))
        {
            goto label_58;
        }
        
        val_30 = null;
        val_30 = null;
        val_31 = GameConnect.专丝下世丄业丕丑七;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_31] == null)
        {
            goto label_58;
        }
        
        val_32 = null;
        val_32 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_40;
        }
        
        val_31 = 1152921505189646336;
        val_33 = null;
        val_33 = null;
        val_34 = 0;
        if(GameController.丆丘丂丈世丏丟丑丏 != 0)
        {
                val_35 = null;
            val_35 = null;
            val_34 = mem[GameController.丆丘丂丈世丏丟丑丏 + 48];
            val_34 = GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上;
        }
        
        if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丏丈丗世丙万丆丐丅:  val_34)) == true)
        {
            goto label_51;
        }
        
        label_40:
        if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
            goto label_54;
        }
        
        label_51:
        this.丘与丐与丂丞丙丒丐 = true;
        label_67:
        this.丐丏丙丞世东丑丏丝 = UnityEngine.Time.frameCount;
        return;
        label_54:
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() <= 0f)
        {
            goto label_58;
        }
        
        val_36 = null;
        val_36 = null;
        val_31 = GameConnect.专丝下世丄业丕丑七;
        double val_25 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_25 = (System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_31])) - val_25;
        bool val_26 = (val_25 <= 0f) ? 1 : 0;
        val_26 = ((val_25 > 16) ? 1 : 0) | val_26;
        this.丘与丐与丂丞丙丒丐 = val_26;
        if(val_26 == 1)
        {
            goto label_67;
        }
        
        return;
        label_58:
        this.丘与丐与丂丞丙丒丐 = false;
    }
    internal void 丗丘丞丏下丝丐丛丛()
    {
        var val_4;
        var val_5;
        var val_6;
        if(this.丘与丐与丂丞丙丒丐 == false)
        {
                return;
        }
        
        if(UnityEngine.Time.frameCount == this.丐丏丙丞世东丑丏丝)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if((GameController.onlineMode + 56 + 24) != 0)
        {
                this.丘与丐与丂丞丙丒丐 = false;
            return;
        }
        
        val_5 = null;
        val_5 = null;
        if(GameController.onlineMode.专丝上丟丆丝丙丄丈() == false)
        {
                return;
        }
        
        this.丘与丐与丂丞丙丒丐 = false;
        val_6 = null;
        val_6 = null;
        GameController.onlineMode.丏七丝丄七丘下丕三();
    }
    public 丟丙三专丂丝丒丏丌()
    {
    
    }

}
