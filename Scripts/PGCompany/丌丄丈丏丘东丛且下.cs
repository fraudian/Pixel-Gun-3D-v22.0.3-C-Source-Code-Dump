using UnityEngine;

namespace PGCompany
{
    internal sealed class 丌丄丈丏丘东丛且下
    {
        // Fields
        private PGCompany.丙且丟业丗世下丈且.丅万丂世不丘丕下一 丒丄丅丟丞丅丄七丕;
        private System.Version 丙丗与丝丟丅且丒上;
        private System.Version 丞丈一且业上万丅专;
        
        // Properties
        internal string 丟丘丛七丄丞七丑世 { get; }
        internal string 丝丏丕且丂丟丞丙丌 { get; }
        internal string 丞丕丝一与丑东丅丑 { get; }
        internal UnityEngine.Texture 丌丟三丅上丅上丗丞 { get; }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 下丐丐丁与丂下世七 { get; }
        internal System.Version 一丌不丟业丛万且丟 { get; }
        internal System.Version 万丆丄丒东丌三丝丅 { get; }
        internal bool 丑丐丐丏不丘丕一三 { get; }
        internal bool 丟丗丄丁丐不丌七丌 { get; }
        internal bool 业丆七丙丝丌丁万丏 { get; }
        
        // Methods
        internal string 丘丟七丄三上业万丐()
        {
            if(this.丒丄丅丟丞丅丄七丕 != null)
            {
                    return (string)this.丒丄丅丟丞丅丄七丕.KeyTitle;
            }
            
            return (string)this.丒丄丅丟丞丅丄七丕.KeyTitle;
        }
        internal string 丟丂不丟世丟丄丑丄()
        {
            if(this.丒丄丅丟丞丅丄七丕 != null)
            {
                    return (string)this.丒丄丅丟丞丅丄七丕.KeyBody;
            }
            
            return (string)this.丒丄丅丟丞丅丄七丕.KeyBody;
        }
        internal string 丏万丙丒丅业丆丙丑()
        {
            if(this.丒丄丅丟丞丅丄七丕 != null)
            {
                    return (string)this.丒丄丅丟丞丅丄七丕.KeyTextReward;
            }
            
            return (string)this.丒丄丅丟丞丅丄七丕.KeyTextReward;
        }
        internal UnityEngine.Texture 丆下世世丟七专丞丒()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + this.丒丄丅丟丞丅丄七丕.MainTexture);
        }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丏丁东上与东丙丕()
        {
            if(this.丒丄丅丟丞丅丄七丕 != null)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this.丒丄丅丟丞丅丄七丕.Rewards;
            }
            
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this.丒丄丅丟丞丅丄七丕.Rewards;
        }
        internal System.Version 丄上丕丙丕丑丆丛丘()
        {
            System.Version val_3;
            if((System.Version.op_Equality(v1:  this.丙丗与丝丟丅且丒上, v2:  0)) != false)
            {
                    this.丙丗与丝丟丅且丒上 = System.Version.Parse(input:  this.丒丄丅丟丞丅丄七丕.VersionForBanner);
                return val_3;
            }
            
            val_3 = this.丙丗与丝丟丅且丒上;
            return val_3;
        }
        internal System.Version 丟三七丛丑丁丒丗三()
        {
            System.Version val_3;
            if((System.Version.op_Equality(v1:  this.丞丈一且业上万丅专, v2:  0)) != false)
            {
                    this.丞丈一且业上万丅专 = System.Version.Parse(input:  this.丒丄丅丟丞丅丄七丕.VersionForReward);
                return val_3;
            }
            
            val_3 = this.丞丈一且业上万丅专;
            return val_3;
        }
        internal bool 丅业东万丌丕上丌丄(long 丌丕三丌丈且丞且丆)
        {
            return this.丅业东万丌丕上丌丄(丌丕三丌丈且丞且丆:  丌丕三丌丈且丞且丆);
        }
        internal bool 丙丄与世丁丛丞业不()
        {
            var val_7;
            if(this.丒丄丅丟丞丅丄七丕.Rewards.Count >= 1)
            {
                    if((System.Version.op_LessThan(v1:  PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世().丐下丗丏不且丟丁丅().丟三七丛丑丁丒丗三(), v2:  this.丟三七丛丑丁丒丗三())) == false)
            {
                    return this.丙丞专丝万七一东丆();
            }
            
                val_7 = 1;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        internal bool 丙丞专丝万七一东丆()
        {
            return System.Version.op_Equality(v1:  PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世().丐下丗丏不且丟丁丅().丞下丈七丈三丄不丙(), v2:  this.丄上丕丙丕丑丆丛丘());
        }
        internal bool 丂丝丕东东世三丅与()
        {
            var val_4;
            if(this.丙丄与世丁丛丞业不() != false)
            {
                    val_4 = this.丙丞专丝万七一东丆() ^ 1;
                return (bool)val_4 & 1;
            }
            
            val_4 = 0;
            return (bool)val_4 & 1;
        }
        internal 丌丄丈丏丘东丛且下(PGCompany.丙且丟业丗世下丈且.丅万丂世不丘丕下一 与不丕丆丈不丙丟丛)
        {
            this.丒丄丅丟丞丅丄七丕 = 与不丕丆丈不丙丟丛;
        }
        internal bool 丅业东万丌丕上丌丄(int 丌丕三丌丈且丞且丆)
        {
            var val_5;
            long val_2 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = this.丒丄丅丟丞丅丄七丕.DateEnd});
            if((专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = this.丒丄丅丟丞丅丄七丕.DateStart})) > (丌丕三丌丈且丞且丆 << ))
            {
                    val_5 = 0;
                return (bool)val_5;
            }
            
            val_5 = ((val_2 > (long)丌丕三丌丈且丞且丆) ? 1 : 0) | ((val_2 < 1) ? 1 : 0);
            return (bool)val_5;
        }
        internal bool 七丙世业七万丈丆丄()
        {
            var val_4;
            var val_5;
            val_4 = this;
            if(this.丂丝丕东东世三丅与() != false)
            {
                    val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_3 = val_4.丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  this.丒丄丅丟丞丅丄七丕.Rewards, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
                val_5 = 1;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
    
    }

}
