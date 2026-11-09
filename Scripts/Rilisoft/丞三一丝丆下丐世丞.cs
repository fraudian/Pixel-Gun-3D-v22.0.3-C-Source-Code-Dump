using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丞三一丝丆下丐世丞 : ISavedGameMetadata
    {
        // Fields
        private string 丞世世上下丘丟上专;
        private System.DateTime <丒东万三丕三丑丆丒>k__BackingField;
        
        // Properties
        public string 三丌丙丄丒丂丄丁丙 { get; }
        public string 丛东下丌一丕丌一丁 { get; }
        public string 与丌丘专专与一丅且 { get; }
        public bool 丂专丕丁丕丑且丝丗 { get; }
        public System.DateTime 丕丑且三丌丝丗丑丆 { get; set; }
        public System.TimeSpan 丙东丝丁世不丕下丐 { get; }
        
        // Methods
        public 丞三一丝丆下丐世丞(string 丂万一与丈丛丝丌丝)
        {
            if(丂万一与丈丛丝丌丝 == null)
            {
                goto label_1;
            }
            
            label_6:
            this.丞世世上下丘丟上专 = 丂万一与丈丛丝丌丝;
            System.DateTime val_1 = System.DateTime.Now;
            this.<丒东万三丕三丑丆丒>k__BackingField = val_1;
            return;
            label_1:
            if(this != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        public string get_CoverImageURL()
        {
            return "http://example.com";
        }
        public string get_Description()
        {
            if(this.GetType() == null)
            {
                
            }
        
        }
        public string get_Filename()
        {
            return (string)this.丞世世上下丘丟上专;
        }
        public bool get_IsOpen()
        {
            return false;
        }
        public System.DateTime get_LastModifiedTimestamp()
        {
            return (System.DateTime)this.<丒东万三丕三丑丆丒>k__BackingField;
        }
        private void 丛三丏不与丄丛丆丂(System.DateTime 丙业与丙丗丝不丈东)
        {
            this.<丒东万三丕三丑丆丒>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.TimeSpan get_TotalTimePlayed()
        {
            null = null;
            return (System.TimeSpan)System.TimeSpan.Zero;
        }
    
    }

}
