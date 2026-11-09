using UnityEngine;
private sealed class Player_move_c.丄丛丝业丏七丕丈丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丄丛丝业丏七丕丈丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_8;
        ArmorRefs val_9;
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                val_8 = this.丝且与丝丒丟万丁专;
            this.丗丏丅丕丆世丁专丟 = 0;
            val_9 = this.丝且与丝丒丟万丁专.mySkinName.丈丈丒且丕丕东丙丞;
            if(val_9 == 0)
        {
                val_10 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_10;
            return (bool)val_10;
        }
        
            SetPosInArmor val_2 = this.丝且与丝丒丟万丁专.mySkinName.丈丈丒且丕丕东丙丞.leftBone.GetComponent<SetPosInArmor>();
            val_9 = this.丝且与丝丒丟万丁专.mySkinName.丈丈丒且丕丕东丙丞.rightBone.GetComponent<SetPosInArmor>();
            val_2.Target = val_8.丙不丅丕三丂业东丕().丛丑丂丌与丗东下专();
            val_9.Target = val_8.丙不丅丕三丂业东丕().丘万专丌丕与上丅丁();
            this.丝且与丝丒丟万丁专.东丄丑丈七丛丁丄丝.Clear();
            this.丝且与丝丒丟万丁专.东丄丑丈七丛丁丄丝.Add(item:  val_2);
            val_8 = this.丝且与丝丒丟万丁专.东丄丑丈七丛丁丄丝;
            val_8.Add(item:  val_9);
        }
        
        val_10 = 0;
        return (bool)val_10;
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
