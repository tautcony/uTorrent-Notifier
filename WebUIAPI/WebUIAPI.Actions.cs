using System.Linq;

namespace uTorrentNotifier.WebUIAPI
{
    public partial class WebUiapi
    {
        public void PauseAll()
        {
            _torrents.Current = ListTorrents();
            Send(Action.Pause, _torrents.Current.Select(f => (Property.Hash, f.Hash)));
        }

        public void StartAll()
        {
            _torrents.Current = ListTorrents();
            Send(Action.Start, _torrents.Current.Select(f => (Property.Hash, f.Hash)));
        }
    }
}
