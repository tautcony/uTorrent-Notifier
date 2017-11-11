using System.Collections.Generic;
using System.Linq;

namespace uTorrentNotifier
{
    public partial class WebUiapi
    {
        public void PauseAll()
        {
            _torrents.Current = ListTorrents();
            Send(Action.Pause, _torrents.Current.Select(f => new KeyValuePair<string, string>(Property.Hash, f.Hash)).ToArray());
        }

        public void StartAll()
        {
            _torrents.Current = ListTorrents();
            Send(Action.Start, _torrents.Current.Select(f => new KeyValuePair<string, string>(Property.Hash, f.Hash)).ToArray());
        }
    }
}
