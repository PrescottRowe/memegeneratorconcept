using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedDontUseMyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        
        public List<Meme> AllMemes { get; set; }
        public Page1()
        {
            InitializeComponent();
        }
        public class Meme
        {
            public string MemeId { get; set; }
            public string MemeName { get; set; }
            public string Url { get; set; }
        }
        public class Memes
        {
            public static IEnumerable<Meme> Get()
            {
                return new List<Meme>
                {
                  new Meme() {MemeId="1", MemeName="2 girls yell at cat", Url="girls_cat.png"},
                  new Meme() {MemeId="2", MemeName="confused guy", Url="confused_guy.png" },
                  new Meme() {MemeId="3", MemeName="distracted boyfriend", Url="distracted_boyfriend.jpg" },
                  new Meme() {MemeId="4", MemeName="dude", Url="dude.jpg" },
                  new Meme() {MemeId="5", MemeName="is this a pigeon", Url="is_this_a_pigeon.jpg" },
                  new Meme() {MemeId="6", MemeName="kevin wtf", Url="kevin_wtf.jpg"},
                  new Meme() {MemeId="7", MemeName="steve harvey", Url="steve_harvey.jpg"},
                  new Meme() {MemeId="8", MemeName="Surprised Pikachu", Url="Surprised_Pikachu.jpg" },
                  new Meme() {MemeId="9", MemeName="Toy story everywhere", Url="toy_story.jpg"}
                };
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AllMemes = new List<Meme>(Memes.Get());
            collectionViewListVertical.ItemsSource = AllMemes;
        }
        void CollectionViewListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSelectionData(e.PreviousSelection, e.CurrentSelection);
        }

        void UpdateSelectionData(IEnumerable<object> previousSelectedMeme, IEnumerable<object> currentSelectedMeme)
        {
            var selectedMeme = currentSelectedMeme.FirstOrDefault() as Meme;
            MainPage.GlobalVariables.selectedUrl = selectedMeme.Url;
            MainPage.GlobalVariables.selectedName = selectedMeme.MemeName;
            //Debug.WriteLine("Meme: " + selectedMeme.MemeName);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            
        }
    }
}