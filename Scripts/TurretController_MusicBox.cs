using UnityEngine;
internal sealed class TurretController_MusicBox : TurretController, 东丁丆一业丈万丆丐
{
    // Fields
    public UnityEngine.AudioClip musicDater;
    public UnityEngine.Transform tower;
    public UnityEngine.Transform gun;
    private bool 丄丗丄一万东丅上业;
    
    // Methods
    protected override void 丈丞一丈丑丝丈丂丂()
    {
        var val_2;
        var val_3;
        val_2 = this;
        this.丈丞一丈丑丝丈丂丂();
        if(this.丄丗丄一万东丅上业 == false)
        {
                return;
        }
        
        this.丛丗丐丝丁丄丙丞丘(丛不丗丟一一七下专:  false);
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        object[] val_1 = new object[1];
        val_1[0] = null;
        this.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  41, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    protected override System.Collections.IEnumerator 丗丅世且丛丑业世丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretController_MusicBox.东七丌上丂丁丐丄丙();
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        var val_2;
        var val_3;
        val_2 = this;
        this.丟丞丆上上丁丅下丐();
        if(this.丄丗丄一万东丅上业 == true)
        {
                return;
        }
        
        this.丛丗丐丝丁丄丙丞丘(丛不丗丟一一七下专:  true);
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        object[] val_1 = new object[1];
        val_1[0] = true;
        this.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  41, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    protected override void 下专专专丄世丗且丐()
    {
        this.下专专专丄世丗且丐();
        if(this.丄丗丄一万东丅上业 == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime * 180f;
        this.tower.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this = this.gun;
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_3 * 180f;
        this.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    protected override void 东丅下世丏专丝东丝()
    {
        float val_32;
        var val_33;
        float val_37;
        float val_38;
        UnityEngine.Object val_40;
        InGameGUI val_41;
        var val_42;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
        val_32 = val_1.y;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  1f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆())) == false)
        {
            goto label_6;
        }
        
        val_32 = 0.05f;
        if(0.targetValue <= val_32)
        {
            goto label_6;
        }
        
        float val_6 = 0.targetValue;
        val_32 = 0.7f;
        var val_7 = (val_6 < 0) ? 1 : 0;
        if(val_6 >= 0)
        {
            goto label_6;
        }
        
        丅丙上七上一丐不下 val_8 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
        if(val_8 == null)
        {
            goto label_49;
        }
        
        var val_34 = 0;
        val_34 = val_34 + 1;
        goto label_11;
        label_6:
        val_33 = 0;
        label_49:
        label_50:
        if(0 != 0)
        {
                UnityEngine.Vector3 val_9 = position;
            val_37 = val_9.x;
            val_38 = val_9.z;
            val_40 = 0;
            bool val_13 = UnityEngine.Physics.CheckSphere(position:  new UnityEngine.Vector3() {x = val_37, y = val_9.y, z = val_38}, radius:  GetComponent<UnityEngine.SphereCollider>().radius, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆());
        }
        else
        {
                UnityEngine.Transform val_14 = myTransform;
            UnityEngine.Vector3 val_15 = val_14.position;
            val_37 = val_15.x;
            val_38 = val_15.z;
            UnityEngine.Vector3 val_16 = val_14.position;
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_37, y = val_15.y, z = val_38}, end:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆())) != false)
        {
                val_40 = 0.transform.root;
            bool val_22 = UnityEngine.Object.op_Inequality(x:  val_40, y:  this.transform);
        }
        else
        {
                val_40 = 0;
        }
        
        }
        
        var val_23 = (val_33 == 0) ? 1 : 0;
        val_23 = val_23 | val_40;
        val_23 = 0 | val_23;
        if((val_23 & 1) != 0)
        {
                this.SetColor(name:  "_TintColor", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            val_41 = InGameGUI.丙丞专丌丁丞与不丐;
            val_42 = 0;
            if(val_41 == 0)
        {
                return;
        }
        
            val_41 = GetComponent<UIButton>();
            if(val_41 != null)
        {
                return;
        }
        
            return;
        }
        
        this.SetColor(name:  "_TintColor", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_41 = InGameGUI.丙丞专丌丁丞与不丐;
        val_42 = 0;
        if(val_41 == 0)
        {
                return;
        }
        
        val_41 = GetComponent<UIButton>();
        return;
        label_11:
        if((val_8.transform.CompareTag(tag:  "Player")) == true)
        {
            goto label_50;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        if((val_8.transform.CompareTag(tag:  "Enemy")) == false)
        {
            goto label_49;
        }
        
        goto label_50;
    }
    public override bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_6;
        var val_7;
        int val_8;
        val_6 = 丗与一丛丐丞丘丌丞;
        byte val_1 = val_6 & 255;
        if(val_1 > 41)
        {
            goto label_1;
        }
        
        if(val_1 > 32)
        {
            goto label_2;
        }
        
        byte val_2 = val_6 & 255;
        if(val_2 == 24)
        {
            goto label_3;
        }
        
        if(val_2 != 32)
        {
            goto label_20;
        }
        
        if(专丒丌丆下丐丞丟丞.Length == 0)
        {
            goto label_6;
        }
        
        object val_6 = 专丒丌丆下丐丞丟丞[0];
        this.丑丕一一丄丘万丗丆(一丆丌丝专丂丛丙上:  false);
        goto label_38;
        label_1:
        if(val_1 > 104)
        {
            goto label_9;
        }
        
        byte val_3 = val_6 & 255;
        if(val_3 == 92)
        {
            goto label_10;
        }
        
        if(val_3 != 104)
        {
            goto label_20;
        }
        
        this.丏且上丌丘丈世丂世();
        goto label_38;
        label_2:
        byte val_4 = val_6 & 255;
        if(val_4 == 37)
        {
            goto label_13;
        }
        
        if(val_4 != 41)
        {
            goto label_20;
        }
        
        object val_7 = 专丒丌丆下丐丞丟丞[0];
        this.丛丗丐丝丁丄丙丞丘(丛不丗丟一一七下专:  false);
        goto label_38;
        label_9:
        byte val_5 = val_6 & 255;
        if(val_5 == 166)
        {
            goto label_18;
        }
        
        if(val_5 == 119)
        {
            goto label_19;
        }
        
        if(val_5 != 110)
        {
            goto label_20;
        }
        
        object val_8 = 专丒丌丆下丐丞丟丞[0];
        this.且不专丙业下丝一下(丒七上丘不丝丁丘与:  21884928);
        goto label_38;
        label_20:
        val_7 = 0;
        return (bool)val_7;
        label_3:
        val_8 = 专丒丌丆下丐丞丟丞.Length;
        if(val_8 == 0)
        {
                val_8 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞[0];
        object val_9 = 专丒丌丆下丐丞丟丞[1];
        this.丟丄丌万丙丘丑丆丘(丛业专丘丂丅丗丝丛:  3.782474E-38f, 丞丗且下世丐业丌丙:  21884928);
        goto label_38;
        label_10:
        this.世且丂丕丐丝丐丐且();
        goto label_38;
        label_13:
        object val_10 = 专丒丌丆下丐丞丟丞[0];
        this.万东专下丆丝丒丙世(丞丗且下世丐业丌丙:  21884928);
        goto label_38;
        label_18:
        object val_11 = 专丒丌丆下丐丞丟丞[0];
        this.且业丆七丌丙且万丌(丒七上丘不丝丁丘与:  21884928);
        goto label_38;
        label_19:
        object val_12 = 专丒丌丆下丐丞丟丞[0];
        this.丙东丟丌丂丝丝七万(丝三不七丑丏一业丑:  3.782474E-38f);
        goto label_38;
        label_6:
        this.丐丕与丟七与三丂业();
        label_38:
        val_7 = 1;
        return (bool)val_7;
    }
    private void 丛丗丐丝丁丄丙丞丘(bool 丛不丗丟一一七下专)
    {
        var val_1 = (this.丄丗丄一万东丅上业 == true) ? 1 : 0;
        val_1 = val_1 ^ 丛不丗丟一一七下专;
        if(val_1 == false)
        {
                return;
        }
        
        this.丄丗丄一万东丅上业 = 丛不丗丟一一七下专;
        if(丛不丗丟一一七下专 == false)
        {
            goto label_2;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_4 = this.GetComponent<UnityEngine.AudioSource>();
        if(val_4 == null)
        {
            goto label_6;
        }
        
        val_4.loop = true;
        val_4.clip = this.musicDater;
        goto label_7;
        label_2:
        this.GetComponent<UnityEngine.AudioSource>().Stop();
        return;
        label_6:
        val_4.loop = true;
        this = this.musicDater;
        val_4.clip = this;
        label_7:
        val_4.Play();
    }
    protected override void 丐三丌丒丄丁丑不丌(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        this.丐三丌丒丄丁丑不丌(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.丄丗丄一万东丅上业 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.丄丗丄一万东丅上业 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.丄丗丄一万东丅上业;
        七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  41, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public TurretController_MusicBox()
    {
    
    }

}
