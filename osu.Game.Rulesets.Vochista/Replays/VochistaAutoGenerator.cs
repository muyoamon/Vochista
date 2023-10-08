// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.Vochista.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Vochista.Replays
{
    public class VochistaAutoGenerator : AutoGenerator<VochistaReplayFrame>
    {
        public new Beatmap<VochistaHitObject> Beatmap => (Beatmap<VochistaHitObject>)base.Beatmap;

        public VochistaAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            Frames.Add(new VochistaReplayFrame());

            foreach (VochistaHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new VochistaReplayFrame
                {
                    Time = hitObject.StartTime,
                    Position = hitObject.Position,
                    // todo: add required inputs and extra frames.
                });
            }
        }
    }
}
