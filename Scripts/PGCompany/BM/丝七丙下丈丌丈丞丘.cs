using UnityEngine;

namespace PGCompany.BM
{
    internal sealed class 丝七丙下丈丌丈丞丘
    {
        // Fields
        internal int _seasonId;
        internal int _checkPurchasesInterval;
        internal System.Collections.Generic.List<PGCompany.BM.丁七上一三丁上丑丑> _cells;
        internal System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> _dropRules;
        internal System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> _currencyConvertation;
        internal PGCompany.BM.丟与业丄世七丏下丌 _upgradeRules;
        internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.Dictionary<int, Rilisoft.丝丑丂丛万丐丈丘且>> _buyRewards;
        internal PGCompany.BM.丝七丙下丈丌丈丞丘.世与七丄且丆丙丗丘 _refreshParameters;
        
        // Properties
        public int 丌丗丏丝丈丒一一丞 { get; set; }
        internal int 丁东丑东万专丌丂专 { get; set; }
        internal System.Collections.Generic.List<PGCompany.BM.丁七上一三丁上丑丑> 丂万丟不丅不丝专丞 { get; set; }
        internal System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 丕专丌丐东丑丌丒丌 { get; set; }
        internal System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丑丏东万上丕丌与丆 { get; set; }
        internal PGCompany.BM.丟与业丄世七丏下丌 丟与丁一丏不丕丞丆 { get; set; }
        internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.Dictionary<int, Rilisoft.丝丑丂丛万丐丈丘且>> 丈丝丆业东丘业不丁 { get; set; }
        internal PGCompany.BM.丝七丙下丈丌丈丞丘.世与七丄且丆丙丗丘 丏东丛专丐下与且七 { get; set; }
        
        // Methods
        public int 万上丁一丞业业万东()
        {
            return (int)this._seasonId;
        }
        public void 丟一三丁丈丈丘丂丘(int 丙业与丙丗丝不丈东)
        {
            this._seasonId = 丙业与丙丗丝不丈东;
        }
        internal int 丄丈丌丈三万万且丁()
        {
            return (int)this._checkPurchasesInterval;
        }
        internal void 丗丑丅且丑不丗丂丂(int 丙业与丙丗丝不丈东)
        {
            this._checkPurchasesInterval = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.List<PGCompany.BM.丁七上一三丁上丑丑> 丂丘业丐丕三上七且()
        {
            return (System.Collections.Generic.List<PGCompany.BM.丁七上一三丁上丑丑>)this._cells;
        }
        internal void 七万丘且丑丂且丑与(System.Collections.Generic.List<PGCompany.BM.丁七上一三丁上丑丑> 丙业与丙丗丝不丈东)
        {
            this._cells = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 丅丗丐丙丛丝丁专丞()
        {
            return (System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世>)this._dropRules;
        }
        internal void 一丈丘三丅七丟专与(System.Collections.Generic.List<PGCompany.BM.丒万丗丏一丝丅丌世> 丙业与丙丗丝不丈东)
        {
            this._dropRules = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丈万丕七丕丒业丛丁()
        {
            return (System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>)this._currencyConvertation;
        }
        internal void 与丛丞万上业丄丈丞(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丙业与丙丗丝不丈东)
        {
            this._currencyConvertation = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.BM.丟与业丄世七丏下丌 专丆三丁丈丁一七丁()
        {
            return (PGCompany.BM.丟与业丄世七丏下丌)this._upgradeRules;
        }
        internal void 与世万下丟丑不丈丆(PGCompany.BM.丟与业丄世七丏下丌 丙业与丙丗丝不丈东)
        {
            this._upgradeRules = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.Dictionary<int, Rilisoft.丝丑丂丛万丐丈丘且>> 七丄丆三且一不丙丂()
        {
            return (System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>>)this._buyRewards;
        }
        internal void 一丟丒丆专丟丂一丒(System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.Dictionary<int, Rilisoft.丝丑丂丛万丐丈丘且>> 丙业与丙丗丝不丈东)
        {
            this._buyRewards = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.BM.丝七丙下丈丌丈丞丘.世与七丄且丆丙丗丘 丝丁丐丈丗丅专与丛()
        {
            return (世与七丄且丆丙丗丘)this._refreshParameters;
        }
        internal void 上丈丈丐世丗丌一且(PGCompany.BM.丝七丙下丈丌丈丞丘.世与七丄且丆丙丗丘 丙业与丙丗丝不丈东)
        {
            this._refreshParameters = 丙业与丙丗丝不丈东;
        }
        public 丝七丙下丈丌丈丞丘()
        {
            this._seasonId = 31;
            this._checkPurchasesInterval = 30;
        }
    
    }

}
