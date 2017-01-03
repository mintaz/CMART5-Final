using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMART5;
using CMART5.BUS;

namespace CMART5.Tests
{
    [TestClass]
    public class BUS_ChangePass_Test
    {
        #region Test scripts để test hàm lấy quyền tài khoản
        /// <summary>
        /// TC#1: Lấy quyền tài khoản thành công
        /// </summary>
        [TestMethod]
        public void getAu_WithValidInput_ShouldReturnSuccessful()
        {
            BUS_ChangePass bus = new BUS_ChangePass();
            string id = "TK160001";
            string expectResult = "Giám Đốc";
            string actualResult = bus.getAuth(id);
            Assert.AreEqual(expectResult, actualResult);
        }
        /// <summary>
        /// TC#2: Lấy quyền tài khoản thất bại do sai id
        /// </summary>
        [TestMethod]
        public void getAu_WithValidInput_ShouldReturnFail()
        {
            BUS_ChangePass bus = new BUS_ChangePass();
            string id = "TK160002";
            string expectResult = "Giám Đốc";
            string actualResult = bus.getAuth(id);
            Assert.AreEqual(expectResult, actualResult);
        }
        /// <summary>
        /// TC#3: Lấy quyền tài khoản thất bại do sai id
        /// </summary>
        [TestMethod]
        public void getAu_WithInValidInput_ShouldReturnErrorMessage()
        {
            BUS_ChangePass bus = new BUS_ChangePass();
            string id = "TK160002001";
            string expectResult = "";
            string actualResult = bus.getAuth(id);
            Assert.AreEqual(expectResult, actualResult);
        }
        #endregion
        #region Test scripts để test hàm đổi mật khẩu
        /// <summary>
        /// TC#4: Đổi mật khẩu thành công
        /// </summary>
        [TestMethod]
        public void UpdatePass_WithValidInput_ShouldReturnSuccessful()
        {
            BUS_ChangePass bus = new BUS_ChangePass();
            string id = "TK160001";
            string pass ="12345";
            bus.UpdatePass(id, pass);
        }
        /// <summary>
        /// TC#5: Đổi mật khẩu thất bại do nhập sai id
        /// </summary>
        [TestMethod]
        public void UpdatePass_WithInValidInput_ShouldReturnMessageError()
        {
            BUS_ChangePass bus = new BUS_ChangePass();
            string id = "TK1600010123";
            string pass ="12345";
            bus.UpdatePass(id, pass);
        }
        #endregion

    }
}
