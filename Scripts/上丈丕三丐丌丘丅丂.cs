using UnityEngine;
internal class 三丏世丟丟丙丟丙万.上丈丕三丐丌丘丅丂
{
    // Fields
    internal ItemRarity Grade;
    internal int Level;
    internal int LevelV3;
    internal int BuyCurrency;
    internal float PricesCoef;
    internal Rilisoft.丝丑丂丛万丐丈丘且 AmmoInClip;
    internal Rilisoft.丝丑丂丛万丐丈丘且 InitialAmmo;
    internal Rilisoft.丝丑丂丛万丐丈丘且 MaxAmmo;
    internal Rilisoft.丒且丐三丁丅丕一业 SpeedModif;
    internal Rilisoft.丒且丐三丁丅丕一业 RocketSpeed;
    internal int ShopFireRate;
    internal int ShopMobility;
    internal System.Nullable<float> HeadshotCoef;
    internal float ReloadSpeedCoef;
    internal float ShootSpeedCoef;
    internal Rilisoft.丒且丐三丁丅丕一业 DpsBattleRoyal;
    internal Rilisoft.丝丑丂丛万丐丈丘且 AmmoBattleRoyal;
    internal Rilisoft.丒且丐三丁丅丕一业 DpsCoef;
    internal System.Collections.Generic.List<int> FilterMap;
    internal System.Nullable<bool> IsRocketHeadShot;
    internal System.Nullable<float> RocketRadiusDamage;
    internal System.Nullable<float> RocketRadiusDamageSelf;
    internal System.Nullable<float> OtherParam;
    
    // Methods
    internal string 不业业丌下丁丅上丆()
    {
        var val_6;
        int val_7;
        val_6 = null;
        val_6 = null;
        PGCompany.丙万丙下三下丄丌丄 val_4 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  (this.BuyCurrency == 1) ? 1015 : ((this.BuyCurrency == 2) ? 2015 : 丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东));
        if(val_4 != null)
        {
                if(val_4.业上丙丞丐丄丆丅七() != null)
        {
                return (string)val_7;
        }
        
        }
        
        val_7 = System.String.alignConst;
        return (string)val_7;
    }
    public 三丏世丟丟丙丟丙万.上丈丕三丐丌丘丅丂()
    {
        this.PricesCoef = 1f;
        this.ReloadSpeedCoef = 1f;
        this.ShootSpeedCoef = 1f;
    }

}
