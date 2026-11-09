using UnityEngine;

namespace Rilisoft
{
    internal sealed class 不丛世下丄且一丒东
    {
        // Fields
        public string 与与丁世丐东丒丑万;
        public string 丑丂东丆丆不丞专丌;
        public string 专丂丕丗丗东世丞下;
        
        // Methods
        internal string 东丌丆丄丙丂不与专()
        {
            string val_8;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.AppendFormat(format:  "mailto:{0}", arg0:  this.专丂丕丗丗东世丞下);
            System.Text.StringBuilder val_4 = val_1.AppendFormat(format:  "?subject={0}", arg0:  System.Uri.EscapeUriString(stringToEscape:  this.丑丂东丆丆不丞专丌));
            string val_5 = System.Uri.EscapeUriString(stringToEscape:  this.与与丁世丐东丒丑万);
            if(val_1 != null)
            {
                    val_8 = "&body={0}";
                System.Text.StringBuilder val_6 = val_1.AppendFormat(format:  val_8, arg0:  val_5);
            }
            else
            {
                    val_8 = "&body={0}";
                System.Text.StringBuilder val_7 = val_1.AppendFormat(format:  val_8, arg0:  val_5);
            }
        
        }
        public 不丛世下丄且一丒东()
        {
        
        }
    
    }

}
