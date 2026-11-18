using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using Azure.Storage.Blobs;
using System.Runtime.InteropServices;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.DEVICES.DEVICE_SERVICES
{
    public class Device_Services01
    {
        private static string[] data01 = new string[100];

        public string launch_default_browser(string url)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo(url)
                {
                    UseShellExecute = true
                });
                data01[0] = "Success";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
                data01[0] = "Success";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
                data01[0] = "Success";
            }
            else
            {
                data01[0] = "failed";
            }
            return data01[0];
        }

        public async Task<(bool success, string output)> get_device_ip()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://ipinfo.io/json";
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();
                    JObject? data = JObject.Parse(json);

                    if (data != null)
                    {
                        data01[1] = $"{data["ip"]?.ToString()}\n" +
                                            $"{data["city"]?.ToString()}\n" +
                                            $"{data["region"]?.ToString()}\n" +
                                            $"{data["country"]?.ToString()}\n" +
                                            $"{data["loc"]?.ToString()}\n";
                        return (true, data01[1]);
                    }
                    else
                    {
                        data01[1] = "no data";
                        return (true, data01[1]);
                    }

                }
                catch (Exception ex)
                {
                    data01[1] = ex.ToString();
                    return (false, data01[1]);
                }

            }
        }
        public async Task<(bool success, string output)> get_mobile_location01()
        {


            try
            {
                PermissionStatus permission = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
                if (permission != PermissionStatus.Granted)
                {
                    permission = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();


                }

                if (permission != PermissionStatus.Granted)
                {

                    return (false, "Location permission was not granted");

                }

                Location? location = await Geolocation.Default.GetLocationAsync(
                    new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(10)));

                if (location is not null)
                {
                    IEnumerable<Placemark>? placemarks = await Geocoding.Default.GetPlacemarksAsync(
                        location.Latitude,
                        location.Longitude);
                    Placemark? placemark = placemarks?.FirstOrDefault();

                    if (placemark is null)
                    {
                        return (false, "Unable to determine the city, state, or country");
                    }

                    return (true, $"City: {placemark.Locality ?? "Unknown"}\n" +
                                  $"State: {placemark.AdminArea ?? "Unknown"}\n" +
                                  $"Country: {placemark.CountryName ?? "Unknown"}\n" +
                                  $"{location.Longitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}\n" +
                                  $"{location.Latitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
                }
                else
                {

                    return (false, "Unable to get the device location");
                }
            }
            catch (FeatureNotSupportedException)
            {

                return (false, "Precise location is not supported on this device");
            }
            catch (PermissionException)
            {

                return (false, "Location permission was not granted");
            }
            catch (Exception ex)
            {

                return (false, $"Unable to get precise location\n {ex}");
            }

        }


        public string image_to_url(string input)
        {
            var account = new Account(
                  $"{File_Manger01.cloudinary_com_text01.Trim()}",   // <-- Replace with your Cloudinary cloud name
                  $"{File_Manger01.API02.Trim()}",      // <-- Replace with your Cloudinary API key
                  $"{File_Manger01.cloudinary_com_text02.Trim()}"    // <-- Replace with your Cloudinary API secret
              );

            var cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription($"{input}"),
                UseFilename = true,
                UniqueFilename = false,
                Overwrite = true
            };

            // 4. Upload image
            var uploadResult = cloudinary.Upload(uploadParams);

            // 5. Output public URL
            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                data01[0] += $"{uploadResult.SecureUrl.ToString()}";
            }
            else
            {
                data01[0] = $"Upload failed:\n";
            }
            return data01[0];
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
                data01[0] = "Image saved to: " + fullPath;

            }

            return data01[0];
        }
        public string open_files_using_windows(string input)
        {

            if (File.Exists(input.Trim()) == true)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = $"{input.Trim()}",
                    UseShellExecute = true
                });
                data01[0] = "Success";
            }
            else
            {
                data01[0] = "Fail";
            }
            return data01[0];

        }
        public string audio_to_url()
        {
            return data01[0];
        }
    }
}