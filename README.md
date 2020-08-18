# Mech-Eye_Csharp_interface


This is official C# interface for Mech-Eye cameras. 

## Features 

By using this api, you can easily control your mech_eye cameras in .Net programs. The features of this API are as follows:

* Connect to your camera in your LANS.
* Set and get cameras parameters like exposure time, period and so on.
* Get color image and depth image as a numpy array.
* Get point cloud data in the format of a 2-dim array.

## Dependency

These environments are needed :

* Visual Studio (2019 is recommanded)
* .Net

These packages are needed:

* Google.Protobuf
* NetMQ
* OpenCvSharp4 
* OpenCvSharp4.runtime.win

All these you can install with Nuget.

### Installation

1. We recommand VS 2019 to compiler the project. Make sure .Net is also installed.

   If not, you can open VS and then go to: Tools ->Get Tools and features and then, in Wordloads tag, choose ".Net Desktop Development" and install it.

2. Clone the repo and open .sln file with VS.

3. Right CIick on the "Mechmind_cameraAPI_Csharp" and click "Manage Nuget packages".

4. Then Click the "Browse" tag and search "Google.Protobuf" and install it.

   The 3 other packages can also be installed in this way.

## Quick Start

After finish installation above, click the Debug->start debugging.

The sample.cs will be compiled and run. 

