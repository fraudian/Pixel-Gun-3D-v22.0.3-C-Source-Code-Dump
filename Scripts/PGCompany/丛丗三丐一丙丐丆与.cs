using UnityEngine;

namespace PGCompany
{
    public class 丛丗三丐一丙丐丆与 : 专丟专世丅丂丁且专, IEquatable<PGCompany.专丟专世丅丂丁且专>, IEquatable<PGCompany.丛丗三丐一丙丐丆与>
    {
        // Fields
        internal PGCompany.丝丗丁丞丒且丙丑丙 Type;
        internal PGCompany.三东丏不丗世丅丌丄[] ItemParams;
        internal PGCompany.丆一丁丏三万丑东不 PurchaseType;
        internal PGCompany.三东丏不丗世丅丌丄 Price;
        internal string InAppId;
        
        // Properties
        public string 下丆三丞且丞不丝一 { get; }
        
        // Methods
        public string 丛业丟下丆丅世丟丛()
        {
            if(this.GetType() == null)
            {
                
            }
        
        }
        public bool 丑丕丈丈不不且丑且()
        {
            if(this.Price == null)
            {
                    return false;
            }
            
            if(this.Price.丕丐一丙专丛丒丑万() == false)
            {
                    return false;
            }
            
            return PGCompany.丞丒专七世下丅万丂.一不丂专一下丑业不<PGCompany.三东丏不丗世丅丌丄>(丈丆丕与丒丌丘丕且:  this.ItemParams);
        }
        public bool 万一丅上东七七丆下(object 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 == null)
            {
                    return false;
            }
            
            return false;
        }
        public bool Equals(PGCompany.专丟专世丅丂丁且专 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 == null)
            {
                    return false;
            }
            
            return false;
        }
        public bool Equals(PGCompany.丛丗三丐一丙丐丆与 丘丛丏丘丝七世七丅)
        {
            PGCompany.三东丏不丗世丅丌丄[] val_4;
            var val_5;
            var val_6;
            if(this == 丘丛丏丘丝七世七丅)
            {
                goto label_6;
            }
            
            if(((((丘丛丏丘丝七世七丅 == null) || (this.Type != 丘丛丏丘丝七世七丅.Type)) || (this.PurchaseType != 丘丛丏丘丝七世七丅.PurchaseType)) || ((System.String.op_Inequality(a:  this.InAppId, b:  丘丛丏丘丝七世七丅.InAppId)) == true)) || ((System.Object.Equals(objA:  this.Price, objB:  丘丛丏丘丝七世七丅.Price)) == false))
            {
                goto label_16;
            }
            
            val_4 = this.ItemParams;
            if(val_4 == 丘丛丏丘丝七世七丅.ItemParams)
            {
                goto label_6;
            }
            
            val_5 = 0;
            if(val_4 == null)
            {
                    return (bool)val_5;
            }
            
            if(丘丛丏丘丝七世七丅.ItemParams == null)
            {
                    return (bool)val_5;
            }
            
            if(this.ItemParams.Length != 丘丛丏丘丝七世七丅.ItemParams.Length)
            {
                goto label_16;
            }
            
            val_6 = 0;
            goto label_10;
            label_18:
            val_4 = this.ItemParams[0];
            if((val_4.Equals(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅.ItemParams[0])) == false)
            {
                goto label_16;
            }
            
            val_4 = this.ItemParams;
            val_6 = 1;
            label_10:
            if(val_6 < this.ItemParams.Length)
            {
                goto label_18;
            }
            
            label_6:
            val_5 = 1;
            return (bool)val_5;
            label_16:
            val_5 = 0;
            return (bool)val_5;
        }
        public override string ToString()
        {
            PGCompany.三东丏不丗世丅丌丄 val_5;
            object[] val_1 = new object[5];
            val_1[0] = this.Type;
            val_1[1] = this.PurchaseType;
            val_5 = this.Price;
            if(val_5 != null)
            {
                    val_5 = PGCompany.万丞丘与丕丞下万丌.丙业不丝丗丌丗世下(丈丄不七三万丄丁不:  val_5);
            }
            
            val_1[2] = val_5;
            val_1[3] = PGCompany.万丞丘与丕丞下万丌.丙业不丝丗丌丗世下(丈丄不七三万丄丁不:  this.ItemParams);
            val_1[4] = this.InAppId;
            return (string)System.String.Format(format:  "{0}_{1}_{2}_{3}_{4}", args:  val_1);
        }
        public 丛丗三丐一丙丐丆与()
        {
        
        }
    
    }

}
