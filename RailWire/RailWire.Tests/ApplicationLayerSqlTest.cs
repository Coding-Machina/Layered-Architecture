using Application.SqlOperations;
using Domain.Abstracts;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWire.Tests
{
    [TestClass]
    public class ApplicationLayerSqlTest
    {
        private Mock<IDomainSqlMethods> mockDomainSqlMethods;
        private ApplicationSqlMethods applicationSqlMethodsUnderTest;

        [TestMethod]
        public void GetSqlTrainDataTest()
        {
            List<TrainHelperModel> returnedTrainDatas = new List<TrainHelperModel>();
            
            //Arrange
            mockDomainSqlMethods = new Mock<IDomainSqlMethods>(MockBehavior.Strict);
            mockDomainSqlMethods.Setup(p => p.GetDataFromSql()).Returns(returnedTrainDatas);  
            applicationSqlMethodsUnderTest = new ApplicationSqlMethods(mockDomainSqlMethods.Object);

            //Act

            var result = applicationSqlMethodsUnderTest.GetDataFromSql();

            //Assert
            Assert.AreEqual(result, returnedTrainDatas );


        }

    }
}
