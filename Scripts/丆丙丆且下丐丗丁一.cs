using UnityEngine;
public class 丆丙丆且下丐丗丁一
{
    // Fields
    internal CharacterInterfaceV2 世丟丈丏丕万丝丆万;
    private bool 世丟丘丞丌丁丙丕丕;
    private bool 丕七丟三丗三丐业丁;
    private bool 丛丑上一丗丒丘丗丈;
    private bool 丒丕丄丆专丂丛丙万;
    
    // Methods
    public void 丝丅与丒东世丒丁丕()
    {
        UnityEngine.GameObject val_1 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Character_model_V2");
        val_1.SetActive(value:  false);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        CharacterInterfaceV2 val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_1, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}).GetComponent<CharacterInterfaceV2>();
        val_1.SetActive(value:  true);
        if(val_5 != null)
        {
                val_5.世丅三丈丐丒万丈万(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_5.世丅三丈丐丒万丈万(丙业与丙丗丝不丈东:  true);
        }
        
        val_5.丟且丟七丌丞专七丁();
        this.世丟丈丏丕万丝丆万 = val_5;
    }
    public void 丆丙上世丟丐与三丑(bool 丑下万丂丞不七丄三, bool 丅丒丆三丌七丟七与, bool 丂丈业东丛且丈一下, bool 丒丒丏业专丌丑丟丆)
    {
        var val_1 = (this.世丟丘丞丌丁丙丕丕 == true) ? 1 : 0;
        val_1 = val_1 ^ 丑下万丂丞不七丄三;
        if(val_1 != true)
        {
                var val_2 = (this.丕七丟三丗三丐业丁 == true) ? 1 : 0;
            val_2 = val_2 ^ 丅丒丆三丌七丟七与;
            if(val_2 != true)
        {
                var val_3 = (this.丛丑上一丗丒丘丗丈 == true) ? 1 : 0;
            val_3 = val_3 ^ 丂丈业东丛且丈一下;
            if(val_3 != true)
        {
                var val_4 = (this.丒丕丄丆专丂丛丙万 == true) ? 1 : 0;
            val_4 = val_4 ^ 丒丒丏业专丌丑丟丆;
            if(val_4 == false)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        this.世丟丘丞丌丁丙丕丕 = 丑下万丂丞不七丄三;
        this.丛丑上一丗丒丘丗丈 = 丂丈业东丛且丈一下;
        this.丕七丟三丗三丐业丁 = 丅丒丆三丌七丟七与;
        this.丒丕丄丆专丂丛丙万 = 丒丒丏业专丌丑丟丆;
        丑下万丂丞不七丄三 = (~丑下万丂丞不七丄三) & 1;
        this.世丟丈丏丕万丝丆万.不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  丑下万丂丞不七丄三);
        this.世丟丈丏丕万丝丆万.丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  (~丅丒丆三丌七丟七与) & 1);
        this.世丟丈丏丕万丝丆万.业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  (~丂丈业东丛且丈一下) & 1);
        this.世丟丈丏丕万丝丆万.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (~丒丒丏业专丌丑丟丆) & 1);
    }
    public void 丈丑丅上七丑丅一丒(string 丐丒丈丌与丈丏不上)
    {
        this.世丟丈丏丕万丝丆万.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  丐丒丈丌与丈丏不上);
    }
    public void 上丈一万东三东世东(UnityEngine.Texture2D 丂丒丘丅专丗丂世丛)
    {
        this.世丟丈丏丕万丝丆万.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.世丟丈丏丕万丝丆万.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  丂丒丘丅专丗丂世丛);
    }
    public void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        this.世丟丈丏丕万丝丆万.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
    }
    public void 丑丞丟丁东丂三与丁(string 丈丐丕业下丟业丛一)
    {
        this.世丟丈丏丕万丝丆万.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  丈丐丕业下丟业丛一);
        this.世丟丈丏丕万丝丆万.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    public void 丑丞丟丁东丂三与丁(string 丈丐丕业下丟业丛一, UnityEngine.Texture2D 丂丒丘丅专丗丂世丛)
    {
        this.世丟丈丏丕万丝丆万.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  丈丐丕业下丟业丛一, 三丆业丘丑万丘世下:  丂丒丘丅专丗丂世丛);
        this.世丟丈丏丕万丝丆万.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    public void 上丛与丅丏丌上丁丞(string 与丙丕丛一丌丛丆丈, bool 七丅丅世丆丆丗丟丐)
    {
        this.世丟丈丏丕万丝丆万.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  与丙丕丛一丌丛丆丈);
        this.世丟丈丏丕万丝丆万.丄丌丏三专丏丄丒丌(丙业与丙丗丝不丈东:  七丅丅世丆丆丗丟丐);
    }
    public void 不一丙东七下不丕丑(string 丟世丟丐且丐丟七上)
    {
        this.世丟丈丏丕万丝丆万.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  丟世丟丐且丐丟七上);
        this.世丟丈丏丕万丝丆万.丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  (this.丕七丟三丗三丐业丁 == false) ? 1 : 0);
    }
    public void 上丒丈世丗丆丗丛下(string 且与丛专丗丞丑丑丝)
    {
        this.世丟丈丏丕万丝丆万.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  且与丛专丗丞丑丑丝);
        this.世丟丈丏丕万丝丆万.业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  (this.丛丑上一丗丒丘丗丈 == false) ? 1 : 0);
    }
    public void 丘丄丏世丒上东丘丒(string 上丈专丌万丕丙万丘)
    {
        this.世丟丈丏丕万丝丆万.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  上丈专丌万丕丙万丘);
        this.世丟丈丏丕万丝丆万.不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  (this.世丟丘丞丌丁丙丕丕 == false) ? 1 : 0);
    }
    public void 丙一世丞丏丌丑丟丘(string 丌丝下丄业一丄不三, string 世世丛与丒丗丏东下)
    {
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丌丝下丄业一丄不三 = 丌丝下丄业一丄不三)) != false)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  世世丛与丒丗丏东下)) != false)
        {
                var val_6 = ((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丌丝下丄业一丄不三)) == 0) ? 1 : 0;
            val_6 = val_6 | (WeaponManager.丞上一丘丆三下丐丑().Contains(item:  丌丝下丄业一丄不三));
        }
        
        }
        
        this.世丟丈丏丕万丝丆万.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  (val_6 != true) ? 世世丛与丒丗丏东下 : (丌丝下丄业一丄不三));
    }
    public void 丙一世丞丏丌丑丟丘(string 丌丝下丄业一丄不三, string 世世丛与丒丗丏东下, int 专丙丐世与丐下不丑)
    {
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丌丝下丄业一丄不三 = 丌丝下丄业一丄不三)) != false)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  世世丛与丒丗丏东下)) != false)
        {
                var val_6 = ((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丌丝下丄业一丄不三)) == 0) ? 1 : 0;
            val_6 = val_6 | (WeaponManager.丞上一丘丆三下丐丑().Contains(item:  丌丝下丄业一丄不三));
        }
        
        }
        
        this.世丟丈丏丕万丝丆万.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  (val_6 != true) ? 世世丛与丒丗丏东下 : (丌丝下丄业一丄不三));
        this.世丟丈丏丕万丝丆万.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  专丙丐世与丐下不丑));
    }
    public void Destroy()
    {
        if(this.世丟丈丏丕万丝丆万 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.世丟丈丏丕万丝丆万.gameObject);
    }
    public 丆丙丆且下丐丗丁一()
    {
    
    }

}
