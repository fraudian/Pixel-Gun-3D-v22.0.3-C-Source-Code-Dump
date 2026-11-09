using UnityEngine;
internal class 一专丁丈丙丁丄丝丄 : 丆丘丆丞丙下丆丟丅
{
    // Fields
    private System.Collections.Generic.List<FlasksDungeonObject> 三丆丅丛专丒丂专丆;
    private int 丒下丘丝丘丅上专三;
    private string 丑丂丆与丄丙丒丗丂;
    private int 三万丕业丑专东不丒;
    
    // Methods
    internal override void 七丗丈丒七丒丕世与(System.Action 丟丘丙丄丅万丏与丗, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_6;
        var val_7;
        object val_8;
        this.七丗丈丒七丒丕世与(丟丘丙丄丅万丏与丗:  丟丘丙丄丅万丏与丗, 专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        if(专丒丌丆下丐丞丟丞.Length == 0)
        {
            goto label_8;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞[0];
        if(val_6 == null)
        {
            goto label_8;
        }
        
        val_7 = null;
        if(专丒丌丆下丐丞丟丞.Length != 0)
        {
            goto label_7;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞[0];
        if(val_6 == null)
        {
            goto label_8;
        }
        
        val_7 = null;
        label_7:
        label_8:
        if(专丒丌丆下丐丞丟丞.Length >= 2)
        {
                val_8 = 专丒丌丆下丐丞丟丞[1];
            if((val_8 != null) && (null == null))
        {
                if(专丒丌丆下丐丞丟丞.Length <= 1)
        {
                val_8 = 专丒丌丆下丐丞丟丞[1];
        }
        
            this.丒下丘丝丘丅上专三 = null;
        }
        
        }
        
        this.三丆丅丛专丒丂专丆.Clear();
        List.Enumerator<T> val_1 = 0.GetEnumerator();
        label_22:
        if((1080215064 & 1) == 0)
        {
            goto label_16;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_22;
        }
        
        this.三丆丅丛专丒丂专丆.Add(item:  val_2);
        System.Action<FlasksDungeonObject> val_4 = new System.Action<FlasksDungeonObject>(object:  this, method:  System.Void 一专丁丈丙丁丄丝丄::丐丐世专丗丘丛丝一(FlasksDungeonObject 丄七丌下不丐且丐丏));
        val_2.丁上世丕丛丕丌丒专(丙业与丙丗丝不丈东:  null);
        goto label_22;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丐丐世专丗丘丛丝一(丄七丌下不丐且丐丏:  0);
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
        return UnityEngine.Color.green;
    }
    internal override float 且丆丁丑万丁丁丌世()
    {
        int val_1 = this.三万丕业丑专东不丒;
        val_1 = this.丒下丘丝丘丅上专三 - val_1;
        float val_2 = (float)val_1;
        val_2 = val_2 / (float)this.丒下丘丝丘丅上专三;
        return (float)val_2;
    }
    internal void 丐丐世专丗丘丛丝一(FlasksDungeonObject 丄七丌下不丐且丐丏)
    {
        object val_16;
        System.Collections.Generic.List<FlasksDungeonObject> val_17;
        string val_18;
        val_16 = this;
        if(丄七丌下不丐且丐丏 != 0)
        {
                丄七丌下不丐且丐丏.丝丆丑丂丝不丙丙一(丙业与丙丗丝不丈东:  new System.Action<FlasksDungeonObject>(object:  this, method:  System.Void 一专丁丈丙丁丄丝丄::丐丐世专丗丘丛丝一(FlasksDungeonObject 丄七丌下不丐且丐丏)));
            val_17 = val_16;
            bool val_3 = this.三丆丅丛专丒丂专丆.Remove(item:  丄七丌下不丐且丐丏);
        }
        else
        {
                val_17 = this.三丆丅丛专丒丂专丆;
        }
        
        int val_4 = this.三丆丅丛专丒丂专丆.SyncRoot.Count;
        this.三万丕业丑专东不丒 = val_4;
        int val_16 = this.丒下丘丝丘丅上专三;
        val_18 = 1152921504622075904;
        val_16 = val_16 - val_4;
        this.丑丂丆与丄丙丒丗丂 = System.String.Format(format:  "{0}/{1}", arg0:  val_16, arg1:  this.丒下丘丝丘丅上专三);
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(丐七丆丐丏丁东丅专() != 0)
        {
                val_18 = val_16;
            丐七丆丐丏丁东丅专().丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  V0.16B, 上丕丈丞丌丘丅不与:  this, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B}, 丘丏丑丁专上世丄不:  false, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ScenarioController.丄丘七三上丕世丞业.findItemLocalize), 三世丏且丑下专丟丟:  ScenarioController.丄丘七三上丕世丞业.findItemIcon);
        }
        
        }
        
        if(this.三丆丅丛专丒丂专丆.SyncRoot.Count != 0)
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
    public 一专丁丈丙丁丄丝丄()
    {
        this.三丆丅丛专丒丂专丆 = new System.Collections.Generic.List<FlasksDungeonObject>();
    }

}
