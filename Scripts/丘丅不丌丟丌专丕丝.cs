using UnityEngine;
private sealed class CharactersCorouselItem.丘丅不丌丟丌专丕丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.CharactersCorouselItem 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharactersCorouselItem.丘丅不丌丟丌专丕丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.CharactersCorouselItem val_36;
        string val_37;
        UnityEngine.GameObject val_38;
        System.Type val_39;
        var val_40;
        var val_41;
        System.Func<UnityEngine.GameObject, System.Boolean> val_43;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        val_36 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.世丝丞七丅丝丄与三 != null)
        {
                val_37 = this.丝且与丝丒丟万丁专.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏();
        }
        else
        {
                val_37 = 0;
        }
        
        val_38 = this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_37)) == false)
        {
            goto label_7;
        }
        
        丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_38);
        this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且 = 0;
        goto label_27;
        label_7:
        val_39 = 1152921504848912384;
        if(val_38 != 0)
        {
                if((System.String.op_Inequality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且), b:  val_37)) == false)
        {
            goto label_61;
        }
        
        }
        
        UnityEngine.GameObject val_8 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丘丕丂万丝丁丌丞业(世丐丗专丅三丝丑丆:  val_37));
        if(val_8 != 0)
        {
            goto label_20;
        }
        
        object[] val_10 = new object[1];
        val_38 = val_10;
        val_38[0] = val_37;
        UnityEngine.Debug.LogErrorFormat(format:  "[PETS] prefab for pet \'{0}\' not found", args:  val_10);
        goto label_27;
        label_20:
        if(this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且 != 0)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且);
            this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且 = 0;
        }
        
        UnityEngine.GameObject val_13 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_8, 丈东丘丏与丌东东下:  val_36.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且 = val_13;
        if((val_13.GetComponent<Rilisoft.FlyingPetEngine>()) != 0)
        {
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.up;
            this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且.transform.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        }
        
        val_40 = 0;
        goto label_44;
        label_52:
        T val_36 = this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且.GetComponents<UnityEngine.Behaviour>()[0];
        val_39 = val_36.GetType();
        if((System.Type.op_Inequality(left:  val_39, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                val_36.enabled = false;
        }
        
        val_40 = 1;
        label_44:
        if(val_40 < val_18.Length)
        {
            goto label_52;
        }
        
        val_41 = null;
        val_41 = null;
        val_43 = CharactersCorouselItem.<>c.<>9__21_0;
        if(val_43 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_24 = null;
            val_43 = val_24;
            val_24 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  CharactersCorouselItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharactersCorouselItem.<>c::丛且业不丅七东业丅(UnityEngine.GameObject 丐丆丂丒丁万丈丛丅));
            CharactersCorouselItem.<>c.<>9__21_0 = val_43;
        }
        
        if((System.Linq.Enumerable.Any<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.东丕丟丏丐业丅东丐(丈丆上丅丘世专丑丕:  val_36.gameObject), predicate:  val_24)) == false)
        {
            goto label_59;
        }
        
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_37)) == null)
        {
            goto label_61;
        }
        
        Rilisoft.PetIndicationController val_28 = this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且.GetComponent<Rilisoft.PetIndicationController>();
        if(val_28 == null)
        {
            goto label_64;
        }
        
        val_28.enabled = true;
        val_28.isUpdateNameFromInfo = true;
        goto label_65;
        label_59:
        Rilisoft.PetIndicationController val_29 = this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且.GetComponent<Rilisoft.PetIndicationController>();
        val_29.IconObject.SetActive(value:  false);
        val_29.LabelObj.SetActive(value:  false);
        label_61:
        if(val_36 != null)
        {
            goto label_80;
        }
        
        label_81:
        label_80:
        this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且.GetComponent<Rilisoft.PetEngine>().世与东丗世三丞丞不(丞丅上丏丂且下丅与:  val_37);
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且, 不东丛三丂丌丑专丆:  val_36.gameObject.layer);
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且);
        val_38 = val_36.enabled;
        this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且.SetActive(value:  val_38);
        label_27:
        this.丝且与丝丒丟万丁专.且丐丘丄且丘七丗丏 = 0;
        return false;
        label_64:
        0.enabled = true;
        mem[128] = 1;
        label_65:
        val_28.IconObject.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.丑七三丆丐丙丟丈且.GetComponent<Rilisoft.PetEngine>().丂七三丐一万丈业丒(丙业与丙丗丝不丈东:  true);
        val_28.LabelObj.SetActive(value:  true);
        val_28.丑上七丈丘东丐丝丈(丙业与丙丗丝不丈东:  val_27.专丕与丒丗丁丘专丟);
        val_28.下丟丐丌三丒丅丈不();
        if(val_36 != null)
        {
            goto label_80;
        }
        
        goto label_81;
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

}
