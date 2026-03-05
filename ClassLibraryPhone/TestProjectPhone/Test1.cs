using BibliotekaPhone;

namespace TestProjectPhone
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Konstruktor_DanePoprawne()
        {
            // Arrange
            string owner = "John Doe";
            string phoneNumber = "123456789";
            
            // Act
            Phone phone = new(owner, phoneNumber);
            
            // Assert
            Assert.AreEqual(owner, phone.Owner);
            Assert.AreEqual(phoneNumber, phone.PhoneNumber);
        }

        [TestMethod]
        public void Konstruktor_DaneNiepoprawne_OwnerPusty()
        {
            // Arrange
            string owner = "";
            string phoneNumber = "123456789";
            
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Phone(owner, phoneNumber));
        }

        [TestMethod]
        public void Konstruktor_DaneNiepoprawne_OwnerNull()
        {
            // Arrange
            string owner = null;
            string phoneNumber = "123456789";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Phone(owner, phoneNumber));
        }

        [TestMethod]
        public void Konstruktor_DaneNiepoprawne_NumerTelefonuNull()
        {
            // Arrange
            string owner = "Molenda";
            string phoneNumber = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Phone(owner, phoneNumber));
        }

        [DataTestMethod]
        [DataRow("123")]
        [DataRow("12345678901234567890")]
        public void Konstruktor_DaneNiepoprawne_NumerTelefonuZlejDlugosci(string nrTel)
        {
            // Arrange
            string owner = "Molenda";
            string phoneNumber = nrTel;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Phone(owner, phoneNumber));
        }

        [DataTestMethod]
        [DataRow("1a3456789")]
        [DataRow("12345678.")]
        public void Konstruktor_DaneNiepoprawne_NumerTelefonuNieTylkoCyfry(string nrTel)
        {
            // Arrange
            string owner = "Molenda";
            string phoneNumber = nrTel;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Phone(owner, phoneNumber));
        }
    }
}
