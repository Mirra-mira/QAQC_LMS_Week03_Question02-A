using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class QuadraticEquationSolverTests
{
    [TestMethod]
    public void Test_VoSoNghiem()
    {
        string result = QuadraticEquationSolver.Solve(0, 0, 0);
        Assert.AreEqual("Vô số nghiệm", result);
    }

    [TestMethod]
    public void Test_VoNghiem()
    {
        string result = QuadraticEquationSolver.Solve(0, 0, 5);
        Assert.AreEqual("Vô nghiệm", result);
    }

    [TestMethod]
    public void Test_PhuongTrinhBacNhat()
    {
        string result = QuadraticEquationSolver.Solve(0, 2, -4);
        Assert.AreEqual("1 nghiệm: x = 2", result);
    }

    [TestMethod]
    public void Test_NghiemKep()
    {
        string result = QuadraticEquationSolver.Solve(1, 2, 1);
        Assert.AreEqual("Nghiệm kép: x1 = x2 = -1", result);
    }

    [TestMethod]
    public void Test_HaiNghiemPhanBiet()
    {
        string result = QuadraticEquationSolver.Solve(1, -3, 2);
        Assert.AreEqual("2 nghiệm: x1 = 2, x2 = 1", result);
    }
}
