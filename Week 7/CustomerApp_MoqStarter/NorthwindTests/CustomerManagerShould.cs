using NUnit.Framework;
using Moq;
using NorthwindBusiness;
using NorthwindData;
using NorthwindData.Services;
using System.Data;
using System.Collections.Generic;
using System;

namespace NorthwindTests
{
    public class CustomerManagerShould
    {
        private CustomerManager _sut;
        // Fakes - In Memory database (not covered this lesson)

        #region Moq as Dummy
        [Ignore("Meant to Fail")]
        [Test]
        public void BeAbleToBeConstructed()
        {
            // Act
            _sut = new CustomerManager(null);
            // Assert
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }

        [Test]
        public void BeAbleToBeConstructed_WithMoq()
        {
            // Use Moq to create a dummy object that implements ICustomerService
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            // Act - Retrieve the ICustomerService object associated with that Mock
            // Mock.Object - doesn't do anything - has no functionality
            _sut = new CustomerManager(mockCustomerService.Object);
        }
        #endregion

        #region Stubs
        // We need to create a test double for implementing the ICustomerService interface
        // AND THEN configure it to return our desired values
        public void ReturnTrue_WhenUpdateIsCalled_WithValidId()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA"
            };
            
            // Set up the service so that it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(customer);

            // Act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("MANDA", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            // Assert
            Assert.That(result);
        }

        public void NotChangeTheSelectedCustomer_WhenUpdateIsCalled_WithInvalidId()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };  

            // Set up the service so that it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns((Customer)null);

            // Act
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = customer;
            var result = _sut.Update("MANDA", "Nishant Mandal", "UK", "London", null);

            // Assert
            Assert.That(!result);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(_sut.SelectedCustomer.Country, Is.Null);
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Birmingham"));
        }
        #endregion

        [Test]
        public void ReturnTrue_WhenDeleteIsCalledWithValidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA"
            };
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(customer);
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Delete("MANDA");
            Assert.That(result);
        }

        [Test]
        public void SetSelectedCustomerToNull_WhenDeleteIsCalledWithValidId()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns((Customer)null);
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Delete("MANDA");

            // Assert
            Assert.That(_sut.SelectedCustomer, Is.Null);
        }

        [Test]
        public void ReturnFalse_WhenDeleteIsCalled_WithInvalidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA"
            };
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(customer);
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Delete("MANDAL");
            Assert.That(!result);
        }

        [Test]
        public void NotChangeTheSelectedCustomer_WhenDeleteIsCalled_WithInvalidId()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            // Create a customer to be the comparator before and after the Delete call
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            // Configure the service to NOT recognise the Id "MANDA.
            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns((Customer)null);

            // Create the customer manager with the mock servive object
            _sut = new CustomerManager(mockCustomerService.Object);
            // Set the SelectedCustomer BEFORE Delete to be the "customer" object
            _sut.SelectedCustomer = customer;
            // Attempt to Delete the customer Id that will not be recognised (i.e. Invalid Id)
            var result = _sut.Delete("MANDA");

            // Assert that the Selected Customer has not changed after the Delete call
            Assert.That(!result);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(_sut.SelectedCustomer.Country, Is.Null);
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Birmingham"));
        }

        #region Testing Expcetions
        [Test]
        public void ReturnsFalse_WhenUpdateIsCalled_AndADatabaseExceptionIsThrown()
        {
            //arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DataException>();
            _sut = new CustomerManager(mockCustomerService.Object);
            //act
            var result = _sut.Update("WOLST", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            Assert.That(!result);
        }

        [Test]
        public void NotChangeTheSelectedCustomer_WhenUpdateIsCalled_AndADatabaseExceptionIsThrown()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DataException>();
            var originalCustomer = new Customer()
            {
                CustomerId = "ROCK",
                ContactName = "Rocky Raccoon",
                CompanyName = "Zoo UK",
                City = "Telford"

            };
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = originalCustomer;
            _sut.Update("ROCK", "Rocky Racoon", "UK", "Chester", null);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Rocky Raccoon"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Zoo UK"));
            Assert.That(_sut.SelectedCustomer.Country, Is.EqualTo(null));
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Telford"));

        }
        #endregion

        #region Behaviour-based testing
        [Test]
        public void CallSaveCustomerChanges_WhenUpdateIsCalled_WithValidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Loose);
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            _sut = new CustomerManager(mockCustomerService.Object);
            //Act
            var result = _sut.Update("WOLST", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            //Assert
            //Calling the udpate method in the CustomerManager class, called the SavesCustomer method once
            mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.Once);
            //mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.Exactly(1));
            //mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.AtMostOnce);
            //mockCustomerService.Verify(cs => cs.RemoveCustomer(new Customer() { CustomerId = "MANDA" }), Times.Never);
        }
        //Strict - all methods withing the Mehtod Under Test must have behaviour set up
        [Test]
        public void Behaviours_LooseVsStrict()
        {
            var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Strict);
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges());
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("WOLST", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            Assert.That(result);
        }
        #endregion

        [Test]
        public void RetrieveAll_OnEmptyDB_WillReturnAnEmptyList()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerList()).Returns(new List<Customer>());
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.RetrieveAll();
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void RetrieveAll_DBWithCustomer_WillReturnListOfCustomer()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };
            var customerList = new List<Customer>() { customer };
            mockCustomerService.Setup(cs => cs.GetCustomerList()).Returns(new List<Customer>() { customer });
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.RetrieveAll();
            Assert.That(result, Is.EqualTo(customerList));
        }

        [Test]
        public void SetSelectedCustomer_ToInvalidCustomer_WillThrowAnInvalidCastException()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            _sut = new CustomerManager(mockCustomerService.Object);
            Assert.That(() => _sut.SetSelectedCustomer("Invalid"), Throws.InstanceOf<InvalidCastException>());
        }

        [Test]
        public void SetSelectedCustomer_ToValidCustomer_WillChangeSelectedCustomer()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SetSelectedCustomer(customer);
            Assert.That(_sut.SelectedCustomer.CustomerId, Is.EqualTo("MANDA"));
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Birmingham"));
        }

        [Test]
        public void CallManagerCreate_CallsCreateCustomerOnTheService()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.Create("CROFT", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            mockCustomerService.Verify(cs => cs.CreateCustomer(It.IsAny<Customer>()), Times.Once);
        }

        [Test]
        public void CallManagerDelete_CallsExpectedServiceMethods()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var customer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(customer);
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Delete(customer.CustomerId);
            mockCustomerService.Verify(cs => cs.GetCustomerById(It.IsAny<string>()), Times.Once);
            mockCustomerService.Verify(cs => cs.RemoveCustomer(customer), Times.Once);
        }
    }
}

