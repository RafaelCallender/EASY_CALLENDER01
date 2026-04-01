using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using System.Reflection;



namespace EASY_CALLENDER01.SERVICES.FILE_SERVICES
{
    public class Read_Images
    {
        private static Assembly assembly = Assembly.GetExecutingAssembly();
        private static Stream?[] stream01 = { assembly.GetManifestResourceStream(File_Helper01.images[0]),
                                                 assembly.GetManifestResourceStream(File_Helper01.images[1]),
                                                  assembly.GetManifestResourceStream(File_Helper01.images[2]),
                                                  assembly.GetManifestResourceStream(File_Helper01.images[3]),
                                                     assembly.GetManifestResourceStream(File_Helper01.images[4]),
                                                         assembly.GetManifestResourceStream(File_Helper01.images[5]),
                                                             assembly.GetManifestResourceStream(File_Helper01.images[6]),
                                                                 assembly.GetManifestResourceStream(File_Helper01.images[7]),
                                                                     assembly.GetManifestResourceStream(File_Helper01.images[8]),
                                                                         assembly.GetManifestResourceStream(File_Helper01.images[9]),
                                                                             assembly.GetManifestResourceStream(File_Helper01.images[10]),
                                                                                 assembly.GetManifestResourceStream(File_Helper01.images[11]),
                                                                                     assembly.GetManifestResourceStream(File_Helper01.images[12]),
                                                                                      assembly.GetManifestResourceStream(File_Helper01.images[13]),
                                                                                    assembly.GetManifestResourceStream(File_Helper01.images[14]),
                                                                                      assembly.GetManifestResourceStream(File_Helper01.images[15]),
            assembly.GetManifestResourceStream(File_Helper01.images[16])



                       };
        private static Image[] image01_ = { new Image { Source = ImageSource.FromStream(() => stream01[0]) },
            new Image { Source = ImageSource.FromStream(() => stream01[1]) },
            new Image { Source = ImageSource.FromStream(() => stream01[2]) },
            new Image { Source = ImageSource.FromStream(() => stream01[3]) },
               new Image { Source = ImageSource.FromStream(() => stream01[4])},
                 new Image { Source = ImageSource.FromStream(() => stream01[5])},
                   new Image { Source = ImageSource.FromStream(() => stream01[6])},
                     new Image { Source = ImageSource.FromStream(() => stream01[7])},
                       new Image { Source = ImageSource.FromStream(() => stream01[8])},
                         new Image { Source = ImageSource.FromStream(() => stream01[9])},
                           new Image { Source = ImageSource.FromStream(() => stream01[10])},
                             new Image { Source = ImageSource.FromStream(() => stream01[11])},
                               new Image { Source = ImageSource.FromStream(() => stream01[12])},
                                      new Image { Source = ImageSource.FromStream(() => stream01[13])},
                                           new Image { Source = ImageSource.FromStream(() => stream01[14])},
                                            new Image { Source = ImageSource.FromStream(() => stream01[15])},
                                            new Image { Source = ImageSource.FromStream(() => stream01[16])}





        };
        public ImageSource[] source = {
image01_[0].Source,//cashapp01.jpg
image01_[1].Source,//.default_group_face01.jpg
image01_[2].Source,//default_single_face01.jpg
image01_[3].Source,//default_single_face02.jpg
image01_[4].Source,//default_single_face03.jpg
image01_[5].Source,//cashapp02.png
image01_[6].Source,//cashapp03.png
image01_[7].Source,//EYE_ICON01.png
image01_[8].Source,//paypal01.png
image01_[9].Source,//paypal02.png
image01_[10].Source,//paypal03.png
image01_[11].Source,//venmo02.png
image01_[12].Source,//venmo03.png
image01_[13].Source,//zelleimage01.png
image01_[14].Source,//zelleimages02.png
image01_[15].Source,//Easy Callender_page_1.jpeg
image01_[16].Source //.venmo01.webp
        };
    }
}
