using System;

namespace InterfaceExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            // Create 4 members that Car, Truck, & SUV all have in common.
            // Example: All vehicles have a number of wheels... for now..

            //In ICompany

            // Create 2 members that are specific to each every company
            // regardless of vehicle type.
            
            // Example: public string Logo { get; set; }
            
            //In each of your car, truck, and suv classes

            // Create 2 members that are specific to each class
            // Example: truck has a bed size while car has a trunk while suv has a cargo hold size
            // Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
            
            Car sudan = new Car() { CompanyName = "Kia", CompanySlogan = "Movement that inspires", NumberOfWheels = 4, HasSteeringWheel = true, HasGreatGasMialage = true, HasRadio = true, LowToTheGround = true, NeedsGas = true };
            Console.WriteLine($"New car type: {sudan.CompanyName}");
            Console.WriteLine($"Company Slogan: {sudan.CompanySlogan}");
            Console.WriteLine($"It has {sudan.NumberOfWheels} wheels.");
            Console.WriteLine($"It has a steering wheel: {sudan.HasSteeringWheel}");
            Console.WriteLine($"It has radio: {sudan.HasRadio}");
            Console.WriteLine($"Needs gas: {sudan.NeedsGas}");
            Console.WriteLine($"This car is low to the ground: {sudan.LowToTheGround}");
            Console.WriteLine($"This car has great gas mialage: {sudan.HasGreatGasMialage}");
            Console.WriteLine();

            Truck ford = new Truck() { CompanyName = "Ford", CompanySlogan = "Built ford tough", IsLifted = true, NotAnnoyinglyLoud = false, HasRadio = true, HasSteeringWheel = true, NeedsGas = true, NumberOfWheels = 4};
            Console.WriteLine($"New truck type: {ford.CompanyName}");
            Console.WriteLine($"Company slogan: {ford.CompanySlogan}");
            Console.WriteLine($"Noone likes lifted trucks: {ford.IsLifted}");                      //Now, create objects of your 3 classes and give their members values;
            Console.WriteLine($"Trucks are not annoyingly loud: {ford.NotAnnoyinglyLoud}");        //Creatively display and organize their values
            Console.WriteLine($"The ford has {ford.NumberOfWheels} wheels");
            Console.WriteLine($"Has radio: {ford.HasRadio}");
            Console.WriteLine($"Needs gas: {ford.NeedsGas}");
            Console.WriteLine($"Has steering wheel: {ford.HasSteeringWheel}");
            Console.WriteLine();

            SUV momVan = new SUV() { CompanyName = "Toyota", CompanySlogan = "Let's go places", GoodStorageSpace = true, HighOffGround = true, NumberOfWheels = 4, HasSteeringWheel = true, HasRadio = true, NeedsGas = true };
            Console.WriteLine($"The mom van is a {momVan.CompanyName}");
            Console.WriteLine($"Company slogan: {momVan.CompanySlogan}");
            Console.WriteLine($"The mom van has good storage space: {momVan.GoodStorageSpace}");
            Console.WriteLine($"The mom van is high off the ground: {momVan.HighOffGround}");
            Console.WriteLine($"The Toyota mom van has {momVan.NumberOfWheels} wheels.");
            Console.WriteLine($"The Toyota mom van has a steering wheel: {momVan.HasSteeringWheel}");
            Console.WriteLine($"The Toyota mom van has radio: {momVan.HasRadio}");
            Console.WriteLine($"The Toyota mom van needs gas: {momVan.NeedsGas}");
        }
    }
}
