using UnityEngine;
internal sealed class PlantedBombExplosion : MonoBehaviour
{
    // Fields
    private UnityEngine.AudioSource bombExplosionSound;
    private UnityEngine.ParticleSystem effect;
    private UnityEngine.Vector2 丆丘丈丆丟丆丄丘业;
    private float 东丂上东丅与下丙丈;
    private const float 丙东丌业与下业丕与 = 0.9;
    private const float 丌丟业丈下丕丏丟丄 = 8;
    
    // Methods
    internal void 丆丌且丙丝不万丂丆()
    {
        if(this.bombExplosionSound != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.bombExplosionSound.Play();
        }
        
        }
        
        if(this.effect != 0)
        {
                this.effect.Play();
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.丆丘丈丆丟丆丄丘业 = val_4;
        mem[1152921538605592620] = val_4.y;
        this.东丂上东丅与下丙丈 = 0f;
    }
    private void Update()
    {
        float val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_16 = 0.9f;
        if(this.东丂上东丅与下丙丈 >= 0)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.东丂上东丅与下丙丈 + val_1;
        this.东丂上东丅与下丙丈 = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_628 == 0)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456) == 0)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        丅丙上七上一丐不下 val_7 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  transform);
        val_22 = 0;
        if( == 0)
        {
                return;
        }
        
        if(IsDead() == true)
        {
                return;
        }
        
        float val_17 = this.东丂上东丅与下丙丈;
        float val_18 = 8f;
        val_17 = val_16 - val_17;
        val_17 = val_17 / val_16;
        val_18 = val_17 * val_18;
        val_16 = val_17 * val_18;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  (float)UnityEngine.Random.Range(min:  0, max:  1), y:  (float)UnityEngine.Random.Range(min:  0, max:  1));
        UnityEngine.Vector2 val_13 = val_12.x.normalized;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, d:  val_16);
        val_23 = null;
        val_16 = val_14.x;
        val_23 = null;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_16, y = val_14.y}, b:  new UnityEngine.Vector2() {x = this.丆丘丈丆丟丆丄丘业});
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丗丂东丌丙一丕业丙(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, 万业丒丞丅一丂丈业:  false);
        this.丆丘丈丆丟丆丄丘业 = val_14;
        mem[1152921538605729196] = val_14.y;
    }
    private float 不丞丏丅三三丅丅业(float 七丝东丛东丝且丆不, float 丙业与丙丗丝不丈东)
    {
        七丝东丛东丝且丆不 = 七丝东丛东丝且丆不 * 丙业与丙丗丝不丈东;
        七丝东丛东丝且丆不 = 七丝东丛东丝且丆不 * 丙业与丙丗丝不丈东;
        return (float)七丝东丛东丝且丆不;
    }
    public PlantedBombExplosion()
    {
        this.东丂上东丅与下丙丈 = 1f;
    }

}
