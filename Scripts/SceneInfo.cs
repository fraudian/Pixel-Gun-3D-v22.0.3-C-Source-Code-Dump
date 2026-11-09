using UnityEngine;
public sealed class SceneInfo : MonoBehaviour
{
    // Fields
    private bool 丆东且下丈丕丒一万;
    internal System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> avaliableInModes;
    public 丂丗世丏下专七丅不 AvaliableWeapon;
    public float gravity;
    public bool playerSurfacesSlidingEnabled;
    public float playerSlopeLimit;
    public int indexMap;
    public bool isPreloading;
    public bool isPremium;
    public string keyTranslateName;
    public string keyTranslateShortName;
    public string keyAlternativeTranslateName;
    public string keyAlternativeTranslateShortName;
    public string keyTranslateDescription;
    public string keyTranslateDescriptionAdditional;
    public string maxAvaliableVersion;
    public string minAvaliableVersion;
    public UnityEngine.Vector3 positionCam;
    public UnityEngine.Vector3 rotationCam;
    public 丒丙丛丅丁一专丟七 sizeMap;
    private string 且丅丐丙丙专与丁丁;
    private string 一丄丗专业丄丘丘丐;
    private string 三丐丟下一专世东不;
    private string 七三东丆专不丝东上;
    private string 东丛与丌专下丛丞丙;
    private string 丞万一上丑丆丑丈丌;
    
    // Properties
    internal bool 丘与丂丙丟一且丗丞 { get; }
    internal string 丏与丄不丅丆丄丞专 { get; }
    internal bool 世丄丝与丘丌丒丌上 { get; }
    internal Sounds 丕丘丈不且丛丒丛与 { get; }
    internal string 与丄丘丗丁丄万上与 { get; }
    internal string 三上万丗丒丁丘下上 { get; }
    internal string 世丞不丐丅七丌业七 { get; }
    internal string 丙丘丘专不丒不丙丅 { get; }
    internal string 丛专丝不三丗不丘丙 { get; }
    internal string 丂丁丗一丅丕世丕丑 { get; }
    internal string 丞业不丘世专丛丐丁 { get; }
    
    // Methods
    internal bool 丛丙丝丕丏丘一且且()
    {
        if(this.丆东且下丈丕丒一万 != false)
        {
                return true;
        }
        
        this.丆东且下丈丕丒一万 = this.isPreloading ^ 1;
        return (bool)(this.isPreloading == false) ? 1 : 0;
    }
    internal string 丙且上丒不下丑下丞()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.name;
        }
        
        return val_1.name;
    }
    internal bool 丕丗丏丑丘丘丛丄丄()
    {
        return true;
    }
    internal Sounds 七丑丞七与丅丅丞丈()
    {
        return 0;
    }
    internal string 上丘丙丒一丈丕丈世()
    {
        if(GameConnect.七丕丟上且丄丂丞丕() == false)
        {
                return (string)this.一丄丗专业丄丘丘丐;
        }
        
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.keyAlternativeTranslateName);
    }
    internal string 七丛一丛专七丈丅专()
    {
        if(GameConnect.七丕丟上且丄丂丞丕() == false)
        {
                return (string)this.三丐丟下一专世东不;
        }
        
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.keyAlternativeTranslateShortName);
    }
    internal string 三业丙三上丌丄与东()
    {
        return (string)this.三丐丟下一专世东不;
    }
    internal string 七丄丆丘七三丁专丗()
    {
        var val_1;
        if(this.sizeMap <= 3)
        {
                val_1 = mem[130691104 + (this.sizeMap) << 3];
            val_1 = 130691104 + (this.sizeMap) << 3;
            return (string)val_1;
        }
        
        val_1 = "";
        return (string)val_1;
    }
    internal string 与业上丙一丁丛丆丟()
    {
        return (string)this.七三东丆专不丝东上;
    }
    internal string 丝丌七上丘丑且丞与()
    {
        return (string)this.东丛与丌专下丛丞丙;
    }
    internal string 丁一上且丑丑业上不()
    {
        return (string)this.丞万一上丑丆丑丈丌;
    }
    internal void 丕东丆三丗丆万东丐()
    {
        bool val_1 = this.isPreloading;
        val_1 = val_1 ^ 1;
        this.丆东且下丈丕丒一万 = val_1;
    }
    internal bool 七丗与三丝丑丈一专(Rilisoft.七丕丟丏三丈一丄世 世专丝一丙业丅丌上)
    {
        var val_4;
        System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_5 = this.avaliableInModes;
        if(val_5 == null)
        {
                return (bool)val_5;
        }
        
        if(val_5.Count < 1)
        {
            goto label_4;
        }
        
        val_4 = 0;
        label_6:
        if(val_4 >= this.avaliableInModes.Count)
        {
            goto label_4;
        }
        
        val_4 = val_4 + 1;
        if(this.avaliableInModes.Item[0] != 世专丝一丙业丅丌上)
        {
            goto label_6;
        }
        
        val_5 = 1;
        return (bool)val_5;
        label_4:
        val_5 = 0;
        return (bool)val_5;
    }
    internal void 丗丐专世丛丄丑丐丛(Rilisoft.七丕丟丏三丈一丄世 世专丝一丙业丅丌上)
    {
        var val_3 = 0;
        label_4:
        if(val_3 >= this.avaliableInModes.Count)
        {
            goto label_3;
        }
        
        val_3 = val_3 + 1;
        if(this.avaliableInModes.Item[0] != 世专丝一丙业丅丌上)
        {
            goto label_4;
        }
        
        return;
        label_3:
        this.avaliableInModes.Add(item:  世专丝一丙业丅丌上);
    }
    internal void 丆丟丁丈丅丕丆丝专()
    {
        this.一丄丗专业丄丘丘丐 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.keyTranslateName);
        this.三丐丟下一专世东不 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.keyTranslateShortName);
        this.七三东丆专不丝东上 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.七丄丆丘七三丁专丗());
        this.且丅丐丙丙专与丁丁 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  this.keyTranslateShortName);
        this.东丛与丌专下丛丞丙 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.keyTranslateDescription);
        this.丞万一上丑丆丑丈丌 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.keyTranslateDescriptionAdditional);
    }
    internal void 且丗丐丙三上世丞丛(UnityEngine.GameObject 丒与三三丘东专丐七)
    {
        if(丒与三三丘东专丐七 == 0)
        {
                return;
        }
        
        丒与三三丘东专丐七.transform.position = new UnityEngine.Vector3() {x = this.positionCam, y = V9.16B, z = V10.16B};
        丒与三三丘东专丐七.transform.eulerAngles = new UnityEngine.Vector3() {x = this.rotationCam, y = V9.16B, z = V10.16B};
    }
    private void 丈丂上三丙丅丈丐丗()
    {
        var val_6;
        var val_7;
        val_6 = 0;
        val_7 = 0;
        goto label_1;
        label_8:
        UnityEngine.Object val_6 = UnityEngine.Resources.LoadAll(path:  "SceneInfo")[0];
        if(val_6 != null)
        {
                var val_2 = (null == null) ? (val_6) : 0;
        }
        
        SceneInfo val_3 = 0.GetComponent<SceneInfo>();
        val_6 = 1;
        label_1:
        if(val_6 < val_1.Length)
        {
            goto label_8;
        }
        
        this.indexMap = ((val_3.indexMap > val_7) ? val_3.indexMap : (val_7)) + 1;
    }
    public SceneInfo()
    {
        this.avaliableInModes = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
        this.gravity = -9.81f;
        this.playerSlopeLimit = 63f;
        this.keyTranslateName = "";
        this.keyTranslateShortName = "";
        this.keyAlternativeTranslateName = "";
        this.keyAlternativeTranslateShortName = "";
        this.keyTranslateDescription = "";
        this.keyTranslateDescriptionAdditional = "";
        this.且丅丐丙丙专与丁丁 = "";
        this.一丄丗专业丄丘丘丐 = "";
        this.三丐丟下一专世东不 = "";
        this.七三东丆专不丝东上 = "";
        this.东丛与丌专下丛丞丙 = "";
        this.丞万一上丑丆丑丈丌 = "";
        this.maxAvaliableVersion = "0.0.0.0";
        this.minAvaliableVersion = "0.0.0.0";
    }

}
