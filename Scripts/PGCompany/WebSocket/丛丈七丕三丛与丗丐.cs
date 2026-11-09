using UnityEngine;

namespace PGCompany.WebSocket
{
    internal sealed class 丛丈七丕三丛与丗丐
    {
        // Fields
        private static PGCompany.WebSocket.丛丈七丕三丛与丗丐 丝业丆丁业三丈丟东;
        private static string <丗丆且丝丞丙丗丙丙>k__BackingField;
        private const string 业丄丟与丅下三丙七 = "{0}.log";
        private readonly string <丝丅三上专丒丅不三>k__BackingField;
        private readonly System.IO.DirectoryInfo 一万七丐下丈丂万丌;
        
        // Properties
        internal static string 与不丆东丁与丝业三 { get; set; }
        internal static PGCompany.WebSocket.丛丈七丕三丛与丗丐 丆丕丝丒不丙且丐丗 { get; }
        internal string 不下业上丏三丒丟一 { get; }
        
        // Methods
        internal static string 世丌丝丝专一丙丌丙()
        {
            null = null;
            return (string)PGCompany.WebSocket.丛丈七丕三丛与丗丐.<丗丆且丝丞丙丗丙丙>k__BackingField;
        }
        private static void 丝丂丂丄丙丁世三七(string 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.WebSocket.丛丈七丕三丛与丗丐.<丗丆且丝丞丙丗丙丙>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static PGCompany.WebSocket.丛丈七丕三丛与丗丐 丑七不且上丗丁一世()
        {
            var val_2;
            string val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PGCompany.WebSocket.丛丈七丕三丛与丗丐.业丄丟与丅下三丙七;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PGCompany.WebSocket.丛丈七丕三丛与丗丐 val_1 = null;
            val_3 = val_1;
            val_1 = new PGCompany.WebSocket.丛丈七丕三丛与丗丐();
            val_4 = null;
            val_4 = null;
            PGCompany.WebSocket.丛丈七丕三丛与丗丐.业丄丟与丅下三丙七 = val_3;
            return val_3;
        }
        internal string 万丂下世丐丗丒万万()
        {
            return (string)this.<丝丅三上专丒丅不三>k__BackingField;
        }
        internal 丛丈七丕三丛与丗丐()
        {
            System.DateTime val_1 = System.DateTime.Now;
            this.<丝丅三上专丒丅不三>k__BackingField = System.IO.Path.Combine(path1:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙(), path2:  System.String.Format(format:  "{0}.log", arg0:  val_1.dateData));
            if((System.IO.Directory.Exists(path:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙())) != true)
            {
                    System.IO.DirectoryInfo val_8 = System.IO.Directory.CreateDirectory(path:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙());
            }
            
            this.一万七丐下丈丂万丌 = new System.IO.DirectoryInfo(path:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙());
            this.丄不丅下丐丐七丑丟();
        }
        internal void 专世丞丟丄丏业丑七(string 丄丙下丝丛丒七丂丘)
        {
            var val_8;
            if((System.IO.Directory.Exists(path:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙())) != true)
            {
                    System.IO.DirectoryInfo val_4 = System.IO.Directory.CreateDirectory(path:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙());
            }
            
            string val_6 = System.Environment.NewLine;
            val_8 = 0;
            var val_8 = 0;
            val_8 = val_8 + 1;
            System.IO.File.AppendText(path:  this.<丝丅三上专丒丅不三>k__BackingField).Dispose();
            if(0 != 1)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        private void 丄不丅下丐丐七丑丟()
        {
            var val_17;
            var val_18;
            System.Func<System.IO.FileInfo, System.DateTime> val_20;
            var val_24;
            var val_25;
            val_17 = this;
            if((System.IO.Directory.Exists(path:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙())) == false)
            {
                    return;
            }
            
            val_18 = null;
            val_18 = null;
            val_20 = 丛丈七丕三丛与丗丐.<>c.<>9__14_0;
            if(val_20 == null)
            {
                    System.Func<System.IO.FileInfo, System.DateTime> val_4 = null;
                val_20 = val_4;
                val_4 = new System.Func<System.IO.FileInfo, System.DateTime>(object:  丛丈七丕三丛与丗丐.<>c.__il2cppRuntimeField_static_fields, method:  System.DateTime 丛丈七丕三丛与丗丐.<>c::丕七丏丆丐丈丒业一(System.IO.FileInfo 三丟东丕丄丄下下丑));
                丛丈七丕三丛与丗丐.<>c.<>9__14_0 = val_20;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_17 = System.Linq.Enumerable.Skip<System.IO.FileInfo>(source:  System.Linq.Enumerable.OrderByDescending<System.IO.FileInfo, System.DateTime>(source:  this.一万七丐下丈丂万丌.GetFiles(), keySelector:  val_4), count:  15).GetEnumerator();
            label_27:
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(val_17.MoveNext() == false)
            {
                goto label_20;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(val_17.Current != 0)
            {
                goto label_27;
            }
            
            goto label_27;
            label_20:
            val_24 = 0;
            val_25 = 0;
            if(val_17 == null)
            {
                
            }
            else
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_17.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_17 = ???;
            val_24 = ???;
        }
        internal System.Collections.Generic.IEnumerable<string> 且丒一丏且丂丂丌与()
        {
            var val_5;
            System.Func<System.IO.FileInfo, System.DateTime> val_7;
            var val_9;
            System.Func<System.IO.FileInfo, System.String> val_11;
            val_5 = null;
            val_5 = null;
            val_7 = 丛丈七丕三丛与丗丐.<>c.<>9__15_0;
            if(val_7 == null)
            {
                    System.Func<System.IO.FileInfo, System.DateTime> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Func<System.IO.FileInfo, System.DateTime>(object:  丛丈七丕三丛与丗丐.<>c.__il2cppRuntimeField_static_fields, method:  System.DateTime 丛丈七丕三丛与丗丐.<>c::丛业业丅下东丝且丟(System.IO.FileInfo 三丟东丕丄丄下下丑));
                丛丈七丕三丛与丗丐.<>c.<>9__15_0 = val_7;
            }
            
            val_9 = null;
            val_9 = null;
            val_11 = 丛丈七丕三丛与丗丐.<>c.<>9__15_1;
            if(val_11 != null)
            {
                    return System.Linq.Enumerable.Select<System.IO.FileInfo, System.String>(source:  System.Linq.Enumerable.OrderByDescending<System.IO.FileInfo, System.DateTime>(source:  this.一万七丐下丈丂万丌.GetFiles(), keySelector:  val_2), selector:  System.Func<System.IO.FileInfo, System.String> val_4 = null);
            }
            
            val_11 = val_4;
            val_4 = new System.Func<System.IO.FileInfo, System.String>(object:  丛丈七丕三丛与丗丐.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丛丈七丕三丛与丗丐.<>c::丑业丙三丂下丗丌丘(System.IO.FileInfo 三丟东丕丄丄下下丑));
            丛丈七丕三丛与丗丐.<>c.<>9__15_1 = val_11;
            return System.Linq.Enumerable.Select<System.IO.FileInfo, System.String>(source:  System.Linq.Enumerable.OrderByDescending<System.IO.FileInfo, System.DateTime>(source:  this.一万七丐下丈丂万丌.GetFiles(), keySelector:  val_2), selector:  val_4);
        }
        internal System.Collections.Generic.IEnumerable<string> 丏丕丈下丄世业丝下()
        {
            var val_3;
            System.Func<System.IO.FileInfo, System.String> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = 丛丈七丕三丛与丗丐.<>c.<>9__16_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.Select<System.IO.FileInfo, System.String>(source:  this.一万七丐下丈丂万丌.GetFiles(), selector:  System.Func<System.IO.FileInfo, System.String> val_2 = null);
            }
            
            val_5 = val_2;
            val_2 = new System.Func<System.IO.FileInfo, System.String>(object:  丛丈七丕三丛与丗丐.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丛丈七丕三丛与丗丐.<>c::七丂丅丂丅丅丁且下(System.IO.FileInfo 三丟东丕丄丄下下丑));
            丛丈七丕三丛与丗丐.<>c.<>9__16_0 = val_5;
            return System.Linq.Enumerable.Select<System.IO.FileInfo, System.String>(source:  this.一万七丐下丈丂万丌.GetFiles(), selector:  val_2);
        }
        internal string 丄世世专下丂丙世丗(string 丝丈丝丆世丁丄专丂)
        {
            string val_2 = System.IO.Path.Combine(path1:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙(), path2:  丝丈丝丆世丁丄专丂);
            return (string)((System.IO.File.Exists(path:  val_2)) != true) ? (val_2) : 0;
        }
        private static 丛丈七丕三丛与丗丐()
        {
            PGCompany.WebSocket.丛丈七丕三丛与丗丐.<丗丆且丝丞丙丗丙丙>k__BackingField = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "logs", path3:  "websocket");
        }
    
    }

}
