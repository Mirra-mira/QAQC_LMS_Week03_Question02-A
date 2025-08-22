using Microsoft.VisualStudio.TestTools.UnitTesting;
using static QuadraticEquationSolver; 

namespace Unittest
{
    [TestClass]
    public sealed class QuadraticEquationSolverTest
    {
        public void Test_VoNghiem()
        {
            string result = QuadraticEquationSolver.SolveQuadratic(1, 0, 1);
            Assert.AreEqual("Vô nghiệm", result);
        }

        [TestMethod]
        public void Test_NghiemKep()
        {
            string result = QuadraticEquationSolver.SolveQuadratic(1, 2, 1);
            Assert.AreEqual("Nghiệm kép: x1 = x2 = -1", result);
        }

        [TestMethod]
        public void Test_HaiNghiem()
        {
            string result = QuadraticEquationSolver.SolveQuadratic(1, -3, 2);
            Assert.AreEqual("2 nghiệm: x1 = 2, x2 = 1", result);
        }
    }
}
