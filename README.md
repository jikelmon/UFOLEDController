# UFOLEDController
A very simple library to control the LD382 and LD382A Wifi LED Controller with C#.

I was searching for a solution to use my LED-Strips with my Homeautomtization-Server 
written in C# an was not able to find an existing project which fitted my needs.

In addition to that the available App for Android workes with the v1 of the Controller
but does not with the new v3 i purchased last.

So i decided to create this project. I'm a beginner in programming so there are may be 
many possibilities to optimize the code. Feel free to use and contribute.

#Using
You have to import the DLL and use the namespace "UFOLEDController". 
Then you can create an object of the type UFOv1 or UFOv3 which has to match your version.

UFOv1 is the LD382, UFOv3 is the LD382A.

1. Create a new object

Ufov1 controller = new UFOv1("NAME", "IP");

2. Change Power Status by Power.On or Power.Off

ontroller.POWER = Power.Off;

3. Set RGB level by SendRGB(redValue, greenValue, blueValue, intensityInPercent);

controller.SendRGB(0, 255, 0, 100);
