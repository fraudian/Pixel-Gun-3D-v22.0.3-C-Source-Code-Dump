using UnityEngine;

namespace Org.BouncyCastle.Math.Field
{
    internal class GenericPolynomialExtensionField : IPolynomialExtensionField, IExtensionField, IFiniteField
    {
        // Fields
        protected readonly Org.BouncyCastle.Math.Field.IFiniteField subfield;
        protected readonly Org.BouncyCastle.Math.Field.IPolynomial minimalPolynomial;
        
        // Properties
        public virtual Org.BouncyCastle.Math.BigInteger Characteristic { get; }
        public virtual int Dimension { get; }
        public virtual Org.BouncyCastle.Math.Field.IFiniteField Subfield { get; }
        public virtual int Degree { get; }
        public virtual Org.BouncyCastle.Math.Field.IPolynomial MinimalPolynomial { get; }
        
        // Methods
        internal GenericPolynomialExtensionField(Org.BouncyCastle.Math.Field.IFiniteField subfield, Org.BouncyCastle.Math.Field.IPolynomial polynomial)
        {
            this.subfield = subfield;
            this.minimalPolynomial = polynomial;
        }
        public virtual Org.BouncyCastle.Math.BigInteger get_Characteristic()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.subfield.Characteristic;
        }
        public virtual int get_Dimension()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_4 = this.minimalPolynomial.Degree;
            val_4 = val_4 * this.subfield.Dimension;
            return (int)val_4;
        }
        public virtual Org.BouncyCastle.Math.Field.IFiniteField get_Subfield()
        {
            return (Org.BouncyCastle.Math.Field.IFiniteField)this.subfield;
        }
        public virtual int get_Degree()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.minimalPolynomial.Degree;
        }
        public virtual Org.BouncyCastle.Math.Field.IPolynomial get_MinimalPolynomial()
        {
            return (Org.BouncyCastle.Math.Field.IPolynomial)this.minimalPolynomial;
        }
        public override bool Equals(object obj)
        {
            var val_2;
            var val_3;
            var val_4;
            val_3 = this;
            if(val_3 == obj)
            {
                goto label_1;
            }
            
            if(obj == null)
            {
                goto label_7;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.Field.GenericPolynomialExtensionField.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
            val_2 = mem[(System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.Field.GenericPolynomialExtensionField.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 16];
            val_2 = (System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.Field.GenericPolynomialExtensionField.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 16;
            if((this.subfield & 1) == 0)
            {
                goto label_7;
            }
            
            val_3 = ???;
            val_2 = ???;
            goto Org.BouncyCastle.Math.Field.IPolynomial.__il2cppRuntimeField_vtable;
            label_7:
            val_4 = 0;
            return (bool)val_4;
            label_1:
            val_4 = 1;
            return (bool)val_4;
        }
        public override int GetHashCode()
        {
            int val_1 = Org.BouncyCastle.Utilities.Integers.RotateLeft(i:  this.minimalPolynomial, distance:  16);
            val_1 = val_1 ^ this.subfield;
            return (int)val_1;
        }
    
    }

}
