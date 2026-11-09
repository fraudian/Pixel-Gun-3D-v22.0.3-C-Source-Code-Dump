using UnityEngine;
private sealed class 丗下丙丅且丐丞丙世.丒丁丁上一丕东七丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丗下丙丅且丐丞丙世 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丗下丙丅且丐丞丙世.丒丁丁上一丕东七丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_29;
        WeaponManager val_30;
        var val_31;
        int val_32;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_29 = null;
        val_29 = null;
        val_30 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_30 == 0)
        {
            goto label_20;
        }
        
        val_31 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() == true)
        {
            goto label_9;
        }
        
        val_30 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
        if(val_30.下不丙丌丙丞丞万上() == false)
        {
            goto label_20;
        }
        
        label_9:
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_20;
        }
        
        if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() != true)
        {
                if(FriendsController.丂丑丈丂丌丟丛丝世() == false)
        {
            goto label_20;
        }
        
        }
        
        if(PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丟东丒三一丐业且专() != 2)
        {
            goto label_22;
        }
        
        val_31 = 1152921504619679744;
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        this.丝且与丝丒丟万丁专.丌且丂丁丆丟不且下(丟丐丙上丈丙万丂丐:  this.丝且与丝丒丟万丁专.丐丝且丈世与七丐丐.Item[0], 东丏上东丆丕丂丗不:  0f);
        this.丝且与丝丒丟万丁专.丛丁丄丂专不丕一丝();
        this.丝且与丝丒丟万丁专.专七东一专丞业丈世 = true;
        val_30 = 1152921504615739392;
        UnityEngine.Coroutine val_17 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  1, 丌专业且丛丏丞丝且:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::丄丞一丐丐东万丕世()));
        PGCompany.丗丝万丏世丛丈丏丕.不七专丙丘丌七丗丂(丙业与丙丗丝不丈东:  new System.Action<System.DateTime, System.Decimal>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::业下丐与丏业东丕丅(System.DateTime 丘丕丙丂丙世上东丅, decimal 丁不丙丈专丄丆丛不)));
        WeaponManager.丐万丑丙七丒且丂上(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::丛万一丏丒一丟东丛()));
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::一丛专丄丁丄三丝丅()));
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::丈下丅丝丈世丑下丗()));
        goto label_36;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_36;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        PGCompany.丗丝万丏世丛丈丏丕.丗世丑丏三丛丌一丂(丙业与丙丗丝不丈东:  new System.Action<System.DateTime, System.Decimal>(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::业下丐与丏业东丕丅(System.DateTime 丘丕丙丂丙世上东丅, decimal 丁不丙丈专丄丆丛不)));
        WeaponManager.七丕丕丒丗丄丒丌上(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::丛万一丏丒一丟东丛()));
        ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::一丛专丄丁丄三丝丅()));
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void Rilisoft.丗下丙丅且丐丞丙世::丈下丅丝丈世丑下丗()));
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_43;
        }
        
        this.丝且与丝丒丟万丁专.专七东一专丞业丈世 = false;
        this.丝且与丝丒丟万丁专.七丘上万丐丛世丑丞();
        goto label_44;
        label_20:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_32 = 1;
        return (bool)val_32;
        label_43:
        mem[24] = 0;
        0.七丘上万丐丛世丑丞();
        label_44:
        if((this.丝且与丝丒丟万丁专.<丛丂世丅丈专丑丅丅>k__BackingField) <= 0)
        {
                this.丝且与丝丒丟万丁专.<丛丂世丅丈专丑丅丅>k__BackingField = PixelTime.丝丗专上三不丄丑丑();
        }
        
        val_30 = Progress.七七世万专丕丁上业.丑丙丏东丘丏专丐丕();
        this.丝且与丝丒丟万丁专.<下丅世丐丞且与三专>k__BackingField = val_30.丌丘丂专万三丂下丗();
        val_32 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_32;
        return (bool)val_32;
        label_22:
        this.丝且与丝丒丟万丁专.七丘上万丐丛世丑丞();
        label_36:
        val_32 = 0;
        return (bool)val_32;
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
