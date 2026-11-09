using UnityEngine;

namespace Rilisoft
{
    internal sealed class 世万上丑专丞下丏丙 : 丆丑丙丈世万丛丈丝
    {
        // Fields
        private readonly System.Xml.Linq.XDocument 丒丏丌与下丁三丝万;
        private static readonly string 丌丄丟丂丆丑下丐世;
        private const string 不丈七丄丗与东丞东 = "Key";
        private const string 丞丗与不丝业三丈丞 = "Preference";
        private const string 丏丈一丘丌丏丝七丘 = "Preferences";
        private const string 万丄丂万一丑丙七丒 = "Value";
        
        // Properties
        public override System.Collections.Generic.ICollection<string> 丕世七丂丗专丝上丕 { get; }
        public override System.Collections.Generic.ICollection<string> 丂丘且上丕三东丕丒 { get; }
        public override int 丒专下与丑丁丆丟业 { get; }
        public override bool 丅丅丌一丕七业世丌 { get; }
        internal static string 世丒业丂一上丆一东 { get; }
        
        // Methods
        private static 世万上丑专丞下丏丙()
        {
            Rilisoft.世万上丑专丞下丏丙.万丄丂万一丑丙七丒 = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "com.P3D.Pixlgun.Settings.xml");
        }
        public 世万上丑专丞下丏丙()
        {
            null = null;
            this.丒丏丌与下丁三丝万 = System.Xml.Linq.XDocument.Load(uri:  Rilisoft.世万上丑专丞下丏丙.万丄丂万一丑丙七丒);
        }
        protected override void 丕丐丐三丒丏丟丞一(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            var val_15;
            .下上丐丆丝丟丝丒不 = 下上丐丆丝丟丝丒不;
            System.Xml.Linq.XElement val_6 = System.Linq.Enumerable.FirstOrDefault<System.Xml.Linq.XElement>(source:  this.丒丏丌与下丁三丝万.Root.Elements(name:  System.Xml.Linq.XName.op_Implicit(expandedName:  "Preference")), predicate:  new System.Func<System.Xml.Linq.XElement, System.Boolean>(object:  new 世万上丑专丞下丏丙.丛与丒丞丁丛上丄丆(), method:  System.Boolean 世万上丑专丞下丏丙.丛与丒丞丁丛上丄丆::丂丑丑业不世丛丐丏(System.Xml.Linq.XElement 丗丛不丁丑专专丂且)));
            if(val_6 != null)
            {
                    val_6.Remove();
            }
            
            object[] val_8 = new object[2];
            System.Xml.Linq.XElement val_10 = new System.Xml.Linq.XElement(name:  System.Xml.Linq.XName.op_Implicit(expandedName:  "Key"), content:  (世万上丑专丞下丏丙.丛与丒丞丁丛上丄丆)[1152921542152598976].下上丐丆丝丟丝丒不);
            if(val_8 == null)
            {
                goto label_5;
            }
            
            if(val_10 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_10 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_8[0] = val_10;
            val_8[1] = new System.Xml.Linq.XElement(name:  System.Xml.Linq.XName.op_Implicit(expandedName:  "Value"), content:  丙业与丙丗丝不丈东);
            this.丒丏丌与下丁三丝万.Root.Add(content:  new System.Xml.Linq.XElement(name:  System.Xml.Linq.XName.op_Implicit(expandedName:  "Preference"), content:  val_8));
            val_15 = null;
            val_15 = null;
            this.丒丏丌与下丁三丝万.Save(fileName:  Rilisoft.世万上丑专丞下丏丙.万丄丂万一丑丙七丒);
        }
        protected override bool 丟丅丆上丅专丑专丅(string 下上丐丆丝丟丝丒不)
        {
            .下上丐丆丝丟丝丒不 = 下上丐丆丝丟丝丒不;
            return System.Linq.Enumerable.Any<System.Xml.Linq.XElement>(source:  this.丒丏丌与下丁三丝万.Root.Elements(name:  System.Xml.Linq.XName.op_Implicit(expandedName:  "Preference")), predicate:  new System.Func<System.Xml.Linq.XElement, System.Boolean>(object:  new 世万上丑专丞下丏丙.上丌专丄丘丂东且丒(), method:  System.Boolean 世万上丑专丞下丏丙.上丌专丄丘丂东且丒::丂丆下不丝丏丘丞三(System.Xml.Linq.XElement 丗丛不丁丑专专丂且)));
        }
        protected override void 一丕丆丐上一与丐丗(System.Collections.Generic.KeyValuePair<string, string>[] 三丒丂世丕丟东丆丏, int 专丞丁世丈下且丁丑)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        protected override bool 丕丈丏丟东丕下下丁(string 下上丐丆丝丟丝丒不)
        {
            System.Xml.Linq.XDocument val_7;
            var val_8;
            var val_9;
            val_7 = this;
            .下上丐丆丝丟丝丒不 = 下上丐丆丝丟丝丒不;
            System.Xml.Linq.XElement val_6 = System.Linq.Enumerable.FirstOrDefault<System.Xml.Linq.XElement>(source:  this.丒丏丌与下丁三丝万.Root.Elements(name:  System.Xml.Linq.XName.op_Implicit(expandedName:  "Preference")), predicate:  new System.Func<System.Xml.Linq.XElement, System.Boolean>(object:  new 世万上丑专丞下丏丙.丞丂万丅不丒丘丟丗(), method:  System.Boolean 世万上丑专丞下丏丙.丞丂万丅不丒丘丟丗::一丗万丌万丄丏丕丏(System.Xml.Linq.XElement 丗丛不丁丑专专丂且)));
            if(val_6 == null)
            {
                    return (bool)val_8;
            }
            
            val_6.Remove();
            val_7 = this.丒丏丌与下丁三丝万;
            val_9 = null;
            val_9 = null;
            val_7.Save(fileName:  Rilisoft.世万上丑专丞下丏丙.万丄丂万一丑丙七丒);
            val_8 = 1;
            return (bool)val_8;
        }
        protected override bool 且丒丑丆丛丗丂丈下(string 下上丐丆丝丟丝丒不, out string 丙业与丙丗丝不丈东)
        {
            var val_11;
            .下上丐丆丝丟丝丒不 = 下上丐丆丝丟丝丒不;
            System.Xml.Linq.XElement val_6 = System.Linq.Enumerable.FirstOrDefault<System.Xml.Linq.XElement>(source:  this.丒丏丌与下丁三丝万.Root.Elements(name:  System.Xml.Linq.XName.op_Implicit(expandedName:  "Preference")), predicate:  new System.Func<System.Xml.Linq.XElement, System.Boolean>(object:  new 世万上丑专丞下丏丙.丘丞上世丗丘丏丐东(), method:  System.Boolean 世万上丑专丞下丏丙.丘丞上世丗丘丏丐东::丛丄不七丌丆丘丆丗(System.Xml.Linq.XElement 丗丛不丁丑专专丂且)));
            if(val_6 == null)
            {
                goto label_5;
            }
            
            System.Xml.Linq.XElement val_8 = val_6.Element(name:  System.Xml.Linq.XName.op_Implicit(expandedName:  "Value"));
            if(val_8 == null)
            {
                goto label_5;
            }
            
            string val_9 = val_8.Value;
            val_11 = 1;
            goto label_6;
            label_5:
            val_11 = 0;
            label_6:
            丙业与丙丗丝不丈东 = val_6;
            return (bool)val_11;
        }
        public override void 丂且不业丂专丛丆东()
        {
            null = null;
            this.丒丏丌与下丁三丝万.Save(fileName:  Rilisoft.世万上丑专丞下丏丙.万丄丂万一丑丙七丒);
        }
        public override System.Collections.Generic.ICollection<string> get_Keys()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override System.Collections.Generic.ICollection<string> get_Values()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override void Clear()
        {
            var val_2;
            this.丒丏丌与下丁三丝万.Root.RemoveNodes();
            val_2 = null;
            val_2 = null;
            this.丒丏丌与下丁三丝万.Save(fileName:  Rilisoft.世万上丑专丞下丏丙.万丄丂万一丑丙七丒);
        }
        public override int get_Count()
        {
            return System.Linq.Enumerable.Count<System.Xml.Linq.XElement>(source:  this.丒丏丌与下丁三丝万.Root.Elements());
        }
        public override bool get_IsReadOnly()
        {
            return false;
        }
        public override System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        internal static string 丕丞专不丌东丒丄世()
        {
            null = null;
            return (string)Rilisoft.世万上丑专丞下丏丙.万丄丂万一丑丙七丒;
        }
    
    }

}
