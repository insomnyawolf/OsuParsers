﻿using OsuParsers.Enums;
using OsuParsers.Replays.Objects;
using System;
using System.Collections.Generic;
using OsuParsers.Encoders;

namespace OsuParsers.Replays
{
    public class Replay
    {
        public Ruleset Ruleset { get; set; }
        public int OsuVersion { get; set; }
        public string BeatmapMD5Hash { get; set; }
        public string PlayerName { get; set; }
        public string ReplayMD5Hash { get; set; }
        public ushort Count300 { get; set; }
        public ushort Count100 { get; set; }
        public ushort Count50 { get; set; }
        public ushort CountGeki { get; set; }
        public ushort CountKatu { get; set; }
        public ushort CountMiss { get; set; }
        public int ReplayScore { get; set; }
        public ushort Combo { get; set; }
        public bool PerfectCombo { get; set; }
        public Mods Mods { get; set; }
        public DateTime ReplayTimestamp { get; set; }
        public int ReplayLength { get; set; }
        public List<ReplayFrame> ReplayFrames { get; set; } = new List<ReplayFrame>();
        public List<LifeFrame> LifeFrames { get; set; } = new List<LifeFrame>();
        public int Seed { get; set; }
        public long OnlineId { get; set; }

        // https://osu.ppy.sh/wiki/en/Gameplay/Accuracy
        public float Accuracy
        {
            get
            {
                switch (Ruleset)
                {
                    case Ruleset.Standard:
                        var totalObjects = Count300 + Count100 + Count50 + CountMiss;
                        var maxValue = totalObjects * 300;

                        var valueUnweighted = (Count300 * 300) + (Count100 * 100) + (Count50 * 50);

                        return 100f * valueUnweighted / maxValue;
                    default:
                        throw new NotImplementedException($"Accuracy for => {Ruleset}");
                }
            }
        }

        /// <summary>
        /// Saves this <see cref="Replay"/> to the specified path.
        /// </summary>
        public void Save(string path)
        {
            ReplayEncoder.Encode(this, path);
        }
    }
}
