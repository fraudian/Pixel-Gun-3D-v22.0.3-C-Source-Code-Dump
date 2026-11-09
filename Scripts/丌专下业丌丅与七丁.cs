using UnityEngine;
private sealed class LobbyCraftButton.丌专下业丌丅与七丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LobbyCraftButton 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyCraftButton.丌专下业丌丅与七丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_27;
        UnityEngine.WaitForSeconds val_28;
        int val_29;
        var val_30;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._craftedItemExists.gameObject, 丏业丟一东丂东丘丛:  false);
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_12;
        }
        
        goto label_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_8:
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.craft")) == false)
        {
            goto label_11;
        }
        
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_12;
        }
        
        label_10:
        label_12:
        if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄丐且丐业丙世丞与()) == null)
        {
            goto label_14;
        }
        
        val_27 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        if(this.丝且与丝丒丟万丁专._craftedItemExists != null)
        {
            goto label_45;
        }
        
        label_46:
        label_45:
        this.丝且与丝丒丟万丁专._craftedItemExists.SetActive(value:  val_27);
        if(((与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true) && ((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万()) != null)) && ((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万().下丞丘丏丂丕丄丐丘()) >= 1))
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._craftTimeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            val_27 = this.丝且与丝丒丟万丁专._craftTimeLeftLabel;
            val_27.text = System.String.Format(format:  "[FFD700]{0}[-]{1}{2}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万().丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐()), arg1:  System.Environment.NewLine, arg2:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万().下丞丘丏丂丕丄丐丘(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        }
        else
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._craftTimeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        val_28 = this.三丛与七下专丅丕东;
        val_29 = 2;
        goto label_43;
        label_3:
        val_30 = 0;
        return (bool)val_30;
        label_11:
        val_28 = 0;
        val_29 = 1;
        label_43:
        val_30 = 1;
        this.丒上七丌业七丟与丐 = val_28;
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_30;
        label_14:
        if(this.丝且与丝丒丟万丁专._craftedItemExists != null)
        {
            goto label_45;
        }
        
        goto label_46;
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
