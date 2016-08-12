namespace XamarinFormsBindablePicker.Model {
    using System;

    public class Person : ObservableObject {

        String _country;
        String _firstName;
        String _lastName;
        String _nextVacationSpot;
        Sex _sex;
        String _state;

        public String Country {
            get { return _country; }
            set {
                _country = value;
                RaisePropertyChanged();
            }
        }

        public String FirstName {
            get { return _firstName; }
            set {
                _firstName = value;
                RaisePropertyChanged();
            }
        }

        public String LastName {
            get { return _lastName; }
            set {
                _lastName = value;
                RaisePropertyChanged();
            }
        }

        public String NextVacationSpot {
            get { return _nextVacationSpot; }
            set {
                _nextVacationSpot = value;
                RaisePropertyChanged();
            }
        }

        public Sex Sex {
            get { return _sex; }
            set {
                _sex = value;
                RaisePropertyChanged();
            }
        }

        public String State {
            get { return _state; }
            set {
                _state = value;
                RaisePropertyChanged();
            }
        }

        public Person() {
        }

    }
}
