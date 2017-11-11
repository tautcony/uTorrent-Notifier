using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace uTorrentNotifier
{
    public class TorrentFile
    {
        public static TorrentFile ConvertStringArray(string[] file)
        {
            var torrentFile = new TorrentFile
            {
                Hash              = file[0],
                Status            = int.Parse(file[1], CultureInfo.CurrentCulture),
                Name              = file[2],
                Size              = double.Parse(file[3], CultureInfo.CurrentCulture),
                PercentProgress   = int.Parse(file[4], CultureInfo.CurrentCulture),
                Downloaded        = double.Parse(file[5], CultureInfo.CurrentCulture),
                Uploaded          = double.Parse(file[6], CultureInfo.CurrentCulture),
                Ratio             = int.Parse(file[7], CultureInfo.CurrentCulture),
                UploadSpeed       = int.Parse(file[8], CultureInfo.CurrentCulture),
                DownloadSpeed     = int.Parse(file[9], CultureInfo.CurrentCulture),
                Eta               = int.Parse(file[10], CultureInfo.CurrentCulture),
                Label             = file[11],
                PeersConnected    = int.Parse(file[12], CultureInfo.CurrentCulture),
                PeersInSwarm      = int.Parse(file[13], CultureInfo.CurrentCulture),
                SeedsConnected    = int.Parse(file[14], CultureInfo.CurrentCulture),
                SeedsInSwarm      = int.Parse(file[15], CultureInfo.CurrentCulture),
                Availability      = double.Parse(file[16], CultureInfo.CurrentCulture),
                TorrentQueueOrder = int.Parse(file[17], CultureInfo.CurrentCulture),
                Remaining         = double.Parse(file[18], CultureInfo.CurrentCulture),
                TorrentSource     = "",
                RssFeed           = "",
                StatusString      = ""
            };


            if (file.Length > 19)
            {
                torrentFile.TorrentSource = file[19];
                torrentFile.RssFeed = file[20];
                torrentFile.StatusString = file[21];
            }

            return torrentFile;
        }

        public string Hash { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }

        public int Status { get; set; }

        public double Size { get; set; }

        public int PercentProgress { get; set; }

        public double Downloaded { get; set; }

        public double Uploaded { get; set; }

        public int Ratio { get; set; }

        public int UploadSpeed { get; set; }

        public int DownloadSpeed { get; set; }

        public int Eta { get; set; }

        public int PeersConnected { get; set; }

        public int PeersInSwarm { get; set; }

        public int SeedsConnected { get; set; }

        public int SeedsInSwarm { get; set; }

        public double Availability { get; set; }

        public int TorrentQueueOrder { get; set; }

        public double Remaining { get; set; }

        public string TorrentSource { get; set; }

        public string RssFeed { get; set; }

        public string StatusString { get; set; }
    }
}
