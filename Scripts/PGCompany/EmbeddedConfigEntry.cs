using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class EmbeddedConfigEntry
    {
        // Fields
        private PGCompany.ConfigId _configId;
        private string _configJson;
        private string _configHash;
        private static readonly System.Text.UTF8Encoding s_utf8Encoding;
        
        // Properties
        public PGCompany.ConfigId ConfigId { get; }
        public string ConfigJson { get; }
        public string ConfigHash { get; }
        
        // Methods
        public PGCompany.ConfigId get_ConfigId()
        {
            return (PGCompany.ConfigId)this._configId;
        }
        public string get_ConfigJson()
        {
            return (string)this._configJson;
        }
        public string get_ConfigHash()
        {
            return (string)this._configHash;
        }
        public EmbeddedConfigEntry(PGCompany.ConfigId 丈丄丈世一且不不丁, string 与丁丁上丝且世三万)
        {
            val_1 = new System.Object();
            this._configJson = val_1;
            this._configId = 丈丄丈世一且不不丁;
            this.丏且丕丄世丕不丕丙();
        }
        internal void 丏且丕丄世丕不丕丙()
        {
            this._configHash = PGCompany.EmbeddedConfigEntry.丌丘丝丂丕丛丘丐丕(丑与丂丌世丕丆一丗:  this._configJson);
        }
        internal static string 丌丘丝丂丕丛丘丐丕(string 丑与丂丌世丕丆一丗)
        {
            var val_7 = null;
            int val_2 = 丑与丂丌世丕丆一丗.Length;
            System.Security.Cryptography.SHA256Managed val_3 = new System.Security.Cryptography.SHA256Managed();
            if(val_3 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_3.Dispose();
            }
            
            if(0 != 1)
            {
                    return (string)PGCompany.丒与东丄丆世丏丙下.万丂丙丄三世专世丞(三丒丂世丕丟东丆丏:  val_3.ComputeHash(buffer:  new byte[0], offset:  0, count:  PGCompany.EmbeddedConfigEntry.s_utf8Encoding), 丛上丙丄丄七丈且丅:  0, 丏上万丅丏一不不丕:  8);
            }
            
            if(0 == 0)
            {
                    return (string)PGCompany.丒与东丄丆世丏丙下.万丂丙丄三世专世丞(三丒丂世丕丟东丆丏:  val_3.ComputeHash(buffer:  new byte[0], offset:  0, count:  PGCompany.EmbeddedConfigEntry.s_utf8Encoding), 丛上丙丄丄七丈且丅:  0, 丏上万丅丏一不不丕:  8);
            }
            
            return (string)PGCompany.丒与东丄丆世丏丙下.万丂丙丄三世专世丞(三丒丂世丕丟东丆丏:  val_3.ComputeHash(buffer:  new byte[0], offset:  0, count:  PGCompany.EmbeddedConfigEntry.s_utf8Encoding), 丛上丙丄丄七丈且丅:  0, 丏上万丅丏一不不丕:  8);
        }
        private static EmbeddedConfigEntry()
        {
            PGCompany.EmbeddedConfigEntry.s_utf8Encoding = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier:  false, throwOnInvalidBytes:  false);
        }
    
    }

}
