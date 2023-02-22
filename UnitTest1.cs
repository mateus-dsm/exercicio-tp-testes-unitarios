using Exercicio35;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Exercicio35.Test
{
    public class ProgramTest
    {
        [Fact]
        public void TestAddValidContact()
        {
            //Arrange:

            var expected = true;
            var contactService = new ContactService();

            //Act:

            var result = contactService.AddContact("Contato 1", "9999-9990", "contato1@email.com");

            //Assert:

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAddInvalidContact()
        {
            //Arrange:

            var expected = false;
            var contactService = new ContactService();

            //Act:

            var result = contactService.AddContact("Contato 1", "0000-0000", "contatoinvalido1@email.xyauchax");

            //Assert:

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAddDuplicateContact() 
        {
            var expected = false;
            var contactService = new ContactService();
            contactService.AddContact("Contato 1", "9999-9990", "contato1@email.com");

            //Act:

            var result = contactService.AddContact("Contato 1", "9999-9990", "contato1@email.com");

            //Assert:

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestListContacts()
        {
            //Arrange:

            var expected = "Lista de contatos:\n1. Contato 1 - 9999-9990 - contato1@email.com\n2. Contato 2 - 9999-9991 - contato2@email.com\n";
            var contactService = new ContactService();
            contactService.AddContact("Contato 1", "9999-9990", "contato1@email.com");
            contactService.AddContact("Contato 2", "9999-9991", "contato2@email.com");

            //Act:

            var result = contactService.ListContacts();

            //Assert:

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestEmptyListContacts()
        {
            //Arrange:

            var expected = "Não há contatos cadastrados.";
            var contactService = new ContactService();

            //Act:

            var result = contactService.ListContacts();

            //Assert:

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestUpdateContact()
        {
            //Arrange:

            var expected = "Contato 'Contato 1' atualizado com sucesso.";
            var contactService = new ContactService();
            contactService.AddContact("Contato 1", "9999-9990", "contato1@email.com");

            //Act:

            var result = contactService.UpdateContact(0, "Contato 1", "9999-9991", "contato1@email.com");

            //Assert:

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestUpdateInvalidIndexContact()
        {
            //Arrange:

            var expected = "Índice inválido. Tente novamente.";
            var contactService = new ContactService();
            contactService.AddContact("Contato 1", "9999-9990", "contato1@email.com");

            //Act:

            var result = contactService.UpdateContact(1, "Contato 1", "9999-9991", "contato1@email.com");

            //Assert:

            Assert.Equal(expected, result);
        }

        [Fact]

        public void TestRemoveContact()
        {
            //Arrange:

            var expected = "Contato 'Contato 1' removido com sucesso.";
            var contactService = new ContactService();
            contactService.AddContact("Contato 1", "9999-9990", "contato1@email.com");

            //Act:

            var result = contactService.RemoveContact(0);

            //Assert:

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestRemoveInvalidIndexContact()
        {
            //Arrange:

            var expected = "Índice inválido. Tente novamente.";
            var contactService = new ContactService();
            contactService.AddContact("Contato 1", "9999-9990", "contato1@email.com");

            //Act:

            var result = contactService.RemoveContact(1);

            //Assert:

            Assert.Equal(expected, result);
        }
    }
}