using UnityEngine;
private sealed class LeaguesGUIController.丗丆丙丕丞世丕世丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LeaguesGUIController 丝且与丝丒丟万丁专;
    private ProfileCup 不丁一丐三业东专东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaguesGUIController.丗丆丙丕丞世丕世丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RatingLeague val_5;
        int val_6;
        ProfileCup val_7;
        var val_8;
        System.Func<ProfileCup, System.Boolean> val_10;
        val_5 = this;
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
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        val_7 = this.不丁一丐三业东专东;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this.不丁一丐三业东专东.League;
        this.丝且与丝丒丟万丁专.七世丑丞丙丐丞上丆(丙丑七万丆万丆且丌:  val_5);
        label_3:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = null;
        val_8 = null;
        val_10 = LeaguesGUIController.<>c.<>9__14_0;
        if(val_10 == null)
        {
                System.Func<ProfileCup, System.Boolean> val_1 = null;
            val_10 = val_1;
            val_1 = new System.Func<ProfileCup, System.Boolean>(object:  LeaguesGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LeaguesGUIController.<>c::丈丒丒丟丑三且丘丑(ProfileCup 丁丂专业丁丅丅丈丙));
            LeaguesGUIController.<>c.<>9__14_0 = val_10;
        }
        
        ProfileCup val_2 = System.Linq.Enumerable.FirstOrDefault<ProfileCup>(source:  this.丝且与丝丒丟万丁专._cups, predicate:  val_1);
        this.不丁一丐三业东专东 = val_2;
        val_7 = val_2.gameObject.transform;
        this.丝且与丝丒丟万丁专._centerOnChild.CenterOn(丞下万上三丘上与专:  val_7);
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
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
