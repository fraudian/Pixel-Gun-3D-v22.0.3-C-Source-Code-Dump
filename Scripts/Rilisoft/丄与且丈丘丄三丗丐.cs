using UnityEngine;

namespace Rilisoft
{
    internal interface 丄与且丈丘丄三丗丐
    {
        // Properties
        public abstract Rilisoft.业丙丘丆东丈丕丂丄 与丄丏丞业三与东丗 { get; }
        public abstract Rilisoft.BonusData 丙丘专丝丄下下七丅 { get; }
        public abstract bool 丕丆下东丁丒丁丕丈 { get; }
        public abstract bool 丗七丟丏丏丑丞丅东 { get; set; }
        public abstract string 专丕与丒丗丁丘专丟 { get; }
        public abstract int 下丄丈不与世丐业专 { get; }
        
        // Methods
        public abstract Rilisoft.业丙丘丆东丈丕丂丄 get_Pack(); // 0
        public abstract Rilisoft.BonusData get_BonusData(); // 0
        public abstract bool get_AnimationsRunning(); // 0
        public abstract bool get_DisableAnimations(); // 0
        public abstract void set_DisableAnimations(bool 丙业与丙丗丝不丈东); // 0
        public abstract string get_Name(); // 0
        public abstract int get_Id(); // 0
        public abstract void add_HideRequest(System.Action 丙业与丙丗丝不丈东); // 0
        public abstract void remove_HideRequest(System.Action 丙业与丙丗丝不丈东); // 0
        public abstract void add_BuyRequest(System.Action 丙业与丙丗丝不丈东); // 0
        public abstract void remove_BuyRequest(System.Action 丙业与丙丗丝不丈东); // 0
        public abstract bool Show(Rilisoft.业丙丘丆东丈丕丂丄 不专一业下丞丝丑丗, Rilisoft.BonusData 丛丝丙丄七一丁丅三); // 0
        public abstract void Hide(System.Action 不丐世丞丏且丛丐业); // 0
        public abstract void HideForce(); // 0
        public abstract void Destroy(); // 0
    
    }

}
