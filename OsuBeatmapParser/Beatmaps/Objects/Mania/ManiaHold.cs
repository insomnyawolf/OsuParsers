using OsuBeatmapParser.Enums;
using System.Drawing;

namespace OsuBeatmapParser.Beatmaps.Objects.Mania
{
    public class ManiaHold : ManiaHitObject
    {
        public ManiaHold(Point position, int startTime, int endTime, HitSoundType hitSound, int collumn, HitObjectExtras extras)
            : base(position, startTime, endTime, hitSound, collumn, extras)
        {

        }
    }
}