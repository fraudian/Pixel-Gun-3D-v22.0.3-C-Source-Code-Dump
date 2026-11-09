using UnityEngine;
public class NJGMap : NJGMapBase
{
    // Fields
    private static NJGMap 丄丈丂丅上专万丞丏;
    public UIAtlas atlas;
    public UISpriteData defaultSprite;
    public UICamera uiCam;
    
    // Properties
    public static NJGMap 丄丘七三上丕世丞业 { get; }
    public override bool 丆丌丌一丙世上丆丞 { get; }
    
    // Methods
    public static NJGMap get_instance()
    {
        NJGMap val_5;
        var val_6;
        val_5 = NJGMap.丄丈丂丅上专万丞丏;
        if(val_5 != 0)
        {
                return (NJGMap)NJGMap.丄丈丂丅上专万丞丏;
        }
        
        val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  val_5);
        val_6 = 0;
        NJGMap.丄丈丂丅上专万丞丏 = ;
        return (NJGMap)NJGMap.丄丈丂丅上专万丞丏;
    }
    public override bool get_isMouseOver()
    {
        if(UICamera.hoveredObject != 0)
        {
                return true;
        }
        
        bool val_3 = UICamera.inputHasFocus;
        if(val_3 == false)
        {
                return val_3.isMouseOver;
        }
        
        return true;
    }
    public UISpriteData GetSprite(int 丁丅丈丌丟世丗丗丟)
    {
        UISpriteData val_4;
        if(this.atlas == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "You need to assign an atlas", context:  this);
            val_4 = 0;
            return val_4;
        }
        
        if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) != null)
        {
                MapItemType val_3 = this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟);
            if(this.atlas != null)
        {
                return this.atlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_3.sprite);
        }
        
            return this.atlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_3.sprite);
        }
        
        val_4 = this.defaultSprite;
        return val_4;
    }
    public UISpriteData GetSpriteBorder(int 丁丅丈丌丟世丗丗丟)
    {
        if(this.atlas == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "You need to assign an atlas", context:  this);
            return 0;
        }
        
        if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
        {
                return 0;
        }
        
        MapItemType val_3 = this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟);
        if(this.atlas != null)
        {
                return this.atlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_3.selectedSprite);
        }
        
        return this.atlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_3.selectedSprite);
    }
    public UISpriteData GetArrowSprite(int 丁丅丈丌丟世丗丗丟)
    {
        UISpriteData val_4;
        if(this.atlas == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "You need to assign an atlas", context:  this);
            val_4 = 0;
            return val_4;
        }
        
        if((this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) != null)
        {
                MapItemType val_3 = this.Get(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟);
            if(this.atlas != null)
        {
                return this.atlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_3.arrowSprite);
        }
        
            return this.atlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_3.arrowSprite);
        }
        
        val_4 = this.defaultSprite;
        return val_4;
    }
    private void OnDestroy()
    {
        if(UIMiniMap.instance != 0)
        {
                UIMiniMap.instance.mainTexture = 0;
        }
        
        if(UIWorldMap.instance != 0)
        {
                UIWorldMap val_6 = UIWorldMap.instance;
            val_6.mainTexture = 0;
        }
        
        bool val_7 = UnityEngine.Object.op_Inequality(x:  val_6, y:  0);
        if(val_7 != false)
        {
                丁丒丐丂万三丌万业.Destroy(万且万且丑丗且丌丆:  val_7);
        }
        
        mem[1152921535438977000] = 0;
    }
    public NJGMap()
    {
    
    }

}
