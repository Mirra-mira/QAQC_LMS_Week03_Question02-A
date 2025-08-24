using Microsoft.VisualStudio.TestTools.UnitTesting;
using static QuadraticEquationSolver;

namespace Unittest
{
    [TestClass]
    public sealed class QuadraticEquationSolverTest
    {
        [TestMethod]
        public void Test_VoNghiem()
        {
            string result = QuadraticEquationSolver.SolveQuadratic(1, 0, 1);
            Assert.AreEqual("Phương trình vô nghiệm", result);
        }

        [TestMethod]
        public void Test_NghiemKep()
        {
            string result = QuadraticEquationSolver.SolveQuadratic(1, 2, 1);
            Assert.AreEqual("Phương trình có nghiệm kép: x1 = x2 = -1", result);
        }

        [TestMethod]
        public void Test_HaiNghiem()
        {
            string result = QuadraticEquationSolver.SolveQuadratic(1, -3, 2);
            Assert.AreEqual("Phương trình có 2 nghiệm:\nx1 = 2\nx2 = 1", result);
        }
    }
}
