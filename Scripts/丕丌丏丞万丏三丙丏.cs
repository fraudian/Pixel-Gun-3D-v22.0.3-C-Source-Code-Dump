using UnityEngine;
private sealed class KeyDungeonObject.丕丌丏丞万丏三丙丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public KeyDungeonObject 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public KeyDungeonObject.丕丌丏丞万丏三丙丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        KeyDungeonObject val_21;
        InGameGUI val_22;
        int val_23;
        float val_24;
        float val_25;
        WorldPosIndicationItem_Distanced val_26;
        var val_27;
        WorldPosIndicationItem_Distanced val_28;
        WorldPosIndicationItem_Distanced val_29;
        var val_30;
        val_21 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_56;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(ScenarioController.丄丘七三上丕世丞业 != 0)
        {
                ScenarioController.丄丘七三上丕世丞业.万丘专丄丑下丆丑丑 = true;
        }
        
        DungeonsController.丒与丒丄丏东万上丛(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  val_21, method:  System.Void KeyDungeonObject::OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        val_22 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_22 == 0)
        {
            goto label_12;
        }
        
        val_22 = WorldPosIndicationsController.丄丘七三上丕世丞业;
        if(val_22 != 0)
        {
            goto label_15;
        }
        
        label_12:
        val_23 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_23;
        label_15:
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(丐七丆丐丏丁东丅专() != 0)
        {
                UnityEngine.Color val_9 = UnityEngine.Color.white;
            val_24 = val_9.r;
            val_25 = val_9.b;
            val_22 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ScenarioController.丄丘七三上丕世丞业.keyLocalize);
            丐七丆丐丏丁东丅专().丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  0f, 上丕丈丞丌丘丅不与:  "", 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_24, g = val_9.g, b = val_25, a = val_9.a}, 丘丏丑丁专上世丄不:  false, 丄一三上七丐专与丘:  val_22, 三世丏且丑下专丟丟:  "");
        }
        
        }
        
        val_26 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        if(val_21 != null)
        {
                val_27 = val_21;
            this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝 = val_26;
        }
        else
        {
                val_27 = 40;
            mem[40] = val_26;
            val_26 = mem[40];
        }
        
        if(val_26 != 0)
        {
                if(val_21 != null)
        {
                val_28 = mem[40];
        }
        else
        {
                val_28 = mem[40];
        }
        
            val_28.万三丗丆下万丅上丈(丞下万上三丘上与专:  val_21.transform, 丒专丌万丄一丒万丏:  0.2f);
            mem[40].丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  DungeonsController.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  ScenarioController.丄丘七三上丕世丞业.iconKey));
            if(val_21 != null)
        {
                val_29 = mem[40];
        }
        else
        {
                val_29 = mem[40];
        }
        
            val_22 = val_21.transform;
            val_30 = null;
            val_30 = null;
            val_29.下上丐丌七丁丄丝丑(丑东与丅丐丅丂丞业:  val_22, 丙七丟丏丅丘丈丁丄:  transform);
            UnityEngine.Color val_17 = UnityEngine.Color.yellow;
            val_24 = val_17.r;
            val_25 = val_17.b;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_21 = val_21.gameObject;
            val_22 = mem[ScenarioController.丄丘七三上丕世丞业 + 144];
            val_22 = ScenarioController.丄丘七三上丕世丞业.iconMinimapIndex;
            NJGMapItem val_20 = AddMiniMapIcon(业丟丏上丛与不一丝:  val_21, 下丗丁丒丘东丂不丑:  val_22);
        }
        
        label_56:
        val_23 = 0;
        return (bool)val_23;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
