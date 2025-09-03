// See https://aka.ms/new-console-template for more information
using AstractFactoryDesignPattern;

Console.WriteLine("Hello, World!");
IVehicleFactory regularVehicle = new RegularVehicle();
ICar rCar = regularVehicle.CreateCar();
rCar.GetDetails();

IBike rBike = regularVehicle.CreateBike();
rBike.GetDetails();

Console.ReadLine();