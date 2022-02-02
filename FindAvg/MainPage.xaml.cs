using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FindAvg
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<double> numList;

        public MainPage()
        {
            this.InitializeComponent();
            this.numList = new ObservableCollection<double>();
            this.listOfNumbers.ItemsSource = numList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.numList.Add(double.Parse(this.field.Text));
                this.field.Text = "";
                this.field.PlaceholderText = "";
            }
            catch
            {
                this.field.Text = "";
                this.field.PlaceholderText = "INVALID INPUT!";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            this.resultBox.Text = numList.Average().ToString();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.resultBox.Text = numList.Sum().ToString();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.resultBox.Text = numList.Max().ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.resultBox.Text = numList.Min().ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.numList.Clear();
            this.resultBox.Text = "";
            this.field.PlaceholderText = "";
        }

        private void addSequenceOfNumbers(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] inputNumsText = field.Text.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                foreach(var stringNum in inputNumsText)
                {
                    numList.Add(double.Parse(stringNum));
                }
                this.field.Text = "";
                this.field.PlaceholderText = "";

            }
            catch
            {
                this.field.Text = "";
                this.field.PlaceholderText = "INVALID INPUT OR FOUND NAN , CHECK LIST";
            }  
        }
    }
}
