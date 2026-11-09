using UnityEngine;
public class NJGAtlas : MonoBehaviour
{
    // Fields
    public UnityEngine.Shader shader;
    public int size;
    public int padding;
    public NJGAtlas.Sprite[] sprites;
    public UnityEngine.Texture2D texture;
    public UnityEngine.Material spriteMaterial;
    private System.Collections.Generic.List<string> 专丏丑三丁与丟丒丛;
    
    // Methods
    public NJGAtlas.Sprite GetSprite(int 丞丅上丏丂且下丅与)
    {
        return (Sprite)this.sprites[(long)丞丅上丏丂且下丅与];
    }
    public NJGAtlas.Sprite GetSprite(string 万丑丞一丝丌丐丒丘)
    {
        if(this.sprites.Length < 1)
        {
                return 0;
        }
        
        label_13:
        var val_1 = 4 - 4;
        if(this.sprites[0] == null)
        {
            goto label_8;
        }
        
        Sprite val_6 = this.sprites[0];
        if((System.String.IsNullOrEmpty(value:  this.sprites[0].name)) == true)
        {
            goto label_8;
        }
        
        Sprite val_7 = this.sprites[0];
        if((System.String.op_Equality(a:  this.sprites[0].name, b:  万丑丞一丝丌丐丒丘)) == true)
        {
            goto label_12;
        }
        
        label_8:
        this.sprites = 4 + 1;
        if((4 - 3) < (long)this.sprites.Length)
        {
            goto label_13;
        }
        
        return 0;
        label_12:
        Sprite val_8 = this.sprites[0];
        return 0;
    }
    public System.Collections.Generic.List<string> GetListOfSprites()
    {
        System.Collections.Generic.List<System.String> val_2;
        this.专丏丑三丁与丟丒丛.Clear();
        val_2 = this.专丏丑三丁与丟丒丛;
        if(this.sprites.Length < 1)
        {
                return val_2;
        }
        
        var val_3 = 0;
        do
        {
            Sprite val_2 = this.sprites[val_3];
            val_2.Add(item:  this.sprites[0x0][0].name);
            val_2 = this.专丏丑三丁与丟丒丛;
            val_3 = val_3 + 1;
        }
        while((this.sprites.Length & 4294967295) != val_3);
        
        return val_2;
    }
    public System.Collections.Generic.List<string> GetListOfSprites(string 与丛丙一丙丆丁七业)
    {
        string val_12;
        string val_13;
        string val_14;
        var val_15;
        var val_16;
        int val_17;
        val_12 = 与丛丙一丙丆丁七业;
        val_13 = this;
        if((System.String.IsNullOrEmpty(value:  val_12)) != false)
        {
                return this.GetListOfSprites();
        }
        
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        if(this.sprites.Length >= 1)
        {
                var val_13 = 0;
            val_14 = (long)this.sprites.Length;
            do
        {
            if(this.sprites[val_13] != null)
        {
                if((System.String.IsNullOrEmpty(value:  this.sprites[0x0][0].name)) != true)
        {
                if((System.String.Equals(a:  val_12, b:  this.sprites[0x0][0].name, comparisonType:  5)) == true)
        {
            goto label_8;
        }
        
        }
        
        }
        
            val_13 = val_13 + 1;
        }
        while(val_13 < val_14);
        
        }
        
        char[] val_5 = new char[1];
        val_5[0] = 32;
        val_12 = val_12.Split(separator:  val_5, options:  1);
        val_14 = 0;
        goto label_13;
        label_20:
        val_14 = 1;
        mem2[0] = val_12[0].ToLower();
        label_13:
        if(val_14 < val_6.Length)
        {
            goto label_20;
        }
        
        if(this.sprites.Length < 1)
        {
                return val_2;
        }
        
        var val_16 = 0;
        label_37:
        if((this.sprites[val_16] == null) || ((System.String.IsNullOrEmpty(value:  this.sprites[0x0][0].name)) == true))
        {
            goto label_35;
        }
        
        val_15 = 0;
        val_16 = 0;
        goto label_28;
        label_34:
        val_14 = val_12[0];
        val_12[0] = this.sprites[0x0][0].name.ToLower().Contains(value:  val_14);
        val_16 = val_16 + val_12[0];
        val_15 = 1;
        label_28:
        if(val_12 == null)
        {
            goto label_31;
        }
        
        val_17 = val_6.Length;
        if(val_15 < val_17)
        {
            goto label_34;
        }
        
        goto label_33;
        label_31:
        val_14 = val_6.Length;
        val_17 = val_6.Length;
        if(val_15 < val_14)
        {
            goto label_34;
        }
        
        label_33:
        if(val_16 == val_17)
        {
                val_2.Add(item:  this.sprites[0x0][0].name);
        }
        
        label_35:
        val_16 = val_16 + 1;
        if(val_16 != (this.sprites.Length & 4294967295))
        {
            goto label_37;
        }
        
        return val_2;
        label_8:
        val_13 = this.sprites[0x0][0].name;
        val_2.Add(item:  val_13);
        return val_2;
    }
    public void CreateSprite(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Rect 世丈丆丆丙一一三与, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        var val_3;
        UnityEngine.Object val_37;
        var val_38;
        UnityEngine.Object val_39;
        UnityEngine.Object val_40;
        var val_41;
        int val_42;
        val_37 = 丝三丁东丈丒世丅业.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if((val_37 != null) && (null != null))
        {
                val_37 = 0;
        }
        
        if(val_37 != 0)
        {
            goto label_13;
        }
        
        val_37 = 丝三丁东丈丒世丅业.AddComponent(componentType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if(val_37 == null)
        {
            goto label_15;
        }
        
        if(null == null)
        {
            goto label_13;
        }
        
        val_37 = 0;
        goto label_15;
        label_13:
        if(val_37 == 0)
        {
            goto label_15;
        }
        
        val_38 = 0;
        goto label_16;
        label_15:
        val_38 = 1;
        label_16:
        val_39 = val_37.sharedMesh;
        if(val_39 == 0)
        {
                UnityEngine.Mesh val_9 = null;
            val_39 = val_9;
            val_9 = new UnityEngine.Mesh();
        }
        
        val_9.Clear();
        val_40 = 丝三丁东丈丒世丅业.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if(val_40 != null)
        {
                val_40 = 0;
        }
        
        if(val_40 != 0)
        {
            goto label_29;
        }
        
        val_41 = 丝三丁东丈丒世丅业.AddComponent(componentType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if(val_41 == null)
        {
            goto label_36;
        }
        
        goto label_36;
        label_29:
        if(val_40 != 0)
        {
            goto label_37;
        }
        
        label_36:
        val_41 = 0;
        label_37:
        val_41.GetComponent<UnityEngine.Renderer>().sharedMaterial = this.spriteMaterial;
        float val_37 = 0.5f;
        float val_19 = (float)this.texture.width * val_37;
        UnityEngine.Vector3[] val_21 = new UnityEngine.Vector3[4];
        float val_22 = (float)this.texture.height * (-0.5f);
        val_3 = 0;
        val_37 = (float)this.texture.height * val_37;
        val_21[0] = 0;
        val_21[0] = 0;
        val_21[1] = 0;
        val_21[1] = 0;
        val_21[2] = 0;
        val_21[2] = 0;
        val_21[3] = 0;
        val_21[3] = 0;
        val_21[4] = 0;
        val_21[4] = 0;
        val_21[5] = 0;
        val_21[5] = 0;
        UnityEngine.Vector2[] val_24 = new UnityEngine.Vector2[4];
        float val_25 = 世丈丆丆丙一一三与.m_XMin.System.IConvertible.ToSingle(provider:  0);
        UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_25, y:  val_25);
        val_24[0] = val_26.x;
        val_24[0] = val_26.y;
        float val_27 = 世丈丆丆丙一一三与.m_XMin.System.IConvertible.ToSingle(provider:  0);
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_27, y:  val_27 + val_27);
        val_24[1] = val_29.x;
        val_24[1] = val_29.y;
        float val_30 = 世丈丆丆丙一一三与.m_XMin.System.IConvertible.ToSingle(provider:  0);
        UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  val_30 + val_30, y:  val_30 + val_30);
        val_24[2] = val_33.x;
        val_24[2] = val_33.y;
        float val_34 = 世丈丆丆丙一一三与.m_XMin.System.IConvertible.ToSingle(provider:  0);
        val_34 = val_34 + val_34;
        UnityEngine.Vector2 val_35 = new UnityEngine.Vector2(x:  val_34, y:  val_34);
        val_24[3] = val_35.x;
        val_24[3] = val_35.y;
        UnityEngine.Color[] val_36 = new UnityEngine.Color[4];
        val_42 = val_36.Length;
        if(val_42 == 0)
        {
                val_42 = val_36.Length;
        }
        
        val_36[0] = 丑丞丈丗丄丙丟万丄;
        val_36[0] = 丑丞丈丗丄丙丟万丄.g;
        val_36[0] = 丑丞丈丗丄丙丟万丄.b;
        val_36[0] = 丑丞丈丗丄丙丟万丄.a;
        if(val_42 <= 1)
        {
                val_42 = val_36.Length;
        }
        
        val_36[1] = 丑丞丈丗丄丙丟万丄;
        val_36[1] = 丑丞丈丗丄丙丟万丄.g;
        val_36[1] = 丑丞丈丗丄丙丟万丄.b;
        val_36[1] = 丑丞丈丗丄丙丟万丄.a;
        if(val_42 <= 2)
        {
                val_42 = val_36.Length;
        }
        
        val_36[2] = 丑丞丈丗丄丙丟万丄;
        val_36[2] = 丑丞丈丗丄丙丟万丄.g;
        val_36[2] = 丑丞丈丗丄丙丟万丄.b;
        val_36[2] = 丑丞丈丗丄丙丟万丄.a;
        val_36[3] = 丑丞丈丗丄丙丟万丄;
        val_36[3] = 丑丞丈丗丄丙丟万丄.g;
        val_36[3] = 丑丞丈丗丄丙丟万丄.b;
        val_36[3] = 丑丞丈丗丄丙丟万丄.a;
        if(val_39 != null)
        {
                val_9.vertices = val_21;
            val_9.colors = val_36;
            val_9.uv = val_24;
        }
        else
        {
                0.vertices = val_21;
            0.colors = val_36;
            0.uv = val_24;
        }
        
        val_9.triangles = new int[6] {0, 1, 2, 0, 2, 3};
        val_37.sharedMesh = val_9;
    }
    public void ChangeSprite(UnityEngine.Mesh 丑与丗丛丝丈丙丆丌, UnityEngine.Rect 世丈丆丆丙一一三与)
    {
        UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[4];
        float val_2 = 世丈丆丆丙一一三与.m_XMin.System.IConvertible.ToSingle(provider:  0);
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2, y:  val_2);
        val_1[0] = val_3.x;
        val_1[0] = val_3.y;
        float val_4 = 世丈丆丆丙一一三与.m_XMin.System.IConvertible.ToSingle(provider:  0);
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4, y:  val_4 + val_4);
        val_1[1] = val_6.x;
        val_1[1] = val_6.y;
        float val_7 = 世丈丆丆丙一一三与.m_XMin.System.IConvertible.ToSingle(provider:  0);
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_7 + val_7, y:  val_7 + val_7);
        val_1[2] = val_10.x;
        val_1[2] = val_10.y;
        float val_11 = 世丈丆丆丙一一三与.m_XMin.System.IConvertible.ToSingle(provider:  0);
        val_11 = val_11 + val_11;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11, y:  val_11);
        val_1[3] = val_12.x;
        val_1[3] = val_12.y;
        丑与丗丛丝丈丙丆丌.uv = val_1;
    }
    public void ChangeColor(UnityEngine.Mesh 丑与丗丛丝丈丙丆丌, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        int val_2;
        UnityEngine.Color[] val_1 = new UnityEngine.Color[4];
        val_2 = val_1.Length;
        if(val_2 == 0)
        {
                val_2 = val_1.Length;
        }
        
        val_1[0] = 丑丞丈丗丄丙丟万丄;
        val_1[0] = 丑丞丈丗丄丙丟万丄.g;
        val_1[0] = 丑丞丈丗丄丙丟万丄.b;
        val_1[0] = 丑丞丈丗丄丙丟万丄.a;
        if(val_2 <= 1)
        {
                val_2 = val_1.Length;
        }
        
        val_1[1] = 丑丞丈丗丄丙丟万丄;
        val_1[1] = 丑丞丈丗丄丙丟万丄.g;
        val_1[1] = 丑丞丈丗丄丙丟万丄.b;
        val_1[1] = 丑丞丈丗丄丙丟万丄.a;
        if(val_2 <= 2)
        {
                val_2 = val_1.Length;
        }
        
        val_1[2] = 丑丞丈丗丄丙丟万丄;
        val_1[2] = 丑丞丈丗丄丙丟万丄.g;
        val_1[2] = 丑丞丈丗丄丙丟万丄.b;
        val_1[2] = 丑丞丈丗丄丙丟万丄.a;
        val_1[3] = 丑丞丈丗丄丙丟万丄;
        val_1[3] = 丑丞丈丗丄丙丟万丄.g;
        val_1[3] = 丑丞丈丗丄丙丟万丄.b;
        val_1[3] = 丑丞丈丗丄丙丟万丄.a;
        丑与丗丛丝丈丙丆丌.colors = val_1;
    }
    public NJGAtlas()
    {
        this.size = 2049;
        this.padding = 1;
        this.专丏丑三丁与丟丒丛 = new System.Collections.Generic.List<System.String>();
    }

}
