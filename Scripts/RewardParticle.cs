using UnityEngine;
internal class RewardParticle : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView itemView;
    private PGCompany.三东丏不丗世丅丌丄 丕丟丈丙丟丅丟丑七;
    private RewardParticlesReceiver 丘一一世下丟丏万世;
    private RewardParticlesSource.Settings 丒丄丅丟丞丅丄七丕;
    private UnityEngine.Vector3 丘丏丗万不七东丄丁;
    private float 丐且且东万一丌不丟;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, RewardParticlesReceiver 业丄丒丑一丙丛丆丕, RewardParticlesSource.Settings 与不丕丆丈不丙丟丛)
    {
        Settings val_6;
        Settings val_7;
        this.丕丟丈丙丟丅丟丑七 = 丈丄不七三万丄丁不;
        this.丘一一世下丟丏万世 = 业丄丒丑一丙丛丆丕;
        this.丒丄丅丟丞丅丄七丕 = 与不丕丆丈不丙丟丛;
        this.itemView.Setup(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this.丘丏丗万不七东丄丁 = val_2;
        mem[1152921538793704988] = val_2.y;
        mem[1152921538793704992] = val_2.z;
        val_6 = this.丒丄丅丟丞丅丄七丕;
        if(this.丒丄丅丟丞丅丄七丕 != null)
        {
            goto label_2;
        }
        
        val_6 = this.丒丄丅丟丞丅丄七丕;
        if(val_6 == null)
        {
            goto label_5;
        }
        
        label_2:
        float val_3 = UnityEngine.Random.Range(min:  -this.丒丄丅丟丞丅丄七丕.radius, max:  this.丒丄丅丟丞丅丄七丕.radius);
        val_3 = val_2.x + val_3;
        this.丘丏丗万不七东丄丁 = val_3;
        val_7 = this.丒丄丅丟丞丅丄七丕;
        if(this.丒丄丅丟丞丅丄七丕 != null)
        {
            goto label_4;
        }
        
        val_7 = this.丒丄丅丟丞丅丄七丕;
        if(val_7 == null)
        {
            goto label_5;
        }
        
        label_4:
        float val_4 = UnityEngine.Random.Range(min:  -this.丒丄丅丟丞丅丄七丕.radius, max:  this.丒丄丅丟丞丅丄七丕.radius);
        val_4 = S9 + val_4;
        mem[1152921538793704988] = val_4;
        this.丐且且东万一丌不丟 = this.丒丄丅丟丞丅丄七丕.moveDelay;
        this.gameObject.SetActive(value:  true);
        return;
        label_5:
    }
    private void Update()
    {
        if(this.丘一一世下丟丏万世 == 0)
        {
                return;
        }
        
        float val_15 = this.丐且且东万一丌不丟;
        val_15 = val_15 - UnityEngine.Time.unscaledDeltaTime;
        this.丐且且东万一丌不丟 = val_15;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Transform val_4 = this.transform;
        if(val_15 < 0)
        {
                UnityEngine.Vector3 val_5 = val_4.position;
            UnityEngine.Vector3 val_7 = this.丘一一世下丟丏万世.transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, target:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, maxDistanceDelta:  UnityEngine.Time.unscaledDeltaTime * this.丒丄丅丟丞丅丄七丕.particlesSpeed);
            val_3.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            return;
        }
        
        UnityEngine.Vector3 val_11 = val_4.localPosition;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = this.丘丏丗万不七东丄丁, y = V11.16B, z = V12.16B}, t:  UnityEngine.Time.unscaledDeltaTime * this.丒丄丅丟丞丅丄七丕.particlesSpeed);
        val_3.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
    }
    public RewardParticle()
    {
    
    }

}
