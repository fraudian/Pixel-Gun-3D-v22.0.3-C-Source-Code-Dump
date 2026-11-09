using UnityEngine;
internal class 丘业丏丒上业丒世丈
{
    // Fields
    private const int 与业丈业丘与丒丙一 = 0;
    private const int 丐丂丆丅丛万丙丅丌 = 1000;
    private const int 万东不丏丛丁丆业丒 = -100;
    private const int 世丛丛下丌一丄与业 = 1;
    private const int 七丐丞丅丛七上业丝 = 5;
    private const string 世丅下丏丁丗专丝七 = "imposter_rating";
    
    // Properties
    private static int 丛上万万丟丌丈上丗 { get; set; }
    
    // Methods
    private static void 丌丗丗丈丟丝丒与万(int 丙业与丙丗丝不丈东)
    {
        int val_2 = 丙业与丙丗丝不丈东;
        val_2 = (val_2 < 1001) ? (val_2 & (~(val_2 >> 31))) : 1000;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "imposter_rating", 下下丏一丙不丘丌丞:  val_2, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private static int 丏与专丌丆世三三一()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "imposter_rating")) == true)
        {
                return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "imposter_rating", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        
        丘业丏丒上业丒世丈.丌丗丗丈丟丝丒与万(丙业与丙丗丝不丈东:  0);
        return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "imposter_rating", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    internal static int 东且丛且业丗丑丙丗()
    {
        return 丘业丏丒上业丒世丈.丏与专丌丆世三三一();
    }
    internal static void 一三七丟丈丝丂丝万(int 丕万丐东与一丈万与)
    {
        int val_2;
        int val_1 = 丘业丏丒上业丒世丈.丏与专丌丆世三三一();
        if(丕万丐东与一丈万与 == 1)
        {
                val_2 = val_1 - 100;
        }
        else
        {
                val_2 = val_1 + 1;
        }
        
        丘业丏丒上业丒世丈.丌丗丗丈丟丝丒与万(丙业与丙丗丝不丈东:  val_2);
    }
    internal static void 上丑丒万丕丂丛专丅(int 丕万丐东与一丈万与)
    {
        if(丕万丐东与一丈万与 == 1)
        {
                return;
        }
        
        int val_1 = 丘业丏丒上业丒世丈.丏与专丌丆世三三一();
        val_1 = val_1 + 5;
        丘业丏丒上业丒世丈.丌丗丗丈丟丝丒与万(丙业与丙丗丝不丈东:  val_1);
    }
    public 丘业丏丒上业丒世丈()
    {
    
    }

}
