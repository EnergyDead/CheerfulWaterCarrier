using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSemple.Model
{
    public class Book : INotifyPropertyChanged
    {
        private string _author;
        private string _title;

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged( nameof( Author ) );
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged( nameof( Title ) );
            }
        }

        public static Book[] GetBooks()
        {
            var result = new[]
            {
                new Book { Author = "Пушкин", Title="Евгений Онегин"},
                new Book { Author = "Толстой", Title="Война и мир"},
                new Book { Author = "Пушкин1", Title="Евгений Онегин1"},
                new Book { Author = "Толстой1", Title="Война и мир1"}
            };

            return result;
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
