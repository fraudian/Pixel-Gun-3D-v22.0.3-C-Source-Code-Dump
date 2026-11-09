using UnityEngine;

namespace Org.BouncyCastle.Utilities.Collections
{
    public abstract class CollectionUtilities
    {
        // Methods
        public static void AddRange(System.Collections.IList to, System.Collections.IEnumerable range)
        {
            var val_13;
            var val_18;
            var val_19;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_13 = 0;
            System.Collections.IEnumerator val_2 = range.GetEnumerator();
            label_22:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_13 = 0;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_13 = 1;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_13 = 2;
            int val_8 = to.Add(value:  val_2.Current);
            goto label_22;
            label_11:
            val_18 = 0;
            val_19 = 0;
            if(val_2 != null)
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_2.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_19 = ???;
            val_18 = ???;
        }
        public static bool CheckElementsAreOfType(System.Collections.IEnumerable e, System.Type t)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_12;
            var val_8 = 0;
            val_8 = val_8 + 1;
            System.Collections.IEnumerator val_2 = e.GetEnumerator();
            label_18:
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            object val_6 = val_2.Current;
            if((t & 1) != 0)
            {
                goto label_18;
            }
            
            val_8 = 0;
            val_9 = 0;
            val_10 = 58;
            goto label_20;
            label_11:
            val_8 = 0;
            val_9 = 0;
            val_10 = 56;
            label_20:
            if(val_2 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_2.Dispose();
            }
            
            if( == 1)
            {
                goto label_29;
            }
            
            if(val_10 != 58)
            {
                goto label_30;
            }
            
            val_12 = 0;
            return (bool)val_12;
            label_29:
            if( == true)
            {
                goto label_32;
            }
            
            goto label_33;
            label_30:
            val_12 = 1;
            if( == false)
            {
                    return (bool)val_12;
            }
            
            if(val_10 == 56)
            {
                    return (bool)val_12;
            }
            
            label_32:
            label_33:
            val_12 = 1;
            return (bool)val_12;
        }
        public static System.Collections.IDictionary ReadOnly(System.Collections.IDictionary d)
        {
            return (System.Collections.IDictionary)d;
        }
        public static System.Collections.IList ReadOnly(System.Collections.IList l)
        {
            return (System.Collections.IList)l;
        }
        public static Org.BouncyCastle.Utilities.Collections.ISet ReadOnly(Org.BouncyCastle.Utilities.Collections.ISet s)
        {
            return (Org.BouncyCastle.Utilities.Collections.ISet)s;
        }
        public static string ToString(System.Collections.IEnumerable c)
        {
            string val_15;
            var val_18;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(value:  "[");
            var val_17 = 0;
            val_17 = val_17 + 1;
            System.Collections.IEnumerator val_3 = c.GetEnumerator();
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_15 = val_3.Current;
            System.Text.StringBuilder val_8 = val_1.Append(value:  val_15);
            goto label_19;
            label_33:
            System.Text.StringBuilder val_9 = val_1.Append(value:  ", ");
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_15 = val_3.Current;
            System.Text.StringBuilder val_12 = val_1.Append(value:  val_15);
            label_19:
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(val_3.MoveNext() == true)
            {
                goto label_33;
            }
            
            label_11:
            if(val_1 != null)
            {
                    val_18 = 93;
                System.Text.StringBuilder val_15 = val_1.Append(value:  ']');
            }
            else
            {
                    val_18 = 93;
                System.Text.StringBuilder val_16 = val_1.Append(value:  ']');
            }
        
        }
        protected CollectionUtilities()
        {
        
        }
    
    }

}
