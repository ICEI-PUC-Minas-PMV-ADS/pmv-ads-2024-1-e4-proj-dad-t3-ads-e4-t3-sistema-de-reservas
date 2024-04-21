using api_reservas.Models;
using api_reservas.Repositories;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Moq;

namespace Testes
{
    /// <summary>
    /// Tests for MyMongoRepositoy class
    /// </summary>
    public class MyMongoRepositoryTests
    {
        private readonly Mock<IOptions<DatabaseSettings>> _mockDatabaseSettings;
        private readonly Mock<IMongoClient> _mockMongoClient;
        private readonly MyMongoRepository _repository;

        public MyMongoRepositoryTests()
        {
            // Arrange: Mock theecessary dependencies
            _mockDatabaseSettings = new Mock<IOptions<DatabaseSettings>>();
            _mockMongoClient = new Mock<IMongoClient>();

            // Set up database settings
            _mockDatabaseSettings.Setup(x => x.Value).Returns(new DatabaseSettings
            {
                ConnectionString = "mongodb://localhost:27017",
                DatabaseName = "mydb"
            });

            // Create the repository instance
            _repository = new MyMongoRepository(_mockDatabaseSettings.Object);
        }

        /// <summary>
        /// Tests the constructor of MyMongoRepository to ensure it sets the MongoDatabase field.
        /// </summary>
        [Fact]
        public void MyMongoRepository_Constructor_SetsMongoDatabase()
        {
            // Arrange
            var databaseSettings = Options.Create(new DatabaseSettings
            {
                ConnectionString = "mongodb://localhost:27017",
                DatabaseName = "testDatabase"
            });

            // Act
            var repository = new MyMongoRepository(databaseSettings);

            // Assert
            Assert.NotNull(repository.mongoDatabase);
        }
        /// <summary>
        /// Tests that an ArgumentNullException is thrown when database settings are null.
        /// </summary>
        [Fact]
        public void MyMongoRepository_Constructor_ThrowsExceptionIfDatabaseSettingsIsNull()
        {
            // Act & Assert
            Assert.Throws<NullReferenceException>(() => new MyMongoRepository(null));
        }

        /// <summary>
        /// Tests that a MongoConfigurationException is thrown when the connection string is invalid.
        /// </summary>
        [Fact]
        public void MyMongoRepository_Constructor_ThrowsExceptionIfConnectionStringIsInvalid()
        {
            // Arrange
            var databaseSettings = Options.Create(new DatabaseSettings
            {
                ConnectionString = "invalid_connection_string",
                DatabaseName = "testDatabase"
            });

            // Act & Assert
            Assert.Throws<MongoConfigurationException>(() => new MyMongoRepository(databaseSettings));
        }

    }
}
