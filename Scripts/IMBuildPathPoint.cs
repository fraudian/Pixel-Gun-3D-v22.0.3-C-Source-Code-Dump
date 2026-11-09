using UnityEngine;
public class IMBuildPathPoint : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject activatedObject;
    public UITexture lineForPath;
    public UnityEngine.Transform path;
    public UnityEngine.Color disabled;
    public UnityEngine.Color activated;
    public bool isActivated;
    internal int 丞世不丒下上上丝丑;
    
    // Methods
    private void Start()
    {
        this.且三丛三丟不业丛一();
        this.与七且三丌丁丒专丑();
    }
    private void 且三丛三丟不业丛一()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.activatedObject, 丏业丟一东丂东丘丛:  (this.isActivated == false) ? 1 : 0);
    }
    internal void 万且丄上三丝东丗丙()
    {
        this.isActivated = true;
        this.且三丛三丟不业丛一();
    }
    internal void 不与丁丕丒丄上三丟()
    {
        this.isActivated = false;
        this.且三丛三丟不业丛一();
        this.与七且三丌丁丒专丑();
    }
    internal void 与七且三丌丁丒专丑()
    {
        UnityEngine.Color val_2;
        var val_3;
        var val_4;
        var val_5;
        if(this.lineForPath == 0)
        {
                return;
        }
        
        if(this.isActivated != false)
        {
                val_2 = this.activated;
            val_3 = 1152921537624291524;
            val_4 = 1152921537624291528;
            val_5 = 1152921537624291532;
        }
        else
        {
                val_2 = this.disabled;
            val_3 = 1152921537624291508;
            val_4 = 1152921537624291512;
            val_5 = 1152921537624291516;
        }
        
        this.lineForPath.color = new UnityEngine.Color() {r = this.disabled.r, g = 8.670229E-18f, b = 8.670229E-18f, a = 8.670229E-18f};
    }
    public IMBuildPathPoint()
    {
        this.丞世不丒下上上丝丑 = 0;
    }

}
