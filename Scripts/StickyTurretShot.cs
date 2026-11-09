using UnityEngine;
internal sealed class StickyTurretShot : PGBehaviour
{
    // Fields
    private UnityEngine.AudioClip shotClip;
    private UnityEngine.Transform shotPoint;
    private UnityEngine.GameObject[] gunFlashes;
    private UnityEngine.ParticleSystem gunParticle;
    private string rayName;
    private UnityEngine.AudioSource audioSource;
    
    // Methods
    internal void 丅丙业不丏丟丄丕丝(UnityEngine.Transform 丞下万上三丘上与专, float 业丏东三丄东且丈万, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, string 丆丈丅上丙业丌且丅, bool 丌且下丕下下丌万丞)
    {
        丅丙上七上一丐不下 val_18;
        float val_19;
        UnityEngine.ParticleSystem val_20;
        UnityEngine.Transform val_21;
        float val_22;
        UnityEngine.GameObject[] val_23;
        val_18 = 丛世一丟丞丁业丘丒;
        val_19 = 业丏东三丄东且丈万;
        val_20 = this;
        val_21 = this.shotPoint;
        if(val_21 == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.audioSource != 0)
        {
                this.audioSource.PlayOneShot(clip:  this.shotClip);
        }
        
        }
        
        UnityEngine.Vector3 val_4 = this.shotPoint.forward;
        val_21 = this.shotPoint;
        val_22 = val_4.y;
        UnityEngine.Vector3 val_5 = val_21.position;
        if(((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  100f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丂丂丟世专三不上丙())) != false) && (丌且下丕下下丌万丞 != false))
        {
                丅丙上七上一丐不下 val_8 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
            if(val_8 != null)
        {
                this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  val_8, 业丏东三丄东且丈万:  val_19, 丛世一丟丞丁业丘丒:  val_18, 丆丈丅上丙业丌且丅:  丆丈丅上丙业丌且丅);
        }
        
        }
        
        val_23 = this.gunFlashes;
        if((val_23 == null) || (this.gunFlashes.Length == 0))
        {
            goto label_17;
        }
        
        val_21 = 1152921505286238208;
        val_18 = 0;
        goto label_18;
        label_35:
        this.gunFlashes[0].SetActive(value:  true);
        UnityEngine.Vector3 val_10 = this.gunFlashes[0].transform.position;
        val_22 = val_10.z;
        UnityEngine.Vector3 val_12 = this.gunFlashes[0].transform.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_19 = 0.targetValue;
        UnityEngine.GameObject val_15 = WeaponManager.上不丝专丏丝丙丅丆(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_22}, 丗丟东丗丕世丛丌丗:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, 丛丄万三丂东丙丑东:  this.rayName, 不丅丛专丘丅专丘丕:  val_19);
        val_23 = this.gunFlashes;
        val_18 = 1;
        label_18:
        if(val_18 < this.gunFlashes.Length)
        {
            goto label_35;
        }
        
        label_17:
        if(this.gunParticle == 0)
        {
                return;
        }
        
        val_20 = this.gunParticle;
        val_20.Play(withChildren:  true);
    }
    protected void 三且丆丙丂丘丗丕丙(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕, float 业丏东三丄东且丈万, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, string 丆丈丅上丙业丌且丅)
    {
        var val_6;
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.position;
        val_6 = null;
        val_6 = null;
        var val_6 = 0;
        val_6 = val_6 + 1;
        丂丈丙且丈丗三丆丕.ApplyDamage(丞丈专下丈专业三丞:  业丏东三丄东且丈万, 丛世一丟丞丁业丘丒:  丛世一丟丞丁业丘丒, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丐丟丘世丁三丕专专:  8, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  丆丈丅上丙业丌且丅, 丒丈丐丐丗丐专丈丏:  GetComponent<PixelView>().viewID);
    }
    public StickyTurretShot()
    {
    
    }

}
