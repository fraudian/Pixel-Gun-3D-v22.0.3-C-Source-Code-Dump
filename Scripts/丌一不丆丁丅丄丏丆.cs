using UnityEngine;
internal class 丌一不丆丁丅丄丏丆 : 丆丘丆丞丙下丆丟丅
{
    // Fields
    private System.Collections.Generic.List<SpawnMobBaseDungeon> 丂不业丂丅且不业业;
    private int 万丛且不丗丙丌丞丈;
    private string 丑丂丆与丄丙丒丗丂;
    private int 不丒下丛专万万丁七;
    
    // Methods
    internal override void 七丗丈丒七丒丕世与(System.Action 丟丘丙丄丅万丏与丗, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_3;
        object val_13;
        object val_14;
        var val_15;
        object val_16;
        string val_17;
        val_13 = this;
        this.七丗丈丒七丒丕世与(丟丘丙丄丅万丏与丗:  丟丘丙丄丅万丏与丗, 专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        if(专丒丌丆下丐丞丟丞.Length == 0)
        {
            goto label_8;
        }
        
        val_14 = 专丒丌丆下丐丞丟丞[0];
        if(val_14 == null)
        {
            goto label_8;
        }
        
        val_15 = null;
        if(专丒丌丆下丐丞丟丞.Length != 0)
        {
            goto label_7;
        }
        
        val_14 = 专丒丌丆下丐丞丟丞[0];
        if(val_14 == null)
        {
            goto label_8;
        }
        
        val_15 = null;
        label_7:
        label_8:
        if(专丒丌丆下丐丞丟丞.Length >= 2)
        {
                val_16 = 专丒丌丆下丐丞丟丞[1];
            if((val_16 != null) && (null == null))
        {
                if(专丒丌丆下丐丞丟丞.Length <= 1)
        {
                val_16 = 专丒丌丆下丐丞丟丞[1];
        }
        
            this.万丛且不丗丙丌丞丈 = null;
        }
        
        }
        
        this.丂不业丂丅且不业业.Clear();
        List.Enumerator<T> val_1 = 0.GetEnumerator();
        label_23:
        if((1078652464 & 1) == 0)
        {
            goto label_16;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == 0)
        {
            goto label_23;
        }
        
        this.丂不业丂丅且不业业.Add(item:  val_4);
        val_4.丛上丐丘丝丑丄丛业();
        System.Action<SpawnMobBaseDungeon> val_6 = new System.Action<SpawnMobBaseDungeon>(object:  this, method:  System.Void 丌一不丆丁丅丄丏丆::世丞与世丛丅丈业丗(SpawnMobBaseDungeon 丈东丝丐业专丈且丘));
        val_4.下七丌丐业丙丌丟丆(丙业与丙丗丝不丈东:  null);
        goto label_23;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.世丞与世丛丅丈业丗(丈东丝丐业专丈且丘:  0);
        val_17 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(丐七丆丐丏丁东丅专() == 0)
        {
                return;
        }
        
        val_17 = val_13;
        val_13 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ScenarioController.丄丘七三上丕世丞业.hiveLocalize);
        丐七丆丐丏丁东丅专().丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  V0.16B, 上丕丈丞丌丘丅不与:  this, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B}, 丘丏丑丁专上世丄不:  false, 丄一三上七丐专与丘:  val_13, 三世丏且丑下专丟丟:  ScenarioController.丄丘七三上丕世丞业.hiveIcon);
    }
    internal override void 七丒丈丗与丟不丐东()
    {
        this.七丒丈丗与丟不丐东();
    }
    internal override string 丄且丙丂丆不一万七()
    {
        return (string)this.丑丂丆与丄丙丒丗丂;
    }
    internal override UnityEngine.Color 丝三世专丞不丈丘丕()
    {
        return UnityEngine.Color.red;
    }
    internal override float 且丆丁丑万丁丁丌世()
    {
        int val_1 = this.不丒下丛专万万丁七;
        val_1 = this.万丛且不丗丙丌丞丈 - val_1;
        float val_2 = (float)val_1;
        val_2 = val_2 / (float)this.万丛且不丗丙丌丞丈;
        return (float)val_2;
    }
    internal void 世丞与世丛丅丈业丗(SpawnMobBaseDungeon 丈东丝丐业专丈且丘)
    {
        object val_16;
        System.Collections.Generic.List<SpawnMobBaseDungeon> val_17;
        string val_18;
        val_16 = this;
        if(丈东丝丐业专丈且丘 != 0)
        {
                丈东丝丐业专丈且丘.丏丁专丑丟丛丟丒丝(丙业与丙丗丝不丈东:  new System.Action<SpawnMobBaseDungeon>(object:  this, method:  System.Void 丌一不丆丁丅丄丏丆::世丞与世丛丅丈业丗(SpawnMobBaseDungeon 丈东丝丐业专丈且丘)));
            val_17 = val_16;
            bool val_3 = this.丂不业丂丅且不业业.Remove(item:  丈东丝丐业专丈且丘);
            丈东丝丐业专丈且丘.专东丗三丛丅丘世世();
        }
        else
        {
                val_17 = this.丂不业丂丅且不业业;
        }
        
        int val_4 = this.丂不业丂丅且不业业.SyncRoot.Count;
        this.不丒下丛专万万丁七 = val_4;
        int val_16 = this.万丛且不丗丙丌丞丈;
        val_18 = 1152921504622075904;
        val_16 = val_16 - val_4;
        this.丑丂丆与丄丙丒丗丂 = System.String.Format(format:  "{0}/{1}", arg0:  val_16, arg1:  this.万丛且不丗丙丌丞丈);
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(丐七丆丐丏丁东丅专() != 0)
        {
                val_18 = val_16;
            丐七丆丐丏丁东丅专().丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  V0.16B, 上丕丈丞丌丘丅不与:  this, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B}, 丘丏丑丁专上世丄不:  false, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ScenarioController.丄丘七三上丕世丞业.hiveLocalize), 三世丏且丑下专丟丟:  ScenarioController.丄丘七三上丕世丞业.hiveIcon);
        }
        
        }
        
        if(this.丂不业丂丅且不业业.SyncRoot.Count != 0)
        {
                return;
        }
        
        val_16 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_16 == 0)
        {
                return;
        }
        
        val_16 = 丐七丆丐丏丁东丅专();
        if(val_16 == 0)
        {
                return;
        }
        
        val_16 = 丐七丆丐丏丁东丅专();
        val_16.且丞丆与万世万丌丟();
    }
    public 丌一不丆丁丅丄丏丆()
    {
        this.丂不业丂丅且不业业 = new System.Collections.Generic.List<SpawnMobBaseDungeon>();
    }

}
