using UnityEngine;
internal sealed class TurretController_ChristmasTree : TurretController
{
    // Fields
    public UnityEngine.Transform tower;
    public float damageRadius;
    public float damageHeight;
    public float towerRotationSpeed;
    public float hitTime;
    public float hitChance;
    public UnityEngine.GameObject gunFlashes;
    public UnityEngine.GameObject workSound;
    public UnityEngine.AudioClip shotClip;
    private float 且丝一丈丟下丞丅与;
    
    // Methods
    protected override void 下专专专丄世丗且丐()
    {
        this.下专专专丄世丗且丐();
        this.gunFlashes.SetActive(value:  (W21 != 0) ? 1 : 0);
        if(this.workSound != 0)
        {
                this.workSound.SetActive(value:  与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗());
        }
        
        UnityEngine.Quaternion val_7 = this.tower.localRotation;
        val_7.z = val_7.z - (UnityEngine.Time.deltaTime * this.towerRotationSpeed);
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.tower.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
    }
    private void 业丑下与丂丝万业丆()
    {
        var val_16;
        var val_17;
        var val_19;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  X21, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  false).世且一丄且上丄不一();
        label_24:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        T val_6 = val_2.Current;
        if(this.hitChance > ((float)UnityEngine.Random.Range(min:  0, max:  100)))
        {
            goto label_24;
        }
        
        UnityEngine.Vector3 val_9 = val_6.transform.position;
        UnityEngine.Vector3 val_11 = this.transform.position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        if((val_12.y < 0) || (val_12.y > this.damageHeight))
        {
            goto label_24;
        }
        
        float val_18 = this.damageRadius;
        val_12.x = val_12.x * val_12.x;
        val_12.z = val_12.z * val_12.z;
        val_12.x = val_12.x + val_12.z;
        val_18 = val_18 * val_18;
        if(val_12.x > val_18)
        {
            goto label_24;
        }
        
        this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_6));
        goto label_24;
        label_7:
        val_16 = 0;
        val_17 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_2.Dispose();
        }
        
        val_19 = null;
        val_19 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
            this.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            return;
        }
        
        this.世且丂丕丐丝丐丐且();
    }
    protected override void 丅丙业不丏丟丄丕丝()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.shotClip);
    }
    public TurretController_ChristmasTree()
    {
        this.hitChance = 10f;
        this.damageRadius = ;
        this.damageHeight = ;
        this.towerRotationSpeed = 900f;
        this.hitTime = 0.1f;
    }

}
