using UnityEngine;
internal sealed class InterolationGameObject : VTableHolder
{
    // Fields
    public int historyLengh;
    public bool isSynchPosition;
    public bool isSynchRotation;
    public bool isLocalTrasformSynch;
    public bool syncOneAxis;
    public bool sglajEnabled;
    private UnityEngine.Quaternion 丘丐丐不丐丁丛且丝;
    private UnityEngine.Vector3 丞上业丐丞丝不丐专;
    private double 丌丟丗下专丙丕不丘;
    private double 下丟丒丁下丄丕丂专;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    private InterolationGameObject.丝丙丒丌东下丕丘丘[] 东专业丑与丐丆丐丟;
    private bool 丌丂丗且丙专业丁业;
    private bool 丌且下丕下下丌万丞;
    
    // Methods
    internal InterolationGameObject()
    {
        this.historyLengh = 5;
        this.丌丂丗且丙专业丁业 = true;
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void InterolationGameObject::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    private void Awake()
    {
        var val_3;
        丝丙丒丌东下丕丘丘[] val_4;
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
        {
                this.enabled = false;
        }
        
        this.万东万丆专丌丕丐丗 = this.transform;
        val_4 = new 丝丙丒丌东下丕丘丘[0];
        this.东专业丑与丐丆丐丟 = val_4;
        if(this.historyLengh < 1)
        {
            goto label_4;
        }
        
        var val_4 = 0;
        goto label_5;
        label_8:
        val_4 = this.东专业丑与丐丆丐丟;
        label_5:
        var val_3 = val_4 + (0 * 40);
        mem2[0] = 0;
        val_4 = val_4 + 1;
        if(val_4 < this.historyLengh)
        {
            goto label_8;
        }
        
        label_4:
        this.下丟丒丁下丄丕丂专 = 1;
    }
    private void Start()
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        this.丌且下丕下下丌万丞 = true;
    }
    private void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        object val_16;
        System.Object[] val_17;
        float val_19;
        float val_20;
        var val_21;
        val_17 = 东业丄丅丅且世七丄;
        if(val_17.丕专丏万下不丞丐丛() == false)
        {
            goto label_2;
        }
        
        if(this.isSynchPosition == false)
        {
            goto label_3;
        }
        
        if(this.万东万丆专丌丕丐丗 == null)
        {
            goto label_4;
        }
        
        if(this.isLocalTrasformSynch == false)
        {
            goto label_5;
        }
        
        label_15:
        UnityEngine.Vector3 val_2 = this.万东万丆专丌丕丐丗.localPosition;
        goto label_6;
        label_2:
        if(this.isSynchPosition != false)
        {
                object val_3 = val_17.与万三丘与专丛丄七();
            this.丞上业丐丞丝不丐专 = new UnityEngine.Vector3();
            mem[1152921526288319788] = ???;
        }
        
        if(this.isSynchRotation == false)
        {
            goto label_9;
        }
        
        val_16 = val_17.与万三丘与专丛丄七();
        if(this.syncOneAxis == false)
        {
            goto label_11;
        }
        
        val_19 = 0f;
        val_20 = 0f;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  3.782474E-38f, y:  val_19, z:  val_20);
        goto label_14;
        label_4:
        if(this.isLocalTrasformSynch == true)
        {
            goto label_15;
        }
        
        label_5:
        UnityEngine.Vector3 val_6 = this.万东万丆专丌丕丐丗.position;
        label_6:
        val_17.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_6);
        label_3:
        if(this.isSynchRotation == false)
        {
            goto label_17;
        }
        
        if(this.syncOneAxis == false)
        {
            goto label_18;
        }
        
        UnityEngine.Quaternion val_7 = this.万东万丆专丌丕丐丗.localRotation;
        val_21 = 1152921504624205824;
        goto label_20;
        label_11:
        label_14:
        this.丘丐丐不丐丁丛且丝 = new UnityEngine.Quaternion();
        mem[1152921526288319768] = ???;
        mem[1152921526288319772] = ???;
        mem[1152921526288319776] = ???;
        label_9:
        object val_8 = val_17.与万三丘与专丛丄七();
        this.丌丟丗下专丙丕不丘 = null;
        this.专丘丐丐世专丆丗上(丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = this.丞上业丐丞丝不丐专}, 丝丏丏东丘丐丝下不:  new UnityEngine.Quaternion() {x = this.丘丐丐不丐丁丛且丝}, 丄丆万一丙丂丕不丐:  1.28822976017949E-231);
        return;
        label_18:
        if(this.isLocalTrasformSynch != false)
        {
                UnityEngine.Quaternion val_9 = this.万东万丆专丌丕丐丗.localRotation;
        }
        else
        {
                UnityEngine.Quaternion val_10 = this.万东万丆专丌丕丐丗.rotation;
        }
        
        val_21 = 1152921504838369280;
        label_20:
        val_17.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_10);
        label_17:
        double val_11 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_16 = val_11;
        val_17.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_11);
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        val_17 = val_17.东与上丗与丏下丂丘();
        丅丑丞上丛丆东丟丂.三丅丐业丙丕丙业丕(丑与丆丝丕东丛丄丝:  "Stream " + this.GetType(), 丗丟上上丒丐丗丞丙:  val_17);
    }
    private void Update()
    {
        float val_25;
        double val_26;
        float val_27;
        float val_28;
        if(this.丌且下丕下下丌万丞 != false)
        {
                return;
        }
        
        if(this.sglajEnabled == false)
        {
            goto label_2;
        }
        
        if(this.丌丂丗且丙专业丁业 == true)
        {
                return;
        }
        
        float val_31 = UnityEngine.Time.deltaTime;
        var val_30 = -4294967296;
        val_30 = val_30 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_3 = this.东专业丑与丐丆丐丟 + ((val_30 >> 32) * 40);
        val_31 = this.下丟丒丁下丄丕丂专 + (double)val_31;
        float val_4 = UnityEngine.Time.deltaTime;
        float val_32 = 1.5f;
        val_32 = val_4 * val_32;
        val_4 = (val_31 < 0) ? (val_32) : (val_4);
        val_25 = this.下丟丒丁下丄丕丂专 + (double)val_4;
        label_10:
        if(0 >= this.东专业丑与丐丆丐丟.Length)
        {
            goto label_7;
        }
        
        var val_5 = this.东专业丑与丐丆丐丟 + (0 * 40);
        var val_6 = 0 + 1;
        if(((0 * 40) + this.东专业丑与丐丆丐丟 + 64) > this.下丟丒丁下丄丕丂专)
        {
            goto label_10;
        }
        
        label_7:
        if(0 == 0)
        {
                this.丌丂丗且丙专业丁业 = true;
        }
        
        var val_7 = this.东专业丑与丐丆丐丟 + (0 * 40);
        float val_33 = (0 * 40) + this.东专业丑与丐丆丐丟 + 64;
        val_26 = this.下丟丒丁下丄丕丂专;
        val_27 = val_25 - this.下丟丒丁下丄丕丂专;
        val_33 = val_33 - val_26;
        val_28 = val_27 / val_33;
        if(this.isLocalTrasformSynch == false)
        {
            goto label_14;
        }
        
        if(this.isSynchPosition != false)
        {
                UnityEngine.Vector3 val_8 = this.万东万丆专丌丕丐丗.localPosition;
            var val_9 = this.东专业丑与丐丆丐丟 + (0 * 40);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = (0 * 40) + this.东专业丑与丐丆丐丟 + 32, y = (0 * 40) + this.东专业丑与丐丆丐丟 + 32 + 4, z = (0 * 40) + this.东专业丑与丐丆丐丟 + 40}, t:  (float)val_28);
            val_28 = val_10.x;
            val_26 = val_10.y;
            val_27 = val_10.z;
            this.万东万丆专丌丕丐丗.localPosition = new UnityEngine.Vector3() {x = val_28, y = val_26, z = val_27};
        }
        
        if(this.isSynchRotation == false)
        {
            goto label_48;
        }
        
        UnityEngine.Quaternion val_11 = this.万东万丆专丌丕丐丗.localRotation;
        var val_12 = this.东专业丑与丐丆丐丟 + (0 * 40);
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, b:  new UnityEngine.Quaternion() {x = (0 * 40) + this.东专业丑与丐丆丐丟 + 44, y = (0 * 40) + this.东专业丑与丐丆丐丟 + 44 + 4, z = (0 * 40) + this.东专业丑与丐丆丐丟 + 52, w = (0 * 40) + this.东专业丑与丐丆丐丟 + 52 + 4}, t:  (float)val_28);
        this.万东万丆专丌丕丐丗.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
        goto label_29;
        label_2:
        if(this.丌丂丗且丙专业丁业 == true)
        {
                return;
        }
        
        if(this.isLocalTrasformSynch == false)
        {
            goto label_31;
        }
        
        if(this.isSynchPosition != false)
        {
                var val_34 = -4294967296;
            val_34 = val_34 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_15 = this.东专业丑与丐丆丐丟 + ((val_34 >> 32) * 40);
            this.万东万丆专丌丕丐丗.localPosition = new UnityEngine.Vector3() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 32, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 32 + 4, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 40};
        }
        
        if(this.isSynchRotation == false)
        {
            goto label_60;
        }
        
        var val_35 = -4294967296;
        val_35 = val_35 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_17 = this.东专业丑与丐丆丐丟 + ((val_35 >> 32) * 40);
        this.万东万丆专丌丕丐丗.localRotation = new UnityEngine.Quaternion() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 44, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 44 + 4, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 52, w = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 52 + 4};
        goto label_60;
        label_14:
        if(this.isSynchPosition != false)
        {
                UnityEngine.Vector3 val_18 = this.万东万丆专丌丕丐丗.position;
            var val_19 = this.东专业丑与丐丆丐丟 + (0 * 40);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = (0 * 40) + this.东专业丑与丐丆丐丟 + 32, y = (0 * 40) + this.东专业丑与丐丆丐丟 + 32 + 4, z = (0 * 40) + this.东专业丑与丐丆丐丟 + 40}, t:  (float)val_28);
            this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        }
        
        if(this.isSynchRotation == false)
        {
            goto label_48;
        }
        
        UnityEngine.Quaternion val_21 = this.万东万丆专丌丕丐丗.rotation;
        var val_22 = this.东专业丑与丐丆丐丟 + (0 * 40);
        UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w}, b:  new UnityEngine.Quaternion() {x = (0 * 40) + this.东专业丑与丐丆丐丟 + 44, y = (0 * 40) + this.东专业丑与丐丆丐丟 + 44 + 4, z = (0 * 40) + this.东专业丑与丐丆丐丟 + 52, w = (0 * 40) + this.东专业丑与丐丆丐丟 + 52 + 4}, t:  (float)val_28);
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w};
        label_29:
        val_25 = val_25;
        label_48:
        this.下丟丒丁下丄丕丂专 = val_25;
        return;
        label_31:
        if(this.isSynchPosition != false)
        {
                var val_36 = -4294967296;
            val_36 = val_36 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_25 = this.东专业丑与丐丆丐丟 + ((val_36 >> 32) * 40);
            this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 32, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 32 + 4, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 40};
        }
        
        if(this.isSynchRotation != false)
        {
                var val_37 = -4294967296;
            val_37 = val_37 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_27 = this.东专业丑与丐丆丐丟 + ((val_37 >> 32) * 40);
            this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 44, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 44 + 4, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 52, w = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 52 + 4};
        }
        
        label_60:
        var val_38 = -4294967296;
        val_38 = val_38 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        var val_29 = this.东专业丑与丐丆丐丟 + ((val_38 >> 32) * 40);
        this.下丟丒丁下丄丕丂专 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 64;
    }
    private void 专丘丐丐世专丆丗上(UnityEngine.Vector3 丑丏与上不丐丘丕丐, UnityEngine.Quaternion 丝丏丏东丘丐丝下不, double 丄丆万一丙丂丕不丐)
    {
        丝丙丒丌东下丕丘丘[] val_11;
        var val_13;
        val_11 = this.东专业丑与丐丆丐丟;
        if(this.东专业丑与丐丆丐丟 == null)
        {
                val_11 = this.东专业丑与丐丆丐丟;
        }
        
        int val_7 = this.东专业丑与丐丆丐丟.Length;
        var val_1 = (val_11 == null) ? 1 : 0;
        val_13 = val_7 - 1;
        if(val_13 >= 1)
        {
                val_7 = val_7 - 2;
            var val_9 = (long)val_13;
            var val_2 = X11 + 32;
            int val_3 = val_7 + 32;
            do
        {
            val_13 = val_13 - 1;
            val_9 = val_9 - 1;
            val_2 = val_2 - 40;
            val_11[val_2] = val_11[val_3];
            val_3 = val_3 - 40;
            mem2[0] = 丑丏与上不丐丘丕丐.x;
            mem2[0] = null;
            val_11 = this.东专业丑与丐丆丐丟;
            var val_4 = (val_11 == null) ? 1 : 0;
        }
        while(val_13 > 0);
        
        }
        
        val_11[0] = 丑丏与上不丐丘丕丐.x;
        val_11[0] = 丑丏与上不丐丘丕丐.y;
        val_11[1] = 丑丏与上不丐丘丕丐.z;
        this.东专业丑与丐丆丐丟[1] = 丝丏丏东丘丐丝下不.x;
        this.东专业丑与丐丆丐丟[2] = 丝丏丏东丘丐丝下不.y;
        this.东专业丑与丐丆丐丟[2] = 丝丏丏东丘丐丝下不.z;
        this.东专业丑与丐丆丐丟[3] = 丝丏丏东丘丐丝下不.w;
        this.东专业丑与丐丆丐丟[4] = 丄丆万一丙丂丕不丐;
        if(this.丌丂丗且丙专业丁业 == false)
        {
                return;
        }
        
        var val_10 = -4294967296;
        val_10 = val_10 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        val_13 = val_10 >> 32;
        var val_5 = this.东专业丑与丐丆丐丟 + (val_13 * 40);
        if(((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 64) <= this.下丟丒丁下丄丕丂专)
        {
                return;
        }
        
        this.丌丂丗且丙专业丁业 = false;
        var val_11 = -4294967296;
        val_11 = val_11 + ((this.东专业丑与丐丆丐丟.Length) << 32);
        val_13 = val_11 >> 32;
        var val_6 = this.东专业丑与丐丆丐丟 + (val_13 * 40);
        this.下丟丒丁下丄丕丂专 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 40) + this.东专业丑与丐丆丐丟 + 64;
    }

}
