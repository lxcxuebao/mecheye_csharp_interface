# Mech-Eye_Csharp_interface


This is official C# interface for Mech-Eye cameras. 

## Features 

By using this api, you can easily control your mech_eye cameras in .Net programs. The features of this API are as follows:

* Connect to your camera in your LANS.
* Set and get cameras parameters like exposure time, period and so on.
* Get color image and depth image as a numpy array.
* Get point cloud data in the format of a 2-dim array.

## Dependency

These packages are needed:

* Google.Protobuf
* NetMQ
* OpenCvSharp4 
* OpenCvSharp4.runtime.win

All these you can install with Nuget.

## Usage

Just clone this project and open the sln file with Visual Studio(VS2019 is recommanded).

If there are missing dependencies, you can easily install them with Nuget.

Build and run, main.cs is an sample to show you how to use API.
