using UnityEngine;
private sealed class Rocket.东丁丘七三丒世一万 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Rocket 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.东丁丘七三丒世一万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rocket val_53;
        RocketSettings val_54;
        int val_55;
        var val_56;
        var val_57;
        float val_59;
        RocketSettings val_60;
        float val_61;
        RocketSettings val_62;
        RocketSettings val_63;
        UnityEngine.Coroutine val_65;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_112;
        }
        
        val_53 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_54 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_54 == 0)
        {
                val_55 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_55;
            return (bool)val_55;
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.trail != 0)
        {
                this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.trail.Clear();
            this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.trail.enabled = true;
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly != 23)
        {
                if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.flyParticle != 0)
        {
                this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.flyParticle.SetActive(value:  true);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false)
        {
            goto label_86;
        }
        
        val_56 = null;
        val_56 = null;
        if(val_53.上丗丞且且丏丑下丟() == WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
        {
                var val_6 = (this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 26) ? 11 : 29;
        }
        else
        {
                if((this.丝且与丝丒丟万丁专.丐丙东丏丂业与业丂 != false) && (this.丝且与丝丒丟万丁专.丞丆下丆丄万丝下世 != false))
        {
                if(val_53.上丗丞且且丏丑下丟().一丝丌丏万丐丌丆东() != false)
        {
                val_53.Invoke(methodName:  "SetDefaultLayer", time:  0.15f);
        }
        
            val_57 = 29;
        }
        else
        {
                val_57 = 0;
        }
        
        }
        
        if(val_53.gameObject.layer != val_57)
        {
                Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_53.gameObject, 不东丛三丂丌丑专丆:  0);
        }
        
        if(this.丝且与丝丒丟万丁专.丈丈丈丙下丝丆丈东 != false)
        {
                val_53.gameObject.layer = 0;
        }
        
        val_54 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_54 == null)
        {
            goto label_41;
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.GradualExplosions == false)
        {
            goto label_42;
        }
        
        label_48:
        float val_16 = UnityEngine.Time.fixedDeltaTime;
        float val_17 = UnityEngine.Time.fixedDeltaTime;
        val_17 = (this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.与丕丒丂丗一且不丁() / val_53.丂丝不一丑下三七业().mass) * val_17;
        val_59 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.gradualFlyDistance / val_17;
        float val_56 = (float)this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.gradualExplosionsCount;
        val_56 = val_59 / val_56;
        this.丝且与丝丒丟万丁专.丌丌丕丝丛与丛下丗 = val_56;
        goto label_58;
        label_41:
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 == null)
        {
            goto label_65;
        }
        
        val_54 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.GradualExplosions == true)
        {
            goto label_48;
        }
        
        label_42:
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.useRandomLifeTime == false)
        {
            goto label_49;
        }
        
        val_60 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_60 == null)
        {
            goto label_50;
        }
        
        val_61 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.maxLifeTime;
        val_62 = val_60;
        goto label_60;
        label_49:
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_54;
        }
        
        val_59 = 1f;
        if((val_53.丗三丗东丒丞丛下丒() == 36) || (val_53.丗三丗东丒丞丛下丒() == 18))
        {
            goto label_58;
        }
        
        label_54:
        val_59 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.lifeTime;
        goto label_58;
        label_50:
        val_62 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        val_61 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.maxLifeTime;
        if(val_62 == null)
        {
            goto label_59;
        }
        
        val_60 = val_62;
        goto label_60;
        label_59:
        val_60 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_60 == null)
        {
            goto label_65;
        }
        
        label_60:
        float val_22 = val_61 - this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.minLifeTime;
        val_22 = val_22 / this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.stepRandomLifeTime;
        val_54 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        val_63 = val_54;
        if(val_54 != null)
        {
            goto label_64;
        }
        
        val_63 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_63 == null)
        {
            goto label_65;
        }
        
        label_64:
        float val_57 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.stepRandomLifeTime;
        float val_58 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.minLifeTime;
        val_57 = val_57 * ((float)UnityEngine.Random.Range(min:  0, max:  UnityEngine.Mathf.FloorToInt(f:  val_22)));
        val_59 = val_58 + val_57;
        label_58:
        this.丝且与丝丒丟万丁专.下东丘丅丕丗东万万 = val_53.StartCoroutine(routine:  val_53.丄丕万丄丐万七丅丈(且丙与丏下丅丐世丑:  0, 丕丕世且下一与丝与:  val_59));
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 23)
        {
                val_58 = val_59 + (-2f);
            var val_59 = 0;
            val_59 = val_59 + 1;
            System.Collections.IEnumerator val_30 = val_53.丂丘一丕丄丌丆一丌(丕丕世且下一与丝与:  UnityEngine.Mathf.Max(a:  0f, b:  val_58)).GetEnumerator();
            if(val_53 != null)
        {
                val_65 = val_53.StartCoroutine(routine:  val_30);
        }
        else
        {
                val_65 = val_53.StartCoroutine(routine:  val_30);
        }
        
            this.丝且与丝丒丟万丁专.丙丌丝专万丅与丅丞 = val_65;
        }
        
        if(((val_53.上丗丞且且丏丑下丟().一丝丌丏万丐丌丆东() != true) && (this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 26)) && (val_53.上丗丞且且丏丑下丟() != 0))
        {
                val_53.上丗丞且且丏丑下丟().丗丆丗与上一七业丙(三且万三万东丝下三:  val_53);
            Player_move_c val_38 = val_53.上丗丞且且丏丑下丟();
            if(val_38.丄丁丑丞丅一三丌丆 != false)
        {
                val_53.上丗丞且且丏丑下丟().专与丅丄不丛丗丛丂(一上丒丏丌丏丘且丑:  false);
        }
        
        }
        
        label_86:
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 20)
        {
                var val_60 = 0;
            val_60 = val_60 + 1;
            System.Collections.IEnumerator val_42 = val_53.世一不上不丒丅丝与(丕丕世且下一与丝与:  1f).GetEnumerator();
            if(val_53 != null)
        {
                UnityEngine.Coroutine val_43 = val_53.StartCoroutine(routine:  val_42);
        }
        else
        {
                UnityEngine.Coroutine val_44 = 0.StartCoroutine(routine:  val_42);
        }
        
            UnityEngine.Animation val_45 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.丁业世丕上东丁丄丁();
            if(val_45 != 0)
        {
                bool val_47 = val_45.Play(animation:  "throw");
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 21)
        {
                var val_61 = 0;
            val_61 = val_61 + 1;
            UnityEngine.Coroutine val_51 = val_53.StartCoroutine(routine:  val_53.不丞一世万丆不丁七(丕丕世且下一与丝与:  2.5f).GetEnumerator());
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.typeFly == 24)
        {
                UnityEngine.Animation val_52 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.丁业世丕上东丁丄丁();
            if(val_52 != 0)
        {
                bool val_54 = val_52.Play(animation:  "Fly");
        }
        
            val_53 = val_53.丂丝不一丑下三七业();
            val_53.useGravity = false;
        }
        
        label_112:
        val_55 = 0;
        return (bool)val_55;
        label_65:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new Rocket.东丁丘七三丒世一万();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
