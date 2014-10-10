// <copyright file="RawStats.cs" company="Team7 Productions">
//     Copyright (c) 2014. All rights reserved.
// </copyright>
// <author>Jason Regnier</author>
namespace Team7.LoLApiManager.Models.Game
{
    /// <summary>
    /// Object representing the raw stats for a given game.
    /// </summary>
    public class RawStats
    {
        /// <summary>
        /// Get the number of kill assists.
        /// </summary>
        public int Assists
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of enemy inhibitors killed.
        /// </summary>
        public int BarracksKilled
        {
            get;
            set;
        }

        /// <summary>
        /// Get t he number of champions killed in the game.
        /// </summary>
        public int ChampionsKilled
        {
            get;
            set;
        }

        /// <summary>
        /// Get the combat player score.
        /// </summary>
        public int CombatPlayerScore
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of consumables purchased in the game.
        /// </summary>
        public int ConsumablesPurchased
        {
            get;
            set;
        }

        /// <summary>
        /// Get the damaged dealt.
        /// </summary>
        public int DamageDealtPlayer
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of double kills in the game.
        /// </summary>
        public int DoubleKills
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of first blood.
        /// </summary>
        public int FirstBlood
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of gold in the game.
        /// </summary>
        public int Gold
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of gold earned in the game.
        /// </summary>
        public int GoldEarned
        {
            get;
            set;
        }

        /// <summary>
        /// Get the amount of gold spent in the game.
        /// </summary>
        public int GoldSpent
        {
            get;
            set;
        }

        /// <summary>
        /// Get the first slot item.
        /// </summary>
        public int Item0
        {
            get;
            set;
        }

        /// <summary>
        /// Get the second slot item.
        /// </summary>
        public int Item1
        {
            get;
            set;
        }

        /// <summary>
        /// Get the third slot item.
        /// </summary>
        public int Item2
        {
            get;
            set;
        }

        /// <summary>
        /// Get the fourth slot item.
        /// </summary>
        public int Item3
        {
            get;
            set;
        }

        /// <summary>
        /// Get the fifth slot item.
        /// </summary>
        public int Item4
        {
            get;
            set;
        }

        /// <summary>
        /// Get the six slot item.
        /// </summary>
        public int Item5
        {
            get;
            set;
        }

        /// <summary>
        /// Get the seventh slot item.
        /// </summary>
        public int Item6
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of items purchased in the game.
        /// </summary>
        public int ItemsPurchased
        {
            get;
            set;
        }

        /// <summary>
        /// Get the number of killing sprees in the game.
        /// </summary>
        public int KillingSprees
        {
            get;
            set;
        }

        /// <summary>
        /// Get the largest critical strike.
        /// </summary>
        public int LargestCriticalStrike
        {
            get;
            set;
        }

        /// <summary>
        /// Get the largest killing spree.
        /// </summary>
        public int LargestKillingSpree
        {
            get;
            set;
        }

        /// <summary>
        /// Get the largest multi kill spree.
        /// </summary>
        public int LargestMultiKill
        {
            get;
            set;
        }

        /// <summary>
        /// Number of tier 3 items built.
        /// </summary>
        public int LegendaryItemsCreated
        {
            get;
            set;
        }

        /// <summary>
        /// Get the level.
        /// </summary>
        public int Level
        {
            get;
            set;
        }

        /// <summary>
        /// Get the magic damage dealt in the game.
        /// </summary>
        public int MagicDamageDealtPlayer
        {
            get;
            set;
        }

        /// <summary>
        /// Get the magic dealt to other champions in the game.
        /// </summary>
        public int MagicDamageDealtToChampions
        {
            get;
            set;
        }

        /// <summary>
        /// Get the magic damage taken in a game.
        /// </summary>
        public int MagicDamageTaken
        {
            get;
            set;
        }

        public int MinionsDenied
        {
            get;
            set;
        }

        public int MinionsKilled
        {
            get;
            set;
        }

        public int NeutralMinionsKilled
        {
            get;
            set;
        }

        public int NeutralMinionsKilledEnemyJungle
        {
            get;
            set;
        }

        public int NeutralMinionsKilledYourJungle
        {
            get;
            set;
        }

        /// <summary>
        /// True if summoner got the killing blow on the nexus. Otherwise false.
        /// </summary>
        public bool NexusKilled
        {
            get;
            set;
        }

        public int NodeCapture
        {
            get;
            set;
        }

        public int NodeCaptureAssist
        {
            get;
            set;
        }

        public int NodeNeutralize
        {
            get;
            set;
        }

        public int NodeNeutralizeAssist
        {
            get;
            set;
        }

        public int NumDeaths
        {
            get;
            set;
        }

        public int NumItemsBought
        {
            get;
            set;
        }

        public int ObjectivePlayerScore
        {
            get;
            set;
        }

        public int PentaKills
        {
            get;
            set;
        }

        public int PhysicalDamageDealtPlayer
        {
            get;
            set;
        }

        public int PhysicalDamageDealtToChampions
        {
            get;
            set;
        }

        public int PhysicalDamageTaken
        {
            get;
            set;
        }

        public int QuadraKills
        {
            get;
            set;
        }

        public int SightWardsBought
        {
            get;
            set;
        }

        /// <summary>
        /// Number of times first champion spell was cast.
        /// </summary>
        public int Spell1Cast
        {
            get;
            set;
        }

        /// <summary>
        /// Number of times second champion spell was cast.
        /// </summary>
        public int Spell2Cast
        {
            get;
            set;
        }

        /// <summary>
        /// Number of times third champion spell was cast.
        /// </summary>
        public int Spell3Cast
        {
            get;
            set;
        }

        /// <summary>
        /// Number of times fourth champion spell was cast.
        /// </summary>
        public int Spell4Cast
        {
            get;
            set;
        }

        public int SummonSpell1Cast
        {
            get;
            set;
        }

        public int SummonSpell2Cast
        {
            get;
            set;
        }

        public int SuperMonsterKilled
        {
            get;
            set;
        }

        public int Team
        {
            get;
            set;
        }

        public int TeamObjective
        {
            get;
            set;
        }

        public int TimePlayed
        {
            get;
            set;
        }

        public int TotalDamageDealt
        {
            get;
            set;
        }

        public int TotalDamageDealtToChampions
        {
            get;
            set;
        }

        public int TotalDamageTaken
        {
            get;
            set;
        }

        public int TotalHeal
        {
            get;
            set;
        }

        public int TotalPlayerScore
        {
            get;
            set;
        }

        public int TotalScoreRank
        {
            get;
            set;
        }

        public int TotalTimeCrowdControlDealt
        {
            get;
            set;
        }

        public int TotalUnitsHealed
        {
            get;
            set;
        }

        public int TripleKills
        {
            get;
            set;
        }

        public int TrueDamageDealtPlayer
        {
            get;
            set;
        }

        public int TrueDamageDealtToChampions
        {
            get;
            set;
        }

        public int TrueDamageTaken
        {
            get;
            set;
        }

        public int TurretsKilled
        {
            get;
            set;
        }

        public int UnrealKills
        {
            get;
            set;
        }

        public int VictoryPointTotal
        {
            get;
            set;
        }

        public int VisionWardsBought
        {
            get;
            set;
        }

        public int WardKilled
        {
            get;
            set;
        }

        public int WardPlaced
        {
            get;
            set;
        }

        /// <summary>
        /// True if this game was won. Otherwise false.
        /// </summary>
        public bool Win
        {
            get;
            set;
        }
    }
}