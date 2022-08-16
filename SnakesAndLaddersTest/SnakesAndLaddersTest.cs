using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders;

namespace SnakesAndLaddersTest
{
    [TestClass]
    public class SnakesAndLaddersTest
    {
        [TestMethod]
        public void PlayerStartOnInitialPosition()
        {
            Game game = new();
            var numberOfPlayers = 2;
            var position = game.AssignStartPosition(numberOfPlayers);

            Assert.AreEqual(1, position);
        }

        [TestMethod]
        public void PlayerMoveToNewPositionAccordingToRolledDice()
        {
            Game game = new();
            Player currentPlayer = new()
            {
                Id = 1,
                Color = "Rojo",
                Name = "Jugador1",
                CurrentPosition = 1
            };

            Dice die = new();
            var diceValue = 3;
            var player = game.AssignDicePosition(currentPlayer, diceValue);

            Assert.AreEqual(4, player.CurrentPosition);
        }

        [TestMethod]
        public void PlayerMoveSeveralPositionAccordingToRolledDice()
        {
            Game game = new();
            Player currentPlayer = new()
            {
                Id = 1,
                Color = "Rojo",
                Name = "Jugador1",
                CurrentPosition = 1
            };

            Dice die = new();
            var diceValue = 3;
            var player = game.AssignDicePosition(currentPlayer, diceValue);

            diceValue = 4;
            player = game.AssignDicePosition(currentPlayer, diceValue);

            Assert.AreEqual(8, player.CurrentPosition);

        }

        [TestMethod]
        public void AnyPlayerWinsWhenGoesToFinalPosition()
        {
            Game game = new();
            Player currentPlayer = new()
            {
                Id = 1,
                Color = "Rojo",
                Name = "Jugador1",
                CurrentPosition = 97
            };

            Dice die = new();
            var diceValue = 3;
            var player = game.AssignDicePosition(currentPlayer, diceValue);

            Assert.IsTrue(player.IsWinner);
        }


        [TestMethod]
        public void GameIsNotOverWhenThereIsNoWinner()
        {
            Game game = new();
            Player currentPlayer = new()
            {
                Id = 1,
                Color = "Rojo",
                Name = "Jugador1",
                CurrentPosition = 97
            };

            Dice die = new();
            var diceValue = 4;
            var player = game.AssignDicePosition(currentPlayer, diceValue);

            Assert.IsTrue(!player.IsWinner);
        }

        [TestMethod]
        public void PlayerCanNotMoveOutsideBoard()
        {
            Game game = new();
            Player currentPlayer = new()
            {
                Id = 1,
                Color = "Rojo",
                Name = "Jugador1",
                CurrentPosition = 97
            };

            Dice die = new();
            var diceValue = 4;
            var player = game.AssignDicePosition(currentPlayer, diceValue);

            Assert.IsTrue(player.CurrentPosition == 97);
        }
        [TestMethod]
        public void PlayerMoveThroughBoardSnake()
        {
            Game game = new();
            Player currentPlayer = new()
            {
                Id = 1,
                Color = "Rojo",
                Name = "Jugador1",
                CurrentPosition = 16
            };

            var position = game.GetElementPosition(currentPlayer.CurrentPosition);

            Assert.AreEqual(6, position);

        }

        [TestMethod]
        public void PlayerMoveThroughBoardLadder()
        {
            Game game = new();
            Player currentPlayer = new()
            {
                Id = 1,
                Color = "Rojo",
                Name = "Jugador1",
                CurrentPosition = 2
            };

            var position = game.GetElementPosition(currentPlayer.CurrentPosition);

            Assert.AreEqual(38, position);

        }
    }
}
