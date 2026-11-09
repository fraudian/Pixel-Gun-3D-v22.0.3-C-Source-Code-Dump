using UnityEngine;
public class PhotonTransformView : MonoBehaviour, 丈丆丁上丁业丒七丘
{
    // Fields
    public PhotonTransformViewPositionModel m_PositionModel;
    public PhotonTransformViewRotationModel m_RotationModel;
    public PhotonTransformViewScaleModel m_ScaleModel;
    private 上上丁丈丄下丕丏丂 丝丏丑丁丛业三丁上;
    private 丙一三丅丏一三丝丂 丈丘丘丛丄丞丕丄且;
    private 七丑万下丁丌丕丕下 丗业一丗下七丁业上;
    private PhotonView 七不丐丆专与丁下丄;
    private bool 专丗丙丙丌万丈下万;
    private bool 丕下一丈不丐丂丕丆;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    
    // Properties
    private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
    
    // Methods
    private void Awake()
    {
        this.七不丐丆专与丁下丄 = this.GetComponent<PhotonView>();
        this.丝丏丑丁丛业三丁上 = new 上上丁丈丄下丕丏丂(丟丞丄万丂丗丟丆七:  this.m_PositionModel);
        this.丈丘丘丛丄丞丕丄且 = new 丙一三丅丏一三丝丂(丟丞丄万丂丗丟丆七:  this.m_RotationModel);
        this.丗业一丗下七丁业上 = new 七丑万下丁丌丕丕下(丟丞丄万丂丗丟丆七:  this.m_ScaleModel);
    }
    private void OnEnable()
    {
        this.丕下一丈不丐丂丕丆 = true;
    }
    private void Update()
    {
        if(this.七不丐丆专与丁下丄 == 0)
        {
                return;
        }
        
        if(this.七不丐丆专与丁下丄.isMine == true)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
                return;
        }
        
        this.七丒下丂丝且丕丌东();
        this.上丛一丗丝万万七丆();
        this.丛业与三丂丌万丑丙();
    }
    private void 七丒下丂丝且丕丌东()
    {
        if(this.m_PositionModel.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(this.专丗丙丙丌万丈下万 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().localPosition;
        UnityEngine.Vector3 val_4 = this.丝丏丑丁丛业三丁上.七丒下丂丝且丕丌东(丒不三丁丒丏丂丒丈:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    private void 上丛一丗丝万万七丆()
    {
        if(this.m_RotationModel.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(this.专丗丙丙丌万丈下万 == false)
        {
                return;
        }
        
        UnityEngine.Quaternion val_3 = this.丌丟丄业且三丛丕丄().localRotation;
        UnityEngine.Quaternion val_4 = this.丈丘丘丛丄丞丕丄且.下丞丙丄三万丛世丑(丞丌万丈丐三丄丐业:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        this.丌丟丄业且三丛丕丄().localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    private void 丛业与三丂丌万丑丙()
    {
        if(this.m_ScaleModel.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(this.专丗丙丙丌万丈下万 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().localScale;
        UnityEngine.Vector3 val_4 = this.丗业一丗下七丁业上.丛丝业丂丒丙丛丆丙(丞丝丕丄与下七世业:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public void SetSynchronizedValues(UnityEngine.Vector3 丟丞一专丕三东丗一, float 丄丒丄丌丆丞专丌下)
    {
        this.丝丏丑丁丛业三丁上.丙七丆丆上丁丘不丈(丟丞一专丕三东丗一:  new UnityEngine.Vector3() {x = 丟丞一专丕三东丗一.x, y = 丟丞一专丕三东丗一.y, z = 丟丞一专丕三东丗一.z}, 丄丒丄丌丆丞专丌下:  丄丒丄丌丆丞专丌下);
    }
    public void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        var val_15;
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        PhotonView val_21;
        val_15 = this;
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().localPosition;
        this.丝丏丑丁丛业三丁上.丁万丂丝丘业丈丛丘(丒不三丁丒丏丂丒丈:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 东业丄丅丅且世七丄:  东业丄丅丅且世七丄, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
        UnityEngine.Quaternion val_4 = this.丌丟丄业且三丛丕丄().localRotation;
        this.丈丘丘丛丄丞丕丄且.丁万丂丝丘业丈丛丘(丞丌万丈丐三丄丐业:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, 东业丄丅丅且世七丄:  东业丄丅丅且世七丄, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
        UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().localScale;
        val_16 = val_6.x;
        val_17 = val_6.z;
        val_18 = val_16;
        val_19 = val_6.y;
        val_20 = val_17;
        this.丗业一丗下七丁业上.丁万丂丝丘业丈丛丘(丞丝丕丄与下七世业:  new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_20}, 东业丄丅丅且世七丄:  东业丄丅丅且世七丄, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
        val_21 = this.七不丐丆专与丁下丄;
        if(val_21.isMine != true)
        {
                val_21 = this.m_PositionModel;
            if(this.m_PositionModel.DrawErrorGizmo != false)
        {
                this.丆丟丟丗丌丆丅丞丟();
        }
        
        }
        
        if(东业丄丅丅且世七丄.丟东七不丕丞七丆丑() == false)
        {
                return;
        }
        
        this.专丗丙丙丌万丈下万 = true;
        if(this.丕下一丈不丐丂丕丆 == false)
        {
                return;
        }
        
        this.丕下一丈不丐丂丕丆 = false;
        if(this.m_PositionModel.SynchronizeEnabled != false)
        {
                val_21 = this.丝丏丑丁丛业三丁上;
            UnityEngine.Vector3 val_10 = val_21.丕丘东丏丂下丕丐丟();
            val_16 = val_10.x;
            val_17 = val_10.z;
            val_18 = val_16;
            val_19 = val_10.y;
            val_20 = val_17;
            this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_20};
        }
        
        if(this.m_RotationModel.SynchronizeEnabled != false)
        {
                val_21 = this.丈丘丘丛丄丞丕丄且;
            UnityEngine.Quaternion val_12 = val_21.丁丞丒万世丛专丑东();
            val_16 = val_12.x;
            val_17 = val_12.z;
            val_18 = val_16;
            val_19 = val_12.y;
            val_20 = val_17;
            this.丌丟丄业且三丛丕丄().localRotation = new UnityEngine.Quaternion() {x = val_18, y = val_19, z = val_20, w = val_12.w};
        }
        
        if(this.m_ScaleModel.SynchronizeEnabled == false)
        {
                return;
        }
        
        val_15 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_14 = this.丗业一丗下七丁业上.丄丏万丌世与丈丄丗();
        val_16 = val_14.x;
        val_17 = val_14.z;
        val_15.localScale = new UnityEngine.Vector3() {x = val_16, y = val_14.y, z = val_17};
    }
    private void 丆丟丟丗丌丆丅丞丟()
    {
        float val_22;
        UnityEngine.Vector3 val_1 = this.丝丏丑丁丛业三丁上.丕丘东丏丂下丕丐丟();
        val_22 = val_1.z;
        if(this.丌丟丄业且三丛丕丄().parent != 0)
        {
                UnityEngine.Vector3 val_7 = this.丌丟丄业且三丛丕丄().parent.position;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_22});
            val_22 = val_8.z;
        }
        
        UnityEngine.Vector3 val_10 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Color val_11 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_22}, end:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, color:  new UnityEngine.Color() {r = val_11.r, g = val_11.b, b = 2f, a = val_8.y}, duration:  ???);
        UnityEngine.Vector3 val_13 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_15 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        UnityEngine.Color val_18 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, end:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, color:  new UnityEngine.Color() {r = val_18.r, g = val_18.b, b = 2f, a = val_8.y}, duration:  ???);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_22}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Color val_21 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_22}, end:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, color:  new UnityEngine.Color() {r = val_21.r, g = val_21.b, b = 2f, a = val_8.y}, duration:  ???);
    }
    private UnityEngine.Transform 丌丟丄业且三丛丕丄()
    {
        UnityEngine.Transform val_3;
        if(this.专专丏下丐丂丂丅东 == 0)
        {
                this.专专丏下丐丂丂丅东 = this.transform;
            return val_3;
        }
        
        val_3 = this.专专丏下丐丂丂丅东;
        return val_3;
    }
    public PhotonTransformView()
    {
        this.m_PositionModel = new PhotonTransformViewPositionModel();
        PhotonTransformViewRotationModel val_2 = null;
        .InterpolateOption = 1;
        .InterpolateLerpSpeed = 5f;
        val_2 = new PhotonTransformViewRotationModel();
        this.m_RotationModel = val_2;
        PhotonTransformViewScaleModel val_3 = null;
        .InterpolateMoveTowardsSpeed = 1f;
        val_3 = new PhotonTransformViewScaleModel();
        this.m_ScaleModel = val_3;
    }

}
