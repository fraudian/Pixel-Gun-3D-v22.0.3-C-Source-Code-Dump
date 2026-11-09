using UnityEngine;
public class PhotonAnimatorView : MonoBehaviour, 丈丆丁上丁业丒七丘
{
    // Fields
    private UnityEngine.Animator 业丏丑丆一一丑万丑;
    private 丆七丂丕丄丙丈万三 丗丟下丝丐丁丌丈东;
    private bool ShowLayerWeightsInspector;
    private bool ShowParameterInspector;
    private System.Collections.Generic.List<PhotonAnimatorView.SynchronizedParameter> m_SynchronizeParameters;
    private System.Collections.Generic.List<PhotonAnimatorView.SynchronizedLayer> m_SynchronizeLayers;
    private UnityEngine.Vector3 丛丑丝世不丑东万丛;
    private float 一丝丁丛与世丏丛丙;
    private bool 丅丐世丁丞丘不东丒;
    private PhotonView 七不丐丆专与丁下丄;
    private System.Collections.Generic.List<string> 一丗丟上业丘丛丄丅;
    
    // Methods
    private void Awake()
    {
        this.七不丐丆专与丁下丄 = this.GetComponent<PhotonView>();
        this.丗丟下丝丐丁丌丈东 = new 丆七丂丕丄丙丈万三(丒下丙丛丂三丕丛业:  120);
        this.业丏丑丆一一丑万丑 = this.GetComponent<UnityEngine.Animator>();
    }
    private void Update()
    {
        if((this.业丏丑丆一一丑万丑.applyRootMotion != false) && (this.七不丐丆专与丁下丄.isMine != true))
        {
                if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != false)
        {
                this.业丏丑丆一一丑万丑.applyRootMotion = false;
        }
        
        }
        
        if(丅丒丗丑丒丙丛不丆.一上下丆世丛丌丆丞() != false)
        {
                if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒() > 1)
        {
            goto label_15;
        }
        
        }
        
        this.丗丟下丝丐丁丌丈东.且七丙丄丘一丄上不();
        return;
        label_15:
        if(this.七不丐丆专与丁下丄.isMine != false)
        {
                this.专丄一丕丛下不一七();
            this.CacheDiscreteTriggers();
            return;
        }
        
        this.丐且丂业一专丁丝七();
    }
    public void CacheDiscreteTriggers()
    {
        goto label_1;
        label_10:
        SynchronizedParameter val_1 = this.m_SynchronizeParameters.Item[0];
        if((val_1.SynchronizeType == 1) && (val_1.Type == 9))
        {
                if((this.业丏丑丆一一丑万丑.GetBool(name:  val_1.Name)) != false)
        {
                if(val_1.Type == 9)
        {
            goto label_8;
        }
        
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < this.m_SynchronizeParameters.Count)
        {
            goto label_10;
        }
        
        return;
        label_8:
        this.一丗丟上业丘丛丄丅.Add(item:  val_1.Name);
    }
    public bool DoesLayerSynchronizeTypeExist(int 丞丅下丙丏丘丟丁不)
    {
        .丞丅下丙丏丘丟丁不 = 丞丅下丙丏丘丟丁不;
        return (bool)((this.m_SynchronizeLayers.FindIndex(match:  new System.Predicate<SynchronizedLayer>(object:  new PhotonAnimatorView.与丟业一丈上丅上不(), method:  System.Boolean PhotonAnimatorView.与丟业一丈上丅上不::丐上下丐丏丁丆丙丄(PhotonAnimatorView.SynchronizedLayer 下丅丙一丂丗丅丝七)))) != 1) ? 1 : 0;
    }
    public bool DoesParameterSynchronizeTypeExist(string 丒丘丏上丙丟丑丕丈)
    {
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        return (bool)((this.m_SynchronizeParameters.FindIndex(match:  new System.Predicate<SynchronizedParameter>(object:  new PhotonAnimatorView.业丂七丏丟丕丌丂世(), method:  System.Boolean PhotonAnimatorView.业丂七丏丟丕丌丂世::丞不下丘丝丁与丗丗(PhotonAnimatorView.SynchronizedParameter 下丅丙一丂丗丅丝七)))) != 1) ? 1 : 0;
    }
    public System.Collections.Generic.List<PhotonAnimatorView.SynchronizedLayer> GetSynchronizedLayers()
    {
        return (System.Collections.Generic.List<SynchronizedLayer>)this.m_SynchronizeLayers;
    }
    public System.Collections.Generic.List<PhotonAnimatorView.SynchronizedParameter> GetSynchronizedParameters()
    {
        return (System.Collections.Generic.List<SynchronizedParameter>)this.m_SynchronizeParameters;
    }
    public PhotonAnimatorView.三且丑丕且三丄丟丅 GetLayerSynchronizeType(int 丞丅下丙丏丘丟丁不)
    {
        var val_5;
        PhotonAnimatorView.三且丑丕且三丄丟丅 val_6;
        val_5 = this;
        .丞丅下丙丏丘丟丁不 = 丞丅下丙丏丘丟丁不;
        int val_3 = this.m_SynchronizeLayers.FindIndex(match:  new System.Predicate<SynchronizedLayer>(object:  new PhotonAnimatorView.丌丐丝丐下上三丛丌(), method:  System.Boolean PhotonAnimatorView.丌丐丝丐下上三丛丌::七专七丐丄丅丟七丟(PhotonAnimatorView.SynchronizedLayer 下丅丙一丂丗丅丝七)));
        if(val_3 != 1)
        {
                val_5 = this.m_SynchronizeLayers.Item[val_3];
            val_6 = val_4.SynchronizeType;
            return (三且丑丕且三丄丟丅)val_6;
        }
        
        val_6 = 0;
        return (三且丑丕且三丄丟丅)val_6;
    }
    public PhotonAnimatorView.三且丑丕且三丄丟丅 GetParameterSynchronizeType(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        PhotonAnimatorView.三且丑丕且三丄丟丅 val_6;
        val_5 = this;
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        int val_3 = this.m_SynchronizeParameters.FindIndex(match:  new System.Predicate<SynchronizedParameter>(object:  new PhotonAnimatorView.上三且上丁业与与丑(), method:  System.Boolean PhotonAnimatorView.上三且上丁业与与丑::丅丗丏且丏三丂丒丁(PhotonAnimatorView.SynchronizedParameter 下丅丙一丂丗丅丝七)));
        if(val_3 != 1)
        {
                val_5 = this.m_SynchronizeParameters.Item[val_3];
            val_6 = val_4.SynchronizeType;
            return (三且丑丕且三丄丟丅)val_6;
        }
        
        val_6 = 0;
        return (三且丑丕且三丄丟丅)val_6;
    }
    public void SetLayerSynchronized(int 丞丅下丙丏丘丟丁不, PhotonAnimatorView.三且丑丕且三丄丟丅 丂丅丐上丒丕丝丅丁)
    {
        .丞丅下丙丏丘丟丁不 = 丞丅下丙丏丘丟丁不;
        if(UnityEngine.Application.isPlaying != false)
        {
                this.丅丐世丁丞丘不东丒 = true;
        }
        
        int val_4 = this.m_SynchronizeLayers.FindIndex(match:  new System.Predicate<SynchronizedLayer>(object:  new PhotonAnimatorView.丛东丟丅丙丗世丗不(), method:  System.Boolean PhotonAnimatorView.丛东丟丅丙丗世丗不::丅丐东且丑东业且丄(PhotonAnimatorView.SynchronizedLayer 下丅丙一丂丗丅丝七)));
        if(val_4 != 1)
        {
                SynchronizedLayer val_5 = this.m_SynchronizeLayers.Item[val_4];
            val_5.SynchronizeType = 丂丅丐上丒丕丝丅丁;
            return;
        }
        
        PhotonAnimatorView.SynchronizedLayer val_6 = new PhotonAnimatorView.SynchronizedLayer();
        if(val_6 != null)
        {
                .LayerIndex = (PhotonAnimatorView.丛东丟丅丙丗世丗不)[1152921535596526480].丞丅下丙丏丘丟丁不;
        }
        else
        {
                .LayerIndex = (PhotonAnimatorView.丛东丟丅丙丗世丗不)[1152921535596526480].丞丅下丙丏丘丟丁不;
        }
        
        .SynchronizeType = 丂丅丐上丒丕丝丅丁;
        this.m_SynchronizeLayers.Add(item:  val_6);
    }
    public void SetParameterSynchronized(string 丒丘丏上丙丟丑丕丈, PhotonAnimatorView.丟七丒一丛丟丂专下 丁丅丈丌丟世丗丗丟, PhotonAnimatorView.三且丑丕且三丄丟丅 丂丅丐上丒丕丝丅丁)
    {
        .丒丘丏上丙丟丑丕丈 = 丒丘丏上丙丟丑丕丈;
        if(UnityEngine.Application.isPlaying != false)
        {
                this.丅丐世丁丞丘不东丒 = true;
        }
        
        int val_4 = this.m_SynchronizeParameters.FindIndex(match:  new System.Predicate<SynchronizedParameter>(object:  new PhotonAnimatorView.丄丆丌丌丕丈丆丆业(), method:  System.Boolean PhotonAnimatorView.丄丆丌丌丕丈丆丆业::丝丒丕一七世丙一且(PhotonAnimatorView.SynchronizedParameter 下丅丙一丂丗丅丝七)));
        if(val_4 != 1)
        {
                SynchronizedParameter val_5 = this.m_SynchronizeParameters.Item[val_4];
            val_5.SynchronizeType = 丂丅丐上丒丕丝丅丁;
            return;
        }
        
        PhotonAnimatorView.SynchronizedParameter val_6 = new PhotonAnimatorView.SynchronizedParameter();
        if(val_6 != null)
        {
                .Name = (PhotonAnimatorView.丄丆丌丌丕丈丆丆业)[1152921535596718352].丒丘丏上丙丟丑丕丈;
            .Type = 丁丅丈丌丟世丗丗丟;
        }
        else
        {
                mem[24] = (PhotonAnimatorView.丄丆丌丌丕丈丆丆业)[1152921535596718352].丒丘丏上丙丟丑丕丈;
            mem[16] = 丁丅丈丌丟世丗丗丟;
        }
        
        .SynchronizeType = 丂丅丐上丒丕丝丅丁;
        this.m_SynchronizeParameters.Add(item:  val_6);
    }
    private void 专丄一丕丛下不一七()
    {
        var val_14;
        int val_15;
        var val_16;
        if(this.业丏丑丆一一丑万丑 == 0)
        {
                return;
        }
        
        val_14 = 0;
        goto label_4;
        label_13:
        SynchronizedLayer val_2 = this.m_SynchronizeLayers.Item[0];
        if(val_2.SynchronizeType == 2)
        {
                SynchronizedLayer val_3 = this.m_SynchronizeLayers.Item[0];
            val_15 = val_3.LayerIndex;
            this.丗丟下丝丐丁丌丈东.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.业丏丑丆一一丑万丑.GetLayerWeight(layerIndex:  val_15));
        }
        
        val_14 = 1;
        label_4:
        if(val_14 < this.m_SynchronizeLayers.Count)
        {
            goto label_13;
        }
        
        val_16 = 0;
        goto label_14;
        label_28:
        SynchronizedParameter val_6 = this.m_SynchronizeParameters.Item[0];
        if(val_6.SynchronizeType != 2)
        {
            goto label_18;
        }
        
        PhotonAnimatorView.丟七丒一丛丟丂专下 val_14 = val_6.Type;
        val_14 = val_14 - 1;
        if(val_14 > 8)
        {
            goto label_18;
        }
        
        var val_15 = 106024000 + ((val_6.Type - 1)) << 2;
        val_15 = val_15 + 106024000;
        goto (106024000 + ((val_6.Type - 1)) << 2 + 106024000);
        label_18:
        val_16 = 1;
        label_14:
        if(val_16 < this.m_SynchronizeParameters.Count)
        {
            goto label_28;
        }
    
    }
    private void 丐且丂业一专丁丝七()
    {
        var val_11;
        var val_12;
        var val_13;
        if(this.丗丟下丝丐丁丌丈东.丝七万东上丑业一丅() == false)
        {
                return;
        }
        
        val_11 = 0;
        goto label_3;
        label_12:
        SynchronizedLayer val_2 = this.m_SynchronizeLayers.Item[0];
        if(val_2.SynchronizeType == 2)
        {
                SynchronizedLayer val_3 = this.m_SynchronizeLayers.Item[0];
            val_12 = this.丗丟下丝丐丁丌丈东.与万三丘与专丛丄七();
            this.业丏丑丆一一丑万丑.SetLayerWeight(layerIndex:  val_3.LayerIndex, weight:  3.782474E-38f);
        }
        
        val_11 = 1;
        label_3:
        if(val_11 < this.m_SynchronizeLayers.Count)
        {
            goto label_12;
        }
        
        val_13 = 0;
        goto label_13;
        label_27:
        SynchronizedParameter val_6 = this.m_SynchronizeParameters.Item[0];
        if(val_6.SynchronizeType != 2)
        {
            goto label_23;
        }
        
        PhotonAnimatorView.丟七丒一丛丟丂专下 val_11 = val_6.Type;
        val_11 = val_11 - 1;
        if(val_11 > 8)
        {
            goto label_23;
        }
        
        var val_12 = 106024036 + ((val_6.Type - 1)) << 2;
        val_12 = val_12 + 106024036;
        goto (106024036 + ((val_6.Type - 1)) << 2 + 106024036);
        label_23:
        val_13 = 1;
        label_13:
        if(val_13 < this.m_SynchronizeParameters.Count)
        {
            goto label_27;
        }
    
    }
    private void 丛丑下丁一丁丐世丗(下丌丙丘丈丌世万专 东业丄丅丅且世七丄)
    {
        var val_13;
        int val_14;
        var val_15;
        val_13 = 0;
        goto label_1;
        label_10:
        SynchronizedLayer val_1 = this.m_SynchronizeLayers.Item[0];
        if(val_1.SynchronizeType == 1)
        {
                SynchronizedLayer val_2 = this.m_SynchronizeLayers.Item[0];
            val_14 = val_2.LayerIndex;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.业丏丑丆一一丑万丑.GetLayerWeight(layerIndex:  val_14));
        }
        
        val_13 = 1;
        label_1:
        if(val_13 < this.m_SynchronizeLayers.Count)
        {
            goto label_10;
        }
        
        val_15 = 0;
        goto label_11;
        label_25:
        SynchronizedParameter val_5 = this.m_SynchronizeParameters.Item[0];
        if(val_5.SynchronizeType != 1)
        {
            goto label_15;
        }
        
        PhotonAnimatorView.丟七丒一丛丟丂专下 val_13 = val_5.Type;
        val_13 = val_13 - 1;
        if(val_13 > 8)
        {
            goto label_15;
        }
        
        var val_14 = 106024072 + ((val_5.Type - 1)) << 2;
        val_14 = val_14 + 106024072;
        goto (106024072 + ((val_5.Type - 1)) << 2 + 106024072);
        label_15:
        val_15 = 1;
        label_11:
        if(val_15 < this.m_SynchronizeParameters.Count)
        {
            goto label_25;
        }
        
        this.一丗丟上业丘丛丄丅.Clear();
    }
    private void 丂丄丗丁一且东丆丈(下丌丙丘丈丌世万专 东业丄丅丅且世七丄)
    {
        var val_15;
        int val_16;
        var val_17;
        val_15 = 0;
        goto label_1;
        label_10:
        SynchronizedLayer val_1 = this.m_SynchronizeLayers.Item[0];
        if(val_1.SynchronizeType == 1)
        {
                SynchronizedLayer val_2 = this.m_SynchronizeLayers.Item[0];
            val_16 = val_2.LayerIndex;
            object val_3 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
            this.业丏丑丆一一丑万丑.SetLayerWeight(layerIndex:  val_16, weight:  3.782474E-38f);
        }
        
        val_15 = 1;
        label_1:
        if(val_15 < this.m_SynchronizeLayers.Count)
        {
            goto label_10;
        }
        
        val_17 = 0;
        goto label_11;
        label_41:
        SynchronizedParameter val_5 = this.m_SynchronizeParameters.Item[0];
        if(val_5.SynchronizeType != 1)
        {
            goto label_38;
        }
        
        PhotonAnimatorView.丟七丒一丛丟丂专下 val_15 = val_5.Type;
        val_15 = val_15 - 1;
        if(val_15 > 8)
        {
            goto label_38;
        }
        
        var val_16 = 106024108 + ((val_5.Type - 1)) << 2;
        val_16 = val_16 + 106024108;
        goto (106024108 + ((val_5.Type - 1)) << 2 + 106024108);
        label_38:
        val_17 = 1;
        label_11:
        if(val_17 < this.m_SynchronizeParameters.Count)
        {
            goto label_41;
        }
    
    }
    private void 丕东不丏丗不与丘丏(下丌丙丘丈丌世万专 东业丄丅丅且世七丄)
    {
        var val_11;
        var val_12;
        int val_3 = this.m_SynchronizeParameters.Count + this.m_SynchronizeLayers.Count;
        byte[] val_4 = new byte[0];
        val_11 = 0;
        goto label_3;
        label_9:
        SynchronizedLayer val_5 = this.m_SynchronizeLayers.Item[0];
        val_11 = 1;
        val_4[0] = val_5.SynchronizeType;
        label_3:
        if(val_11 < this.m_SynchronizeLayers.Count)
        {
            goto label_9;
        }
        
        val_12 = 0;
        goto label_10;
        label_17:
        SynchronizedParameter val_8 = this.m_SynchronizeParameters.Item[0];
        val_12 = 1;
        val_4[(long)this.m_SynchronizeLayers.Count + val_12] = val_8.SynchronizeType;
        label_10:
        if(val_12 < this.m_SynchronizeParameters.Count)
        {
            goto label_17;
        }
        
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_4);
    }
    private void 不万丄且丗丛三丏世(下丌丙丘丈丌世万专 东业丄丅丅且世七丄)
    {
        PhotonAnimatorView.三且丑丕且三丄丟丅 val_10;
        var val_11;
        var val_12;
        object val_1 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        if(val_1 != null)
        {
                if(val_1 != null)
        {
            goto label_3;
        }
        
        }
        
        label_3:
        val_10 = 1152921535596119504;
        val_11 = 0;
        goto label_4;
        label_10:
        SynchronizedLayer val_3 = this.m_SynchronizeLayers.Item[0];
        val_11 = 1;
        val_3.SynchronizeType = 64;
        label_4:
        if(val_11 < this.m_SynchronizeLayers.Count)
        {
            goto label_10;
        }
        
        val_12 = 0;
        goto label_11;
        label_18:
        SynchronizedParameter val_5 = this.m_SynchronizeParameters.Item[0];
        var val_8 = 0 + ((long)this.m_SynchronizeLayers.Count + val_12);
        val_10 = mem[(0 + (long)(int)((val_6 + val_12))) + 32];
        val_10 = (0 + (long)(int)((val_6 + val_12))) + 32;
        val_12 = 1;
        val_5.SynchronizeType = val_10;
        label_11:
        if(val_12 < this.m_SynchronizeParameters.Count)
        {
            goto label_18;
        }
    
    }
    public void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        if(this.业丏丑丆一一丑万丑 == 0)
        {
                return;
        }
        
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                if(this.丅丐世丁丞丘不东丒 != false)
        {
                this.丗丟下丝丐丁丌丈东.且七丙丄丘一丄上不();
            this.丕东不丏丗不与丘丏(东业丄丅丅且世七丄:  东业丄丅丅且世七丄);
            this.丅丐世丁丞丘不东丒 = false;
        }
        
            this.丗丟下丝丐丁丌丈东.丙业不丝丗丌丗世下(东业丄丅丅且世七丄:  东业丄丅丅且世七丄);
            this.丛丑下丁一丁丐世丗(东业丄丅丅且世七丄:  东业丄丅丅且世七丄);
            return;
        }
        
        if(东业丄丅丅且世七丄.丁专不丘丒丁丐上东() != null)
        {
                this.不万丄且丗丛三丏世(东业丄丅丅且世七丄:  东业丄丅丅且世七丄);
        }
        
        this.丗丟下丝丐丁丌丈东.丂东专丙丒丏且丛丁(东业丄丅丅且世七丄:  东业丄丅丅且世七丄);
        this.丂丄丗丁一且东丆丈(东业丄丅丅且世七丄:  东业丄丅丅且世七丄);
    }
    public PhotonAnimatorView()
    {
        this.ShowLayerWeightsInspector = true;
        this.ShowParameterInspector = true;
        this.m_SynchronizeParameters = new System.Collections.Generic.List<SynchronizedParameter>();
        this.m_SynchronizeLayers = new System.Collections.Generic.List<SynchronizedParameter>();
        this.丅丐世丁丞丘不东丒 = true;
        this.一丗丟上业丘丛丄丅 = new System.Collections.Generic.List<System.String>();
    }

}
