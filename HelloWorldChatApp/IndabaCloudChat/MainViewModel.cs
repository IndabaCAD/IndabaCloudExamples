using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using AbService.Api.Common.Entities;
using AbService.Api.Public;

namespace IndabaCloudChat
{
    public class MainViewModel : PropertyChangedBase
    {
        #region Commands
        public ICommand LineSentCommand { get; set; }
        #endregion Commands

        private Manager man = new Manager("IndabaCloudExamples");
        private DateTime _lastCheck = DateTime.UtcNow.AddSeconds(-60000);

        public MainViewModel()
        {
            //  Get updated chat lines
            Task.Run(() =>
            {
                while (true)
                {
                    UpdateChatLines();
                    Thread.Sleep(1000);
                }
            });

            LineSentCommand = new RelayCommand(() =>
                {
                    man.InsertFeedEntry("chatlines","chat",Chatter == "" ? "anonymous" : Chatter,ChatLine);
                    ChatLine = "";
                });
        }

        private async void UpdateChatLines()
        {
            var chats = new List<AbFeedEntry>();
                await Task.Run(() =>
                    chats =
                        (List<AbFeedEntry>)
                            man.GetAllFeedEntriesSince("chatlines","chat", _lastCheck.AddSeconds(0), 100));

                Application.Current.Dispatcher.BeginInvoke((Action)(() => chats.ForEach(
                    r => ChatLines.Add(string.Format("{0} {1}: {2}", r.LastModified,r.Key, r.Value)))));

                _lastCheck = DateTime.UtcNow;
        }

       
        private ObservableCollection<string> _chatLines = new ObservableCollection<string>();
        public ObservableCollection<string> ChatLines
        {
            get { return _chatLines; }
            set
            {
                if (value != _chatLines)
                {
                    _chatLines = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        private string _chatter;
        public string Chatter
        {
            get { return _chatter; }
            set
            {
                if (value != _chatter)
                {
                    _chatter = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        private string _chatLine;
        public string ChatLine
        {
            get { return _chatLine; }
            set
            {
                if (value != _chatLine)
                {
                    _chatLine = value;
                    RaisePropertyChangedEvent();
                }
            }
        }
    }
}
