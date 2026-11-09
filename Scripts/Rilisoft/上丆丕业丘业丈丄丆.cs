using UnityEngine;

namespace Rilisoft
{
    public interface 上丆丕业丘业丈丄丆
    {
        // Properties
        public abstract Rilisoft.丏丘七丞丄丙丌丞丁 丏丘七丞丄丙丌丞丁 { get; }
        public abstract bool 丟七一丏丈丒丘丝世 { get; set; }
        public abstract bool 且丗丈丈世丐丐万七 { get; set; }
        
        // Methods
        public abstract Rilisoft.丏丘七丞丄丙丌丞丁 get_LobbyItem(); // 0
        public abstract bool get_IsSelected(); // 0
        public abstract void set_IsSelected(bool 丙业与丙丗丝不丈东); // 0
        public abstract bool get_IsCrafting(); // 0
        public abstract void set_IsCrafting(bool 丙业与丙丗丝不丈东); // 0
        public abstract void Setup(UnityEngine.Transform 七万上丐一丈丏丏专, Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七); // 0
        public abstract void Hide(); // 0
        public abstract void UpdateView(); // 0
        public abstract void Kill(); // 0
    
    }

}
