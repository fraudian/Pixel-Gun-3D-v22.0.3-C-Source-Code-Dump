using UnityEngine;
internal class Portal : MonoBehaviour
{
    // Fields
    public Portal connectedPortal;
    private UnityEngine.Collider triger;
    private float deactivationTimer;
    private float delayTeleportation;
    private UnityEngine.Transform outPoint;
    private UnityEngine.ParticleSystem activeVisualization;
    private UnityEngine.ParticleSystem deactiveVisualization;
    private UnityEngine.ParticleSystem enemyVisualization;
    private string explosionName;
    internal bool 东丅丞丁丗万且丁丗;
    private UnityEngine.Coroutine 丝业丗不万下世万丗;
    private UnityEngine.Coroutine 七东丏丏一丘丒三万;
    private bool 业东且万丏上丁丘丈;
    private float 丁丄丄丕业丙与丘下;
    private bool 万丛丘下七丈丌丟丅;
    private int 业东丐丟且业上丏丒;
    private float 七且上丞丏丘万丝专;
    private float 丛七东丘丑与丆世东;
    private Player_move_c 丕不丘下七丑上丏丏;
    private float 丙丝不丝下丐丘万丁;
    private Player_move_c.世不丟丂上丟与丌下 世丙丝万丌丅且七且;
    private WeaponSounds.丏专丐且丘丌丛不丁 与丘丂下丘丁丅与东;
    private int 丘丏丌一丛丐丑上东;
    private string 丆与丕丕丂下丟一丈;
    private bool 丗丌世且丗一业不专;
    private UnityEngine.Vector3 三丄下东世丒丛丄万;
    private bool 七丈与丌下世丒丅专;
    private float 丙一丑丏丁一且丒业;
    
    // Properties
    internal static int 丅丁且丝丝专丞丂丑 { get; }
    
    // Methods
    internal static int 丗专东丂上丄下丝丄()
    {
        int val_4 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        int val_5 = (UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider")) & 31;
        var val_10 = 1;
        int val_6 = (UnityEngine.LayerMask.NameToLayer(layerName:  "TransparentFX")) & 31;
        val_5 = val_10 << val_5;
        int val_7 = (UnityEngine.LayerMask.NameToLayer(layerName:  "IgnoreRocketsAndBullets")) & 31;
        val_6 = val_10 << val_6;
        var val_9 = ~val_5;
        val_7 = val_10 << val_7;
        val_9 = val_9 & (~val_6);
        val_10 = val_10 << (val_4 & 31);
        val_9 = val_9 & (~val_7);
        val_9 = val_9 & (~val_10);
        val_4 = val_9 & 2052;
        return (int)val_4;
    }
    private void Awake()
    {
        this.丁丂丘丐丑丆丐丙丝();
    }
    private void OnDestroy()
    {
        if(this.丝业丗不万下世万丗 != null)
        {
                this.StopCoroutine(routine:  this.丝业丗不万下世万丗);
            this.丝业丗不万下世万丗 = 0;
        }
        
        if(this.七东丏丏一丘丒三万 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.七东丏丏一丘丒三万);
        this.七东丏丏一丘丒三万 = 0;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        Portal val_20;
        Portal val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        PortalChainManager val_26;
        val_20 = this;
        val_21 = this.connectedPortal;
        if(this.connectedPortal.东丅丞丁丗万且丁丗 == false)
        {
                return;
        }
        
        bool val_20 = this.业东且万丏上丁丘丈;
        val_20 = val_20 + 3;
        var val_21 = ~val_20;
        val_21 = val_21 & 3;
        if(val_21 != 0)
        {
                return;
        }
        
        val_21 = 丘丛丏丘丝七世七丅.gameObject.name;
        if((val_21.Equals(value:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_21 = 丘丛丏丘丝七世七丅.transform.parent;
        if(val_21 == 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_21 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_21 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject & 1) == 0)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        业丁丘丙丌丅丏丈且(丟丄七一一丒与业丂:  false);
        UnityEngine.Vector3 val_11 = this.connectedPortal.outPoint.position;
        transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        mem2[0] = 1;
        mem2[0] = 1;
        UnityEngine.Quaternion val_13 = this.outPoint.transform.rotation;
        float val_23 = val_13.y;
        UnityEngine.Quaternion val_15 = this.connectedPortal.outPoint.transform.rotation;
        val_24 = null;
        float val_22 = 360f;
        val_22 = val_15.y + val_22;
        val_24 = null;
        val_23 = ((val_15.y < 0) ? (val_22) : val_15.y) - val_23;
        val_23 = val_23 + (-180f);
        transform.Rotate(xAngle:  0f, yAngle:  val_23, zAngle:  0f);
        UnityEngine.Vector3 val_19 = this.connectedPortal.transform.position;
        val_21 = 1152921505319784448;
        val_25 = null;
        val_25 = null;
        val_26 = PortalChainManager.丄丘七三上丕世丞业;
        if(PortalChainManager.丄丘七三上丕世丞业 != null)
        {
            goto label_52;
        }
        
        val_26 = PortalChainManager.丄丘七三上丕世丞业;
        if(val_26 == null)
        {
            goto label_53;
        }
        
        label_52:
        且丐专丆丄专丕世丛(且丒丗万七丑丁丏丏:  4, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, 丒专丁不三丛丕世丙:  PortalChainManager.丄丘七三上丕世丞业.radiusImpulse, 与丁丐丈万丏丘丂下:  PortalChainManager.丄丘七三上丕世丞业.impulceForce, 丐丙专丄丕丅东丛丑:  0f, 不与一下丈丁一丆丒:  false);
        下万丟万且七不丏丕();
        val_20 = this.connectedPortal;
        this.connectedPortal.业东且万丏上丁丘丈 = true;
        return;
        label_53:
    }
    private void Update()
    {
        if(this.丙一丑丏丁一且丒业 < 1f)
        {
                return;
        }
        
        if(this.七丈与丌下世丒丅专 != false)
        {
                this.丁丂丘丐丑丆丐丙丝();
        }
        else
        {
                this.DeactivateEnemyPortal();
        }
        
        if(this.丝业丗不万下世万丗 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丝业丗不万下世万丗);
        this.丝业丗不万下世万丗 = 0;
    }
    public void SetPortal(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 丏与三业丈丕专且丑, out UnityEngine.Quaternion 三丞丞不丟丕丛下万, UnityEngine.Gradient 丈三丂且丗丆丛七一, Rocket 丁丂丏与丗上丗一丆)
    {
        int val_23;
        float val_24;
        float val_25;
        Player_move_c val_26;
        float val_27;
        int val_28;
        RocketSettings val_29;
        if((this.东丅丞丁丗万且丁丗 != false) && (this.万丛丘下七丈丌丟丅 != false))
        {
                this.万丒丗万丑一一丟丑();
        }
        
        this.gameObject.SetActive(value:  true);
        this.东丅丞丁丗万且丁丗 = true;
        this.transform.position = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        UnityEngine.Vector3 val_4 = this.transform.forward;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, toDirection:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = 丏与三业丈丕专且丑.y, z = 丏与三业丈丕专且丑.z});
        val_23 = this.transform;
        UnityEngine.Quaternion val_7 = val_23.rotation;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, rhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
        三丞丞不丟丕丛下万.x = val_8.x;
        三丞丞不丟丕丛下万.y = val_8.y;
        三丞丞不丟丕丛下万.z = val_8.z;
        三丞丞不丟丕丛下万.w = val_8.w;
        val_24 = 三丞丞不丟丕丛下万.x;
        val_25 = 三丞丞不丟丕丛下万.z;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_24, y = 三丞丞不丟丕丛下万.y, z = val_25, w = 三丞丞不丟丕丛下万.w};
        this.不上丆东丘丌丄丛且(丈三丂且丗丆丛七一:  丈三丂且丗丆丛七一);
        this.triger.enabled = true;
        if(this.connectedPortal.东丅丞丁丗万且丁丗 != false)
        {
                this.connectedPortal.不上丆东丘丌丄丛且(丈三丂且丗丆丛七一:  丈三丂且丗丆丛七一);
        }
        
        if(this.丝业丗不万下世万丗 != null)
        {
                this.StopCoroutine(routine:  this.丝业丗不万下世万丗);
        }
        
        this.丝业丗不万下世万丗 = this.StartCoroutine(routine:  this.丒下丁丝一丐丙专上(丌丏一一业丗丐丑不:  true));
        if(this.七东丏丏一丘丒三万 != null)
        {
                this.StopCoroutine(routine:  this.七东丏丏一丘丒三万);
        }
        
        this.业东且万丏上丁丘丈 = false;
        this.七东丏丏一丘丒三万 = this.StartCoroutine(routine:  this.丄丝七东业丄丐丞丙());
        if(丁丂丏与丗上丗一丆 != null)
        {
                val_26 = 丁丂丏与丗上丗一丆;
            this.万丛丘下七丈丌丟丅 = 丁丂丏与丗上丗一丆.丈丛丕下丙三丒与丈;
        }
        else
        {
                val_26 = 252;
            this.万丛丘下七丈丌丟丅 = false;
        }
        
        if(val_26 == 0)
        {
                return;
        }
        
        if(丁丂丏与丗上丗一丆 != null)
        {
                val_26 = 丁丂丏与丗上丗一丆.上丗丞且且丏丑下丟();
            val_24 = 丁丂丏与丗上丗一丆.下丐不世丁与与丄下;
            val_27 = 丁丂丏与丗上丗一丆.且丙丈业专万不丐丁;
            val_25 = 丁丂丏与丗上丗一丆.丈丒丄丝丐专丐丙丌;
            val_28 = 丁丂丏与丗上丗一丆.万丞丙东东专世丁丘();
        }
        else
        {
                val_26 = 0.上丗丞且且丏丑下丟();
            val_28 = 0.万丞丙东东专世丁丘();
            val_24 = 0f;
            val_27 = 1.651491E-34f;
            val_25 = 9.18355E-41f;
        }
        
        val_29 = 丁丂丏与丗上丗一丆.丅丕丟七丌丘丆丌上;
        if(丁丂丏与丗上丗一丆.丅丕丟七丌丘丆丌上 != null)
        {
            goto label_21;
        }
        
        val_29 = 丁丂丏与丗上丗一丆.丅丕丟七丌丘丆丌上;
        if(val_29 == null)
        {
            goto label_22;
        }
        
        label_21:
        val_23 = 丁丂丏与丗上丗一丆.下业丑万丟丁与丕不().丌上丗丕不七世丅丁().业东丅东丌上丗丑不();
        this.丕不丘下七丑上丏丏 = val_26;
        this.业东丐丟且业上丏丒 = val_28;
        this.七且上丞丏丘万丝专 = val_24;
        this.丛七东丘丑与丆世东 = val_27;
        this.丙丝不丝下丐丘万丁 = val_25;
        this.世丙丝万丌丅且七且 = 丁丂丏与丗上丗一丆.丅丕丟七丌丘丆丌上.typeKilsIconChat;
        this.与丘丂下丘丁丅与东 = 丁丂丏与丗上丗一丆.丅丕丟七丌丘丆丌上.typeDead;
        this.丘丏丌一丛丐丑上东 = val_23;
        this.丆与丕丕丂下丟一丈 = 丁丂丏与丗上丗一丆.下业丑万丟丁与丕不().三与丛丑且丐丈业丌();
        return;
        label_22:
    }
    private void 不上丆东丘丌丄丛且(UnityEngine.Gradient 丈三丂且丗丆丛七一)
    {
        UnityEngine.ParticleSystem val_23;
        var val_26;
        UnityEngine.ParticleSystem val_27;
        var val_28;
        var val_29;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.activeVisualization.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.deactiveVisualization.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enemyVisualization.gameObject, 丏业丟一东丂东丘丛:  true);
        val_23 = this.activeVisualization;
        if(val_23 == null)
        {
            goto label_7;
        }
        
        if(this.connectedPortal.东丅丞丁丗万且丁丗 == false)
        {
            goto label_8;
        }
        
        label_30:
        MainModule val_4 = val_23.main;
        MinMaxGradient val_5 = ParticleSystem.MinMaxGradient.op_Implicit(gradient:  丈三丂且丗丆丛七一);
        System.Collections.IEnumerator val_11 = this.activeVisualization.transform.GetEnumerator();
        label_29:
        var val_24 = 0;
        val_24 = val_24 + 1;
        if(val_11.MoveNext() == false)
        {
            goto label_16;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_26 = val_11.Current;
        if(val_26 != null)
        {
                val_26 = 0;
        }
        
        MainModule val_21 = val_26.GetComponent<UnityEngine.ParticleSystem>().main;
        MinMaxGradient val_22 = ParticleSystem.MinMaxGradient.op_Implicit(gradient:  丈三丂且丗丆丛七一);
        goto label_29;
        label_7:
        if(this.connectedPortal.东丅丞丁丗万且丁丗 == true)
        {
            goto label_30;
        }
        
        label_8:
        val_23.Stop();
        val_27 = this.deactiveVisualization;
        val_27.Play();
        return;
        label_16:
        val_28 = 0;
        val_29 = 0;
        val_23 = val_11;
        if(val_23 != null)
        {
                var val_26 = 0;
            val_26 = val_26 + 1;
            val_23.Dispose();
        }
        
        this.activeVisualization.Play();
        val_27 = this.deactiveVisualization;
        val_27.Stop();
    }
    private void 丁丂丘丐丑丆丐丙丝()
    {
        if((this.东丅丞丁丗万且丁丗 != false) && (this.万丛丘下七丈丌丟丅 != false))
        {
                this.万丒丗万丑一一丟丑();
        }
        
        this.activeVisualization.Stop();
        this.deactiveVisualization.Stop();
        this.enemyVisualization.Stop();
        this.triger.enabled = false;
        this.东丅丞丁丗万且丁丗 = false;
        if(this.七东丏丏一丘丒三万 != null)
        {
                this.StopCoroutine(routine:  this.七东丏丏一丘丒三万);
            this.七东丏丏一丘丒三万 = 0;
        }
        
        if((this.connectedPortal != 0) && (this.connectedPortal.东丅丞丁丗万且丁丗 != false))
        {
                this.connectedPortal.不上丆东丘丌丄丛且(丈三丂且丗丆丛七一:  0);
        }
        
        this.transform.position = new UnityEngine.Vector3() {x = this.三丄下东世丒丛丄万, y = V9.16B, z = V10.16B};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.activeVisualization.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.deactiveVisualization.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enemyVisualization.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.IEnumerator 丒下丁丝一丐丙专上(bool 丌丏一一业丗丐丑不)
    {
        Portal.且与丗专丗业丛万万 val_1 = new Portal.且与丗专丗业丛万万();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丌丏一一业丗丐丑不 = 丌丏一一业丗丐丑不;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丄丝七东业丄丐丞丙()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new Portal.丌丄东东万丕七三丌();
    }
    public void SetEnemyPortal(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Quaternion 七丅丗丆丒丌丑丝不, bool 丆且丙三丐丂丒东丆 = False)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.activeVisualization.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.deactiveVisualization.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enemyVisualization.gameObject, 丏业丟一东丂东丘丛:  true);
        this.万丛丘下七丈丌丟丅 = 丆且丙三丐丂丒东丆;
        this.gameObject.SetActive(value:  true);
        this.transform.position = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        this.transform.rotation = new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.y, z = 七丅丗丆丒丌丑丝不.z, w = 七丅丗丆丒丌丑丝不.w};
        this.enemyVisualization.Play();
        this.activeVisualization.Stop();
        this.deactiveVisualization.Stop();
        this.triger.enabled = false;
        this.东丅丞丁丗万且丁丗 = false;
        this.丗丌世且丗一业不专 = true;
        if(this.丝业丗不万下世万丗 != null)
        {
                this.StopCoroutine(routine:  this.丝业丗不万下世万丗);
        }
        
        this.丝业丗不万下世万丗 = this.StartCoroutine(routine:  this.丒下丁丝一丐丙专上(丌丏一一业丗丐丑不:  false));
    }
    public void DeactivateEnemyPortal()
    {
        this.enemyVisualization.Stop();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.activeVisualization.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.deactiveVisualization.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enemyVisualization.gameObject, 丏业丟一东丂东丘丛:  false);
        if(this.丝业丗不万下世万丗 != null)
        {
                this.StopCoroutine(routine:  this.丝业丗不万下世万丗);
            this.丝业丗不万下世万丗 = 0;
        }
        
        this.transform.position = new UnityEngine.Vector3() {x = this.三丄下东世丒丛丄万, y = V9.16B, z = V10.16B};
    }
    private void 万丒丗万丑一一丟丑()
    {
        string val_55;
        UnityEngine.Object val_56;
        float val_57;
        float val_58;
        var val_59;
        var val_60;
        var val_63;
        var val_64;
        var val_65;
        float val_66;
        var val_67;
        丅丙上七上一丐不下 val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        bool val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        val_55 = 丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  this.explosionName);
        val_56 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  val_55);
        if(val_56 != 0)
        {
                val_56 = val_56.transform;
            val_55 = this.transform;
            UnityEngine.Vector3 val_6 = val_55.position;
            val_57 = val_6.x;
            val_58 = val_6.z;
            val_56.position = new UnityEngine.Vector3() {x = val_57, y = val_6.y, z = val_58};
        }
        
        bool val_57 = this.丗丌世且丗一业不专;
        val_57 = val_57 + 7;
        var val_58 = ~val_57;
        val_58 = val_58 & 7;
        if(val_58 != 0)
        {
                return;
        }
        
        val_59 = null;
        val_59 = null;
        val_60 = null;
        val_60 = null;
        UnityEngine.Vector3 val_9 = this.transform.position;
        val_57 = val_9.x;
        val_58 = val_9.z;
        val_56 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不丙丗丞丌丈且丄丟:  与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
        label_158:
        var val_59 = 0;
        val_59 = val_59 + 1;
        if(val_56.MoveNext() == false)
        {
            goto label_23;
        }
        
        var val_60 = 0;
        val_60 = val_60 + 1;
        T val_14 = val_56.Current;
        if(val_14 == 0)
        {
            goto label_158;
        }
        
        丅丙上七上一丐不下 val_16 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_14);
        val_63 = null;
        val_63 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_64 = null;
            val_64 = null;
            var val_18 = (typeof(Player_move_c).__il2cppRuntimeField_600 == val_16) ? 1 : 0;
        }
        else
        {
                val_65 = 0;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                丅丙上七上一丐不下 val_20 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_14);
        }
        
        if(val_65 == 0)
        {
            goto label_56;
        }
        
        val_66 = this.丛七东丘丑与丆世东;
        if(val_14 != 0)
        {
            goto label_106;
        }
        
        goto label_107;
        label_56:
        val_66 = this.七且上丞丏丘万丝专;
        if(val_14 != 0)
        {
            goto label_106;
        }
        
        label_107:
        label_106:
        UnityEngine.Vector3 val_21 = val_14.position;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_57, y = val_9.y, z = val_58});
        val_67 = 0;
        float val_24 = val_66 * 1000f;
        goto label_62;
        label_78:
        val_67 = 1;
        label_62:
        if(val_67 >= val_23.Length)
        {
            goto label_158;
        }
        
        long val_61 = 1;
        val_61 = (UnityEngine.Physics.RaycastAll(origin:  new UnityEngine.Vector3() {x = val_57, y = val_9.y, z = val_58}, direction:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, maxDistance:  val_66)) + (val_61 * 44);
        val_68 = val_16;
        val_69 = 1152921505286238208;
        if((val_14.root.gameObject != (val_61 + 32.gameObject.transform.root.gameObject)) || ((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_57, y = val_9.y, z = val_58}, b:  new UnityEngine.Vector3() {x = val_57, y = val_9.y, z = val_58})) >= 0))
        {
            goto label_78;
        }
        
        val_70 = null;
        val_70 = null;
        if(val_65 != 0)
        {
            goto label_84;
        }
        
        bool val_35 = (UnityEngine.Object.op_Equality(x:  this.丕不丘下七丑上丏丏, y:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) ^ 1;
        val_35 = 0 | val_35;
        val_71 = 0;
        if(val_35 == true)
        {
            goto label_114;
        }
        
        val_72 = 0;
        if((val_14.CompareTag(tag:  "Player")) == true)
        {
            goto label_87;
        }
        
        val_72 = 0;
        if((val_14.CompareTag(tag:  "Pet")) == false)
        {
            goto label_89;
        }
        
        label_87:
        if(val_68 == 0)
        {
            goto label_141;
        }
        
        label_113:
        val_73 = null;
        val_73 = null;
        var val_65 = val_68;
        if((val_16 + 286) == 0)
        {
            goto label_95;
        }
        
        var val_62 = val_16 + 176;
        var val_63 = 0;
        val_62 = val_62 + 8;
        label_97:
        if(((val_16 + 176 + 8) + -8) == null)
        {
            goto label_96;
        }
        
        val_63 = val_63 + 1;
        val_62 = val_62 + 16;
        if(val_63 < (val_16 + 286))
        {
            goto label_97;
        }
        
        label_95:
        val_72 = 4;
        goto label_98;
        label_84:
        val_71 = 0;
        if(val_68 != 0)
        {
            goto label_133;
        }
        
        goto label_136;
        label_89:
        val_71 = 0;
        if(val_68 == 0)
        {
            goto label_114;
        }
        
        if(((val_14.CompareTag(tag:  "Enemy")) ^ 1) == false)
        {
            goto label_113;
        }
        
        goto label_114;
        label_96:
        var val_64 = val_62;
        val_64 = val_64 + 4;
        val_65 = val_65 + val_64;
        val_74 = val_65 + 296;
        label_98:
        if((val_68.IsEnemyTo(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
            goto label_132;
        }
        
        if((val_68 == 0) || ((val_16 + 24.丏下丙丞丕丕丏丕丞()) == false))
        {
            goto label_120;
        }
        
        val_71 = 0;
        goto label_133;
        label_120:
        if((GameConnect.丙丘不世专且万丄丐() == false) || (((TimeGameController.丄丞丁丈与业上丞丟 == 0) || (ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory == 1)) || (this.业东丐丟且业上丏丒 == 1)))
        {
            goto label_130;
        }
        
        val_68 = val_16;
        val_69 = 1152921505286238208;
        if((this.业东丐丟且业上丏丒 - 1) != ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory)
        {
            goto label_132;
        }
        
        label_130:
        val_71 = 1;
        if(val_68 != 0)
        {
            goto label_133;
        }
        
        label_136:
        val_78 = 0;
        val_79 = 0;
        if((val_71 & 1) != 0)
        {
            goto label_134;
        }
        
        goto label_148;
        label_132:
        val_71 = 0;
        label_114:
        if(val_68 == 0)
        {
            goto label_136;
        }
        
        label_133:
        var val_69 = val_68;
        if((val_16 + 286) == 0)
        {
            goto label_140;
        }
        
        var val_66 = val_16 + 176;
        var val_67 = 0;
        val_66 = val_66 + 8;
        label_139:
        if(((val_16 + 176 + 8) + -8) == null)
        {
            goto label_138;
        }
        
        val_67 = val_67 + 1;
        val_66 = val_66 + 16;
        if(val_67 < (val_16 + 286))
        {
            goto label_139;
        }
        
        goto label_140;
        label_138:
        var val_68 = val_66;
        val_68 = val_68 + 5;
        val_69 = val_69 + val_68;
        val_80 = val_69 + 296;
        label_140:
        val_78 = val_68.IsDead();
        if((val_71 & 1) == 0)
        {
            goto label_141;
        }
        
        label_134:
        丛丐丒上丒丘丆丕与(万丐七下丂丂丛世丞:  val_78, 且世与七东丕丈丗丁:  true, 世丕与丙丄丙不丄丝:  false);
        val_81 = null;
        丐丐丙丕丒丘三上丒(三丕丕七丘不专丏且:  val_78, 不丕丅三丕丏丕上专:  0);
        val_79 = 1;
        goto label_148;
        label_141:
        val_79 = 0;
        label_148:
        UnityEngine.Vector3 val_54 = this.transform.position;
        var val_73 = val_68;
        if((val_16 + 286) == 0)
        {
            goto label_157;
        }
        
        var val_70 = val_16 + 176;
        var val_71 = 0;
        val_70 = val_70 + 8;
        label_156:
        if(((val_16 + 176 + 8) + -8) == null)
        {
            goto label_155;
        }
        
        val_71 = val_71 + 1;
        val_70 = val_70 + 16;
        if(val_71 < (val_16 + 286))
        {
            goto label_156;
        }
        
        goto label_157;
        label_155:
        var val_72 = val_70;
        val_72 = val_72 + 3;
        val_73 = val_73 + val_72;
        val_82 = val_73 + 296;
        label_157:
        val_68.ApplyDamage(丞丈专下丈专业三丞:  this.业丂丛丟上且丂东丂(丏丆世丒且丑与丗丅:  false, 丞下万上三丘上与专:  val_68), 丛世一丟丞丁业丘丒:  this.丕不丘下七丑上丏丏.丂七一业下丈业丕丒, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, 丐丟丘世丁三丕专专:  this.世丙丝万丌丅且七且, 东丏业丞丞业下丄世:  this.与丘丂下丘丁丅与东, 丝三丛且丘不丌丙下:  this.丆与丕丕丂下丟一丈, 丒丈丐丐丗丐专丈丏:  this.丕不丘下七丑上丏丏.丕七丆丂丅丐专不丞.viewID);
        goto label_158;
        label_23:
        val_55 = 0;
        val_83 = 0;
        if(val_56 == null)
        {
            
        }
        else
        {
                var val_74 = 0;
            val_74 = val_74 + 1;
            val_56.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private float 业丂丛丟上且丂东丂(bool 丏丆世丒且丑与丗丅, 丅丙上七上一丐不下 丞下万上三丘上与专)
    {
        float val_23;
        float val_24;
        var val_25;
        float val_26;
        float val_28;
        Player_move_c val_30;
        float val_31;
        var val_33;
        if(this.丕不丘下七丑上丏丏.丈且丟且与丐七一专 != false)
        {
                val_23 = this.丕不丘下七丑上丏丏.三丘丈丛丏丅丟丝与;
        }
        else
        {
                val_23 = 1f;
        }
        
        if(this.丕不丘下七丑上丏丏 == 0)
        {
            goto label_7;
        }
        
        val_24 = this.丕不丘下七丑上丏丏.mySkinName.firstPersonControl.与丌丆下丝下丘丏丗;
        var val_2 = (val_24 > 0.2f) ? 1 : 0;
        if(丏丆世丒且丑与丗丅 == true)
        {
            goto label_11;
        }
        
        label_14:
        val_26 = 1f;
        if(丞下万上三丘上与专 != null)
        {
            goto label_23;
        }
        
        goto label_13;
        label_7:
        val_25 = 0;
        if(丏丆世丒且丑与丗丅 == false)
        {
            goto label_14;
        }
        
        label_11:
        一三专丈世丑丆丑丐 val_3 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_25 != 0)
        {
                一三专丈世丑丆丑丐 val_4 = PlayerCoreSettingsStorager.dynamicSettings;
            val_24 = val_4.丒丂下七丑丌丏东丐;
        }
        else
        {
                val_24 = 1f;
        }
        
        val_26 = val_3.与三丞上丛丒丆丙丝 * val_24;
        if(丞下万上三丘上与专 != null)
        {
            goto label_23;
        }
        
        label_13:
        label_23:
        var val_25 = 0;
        val_25 = val_25 + 1;
        UnityEngine.Vector3 val_7 = 丞下万上三丘上与专.transform.position;
        float val_9 = this.丌七丞丄丁万丂丅丒(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 丕丒丕丐万丌且一下:  丏丆世丒且丑与丗丅);
        val_9 = val_26 * val_9;
        val_23 = val_23 * val_9;
        val_28 = val_23 * 丘丐丘万丌丟丞下丝.七丒丁丌丞丑丏丟丑();
        if(丏丆世丒且丑与丗丅 != false)
        {
                val_28 = val_28 * 丘丐丘万丌丟丞下丝.丙丝丙三万东丙丗丙();
        }
        
        val_28 = val_28 * this.丕不丘下七丑上丏丏.丝上丐万七上丈丞丐();
        float val_13 = this.丕不丘下七丑上丏丏.丛三七丑丁三丙丐东();
        float val_26 = 1f;
        val_13 = val_13 + val_26;
        val_28 = val_28 * val_13;
        float val_15 = 丘丐丘万丌丟丞下丝.丕丅万丌与丛且丐丗(七丆丒与丗丌丄且丂:  this.业东丐丟且业上丏丒 - 1);
        val_15 = val_15 + val_26;
        val_28 = val_28 * val_15;
        val_26 = val_28 * (丘丐丘万丌丟丞下丝.专丝下丝世下世丛不(七丞丙丒三丕且丌丟:  this.业东丐丟且业上丏丒 - 1));
        val_30 = this.丕不丘下七丑上丏丏;
        val_31 = val_26 * 丘丐丘万丌丟丞下丝.三一丑丂丞丈丞丝丆();
        if(val_30 != 0)
        {
                val_30 = this.丕不丘下七丑上丏丏;
            val_31 = val_31 * val_30.charDmgCoef;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        val_33 = null;
        val_33 = null;
        float val_24 = WeaponManager.丟丗丄业丘丗业丗七.丌丄丄丙与丟丐丕丑(丈丁丄丘丛世七丙丝:  this.丘丏丌一丛丐丑上东);
        val_7.y = val_31 * (万世专丘且万世七丒.丏下丐业丏万丄丁下(万丄丟业丅丄不东丒:  this.丙丝不丝下丐丘万丁, 业业丈丗丅丘不上丙:  0, 丞下万上三丘上与专:  丞下万上三丘上与专.transform));
        val_24 = val_7.y * val_24;
        return (float)val_24;
    }
    private float 丌七丞丄丁万丂丅丒(UnityEngine.Vector3 下业丕七东丌丝下且, bool 丕丒丕丐万丌且一下 = False)
    {
        float val_8;
        var val_9;
        val_8 = 下业丕七东丌丝下且.z;
        val_9 = this;
        float val_1 = (丕丒丕丐万丌且一下 != true) ? this.丛七东丘丑与丆世东 : this.七且上丞丏丘万丝专;
        if(val_1 <= 0f)
        {
                return (float)val_7;
        }
        
        val_9 = this.transform;
        UnityEngine.Vector3 val_3 = val_9.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = val_8});
        float val_5 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_5 = val_5 / (val_1 * val_1);
        val_8 = 1f;
        float val_7 = UnityEngine.Mathf.Clamp(value:  val_5, min:  0.01f, max:  val_8);
        val_7 = val_8 - val_7;
        return (float)val_7;
    }
    private void 上丟丛丑丈世丁丈一(Player_move_c 丘世丛丈丅世丑丙丂, int 下丐东专丏丙丗丈不, float 下丐不世丁与与丄下, float 且丙丈业专万不丐丁, float 丈丒丄丝丐专丐丙丌, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, int 丒东专世上七丅业丕, string 丝三丛且丘不丌丙下)
    {
        this.丕不丘下七丑上丏丏 = 丘世丛丈丅世丑丙丂;
        this.业东丐丟且业上丏丒 = 下丐东专丏丙丗丈不;
        this.七且上丞丏丘万丝专 = 下丐不世丁与与丄下;
        this.丛七东丘丑与丆世东 = 且丙丈业专万不丐丁;
        this.丙丝不丝下丐丘万丁 = 丈丒丄丝丐专丐丙丌;
        this.世丙丝万丌丅且七且 = 丐丟丘世丁三丕专专;
        this.与丘丂下丘丁丅与东 = 东丏业丞丞业下丄世;
        this.丘丏丌一丛丐丑上东 = 丒东专世上七丅业丕;
        this.丆与丕丕丂下丟一丈 = 丝三丛且丘不丌丙下;
    }
    public Portal()
    {
        this.deactivationTimer = 10f;
        this.delayTeleportation = 2f;
        this.explosionName = "Explosion825";
        this.七且上丞丏丘万丝专 = 10f;
        this.丛七东丘丑与丆世东 = 10f;
        this.三丄下东世丒丛丄万 = 0;
        mem[1152921540242125812] = 0;
    }

}
