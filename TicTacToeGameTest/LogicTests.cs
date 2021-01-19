using NUnit.Framework;
using TicTacToeGame; 

namespace TicTacToeGameTest
{
    public class LogicTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckRow_3x3_OOO_O_wins()
        { 
            Logic logic = new Logic();
            logic.boardSize=3;
            logic.boardArray[1, 0] = "O";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[1, 2] = "O";
            Assert.AreEqual("O wins!", logic.CheckRow());
        }

        [Test]
        public void CheckColumn_3x3_OOO_O_wins()
        {
            Logic logic = new Logic();
            logic.boardSize = 3;
            logic.boardArray[0, 1] = "O";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[2, 1] = "O";
            Assert.AreEqual("O wins!", logic.CheckColumn());
        }

        [Test]
        public void CheckCross1_3x3_OOO_O_wins()
        {
            Logic logic = new Logic();
            logic.boardSize = 3;
            logic.boardArray[0, 0] = "O";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[2, 2] = "O";
            Assert.AreEqual("O wins!", logic.CheckCross1());
        }

        [Test]
        public void CheckCross2_3x3_XXX_X_wins()
        {
            Logic logic = new Logic();
            logic.boardSize = 3;
            logic.boardArray[0, 2] = "X";
            logic.boardArray[1, 1] = "X";
            logic.boardArray[2, 0] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross2());
        }

        [Test]
        public void CheckRow_4x4_OOO_O_wins()
        {
            Logic logic = new Logic();
            logic.boardSize = 4;
            logic.boardArray[1, 0] = "O";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[1, 2] = "O";
            logic.boardArray[1, 3] = "X";
            Assert.AreEqual("O wins!", logic.CheckRow());
        }

        [Test]
        public void CheckColumn_4x4_OOO_O_wins()
        {
            Logic logic = new Logic();
            logic.boardSize = 4;
            logic.boardArray[0, 1] = "X";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[2, 1] = "O";
            logic.boardArray[3, 1] = "O";
            Assert.AreEqual("O wins!", logic.CheckColumn());
        }

        [Test]
        public void CheckCross1_4x4_OOO_O_wins() //--the main cross at 4x4: \
        {
            Logic logic = new Logic();
            logic.boardSize = 4;
            logic.boardArray[0, 0] = "O";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[2, 2] = "O";
            logic.boardArray[3, 3] = "X";
            Assert.AreEqual("O wins!", logic.CheckCross1());
        }

        [Test]
        public void CheckCross2_4x4_XXX_X_wins() //--the main cross at 4x4: /
        {
            Logic logic = new Logic();
            logic.boardSize = 4;
            logic.boardArray[0, 3] = "O";
            logic.boardArray[1, 2] = "X";
            logic.boardArray[2, 1] = "X";
            logic.boardArray[3, 0] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross2());
        }

        [Test]
        public void CheckCross3_4x4_OOO_O_wins() //--on right from the main cross at 4x4: \
        {
            Logic logic = new Logic();
            logic.boardSize = 4;
            logic.boardArray[0, 0] = "X";
            logic.boardArray[0, 1] = "O";
            logic.boardArray[1, 2] = "O";
            logic.boardArray[2, 3] = "O";
            Assert.AreEqual("O wins!", logic.CheckCross3());
        }

        [Test]
        public void CheckCross4_4x4_OOO_O_wins() //--on left from the main cross at 4x4: \
        {
            Logic logic = new Logic();
            logic.boardSize = 4;
            logic.boardArray[0, 0] = "X";
            logic.boardArray[1, 0] = "O";
            logic.boardArray[2, 1] = "O";
            logic.boardArray[3, 2] = "O";
            Assert.AreEqual("O wins!", logic.CheckCross4());
        }

        [Test]
        public void CheckCross5_4x4_XXX_X_wins() //--on right from the main cross at 4x4: /
        {
            Logic logic = new Logic();
            logic.boardSize = 4;
            logic.boardArray[0, 3] = "O";
            logic.boardArray[1, 3] = "X";
            logic.boardArray[2, 2] = "X";
            logic.boardArray[3, 1] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross5());
        }

        [Test]
        public void CheckCross6_4x4_XXX_X_wins() //--on left from the main cross at 4x4: /
        {
            Logic logic = new Logic();
            logic.boardSize = 4;
            logic.boardArray[0, 1] = "O";
            logic.boardArray[0, 2] = "X";
            logic.boardArray[1, 1] = "X";
            logic.boardArray[2, 0] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross6());
        }

   

        [Test]
        public void CheckRow_5x5_OOO_O_wins()
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[1, 0] = "O";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[1, 2] = "O";
            logic.boardArray[1, 3] = "X";
            logic.boardArray[1, 4] = "X";
            Assert.AreEqual("O wins!", logic.CheckRow());
        }

        [Test]
        public void CheckColumn_5x5_OOO_O_wins()
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[0, 1] = "X";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[2, 1] = "O";
            logic.boardArray[3, 1] = "O";
            logic.boardArray[4, 1] = "X";
            Assert.AreEqual("O wins!", logic.CheckColumn());
        }

        [Test]
        public void CheckCross1_5x5_OOO_O_wins() //--the main cross at 5x5: \
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[0, 0] = "X";
            logic.boardArray[1, 1] = "O";
            logic.boardArray[2, 2] = "O";
            logic.boardArray[3, 3] = "O";
            logic.boardArray[4, 4] = "X";
            Assert.AreEqual("O wins!", logic.CheckCross1());
        }

        [Test]
        public void CheckCross2_5x5_XXX_X_wins() //--the main cross at 5x5: /
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[0, 4] = "O";
            logic.boardArray[1, 3] = "O";
            logic.boardArray[2, 2] = "X";
            logic.boardArray[3, 1] = "X";
            logic.boardArray[4, 0] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross2());
        }

        [Test]
        public void CheckCross3_5x5_OOO_O_wins() //--on right from the main cross at 5x5: \
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[0, 0] = "X";
            logic.boardArray[0, 1] = "X";
            logic.boardArray[1, 2] = "O";
            logic.boardArray[2, 3] = "O";
            logic.boardArray[3, 4] = "O";
            Assert.AreEqual("O wins!", logic.CheckCross3());
        }

        [Test]
        public void CheckCross4_5x5_OOO_O_wins() //--on left from the main cross at 5x5: \
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[0, 0] = "X";
            logic.boardArray[1, 0] = "X";
            logic.boardArray[2, 1] = "O";
            logic.boardArray[3, 2] = "O";
            logic.boardArray[4, 3] = "O";
            Assert.AreEqual("O wins!", logic.CheckCross4());
        }
     
        [Test]
        public void CheckCross6_5x5_XXX_X_wins() //--on left from the main cross at 5x5: /
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[0, 0] = "O";
            logic.boardArray[0, 1] = "O";
            logic.boardArray[0, 2] = "X";
            logic.boardArray[1, 1] = "X";
            logic.boardArray[2, 0] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross6());
        }

        [Test]
        public void CheckCross7_5x5_XXX_X_wins()
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[1, 0] = "O";
            logic.boardArray[2, 0] = "X";
            logic.boardArray[3, 1] = "X";
            logic.boardArray[4, 2] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross7());
        }

        [Test]
        public void CheckCross8_5x5_XXX_X_wins() //--on right from the main cross at 5x5: /
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[0, 0] = "O";
            logic.boardArray[0, 1] = "O";
            logic.boardArray[0, 2] = "X";
            logic.boardArray[1, 3] = "X";
            logic.boardArray[2, 4] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross8());
        }

        [Test]
        public void CheckCross9_5x5_XXX_X_wins() //--on right from the main cross at 5x5: /
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[4, 1] = "X";
            logic.boardArray[3, 2] = "X";
            logic.boardArray[2, 3] = "X";
            logic.boardArray[1, 4] = "O";
            logic.boardArray[0, 4] = "O";
            Assert.AreEqual("X wins!", logic.CheckCross9());
        }

        [Test]
        public void CheckCross10_5x5_XXX_X_wins() //--on right from the main cross at 5x5: /
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[4, 1] = "O";
            logic.boardArray[4, 2] = "X";
            logic.boardArray[3, 3] = "X";
            logic.boardArray[2, 4] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross10());
        }

        [Test]
        public void CheckCross11_5x5_XXX_X_wins() //--on left from the main cross at 5x5: /
        {
            Logic logic = new Logic();
            logic.boardSize = 5;
            logic.boardArray[3, 0] = "O";
            logic.boardArray[2, 1] = "X";
            logic.boardArray[1, 2] = "X";
            logic.boardArray[0, 3] = "X";
            Assert.AreEqual("X wins!", logic.CheckCross11());
        }

    }
}