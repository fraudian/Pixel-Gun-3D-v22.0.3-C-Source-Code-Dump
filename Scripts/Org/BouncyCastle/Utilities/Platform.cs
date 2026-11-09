using UnityEngine;

namespace Org.BouncyCastle.Utilities
{
    internal abstract class Platform
    {
        // Fields
        private static readonly System.Globalization.CompareInfo InvariantCompareInfo;
        internal static readonly string NewLine;
        
        // Methods
        private static string GetNewLine()
        {
            return System.Environment.NewLine;
        }
        internal static bool EqualsIgnoreCase(string a, string b)
        {
            return (bool)((System.String.Compare(strA:  a, strB:  b, comparisonType:  5)) == 0) ? 1 : 0;
        }
        internal static string GetEnvironmentVariable(string variable)
        {
            return (string)System.Environment.GetEnvironmentVariable(variable:  variable);
        }
        internal static System.Exception CreateNotImplementedException(string message)
        {
            return (System.Exception)new System.NotImplementedException(message:  message);
        }
        internal static System.Collections.IList CreateArrayList()
        {
            return (System.Collections.IList)new System.Collections.ArrayList();
        }
        internal static System.Collections.IList CreateArrayList(int capacity)
        {
            return (System.Collections.IList)new System.Collections.ArrayList(capacity:  capacity);
        }
        internal static System.Collections.IList CreateArrayList(System.Collections.ICollection collection)
        {
            return (System.Collections.IList)new System.Collections.ArrayList(c:  collection);
        }
        internal static System.Collections.IList CreateArrayList(System.Collections.IEnumerable collection)
        {
            var val_9;
            var val_10;
            System.Collections.ArrayList val_1 = new System.Collections.ArrayList();
            var val_9 = 0;
            val_9 = val_9 + 1;
            System.Collections.IEnumerator val_3 = collection.GetEnumerator();
            label_18:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            object val_7 = val_3.Current;
            if(val_1 != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_11:
            val_9 = 0;
            val_10 = 0;
            if(val_3 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_3.Dispose();
            }
            
            if( != 1)
            {
                    return (System.Collections.IList)val_1;
            }
            
            if( == false)
            {
                    return (System.Collections.IList)val_1;
            }
            
            return (System.Collections.IList)val_1;
        }
        internal static System.Collections.IDictionary CreateHashtable()
        {
            return (System.Collections.IDictionary)new System.Collections.Hashtable();
        }
        internal static System.Collections.IDictionary CreateHashtable(int capacity)
        {
            return (System.Collections.IDictionary)new System.Collections.Hashtable(capacity:  capacity);
        }
        internal static System.Collections.IDictionary CreateHashtable(System.Collections.IDictionary dictionary)
        {
            return (System.Collections.IDictionary)new System.Collections.Hashtable(d:  dictionary);
        }
        internal static string ToLowerInvariant(string s)
        {
            if(s != null)
            {
                    return s.ToLower(culture:  System.Globalization.CultureInfo.InvariantCulture);
            }
            
            return s.ToLower(culture:  System.Globalization.CultureInfo.InvariantCulture);
        }
        internal static string ToUpperInvariant(string s)
        {
            if(s != null)
            {
                    return s.ToUpper(culture:  System.Globalization.CultureInfo.InvariantCulture);
            }
            
            return s.ToUpper(culture:  System.Globalization.CultureInfo.InvariantCulture);
        }
        internal static void Dispose(System.IO.Stream s)
        {
            if(s == null)
            {
                
            }
        
        }
        internal static void Dispose(System.IO.TextWriter t)
        {
            if(t == null)
            {
                
            }
        
        }
        internal static int IndexOf(string source, string value)
        {
            null = null;
            if(Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo == null)
            {
                
            }
        
        }
        internal static int LastIndexOf(string source, string value)
        {
            null = null;
            if(Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo == null)
            {
                
            }
        
        }
        internal static bool StartsWith(string source, string prefix)
        {
            null = null;
            if(Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo == null)
            {
                
            }
        
        }
        internal static bool EndsWith(string source, string suffix)
        {
            null = null;
            if(Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo == null)
            {
                
            }
        
        }
        internal static string GetTypeName(object obj)
        {
            if(obj.GetType() == null)
            {
                
            }
        
        }
        protected Platform()
        {
        
        }
        private static Platform()
        {
            Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo = System.Globalization.CultureInfo.InvariantCulture;
            Org.BouncyCastle.Utilities.Platform.NewLine = System.Environment.NewLine;
        }
    
    }

}
