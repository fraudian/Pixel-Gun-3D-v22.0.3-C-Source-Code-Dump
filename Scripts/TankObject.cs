using UnityEngine;
public class TankObject : TrainObject
{
    // Fields
    internal UnityEngine.Transform healthPoint;
    private bool 三丟不丑东丈且丝丑;
    private float 丞丂丄丁丅万业业下;
    private float 下丈丑三丂一丘万丈;
    public UnityEngine.GameObject explosionObject;
    public UnityEngine.GameObject radiusIndication;
    internal float indicatorAlpha;
    internal UnityEngine.MeshRenderer indicatorMeshRenderer;
    internal ClanTankTowerHolder towerHolder;
    internal System.Collections.Generic.List<ClanTankTurretPoint> turretPoints;
    internal System.Collections.Generic.List<ClanTankMaterialChangePoint> materialPoints;
    public UnityEngine.Material trackMaterial;
    public float trackSpeed;
    private bool 下丈万东不丁丒丐世;
    private bool 丈万丝丁丞丙不万丘;
    private float 一三专东丞不上丅丟;
    private bool 且七丝丞丝下七丏丂;
    
    // Methods
    protected override void 丐丕丏专丐不丘三不()
    {
        this.丐丕丏专丐不丘三不();
        this.radiusIndication.transform.SetParent(parent:  0, worldPositionStays:  false);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  S8 + S8);
        this.radiusIndication.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
        this.trackMaterial.mainTextureOffset = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
    }
    protected override void 丗丙下且上下与丛丈()
    {
        this.丗丙下且上下与丛丈();
        this.七丅且丘不丝丄丁东();
        this.三丑下丆丂丅丟丄丐();
    }
    protected override void 丄丙丝万丌丞丑丈丐(TramPath 丅专与丒丈丗丒丘丌)
    {
        TankController.丄丘七三上丕世丞业.OnCheckpointReached(丛丄业丕且丗下一万:  丅专与丒丈丗丒丘丌);
    }
    protected override void 丟丁丛丏与业万丟且()
    {
        this.丟丁丛丏与业万丟且();
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.radiusIndication.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    protected override void 丘丟丛一万下七丁丁(float 丒且丆丘丞丑业丅不)
    {
        var val_9;
        float val_10;
        var val_11;
        this.丘丟丛一万下七丁丁(丒且丆丘丞丑业丅不:  丒且丆丘丞丑业丅不);
        UnityEngine.Vector2 val_1 = this.trackMaterial.mainTextureOffset;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.up;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  丒且丆丘丞丑业丅不);
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  this.trackSpeed);
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.trackMaterial.mainTextureOffset = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        if(this.三丟不丑东丈且丝丑 == false)
        {
                return;
        }
        
        if(this.三丟不丑东丈且丝丑 == true)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        float val_7 = this.丞丂丄丁丅万业业下 + 丒且丆丘丞丑业丅不;
        val_10 = this.下丈丑三丂一丘万丈 + 丒且丆丘丞丑业丅不;
        this.丞丂丄丁丅万业业下 = val_7;
        this.下丈丑三丂一丘万丈 = val_10;
        if(val_7 >= 5f)
        {
                this.丞丂丄丁丅万业业下 = 0f;
            val_11 = null;
            val_11 = null;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  136, 专上丝且丂世丛丝丒:  1f);
            val_10 = this.下丈丑三丂一丘万丈;
        }
        
        if(val_10 < 1f)
        {
                return;
        }
        
        val_10 = val_10 + (-1f);
        this.下丈丑三丂一丘万丈 = val_10;
    }
    protected override void 丐丕丆丈丙万丝丛丒(TramPath 丅专与丒丈丗丒丘丌)
    {
        TankController.丄丘七三上丕世丞业.OnEndReached(丛丄业丕且丗下一万:  丅专与丒丈丗丒丘丌);
    }
    private void 三丑下丆丂丅丟丄丐()
    {
        TankController val_20;
        var val_21;
        var val_22;
        float val_23;
        var val_24;
        var val_25;
        val_20 = this;
        val_21 = null;
        val_21 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer != 0)
        {
                UnityEngine.Vector3 val_3 = this.transform.position;
            val_22 = null;
            val_23 = val_3.x;
            val_22 = null;
            UnityEngine.Vector3 val_5 = transform.position;
            UnityEngine.Vector3 val_7 = this.transform.position;
            UnityEngine.Vector3 val_9 = transform.position;
            float val_11 = val_7.z - val_9.z;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_23 - val_5.x, y:  val_11);
            val_11 = val_11 * val_11;
            if(val_12.x.sqrMagnitude <= val_11)
        {
                UnityEngine.Vector3 val_15 = this.transform.position;
            val_24 = null;
            val_23 = val_15.y;
            val_24 = null;
            UnityEngine.Vector3 val_17 = transform.position;
            val_17.y = val_23 - val_17.y;
            if(System.Math.Abs(val_17.y) < 0)
        {
                val_25 = null;
            val_25 = null;
        }
        
        }
        
        }
        
        if(this.三丟不丑东丈且丝丑 == false)
        {
                return;
        }
        
        this.丞丂丄丁丅万业业下 = 0f;
        val_20 = TankController.丄丘七三上丕世丞业;
        val_20.RegisterMyPlayerInTram(东丝丁下丁东且丑业:  false);
        this.三丟不丑东丈且丝丑 = false;
    }
    private void 七丅且丘不丝丄丁东()
    {
        var val_6;
        float val_7;
        float val_8;
        string val_9;
        if(true != 0)
        {
                if(true != 0)
        {
                val_6 = 1;
        }
        else
        {
                bool val_1 = (S0 >= 0f) ? 1 : 0;
        }
        
        }
        
        if(val_1 == this.下丈万东不丁丒丐世)
        {
                val_7 = this.一三专东丞不上丅丟;
            if(val_7 <= 0f)
        {
                return;
        }
        
            val_8 = this.一三专东丞不上丅丟;
        }
        else
        {
                this.下丈万东不丁丒丐世 = val_1;
            val_8 = this.一三专东丞不上丅丟;
            this.一三专东丞不上丅丟 = 1.5f;
            val_7 = 1.5f;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_7 - val_2;
        mem2[0] = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        if(((this.下丈万东不丁丒丐世 == true) ? 1 : 0) == ((this.且七丝丞丝下七丏丂 == true) ? 1 : 0))
        {
                return;
        }
        
        this.且七丝丞丝下七丏丂 = this.下丈万东不丁丒丐世;
        if(this.下丈万东不丁丒丐世 == false)
        {
            goto label_9;
        }
        
        if(this.下丈万东不丁丒丐世 == false)
        {
            goto label_10;
        }
        
        return;
        label_9:
        val_9 = "Key_8094";
        goto label_13;
        label_10:
        val_9 = "Key_8095";
        label_13:
        string val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_9);
        val_5.上丛丑世不丅丟下丄(丕丗丘丑丛与丑业丒:  val_5, 丂三丟丂丈丐丆丗丟:  2f);
    }
    private void 上丛丑世不丅丟下丄(string 丕丗丘丑丛与丑业丒, float 丂三丟丂丈丐丆丗丟)
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        且丕万丑下业丙丂丗().Show(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
    }
    internal ClanTankTurretPoint 丝丌且东东上丌丙丟(int 世丟丄丅丛世丝丑丕)
    {
        var val_4;
        .世丟丄丅丛世丝丑丕 = 世丟丄丅丛世丝丑丕;
        if(this.turretPoints != null)
        {
                ClanTankTurretPoint val_3 = this.turretPoints.Find(match:  new System.Predicate<ClanTankTurretPoint>(object:  new TankObject.丒丂万丒丂一上丞一(), method:  System.Boolean TankObject.丒丂万丒丂一上丞一::不丄与丕万丅且下丏(ClanTankTurretPoint 三丟东丕丄丄下下丑)));
            return (ClanTankTurretPoint)val_4;
        }
        
        val_4 = 0;
        return (ClanTankTurretPoint)val_4;
    }
    public ClanTankMaterialChangePoint GetMaterialChangePointByPlaceId(int 世丟丄丅丛世丝丑丕)
    {
        var val_4;
        .世丟丄丅丛世丝丑丕 = 世丟丄丅丛世丝丑丕;
        if(this.materialPoints != null)
        {
                ClanTankMaterialChangePoint val_3 = this.materialPoints.Find(match:  new System.Predicate<ClanTankMaterialChangePoint>(object:  new TankObject.丘丞三且东万丕丙丂(), method:  System.Boolean TankObject.丘丞三且东万丕丙丂::丌世东三专丆丆丏万(ClanTankMaterialChangePoint 三丟东丕丄丄下下丑)));
            return (ClanTankMaterialChangePoint)val_4;
        }
        
        val_4 = 0;
        return (ClanTankMaterialChangePoint)val_4;
    }
    public void SetRadiusIndicatorColor(UnityEngine.Color 丌七东世丟丒世丌丆)
    {
        this.indicatorMeshRenderer.material.color = new UnityEngine.Color() {r = 丌七东世丟丒世丌丆.r, g = 丌七东世丟丒世丌丆.g, b = 丌七东世丟丒世丌丆.b, a = this.indicatorAlpha};
        this.indicatorMeshRenderer.gameObject.SetActive(value:  true);
    }
    internal void 丝丞丏丌丐丂丛专丒()
    {
        this.indicatorMeshRenderer.gameObject.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.trackMaterial.mainTextureOffset = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    public TankObject()
    {
        this.indicatorAlpha = 0.65f;
        this.trackSpeed = 1f;
    }

}
