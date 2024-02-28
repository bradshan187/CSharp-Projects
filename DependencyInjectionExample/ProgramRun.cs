
using DependencyInjection;

// This class allows for the execution of any programs
class Example {
    static void Main() {
        // This is the example from CarExample
        var ford = new Ford();
        var car = new Car(ford);
        car.PrintCar();

        // This is the example from GamepadExample
        var steamController = new SteamController();
        var gamepad = new Gamepad(steamController);
        gamepad.Showcase();
    }
}
