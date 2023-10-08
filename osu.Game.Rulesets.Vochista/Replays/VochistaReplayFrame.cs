// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;
using osuTK;

namespace osu.Game.Rulesets.Vochista.Replays
{
    public class VochistaReplayFrame : ReplayFrame
    {
        public List<VochistaAction> Actions = new List<VochistaAction>();
        public Vector2 Position;

        public VochistaReplayFrame(VochistaAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
