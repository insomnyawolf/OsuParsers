using OsuBeatmapParser.Enums;
using System.Drawing;

namespace OsuBeatmapParser.Objects.Standard
{
    public abstract class StandardHitObject : HitObject
    {
        public bool IsNewCombo { get; }

        public StandardHitObject(Point position, int startTime, int endTime, HitSoundType hitSound, bool isNewCombo, HitObjectExtras extras)
            : base(position, startTime, endTime, hitSound, extras)
        {
            IsNewCombo = isNewCombo;
        }
    }
}