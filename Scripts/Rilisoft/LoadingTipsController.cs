using UnityEngine;

namespace Rilisoft
{
    public class LoadingTipsController : Singleton<Rilisoft.LoadingTipsController>
    {
        // Fields
        private const int 不万东丈丄丒丞丁丌 = 2;
        private const string 丈三丆世丟丒丌丄丄 = "bp_bot_helper_blue";
        internal static bool 丌万丏与丞且丝丞东;
        internal static bool 丗丐丏专丌丅丛丈七;
        private System.Collections.Generic.Dictionary<Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑, System.Collections.Generic.Queue<int>> 丘丝丂业且东不丂丄;
        private System.Collections.Generic.List<Rilisoft.丄丕丏东丆丌七与且> 丙业丛丝与丟且丗专;
        private Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 丘丒丐万七丕丕三不;
        private Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 七与下丁东丐一东一;
        private Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 丂世丘不丐专丛七丕;
        private Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 业丙万丕世丕丐专丘;
        private bool 下丁丞丝丛一丘丐丒;
        private Rilisoft.丄丕丏东丆丌七与且 丙丁丘丝丞业丝丙丛;
        public float ShowingTime;
        
        // Properties
        public bool 世丑丗上丘丟丐丂丕 { get; set; }
        
        // Methods
        public bool get_IsShowing()
        {
            return (bool)this.下丁丞丝丛一丘丐丒;
        }
        public void set_IsShowing(bool 丙业与丙丗丝不丈东)
        {
            this.下丁丞丝丛一丘丐丒 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == false)
            {
                    return;
            }
            
            this.ShowingTime = 0f;
        }
        protected override void Awake()
        {
            Rilisoft.丄丕丏东丆丌七与且 val_115;
            var val_116;
            var val_117;
            this.Awake();
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1, 丁丅丈丌丟世丗丗丟:  1, 丞丅上丏丂且下丅与:  0, 丟丒丏丛三丟丑丗丝:  "Key_6042", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tutor_arsenal_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  2, 丁丅丈丌丟世丗丗丟:  1, 丞丅上丏丂且下丅与:  1, 丟丒丏丛三丟丑丗丝:  "Key_6043", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tutor_profile_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1, 丁丅丈丌丟世丗丗丟:  1, 丞丅上丏丂且下丅与:  3, 丟丒丏丛三丟丑丗丝:  "Key_6045", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tutor_levelup_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1, 丁丅丈丌丟世丗丗丟:  2, 丞丅上丏丂且下丅与:  4, 丟丒丏丛三丟丑丗丝:  "Key_6046", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_сontrols_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  2, 丁丅丈丌丟世丗丗丟:  2, 丞丅上丏丂且下丅与:  5, 丟丒丏丛三丟丑丗丝:  "Key_6047", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_сraft_icon", 不丛丅丞丐丞且丒丈:  4, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1, 丁丅丈丌丟世丗丗丟:  2, 丞丅上丏丂且下丅与:  6, 丟丒丏丛三丟丑丗丝:  "Key_6048", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_friends_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  2, 丁丅丈丌丟世丗丗丟:  2, 丞丅上丏丂且下丅与:  7, 丟丒丏丛三丟丑丗丝:  "Key_6049", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_clans_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  2, 丁丅丈丌丟世丗丗丟:  2, 丞丅上丏丂且下丅与:  8, 丟丒丏丛三丟丑丗丝:  "Key_6050", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_pets_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  8, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  9, 丟丒丏丛三丟丑丗丝:  "Key_6103", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_tur_exp_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  8, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  10, 丟丒丏丛三丟丑丗丝:  "Key_6104", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_team_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  8, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  11, 丟丒丏丛三丟丑丗丝:  "Key_6105", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_team_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  4, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  12, 丟丒丏丛三丟丑丗丝:  "Key_6058", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_mvlock_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  4, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  13, 丟丒丏丛三丟丑丗丝:  "Key_6059", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tutor_wdrop_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  4, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  14, 丟丒丏丛三丟丑丗丝:  "Key_6060", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_steps_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  4, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  15, 丟丒丏丛三丟丑丗丝:  "Key_6061", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_rl_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  4, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  16, 丟丒丏丛三丟丑丗丝:  "Key_6062", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_heal_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  16, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  17, 丟丒丏丛三丟丑丗丝:  "Key_6106", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_deathm_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  16, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  18, 丟丒丏丛三丟丑丗丝:  "Key_6107", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_score_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  16, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  19, 丟丒丏丛三丟丑丗丝:  "Key_6108", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_headsht_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  32, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  20, 丟丒丏丛三丟丑丗丝:  "Key_6109", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tutor_catgry_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  32, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  22, 丟丒丏丛三丟丑丗丝:  "Key_6111", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_scoredrop_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  64, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  23, 丟丒丏丛三丟丑丗丝:  "Key_6112", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_flagscore_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  64, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  24, 丟丒丏丛三丟丑丗丝:  "Key_6113", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_flagind_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  64, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  25, 丟丒丏丛三丟丑丗丝:  "Key_6114", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_relay_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  128, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  26, 丟丒丏丛三丟丑丗丝:  "Key_6115", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_dmntnspeed_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  128, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  27, 丟丒丏丛三丟丑丗丝:  "Key_6116", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_dmntnspeed2_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  128, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  28, 丟丒丏丛三丟丑丗丝:  "Key_6117", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_dmntn_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  256, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  29, 丟丒丏丛三丟丑丗丝:  "Key_6118", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_hgms_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  256, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  30, 丟丒丏丛三丟丑丗丝:  "Key_6119", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_hgms_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  256, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  31, 丟丒丏丛三丟丑丗丝:  "Key_6120", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_hgms_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  512, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  32, 丟丒丏丛三丟丑丗丝:  "Key_6121", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_otr_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  512, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  33, 丟丒丏丛三丟丑丗丝:  "Key_6122", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_otr_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  512, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  34, 丟丒丏丛三丟丑丗丝:  "Key_6123", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_otr_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1024, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  35, 丟丒丏丛三丟丑丗丝:  "Key_6124", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_duel_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1024, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  36, 丟丒丏丛三丟丑丗丝:  "Key_6125", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_duel_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1024, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  37, 丟丒丏丛三丟丑丗丝:  "Key_6126", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_duel_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  2048, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  38, 丟丒丏丛三丟丑丗丝:  "Key_6127", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_sg_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  2048, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  39, 丟丒丏丛三丟丑丗丝:  "Key_6128", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_sg_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  2048, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  40, 丟丒丏丛三丟丑丗丝:  "Key_6129", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_sg_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  12288, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  45, 丟丒丏丛三丟丑丗丝:  "Key_6202", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_3stars_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  4096, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  46, 丟丒丏丛三丟丑丗丝:  "Key_6203", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_cmp_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  4096, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  47, 丟丒丏丛三丟丑丗丝:  "Key_6204", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_cmp_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  16384, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  48, 丟丒丏丛三丟丑丗丝:  "Key_6205", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_snd_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  16384, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  49, 丟丒丏丛三丟丑丗丝:  "Key_6206", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_snd_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  16384, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  50, 丟丒丏丛三丟丑丗丝:  "Key_6207", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_snd_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  32768, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  51, 丟丒丏丛三丟丑丗丝:  "Key_6208", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_srvvl_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  32768, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  52, 丟丒丏丛三丟丑丗丝:  "Key_6209", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_srvvl_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  32768, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  53, 丟丒丏丛三丟丑丗丝:  "Key_6210", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_srvvl_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  65536, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  54, 丟丒丏丛三丟丑丗丝:  "Key_6211", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_prkr_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  65536, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  55, 丟丒丏丛三丟丑丗丝:  "Key_6212", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_prkr_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  65536, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  56, 丟丒丏丛三丟丑丗丝:  "Key_6213", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_prkr_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  131072, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  57, 丟丒丏丛三丟丑丗丝:  "Key_6214", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_cb_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  131072, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  58, 丟丒丏丛三丟丑丗丝:  "Key_6215", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_cb_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  131072, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  59, 丟丒丏丛三丟丑丗丝:  "Key_6216", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_cb_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  262144, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  60, 丟丒丏丛三丟丑丗丝:  "Key_6217", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_run_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  262144, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  61, 丟丒丏丛三丟丑丗丝:  "Key_6218", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_run_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  262144, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  62, 丟丒丏丛三丟丑丗丝:  "Key_6219", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_run_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  524288, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  63, 丟丒丏丛三丟丑丗丝:  "Key_6898", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_3stars_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1048576, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  64, 丟丒丏丛三丟丑丗丝:  "Key_7107", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_raids_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1048576, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  65, 丟丒丏丛三丟丑丗丝:  "Key_7108", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_raids_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  1048576, 丁丅丈丌丟世丗丗丟:  4, 丞丅上丏丂且下丅与:  66, 丟丒丏丛三丟丑丗丝:  "Key_7109", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_raids_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  33554432, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  67, 丟丒丏丛三丟丑丗丝:  "Key_8201", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_FortDefence_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  33554432, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  68, 丟丒丏丛三丟丑丗丝:  "Key_8202", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_FortDefence_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  33554432, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  69, 丟丒丏丛三丟丑丗丝:  "Key_8203", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_FortDefence_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  33554432, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  70, 丟丒丏丛三丟丑丗丝:  "Key_8204", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_FortDefence_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  67108864, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  71, 丟丒丏丛三丟丑丗丝:  "Key_8205", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_FortAttack_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  67108864, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  72, 丟丒丏丛三丟丑丗丝:  "Key_8206", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_FortAttack_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  67108864, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  73, 丟丒丏丛三丟丑丗丝:  "Key_8207", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_FortAttack_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  67108864, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  74, 丟丒丏丛三丟丑丗丝:  "Key_8208", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_FortAttack_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  134217728, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  75, 丟丒丏丛三丟丑丗丝:  "Key_8209", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_ClanWar_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  134217728, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  76, 丟丒丏丛三丟丑丗丝:  "Key_8210", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_ClanWar_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  134217728, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  77, 丟丒丏丛三丟丑丗丝:  "Key_8211", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_ClanWar_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  134217728, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  78, 丟丒丏丛三丟丑丗丝:  "Key_8212", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_ClanWar_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  268435456, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  79, 丟丒丏丛三丟丑丗丝:  "Key_8213", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_clans_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  268435456, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  80, 丟丒丏丛三丟丑丗丝:  "Key_8214", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_clans_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  268435456, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  81, 丟丒丏丛三丟丑丗丝:  "Key_8215", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_clans_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  268435456, 丁丅丈丌丟世丗丗丟:  5, 丞丅上丏丂且下丅与:  82, 丟丒丏丛三丟丑丗丝:  "Key_8216", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "feature_clans_icon", 不丛丅丞丐丞且丒丈:  6, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  83, 丟丒丏丛三丟丑丗丝:  "Key_10401", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_free_play_icon", 不丛丅丞丐丞且丒丈:  5, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  84, 丟丒丏丛三丟丑丗丝:  "Key_10402", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_free_play_icon", 不丛丅丞丐丞且丒丈:  5, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  85, 丟丒丏丛三丟丑丗丝:  "Key_10403", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_free_play_icon", 不丛丅丞丐丞且丒丈:  5, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  86, 丟丒丏丛三丟丑丗丝:  "Key_10404", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_free_play_icon", 不丛丅丞丐丞且丒丈:  5, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  87, 丟丒丏丛三丟丑丗丝:  "Key_11335", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_arms_race", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  88, 丟丒丏丛三丟丑丗丝:  "Key_11336", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_arms_race", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  89, 丟丒丏丛三丟丑丗丝:  "Key_11337", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_arms_race", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  90, 丟丒丏丛三丟丑丗丝:  "Key_11338", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_arms_race", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  91, 丟丒丏丛三丟丑丗丝:  "Key_11339", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_arms_race", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  92, 丟丒丏丛三丟丑丗丝:  "Key_11340", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_arms_race", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  93, 丟丒丏丛三丟丑丗丝:  "Key_11341", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_arms_race", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  94, 丟丒丏丛三丟丑丗丝:  "Key_11837", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  95, 丟丒丏丛三丟丑丗丝:  "Key_11838", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  96, 丟丒丏丛三丟丑丗丝:  "Key_11839", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  97, 丟丒丏丛三丟丑丗丝:  "Key_11840", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  98, 丟丒丏丛三丟丑丗丝:  "Key_11841", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  99, 丟丒丏丛三丟丑丗丝:  "Key_11842", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  100, 丟丒丏丛三丟丑丗丝:  "Key_11843", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  101, 丟丒丏丛三丟丑丗丝:  "Key_11844", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  102, 丟丒丏丛三丟丑丗丝:  "Key_11845", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  103, 丟丒丏丛三丟丑丗丝:  "Key_11846", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_plant_the_bomb", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  104, 丟丒丏丛三丟丑丗丝:  "Key_12569", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  105, 丟丒丏丛三丟丑丗丝:  "Key_12570", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  106, 丟丒丏丛三丟丑丗丝:  "Key_12571", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  107, 丟丒丏丛三丟丑丗丝:  "Key_12572", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  108, 丟丒丏丛三丟丑丗丝:  "Key_12573", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  109, 丟丒丏丛三丟丑丗丝:  "Key_12574", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  110, 丟丒丏丛三丟丑丗丝:  "Key_12575", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  111, 丟丒丏丛三丟丑丗丝:  "Key_12576", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  112, 丟丒丏丛三丟丑丗丝:  "Key_12577", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  113, 丟丒丏丛三丟丑丗丝:  "Key_12578", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_Mutation_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  114, 丟丒丏丛三丟丑丗丝:  "Key_12724", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_RedLight_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  115, 丟丒丏丛三丟丑丗丝:  "Key_12725", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_RedLight_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  116, 丟丒丏丛三丟丑丗丝:  "Key_12726", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_RedLight_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            this.丙业丛丝与丟且丗专.Add(item:  new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  117, 丟丒丏丛三丟丑丗丝:  "Key_12727", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_RedLight_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535));
            Rilisoft.丄丕丏东丆丌七与且 val_113 = null;
            val_115 = val_113;
            val_113 = new Rilisoft.丄丕丏东丆丌七与且(七丆丒与丗丌丄且丂:  0, 丁丅丈丌丟世丗丗丟:  3, 丞丅上丏丂且下丅与:  118, 丟丒丏丛三丟丑丗丝:  "Key_12728", 丁丕且丏丘丝东丆万:  "bp_bot_helper_blue", 丅万与丒丈丗丏丗丛:  "tip_RedLight_icon", 不丛丅丞丐丞且丒丈:  2, 丁丁丛丗丏三丁万东:  65535);
            this.丙业丛丝与丟且丗专.Add(item:  val_113);
            val_116 = null;
            val_116 = null;
            val_117 = 0;
            goto label_116;
            label_120:
            val_115 = this.丘丝丂业且东不丂丄;
            val_115.Add(key:  Rilisoft.丄丕丏东丆丌七与且.丟世丑专丅丌丙丏业.__il2cppRuntimeField_20, value:  new System.Collections.Generic.Queue<System.Int32>());
            val_117 = 1;
            label_116:
            if(val_117 < Rilisoft.丄丕丏东丆丌七与且.丟世丑专丅丌丙丏业.Length)
            {
                goto label_120;
            }
            
            this.丘丒丐万七丕丕三不 = ;
        }
        public void ShowTip()
        {
            LoadingTipsView val_1 = UnityEngine.Object.FindObjectOfType<LoadingTipsView>();
            if(val_1 == 0)
            {
                    return;
            }
            
            this.ShowTip(丞万一业万丕丏且丄:  val_1, 七丆丒与丗丌丄且丂:  0, 丛业丑丝丘丟七与丑:  false);
        }
        public void ShowTip(LoadingTipsView 丞万一业万丕丏且丄, Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 七丆丒与丗丌丄且丂 = 0, bool 丛业丑丝丘丟七与丑 = False)
        {
            LoadingTipsController.与丟业一丈上丅上不 val_56;
            object val_57;
            丟丙世丙不丛丈下丑 val_58;
            UnityEngine.Object val_59;
            TSource val_60;
            var val_61;
            bool val_62;
            System.Collections.Generic.List<Rilisoft.丄丕丏东丆丌七与且> val_63;
            var val_64;
            System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean> val_66;
            var val_68;
            var val_69;
            var val_71;
            Rilisoft.丄丕丏东丆丌七与且 val_72;
            var val_73;
            System.Collections.Generic.List<Rilisoft.丄丕丏东丆丌七与且> val_74;
            System.Func<T, TResult> val_75;
            var val_76;
            var val_77;
            var val_78;
            val_57 = 丛业丑丝丘丟七与丑;
            val_58 = 七丆丒与丗丌丄且丂;
            val_59 = 丞万一业万丕丏且丄;
            LoadingTipsController.与丟业一丈上丅上不 val_1 = new LoadingTipsController.与丟业一丈上丅上不();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .七丆丒与丗丌丄且丂 = val_58;
            if(val_59 == 0)
            {
                    return;
            }
            
            val_56 = 1152921525544440992;
            val_58 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_58 == 0)
            {
                goto label_12;
            }
            
            val_58 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_58.丝且丗丌丟丈世上万() == null)
            {
                goto label_12;
            }
            
            val_58 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_7.万丅一丟丑丆世丞且 == null)
            {
                goto label_12;
            }
            
            PGCompany.ClanWarController val_8 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            val_58 = val_8.万丅一丟丑丆世丞且;
            val_60 = (~val_58.丞专丅丁丁三丄上专()) & 1;
            if(val_57 == true)
            {
                goto label_15;
            }
            
            label_42:
            LoadingTipsController.丄业下丌专丄下丏丏 val_10 = null;
            val_57 = val_10;
            val_10 = new LoadingTipsController.丄业下丌专丄下丏丏();
            .东丟且丗且三专丙丁 = val_1;
            .丈丘丝一丗下丈丐不 = ExperienceController.丞丞丘业东丙丏七丌();
            丟丙世丙不丛丈下丑 val_55 = (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂;
            val_55 = val_55 | 1;
            .丟丐上丟丆丙丄丗丈 = val_55;
            val_61 = 1152921504616005632;
            System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean> val_12 = new System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean>(object:  val_10, method:  System.Boolean LoadingTipsController.丄业下丌专丄下丏丏::不丙丞上业丂且东丌(Rilisoft.丄丕丏东丆丌七与且 丙丒七丄上与丏丙丙));
            bool val_14 = this.七与下丁东丐一东一.HasFlag(flag:  new System.Enum());
            bool val_15 = this.丂世丘不丐专丛七丕.HasFlag(flag:  new System.Enum());
            val_62 = this.业丙万丕世丕丐专丘.HasFlag(flag:  new System.Enum());
            if((this.丘丒丐万七丕丕三不.HasFlag(flag:  new System.Enum())) == false)
            {
                goto label_28;
            }
            
            if((this.丙丁丘丝丞业丝丙丛 == null) || ((this.丘丒丐万七丕丕三不.HasFlag(flag:  new System.Enum())) == false))
            {
                goto label_39;
            }
            
            val_61 = val_61;
            val_62 = val_62;
            if(this.丙丁丘丝丞业丝丙丛.万丁一东丞丗丄丑业 != (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂)
            {
                    if((this.丘丒丐万七丕丕三不.HasFlag(flag:  new System.Enum())) == true)
            {
                goto label_39;
            }
            
            }
            
            if(this.丙丁丘丝丞业丝丙丛 == null)
            {
                goto label_39;
            }
            
            label_28:
            if(val_14 == true)
            {
                goto label_40;
            }
            
            goto label_47;
            label_12:
            val_60 = 0;
            if(val_57 == false)
            {
                goto label_42;
            }
            
            label_15:
            if(this.丙丁丘丝丞业丝丙丛 == null)
            {
                goto label_43;
            }
            
            val_59.SetTip(丆丛东丒丞一丈丘丆:  this.丙丁丘丝丞业丝丙丛);
            return;
            label_39:
            .丟丐上丟丆丙丄丗丈 = (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂;
            if(val_14 == false)
            {
                goto label_47;
            }
            
            label_40:
            if(((LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂.HasFlag(flag:  new System.Enum())) == false)
            {
                goto label_50;
            }
            
            .丟丐上丟丆丙丄丗丈 = 0;
            val_63 = this.丙业丛丝与丟且丗专;
            val_64 = null;
            val_64 = null;
            val_66 = LoadingTipsController.<>c.<>9__18_1;
            if(val_66 != null)
            {
                goto label_67;
            }
            
            System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean> val_20 = null;
            val_66 = val_20;
            val_20 = new System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean>(object:  LoadingTipsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LoadingTipsController.<>c::丈丞上丕与不丂丆三(Rilisoft.丄丕丏东丆丌七与且 丙丒七丄上与丏丙丙));
            LoadingTipsController.<>c.<>9__18_1 = val_66;
            goto label_67;
            label_43:
            if(val_59 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_22 = val_59.gameObject;
            val_68 = null;
            goto label_61;
            label_50:
            if(((LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂.HasFlag(flag:  new System.Enum())) == false)
            {
                goto label_64;
            }
            
            .丟丐上丟丆丙丄丗丈 = 0;
            val_63 = this.丙业丛丝与丟且丗专;
            val_69 = null;
            val_69 = null;
            val_66 = LoadingTipsController.<>c.<>9__18_2;
            if(val_66 == null)
            {
                    System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean> val_24 = null;
                val_66 = val_24;
                val_24 = new System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean>(object:  LoadingTipsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LoadingTipsController.<>c::丟丏丞七上丌三丟丐(Rilisoft.丄丕丏东丆丌七与且 丙丒七丄上与丏丙丙));
                LoadingTipsController.<>c.<>9__18_2 = val_66;
            }
            
            label_67:
            val_60 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丄丕丏东丆丌七与且>(source:  val_63, predicate:  val_24);
            if(val_15 == true)
            {
                goto label_93;
            }
            
            goto label_94;
            label_64:
            if((this.丙丁丘丝丞业丝丙丛 == null) || ((this.七与下丁东丐一东一.HasFlag(flag:  new System.Enum())) == false))
            {
                goto label_82;
            }
            
            val_61 = val_61;
            val_62 = val_62;
            if(this.丙丁丘丝丞业丝丙丛.万丁一东丞丗丄丑业 != (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂)
            {
                    if((this.七与下丁东丐一东一.HasFlag(flag:  new System.Enum())) == true)
            {
                goto label_82;
            }
            
            }
            
            if(this.丙丁丘丝丞业丝丙丛 == null)
            {
                goto label_82;
            }
            
            label_47:
            val_60 = 0;
            if(val_15 == false)
            {
                goto label_94;
            }
            
            label_93:
            List.Enumerator<T> val_29 = this.丙业丛丝与丟且丗专.GetEnumerator();
            label_90:
            if(((-208176560) & 1) == 0)
            {
                goto label_85;
            }
            
            if(this.丙丁丘丝丞业丝丙丛.万丁一东丞丗丄丑业 != (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂)
            {
                goto label_90;
            }
            
            new System.Collections.Generic.List<Rilisoft.丄丕丏东丆丌七与且>().Add(item:  this.七与下丁东丐一东一.丐丏七丌丕丗业且上());
            goto label_90;
            label_85:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_99;
            label_82:
            val_60 = 0;
            .丟丐上丟丆丙丄丗丈 = (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂;
            if(val_15 == true)
            {
                goto label_93;
            }
            
            goto label_94;
            label_99:
            val_71 = 0;
            goto label_100;
            label_106:
            if(val_15 != false)
            {
                    val_72 = val_15.Item[0];
            }
            else
            {
                    val_72 = val_15.Item[0];
            }
            
            int val_35 = UnityEngine.Random.Range(min:  0, max:  val_15.Count);
            if(val_15 != false)
            {
                    val_15.set_Item(index:  0, value:  val_15.Item[val_35]);
            }
            else
            {
                    val_15.set_Item(index:  0, value:  val_15.Item[val_35]);
            }
            
            val_15.set_Item(index:  val_35, value:  val_72);
            val_71 = 1;
            label_100:
            if(val_71 < val_15.Count)
            {
                goto label_106;
            }
            
            val_62 = val_62;
            if((this.丙丁丘丝丞业丝丙丛 == null) || (this.丙丁丘丝丞业丝丙丛.万丁一东丞丗丄丑业 != (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂))
            {
                goto label_110;
            }
            
            val_61 = 1152921504616005632;
            val_60 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丄丕丏东丆丌七与且>(source:  val_15, predicate:  new System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean>(object:  (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁, method:  System.Boolean LoadingTipsController.与丟业一丈上丅上不::丘东丘丌一丟丟三丞(Rilisoft.丄丕丏东丆丌七与且 丙丒七丄上与丏丙丙)));
            if(val_57 != null)
            {
                goto label_113;
            }
            
            goto label_112;
            label_110:
            val_61 = 1152921504616005632;
            val_60 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丄丕丏东丆丌七与且>(source:  val_15);
            if(val_57 != null)
            {
                goto label_113;
            }
            
            label_112:
            label_113:
            .丟丐上丟丆丙丄丗丈 = 0;
            label_94:
            val_73 = 1;
            if(val_62 != false)
            {
                    val_73 = 1;
                .丟丐上丟丆丙丄丗丈 = (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂;
            }
            
            if(val_60 != 0)
            {
                    val_73 = 1;
                .丟丐上丟丆丙丄丗丈 = 134217728;
            }
            
            if((LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂 != 268435456)
            {
                goto label_118;
            }
            
            .丟丐上丟丆丙丄丗丈 = 268435456;
            val_59 = this;
            val_74 = this.丙业丛丝与丟且丗专;
            goto label_119;
            label_118:
            val_59 = this;
            val_74 = this.丙业丛丝与丟且丗专;
            if(val_73 == 0)
            {
                goto label_120;
            }
            
            label_119:
            System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean> val_42 = null;
            val_75 = val_42;
            val_42 = new System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean>(object:  val_10, method:  System.Boolean LoadingTipsController.丄业下丌专丄下丏丏::丐丘专与三丝丑丟丅(Rilisoft.丄丕丏东丆丌七与且 丙丒七丄上与丏丙丙));
            val_76 = 1;
            goto label_121;
            label_120:
            val_75 = val_12;
            val_76 = 0;
            label_121:
            val_77 = 1152921543053209584;
            val_78 = 1152921543053214704;
            val_58 = System.Linq.Enumerable.ToArray<Rilisoft.丄丕丏东丆丌七与且>(source:  System.Linq.Enumerable.Where<Rilisoft.丄丕丏东丆丌七与且>(source:  val_74, predicate:  val_12));
            if((val_44.Length == 0) || ((LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂 != 2304))
            {
                goto label_125;
            }
            
            System.Collections.Generic.List<Rilisoft.丄丕丏东丆丌七与且> val_45 = new System.Collections.Generic.List<Rilisoft.丄丕丏东丆丌七与且>();
            if(val_44.Length < 1)
            {
                goto label_126;
            }
            
            label_134:
            if((val_44[0x0][0] + 32) != 2304)
            {
                    if((val_44[0x0][0] + 32) != 1)
            {
                goto label_132;
            }
            
            }
            
            if(this.丙丁丘丝丞业丝丙丛 != null)
            {
                    if(this.丙丁丘丝丞业丝丙丛.万丁一东丞丗丄丑业 == (val_44[0x0][0] + 32))
            {
                goto label_132;
            }
            
            }
            
            val_45.Add(item:  val_58[0]);
            label_132:
            if((0 + 1) < val_44.Length)
            {
                goto label_134;
            }
            
            label_126:
            val_77 = 1152921543053209584;
            val_78 = 1152921543053214704;
            val_58 = val_45.ToArray();
            if(val_58 == null)
            {
                goto label_136;
            }
            
            label_125:
            var val_48 = (val_47.Length == 0) ? 1 : 0;
            val_48 = val_76 & val_48;
            if(val_48 == 1)
            {
                    .丟丐上丟丆丙丄丗丈 = 1;
                val_58 = System.Linq.Enumerable.ToArray<Rilisoft.丄丕丏东丆丌七与且>(source:  System.Linq.Enumerable.Where<Rilisoft.丄丕丏东丆丌七与且>(source:  val_63, predicate:  val_12));
            }
            
            if((val_50.Length != 0) && (GameConnect.丄丏丒丏上东业丒一() != true))
            {
                    if(GameConnect.一业上七丟业且业丙() != true)
            {
                    val_60 = val_58[(long)UnityEngine.Random.Range(min:  0, max:  val_50.Length)];
            }
            
            }
            
            if(val_60 != 0)
            {
                    val_59.SetTip(丆丛东丒丞一丈丘丆:  val_60);
                this.下丁丞丝丛一丘丐丒 = true;
                this.ShowingTime = 0f;
                val_56 = (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁;
                this.丑不丙专丐三七上丙(丁丅丈丌丟世丗丗丟:  (LoadingTipsController.丄业下丌专丄下丏丏)[1152921543053461168].东丟且丗且三专丙丁.七丆丒与丗丌丄且丂, 丞丅上丏丂且下丅与:  val_50[(long)(int)(val_53)][0] + 28);
                this.丙丁丘丝丞业丝丙丛 = val_60;
                return;
            }
            
            val_68 = null;
            label_61:
            val_56 = val_59.gameObject;
            UnityEngine.Object.Destroy(obj:  val_56);
            return;
            label_136:
        }
        internal void 七丅丏丄丏世丙万万(Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 丆万一不丌且东丐丐)
        {
            丟丙世丙不丛丈下丑 val_4 = 丆万一不丌且东丐丐;
            LoadingTipsController.业丂七丏丟丕丌丂世 val_1 = new LoadingTipsController.业丂七丏丟丕丌丂世();
            if(val_1 != null)
            {
                    .丆万一不丌且东丐丐 = val_4;
            }
            else
            {
                    mem[16] = val_4;
                val_4 = mem[16];
            }
            
            if(val_4 == 2304)
            {
                    return;
            }
            
            val_4 = this.丙业丛丝与丟且丗专;
            this.丙丁丘丝丞业丝丙丛 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丄丕丏东丆丌七与且>(source:  val_4, predicate:  new System.Func<Rilisoft.丄丕丏东丆丌七与且, System.Boolean>(object:  val_1, method:  System.Boolean LoadingTipsController.业丂七丏丟丕丌丂世::不丒丛专上三专丏东(Rilisoft.丄丕丏东丆丌七与且 丙丒七丄上与丏丙丙)));
        }
        internal static Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 七与丙一丞下丏丕业(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
        {
            if(丂丛丑东不丅丈一东 > 38)
            {
                    return 0;
            }
            
            return (丟丙世丙不丛丈下丑)106045152 + (丂丛丑东不丅丈一东) << 2;
        }
        private void 丑不丙专丐三七上丙(Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 丁丅丈丌丟世丗丗丟, int 丞丅上丏丂且下丅与)
        {
            if((this.丘丝丂业且东不丂丄.ContainsKey(key:  丁丅丈丌丟世丗丗丟)) != true)
            {
                    this.丘丝丂业且东不丂丄.Add(key:  丁丅丈丌丟世丗丗丟, value:  new System.Collections.Generic.Queue<System.Int32>());
            }
            
            this.丘丝丂业且东不丂丄.Item[丁丅丈丌丟世丗丗丟].Enqueue(item:  丞丅上丏丂且下丅与);
            if(this.丘丝丂业且东不丂丄.Item[丁丅丈丌丟世丗丗丟].Count < 3)
            {
                    return;
            }
            
            int val_7 = this.丘丝丂业且东不丂丄.Item[丁丅丈丌丟世丗丗丟].Dequeue();
        }
        private bool 不丛七丕丌丙丑业丆(Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 七丆丒与丗丌丄且丂, Rilisoft.丄丕丏东丆丌七与且 丆丛东丒丞一丈丘丆)
        {
            int val_5;
            丟丙世丙不丛丈下丑 val_6;
            var val_7;
            val_5 = 丆丛东丒丞一丈丘丆;
            val_6 = 七丆丒与丗丌丄且丂;
            if(val_6 == 0)
            {
                goto label_7;
            }
            
            if(val_5 == null)
            {
                    if(64 == 0)
            {
                goto label_7;
            }
            
            }
            
            if((丆丛东丒丞一丈丘丆.万丁一东丞丗丄丑业.HasFlag(flag:  new System.Enum())) == false)
            {
                goto label_7;
            }
            
            val_6 = 丆丛东丒丞一丈丘丆.万丁一东丞丗丄丑业 & val_6;
            if((this.丘丝丂业且东不丂丄.ContainsKey(key:  val_6)) == false)
            {
                goto label_7;
            }
            
            val_5 = 丆丛东丒丞一丈丘丆.下丄丈不与世丐业专;
            val_7 = this.丘丝丂业且东不丂丄.Item[val_6];
            bool val_4 = val_7.Contains(item:  val_5);
            goto label_10;
            label_7:
            val_7 = 0;
            label_10:
            val_7 = val_7 & 1;
            return (bool)val_7;
        }
        private void Update()
        {
            if(this.下丁丞丝丛一丘丐丒 == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.ShowingTime + val_1;
            this.ShowingTime = val_1;
        }
        public LoadingTipsController()
        {
            this.丘丝丂业且东不丂丄 = new System.Collections.Generic.Dictionary<丟丙世丙不丛丈下丑, System.Collections.Generic.Queue<System.Int32>>();
            this.丙业丛丝与丟且丗专 = new System.Collections.Generic.List<Rilisoft.丄丕丏东丆丌七与且>();
        }
        private static LoadingTipsController()
        {
        
        }
    
    }

}
