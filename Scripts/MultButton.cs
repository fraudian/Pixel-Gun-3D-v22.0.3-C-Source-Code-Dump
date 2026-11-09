using UnityEngine;
public class MultButton : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject[] _objects;
    private MultButton.丒不与与丗丄七三丅 丏业丟一东丂东丘丛;
    public UnityEngine.Color normal;
    public UnityEngine.Color pressed;
    public UnityEngine.Color disabled;
    private string _normalSpriteName;
    private string _pressedSpriteName;
    private string _disabledSpriteName;
    
    // Properties
    public string 丄一不与丞上下丗丁 { get; set; }
    public string 丄丙丘专丅丅丛丈丟 { get; set; }
    public string 七丒丅与丌丂丞一丑 { get; set; }
    
    // Methods
    public string get_normalSpriteName()
    {
        return (string)this._normalSpriteName;
    }
    public void set_normalSpriteName(string 丙业与丙丗丝不丈东)
    {
        if((System.String.op_Inequality(a:  this._normalSpriteName, b:  丙业与丙丗丝不丈东)) == false)
        {
                return;
        }
        
        this.与专丟业下且丕不丈(万丑丞一丝丌丐丒丘:  丙业与丙丗丝不丈东);
        this._normalSpriteName = 丙业与丙丗丝不丈东;
    }
    public string get_pressedSpriteName()
    {
        return (string)this._pressedSpriteName;
    }
    public void set_pressedSpriteName(string 丙业与丙丗丝不丈东)
    {
        this._pressedSpriteName = 丙业与丙丗丝不丈东;
    }
    public string get_disabledSpriteName()
    {
        return (string)this._disabledSpriteName;
    }
    public void set_disabledSpriteName(string 丙业与丙丗丝不丈东)
    {
        this._disabledSpriteName = 丙业与丙丗丝不丈东;
    }
    private void Start()
    {
        this.与专丟业下且丕不丈(万丑丞一丝丌丐丒丘:  this._normalSpriteName);
        this.丒丗丙丙丙丟专丅万(丆丛丂丝丄世且丛丕:  new UnityEngine.Color() {r = this.normal});
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        if(万东丂丒且丅丛丑丕 != false)
        {
                this.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  1);
            return;
        }
        
        this.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  0);
    }
    private void 丄丑七丘丁且丞丙专(MultButton.丒不与与丗丄七三丅 丏业丟一东丂东丘丛)
    {
        string val_1;
        if(丏业丟一东丂东丘丛 == 2)
        {
            goto label_0;
        }
        
        if(丏业丟一东丂东丘丛 == 1)
        {
            goto label_1;
        }
        
        if(丏业丟一东丂东丘丛 != 0)
        {
                return;
        }
        
        this.丒丗丙丙丙丟专丅万(丆丛丂丝丄世且丛丕:  new UnityEngine.Color() {r = this.normal});
        val_1 = this._normalSpriteName;
        goto label_4;
        label_0:
        this.丒丗丙丙丙丟专丅万(丆丛丂丝丄世且丛丕:  new UnityEngine.Color() {r = this.disabled});
        val_1 = this._disabledSpriteName;
        goto label_4;
        label_1:
        this.丒丗丙丙丙丟专丅万(丆丛丂丝丄世且丛丕:  new UnityEngine.Color() {r = this.pressed});
        val_1 = this._pressedSpriteName;
        label_4:
        this.与专丟业下且丕不丈(万丑丞一丝丌丐丒丘:  val_1);
    }
    private void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丆丛丂丝丄世且丛丕)
    {
        float val_22;
        float val_23;
        var val_24;
        System.Func<UnityEngine.GameObject, System.Boolean> val_26;
        var val_28;
        var val_29;
        var val_32;
        var val_33;
        val_22 = 丆丛丂丝丄世且丛丕.a;
        val_23 = 丆丛丂丝丄世且丛丕.g;
        val_24 = null;
        val_24 = null;
        val_26 = MultButton.<>c.<>9__21_0;
        if(val_26 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_1 = null;
            val_26 = val_1;
            val_1 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  MultButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MultButton.<>c::业丑丝下三七丅世世(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            MultButton.<>c.<>9__21_0 = val_26;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_28 = 1152921530949963856;
        val_29 = System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  this._objects, predicate:  val_1).GetEnumerator();
        label_29:
        var val_26 = 0;
        val_26 = val_26 + 1;
        if(val_29.MoveNext() == false)
        {
            goto label_16;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        UIBasicSprite val_9 = val_29.Current.GetComponent<UIBasicSprite>();
        if(val_9 == 0)
        {
            goto label_29;
        }
        
        val_9.color = new UnityEngine.Color() {r = 丆丛丂丝丄世且丛丕.r, g = val_23, b = 丆丛丂丝丄世且丛丕.b, a = val_22};
        不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  val_9);
        goto label_29;
        label_16:
        val_32 = 0;
        val_33 = 0;
        if(val_29 == null)
        {
            
        }
        else
        {
                var val_28 = 0;
            val_28 = val_28 + 1;
            val_29.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_29 = ???;
        val_32 = ???;
        val_28 = ???;
        val_22 = ???;
        val_23 = ???;
    }
    private void 与专丟业下且丕不丈(string 万丑丞一丝丌丐丒丘)
    {
        string val_20;
        var val_21;
        System.Func<UnityEngine.GameObject, System.Boolean> val_23;
        var val_25;
        var val_26;
        var val_29;
        var val_30;
        val_20 = 万丑丞一丝丌丐丒丘;
        if((System.String.IsNullOrEmpty(value:  val_20)) != false)
        {
                val_20 = this._normalSpriteName;
        }
        
        val_21 = null;
        val_21 = null;
        val_23 = MultButton.<>c.<>9__22_0;
        if(val_23 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_2 = null;
            val_23 = val_2;
            val_2 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  MultButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MultButton.<>c::丗七专丙丑与丕丆下(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            MultButton.<>c.<>9__22_0 = val_23;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  this._objects, predicate:  val_2).GetEnumerator();
        val_25 = 1152921504691191808;
        val_26 = 1152921504848912384;
        label_30:
        var val_24 = 0;
        val_24 = val_24 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        UISprite val_10 = val_5.Current.GetComponent<UISprite>();
        if(val_10 == 0)
        {
            goto label_30;
        }
        
        val_10.spriteName = val_20;
        不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  val_10);
        goto label_30;
        label_17:
        val_29 = 0;
        val_30 = 0;
        if(val_5 == null)
        {
            
        }
        else
        {
                var val_26 = 0;
            val_26 = val_26 + 1;
            val_5.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_30 = ???;
        val_29 = ???;
        val_25 = ???;
        val_26 = ???;
    }
    public void AddTargetObject(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(this._objects != null)
        {
            goto label_1;
        }
        
        UnityEngine.GameObject[] val_1 = new UnityEngine.GameObject[0];
        this._objects = val_1;
        if(val_1 == null)
        {
            goto label_2;
        }
        
        label_1:
        int val_2 = val_1.Length + 1;
        UnityEngine.GameObject[] val_3 = new UnityEngine.GameObject[0];
        System.Array.Copy(sourceArray:  this._objects, destinationArray:  val_3, length:  this._objects.Length);
        var val_5 = -4294967296;
        val_5 = val_5 + ((val_3.Length) << 32);
        val_3[val_5 >> 32] = 丝三丁东丈丒世丅业;
        this._objects = val_3;
        return;
        label_2:
    }
    public MultButton()
    {
    
    }

}
