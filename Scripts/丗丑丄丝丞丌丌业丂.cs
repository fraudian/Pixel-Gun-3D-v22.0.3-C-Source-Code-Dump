using UnityEngine;
public class 丗丑丄丝丞丌丌业丂
{
    // Fields
    public byte 下丄丈不与世丐业专;
    public UnityEngine.Vector3 丒丁与不一上丛专丒;
    public UnityEngine.Vector3 丁业丛且一丂一丟丁;
    public UnityEngine.Vector3 丛七丟丗丝丏专专与;
    public UnityEngine.Vector3 丑与东丅丘丌业丟业;
    public 丗丑丄丝丞丌丌业丂.且丒丁丙丟丁世丅丙 专专丙丒丁丕丅业三;
    public 丗丑丄丝丞丌丌业丂 丘且三与丂世丂万丛;
    public System.Collections.Generic.List<丗丑丄丝丞丌丌业丂> 且丟丒三丗丛丟丙一;
    private float 丛业上丄丏丛丞丆丕;
    
    // Methods
    public 丗丑丄丝丞丌丌业丂()
    {
    
    }
    public 丗丑丄丝丞丌丌业丂(byte 丞丅上丏丂且下丅与, 丗丑丄丝丞丌丌业丂.且丒丁丙丟丁世丅丙 丆丑丅万丝丞丘业与, 丗丑丄丝丞丌丌业丂 丈东丘丏与丌东东下)
    {
        val_1 = new System.Object();
        this.下丄丈不与世丐业专 = 丞丅上丏丂且下丅与;
        this.专专丙丒丁丕丅业三 = 丆丑丅万丝丞丘业与;
        this.丘且三与丂世丂万丛 = val_1;
    }
    public void 丗上世丑丘业丆七一(丗丑丄丝丞丌丌业丂 不七丘丘丒万七丄丒)
    {
        System.Collections.Generic.List<丗丑丄丝丞丌丌业丂> val_2 = this.且丟丒三丗丛丟丙一;
        if(val_2 == null)
        {
                System.Collections.Generic.List<丗丑丄丝丞丌丌业丂> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<丗丑丄丝丞丌丌业丂>(capacity:  1);
            this.且丟丒三丗丛丟丙一 = val_2;
        }
        
        val_1.Add(item:  不七丘丘丒万七丄丒);
    }
    public void 丈业丑丂一丕丂丏丗()
    {
    
    }
    public void 丛丒丅丌不丟七丆且(System.Collections.Generic.List<byte> 三丈丕丝世丝专下东, bool 丐丆三丝七丏不丌丕, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        bool val_6 = 丐丆三丝七丏不丌丕;
        if(this.专专丙丒丁丕丅业三 == 2)
        {
            goto label_10;
        }
        
        List.Enumerator<T> val_1 = this.且丟丒三丗丛丟丙一.GetEnumerator();
        label_6:
        if((938239336 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        丐丆三丝七丏不丌丕 = val_6;
        goto label_6;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_10:
        if((this.丅丝丙丟丆上丌丌万(丐丆三丝七丏不丌丕:  false, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z})) == false)
        {
                return;
        }
        
        bool val_5 = this.丆丒上东丒丁丕丅丝(丐丆三丝七丏不丌丕:  val_6 = 丐丆三丝七丏不丌丕, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        val_6 = this.下丄丈不与世丐业专;
        if(三丈丕丝世丝专下东 == null)
        {
            goto label_12;
        }
        
        if(val_5 == false)
        {
            goto label_13;
        }
        
        label_18:
        三丈丕丝世丝专下东.Insert(index:  0, item:  val_6);
        val_6 = this.丘且三与丂世丂万丛;
        if(val_6 == null)
        {
                return;
        }
        
        do
        {
            三丈丕丝世丝专下东.Insert(index:  0, item:  this.丘且三与丂世丂万丛.下丄丈不与世丐业专);
            val_6 = this.丘且三与丂世丂万丛.丘且三与丂世丂万丛;
        }
        while(val_6 != null);
        
        return;
        label_12:
        if(val_5 == true)
        {
            goto label_18;
        }
        
        label_13:
        三丈丕丝世丝专下东.Add(item:  val_6);
    }
    public bool 丆丒上东丒丁丕丅丝(bool 丐丆三丝七丏不丌丕, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        if(丅专与丒丈丗丒丘丌.x < 0)
        {
                return false;
        }
        
        if(丅专与丒丈丗丒丘丌.x > this.丑与东丅丘丌业丟业)
        {
                return false;
        }
        
        if(丐丆三丝七丏不丌丕 != false)
        {
                if(丅专与丒丈丗丒丘丌.y < 丅专与丒丈丗丒丘丌.x)
        {
                return false;
        }
        
            if(丅专与丒丈丗丒丘丌.y > 丅专与丒丈丗丒丘丌.x)
        {
                return false;
        }
        
            return true;
        }
        
        if(丅专与丒丈丗丒丘丌.z < 丅专与丒丈丗丒丘丌.x)
        {
                return false;
        }
        
        if(丅专与丒丈丗丒丘丌.z <= 丅专与丒丈丗丒丘丌.x)
        {
                return true;
        }
        
        return false;
    }
    public bool 丅丝丙丟丆上丌丌万(bool 丐丆三丝七丏不丌丕, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        if(this.丛业上丄丏丛丞丆丕 == 0f)
        {
                UnityEngine.Vector3 val_3 = this.丁业丛且一丂一丟丁;
            val_3 = val_3 + 丅专与丒丈丗丒丘丌.y;
            val_3 = val_3 + 丅专与丒丈丗丒丘丌.z;
            val_3 = val_3 * 0.5f;
            this.丛业上丄丏丛丞丆丕 = val_3;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.y, z = 丅专与丒丈丗丒丘丌.z}, b:  new UnityEngine.Vector3() {x = this.丒丁与不一上丛专丒, y = V11.16B, z = V12.16B});
        float val_4 = this.丛业上丄丏丛丞丆丕;
        val_4 = val_4 * val_4;
        return (bool)(val_1.x <= val_4) ? 1 : 0;
    }

}
