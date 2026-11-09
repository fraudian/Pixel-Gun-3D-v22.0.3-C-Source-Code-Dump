using UnityEngine;

namespace PGCompany
{
    internal sealed class 丘三丏丌丗丒万丏丈 : 丒丘与丞丐不七丈与
    {
        // Fields
        private PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 丙七丘丅丛丘万三丞;
        
        // Properties
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        internal override CategoryNames 七丌丌丏丗东丕且丅 { get; }
        internal PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 丗七丐丏丙丟丟世丟 { get; }
        
        // Methods
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 == null)
            {
                    return (ItemRarity)val_1;
            }
            
            return val_1.七东与丄丕丁丛世三();
        }
        internal override CategoryNames 丒万丕七专不丏丞丌()
        {
            return 250000;
        }
        internal PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 上丄丂丄丙丗丛丌丟()
        {
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_5 = this.丙七丘丅丛丘万三丞;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_2 = PGCompany.ItemVisualSystem.丄万丛且一丈与丝不.丙丘丝七业丟丁与丛(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不());
            this.丙七丘丅丛丘万三丞 = val_2;
            if(val_2 != null)
            {
                    return val_5;
            }
            
            丆丟丟三丗东一丆三.丅丟丝丏七业下丟丗(丕丗丘丑丛与丑业丒:  "In ItemVisual not info by graffiti: "("In ItemVisual not info by graffiti: ") + this.业上丙丞丐丄丆丅七() + " !!!"(" !!!"));
            val_5 = this.丙七丘丅丛丘万三丞;
            return val_5;
        }
        public 丘三丏丌丗丒万丏丈(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            int val_3;
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 != null)
            {
                    if(val_1.丛专丑丘且丘丑世世() != null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        internal override string 东且丏丆万与东丙万()
        {
            int val_3;
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 != null)
            {
                    val_3 = val_1.丑世不丂万下业丟丒();
                if(val_3 != null)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3 = System.String.alignConst);
            }
            
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3);
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            string val_4;
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            val_4 = 0;
            if(val_1 == null)
            {
                    return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + val_4);
            }
            
            val_4 = val_1.一丄专三丒上丆万世();
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + val_4);
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            object val_5;
            PGCompany.ItemVisualSystem.丝丅丛丙与且丆业且 val_1 = this.上丄丂丄丙丗丛丌丟();
            if(val_1 != null)
            {
                    int val_2 = val_1.丕丌丐丙丑丙丌世下();
                val_5 = 0;
                return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferMiniIcons/{0}", arg0:  val_5 = 0));
            }
            
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferMiniIcons/{0}", arg0:  val_5));
        }
        internal override string 丟七万东万七丙丘丌()
        {
            null = null;
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.丏丁丐下丐丌丂丆万.Item[this])(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.丏丁丐下丐丌丂丆万.Item[this])) + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this));
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丘三丏丌丗丒万丏丈(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
