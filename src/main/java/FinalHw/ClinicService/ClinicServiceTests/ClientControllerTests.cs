using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    public class ClientControllerTests
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _mocClientRepositoty;

        public ClientControllerTests()
        {
            _mocClientRepositoty = new Mock<IClientRepository>();
            _clientController = new ClientController(_mocClientRepositoty.Object);
        }
        [Fact]
        public void GetAllClientsTest()
        {
            // [1.1] Подготовка данных для тестироывания
            // [1.2] 

            List<Client> list = new List<Client>();
            list.Add(new Client());
            list.Add(new Client());
            list.Add(new Client());

            _mocClientRepositoty.Setup(repository =>
            repository.GetAll()).Returns(list);

            // [2] исполнение тестируемого метода
            var operationResult = _clientController.GetAll();

            // [3] Подготовка эталонного результата, проверка результата
            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Client>>(((OkObjectResult)operationResult.Result).Value);

            _mocClientRepositoty.Verify(repository =>
            repository.GetAll(), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectCreateClientData =
        {
            new object[] { new DateTime(1985, 5, 20), "789 123", "Иванов", "Андрей", "Сергеевич" },
            new object[] { new DateTime(1985, 5, 20), "123 456", "Иванов", "Андрей", "Сергеевич" },
            new object[] { new DateTime(1985, 5, 20), "456 789", "Иванов", "Андрей", "Сергеевич" }
        };

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void CreateClientTest(DateTime birthday, string document, string surName, string firstName, string patronymic)
        {
            _mocClientRepositoty.Setup(repository =>
            repository
            .Create(It.IsNotNull<Client>()))
                .Returns(1)
                .Verifiable();

            var operationResult = _clientController.Create(new CreateClientRequest
            {
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocClientRepositoty.Verify(repository =>
            repository.Create(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }
    }
}
