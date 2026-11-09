using UnityEngine;
internal sealed class TapOnThisWidgetCheckUI : PGBehaviour
{
    // Fields
    private UIWidget widget;
    private UnityEngine.Vector4 一且丙丈丕丏丂三丐;
    private bool 东丂丆丂上与丌专万;
    private UnityEngine.Vector3 丑丑丘三丅三丗丅丏;
    
    // Properties
    private UnityEngine.Vector4 世下丁丁丑丑业丂丞 { get; }
    
    // Methods
    private UnityEngine.Vector4 不丙丛万业丂下且丙()
    {
        float val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Vector4 val_15;
        var val_16;
        var val_17;
        var val_18;
        if(this.东丂丆丂上与丌专万 == false)
        {
            goto label_1;
        }
        
        UnityEngine.Vector3 val_2 = this.widget.transform.position;
        val_11 = val_2.x;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_11, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = this.丑丑丘三丅三丗丅丏, y = V11.16B, z = V10.16B})) == false)
        {
            goto label_6;
        }
        
        label_1:
        if(null == null)
        {
                val_12 = 0;
        }
        
        if(null == null)
        {
                val_13 = 0;
        }
        
        if(null <= 2)
        {
                val_14 = 0;
        }
        
        val_15 = this;
        this.一且丙丈丕丏丂三丐 = 0;
        this.东丂丆丂上与丌专万 = true;
        val_16 = 1152921537645184500;
        val_17 = 1152921537645184504;
        val_18 = 1152921537645184508;
        UnityEngine.Vector3 val_5 = this.widget.transform.position;
        this.丑丑丘三丅三丗丅丏 = val_5;
        mem[1152921537645184520] = val_5.y;
        mem[1152921537645184524] = val_5.z;
        return new UnityEngine.Vector4() {x = this.一且丙丈丕丏丂三丐.x, y = 9.507098E-18f, z = 9.507098E-18f, w = 9.507098E-18f};
        label_6:
        val_15 = this.一且丙丈丕丏丂三丐;
        val_16 = 1152921537645184500;
        val_17 = 1152921537645184504;
        val_18 = 1152921537645184508;
        return new UnityEngine.Vector4() {x = this.一且丙丈丕丏丂三丐.x, y = 9.507098E-18f, z = 9.507098E-18f, w = 9.507098E-18f};
    }
    internal bool 一丁且上丛丛丐下丛(UnityEngine.Vector3 一丁丂东丏丙上丟且)
    {
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(this.gameObject.activeInHierarchy == false)
        {
                return false;
        }
        
        }
        
        if(this.widget == 0)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_5 = this.不丙丛万业丂下且丙();
        if(一丁丂东丏丙上丟且.x < val_5.x)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_6 = this.不丙丛万业丂下且丙();
        if(一丁丂东丏丙上丟且.y < val_6.y)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_7 = this.不丙丛万业丂下且丙();
        if(一丁丂东丏丙上丟且.x > val_7.z)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_8 = this.不丙丛万业丂下且丙();
        var val_9 = (一丁丂东丏丙上丟且.y <= val_8.w) ? 1 : 0;
        return false;
    }
    public TapOnThisWidgetCheckUI()
    {
    
    }

}
