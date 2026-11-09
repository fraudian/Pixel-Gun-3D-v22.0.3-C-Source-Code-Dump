using UnityEngine;
private sealed class ClanTutorButtonHintLobbyV2.一上丛万丆丙丛万丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClanTutorButtonHintLobbyV2 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanTutorButtonHintLobbyV2.一上丛万丆丙丛万丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        var val_16;
        UnityEngine.WaitForSeconds val_17;
        int val_18;
        var val_19;
        var val_20;
        var val_21;
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
        this.三丛与七下专丅丕东 = 0;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_15 = null;
        val_15 = null;
        if((ExperienceController.sharedController == 0) || ((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans")) == false))
        {
            goto label_11;
        }
        
        bool val_3 = ClansTutorialController.上且世丘丝三丄丈丗();
        if(val_3 == false)
        {
            goto label_13;
        }
        
        val_16 = 0;
        goto label_14;
        label_11:
        val_17 = this.三丛与七下专丅丕东;
        if(val_17 == null)
        {
                UnityEngine.WaitForSeconds val_4 = null;
            val_17 = val_4;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
            this.三丛与七下专丅丕东 = val_17;
        }
        
        val_18 = 1;
        goto label_16;
        label_3:
        val_19 = 0;
        return (bool)val_19;
        label_13:
        label_14:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.丝且与丝丒丟万丁专.不丅丅丈下业丂丁一, 丏业丟一东丂东丘丛:  (与丂丅三丂且不不与.丑七不且上丗丁一世().丈丏丒丈丐丌丗上丂() != 1) ? 1 : 0);
        if(val_3 != false)
        {
                val_20 = 0;
        }
        
        val_21 = null;
        val_21 = null;
        ClansController.丑丏丛不丂丄上且丈 = (与丂丅三丂且不不与.丑七不且上丗丁一世().丈丏丒丈丐丌丗上丂() != 1) ? 1 : 0;
        this.三丛与七下专丅丕东 = 0;
        label_5:
        if(ClansTutorialController.上且世丘丝三丄丈丗() != false)
        {
                if(this.丝且与丝丒丟万丁专.不丅丅丈下业丂丁一.gameObject.activeSelf != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.丝且与丝丒丟万丁专.不丅丅丈下业丂丁一, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        val_17 = this.三丛与七下专丅丕东;
        if(val_17 == null)
        {
                UnityEngine.WaitForSeconds val_14 = null;
            val_17 = val_14;
            val_14 = new UnityEngine.WaitForSeconds(seconds:  1f);
            this.三丛与七下专丅丕东 = val_17;
        }
        
        val_18 = 2;
        label_16:
        val_19 = 1;
        this.丒上七丌业七丟与丐 = val_17;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_19;
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
