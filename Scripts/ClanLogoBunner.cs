using UnityEngine;
internal class ClanLogoBunner : PGBehaviour
{
    // Fields
    internal UnityEngine.Material materialForSet;
    internal UnityEngine.TextMesh textMesh;
    internal TextMeshBounds textMeshBounds;
    internal UnityEngine.Transform pointForCalculateDistance;
    internal float distanceForShow;
    internal bool NeedCalculateDistance;
    private UITweener[] 丁不专七丆丆丝丑且;
    private UnityEngine.Transform 专丟丟丝东丗上丄丒;
    
    // Methods
    private void Awake()
    {
        this.丁不专七丆丆丝丑且 = this.GetComponentsInChildren<UITweener>(includeInactive:  true);
    }
    internal void 丈且东丑丂且万丒丅(System.ValueTuple<string, UnityEngine.Texture2D> 丞七业上丏下三专丌)
    {
        if(this.materialForSet == 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        this.materialForSet.mainTexture = X2;
        this.textMeshBounds.Text = 丐丄七丙丁丆丁专丏.丂丞世丐丌丑丕下三(丕丗丘丑丛与丑业丒:  万三丟丞业万丕丐丌.丏丙专丞丗丐下专东(下业七不丑丂丏丟东:  丞七业上丏下三专丌.Item2));
    }
    private void LateUpdate()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(this.专丟丟丝东丗上丄丒 != 0)
        {
            goto label_3;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_19;
        }
        
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_19;
        }
        
        val_11 = null;
        val_11 = null;
        this.专丟丟丝东丗上丄丒 = null;
        goto label_19;
        label_3:
        if(this.NeedCalculateDistance == false)
        {
            goto label_25;
        }
        
        UnityEngine.Vector3 val_4 = this.专丟丟丝东丗上丄丒.position;
        UnityEngine.Vector3 val_5 = this.pointForCalculateDistance.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) <= this.distanceForShow)
        {
            goto label_25;
        }
        
        label_19:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.textMesh.gameObject, 丏业丟一东丂东丘丛:  false);
        return;
        label_25:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.textMesh.gameObject, 丏业丟一东丂东丘丛:  true);
        val_12 = 0;
        goto label_32;
        label_37:
        this.丁不专七丆丆丝丑且[0].Play(且丒且丐丌东专三丁:  true);
        val_12 = 1;
        label_32:
        if(val_12 < this.丁不专七丆丆丝丑且.Length)
        {
            goto label_37;
        }
    
    }
    public ClanLogoBunner()
    {
        this.distanceForShow = 4f;
        this.NeedCalculateDistance = true;
    }

}
