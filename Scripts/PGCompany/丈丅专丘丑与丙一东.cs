using UnityEngine;

namespace PGCompany
{
    internal sealed class 丈丅专丘丑与丙一东 : 七丑丞丙东丄三丆上, 七专丙与东丘丌丘丈
    {
        // Fields
        private System.Lazy<CategoryNames> 专丄丌且一丕万与丛;
        
        // Properties
        internal override CategoryNames 七丌丌丏丗东丕且丅 { get; }
        
        // Methods
        internal override CategoryNames 丒万丕七专不丏丞丌()
        {
            if(this.专丄丌且一丕万与丛 != null)
            {
                    return this.专丄丌且一丕万与丛.Value;
            }
            
            return this.专丄丌且一丕万与丛.Value;
        }
        internal 丈丅专丘丑与丙一东(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.专丄丌且一丕万与丛 = new System.Lazy<CategoryNames>(valueFactory:  new System.Func<CategoryNames>(object:  this, method:  CategoryNames PGCompany.丈丅专丘丑与丙一东::世丒三专丞丒丘丌下()));
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        }
        internal override string 七业丑不七丐业丟丂()
        {
            string val_15 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_15 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this))) == true)
            {
                    return (string)val_15;
            }
            
            if(((val_15.EndsWith(value:  "up1", ignoreCase:  true, culture:  System.Globalization.CultureInfo.InvariantCulture)) != true) && ((val_15.EndsWith(value:  "up2", ignoreCase:  true, culture:  System.Globalization.CultureInfo.InvariantCulture)) != true))
            {
                    if((val_15.EndsWith(value:  "up 1", ignoreCase:  true, culture:  System.Globalization.CultureInfo.InvariantCulture)) != true)
            {
                    if((val_15.EndsWith(value:  "up 2", ignoreCase:  true, culture:  System.Globalization.CultureInfo.InvariantCulture)) == false)
            {
                    return (string)val_15;
            }
            
            }
            
            }
            
            val_15 = val_15.Substring(startIndex:  0, length:  val_15.Length - 4);
            return (string)val_15;
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            return 丏丄丑上丛不丈且万.丛丐丏上丗不丘丕丕(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this);
        }
        internal override string 东且丏丆万与东丙万()
        {
            return 七丌丞万七万丁丐丙.丌丄三丆下丑丟三丑(丝丒丞丙丐一一丅三:  this.业上丙丞丐丄丆丅七());
        }
        public int 丁丕丁三丁丗不三丟()
        {
            return (int)七丌丞万七万丁丐丙.丐丛万丗丅丒业丐丙(丞丅上丏丂且下丅与:  this.业上丙丞丐丄丆丅七(), 下不东三七丘万丌业: out  false, 丁丂专业丁丅丅丈丙:  this, 业丟七丅丌三且与丛: out  0);
        }
        public int 万丙东丙丐丕专丈丕()
        {
            int val_3 = 0;
            int val_4 = 七丌丞万七万丁丐丙.丐丛万丗丅丒业丐丙(丞丅上丏丂且下丅与:  this.业上丙丞丐丄丆丅七(), 下不东三七丘万丌业: out  false, 丁丂专业丁丅丅丈丙:  this, 业丟七丅丌三且与丛: out  val_3);
            return val_3;
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丈丅专丘丑与丙一东(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        private CategoryNames 世丒三专丞丒丘丌下()
        {
            return 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七());
        }
    
    }

}
