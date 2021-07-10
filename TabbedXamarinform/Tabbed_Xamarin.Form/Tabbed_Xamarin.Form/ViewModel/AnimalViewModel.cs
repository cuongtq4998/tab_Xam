using System;
using System.Collections.ObjectModel;
using Tabbed_Xamarin.Form.DB;
using Tabbed_Xamarin.Form.Model;

namespace Tabbed_Xamarin.Form.ViewModel
{
    public class AnimalViewModel
    {
        private ObservableCollection<Animal> animals;
        public ObservableCollection<Animal> Animals
        {
            get { return animals; }
            set
            {
                animals = value;
            }
        }

        public AnimalViewModel()
        {

            Animals = new ObservableCollection<Animal>();

            DummyDB _context = new DummyDB();

            foreach (var animal in _context.Animals)
            {
                Animals.Add(animal);
            }
        }
    }
}
