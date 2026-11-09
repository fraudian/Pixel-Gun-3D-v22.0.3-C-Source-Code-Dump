using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丞丂丂丕丅丅丙丝丒 : Exception
    {
        // Fields
        private readonly GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丁下丂与丛丝丐丄下;
        
        // Properties
        public GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 万业世丏丐丏丏丕且 { get; }
        
        // Methods
        public 丞丂丂丕丅丅丙丝丒(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐)
        {
            string val_1 = Rilisoft.丞丂丂丕丅丅丙丝丒.丟丟丝丅丗丞万丆丗(丆丞丄丄丕七三专丐:  丆丞丄丄丕七三专丐);
            this.丁下丂与丛丝丐丄下 = 丆丞丄丄丕七三专丐;
        }
        public GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丞丝一且上丅丙丂丟()
        {
            return (GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus)this.丁下丂与丛丝丐丄下;
        }
        private static string 丟丟丝丅丗丞万丆丗(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐)
        {
            return (string)"SavedGameRequestStatus." + 丆丞丄丄丕七三专丐;
        }
    
    }

}
