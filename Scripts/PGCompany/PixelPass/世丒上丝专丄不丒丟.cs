using UnityEngine;

namespace PGCompany.PixelPass
{
    internal sealed class 世丒上丝专丄不丒丟
    {
        // Fields
        internal PGCompany.PixelPass.世丛丏丏上世丑东丕 Common;
        internal System.Collections.Generic.List<PGCompany.PixelPass.丆丄万专丄万不世丁> Pages;
        internal System.Collections.Generic.List<PGCompany.PixelPass.世丗丘丈丄丙七丆七> Levels;
        internal System.Collections.Generic.List<PGCompany.PixelPass.丕丙丝业丁丏丝丞丄> Tasks;
        internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> _premiumTaskIndexes;
        internal System.Collections.Generic.List<PGCompany.PixelPass.丙一丘一一丟丄丈世> TasksBase;
        internal System.Collections.Generic.List<PGCompany.PixelPass.丁七业丂与业丒丑丈> TasksForAds;
        internal PGCompany.PixelPass.三丟业丆丌丅丟丕丞 GameRewards;
        internal System.Collections.Generic.List<PGCompany.且丏丝丗丞丅丂丝丂> Offers;
        
        // Properties
        internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丞丄不丞丒业丟丘丝 { get; set; }
        
        // Methods
        internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丑丛丄丛专三丏东丈()
        {
            if(this._premiumTaskIndexes != null)
            {
                    return (System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>)this._premiumTaskIndexes;
            }
            
            this._premiumTaskIndexes = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
            if(this.Tasks == null)
            {
                    return (System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>)this._premiumTaskIndexes;
            }
            
            List.Enumerator<T> val_2 = this.Tasks.GetEnumerator();
            label_9:
            if(((-91186248) & 1) == 0)
            {
                goto label_3;
            }
            
            if((丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = X22, 丑丒丄下丁丐专丄丞 = X22, 上万三丆专丏丒丗业 = X21})) == true)
            {
                goto label_9;
            }
            
            this._premiumTaskIndexes.Add(item:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_3.m_stringLength, 丑丒丄下丁丐专丄丞 = val_3.m_stringLength, 上万三丆专丏丒丗业 = 0.丐丏七丌丕丗业且上()});
            goto label_9;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>)this._premiumTaskIndexes;
        }
        internal void 丐三丄丑丑丕七丐且(System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丙业与丙丗丝不丈东)
        {
            this._premiumTaskIndexes = 丙业与丙丗丝不丈东;
        }
        public 世丒上丝专丄不丒丟()
        {
        
        }
    
    }

}
