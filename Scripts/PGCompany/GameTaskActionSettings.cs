using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class GameTaskActionSettings
    {
        // Fields
        internal PGCompany.丒丘且上丟专东不丐 Type;
        internal Rilisoft.丝丑丂丛万丐丈丘且 Version;
        internal Rilisoft.丝丑丂丛万丐丈丘且 NeededCount;
        internal Rilisoft.丝丑丂丛万丐丈丘且 IntParam;
        internal string StringParam;
        internal Rilisoft.丝丑丂丛万丐丈丘且 ItemRarity;
        internal int cellIndex;
        private Rilisoft.丝丑丂丛万丐丈丘且 _perMatch;
        private Rilisoft.丝丑丂丛万丐丈丘且 _perLife;
        internal Rilisoft.七丕丟丏三丈一丄世 GameMode;
        internal 丐七不丝丆丐丂丐下 Complexity;
        internal string Map;
        private Rilisoft.丝丑丂丛万丐丈丘且 _inParty;
        internal CategoryNames ItemCategory;
        internal Rilisoft.丝丑丂丛万丐丈丘且 ItemIndex;
        internal 丈下专丂丑不丑丗丁 ItemObtainPlace;
        internal PGCompany.ModuleData.ModuleCategory ModuleCategory;
        internal PGCompany.ModuleData.ModuleType ModuleType;
        internal string WeaponSetId;
        internal WeaponSounds.丈不三丛七丑丈丑丆 WeaponEffect;
        internal GadgetCategory GadgetCategory;
        private Rilisoft.丝丑丂丛万丐丈丘且 _shouldWin;
        private Rilisoft.丝丑丂丛万丐丈丘且 _noDeath;
        private Rilisoft.丝丑丂丛万丐丈丘且 _noDamage;
        private Rilisoft.丝丑丂丛万丐丈丘且 _notTakingDamage;
        private Rilisoft.丝丑丂丛万丐丈丘且 _notTakingZoneDamage;
        internal Rilisoft.丝丑丂丛万丐丈丘且 InARow;
        private Rilisoft.丝丑丂丛万丐丈丘且 _isNoArmor;
        internal Rilisoft.丝丑丂丛万丐丈丘且 Rank;
        private Rilisoft.丝丑丂丛万丐丈丘且 _killInHead;
        private Rilisoft.丝丑丂丛万丐丈丘且 _isSelfInvisible;
        private Rilisoft.丝丑丂丛万丐丈丘且 _isZoomShot;
        internal string Zone;
        private Rilisoft.丝丑丂丛万丐丈丘且 _enemyInvisible;
        private Rilisoft.丝丑丂丛万丐丈丘且 _clanWarChallange;
        private Rilisoft.丝丑丂丛万丐丈丘且 _isBrawl;
        private Rilisoft.丝丑丂丛万丐丈丘且 _isCompetition;
        internal PGCompany.BattlePass.业专丒丟且丝七丑丁 BPChallengeOpenType;
        internal PGCompany.PixelPass.丒且丏万业业七业万 PixelPassTaskOpenType;
        internal string ClanChestType;
        internal Rilisoft.丝丑丂丛万丐丈丘且 MobRole;
        private Rilisoft.丝丑丂丛万丐丈丘且 _isClanGadget;
        private Rilisoft.丝丑丂丛万丐丈丘且 _isClanWeapon;
        internal string CompoundTag;
        internal 丘丌丒丑一七丁丑一 TrainingStage;
        private Rilisoft.丝丑丂丛万丐丈丘且 _inSquad;
        internal Rilisoft.丝丑丂丛万丐丈丘且 squadCount;
        internal Rilisoft.丝丑丂丛万丐丈丘且 distance;
        internal Rilisoft.丝丑丂丛万丐丈丘且 health;
        internal Rilisoft.丝丑丂丛万丐丈丘且 armor;
        private Rilisoft.丝丑丂丛万丐丈丘且 _inCar;
        private Rilisoft.丝丑丂丛万丐丈丘且 _enemyinCar;
        private Rilisoft.丝丑丂丛万丐丈丘且 _revenge;
        private Rilisoft.丝丑丂丛万丐丈丘且 _pickupHealth;
        private Rilisoft.丝丑丂丛万丐丈丘且 _pickupAmmo;
        private Rilisoft.丝丑丂丛万丐丈丘且 _pickupArmor;
        private Rilisoft.丝丑丂丛万丐丈丘且 _pickupSecret;
        private Rilisoft.丝丑丂丛万丐丈丘且 _usingGadget;
        internal Player_move_c.丐上丅与业下丈下丗 HealReason;
        internal PGCompany.丝丗丁丞丒且丙丑丙 PromotionType;
        internal Rilisoft.GameEventType GameEventType;
        internal PGCompany.丟丟丈丙万丂上与不 connectSceneTutorialFingerAction;
        internal System.Collections.Generic.List<string> ZoneTags;
        internal 丏丐丏丘下东丁丐一 TransportType;
        
        // Properties
        internal bool PerMatch { get; set; }
        internal bool PerLife { get; set; }
        internal bool InParty { get; set; }
        internal bool ShouldWin { get; set; }
        internal bool NoDeath { get; set; }
        internal bool NoDamage { get; set; }
        internal bool NotTakingDamage { get; set; }
        internal bool NotTakingZoneDamage { get; set; }
        internal bool IsNoArmor { get; set; }
        internal bool KillInHead { get; set; }
        internal bool IsSelfInvisible { get; set; }
        internal bool IsZoomShot { get; set; }
        internal bool EnemyInvisible { get; set; }
        internal bool IsClanWarChallange { get; set; }
        internal bool IsBrawl { get; set; }
        internal bool IsCompetition { get; set; }
        internal bool IsClanGadget { get; set; }
        internal bool IsClanWeapon { get; set; }
        internal bool InSquad { get; set; }
        internal bool InCar { get; set; }
        internal bool EnemyInCar { get; set; }
        internal bool Revenge { get; set; }
        internal bool PickupHealth { get; }
        internal bool PickupAmmo { get; }
        internal bool PickupArmor { get; }
        internal bool PickupSecret { get; }
        internal bool UsingGadget { get; }
        
        // Methods
        internal bool get_PerMatch()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._perMatch);
        }
        internal void set_PerMatch(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._perMatch = val_3;
            mem[1152921555433024272] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_PerLife()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._perLife);
        }
        internal void set_PerLife(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._perLife = val_3;
            mem[1152921555433248288] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_InParty()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._inParty);
        }
        internal void set_InParty(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._inParty = val_3;
            mem[1152921555433472320] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_ShouldWin()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._shouldWin);
        }
        internal void set_ShouldWin(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._shouldWin = val_3;
            mem[1152921555433696392] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_NoDeath()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._noDeath);
        }
        internal void set_NoDeath(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._noDeath = val_3;
            mem[1152921555433920408] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_NoDamage()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._noDamage);
        }
        internal void set_NoDamage(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._noDamage = val_3;
            mem[1152921555434144424] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_NotTakingDamage()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._notTakingDamage);
        }
        internal void set_NotTakingDamage(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._notTakingDamage = val_3;
            mem[1152921555434368440] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_NotTakingZoneDamage()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._notTakingZoneDamage);
        }
        internal void set_NotTakingZoneDamage(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._notTakingZoneDamage = val_3;
            mem[1152921555434592456] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_IsNoArmor()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._isNoArmor);
        }
        internal void set_IsNoArmor(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._isNoArmor = val_3;
            mem[1152921555434816488] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_KillInHead()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._killInHead);
        }
        internal void set_KillInHead(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._killInHead = val_3;
            mem[1152921555435040520] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_IsSelfInvisible()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._isSelfInvisible);
        }
        internal void set_IsSelfInvisible(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._isSelfInvisible = val_3;
            mem[1152921555435264536] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_IsZoomShot()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._isZoomShot);
        }
        internal void set_IsZoomShot(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._isZoomShot = val_3;
            mem[1152921555435488552] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_EnemyInvisible()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._enemyInvisible);
        }
        internal void set_EnemyInvisible(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._enemyInvisible = val_3;
            mem[1152921555435712576] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_IsClanWarChallange()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._clanWarChallange);
        }
        internal void set_IsClanWarChallange(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._clanWarChallange = val_3;
            mem[1152921555435936592] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_IsBrawl()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._isBrawl);
        }
        internal void set_IsBrawl(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._isBrawl = val_3;
            mem[1152921555436160608] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_IsCompetition()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._isCompetition);
        }
        internal void set_IsCompetition(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
            this._isCompetition = val_3;
            mem[1152921555436384624] = val_3.上万三丆专丏丒丗业;
        }
        internal bool get_IsClanGadget()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._isClanGadget);
        }
        internal void set_IsClanGadget(bool 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_3 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东);
            this._isClanGadget = 0;
            mem[1152921555436608672] = 0;
        }
        internal bool get_IsClanWeapon()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._isClanWeapon);
        }
        internal void set_IsClanWeapon(bool 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_3 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东);
            this._isClanWeapon = 0;
            mem[1152921555436832688] = 0;
        }
        internal bool get_InSquad()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._inSquad);
        }
        internal void set_InSquad(bool 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_3 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东);
            this._inSquad = 0;
            mem[1152921555437056720] = 0;
        }
        internal bool get_InCar()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._inCar);
        }
        internal void set_InCar(bool 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_3 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东);
            this._inCar = 0;
            mem[1152921555437280800] = 0;
        }
        internal bool get_EnemyInCar()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._enemyinCar);
        }
        internal void set_EnemyInCar(bool 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_3 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东);
            this._enemyinCar = 0;
            mem[1152921555437504816] = 0;
        }
        internal bool get_Revenge()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._revenge);
        }
        internal void set_Revenge(bool 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_3 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东);
            this._revenge = 0;
            mem[1152921555437728832] = 0;
        }
        internal bool get_PickupHealth()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._pickupHealth);
        }
        internal bool get_PickupAmmo()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._pickupAmmo);
        }
        internal bool get_PickupArmor()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._pickupArmor);
        }
        internal bool get_PickupSecret()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._pickupSecret);
        }
        internal bool get_UsingGadget()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this._usingGadget);
        }
        public GameTaskActionSettings()
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            this.ItemRarity = val_1;
            mem[1152921555438400248] = val_1.上万三丆专丏丒丗业;
            this.GameMode = 100;
            this.ItemCategory = 9990000;
            this.WeaponEffect = 99999;
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            this.MobRole = val_2;
            mem[1152921555438400656] = val_2.上万三丆专丏丒丗业;
            this.HealReason = 7;
        }
    
    }

}
