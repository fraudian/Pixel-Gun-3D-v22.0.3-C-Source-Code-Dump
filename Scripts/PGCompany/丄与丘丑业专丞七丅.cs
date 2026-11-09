using UnityEngine;

namespace PGCompany
{
    internal sealed class 丄与丘丑业专丞七丅 : ICloneable, IEquatable<PGCompany.丄与丘丑业专丞七丅>
    {
        // Fields
        internal PGCompany.三东丏不丗世丅丌丄 ItemParams;
        internal TagSystem.三与下丘七丘丌丏丄 Tag;
        internal Rilisoft.丝丑丂丛万丐丈丘且 IntParams;
        
        // Methods
        internal 丄与丘丑业专丞七丅()
        {
            this.Tag = new TagSystem.三与下丘七丘丌丏丄();
        }
        internal 丄与丘丑业专丞七丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.Tag = new TagSystem.三与下丘七丘丌丏丄();
            this.ItemParams = 丈丄不七三万丄丁不;
            this.Tag = new TagSystem.三与下丘七丘丌丏丄();
        }
        internal 丄与丘丑业专丞七丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, TagSystem.三与下丘七丘丌丏丄 丆万一不丌且东丐丐)
        {
            this.Tag = new TagSystem.三与下丘七丘丌丏丄();
            val_2 = new System.Object();
            this.ItemParams = 丈丄不七三万丄丁不;
            this.Tag = val_2;
        }
        internal 丄与丘丑业专丞七丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, TagSystem.三与下丘七丘丌丏丄 丆万一不丌且东丐丐, int 丅七丛丘一丟丐丌上)
        {
            this.Tag = new TagSystem.三与下丘七丘丌丏丄();
            val_2 = new System.Object();
            this.ItemParams = 丈丄不七三万丄丁不;
            this.Tag = val_2;
            int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.IntParams = 0;
            mem[1152921555927759096] = 0;
        }
        public override string ToString()
        {
            return System.String.Format(format:  "{0}", arg0:  this.ItemParams);
        }
        public object Clone()
        {
            var val_5;
            var val_6;
            if(this.Tag != null)
            {
                    val_5 = this.Tag.Clone();
            }
            else
            {
                    val_5 = 0;
            }
            
            val_6 = 0;
            new PGCompany.丄与丘丑业专丞七丅() = new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  this.ItemParams.与下不与丐丈丁丈万(), 丆万一不丌且东丐丐:  null, 丅七丛丘一丟丐丌上:  this.IntParams);
            return (object)new PGCompany.丄与丘丑业专丞七丅();
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            var val_3;
            if(万且万且丑丗且丌丆 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_3 = 0;
            return (bool)this.Equals(丘丛丏丘丝七世七丅:  万且万且丑丗且丌丆);
            label_2:
            val_3 = this;
            return (bool)this.Equals(丘丛丏丘丝七世七丅:  万且万且丑丗且丌丆);
        }
        public bool Equals(PGCompany.丄与丘丑业专丞七丅 丘丛丏丘丝七世七丅)
        {
            var val_3;
            var val_4;
            val_3 = 丘丛丏丘丝七世七丅;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            if(this == val_3)
            {
                goto label_1;
            }
            
            if((System.Object.Equals(objA:  this.ItemParams, objB:  丘丛丏丘丝七世七丅.ItemParams)) != false)
            {
                    if((System.Object.Equals(objA:  this.Tag, objB:  丘丛丏丘丝七世七丅.Tag)) != false)
            {
                    val_3 = ???;
            }
            
            }
            
            label_3:
            val_4 = 0;
            return (bool)val_4;
            label_1:
            val_4 = 1;
            return (bool)val_4;
        }
        public int 且丘不丁不丞丏丕丞(PGCompany.丄与丘丑业专丞七丅 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 != null)
            {
                    return 万且万且丑丗且丌丆.GetHashCode();
            }
            
            return 万且万且丑丗且丌丆.GetHashCode();
        }
    
    }

}
