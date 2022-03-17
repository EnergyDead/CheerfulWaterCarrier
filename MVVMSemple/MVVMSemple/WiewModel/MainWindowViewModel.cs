using MVVMSemple.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSemple.WiewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Book[] _books;
        private Book _selectedBook;
        public Book[] Books { get; private set; }

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                OnPropertyChanged( nameof( SelectedBook ) );
            }
        }


        public MainWindowViewModel()
        {
            Books = Book.GetBooks();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged( string propertyName )
        {
            if ( PropertyChanged != null )
            {
                PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
            }
        }
    }
}
