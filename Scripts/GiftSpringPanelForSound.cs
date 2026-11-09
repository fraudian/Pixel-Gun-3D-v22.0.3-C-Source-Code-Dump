using UnityEngine;
public class GiftSpringPanelForSound : SpringPanel
{
    // Fields
    internal UnityEngine.AudioClip 丙丁专下且丞丆东丙;
    internal int 丆丁丐丈丂七丙丁丗;
    internal UIWrapContent 上丈世丁丐丒业上世;
    internal UnityEngine.Vector3 与丕丝且不丑丞一丕;
    
    // Methods
    protected override void 与丑与丙丒下丟丛丆()
    {
        GiftSpringPanelForSound val_20;
        float val_24;
        float val_25;
        float val_26;
        float val_30;
        var val_32;
        val_20 = this;
        UnityEngine.Vector3 val_2 = localPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_4 = localPosition;
        if(W21 != 0)
        {
                UnityEngine.Vector3 val_5 = this.丐上丐上东丐专上不(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3(), 丛上丟丌丄丗丁世与:  null);
        }
        else
        {
                UnityEngine.Vector3 val_6 = 万丗丅且丄丑世专与.七下丙不业一丑丞业(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3(), 丛上丟丌丄丗丁世与:  null, 丑丗丘与丈不七东丛:  RealTime.deltaTime);
        }
        
        val_24 = val_6.x;
        val_25 = val_6.y;
        val_26 = val_6.z;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, b:  new UnityEngine.Vector3() {x = V9.16B, y = V14.16B, z = V15.16B});
        if(val_7.x < 0)
        {
                if((-64352716) != 0)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_30 = val_9.z;
            GetComponent<UIScrollView>().currentMomentum = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_30};
            mem[1152921537839471884] = 0;
        }
        
            this.enabled = false;
            val_32 = 1;
        }
        else
        {
                val_32 = 0;
        }
        
        localPosition = new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector2 val_11 = clipOffset;
        clipOffset = new UnityEngine.Vector2() {x = val_11.x - val_10.x, y = val_11.y - val_10.y};
        bool val_14 = UnityEngine.Object.op_Inequality(x:  137125888, y:  0);
        if(((this.上丈世丁丐丒业上世 != 0) && (this.丙丁专下且丞丆东丙 != 0)) && (与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false))
        {
                val_24 = System.Math.Abs(this.与丕丝且不丑丞一丕 - val_24);
            int val_20 = this.上丈世丁丐丒业上世.itemSize;
            val_20 = (int)val_24 / val_20;
            if(this.丆丁丐丈丂七丙丁丗 != val_20)
        {
                this.丆丁丐丈丂七丙丁丗 = val_20;
            UnityEngine.AudioSource val_19 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丙丁专下且丞丆东丙);
        }
        
        }
        
        if(val_32 == 0)
        {
                return;
        }
        
        SpringPanel.current = val_20;
        this.Invoke();
        SpringPanel.current = 0;
    }
    public static GiftSpringPanelForSound Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector3 下业丕七东丌丝下且, float 丛上丟丌丄丗丁世与)
    {
        GiftSpringPanelForSound val_4 = 丝三丁东丈丒世丅业.GetComponent<GiftSpringPanelForSound>();
        if(val_4 == 0)
        {
                val_4 = 丝三丁东丈丒世丅业.AddComponent<GiftSpringPanelForSound>();
        }
        
        mem2[0] = 下业丕七东丌丝下且.x;
        mem2[0] = 下业丕七东丌丝下且.y;
        mem2[0] = 下业丕七东丌丝下且.z;
        if(val_4 != null)
        {
                mem2[0] = 丛上丟丌丄丗丁世与;
            mem2[0] = 0;
            val_4.enabled = true;
        }
        else
        {
                mem2[0] = 丛上丟丌丄丗丁世与;
            mem[40] = 0;
            0.enabled = true;
        }
        
        mem2[0] = 0;
        return (GiftSpringPanelForSound)val_4;
    }
    public static GiftSpringPanelForSound BeginWithSound(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector3 下业丕七东丌丝下且, float 丛上丟丌丄丗丁世与, UnityEngine.AudioClip 丏世一不与丗丏三不)
    {
        UIWrapContent val_1 = 丝三丁东丈丒世丅业.GetComponentInChildren<UIWrapContent>();
        return GiftSpringPanelForSound.BeginWithSound(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 丛上丟丌丄丗丁世与:  丛上丟丌丄丗丁世与, 丏世一不与丗丏三不:  丏世一不与丗丏三不, 丄丕丝下丒东上丞丁:  null);
    }
    public static GiftSpringPanelForSound BeginWithSound(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector3 下业丕七东丌丝下且, float 丛上丟丌丄丗丁世与, UnityEngine.AudioClip 丏世一不与丗丏三不, UIWrapContent 丄丕丝下丒东上丞丁)
    {
        GiftSpringPanelForSound val_7 = 丝三丁东丈丒世丅业.GetComponent<GiftSpringPanelForSound>();
        if(val_7 == 0)
        {
                val_7 = 丝三丁东丈丒世丅业.AddComponent<GiftSpringPanelForSound>();
        }
        
        mem2[0] = 下业丕七东丌丝下且.x;
        mem2[0] = 下业丕七东丌丝下且.y;
        mem2[0] = 下业丕七东丌丝下且.z;
        if(val_7 != null)
        {
                mem2[0] = 丛上丟丌丄丗丁世与;
            mem2[0] = 0;
            val_7.enabled = true;
            mem2[0] = 0;
            val_3.丙丁专下且丞丆东丙 = 丏世一不与丗丏三不;
        }
        else
        {
                mem2[0] = 丛上丟丌丄丗丁世与;
            mem[40] = 0;
            0.enabled = true;
            mem[72] = 0;
            mem[96] = 丏世一不与丗丏三不;
        }
        
        val_3.丆丁丐丈丂七丙丁丗 = 0;
        val_3.上丈世丁丐丒业上世 = 丝三丁东丈丒世丅业.GetComponentInChildren<UIWrapContent>();
        UnityEngine.Vector3 val_6 = val_7.transform.localPosition;
        val_3.与丕丝且不丑丞一丕 = val_6;
        mem2[0] = val_6.y;
        mem2[0] = val_6.z;
        return (GiftSpringPanelForSound)val_7;
    }
    public GiftSpringPanelForSound()
    {
        this.丆丁丐丈丂七丙丁丗 = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.与丕丝且不丑丞一丕 = val_1;
        mem[1152921537840054076] = val_1.y;
        mem[1152921537840054080] = val_1.z;
    }

}
