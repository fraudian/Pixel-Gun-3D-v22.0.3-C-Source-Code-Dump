using UnityEngine;
public class GEGuiMeshApplyer : GEGuiApplyer
{
    // Fields
    private UnityEngine.SkinnedMeshRenderer skinedRenderer;
    private UnityEngine.MeshFilter meshFilter;
    private UnityEngine.Mesh 七丟下丏丈万丗丗丒;
    private bool 专丞丅丅丐丞万专与;
    
    // Properties
    private UnityEngine.Mesh 丈丒不专上丘业丌丞 { get; set; }
    
    // Methods
    private UnityEngine.Mesh 丛丕丙丒丟东万与丘()
    {
        if(this.skinedRenderer != 0)
        {
                if(this.skinedRenderer != null)
        {
                return this.skinedRenderer.sharedMesh;
        }
        
            return this.skinedRenderer.sharedMesh;
        }
        
        if(this.meshFilter == 0)
        {
                return 0;
        }
        
        if(this.meshFilter != null)
        {
                return this.meshFilter.sharedMesh;
        }
        
        return this.meshFilter.sharedMesh;
    }
    private void 上不丐丏丞不丛丗不(UnityEngine.Mesh 丙业与丙丗丝不丈东)
    {
        if(this.skinedRenderer != 0)
        {
                this.skinedRenderer.sharedMesh = 丙业与丙丗丝不丈东;
            return;
        }
        
        if(this.meshFilter == 0)
        {
                return;
        }
        
        this.meshFilter.sharedMesh = 丙业与丙丗丝不丈东;
    }
    internal override void 丘上丐世丆丑且丞丒()
    {
        this.丘上丐世丆丑且丞丒();
        if(this.skinedRenderer == 0)
        {
                this.skinedRenderer = this.GetComponent<UnityEngine.SkinnedMeshRenderer>();
        }
        
        if(this.meshFilter != 0)
        {
                return;
        }
        
        this.meshFilter = this.GetComponent<UnityEngine.MeshFilter>();
    }
    internal override bool 七丆业丗不业丙丏三()
    {
        var val_3;
        if(this.七丆业丗不业丙丏三() != false)
        {
                if(this.skinedRenderer == 0)
        {
                return UnityEngine.Object.op_Inequality(x:  this.meshFilter, y:  0);
        }
        
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    internal override bool 三业丒丑丂三丕上丛()
    {
        UnityEngine.Mesh val_15;
        var val_16;
        if((this & 1) == 0)
        {
            goto label_1;
        }
        
        mem[1152921537428908304] = true;
        mem[1152921537428908352] = this.Context;
        if(this.专丞丅丅丐丞万专与 != true)
        {
                this.七丟下丏丈万丗丗丒 = this.丛丕丙丒丟东万与丘();
            this.专丞丅丅丐丞万专与 = true;
        }
        
        if(this.丛丕丙丒丟东万与丘() != 0)
        {
                if((System.String.op_Inequality(a:  this.丛丕丙丒丟东万与丘().name, b:  GameEventsHalper.丏丟世丄七三丒丟上(丞丕丟丁且丛三丕不:  this.Context.业上丙丞丐丄丆丅七(), 丒丘丏上丙丟丑丕丈:  0))) == false)
        {
            goto label_8;
        }
        
        }
        
        UnityEngine.Mesh val_13 = GameEventsHalper.丙丌丘丅丑与与丂万<UnityEngine.Mesh>(丞丕丟丁且丛三丕不:  this.Context.业上丙丞丐丄丆丅七(), 丒丘丏上丙丟丑丕丈:  0, 下上丕丌业丁丙上丐:  false);
        if(val_13 == 0)
        {
            goto label_12;
        }
        
        val_15 = val_13;
        goto label_13;
        label_1:
        val_16 = 0;
        return (bool)val_16;
        label_12:
        val_15 = this.七丟下丏丈万丗丗丒;
        label_13:
        this.上不丐丏丞不丛丗不(丙业与丙丗丝不丈东:  val_15);
        label_8:
        val_16 = 1;
        return (bool)val_16;
    }
    public GEGuiMeshApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
