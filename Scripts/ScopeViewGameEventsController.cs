using UnityEngine;
public class ScopeViewGameEventsController : PGBehaviour
{
    // Fields
    internal static ScopeViewGameEventsController 丄丘七三上丕世丞业;
    private System.Collections.Generic.List<业丗丕丟三丝丘三丗>[] 七不丛丐丏丗丈且丕;
    private float[] 丑且丈丘丅丑丏丙一;
    private ScopeViewGameEventSettings[] eventsSettings;
    private System.Collections.Generic.List<ScopeViewGameEventGuiItem>[] 世上一丟丑丈丈丗且;
    private int[] 东丆丏丛丑丞丂丐丑;
    private UnityEngine.Transform stackRootTransform;
    
    // Properties
    internal static UnityEngine.Transform 业东上丌三下丅三丙 { get; }
    
    // Methods
    internal static UnityEngine.Transform 丏丈万丅与丌不东丄()
    {
        null = null;
        if(丝丙与东丈不丙三丟() != null)
        {
                return (UnityEngine.Transform)val_1.丒不世丁丌丁万丌三;
        }
        
        return (UnityEngine.Transform)val_1.丒不世丁丌丁万丌三;
    }
    public ScopeViewGameEventSettings GetEventSettings(业丗丕丟三丝丘三丗.丗丄丐丈丛丛三丗丏 且下丕七丙丗丄不七)
    {
        var val_1;
        ScopeViewGameEventSettings val_2;
        val_1 = 且下丕七丙丗丄不七;
        if(((val_1 & 2147483648) == 0) && (this.eventsSettings.Length > val_1))
        {
                val_1 = (long)val_1;
            val_2 = this.eventsSettings[val_1];
            return (ScopeViewGameEventSettings)val_2;
        }
        
        val_2 = 0;
        return (ScopeViewGameEventSettings)val_2;
    }
    private void Awake()
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        ScopeViewGameEventsController.丄丘七三上丕世丞业 = this;
        this.世上一丟丑丈丈丗且 = new System.Collections.Generic.List<ScopeViewGameEventGuiItem>[0];
        this.七不丛丐丏丗丈且丕 = new System.Collections.Generic.List<业丗丕丟三丝丘三丗>[0];
        this.东丆丏丛丑丞丂丐丑 = new int[0];
        this.丑且丈丘丅丑丏丙一 = new float[0];
        val_9 = 0;
        goto label_7;
        label_32:
        System.Collections.Generic.List<ScopeViewGameEventGuiItem> val_5 = new System.Collections.Generic.List<ScopeViewGameEventGuiItem>();
        if(this.世上一丟丑丈丈丗且 == null)
        {
            goto label_8;
        }
        
        if(val_5 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_5 == null)
        {
            goto label_12;
        }
        
        label_9:
        label_12:
        this.世上一丟丑丈丈丗且[0] = val_5;
        System.Collections.Generic.List<业丗丕丟三丝丘三丗> val_6 = new System.Collections.Generic.List<业丗丕丟三丝丘三丗>();
        if(this.七不丛丐丏丗丈且丕 == null)
        {
            goto label_14;
        }
        
        if(val_6 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_6 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        this.七不丛丐丏丗丈且丕[0] = val_6;
        ScopeViewGameEventSettings val_8 = this.eventsSettings[0];
        if(this.eventsSettings[0x0][0].eventGuiItem != 0)
        {
                ScopeViewGameEventSettings val_9 = this.eventsSettings[0];
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.eventsSettings[0x0][0].eventGuiItem, 丏业丟一东丂东丘丛:  false);
        }
        
        val_9 = 1;
        label_7:
        if(val_9 < this.eventsSettings.Length)
        {
            goto label_32;
        }
    
    }
    private void OnDestroy()
    {
        null = null;
        ScopeViewGameEventsController.丄丘七三上丕世丞业 = 0;
    }
    private ScopeViewGameEventGuiItem 丐丂业专万丐万丕万(业丗丕丟三丝丘三丗.丗丄丐丈丛丛三丗丏 且下丕七丙丗丄不七)
    {
        UnityEngine.Object val_9;
        System.Collections.Generic.List<ScopeViewGameEventGuiItem> val_9 = this.世上一丟丑丈丈丗且[(long)且下丕七丙丗丄不七];
        ScopeViewGameEventSettings val_10 = this.eventsSettings[(long)且下丕七丙丗丄不七];
        if(val_9.Count < 1)
        {
            goto label_6;
        }
        
        if(val_9 == null)
        {
            goto label_7;
        }
        
        val_9 = val_9.Item[0];
        goto label_8;
        label_6:
        val_9 = 0;
        goto label_9;
        label_7:
        val_9 = val_9.Item[0];
        label_8:
        val_9.RemoveAt(index:  0);
        label_9:
        if(val_9 == 0)
        {
                val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.eventsSettings[(long)(int)(且下丕七丙丗丄不七)][0].eventGuiItem.gameObject, parent:  this.stackRootTransform).GetComponent<ScopeViewGameEventGuiItem>();
            val_7.eventType = 且下丕七丙丗丄不七;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9.gameObject, 丏业丟一东丂东丘丛:  true);
        int val_11 = this.东丆丏丛丑丞丂丐丑[(long)且下丕七丙丗丄不七];
        val_11 = val_11 + 1;
        this.东丆丏丛丑丞丂丐丑[(long)且下丕七丙丗丄不七] = val_11;
        return (ScopeViewGameEventGuiItem)val_9;
    }
    private void 丏丘丘三丏丄上世丈(ScopeViewGameEventGuiItem 上丆东世丘世丘丂丄)
    {
        if(上丆东世丘世丘丂丄 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  上丆东世丘世丘丂丄.gameObject, 丏业丟一东丂东丘丛:  false);
        int val_3 = this.东丆丏丛丑丞丂丐丑[上丆东世丘世丘丂丄.eventType];
        val_3 = val_3 - 1;
        this.东丆丏丛丑丞丂丐丑[上丆东世丘世丘丂丄.eventType] = val_3;
        this.世上一丟丑丈丈丗且[上丆东世丘世丘丂丄.eventType].Add(item:  上丆东世丘世丘丂丄);
    }
    private ScopeViewGameEventGuiItem 丐专与专东且丆上丐(业丗丕丟三丝丘三丗.丗丄丐丈丛丛三丗丏 且下丕七丙丗丄不七)
    {
        return 0;
    }
    public 业丗丕丟三丝丘三丗 AddEvent(业丗丕丟三丝丘三丗.丗丄丐丈丛丛三丗丏 且下丕七丙丗丄不七, UnityEngine.Transform 业不不丞专丗丟世丈, UnityEngine.Color 丑丞丈丗丄丙丟万丄, float 丑丘丛丆丝上丂丙丗 = -1, float 丐丟丕丌与丞丅下万 = 1)
    {
        ScopeViewGameEventGuiItem val_8;
        if((this.eventsSettings == null) || (this.eventsSettings.Length <= 且下丕七丙丗丄不七))
        {
            goto label_2;
        }
        
        ScopeViewGameEventSettings val_8 = this.eventsSettings[(long)且下丕七丙丗丄不七];
        业丗丕丟三丝丘三丗 val_1 = new 业丗丕丟三丝丘三丗(丑不丛三丞丅且丑丕:  this.eventsSettings[(long)且下丕七丙丗丄不七], 丛丌丕丐世丑丂七丂:  业不不丞专丗丟世丈, 丂丄一丗业丗丐万丏:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a}, 丑丘丛丆丝上丂丙丗:  丑丘丛丆丝上丂丙丗, 丐丟丕丌与丞丅下万:  丐丟丕丌与丞丅下万);
        if(this.eventsSettings[(long)(int)(且下丕七丙丗丄不七)][0].showType == 0)
        {
            goto label_11;
        }
        
        val_8 = 0;
        if(val_1 != null)
        {
            goto label_25;
        }
        
        goto label_13;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Debug.LogError(message:  "Can\'t find settings for: "("Can\'t find settings for: ") + 且下丕七丙丗丄不七.ToString());
        return 0;
        label_11:
        UnityEngine.Object val_12 = 0;
        val_12 = UnityEngine.Object.op_Inequality(x:  ScopeViewGameEventsController.丏丈万丅与丌不东丄(), y:  val_12);
        val_8 = 0;
        if((val_1.丑丕丈丈不不且丑且(丌世丟丆丄丞丞业丈:  val_12)) != false)
        {
                if(this.东丆丏丛丑丞丂丐丑[(long)且下丕七丙丗丄不七] >= this.eventsSettings[(long)(int)(且下丕七丙丗丄不七)][0].maxGuiItemsCount)
        {
                return 0;
        }
        
            val_8 = this.丐丂业专万丐万丕万(且下丕七丙丗丄不七:  且下丕七丙丗丄不七);
        }
        
        if(val_1 != null)
        {
            goto label_25;
        }
        
        label_13:
        label_25:
        val_1.三丌丆与东万丌丞专(丙业与丙丗丝不丈东:  val_8);
        this.七不丛丐丏丗丈且丕[(long)且下丕七丙丗丄不七].Add(item:  val_1);
        ScopeViewGameEventSettings val_14 = this.eventsSettings[(long)且下丕七丙丗丄不七];
        if(this.东丆丏丛丑丞丂丐丑[(long)且下丕七丙丗丄不七] >= this.eventsSettings[(long)(int)(且下丕七丙丗丄不七)][0].maxGuiItemsCount)
        {
                return 0;
        }
        
        this.一丛东丁丛专丐且下(且下丕七丙丗丄不七:  且下丕七丙丗丄不七);
        return 0;
    }
    private void 丘丁丂丘三丒丙丈丄(业丗丕丟三丝丘三丗 丅东专与不三丂丁丝)
    {
        UnityEngine.Object val_5;
        if(丅东专与不三丂丁丝 == null)
        {
                return;
        }
        
        bool val_1 = this.七不丛丐丏丗丈且丕[丅东专与不三丂丁丝.丑丗专丆一上世业丗.eventType].Remove(item:  丅东专与不三丂丁丝);
        val_5 = 丅东专与不三丂丁丝.上世不丆丌丄世下且();
        if(val_5 != 0)
        {
                this.丏丘丘三丏丄上世丈(上丆东世丘世丘丂丄:  丅东专与不三丂丁丝.上世不丆丌丄世下且());
        }
        
        丅东专与不三丂丁丝.下丌丘七专丂七三丆 = true;
    }
    public void DisableEvent(业丗丕丟三丝丘三丗 丅东专与不三丂丁丝)
    {
        业丗丕丟三丝丘三丗 val_3;
        业丗丕丟三丝丘三丗 val_4;
        业丗丕丟三丝丘三丗 val_5;
        val_3 = 丅东专与不三丂丁丝;
        ScopeViewGameEventsController.三丅丞丒丕丅专一丅 val_1 = new ScopeViewGameEventsController.三丅丞丒丕丅专一丅();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .丅东专与不三丂丁丝 = val_3;
        mem[1152921538907939728] = this;
        if(val_3 == null)
        {
                return;
        }
        
        label_5:
        if(val_1 == null)
        {
                val_4 = .丅东专与不三丂丁丝;
        }
        
        val_4.丆世与丑丆丅丐万且(且七丂丆丅不丏丂丗:  new 业丗丕丟三丝丘三丗.丏东丂专丗不丟一与(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void ScopeViewGameEventsController.三丅丞丒丕丅专一丅::丒丙丄上业丛丒东一()));
        return;
        label_1:
        mem[16] = this;
        mem[24] = val_3;
        val_5 = mem[24];
        if(val_5 != 0)
        {
            goto label_5;
        }
    
    }
    public void ResetTimedEvents()
    {
        goto label_1;
        label_19:
        ScopeViewGameEventSettings val_4 = this.eventsSettings[0];
        if(this.eventsSettings[0x0][0].showType == 0)
        {
                System.Collections.Generic.List<业丗丕丟三丝丘三丗> val_5 = this.七不丛丐丏丗丈且丕[0];
            val_5 = val_5.Count - 1;
            if((val_5 & 2147483648) == 0)
        {
                do
        {
            业丗丕丟三丝丘三丗 val_2 = this.七不丛丐丏丗丈且丕[0].Item[val_5];
            if(val_2 != null)
        {
                this.丏丘丘三丏丄上世丈(上丆东世丘世丘丂丄:  val_2.上世不丆丌丄世下且());
        }
        
            this.七不丛丐丏丗丈且丕[0].RemoveAt(index:  val_5);
            val_5 = val_5 - 1;
        }
        while((val_5 & 2147483648) == 0);
        
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < this.七不丛丐丏丗丈且丕.Length)
        {
            goto label_19;
        }
    
    }
    private void 一丛东丁丛专丐且下(int 且下丕七丙丗丄不七)
    {
        System.Collections.Generic.List<业丗丕丟三丝丘三丗>[] val_44;
        UnityEngine.Object val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        int val_51;
        var val_52;
        int val_46 = 且下丕七丙丗丄不七;
        val_45 = ScopeViewGameEventsController.丏丈万丅与丌不东丄();
        if(val_45 == 0)
        {
                return;
        }
        
        val_44 = this.七不丛丐丏丗丈且丕;
        val_45 = val_44[(long)val_46];
        if(val_45.Count == 0)
        {
                return;
        }
        
        val_46 = val_45.Count;
        ScopeViewGameEventSettings val_45 = this.eventsSettings[(long)val_46];
        int val_8 = UnityEngine.Mathf.Clamp(value:  val_46 - this.eventsSettings[(long)(int)(且下丕七丙丗丄不七)][0].maxGuiItemsCount, min:  0, max:  val_45.Count - 1);
        int val_9 = val_45.Count;
        val_46 = val_9 - val_8;
        if(val_46 < 1)
        {
            goto label_18;
        }
        
        var val_47 = 0;
        val_47 = 0;
        label_28:
        val_48 = 0;
        goto label_19;
        label_23:
        float val_11 = val_9.Item[0].丘丗专不丌且丏不丐();
        int val_12 = (val_11 < 0) ? (val_48) : (val_47);
        var val_13 = (val_11 < 0) ? (val_11) : 3.402823E+38f;
        val_48 = 1;
        label_19:
        if(val_48 < (val_45.Count - 0))
        {
            goto label_23;
        }
        
        if(val_45 != null)
        {
                val_49 = val_45.Count;
        }
        else
        {
                val_49 = val_45.Count;
        }
        
        val_47 = val_47 - 1;
        业丗丕丟三丝丘三丗 val_20 = val_45.Item[val_47 + val_49];
        if(val_45 != null)
        {
                val_45.set_Item(index:  val_12, value:  val_20);
            val_50 = val_45.Count;
        }
        else
        {
                val_45.set_Item(index:  val_12, value:  val_20);
            val_50 = val_45.Count;
        }
        
        val_45.set_Item(index:  val_47 + val_50, value:  val_45.Item[val_12]);
        val_46 = 0;
        if((0 + 1) != val_46)
        {
            goto label_28;
        }
        
        label_18:
        val_44 = 1152921504848912384;
        val_51 = val_8;
        int val_49 = val_45.Count;
        goto label_38;
        label_66:
        if(val_45.Item[val_49].丕世一与业丅万专丑() == false)
        {
                return;
        }
        
        if(val_45.Item[val_49].上世不丆丌丄世下且() != 0)
        {
            goto label_38;
        }
        
        var val_31 = mem[1152921538908729832] + (((long)(int)(且下丕七丙丗丄不七)) << 2);
        ScopeViewGameEventSettings val_48 = this.eventsSettings[(long)val_46];
        val_44 = 1152921504848912384;
        if(((mem[1152921538908729832] + ((long)(int)(且下丕七丙丗丄不七)) << 2) + 32) >= this.eventsSettings[(long)(int)(且下丕七丙丗丄不七)][0].maxGuiItemsCount)
        {
            goto label_55;
        }
        
        val_45.Item[val_49].三丌丆与东万丌丞专(丙业与丙丗丝不丈东:  this.丐丂业专万丐万丕万(且下丕七丙丗丄不七:  val_46));
        val_51 = val_8;
        if(val_45 != null)
        {
            goto label_62;
        }
        
        goto label_48;
        label_55:
        if(1 >= val_45.Count)
        {
            goto label_50;
        }
        
        if(val_45.Item[1].上世不丆丌丄世下且() == 0)
        {
            goto label_55;
        }
        
        if(val_45 != null)
        {
                val_52 = val_45.Item[val_49];
        }
        else
        {
                val_52 = val_45.Item[val_49];
        }
        
        val_52.三丌丆与东万丌丞专(丙业与丙丗丝不丈东:  val_45.Item[1].上世不丆丌丄世下且());
        val_45.Item[1].三丌丆与东万丌丞专(丙业与丙丗丝不丈东:  0);
        val_51 = val_8;
        label_50:
        if(val_45 != null)
        {
            goto label_62;
        }
        
        label_48:
        label_62:
        val_45.Item[val_49].且七丙丄丘一丄上不();
        val_45.Item[val_49].下与丞三丅丛丄七丕();
        label_38:
        val_49 = val_49 - 1;
        if(val_49 >= val_51)
        {
            goto label_66;
        }
    
    }
    internal bool 丏世三万丟丙丙丟丘()
    {
        System.Collections.Generic.List<业丗丕丟三丝丘三丗>[] val_6;
        var val_7;
        val_6 = this.七不丛丐丏丗丈且丕;
        System.Collections.Generic.List<业丗丕丟三丝丘三丗> val_6 = val_6[0];
        if(val_6 == null)
        {
            goto label_3;
        }
        
        List.Enumerator<T> val_1 = val_6.GetEnumerator();
        label_10:
        label_8:
        if(((-57546792) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((val_2.丕世一与业丅万专丑() == false) || (1000f <= val_2.丘丗专不丌且丏不丐()))
        {
            goto label_8;
        }
        
        float val_5 = val_2.丘丗专不丌且丏不丐();
        goto label_10;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(1000f < 0)
        {
            goto label_17;
        }
        
        label_3:
        val_7 = 0;
        return (bool)val_7;
        label_17:
        val_7 = 1;
        return (bool)val_7;
    }
    private void LateUpdate()
    {
        float val_21;
        var val_22;
        int val_23;
        if(ScopeViewGameEventsController.丏丈万丅与丌不东丄() == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_5 = ScopeViewGameEventsController.丏丈万丅与丌不东丄().rotation;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_21 = val_6.x;
        this.丌丟丄业且三丛丕丄().localRotation = new UnityEngine.Quaternion() {x = val_21, y = val_6.y, z = val_6.z, w = val_6.w};
        val_22 = 0;
        goto label_12;
        label_46:
        System.Collections.Generic.List<业丗丕丟三丝丘三丗> val_20 = this.七不丛丐丏丗丈且丕[0];
        ScopeViewGameEventSettings val_21 = this.eventsSettings[0];
        if(this.eventsSettings[0x0][0].showType == 1)
        {
                val_21 = UnityEngine.Time.realtimeSinceStartup;
            float val_22 = this.丑且丈丘丅丑丏丙一[0];
            val_22 = val_21 - val_22;
            if(val_22 > 1f)
        {
                val_21 = UnityEngine.Time.realtimeSinceStartup;
            this.丑且丈丘丅丑丏丙一[0] = val_21;
            this.一丛东丁丛专丐且下(且下丕七丙丗丄不七:  0);
        }
        
        }
        
        val_23 = val_20.Count - 1;
        if((val_23 & 2147483648) != 0)
        {
            goto label_29;
        }
        
        label_44:
        业丗丕丟三丝丘三丗 val_12 = val_20.Item[val_23];
        if(val_12 == null)
        {
            goto label_31;
        }
        
        if((val_12.丑丕丈丈不不且丑且(丌世丟丆丄丞丞业丈:  UnityEngine.Object.op_Inequality(x:  ScopeViewGameEventsController.丏丈万丅与丌不东丄(), y:  0))) == false)
        {
            goto label_32;
        }
        
        val_12.上专丄丑专丑丘业丌();
        goto label_42;
        label_31:
        UnityEngine.Debug.LogError(message:  "Null event in list!");
        goto label_42;
        label_32:
        if(val_12.上世不丆丌丄世下且() == 0)
        {
            goto label_42;
        }
        
        if(this.eventsSettings[0x0][0].showType != 1)
        {
            goto label_40;
        }
        
        if(val_12.丕世一与业丅万专丑() == true)
        {
            goto label_42;
        }
        
        this.丏丘丘三丏丄上世丈(上丆东世丘世丘丂丄:  val_12.上世不丆丌丄世下且());
        val_12.三丌丆与东万丌丞专(丙业与丙丗丝不丈东:  0);
        goto label_42;
        label_40:
        this.丏丘丘三丏丄上世丈(上丆东世丘世丘丂丄:  val_12.上世不丆丌丄世下且());
        val_12.三丌丆与东万丌丞专(丙业与丙丗丝不丈东:  0);
        val_20.RemoveAt(index:  val_23);
        label_42:
        val_23 = val_23 - 1;
        if((val_23 & 2147483648) == 0)
        {
            goto label_44;
        }
        
        label_29:
        val_22 = 1;
        label_12:
        if(val_22 < this.七不丛丐丏丗丈且丕.Length)
        {
            goto label_46;
        }
    
    }
    public ScopeViewGameEventsController()
    {
    
    }
    private static ScopeViewGameEventsController()
    {
    
    }

}
