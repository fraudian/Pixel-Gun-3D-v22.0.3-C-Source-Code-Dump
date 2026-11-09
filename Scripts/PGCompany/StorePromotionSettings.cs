using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class StorePromotionSettings
    {
        // Fields
        internal string TitleLocKey;
        internal string DescriptionLocKey;
        internal string AditionalDescriptionLocKey;
        internal string TexturePath;
        internal PGCompany.丑丘丂丝丐上丆丆世 DescriptionHandlerType;
        internal string MainPrefabName;
        internal string InfoPrefabName;
        internal string BannerPrefabName;
        internal string ExtendPrefabName;
        internal string RewardPrefabName;
        internal PGCompany.StorePromotionPurchaseSettings PurchaseSettings;
        internal PGCompany.丝且七万丄一丏丌丙 CountStorageType;
        internal Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 ObtainCurrencyCause;
        internal Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 SpendCurrencyCause;
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> ItemsParams;
        internal Rilisoft.丝丑丂丛万丐丈丘且 StartTime;
        internal Rilisoft.丝丑丂丛万丐丈丘且 EndTime;
        internal decimal ContentPrice;
        internal TagSystem.三与下丘七丘丌丏丄 Tag;
        internal PGCompany.DataObjects.IntInterval CollectProgress;
        internal string InfoPrefabNameAlternative;
        internal 丈下专丂丑不丑丗丁 ItemObtainPlace;
        internal Rilisoft.丝丑丂丛万丐丈丘且 Level;
        internal System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> ItemRewards;
        internal Rilisoft.丝丑丂丛万丐丈丘且 PresentationTime;
        internal Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 ObtainWeaponCause;
        internal string GuiStyleMain;
        internal string BackgroundTexture;
        internal string IconFullBanner;
        internal string IconMiniBannerLobby;
        internal string IconBankCell;
        internal string TimerLocKey;
        internal string ButtonBuyLocKey;
        internal string PriceLocKey;
        internal string SaleLocKey;
        internal string OldPriceLocKey;
        internal string SaleStringValue;
        internal PGCompany.三东丏不丗世丅丌丄 OldPrice;
        internal int OldCount;
        internal string MiniBannerPrefabName;
        internal System.Collections.Generic.List<PGCompany.Attributes.丝万专丆丂丘丌世丟> Lockers;
        internal PGCompany.丏丈丈且东丅上丄丙 ItemObtainSource;
        internal UniversalRewardController.丑三不丕丘丞不丏下 UniversalRewardParams;
        
        // Methods
        public StorePromotionSettings()
        {
            this.ObtainCurrencyCause = 126;
            this.ItemsParams = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            this.Tag = new TagSystem.三与下丘七丘丌丏丄();
            this.ItemRewards = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            this.ObtainWeaponCause = 25;
        }
    
    }

}
