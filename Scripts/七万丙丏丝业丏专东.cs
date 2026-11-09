using UnityEngine;
private sealed class ArmoryInfoScreenController.七万丙丏丝业丏专东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ArmoryInfoScreenController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ArmoryInfoScreenController.七万丙丏丝业丏专东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_7;
        ArmoryInfoScreenController val_8;
        bool val_9;
        object val_10;
        var val_11;
        var val_12;
        val_7 = this;
        val_8 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_20;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.UpgradeFinishedParticles, 丏业丟一东丂东丘丛:  false);
        val_9 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.UpgradeFinishedParticles, 丏业丟一东丂东丘丛:  true);
        ArmoryInfoScreenController.丌世丒万丈丒且丙一();
        this.丝且与丝丒丟万丁专.AnimationIsRunning = val_9;
        不丆三丕与与丂丐一 val_1 = null;
        val_10 = val_1;
        val_1 = new 不丆三丕与与丂丐一(丆丐七丅丆丗丛上与:  this.丝且与丝丒丟万丁专.业丕下三丆世与丝丄);
        this.丒上七丌业七丟与丐 = val_10;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_8 != null)
        {
                this.丝且与丝丒丟万丁专.AnimationIsRunning = false;
        }
        else
        {
                mem[424] = 0;
        }
        
        val_7 = this.丝且与丝丒丟万丁专.UpgradeFinishedParticles;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  false);
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_11 = null;
            val_11 = null;
            val_10 = this.丝且与丝丒丟万丁专.丛丞专万丈业业七丟.id;
            val_8 = this.丝且与丝丒丟万丁专.丟丘丅业丝丆丟丝丟;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.业丆上丐东丈丂丈丈(丆三丝丝一丕与丝丆:  this.丝且与丝丒丟万丁专.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七(), 丂丒丒丆且丝丘丈丟:  val_10, 丘丐丝丟业丘丏东专:  this.丝且与丝丒丟万丁专.propertiesContainer, 东丈丒三丞与业世一:  false, 丐丙丒丈丄不一丈与:  val_8, 丑丂丟丆丗丒丙业丕:  false, 丙丂丒一丗下丘下丟:  0, 丄丄丒丘丏一丗丆与:  0, 世七与业一七世丂丒:  0);
            val_7 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            if(val_7.东丂丈与丄丛万丞丑() != null)
        {
                val_12 = null;
            val_12 = null;
            val_10 = ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑();
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且(), 与丝丕与丙不与丗丆:  val_10, 七丑业业丒七一丂丆:  false);
            val_7 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            val_7.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        }
        
        }
        
        label_20:
        val_9 = 0;
        return (bool)val_9;
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
