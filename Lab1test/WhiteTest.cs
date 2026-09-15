namespace Lab1_test
{
    [TestClass]
    public sealed class WhiteTest
    {
        Lab1.White main = new Lab1.White();
        const double E = 0.0001;

        [TestMethod]
        public void Test1()
        {
            //  Arrange
            var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3};
            var answer = new bool[] { false, true, true, true, false, false, true, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task1(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test2()
        {
            // Arrange
            var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            var answer = new bool[] { true, false, true, false, true, false, true, false, true };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task2(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test3()
        {
            // Arrange
            var input = new int[] { 0, 1, 5, -2, 2, -1, 13, -13, 30 };
            var answer = new int[] { 1, 5, 5, 2, 2, 13, 13, 30, 30 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task3(input[i], input[(i+1)%input.Length]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test4()
        {
            // Arrange
            var input = new int[] { 0, 1, 5, -2, 2, -1, 13, -13, 30 };
            var answer = new double[] { 0, 1, -2, -2, -1, -1, 13, -13, 0};
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task4(input[i], input[(i + 1) % input.Length]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3 };
            var answer = new double[] { 0, 1, 1, 1, -1, 1, 0.78, -0.3 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task5(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test6()
        {
            // Arrange
            var input = new double[,] {
                { 0, 1.5, 1, 1, -1, 3, -1, -2.3, 2, 1 },
                { 0, 2.3, -1, -1, 1, 0.01, 1.23, -3.2, 1, 0 },
                { 0, 1, 1, 0.5, 1.5, 3, 2, 2.5, 1, 1 }
            };
            var answer = new bool[] { true, false, false, false, false, true, false, false, false, true };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task6(input[0, i], input[1, i], input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test7()
        {
            // Arrange
            var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            var answer = new bool[] { false, false, false, false, true, false, true, false, true };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task7(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test8()
        {
            // Arrange
            var input = new double[,] {
                { 0, 1.5, 10, 10, 10, 30, 30, 30.1, 78, 29.9 },
                { 0, 6, 1, 5, 5, 3, 3, 5, 4, 4 },
                { 0, 1, 1, 1, 2, 3, 4, 4, 4, 4 }
            };
            var answer = new bool[] { false, false, false, false, true, false, true, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task8(input[0, i], (int)input[1, i], (int)input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
    }
}
