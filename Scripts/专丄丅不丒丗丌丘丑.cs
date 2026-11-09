using UnityEngine;
public class 不下不丏三上万万丗.专丄丅不丒丗丌丘丑
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Vector3> 丗丞不丞业丑七且丗;
    private System.Collections.Generic.List<UnityEngine.Vector2> 下万上下丁丘丆丌丂;
    private System.Collections.Generic.List<UnityEngine.Vector2> 丑丛丆三丑丅三三丝;
    private System.Collections.Generic.List<UnityEngine.Vector2> 专丘丟东丈与下丗丑;
    private System.Collections.Generic.List<UnityEngine.Vector2> 上三不东丏上业且一;
    private System.Collections.Generic.List<UnityEngine.Vector3> 七丛丛丁业七丝丌丄;
    private System.Collections.Generic.List<UnityEngine.Vector4> 丗丑下丌与不丗万丝;
    private System.Collections.Generic.List<UnityEngine.Color32> 丅丏东三丆丙且业专;
    private System.Collections.Generic.List<UnityEngine.BoneWeight> 七下丞丁一丁丏业丒;
    
    // Methods
    public 不下不丏三上万万丗.专丄丅不丒丗丌丘丑()
    {
        this.丗丞不丞业丑七且丗 = new System.Collections.Generic.List<UnityEngine.Vector3>();
    }
    public 不下不丏三上万万丗.专丄丅不丒丗丌丘丑(UnityEngine.Mesh 不与丌丏不丘不丛丁)
    {
        if(不与丌丏不丘不丛丁 != null)
        {
                this.丗丞不丞业丑七且丗 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector3>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.vertices);
        }
        else
        {
                this.丗丞不丞业丑七且丗 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector3>(丝丐不东丑不且丏丌:  0.vertices);
        }
        
        this.下万上下丁丘丆丌丂 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector2>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.uv);
        if(不与丌丏不丘不丛丁 != null)
        {
                this.丑丛丆三丑丅三三丝 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector2>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.uv2);
        }
        else
        {
                this.丑丛丆三丑丅三三丝 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector2>(丝丐不东丑不且丏丌:  0.uv2);
        }
        
        this.专丘丟东丈与下丗丑 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector2>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.uv3);
        if(不与丌丏不丘不丛丁 != null)
        {
                this.上三不东丏上业且一 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector2>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.uv4);
        }
        else
        {
                this.上三不东丏上业且一 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector2>(丝丐不东丑不且丏丌:  0.uv4);
        }
        
        this.七丛丛丁业七丝丌丄 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector3>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.normals);
        if(不与丌丏不丘不丛丁 != null)
        {
                this.丗丑下丌与不丗万丝 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector4>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.tangents);
        }
        else
        {
                this.丗丑下丌与不丗万丝 = this.丆丐世下丁丑丞丟丈<UnityEngine.Vector4>(丝丐不东丑不且丏丌:  0.tangents);
        }
        
        this.丅丏东三丆丙且业专 = this.丆丐世下丁丑丞丟丈<UnityEngine.Color32>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.colors32);
        this.七下丞丁一丁丏业丒 = this.丆丐世下丁丑丞丟丈<UnityEngine.BoneWeight>(丝丐不东丑不且丏丌:  不与丌丏不丘不丛丁.boneWeights);
    }
    private System.Collections.Generic.List<T> 丆丐世下丁丑丞丟丈<T>(T[] 丝丐不东丑不且丏丌)
    {
        var val_1;
        if((丝丐不东丑不且丏丌 != null) && (丝丐不东丑不且丏丌.Length != 0))
        {
                val_1 = __RuntimeMethodHiddenParam + 48;
            return (System.Collections.Generic.List<T>)val_1;
        }
        
        val_1 = 0;
        return (System.Collections.Generic.List<T>)val_1;
    }
    private void 丕东丞业丗三丅丗万<T>(ref System.Collections.Generic.List<T> 丂丙丐不丄专上丅丒, System.Collections.Generic.List<T> 丝丐不东丑不且丏丌, int 丌丑丐丞丞丅专与丒)
    {
        var val_8;
        var val_9;
        System.Collections.Generic.List<T> val_10;
        val_8 = __RuntimeMethodHiddenParam;
        val_9 = 丝丐不东丑不且丏丌;
        if(val_9 == null)
        {
                return;
        }
        
        val_10 = 丂丙丐不丄专上丅丒;
        if(val_10 == null)
        {
                val_10 = __RuntimeMethodHiddenParam + 48;
            丂丙丐不丄专上丅丒 = val_10;
        }
        
        val_8 = ???;
        val_9 = ???;
        goto __RuntimeMethodHiddenParam + 48 + 24;
    }
    public int 业丏丗丐丂业东丂丗(MTAssets.SkinnedMeshCombiner.不下不丏三上万万丗.专丄丅不丒丗丌丘丑 丏丌下七丁丑东丑丗, int 丌丑丐丞丞丅专与丒)
    {
        System.Collections.Generic.List<UnityEngine.Vector3> val_2 = this.丗丞不丞业丑七且丗;
        this.丕东丞业丗三丅丗万<UnityEngine.Vector3>(丂丙丐不丄专上丅丒: ref  val_2, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.丗丞不丞业丑七且丗, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        this.丕东丞业丗三丅丗万<UnityEngine.Vector2>(丂丙丐不丄专上丅丒: ref  this.下万上下丁丘丆丌丂, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.下万上下丁丘丆丌丂, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        this.丕东丞业丗三丅丗万<UnityEngine.Vector2>(丂丙丐不丄专上丅丒: ref  this.丑丛丆三丑丅三三丝, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.丑丛丆三丑丅三三丝, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        this.丕东丞业丗三丅丗万<UnityEngine.Vector2>(丂丙丐不丄专上丅丒: ref  this.专丘丟东丈与下丗丑, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.专丘丟东丈与下丗丑, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        this.丕东丞业丗三丅丗万<UnityEngine.Vector2>(丂丙丐不丄专上丅丒: ref  this.上三不东丏上业且一, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.上三不东丏上业且一, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        this.丕东丞业丗三丅丗万<UnityEngine.Vector3>(丂丙丐不丄专上丅丒: ref  this.七丛丛丁业七丝丌丄, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.七丛丛丁业七丝丌丄, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        this.丕东丞业丗三丅丗万<UnityEngine.Vector4>(丂丙丐不丄专上丅丒: ref  this.丗丑下丌与不丗万丝, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.丗丑下丌与不丗万丝, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        this.丕东丞业丗三丅丗万<UnityEngine.Color32>(丂丙丐不丄专上丅丒: ref  this.丅丏东三丆丙且业专, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.丅丏东三丆丙且业专, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        this.丕东丞业丗三丅丗万<UnityEngine.BoneWeight>(丂丙丐不丄专上丅丒: ref  this.七下丞丁一丁丏业丒, 丝丐不东丑不且丏丌:  丏丌下七丁丑东丑丗.七下丞丁一丁丏业丒, 丌丑丐丞丞丅专与丒:  丌丑丐丞丞丅专与丒);
        return (int)val_2.Count;
    }
    public void 世万丗专下丘丐业丐(UnityEngine.Mesh 丟丂万业上丄三丘丆)
    {
        if(this.丗丞不丞业丑七且丗.Count >= 65536)
        {
                丟丂万业上丄三丘丆.indexFormat = 1;
        }
        
        丟丂万业上丄三丘丆.SetVertices(inVertices:  this.丗丞不丞业丑七且丗);
        if(this.下万上下丁丘丆丌丂 != null)
        {
                丟丂万业上丄三丘丆.SetUVs(channel:  0, uvs:  this.下万上下丁丘丆丌丂);
        }
        
        if(this.丑丛丆三丑丅三三丝 != null)
        {
                丟丂万业上丄三丘丆.SetUVs(channel:  1, uvs:  this.丑丛丆三丑丅三三丝);
        }
        
        if(this.专丘丟东丈与下丗丑 != null)
        {
                丟丂万业上丄三丘丆.SetUVs(channel:  2, uvs:  this.专丘丟东丈与下丗丑);
        }
        
        if(this.上三不东丏上业且一 != null)
        {
                丟丂万业上丄三丘丆.SetUVs(channel:  3, uvs:  this.上三不东丏上业且一);
        }
        
        if(this.七丛丛丁业七丝丌丄 != null)
        {
                丟丂万业上丄三丘丆.SetNormals(inNormals:  this.七丛丛丁业七丝丌丄);
        }
        
        if(this.丗丑下丌与不丗万丝 != null)
        {
                丟丂万业上丄三丘丆.SetTangents(inTangents:  this.丗丑下丌与不丗万丝);
        }
        
        if(this.丅丏东三丆丙且业专 != null)
        {
                丟丂万业上丄三丘丆.SetColors(inColors:  this.丅丏东三丆丙且业专);
        }
        
        if(this.七下丞丁一丁丏业丒 == null)
        {
                return;
        }
        
        丟丂万业上丄三丘丆.boneWeights = this.七下丞丁一丁丏业丒.ToArray();
    }

}
