using UnityEngine;
internal class 丟丗丒丏丈不丌专一 : IEqualityComparer<CategoryNames>
{
    // Methods
    public bool Equals(CategoryNames 一世不丄下丐丁丙丄, CategoryNames 丒与且丂丆丑丑丄东)
    {
        return (bool)(一世不丄下丐丁丙丄 == 丒与且丂丆丑丑丄东) ? 1 : 0;
    }
    public int GetHashCode(CategoryNames 丙丑丕丂下丏一丁专)
    {
        return (int)丙丑丕丂下丏一丁专.丙东专丂世丈丏丁丂();
    }
    public 丟丗丒丏丈不丌专一()
    {
    
    }

}
