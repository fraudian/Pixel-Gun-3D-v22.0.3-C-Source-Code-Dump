using UnityEngine;
internal static class 丝丙一上业丁且丄不
{
    // Methods
    internal static DiscreteVector2 下丏且一三丐一丐不(DiscreteVector2 下业丕七东丌丝下且, 丏丑东丐下丘丘丄丌 丒丈丘业丛丁丏丙丘, int 丌七丒世丄上丞丞丁 = 1)
    {
        int val_18 = 丌七丒世丄上丞丞丁;
        DiscreteVector2 val_1 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  0);
        if(丒丈丘业丛丁丏丙丘 > 6)
        {
                return new DiscreteVector2() {_x = val_9._x, _y = val_9._x};
        }
        
        var val_10 = 106018812 + (丒丈丘业丛丁丏丙丘) << 2;
        val_10 = val_10 + 106018812;
        goto (106018812 + (丒丈丘业丛丁丏丙丘) << 2 + 106018812);
    }
    internal static System.Collections.Generic.List<DiscreteVector2> 不丆丝丞丛丟与丝不(DiscreteVector2 下业丕七东丌丝下且, int 且丛上丕业丂丒与一 = 1)
    {
        int val_4 = 下业丕七东丌丝下且._x;
        System.Collections.Generic.List<DiscreteVector2> val_1 = new System.Collections.Generic.List<DiscreteVector2>();
        if(且丛上丕业丂丒与一 >= 1)
        {
                int val_4 = 且丛上丕业丂丒与一;
            do
        {
            DiscreteVector2 val_2 = 丝丙一上业丁且丄不.下丏且一三丐一丐不(下业丕七东丌丝下且:  new DiscreteVector2() {_x = val_4, _y = 下业丕七东丌丝下且._y}, 丒丈丘业丛丁丏丙丘:  5, 丌七丒世丄上丞丞丁:  1);
            val_4 = val_4 - 1;
            val_4 = val_2._x;
        }
        while(val_4 != 0);
        
        }
        
        丏丑东丐下丘丘丄丌 val_6 = 1;
        do
        {
            int val_5 = 且丛上丕业丂丒与一;
            if(且丛上丕业丂丒与一 >= 1)
        {
                do
        {
            DiscreteVector2 val_3 = 丝丙一上业丁且丄不.下丏且一三丐一丐不(下业丕七东丌丝下且:  new DiscreteVector2() {_x = val_4, _y = val_2._y}, 丒丈丘业丛丁丏丙丘:  val_6, 丌七丒世丄上丞丞丁:  1);
            val_1.Add(item:  new DiscreteVector2() {_x = val_3._x, _y = val_3._y});
            val_5 = val_5 - 1;
        }
        while(val_5 != 0);
        
        }
        
            val_6 = val_6 + 1;
        }
        while(val_6 != 7);
        
        return val_1;
    }
    internal static System.Collections.Generic.List<DiscreteVector2> 业丗丕丌丏丁丗丁万(DiscreteVector2 下业丕七东丌丝下且, int 且丛上丕业丂丒与一 = 1)
    {
        System.Collections.Generic.List<DiscreteVector2> val_1 = new System.Collections.Generic.List<DiscreteVector2>();
        if(且丛上丕业丂丒与一 < 1)
        {
                return val_1;
        }
        
        var val_3 = 1;
        do
        {
            val_1.AddRange(collection:  丝丙一上业丁且丄不.不丆丝丞丛丟与丝不(下业丕七东丌丝下且:  new DiscreteVector2() {_x = 下业丕七东丌丝下且._x, _y = 下业丕七东丌丝下且._y}, 且丛上丕业丂丒与一:  1));
            val_3 = val_3 + 1;
        }
        while(val_3 <= 且丛上丕业丂丒与一);
        
        return val_1;
    }
    internal static bool 万丙丕丈丈上丟丌丌(DiscreteVector2 丆丛丑世下一丐且丕, DiscreteVector2 丌丗丏丏丛东专丁且, int 且丛上丕业丂丒与一 = 1)
    {
        System.Collections.Generic.List<DiscreteVector2> val_1 = 丝丙一上业丁且丄不.业丗丕丌丏丁丗丁万(下业丕七东丌丝下且:  new DiscreteVector2() {_x = 丆丛丑世下一丐且丕._x, _y = 丆丛丑世下一丐且丕._y}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一);
        if(val_1 != null)
        {
                return val_1.Contains(item:  new DiscreteVector2() {_x = 丌丗丏丏丛东专丁且._x, _y = 丌丗丏丏丛东专丁且._y});
        }
        
        return val_1.Contains(item:  new DiscreteVector2() {_x = 丌丗丏丏丛东专丁且._x, _y = 丌丗丏丏丛东专丁且._y});
    }
    internal static UnityEngine.Vector3 与一丅丙丛丈下万丌(DiscreteVector2 丗丒且世丆专丄三专, float 丒丆一丄丛丒且万七, float 上丘万且丁丏下丂与 = 0)
    {
        float val_7 = 0.5f;
        float val_4 = (float)丗丒且世丆专丄三专._x.GetHashCode();
        float val_5 = 1.152922E+18f;
        val_4 = val_4 * val_7;
        val_5 = val_4 + val_5;
        float val_8 = 1.732051f;
        float val_6 = 3f;
        float val_3 = 丒丆一丄丛丒且万七 * val_7;
        val_6 = val_3 * val_6;
        val_7 = val_6 * val_7;
        val_8 = val_3 * val_8;
        val_8 = val_8 * val_5;
        val_7 = val_7 * (float)丗丒且世丆专丄三专._x.GetHashCode();
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal static 丏丑东丐下丘丘丄丌 万丅与丁丙丈丙东且(DiscreteVector2 丈丗与丞一上且上上, DiscreteVector2 专丂丕丗丗东世丞下)
    {
        丏丑东丐下丘丘丄丌 val_3;
        do
        {
            val_3 = 1;
            DiscreteVector2 val_1 = 丝丙一上业丁且丄不.下丏且一三丐一丐不(下业丕七东丌丝下且:  new DiscreteVector2() {_x = 丈丗与丞一上且上上._x, _y = 丈丗与丞一上且上上._y}, 丒丈丘业丛丁丏丙丘:  val_3, 丌七丒世丄上丞丞丁:  1);
            if((DiscreteVector2.丌且丕丐丛上丅且丁(万且丂丘丌业七与丞:  new DiscreteVector2() {_x = val_1._x, _y = val_1._y}, 丅专丌丅业与丏丞下:  new DiscreteVector2() {_x = 专丂丕丗丗东世丞下._x, _y = 专丂丕丗丗东世丞下._y})) == true)
        {
                return (丏丑东丐下丘丘丄丌)val_3;
        }
        
        }
        while(val_3 <= 5);
        
        val_3 = 0;
        return (丏丑东丐下丘丘丄丌)val_3;
    }

}
