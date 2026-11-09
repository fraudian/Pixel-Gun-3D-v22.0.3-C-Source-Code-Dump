using UnityEngine;

namespace I2.Loc
{
    public class LanguageSource : MonoBehaviour
    {
        // Fields
        public string Google_WebServiceURL;
        public string Google_SpreadsheetKey;
        public string Google_SpreadsheetName;
        public string Google_LastUpdatedVersion;
        private I2.Loc.CoroutineManager 且且丛一业丏丁且丂;
        public static string EmptyCategory;
        public static char[] CategorySeparators;
        public I2.Loc.LanguageData languageData;
        public int LanguageIndex;
        public int LanguageIndexForSelect;
        public System.Collections.Generic.List<I2.Loc.TermData> mTerms;
        public System.Collections.Generic.Dictionary<string, I2.Loc.TermData> mDictionary;
        public UnityEngine.Object[] Assets;
        public bool NeverDestroy;
        public bool UserAgreesToHaveItOnTheScene;
        
        // Methods
        public string Export_CSV(string 七丌丌丏丗东丕且丅)
        {
            var val_8;
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            I2.Loc.LocalizationLanguageStore val_2 = I2.Loc.丗丈下丕丟丟丙七丞.且丞不丐丁丘与丒下();
            int val_3 = val_2.LanguageDictionary.Count;
            System.Text.StringBuilder val_4 = val_1.Append(value:  "Key,Type,Desc");
            I2.Loc.LocalizationLanguageStore val_5 = I2.Loc.丗丈下丕丟丟丙七丞.且丞不丐丁丘与丒下();
            List.Enumerator<T> val_6 = val_5.LanguageDictionary.GetEnumerator();
            label_16:
            if(((-1690769216) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            System.Text.StringBuilder val_10 = val_1.Append(value:  ",");
            if(val_9 != null)
            {
                    val_29 = val_9.m_stringLength;
            }
            else
            {
                    val_29 = 11993091;
            }
            
            I2.Loc.LanguageSource.丆世丒丛七东上三丁(丟一丙丑丈丙一与业:  val_1, 不三世丏丙丁与丑丒:  I2.Loc.不与不丌七丗业丝万.丑丝丆丗丌丁且东丂(不世丏东丄丟世与不:  val_29, 专丏不丏东丏丈丆上:  val_9));
            goto label_16;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Text.StringBuilder val_12 = val_1.Append(value:  "\n");
            List.Enumerator<T> val_13 = mem[1152921541570795632].GetEnumerator();
            label_51:
            if(((-1690769248) & 1) == 0)
            {
                goto label_28;
            }
            
            string val_14 = val_8.丐丏七丌丕丗业且上();
            if((System.String.IsNullOrEmpty(value:  七丌丌丏丗东丕且丅)) == false)
            {
                goto label_29;
            }
            
            if(val_14 != null)
            {
                goto label_31;
            }
            
            goto label_31;
            label_29:
            val_30 = null;
            val_30 = null;
            if((System.String.op_Equality(a:  七丌丌丏丗东丕且丅, b:  I2.Loc.LanguageSource.EmptyCategory)) == false)
            {
                goto label_34;
            }
            
            val_31 = null;
            val_31 = null;
            if(((val_14.m_stringLength.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators)) & 2147483648) == 0)
            {
                goto label_48;
            }
            
            label_31:
            label_54:
            I2.Loc.LanguageSource.丆世丒丛七东上三丁(丟一丙丑丈丙一与业:  val_1, 不三世丏丙丁与丑丒:  val_14.m_stringLength);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            System.Text.StringBuilder val_20 = val_1.AppendFormat(format:  ",{0}", arg0:  val_14 + 24.ToString());
            System.Text.StringBuilder val_21 = val_1.Append(value:  ",");
            I2.Loc.LanguageSource.丆世丒丛七东上三丁(丟一丙丑丈丙一与业:  val_1, 不三世丏丙丁与丑丒:  ",");
            System.Text.StringBuilder val_22 = val_1.Append(value:  ",");
            I2.Loc.LanguageSource.丆世丒丛七东上三丁(丟一丙丑丈丙一与业:  val_1, 不三世丏丙丁与丑丒:  ",");
            System.Text.StringBuilder val_23 = val_1.Append(value:  "\n");
            goto label_51;
            label_34:
            label_48:
            if(((val_14.m_stringLength.StartsWith(value:  七丌丌丏丗东丕且丅)) == false) || ((System.String.op_Inequality(a:  七丌丌丏丗东丕且丅, b:  val_14.m_stringLength)) == false))
            {
                goto label_51;
            }
            
            string val_28 = val_14.m_stringLength.Substring(startIndex:  七丌丌丏丗东丕且丅.Length + 1);
            goto label_54;
            label_28:
            val_32 = public System.Void List.Enumerator<I2.Loc.TermData>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
        private static void 丆世丒丛七东上三丁(System.Text.StringBuilder 丟一丙丑丈丙一与业, string 不三世丏丙丁与丑丒)
        {
            var val_8;
            if((System.String.IsNullOrEmpty(value:  不三世丏丙丁与丑丒)) != false)
            {
                    return;
            }
            
            string val_2 = 不三世丏丙丁与丑丒.Replace(oldValue:  "\\n", newValue:  "\n");
            val_8 = ",\n\"";
            if(",\n\"" == null)
            {
                    val_8 = ",\n\"";
            }
            
            if(((val_2.IndexOfAny(anyOf:  ToCharArray())) & 2147483648) == 0)
            {
                    System.Text.StringBuilder val_6 = 丟一丙丑丈丙一与业.AppendFormat(format:  "\"{0}\"", arg0:  val_2.Replace(oldValue:  "\"", newValue:  "\"\""));
                return;
            }
            
            System.Text.StringBuilder val_7 = 丟一丙丑丈丙一与业.Append(value:  val_2);
        }
        public UnityEngine.WWW Export_Google_CreateWWWcall(I2.Loc.不丟七丑业东且丁下 丟不东丌丕不丐专业 = 1)
        {
            UnityEngine.WWWForm val_2 = new UnityEngine.WWWForm();
            if(val_2 != null)
            {
                    val_2.AddField(fieldName:  "key", value:  this.Google_SpreadsheetKey);
                val_2.AddField(fieldName:  "action", value:  "SetLanguageSource");
            }
            else
            {
                    val_2.AddField(fieldName:  "key", value:  this.Google_SpreadsheetKey);
                val_2.AddField(fieldName:  "action", value:  "SetLanguageSource");
            }
            
            val_2.AddField(fieldName:  "data", value:  this.七且丐上丘丌不丁丛());
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_2.AddField(fieldName:  "updateMode", value:  丟不东丌丕不丐专业.ToString());
            return (UnityEngine.WWW)new UnityEngine.WWW(url:  this.Google_WebServiceURL, form:  val_2);
        }
        private string 七且丐上丘丌不丁丛()
        {
            var val_10;
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            List.Enumerator<T> val_3 = this.GetCategories(丗丁专丈丌丁丛丄丄:  true).GetEnumerator();
            label_8:
            if(((-1690133704) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            if((1 & 1) == 0)
            {
                    System.Text.StringBuilder val_5 = val_2.Append(value:  "<I2Loc>");
            }
            
            System.Text.StringBuilder val_7 = val_2.Append(value:  val_4);
            System.Text.StringBuilder val_8 = val_2.Append(value:  "<I2Loc>");
            System.Text.StringBuilder val_9 = val_2.Append(value:  this.Export_CSV(七丌丌丏丗东丕且丅:  val_4));
            goto label_8;
            label_2:
            val_10 = public System.Void List.Enumerator<System.String>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_2 != null)
            {
                    return (string)val_2;
            }
            
            return (string)val_2;
        }
        public static I2.Loc.丟丘万丅丙丆丄丈三 GetTermType(string 丁丅丈丌丟世丗丗丟)
        {
            var val_3;
            var val_4 = 0;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if((System.String.Equals(a:  val_4 + 1.ToString(), b:  丁丅丈丌丟世丗丗丟, comparisonType:  5)) == true)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            if(val_4 <= 7)
            {
                goto label_4;
            }
            
            val_3 = 0;
            return (I2.Loc.丟丘万丅丙丆丄丈三)val_3;
            label_3:
            val_3 = val_4 + 1;
            return (I2.Loc.丟丘万丅丙丆丄丈三)val_3;
        }
        private System.Collections.IEnumerator 丝上丁丆与丘与丁且()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LanguageSource.丑不丒且丐丂东专丑();
        }
        public UnityEngine.WWW Import_Google_CreateWWWcall(bool 丑丁丌上且且丘下丌 = False)
        {
            var val_5;
            if(this.HasGoogleSpreadsheet() != false)
            {
                    UnityEngine.WWW val_4 = null;
                val_5 = val_4;
                val_4 = new UnityEngine.WWW(url:  System.String.Format(format:  "{0}?key={1}&action=GetLanguageSource&version={2}", arg0:  this.Google_WebServiceURL, arg1:  this.Google_SpreadsheetKey, arg2:  (丑丁丌上且且丘下丌 != true) ? "0" : this.Google_LastUpdatedVersion));
                return (UnityEngine.WWW)val_5;
            }
            
            val_5 = 0;
            return (UnityEngine.WWW)val_5;
        }
        public bool HasGoogleSpreadsheet()
        {
            var val_4;
            if((System.String.IsNullOrEmpty(value:  this.Google_WebServiceURL)) != false)
            {
                    val_4 = 0;
            }
            else
            {
                    bool val_2 = System.String.IsNullOrEmpty(value:  this.Google_SpreadsheetKey);
                val_4 = val_2 ^ 1;
            }
            
            val_2 = val_4;
            return (bool)val_2;
        }
        public void Import_Google_Result(string 丌丗丒丄丐丆与七专, I2.Loc.不丟七丑业东且丁下 丟不东丌丕不丐专业)
        {
            if((System.String.op_Equality(a:  丌丗丒丄丐丆与七专, b:  "\"\"")) != false)
            {
                    UnityEngine.Debug.Log(message:  "Language Source was up to date");
                return;
            }
            
            if(丟不东丌丕不丐专业 != 1)
            {
                    return;
            }
            
            this.ClearAllData();
        }
        public System.Collections.Generic.List<string> GetCategories(bool 丗丁专丈丌丁丛丄丄 = False)
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_2 = this.mTerms.GetEnumerator();
            label_9:
            if(((-1689313944) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            string val_5 = I2.Loc.LanguageSource.一丟丌丕一丌与丅丘(下丏且丐丕丟世丆业:  val_4.m_stringLength, 丗丁专丈丌丁丛丄丄:  丗丁专丈丌丁丛丄丄);
            if((val_1.Contains(item:  val_5)) == true)
            {
                goto label_9;
            }
            
            val_1.Add(item:  val_5);
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_1.Sort();
            return val_1;
        }
        internal static string 丏丅一七丗三丅丘上(string 下丏且丐丕丟世丆业, bool 丗丁专丈丌丁丛丄丄 = False)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = null;
            if(丗丁专丈丌丁丛丄丄 != false)
            {
                    val_4 = null;
                val_5 = 下丏且丐丕丟世丆业;
                int val_1 = val_5.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            else
            {
                    val_6 = null;
                val_5 = 下丏且丐丕丟世丆业;
                System.Char[] val_3 = I2.Loc.LanguageSource.CategorySeparators;
                int val_2 = val_5.LastIndexOfAny(anyOf:  val_3);
            }
            
            if((val_2 & 2147483648) != 0)
            {
                    return (string)下丏且丐丕丟世丆业;
            }
            
            val_3 = val_2 + 1;
            return 下丏且丐丕丟世丆业.Substring(startIndex:  val_3);
        }
        internal static string 一丟丌丕一丌与丅丘(string 下丏且丐丕丟世丆业, bool 丗丁专丈丌丁丛丄丄 = False)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = null;
            if(丗丁专丈丌丁丛丄丄 != false)
            {
                    val_4 = null;
                val_5 = 下丏且丐丕丟世丆业;
                int val_1 = val_5.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            else
            {
                    val_6 = null;
                val_5 = 下丏且丐丕丟世丆业;
                int val_2 = val_5.LastIndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            
            if((val_2 & 2147483648) == 0)
            {
                    if(下丏且丐丕丟世丆业 != null)
            {
                    return 下丏且丐丕丟世丆业.Substring(startIndex:  0, length:  val_2);
            }
            
                return 下丏且丐丕丟世丆业.Substring(startIndex:  0, length:  val_2);
            }
            
            val_7 = null;
            val_7 = null;
            return (string)I2.Loc.LanguageSource.EmptyCategory;
        }
        internal static void 万下丑丛上下下丝且(string 下丏且丐丕丟世丆业, out string 万丄七三丕丛丗丆丆, out string 七丌丌丏丗东丕且丅, bool 丗丁专丈丌丁丛丄丄 = False)
        {
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_7 = 下丏且丐丕丟世丆业;
            val_8 = null;
            if(丗丁专丈丌丁丛丄丄 != false)
            {
                    val_9 = null;
                val_10 = val_7;
                int val_1 = val_10.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            else
            {
                    val_11 = null;
                val_10 = val_7;
                int val_2 = val_10.LastIndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            
            if((val_2 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            if(val_7 == null)
            {
                goto label_10;
            }
            
            七丌丌丏丗东丕且丅 = val_7.Substring(startIndex:  0, length:  val_2);
            goto label_11;
            label_9:
            val_12 = null;
            val_12 = null;
            七丌丌丏丗东丕且丅 = I2.Loc.LanguageSource.EmptyCategory;
            goto label_14;
            label_10:
            七丌丌丏丗东丕且丅 = 0.Substring(startIndex:  0, length:  val_2);
            label_11:
            val_7 = val_7.Substring(startIndex:  val_2 + 1);
            label_14:
            万丄七三丕丛丗丆丆 = val_7;
        }
        private void Awake()
        {
            if(this.NeverDestroy != false)
            {
                    if(this.一丗丏丂丌丝丗丄与() != false)
            {
                    UnityEngine.Object.Destroy(obj:  this);
                return;
            }
            
                UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            }
            
            I2.Loc.丗丈下丕丟丟丙七丞.丟七世丄上丗丈专丗(丗业丛业丂丆丕丈一:  this);
            this.UpdateDictionary();
        }
        public void UpdateDictionary()
        {
            this.mDictionary.Clear();
            int val_1 = this.mTerms.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                I2.Loc.TermData val_2 = this.mTerms.Item[0];
                I2.Loc.LanguageSource.ValidateFullTerm(丝丐丟三业丟丏万且: ref  val_2.Term);
                I2.Loc.TermData val_4 = this.mTerms.Item[0];
                this.mDictionary.set_Item(key:  val_4.Term, value:  this.mTerms.Item[0]);
                val_6 = val_6 + 1;
            }
            while(val_1 != val_6);
        
        }
        public System.Collections.Generic.List<string> GetLanguages()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            I2.Loc.LocalizationLanguageStore val_2 = I2.Loc.丗丈下丕丟丟丙七丞.且丞不丐丁丘与丒下();
            int val_3 = val_2.LanguageDictionary.Count;
            if(val_3 < 1)
            {
                    return val_1;
            }
            
            var val_6 = 0;
            do
            {
                I2.Loc.LocalizationLanguageStore val_4 = I2.Loc.丗丈下丕丟丟丙七丞.且丞不丐丁丘与丒下();
                I2.Loc.LanguageEntry val_5 = val_4.LanguageDictionary.Item[0];
                val_1.Add(item:  val_5.key);
                val_6 = val_6 + 1;
            }
            while(val_3 != val_6);
            
            return val_1;
        }
        public I2.Loc.TermData AddTerm(string 与专丒七不丈上丐上)
        {
            return this.AddTerm(一上丛丏丘丏丞丒丆:  与专丒七不丈上丐上, 丛丅且丕丗一丈上东:  0);
        }
        public I2.Loc.TermData GetTermData(string 与专丒七不丈上丐上)
        {
            I2.Loc.TermData val_2 = 0;
            if(this.mDictionary.Count == 0)
            {
                    this.UpdateDictionary();
            }
            
            bool val_3 = this.mDictionary.TryGetValue(key:  与专丒七不丈上丐上, value: out  val_2);
            return val_2;
        }
        public bool ContainsTerm(string 与专丒七不丈上丐上)
        {
            return (bool)((this.GetTermData(与专丒七不丈上丐上:  与专丒七不丈上丐上)) != 0) ? 1 : 0;
        }
        public System.Collections.Generic.List<string> GetTermsList()
        {
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  this.mDictionary.Keys);
        }
        public I2.Loc.TermData AddTerm(string 一上丛丏丘丏丞丒丆, I2.Loc.丟丘万丅丙丆丄丈三 丛丅且丕丗一丈上东)
        {
            I2.Loc.丟丘万丅丙丆丄丈三 val_5;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData> val_6;
            I2.Loc.TermData val_7;
            int val_8;
            val_5 = 丛丅且丕丗一丈上东;
            val_6 = this;
            string val_1 = 一上丛丏丘丏丞丒丆;
            I2.Loc.LanguageSource.ValidateFullTerm(丝丐丟三业丟丏万且: ref  val_1);
            string val_2 = val_1.Trim();
            val_7 = this.GetTermData(与专丒七不丈上丐上:  val_2);
            if(val_7 != null)
            {
                    return val_7;
            }
            
            I2.Loc.TermData val_4 = null;
            val_7 = val_4;
            val_4 = new I2.Loc.TermData();
            if(val_7 != null)
            {
                    .Term = val_2;
                .TermType = val_5;
                val_8 = System.String.alignConst;
            }
            else
            {
                    mem[16] = val_2;
                .TermType = val_5;
                val_8 = System.String.alignConst;
            }
            
            .Language = val_8;
            val_5 = this.mTerms;
            val_5.Add(item:  val_4);
            val_6 = this.mDictionary;
            val_6.Add(key:  val_2, value:  val_4);
            return val_7;
        }
        public void RemoveTerm(string 与专丒七不丈上丐上)
        {
            System.Collections.Generic.List<I2.Loc.TermData> val_5 = this.mTerms;
            int val_1 = val_5.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            label_6:
            I2.Loc.TermData val_2 = this.mTerms.Item[0];
            if((System.String.op_Equality(a:  val_2.Term, b:  与专丒七不丈上丐上)) == true)
            {
                goto label_5;
            }
            
            val_5 = 0 + 1;
            if(val_5 < val_1)
            {
                goto label_6;
            }
            
            return;
            label_5:
            this.mTerms.RemoveAt(index:  0);
            bool val_4 = this.mDictionary.Remove(key:  与专丒七不丈上丐上);
        }
        public static void ValidateFullTerm(ref string 丝丐丟三业丟丏万且)
        {
            var val_12;
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            string val_1 = 丝丐丟三业丟丏万且.Replace(oldChar:  '\', newChar:  '/');
            丝丐丟三业丟丏万且 = val_1;
            string val_2 = val_1.Trim();
            丝丐丟三业丟丏万且 = val_2;
            val_12 = null;
            val_12 = null;
            val_13 = I2.Loc.LanguageSource.EmptyCategory;
            if((val_2.StartsWith(value:  val_13)) == false)
            {
                    return;
            }
            
            val_14 = null;
            val_14 = null;
            val_13 = I2.Loc.LanguageSource.EmptyCategory;
            if(丝丐丟三业丟丏万且.Length <= val_13.Length)
            {
                    return;
            }
            
            val_15 = null;
            val_15 = null;
            val_13 = I2.Loc.LanguageSource.EmptyCategory.Length;
            if((丝丐丟三业丟丏万且.Chars[val_13] & 65535) != ('/'))
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            val_13 = I2.Loc.LanguageSource.EmptyCategory.Length;
            丝丐丟三业丟丏万且 = 丝丐丟三业丟丏万且.Substring(startIndex:  val_13 + 1);
        }
        internal bool 一丗丏丂丌丝丗丄与()
        {
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            int val_1 = I2.Loc.丗丈下丕丟丟丙七丞.下且丛丐丕丘丐丑丒.Count;
            if(val_1 < 1)
            {
                    return false;
            }
            
            var val_6 = 0;
            do
            {
                val_7 = null;
                val_7 = null;
                I2.Loc.LanguageSource val_2 = I2.Loc.丗丈下丕丟丟丙七丞.下且丛丐丕丘丐丑丒.Item[0];
                if(val_2 != 0)
            {
                    if((I2.Loc.丗丈下丕丟丟丙七丞.丄且丝丕七丐三丂世(丗业丛业丂丆丕丈一:  this)) != false)
            {
                    if(val_2 != this)
            {
                    return false;
            }
            
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < val_1);
            
            return false;
        }
        public void ClearAllData()
        {
            this.mTerms.Clear();
            this.languageData = 0;
            this.mDictionary.Clear();
        }
        public UnityEngine.Object FindAsset(string 专丕与丒丗丁丘专丟)
        {
            UnityEngine.Object[] val_4;
            var val_5;
            UnityEngine.Object[] val_6;
            UnityEngine.Object val_7;
            val_4 = this.Assets;
            if((val_4 == null) || (this.Assets.Length < 1))
            {
                    return 0;
            }
            
            val_5 = 4;
            goto label_3;
            label_13:
            val_6 = this.Assets;
            val_5 = 5;
            label_3:
            val_7 = val_6[1];
            if(val_7 == 0)
            {
                goto label_8;
            }
            
            val_7 = this.Assets[1];
            if((System.String.op_Equality(a:  val_7.name, b:  专丕与丒丗丁丘专丟)) == true)
            {
                goto label_12;
            }
            
            label_8:
            if((val_5 - 3) < (long)this.Assets.Length)
            {
                goto label_13;
            }
            
            return 0;
            label_12:
            UnityEngine.Object val_5 = this.Assets[1];
            return 0;
        }
        public bool HasAsset(UnityEngine.Object 世丂丑下下下丕业专)
        {
            int val_1 = System.Array.IndexOf<UnityEngine.Object>(array:  this.Assets, value:  世丂丑下下下丕业专);
            val_1 = (val_1 >> 31) ^ 1;
            return (bool)val_1;
        }
        public LanguageSource()
        {
            this.mTerms = new System.Collections.Generic.List<I2.Loc.TermData>();
            this.mDictionary = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>();
            this.NeverDestroy = true;
        }
        private static LanguageSource()
        {
            I2.Loc.LanguageSource.EmptyCategory = "Default";
            I2.Loc.LanguageSource.CategorySeparators = ToCharArray();
        }
    
    }

}
