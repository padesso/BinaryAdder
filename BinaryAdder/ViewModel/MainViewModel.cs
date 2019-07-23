using BinaryAdder.Modules;
using GalaSoft.MvvmLight;
using System.Collections;

namespace BinaryAdder.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        BitArray numerator = new BitArray(4);
        BitArray denominator = new BitArray(4);
        BitArray result = new BitArray(5);

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            
        }

        public bool NumeratorOneBit
        {
            get
            {
                return numerator[3];
            }

            set
            {
                numerator[3] = value;
                result = Adder.Add(numerator, denominator);
                UpdateResultUI();
            }
        }

        public bool NumeratorTwoBit
        {
            get
            {
                return numerator[2];
            }

            set
            {
                numerator[2] = value;
                result = Adder.Add(numerator, denominator);
                UpdateResultUI();
            }
        }

        public bool NumeratorFourBit
        {
            get
            {
                return numerator[1];
            }

            set
            {
                numerator[1] = value;
                result = Adder.Add(numerator, denominator);
                UpdateResultUI();
            }
        }

        public bool NumeratorEightBit
        {
            get
            {
                return numerator[0];
            }

            set
            {
                numerator[0] = value;
                result = Adder.Add(numerator, denominator);
                UpdateResultUI();
            }
        }

        public bool DenominatorOneBit
        {
            get
            {
                return denominator[3];
            }

            set
            {
                denominator[3] = value;
                result = Adder.Add(numerator, denominator);
                UpdateResultUI();
            }
        }

        public bool DenominatorTwoBit
        {
            get
            {
                return denominator[2];
            }

            set
            {
                denominator[2] = value;
                result = Adder.Add(numerator, denominator);
                UpdateResultUI();
            }
        }

        public bool DenominatorFourBit
        {
            get
            {
                return denominator[1];
            }

            set
            {
                denominator[1] = value;
                result = Adder.Add(numerator, denominator);
                UpdateResultUI();
            }
        }

        public bool DenominatorEightBit
        {
            get
            {
                return denominator[0];
            }

            set
            {
                denominator[0] = value;
                result = Adder.Add(numerator, denominator);
                UpdateResultUI();
            }
        }

        public bool ResultOneBit
        {
            get
            {
                return result[4];
            }

            set
            {
                result[4] = value;
            }
        }

        public bool ResultTwoBit
        {
            get
            {
                return result[3];
            }

            set
            {
                result[3] = value;
            }
        }

        public bool ResultFourBit
        {
            get
            {
                return result[2];
            }

            set
            {
                result[2] = value;
            }
        }

        public bool ResultEightBit
        {
            get
            {
                return result[1];
            }

            set
            {
                result[1] = value;
            }
        }

        public bool ResultSixteenBit
        {
            get
            {
                return result[0];
            }

            set
            {
                result[0] = value;
            }
        }

        private void UpdateResultUI()
        {
            RaisePropertyChanged("ResultOneBit");
            RaisePropertyChanged("ResultTwoBit");
            RaisePropertyChanged("ResultFourBit");
            RaisePropertyChanged("ResultEightBit");
            RaisePropertyChanged("ResultSixteenBit");
        }
    }
}