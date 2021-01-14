using Xunit;

namespace BowlingGameTests
{
    public class BowlingGameTest
    {

        private BowlingGame.BowlingGame theGame;

        public BowlingGameTest() => theGame = new BowlingGame.BowlingGame();

        [Fact]
        public void ShouldScoreZeroWhenNoRolls()
        {
            Assert.Equal(0, theGame.getScore());
        }

        [Fact]
        public void ShouldScore0WhenNoPinsDown20Times()
        {
            roll(20, 0);
            Assert.Equal(0, theGame.getScore());
        }

        [Fact]
        public void ShouldScore20WhenOnePinsDown20Times()
        {
            roll(20, 1);
            Assert.Equal(20, theGame.getScore());
        }


        private void roll(int throws, int pins)
        {
            for (int i = 0; i < throws; i++)
            {
                theGame.roll(pins);
            }
        }
    }
}
