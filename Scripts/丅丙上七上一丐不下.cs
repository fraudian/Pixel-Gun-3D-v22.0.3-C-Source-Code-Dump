using UnityEngine;
internal interface 丅丙上七上一丐不下
{
    // Properties
    public abstract UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public abstract bool 丁丙世丕丐丕丞丈丂 { get; }
    public abstract float 丟丆丆丝东世一丒丐 { get; }
    public abstract int 丗且丗丞丝丄世上一 { get; set; }
    
    // Methods
    public abstract UnityEngine.Transform get_transform(); // 0
    public abstract bool get_isLivingTarget(); // 0
    public abstract float get_maxHealth(); // 0
    public abstract void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0); // 0
    public abstract bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗); // 0
    public abstract bool IsDead(); // 0
    public abstract int get_moduleResistShownFrame(); // 0
    public abstract void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东); // 0
    public abstract void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下); // 0

}
