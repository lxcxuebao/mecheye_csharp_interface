using System;
using System.Collections.Generic;
using System.Text;
using OpenCvSharp;
using OpenCvSharp.Flann;

namespace Mechmind_CameraAPI_Csharp
{
    class main
    {
        static void Main()
        {
            CameraClient camera = new CameraClient();
            //camera ip should be modified to actual ip address
            //always set ip before do anything else
            camera.setIp("192.168.3.146");
            //get some camera info like intrincis, ip, id and version
            double[] intri = camera.getCameraIntri(); //[fx,fy,u,v]
       
            Console.WriteLine("Camera IP: " + camera.getCameraIp());
            Console.WriteLine("Camera ID: " + camera.getCameraId());
            Console.WriteLine("Version: " + camera.getCameraVersion());

            string save_path = "D:\\";
            //capture color image and depth image and save them
            Mat color = camera.captureColorImg();
            Mat depth = camera.captureDepthImg();

            if (color.Empty() || depth.Empty())
            {
                Console.WriteLine("Empty images");
            }
            else
            {
                Cv2.ImWrite(save_path + "color.jpg", color);
                Cv2.ImWrite(save_path + "depth.png", depth);
            }

            //set some parameters of camera, you can refer to parameters' names in Mech_eye
            Console.WriteLine(camera.setParameter("camera2DExpTime", 15));
            Console.WriteLine(camera.getParameter("camera2DExpTime"));
            Console.WriteLine(camera.setParameter("camera2DExpTime", 20));
            Console.WriteLine(camera.getParameter("camera2DExpTime"));

            //get point cloud in a 2-dim array,each element is [x,y,z,b,g,r]
            double[,] rel = camera.captureRGBCloud();//point cloud data in xyzrgb3
            Console.WriteLine("Cloud has " + rel.Length.ToString() + " points"); 
        }
        
    }
}
