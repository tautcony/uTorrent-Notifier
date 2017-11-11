using System;
using System.Collections.Generic;

namespace uTorrentNotifier
{
    public partial class WebUiapi
    {
        public delegate void DownloadFinishedEventHandler(List<TorrentFile> finished);
        public delegate void TorrentAddedEventHandler(List<TorrentFile> added);
        public delegate void WebUiErrorEventHandler(object sender, Exception e);
        public delegate void UpdatedListEventHandler(List<TorrentFile> torrents);

        public event DownloadFinishedEventHandler DownloadComplete;
        public event TorrentAddedEventHandler TorrentAdded;
        public event WebUiErrorEventHandler WebUiError;
        public event UpdatedListEventHandler UpdatedList;

        public class DownloadFinishedEventArgs : EventArgs
        {
        }

        public class TorrentAddedEventArgs : EventArgs
        {
        }

        public class LogOnErrorEventArgs : EventArgs
        {
        }

        public class UpdatedListEventArgs : EventArgs
        {
        }
    }
}