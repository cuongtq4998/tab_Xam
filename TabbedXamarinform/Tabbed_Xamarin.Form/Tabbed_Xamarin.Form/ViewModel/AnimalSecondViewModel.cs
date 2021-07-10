using System;
using System.Collections.ObjectModel;
using System.Linq;
using Tabbed_Xamarin.Form.DB;
using Tabbed_Xamarin.Form.Model;

namespace Tabbed_Xamarin.Form.ViewModel
{
    public class AnimalSecondViewModel
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

        public AnimalSecondViewModel(string continent)
        {

            Animals = new ObservableCollection<Animal>();

            DummyDB _context = new DummyDB();

            // Get only animals from that continent
            var animals = _context.Animals.Where(a => a.ContinentOrigin == continent).ToList();

            foreach (var animal in animals)
            {
                Animals.Add(animal);
            }
        }
    }
}
