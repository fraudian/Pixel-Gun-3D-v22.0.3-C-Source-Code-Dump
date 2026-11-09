using UnityEngine;
internal class RewardParticlesSource : PGBehaviour
{
    // Fields
    private static System.Action<RewardParticlesSource> 丞下与业东东丏丒丆;
    private static System.Action<RewardParticlesSource> 上上专专三丏不丑丈;
    private static System.Action<RewardParticlesSource> 丒不丕与丞丄丆专丑;
    private static System.Action<RewardParticlesSource> 丈丒丄万丘且且丅丏;
    private static System.Action<RewardParticlesSource> 丌业不万业下丕丟七;
    internal SimpleTweenePlayer playOnEmmit;
    internal PGPlaySound soundOnPlay;
    private RewardParticlesReceiver 丘一一世下丟丏万世;
    private PGCompany.三东丏不丗世丅丌丄 丕丟丈丙丟丅丟丑七;
    private MiniPoolMonoBehaviour particlesPool;
    private UnityEngine.GameObject countHolder;
    private UILabel countLabel;
    private float showCountTime;
    private RewardParticlesSource.Settings 丒丄丅丟丞丅丄七丕;
    private System.Collections.Generic.List<RewardParticle> 下丟丏丘不丄丅丒七;
    private int 丏丌不丌与丘丆上业;
    private UnityEngine.Coroutine 丈专丛丞万世丕丞丄;
    private int 世丁东业丆丙丌丝丆;
    private float 丘不不专下丒世丙不;
    private UnityEngine.Coroutine 丏丗业丘丒丛丝丐丟;
    
    // Properties
    internal RewardParticlesReceiver 业丞丈与丏丆丐万且 { get; }
    internal PGCompany.三东丏不丗世丅丌丄 三东丏不丗世丅丌丄 { get; }
    
    // Methods
    internal static void 丞丁上丐丁不丆丙与(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  RewardParticlesSource.丞下与业东东丏丒丆, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丞上业丆丏世丟一世(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  RewardParticlesSource.丞下与业东东丏丒丆, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 一下业丙七丕业丁丘(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  RewardParticlesSource.上上专专三丏不丑丈, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(RewardParticlesSource.上上专专三丏不丑丈 != 1152921505250938888);
    
    }
    internal static void 上丑世丛业丗丟一丙(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  RewardParticlesSource.上上专专三丏不丑丈, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(RewardParticlesSource.上上专专三丏不丑丈 != 1152921505250938888);
    
    }
    internal static void 丕丒丞与丆七丛丞丟(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  RewardParticlesSource.丒不丕与丞丄丆专丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(RewardParticlesSource.丒不丕与丞丄丆专丑 != 1152921505250938896);
    
    }
    internal static void 三丈万丏世丄丟上下(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  RewardParticlesSource.丒不丕与丞丄丆专丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(RewardParticlesSource.丒不丕与丞丄丆专丑 != 1152921505250938896);
    
    }
    internal static void 丄与与丐不万丅丗丝(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  RewardParticlesSource.丈丒丄万丘且且丅丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(RewardParticlesSource.丈丒丄万丘且且丅丏 != 1152921505250938904);
    
    }
    internal static void 不丛丅上与丏丙丒丄(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  RewardParticlesSource.丈丒丄万丘且且丅丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(RewardParticlesSource.丈丒丄万丘且且丅丏 != 1152921505250938904);
    
    }
    internal static void 丛丙丟下东上丗丏丝(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  RewardParticlesSource.丌业不万业下丕丟七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(RewardParticlesSource.丌业不万业下丕丟七 != 1152921505250938912);
    
    }
    internal static void 丛万丁七丌丛丛不专(System.Action<RewardParticlesSource> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  RewardParticlesSource.丌业不万业下丕丟七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(RewardParticlesSource.丌业不万业下丕丟七 != 1152921505250938912);
    
    }
    internal RewardParticlesReceiver 丗下丙丈丅丝丘东丏()
    {
        return (RewardParticlesReceiver)this.丘一一世下丟丏万世;
    }
    internal PGCompany.三东丏不丗世丅丌丄 丝上三丌丙七三七丏()
    {
        return (PGCompany.三东丏不丗世丅丌丄)this.丕丟丈丙丟丅丟丑七;
    }
    private void OnDisable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countHolder, 丏业丟一东丂东丘丛:  false);
        this.丅丂东丐丌下丟不专();
        this.丂丌丄不丆丒丝丅万();
    }
    internal void 三且世三丂七丐一丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, RewardParticlesReceiver 业丄丒丑一丙丛丆丕, RewardParticlesSource.Settings 与不丕丆丈不丙丟丛)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countHolder, 丏业丟一东丂东丘丛:  false);
        this.丘一一世下丟丏万世 = 业丄丒丑一丙丛丆丕;
        this.丕丟丈丙丟丅丟丑七 = 丈丄不七三万丄丁不;
        this.丒丄丅丟丞丅丄七丕 = 与不丕丆丈不丙丟丛;
        if(丈丄不七三万丄丁不 == null)
        {
                return;
        }
        
        if(业丄丒丑一丙丛丆丕 == 0)
        {
                return;
        }
        
        if(this.丒丄丅丟丞丅丄七丕 == null)
        {
                return;
        }
        
        this.丈丒丟东丈七七七七();
        if(this.soundOnPlay == null)
        {
                return;
        }
        
        this.soundOnPlay.三且世三丂七丐一丟(丌丏丂与丂三丐一下:  0);
    }
    private void 丐丛上三丛丌七丐东()
    {
        RewardParticle val_1 = this.particlesPool.Get<RewardParticle>();
        this.下丟丏丘不丄丅丒七.Add(item:  val_1);
        UnityEngine.Vector3 val_4 = this.transform.position;
        val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        val_1.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  this.丕丟丈丙丟丅丟丑七, 业丄丒丑一丙丛丆丕:  this.丘一一世下丟丏万世, 与不丕丆丈不丙丟丛:  this.丒丄丅丟丞丅丄七丕);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  true);
        if(this.playOnEmmit != null)
        {
                this.playOnEmmit.Play();
        }
        
        if(RewardParticlesSource.上上专专三丏不丑丈 == null)
        {
                return;
        }
        
        RewardParticlesSource.上上专专三丏不丑丈.Invoke(obj:  this);
    }
    private void 丈丒丟东丈七七七七()
    {
        this.丅丂东丐丌下丟不专();
        this.丈专丛丞万世丕丞丄 = this.StartCoroutine(routine:  this.下丗不丞丄业与世下());
        this.世一业与丟不丗三七();
    }
    private void 丅丂东丐丌下丟不专()
    {
        if(this.丏丗业丘丒丛丝丐丟 != null)
        {
                this.StopCoroutine(routine:  this.丏丗业丘丒丛丝丐丟);
            this.丏丗业丘丒丛丝丐丟 = 0;
        }
        
        if(this.丈专丛丞万世丕丞丄 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丈专丛丞万世丕丞丄);
        this.丈专丛丞万世丕丞丄 = 0;
    }
    private System.Collections.IEnumerator 下丗不丞丄业与世下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RewardParticlesSource.丝丞丕与上丐丟丐东();
    }
    private void 上丕丄丞丅丝三丗丏()
    {
        RewardParticle val_12 = 0;
        goto label_1;
        label_22:
        UnityEngine.Vector3 val_3 = this.下丟丏丘不丄丅丒七.Item[0].transform.position;
        UnityEngine.Vector3 val_5 = this.丘一一世下丟丏万世.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) < 0)
        {
                if(this.世丁东业丆丙丌丝丆 == 0)
        {
                if(RewardParticlesSource.丒不丕与丞丄丆专丑 != null)
        {
                (RewardParticlesSource.丒不丕与丞丄丆专丑 == 0) ? 0 : RewardParticlesSource.丒不丕与丞丄丆专丑.Invoke(obj:  this);
        }
        
        }
        
            RewardParticle val_8 = this.下丟丏丘不丄丅丒七.Item[0];
            this.丘一一世下丟丏万世.丝丟不丒丐三丌下丆(丙与丁不丁丘丒上世:  val_12 = 0);
            if(RewardParticlesSource.丈丒丄万丘且且丅丏 != null)
        {
                (RewardParticlesSource.丈丒丄万丘且且丅丏 == 0) ? 0 : RewardParticlesSource.丈丒丄万丘且且丅丏.Invoke(obj:  this);
        }
        
            this.particlesPool.Return(万且万且丑丗且丌丆:  this.下丟丏丘不丄丅丒七.Item[0]);
            this.下丟丏丘不丄丅丒七.RemoveAt(index:  0);
            int val_12 = this.世丁东业丆丙丌丝丆;
            val_12 = val_12 + 1;
            this.世丁东业丆丙丌丝丆 = val_12;
        }
        
        val_12 = 1;
        label_1:
        if(val_12 < this.下丟丏丘不丄丅丒七.Count)
        {
            goto label_22;
        }
    
    }
    private void 丂丌丄不丆丒丝丅万()
    {
        List.Enumerator<T> val_1 = this.下丟丏丘不丄丅丒七.GetEnumerator();
        label_4:
        if(((-167962120) & 1) == 0)
        {
            goto label_2;
        }
        
        this.particlesPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.下丟丏丘不丄丅丒七.Clear();
    }
    private void 世一业与丟不丗三七()
    {
        if(this.丏丗业丘丒丛丝丐丟 != null)
        {
                this.StopCoroutine(routine:  this.丏丗业丘丒丛丝丐丟);
            this.丏丗业丘丒丛丝丐丟 = 0;
        }
        
        this.丏丗业丘丒丛丝丐丟 = this.StartCoroutine(routine:  this.且丄丘丕丏丝丌丐丟());
    }
    private void 丗下丂丁丂丝专不丐()
    {
        if(this.丏丗业丘丒丛丝丐丟 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丏丗业丘丒丛丝丐丟);
        this.丏丗业丘丒丛丝丐丟 = 0;
    }
    private System.Collections.IEnumerator 且丄丘丕丏丝丌丐丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RewardParticlesSource.丝东丂丝丅丈丒业三();
    }
    public RewardParticlesSource()
    {
        this.showCountTime = 3f;
        this.下丟丏丘不丄丅丒七 = new System.Collections.Generic.List<RewardParticle>();
    }

}
