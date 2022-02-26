using System.Text;
using MobileLibrary.Models;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MobileLibrary.Services;
using System.ComponentModel;
using System.Collections.Generic;

namespace MobileLibrary.ViewModels
{
    class MainPageViewModel
    {
        bool initialized = false;   // была ли начальная инициализация
        Book selectedBook;  
        private bool isBusy;    // идет ли загрузка с сервера

        public ObservableCollection<Book> Books { get; set; }
        LibraryService libraryService = new LibraryService();
        public event PropertyChangedEventHandler PropertyChanged;
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


        public async Task GetBooks()
        {
            if (initialized == true) return;
            IsBusy = true;
            IEnumerable<Book> books = await libraryService.Get();

            // очищаем список
            //Friends.Clear();
            while (Books.Any())
                Books.RemoveAt(Books.Count - 1);

            // добавляем загруженные данные
            foreach (Book b in books)
                Books.Add(b);
            IsBusy = false;
            initialized = true;
        }


        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
