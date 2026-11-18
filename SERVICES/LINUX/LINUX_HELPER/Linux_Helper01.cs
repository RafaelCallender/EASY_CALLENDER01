using System.Diagnostics;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER
{
    public class Linux_Helper01
    {

        private static File_Helper01 File_H01 = new File_Helper01();
        private static File_Servicesr01 File_S01 = new File_Servicesr01();

        private static string[] filepaths =
        {
    "/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_WEBB",
"/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_MOBILE",
"/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASYCONSOLE",
"/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_CALLENDER01",
"/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_DATABASE"



};
        private static string[] urlpaths = {
            "https://github.com/RafaelCallender/EASY_WEBB.git",
            "https://github.com/RafaelCallender/EASY_MOBILE.git",
         "https://github.com/RafaelCallender/EASYCONSOLE.git",
         "https://github.com/RafaelCallender/EASY_CALLENDER01.git",
         "https://github.com/RafaelCallender/EASY_DATABASE.git"
         };



        private static string[] project_paths =
        {
            "RafaelCallender/EASY_WEBB",
"RafaelCallender/EASY_MOBILE",
"RafaelCallender/EASYCONSOLE",
"RafaelCallender/EASY_CALLENDER01",
"RafaelCallender/EASY_DATABASE"
        };
        private static string[] project_names =
        {
            "EASY_WEBB",
"EASY_MOBILE",
"EASYCONSOLE",
"EASY_CALLENDER01",
"EASY_DATABASE"
        };

        private static string[] linux_OneDrive_array_ =
        {
          "rclone purge \"onedrive:Desktop/OneDrive\"",
          "rclone mkdir \"onedrive:Desktop/OneDrive\"",
          "rclone copy \"/home/swageteam101/Desktop/OneDrive\" \"onedrive:Desktop/OneDrive\" --fast-list --transfers=16 --checkers=16"
        };


        private static string[] linux_terminal_array_ =
        {
    @$"sudo apt clean && \
sudo apt autoclean && \
sudo apt autoremove --purge -y && \
sudo journalctl --vacuum-time=7d && \
flatpak uninstall --unused -y 2>/dev/null; \
rm -rf ~/.cache/*"
};

        public static string res01 { get; set; }

        private static string[] linux_github_array01_ =
        {
@$"
sed -i 's/0?/0/g' ~/.gitconfig
cd {filepaths[0].Trim()}
gh repo delete {project_paths[0].Trim()} --yes 2>/dev/null || true
sleep 3
rm -rf .git
gh repo create {project_names[0].Trim()} --public
sleep 5
git init
git branch -M main
git remote remove origin 2>/dev/null || true
git remote add origin {urlpaths[0].Trim()}
echo 'bin/' >> .gitignore
echo 'obj/' >> .gitignore
echo '.vs/' >> .gitignore
git add .
git commit -m 'Initial commit'
git push -u origin main --force
",@$"
sed -i 's/0?/0/g' ~/.gitconfig
cd {filepaths[1]}
gh repo delete {project_paths[1]} --yes 2>/dev/null || true
sleep 3
rm -rf .git
gh repo create {project_names[1]} --public
sleep 5
git init
git branch -M main
git remote remove origin 2>/dev/null || true
git remote add origin {urlpaths[1]}
echo 'bin/' >> .gitignore
echo 'obj/' >> .gitignore
echo '.vs/' >> .gitignore
git add .
git commit -m 'Initial commit'
git push -u origin main --force
",@$"
sed -i 's/0?/0/g' ~/.gitconfig
cd {filepaths[2]}
gh repo delete {project_paths[2]} --yes 2>/dev/null || true
sleep 3
rm -rf .git
gh repo create {project_names[2]} --public
sleep 5
git init
git branch -M main
git remote remove origin 2>/dev/null || true
git remote add origin {urlpaths[2]}
echo 'bin/' >> .gitignore
echo 'obj/' >> .gitignore
echo '.vs/' >> .gitignore
git add .
git commit -m 'Initial commit'
git push -u origin main --force
"
,@$"
sed -i 's/0?/0/g' ~/.gitconfig
cd {filepaths[3]}
gh repo delete {project_paths[3]} --yes 2>/dev/null || true
sleep 3
rm -rf .git
gh repo create {project_names[3]} --public
sleep 5
git init
git branch -M main
git remote remove origin 2>/dev/null || true
git remote add origin {urlpaths[3]}
echo 'bin/' >> .gitignore
echo 'obj/' >> .gitignore
echo '.vs/' >> .gitignore
echo 'FILES/' >> .gitignore
echo 'appsettings.json' >> .gitignore
echo 'appsettings.Development.json' >> .gitignore
echo '.env' >> .gitignore
echo 'client_secret.json' >> .gitignore
echo 'google-services.json' >> .gitignore
git add .
git commit -m 'Initial commit'
git push -u origin main --force
",
$@"gh repo create ""{res01}"" --public",
$@"gh repo list RafaelCallender",
@$"
sed -i 's/0?/0/g' ~/.gitconfig
cd {filepaths[4]}
gh repo delete {project_paths[4]} --yes 2>/dev/null || true
sleep 3
rm -rf .git
gh repo create {project_names[4]} --public
sleep 5
git init
git branch -M main
git remote remove origin 2>/dev/null || true
git remote add origin {urlpaths[4]}
echo 'bin/' >> .gitignore
echo 'obj/' >> .gitignore
echo '.vs/' >> .gitignore
echo 'FILES/' >> .gitignore
echo 'appsettings.json' >> .gitignore
echo 'appsettings.Development.json' >> .gitignore
echo '.env' >> .gitignore
echo 'client_secret.json' >> .gitignore
echo 'google-services.json' >> .gitignore
git add .
git commit -m 'Initial commit'
git push -u origin main --force
",
@$"mkdir -p ~{File_S01.create_file01("PROJECT").Trim()}
cd ~{File_S01.create_file01("PROJECT").Trim()}
gh repo list RafaelCallender --limit 1000 --json name --jq '.[].name' |
while read repo; do
    gh repo clone ""RafaelCallender/$repo""
done",
@$"cd ~/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_WEBB && \
git add . && \
git commit -m ""Updated EASY_WEBB"" && \
git push origin main"

};

        public enum linux_terminal01_index
        {
            pc_clean_up = 0
        }
        public enum linux_OneDrive01_index
        {
            DeleteRemoteFolder = 0,
            MakeRemoteFolder = 1,
            UploadToOneDrive = 2,
        }
        public enum linux_github01_index
        {
            upload_EASY_WEBB = 0,
            upload_EASY_MOBILE = 1,
            upload_EASY_EASYCONSOLE = 2,
            upload_EASY_CALLENDER01 = 3,
            create_repository = 4,
            list_repository = 5,
            upload_EASY_DATABASE = 6,
            download_all_repository = 7,
            update_EASY_WEBB_repository = 8
        }
        public static string[] linux_OneDrive_array => linux_OneDrive_array_;
        public static string[] linux_github_array01 => linux_github_array01_;
        public static string[] linux_terminal_array01 => linux_terminal_array_;

        public string CreateRepositoryCommand(string input)
        {
            return $@"gh repo create ""{input}"" --public";
        }
        public string DeleteRepositoryCommand(string input)
        {
            return $@"gh repo delete ""{input}"" --yes";
        }
        public string ListRepositoryCommand(string input)
        {
            return $@"gh repo list ""{input}""";
        }

        public string DownloadRepositoryCommand()
        {
            return linux_github_array01_[(int)linux_github01_index.download_all_repository];
        }
        public bool RunCommand(string command, out string output, out string error)
        {
            // REMOVE WINDOWS \r
            command = command.Replace("\r", "");
            var process = new Process();
            process.StartInfo.FileName = "/bin/bash";
            process.StartInfo.Arguments =
                $"-c \"{command.Replace("\"", "\\\"")}\"";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            output = process.StandardOutput.ReadToEnd();
            error = process.StandardError.ReadToEnd();
            process.WaitForExit();
            return process.ExitCode == 0;
        }

    }
}