using UnityEngine;
public class AdjustBalls : MonoBehaviour
{
    // Methods
    public void DoSomethingWithTheData(LitJson.丑丘丆不丄丐丟丄七[] 丗一且丙丛丈丛下上)
    {
        var val_12;
        float val_13;
        float val_14;
        var val_15;
        var val_17;
        var val_19;
        string val_20;
        val_12 = 0;
        val_13 = 0f;
        val_14 = 0f;
        goto label_1;
        label_41:
        if(val_12 >= true)
        {
                val_15 = 0;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_15 = 4;
        val_17 = public System.Boolean System.Collections.Generic.ICollection<T>::Contains(T item);
        if((丗一且丙丛丈丛下上[0].上上丞丛业丑丟丛丘().Contains(item:  null)) != false)
        {
                val_17 = 0;
        }
        
        if(val_12 >= 丗一且丙丛丈丛下上.Length)
        {
                val_17 = 0;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_17 = 4;
        val_19 = public System.Boolean System.Collections.Generic.ICollection<T>::Contains(T item);
        if((丗一且丙丛丈丛下上[0x0] + 32.上上丞丛业丑丟丛丘().Contains(item:  null)) != false)
        {
                val_19 = 0;
            LitJson.丑丘丆不丄丐丟丄七 val_8 = 丗一且丙丛丈丛下上[0x0] + 32.丂丑丞丝且万丐万丟(一丒万丁七一东三丆:  "color");
            UnityEngine.Color val_9 = val_8.丝一丙丝上丛三丄丈(丑丞丈丗丄丙丟万丄:  val_8);
            val_14 = val_9.b;
        }
        
        if(val_12 >= 丗一且丙丛丈丛下上.Length)
        {
                val_19 = 0;
        }
        
        val_20 = 丗一且丙丛丈丛下上[0x0] + 32.上上丞丛业丑丟丛丘();
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_19 = 4;
        if((val_20.Contains(item:  null)) != false)
        {
                val_20 = 丗一且丙丛丈丛下上[0x0] + 32.丂丑丞丝且万丐万丟(一丒万丁七一东三丆:  "drag");
            val_13 = System.Single.Parse(s:  val_20);
        }
        
        val_20.一三丆世丘丘丄上业(万三丂且丆三且丝且:  new 丕丂丌不一且一丁不() {丒丘丏上丙丟丑丕丈 = 丗一且丙丛丈丛下上[0x0] + 32.丂丑丞丝且万丐万丟(一丒万丁七一东三丆:  "name"), 丑丞丈丗丄丙丟万丄 = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_14, a = val_9.a}, 世与丕丙不丟东东下 = val_13});
        val_12 = 1;
        label_1:
        if(val_12 < 丗一且丙丛丈丛下上.Length)
        {
            goto label_41;
        }
    
    }
    private void 一三丆世丘丘丄上业(丕丂丌不一且一丁不 万三丂且丆三且丝且)
    {
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  万三丂且丆三且丝且.丒丘丏上丙丟丑丕丈);
        val_1.GetComponent<UnityEngine.Renderer>().sharedMaterial.color = new UnityEngine.Color() {r = 万三丂且丆三且丝且.丑丞丈丗丄丙丟万丄.r, g = 万三丂且丆三且丝且.丑丞丈丗丄丙丟万丄.g, b = 万三丂且丆三且丝且.丑丞丈丗丄丙丟万丄.b, a = 万三丂且丆三且丝且.丑丞丈丗丄丙丟万丄.a};
        val_1.GetComponent<UnityEngine.Rigidbody>().drag = 万三丂且丆三且丝且.世与丕丙不丟东东下;
    }
    private UnityEngine.Color 丝一丙丝上丛三丄丈(string 丑丞丈丗丄丙丟万丄)
    {
        uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  丑丞丈丗丄丙丟万丄);
        if(val_1 > 1452231588)
        {
            goto label_1;
        }
        
        if(val_1 > 96429129)
        {
            goto label_2;
        }
        
        if(val_1 == 18738364)
        {
            goto label_3;
        }
        
        if(val_1 != 96429129)
        {
                return UnityEngine.Color.grey;
        }
        
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "yellow")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.yellow;
        label_1:
        if(val_1 > (-2097416755))
        {
            goto label_6;
        }
        
        if(val_1 == (-2097416755))
        {
            goto label_7;
        }
        
        if(val_1 == 1550717474)
        {
            goto label_8;
        }
        
        if(val_1 != 1676028392)
        {
                return UnityEngine.Color.grey;
        }
        
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "magenta")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.magenta;
        label_2:
        if(val_1 == 1089765596)
        {
            goto label_11;
        }
        
        if(val_1 == 1231115066)
        {
            goto label_12;
        }
        
        if(val_1 != 1452231588)
        {
                return UnityEngine.Color.grey;
        }
        
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "black")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.black;
        label_6:
        if(val_1 == (-1299179098))
        {
            goto label_15;
        }
        
        if(val_1 == (-1164266598))
        {
            goto label_16;
        }
        
        if(val_1 != (-570292378))
        {
                return UnityEngine.Color.grey;
        }
        
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "white")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.white;
        label_3:
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "green")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.green;
        label_7:
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "blue")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.blue;
        label_8:
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "clear")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.clear;
        label_11:
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "red")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.red;
        label_12:
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "cyan")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.cyan;
        label_15:
        bool val_11 = System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "grey");
        return UnityEngine.Color.grey;
        label_16:
        if((System.String.op_Equality(a:  丑丞丈丗丄丙丟万丄, b:  "gray")) == false)
        {
                return UnityEngine.Color.grey;
        }
        
        return UnityEngine.Color.gray;
    }
    public void ResetBalls()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        do
        {
            string val_3 = "Ball" + 1.ToString();
            val_3.一三丆世丘丘丄上业(万三丂且丆三且丝且:  new 丕丂丌不一且一丁不() {丒丘丏上丙丟丑丕丈 = val_3, 丑丞丈丗丄丙丟万丄 = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, 世与丕丙不丟东东下 = 0f});
        }
        while(2 < 4);
    
    }
    public AdjustBalls()
    {
    
    }

}
