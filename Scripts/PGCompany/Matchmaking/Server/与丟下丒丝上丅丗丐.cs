using UnityEngine;

namespace PGCompany.Matchmaking.Server
{
    internal sealed class 与丟下丒丝上丅丗丐
    {
        // Fields
        internal string 丛三三与丁丘丄丑下;
        internal string 丝万丙上且丒且丂三;
        internal string 专丐下一且丕丟丐一;
        internal byte[] 丘专丅丞七且丗东丁;
        internal UnityEngine.Texture2D 丂丒丘丅专丗丂世丛;
        internal string 万丐丆丗丏丝七东专;
        internal string 丛丗丅丆丕丅上丑三;
        internal string 专下不丘丘丝丅七三;
        internal string[] 丌丝下丄业一丄不三;
        internal string[] 世东丏三三丑丁且东;
        internal int[] 丅专丕三且丑丘专下;
        internal int[] 丐丅下世一丛万丑丟;
        internal float[] 丘专下与三丗丝丝丁;
        internal int 七一丞丈万丛下丘上;
        internal string 丈丐丕业下丟业丛一;
        internal byte[] 丝专丌七万丈丏且丐;
        internal string 上丈专丌万丕丙万丘;
        internal string 丟世丟丐且丐丟七上;
        internal string 且与丛专丗丞丑丑丝;
        internal bool 丐丄下丒世丏七且丘;
        internal bool 丕三丑丛与专丏丒丒;
        internal bool 丐丑且下丗丘丗三丙;
        internal bool 世丛世且丆不丐丌丝;
        internal string 与丙丕丛一丌丛丆丈;
        internal bool 丈七与世丏丕业世丙;
        internal string 丐专下三丙三世且万;
        
        // Methods
        public 与丟下丒丝上丅丗丐(System.Collections.Generic.Dictionary<string, object> 万丘丁丛下丈丘丆丌)
        {
            与丟下丒丝上丅丗丐.<>c val_118;
            var val_119;
            var val_120;
            var val_121;
            var val_123;
            var val_124;
            System.Collections.IEnumerable val_125;
            var val_126;
            var val_127;
            bool val_128;
            var val_129;
            var val_130;
            string val_131;
            var val_132;
            var val_133;
            bool val_134;
            var val_135;
            var val_136;
            var val_138;
            var val_139;
            bool val_140;
            var val_141;
            var val_142;
            var val_144;
            string val_145;
            var val_146;
            bool val_147;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丒丐丐丙丘丂丂丗东)) != false)
            {
                    string val_3 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丒丐丐丙丘丂丂丗东]);
            }
            
            this.丛三三与丁丘丄丑下 = "Player";
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丟丆东丑三丙丄丆不)) != false)
            {
                    string val_6 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丟丆东丑三丙丄丆不]);
            }
            
            this.丝万丙上且丒且丂三 = "0";
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丗丅丙丕丛丁丂丄万)) != false)
            {
                    string val_9 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丗丅丙丕丛丁丂丄万]);
            }
            
            this.万丐丆丗丏丝七东专 = "0";
            this.专丐下一且丕丟丐一 = System.String.alignConst;
            this.专下不丘丘丝丅七三 = System.String.alignConst;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丕与丌丂万一三丘丂)) != false)
            {
                    val_118 = 1152921516622706448;
                val_119 = 1152921504618561536;
                int val_12 = System.Convert.ToInt32(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丕与丌丂万一三丘丂]);
                if(((val_12 & 2147483648) == 0) && (ClanCreateGui.三丗不丙丘丂业丝三().Count > val_12))
            {
                    if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.万丂丞丌丛丂丅丑万)) != false)
            {
                    this.专丐下一且丕丟丐一 = System.Convert.ToBase64String(inArray:  UnityEngine.ImageConversion.EncodeToPNG(tex:  ClanCreateGui.三丗不丙丘丂业丝三().Item[val_12]));
                this.专下不丘丘丝丅七三 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.万丂丞丌丛丂丅丑万]);
            }
            
            }
            
            }
            
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丟丛丅丟世下丗丈专)) != false)
            {
                    object val_23 = 万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丟丛丅丟世下丗丈专];
                if(val_23 != null)
            {
                    val_23 = (null == null) ? (val_23) : 0;
            }
            
                System.Byte[] val_24 = System.Convert.FromBase64String(s:  0);
                this.丘专丅丞七且丗东丁 = val_24;
                UnityEngine.Texture2D val_25 = new UnityEngine.Texture2D(width:  64, height:  32, textureFormat:  4, mipChain:  false);
                bool val_26 = UnityEngine.ImageConversion.LoadImage(tex:  val_25, data:  val_24, markNonReadable:  true);
                val_25.filterMode = 0;
            }
            
            this.丂丒丘丅专丗丂世丛 = val_25;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丕一业丌丄下丈丂专)) != false)
            {
                    string val_29 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丕一业丌丄下丈丂专]);
            }
            
            this.丛丗丅丆丕丅上丑三 = "";
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.三不三三丆丅世丞三)) != false)
            {
                    object val_31 = 万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.三不三三丆丅世丞三];
                val_119 = 1152921505653702656;
                if((与丟下丒丝上丅丗丐.<>c.<>9__0_0) == null)
            {
                    val_118 = 与丟下丒丝上丅丗丐.<>c.<>9;
                System.Func<System.Int32, System.String> val_36 = new System.Func<System.Int32, System.String>(object:  val_118, method:  System.String 与丟下丒丝上丅丗丐.<>c::不丁丂丐丄丈万丆丞(int 三丟东丕丄丄下下丑));
                与丟下丒丝上丅丗丐.<>c.<>9__0_0 = val_36;
            }
            
                TSource[] val_38 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  System.Linq.Enumerable.Select<System.Object, System.Int32>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  0), selector:  new System.Func<System.Object, System.Int32>(object:  0, method:  public static System.Int32 System.Convert::ToInt32(object value))), selector:  val_36));
            }
            else
            {
                    string[] val_39 = new string[6];
                val_39[0] = "Weapon1";
                val_39[1] = "Weapon1";
                val_39[2] = "Weapon1";
                val_39[3] = "Weapon1";
                val_118 = "Weapon1";
                val_39[4] = val_118;
                val_39[5] = "Weapon1";
            }
            
            this.丌丝下丄业一丄不三 = val_39;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.与业丞三一万上一丟)) != false)
            {
                    object val_41 = 万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.与业丞三一万上一丟];
                val_119 = 1152921505653702656;
                if((与丟下丒丝上丅丗丐.<>c.<>9__0_1) == null)
            {
                    val_118 = 与丟下丒丝上丅丗丐.<>c.<>9;
                System.Func<System.Int32, System.String> val_45 = new System.Func<System.Int32, System.String>(object:  val_118, method:  System.String 与丟下丒丝上丅丗丐.<>c::丐丕丘三不丒丁丏丐(int 三丟东丕丄丄下下丑));
                与丟下丒丝上丅丗丐.<>c.<>9__0_1 = val_45;
            }
            
                TSource[] val_47 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  System.Linq.Enumerable.Select<System.Object, System.Int32>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  0), selector:  new System.Func<System.Object, System.Int32>(object:  0, method:  public static System.Int32 System.Convert::ToInt32(object value))), selector:  val_45));
            }
            else
            {
                    string[] val_48 = new string[6];
                val_48[0] = "Weapon1";
                val_48[1] = "Weapon1";
                val_48[2] = "Weapon1";
                val_48[3] = "Weapon1";
                val_118 = "Weapon1";
                val_48[4] = val_118;
                val_48[5] = "Weapon1";
            }
            
            this.世东丏三三丑丁且东 = val_48;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丁丑丗丙丌七丞且丌)) != false)
            {
                    object val_50 = 万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丁丑丗丙丌七丞且丌];
                TSource[] val_54 = System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<System.Object, System.Int32>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  0), selector:  new System.Func<System.Object, System.Int32>(object:  0, method:  public static System.Int32 System.Convert::ToInt32(object value))));
            }
            
            this.丅专丕三且丑丘专下 = new int[0];
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丐万丘七专上丅丛丅)) == false)
            {
                goto label_162;
            }
            
            if((万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丐万丘七专上丅丛丅] == null) || (null == null))
            {
                goto label_168;
            }
            
            goto label_168;
            label_162:
            label_168:
            this.丐专下三丙三世且万 = "gadget_fraggrenade";
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.下且丙业丐上丁丟专)) != false)
            {
                    object val_59 = 万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.下且丙业丐上丁丟专];
            }
            
            int[] val_60 = new int[2];
            val_60[0] = 1;
            this.丐丅下世一丛万丑丟 = val_60;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.万专丘丝丄丆一丑丞)) != false)
            {
                    object val_62 = 万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.万专丘丝丄丆一丑丞];
            }
            
            this.丘专下与三丗丝丝丁 = new float[3] {-6.352689E-23f, 8.82818E-44f, 4.172329E-08f};
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.下东三丐七丐一丛业)) != false)
            {
                    int val_66 = System.Convert.ToInt32(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.下东三丐七丐一丛业]);
            }
            
            this.七一丞丈万丛下丘上 = 0;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丐丄一专丑丌世丞不)) != false)
            {
                    string val_69 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丐丄一专丑丌世丞不]);
            }
            
            this.上丈专丌万丕丙万丘 = 与丂丏丛丞丞丒丟丄.丄丄丏丛且丛丙且丑();
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丁丛丂丕与丅丏不上)) != false)
            {
                    bool val_74 = System.Convert.ToBoolean(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丁丛丂丕与丅丏不上]);
            }
            
            this.丐丄下丒世丏七且丘 = true;
            val_120 = null;
            val_120 = null;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.万丛丄一专丌丄东丟)) != false)
            {
                    val_121 = null;
                val_121 = null;
                string val_77 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.万丛丄一专丌丄东丟]);
            }
            
            this.丈丐丕业下丟业丛一 = 与丂丏丛丞丞丒丟丄.丟丕丈丙丈业业专业();
            val_123 = null;
            val_123 = null;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.东丒丒丅丙丆七上丄)) != false)
            {
                    val_124 = null;
                val_124 = null;
                object val_80 = 万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.东丒丒丅丙丆七上丄];
                if(val_80 != null)
            {
                    val_125 = val_80;
                if(val_125 == null)
            {
                    val_125 = 0;
            }
            
            }
            
                this.丝专丌七万丈丏且丐 = System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Select<System.Object, System.Byte>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  val_125), selector:  new System.Func<System.Object, System.Byte>(object:  0, method:  public static System.Byte System.Convert::ToByte(object value))));
            }
            
            val_126 = null;
            val_126 = null;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丄万丞七三丕丅丌丕)) != false)
            {
                    val_127 = null;
                val_127 = null;
                val_128 = System.Convert.ToBoolean(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丄万丞七三丕丅丌丕]);
            }
            else
            {
                    val_128 = true;
            }
            
            this.世丛世且丆不丐丌丝 = val_128;
            val_129 = null;
            val_129 = null;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.专一丈丑丆下东丕丙)) != false)
            {
                    val_130 = null;
                val_130 = null;
                string val_90 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.专一丈丑丆下东丕丙]);
            }
            else
            {
                    val_131 = "MaskNoneEquipped";
            }
            
            this.丟世丟丐且丐丟七上 = val_131;
            val_132 = null;
            val_132 = null;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.世世上万丗丞丕且丝)) != false)
            {
                    val_133 = null;
                val_133 = null;
                val_134 = System.Convert.ToBoolean(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.世世上万丗丞丕且丝]);
            }
            else
            {
                    val_134 = true;
            }
            
            this.丕三丑丛与专丏丒丒 = val_134;
            val_135 = null;
            val_135 = null;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.且丌专一丟一丄丁丏)) != false)
            {
                    val_136 = null;
                val_136 = null;
                string val_96 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.且丌专一丟一丄丁丏]);
            }
            
            this.且与丛专丗丞丑丑丝 = 与丂丏丛丞丞丒丟丄.丏丟且丛业不丙七丟();
            val_138 = null;
            val_138 = null;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丈丅三丗丅且丅丏丄)) != false)
            {
                    val_139 = null;
                val_139 = null;
                val_140 = System.Convert.ToBoolean(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丈丅三丗丅且丅丏丄]);
            }
            else
            {
                    val_140 = true;
            }
            
            this.丐丑且下丗丘丗三丙 = val_140;
            val_141 = null;
            val_141 = null;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  MatchmakingConnect.丛丟丅丒丒一一丅业)) != false)
            {
                    val_142 = null;
                val_142 = null;
                string val_103 = System.Convert.ToString(value:  万丘丁丛下丈丘丆丌.Item[MatchmakingConnect.丛丟丅丒丒一一丅业]);
            }
            
            this.与丙丕丛一丌丛丆丈 = 与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙();
            val_144 = null;
            val_144 = null;
            val_145 = MatchmakingConnect.三丄丈丄世丏丞丝丌;
            if((万丘丁丛下丈丘丆丌.ContainsKey(key:  val_145)) != false)
            {
                    val_146 = null;
                val_146 = null;
                val_145 = MatchmakingConnect.三丄丈丄世丏丞丝丌;
                val_147 = System.Convert.ToBoolean(value:  万丘丁丛下丈丘丆丌.Item[val_145]);
            }
            else
            {
                    val_147 = true;
            }
            
            this.丈七与世丏丕业世丙 = val_147;
        }
    
    }

}
