using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CMART5.BUS;
using CMART5;
namespace CMART5.Tests
{
    [TestClass]
    public class BUS_Login_Test
    {
        #region Test scripts để test hàm lấy quyền tài khoản
        /// <summary>
        /// TC#6: Lấy quyền tài khoản thành công
        /// </summary>
        [TestMethod]
        public void Authorize_WithValidInput_ShouldReturnSuccessful()
        {
            BUS_Login bus = new BUS_Login();
            string name = "admin";
            string pass = "12345";
            int expectResult = 1;
            int actualResult = bus.Authorize(name, pass);
            Assert.AreEqual(expectResult, actualResult);
        }
        /// <summary>
        /// TC#7: Lấy quyền tài khoản thành công
        /// </summary>
        [TestMethod]
        public void Authorize_WithInValidInput_ShouldReturnFail()
        {
            BUS_Login bus = new BUS_Login();
            string name = "admin1234";
            string pass = "12345";
            int expectResult = 1;
            int actualResult = bus.Authorize(name, pass);
            Assert.AreEqual(expectResult, actualResult);
        }
        #endregion
        #region Test scripts để test hàm lấy ID tài khoản
        /// <summary>
        /// TC#8: Lấy ID tài khoản thành công
        /// </summary>
        [TestMethod]
        public void getID_WithValidInput_ShouldReturnSuccessful()
        {
            BUS_Login bus = new BUS_Login();
            string name = "admin";
            string pass = "12345";
            string expectResult = "TK160001";
            string actualResult = bus.getID(name, pass);
            Assert.AreEqual(expectResult, actualResult);
        }
        #endregion

        #region Test scripts để test hàm lấy ID tài khoản
        /// <summary>
        /// TC#9: Lấy ID tài khoản rỗng
        /// </summary>
        [TestMethod]
        public void getID_WithUnValidInput_ShouldReturnEmpty()
        {
            BUS_Login bus = new BUS_Login();
            string name = "admin";
            string pass = "";
            string expectResult = "";
            string actualResult = bus.getID(name, pass);
            Assert.AreEqual(expectResult, actualResult);
        }
        #endregion

        #region Test scripts để test hàm kiểm tra trường
        /// <summary>
        /// TC#10: kiểm tra true thành công
        /// </summary>
        [TestMethod]
        public void validate_WithValidInput_ShouldReturnSuccessful()
        {
            BUS_Login bus = new BUS_Login();
            string name = "admin";
            string pass = "12345";
            bool expectResult = true;
            bool actualResult = bus.validate(name, pass);
            Assert.AreEqual(expectResult, actualResult);
        }
        /// <summary>
        /// TC#11: kiểm tra thất bại
        /// </summary>
        [TestMethod]
        public void validate_WithValidInput_ShouldReturnFail()
        {
            BUS_Login bus = new BUS_Login();
            string name = "admin";
            string pass= "";
            bool expectResult = true ;
            bool actualResult = bus.validate(name, pass);
            Assert.AreEqual(expectResult, actualResult);
        }
        #endregion


    }
}
