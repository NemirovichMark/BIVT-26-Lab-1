namespace Lab1_test
{
    [TestClass]
    public sealed class PurpleTest
    {
        Lab1.Purple main = new Lab1.Purple();

        [TestMethod]
        public void Test1()
        {
            // Arrange
            var input = new int[] { 0, 5, 2, 3, -2, 11, 22, -31, -418, -1 };
            var answer = new bool[] { false, true, false, false, false, false, false, true, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task1(input[i], input[(i + 1) % input.Length], input[(i + 2) % input.Length]);
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
            var input = new int[] { 0, 5, 2, 4, -4, -2, 11, 121, 11, -418 };
            var answer = new bool[] { true, false, true, true, true, false, true, true, true, true };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task2(input[i], input[(i + 1) % input.Length]);
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
            var input = new int[] { 0, 2, 4, 8, 9, -3, 9, -27, 3, 27 };
            var answer = new bool[] { false, true, false, false, true, true, false, false, true, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task3(input[i], input[(i + 1) % input.Length]);
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
            var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3 };
            var answer = new double[] { 2.25, -17, 13, 28.6, 8.41, -2.1516, 0.09 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task4(input[i], input[(i + 1) % input.Length], input[(i + 2) % input.Length]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], 0.0001);
            }
        }
        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new double[] { 0, -0.55, 1, 3, -1, -2.3, 0.78, -0.3 };
            var answer = new double[] { 0, 0.55,-1, -1, 1, 1, -0.78, 0.3 };
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
                { 0.1, 1.5,   1, 3.9, 5, 1.3, 0.1, 12, 12, 12.34 },
                { 0.1, 2.3, 3.9,   1, 5, 0.1, 1.3, 14, 18, 34.12 }
            };
            var answer = new bool[] { false, false, true, false, false, false, true, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task6(input[0, i], input[1, i]);
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
            var input = new bool[] { true, true, true,false, false, false, true, false, false };
            var answer = new double[] { 6, 6, 2, 1, 5, 3, 2, 5, 3 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task7(input[i], input[(i + 1) % input.Length], input[(i + 2) % input.Length]);
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
            var input = new int[,] {
            { 2000, 2001, 2025, 2025, 2020, 2100, 2200, 2401, 2104, 2400 },
            { 1000, 1000,   80,   80,  140,  140,  150,  150,   25,  123 },
            { 1000,   50,   50,   10,   10,   10,  421,  420,   10,  100 },
        };
            var answer = new bool[] { false, false, true, true, false, true, false, true, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task8(input[0, i], input[1, i], input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
    }
}
