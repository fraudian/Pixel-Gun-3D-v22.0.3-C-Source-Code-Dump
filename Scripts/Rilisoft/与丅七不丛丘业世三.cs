using UnityEngine;

namespace Rilisoft
{
    internal sealed class 与丅七不丛丘业世三 : IConflictResolver
    {
        // Fields
        private static readonly Rilisoft.与丅七不丛丘业世三 世丒丞七专三与万丕;
        
        // Properties
        internal static Rilisoft.与丅七不丛丘业世三 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        private 与丅七不丛丘业世三()
        {
        
        }
        internal static Rilisoft.与丅七不丛丘业世三 丑七不且上丗丁一世()
        {
            null = null;
            return (Rilisoft.与丅七不丛丘业世三)Rilisoft.与丅七不丛丘业世三.世丒丞七专三与万丕;
        }
        public void ChooseMetadata(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 丟丝丗世丑世不与丘)
        {
            int val_5;
            if(丟丝丗世丑世不与丘 == null)
            {
                goto label_1;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_5;
            label_1:
            val_5 = System.String.alignConst;
            goto label_6;
            label_5:
            val_5 = 丟丝丗世丑世不与丘.Filename;
            label_6:
            object[] val_3 = new object[2];
            System.Type val_4 = this.GetType();
            if(val_3 == null)
            {
                goto label_8;
            }
            
            if(val_4 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_4 == null)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            val_3[0] = val_4;
            val_3[1] = val_5;
            UnityEngine.Debug.LogFormat(format:  "{0}(\'{1}\').ChooseMetadata()", args:  val_3);
        }
        public void ResolveConflict(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 丟丝丗世丑世不与丘, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate 业丗丟万丞万世丙丁, byte[] 丌丅东且一专丕丙丗)
        {
            int val_4;
            if(丟丝丗世丑世不与丘 == null)
            {
                goto label_1;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_5;
            label_1:
            val_4 = System.String.alignConst;
            goto label_6;
            label_5:
            val_4 = 丟丝丗世丑世不与丘.Filename;
            label_6:
            object[] val_3 = new object[1];
            if(val_3 == null)
            {
                goto label_7;
            }
            
            if(val_4 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_4 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            val_3[0] = val_4;
            UnityEngine.Debug.LogFormat(format:  "[DummyConflictResolver] ResolveConflict => filename: {0}", args:  val_3);
        }
        private static 与丅七不丛丘业世三()
        {
            Rilisoft.与丅七不丛丘业世三.世丒丞七专三与万丕 = new Rilisoft.与丅七不丛丘业世三();
        }
    
    }

}
