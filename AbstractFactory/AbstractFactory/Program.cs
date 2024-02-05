using AbstractFactory;
using AbstractFactory.Factories;

IGUIFactory windowsFactory = new WindowsFactory();
var windowsButton = windowsFactory.CreateButton();
var windowsCheckbox = windowsFactory.CreateCheckbox();
var windowsWindow = windowsFactory.CreateWindow();

Console.WriteLine();
Console.WriteLine("Windows");
windowsButton.Render();
windowsCheckbox.Render();
windowsWindow.Render();

IGUIFactory linuxFactory = new LinuxFactory();
var linuxButton = linuxFactory.CreateButton();
var linuxCheckbox = linuxFactory.CreateCheckbox();
var linuxWindow = linuxFactory.CreateWindow();

Console.WriteLine();
Console.WriteLine("Linux");
linuxButton.Render();
linuxCheckbox.Render();
linuxWindow.Render();

IGUIFactory macOSFactory = new MacOSFactory();
var macOSButton = macOSFactory.CreateButton();
var macOSCheckbox = macOSFactory.CreateCheckbox();
var macOSWindow = macOSFactory.CreateWindow();

Console.WriteLine();
Console.WriteLine("MacOs");
macOSButton.Render();
macOSCheckbox.Render();
macOSWindow.Render();