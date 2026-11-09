using UnityEngine;
public sealed class PlayerCountStartCondition : ModeStartCondition, 东丁丆一业丈万丆丐
{
    // Fields
    private bool 丝与丆丞东丘丈东丘;
    private float 与业丅丝丅丆且业丆;
    private float 丛丁丈与丛万一丝万;
    private bool 丘丈三一三丙丕丁世;
    private bool 下丙丏丙丆丁丅七丑;
    public bool dontAutoStartOnMax;
    public bool dontStopTimerOnLowCount;
    public bool bufferedStart;
    public bool maxCountStart;
    public bool startByRoomProperty;
    public int minCountPlayer;
    public float timeToStart;
    
    // Properties
    internal bool 丌丁世丗七丗且丐一 { get; }
    internal bool 丝丙七丆丅专丝丞丏 { get; }
    internal float 且东丟丈丞丄一丙丌 { get; }
    
    // Methods
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        bool val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 == 1)
        {
            goto label_1;
        }
        
        if(val_1 != 0)
        {
            goto label_2;
        }
        
        val_2 = true;
        if(this.丘丈三一三丙丕丁世 == true)
        {
                return (bool)val_2;
        }
        
        this.丘丈三一三丙丕丁世 = val_2;
        this.下丙丏丙丆丁丅七丑 = false;
        this.丛万丙丏丝丗丛丄丐();
        return (bool)val_2;
        label_1:
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        val_2 = true;
        this.下丙丏丙丆丁丅七丑 = val_2;
        this.丛丁丈与丛万一丝万 = null;
        return (bool)val_2;
        label_2:
        val_2 = 0;
        return (bool)val_2;
    }
    internal override void 上丛丌丆丑上七世三()
    {
        this.丝与丆丞东丘丈东丘 = true;
    }
    internal bool 丈丁丆丆丁一丅丝丒()
    {
        return (bool)this.丘丈三一三丙丕丁世;
    }
    internal bool 丟丛万丅业丛且不丂()
    {
        return (bool)this.下丙丏丙丆丁丅七丑;
    }
    internal float 丝丒不万丑丙丏丆上()
    {
        return (float)this.丛丁丈与丛万一丝万;
    }
    private void Update()
    {
        int val_21;
        var val_22;
        ExitGames.Client.Photon.Hashtable val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        if(this.丘丈三一三丙丕丁世 == true)
        {
                return;
        }
        
        if((this.下丙丏丙丆丁丅七丑 != false) && (this.丛丁丈与丛万一丝万 > 0f))
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.丛丁丈与丛万一丝万 - val_1;
            this.丛丁丈与丛万一丝万 = val_1;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_33;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.与业丅丝丅丆且业丆 - val_3;
        this.与业丅丝丅丆且业丆 = val_3;
        if(this.maxCountStart != false)
        {
                val_21 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下();
        }
        else
        {
                val_21 = this.minCountPlayer;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = public System.Int32 System.Collections.Generic.List<NetworkStartTable>::get_Count();
        val_24 = Count;
        if((val_24 < val_21) || (this.下丙丏丙丆丁丅七丑 == true))
        {
            goto label_17;
        }
        
        this.下丙丏丙丆丁丅七丑 = true;
        this.与业丅丝丅丆且业丆 = 0f;
        this.丛丁丈与丛万一丝万 = this.timeToStart;
        goto label_20;
        label_17:
        if(this.下丙丏丙丆丁丅七丑 == false)
        {
            goto label_33;
        }
        
        if(this.与业丅丝丅丆且业丆 >= 0)
        {
            goto label_20;
        }
        
        this.与业丅丝丅丆且业丆 = 0.5f;
        object[] val_7 = new object[1];
        val_23 = 1;
        val_7[0] = this.丛丁丈与丛万一丝万;
        this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  1, 丈丅丘丐三丂丗且丌:  0, 丕业丑万一丞丞东三:  false, 丗丟上上丒丐丗丞丙:  val_7);
        if(this.下丙丏丙丆丁丅七丑 == false)
        {
            goto label_33;
        }
        
        label_20:
        if(this.丛丁丈与丛万一丝万 <= 0f)
        {
                if((val_24 >= val_21) || (this.dontStopTimerOnLowCount == true))
        {
            goto label_28;
        }
        
        }
        
        val_23 = 0;
        if((val_24 == 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下()) && (this.dontAutoStartOnMax != true))
        {
                label_28:
            if(this.startByRoomProperty != false)
        {
                ExitGames.Client.Photon.Hashtable val_10 = new ExitGames.Client.Photon.Hashtable();
            val_25 = null;
            val_25 = null;
            val_10.set_Item(key:  GameConnect.下丐一丈下且丛下丝, value:  1);
            val_24 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_23 = val_10;
            val_24.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_10, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
            if(this.丘丈三一三丙丕丁世 != true)
        {
                this.丘丈三一三丙丕丁世 = true;
            this.下丙丏丙丆丁丅七丑 = false;
            this.丛万丙丏丝丗丛丄丐();
        }
        
            this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  0, 丈丅丘丐三丂丗且丌:  0, 丕业丑万一丞丞东三:  this.bufferedStart, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
        label_33:
        val_26 = null;
        val_26 = null;
        if(null != 0)
        {
                this.丘丈三一三丙丕丁世 = true;
            return;
        }
        
        if(this.丘丈三一三丙丕丁世 != false)
        {
                return;
        }
        
        if(this.丝与丆丞东丘丈东丘 == false)
        {
                return;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(this.startByRoomProperty == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_27 = null;
        val_27 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.下丐一丈下且丛下丝)) == false)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        object val_20 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.下丐一丈下且丛下丝];
        if(null != 1)
        {
                return;
        }
        
        if(this.丘丈三一三丙丕丁世 == true)
        {
                return;
        }
        
        this.丘丈三一三丙丕丁世 = true;
        this.下丙丏丙丆丁丅七丑 = false;
        this.丛万丙丏丝丗丛丄丐();
    }
    private void 丛丛业丈下下丐丟丒()
    {
        if(this.丘丈三一三丙丕丁世 != false)
        {
                return;
        }
        
        this.丘丈三一三丙丕丁世 = true;
        this.下丙丏丙丆丁丅七丑 = false;
        this.丛万丙丏丝丗丛丄丐();
    }
    private void 丞丝下丄丆且丌丈丐()
    {
        this.下丙丏丙丆丁丅七丑 = true;
        this.丛丁丈与丛万一丝万 = this.timeToStart;
    }
    private void 丈业业业七丄上丘下(float 丘上三丁与丘世专丝)
    {
        this.下丙丏丙丆丁丅七丑 = true;
        this.丛丁丈与丛万一丝万 = 丘上三丁与丘世专丝;
    }
    public PlayerCountStartCondition()
    {
        this.与业丅丝丅丆且业丆 = 0.5f;
        this.bufferedStart = true;
        this.minCountPlayer = 2;
        this.timeToStart = 5f;
    }

}
