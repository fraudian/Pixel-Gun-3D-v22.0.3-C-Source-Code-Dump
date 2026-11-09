using UnityEngine;
[Serializable]
public class VersionChange
{
    // Fields
    public System.Collections.Generic.List<VersionChangeText> Headers;
    public System.Collections.Generic.List<VersionChangeText> Descriptions;
    public string ImageUri;
    private UnityEngine.Texture2D _cachedTexture;
    
    // Properties
    public UnityEngine.Texture2D ImageTexture { get; }
    public string HeaderText { get; }
    public string DescriptionText { get; }
    
    // Methods
    public UnityEngine.Texture2D get_ImageTexture()
    {
        UnityEngine.Texture2D val_5;
        if(this._cachedTexture != 0)
        {
                val_5 = this._cachedTexture;
            return val_4;
        }
        
        val_5 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.ImageUri)) == true)
        {
                return val_4;
        }
        
        val_5 = 0;
        if((UpdatesChecker.专三丄丙丘世丁丘世(丝丅丏丙丞丟丕丘上:  this.ImageUri)) == false)
        {
                return val_4;
        }
        
        UnityEngine.Texture2D val_4 = UpdatesChecker.东丂丒七专丏丌丛丞(丝丅丏丙丞丟丕丘上:  this.ImageUri);
        this._cachedTexture = val_4;
        return val_4;
    }
    public string get_HeaderText()
    {
        return this.与丈三丗丒不丒丘丅(丝丏上丘丘七一与七:  this.Headers);
    }
    public string get_DescriptionText()
    {
        return this.与丈三丗丒不丒丘丅(丝丏上丘丘七一与七:  this.Descriptions);
    }
    private string 与丈三丗丒不丒丘丅(System.Collections.Generic.List<VersionChangeText> 丝丏上丘丘七一与七)
    {
        System.Func<TSource, System.Boolean> val_7;
        var val_9;
        System.Func<VersionChangeText, System.Boolean> val_11;
        string val_13;
        .丐丌七不丂丝不专世 = 丟丏下丂七三下丗丕.丗七丏三万丛丙丟业();
        System.Func<VersionChangeText, System.Boolean> val_3 = null;
        val_7 = val_3;
        val_3 = new System.Func<VersionChangeText, System.Boolean>(object:  new VersionChange.下丌丛三下专丘丐丕(), method:  System.Boolean VersionChange.下丌丛三下专丘丐丕::专丘万东东专万丛丆(VersionChangeText 丙丒七丄上与丏丙丙));
        if((System.Linq.Enumerable.FirstOrDefault<VersionChangeText>(source:  丝丏上丘丘七一与七, predicate:  val_3)) == null)
        {
                val_9 = null;
            val_9 = null;
            val_11 = VersionChange.<>c.<>9__10_1;
            if(val_11 == null)
        {
                System.Func<VersionChangeText, System.Boolean> val_5 = null;
            val_11 = val_5;
            val_5 = new System.Func<VersionChangeText, System.Boolean>(object:  VersionChange.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean VersionChange.<>c::下丐丘与丒丞七丗丁(VersionChangeText 丙丒七丄上与丏丙丙));
            VersionChange.<>c.<>9__10_1 = val_11;
        }
        
            if((System.Linq.Enumerable.FirstOrDefault<VersionChangeText>(source:  丝丏上丘丘七一与七, predicate:  val_5)) == null)
        {
                return val_13;
        }
        
        }
        
        val_13 = val_6.Text;
        return val_13;
    }
    public VersionChange()
    {
    
    }

}
