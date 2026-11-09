using UnityEngine;
[Serializable]
internal sealed class RarityColorEntry
{
    // Fields
    internal int colorIndex;
    internal System.Collections.Generic.List<UIWidget> colorRessivers;
    
    // Methods
    internal void 丌万丌丙丌丆丐丁丐(ItemRarity 丈下丑丆上丏丗丈专)
    {
        List.Enumerator<T> val_1 = this.colorRessivers.GetEnumerator();
        label_5:
        if((505013464 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Color val_3 = RarityColorEntry.丝一丙丝上丛三丄丈(丈下丑丆上丏丗丈专:  丈下丑丆上丏丗丈专 = 丈下丑丆上丏丗丈专, 且丐且与丟丞业丈丗:  this.colorIndex);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  0.丐丏七丌丕丗业且上(), 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static UnityEngine.Color 丝一丙丝上丛三丄丈(ItemRarity 丈下丑丆上丏丗丈专, int 且丐且与丟丞业丈丗 = 0)
    {
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  System.String.Format(format:  "ItemRarity/{0}_{1}", arg0:  丈下丑丆上丏丗丈专, arg1:  且丐且与丟丞业丈丗));
        return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    public RarityColorEntry()
    {
    
    }

}
