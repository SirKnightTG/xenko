// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Xunit;
using Stride.Graphics;

namespace Stride.Particles.Tests
{
    public class VisualTestSoftEdge : GameTest
    {
        public VisualTestSoftEdge() : base("VisualTestSoftEdge") { }

        [Fact]
        public void RunVisualTests10()
        {
            RunGameTest(new GameTest("VisualTestSoftEdge", GraphicsProfile.Level_10_0));
        }

        [Fact]
        public void RunVisualTests11()
        {
            RunGameTest(new GameTest("VisualTestSoftEdge", GraphicsProfile.Level_11_0));
        }

    }
}
