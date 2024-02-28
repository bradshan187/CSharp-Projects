using System;

namespace DependencyInjection;

// Our client will only know about this interface, not which specific car it is using.
internal interface ICar {
    string GetCarName();
}

// The following service provides concrete implementations of the above interface.
class Ford : ICar {
    public string GetCarName() => "Ford";
}

// This class is the client which receives a service.
class Car {
    ICar car;

    // The service is injected through the constructor and stored in the above field.
    public Car(ICar car) => this.car = car;

    public void PrintCar() {
        // The injected service is used.
        var carName = this.car.GetCarName();
        var message = $"You're driving the {carName} right now";

        Console.WriteLine(message);
    }
}

//class CarExample {
//    static void Main() {
//        var ford = new Ford();

//        var car = new Car(ford);

//        car.PrintCar();
//    }
//}