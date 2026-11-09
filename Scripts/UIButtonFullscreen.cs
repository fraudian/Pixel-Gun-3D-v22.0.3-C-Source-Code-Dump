using UnityEngine;
public class UIButtonFullscreen : MonoBehaviour
{
    // Fields
    public UIWidget normalState;
    public UIWidget exitState;
    public UIStretch stretch;
    public UIWidget widget;
    public UIDragObject drag;
    public UIDragResize resize;
    public float speed;
    public UITweener.丞丝不丐丘不丕丞不 ease;
    public int defaultWidth;
    public int defaultHeight;
    private bool 丗丙丆丏业世丆丗与;
    
    // Methods
    private void Awake()
    {
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.normalState.gameObject, 丏业丟一东丂东丘丛:  true);
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.exitState.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void OnClick()
    {
        var val_24;
        UnityEngine.GameObject val_25;
        var val_26;
        UnityEngine.GameObject val_27;
        this.丗丙丆丏业世丆丗与 = this.丗丙丆丏业世丆丗与 ^ 1;
        if(this.丗丙丆丏业世丆丗与 != false)
        {
                val_24 = 1152921505093320704;
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.normalState.gameObject, 丏业丟一东丂东丘丛:  true);
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.exitState.gameObject, 丏业丟一东丂东丘丛:  false);
            this.stretch.style = 0;
            this.stretch.enabled = false;
            TweenWidth val_4 = TweenWidth.Begin(世丌丌丙丞丟下东丞:  this.widget, 与丈业丛丝丒丙一丏:  this.speed, 业与三万七丝不万东:  this.defaultWidth);
            mem2[0] = this.ease;
            TweenHeight val_5 = TweenHeight.Begin(世丌丌丙丞丟下东丞:  this.widget, 与丈业丛丝丒丙一丏:  this.speed, 丟丌丐丘丆丙丑丑一:  this.defaultHeight);
            mem2[0] = this.ease;
            if(this.drag != 0)
        {
                不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.drag.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
            if(this.resize == 0)
        {
                return;
        }
        
            val_25 = this.resize.gameObject;
            val_26 = 1;
            val_27 = val_25;
        }
        else
        {
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            this.widget.cachedTransform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.normalState.gameObject, 丏业丟一东丂东丘丛:  false);
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.exitState.gameObject, 丏业丟一东丂东丘丛:  true);
            TweenWidth val_15 = TweenWidth.Begin(世丌丌丙丞丟下东丞:  this.widget, 与丈业丛丝丒丙一丏:  this.speed, 业与三万七丝不万东:  UnityEngine.Screen.width);
            if(val_15 != null)
        {
                mem2[0] = this.ease;
        }
        else
        {
                mem[24] = this.ease;
        }
        
            EventDelegate val_17 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_15, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UIButtonFullscreen::世丈且丆丄丁丂丂专()), 丕万三专丕不七专丐:  true);
            TweenHeight val_19 = TweenHeight.Begin(世丌丌丙丞丟下东丞:  this.widget, 与丈业丛丝丒丙一丏:  this.speed, 丟丌丐丘丆丙丑丑一:  UnityEngine.Screen.height);
            mem2[0] = this.ease;
            val_24 = 1152921504848912384;
            if(this.drag != 0)
        {
                不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  this.drag.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
            if(this.resize == 0)
        {
                return;
        }
        
            val_25 = this.resize.gameObject;
            val_27 = val_25;
            val_26 = 0;
        }
        
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_27, 丏业丟一东丂东丘丛:  false);
    }
    private void 世丈且丆丄丁丂丂专()
    {
        this.stretch.enabled = true;
        this.stretch.style = 3;
    }
    public UIButtonFullscreen()
    {
        this.speed = 1f;
        this.ease = 5;
        this.defaultWidth = 750;
        this.defaultHeight = 400;
    }

}
