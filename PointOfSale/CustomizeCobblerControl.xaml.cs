using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }
        void OnRadioButtonChanged(object sender, RoutedEventArgs e)
        {
            if(DataContext is Cobbler cobbler)
            {
                if(cobbler.Fruit == FruitFilling.Blueberry)
                {
                    BlueberryFillingButton.IsChecked = true;
                }
                 else if (cobbler.Fruit == FruitFilling.Cherry)
                {
                    CherryFillingButton.IsChecked = true;
                }
                else 
                {
                    PeachFillingButton.IsChecked = true;
                }
            }
        }
        void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Cobbler cobbler)
            {
                if (sender is RadioButton r)
                {

                    if (r.Tag.Equals("Blueberry"))
                    {
                        cobbler.Fruit=FruitFilling.Blueberry;
                    }
                    else if (r.Tag.Equals("Cherry"))
                    {
                        cobbler.Fruit=FruitFilling.Cherry;
                    }
                    else 
                    {
                        cobbler.Fruit = FruitFilling.Peach;
                    }
                }
            }
        }
    }
}
