using System;

namespace DependencyInjection;

// Our client will only know about this interface, not which specific gamepad it is using.
internal interface IGamepadFunctionality {
    string GetGamepadName();
    void SetVibrationPower(float power);
}

// The following services provide concrete implementations of the above interface.

class XBoxGamepad : IGamepadFunctionality {
    float vibrationPower = 1.0f;

    public string GetGamepadName() => "Xbox controller";

    public void SetVibrationPower(float power) => this.vibrationPower = Math.Clamp(power, 0.0f, 1.0f);
}

class PlaystationJoystick : IGamepadFunctionality {
    float vibratingPower = 100.0f;

    public string GetGamepadName() => "PlayStation controller";

    public void SetVibrationPower(float power) => this.vibratingPower = Math.Clamp(power * 100.0f, 0.0f, 100.0f);
}

class SteamController : IGamepadFunctionality {
    double vibrating = 1.0;

    public string GetGamepadName() => "Steam controller";

    public void SetVibrationPower(float power) => this.vibrating = Convert.ToDouble(Math.Clamp(power, 0.0f, 1.0f));
}

// This class is the client which receives a service.
class Gamepad {
    IGamepadFunctionality gamepadFunctionality;

    // The service is injected through the constructor and stored in the above field.
    public Gamepad(IGamepadFunctionality gamepadFunctionality) => this.gamepadFunctionality = gamepadFunctionality;

    public void Showcase() {
        // The injected service is used.
        var gamepadName = this.gamepadFunctionality.GetGamepadName();
        var message = $"We're using the {gamepadName} right now, do you want to change the vibrating power?";
        Console.WriteLine(message);

    }
}

//class GamepadExample {
//    static void Main() {
//        var steamController = new SteamController();

//        // We could have also passed in an XboxController, PlaystationJoystick, etc.
//        // The gamepad doesn't know what it's using and doesn't need to.
//        var gamepad = new Gamepad(steamController);

//        gamepad.Showcase();
//    }
//}