using System.Diagnostics;
using System.IO.Compression;

namespace FortniteBuildInstaller
{
    class Program
    {

        public struct Build
        {
            public string Name;
            public string Date;
            public string EngineVersion;
            public string DownloadLink;

            public Build(string name, string date, string engineVersion, string downloadLink)
            {
                Name = name;
                Date = date;
                EngineVersion = engineVersion;
                DownloadLink = downloadLink;
            }
        }

        static async Task Main(string[] args)
        {
            Console.Title = "FortniteBuild Installer+";
            Dictionary<string, string> messages;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + "Fortnite Build-Installer:");
            Console.WriteLine("CREDITS: Code made by Waslyl, Repo by Shoqapique | More builds and Laguages added by:Ducki67");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n" + "Builds from 2 Public Archives:");
            Console.WriteLine("Archive #1 GALAXIAFN:https://galaxiafn.co.uk");
            Console.WriteLine("Archive #2 FORTNITEBUILDS:https://github.com/n6617x/Fortnitebuilds");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + "Original Build-Installer:");
            Console.WriteLine("Source Code:https://github.com/Waslyl/FortniteBuild-Installer?tab=readme-ov-file");
            Console.WriteLine("Build-Installer V1.1 Realese:https://github.com/Waslyl/FortniteBuild-Installer/releases");
            Console.WriteLine("Installer Discord Server:https://discord.com/invite/QkfTM4gY9d");
            Console.WriteLine("GalaxiaFN Discord Server:https://discord.com/invite/bNkVktZhGb");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n" + "Wellcome to Fortnite Build-Installer!! Please select your language: (total 6 available) ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1. English\n2. Français\n3. Deutsch\n4. Español\n5. Italiano\n6. Hungarian");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Choice: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string langChoice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            switch (langChoice)
            {
                case "1":
                    messages = Languages.English;
                    Console.Clear();
                    break;
                case "2":
                    messages = Languages.French;
                    Console.Clear();
                    break;
                case "3":
                    messages = Languages.German;
                    Console.Clear();
                    break;
                case "4":
                    messages = Languages.Spanish;
                    Console.Clear();
                    break;
                case "6":
                    messages = Languages.Hungarian;
                    Console.Clear();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Defaulting to English.");
                    messages = Languages.English;
                    break;
            }

            List<Build> builds = new List<Build>
            {
new Build(  "OT6.5-CL-2870186 [GalaxiaFN]", "28-02-16", "UE4.12", "https://galaxiafn.co.uk/0.6.5.zip"),
new Build(  "OT6.5-CL-2870186 [FortniteBuilds]", "28-02-16", "UE4.12", "https://public.simplyblk.xyz/OT0.6.5.zip"),
new Build(  "1.7.2-CL-3700114 [FortniteBuilds]", "17-10-17", "UE4.16", "https://public.simplyblk.xyz/1.7.2.zip"),
new Build(  "1.7.2-CL-3700114 [GalaxiaFN]", "17-10-17", "UE4.16", "https://galaxiafn.co.uk/1.7.2.zip"),
new Build(  "1.8-CL-3724489 [FortniteBuilds]", "25-10-17", "UE4.16-3724489", "https://public.simplyblk.xyz/1.8.rar"),
new Build(  "1.8.1-CL-3729133 [FortniteBuilds]", "02-11-17", "UE4.16-3729133", "https://public.simplyblk.xyz/1.8.1.rar"),
new Build(  "1.8.2-CL-3741772 [FortniteBuilds]", "08-11-17", "UE4.16-3741772", "https://public.simplyblk.xyz/1.8.2.rar"),
new Build(  "1.9-CL-3757339 [FortniteBuilds]", "14-11-17", "UE4.16-3757339", "https://public.simplyblk.xyz/1.9.rar"),
new Build(  "1.9.1-CL-3775276 [FortniteBuilds]", "29-11-17", "UE4.16-3775276", "https://public.simplyblk.xyz/1.9.1.rar"),
new Build(  "1.10-CL-3790078 [FortniteBuilds]", "06-12-17", "UE4.19-3790078", "https://public.simplyblk.xyz/1.10.rar"),
new Build(  "1.11-CL-3807424 [GalaxiaFN]", "14-12-17", "UE4.19", "https://galaxiafn.co.uk/1.11.zip"),
new Build(  "1.11-CL-3807424 [FortniteBuilds]", "14-12-17", "UE4.19", "https://public.simplyblk.xyz/1.11.zip"),
new Build(  "2.1.0-CL-3825894 [FortniteBuilds]", "09-01-18", "UE4.19-3825894", "https://public.simplyblk.xyz/2.1.0.zip"),
new Build(  "2.2.0-CL-3841827 [FortniteBuilds]", "18-01-18", "UE4.19-3841827", "https://public.simplyblk.xyz/2.2.0.zip"),
new Build(  "2.3.0-CL-3847564 [FortniteBuilds]", "25-01-18", "UE4.19-3847564", "https://public.simplyblk.xyz/2.3.0.zip"),
new Build(  "2.4.0-CL-3858292 [GalaxiaFN]", "01-02-18", "UE4.19", "https://galaxiafn.co.uk/2.4.0.zip"),
new Build(  "2.4.0-CL-3858292 [FortniteBuilds]", "01-02-18", "UE4.19-3858292", "https://public.simplyblk.xyz/2.4.0.zip"),
new Build(  "2.4.2-CL-3870737 [FortniteBuilds]", "07-02-18", "UE4.19-3870737", "https://public.simplyblk.xyz/2.4.2.zip"),
new Build(  "2.5.0-CL-3889387 [FortniteBuilds]", "13-02-18", "UE4.20-3889387", "https://public.simplyblk.xyz/2.5.0.rar"),
new Build(  "3.0-CL-3901517 [FortniteBuilds]", "21-02-18", "UE4.20-3901517", "https://public.simplyblk.xyz/3.0.zip"),
new Build(  "3.0-CL-3901517 [GalaxiaFN]", "21-02-18", "UE4.20", "https://galaxiafn.co.uk/3.0.zip"),
new Build(  "3.1.1-CL-3917250 [FortniteBuilds]", "28-02-18", "UE4.20-3917250", "https://public.simplyblk.xyz/3.1.1.zip"),
new Build(  "3.2-CL-3935073 [FortniteBuilds]", "08-03-18", "UE4.20-3935073", "https://public.simplyblk.xyz/3.2.zip"),
new Build(  "3.3-CL-3942182 [FortniteBuilds]", "15-03-18", "UE4.20-3942182", "https://public.simplyblk.xyz/3.3.rar"),
new Build(  "3.5-CL-4008490 [FortniteBuilds]", "11-04-18", "UE4.20-4008490", "https://public.simplyblk.xyz/3.5.rar"),
new Build(  "3.5-CL-4008490 [GalaxiaFN]", "11-04-18", "UE4.20", "https://galaxiafn.co.uk/3.5.zip"),
new Build(  "3.6-CL-4019403 [FortniteBuilds]", "24-04-18", "UE4.20-4019403", "https://public.simplyblk.xyz/3.6.rar"),
new Build(  "4.0-CL-4039451 [FortniteBuilds]", "02-05-18", "UE4.20-4039451", "https://public.simplyblk.xyz/4.0.zip"),
new Build(  "4.1-CL-4053532 [FortniteBuilds]", "02-05-18", "UE4.20-4053532", "https://public.simplyblk.xyz/4.1.zip"),
new Build(  "4.2-CL-4072250 [GalaxiaFN]", "16-05-18", "UE4.20", "https://galaxiafn.co.uk/4.2.zip"),
new Build(  "4.2-CL-4072250 [FortniteBuilds]", "16-05-18", "UE4.20-4072250", "https://public.simplyblk.xyz/4.2.zip"),
new Build(  "4.4-CL-4117433 [FortniteBuilds]", "11-06-18", "UE4.20-4117433", "https://public.simplyblk.xyz/4.4.rar"),
new Build(  "4.5-CL-4159770 [FortniteBuilds]", "27-06-18", "UE4.20-4159770", "https://public.simplyblk.xyz/4.5.rar"),
new Build(  "5.00-CL-4204761 [FortniteBuilds]", "12-07-18", "UE4.21-4204761", "https://public.simplyblk.xyz/5.00.rar"),
new Build(  "5.0.1-CL-4214610 [FortniteBuilds]", "12-07-18", "UE4.21-4214610", "https://public.simplyblk.xyz/5.0.1.rar"),
new Build(  "5.10-CL-4240749 [FortniteBuilds]", "25-07-18", "UE4.21-4240749", "https://public.simplyblk.xyz/5.10.rar"),
new Build(  "5.21-CL-4288479 [FortniteBuilds]", "15-08-18", "UE4.21-4288479", "https://public.simplyblk.xyz/5.21.rar"),
new Build(  "5.30-CL-4305896 [FortniteBuilds]", "23-08-18", "UE4.21-4305896", "https://public.simplyblk.xyz/5.30.rar"),
new Build(  "5.40-CL-4352937 [FortniteBuilds]", "05-09-18", "UE4.21-4352937", "	https://public.simplyblk.xyz/5.40.rar"),
new Build(  "5.41-CL-4363240 [GalaxiaFN]", "19-09-18", "UE4.21", "https://galaxiafn.co.uk/5.41.zip"),
new Build(  "6.00-CL-4395664 [FortniteBuilds]", "27-09-18", "UE4.21-4395664", "https://public.simplyblk.xyz/6.00.rar"),
new Build(  "6.01-CL-4417689 [FortniteBuilds]", "03-10-18", "UE4.21-4417689", "https://public.simplyblk.xyz/6.01.rar"),
new Build(  "6.1.1-CL-4424678 [FortniteBuilds]", "03-10-18", "UE4.21-4424678	", "https://public.simplyblk.xyz/6.1.1.rar"),
new Build(  "6.02-CL-4442095 [FortniteBuilds]", "10-10-18", "UE4.21-4442095", "https://public.simplyblk.xyz/6.02.rar"),
new Build(  "6.2.1-CL-4461277 [FortniteBuilds]", "10-10-18", "UE4.21-4461277", "https://public.simplyblk.xyz/6.2.1.rar"),
new Build(  "6.10-CL-4464155 [FortniteBuilds]", "16-10-18", "UE4.21-4464155", "https://public.simplyblk.xyz/6.10.rar"),
new Build(  "6.10.1-CL-4476098 [FortniteBuilds]", "16-10-18", "UE4.21-4476098", "https://public.simplyblk.xyz/6.10.1.rar"),
new Build(  "6.10.2-CL-4480234 [FortniteBuilds]", "16-10-18", "UE4.21-4480234", "https://public.simplyblk.xyz/6.10.2.rar"),
new Build(  "6.21-CL-4526925 [FortniteBuilds]", "01-11-18", "UE4.21-4526925", "https://public.simplyblk.xyz/6.21.rar"),
new Build(  "6.22-CL-4543176 [FortniteBuilds]", "04-11-18", "UE4.21-4543176", "https://public.simplyblk.xyz/6.22.rar"),
new Build(  "6.30-CL-4573096 [FortniteBuilds]", "13-11-18", "UE4.21-4573096", "https://public.simplyblk.xyz/6.30.rar"),
new Build(  "6.31-CL-4573279 [FortniteBuilds]", "27-11-18", "UE4.21-4573279	", "https://public.simplyblk.xyz/6.31.rar"),
new Build(  "7.00-CL-4629139 [FortniteBuilds]", "06-12-188", "UE4.22-4629139", "https://public.simplyblk.xyz/7.00.rar"),
new Build(  "7.10-CL-4667333 [FortniteBuilds]", "18-12-18", "UE4.22-4667333", "https://public.simplyblk.xyz/7.10.rar"),
new Build(  "7.20-CL-4727874 [FortniteBuilds]", "22-01-19", "UE4.22-4727874", "https://public.simplyblk.xyz/7.20.rar"),
new Build(  "7.30-CL-4834550 [GalaxiaFN]", "29-01-19", "UE4.22", "https://galaxiafn.co.uk/7.30.zip"),
new Build(  "7.30-CL-4834550 [FortniteBuilds]", "29-01-19", "UE4.22-4834550", "https://public.simplyblk.xyz/7.30.rar"),
new Build(  "7.40-CL-5046157 [FortniteBuilds]", "13-02-19", "UE4.22-5046157", "https://public.simplyblk.xyz/7.40.rar"),
new Build(  "8.00-CL-5203069 [FortniteBuilds]", "28-02-19", "UE4.22", "https://galaxiafn.co.uk/8.00.zip"),
new Build(  "8.00-CL-5203069 [FortniteBuilds]", "28-02-19", "UE4.22", "https://public.simplyblk.xyz/8.00.zip"),
new Build(  "8.20-CL-N/A [FortniteBuilds]", "27-03-19", "UE4.23", "https://public.simplyblk.xyz/8.20.rar"),
new Build(  "8.30-CL-N/A [FortniteBuilds]", "10-04-19", "UE4.23", "https://public.simplyblk.xyz/8.30.rar"),
new Build(  "8.40-CL-N/A [FortniteBuilds]", "17-04-19", "UE4.23", "https://public.simplyblk.xyz/8.40.zip"),
new Build(  "8.50-CL-6058028 [GalaxiaFN]", "25-04-19", "UE4.23", "https://galaxiafn.co.uk/8.50.zip"),
new Build(  "8.50-CL-6058028 [FortniteBuilds]", "25-04-19", "UE4.23", "https://public.simplyblk.xyz/8.50.zip"),
new Build(  "8.51-CL-6165369 [GalaxiaFN]", "02-05-19", "UE4.23", "https://galaxiafn.co.uk/8.51.zip"),
new Build(  "8.51-CL-N/A [FortniteBuilds]", "02-05-19", "UE4.23", "https://public.simplyblk.xyz/8.51.rar"),
new Build(  "9.00-CL-6337466 [FortniteBuilds]", "09-05-19", "UE4.23", "https://public.simplyblk.xyz/9.00.zip"),
new Build(  "9.01-CL-6428087 [FortniteBuilds]", "15-05-19", "UE4.23", "https://public.simplyblk.xyz/9.01.zip"),
new Build(  "9.10-CL-6639283 [GalaxiaFN]", "19-05-19", "UE4.23", "https://galaxiafn.co.uk/9.10.zip"),
new Build(  "9.10-CL-6639283 [FortniteBuilds]", "19-05-19", "UE4.23", "https://public.simplyblk.xyz/9.10.rar"),
new Build(  "9.21-CL-6922310 [FortniteBuilds]", "12-06-19", "UE4.23", "https://public.simplyblk.xyz/9.21.zip"),
new Build(  "9.30-CL-7095426 [FortniteBuilds]", "09-07-19", "UE4.23", "https://public.simplyblk.xyz/9.30.zip"),
new Build(  "9.40-CL-7315705 [FortniteBuilds]", "17-07-19", "UE4.23", "https://public.simplyblk.xyz/9.40.zip"),
new Build(  "9.41-CL-7609292 [FortniteBuilds]", "23-07-19", "UE4.23", "https://public.simplyblk.xyz/9.41.rar"),
new Build(  "10.00-CL-7704164 [FortniteBuilds]", "01-08-19", "UE4.23", "https://public.simplyblk.xyz/10.00.zip"),
new Build(  "10.10-CL-7955722 [FortniteBuilds]", "10-08-19", "UE4.23", "https://public.simplyblk.xyz/10.10.zip"),
new Build(  "10.20-CL-8456527 [FortniteBuilds]", "27-08-19", "UE4.23", "https://public.simplyblk.xyz/10.20.zip"),
new Build(  "10.31-CL-8723043 [FortniteBuilds]", "18-09-19", "UE4.23", "https://public.simplyblk.xyz/10.31.zip"),
new Build(  "10.40-CL-9380822 [FortniteBuilds]", "25-09-19", "UE4.23", "https://public.simplyblk.xyz/10.40.rar"),
new Build(  "11.00-CL-9603448 [GalaxiaFN]", "15-10-19", "UE4.24", "https://galaxiafn.co.uk/11.00.zip"),
new Build(  "11.31-CL-N/A [FortniteBuilds]", "N/A", "N/A", "https://public.simplyblk.xyz/11.31.rar"),
new Build(  "12.00-CL-N/A [FortniteBuilds]", "20-02-20", "UE4.24", "https://public.simplyblk.xyz/12.00.rar"),
new Build(  "12.21-CL-N/A [FortniteBuilds]", "24-03-20", "UE4.25", "https://public.simplyblk.xyz/12.21.zip"),
new Build(  "12.41-CL-12905909 [FortniteBuilds]", "21-04-20", "UE4.25", "https://public.simplyblk.xyz/Fortnite%2012.41.zip"),
new Build(  "12.50-CL-N/A [FortniteBuilds]", "29-04-20", "UE4.25", "https://public.simplyblk.xyz/12.50.zip"),
new Build(  "12.61-CL-N/A [FortniteBuilds]", "26-05-20", "UE4.25", "https://public.simplyblk.xyz/12.61.zip"),
new Build(  "13.00-CL-N/A [FortniteBuilds]", "27-09-20", "UE4.26", "https://public.simplyblk.xyz/13.00.rar"),
new Build(  "13.40-CL-14113327 [FortniteBuilds]", "27-09-20", "UE4.26", "https://public.simplyblk.xyz/13.40.zip"),
new Build(  "14.00-CL-N/A [FortniteBuilds]", "27-09-20", "UE4.26", "https://public.simplyblk.xyz/14.00.rar"),
new Build(  "14.40-CL-14550713 [FortniteBuilds]", "21-10-20", "UE4.26", "https://public.simplyblk.xyz/14.40.rar"),
new Build(  "15.30-CL-15341163 [FortniteBuilds]", "02-02-21", "UE4.26", "https://public.simplyblk.xyz/15.30.rar"),
new Build(  "15.50-CL-15526472 [GalaxiaFN]", "02-03-21", "UE4.26", "https://galaxiafn.co.uk/15.50.zip"),
new Build(  "16.40-CL-16218553 [FortniteBuilds]", "11-05-21", "UE4.26.1", "https://public.simplyblk.xyz/16.40.rar"),
new Build(  "16.50-CL-16432754 [GalaxiaFN]", "26-05-21", "UE4.26.1", "https://galaxiafn.co.uk/16.50.zip"),
new Build(  "17.30-CL-N/A [FortniteBuilds]", "27-04-21", "UE4.26", "https://public.simplyblk.xyz/17.30.zip"),
new Build(  "17.50-CL-N/A [FortniteBuilds]", "03-06-22", "UE4.26.1", "https://public.simplyblk.xyz/17.50.zip"),
new Build(  "18.40-CL-N/A [FortniteBuilds]", "03-06-22", "UE4.26.1", "https://public.simplyblk.xyz/18.40.zip"),
new Build(  "19.10-CL-N/A [FortniteBuilds]", "N/A", "N/A", "https://public.simplyblk.xyz/19.10.rar"),
new Build(  "20.40-CL-N/A [FortniteBuilds]", "N/A", "N/A", "https://public.simplyblk.xyz/20.40.zip"),

            };

            Console.WriteLine(messages["welcome"]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + "CREDITS: Code made by Waslyl, Repo by Shoqapique | More builds and Laguages added by:Ducki67");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n" + "Builds from 2 Public Archives:");
            Console.WriteLine("Archive #1 GALAXIAFN:https://galaxiafn.co.uk");
            Console.WriteLine("Archive #2 FORTNITEBUILDS:https://github.com/n6617x/FortniteBuilds");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + "Original Build-Installer:");
            Console.WriteLine("Source Code:https://github.com/Waslyl/FortniteBuild-Installer?tab=readme-ov-file");
            Console.WriteLine("Build-Installer V1.1 Realese:https://github.com/Waslyl/FortniteBuild-Installer/releases");
            Console.WriteLine("Installer Discord Server:https://discord.com/invite/QkfTM4gY9d");
            Console.WriteLine("GalaxiaFN Discord Server:https://discord.com/invite/bNkVktZhGb");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + messages["available_builds"] + "\n");

            for (int i = 0; i < builds.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{i + 1}. Build: {builds[i].Name}, Date: {builds[i].Date}, Engine: {builds[i].EngineVersion}");

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + messages["enter_choice"]);
            Console.ForegroundColor = ConsoleColor.Green;

            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= builds.Count)
            {
                Build selectedBuild = builds[choice - 1];
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n{messages["build_choice"]} {selectedBuild.Name}");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n" + messages["enter_path"]);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string installPath = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                if (!Directory.Exists(installPath))
                {
                    Console.WriteLine(messages["invalid_path"]);
                    return;
                }

                string zipPath = Path.Combine(installPath, "build.zip");

                Console.WriteLine($"\n{messages["downloading"]} {zipPath}\n"); //This is a problem here.

                try
                {
                    await DownloadFileAsync(selectedBuild.DownloadLink, zipPath);
                    Console.WriteLine(messages["download_success"]);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{messages["download_error"]} {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine(messages["invalid_choice"]);
            }

            Console.WriteLine(messages["press_key"]);
            Console.ReadKey();
        }

        private static async Task DownloadFileAsync(string url, string filePath)
        {
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();
                    long totalBytes = response.Content.Headers.ContentLength ?? 0;

                    using (var contentStream = await response.Content.ReadAsStreamAsync())
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        byte[] buffer = new byte[8192];
                        long totalRead = 0;
                        int bytesRead;

                        var stopwatch = Stopwatch.StartNew();

                        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await fileStream.WriteAsync(buffer, 0, bytesRead);
                            totalRead += bytesRead;

                            Console.Write($"\rProgression: {((double)totalRead / totalBytes) * 100:0.00}%");

                            if (stopwatch.Elapsed.TotalSeconds > 0)
                            {
                                double speed = (totalRead / (1024 * 1024)) / stopwatch.Elapsed.TotalSeconds;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write($" - Speed: {speed:0.00} Mo/s");
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }
                        stopwatch.Stop();

                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
