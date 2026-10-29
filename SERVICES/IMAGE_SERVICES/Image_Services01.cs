using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using System.Net;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.IMAGE_SERVICES
{
    public class Image_Services01
    {
        private static string[] data01 = new string[100];
        public async Task<string> image_to_url(string input)
        {
            var account = new Account(
                  $"{File_Manger01.cloudinary_com_text01.Trim()}",   // <-- Replace with your Cloudinary cloud name
                  $"{File_Manger01.API02.Trim()}",      // <-- Replace with your Cloudinary API key
                  $"{File_Manger01.cloudinary_com_text02.Trim()}"    // <-- Replace with your Cloudinary API secret
              );

            var cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription($"{input.Trim()}"),
                UseFilename = true,
                UniqueFilename = false,
                Overwrite = true
            };

            // 4. Upload image
            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            if (uploadResult.StatusCode == HttpStatusCode.OK)
            {
                data01[0] = $"URL: {uploadResult.SecureUrl}\n" +
                            $"Status: {uploadResult.Status}\n" +
                            $"StatusCode: {uploadResult.StatusCode}\n" +
                            $"Signature: {uploadResult.Signature}\n" +
                            $"Version: {uploadResult.Version}";

            }
            else
            {
                data01[0] = $"Upload failed: {uploadResult.Error?.Message ?? "Unknown error"}";
            }
            return $"{uploadResult.SecureUrl}\n";

        }
        public async Task<string> image_url_to_file(string input)
        {
            // input = image URL
            string folderPath = @"C:\Photo01";
            Directory.CreateDirectory(folderPath);
            // Generate a unique filename from timestamp or GUID
            string fileName = "downloaded_image_" + DateTime.Now.Ticks + ".jpg";
            string fullPath = Path.Combine(folderPath, fileName);

            using (HttpClient client = new HttpClient())
            {

                byte[] imageBytes = await client.GetByteArrayAsync(input);
                await File.WriteAllBytesAsync(fullPath, imageBytes);
                data01[1] = fullPath;

            }

            return data01[1];
        }
    }
}
