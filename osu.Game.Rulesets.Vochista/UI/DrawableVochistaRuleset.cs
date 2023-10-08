// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Vochista.Objects;
using osu.Game.Rulesets.Vochista.Objects.Drawables;
using osu.Game.Rulesets.Vochista.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Vochista.UI
{
    [Cached]
    public partial class DrawableVochistaRuleset : DrawableRuleset<VochistaHitObject>
    {
        public DrawableVochistaRuleset(VochistaRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
        }

        protected override Playfield CreatePlayfield() => new VochistaPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new VochistaFramedReplayInputHandler(replay);

        public override DrawableHitObject<VochistaHitObject> CreateDrawableRepresentation(VochistaHitObject h) => new DrawableVochistaHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new VochistaInputManager(Ruleset?.RulesetInfo);
    }
}
