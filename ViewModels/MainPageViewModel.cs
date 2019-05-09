using EmojiInXaml.Helpers;
using EmojiInXaml.Models;

namespace EmojiInXaml.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            Emoji = new Emoji(0x1F914).ToString();
        }


        private string _emoji;
        public string Emoji
        {
            get { return _emoji; }
            set { SetProperty(ref _emoji, value); }
        }
    }
}
