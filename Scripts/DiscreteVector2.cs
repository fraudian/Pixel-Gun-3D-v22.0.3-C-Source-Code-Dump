using UnityEngine;
[Serializable]
internal struct DiscreteVector2
{
    // Fields
    private int _x;
    private int _y;
    
    // Properties
    internal int X { get; }
    internal int Y { get; }
    internal HexTiles.HexPosition HexPosition { get; }
    internal HexTiles.HexCoords HexCoords { get; }
    
    // Methods
    internal int get_X()
    {
        return (int)this;
    }
    internal int get_Y()
    {
        return (int)this;
    }
    internal DiscreteVector2(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌)
    {
        mem[1152921526220977296] = 三丟东丕丄丄下下丑;
        mem[1152921526220977300] = 丒丒丄丁且丄丆丂丌;
    }
    internal DiscreteVector2(UnityEngine.Vector3 专丈丌一丅业七丌丌)
    {
        mem[1152921526221089296] = (int)专丈丌一丅业七丌丌.x;
        mem[1152921526221089300] = (int)专丈丌一丅业七丌丌.z;
    }
    internal DiscreteVector2(UnityEngine.Vector2 丘丑丛丕下丈世下丂)
    {
        mem[1152921526221201296] = (int)丘丑丛丕下丈世下丂.x;
        mem[1152921526221201300] = (int)丘丑丛丕下丈世下丂.y;
    }
    public override bool Equals(object 万且万且丑丗且丌丆)
    {
    
    }
    public bool 万一丅上东七七丆下(DiscreteVector2 丘丛丏丘丝七世七丅)
    {
        if(W8 != 丘丛丏丘丝七世七丅._x)
        {
                return false;
        }
        
        return (bool)(W8 == (丘丛丏丘丝七世七丅._x >> 32)) ? 1 : 0;
    }
    public override int GetHashCode()
    {
        return (int)(W8 * 397) ^ W9;
    }
    public static bool 丌且丕丐丛上丅且丁(DiscreteVector2 万且丂丘丌业七与丞, DiscreteVector2 丅专丌丅业与丏丞下)
    {
        万且丂丘丌业七与丞._x = ((万且丂丘丌业七与丞._x == 丅专丌丅业与丏丞下._x) ? 1 : 0) & (((万且丂丘丌业七与丞._x >> 32) == (丅专丌丅业与丏丞下._x >> 32)) ? 1 : 0);
        return (bool)万且丂丘丌业七与丞._x;
    }
    public static bool 万丌专丅丘丘丟万东(DiscreteVector2 万且丂丘丌业七与丞, DiscreteVector2 丅专丌丅业与丏丞下)
    {
        万且丂丘丌业七与丞._x = ((万且丂丘丌业七与丞._x != 丅专丌丅业与丏丞下._x) ? 1 : 0) | (((万且丂丘丌业七与丞._x >> 32) != (丅专丌丅业与丏丞下._x >> 32)) ? 1 : 0);
        return (bool)万且丂丘丌业七与丞._x;
    }
    public static DiscreteVector2 丗丏丙丈不丛丆七丂(DiscreteVector2 与东丑丂丅丅丅丂上, DiscreteVector2 不丐丒丑丈丁丒世丟)
    {
        int val_1 = 不丐丒丑丈丁丒世丟._x & (-4294967296);
        val_1 = 与东丑丂丅丅丅丂上._x - val_1;
        val_1 = val_1 & (-4294967296);
        与东丑丂丅丅丅丂上._x = val_1 | (与东丑丂丅丅丅丂上._x - 不丐丒丑丈丁丒世丟._x);
        return new DiscreteVector2() {_x = 与东丑丂丅丅丅丂上._x, _y = 与东丑丂丅丅丅丂上._x};
    }
    public override string ToString()
    {
    
    }
    internal UnityEngine.Vector2 丙丕三丆丗下丟丒专()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  (float)S0, y:  (float)S1);
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    internal HexTiles.HexPosition get_HexPosition()
    {
    
    }
    internal HexTiles.HexCoords get_HexCoords()
    {
        return 106015064;
    }

}
