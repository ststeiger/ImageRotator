
namespace ImageRotator
{


	class MainClass
	{


		private static void RotateAndSaveImage(string input, string output)
		{

            using (System.Drawing.Image img = System.Drawing.Image.FromFile(input))
			{
				//rotate the picture by 90 degrees and re-save the picture as a Jpeg
                img.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone); // + 90 UZS
                // img.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone); // -90 UZS
				img.Save(output, System.Drawing.Imaging.ImageFormat.Jpeg);
            } // End Using System.Drawing.Image img 

		} // End Sub RotateAndSaveImage 


		// http://stackoverflow.com/questions/2225363/c-sharp-rotate-bitmap-90-degrees
		// http://stackoverflow.com/questions/2163829/how-do-i-rotate-a-picture-in-c-sharp
		public static void Main(string[] args)
		{
            string source = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            source = System.IO.Path.Combine(source, "axyrOZH_1.jpg");

            string target = System.IO.Path.Combine(@"D:\Programme\PortableApps", "rotated_" + System.IO.Path.GetFileName(source));


            RotateAndSaveImage(source, target);

			System.Console.WriteLine (" === Press any key to continue === ");
            System.Console.ReadKey();
        } // End Sub Main 


    } // End Class MainClass 


} // End Namespace ImageRotator 
