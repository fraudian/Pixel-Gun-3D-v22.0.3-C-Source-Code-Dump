using UnityEngine;
internal static class 丆东丟下丌下丏上丌
{
    // Methods
    internal static BaseArmoryCell 万丒丙七丘不丁丈三(CategoryNames 七丆丒与丗丌丄且丂)
    {
        return (BaseArmoryCell)UnityEngine.Object.Instantiate<BaseArmoryCell>(original:  UnityEngine.Resources.Load<BaseArmoryCell>(path:  (七丆丒与丗丌丄且丂 == 140000) ? "SetArmoryCell" : "ArmoryCell"));
    }
    internal static ShopItemsRowContainer 专一丈丅丂丆丈丒丅()
    {
        return (ShopItemsRowContainer)UnityEngine.Object.Instantiate<ShopItemsRowContainer>(original:  UnityEngine.Resources.Load<ShopItemsRowContainer>(path:  "ShopRowItemsContainer"));
    }

}
