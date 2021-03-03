using Application.UseCases;
using Domain.Entities;
using FluentAssertions;
using Infrastructure.Repository;
using System;
using Xunit;

namespace Application.UnitTest
{
    public class UnitsManagerTests
    {
        [Fact]
        public async void Should_Add_Units()
        {
            //arrange
            var dbContextFactor = new DbContextFactory();
            var dbContext = dbContextFactor.CreateInMemoryDbContext();
            var repository = new Repository<Unit>(dbContext);
            var unitsManager = new UnitsManager(repository);

            var unit = new Unit { UnitNumber = "Test1", UnitType = "UnitType" };

            //act
            var insertedEntity = await unitsManager.Add(unit);

            //assert
            insertedEntity.Should().NotBeNull();
            insertedEntity.Should().BeOfType<Unit>();
            insertedEntity.Should().Match<Unit>(u => u.Id > 0);
        }

        [Theory]
        [InlineData("UnitNumber1","TRACTOR")]
        [InlineData("UnitNumber2", "TRAILER")]
        [InlineData("UnitNumber3", "VAN")]
        public async void Should_Add_All_Type_Of_Units(string unitNumber, string unitType)
        {
            //arrange
            var dbContextFactor = new DbContextFactory();
            var dbContext = dbContextFactor.CreateInMemoryDbContext();
            var repository = new Repository<Unit>(dbContext);
            var unitsManager = new UnitsManager(repository);

            var unit = new Unit { UnitNumber = unitNumber, UnitType = unitType };

            //act
            var insertedEntity = await unitsManager.Add(unit);

            //assert
            insertedEntity.Should().NotBeNull();
            insertedEntity.Should().BeOfType<Unit>();
            insertedEntity.Should().Match<Unit>(u => u.Id > 0);
        }
    }
}
