using System;
using BowlingGame;
using Xunit;


namespace BowlingGameTests
{
    public class BowlingGameTest
    {
        [Fact]
        public void MyFirstTest()
        {
            //Arrange
            var myGame = new Game();
            
            //Act
            myGame.Roll(1);
            
            //Assert
            var expected = 1;
            var actual = myGame.Score();

            Assert.Equal(expected, actual);
        }
    }
}
