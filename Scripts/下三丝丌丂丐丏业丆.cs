using UnityEngine;
internal class 下三丝丌丂丐丏业丆 : 丆丘丆丞丙下丆丟丅
{
    // Fields
    private AltarePoint 一丐丞丅丆丐一丝丒;
    private float 丗与不且丏丆上丂丛;
    private string 业丁丆万上丂丌七世;
    private WorldPosIndicationItem_Distanced 东丄与丛丂丘丝三丝;
    
    // Methods
    private void 东万丗丄丕丞丑丌丆(float 丂丐丏下万万丒三上)
    {
        string val_17;
        UnityEngine.Object val_18;
        string val_19;
        val_17 = this;
        float val_17 = this.一丐丞丅丆丐一丝丒.maxCapturePoint;
        val_17 = this.一丐丞丅丆丐一丝丒.CurrentCapturePoint / val_17;
        this.丗与不且丏丆上丂丛 = val_17;
        val_17 = val_17 * 100f;
        this.业丁丆万上丂丌七世 = (int)val_17.ToString() + " %"(" %");
        val_18 = 0;
        if(InGameGUI.丙丞专丌丁丞与不丐 != val_18)
        {
                val_18 = 0;
            if(丐七丆丐丏丁东丅专() != val_18)
        {
                val_19 = val_17;
            val_18 = val_19;
            丐七丆丐丏丁东丅专().丙上丟丏且丐丌不丒(丗与丘不且万丟丙丑:  val_17, 上丕丈丞丌丘丅不与:  this);
        }
        
        }
        
        if(this.丗与不且丏丆上丂丛 < 1f)
        {
                return;
        }
        
        System.Action<System.Single> val_8 = null;
        val_19 = val_8;
        val_8 = new System.Action<System.Single>(object:  this, method:  System.Void 下三丝丌丂丐丏业丆::东万丗丄丕丞丑丌丆(float 丂丐丏下万万丒三上));
        this.一丐丞丅丆丐一丝丒.丘业下上且丗丈且丙(丙业与丙丗丝不丈东:  val_8);
        this.一丐丞丅丆丐一丝丒.三丂丐且丕丆世丁下();
        this.一丐丞丅丆丐一丝丒.ActivateScenario = false;
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
        
        val_19 = InGameGUI.丙丞专丌丁丞与不丐;
        val_17 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 912];
        val_17 = InGameGUI.丙丞专丌丁丞与不丐.专丐万丆丑三上丘七;
        RemoveMiniMapIcon(业丟丏上丛与不一丝:  this.一丐丞丅丆丐一丝丒.gameObject);
    }
    internal override void 七丗丈丒七丒丕世与(System.Action 丟丘丙丄丅万丏与丗, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_16;
        System.Action<System.Single> val_17;
        var val_18;
        System.Object[] val_17 = 专丒丌丆下丐丞丟丞;
        this.七丗丈丒七丒丕世与(丟丘丙丄丅万丏与丗:  丟丘丙丄丅万丏与丗, 专丒丌丆下丐丞丟丞:  val_17);
        object val_16 = val_17[0];
        val_16 = 0;
        this.一丐丞丅丆丐一丝丒 = ;
        System.Action<System.Single> val_1 = null;
        val_17 = val_1;
        val_1 = new System.Action<System.Single>(object:  this, method:  System.Void 下三丝丌丂丐丏业丆::东万丗丄丕丞丑丌丆(float 丂丐丏下万万丒三上));
        丐专三丁丘丈丘丝丅(丙业与丙丗丝不丈东:  val_1);
        this.东万丗丄丕丞丑丌丆(丂丐丏下万万丒三上:  null);
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(丐七丆丐丏丁东丅专() != 0)
        {
                val_17 = this;
            丐七丆丐丏丁东丅专().丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  V0.16B, 上丕丈丞丌丘丅不与:  this, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B}, 丘丏丑丁专上世丄不:  true, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7348"), 三世丏且丑下专丟丟:  "Dungeon_Altar");
        }
        
        }
        
        WorldPosIndicationItem_Distanced val_7 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        this.东丄与丛丂丘丝三丝 = val_7;
        if(val_7 != 0)
        {
                this.东丄与丛丂丘丝三丝.万三丗丆下万丅上丈(丞下万上三丘上与专:  this.一丐丞丅丆丐一丝丒.transform, 丒专丌万丄一丒万丏:  1f);
            this.东丄与丛丂丘丝三丝.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  DungeonsController.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  6));
            val_17 = this.一丐丞丅丆丐一丝丒.transform;
            val_18 = null;
            val_18 = null;
            this.东丄与丛丂丘丝三丝.下上丐丌七丁丄丝丑(丑东与丅丐丅丂丞业:  val_17, 丙七丟丏丅丘丈丁丄:  transform);
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        NJGMapItem val_15 = AddMiniMapIcon(业丟丏上丛与不一丝:  this.一丐丞丅丆丐一丝丒.gameObject, 下丗丁丒丘东丂不丑:  18);
    }
    internal override void 七丒丈丗与丟不丐东()
    {
        this.七丒丈丗与丟不丐东();
        this.一丐丞丅丆丐一丝丒.ActivateScenario = false;
        this.一丐丞丅丆丐一丝丒.上万丁丛丛万丌丕丅 = true;
    }
    internal override string 丄且丙丂丆不一万七()
    {
        return (string)this.业丁丆万上丂丌七世;
    }
    internal override UnityEngine.Color 丝三世专丞不丈丘丕()
    {
        return UnityEngine.Color.green;
    }
    internal override float 且丆丁丑万丁丁丌世()
    {
        return (float)this.丗与不且丏丆上丂丛;
    }
    public 下三丝丌丂丐丏业丆()
    {
    
    }

}
