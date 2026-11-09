using UnityEngine;
private sealed class TargetScanner.丙不丂万且万上丐与 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public TargetScanner 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 万下一丈丄丌三且丙;
    private UnityEngine.GameObject 丁丌东与丟丏丘丄丅;
    private float 丕一东且东七东与专;
    private System.Collections.Generic.IEnumerator<UnityEngine.Transform> 丆丆丞与世丗丈七专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TargetScanner.丙不丂万且万上丐与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_50;
        WeaponManager val_51;
        int val_53;
        float val_54;
        var val_56;
        UnityEngine.Transform val_57;
        UnityEngine.Object val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        float val_64;
        float val_65;
        float val_66;
        float val_67;
        float val_68;
        float val_69;
        if(this.丗丏丅丕丆世丁专丟 > 3)
        {
            goto label_198;
        }
        
        var val_47 = 106038032 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_47 = val_47 + 106038032;
        goto (106038032 + (this.丗丏丅丕丆世丁专丟) << 2 + 106038032);
        label_79:
        val_51 = new TargetScanner.丘丞上世丗丘丏丐东();
        val_51 = new System.Object();
        var val_50 = mem[val_6];
        if((mem[val_6] + 286) == 0)
        {
            goto label_30;
        }
        
        var val_48 = mem[val_6] + 176;
        var val_49 = 0;
        val_48 = val_48 + 8;
        label_29:
        if(((mem[val_6] + 176 + 8) + -8) == null)
        {
            goto label_28;
        }
        
        val_49 = val_49 + 1;
        val_48 = val_48 + 16;
        if(val_49 < (mem[val_6] + 286))
        {
            goto label_29;
        }
        
        goto label_30;
        label_28:
        val_50 = val_50 + (((mem[val_6] + 176 + 8)) << 4);
        val_56 = val_50 + 296;
        label_30:
        val_57 = Current;
        if(val_51 != null)
        {
                val_58 = val_51;
            .丌不丏丟万丛丕与丟 = val_57;
        }
        else
        {
                mem[16] = val_57;
            val_57 = mem[16];
            val_58 = 16;
        }
        
        if(val_57 == 0)
        {
            goto label_73;
        }
        
        val_50 = ;
        if(val_58 == this.丝且与丝丒丟万丁专.transform)
        {
            goto label_73;
        }
        
        val_59 = null;
        val_59 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_73;
        }
        
        val_60 = null;
        val_60 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
            goto label_73;
        }
        
        val_61 = null;
        val_61 = null;
        val_50 = ;
        if(mem[16] == transform)
        {
            goto label_73;
        }
        
        val_62 = null;
        val_62 = null;
        System.Predicate<Player_move_c> val_16 = new System.Predicate<Player_move_c>(object:  new TargetScanner.丘丞上世丗丘丏丐东(), method:  System.Boolean TargetScanner.丘丞上世丗丘丏丐东::丁丟东丅丄丂丐万丄(Player_move_c 三丟东丕丄丄下下丑));
        val_50 = ;
        if(((丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Find(match:  null)) == 0) || (val_17.万万一与丝业七专下 == false))
        {
            goto label_67;
        }
        
        if(this.丝且与丝丒丟万丁专.丘与丈丘丒丂丁丛丟 == mem[16].gameObject)
        {
                this.丝且与丝丒丟万丁专.丘与丈丘丒丂丁丛丟 = 0;
        }
        
        label_73:
        var val_53 = mem[val_6];
        if((mem[val_6] + 286) == 0)
        {
            goto label_78;
        }
        
        var val_51 = mem[val_6] + 176;
        var val_52 = 0;
        val_51 = val_51 + 8;
        label_77:
        if(((mem[val_6] + 176 + 8) + -8) == null)
        {
            goto label_76;
        }
        
        val_52 = val_52 + 1;
        val_51 = val_51 + 16;
        if(val_52 < (mem[val_6] + 286))
        {
            goto label_77;
        }
        
        goto label_78;
        label_76:
        val_53 = val_53 + (((mem[val_6] + 176 + 8)) << 4);
        val_63 = val_53 + 296;
        label_78:
        if(MoveNext() == true)
        {
            goto label_79;
        }
        
        this.一世丕丕业且且丅丌();
        val_51 = this.丁丌东与丟丏丘丄丅;
        this.丆丆丞与世丗丈七专 = 0;
        this.丝且与丝丒丟万丁专.丘与丈丘丒丂丁丛丟 = val_51;
        this.丗丏丅丕丆世丁专丟 = 3;
        val_53 = 1;
        this.丒上七丌业七丟与丐 = this.万下一丈丄丌三且丙;
        return (bool)val_53;
        label_67:
        UnityEngine.Vector3 val_22 = mem[16].position;
        UnityEngine.Vector3 val_24 = this.丝且与丝丒丟万丁专.transform.position;
        val_64 = val_24.y;
        val_50 = 1152921504838316032;
        val_65 = val_22.z;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_65}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_64, z = val_24.z});
        if(this.丝且与丝丒丟万丁专.LookPoint != 0)
        {
                UnityEngine.Vector3 val_27 = this.丝且与丝丒丟万丁专.LookPoint.position;
            val_66 = val_27.x;
            val_67 = val_27.y;
            val_68 = val_27.z;
        }
        else
        {
                UnityEngine.Vector3 val_29 = this.丝且与丝丒丟万丁专.transform.position;
            val_66 = val_29.x;
            val_67 = val_29.y;
            val_68 = val_29.z;
        }
        
        val_54 = val_29.x;
        val_69 = this.丕一东且东七东与专;
        if(val_54 >= 0)
        {
            goto label_95;
        }
        
        val_64 = this.丝且与丝丒丟万丁专.DetectRadius;
        val_69 = val_64 * val_64;
        if(val_54 < 0)
        {
            goto label_98;
        }
        
        label_95:
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_124;
        }
        
        label_98:
        if(this.丝且与丝丒丟万丁专.SkipCheckVisible == false)
        {
            goto label_102;
        }
        
        if(mem[16].gameObject.layer == (UnityEngine.LayerMask.NameToLayer(layerName:  "Pets")))
        {
            goto label_124;
        }
        
        this.丕一东且东七东与专 = val_54;
        label_127:
        this.丁丌东与丟丏丘丄丅 = mem[16].gameObject;
        goto label_124;
        label_102:
        UnityEngine.Vector3 val_35 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  mem[16]);
        val_64 = val_35.x;
        val_65 = val_35.z;
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_64, y = val_35.y, z = val_65}, b:  new UnityEngine.Vector3() {x = val_66, y = val_67, z = val_68});
        int val_39 = (UnityEngine.LayerMask.NameToLayer(layerName:  "Pets")) & 31;
        val_39 = 1 << val_39;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  this.丝且与丝丒丟万丁专.DetectRadius, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业() & (~val_39))) == false)
        {
            goto label_124;
        }
        
        丅丙上七上一丐不下 val_42 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
        if(val_42 == null)
        {
            goto label_124;
        }
        
        var val_54 = 0;
        val_54 = val_54 + 1;
        if(val_42.transform != mem[16])
        {
            goto label_124;
        }
        
        this.丕一东且东七东与专 = val_54;
        UnityEngine.GameObject val_46 = mem[16].gameObject;
        goto label_127;
        label_124:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_53 = 1;
        return (bool)val_53;
        label_198:
        val_53 = 0;
        return (bool)val_53;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丆丆丞与世丗丈七专 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丆丆丞与世丗丈七专.Dispose();
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
        this = new TargetScanner.丙不丂万且万上丐与();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
