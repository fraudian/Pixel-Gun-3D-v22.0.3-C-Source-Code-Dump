using UnityEngine;
public class RoyaleMarkerRayController : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem rayParticle;
    private float 下丌丌丏万业与东丁;
    private UnityEngine.Color 丛不丘丅且专一与丝;
    private float 三下丛丌三上丁丁丞;
    private UnityEngine.ParticleSystem ringParticle;
    private float 业丞万丟丁东丘三丗;
    private UnityEngine.Color 丆万专丟下丙与丕丕;
    private float 丗与与与且丞丏丑丐;
    private static float 丞丏七业三与与丄三;
    private static float 丂一丂东丝七丙专丙;
    private static float 丕丝丅丂丁丟丆七七;
    private static float 丒丝丂丕丛丕一丂丂;
    
    // Methods
    private void Awake()
    {
        var val_6;
        var val_13;
        MainModule val_1 = this.rayParticle.main;
        MinMaxGradient val_2 = val_1.m_ParticleSystem.startColor;
        UnityEngine.Color val_7 = val_6.targetColor;
        this.下丌丌丏万业与东丁 = val_7.a;
        this.丛不丘丅且专一与丝 = val_7;
        mem[1152921538889392168] = val_7.g;
        mem[1152921538889392172] = val_7.b;
        mem[1152921538889392176] = val_7.a;
        MainModule val_8 = this.ringParticle.main;
        MinMaxGradient val_9 = val_8.m_ParticleSystem.startColor;
        UnityEngine.Color val_14 = val_13.targetColor;
        this.业丞万丟丁东丘三丗 = val_14.a;
        this.丆万专丟下丙与丕丕 = val_14;
        mem[1152921538889392200] = val_14.g;
        mem[1152921538889392204] = val_14.b;
        mem[1152921538889392208] = val_14.a;
    }
    private void 丘丅下丛东三丝丙丒(UnityEngine.ParticleSystem 丅丅丌丕世丙不丑丄, float 丝万丅世丏三东业丞, float 丕与丙丐上丅丘丂丅, float 丌丈丁丘丟下丕丒丌, ref float 一丄丞丂七丐与丙万, ref UnityEngine.Color 不丄丞丒丞丗丆丝丈, float 丝丄业一丁东与专丏)
    {
        var val_12;
        float val_20;
        float val_21;
        float val_22;
        val_20 = 丌丈丁丘丟下丕丒丌 * 丌丈丁丘丟下丕丒丌;
        val_21 = 0f;
        if(val_20 <= 丝万丅世丏三东业丞)
        {
                float val_1 = 丕与丙丐上丅丘丂丅 * 丕与丙丐上丅丘丂丅;
            if(val_1 > 丝万丅世丏三东业丞)
        {
                if(val_1 >= _TYPE_MAX_)
        {
                val_22 = 丝万丅世丏三东业丞;
        }
        
            val_22 = val_22 - 丌丈丁丘丟下丕丒丌;
            val_22 = val_22 / (丕与丙丐上丅丘丂丅 - 丌丈丁丘丟下丕丒丌);
            val_20 = 0f;
            val_21 = UnityEngine.Mathf.Clamp(value:  val_22, min:  val_20, max:  1f);
        }
        else
        {
                val_21 = 1f;
        }
        
        }
        
        if(val_21 != 一丄丞丂七丐与丙万)
        {
                UnityEngine.GameObject val_4 = 丅丅丌丕世丙不丑丄.gameObject;
            if(val_21 == 0f)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
            if(丅丅丌丕世丙不丑丄 != null)
        {
                MainModule val_5 = 丅丅丌丕世丙不丑丄.main;
        }
        else
        {
                MainModule val_6 = 0.main;
        }
        
            MainModule val_7 = 丅丅丌丕世丙不丑丄.main;
            MinMaxGradient val_8 = val_7.m_ParticleSystem.startColor;
            丝丄业一丁东与专丏 = val_21 * 丝丄业一丁东与专丏;
            不丄丞丒丞丗丆丝丈.a = 丝丄业一丁东与专丏;
            val_12.targetColor = new UnityEngine.Color() {r = 不丄丞丒丞丗丆丝丈.r, g = 不丄丞丒丞丗丆丝丈.g, b = 不丄丞丒丞丗丆丝丈.b, a = 丝丄业一丁东与专丏};
            int val_13 = val_6.m_ParticleSystem.maxParticles;
            Particle[] val_14 = new Particle[0];
            int val_15 = 丅丅丌丕世丙不丑丄.GetParticles(particles:  val_14);
            if(val_14 != null)
        {
                if(val_15 >= 1)
        {
                var val_19 = 0;
            do
        {
            UnityEngine.Color32 val_16 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 不丄丞丒丞丗丆丝丈.r, g = 不丄丞丒丞丗丆丝丈.g, b = 不丄丞丒丞丗丆丝丈.b, a = 不丄丞丒丞丗丆丝丈.a});
            val_14[32].area = val_16.r & 4294967295;
            val_19 = val_19 + 1;
        }
        while(val_15 != val_19);
        
        }
        
            丅丅丌丕世丙不丑丄.SetParticles(particles:  val_14, size:  val_15);
        }
        
        }
        
        }
        
        一丄丞丂七丐与丙万 = val_21;
    }
    private void Update()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_628 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = this.transform.position;
        val_19 = null;
        val_19 = null;
        UnityEngine.Vector3 val_8 = transform.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_20 = null;
        val_20 = null;
        丘丅下丛东三丝丙丒(丅丅丌丕世丙不丑丄:  this.rayParticle, 丝万丅世丏三东业丞:  val_9.x, 丕与丙丐上丅丘丂丅:  RoyaleMarkerRayController.丞丏七业三与与丄三, 丌丈丁丘丟下丕丒丌:  RoyaleMarkerRayController.丂一丂东丝七丙专丙, 一丄丞丂七丐与丙万: ref  this.三下丛丌三上丁丁丞, 不丄丞丒丞丗丆丝丈: ref  new UnityEngine.Color() {r = this.丛不丘丅且专一与丝, g = this.丛不丘丅且专一与丝, b = this.丛不丘丅且专一与丝, a = this.丛不丘丅且专一与丝}, 丝丄业一丁东与专丏:  this.下丌丌丏万业与东丁);
        val_21 = null;
        val_21 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ringParticle.gameObject, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_22 = null;
        val_22 = null;
        丘丅下丛东三丝丙丒(丅丅丌丕世丙不丑丄:  this.ringParticle, 丝万丅世丏三东业丞:  val_12.x, 丕与丙丐上丅丘丂丅:  RoyaleMarkerRayController.丕丝丅丂丁丟丆七七, 丌丈丁丘丟下丕丒丌:  RoyaleMarkerRayController.丒丝丂丕丛丕一丂丂, 一丄丞丂七丐与丙万: ref  this.丗与与与且丞丏丑丐, 不丄丞丒丞丗丆丝丈: ref  new UnityEngine.Color() {r = this.丆万专丟下丙与丕丕, g = this.丆万专丟下丙与丕丕, b = this.丆万专丟下丙与丕丕, a = this.丆万专丟下丙与丕丕}, 丝丄业一丁东与专丏:  this.业丞万丟丁东丘三丗);
    }
    public RoyaleMarkerRayController()
    {
        this.三下丛丌三上丁丁丞 = 1f;
        this.丗与与与且丞丏丑丐 = 1f;
    }
    private static RoyaleMarkerRayController()
    {
        RoyaleMarkerRayController.丞丏七业三与与丄三 = 50f;
        RoyaleMarkerRayController.丂一丂东丝七丙专丙 = 20f;
        RoyaleMarkerRayController.丕丝丅丂丁丟丆七七 = 100f;
        RoyaleMarkerRayController.丒丝丂丕丛丕一丂丂 = 80f;
    }

}
