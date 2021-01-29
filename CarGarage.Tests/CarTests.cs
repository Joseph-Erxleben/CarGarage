using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        Car car;

        public CarTests()
        {
            car = new Car();
        }

        [Fact]
        public void SetMake_Assigns_Make_of_Car()
        {
            car.Make = "";

            // Add a SetMake method to the Car class that assigns the Make property to the value passed into the method
            // Uncomment the line below:
            // car.SetMake("Honda");

            Assert.Equal("Honda", car.Make);
        }

        [Fact]
        public void SetModel_Assigns_Model_of_Car()
        {
            car.Model = "";

            // Add a SetModel method to the Car class that assigns the Model property to the value passed into the method
            // Uncomment the line below:
            // car.SetModel("Accord");

            Assert.Equal("Accord", car.Model);
        }

        [Fact]
        public void GetSpeed_Should_Return_Speed()
        {
            car.Speed = 27;

            // Add a GetSpeed method to the Car class that returns the value of the Speed property
            // Uncomment the line below:
            // Assert.Equal(27, car.GetSpeed());
        }

        [Fact]
        public void IsSpeeding_Should_Return_True_If_Speed_Over_70mph()
        {
            car.Speed = 71;

            // Add an IsSpeeding method to the Car class that returns true if the Speed property is greater than 70
            // Uncomment the line below:
            // Assert.True(car.IsSpeeding());
        }

        [Fact]
        public void Accelerate_Should_Increase_Speed_By_10mph()
        {
            car.Speed = 0;

            // Add an Accelerate method to the Car class that increases Speed by 10 mph
            // Uncomment the line below:
            // car.Accelerate();

            Assert.Equal(10, car.Speed);
        }

        [Fact]
        public void Accelerate_Should_Not_Increase_Speed_Over_100mph()
        {
            car.Speed = 100;

            // Modify the Accelerate method so that the car's Speed can never exceed 100 mph
            // Uncomment the line below:
            // car.Accelerate();

            Assert.Equal(100, car.Speed);
        }

        [Fact]
        public void Accelerate_Should_Increase_Speed_By_20mph_If_Ferrari()
        {
            car.Speed = 0;
            car.Make = "Ferrari";

            // Modify the Accelerate method so that the car's Speed increases by 20mph, but only if the
            // Make is "Ferrari"
            // Uncomment the line below:
            // car.Accelerate();

            Assert.Equal(20, car.Speed);
        }

        [Fact]
        public void Brake_Should_Decrease_Speed_by_7mph()
        {
            car.Speed = 10;

            // Add a Brake method to the Car class that decreases Speed by 7 mph
            // Uncomment the line below:
            // car.Brake();

            Assert.Equal(3, car.Speed);
        }

        [Fact]
        public void Brake_Should_Not_Decrease_Speed_Less_Than_0mph()
        {
            car.Speed = 1;

            // Modify the Brake method so that the car's Speed can never go below 0 mph
            // Uncomment the line below:
            // car.Brake();

            Assert.Equal(0, car.Speed);
        }

        [Fact]
        public void Brake_Should_Decrease_Speed_in_Half_if_AutoBrake_is_True()
        {
            car.Speed = 50;
            car.AutoBrakeActive = true;

            // Modify the Brake method so that the car's Speed is decreased by half if AutoBrakeActive property is true
            // Uncomment the line below:
            // car.Brake();

            Assert.Equal(25, car.Speed);
        }
    }
}
