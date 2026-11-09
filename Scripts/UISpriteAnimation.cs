using UnityEngine;
public class UISpriteAnimation : MonoBehaviour
{
    // Fields
    protected int mFPS;
    protected string mPrefix;
    protected bool mLoop;
    protected bool mSnap;
    protected UISprite 丂丑丌丂丝专丗丆东;
    protected float 万万一一丈世下丅上;
    protected int 丄丒业专业丅丘丐丈;
    protected bool 万丝业下下丏丆丏东;
    protected System.Collections.Generic.List<string> 一且七丅万三与丙丐;
    
    // Properties
    public int 丙丁与丈上与且丏丝 { get; }
    public int 下丗丒丑丐丕丂东丟 { get; set; }
    public string 上与丞丛丒丅下丞丆 { get; set; }
    public bool 东且丒丌且丈丞丗与 { get; set; }
    public bool 下丐丈丄丗丞丕业丆 { get; }
    
    // Methods
    public int get_frames()
    {
        if(this.一且七丅万三与丙丐 != null)
        {
                return this.一且七丅万三与丙丐.Count;
        }
        
        return this.一且七丅万三与丙丐.Count;
    }
    public int get_framesPerSecond()
    {
        return (int)this.mFPS;
    }
    public void set_framesPerSecond(int 丙业与丙丗丝不丈东)
    {
        this.mFPS = 丙业与丙丗丝不丈东;
    }
    public string get_namePrefix()
    {
        return (string)this.mPrefix;
    }
    public void set_namePrefix(string 丙业与丙丗丝不丈东)
    {
        if((System.String.op_Inequality(a:  this.mPrefix, b:  丙业与丙丗丝不丈东)) == false)
        {
                return;
        }
        
        this.mPrefix = 丙业与丙丗丝不丈东;
        this.RebuildSpriteList();
    }
    public bool get_loop()
    {
        return (bool)this.mLoop;
    }
    public void set_loop(bool 丙业与丙丗丝不丈东)
    {
        this.mLoop = 丙业与丙丗丝不丈东;
    }
    public bool get_isPlaying()
    {
        return (bool)this.万丝业下下丏丆丏东;
    }
    protected virtual void Start()
    {
        this.RebuildSpriteList();
    }
    protected virtual void Update()
    {
        var val_15;
        string val_16;
        val_15 = this;
        if(this.万丝业下下丏丆丏东 == false)
        {
                return;
        }
        
        val_16 = 1152921516934571616;
        if(this.一且七丅万三与丙丐.Count < 2)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        if(this.mFPS < 1)
        {
                return;
        }
        
        float val_3 = RealTime.deltaTime;
        val_3 = this.万万一一丈世下丅上 + val_3;
        this.万万一一丈世下丅上 = val_3;
        float val_15 = (float)this.mFPS;
        val_15 = 1f / val_15;
        if(val_15 >= 0)
        {
                return;
        }
        
        val_3 = val_3 - val_15;
        int val_5 = this.丄丒业专业丅丘丐丈 + 1;
        this.万万一一丈世下丅上 = (val_15 > 0f) ? (val_3) : 0f;
        this.丄丒业专业丅丘丐丈 = val_5;
        if(val_5 >= this.一且七丅万三与丙丐.Count)
        {
            goto label_8;
        }
        
        if(this.万丝业下下丏丆丏东 == true)
        {
            goto label_9;
        }
        
        return;
        label_8:
        this.丄丒业专业丅丘丐丈 = 0;
        this.万丝业下下丏丆丏东 = this.mLoop;
        if(this.mLoop == false)
        {
                return;
        }
        
        label_9:
        val_16 = this.一且七丅万三与丙丐.Item[this.丄丒业专业丅丘丐丈];
        this.丂丑丌丂丝专丗丆东.spriteName = val_16;
        if(this.mSnap == false)
        {
                return;
        }
        
        val_15 = ???;
        val_16 = ???;
        goto typeof(UISprite).__il2cppRuntimeField_358;
    }
    public void RebuildSpriteList()
    {
        string val_10;
        System.Collections.Generic.List<System.String> val_11;
        if(this.丂丑丌丂丝专丗丆东 == 0)
        {
                this.丂丑丌丂丝专丗丆东 = this.GetComponent<UISprite>();
        }
        
        this.一且七丅万三与丙丐.Clear();
        if(this.丂丑丌丂丝专丗丆东 == 0)
        {
                return;
        }
        
        if(this.丂丑丌丂丝专丗丆东.mAtlas == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<UISpriteData> val_5 = this.丂丑丌丂丝专丗丆东.mAtlas.spriteList;
        int val_6 = val_5.Count;
        if(val_6 < 1)
        {
            goto label_15;
        }
        
        var val_10 = 0;
        label_24:
        val_10 = val_5.Item[0];
        if((System.String.IsNullOrEmpty(value:  this.mPrefix)) == false)
        {
            goto label_17;
        }
        
        val_11 = this.一且七丅万三与丙丐;
        if(val_10 != null)
        {
            goto label_19;
        }
        
        goto label_19;
        label_17:
        if((val_7.name.StartsWith(value:  this.mPrefix)) == false)
        {
            goto label_22;
        }
        
        val_11 = this.一且七丅万三与丙丐;
        label_19:
        val_10 = val_7.name;
        val_11.Add(item:  val_10);
        label_22:
        val_10 = val_10 + 1;
        if(val_6 != val_10)
        {
            goto label_24;
        }
        
        label_15:
        this.一且七丅万三与丙丐.Sort();
    }
    public void Play()
    {
        this.万丝业下下丏丆丏东 = true;
    }
    public void Pause()
    {
        this.万丝业下下丏丆丏东 = false;
    }
    public void ResetToBeginning()
    {
        var val_10;
        string val_11;
        val_10 = this;
        this.丄丒业专业丅丘丐丈 = 0;
        this.万丝业下下丏丆丏东 = true;
        if(this.丂丑丌丂丝专丗丆东 == 0)
        {
                return;
        }
        
        if(this.一且七丅万三与丙丐.Count < 1)
        {
                return;
        }
        
        val_11 = this.一且七丅万三与丙丐.Item[this.丄丒业专业丅丘丐丈];
        this.丂丑丌丂丝专丗丆东.spriteName = val_11;
        if(this.mSnap == false)
        {
                return;
        }
        
        val_10 = ???;
        val_11 = ???;
        goto typeof(UISprite).__il2cppRuntimeField_358;
    }
    public UISpriteAnimation()
    {
        this.mFPS = 30;
        this.mLoop = true;
        this.mSnap = true;
        this.万丝业下下丏丆丏东 = true;
        this.mPrefix = "";
        this.一且七丅万三与丙丐 = new System.Collections.Generic.List<System.String>();
    }

}
