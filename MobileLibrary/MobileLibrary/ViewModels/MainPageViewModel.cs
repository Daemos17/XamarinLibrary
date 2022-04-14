using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MobileLibrary.Services;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Input;
using System;

namespace MobileLibrary.ViewModels
{
    class MainPageViewModel 
    {


        bool initialized = false;   // была ли начальная инициализация
        Book selectedBook;  // выбранный друг
        private bool isBusy;    // идет ли загрузка с сервера

        public ObservableCollection<Book> Books { get; set; }
        apiBookService bookService = new apiBookService();
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreateFriendCommand { protected set; get; }
        public ICommand DeleteFriendCommand { protected set; get; }
        public ICommand SaveFriendCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }

        public INavigation Navigation { get; set; }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
                OnPropertyChanged("IsLoaded");
            }
        }
        public bool IsLoaded
        {
            get { return !isBusy; }
        }

        public MainPageViewModel()
        {
            Books = new ObservableCollection<Book>();
            IsBusy = false;

            BackCommand = new Command(Back);
        }

        public Book SelectedFriend
        {
            get { return selectedBook; }
            set
            {
                if (selectedBook != value)
                {

                    selectedBook = null;
                    OnPropertyChanged("SelectedFriend");

                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }


        private void Back()
        {
            Navigation.PopAsync();
        }

        public async Task GetBooks()
        {
            if (initialized == true) return;
            IsBusy = true;
            IEnumerable<Book> books = await bookService.Get();
           
            // очищаем список
            //Friends.Clear();
            while (Books.Any())
                Books.RemoveAt(Books.Count - 1);

            // добавляем загруженные данные
            foreach (Book f in books)
                Books.Add(f);
            IsBusy = false;
            initialized = true;
        }




    }
}

