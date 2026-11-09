using UnityEngine;
internal class 丙丕丂丗丅上丙丑丞 : 丆丘丆丞丙下丆丟丅
{
    // Fields
    private RilisoftBot.BaseBot 丑下万丛丟下丟丕不;
    private float 世丝专丆下丟丙不世;
    private string 丑业丙丄丝丛丏且一;
    private WorldPosIndicationItem_Distanced 东丄与丛丂丘丝三丝;
    
    // Methods
    internal override void 七丗丈丒七丒丕世与(System.Action 丟丘丙丄丅万丏与丗, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_20;
        System.Action val_21;
        float val_22;
        var val_23;
        System.Object[] val_21 = 专丒丌丆下丐丞丟丞;
        this.七丗丈丒七丒丕世与(丟丘丙丄丅万丏与丗:  丟丘丙丄丅万丏与丗, 专丒丌丆下丐丞丟丞:  val_21);
        object val_20 = val_21[0];
        val_20 = 0;
        this.丑下万丛丟下丟丕不 = ;
        七东丘与丁丌三丛丐(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void 丙丕丂丗丅上丙丑丞::世丗三东东三东七上(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
        System.Action val_2 = null;
        val_21 = val_2;
        val_2 = new System.Action(object:  this, method:  System.Void 丙丕丂丗丅上丙丑丞::丁丂丐上与丈三丈不());
        this.丑下万丛丟下丟丕不.丞丘七丗丁丄不丏丈(丙业与丙丗丝不丈东:  val_2);
        this.丑下万丛丟下丟丕不.一丕丐专一东丞下上 = true;
        this.丁丂丐上与丈三丈不();
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(丐七丆丐丏丁东丅专() != 0)
        {
                val_22 = V0.16B;
            val_21 = this;
            丐七丆丐丏丁东丅专().丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  val_22, 上丕丈丞丌丘丅不与:  this, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B}, 丘丏丑丁专上世丄不:  true, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7101"), 三世丏且丑下专丟丟:  "Dungeon_" + this.丑下万丛丟下丟丕不.name.Replace(oldValue:  "(Clone)", newValue:  "")(this.丑下万丛丟下丟丕不.name.Replace(oldValue:  "(Clone)", newValue:  "")));
        }
        
        }
        
        WorldPosIndicationItem_Distanced val_11 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        this.东丄与丛丂丘丝三丝 = val_11;
        if(val_11 != 0)
        {
                val_22 = this.丑下万丛丟下丟丕不.worldIndicationOffset;
            this.东丄与丛丂丘丝三丝.万三丗丆下万丅上丈(丞下万上三丘上与专:  this.丑下万丛丟下丟丕不.transform, 丒专丌万丄一丒万丏:  val_22);
            this.东丄与丛丂丘丝三丝.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  DungeonsController.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  1));
            val_21 = this.丑下万丛丟下丟丕不.transform;
            val_23 = null;
            val_23 = null;
            this.东丄与丛丂丘丝三丝.下上丐丌七丁丄丝丑(丑东与丅丐丅丂丞业:  val_21, 丙七丟丏丅丘丈丁丄:  transform);
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        NJGMapItem val_19 = AddMiniMapIcon(业丟丏上丛与不一丝:  this.丑下万丛丟下丟丕不.gameObject, 下丗丁丒丘东丂不丑:  14);
    }
    internal override void 七丒丈丗与丟不丐东()
    {
        this.丑下万丛丟下丟丕不.万丗七丕专且丆丏丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void 丙丕丂丗丅上丙丑丞::世丗三东东三东七上(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
        this.丑下万丛丟下丟丕不.七世下丗专下东丁世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丙丕丂丗丅上丙丑丞::丁丂丐上与丈三丈不()));
        this.七丒丈丗与丟不丐东();
    }
    internal override string 丄且丙丂丆不一万七()
    {
        return (string)this.丑业丙丄丝丛丏且一;
    }
    internal override UnityEngine.Color 丝三世专丞不丈丘丕()
    {
        return UnityEngine.Color.red;
    }
    internal override float 且丆丁丑万丁丁丌世()
    {
        return (float)this.世丝专丆下丟丙不世;
    }
    private void 丁丂丐上与丈三丈不()
    {
        string val_17;
        RilisoftBot.BaseBot val_18;
        float val_19;
        float val_20;
        float val_21;
        var val_22;
        UnityEngine.Object val_23;
        string val_24;
        val_17 = this;
        val_18 = this.丑下万丛丟下丟丕不;
        if(val_18 != null)
        {
                val_19 = this.丑下万丛丟下丟丕不.health;
        }
        else
        {
                val_19 = this.丑下万丛丟下丟丕不.health;
            if(this.丑下万丛丟下丟丕不 != null)
        {
                val_18 = this.丑下万丛丟下丟丕不;
        }
        else
        {
                val_18 = 0;
        }
        
        }
        
        val_20 = val_19 / val_18.maxHealth;
        this.世丝专丆下丟丙不世 = val_20;
        if(((int)val_20 * 100f) != 0)
        {
            goto label_5;
        }
        
        val_21 = this.丑下万丛丟下丟丕不.health;
        if(val_21 <= 0f)
        {
            goto label_7;
        }
        
        val_22 = "1%";
        goto label_8;
        label_7:
        val_20 = this.世丝专丆下丟丙不世;
        label_5:
        val_21 = val_20 * 100f;
        label_8:
        this.丑业丙丄丝丛丏且一 = (int)val_21.ToString() + " %"(" %");
        val_23 = 0;
        if(InGameGUI.丙丞专丌丁丞与不丐 != val_23)
        {
                val_23 = 0;
            if(丐七丆丐丏丁东丅专() != val_23)
        {
                val_19 = val_21;
            val_24 = val_17;
            val_23 = val_24;
            丐七丆丐丏丁东丅专().丙上丟丏且丐丌不丒(丗与丘不且万丟丙丑:  val_19, 上丕丈丞丌丘丅不与:  this);
        }
        
        }
        
        if(this.世丝专丆下丟丙不世 > 0f)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(丐七丆丐丏丁东丅专() != 0)
        {
                丐七丆丐丏丁东丅专().且丞丆与万世万丌丟();
        }
        
        }
        
        if(this.东丄与丛丂丘丝三丝 != 0)
        {
                WorldPosIndicationsController.丄丘七三上丕世丞业.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
            this.东丄与丛丂丘丝三丝 = 0;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        val_24 = InGameGUI.丙丞专丌丁丞与不丐;
        val_17 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 912];
        val_17 = InGameGUI.丙丞专丌丁丞与不丐.专丐万丆丑三上丘七;
        RemoveMiniMapIcon(业丟丏上丛与不一丝:  this.丑下万丛丟下丟丕不.gameObject);
    }
    private void 世丗三东东三东七上(RilisoftBot.BaseBot 业丘东且七丕丞东不)
    {
        UnityEngine.GameObject val_9;
        this.世丝专丆下丟丙不世 = 0f;
        this.丑业丙丄丝丛丏且一 = "0 %";
        val_9 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(丐七丆丐丏丁东丅专() != 0)
        {
                丐七丆丐丏丁东丅专().且丞丆与万世万丌丟();
        }
        
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_9 = this.丑下万丛丟下丟丕不.gameObject;
            RemoveMiniMapIcon(业丟丏上丛与不一丝:  val_9);
        }
        
        if(this.东丄与丛丂丘丝三丝 == 0)
        {
                return;
        }
        
        WorldPosIndicationsController.丄丘七三上丕世丞业.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
        this.东丄与丛丂丘丝三丝 = 0;
    }
    public 丙丕丂丗丅上丙丑丞()
    {
    
    }

}
