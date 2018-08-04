using System.Drawing;

namespace OsuBeatmapParser.Objects.Catch
{
    public abstract class CatchHitObject : HitObject
    {
        public bool IsNewCombo { get; }

        public CatchHitObject(Point position, int startTime, int endTime, int hitSound, bool isNewCombo)
            : base(position, startTime, endTime, hitSound)
        {
            IsNewCombo = isNewCombo;
        }
    }
}