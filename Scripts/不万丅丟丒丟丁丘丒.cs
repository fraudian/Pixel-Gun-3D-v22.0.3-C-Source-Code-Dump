using UnityEngine;
private sealed class ModuleUpdateElementalPanel.不万丅丟丒丟丁丘丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ModuleUpdateElementalPanel 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ModuleUpdateElementalPanel.不万丅丟丒丟丁丘丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UILabel val_8;
        Rilisoft.OfferItemType val_9;
        var val_10;
        int val_11;
        int val_12;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_9 = this.丝且与丝丒丟万丁专._itemType;
        goto label_4;
        label_1:
        val_10 = val_8;
        int val_2 = this.丈丌丝且业丏丈丂丁 - 1;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丈丌丝且业丏丈丂丁 = val_2;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        if(val_2 > 0)
        {
            goto label_13;
        }
        
        goto label_14;
        label_3:
        val_9 = 0;
        label_4:
        this.丝且与丝丒丟万丁专.丐丙丒丈丄不一丈与 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_9, 丞丅上丏丂且下丅与:  this.丝且与丝丒丟万丁专._itemId);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._containerInfo, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._containerReward, 丏业丟一东丂东丘丛:  false);
        this.丝且与丝丒丟万丁专._buttonInfoBoxCollider.enabled = false;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丈丌丝且业丏丈丂丁 = this.丝且与丝丒丟万丁专._blockSeconds;
        if(this.丝且与丝丒丟万丁专._blockSeconds < 1)
        {
            goto label_14;
        }
        
        val_11 = this.丈丌丝且业丏丈丂丁;
        goto label_13;
        label_5:
        if(val_2 < 1)
        {
            goto label_14;
        }
        
        label_13:
        val_9 = System.String.Format(format:  "{0}...", arg0:  this.丈丌丝且业丏丈丂丁);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专._buttonInfoLabel, 丕丗丘丑丛与丑业丒:  val_9);
        val_12 = 1;
        this.丗丏丅丕丆世丁专丟 = val_12;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_12;
        label_14:
        this.丝且与丝丒丟万丁专._buttonInfoBoxCollider.enabled = true;
        UnityEngine.Color val_6 = UnityEngine.Color.clear;
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.丝且与丝丒丟万丁专._buttonDarkenSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
        val_8 = this.丝且与丝丒丟万丁专._buttonInfoLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_8, 丕丗丘丑丛与丑业丒:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6102"));
        label_2:
        val_12 = 0;
        return (bool)val_12;
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
