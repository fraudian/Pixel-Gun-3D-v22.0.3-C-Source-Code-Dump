using UnityEngine;

namespace LitJson
{
    internal class 上丛丌丟且丛丛丘丆 : IDictionaryEnumerator, IEnumerator
    {
        // Fields
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, LitJson.丑丘丆不丄丐丟丄七>> 丏专世丘七丁丄丏丄;
        
        // Properties
        public object 下世丛三七丐业丄下 { get; }
        public System.Collections.DictionaryEntry 业业丛东下业丙上丘 { get; }
        public object 万丄七三丕丛丗丆丆 { get; }
        public object 不丑一丙东丙丆丁七 { get; }
        
        // Methods
        public object get_Current()
        {
            System.Collections.DictionaryEntry val_1 = this.Entry;
            return (object)val_1;
        }
        public System.Collections.DictionaryEntry get_Entry()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            T val_2 = this.丏专世丘七丁丄丏丄.Current;
            MoonSharp.Interpreter.TablePair val_4 = new MoonSharp.Interpreter.TablePair(key:  val_2.丐丏七丌丕丗业且上(), val:  val_2);
            return new System.Collections.DictionaryEntry() {Key = val_4.key, Value = val_4.value};
        }
        public object get_Key()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (object)this.丏专世丘七丁丄丏丄.Current.丐丏七丌丕丗业且上();
        }
        public object get_Value()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            T val_2 = this.丏专世丘七丁丄丏丄.Current;
            return (object);
        }
        public 上丛丌丟且丛丛丘丆(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, LitJson.丑丘丆不丄丐丟丄七>> 业丁东丛三丗东东东)
        {
            this.丏专世丘七丁丄丏丄 = 业丁东丛三丗东东东;
        }
        public bool MoveNext()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丏专世丘七丁丄丏丄.MoveNext();
        }
        public void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丏专世丘七丁丄丏丄.Reset();
        }
    
    }

}
